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

namespace Google.Cloud.Dialogflow.V2
{
    /// <summary>Settings for <see cref="ConversationModelsClient"/> instances.</summary>
    public sealed partial class ConversationModelsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ConversationModelsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ConversationModelsSettings"/>.</returns>
        public static ConversationModelsSettings GetDefault() => new ConversationModelsSettings();

        /// <summary>Constructs a new <see cref="ConversationModelsSettings"/> object with default settings.</summary>
        public ConversationModelsSettings()
        {
        }

        private ConversationModelsSettings(ConversationModelsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateConversationModelSettings = existing.CreateConversationModelSettings;
            CreateConversationModelOperationsSettings = existing.CreateConversationModelOperationsSettings.Clone();
            GetConversationModelSettings = existing.GetConversationModelSettings;
            ListConversationModelsSettings = existing.ListConversationModelsSettings;
            DeleteConversationModelSettings = existing.DeleteConversationModelSettings;
            DeleteConversationModelOperationsSettings = existing.DeleteConversationModelOperationsSettings.Clone();
            DeployConversationModelSettings = existing.DeployConversationModelSettings;
            DeployConversationModelOperationsSettings = existing.DeployConversationModelOperationsSettings.Clone();
            UndeployConversationModelSettings = existing.UndeployConversationModelSettings;
            UndeployConversationModelOperationsSettings = existing.UndeployConversationModelOperationsSettings.Clone();
            GetConversationModelEvaluationSettings = existing.GetConversationModelEvaluationSettings;
            ListConversationModelEvaluationsSettings = existing.ListConversationModelEvaluationsSettings;
            CreateConversationModelEvaluationSettings = existing.CreateConversationModelEvaluationSettings;
            CreateConversationModelEvaluationOperationsSettings = existing.CreateConversationModelEvaluationOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ConversationModelsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversationModelsClient.CreateConversationModel</c> and
        /// <c>ConversationModelsClient.CreateConversationModelAsync</c>.
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
        public gaxgrpc::CallSettings CreateConversationModelSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ConversationModelsClient.CreateConversationModel</c> and
        /// <c>ConversationModelsClient.CreateConversationModelAsync</c>.
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
        public lro::OperationsSettings CreateConversationModelOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversationModelsClient.GetConversationModel</c> and
        /// <c>ConversationModelsClient.GetConversationModelAsync</c>.
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
        public gaxgrpc::CallSettings GetConversationModelSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversationModelsClient.ListConversationModels</c> and
        /// <c>ConversationModelsClient.ListConversationModelsAsync</c>.
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
        public gaxgrpc::CallSettings ListConversationModelsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversationModelsClient.DeleteConversationModel</c> and
        /// <c>ConversationModelsClient.DeleteConversationModelAsync</c>.
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
        public gaxgrpc::CallSettings DeleteConversationModelSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ConversationModelsClient.DeleteConversationModel</c> and
        /// <c>ConversationModelsClient.DeleteConversationModelAsync</c>.
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
        public lro::OperationsSettings DeleteConversationModelOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversationModelsClient.DeployConversationModel</c> and
        /// <c>ConversationModelsClient.DeployConversationModelAsync</c>.
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
        public gaxgrpc::CallSettings DeployConversationModelSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ConversationModelsClient.DeployConversationModel</c> and
        /// <c>ConversationModelsClient.DeployConversationModelAsync</c>.
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
        public lro::OperationsSettings DeployConversationModelOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversationModelsClient.UndeployConversationModel</c> and
        /// <c>ConversationModelsClient.UndeployConversationModelAsync</c>.
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
        public gaxgrpc::CallSettings UndeployConversationModelSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ConversationModelsClient.UndeployConversationModel</c> and
        /// <c>ConversationModelsClient.UndeployConversationModelAsync</c>.
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
        public lro::OperationsSettings UndeployConversationModelOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversationModelsClient.GetConversationModelEvaluation</c> and
        /// <c>ConversationModelsClient.GetConversationModelEvaluationAsync</c>.
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
        public gaxgrpc::CallSettings GetConversationModelEvaluationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversationModelsClient.ListConversationModelEvaluations</c> and
        /// <c>ConversationModelsClient.ListConversationModelEvaluationsAsync</c>.
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
        public gaxgrpc::CallSettings ListConversationModelEvaluationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversationModelsClient.CreateConversationModelEvaluation</c> and
        /// <c>ConversationModelsClient.CreateConversationModelEvaluationAsync</c>.
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
        public gaxgrpc::CallSettings CreateConversationModelEvaluationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ConversationModelsClient.CreateConversationModelEvaluation</c>
        ///  and <c>ConversationModelsClient.CreateConversationModelEvaluationAsync</c>.
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
        public lro::OperationsSettings CreateConversationModelEvaluationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ConversationModelsSettings"/> object.</returns>
        public ConversationModelsSettings Clone() => new ConversationModelsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ConversationModelsClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class ConversationModelsClientBuilder : gaxgrpc::ClientBuilderBase<ConversationModelsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ConversationModelsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ConversationModelsClientBuilder() : base(ConversationModelsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ConversationModelsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ConversationModelsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ConversationModelsClient Build()
        {
            ConversationModelsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ConversationModelsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ConversationModelsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ConversationModelsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ConversationModelsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ConversationModelsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ConversationModelsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ConversationModelsClient.ChannelPool;
    }

    /// <summary>ConversationModels client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Manages a collection of models for human agent assistant.
    /// </remarks>
    public abstract partial class ConversationModelsClient
    {
        /// <summary>
        /// The default endpoint for the ConversationModels service, which is a host of "dialogflow.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dialogflow.googleapis.com:443";

        /// <summary>The default ConversationModels scopes.</summary>
        /// <remarks>
        /// The default ConversationModels scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ConversationModels.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ConversationModelsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ConversationModelsClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ConversationModelsClient"/>.</returns>
        public static stt::Task<ConversationModelsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ConversationModelsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ConversationModelsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ConversationModelsClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="ConversationModelsClient"/>.</returns>
        public static ConversationModelsClient Create() => new ConversationModelsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ConversationModelsClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ConversationModelsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ConversationModelsClient"/>.</returns>
        internal static ConversationModelsClient Create(grpccore::CallInvoker callInvoker, ConversationModelsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ConversationModels.ConversationModelsClient grpcClient = new ConversationModels.ConversationModelsClient(callInvoker);
            return new ConversationModelsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ConversationModels client</summary>
        public virtual ConversationModels.ConversationModelsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a model.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [CreateConversationModelOperationMetadata][google.cloud.dialogflow.v2.CreateConversationModelOperationMetadata]
        /// - `response`:
        /// [ConversationModel][google.cloud.dialogflow.v2.ConversationModel]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConversationModel, CreateConversationModelOperationMetadata> CreateConversationModel(CreateConversationModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a model.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [CreateConversationModelOperationMetadata][google.cloud.dialogflow.v2.CreateConversationModelOperationMetadata]
        /// - `response`:
        /// [ConversationModel][google.cloud.dialogflow.v2.ConversationModel]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConversationModel, CreateConversationModelOperationMetadata>> CreateConversationModelAsync(CreateConversationModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a model.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [CreateConversationModelOperationMetadata][google.cloud.dialogflow.v2.CreateConversationModelOperationMetadata]
        /// - `response`:
        /// [ConversationModel][google.cloud.dialogflow.v2.ConversationModel]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConversationModel, CreateConversationModelOperationMetadata>> CreateConversationModelAsync(CreateConversationModelRequest request, st::CancellationToken cancellationToken) =>
            CreateConversationModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateConversationModel</c>.</summary>
        public virtual lro::OperationsClient CreateConversationModelOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateConversationModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ConversationModel, CreateConversationModelOperationMetadata> PollOnceCreateConversationModel(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ConversationModel, CreateConversationModelOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateConversationModelOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateConversationModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ConversationModel, CreateConversationModelOperationMetadata>> PollOnceCreateConversationModelAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ConversationModel, CreateConversationModelOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateConversationModelOperationsClient, callSettings);

        /// <summary>
        /// Creates a model.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [CreateConversationModelOperationMetadata][google.cloud.dialogflow.v2.CreateConversationModelOperationMetadata]
        /// - `response`:
        /// [ConversationModel][google.cloud.dialogflow.v2.ConversationModel]
        /// </summary>
        /// <param name="parent">
        /// The project to create conversation model for. Format:
        /// `projects/&lt;Project ID&gt;`
        /// </param>
        /// <param name="conversationModel">
        /// Required. The conversation model to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConversationModel, CreateConversationModelOperationMetadata> CreateConversationModel(string parent, ConversationModel conversationModel, gaxgrpc::CallSettings callSettings = null) =>
            CreateConversationModel(new CreateConversationModelRequest
            {
                Parent = parent ?? "",
                ConversationModel = gax::GaxPreconditions.CheckNotNull(conversationModel, nameof(conversationModel)),
            }, callSettings);

        /// <summary>
        /// Creates a model.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [CreateConversationModelOperationMetadata][google.cloud.dialogflow.v2.CreateConversationModelOperationMetadata]
        /// - `response`:
        /// [ConversationModel][google.cloud.dialogflow.v2.ConversationModel]
        /// </summary>
        /// <param name="parent">
        /// The project to create conversation model for. Format:
        /// `projects/&lt;Project ID&gt;`
        /// </param>
        /// <param name="conversationModel">
        /// Required. The conversation model to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConversationModel, CreateConversationModelOperationMetadata>> CreateConversationModelAsync(string parent, ConversationModel conversationModel, gaxgrpc::CallSettings callSettings = null) =>
            CreateConversationModelAsync(new CreateConversationModelRequest
            {
                Parent = parent ?? "",
                ConversationModel = gax::GaxPreconditions.CheckNotNull(conversationModel, nameof(conversationModel)),
            }, callSettings);

        /// <summary>
        /// Creates a model.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [CreateConversationModelOperationMetadata][google.cloud.dialogflow.v2.CreateConversationModelOperationMetadata]
        /// - `response`:
        /// [ConversationModel][google.cloud.dialogflow.v2.ConversationModel]
        /// </summary>
        /// <param name="parent">
        /// The project to create conversation model for. Format:
        /// `projects/&lt;Project ID&gt;`
        /// </param>
        /// <param name="conversationModel">
        /// Required. The conversation model to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConversationModel, CreateConversationModelOperationMetadata>> CreateConversationModelAsync(string parent, ConversationModel conversationModel, st::CancellationToken cancellationToken) =>
            CreateConversationModelAsync(parent, conversationModel, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets conversation model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConversationModel GetConversationModel(GetConversationModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets conversation model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversationModel> GetConversationModelAsync(GetConversationModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets conversation model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversationModel> GetConversationModelAsync(GetConversationModelRequest request, st::CancellationToken cancellationToken) =>
            GetConversationModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets conversation model.
        /// </summary>
        /// <param name="name">
        /// Required. The conversation model to retrieve. Format:
        /// `projects/&lt;Project ID&gt;/conversationModels/&lt;Conversation Model ID&gt;`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConversationModel GetConversationModel(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConversationModel(new GetConversationModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets conversation model.
        /// </summary>
        /// <param name="name">
        /// Required. The conversation model to retrieve. Format:
        /// `projects/&lt;Project ID&gt;/conversationModels/&lt;Conversation Model ID&gt;`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversationModel> GetConversationModelAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConversationModelAsync(new GetConversationModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets conversation model.
        /// </summary>
        /// <param name="name">
        /// Required. The conversation model to retrieve. Format:
        /// `projects/&lt;Project ID&gt;/conversationModels/&lt;Conversation Model ID&gt;`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversationModel> GetConversationModelAsync(string name, st::CancellationToken cancellationToken) =>
            GetConversationModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists conversation models.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ConversationModel"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConversationModelsResponse, ConversationModel> ListConversationModels(ListConversationModelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists conversation models.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ConversationModel"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConversationModelsResponse, ConversationModel> ListConversationModelsAsync(ListConversationModelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists conversation models.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to list all conversation models for.
        /// Format: `projects/&lt;Project ID&gt;`
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
        /// <returns>A pageable sequence of <see cref="ConversationModel"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConversationModelsResponse, ConversationModel> ListConversationModels(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConversationModelsRequest request = new ListConversationModelsRequest
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
            return ListConversationModels(request, callSettings);
        }

        /// <summary>
        /// Lists conversation models.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to list all conversation models for.
        /// Format: `projects/&lt;Project ID&gt;`
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
        /// <returns>A pageable asynchronous sequence of <see cref="ConversationModel"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConversationModelsResponse, ConversationModel> ListConversationModelsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConversationModelsRequest request = new ListConversationModelsRequest
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
            return ListConversationModelsAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes a model.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [DeleteConversationModelOperationMetadata][google.cloud.dialogflow.v2.DeleteConversationModelOperationMetadata]
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteConversationModelOperationMetadata> DeleteConversationModel(DeleteConversationModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a model.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [DeleteConversationModelOperationMetadata][google.cloud.dialogflow.v2.DeleteConversationModelOperationMetadata]
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteConversationModelOperationMetadata>> DeleteConversationModelAsync(DeleteConversationModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a model.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [DeleteConversationModelOperationMetadata][google.cloud.dialogflow.v2.DeleteConversationModelOperationMetadata]
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteConversationModelOperationMetadata>> DeleteConversationModelAsync(DeleteConversationModelRequest request, st::CancellationToken cancellationToken) =>
            DeleteConversationModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteConversationModel</c>.</summary>
        public virtual lro::OperationsClient DeleteConversationModelOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteConversationModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteConversationModelOperationMetadata> PollOnceDeleteConversationModel(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteConversationModelOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteConversationModelOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteConversationModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteConversationModelOperationMetadata>> PollOnceDeleteConversationModelAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteConversationModelOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteConversationModelOperationsClient, callSettings);

        /// <summary>
        /// Deletes a model.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [DeleteConversationModelOperationMetadata][google.cloud.dialogflow.v2.DeleteConversationModelOperationMetadata]
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="name">
        /// Required. The conversation model to delete. Format:
        /// `projects/&lt;Project ID&gt;/conversationModels/&lt;Conversation Model ID&gt;`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteConversationModelOperationMetadata> DeleteConversationModel(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConversationModel(new DeleteConversationModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a model.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [DeleteConversationModelOperationMetadata][google.cloud.dialogflow.v2.DeleteConversationModelOperationMetadata]
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="name">
        /// Required. The conversation model to delete. Format:
        /// `projects/&lt;Project ID&gt;/conversationModels/&lt;Conversation Model ID&gt;`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteConversationModelOperationMetadata>> DeleteConversationModelAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConversationModelAsync(new DeleteConversationModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a model.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [DeleteConversationModelOperationMetadata][google.cloud.dialogflow.v2.DeleteConversationModelOperationMetadata]
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="name">
        /// Required. The conversation model to delete. Format:
        /// `projects/&lt;Project ID&gt;/conversationModels/&lt;Conversation Model ID&gt;`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteConversationModelOperationMetadata>> DeleteConversationModelAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteConversationModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deploys a model. If a model is already deployed, deploying it
        /// has no effect. A model can only serve prediction requests after it gets
        /// deployed. For article suggestion, custom model will not be used unless
        /// it is deployed.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [DeployConversationModelOperationMetadata][google.cloud.dialogflow.v2.DeployConversationModelOperationMetadata]
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeployConversationModelOperationMetadata> DeployConversationModel(DeployConversationModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deploys a model. If a model is already deployed, deploying it
        /// has no effect. A model can only serve prediction requests after it gets
        /// deployed. For article suggestion, custom model will not be used unless
        /// it is deployed.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [DeployConversationModelOperationMetadata][google.cloud.dialogflow.v2.DeployConversationModelOperationMetadata]
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeployConversationModelOperationMetadata>> DeployConversationModelAsync(DeployConversationModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deploys a model. If a model is already deployed, deploying it
        /// has no effect. A model can only serve prediction requests after it gets
        /// deployed. For article suggestion, custom model will not be used unless
        /// it is deployed.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [DeployConversationModelOperationMetadata][google.cloud.dialogflow.v2.DeployConversationModelOperationMetadata]
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeployConversationModelOperationMetadata>> DeployConversationModelAsync(DeployConversationModelRequest request, st::CancellationToken cancellationToken) =>
            DeployConversationModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeployConversationModel</c>.</summary>
        public virtual lro::OperationsClient DeployConversationModelOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeployConversationModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeployConversationModelOperationMetadata> PollOnceDeployConversationModel(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeployConversationModelOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeployConversationModelOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeployConversationModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeployConversationModelOperationMetadata>> PollOnceDeployConversationModelAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeployConversationModelOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeployConversationModelOperationsClient, callSettings);

        /// <summary>
        /// Undeploys a model. If the model is not deployed this method has no effect.
        /// If the model is currently being used:
        /// - For article suggestion, article suggestion will fallback to the default
        /// model if model is undeployed.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [UndeployConversationModelOperationMetadata][google.cloud.dialogflow.v2.UndeployConversationModelOperationMetadata]
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, UndeployConversationModelOperationMetadata> UndeployConversationModel(UndeployConversationModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Undeploys a model. If the model is not deployed this method has no effect.
        /// If the model is currently being used:
        /// - For article suggestion, article suggestion will fallback to the default
        /// model if model is undeployed.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [UndeployConversationModelOperationMetadata][google.cloud.dialogflow.v2.UndeployConversationModelOperationMetadata]
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, UndeployConversationModelOperationMetadata>> UndeployConversationModelAsync(UndeployConversationModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Undeploys a model. If the model is not deployed this method has no effect.
        /// If the model is currently being used:
        /// - For article suggestion, article suggestion will fallback to the default
        /// model if model is undeployed.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [UndeployConversationModelOperationMetadata][google.cloud.dialogflow.v2.UndeployConversationModelOperationMetadata]
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, UndeployConversationModelOperationMetadata>> UndeployConversationModelAsync(UndeployConversationModelRequest request, st::CancellationToken cancellationToken) =>
            UndeployConversationModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UndeployConversationModel</c>.</summary>
        public virtual lro::OperationsClient UndeployConversationModelOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UndeployConversationModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, UndeployConversationModelOperationMetadata> PollOnceUndeployConversationModel(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, UndeployConversationModelOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UndeployConversationModelOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UndeployConversationModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, UndeployConversationModelOperationMetadata>> PollOnceUndeployConversationModelAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, UndeployConversationModelOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UndeployConversationModelOperationsClient, callSettings);

        /// <summary>
        /// Gets an evaluation of conversation model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConversationModelEvaluation GetConversationModelEvaluation(GetConversationModelEvaluationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an evaluation of conversation model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversationModelEvaluation> GetConversationModelEvaluationAsync(GetConversationModelEvaluationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an evaluation of conversation model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversationModelEvaluation> GetConversationModelEvaluationAsync(GetConversationModelEvaluationRequest request, st::CancellationToken cancellationToken) =>
            GetConversationModelEvaluationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an evaluation of conversation model.
        /// </summary>
        /// <param name="name">
        /// Required. The conversation model evaluation resource name. Format:
        /// `projects/&lt;Project ID&gt;/conversationModels/&lt;Conversation Model
        /// ID&gt;/evaluations/&lt;Evaluation ID&gt;`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConversationModelEvaluation GetConversationModelEvaluation(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConversationModelEvaluation(new GetConversationModelEvaluationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an evaluation of conversation model.
        /// </summary>
        /// <param name="name">
        /// Required. The conversation model evaluation resource name. Format:
        /// `projects/&lt;Project ID&gt;/conversationModels/&lt;Conversation Model
        /// ID&gt;/evaluations/&lt;Evaluation ID&gt;`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversationModelEvaluation> GetConversationModelEvaluationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConversationModelEvaluationAsync(new GetConversationModelEvaluationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an evaluation of conversation model.
        /// </summary>
        /// <param name="name">
        /// Required. The conversation model evaluation resource name. Format:
        /// `projects/&lt;Project ID&gt;/conversationModels/&lt;Conversation Model
        /// ID&gt;/evaluations/&lt;Evaluation ID&gt;`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversationModelEvaluation> GetConversationModelEvaluationAsync(string name, st::CancellationToken cancellationToken) =>
            GetConversationModelEvaluationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists evaluations of a conversation model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ConversationModelEvaluation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConversationModelEvaluationsResponse, ConversationModelEvaluation> ListConversationModelEvaluations(ListConversationModelEvaluationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists evaluations of a conversation model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ConversationModelEvaluation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConversationModelEvaluationsResponse, ConversationModelEvaluation> ListConversationModelEvaluationsAsync(ListConversationModelEvaluationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists evaluations of a conversation model.
        /// </summary>
        /// <param name="parent">
        /// Required. The conversation model resource name. Format:
        /// `projects/&lt;Project ID&gt;/conversationModels/&lt;Conversation Model ID&gt;`
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
        /// <returns>A pageable sequence of <see cref="ConversationModelEvaluation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConversationModelEvaluationsResponse, ConversationModelEvaluation> ListConversationModelEvaluations(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConversationModelEvaluationsRequest request = new ListConversationModelEvaluationsRequest
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
            return ListConversationModelEvaluations(request, callSettings);
        }

        /// <summary>
        /// Lists evaluations of a conversation model.
        /// </summary>
        /// <param name="parent">
        /// Required. The conversation model resource name. Format:
        /// `projects/&lt;Project ID&gt;/conversationModels/&lt;Conversation Model ID&gt;`
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
        /// <returns>A pageable asynchronous sequence of <see cref="ConversationModelEvaluation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConversationModelEvaluationsResponse, ConversationModelEvaluation> ListConversationModelEvaluationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConversationModelEvaluationsRequest request = new ListConversationModelEvaluationsRequest
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
            return ListConversationModelEvaluationsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates evaluation of a conversation model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConversationModelEvaluation, CreateConversationModelEvaluationOperationMetadata> CreateConversationModelEvaluation(CreateConversationModelEvaluationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates evaluation of a conversation model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConversationModelEvaluation, CreateConversationModelEvaluationOperationMetadata>> CreateConversationModelEvaluationAsync(CreateConversationModelEvaluationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates evaluation of a conversation model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConversationModelEvaluation, CreateConversationModelEvaluationOperationMetadata>> CreateConversationModelEvaluationAsync(CreateConversationModelEvaluationRequest request, st::CancellationToken cancellationToken) =>
            CreateConversationModelEvaluationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateConversationModelEvaluation</c>.</summary>
        public virtual lro::OperationsClient CreateConversationModelEvaluationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateConversationModelEvaluation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ConversationModelEvaluation, CreateConversationModelEvaluationOperationMetadata> PollOnceCreateConversationModelEvaluation(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ConversationModelEvaluation, CreateConversationModelEvaluationOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateConversationModelEvaluationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateConversationModelEvaluation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ConversationModelEvaluation, CreateConversationModelEvaluationOperationMetadata>> PollOnceCreateConversationModelEvaluationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ConversationModelEvaluation, CreateConversationModelEvaluationOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateConversationModelEvaluationOperationsClient, callSettings);

        /// <summary>
        /// Creates evaluation of a conversation model.
        /// </summary>
        /// <param name="parent">
        /// Required. The conversation model resource name. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversationModels/&lt;Conversation Model ID&gt;`
        /// </param>
        /// <param name="conversationModelEvaluation">
        /// Required. The conversation model evaluation to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConversationModelEvaluation, CreateConversationModelEvaluationOperationMetadata> CreateConversationModelEvaluation(string parent, ConversationModelEvaluation conversationModelEvaluation, gaxgrpc::CallSettings callSettings = null) =>
            CreateConversationModelEvaluation(new CreateConversationModelEvaluationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ConversationModelEvaluation = gax::GaxPreconditions.CheckNotNull(conversationModelEvaluation, nameof(conversationModelEvaluation)),
            }, callSettings);

        /// <summary>
        /// Creates evaluation of a conversation model.
        /// </summary>
        /// <param name="parent">
        /// Required. The conversation model resource name. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversationModels/&lt;Conversation Model ID&gt;`
        /// </param>
        /// <param name="conversationModelEvaluation">
        /// Required. The conversation model evaluation to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConversationModelEvaluation, CreateConversationModelEvaluationOperationMetadata>> CreateConversationModelEvaluationAsync(string parent, ConversationModelEvaluation conversationModelEvaluation, gaxgrpc::CallSettings callSettings = null) =>
            CreateConversationModelEvaluationAsync(new CreateConversationModelEvaluationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ConversationModelEvaluation = gax::GaxPreconditions.CheckNotNull(conversationModelEvaluation, nameof(conversationModelEvaluation)),
            }, callSettings);

        /// <summary>
        /// Creates evaluation of a conversation model.
        /// </summary>
        /// <param name="parent">
        /// Required. The conversation model resource name. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversationModels/&lt;Conversation Model ID&gt;`
        /// </param>
        /// <param name="conversationModelEvaluation">
        /// Required. The conversation model evaluation to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConversationModelEvaluation, CreateConversationModelEvaluationOperationMetadata>> CreateConversationModelEvaluationAsync(string parent, ConversationModelEvaluation conversationModelEvaluation, st::CancellationToken cancellationToken) =>
            CreateConversationModelEvaluationAsync(parent, conversationModelEvaluation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates evaluation of a conversation model.
        /// </summary>
        /// <param name="parent">
        /// Required. The conversation model resource name. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversationModels/&lt;Conversation Model ID&gt;`
        /// </param>
        /// <param name="conversationModelEvaluation">
        /// Required. The conversation model evaluation to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConversationModelEvaluation, CreateConversationModelEvaluationOperationMetadata> CreateConversationModelEvaluation(ConversationModelName parent, ConversationModelEvaluation conversationModelEvaluation, gaxgrpc::CallSettings callSettings = null) =>
            CreateConversationModelEvaluation(new CreateConversationModelEvaluationRequest
            {
                ParentAsConversationModelName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ConversationModelEvaluation = gax::GaxPreconditions.CheckNotNull(conversationModelEvaluation, nameof(conversationModelEvaluation)),
            }, callSettings);

        /// <summary>
        /// Creates evaluation of a conversation model.
        /// </summary>
        /// <param name="parent">
        /// Required. The conversation model resource name. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversationModels/&lt;Conversation Model ID&gt;`
        /// </param>
        /// <param name="conversationModelEvaluation">
        /// Required. The conversation model evaluation to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConversationModelEvaluation, CreateConversationModelEvaluationOperationMetadata>> CreateConversationModelEvaluationAsync(ConversationModelName parent, ConversationModelEvaluation conversationModelEvaluation, gaxgrpc::CallSettings callSettings = null) =>
            CreateConversationModelEvaluationAsync(new CreateConversationModelEvaluationRequest
            {
                ParentAsConversationModelName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ConversationModelEvaluation = gax::GaxPreconditions.CheckNotNull(conversationModelEvaluation, nameof(conversationModelEvaluation)),
            }, callSettings);

        /// <summary>
        /// Creates evaluation of a conversation model.
        /// </summary>
        /// <param name="parent">
        /// Required. The conversation model resource name. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversationModels/&lt;Conversation Model ID&gt;`
        /// </param>
        /// <param name="conversationModelEvaluation">
        /// Required. The conversation model evaluation to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConversationModelEvaluation, CreateConversationModelEvaluationOperationMetadata>> CreateConversationModelEvaluationAsync(ConversationModelName parent, ConversationModelEvaluation conversationModelEvaluation, st::CancellationToken cancellationToken) =>
            CreateConversationModelEvaluationAsync(parent, conversationModelEvaluation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ConversationModels client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Manages a collection of models for human agent assistant.
    /// </remarks>
    public sealed partial class ConversationModelsClientImpl : ConversationModelsClient
    {
        private readonly gaxgrpc::ApiCall<CreateConversationModelRequest, lro::Operation> _callCreateConversationModel;

        private readonly gaxgrpc::ApiCall<GetConversationModelRequest, ConversationModel> _callGetConversationModel;

        private readonly gaxgrpc::ApiCall<ListConversationModelsRequest, ListConversationModelsResponse> _callListConversationModels;

        private readonly gaxgrpc::ApiCall<DeleteConversationModelRequest, lro::Operation> _callDeleteConversationModel;

        private readonly gaxgrpc::ApiCall<DeployConversationModelRequest, lro::Operation> _callDeployConversationModel;

        private readonly gaxgrpc::ApiCall<UndeployConversationModelRequest, lro::Operation> _callUndeployConversationModel;

        private readonly gaxgrpc::ApiCall<GetConversationModelEvaluationRequest, ConversationModelEvaluation> _callGetConversationModelEvaluation;

        private readonly gaxgrpc::ApiCall<ListConversationModelEvaluationsRequest, ListConversationModelEvaluationsResponse> _callListConversationModelEvaluations;

        private readonly gaxgrpc::ApiCall<CreateConversationModelEvaluationRequest, lro::Operation> _callCreateConversationModelEvaluation;

        /// <summary>
        /// Constructs a client wrapper for the ConversationModels service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ConversationModelsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ConversationModelsClientImpl(ConversationModels.ConversationModelsClient grpcClient, ConversationModelsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ConversationModelsSettings effectiveSettings = settings ?? ConversationModelsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateConversationModelOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateConversationModelOperationsSettings, logger);
            DeleteConversationModelOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteConversationModelOperationsSettings, logger);
            DeployConversationModelOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeployConversationModelOperationsSettings, logger);
            UndeployConversationModelOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UndeployConversationModelOperationsSettings, logger);
            CreateConversationModelEvaluationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateConversationModelEvaluationOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callCreateConversationModel = clientHelper.BuildApiCall<CreateConversationModelRequest, lro::Operation>("CreateConversationModel", grpcClient.CreateConversationModelAsync, grpcClient.CreateConversationModel, effectiveSettings.CreateConversationModelSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateConversationModel);
            Modify_CreateConversationModelApiCall(ref _callCreateConversationModel);
            _callGetConversationModel = clientHelper.BuildApiCall<GetConversationModelRequest, ConversationModel>("GetConversationModel", grpcClient.GetConversationModelAsync, grpcClient.GetConversationModel, effectiveSettings.GetConversationModelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetConversationModel);
            Modify_GetConversationModelApiCall(ref _callGetConversationModel);
            _callListConversationModels = clientHelper.BuildApiCall<ListConversationModelsRequest, ListConversationModelsResponse>("ListConversationModels", grpcClient.ListConversationModelsAsync, grpcClient.ListConversationModels, effectiveSettings.ListConversationModelsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListConversationModels);
            Modify_ListConversationModelsApiCall(ref _callListConversationModels);
            _callDeleteConversationModel = clientHelper.BuildApiCall<DeleteConversationModelRequest, lro::Operation>("DeleteConversationModel", grpcClient.DeleteConversationModelAsync, grpcClient.DeleteConversationModel, effectiveSettings.DeleteConversationModelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteConversationModel);
            Modify_DeleteConversationModelApiCall(ref _callDeleteConversationModel);
            _callDeployConversationModel = clientHelper.BuildApiCall<DeployConversationModelRequest, lro::Operation>("DeployConversationModel", grpcClient.DeployConversationModelAsync, grpcClient.DeployConversationModel, effectiveSettings.DeployConversationModelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeployConversationModel);
            Modify_DeployConversationModelApiCall(ref _callDeployConversationModel);
            _callUndeployConversationModel = clientHelper.BuildApiCall<UndeployConversationModelRequest, lro::Operation>("UndeployConversationModel", grpcClient.UndeployConversationModelAsync, grpcClient.UndeployConversationModel, effectiveSettings.UndeployConversationModelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUndeployConversationModel);
            Modify_UndeployConversationModelApiCall(ref _callUndeployConversationModel);
            _callGetConversationModelEvaluation = clientHelper.BuildApiCall<GetConversationModelEvaluationRequest, ConversationModelEvaluation>("GetConversationModelEvaluation", grpcClient.GetConversationModelEvaluationAsync, grpcClient.GetConversationModelEvaluation, effectiveSettings.GetConversationModelEvaluationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetConversationModelEvaluation);
            Modify_GetConversationModelEvaluationApiCall(ref _callGetConversationModelEvaluation);
            _callListConversationModelEvaluations = clientHelper.BuildApiCall<ListConversationModelEvaluationsRequest, ListConversationModelEvaluationsResponse>("ListConversationModelEvaluations", grpcClient.ListConversationModelEvaluationsAsync, grpcClient.ListConversationModelEvaluations, effectiveSettings.ListConversationModelEvaluationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListConversationModelEvaluations);
            Modify_ListConversationModelEvaluationsApiCall(ref _callListConversationModelEvaluations);
            _callCreateConversationModelEvaluation = clientHelper.BuildApiCall<CreateConversationModelEvaluationRequest, lro::Operation>("CreateConversationModelEvaluation", grpcClient.CreateConversationModelEvaluationAsync, grpcClient.CreateConversationModelEvaluation, effectiveSettings.CreateConversationModelEvaluationSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateConversationModelEvaluation);
            Modify_CreateConversationModelEvaluationApiCall(ref _callCreateConversationModelEvaluation);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateConversationModelApiCall(ref gaxgrpc::ApiCall<CreateConversationModelRequest, lro::Operation> call);

        partial void Modify_GetConversationModelApiCall(ref gaxgrpc::ApiCall<GetConversationModelRequest, ConversationModel> call);

        partial void Modify_ListConversationModelsApiCall(ref gaxgrpc::ApiCall<ListConversationModelsRequest, ListConversationModelsResponse> call);

        partial void Modify_DeleteConversationModelApiCall(ref gaxgrpc::ApiCall<DeleteConversationModelRequest, lro::Operation> call);

        partial void Modify_DeployConversationModelApiCall(ref gaxgrpc::ApiCall<DeployConversationModelRequest, lro::Operation> call);

        partial void Modify_UndeployConversationModelApiCall(ref gaxgrpc::ApiCall<UndeployConversationModelRequest, lro::Operation> call);

        partial void Modify_GetConversationModelEvaluationApiCall(ref gaxgrpc::ApiCall<GetConversationModelEvaluationRequest, ConversationModelEvaluation> call);

        partial void Modify_ListConversationModelEvaluationsApiCall(ref gaxgrpc::ApiCall<ListConversationModelEvaluationsRequest, ListConversationModelEvaluationsResponse> call);

        partial void Modify_CreateConversationModelEvaluationApiCall(ref gaxgrpc::ApiCall<CreateConversationModelEvaluationRequest, lro::Operation> call);

        partial void OnConstruction(ConversationModels.ConversationModelsClient grpcClient, ConversationModelsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ConversationModels client</summary>
        public override ConversationModels.ConversationModelsClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_CreateConversationModelRequest(ref CreateConversationModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetConversationModelRequest(ref GetConversationModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListConversationModelsRequest(ref ListConversationModelsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteConversationModelRequest(ref DeleteConversationModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeployConversationModelRequest(ref DeployConversationModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UndeployConversationModelRequest(ref UndeployConversationModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetConversationModelEvaluationRequest(ref GetConversationModelEvaluationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListConversationModelEvaluationsRequest(ref ListConversationModelEvaluationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateConversationModelEvaluationRequest(ref CreateConversationModelEvaluationRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateConversationModel</c>.</summary>
        public override lro::OperationsClient CreateConversationModelOperationsClient { get; }

        /// <summary>
        /// Creates a model.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [CreateConversationModelOperationMetadata][google.cloud.dialogflow.v2.CreateConversationModelOperationMetadata]
        /// - `response`:
        /// [ConversationModel][google.cloud.dialogflow.v2.ConversationModel]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ConversationModel, CreateConversationModelOperationMetadata> CreateConversationModel(CreateConversationModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateConversationModelRequest(ref request, ref callSettings);
            return new lro::Operation<ConversationModel, CreateConversationModelOperationMetadata>(_callCreateConversationModel.Sync(request, callSettings), CreateConversationModelOperationsClient);
        }

        /// <summary>
        /// Creates a model.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [CreateConversationModelOperationMetadata][google.cloud.dialogflow.v2.CreateConversationModelOperationMetadata]
        /// - `response`:
        /// [ConversationModel][google.cloud.dialogflow.v2.ConversationModel]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ConversationModel, CreateConversationModelOperationMetadata>> CreateConversationModelAsync(CreateConversationModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateConversationModelRequest(ref request, ref callSettings);
            return new lro::Operation<ConversationModel, CreateConversationModelOperationMetadata>(await _callCreateConversationModel.Async(request, callSettings).ConfigureAwait(false), CreateConversationModelOperationsClient);
        }

        /// <summary>
        /// Gets conversation model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ConversationModel GetConversationModel(GetConversationModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConversationModelRequest(ref request, ref callSettings);
            return _callGetConversationModel.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets conversation model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ConversationModel> GetConversationModelAsync(GetConversationModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConversationModelRequest(ref request, ref callSettings);
            return _callGetConversationModel.Async(request, callSettings);
        }

        /// <summary>
        /// Lists conversation models.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ConversationModel"/> resources.</returns>
        public override gax::PagedEnumerable<ListConversationModelsResponse, ConversationModel> ListConversationModels(ListConversationModelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConversationModelsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListConversationModelsRequest, ListConversationModelsResponse, ConversationModel>(_callListConversationModels, request, callSettings);
        }

        /// <summary>
        /// Lists conversation models.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ConversationModel"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListConversationModelsResponse, ConversationModel> ListConversationModelsAsync(ListConversationModelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConversationModelsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListConversationModelsRequest, ListConversationModelsResponse, ConversationModel>(_callListConversationModels, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteConversationModel</c>.</summary>
        public override lro::OperationsClient DeleteConversationModelOperationsClient { get; }

        /// <summary>
        /// Deletes a model.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [DeleteConversationModelOperationMetadata][google.cloud.dialogflow.v2.DeleteConversationModelOperationMetadata]
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteConversationModelOperationMetadata> DeleteConversationModel(DeleteConversationModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteConversationModelRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteConversationModelOperationMetadata>(_callDeleteConversationModel.Sync(request, callSettings), DeleteConversationModelOperationsClient);
        }

        /// <summary>
        /// Deletes a model.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [DeleteConversationModelOperationMetadata][google.cloud.dialogflow.v2.DeleteConversationModelOperationMetadata]
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteConversationModelOperationMetadata>> DeleteConversationModelAsync(DeleteConversationModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteConversationModelRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteConversationModelOperationMetadata>(await _callDeleteConversationModel.Async(request, callSettings).ConfigureAwait(false), DeleteConversationModelOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeployConversationModel</c>.</summary>
        public override lro::OperationsClient DeployConversationModelOperationsClient { get; }

        /// <summary>
        /// Deploys a model. If a model is already deployed, deploying it
        /// has no effect. A model can only serve prediction requests after it gets
        /// deployed. For article suggestion, custom model will not be used unless
        /// it is deployed.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [DeployConversationModelOperationMetadata][google.cloud.dialogflow.v2.DeployConversationModelOperationMetadata]
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeployConversationModelOperationMetadata> DeployConversationModel(DeployConversationModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeployConversationModelRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeployConversationModelOperationMetadata>(_callDeployConversationModel.Sync(request, callSettings), DeployConversationModelOperationsClient);
        }

        /// <summary>
        /// Deploys a model. If a model is already deployed, deploying it
        /// has no effect. A model can only serve prediction requests after it gets
        /// deployed. For article suggestion, custom model will not be used unless
        /// it is deployed.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [DeployConversationModelOperationMetadata][google.cloud.dialogflow.v2.DeployConversationModelOperationMetadata]
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeployConversationModelOperationMetadata>> DeployConversationModelAsync(DeployConversationModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeployConversationModelRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeployConversationModelOperationMetadata>(await _callDeployConversationModel.Async(request, callSettings).ConfigureAwait(false), DeployConversationModelOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UndeployConversationModel</c>.</summary>
        public override lro::OperationsClient UndeployConversationModelOperationsClient { get; }

        /// <summary>
        /// Undeploys a model. If the model is not deployed this method has no effect.
        /// If the model is currently being used:
        /// - For article suggestion, article suggestion will fallback to the default
        /// model if model is undeployed.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [UndeployConversationModelOperationMetadata][google.cloud.dialogflow.v2.UndeployConversationModelOperationMetadata]
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, UndeployConversationModelOperationMetadata> UndeployConversationModel(UndeployConversationModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeployConversationModelRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, UndeployConversationModelOperationMetadata>(_callUndeployConversationModel.Sync(request, callSettings), UndeployConversationModelOperationsClient);
        }

        /// <summary>
        /// Undeploys a model. If the model is not deployed this method has no effect.
        /// If the model is currently being used:
        /// - For article suggestion, article suggestion will fallback to the default
        /// model if model is undeployed.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [UndeployConversationModelOperationMetadata][google.cloud.dialogflow.v2.UndeployConversationModelOperationMetadata]
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, UndeployConversationModelOperationMetadata>> UndeployConversationModelAsync(UndeployConversationModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeployConversationModelRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, UndeployConversationModelOperationMetadata>(await _callUndeployConversationModel.Async(request, callSettings).ConfigureAwait(false), UndeployConversationModelOperationsClient);
        }

        /// <summary>
        /// Gets an evaluation of conversation model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ConversationModelEvaluation GetConversationModelEvaluation(GetConversationModelEvaluationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConversationModelEvaluationRequest(ref request, ref callSettings);
            return _callGetConversationModelEvaluation.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an evaluation of conversation model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ConversationModelEvaluation> GetConversationModelEvaluationAsync(GetConversationModelEvaluationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConversationModelEvaluationRequest(ref request, ref callSettings);
            return _callGetConversationModelEvaluation.Async(request, callSettings);
        }

        /// <summary>
        /// Lists evaluations of a conversation model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ConversationModelEvaluation"/> resources.</returns>
        public override gax::PagedEnumerable<ListConversationModelEvaluationsResponse, ConversationModelEvaluation> ListConversationModelEvaluations(ListConversationModelEvaluationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConversationModelEvaluationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListConversationModelEvaluationsRequest, ListConversationModelEvaluationsResponse, ConversationModelEvaluation>(_callListConversationModelEvaluations, request, callSettings);
        }

        /// <summary>
        /// Lists evaluations of a conversation model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ConversationModelEvaluation"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListConversationModelEvaluationsResponse, ConversationModelEvaluation> ListConversationModelEvaluationsAsync(ListConversationModelEvaluationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConversationModelEvaluationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListConversationModelEvaluationsRequest, ListConversationModelEvaluationsResponse, ConversationModelEvaluation>(_callListConversationModelEvaluations, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateConversationModelEvaluation</c>.</summary>
        public override lro::OperationsClient CreateConversationModelEvaluationOperationsClient { get; }

        /// <summary>
        /// Creates evaluation of a conversation model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ConversationModelEvaluation, CreateConversationModelEvaluationOperationMetadata> CreateConversationModelEvaluation(CreateConversationModelEvaluationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateConversationModelEvaluationRequest(ref request, ref callSettings);
            return new lro::Operation<ConversationModelEvaluation, CreateConversationModelEvaluationOperationMetadata>(_callCreateConversationModelEvaluation.Sync(request, callSettings), CreateConversationModelEvaluationOperationsClient);
        }

        /// <summary>
        /// Creates evaluation of a conversation model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ConversationModelEvaluation, CreateConversationModelEvaluationOperationMetadata>> CreateConversationModelEvaluationAsync(CreateConversationModelEvaluationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateConversationModelEvaluationRequest(ref request, ref callSettings);
            return new lro::Operation<ConversationModelEvaluation, CreateConversationModelEvaluationOperationMetadata>(await _callCreateConversationModelEvaluation.Async(request, callSettings).ConfigureAwait(false), CreateConversationModelEvaluationOperationsClient);
        }
    }

    public partial class ListConversationModelsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListConversationModelEvaluationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListConversationModelsResponse : gaxgrpc::IPageResponse<ConversationModel>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ConversationModel> GetEnumerator() => ConversationModels.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListConversationModelEvaluationsResponse : gaxgrpc::IPageResponse<ConversationModelEvaluation>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ConversationModelEvaluation> GetEnumerator() =>
            ConversationModelEvaluations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class ConversationModels
    {
        public partial class ConversationModelsClient
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

    public static partial class ConversationModels
    {
        public partial class ConversationModelsClient
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
