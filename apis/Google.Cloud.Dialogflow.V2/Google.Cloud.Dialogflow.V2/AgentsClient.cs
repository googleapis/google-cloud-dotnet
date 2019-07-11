// Copyright 2019 Google LLC
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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gaxres = Google.Api.Gax.ResourceNames;
using lro = Google.LongRunning;
using pb = Google.Protobuf;
using pbwkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Dialogflow.V2
{
    /// <summary>
    /// Settings for a <see cref="AgentsClient"/>.
    /// </summary>
    public sealed partial class AgentsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="AgentsSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="AgentsSettings"/>.
        /// </returns>
        public static AgentsSettings GetDefault() => new AgentsSettings();

        /// <summary>
        /// Constructs a new <see cref="AgentsSettings"/> object with default settings.
        /// </summary>
        public AgentsSettings() { }

        private AgentsSettings(AgentsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            SetAgentSettings = existing.SetAgentSettings;
            DeleteAgentSettings = existing.DeleteAgentSettings;
            GetAgentSettings = existing.GetAgentSettings;
            SearchAgentsSettings = existing.SearchAgentsSettings;
            TrainAgentSettings = existing.TrainAgentSettings;
            TrainAgentOperationsSettings = existing.TrainAgentOperationsSettings?.Clone();
            ExportAgentSettings = existing.ExportAgentSettings;
            ExportAgentOperationsSettings = existing.ExportAgentOperationsSettings?.Clone();
            ImportAgentSettings = existing.ImportAgentSettings;
            ImportAgentOperationsSettings = existing.ImportAgentOperationsSettings?.Clone();
            RestoreAgentSettings = existing.RestoreAgentSettings;
            RestoreAgentOperationsSettings = existing.RestoreAgentOperationsSettings?.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(AgentsSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="AgentsClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="grpccore::StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> IdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="AgentsClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="AgentsClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="AgentsClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="AgentsClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultRetryBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(100),
            maxDelay: sys::TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "Default" timeout backoff for <see cref="AgentsClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="AgentsClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="AgentsClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 20000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(20000),
            maxDelay: sys::TimeSpan.FromMilliseconds(20000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentsClient.SetAgent</c> and <c>AgentsClient.SetAgentAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>AgentsClient.SetAgent</c> and
        /// <c>AgentsClient.SetAgentAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings SetAgentSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentsClient.DeleteAgent</c> and <c>AgentsClient.DeleteAgentAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>AgentsClient.DeleteAgent</c> and
        /// <c>AgentsClient.DeleteAgentAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAgentSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentsClient.GetAgent</c> and <c>AgentsClient.GetAgentAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>AgentsClient.GetAgent</c> and
        /// <c>AgentsClient.GetAgentAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings GetAgentSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentsClient.SearchAgents</c> and <c>AgentsClient.SearchAgentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>AgentsClient.SearchAgents</c> and
        /// <c>AgentsClient.SearchAgentsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings SearchAgentsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentsClient.TrainAgent</c> and <c>AgentsClient.TrainAgentAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>AgentsClient.TrainAgent</c> and
        /// <c>AgentsClient.TrainAgentAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings TrainAgentSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AgentsClient.TrainAgent</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 500 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 5000 milliseconds</description></item>
        /// <item><description>Total timeout: 300000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings TrainAgentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(
                gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000L)),
                sys::TimeSpan.FromMilliseconds(500L),
                1.5,
                sys::TimeSpan.FromMilliseconds(5000L))
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentsClient.ExportAgent</c> and <c>AgentsClient.ExportAgentAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>AgentsClient.ExportAgent</c> and
        /// <c>AgentsClient.ExportAgentAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ExportAgentSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AgentsClient.ExportAgent</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 500 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 5000 milliseconds</description></item>
        /// <item><description>Total timeout: 300000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings ExportAgentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(
                gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000L)),
                sys::TimeSpan.FromMilliseconds(500L),
                1.5,
                sys::TimeSpan.FromMilliseconds(5000L))
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentsClient.ImportAgent</c> and <c>AgentsClient.ImportAgentAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>AgentsClient.ImportAgent</c> and
        /// <c>AgentsClient.ImportAgentAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ImportAgentSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AgentsClient.ImportAgent</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 500 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 5000 milliseconds</description></item>
        /// <item><description>Total timeout: 300000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings ImportAgentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(
                gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000L)),
                sys::TimeSpan.FromMilliseconds(500L),
                1.5,
                sys::TimeSpan.FromMilliseconds(5000L))
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentsClient.RestoreAgent</c> and <c>AgentsClient.RestoreAgentAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>AgentsClient.RestoreAgent</c> and
        /// <c>AgentsClient.RestoreAgentAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings RestoreAgentSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AgentsClient.RestoreAgent</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 500 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 5000 milliseconds</description></item>
        /// <item><description>Total timeout: 300000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings RestoreAgentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(
                gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000L)),
                sys::TimeSpan.FromMilliseconds(500L),
                1.5,
                sys::TimeSpan.FromMilliseconds(5000L))
        };

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="AgentsSettings"/> object.</returns>
        public AgentsSettings Clone() => new AgentsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AgentsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class AgentsClientBuilder : gaxgrpc::ClientBuilderBase<AgentsClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public AgentsSettings Settings { get; set; }

        /// <inheritdoc/>
        public override AgentsClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AgentsClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<AgentsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AgentsClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => AgentsClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => AgentsClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => AgentsClient.ChannelPool;
    }

    /// <summary>
    /// Agents client wrapper, for convenient use.
    /// </summary>
    public abstract partial class AgentsClient
    {
        /// <summary>
        /// The default endpoint for the Agents service, which is a host of "dialogflow.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("dialogflow.googleapis.com", 443);

        /// <summary>
        /// The default Agents scopes.
        /// </summary>
        /// <remarks>
        /// The default Agents scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/dialogflow"</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/dialogflow",
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="AgentsClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Dialogflow.V2;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// AgentsClient client = await AgentsClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Dialogflow.V2;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     AgentsClient.DefaultEndpoint.Host, AgentsClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// AgentsClient client = AgentsClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="AgentsSettings"/>.</param>
        /// <returns>The task representing the created <see cref="AgentsClient"/>.</returns>
        public static async stt::Task<AgentsClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, AgentsSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="AgentsClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Dialogflow.V2;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// AgentsClient client = AgentsClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Dialogflow.V2;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     AgentsClient.DefaultEndpoint.Host, AgentsClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// AgentsClient client = AgentsClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="AgentsSettings"/>.</param>
        /// <returns>The created <see cref="AgentsClient"/>.</returns>
        public static AgentsClient Create(gaxgrpc::ServiceEndpoint endpoint = null, AgentsSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="AgentsClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="AgentsSettings"/>.</param>
        /// <returns>The created <see cref="AgentsClient"/>.</returns>
        public static AgentsClient Create(grpccore::Channel channel, AgentsSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="AgentsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="AgentsSettings"/>.</param>
        /// <returns>The created <see cref="AgentsClient"/>.</returns>
        public static AgentsClient Create(grpccore::CallInvoker callInvoker, AgentsSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Agents.AgentsClient grpcClient = new Agents.AgentsClient(callInvoker);
            return new AgentsClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, AgentsSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, AgentsSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, AgentsSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, AgentsSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC Agents client.
        /// </summary>
        public virtual Agents.AgentsClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Creates/updates the specified agent.
        /// </summary>
        /// <param name="agent">
        /// Required. The agent to update.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Agent> SetAgentAsync(
            Agent agent,
            gaxgrpc::CallSettings callSettings = null) => SetAgentAsync(
                new SetAgentRequest
                {
                    Agent = gax::GaxPreconditions.CheckNotNull(agent, nameof(agent)),
                },
                callSettings);

        /// <summary>
        /// Creates/updates the specified agent.
        /// </summary>
        /// <param name="agent">
        /// Required. The agent to update.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Agent> SetAgentAsync(
            Agent agent,
            st::CancellationToken cancellationToken) => SetAgentAsync(
                agent,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates/updates the specified agent.
        /// </summary>
        /// <param name="agent">
        /// Required. The agent to update.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Agent SetAgent(
            Agent agent,
            gaxgrpc::CallSettings callSettings = null) => SetAgent(
                new SetAgentRequest
                {
                    Agent = gax::GaxPreconditions.CheckNotNull(agent, nameof(agent)),
                },
                callSettings);

        /// <summary>
        /// Creates/updates the specified agent.
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
        public virtual stt::Task<Agent> SetAgentAsync(
            SetAgentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates/updates the specified agent.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Agent> SetAgentAsync(
            SetAgentRequest request,
            st::CancellationToken cancellationToken) => SetAgentAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates/updates the specified agent.
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
        public virtual Agent SetAgent(
            SetAgentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to delete is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteAgentAsync(
            gaxres::ProjectName parent,
            gaxgrpc::CallSettings callSettings = null) => DeleteAgentAsync(
                new DeleteAgentRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                },
                callSettings);

        /// <summary>
        /// Deletes the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to delete is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteAgentAsync(
            gaxres::ProjectName parent,
            st::CancellationToken cancellationToken) => DeleteAgentAsync(
                parent,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to delete is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteAgent(
            gaxres::ProjectName parent,
            gaxgrpc::CallSettings callSettings = null) => DeleteAgent(
                new DeleteAgentRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                },
                callSettings);

        /// <summary>
        /// Deletes the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to delete is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteAgentAsync(
            string parent,
            gaxgrpc::CallSettings callSettings = null) => DeleteAgentAsync(
                new DeleteAgentRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                },
                callSettings);

        /// <summary>
        /// Deletes the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to delete is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteAgentAsync(
            string parent,
            st::CancellationToken cancellationToken) => DeleteAgentAsync(
                parent,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to delete is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteAgent(
            string parent,
            gaxgrpc::CallSettings callSettings = null) => DeleteAgent(
                new DeleteAgentRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                },
                callSettings);

        /// <summary>
        /// Deletes the specified agent.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteAgentAsync(
            DeleteAgentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes the specified agent.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteAgentAsync(
            DeleteAgentRequest request,
            st::CancellationToken cancellationToken) => DeleteAgentAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified agent.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteAgent(
            DeleteAgentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Retrieves the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to fetch is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Agent> GetAgentAsync(
            gaxres::ProjectName parent,
            gaxgrpc::CallSettings callSettings = null) => GetAgentAsync(
                new GetAgentRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                },
                callSettings);

        /// <summary>
        /// Retrieves the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to fetch is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Agent> GetAgentAsync(
            gaxres::ProjectName parent,
            st::CancellationToken cancellationToken) => GetAgentAsync(
                parent,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to fetch is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Agent GetAgent(
            gaxres::ProjectName parent,
            gaxgrpc::CallSettings callSettings = null) => GetAgent(
                new GetAgentRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                },
                callSettings);

        /// <summary>
        /// Retrieves the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to fetch is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Agent> GetAgentAsync(
            string parent,
            gaxgrpc::CallSettings callSettings = null) => GetAgentAsync(
                new GetAgentRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                },
                callSettings);

        /// <summary>
        /// Retrieves the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to fetch is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Agent> GetAgentAsync(
            string parent,
            st::CancellationToken cancellationToken) => GetAgentAsync(
                parent,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to fetch is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Agent GetAgent(
            string parent,
            gaxgrpc::CallSettings callSettings = null) => GetAgent(
                new GetAgentRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                },
                callSettings);

        /// <summary>
        /// Retrieves the specified agent.
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
        public virtual stt::Task<Agent> GetAgentAsync(
            GetAgentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Retrieves the specified agent.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Agent> GetAgentAsync(
            GetAgentRequest request,
            st::CancellationToken cancellationToken) => GetAgentAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified agent.
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
        public virtual Agent GetAgent(
            GetAgentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns the list of agents.
        ///
        /// Since there is at most one conversational agent per project, this method is
        /// useful primarily for listing all agents across projects the caller has
        /// access to. One can achieve that with a wildcard project collection id "-".
        /// Refer to [List
        /// Sub-Collections](https://cloud.google.com/apis/design/design_patterns#list_sub-collections).
        /// </summary>
        /// <param name="parent">
        /// Required. The project to list agents from.
        /// Format: `projects/&lt;Project ID or '-'&gt;`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Agent"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<SearchAgentsResponse, Agent> SearchAgentsAsync(
            gaxres::ProjectName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => SearchAgentsAsync(
                new SearchAgentsRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns the list of agents.
        ///
        /// Since there is at most one conversational agent per project, this method is
        /// useful primarily for listing all agents across projects the caller has
        /// access to. One can achieve that with a wildcard project collection id "-".
        /// Refer to [List
        /// Sub-Collections](https://cloud.google.com/apis/design/design_patterns#list_sub-collections).
        /// </summary>
        /// <param name="parent">
        /// Required. The project to list agents from.
        /// Format: `projects/&lt;Project ID or '-'&gt;`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Agent"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<SearchAgentsResponse, Agent> SearchAgents(
            gaxres::ProjectName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => SearchAgents(
                new SearchAgentsRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns the list of agents.
        ///
        /// Since there is at most one conversational agent per project, this method is
        /// useful primarily for listing all agents across projects the caller has
        /// access to. One can achieve that with a wildcard project collection id "-".
        /// Refer to [List
        /// Sub-Collections](https://cloud.google.com/apis/design/design_patterns#list_sub-collections).
        /// </summary>
        /// <param name="parent">
        /// Required. The project to list agents from.
        /// Format: `projects/&lt;Project ID or '-'&gt;`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Agent"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<SearchAgentsResponse, Agent> SearchAgentsAsync(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => SearchAgentsAsync(
                new SearchAgentsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns the list of agents.
        ///
        /// Since there is at most one conversational agent per project, this method is
        /// useful primarily for listing all agents across projects the caller has
        /// access to. One can achieve that with a wildcard project collection id "-".
        /// Refer to [List
        /// Sub-Collections](https://cloud.google.com/apis/design/design_patterns#list_sub-collections).
        /// </summary>
        /// <param name="parent">
        /// Required. The project to list agents from.
        /// Format: `projects/&lt;Project ID or '-'&gt;`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Agent"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<SearchAgentsResponse, Agent> SearchAgents(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => SearchAgents(
                new SearchAgentsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns the list of agents.
        ///
        /// Since there is at most one conversational agent per project, this method is
        /// useful primarily for listing all agents across projects the caller has
        /// access to. One can achieve that with a wildcard project collection id "-".
        /// Refer to [List
        /// Sub-Collections](https://cloud.google.com/apis/design/design_patterns#list_sub-collections).
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Agent"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<SearchAgentsResponse, Agent> SearchAgentsAsync(
            SearchAgentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns the list of agents.
        ///
        /// Since there is at most one conversational agent per project, this method is
        /// useful primarily for listing all agents across projects the caller has
        /// access to. One can achieve that with a wildcard project collection id "-".
        /// Refer to [List
        /// Sub-Collections](https://cloud.google.com/apis/design/design_patterns#list_sub-collections).
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Agent"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<SearchAgentsResponse, Agent> SearchAgents(
            SearchAgentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Trains the specified agent.
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to train is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> TrainAgentAsync(
            gaxres::ProjectName parent,
            gaxgrpc::CallSettings callSettings = null) => TrainAgentAsync(
                new TrainAgentRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                },
                callSettings);

        /// <summary>
        /// Trains the specified agent.
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to train is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> TrainAgentAsync(
            gaxres::ProjectName parent,
            st::CancellationToken cancellationToken) => TrainAgentAsync(
                parent,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Trains the specified agent.
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to train is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<pbwkt::Empty, pbwkt::Struct> TrainAgent(
            gaxres::ProjectName parent,
            gaxgrpc::CallSettings callSettings = null) => TrainAgent(
                new TrainAgentRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                },
                callSettings);

        /// <summary>
        /// Trains the specified agent.
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to train is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> TrainAgentAsync(
            string parent,
            gaxgrpc::CallSettings callSettings = null) => TrainAgentAsync(
                new TrainAgentRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                },
                callSettings);

        /// <summary>
        /// Trains the specified agent.
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to train is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> TrainAgentAsync(
            string parent,
            st::CancellationToken cancellationToken) => TrainAgentAsync(
                parent,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Trains the specified agent.
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to train is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<pbwkt::Empty, pbwkt::Struct> TrainAgent(
            string parent,
            gaxgrpc::CallSettings callSettings = null) => TrainAgent(
                new TrainAgentRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                },
                callSettings);

        /// <summary>
        /// Trains the specified agent.
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
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
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> TrainAgentAsync(
            TrainAgentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>TrainAgentAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> PollOnceTrainAgentAsync(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<pbwkt::Empty, pbwkt::Struct>.PollOnceFromNameAsync(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                TrainAgentOperationsClient,
                callSettings);

        /// <summary>
        /// Trains the specified agent.
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
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
        public virtual lro::Operation<pbwkt::Empty, pbwkt::Struct> TrainAgent(
            TrainAgentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>TrainAgent</c>.
        /// </summary>
        public virtual lro::OperationsClient TrainAgentOperationsClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>TrainAgent</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<pbwkt::Empty, pbwkt::Struct> PollOnceTrainAgent(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<pbwkt::Empty, pbwkt::Struct>.PollOnceFromName(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                TrainAgentOperationsClient,
                callSettings);

        /// <summary>
        /// Exports the specified agent to a ZIP file.
        ///
        /// Operation &lt;response: [ExportAgentResponse][google.cloud.dialogflow.v2.ExportAgentResponse]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to export is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<ExportAgentResponse, pbwkt::Struct>> ExportAgentAsync(
            gaxres::ProjectName parent,
            gaxgrpc::CallSettings callSettings = null) => ExportAgentAsync(
                new ExportAgentRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                },
                callSettings);

        /// <summary>
        /// Exports the specified agent to a ZIP file.
        ///
        /// Operation &lt;response: [ExportAgentResponse][google.cloud.dialogflow.v2.ExportAgentResponse]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to export is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<ExportAgentResponse, pbwkt::Struct>> ExportAgentAsync(
            gaxres::ProjectName parent,
            st::CancellationToken cancellationToken) => ExportAgentAsync(
                parent,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports the specified agent to a ZIP file.
        ///
        /// Operation &lt;response: [ExportAgentResponse][google.cloud.dialogflow.v2.ExportAgentResponse]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to export is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<ExportAgentResponse, pbwkt::Struct> ExportAgent(
            gaxres::ProjectName parent,
            gaxgrpc::CallSettings callSettings = null) => ExportAgent(
                new ExportAgentRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                },
                callSettings);

        /// <summary>
        /// Exports the specified agent to a ZIP file.
        ///
        /// Operation &lt;response: [ExportAgentResponse][google.cloud.dialogflow.v2.ExportAgentResponse]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to export is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<ExportAgentResponse, pbwkt::Struct>> ExportAgentAsync(
            string parent,
            gaxgrpc::CallSettings callSettings = null) => ExportAgentAsync(
                new ExportAgentRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                },
                callSettings);

        /// <summary>
        /// Exports the specified agent to a ZIP file.
        ///
        /// Operation &lt;response: [ExportAgentResponse][google.cloud.dialogflow.v2.ExportAgentResponse]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to export is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<ExportAgentResponse, pbwkt::Struct>> ExportAgentAsync(
            string parent,
            st::CancellationToken cancellationToken) => ExportAgentAsync(
                parent,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports the specified agent to a ZIP file.
        ///
        /// Operation &lt;response: [ExportAgentResponse][google.cloud.dialogflow.v2.ExportAgentResponse]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to export is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<ExportAgentResponse, pbwkt::Struct> ExportAgent(
            string parent,
            gaxgrpc::CallSettings callSettings = null) => ExportAgent(
                new ExportAgentRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                },
                callSettings);

        /// <summary>
        /// Exports the specified agent to a ZIP file.
        ///
        /// Operation &lt;response: [ExportAgentResponse][google.cloud.dialogflow.v2.ExportAgentResponse]&gt;
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
        public virtual stt::Task<lro::Operation<ExportAgentResponse, pbwkt::Struct>> ExportAgentAsync(
            ExportAgentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ExportAgentAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ExportAgentResponse, pbwkt::Struct>> PollOnceExportAgentAsync(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<ExportAgentResponse, pbwkt::Struct>.PollOnceFromNameAsync(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                ExportAgentOperationsClient,
                callSettings);

        /// <summary>
        /// Exports the specified agent to a ZIP file.
        ///
        /// Operation &lt;response: [ExportAgentResponse][google.cloud.dialogflow.v2.ExportAgentResponse]&gt;
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
        public virtual lro::Operation<ExportAgentResponse, pbwkt::Struct> ExportAgent(
            ExportAgentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>ExportAgent</c>.
        /// </summary>
        public virtual lro::OperationsClient ExportAgentOperationsClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ExportAgent</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ExportAgentResponse, pbwkt::Struct> PollOnceExportAgent(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<ExportAgentResponse, pbwkt::Struct>.PollOnceFromName(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                ExportAgentOperationsClient,
                callSettings);

        /// <summary>
        /// Imports the specified agent from a ZIP file.
        ///
        /// Uploads new intents and entity types without deleting the existing ones.
        /// Intents and entity types with the same name are replaced with the new
        /// versions from ImportAgentRequest.
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
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
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> ImportAgentAsync(
            ImportAgentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ImportAgentAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> PollOnceImportAgentAsync(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<pbwkt::Empty, pbwkt::Struct>.PollOnceFromNameAsync(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                ImportAgentOperationsClient,
                callSettings);

        /// <summary>
        /// Imports the specified agent from a ZIP file.
        ///
        /// Uploads new intents and entity types without deleting the existing ones.
        /// Intents and entity types with the same name are replaced with the new
        /// versions from ImportAgentRequest.
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
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
        public virtual lro::Operation<pbwkt::Empty, pbwkt::Struct> ImportAgent(
            ImportAgentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>ImportAgent</c>.
        /// </summary>
        public virtual lro::OperationsClient ImportAgentOperationsClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ImportAgent</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<pbwkt::Empty, pbwkt::Struct> PollOnceImportAgent(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<pbwkt::Empty, pbwkt::Struct>.PollOnceFromName(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                ImportAgentOperationsClient,
                callSettings);

        /// <summary>
        /// Restores the specified agent from a ZIP file.
        ///
        /// Replaces the current agent version with a new one. All the intents and
        /// entity types in the older version are deleted.
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
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
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> RestoreAgentAsync(
            RestoreAgentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RestoreAgentAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> PollOnceRestoreAgentAsync(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<pbwkt::Empty, pbwkt::Struct>.PollOnceFromNameAsync(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                RestoreAgentOperationsClient,
                callSettings);

        /// <summary>
        /// Restores the specified agent from a ZIP file.
        ///
        /// Replaces the current agent version with a new one. All the intents and
        /// entity types in the older version are deleted.
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
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
        public virtual lro::Operation<pbwkt::Empty, pbwkt::Struct> RestoreAgent(
            RestoreAgentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>RestoreAgent</c>.
        /// </summary>
        public virtual lro::OperationsClient RestoreAgentOperationsClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RestoreAgent</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<pbwkt::Empty, pbwkt::Struct> PollOnceRestoreAgent(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<pbwkt::Empty, pbwkt::Struct>.PollOnceFromName(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                RestoreAgentOperationsClient,
                callSettings);

    }

    /// <summary>
    /// Agents client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class AgentsClientImpl : AgentsClient
    {
        private readonly gaxgrpc::ApiCall<SetAgentRequest, Agent> _callSetAgent;
        private readonly gaxgrpc::ApiCall<DeleteAgentRequest, pbwkt::Empty> _callDeleteAgent;
        private readonly gaxgrpc::ApiCall<GetAgentRequest, Agent> _callGetAgent;
        private readonly gaxgrpc::ApiCall<SearchAgentsRequest, SearchAgentsResponse> _callSearchAgents;
        private readonly gaxgrpc::ApiCall<TrainAgentRequest, lro::Operation> _callTrainAgent;
        private readonly gaxgrpc::ApiCall<ExportAgentRequest, lro::Operation> _callExportAgent;
        private readonly gaxgrpc::ApiCall<ImportAgentRequest, lro::Operation> _callImportAgent;
        private readonly gaxgrpc::ApiCall<RestoreAgentRequest, lro::Operation> _callRestoreAgent;

        /// <summary>
        /// Constructs a client wrapper for the Agents service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AgentsSettings"/> used within this client </param>
        public AgentsClientImpl(Agents.AgentsClient grpcClient, AgentsSettings settings)
        {
            GrpcClient = grpcClient;
            AgentsSettings effectiveSettings = settings ?? AgentsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            TrainAgentOperationsClient = new lro::OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.TrainAgentOperationsSettings);
            ExportAgentOperationsClient = new lro::OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.ExportAgentOperationsSettings);
            ImportAgentOperationsClient = new lro::OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.ImportAgentOperationsSettings);
            RestoreAgentOperationsClient = new lro::OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.RestoreAgentOperationsSettings);
            _callSetAgent = clientHelper.BuildApiCall<SetAgentRequest, Agent>(
                GrpcClient.SetAgentAsync, GrpcClient.SetAgent, effectiveSettings.SetAgentSettings)
                .WithGoogleRequestParam("agent.parent", request => request.Agent?.Parent);
            _callDeleteAgent = clientHelper.BuildApiCall<DeleteAgentRequest, pbwkt::Empty>(
                GrpcClient.DeleteAgentAsync, GrpcClient.DeleteAgent, effectiveSettings.DeleteAgentSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callGetAgent = clientHelper.BuildApiCall<GetAgentRequest, Agent>(
                GrpcClient.GetAgentAsync, GrpcClient.GetAgent, effectiveSettings.GetAgentSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callSearchAgents = clientHelper.BuildApiCall<SearchAgentsRequest, SearchAgentsResponse>(
                GrpcClient.SearchAgentsAsync, GrpcClient.SearchAgents, effectiveSettings.SearchAgentsSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callTrainAgent = clientHelper.BuildApiCall<TrainAgentRequest, lro::Operation>(
                GrpcClient.TrainAgentAsync, GrpcClient.TrainAgent, effectiveSettings.TrainAgentSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callExportAgent = clientHelper.BuildApiCall<ExportAgentRequest, lro::Operation>(
                GrpcClient.ExportAgentAsync, GrpcClient.ExportAgent, effectiveSettings.ExportAgentSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callImportAgent = clientHelper.BuildApiCall<ImportAgentRequest, lro::Operation>(
                GrpcClient.ImportAgentAsync, GrpcClient.ImportAgent, effectiveSettings.ImportAgentSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callRestoreAgent = clientHelper.BuildApiCall<RestoreAgentRequest, lro::Operation>(
                GrpcClient.RestoreAgentAsync, GrpcClient.RestoreAgent, effectiveSettings.RestoreAgentSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callSetAgent);
            Modify_SetAgentApiCall(ref _callSetAgent);
            Modify_ApiCall(ref _callDeleteAgent);
            Modify_DeleteAgentApiCall(ref _callDeleteAgent);
            Modify_ApiCall(ref _callGetAgent);
            Modify_GetAgentApiCall(ref _callGetAgent);
            Modify_ApiCall(ref _callSearchAgents);
            Modify_SearchAgentsApiCall(ref _callSearchAgents);
            Modify_ApiCall(ref _callTrainAgent);
            Modify_TrainAgentApiCall(ref _callTrainAgent);
            Modify_ApiCall(ref _callExportAgent);
            Modify_ExportAgentApiCall(ref _callExportAgent);
            Modify_ApiCall(ref _callImportAgent);
            Modify_ImportAgentApiCall(ref _callImportAgent);
            Modify_ApiCall(ref _callRestoreAgent);
            Modify_RestoreAgentApiCall(ref _callRestoreAgent);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        // Partial methods are named to (mostly) ensure there cannot be conflicts with RPC method names.

        // Partial methods called for every ApiCall on construction.
        // Allows modification of all the underlying ApiCall objects.
        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call)
            where TRequest : class, pb::IMessage<TRequest>
            where TResponse : class, pb::IMessage<TResponse>;

        // Partial methods called for each ApiCall on construction.
        // Allows per-RPC-method modification of the underlying ApiCall object.
        partial void Modify_SetAgentApiCall(ref gaxgrpc::ApiCall<SetAgentRequest, Agent> call);
        partial void Modify_DeleteAgentApiCall(ref gaxgrpc::ApiCall<DeleteAgentRequest, pbwkt::Empty> call);
        partial void Modify_GetAgentApiCall(ref gaxgrpc::ApiCall<GetAgentRequest, Agent> call);
        partial void Modify_SearchAgentsApiCall(ref gaxgrpc::ApiCall<SearchAgentsRequest, SearchAgentsResponse> call);
        partial void Modify_TrainAgentApiCall(ref gaxgrpc::ApiCall<TrainAgentRequest, lro::Operation> call);
        partial void Modify_ExportAgentApiCall(ref gaxgrpc::ApiCall<ExportAgentRequest, lro::Operation> call);
        partial void Modify_ImportAgentApiCall(ref gaxgrpc::ApiCall<ImportAgentRequest, lro::Operation> call);
        partial void Modify_RestoreAgentApiCall(ref gaxgrpc::ApiCall<RestoreAgentRequest, lro::Operation> call);
        partial void OnConstruction(Agents.AgentsClient grpcClient, AgentsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC Agents client.
        /// </summary>
        public override Agents.AgentsClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_SetAgentRequest(ref SetAgentRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteAgentRequest(ref DeleteAgentRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetAgentRequest(ref GetAgentRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_SearchAgentsRequest(ref SearchAgentsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_TrainAgentRequest(ref TrainAgentRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ExportAgentRequest(ref ExportAgentRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ImportAgentRequest(ref ImportAgentRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_RestoreAgentRequest(ref RestoreAgentRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates/updates the specified agent.
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
        public override stt::Task<Agent> SetAgentAsync(
            SetAgentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetAgentRequest(ref request, ref callSettings);
            return _callSetAgent.Async(request, callSettings);
        }

        /// <summary>
        /// Creates/updates the specified agent.
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
        public override Agent SetAgent(
            SetAgentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetAgentRequest(ref request, ref callSettings);
            return _callSetAgent.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified agent.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public override stt::Task DeleteAgentAsync(
            DeleteAgentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAgentRequest(ref request, ref callSettings);
            return _callDeleteAgent.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified agent.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteAgent(
            DeleteAgentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAgentRequest(ref request, ref callSettings);
            _callDeleteAgent.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified agent.
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
        public override stt::Task<Agent> GetAgentAsync(
            GetAgentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAgentRequest(ref request, ref callSettings);
            return _callGetAgent.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified agent.
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
        public override Agent GetAgent(
            GetAgentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAgentRequest(ref request, ref callSettings);
            return _callGetAgent.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the list of agents.
        ///
        /// Since there is at most one conversational agent per project, this method is
        /// useful primarily for listing all agents across projects the caller has
        /// access to. One can achieve that with a wildcard project collection id "-".
        /// Refer to [List
        /// Sub-Collections](https://cloud.google.com/apis/design/design_patterns#list_sub-collections).
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Agent"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<SearchAgentsResponse, Agent> SearchAgentsAsync(
            SearchAgentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchAgentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchAgentsRequest, SearchAgentsResponse, Agent>(_callSearchAgents, request, callSettings);
        }

        /// <summary>
        /// Returns the list of agents.
        ///
        /// Since there is at most one conversational agent per project, this method is
        /// useful primarily for listing all agents across projects the caller has
        /// access to. One can achieve that with a wildcard project collection id "-".
        /// Refer to [List
        /// Sub-Collections](https://cloud.google.com/apis/design/design_patterns#list_sub-collections).
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Agent"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<SearchAgentsResponse, Agent> SearchAgents(
            SearchAgentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchAgentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchAgentsRequest, SearchAgentsResponse, Agent>(_callSearchAgents, request, callSettings);
        }

        /// <summary>
        /// Trains the specified agent.
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
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
        public override async stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> TrainAgentAsync(
            TrainAgentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TrainAgentRequest(ref request, ref callSettings);
            return new lro::Operation<pbwkt::Empty, pbwkt::Struct>(
                await _callTrainAgent.Async(request, callSettings).ConfigureAwait(false), TrainAgentOperationsClient);
        }

        /// <summary>
        /// Trains the specified agent.
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
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
        public override lro::Operation<pbwkt::Empty, pbwkt::Struct> TrainAgent(
            TrainAgentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TrainAgentRequest(ref request, ref callSettings);
            return new lro::Operation<pbwkt::Empty, pbwkt::Struct>(
                _callTrainAgent.Sync(request, callSettings), TrainAgentOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>TrainAgent</c>.
        /// </summary>
        public override lro::OperationsClient TrainAgentOperationsClient { get; }

        /// <summary>
        /// Exports the specified agent to a ZIP file.
        ///
        /// Operation &lt;response: [ExportAgentResponse][google.cloud.dialogflow.v2.ExportAgentResponse]&gt;
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
        public override async stt::Task<lro::Operation<ExportAgentResponse, pbwkt::Struct>> ExportAgentAsync(
            ExportAgentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportAgentRequest(ref request, ref callSettings);
            return new lro::Operation<ExportAgentResponse, pbwkt::Struct>(
                await _callExportAgent.Async(request, callSettings).ConfigureAwait(false), ExportAgentOperationsClient);
        }

        /// <summary>
        /// Exports the specified agent to a ZIP file.
        ///
        /// Operation &lt;response: [ExportAgentResponse][google.cloud.dialogflow.v2.ExportAgentResponse]&gt;
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
        public override lro::Operation<ExportAgentResponse, pbwkt::Struct> ExportAgent(
            ExportAgentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportAgentRequest(ref request, ref callSettings);
            return new lro::Operation<ExportAgentResponse, pbwkt::Struct>(
                _callExportAgent.Sync(request, callSettings), ExportAgentOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>ExportAgent</c>.
        /// </summary>
        public override lro::OperationsClient ExportAgentOperationsClient { get; }

        /// <summary>
        /// Imports the specified agent from a ZIP file.
        ///
        /// Uploads new intents and entity types without deleting the existing ones.
        /// Intents and entity types with the same name are replaced with the new
        /// versions from ImportAgentRequest.
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
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
        public override async stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> ImportAgentAsync(
            ImportAgentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportAgentRequest(ref request, ref callSettings);
            return new lro::Operation<pbwkt::Empty, pbwkt::Struct>(
                await _callImportAgent.Async(request, callSettings).ConfigureAwait(false), ImportAgentOperationsClient);
        }

        /// <summary>
        /// Imports the specified agent from a ZIP file.
        ///
        /// Uploads new intents and entity types without deleting the existing ones.
        /// Intents and entity types with the same name are replaced with the new
        /// versions from ImportAgentRequest.
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
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
        public override lro::Operation<pbwkt::Empty, pbwkt::Struct> ImportAgent(
            ImportAgentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportAgentRequest(ref request, ref callSettings);
            return new lro::Operation<pbwkt::Empty, pbwkt::Struct>(
                _callImportAgent.Sync(request, callSettings), ImportAgentOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>ImportAgent</c>.
        /// </summary>
        public override lro::OperationsClient ImportAgentOperationsClient { get; }

        /// <summary>
        /// Restores the specified agent from a ZIP file.
        ///
        /// Replaces the current agent version with a new one. All the intents and
        /// entity types in the older version are deleted.
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
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
        public override async stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> RestoreAgentAsync(
            RestoreAgentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RestoreAgentRequest(ref request, ref callSettings);
            return new lro::Operation<pbwkt::Empty, pbwkt::Struct>(
                await _callRestoreAgent.Async(request, callSettings).ConfigureAwait(false), RestoreAgentOperationsClient);
        }

        /// <summary>
        /// Restores the specified agent from a ZIP file.
        ///
        /// Replaces the current agent version with a new one. All the intents and
        /// entity types in the older version are deleted.
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
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
        public override lro::Operation<pbwkt::Empty, pbwkt::Struct> RestoreAgent(
            RestoreAgentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RestoreAgentRequest(ref request, ref callSettings);
            return new lro::Operation<pbwkt::Empty, pbwkt::Struct>(
                _callRestoreAgent.Sync(request, callSettings), RestoreAgentOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>RestoreAgent</c>.
        /// </summary>
        public override lro::OperationsClient RestoreAgentOperationsClient { get; }

    }

    // Partial classes to enable page-streaming

    public partial class SearchAgentsRequest : gaxgrpc::IPageRequest { }
    public partial class SearchAgentsResponse : gaxgrpc::IPageResponse<Agent>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<Agent> GetEnumerator() => Agents.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    // Partial Grpc class to enable LRO client creation
    public static partial class Agents
    {
        public partial class AgentsClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() => new lro::Operations.OperationsClient(CallInvoker);
        }
    }


}
