// Copyright 2026 Google LLC
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

namespace Google.Cloud.Dialogflow.Cx.V3
{
    /// <summary>Settings for <see cref="PlaybooksClient"/> instances.</summary>
    public sealed partial class PlaybooksSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="PlaybooksSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="PlaybooksSettings"/>.</returns>
        public static PlaybooksSettings GetDefault() => new PlaybooksSettings();

        /// <summary>Constructs a new <see cref="PlaybooksSettings"/> object with default settings.</summary>
        public PlaybooksSettings()
        {
        }

        private PlaybooksSettings(PlaybooksSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreatePlaybookSettings = existing.CreatePlaybookSettings;
            DeletePlaybookSettings = existing.DeletePlaybookSettings;
            ListPlaybooksSettings = existing.ListPlaybooksSettings;
            GetPlaybookSettings = existing.GetPlaybookSettings;
            ExportPlaybookSettings = existing.ExportPlaybookSettings;
            ExportPlaybookOperationsSettings = existing.ExportPlaybookOperationsSettings.Clone();
            ImportPlaybookSettings = existing.ImportPlaybookSettings;
            ImportPlaybookOperationsSettings = existing.ImportPlaybookOperationsSettings.Clone();
            UpdatePlaybookSettings = existing.UpdatePlaybookSettings;
            CreatePlaybookVersionSettings = existing.CreatePlaybookVersionSettings;
            GetPlaybookVersionSettings = existing.GetPlaybookVersionSettings;
            RestorePlaybookVersionSettings = existing.RestorePlaybookVersionSettings;
            ListPlaybookVersionsSettings = existing.ListPlaybookVersionsSettings;
            DeletePlaybookVersionSettings = existing.DeletePlaybookVersionSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(PlaybooksSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PlaybooksClient.CreatePlaybook</c> and <c>PlaybooksClient.CreatePlaybookAsync</c>.
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
        public gaxgrpc::CallSettings CreatePlaybookSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PlaybooksClient.DeletePlaybook</c> and <c>PlaybooksClient.DeletePlaybookAsync</c>.
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
        public gaxgrpc::CallSettings DeletePlaybookSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PlaybooksClient.ListPlaybooks</c> and <c>PlaybooksClient.ListPlaybooksAsync</c>.
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
        public gaxgrpc::CallSettings ListPlaybooksSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>PlaybooksClient.GetPlaybook</c>
        ///  and <c>PlaybooksClient.GetPlaybookAsync</c>.
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
        public gaxgrpc::CallSettings GetPlaybookSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PlaybooksClient.ExportPlaybook</c> and <c>PlaybooksClient.ExportPlaybookAsync</c>.
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
        public gaxgrpc::CallSettings ExportPlaybookSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>PlaybooksClient.ExportPlaybook</c> and
        /// <c>PlaybooksClient.ExportPlaybookAsync</c>.
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
        public lro::OperationsSettings ExportPlaybookOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PlaybooksClient.ImportPlaybook</c> and <c>PlaybooksClient.ImportPlaybookAsync</c>.
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
        public gaxgrpc::CallSettings ImportPlaybookSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>PlaybooksClient.ImportPlaybook</c> and
        /// <c>PlaybooksClient.ImportPlaybookAsync</c>.
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
        public lro::OperationsSettings ImportPlaybookOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PlaybooksClient.UpdatePlaybook</c> and <c>PlaybooksClient.UpdatePlaybookAsync</c>.
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
        public gaxgrpc::CallSettings UpdatePlaybookSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PlaybooksClient.CreatePlaybookVersion</c> and <c>PlaybooksClient.CreatePlaybookVersionAsync</c>.
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
        public gaxgrpc::CallSettings CreatePlaybookVersionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PlaybooksClient.GetPlaybookVersion</c> and <c>PlaybooksClient.GetPlaybookVersionAsync</c>.
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
        public gaxgrpc::CallSettings GetPlaybookVersionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PlaybooksClient.RestorePlaybookVersion</c> and <c>PlaybooksClient.RestorePlaybookVersionAsync</c>.
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
        public gaxgrpc::CallSettings RestorePlaybookVersionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PlaybooksClient.ListPlaybookVersions</c> and <c>PlaybooksClient.ListPlaybookVersionsAsync</c>.
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
        public gaxgrpc::CallSettings ListPlaybookVersionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PlaybooksClient.DeletePlaybookVersion</c> and <c>PlaybooksClient.DeletePlaybookVersionAsync</c>.
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
        public gaxgrpc::CallSettings DeletePlaybookVersionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="PlaybooksSettings"/> object.</returns>
        public PlaybooksSettings Clone() => new PlaybooksSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="PlaybooksClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class PlaybooksClientBuilder : gaxgrpc::ClientBuilderBase<PlaybooksClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public PlaybooksSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public PlaybooksClientBuilder() : base(PlaybooksClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref PlaybooksClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<PlaybooksClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override PlaybooksClient Build()
        {
            PlaybooksClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<PlaybooksClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<PlaybooksClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private PlaybooksClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return PlaybooksClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<PlaybooksClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return PlaybooksClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => PlaybooksClient.ChannelPool;
    }

    /// <summary>Playbooks client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing [Playbooks][google.cloud.dialogflow.cx.v3.Playbook].
    /// </remarks>
    public abstract partial class PlaybooksClient
    {
        /// <summary>
        /// The default endpoint for the Playbooks service, which is a host of "dialogflow.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dialogflow.googleapis.com:443";

        /// <summary>The default Playbooks scopes.</summary>
        /// <remarks>
        /// The default Playbooks scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Playbooks.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="PlaybooksClient"/> using the default credentials, endpoint and settings.
        /// To specify custom credentials or other settings, use <see cref="PlaybooksClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="PlaybooksClient"/>.</returns>
        public static stt::Task<PlaybooksClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new PlaybooksClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="PlaybooksClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="PlaybooksClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="PlaybooksClient"/>.</returns>
        public static PlaybooksClient Create() => new PlaybooksClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="PlaybooksClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="PlaybooksSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="PlaybooksClient"/>.</returns>
        internal static PlaybooksClient Create(grpccore::CallInvoker callInvoker, PlaybooksSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Playbooks.PlaybooksClient grpcClient = new Playbooks.PlaybooksClient(callInvoker);
            return new PlaybooksClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Playbooks client</summary>
        public virtual Playbooks.PlaybooksClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a playbook in a specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Playbook CreatePlaybook(CreatePlaybookRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a playbook in a specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Playbook> CreatePlaybookAsync(CreatePlaybookRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a playbook in a specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Playbook> CreatePlaybookAsync(CreatePlaybookRequest request, st::CancellationToken cancellationToken) =>
            CreatePlaybookAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a playbook in a specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a playbook for.
        /// Format: `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`.
        /// </param>
        /// <param name="playbook">
        /// Required. The playbook to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Playbook CreatePlaybook(string parent, Playbook playbook, gaxgrpc::CallSettings callSettings = null) =>
            CreatePlaybook(new CreatePlaybookRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Playbook = gax::GaxPreconditions.CheckNotNull(playbook, nameof(playbook)),
            }, callSettings);

        /// <summary>
        /// Creates a playbook in a specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a playbook for.
        /// Format: `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`.
        /// </param>
        /// <param name="playbook">
        /// Required. The playbook to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Playbook> CreatePlaybookAsync(string parent, Playbook playbook, gaxgrpc::CallSettings callSettings = null) =>
            CreatePlaybookAsync(new CreatePlaybookRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Playbook = gax::GaxPreconditions.CheckNotNull(playbook, nameof(playbook)),
            }, callSettings);

        /// <summary>
        /// Creates a playbook in a specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a playbook for.
        /// Format: `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`.
        /// </param>
        /// <param name="playbook">
        /// Required. The playbook to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Playbook> CreatePlaybookAsync(string parent, Playbook playbook, st::CancellationToken cancellationToken) =>
            CreatePlaybookAsync(parent, playbook, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a playbook in a specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a playbook for.
        /// Format: `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`.
        /// </param>
        /// <param name="playbook">
        /// Required. The playbook to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Playbook CreatePlaybook(AgentName parent, Playbook playbook, gaxgrpc::CallSettings callSettings = null) =>
            CreatePlaybook(new CreatePlaybookRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Playbook = gax::GaxPreconditions.CheckNotNull(playbook, nameof(playbook)),
            }, callSettings);

        /// <summary>
        /// Creates a playbook in a specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a playbook for.
        /// Format: `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`.
        /// </param>
        /// <param name="playbook">
        /// Required. The playbook to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Playbook> CreatePlaybookAsync(AgentName parent, Playbook playbook, gaxgrpc::CallSettings callSettings = null) =>
            CreatePlaybookAsync(new CreatePlaybookRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Playbook = gax::GaxPreconditions.CheckNotNull(playbook, nameof(playbook)),
            }, callSettings);

        /// <summary>
        /// Creates a playbook in a specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a playbook for.
        /// Format: `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`.
        /// </param>
        /// <param name="playbook">
        /// Required. The playbook to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Playbook> CreatePlaybookAsync(AgentName parent, Playbook playbook, st::CancellationToken cancellationToken) =>
            CreatePlaybookAsync(parent, playbook, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a specified playbook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePlaybook(DeletePlaybookRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a specified playbook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePlaybookAsync(DeletePlaybookRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a specified playbook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePlaybookAsync(DeletePlaybookRequest request, st::CancellationToken cancellationToken) =>
            DeletePlaybookAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a specified playbook.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the playbook to delete.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePlaybook(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePlaybook(new DeletePlaybookRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specified playbook.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the playbook to delete.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePlaybookAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePlaybookAsync(new DeletePlaybookRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specified playbook.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the playbook to delete.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePlaybookAsync(string name, st::CancellationToken cancellationToken) =>
            DeletePlaybookAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a specified playbook.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the playbook to delete.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePlaybook(PlaybookName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePlaybook(new DeletePlaybookRequest
            {
                PlaybookName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specified playbook.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the playbook to delete.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePlaybookAsync(PlaybookName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePlaybookAsync(new DeletePlaybookRequest
            {
                PlaybookName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specified playbook.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the playbook to delete.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePlaybookAsync(PlaybookName name, st::CancellationToken cancellationToken) =>
            DeletePlaybookAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a list of playbooks in the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Playbook"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPlaybooksResponse, Playbook> ListPlaybooks(ListPlaybooksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of playbooks in the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Playbook"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPlaybooksResponse, Playbook> ListPlaybooksAsync(ListPlaybooksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of playbooks in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list playbooks from.
        /// Format: `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`.
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
        /// <returns>A pageable sequence of <see cref="Playbook"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPlaybooksResponse, Playbook> ListPlaybooks(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPlaybooksRequest request = new ListPlaybooksRequest
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
            return ListPlaybooks(request, callSettings);
        }

        /// <summary>
        /// Returns a list of playbooks in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list playbooks from.
        /// Format: `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Playbook"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPlaybooksResponse, Playbook> ListPlaybooksAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPlaybooksRequest request = new ListPlaybooksRequest
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
            return ListPlaybooksAsync(request, callSettings);
        }

        /// <summary>
        /// Returns a list of playbooks in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list playbooks from.
        /// Format: `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`.
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
        /// <returns>A pageable sequence of <see cref="Playbook"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPlaybooksResponse, Playbook> ListPlaybooks(AgentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPlaybooksRequest request = new ListPlaybooksRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListPlaybooks(request, callSettings);
        }

        /// <summary>
        /// Returns a list of playbooks in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list playbooks from.
        /// Format: `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Playbook"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPlaybooksResponse, Playbook> ListPlaybooksAsync(AgentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPlaybooksRequest request = new ListPlaybooksRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListPlaybooksAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified Playbook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Playbook GetPlaybook(GetPlaybookRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified Playbook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Playbook> GetPlaybookAsync(GetPlaybookRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified Playbook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Playbook> GetPlaybookAsync(GetPlaybookRequest request, st::CancellationToken cancellationToken) =>
            GetPlaybookAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified Playbook.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the playbook.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Playbook GetPlaybook(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPlaybook(new GetPlaybookRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified Playbook.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the playbook.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Playbook> GetPlaybookAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPlaybookAsync(new GetPlaybookRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified Playbook.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the playbook.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Playbook> GetPlaybookAsync(string name, st::CancellationToken cancellationToken) =>
            GetPlaybookAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified Playbook.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the playbook.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Playbook GetPlaybook(PlaybookName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPlaybook(new GetPlaybookRequest
            {
                PlaybookName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified Playbook.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the playbook.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Playbook> GetPlaybookAsync(PlaybookName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPlaybookAsync(new GetPlaybookRequest
            {
                PlaybookName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified Playbook.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the playbook.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Playbook> GetPlaybookAsync(PlaybookName name, st::CancellationToken cancellationToken) =>
            GetPlaybookAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports the specified playbook to a binary file.
        /// 
        /// Note that resources (e.g. examples, tools) that the playbook
        /// references will also be exported.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportPlaybookResponse, wkt::Struct> ExportPlaybook(ExportPlaybookRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports the specified playbook to a binary file.
        /// 
        /// Note that resources (e.g. examples, tools) that the playbook
        /// references will also be exported.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportPlaybookResponse, wkt::Struct>> ExportPlaybookAsync(ExportPlaybookRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports the specified playbook to a binary file.
        /// 
        /// Note that resources (e.g. examples, tools) that the playbook
        /// references will also be exported.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportPlaybookResponse, wkt::Struct>> ExportPlaybookAsync(ExportPlaybookRequest request, st::CancellationToken cancellationToken) =>
            ExportPlaybookAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ExportPlaybook</c>.</summary>
        public virtual lro::OperationsClient ExportPlaybookOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ExportPlaybook</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ExportPlaybookResponse, wkt::Struct> PollOnceExportPlaybook(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportPlaybookResponse, wkt::Struct>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportPlaybookOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExportPlaybook</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ExportPlaybookResponse, wkt::Struct>> PollOnceExportPlaybookAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportPlaybookResponse, wkt::Struct>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportPlaybookOperationsClient, callSettings);

        /// <summary>
        /// Imports the specified playbook to the specified agent from a binary file.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportPlaybookResponse, wkt::Struct> ImportPlaybook(ImportPlaybookRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports the specified playbook to the specified agent from a binary file.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportPlaybookResponse, wkt::Struct>> ImportPlaybookAsync(ImportPlaybookRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports the specified playbook to the specified agent from a binary file.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportPlaybookResponse, wkt::Struct>> ImportPlaybookAsync(ImportPlaybookRequest request, st::CancellationToken cancellationToken) =>
            ImportPlaybookAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ImportPlaybook</c>.</summary>
        public virtual lro::OperationsClient ImportPlaybookOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ImportPlaybook</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ImportPlaybookResponse, wkt::Struct> PollOnceImportPlaybook(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportPlaybookResponse, wkt::Struct>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportPlaybookOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ImportPlaybook</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ImportPlaybookResponse, wkt::Struct>> PollOnceImportPlaybookAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportPlaybookResponse, wkt::Struct>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportPlaybookOperationsClient, callSettings);

        /// <summary>
        /// Updates the specified Playbook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Playbook UpdatePlaybook(UpdatePlaybookRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified Playbook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Playbook> UpdatePlaybookAsync(UpdatePlaybookRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified Playbook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Playbook> UpdatePlaybookAsync(UpdatePlaybookRequest request, st::CancellationToken cancellationToken) =>
            UpdatePlaybookAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified Playbook.
        /// </summary>
        /// <param name="playbook">
        /// Required. The playbook to update.
        /// </param>
        /// <param name="updateMask">
        /// The mask to control which fields get updated. If the mask is not present,
        /// all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Playbook UpdatePlaybook(Playbook playbook, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePlaybook(new UpdatePlaybookRequest
            {
                Playbook = gax::GaxPreconditions.CheckNotNull(playbook, nameof(playbook)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specified Playbook.
        /// </summary>
        /// <param name="playbook">
        /// Required. The playbook to update.
        /// </param>
        /// <param name="updateMask">
        /// The mask to control which fields get updated. If the mask is not present,
        /// all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Playbook> UpdatePlaybookAsync(Playbook playbook, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePlaybookAsync(new UpdatePlaybookRequest
            {
                Playbook = gax::GaxPreconditions.CheckNotNull(playbook, nameof(playbook)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specified Playbook.
        /// </summary>
        /// <param name="playbook">
        /// Required. The playbook to update.
        /// </param>
        /// <param name="updateMask">
        /// The mask to control which fields get updated. If the mask is not present,
        /// all fields will be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Playbook> UpdatePlaybookAsync(Playbook playbook, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdatePlaybookAsync(playbook, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a version for the specified Playbook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PlaybookVersion CreatePlaybookVersion(CreatePlaybookVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a version for the specified Playbook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PlaybookVersion> CreatePlaybookVersionAsync(CreatePlaybookVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a version for the specified Playbook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PlaybookVersion> CreatePlaybookVersionAsync(CreatePlaybookVersionRequest request, st::CancellationToken cancellationToken) =>
            CreatePlaybookVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a version for the specified Playbook.
        /// </summary>
        /// <param name="parent">
        /// Required. The playbook to create a version for.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;`.
        /// </param>
        /// <param name="playbookVersion">
        /// Required. The playbook version to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PlaybookVersion CreatePlaybookVersion(string parent, PlaybookVersion playbookVersion, gaxgrpc::CallSettings callSettings = null) =>
            CreatePlaybookVersion(new CreatePlaybookVersionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PlaybookVersion = gax::GaxPreconditions.CheckNotNull(playbookVersion, nameof(playbookVersion)),
            }, callSettings);

        /// <summary>
        /// Creates a version for the specified Playbook.
        /// </summary>
        /// <param name="parent">
        /// Required. The playbook to create a version for.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;`.
        /// </param>
        /// <param name="playbookVersion">
        /// Required. The playbook version to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PlaybookVersion> CreatePlaybookVersionAsync(string parent, PlaybookVersion playbookVersion, gaxgrpc::CallSettings callSettings = null) =>
            CreatePlaybookVersionAsync(new CreatePlaybookVersionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PlaybookVersion = gax::GaxPreconditions.CheckNotNull(playbookVersion, nameof(playbookVersion)),
            }, callSettings);

        /// <summary>
        /// Creates a version for the specified Playbook.
        /// </summary>
        /// <param name="parent">
        /// Required. The playbook to create a version for.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;`.
        /// </param>
        /// <param name="playbookVersion">
        /// Required. The playbook version to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PlaybookVersion> CreatePlaybookVersionAsync(string parent, PlaybookVersion playbookVersion, st::CancellationToken cancellationToken) =>
            CreatePlaybookVersionAsync(parent, playbookVersion, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a version for the specified Playbook.
        /// </summary>
        /// <param name="parent">
        /// Required. The playbook to create a version for.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;`.
        /// </param>
        /// <param name="playbookVersion">
        /// Required. The playbook version to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PlaybookVersion CreatePlaybookVersion(PlaybookName parent, PlaybookVersion playbookVersion, gaxgrpc::CallSettings callSettings = null) =>
            CreatePlaybookVersion(new CreatePlaybookVersionRequest
            {
                ParentAsPlaybookName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PlaybookVersion = gax::GaxPreconditions.CheckNotNull(playbookVersion, nameof(playbookVersion)),
            }, callSettings);

        /// <summary>
        /// Creates a version for the specified Playbook.
        /// </summary>
        /// <param name="parent">
        /// Required. The playbook to create a version for.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;`.
        /// </param>
        /// <param name="playbookVersion">
        /// Required. The playbook version to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PlaybookVersion> CreatePlaybookVersionAsync(PlaybookName parent, PlaybookVersion playbookVersion, gaxgrpc::CallSettings callSettings = null) =>
            CreatePlaybookVersionAsync(new CreatePlaybookVersionRequest
            {
                ParentAsPlaybookName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PlaybookVersion = gax::GaxPreconditions.CheckNotNull(playbookVersion, nameof(playbookVersion)),
            }, callSettings);

        /// <summary>
        /// Creates a version for the specified Playbook.
        /// </summary>
        /// <param name="parent">
        /// Required. The playbook to create a version for.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;`.
        /// </param>
        /// <param name="playbookVersion">
        /// Required. The playbook version to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PlaybookVersion> CreatePlaybookVersionAsync(PlaybookName parent, PlaybookVersion playbookVersion, st::CancellationToken cancellationToken) =>
            CreatePlaybookVersionAsync(parent, playbookVersion, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified version of the Playbook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PlaybookVersion GetPlaybookVersion(GetPlaybookVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified version of the Playbook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PlaybookVersion> GetPlaybookVersionAsync(GetPlaybookVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified version of the Playbook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PlaybookVersion> GetPlaybookVersionAsync(GetPlaybookVersionRequest request, st::CancellationToken cancellationToken) =>
            GetPlaybookVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified version of the Playbook.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the playbook version.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;/versions/&lt;VersionID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PlaybookVersion GetPlaybookVersion(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPlaybookVersion(new GetPlaybookVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified version of the Playbook.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the playbook version.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;/versions/&lt;VersionID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PlaybookVersion> GetPlaybookVersionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPlaybookVersionAsync(new GetPlaybookVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified version of the Playbook.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the playbook version.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;/versions/&lt;VersionID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PlaybookVersion> GetPlaybookVersionAsync(string name, st::CancellationToken cancellationToken) =>
            GetPlaybookVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified version of the Playbook.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the playbook version.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;/versions/&lt;VersionID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PlaybookVersion GetPlaybookVersion(PlaybookVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPlaybookVersion(new GetPlaybookVersionRequest
            {
                PlaybookVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified version of the Playbook.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the playbook version.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;/versions/&lt;VersionID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PlaybookVersion> GetPlaybookVersionAsync(PlaybookVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPlaybookVersionAsync(new GetPlaybookVersionRequest
            {
                PlaybookVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified version of the Playbook.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the playbook version.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;/versions/&lt;VersionID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PlaybookVersion> GetPlaybookVersionAsync(PlaybookVersionName name, st::CancellationToken cancellationToken) =>
            GetPlaybookVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified version of the Playbook and stores it as the
        /// current playbook draft, returning the playbook with resources updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RestorePlaybookVersionResponse RestorePlaybookVersion(RestorePlaybookVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified version of the Playbook and stores it as the
        /// current playbook draft, returning the playbook with resources updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RestorePlaybookVersionResponse> RestorePlaybookVersionAsync(RestorePlaybookVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified version of the Playbook and stores it as the
        /// current playbook draft, returning the playbook with resources updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RestorePlaybookVersionResponse> RestorePlaybookVersionAsync(RestorePlaybookVersionRequest request, st::CancellationToken cancellationToken) =>
            RestorePlaybookVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified version of the Playbook and stores it as the
        /// current playbook draft, returning the playbook with resources updated.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the playbook version.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;/versions/&lt;VersionID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RestorePlaybookVersionResponse RestorePlaybookVersion(string name, gaxgrpc::CallSettings callSettings = null) =>
            RestorePlaybookVersion(new RestorePlaybookVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified version of the Playbook and stores it as the
        /// current playbook draft, returning the playbook with resources updated.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the playbook version.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;/versions/&lt;VersionID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RestorePlaybookVersionResponse> RestorePlaybookVersionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            RestorePlaybookVersionAsync(new RestorePlaybookVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified version of the Playbook and stores it as the
        /// current playbook draft, returning the playbook with resources updated.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the playbook version.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;/versions/&lt;VersionID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RestorePlaybookVersionResponse> RestorePlaybookVersionAsync(string name, st::CancellationToken cancellationToken) =>
            RestorePlaybookVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified version of the Playbook and stores it as the
        /// current playbook draft, returning the playbook with resources updated.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the playbook version.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;/versions/&lt;VersionID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RestorePlaybookVersionResponse RestorePlaybookVersion(PlaybookVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            RestorePlaybookVersion(new RestorePlaybookVersionRequest
            {
                PlaybookVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified version of the Playbook and stores it as the
        /// current playbook draft, returning the playbook with resources updated.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the playbook version.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;/versions/&lt;VersionID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RestorePlaybookVersionResponse> RestorePlaybookVersionAsync(PlaybookVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            RestorePlaybookVersionAsync(new RestorePlaybookVersionRequest
            {
                PlaybookVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified version of the Playbook and stores it as the
        /// current playbook draft, returning the playbook with resources updated.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the playbook version.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;/versions/&lt;VersionID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RestorePlaybookVersionResponse> RestorePlaybookVersionAsync(PlaybookVersionName name, st::CancellationToken cancellationToken) =>
            RestorePlaybookVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists versions for the specified Playbook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PlaybookVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPlaybookVersionsResponse, PlaybookVersion> ListPlaybookVersions(ListPlaybookVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists versions for the specified Playbook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PlaybookVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPlaybookVersionsResponse, PlaybookVersion> ListPlaybookVersionsAsync(ListPlaybookVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists versions for the specified Playbook.
        /// </summary>
        /// <param name="parent">
        /// Required. The playbook to list versions for.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;`.
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
        /// <returns>A pageable sequence of <see cref="PlaybookVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPlaybookVersionsResponse, PlaybookVersion> ListPlaybookVersions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPlaybookVersionsRequest request = new ListPlaybookVersionsRequest
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
            return ListPlaybookVersions(request, callSettings);
        }

        /// <summary>
        /// Lists versions for the specified Playbook.
        /// </summary>
        /// <param name="parent">
        /// Required. The playbook to list versions for.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="PlaybookVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPlaybookVersionsResponse, PlaybookVersion> ListPlaybookVersionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPlaybookVersionsRequest request = new ListPlaybookVersionsRequest
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
            return ListPlaybookVersionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists versions for the specified Playbook.
        /// </summary>
        /// <param name="parent">
        /// Required. The playbook to list versions for.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;`.
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
        /// <returns>A pageable sequence of <see cref="PlaybookVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPlaybookVersionsResponse, PlaybookVersion> ListPlaybookVersions(PlaybookName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPlaybookVersionsRequest request = new ListPlaybookVersionsRequest
            {
                ParentAsPlaybookName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListPlaybookVersions(request, callSettings);
        }

        /// <summary>
        /// Lists versions for the specified Playbook.
        /// </summary>
        /// <param name="parent">
        /// Required. The playbook to list versions for.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="PlaybookVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPlaybookVersionsResponse, PlaybookVersion> ListPlaybookVersionsAsync(PlaybookName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPlaybookVersionsRequest request = new ListPlaybookVersionsRequest
            {
                ParentAsPlaybookName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListPlaybookVersionsAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified version of the Playbook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePlaybookVersion(DeletePlaybookVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified version of the Playbook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePlaybookVersionAsync(DeletePlaybookVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified version of the Playbook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePlaybookVersionAsync(DeletePlaybookVersionRequest request, st::CancellationToken cancellationToken) =>
            DeletePlaybookVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified version of the Playbook.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the playbook version to delete.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;/versions/&lt;VersionID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePlaybookVersion(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePlaybookVersion(new DeletePlaybookVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified version of the Playbook.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the playbook version to delete.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;/versions/&lt;VersionID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePlaybookVersionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePlaybookVersionAsync(new DeletePlaybookVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified version of the Playbook.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the playbook version to delete.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;/versions/&lt;VersionID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePlaybookVersionAsync(string name, st::CancellationToken cancellationToken) =>
            DeletePlaybookVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified version of the Playbook.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the playbook version to delete.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;/versions/&lt;VersionID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePlaybookVersion(PlaybookVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePlaybookVersion(new DeletePlaybookVersionRequest
            {
                PlaybookVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified version of the Playbook.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the playbook version to delete.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;/versions/&lt;VersionID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePlaybookVersionAsync(PlaybookVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePlaybookVersionAsync(new DeletePlaybookVersionRequest
            {
                PlaybookVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified version of the Playbook.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the playbook version to delete.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;/versions/&lt;VersionID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePlaybookVersionAsync(PlaybookVersionName name, st::CancellationToken cancellationToken) =>
            DeletePlaybookVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Playbooks client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing [Playbooks][google.cloud.dialogflow.cx.v3.Playbook].
    /// </remarks>
    public sealed partial class PlaybooksClientImpl : PlaybooksClient
    {
        private readonly gaxgrpc::ApiCall<CreatePlaybookRequest, Playbook> _callCreatePlaybook;

        private readonly gaxgrpc::ApiCall<DeletePlaybookRequest, wkt::Empty> _callDeletePlaybook;

        private readonly gaxgrpc::ApiCall<ListPlaybooksRequest, ListPlaybooksResponse> _callListPlaybooks;

        private readonly gaxgrpc::ApiCall<GetPlaybookRequest, Playbook> _callGetPlaybook;

        private readonly gaxgrpc::ApiCall<ExportPlaybookRequest, lro::Operation> _callExportPlaybook;

        private readonly gaxgrpc::ApiCall<ImportPlaybookRequest, lro::Operation> _callImportPlaybook;

        private readonly gaxgrpc::ApiCall<UpdatePlaybookRequest, Playbook> _callUpdatePlaybook;

        private readonly gaxgrpc::ApiCall<CreatePlaybookVersionRequest, PlaybookVersion> _callCreatePlaybookVersion;

        private readonly gaxgrpc::ApiCall<GetPlaybookVersionRequest, PlaybookVersion> _callGetPlaybookVersion;

        private readonly gaxgrpc::ApiCall<RestorePlaybookVersionRequest, RestorePlaybookVersionResponse> _callRestorePlaybookVersion;

        private readonly gaxgrpc::ApiCall<ListPlaybookVersionsRequest, ListPlaybookVersionsResponse> _callListPlaybookVersions;

        private readonly gaxgrpc::ApiCall<DeletePlaybookVersionRequest, wkt::Empty> _callDeletePlaybookVersion;

        /// <summary>
        /// Constructs a client wrapper for the Playbooks service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="PlaybooksSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public PlaybooksClientImpl(Playbooks.PlaybooksClient grpcClient, PlaybooksSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            PlaybooksSettings effectiveSettings = settings ?? PlaybooksSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            ExportPlaybookOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ExportPlaybookOperationsSettings, logger);
            ImportPlaybookOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ImportPlaybookOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callCreatePlaybook = clientHelper.BuildApiCall<CreatePlaybookRequest, Playbook>("CreatePlaybook", grpcClient.CreatePlaybookAsync, grpcClient.CreatePlaybook, effectiveSettings.CreatePlaybookSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreatePlaybook);
            Modify_CreatePlaybookApiCall(ref _callCreatePlaybook);
            _callDeletePlaybook = clientHelper.BuildApiCall<DeletePlaybookRequest, wkt::Empty>("DeletePlaybook", grpcClient.DeletePlaybookAsync, grpcClient.DeletePlaybook, effectiveSettings.DeletePlaybookSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeletePlaybook);
            Modify_DeletePlaybookApiCall(ref _callDeletePlaybook);
            _callListPlaybooks = clientHelper.BuildApiCall<ListPlaybooksRequest, ListPlaybooksResponse>("ListPlaybooks", grpcClient.ListPlaybooksAsync, grpcClient.ListPlaybooks, effectiveSettings.ListPlaybooksSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPlaybooks);
            Modify_ListPlaybooksApiCall(ref _callListPlaybooks);
            _callGetPlaybook = clientHelper.BuildApiCall<GetPlaybookRequest, Playbook>("GetPlaybook", grpcClient.GetPlaybookAsync, grpcClient.GetPlaybook, effectiveSettings.GetPlaybookSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPlaybook);
            Modify_GetPlaybookApiCall(ref _callGetPlaybook);
            _callExportPlaybook = clientHelper.BuildApiCall<ExportPlaybookRequest, lro::Operation>("ExportPlaybook", grpcClient.ExportPlaybookAsync, grpcClient.ExportPlaybook, effectiveSettings.ExportPlaybookSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callExportPlaybook);
            Modify_ExportPlaybookApiCall(ref _callExportPlaybook);
            _callImportPlaybook = clientHelper.BuildApiCall<ImportPlaybookRequest, lro::Operation>("ImportPlaybook", grpcClient.ImportPlaybookAsync, grpcClient.ImportPlaybook, effectiveSettings.ImportPlaybookSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callImportPlaybook);
            Modify_ImportPlaybookApiCall(ref _callImportPlaybook);
            _callUpdatePlaybook = clientHelper.BuildApiCall<UpdatePlaybookRequest, Playbook>("UpdatePlaybook", grpcClient.UpdatePlaybookAsync, grpcClient.UpdatePlaybook, effectiveSettings.UpdatePlaybookSettings).WithGoogleRequestParam("playbook.name", request => request.Playbook?.Name);
            Modify_ApiCall(ref _callUpdatePlaybook);
            Modify_UpdatePlaybookApiCall(ref _callUpdatePlaybook);
            _callCreatePlaybookVersion = clientHelper.BuildApiCall<CreatePlaybookVersionRequest, PlaybookVersion>("CreatePlaybookVersion", grpcClient.CreatePlaybookVersionAsync, grpcClient.CreatePlaybookVersion, effectiveSettings.CreatePlaybookVersionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreatePlaybookVersion);
            Modify_CreatePlaybookVersionApiCall(ref _callCreatePlaybookVersion);
            _callGetPlaybookVersion = clientHelper.BuildApiCall<GetPlaybookVersionRequest, PlaybookVersion>("GetPlaybookVersion", grpcClient.GetPlaybookVersionAsync, grpcClient.GetPlaybookVersion, effectiveSettings.GetPlaybookVersionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPlaybookVersion);
            Modify_GetPlaybookVersionApiCall(ref _callGetPlaybookVersion);
            _callRestorePlaybookVersion = clientHelper.BuildApiCall<RestorePlaybookVersionRequest, RestorePlaybookVersionResponse>("RestorePlaybookVersion", grpcClient.RestorePlaybookVersionAsync, grpcClient.RestorePlaybookVersion, effectiveSettings.RestorePlaybookVersionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRestorePlaybookVersion);
            Modify_RestorePlaybookVersionApiCall(ref _callRestorePlaybookVersion);
            _callListPlaybookVersions = clientHelper.BuildApiCall<ListPlaybookVersionsRequest, ListPlaybookVersionsResponse>("ListPlaybookVersions", grpcClient.ListPlaybookVersionsAsync, grpcClient.ListPlaybookVersions, effectiveSettings.ListPlaybookVersionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPlaybookVersions);
            Modify_ListPlaybookVersionsApiCall(ref _callListPlaybookVersions);
            _callDeletePlaybookVersion = clientHelper.BuildApiCall<DeletePlaybookVersionRequest, wkt::Empty>("DeletePlaybookVersion", grpcClient.DeletePlaybookVersionAsync, grpcClient.DeletePlaybookVersion, effectiveSettings.DeletePlaybookVersionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeletePlaybookVersion);
            Modify_DeletePlaybookVersionApiCall(ref _callDeletePlaybookVersion);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreatePlaybookApiCall(ref gaxgrpc::ApiCall<CreatePlaybookRequest, Playbook> call);

        partial void Modify_DeletePlaybookApiCall(ref gaxgrpc::ApiCall<DeletePlaybookRequest, wkt::Empty> call);

        partial void Modify_ListPlaybooksApiCall(ref gaxgrpc::ApiCall<ListPlaybooksRequest, ListPlaybooksResponse> call);

        partial void Modify_GetPlaybookApiCall(ref gaxgrpc::ApiCall<GetPlaybookRequest, Playbook> call);

        partial void Modify_ExportPlaybookApiCall(ref gaxgrpc::ApiCall<ExportPlaybookRequest, lro::Operation> call);

        partial void Modify_ImportPlaybookApiCall(ref gaxgrpc::ApiCall<ImportPlaybookRequest, lro::Operation> call);

        partial void Modify_UpdatePlaybookApiCall(ref gaxgrpc::ApiCall<UpdatePlaybookRequest, Playbook> call);

        partial void Modify_CreatePlaybookVersionApiCall(ref gaxgrpc::ApiCall<CreatePlaybookVersionRequest, PlaybookVersion> call);

        partial void Modify_GetPlaybookVersionApiCall(ref gaxgrpc::ApiCall<GetPlaybookVersionRequest, PlaybookVersion> call);

        partial void Modify_RestorePlaybookVersionApiCall(ref gaxgrpc::ApiCall<RestorePlaybookVersionRequest, RestorePlaybookVersionResponse> call);

        partial void Modify_ListPlaybookVersionsApiCall(ref gaxgrpc::ApiCall<ListPlaybookVersionsRequest, ListPlaybookVersionsResponse> call);

        partial void Modify_DeletePlaybookVersionApiCall(ref gaxgrpc::ApiCall<DeletePlaybookVersionRequest, wkt::Empty> call);

        partial void OnConstruction(Playbooks.PlaybooksClient grpcClient, PlaybooksSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Playbooks client</summary>
        public override Playbooks.PlaybooksClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_CreatePlaybookRequest(ref CreatePlaybookRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeletePlaybookRequest(ref DeletePlaybookRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPlaybooksRequest(ref ListPlaybooksRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetPlaybookRequest(ref GetPlaybookRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExportPlaybookRequest(ref ExportPlaybookRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ImportPlaybookRequest(ref ImportPlaybookRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdatePlaybookRequest(ref UpdatePlaybookRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreatePlaybookVersionRequest(ref CreatePlaybookVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetPlaybookVersionRequest(ref GetPlaybookVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RestorePlaybookVersionRequest(ref RestorePlaybookVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPlaybookVersionsRequest(ref ListPlaybookVersionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeletePlaybookVersionRequest(ref DeletePlaybookVersionRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a playbook in a specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Playbook CreatePlaybook(CreatePlaybookRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePlaybookRequest(ref request, ref callSettings);
            return _callCreatePlaybook.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a playbook in a specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Playbook> CreatePlaybookAsync(CreatePlaybookRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePlaybookRequest(ref request, ref callSettings);
            return _callCreatePlaybook.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a specified playbook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeletePlaybook(DeletePlaybookRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePlaybookRequest(ref request, ref callSettings);
            _callDeletePlaybook.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a specified playbook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeletePlaybookAsync(DeletePlaybookRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePlaybookRequest(ref request, ref callSettings);
            return _callDeletePlaybook.Async(request, callSettings);
        }

        /// <summary>
        /// Returns a list of playbooks in the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Playbook"/> resources.</returns>
        public override gax::PagedEnumerable<ListPlaybooksResponse, Playbook> ListPlaybooks(ListPlaybooksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPlaybooksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPlaybooksRequest, ListPlaybooksResponse, Playbook>(_callListPlaybooks, request, callSettings);
        }

        /// <summary>
        /// Returns a list of playbooks in the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Playbook"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPlaybooksResponse, Playbook> ListPlaybooksAsync(ListPlaybooksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPlaybooksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPlaybooksRequest, ListPlaybooksResponse, Playbook>(_callListPlaybooks, request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified Playbook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Playbook GetPlaybook(GetPlaybookRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPlaybookRequest(ref request, ref callSettings);
            return _callGetPlaybook.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified Playbook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Playbook> GetPlaybookAsync(GetPlaybookRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPlaybookRequest(ref request, ref callSettings);
            return _callGetPlaybook.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>ExportPlaybook</c>.</summary>
        public override lro::OperationsClient ExportPlaybookOperationsClient { get; }

        /// <summary>
        /// Exports the specified playbook to a binary file.
        /// 
        /// Note that resources (e.g. examples, tools) that the playbook
        /// references will also be exported.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ExportPlaybookResponse, wkt::Struct> ExportPlaybook(ExportPlaybookRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportPlaybookRequest(ref request, ref callSettings);
            return new lro::Operation<ExportPlaybookResponse, wkt::Struct>(_callExportPlaybook.Sync(request, callSettings), ExportPlaybookOperationsClient);
        }

        /// <summary>
        /// Exports the specified playbook to a binary file.
        /// 
        /// Note that resources (e.g. examples, tools) that the playbook
        /// references will also be exported.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ExportPlaybookResponse, wkt::Struct>> ExportPlaybookAsync(ExportPlaybookRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportPlaybookRequest(ref request, ref callSettings);
            return new lro::Operation<ExportPlaybookResponse, wkt::Struct>(await _callExportPlaybook.Async(request, callSettings).ConfigureAwait(false), ExportPlaybookOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ImportPlaybook</c>.</summary>
        public override lro::OperationsClient ImportPlaybookOperationsClient { get; }

        /// <summary>
        /// Imports the specified playbook to the specified agent from a binary file.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ImportPlaybookResponse, wkt::Struct> ImportPlaybook(ImportPlaybookRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportPlaybookRequest(ref request, ref callSettings);
            return new lro::Operation<ImportPlaybookResponse, wkt::Struct>(_callImportPlaybook.Sync(request, callSettings), ImportPlaybookOperationsClient);
        }

        /// <summary>
        /// Imports the specified playbook to the specified agent from a binary file.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ImportPlaybookResponse, wkt::Struct>> ImportPlaybookAsync(ImportPlaybookRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportPlaybookRequest(ref request, ref callSettings);
            return new lro::Operation<ImportPlaybookResponse, wkt::Struct>(await _callImportPlaybook.Async(request, callSettings).ConfigureAwait(false), ImportPlaybookOperationsClient);
        }

        /// <summary>
        /// Updates the specified Playbook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Playbook UpdatePlaybook(UpdatePlaybookRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePlaybookRequest(ref request, ref callSettings);
            return _callUpdatePlaybook.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the specified Playbook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Playbook> UpdatePlaybookAsync(UpdatePlaybookRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePlaybookRequest(ref request, ref callSettings);
            return _callUpdatePlaybook.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a version for the specified Playbook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PlaybookVersion CreatePlaybookVersion(CreatePlaybookVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePlaybookVersionRequest(ref request, ref callSettings);
            return _callCreatePlaybookVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a version for the specified Playbook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PlaybookVersion> CreatePlaybookVersionAsync(CreatePlaybookVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePlaybookVersionRequest(ref request, ref callSettings);
            return _callCreatePlaybookVersion.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified version of the Playbook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PlaybookVersion GetPlaybookVersion(GetPlaybookVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPlaybookVersionRequest(ref request, ref callSettings);
            return _callGetPlaybookVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified version of the Playbook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PlaybookVersion> GetPlaybookVersionAsync(GetPlaybookVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPlaybookVersionRequest(ref request, ref callSettings);
            return _callGetPlaybookVersion.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified version of the Playbook and stores it as the
        /// current playbook draft, returning the playbook with resources updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RestorePlaybookVersionResponse RestorePlaybookVersion(RestorePlaybookVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RestorePlaybookVersionRequest(ref request, ref callSettings);
            return _callRestorePlaybookVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified version of the Playbook and stores it as the
        /// current playbook draft, returning the playbook with resources updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RestorePlaybookVersionResponse> RestorePlaybookVersionAsync(RestorePlaybookVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RestorePlaybookVersionRequest(ref request, ref callSettings);
            return _callRestorePlaybookVersion.Async(request, callSettings);
        }

        /// <summary>
        /// Lists versions for the specified Playbook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PlaybookVersion"/> resources.</returns>
        public override gax::PagedEnumerable<ListPlaybookVersionsResponse, PlaybookVersion> ListPlaybookVersions(ListPlaybookVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPlaybookVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPlaybookVersionsRequest, ListPlaybookVersionsResponse, PlaybookVersion>(_callListPlaybookVersions, request, callSettings);
        }

        /// <summary>
        /// Lists versions for the specified Playbook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PlaybookVersion"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPlaybookVersionsResponse, PlaybookVersion> ListPlaybookVersionsAsync(ListPlaybookVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPlaybookVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPlaybookVersionsRequest, ListPlaybookVersionsResponse, PlaybookVersion>(_callListPlaybookVersions, request, callSettings);
        }

        /// <summary>
        /// Deletes the specified version of the Playbook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeletePlaybookVersion(DeletePlaybookVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePlaybookVersionRequest(ref request, ref callSettings);
            _callDeletePlaybookVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified version of the Playbook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeletePlaybookVersionAsync(DeletePlaybookVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePlaybookVersionRequest(ref request, ref callSettings);
            return _callDeletePlaybookVersion.Async(request, callSettings);
        }
    }

    public partial class ListPlaybooksRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPlaybookVersionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPlaybooksResponse : gaxgrpc::IPageResponse<Playbook>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Playbook> GetEnumerator() => Playbooks.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListPlaybookVersionsResponse : gaxgrpc::IPageResponse<PlaybookVersion>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<PlaybookVersion> GetEnumerator() => PlaybookVersions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Playbooks
    {
        public partial class PlaybooksClient
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

    public static partial class Playbooks
    {
        public partial class PlaybooksClient
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
