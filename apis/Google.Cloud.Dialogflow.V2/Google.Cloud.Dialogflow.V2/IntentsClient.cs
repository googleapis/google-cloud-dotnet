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
    /// Settings for a <see cref="IntentsClient"/>.
    /// </summary>
    public sealed partial class IntentsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="IntentsSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="IntentsSettings"/>.
        /// </returns>
        public static IntentsSettings GetDefault() => new IntentsSettings();

        /// <summary>
        /// Constructs a new <see cref="IntentsSettings"/> object with default settings.
        /// </summary>
        public IntentsSettings() { }

        private IntentsSettings(IntentsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListIntentsSettings = existing.ListIntentsSettings;
            GetIntentSettings = existing.GetIntentSettings;
            CreateIntentSettings = existing.CreateIntentSettings;
            UpdateIntentSettings = existing.UpdateIntentSettings;
            DeleteIntentSettings = existing.DeleteIntentSettings;
            BatchUpdateIntentsSettings = existing.BatchUpdateIntentsSettings;
            BatchUpdateIntentsOperationsSettings = existing.BatchUpdateIntentsOperationsSettings?.Clone();
            BatchDeleteIntentsSettings = existing.BatchDeleteIntentsSettings;
            BatchDeleteIntentsOperationsSettings = existing.BatchDeleteIntentsOperationsSettings?.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(IntentsSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="IntentsClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="IntentsClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="IntentsClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="IntentsClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="IntentsClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="IntentsClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="IntentsClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="IntentsClient"/> RPC methods is defined as:
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
        /// <c>IntentsClient.ListIntents</c> and <c>IntentsClient.ListIntentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>IntentsClient.ListIntents</c> and
        /// <c>IntentsClient.ListIntentsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListIntentsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IntentsClient.GetIntent</c> and <c>IntentsClient.GetIntentAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>IntentsClient.GetIntent</c> and
        /// <c>IntentsClient.GetIntentAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetIntentSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IntentsClient.CreateIntent</c> and <c>IntentsClient.CreateIntentAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>IntentsClient.CreateIntent</c> and
        /// <c>IntentsClient.CreateIntentAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings CreateIntentSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IntentsClient.UpdateIntent</c> and <c>IntentsClient.UpdateIntentAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>IntentsClient.UpdateIntent</c> and
        /// <c>IntentsClient.UpdateIntentAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings UpdateIntentSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IntentsClient.DeleteIntent</c> and <c>IntentsClient.DeleteIntentAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>IntentsClient.DeleteIntent</c> and
        /// <c>IntentsClient.DeleteIntentAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings DeleteIntentSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IntentsClient.BatchUpdateIntents</c> and <c>IntentsClient.BatchUpdateIntentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>IntentsClient.BatchUpdateIntents</c> and
        /// <c>IntentsClient.BatchUpdateIntentsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings BatchUpdateIntentsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>IntentsClient.BatchUpdateIntents</c>.
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
        public lro::OperationsSettings BatchUpdateIntentsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(
                gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000L)),
                sys::TimeSpan.FromMilliseconds(500L),
                1.5,
                sys::TimeSpan.FromMilliseconds(5000L))
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IntentsClient.BatchDeleteIntents</c> and <c>IntentsClient.BatchDeleteIntentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>IntentsClient.BatchDeleteIntents</c> and
        /// <c>IntentsClient.BatchDeleteIntentsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings BatchDeleteIntentsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>IntentsClient.BatchDeleteIntents</c>.
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
        public lro::OperationsSettings BatchDeleteIntentsOperationsSettings { get; set; } = new lro::OperationsSettings
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
        /// <returns>A deep clone of this <see cref="IntentsSettings"/> object.</returns>
        public IntentsSettings Clone() => new IntentsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="IntentsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class IntentsClientBuilder : gaxgrpc::ClientBuilderBase<IntentsClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public IntentsSettings Settings { get; set; }

        /// <inheritdoc/>
        public override IntentsClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return IntentsClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<IntentsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return IntentsClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => IntentsClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => IntentsClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => IntentsClient.ChannelPool;
    }

    /// <summary>
    /// Intents client wrapper, for convenient use.
    /// </summary>
    public abstract partial class IntentsClient
    {
        /// <summary>
        /// The default endpoint for the Intents service, which is a host of "dialogflow.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("dialogflow.googleapis.com", 443);

        /// <summary>
        /// The default Intents scopes.
        /// </summary>
        /// <remarks>
        /// The default Intents scopes are:
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
        /// Asynchronously creates a <see cref="IntentsClient"/>, applying defaults for all unspecified settings,
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
        /// IntentsClient client = await IntentsClient.CreateAsync();
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
        ///     IntentsClient.DefaultEndpoint.Host, IntentsClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// IntentsClient client = IntentsClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="IntentsSettings"/>.</param>
        /// <returns>The task representing the created <see cref="IntentsClient"/>.</returns>
        public static async stt::Task<IntentsClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, IntentsSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="IntentsClient"/>, applying defaults for all unspecified settings,
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
        /// IntentsClient client = IntentsClient.Create();
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
        ///     IntentsClient.DefaultEndpoint.Host, IntentsClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// IntentsClient client = IntentsClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="IntentsSettings"/>.</param>
        /// <returns>The created <see cref="IntentsClient"/>.</returns>
        public static IntentsClient Create(gaxgrpc::ServiceEndpoint endpoint = null, IntentsSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="IntentsClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="IntentsSettings"/>.</param>
        /// <returns>The created <see cref="IntentsClient"/>.</returns>
        public static IntentsClient Create(grpccore::Channel channel, IntentsSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="IntentsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="IntentsSettings"/>.</param>
        /// <returns>The created <see cref="IntentsClient"/>.</returns>
        public static IntentsClient Create(grpccore::CallInvoker callInvoker, IntentsSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Intents.IntentsClient grpcClient = new Intents.IntentsClient(callInvoker);
            return new IntentsClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, IntentsSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, IntentsSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, IntentsSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, IntentsSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC Intents client.
        /// </summary>
        public virtual Intents.IntentsClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Returns the list of all intents in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list all intents from.
        /// Format: `projects/&lt;Project ID&gt;/agent`.
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
        /// A pageable asynchronous sequence of <see cref="Intent"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListIntentsResponse, Intent> ListIntentsAsync(
            ProjectAgentName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListIntentsAsync(
                new ListIntentsRequest
                {
                    ParentAsProjectAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns the list of all intents in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list all intents from.
        /// Format: `projects/&lt;Project ID&gt;/agent`.
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
        /// A pageable sequence of <see cref="Intent"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListIntentsResponse, Intent> ListIntents(
            ProjectAgentName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListIntents(
                new ListIntentsRequest
                {
                    ParentAsProjectAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns the list of all intents in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list all intents from.
        /// Format: `projects/&lt;Project ID&gt;/agent`.
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
        /// A pageable asynchronous sequence of <see cref="Intent"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListIntentsResponse, Intent> ListIntentsAsync(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListIntentsAsync(
                new ListIntentsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns the list of all intents in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list all intents from.
        /// Format: `projects/&lt;Project ID&gt;/agent`.
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
        /// A pageable sequence of <see cref="Intent"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListIntentsResponse, Intent> ListIntents(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListIntents(
                new ListIntentsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns the list of all intents in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list all intents from.
        /// Format: `projects/&lt;Project ID&gt;/agent`.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language to list training phrases, parameters and rich
        /// messages for. If not specified, the agent's default language is used.
        /// [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
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
        /// A pageable asynchronous sequence of <see cref="Intent"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListIntentsResponse, Intent> ListIntentsAsync(
            ProjectAgentName parent,
            string languageCode,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListIntentsAsync(
                new ListIntentsRequest
                {
                    ParentAsProjectAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    LanguageCode = languageCode ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns the list of all intents in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list all intents from.
        /// Format: `projects/&lt;Project ID&gt;/agent`.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language to list training phrases, parameters and rich
        /// messages for. If not specified, the agent's default language is used.
        /// [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
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
        /// A pageable sequence of <see cref="Intent"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListIntentsResponse, Intent> ListIntents(
            ProjectAgentName parent,
            string languageCode,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListIntents(
                new ListIntentsRequest
                {
                    ParentAsProjectAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    LanguageCode = languageCode ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns the list of all intents in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list all intents from.
        /// Format: `projects/&lt;Project ID&gt;/agent`.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language to list training phrases, parameters and rich
        /// messages for. If not specified, the agent's default language is used.
        /// [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
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
        /// A pageable asynchronous sequence of <see cref="Intent"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListIntentsResponse, Intent> ListIntentsAsync(
            string parent,
            string languageCode,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListIntentsAsync(
                new ListIntentsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    LanguageCode = languageCode ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns the list of all intents in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list all intents from.
        /// Format: `projects/&lt;Project ID&gt;/agent`.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language to list training phrases, parameters and rich
        /// messages for. If not specified, the agent's default language is used.
        /// [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
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
        /// A pageable sequence of <see cref="Intent"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListIntentsResponse, Intent> ListIntents(
            string parent,
            string languageCode,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListIntents(
                new ListIntentsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    LanguageCode = languageCode ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns the list of all intents in the specified agent.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Intent"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListIntentsResponse, Intent> ListIntentsAsync(
            ListIntentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns the list of all intents in the specified agent.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Intent"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListIntentsResponse, Intent> ListIntents(
            ListIntentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Retrieves the specified intent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the intent.
        /// Format: `projects/&lt;Project ID&gt;/agent/intents/&lt;Intent ID&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Intent> GetIntentAsync(
            IntentName name,
            gaxgrpc::CallSettings callSettings = null) => GetIntentAsync(
                new GetIntentRequest
                {
                    IntentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Retrieves the specified intent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the intent.
        /// Format: `projects/&lt;Project ID&gt;/agent/intents/&lt;Intent ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Intent> GetIntentAsync(
            IntentName name,
            st::CancellationToken cancellationToken) => GetIntentAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified intent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the intent.
        /// Format: `projects/&lt;Project ID&gt;/agent/intents/&lt;Intent ID&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Intent GetIntent(
            IntentName name,
            gaxgrpc::CallSettings callSettings = null) => GetIntent(
                new GetIntentRequest
                {
                    IntentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Retrieves the specified intent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the intent.
        /// Format: `projects/&lt;Project ID&gt;/agent/intents/&lt;Intent ID&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Intent> GetIntentAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetIntentAsync(
                new GetIntentRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Retrieves the specified intent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the intent.
        /// Format: `projects/&lt;Project ID&gt;/agent/intents/&lt;Intent ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Intent> GetIntentAsync(
            string name,
            st::CancellationToken cancellationToken) => GetIntentAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified intent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the intent.
        /// Format: `projects/&lt;Project ID&gt;/agent/intents/&lt;Intent ID&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Intent GetIntent(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetIntent(
                new GetIntentRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Retrieves the specified intent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the intent.
        /// Format: `projects/&lt;Project ID&gt;/agent/intents/&lt;Intent ID&gt;`.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language to retrieve training phrases, parameters and rich
        /// messages for. If not specified, the agent's default language is used.
        /// [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Intent> GetIntentAsync(
            IntentName name,
            string languageCode,
            gaxgrpc::CallSettings callSettings = null) => GetIntentAsync(
                new GetIntentRequest
                {
                    IntentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    LanguageCode = languageCode ?? "", // Optional
                },
                callSettings);

        /// <summary>
        /// Retrieves the specified intent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the intent.
        /// Format: `projects/&lt;Project ID&gt;/agent/intents/&lt;Intent ID&gt;`.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language to retrieve training phrases, parameters and rich
        /// messages for. If not specified, the agent's default language is used.
        /// [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Intent> GetIntentAsync(
            IntentName name,
            string languageCode,
            st::CancellationToken cancellationToken) => GetIntentAsync(
                name,
                languageCode,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified intent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the intent.
        /// Format: `projects/&lt;Project ID&gt;/agent/intents/&lt;Intent ID&gt;`.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language to retrieve training phrases, parameters and rich
        /// messages for. If not specified, the agent's default language is used.
        /// [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Intent GetIntent(
            IntentName name,
            string languageCode,
            gaxgrpc::CallSettings callSettings = null) => GetIntent(
                new GetIntentRequest
                {
                    IntentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    LanguageCode = languageCode ?? "", // Optional
                },
                callSettings);

        /// <summary>
        /// Retrieves the specified intent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the intent.
        /// Format: `projects/&lt;Project ID&gt;/agent/intents/&lt;Intent ID&gt;`.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language to retrieve training phrases, parameters and rich
        /// messages for. If not specified, the agent's default language is used.
        /// [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Intent> GetIntentAsync(
            string name,
            string languageCode,
            gaxgrpc::CallSettings callSettings = null) => GetIntentAsync(
                new GetIntentRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    LanguageCode = languageCode ?? "", // Optional
                },
                callSettings);

        /// <summary>
        /// Retrieves the specified intent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the intent.
        /// Format: `projects/&lt;Project ID&gt;/agent/intents/&lt;Intent ID&gt;`.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language to retrieve training phrases, parameters and rich
        /// messages for. If not specified, the agent's default language is used.
        /// [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Intent> GetIntentAsync(
            string name,
            string languageCode,
            st::CancellationToken cancellationToken) => GetIntentAsync(
                name,
                languageCode,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified intent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the intent.
        /// Format: `projects/&lt;Project ID&gt;/agent/intents/&lt;Intent ID&gt;`.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language to retrieve training phrases, parameters and rich
        /// messages for. If not specified, the agent's default language is used.
        /// [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Intent GetIntent(
            string name,
            string languageCode,
            gaxgrpc::CallSettings callSettings = null) => GetIntent(
                new GetIntentRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    LanguageCode = languageCode ?? "", // Optional
                },
                callSettings);

        /// <summary>
        /// Retrieves the specified intent.
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
        public virtual stt::Task<Intent> GetIntentAsync(
            GetIntentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Retrieves the specified intent.
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
        public virtual stt::Task<Intent> GetIntentAsync(
            GetIntentRequest request,
            st::CancellationToken cancellationToken) => GetIntentAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified intent.
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
        public virtual Intent GetIntent(
            GetIntentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates an intent in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a intent for.
        /// Format: `projects/&lt;Project ID&gt;/agent`.
        /// </param>
        /// <param name="intent">
        /// Required. The intent to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Intent> CreateIntentAsync(
            ProjectAgentName parent,
            Intent intent,
            gaxgrpc::CallSettings callSettings = null) => CreateIntentAsync(
                new CreateIntentRequest
                {
                    ParentAsProjectAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Intent = gax::GaxPreconditions.CheckNotNull(intent, nameof(intent)),
                },
                callSettings);

        /// <summary>
        /// Creates an intent in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a intent for.
        /// Format: `projects/&lt;Project ID&gt;/agent`.
        /// </param>
        /// <param name="intent">
        /// Required. The intent to create.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Intent> CreateIntentAsync(
            ProjectAgentName parent,
            Intent intent,
            st::CancellationToken cancellationToken) => CreateIntentAsync(
                parent,
                intent,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an intent in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a intent for.
        /// Format: `projects/&lt;Project ID&gt;/agent`.
        /// </param>
        /// <param name="intent">
        /// Required. The intent to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Intent CreateIntent(
            ProjectAgentName parent,
            Intent intent,
            gaxgrpc::CallSettings callSettings = null) => CreateIntent(
                new CreateIntentRequest
                {
                    ParentAsProjectAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Intent = gax::GaxPreconditions.CheckNotNull(intent, nameof(intent)),
                },
                callSettings);

        /// <summary>
        /// Creates an intent in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a intent for.
        /// Format: `projects/&lt;Project ID&gt;/agent`.
        /// </param>
        /// <param name="intent">
        /// Required. The intent to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Intent> CreateIntentAsync(
            string parent,
            Intent intent,
            gaxgrpc::CallSettings callSettings = null) => CreateIntentAsync(
                new CreateIntentRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Intent = gax::GaxPreconditions.CheckNotNull(intent, nameof(intent)),
                },
                callSettings);

        /// <summary>
        /// Creates an intent in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a intent for.
        /// Format: `projects/&lt;Project ID&gt;/agent`.
        /// </param>
        /// <param name="intent">
        /// Required. The intent to create.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Intent> CreateIntentAsync(
            string parent,
            Intent intent,
            st::CancellationToken cancellationToken) => CreateIntentAsync(
                parent,
                intent,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an intent in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a intent for.
        /// Format: `projects/&lt;Project ID&gt;/agent`.
        /// </param>
        /// <param name="intent">
        /// Required. The intent to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Intent CreateIntent(
            string parent,
            Intent intent,
            gaxgrpc::CallSettings callSettings = null) => CreateIntent(
                new CreateIntentRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Intent = gax::GaxPreconditions.CheckNotNull(intent, nameof(intent)),
                },
                callSettings);

        /// <summary>
        /// Creates an intent in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a intent for.
        /// Format: `projects/&lt;Project ID&gt;/agent`.
        /// </param>
        /// <param name="intent">
        /// Required. The intent to create.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language of training phrases, parameters and rich messages
        /// defined in `intent`. If not specified, the agent's default language is
        /// used. [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Intent> CreateIntentAsync(
            ProjectAgentName parent,
            Intent intent,
            string languageCode,
            gaxgrpc::CallSettings callSettings = null) => CreateIntentAsync(
                new CreateIntentRequest
                {
                    ParentAsProjectAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Intent = gax::GaxPreconditions.CheckNotNull(intent, nameof(intent)),
                    LanguageCode = languageCode ?? "", // Optional
                },
                callSettings);

        /// <summary>
        /// Creates an intent in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a intent for.
        /// Format: `projects/&lt;Project ID&gt;/agent`.
        /// </param>
        /// <param name="intent">
        /// Required. The intent to create.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language of training phrases, parameters and rich messages
        /// defined in `intent`. If not specified, the agent's default language is
        /// used. [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Intent> CreateIntentAsync(
            ProjectAgentName parent,
            Intent intent,
            string languageCode,
            st::CancellationToken cancellationToken) => CreateIntentAsync(
                parent,
                intent,
                languageCode,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an intent in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a intent for.
        /// Format: `projects/&lt;Project ID&gt;/agent`.
        /// </param>
        /// <param name="intent">
        /// Required. The intent to create.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language of training phrases, parameters and rich messages
        /// defined in `intent`. If not specified, the agent's default language is
        /// used. [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Intent CreateIntent(
            ProjectAgentName parent,
            Intent intent,
            string languageCode,
            gaxgrpc::CallSettings callSettings = null) => CreateIntent(
                new CreateIntentRequest
                {
                    ParentAsProjectAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Intent = gax::GaxPreconditions.CheckNotNull(intent, nameof(intent)),
                    LanguageCode = languageCode ?? "", // Optional
                },
                callSettings);

        /// <summary>
        /// Creates an intent in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a intent for.
        /// Format: `projects/&lt;Project ID&gt;/agent`.
        /// </param>
        /// <param name="intent">
        /// Required. The intent to create.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language of training phrases, parameters and rich messages
        /// defined in `intent`. If not specified, the agent's default language is
        /// used. [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Intent> CreateIntentAsync(
            string parent,
            Intent intent,
            string languageCode,
            gaxgrpc::CallSettings callSettings = null) => CreateIntentAsync(
                new CreateIntentRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Intent = gax::GaxPreconditions.CheckNotNull(intent, nameof(intent)),
                    LanguageCode = languageCode ?? "", // Optional
                },
                callSettings);

        /// <summary>
        /// Creates an intent in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a intent for.
        /// Format: `projects/&lt;Project ID&gt;/agent`.
        /// </param>
        /// <param name="intent">
        /// Required. The intent to create.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language of training phrases, parameters and rich messages
        /// defined in `intent`. If not specified, the agent's default language is
        /// used. [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Intent> CreateIntentAsync(
            string parent,
            Intent intent,
            string languageCode,
            st::CancellationToken cancellationToken) => CreateIntentAsync(
                parent,
                intent,
                languageCode,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an intent in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a intent for.
        /// Format: `projects/&lt;Project ID&gt;/agent`.
        /// </param>
        /// <param name="intent">
        /// Required. The intent to create.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language of training phrases, parameters and rich messages
        /// defined in `intent`. If not specified, the agent's default language is
        /// used. [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Intent CreateIntent(
            string parent,
            Intent intent,
            string languageCode,
            gaxgrpc::CallSettings callSettings = null) => CreateIntent(
                new CreateIntentRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Intent = gax::GaxPreconditions.CheckNotNull(intent, nameof(intent)),
                    LanguageCode = languageCode ?? "", // Optional
                },
                callSettings);

        /// <summary>
        /// Creates an intent in the specified agent.
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
        public virtual stt::Task<Intent> CreateIntentAsync(
            CreateIntentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates an intent in the specified agent.
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
        public virtual stt::Task<Intent> CreateIntentAsync(
            CreateIntentRequest request,
            st::CancellationToken cancellationToken) => CreateIntentAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an intent in the specified agent.
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
        public virtual Intent CreateIntent(
            CreateIntentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates the specified intent.
        /// </summary>
        /// <param name="intent">
        /// Required. The intent to update.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language of training phrases, parameters and rich messages
        /// defined in `intent`. If not specified, the agent's default language is
        /// used. [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Intent> UpdateIntentAsync(
            Intent intent,
            string languageCode,
            gaxgrpc::CallSettings callSettings = null) => UpdateIntentAsync(
                new UpdateIntentRequest
                {
                    Intent = gax::GaxPreconditions.CheckNotNull(intent, nameof(intent)),
                    LanguageCode = gax::GaxPreconditions.CheckNotNullOrEmpty(languageCode, nameof(languageCode)),
                },
                callSettings);

        /// <summary>
        /// Updates the specified intent.
        /// </summary>
        /// <param name="intent">
        /// Required. The intent to update.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language of training phrases, parameters and rich messages
        /// defined in `intent`. If not specified, the agent's default language is
        /// used. [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Intent> UpdateIntentAsync(
            Intent intent,
            string languageCode,
            st::CancellationToken cancellationToken) => UpdateIntentAsync(
                intent,
                languageCode,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified intent.
        /// </summary>
        /// <param name="intent">
        /// Required. The intent to update.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language of training phrases, parameters and rich messages
        /// defined in `intent`. If not specified, the agent's default language is
        /// used. [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Intent UpdateIntent(
            Intent intent,
            string languageCode,
            gaxgrpc::CallSettings callSettings = null) => UpdateIntent(
                new UpdateIntentRequest
                {
                    Intent = gax::GaxPreconditions.CheckNotNull(intent, nameof(intent)),
                    LanguageCode = gax::GaxPreconditions.CheckNotNullOrEmpty(languageCode, nameof(languageCode)),
                },
                callSettings);

        /// <summary>
        /// Updates the specified intent.
        /// </summary>
        /// <param name="intent">
        /// Required. The intent to update.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language of training phrases, parameters and rich messages
        /// defined in `intent`. If not specified, the agent's default language is
        /// used. [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The mask to control which fields get updated.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Intent> UpdateIntentAsync(
            Intent intent,
            string languageCode,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateIntentAsync(
                new UpdateIntentRequest
                {
                    Intent = gax::GaxPreconditions.CheckNotNull(intent, nameof(intent)),
                    LanguageCode = gax::GaxPreconditions.CheckNotNullOrEmpty(languageCode, nameof(languageCode)),
                    UpdateMask = updateMask, // Optional
                },
                callSettings);

        /// <summary>
        /// Updates the specified intent.
        /// </summary>
        /// <param name="intent">
        /// Required. The intent to update.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language of training phrases, parameters and rich messages
        /// defined in `intent`. If not specified, the agent's default language is
        /// used. [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The mask to control which fields get updated.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Intent> UpdateIntentAsync(
            Intent intent,
            string languageCode,
            pbwkt::FieldMask updateMask,
            st::CancellationToken cancellationToken) => UpdateIntentAsync(
                intent,
                languageCode,
                updateMask,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified intent.
        /// </summary>
        /// <param name="intent">
        /// Required. The intent to update.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language of training phrases, parameters and rich messages
        /// defined in `intent`. If not specified, the agent's default language is
        /// used. [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The mask to control which fields get updated.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Intent UpdateIntent(
            Intent intent,
            string languageCode,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateIntent(
                new UpdateIntentRequest
                {
                    Intent = gax::GaxPreconditions.CheckNotNull(intent, nameof(intent)),
                    LanguageCode = gax::GaxPreconditions.CheckNotNullOrEmpty(languageCode, nameof(languageCode)),
                    UpdateMask = updateMask, // Optional
                },
                callSettings);

        /// <summary>
        /// Updates the specified intent.
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
        public virtual stt::Task<Intent> UpdateIntentAsync(
            UpdateIntentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates the specified intent.
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
        public virtual stt::Task<Intent> UpdateIntentAsync(
            UpdateIntentRequest request,
            st::CancellationToken cancellationToken) => UpdateIntentAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified intent.
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
        public virtual Intent UpdateIntent(
            UpdateIntentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes the specified intent and its direct or indirect followup intents.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the intent to delete. If this intent has direct or
        /// indirect followup intents, we also delete them.
        /// Format: `projects/&lt;Project ID&gt;/agent/intents/&lt;Intent ID&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteIntentAsync(
            IntentName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteIntentAsync(
                new DeleteIntentRequest
                {
                    IntentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes the specified intent and its direct or indirect followup intents.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the intent to delete. If this intent has direct or
        /// indirect followup intents, we also delete them.
        /// Format: `projects/&lt;Project ID&gt;/agent/intents/&lt;Intent ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteIntentAsync(
            IntentName name,
            st::CancellationToken cancellationToken) => DeleteIntentAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified intent and its direct or indirect followup intents.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the intent to delete. If this intent has direct or
        /// indirect followup intents, we also delete them.
        /// Format: `projects/&lt;Project ID&gt;/agent/intents/&lt;Intent ID&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteIntent(
            IntentName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteIntent(
                new DeleteIntentRequest
                {
                    IntentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes the specified intent and its direct or indirect followup intents.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the intent to delete. If this intent has direct or
        /// indirect followup intents, we also delete them.
        /// Format: `projects/&lt;Project ID&gt;/agent/intents/&lt;Intent ID&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteIntentAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteIntentAsync(
                new DeleteIntentRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes the specified intent and its direct or indirect followup intents.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the intent to delete. If this intent has direct or
        /// indirect followup intents, we also delete them.
        /// Format: `projects/&lt;Project ID&gt;/agent/intents/&lt;Intent ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteIntentAsync(
            string name,
            st::CancellationToken cancellationToken) => DeleteIntentAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified intent and its direct or indirect followup intents.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the intent to delete. If this intent has direct or
        /// indirect followup intents, we also delete them.
        /// Format: `projects/&lt;Project ID&gt;/agent/intents/&lt;Intent ID&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteIntent(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteIntent(
                new DeleteIntentRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes the specified intent and its direct or indirect followup intents.
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
        public virtual stt::Task DeleteIntentAsync(
            DeleteIntentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes the specified intent and its direct or indirect followup intents.
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
        public virtual stt::Task DeleteIntentAsync(
            DeleteIntentRequest request,
            st::CancellationToken cancellationToken) => DeleteIntentAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified intent and its direct or indirect followup intents.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteIntent(
            DeleteIntentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates/Creates multiple intents in the specified agent.
        ///
        /// Operation &lt;response: [BatchUpdateIntentsResponse][google.cloud.dialogflow.v2.BatchUpdateIntentsResponse]&gt;
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
        public virtual stt::Task<lro::Operation<BatchUpdateIntentsResponse, pbwkt::Struct>> BatchUpdateIntentsAsync(
            BatchUpdateIntentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>BatchUpdateIntentsAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<BatchUpdateIntentsResponse, pbwkt::Struct>> PollOnceBatchUpdateIntentsAsync(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<BatchUpdateIntentsResponse, pbwkt::Struct>.PollOnceFromNameAsync(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                BatchUpdateIntentsOperationsClient,
                callSettings);

        /// <summary>
        /// Updates/Creates multiple intents in the specified agent.
        ///
        /// Operation &lt;response: [BatchUpdateIntentsResponse][google.cloud.dialogflow.v2.BatchUpdateIntentsResponse]&gt;
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
        public virtual lro::Operation<BatchUpdateIntentsResponse, pbwkt::Struct> BatchUpdateIntents(
            BatchUpdateIntentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>BatchUpdateIntents</c>.
        /// </summary>
        public virtual lro::OperationsClient BatchUpdateIntentsOperationsClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>BatchUpdateIntents</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<BatchUpdateIntentsResponse, pbwkt::Struct> PollOnceBatchUpdateIntents(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<BatchUpdateIntentsResponse, pbwkt::Struct>.PollOnceFromName(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                BatchUpdateIntentsOperationsClient,
                callSettings);

        /// <summary>
        /// Deletes intents in the specified agent.
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the agent to delete all entities types for. Format:
        /// `projects/&lt;Project ID&gt;/agent`.
        /// </param>
        /// <param name="intents">
        /// Required. The collection of intents to delete. Only intent `name` must be
        /// filled in.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> BatchDeleteIntentsAsync(
            ProjectAgentName parent,
            scg::IEnumerable<Intent> intents,
            gaxgrpc::CallSettings callSettings = null) => BatchDeleteIntentsAsync(
                new BatchDeleteIntentsRequest
                {
                    ParentAsProjectAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Intents = { gax::GaxPreconditions.CheckNotNull(intents, nameof(intents)) },
                },
                callSettings);

        /// <summary>
        /// Deletes intents in the specified agent.
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the agent to delete all entities types for. Format:
        /// `projects/&lt;Project ID&gt;/agent`.
        /// </param>
        /// <param name="intents">
        /// Required. The collection of intents to delete. Only intent `name` must be
        /// filled in.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> BatchDeleteIntentsAsync(
            ProjectAgentName parent,
            scg::IEnumerable<Intent> intents,
            st::CancellationToken cancellationToken) => BatchDeleteIntentsAsync(
                parent,
                intents,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes intents in the specified agent.
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the agent to delete all entities types for. Format:
        /// `projects/&lt;Project ID&gt;/agent`.
        /// </param>
        /// <param name="intents">
        /// Required. The collection of intents to delete. Only intent `name` must be
        /// filled in.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<pbwkt::Empty, pbwkt::Struct> BatchDeleteIntents(
            ProjectAgentName parent,
            scg::IEnumerable<Intent> intents,
            gaxgrpc::CallSettings callSettings = null) => BatchDeleteIntents(
                new BatchDeleteIntentsRequest
                {
                    ParentAsProjectAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Intents = { gax::GaxPreconditions.CheckNotNull(intents, nameof(intents)) },
                },
                callSettings);

        /// <summary>
        /// Deletes intents in the specified agent.
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the agent to delete all entities types for. Format:
        /// `projects/&lt;Project ID&gt;/agent`.
        /// </param>
        /// <param name="intents">
        /// Required. The collection of intents to delete. Only intent `name` must be
        /// filled in.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> BatchDeleteIntentsAsync(
            string parent,
            scg::IEnumerable<Intent> intents,
            gaxgrpc::CallSettings callSettings = null) => BatchDeleteIntentsAsync(
                new BatchDeleteIntentsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Intents = { gax::GaxPreconditions.CheckNotNull(intents, nameof(intents)) },
                },
                callSettings);

        /// <summary>
        /// Deletes intents in the specified agent.
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the agent to delete all entities types for. Format:
        /// `projects/&lt;Project ID&gt;/agent`.
        /// </param>
        /// <param name="intents">
        /// Required. The collection of intents to delete. Only intent `name` must be
        /// filled in.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> BatchDeleteIntentsAsync(
            string parent,
            scg::IEnumerable<Intent> intents,
            st::CancellationToken cancellationToken) => BatchDeleteIntentsAsync(
                parent,
                intents,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes intents in the specified agent.
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the agent to delete all entities types for. Format:
        /// `projects/&lt;Project ID&gt;/agent`.
        /// </param>
        /// <param name="intents">
        /// Required. The collection of intents to delete. Only intent `name` must be
        /// filled in.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<pbwkt::Empty, pbwkt::Struct> BatchDeleteIntents(
            string parent,
            scg::IEnumerable<Intent> intents,
            gaxgrpc::CallSettings callSettings = null) => BatchDeleteIntents(
                new BatchDeleteIntentsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Intents = { gax::GaxPreconditions.CheckNotNull(intents, nameof(intents)) },
                },
                callSettings);

        /// <summary>
        /// Deletes intents in the specified agent.
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
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> BatchDeleteIntentsAsync(
            BatchDeleteIntentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>BatchDeleteIntentsAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> PollOnceBatchDeleteIntentsAsync(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<pbwkt::Empty, pbwkt::Struct>.PollOnceFromNameAsync(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                BatchDeleteIntentsOperationsClient,
                callSettings);

        /// <summary>
        /// Deletes intents in the specified agent.
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
        public virtual lro::Operation<pbwkt::Empty, pbwkt::Struct> BatchDeleteIntents(
            BatchDeleteIntentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>BatchDeleteIntents</c>.
        /// </summary>
        public virtual lro::OperationsClient BatchDeleteIntentsOperationsClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>BatchDeleteIntents</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<pbwkt::Empty, pbwkt::Struct> PollOnceBatchDeleteIntents(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<pbwkt::Empty, pbwkt::Struct>.PollOnceFromName(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                BatchDeleteIntentsOperationsClient,
                callSettings);

    }

    /// <summary>
    /// Intents client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class IntentsClientImpl : IntentsClient
    {
        private readonly gaxgrpc::ApiCall<ListIntentsRequest, ListIntentsResponse> _callListIntents;
        private readonly gaxgrpc::ApiCall<GetIntentRequest, Intent> _callGetIntent;
        private readonly gaxgrpc::ApiCall<CreateIntentRequest, Intent> _callCreateIntent;
        private readonly gaxgrpc::ApiCall<UpdateIntentRequest, Intent> _callUpdateIntent;
        private readonly gaxgrpc::ApiCall<DeleteIntentRequest, pbwkt::Empty> _callDeleteIntent;
        private readonly gaxgrpc::ApiCall<BatchUpdateIntentsRequest, lro::Operation> _callBatchUpdateIntents;
        private readonly gaxgrpc::ApiCall<BatchDeleteIntentsRequest, lro::Operation> _callBatchDeleteIntents;

        /// <summary>
        /// Constructs a client wrapper for the Intents service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="IntentsSettings"/> used within this client </param>
        public IntentsClientImpl(Intents.IntentsClient grpcClient, IntentsSettings settings)
        {
            GrpcClient = grpcClient;
            IntentsSettings effectiveSettings = settings ?? IntentsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            BatchUpdateIntentsOperationsClient = new lro::OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.BatchUpdateIntentsOperationsSettings);
            BatchDeleteIntentsOperationsClient = new lro::OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.BatchDeleteIntentsOperationsSettings);
            _callListIntents = clientHelper.BuildApiCall<ListIntentsRequest, ListIntentsResponse>(
                GrpcClient.ListIntentsAsync, GrpcClient.ListIntents, effectiveSettings.ListIntentsSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callGetIntent = clientHelper.BuildApiCall<GetIntentRequest, Intent>(
                GrpcClient.GetIntentAsync, GrpcClient.GetIntent, effectiveSettings.GetIntentSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callCreateIntent = clientHelper.BuildApiCall<CreateIntentRequest, Intent>(
                GrpcClient.CreateIntentAsync, GrpcClient.CreateIntent, effectiveSettings.CreateIntentSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callUpdateIntent = clientHelper.BuildApiCall<UpdateIntentRequest, Intent>(
                GrpcClient.UpdateIntentAsync, GrpcClient.UpdateIntent, effectiveSettings.UpdateIntentSettings)
                .WithGoogleRequestParam("intent.name", request => request.Intent?.Name);
            _callDeleteIntent = clientHelper.BuildApiCall<DeleteIntentRequest, pbwkt::Empty>(
                GrpcClient.DeleteIntentAsync, GrpcClient.DeleteIntent, effectiveSettings.DeleteIntentSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callBatchUpdateIntents = clientHelper.BuildApiCall<BatchUpdateIntentsRequest, lro::Operation>(
                GrpcClient.BatchUpdateIntentsAsync, GrpcClient.BatchUpdateIntents, effectiveSettings.BatchUpdateIntentsSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callBatchDeleteIntents = clientHelper.BuildApiCall<BatchDeleteIntentsRequest, lro::Operation>(
                GrpcClient.BatchDeleteIntentsAsync, GrpcClient.BatchDeleteIntents, effectiveSettings.BatchDeleteIntentsSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListIntents);
            Modify_ListIntentsApiCall(ref _callListIntents);
            Modify_ApiCall(ref _callGetIntent);
            Modify_GetIntentApiCall(ref _callGetIntent);
            Modify_ApiCall(ref _callCreateIntent);
            Modify_CreateIntentApiCall(ref _callCreateIntent);
            Modify_ApiCall(ref _callUpdateIntent);
            Modify_UpdateIntentApiCall(ref _callUpdateIntent);
            Modify_ApiCall(ref _callDeleteIntent);
            Modify_DeleteIntentApiCall(ref _callDeleteIntent);
            Modify_ApiCall(ref _callBatchUpdateIntents);
            Modify_BatchUpdateIntentsApiCall(ref _callBatchUpdateIntents);
            Modify_ApiCall(ref _callBatchDeleteIntents);
            Modify_BatchDeleteIntentsApiCall(ref _callBatchDeleteIntents);
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
        partial void Modify_ListIntentsApiCall(ref gaxgrpc::ApiCall<ListIntentsRequest, ListIntentsResponse> call);
        partial void Modify_GetIntentApiCall(ref gaxgrpc::ApiCall<GetIntentRequest, Intent> call);
        partial void Modify_CreateIntentApiCall(ref gaxgrpc::ApiCall<CreateIntentRequest, Intent> call);
        partial void Modify_UpdateIntentApiCall(ref gaxgrpc::ApiCall<UpdateIntentRequest, Intent> call);
        partial void Modify_DeleteIntentApiCall(ref gaxgrpc::ApiCall<DeleteIntentRequest, pbwkt::Empty> call);
        partial void Modify_BatchUpdateIntentsApiCall(ref gaxgrpc::ApiCall<BatchUpdateIntentsRequest, lro::Operation> call);
        partial void Modify_BatchDeleteIntentsApiCall(ref gaxgrpc::ApiCall<BatchDeleteIntentsRequest, lro::Operation> call);
        partial void OnConstruction(Intents.IntentsClient grpcClient, IntentsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC Intents client.
        /// </summary>
        public override Intents.IntentsClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_ListIntentsRequest(ref ListIntentsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetIntentRequest(ref GetIntentRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateIntentRequest(ref CreateIntentRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateIntentRequest(ref UpdateIntentRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteIntentRequest(ref DeleteIntentRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_BatchUpdateIntentsRequest(ref BatchUpdateIntentsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_BatchDeleteIntentsRequest(ref BatchDeleteIntentsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the list of all intents in the specified agent.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Intent"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListIntentsResponse, Intent> ListIntentsAsync(
            ListIntentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListIntentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListIntentsRequest, ListIntentsResponse, Intent>(_callListIntents, request, callSettings);
        }

        /// <summary>
        /// Returns the list of all intents in the specified agent.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Intent"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListIntentsResponse, Intent> ListIntents(
            ListIntentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListIntentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListIntentsRequest, ListIntentsResponse, Intent>(_callListIntents, request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified intent.
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
        public override stt::Task<Intent> GetIntentAsync(
            GetIntentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIntentRequest(ref request, ref callSettings);
            return _callGetIntent.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified intent.
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
        public override Intent GetIntent(
            GetIntentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIntentRequest(ref request, ref callSettings);
            return _callGetIntent.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates an intent in the specified agent.
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
        public override stt::Task<Intent> CreateIntentAsync(
            CreateIntentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateIntentRequest(ref request, ref callSettings);
            return _callCreateIntent.Async(request, callSettings);
        }

        /// <summary>
        /// Creates an intent in the specified agent.
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
        public override Intent CreateIntent(
            CreateIntentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateIntentRequest(ref request, ref callSettings);
            return _callCreateIntent.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the specified intent.
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
        public override stt::Task<Intent> UpdateIntentAsync(
            UpdateIntentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateIntentRequest(ref request, ref callSettings);
            return _callUpdateIntent.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the specified intent.
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
        public override Intent UpdateIntent(
            UpdateIntentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateIntentRequest(ref request, ref callSettings);
            return _callUpdateIntent.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified intent and its direct or indirect followup intents.
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
        public override stt::Task DeleteIntentAsync(
            DeleteIntentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteIntentRequest(ref request, ref callSettings);
            return _callDeleteIntent.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified intent and its direct or indirect followup intents.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteIntent(
            DeleteIntentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteIntentRequest(ref request, ref callSettings);
            _callDeleteIntent.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates/Creates multiple intents in the specified agent.
        ///
        /// Operation &lt;response: [BatchUpdateIntentsResponse][google.cloud.dialogflow.v2.BatchUpdateIntentsResponse]&gt;
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
        public override async stt::Task<lro::Operation<BatchUpdateIntentsResponse, pbwkt::Struct>> BatchUpdateIntentsAsync(
            BatchUpdateIntentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateIntentsRequest(ref request, ref callSettings);
            return new lro::Operation<BatchUpdateIntentsResponse, pbwkt::Struct>(
                await _callBatchUpdateIntents.Async(request, callSettings).ConfigureAwait(false), BatchUpdateIntentsOperationsClient);
        }

        /// <summary>
        /// Updates/Creates multiple intents in the specified agent.
        ///
        /// Operation &lt;response: [BatchUpdateIntentsResponse][google.cloud.dialogflow.v2.BatchUpdateIntentsResponse]&gt;
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
        public override lro::Operation<BatchUpdateIntentsResponse, pbwkt::Struct> BatchUpdateIntents(
            BatchUpdateIntentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateIntentsRequest(ref request, ref callSettings);
            return new lro::Operation<BatchUpdateIntentsResponse, pbwkt::Struct>(
                _callBatchUpdateIntents.Sync(request, callSettings), BatchUpdateIntentsOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>BatchUpdateIntents</c>.
        /// </summary>
        public override lro::OperationsClient BatchUpdateIntentsOperationsClient { get; }

        /// <summary>
        /// Deletes intents in the specified agent.
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
        public override async stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> BatchDeleteIntentsAsync(
            BatchDeleteIntentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeleteIntentsRequest(ref request, ref callSettings);
            return new lro::Operation<pbwkt::Empty, pbwkt::Struct>(
                await _callBatchDeleteIntents.Async(request, callSettings).ConfigureAwait(false), BatchDeleteIntentsOperationsClient);
        }

        /// <summary>
        /// Deletes intents in the specified agent.
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
        public override lro::Operation<pbwkt::Empty, pbwkt::Struct> BatchDeleteIntents(
            BatchDeleteIntentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeleteIntentsRequest(ref request, ref callSettings);
            return new lro::Operation<pbwkt::Empty, pbwkt::Struct>(
                _callBatchDeleteIntents.Sync(request, callSettings), BatchDeleteIntentsOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>BatchDeleteIntents</c>.
        /// </summary>
        public override lro::OperationsClient BatchDeleteIntentsOperationsClient { get; }

    }

    // Partial classes to enable page-streaming

    public partial class ListIntentsRequest : gaxgrpc::IPageRequest { }
    public partial class ListIntentsResponse : gaxgrpc::IPageResponse<Intent>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<Intent> GetEnumerator() => Intents.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    // Partial Grpc class to enable LRO client creation
    public static partial class Intents
    {
        public partial class IntentsClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() => new lro::Operations.OperationsClient(CallInvoker);
        }
    }


}
