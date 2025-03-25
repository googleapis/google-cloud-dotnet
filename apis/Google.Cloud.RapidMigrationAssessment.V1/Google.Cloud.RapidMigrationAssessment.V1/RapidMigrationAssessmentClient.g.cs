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

namespace Google.Cloud.RapidMigrationAssessment.V1
{
    /// <summary>Settings for <see cref="RapidMigrationAssessmentClient"/> instances.</summary>
    public sealed partial class RapidMigrationAssessmentSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="RapidMigrationAssessmentSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="RapidMigrationAssessmentSettings"/>.</returns>
        public static RapidMigrationAssessmentSettings GetDefault() => new RapidMigrationAssessmentSettings();

        /// <summary>
        /// Constructs a new <see cref="RapidMigrationAssessmentSettings"/> object with default settings.
        /// </summary>
        public RapidMigrationAssessmentSettings()
        {
        }

        private RapidMigrationAssessmentSettings(RapidMigrationAssessmentSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateCollectorSettings = existing.CreateCollectorSettings;
            CreateCollectorOperationsSettings = existing.CreateCollectorOperationsSettings.Clone();
            CreateAnnotationSettings = existing.CreateAnnotationSettings;
            CreateAnnotationOperationsSettings = existing.CreateAnnotationOperationsSettings.Clone();
            GetAnnotationSettings = existing.GetAnnotationSettings;
            ListCollectorsSettings = existing.ListCollectorsSettings;
            GetCollectorSettings = existing.GetCollectorSettings;
            UpdateCollectorSettings = existing.UpdateCollectorSettings;
            UpdateCollectorOperationsSettings = existing.UpdateCollectorOperationsSettings.Clone();
            DeleteCollectorSettings = existing.DeleteCollectorSettings;
            DeleteCollectorOperationsSettings = existing.DeleteCollectorOperationsSettings.Clone();
            ResumeCollectorSettings = existing.ResumeCollectorSettings;
            ResumeCollectorOperationsSettings = existing.ResumeCollectorOperationsSettings.Clone();
            RegisterCollectorSettings = existing.RegisterCollectorSettings;
            RegisterCollectorOperationsSettings = existing.RegisterCollectorOperationsSettings.Clone();
            PauseCollectorSettings = existing.PauseCollectorSettings;
            PauseCollectorOperationsSettings = existing.PauseCollectorOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(RapidMigrationAssessmentSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RapidMigrationAssessmentClient.CreateCollector</c> and
        /// <c>RapidMigrationAssessmentClient.CreateCollectorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateCollectorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>RapidMigrationAssessmentClient.CreateCollector</c> and
        /// <c>RapidMigrationAssessmentClient.CreateCollectorAsync</c>.
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
        public lro::OperationsSettings CreateCollectorOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RapidMigrationAssessmentClient.CreateAnnotation</c> and
        /// <c>RapidMigrationAssessmentClient.CreateAnnotationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAnnotationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>RapidMigrationAssessmentClient.CreateAnnotation</c> and
        /// <c>RapidMigrationAssessmentClient.CreateAnnotationAsync</c>.
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
        public lro::OperationsSettings CreateAnnotationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RapidMigrationAssessmentClient.GetAnnotation</c> and <c>RapidMigrationAssessmentClient.GetAnnotationAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAnnotationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RapidMigrationAssessmentClient.ListCollectors</c> and
        /// <c>RapidMigrationAssessmentClient.ListCollectorsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListCollectorsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RapidMigrationAssessmentClient.GetCollector</c> and <c>RapidMigrationAssessmentClient.GetCollectorAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCollectorSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RapidMigrationAssessmentClient.UpdateCollector</c> and
        /// <c>RapidMigrationAssessmentClient.UpdateCollectorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateCollectorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>RapidMigrationAssessmentClient.UpdateCollector</c> and
        /// <c>RapidMigrationAssessmentClient.UpdateCollectorAsync</c>.
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
        public lro::OperationsSettings UpdateCollectorOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RapidMigrationAssessmentClient.DeleteCollector</c> and
        /// <c>RapidMigrationAssessmentClient.DeleteCollectorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteCollectorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>RapidMigrationAssessmentClient.DeleteCollector</c> and
        /// <c>RapidMigrationAssessmentClient.DeleteCollectorAsync</c>.
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
        public lro::OperationsSettings DeleteCollectorOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RapidMigrationAssessmentClient.ResumeCollector</c> and
        /// <c>RapidMigrationAssessmentClient.ResumeCollectorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ResumeCollectorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>RapidMigrationAssessmentClient.ResumeCollector</c> and
        /// <c>RapidMigrationAssessmentClient.ResumeCollectorAsync</c>.
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
        public lro::OperationsSettings ResumeCollectorOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RapidMigrationAssessmentClient.RegisterCollector</c> and
        /// <c>RapidMigrationAssessmentClient.RegisterCollectorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RegisterCollectorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>RapidMigrationAssessmentClient.RegisterCollector</c> and
        /// <c>RapidMigrationAssessmentClient.RegisterCollectorAsync</c>.
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
        public lro::OperationsSettings RegisterCollectorOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RapidMigrationAssessmentClient.PauseCollector</c> and
        /// <c>RapidMigrationAssessmentClient.PauseCollectorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PauseCollectorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>RapidMigrationAssessmentClient.PauseCollector</c> and
        /// <c>RapidMigrationAssessmentClient.PauseCollectorAsync</c>.
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
        public lro::OperationsSettings PauseCollectorOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="RapidMigrationAssessmentSettings"/> object.</returns>
        public RapidMigrationAssessmentSettings Clone() => new RapidMigrationAssessmentSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="RapidMigrationAssessmentClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class RapidMigrationAssessmentClientBuilder : gaxgrpc::ClientBuilderBase<RapidMigrationAssessmentClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public RapidMigrationAssessmentSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public RapidMigrationAssessmentClientBuilder() : base(RapidMigrationAssessmentClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref RapidMigrationAssessmentClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<RapidMigrationAssessmentClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override RapidMigrationAssessmentClient Build()
        {
            RapidMigrationAssessmentClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<RapidMigrationAssessmentClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<RapidMigrationAssessmentClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private RapidMigrationAssessmentClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return RapidMigrationAssessmentClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<RapidMigrationAssessmentClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return RapidMigrationAssessmentClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => RapidMigrationAssessmentClient.ChannelPool;
    }

    /// <summary>RapidMigrationAssessment client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources.
    /// </remarks>
    public abstract partial class RapidMigrationAssessmentClient
    {
        /// <summary>
        /// The default endpoint for the RapidMigrationAssessment service, which is a host of
        /// "rapidmigrationassessment.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "rapidmigrationassessment.googleapis.com:443";

        /// <summary>The default RapidMigrationAssessment scopes.</summary>
        /// <remarks>
        /// The default RapidMigrationAssessment scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(RapidMigrationAssessment.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="RapidMigrationAssessmentClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="RapidMigrationAssessmentClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="RapidMigrationAssessmentClient"/>.</returns>
        public static stt::Task<RapidMigrationAssessmentClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new RapidMigrationAssessmentClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="RapidMigrationAssessmentClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="RapidMigrationAssessmentClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="RapidMigrationAssessmentClient"/>.</returns>
        public static RapidMigrationAssessmentClient Create() => new RapidMigrationAssessmentClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="RapidMigrationAssessmentClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="RapidMigrationAssessmentSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="RapidMigrationAssessmentClient"/>.</returns>
        internal static RapidMigrationAssessmentClient Create(grpccore::CallInvoker callInvoker, RapidMigrationAssessmentSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            RapidMigrationAssessment.RapidMigrationAssessmentClient grpcClient = new RapidMigrationAssessment.RapidMigrationAssessmentClient(callInvoker);
            return new RapidMigrationAssessmentClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC RapidMigrationAssessment client</summary>
        public virtual RapidMigrationAssessment.RapidMigrationAssessmentClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Create a Collector to manage the on-prem appliance which collects
        /// information about Customer assets.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Collector, OperationMetadata> CreateCollector(CreateCollectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a Collector to manage the on-prem appliance which collects
        /// information about Customer assets.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Collector, OperationMetadata>> CreateCollectorAsync(CreateCollectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a Collector to manage the on-prem appliance which collects
        /// information about Customer assets.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Collector, OperationMetadata>> CreateCollectorAsync(CreateCollectorRequest request, st::CancellationToken cancellationToken) =>
            CreateCollectorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateCollector</c>.</summary>
        public virtual lro::OperationsClient CreateCollectorOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateCollector</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Collector, OperationMetadata> PollOnceCreateCollector(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Collector, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateCollectorOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateCollector</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Collector, OperationMetadata>> PollOnceCreateCollectorAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Collector, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateCollectorOperationsClient, callSettings);

        /// <summary>
        /// Create a Collector to manage the on-prem appliance which collects
        /// information about Customer assets.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent (project+location).
        /// </param>
        /// <param name="collector">
        /// Required. The resource being created.
        /// </param>
        /// <param name="collectorId">
        /// Required. Id of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Collector, OperationMetadata> CreateCollector(string parent, Collector collector, string collectorId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCollector(new CreateCollectorRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CollectorId = gax::GaxPreconditions.CheckNotNullOrEmpty(collectorId, nameof(collectorId)),
                Collector = gax::GaxPreconditions.CheckNotNull(collector, nameof(collector)),
            }, callSettings);

        /// <summary>
        /// Create a Collector to manage the on-prem appliance which collects
        /// information about Customer assets.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent (project+location).
        /// </param>
        /// <param name="collector">
        /// Required. The resource being created.
        /// </param>
        /// <param name="collectorId">
        /// Required. Id of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Collector, OperationMetadata>> CreateCollectorAsync(string parent, Collector collector, string collectorId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCollectorAsync(new CreateCollectorRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CollectorId = gax::GaxPreconditions.CheckNotNullOrEmpty(collectorId, nameof(collectorId)),
                Collector = gax::GaxPreconditions.CheckNotNull(collector, nameof(collector)),
            }, callSettings);

        /// <summary>
        /// Create a Collector to manage the on-prem appliance which collects
        /// information about Customer assets.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent (project+location).
        /// </param>
        /// <param name="collector">
        /// Required. The resource being created.
        /// </param>
        /// <param name="collectorId">
        /// Required. Id of the requesting object.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Collector, OperationMetadata>> CreateCollectorAsync(string parent, Collector collector, string collectorId, st::CancellationToken cancellationToken) =>
            CreateCollectorAsync(parent, collector, collectorId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a Collector to manage the on-prem appliance which collects
        /// information about Customer assets.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent (project+location).
        /// </param>
        /// <param name="collector">
        /// Required. The resource being created.
        /// </param>
        /// <param name="collectorId">
        /// Required. Id of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Collector, OperationMetadata> CreateCollector(gagr::LocationName parent, Collector collector, string collectorId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCollector(new CreateCollectorRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CollectorId = gax::GaxPreconditions.CheckNotNullOrEmpty(collectorId, nameof(collectorId)),
                Collector = gax::GaxPreconditions.CheckNotNull(collector, nameof(collector)),
            }, callSettings);

        /// <summary>
        /// Create a Collector to manage the on-prem appliance which collects
        /// information about Customer assets.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent (project+location).
        /// </param>
        /// <param name="collector">
        /// Required. The resource being created.
        /// </param>
        /// <param name="collectorId">
        /// Required. Id of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Collector, OperationMetadata>> CreateCollectorAsync(gagr::LocationName parent, Collector collector, string collectorId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCollectorAsync(new CreateCollectorRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CollectorId = gax::GaxPreconditions.CheckNotNullOrEmpty(collectorId, nameof(collectorId)),
                Collector = gax::GaxPreconditions.CheckNotNull(collector, nameof(collector)),
            }, callSettings);

        /// <summary>
        /// Create a Collector to manage the on-prem appliance which collects
        /// information about Customer assets.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent (project+location).
        /// </param>
        /// <param name="collector">
        /// Required. The resource being created.
        /// </param>
        /// <param name="collectorId">
        /// Required. Id of the requesting object.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Collector, OperationMetadata>> CreateCollectorAsync(gagr::LocationName parent, Collector collector, string collectorId, st::CancellationToken cancellationToken) =>
            CreateCollectorAsync(parent, collector, collectorId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an Annotation
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Annotation, OperationMetadata> CreateAnnotation(CreateAnnotationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an Annotation
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Annotation, OperationMetadata>> CreateAnnotationAsync(CreateAnnotationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an Annotation
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Annotation, OperationMetadata>> CreateAnnotationAsync(CreateAnnotationRequest request, st::CancellationToken cancellationToken) =>
            CreateAnnotationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateAnnotation</c>.</summary>
        public virtual lro::OperationsClient CreateAnnotationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateAnnotation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Annotation, OperationMetadata> PollOnceCreateAnnotation(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Annotation, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAnnotationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateAnnotation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Annotation, OperationMetadata>> PollOnceCreateAnnotationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Annotation, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAnnotationOperationsClient, callSettings);

        /// <summary>
        /// Creates an Annotation
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent (project+location).
        /// </param>
        /// <param name="annotation">
        /// Required. The resource being created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Annotation, OperationMetadata> CreateAnnotation(string parent, Annotation annotation, gaxgrpc::CallSettings callSettings = null) =>
            CreateAnnotation(new CreateAnnotationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Annotation = gax::GaxPreconditions.CheckNotNull(annotation, nameof(annotation)),
            }, callSettings);

        /// <summary>
        /// Creates an Annotation
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent (project+location).
        /// </param>
        /// <param name="annotation">
        /// Required. The resource being created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Annotation, OperationMetadata>> CreateAnnotationAsync(string parent, Annotation annotation, gaxgrpc::CallSettings callSettings = null) =>
            CreateAnnotationAsync(new CreateAnnotationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Annotation = gax::GaxPreconditions.CheckNotNull(annotation, nameof(annotation)),
            }, callSettings);

        /// <summary>
        /// Creates an Annotation
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent (project+location).
        /// </param>
        /// <param name="annotation">
        /// Required. The resource being created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Annotation, OperationMetadata>> CreateAnnotationAsync(string parent, Annotation annotation, st::CancellationToken cancellationToken) =>
            CreateAnnotationAsync(parent, annotation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an Annotation
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent (project+location).
        /// </param>
        /// <param name="annotation">
        /// Required. The resource being created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Annotation, OperationMetadata> CreateAnnotation(gagr::LocationName parent, Annotation annotation, gaxgrpc::CallSettings callSettings = null) =>
            CreateAnnotation(new CreateAnnotationRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Annotation = gax::GaxPreconditions.CheckNotNull(annotation, nameof(annotation)),
            }, callSettings);

        /// <summary>
        /// Creates an Annotation
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent (project+location).
        /// </param>
        /// <param name="annotation">
        /// Required. The resource being created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Annotation, OperationMetadata>> CreateAnnotationAsync(gagr::LocationName parent, Annotation annotation, gaxgrpc::CallSettings callSettings = null) =>
            CreateAnnotationAsync(new CreateAnnotationRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Annotation = gax::GaxPreconditions.CheckNotNull(annotation, nameof(annotation)),
            }, callSettings);

        /// <summary>
        /// Creates an Annotation
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent (project+location).
        /// </param>
        /// <param name="annotation">
        /// Required. The resource being created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Annotation, OperationMetadata>> CreateAnnotationAsync(gagr::LocationName parent, Annotation annotation, st::CancellationToken cancellationToken) =>
            CreateAnnotationAsync(parent, annotation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Annotation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Annotation GetAnnotation(GetAnnotationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Annotation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Annotation> GetAnnotationAsync(GetAnnotationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Annotation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Annotation> GetAnnotationAsync(GetAnnotationRequest request, st::CancellationToken cancellationToken) =>
            GetAnnotationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Annotation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Annotation GetAnnotation(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnnotation(new GetAnnotationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Annotation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Annotation> GetAnnotationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnnotationAsync(new GetAnnotationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Annotation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Annotation> GetAnnotationAsync(string name, st::CancellationToken cancellationToken) =>
            GetAnnotationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Annotation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Annotation GetAnnotation(AnnotationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnnotation(new GetAnnotationRequest
            {
                AnnotationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Annotation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Annotation> GetAnnotationAsync(AnnotationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnnotationAsync(new GetAnnotationRequest
            {
                AnnotationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Annotation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Annotation> GetAnnotationAsync(AnnotationName name, st::CancellationToken cancellationToken) =>
            GetAnnotationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Collectors in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Collector"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCollectorsResponse, Collector> ListCollectors(ListCollectorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Collectors in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Collector"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCollectorsResponse, Collector> ListCollectorsAsync(ListCollectorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Collectors in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListCollectorsRequest.
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
        /// <returns>A pageable sequence of <see cref="Collector"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCollectorsResponse, Collector> ListCollectors(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCollectorsRequest request = new ListCollectorsRequest
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
            return ListCollectors(request, callSettings);
        }

        /// <summary>
        /// Lists Collectors in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListCollectorsRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Collector"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCollectorsResponse, Collector> ListCollectorsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCollectorsRequest request = new ListCollectorsRequest
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
            return ListCollectorsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Collectors in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListCollectorsRequest.
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
        /// <returns>A pageable sequence of <see cref="Collector"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCollectorsResponse, Collector> ListCollectors(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCollectorsRequest request = new ListCollectorsRequest
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
            return ListCollectors(request, callSettings);
        }

        /// <summary>
        /// Lists Collectors in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListCollectorsRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Collector"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCollectorsResponse, Collector> ListCollectorsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCollectorsRequest request = new ListCollectorsRequest
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
            return ListCollectorsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Collector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Collector GetCollector(GetCollectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Collector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Collector> GetCollectorAsync(GetCollectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Collector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Collector> GetCollectorAsync(GetCollectorRequest request, st::CancellationToken cancellationToken) =>
            GetCollectorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Collector.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Collector GetCollector(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCollector(new GetCollectorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Collector.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Collector> GetCollectorAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCollectorAsync(new GetCollectorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Collector.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Collector> GetCollectorAsync(string name, st::CancellationToken cancellationToken) =>
            GetCollectorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Collector.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Collector GetCollector(CollectorName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCollector(new GetCollectorRequest
            {
                CollectorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Collector.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Collector> GetCollectorAsync(CollectorName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCollectorAsync(new GetCollectorRequest
            {
                CollectorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Collector.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Collector> GetCollectorAsync(CollectorName name, st::CancellationToken cancellationToken) =>
            GetCollectorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single Collector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Collector, OperationMetadata> UpdateCollector(UpdateCollectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Collector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Collector, OperationMetadata>> UpdateCollectorAsync(UpdateCollectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Collector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Collector, OperationMetadata>> UpdateCollectorAsync(UpdateCollectorRequest request, st::CancellationToken cancellationToken) =>
            UpdateCollectorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateCollector</c>.</summary>
        public virtual lro::OperationsClient UpdateCollectorOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateCollector</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Collector, OperationMetadata> PollOnceUpdateCollector(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Collector, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateCollectorOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateCollector</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Collector, OperationMetadata>> PollOnceUpdateCollectorAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Collector, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateCollectorOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single Collector.
        /// </summary>
        /// <param name="collector">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Collector resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Collector, OperationMetadata> UpdateCollector(Collector collector, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCollector(new UpdateCollectorRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Collector = gax::GaxPreconditions.CheckNotNull(collector, nameof(collector)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Collector.
        /// </summary>
        /// <param name="collector">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Collector resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Collector, OperationMetadata>> UpdateCollectorAsync(Collector collector, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCollectorAsync(new UpdateCollectorRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Collector = gax::GaxPreconditions.CheckNotNull(collector, nameof(collector)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Collector.
        /// </summary>
        /// <param name="collector">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Collector resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Collector, OperationMetadata>> UpdateCollectorAsync(Collector collector, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateCollectorAsync(collector, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Collector - changes state of collector to "Deleting".
        /// Background jobs does final deletion through producer API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Collector, OperationMetadata> DeleteCollector(DeleteCollectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Collector - changes state of collector to "Deleting".
        /// Background jobs does final deletion through producer API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Collector, OperationMetadata>> DeleteCollectorAsync(DeleteCollectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Collector - changes state of collector to "Deleting".
        /// Background jobs does final deletion through producer API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Collector, OperationMetadata>> DeleteCollectorAsync(DeleteCollectorRequest request, st::CancellationToken cancellationToken) =>
            DeleteCollectorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteCollector</c>.</summary>
        public virtual lro::OperationsClient DeleteCollectorOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteCollector</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Collector, OperationMetadata> PollOnceDeleteCollector(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Collector, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteCollectorOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteCollector</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Collector, OperationMetadata>> PollOnceDeleteCollectorAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Collector, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteCollectorOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Collector - changes state of collector to "Deleting".
        /// Background jobs does final deletion through producer API.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Collector, OperationMetadata> DeleteCollector(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCollector(new DeleteCollectorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Collector - changes state of collector to "Deleting".
        /// Background jobs does final deletion through producer API.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Collector, OperationMetadata>> DeleteCollectorAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCollectorAsync(new DeleteCollectorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Collector - changes state of collector to "Deleting".
        /// Background jobs does final deletion through producer API.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Collector, OperationMetadata>> DeleteCollectorAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteCollectorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Collector - changes state of collector to "Deleting".
        /// Background jobs does final deletion through producer API.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Collector, OperationMetadata> DeleteCollector(CollectorName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCollector(new DeleteCollectorRequest
            {
                CollectorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Collector - changes state of collector to "Deleting".
        /// Background jobs does final deletion through producer API.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Collector, OperationMetadata>> DeleteCollectorAsync(CollectorName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCollectorAsync(new DeleteCollectorRequest
            {
                CollectorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Collector - changes state of collector to "Deleting".
        /// Background jobs does final deletion through producer API.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Collector, OperationMetadata>> DeleteCollectorAsync(CollectorName name, st::CancellationToken cancellationToken) =>
            DeleteCollectorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resumes the given collector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Collector, OperationMetadata> ResumeCollector(ResumeCollectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resumes the given collector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Collector, OperationMetadata>> ResumeCollectorAsync(ResumeCollectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resumes the given collector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Collector, OperationMetadata>> ResumeCollectorAsync(ResumeCollectorRequest request, st::CancellationToken cancellationToken) =>
            ResumeCollectorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ResumeCollector</c>.</summary>
        public virtual lro::OperationsClient ResumeCollectorOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ResumeCollector</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Collector, OperationMetadata> PollOnceResumeCollector(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Collector, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ResumeCollectorOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ResumeCollector</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Collector, OperationMetadata>> PollOnceResumeCollectorAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Collector, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ResumeCollectorOperationsClient, callSettings);

        /// <summary>
        /// Resumes the given collector.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Collector, OperationMetadata> ResumeCollector(string name, gaxgrpc::CallSettings callSettings = null) =>
            ResumeCollector(new ResumeCollectorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Resumes the given collector.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Collector, OperationMetadata>> ResumeCollectorAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ResumeCollectorAsync(new ResumeCollectorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Resumes the given collector.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Collector, OperationMetadata>> ResumeCollectorAsync(string name, st::CancellationToken cancellationToken) =>
            ResumeCollectorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resumes the given collector.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Collector, OperationMetadata> ResumeCollector(CollectorName name, gaxgrpc::CallSettings callSettings = null) =>
            ResumeCollector(new ResumeCollectorRequest
            {
                CollectorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Resumes the given collector.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Collector, OperationMetadata>> ResumeCollectorAsync(CollectorName name, gaxgrpc::CallSettings callSettings = null) =>
            ResumeCollectorAsync(new ResumeCollectorRequest
            {
                CollectorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Resumes the given collector.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Collector, OperationMetadata>> ResumeCollectorAsync(CollectorName name, st::CancellationToken cancellationToken) =>
            ResumeCollectorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Registers the given collector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Collector, OperationMetadata> RegisterCollector(RegisterCollectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Registers the given collector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Collector, OperationMetadata>> RegisterCollectorAsync(RegisterCollectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Registers the given collector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Collector, OperationMetadata>> RegisterCollectorAsync(RegisterCollectorRequest request, st::CancellationToken cancellationToken) =>
            RegisterCollectorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RegisterCollector</c>.</summary>
        public virtual lro::OperationsClient RegisterCollectorOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RegisterCollector</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Collector, OperationMetadata> PollOnceRegisterCollector(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Collector, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RegisterCollectorOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RegisterCollector</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Collector, OperationMetadata>> PollOnceRegisterCollectorAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Collector, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RegisterCollectorOperationsClient, callSettings);

        /// <summary>
        /// Registers the given collector.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Collector, OperationMetadata> RegisterCollector(string name, gaxgrpc::CallSettings callSettings = null) =>
            RegisterCollector(new RegisterCollectorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Registers the given collector.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Collector, OperationMetadata>> RegisterCollectorAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            RegisterCollectorAsync(new RegisterCollectorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Registers the given collector.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Collector, OperationMetadata>> RegisterCollectorAsync(string name, st::CancellationToken cancellationToken) =>
            RegisterCollectorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Registers the given collector.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Collector, OperationMetadata> RegisterCollector(CollectorName name, gaxgrpc::CallSettings callSettings = null) =>
            RegisterCollector(new RegisterCollectorRequest
            {
                CollectorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Registers the given collector.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Collector, OperationMetadata>> RegisterCollectorAsync(CollectorName name, gaxgrpc::CallSettings callSettings = null) =>
            RegisterCollectorAsync(new RegisterCollectorRequest
            {
                CollectorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Registers the given collector.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Collector, OperationMetadata>> RegisterCollectorAsync(CollectorName name, st::CancellationToken cancellationToken) =>
            RegisterCollectorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Pauses the given collector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Collector, OperationMetadata> PauseCollector(PauseCollectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Pauses the given collector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Collector, OperationMetadata>> PauseCollectorAsync(PauseCollectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Pauses the given collector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Collector, OperationMetadata>> PauseCollectorAsync(PauseCollectorRequest request, st::CancellationToken cancellationToken) =>
            PauseCollectorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>PauseCollector</c>.</summary>
        public virtual lro::OperationsClient PauseCollectorOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>PauseCollector</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Collector, OperationMetadata> PollOncePauseCollector(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Collector, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PauseCollectorOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>PauseCollector</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Collector, OperationMetadata>> PollOncePauseCollectorAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Collector, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PauseCollectorOperationsClient, callSettings);

        /// <summary>
        /// Pauses the given collector.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Collector, OperationMetadata> PauseCollector(string name, gaxgrpc::CallSettings callSettings = null) =>
            PauseCollector(new PauseCollectorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Pauses the given collector.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Collector, OperationMetadata>> PauseCollectorAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            PauseCollectorAsync(new PauseCollectorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Pauses the given collector.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Collector, OperationMetadata>> PauseCollectorAsync(string name, st::CancellationToken cancellationToken) =>
            PauseCollectorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Pauses the given collector.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Collector, OperationMetadata> PauseCollector(CollectorName name, gaxgrpc::CallSettings callSettings = null) =>
            PauseCollector(new PauseCollectorRequest
            {
                CollectorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Pauses the given collector.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Collector, OperationMetadata>> PauseCollectorAsync(CollectorName name, gaxgrpc::CallSettings callSettings = null) =>
            PauseCollectorAsync(new PauseCollectorRequest
            {
                CollectorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Pauses the given collector.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Collector, OperationMetadata>> PauseCollectorAsync(CollectorName name, st::CancellationToken cancellationToken) =>
            PauseCollectorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>RapidMigrationAssessment client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources.
    /// </remarks>
    public sealed partial class RapidMigrationAssessmentClientImpl : RapidMigrationAssessmentClient
    {
        private readonly gaxgrpc::ApiCall<CreateCollectorRequest, lro::Operation> _callCreateCollector;

        private readonly gaxgrpc::ApiCall<CreateAnnotationRequest, lro::Operation> _callCreateAnnotation;

        private readonly gaxgrpc::ApiCall<GetAnnotationRequest, Annotation> _callGetAnnotation;

        private readonly gaxgrpc::ApiCall<ListCollectorsRequest, ListCollectorsResponse> _callListCollectors;

        private readonly gaxgrpc::ApiCall<GetCollectorRequest, Collector> _callGetCollector;

        private readonly gaxgrpc::ApiCall<UpdateCollectorRequest, lro::Operation> _callUpdateCollector;

        private readonly gaxgrpc::ApiCall<DeleteCollectorRequest, lro::Operation> _callDeleteCollector;

        private readonly gaxgrpc::ApiCall<ResumeCollectorRequest, lro::Operation> _callResumeCollector;

        private readonly gaxgrpc::ApiCall<RegisterCollectorRequest, lro::Operation> _callRegisterCollector;

        private readonly gaxgrpc::ApiCall<PauseCollectorRequest, lro::Operation> _callPauseCollector;

        /// <summary>
        /// Constructs a client wrapper for the RapidMigrationAssessment service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="RapidMigrationAssessmentSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public RapidMigrationAssessmentClientImpl(RapidMigrationAssessment.RapidMigrationAssessmentClient grpcClient, RapidMigrationAssessmentSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            RapidMigrationAssessmentSettings effectiveSettings = settings ?? RapidMigrationAssessmentSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateCollectorOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateCollectorOperationsSettings, logger);
            CreateAnnotationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateAnnotationOperationsSettings, logger);
            UpdateCollectorOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateCollectorOperationsSettings, logger);
            DeleteCollectorOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteCollectorOperationsSettings, logger);
            ResumeCollectorOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ResumeCollectorOperationsSettings, logger);
            RegisterCollectorOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RegisterCollectorOperationsSettings, logger);
            PauseCollectorOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.PauseCollectorOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callCreateCollector = clientHelper.BuildApiCall<CreateCollectorRequest, lro::Operation>("CreateCollector", grpcClient.CreateCollectorAsync, grpcClient.CreateCollector, effectiveSettings.CreateCollectorSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateCollector);
            Modify_CreateCollectorApiCall(ref _callCreateCollector);
            _callCreateAnnotation = clientHelper.BuildApiCall<CreateAnnotationRequest, lro::Operation>("CreateAnnotation", grpcClient.CreateAnnotationAsync, grpcClient.CreateAnnotation, effectiveSettings.CreateAnnotationSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAnnotation);
            Modify_CreateAnnotationApiCall(ref _callCreateAnnotation);
            _callGetAnnotation = clientHelper.BuildApiCall<GetAnnotationRequest, Annotation>("GetAnnotation", grpcClient.GetAnnotationAsync, grpcClient.GetAnnotation, effectiveSettings.GetAnnotationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAnnotation);
            Modify_GetAnnotationApiCall(ref _callGetAnnotation);
            _callListCollectors = clientHelper.BuildApiCall<ListCollectorsRequest, ListCollectorsResponse>("ListCollectors", grpcClient.ListCollectorsAsync, grpcClient.ListCollectors, effectiveSettings.ListCollectorsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCollectors);
            Modify_ListCollectorsApiCall(ref _callListCollectors);
            _callGetCollector = clientHelper.BuildApiCall<GetCollectorRequest, Collector>("GetCollector", grpcClient.GetCollectorAsync, grpcClient.GetCollector, effectiveSettings.GetCollectorSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCollector);
            Modify_GetCollectorApiCall(ref _callGetCollector);
            _callUpdateCollector = clientHelper.BuildApiCall<UpdateCollectorRequest, lro::Operation>("UpdateCollector", grpcClient.UpdateCollectorAsync, grpcClient.UpdateCollector, effectiveSettings.UpdateCollectorSettings).WithGoogleRequestParam("collector.name", request => request.Collector?.Name);
            Modify_ApiCall(ref _callUpdateCollector);
            Modify_UpdateCollectorApiCall(ref _callUpdateCollector);
            _callDeleteCollector = clientHelper.BuildApiCall<DeleteCollectorRequest, lro::Operation>("DeleteCollector", grpcClient.DeleteCollectorAsync, grpcClient.DeleteCollector, effectiveSettings.DeleteCollectorSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteCollector);
            Modify_DeleteCollectorApiCall(ref _callDeleteCollector);
            _callResumeCollector = clientHelper.BuildApiCall<ResumeCollectorRequest, lro::Operation>("ResumeCollector", grpcClient.ResumeCollectorAsync, grpcClient.ResumeCollector, effectiveSettings.ResumeCollectorSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callResumeCollector);
            Modify_ResumeCollectorApiCall(ref _callResumeCollector);
            _callRegisterCollector = clientHelper.BuildApiCall<RegisterCollectorRequest, lro::Operation>("RegisterCollector", grpcClient.RegisterCollectorAsync, grpcClient.RegisterCollector, effectiveSettings.RegisterCollectorSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRegisterCollector);
            Modify_RegisterCollectorApiCall(ref _callRegisterCollector);
            _callPauseCollector = clientHelper.BuildApiCall<PauseCollectorRequest, lro::Operation>("PauseCollector", grpcClient.PauseCollectorAsync, grpcClient.PauseCollector, effectiveSettings.PauseCollectorSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callPauseCollector);
            Modify_PauseCollectorApiCall(ref _callPauseCollector);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateCollectorApiCall(ref gaxgrpc::ApiCall<CreateCollectorRequest, lro::Operation> call);

        partial void Modify_CreateAnnotationApiCall(ref gaxgrpc::ApiCall<CreateAnnotationRequest, lro::Operation> call);

        partial void Modify_GetAnnotationApiCall(ref gaxgrpc::ApiCall<GetAnnotationRequest, Annotation> call);

        partial void Modify_ListCollectorsApiCall(ref gaxgrpc::ApiCall<ListCollectorsRequest, ListCollectorsResponse> call);

        partial void Modify_GetCollectorApiCall(ref gaxgrpc::ApiCall<GetCollectorRequest, Collector> call);

        partial void Modify_UpdateCollectorApiCall(ref gaxgrpc::ApiCall<UpdateCollectorRequest, lro::Operation> call);

        partial void Modify_DeleteCollectorApiCall(ref gaxgrpc::ApiCall<DeleteCollectorRequest, lro::Operation> call);

        partial void Modify_ResumeCollectorApiCall(ref gaxgrpc::ApiCall<ResumeCollectorRequest, lro::Operation> call);

        partial void Modify_RegisterCollectorApiCall(ref gaxgrpc::ApiCall<RegisterCollectorRequest, lro::Operation> call);

        partial void Modify_PauseCollectorApiCall(ref gaxgrpc::ApiCall<PauseCollectorRequest, lro::Operation> call);

        partial void OnConstruction(RapidMigrationAssessment.RapidMigrationAssessmentClient grpcClient, RapidMigrationAssessmentSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC RapidMigrationAssessment client</summary>
        public override RapidMigrationAssessment.RapidMigrationAssessmentClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_CreateCollectorRequest(ref CreateCollectorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateAnnotationRequest(ref CreateAnnotationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAnnotationRequest(ref GetAnnotationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCollectorsRequest(ref ListCollectorsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetCollectorRequest(ref GetCollectorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateCollectorRequest(ref UpdateCollectorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteCollectorRequest(ref DeleteCollectorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ResumeCollectorRequest(ref ResumeCollectorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RegisterCollectorRequest(ref RegisterCollectorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PauseCollectorRequest(ref PauseCollectorRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateCollector</c>.</summary>
        public override lro::OperationsClient CreateCollectorOperationsClient { get; }

        /// <summary>
        /// Create a Collector to manage the on-prem appliance which collects
        /// information about Customer assets.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Collector, OperationMetadata> CreateCollector(CreateCollectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCollectorRequest(ref request, ref callSettings);
            return new lro::Operation<Collector, OperationMetadata>(_callCreateCollector.Sync(request, callSettings), CreateCollectorOperationsClient);
        }

        /// <summary>
        /// Create a Collector to manage the on-prem appliance which collects
        /// information about Customer assets.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Collector, OperationMetadata>> CreateCollectorAsync(CreateCollectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCollectorRequest(ref request, ref callSettings);
            return new lro::Operation<Collector, OperationMetadata>(await _callCreateCollector.Async(request, callSettings).ConfigureAwait(false), CreateCollectorOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreateAnnotation</c>.</summary>
        public override lro::OperationsClient CreateAnnotationOperationsClient { get; }

        /// <summary>
        /// Creates an Annotation
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Annotation, OperationMetadata> CreateAnnotation(CreateAnnotationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAnnotationRequest(ref request, ref callSettings);
            return new lro::Operation<Annotation, OperationMetadata>(_callCreateAnnotation.Sync(request, callSettings), CreateAnnotationOperationsClient);
        }

        /// <summary>
        /// Creates an Annotation
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Annotation, OperationMetadata>> CreateAnnotationAsync(CreateAnnotationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAnnotationRequest(ref request, ref callSettings);
            return new lro::Operation<Annotation, OperationMetadata>(await _callCreateAnnotation.Async(request, callSettings).ConfigureAwait(false), CreateAnnotationOperationsClient);
        }

        /// <summary>
        /// Gets details of a single Annotation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Annotation GetAnnotation(GetAnnotationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAnnotationRequest(ref request, ref callSettings);
            return _callGetAnnotation.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Annotation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Annotation> GetAnnotationAsync(GetAnnotationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAnnotationRequest(ref request, ref callSettings);
            return _callGetAnnotation.Async(request, callSettings);
        }

        /// <summary>
        /// Lists Collectors in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Collector"/> resources.</returns>
        public override gax::PagedEnumerable<ListCollectorsResponse, Collector> ListCollectors(ListCollectorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCollectorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCollectorsRequest, ListCollectorsResponse, Collector>(_callListCollectors, request, callSettings);
        }

        /// <summary>
        /// Lists Collectors in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Collector"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCollectorsResponse, Collector> ListCollectorsAsync(ListCollectorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCollectorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCollectorsRequest, ListCollectorsResponse, Collector>(_callListCollectors, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Collector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Collector GetCollector(GetCollectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCollectorRequest(ref request, ref callSettings);
            return _callGetCollector.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Collector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Collector> GetCollectorAsync(GetCollectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCollectorRequest(ref request, ref callSettings);
            return _callGetCollector.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateCollector</c>.</summary>
        public override lro::OperationsClient UpdateCollectorOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single Collector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Collector, OperationMetadata> UpdateCollector(UpdateCollectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCollectorRequest(ref request, ref callSettings);
            return new lro::Operation<Collector, OperationMetadata>(_callUpdateCollector.Sync(request, callSettings), UpdateCollectorOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single Collector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Collector, OperationMetadata>> UpdateCollectorAsync(UpdateCollectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCollectorRequest(ref request, ref callSettings);
            return new lro::Operation<Collector, OperationMetadata>(await _callUpdateCollector.Async(request, callSettings).ConfigureAwait(false), UpdateCollectorOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteCollector</c>.</summary>
        public override lro::OperationsClient DeleteCollectorOperationsClient { get; }

        /// <summary>
        /// Deletes a single Collector - changes state of collector to "Deleting".
        /// Background jobs does final deletion through producer API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Collector, OperationMetadata> DeleteCollector(DeleteCollectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCollectorRequest(ref request, ref callSettings);
            return new lro::Operation<Collector, OperationMetadata>(_callDeleteCollector.Sync(request, callSettings), DeleteCollectorOperationsClient);
        }

        /// <summary>
        /// Deletes a single Collector - changes state of collector to "Deleting".
        /// Background jobs does final deletion through producer API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Collector, OperationMetadata>> DeleteCollectorAsync(DeleteCollectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCollectorRequest(ref request, ref callSettings);
            return new lro::Operation<Collector, OperationMetadata>(await _callDeleteCollector.Async(request, callSettings).ConfigureAwait(false), DeleteCollectorOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ResumeCollector</c>.</summary>
        public override lro::OperationsClient ResumeCollectorOperationsClient { get; }

        /// <summary>
        /// Resumes the given collector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Collector, OperationMetadata> ResumeCollector(ResumeCollectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResumeCollectorRequest(ref request, ref callSettings);
            return new lro::Operation<Collector, OperationMetadata>(_callResumeCollector.Sync(request, callSettings), ResumeCollectorOperationsClient);
        }

        /// <summary>
        /// Resumes the given collector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Collector, OperationMetadata>> ResumeCollectorAsync(ResumeCollectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResumeCollectorRequest(ref request, ref callSettings);
            return new lro::Operation<Collector, OperationMetadata>(await _callResumeCollector.Async(request, callSettings).ConfigureAwait(false), ResumeCollectorOperationsClient);
        }

        /// <summary>The long-running operations client for <c>RegisterCollector</c>.</summary>
        public override lro::OperationsClient RegisterCollectorOperationsClient { get; }

        /// <summary>
        /// Registers the given collector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Collector, OperationMetadata> RegisterCollector(RegisterCollectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RegisterCollectorRequest(ref request, ref callSettings);
            return new lro::Operation<Collector, OperationMetadata>(_callRegisterCollector.Sync(request, callSettings), RegisterCollectorOperationsClient);
        }

        /// <summary>
        /// Registers the given collector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Collector, OperationMetadata>> RegisterCollectorAsync(RegisterCollectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RegisterCollectorRequest(ref request, ref callSettings);
            return new lro::Operation<Collector, OperationMetadata>(await _callRegisterCollector.Async(request, callSettings).ConfigureAwait(false), RegisterCollectorOperationsClient);
        }

        /// <summary>The long-running operations client for <c>PauseCollector</c>.</summary>
        public override lro::OperationsClient PauseCollectorOperationsClient { get; }

        /// <summary>
        /// Pauses the given collector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Collector, OperationMetadata> PauseCollector(PauseCollectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PauseCollectorRequest(ref request, ref callSettings);
            return new lro::Operation<Collector, OperationMetadata>(_callPauseCollector.Sync(request, callSettings), PauseCollectorOperationsClient);
        }

        /// <summary>
        /// Pauses the given collector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Collector, OperationMetadata>> PauseCollectorAsync(PauseCollectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PauseCollectorRequest(ref request, ref callSettings);
            return new lro::Operation<Collector, OperationMetadata>(await _callPauseCollector.Async(request, callSettings).ConfigureAwait(false), PauseCollectorOperationsClient);
        }
    }

    public partial class ListCollectorsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCollectorsResponse : gaxgrpc::IPageResponse<Collector>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Collector> GetEnumerator() => Collectors.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class RapidMigrationAssessment
    {
        public partial class RapidMigrationAssessmentClient
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

    public static partial class RapidMigrationAssessment
    {
        public partial class RapidMigrationAssessmentClient
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
