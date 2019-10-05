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

namespace Google.Cloud.Dataproc.V1
{
    /// <summary>
    /// Settings for a <see cref="WorkflowTemplateServiceClient"/>.
    /// </summary>
    public sealed partial class WorkflowTemplateServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="WorkflowTemplateServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="WorkflowTemplateServiceSettings"/>.
        /// </returns>
        public static WorkflowTemplateServiceSettings GetDefault() => new WorkflowTemplateServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="WorkflowTemplateServiceSettings"/> object with default settings.
        /// </summary>
        public WorkflowTemplateServiceSettings() { }

        private WorkflowTemplateServiceSettings(WorkflowTemplateServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateWorkflowTemplateSettings = existing.CreateWorkflowTemplateSettings;
            GetWorkflowTemplateSettings = existing.GetWorkflowTemplateSettings;
            InstantiateWorkflowTemplateSettings = existing.InstantiateWorkflowTemplateSettings;
            InstantiateWorkflowTemplateOperationsSettings = existing.InstantiateWorkflowTemplateOperationsSettings?.Clone();
            InstantiateInlineWorkflowTemplateSettings = existing.InstantiateInlineWorkflowTemplateSettings;
            InstantiateInlineWorkflowTemplateOperationsSettings = existing.InstantiateInlineWorkflowTemplateOperationsSettings?.Clone();
            UpdateWorkflowTemplateSettings = existing.UpdateWorkflowTemplateSettings;
            ListWorkflowTemplatesSettings = existing.ListWorkflowTemplatesSettings;
            DeleteWorkflowTemplateSettings = existing.DeleteWorkflowTemplateSettings;
            OnCopy(existing);
        }

        partial void OnCopy(WorkflowTemplateServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="WorkflowTemplateServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="grpccore::StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Internal"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> IdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="WorkflowTemplateServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="grpccore::StatusCode"/>s for retry for "NonIdempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable);

        /// <summary>
        /// "Default" retry backoff for <see cref="WorkflowTemplateServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="WorkflowTemplateServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="WorkflowTemplateServiceClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="WorkflowTemplateServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="WorkflowTemplateServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="WorkflowTemplateServiceClient"/> RPC methods is defined as:
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
        /// <c>WorkflowTemplateServiceClient.CreateWorkflowTemplate</c> and <c>WorkflowTemplateServiceClient.CreateWorkflowTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>WorkflowTemplateServiceClient.CreateWorkflowTemplate</c> and
        /// <c>WorkflowTemplateServiceClient.CreateWorkflowTemplateAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings CreateWorkflowTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkflowTemplateServiceClient.GetWorkflowTemplate</c> and <c>WorkflowTemplateServiceClient.GetWorkflowTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>WorkflowTemplateServiceClient.GetWorkflowTemplate</c> and
        /// <c>WorkflowTemplateServiceClient.GetWorkflowTemplateAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.Internal"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings GetWorkflowTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkflowTemplateServiceClient.InstantiateWorkflowTemplate</c> and <c>WorkflowTemplateServiceClient.InstantiateWorkflowTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>WorkflowTemplateServiceClient.InstantiateWorkflowTemplate</c> and
        /// <c>WorkflowTemplateServiceClient.InstantiateWorkflowTemplateAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings InstantiateWorkflowTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>WorkflowTemplateServiceClient.InstantiateWorkflowTemplate</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 1000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 2.0</description></item>
        /// <item><description>Maximum delay: 10000 milliseconds</description></item>
        /// <item><description>Total timeout: 43200000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings InstantiateWorkflowTemplateOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(
                gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(43200000L)),
                sys::TimeSpan.FromMilliseconds(1000L),
                2.0,
                sys::TimeSpan.FromMilliseconds(10000L))
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkflowTemplateServiceClient.InstantiateInlineWorkflowTemplate</c> and <c>WorkflowTemplateServiceClient.InstantiateInlineWorkflowTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>WorkflowTemplateServiceClient.InstantiateInlineWorkflowTemplate</c> and
        /// <c>WorkflowTemplateServiceClient.InstantiateInlineWorkflowTemplateAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings InstantiateInlineWorkflowTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>WorkflowTemplateServiceClient.InstantiateInlineWorkflowTemplate</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 1000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 2.0</description></item>
        /// <item><description>Maximum delay: 10000 milliseconds</description></item>
        /// <item><description>Total timeout: 43200000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings InstantiateInlineWorkflowTemplateOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(
                gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(43200000L)),
                sys::TimeSpan.FromMilliseconds(1000L),
                2.0,
                sys::TimeSpan.FromMilliseconds(10000L))
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkflowTemplateServiceClient.UpdateWorkflowTemplate</c> and <c>WorkflowTemplateServiceClient.UpdateWorkflowTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>WorkflowTemplateServiceClient.UpdateWorkflowTemplate</c> and
        /// <c>WorkflowTemplateServiceClient.UpdateWorkflowTemplateAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings UpdateWorkflowTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkflowTemplateServiceClient.ListWorkflowTemplates</c> and <c>WorkflowTemplateServiceClient.ListWorkflowTemplatesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>WorkflowTemplateServiceClient.ListWorkflowTemplates</c> and
        /// <c>WorkflowTemplateServiceClient.ListWorkflowTemplatesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.Internal"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ListWorkflowTemplatesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkflowTemplateServiceClient.DeleteWorkflowTemplate</c> and <c>WorkflowTemplateServiceClient.DeleteWorkflowTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>WorkflowTemplateServiceClient.DeleteWorkflowTemplate</c> and
        /// <c>WorkflowTemplateServiceClient.DeleteWorkflowTemplateAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings DeleteWorkflowTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="WorkflowTemplateServiceSettings"/> object.</returns>
        public WorkflowTemplateServiceSettings Clone() => new WorkflowTemplateServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="WorkflowTemplateServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class WorkflowTemplateServiceClientBuilder : gaxgrpc::ClientBuilderBase<WorkflowTemplateServiceClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public WorkflowTemplateServiceSettings Settings { get; set; }

        /// <inheritdoc/>
        public override WorkflowTemplateServiceClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return WorkflowTemplateServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<WorkflowTemplateServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return WorkflowTemplateServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => WorkflowTemplateServiceClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => WorkflowTemplateServiceClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => WorkflowTemplateServiceClient.ChannelPool;
    }

    /// <summary>
    /// WorkflowTemplateService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class WorkflowTemplateServiceClient
    {
        /// <summary>
        /// The default endpoint for the WorkflowTemplateService service, which is a host of "dataproc.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("dataproc.googleapis.com", 443);

        /// <summary>
        /// The default WorkflowTemplateService scopes.
        /// </summary>
        /// <remarks>
        /// The default WorkflowTemplateService scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="WorkflowTemplateServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Dataproc.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// WorkflowTemplateServiceClient client = await WorkflowTemplateServiceClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Dataproc.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     WorkflowTemplateServiceClient.DefaultEndpoint.Host, WorkflowTemplateServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// WorkflowTemplateServiceClient client = WorkflowTemplateServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="WorkflowTemplateServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="WorkflowTemplateServiceClient"/>.</returns>
        public static async stt::Task<WorkflowTemplateServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, WorkflowTemplateServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="WorkflowTemplateServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Dataproc.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// WorkflowTemplateServiceClient client = WorkflowTemplateServiceClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Dataproc.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     WorkflowTemplateServiceClient.DefaultEndpoint.Host, WorkflowTemplateServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// WorkflowTemplateServiceClient client = WorkflowTemplateServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="WorkflowTemplateServiceSettings"/>.</param>
        /// <returns>The created <see cref="WorkflowTemplateServiceClient"/>.</returns>
        public static WorkflowTemplateServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, WorkflowTemplateServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="WorkflowTemplateServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="WorkflowTemplateServiceSettings"/>.</param>
        /// <returns>The created <see cref="WorkflowTemplateServiceClient"/>.</returns>
        public static WorkflowTemplateServiceClient Create(grpccore::Channel channel, WorkflowTemplateServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="WorkflowTemplateServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="WorkflowTemplateServiceSettings"/>.</param>
        /// <returns>The created <see cref="WorkflowTemplateServiceClient"/>.</returns>
        public static WorkflowTemplateServiceClient Create(grpccore::CallInvoker callInvoker, WorkflowTemplateServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            WorkflowTemplateService.WorkflowTemplateServiceClient grpcClient = new WorkflowTemplateService.WorkflowTemplateServiceClient(callInvoker);
            return new WorkflowTemplateServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, WorkflowTemplateServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, WorkflowTemplateServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, WorkflowTemplateServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, WorkflowTemplateServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC WorkflowTemplateService client.
        /// </summary>
        public virtual WorkflowTemplateService.WorkflowTemplateServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Creates new workflow template.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        ///
        /// * For `projects.regions.workflowTemplates,create`, the resource name of the
        ///   region has the following format:
        ///   `projects/{project_id}/regions/{region}`
        ///
        /// * For `projects.locations.workflowTemplates.create`, the resource name of
        ///   the location has the following format:
        ///   `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="template">
        /// Required. The Dataproc workflow template to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<WorkflowTemplate> CreateWorkflowTemplateAsync(
            RegionName parent,
            WorkflowTemplate template,
            gaxgrpc::CallSettings callSettings = null) => CreateWorkflowTemplateAsync(
                new CreateWorkflowTemplateRequest
                {
                    ParentAsRegionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Template = gax::GaxPreconditions.CheckNotNull(template, nameof(template)),
                },
                callSettings);

        /// <summary>
        /// Creates new workflow template.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        ///
        /// * For `projects.regions.workflowTemplates,create`, the resource name of the
        ///   region has the following format:
        ///   `projects/{project_id}/regions/{region}`
        ///
        /// * For `projects.locations.workflowTemplates.create`, the resource name of
        ///   the location has the following format:
        ///   `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="template">
        /// Required. The Dataproc workflow template to create.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<WorkflowTemplate> CreateWorkflowTemplateAsync(
            RegionName parent,
            WorkflowTemplate template,
            st::CancellationToken cancellationToken) => CreateWorkflowTemplateAsync(
                parent,
                template,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates new workflow template.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        ///
        /// * For `projects.regions.workflowTemplates,create`, the resource name of the
        ///   region has the following format:
        ///   `projects/{project_id}/regions/{region}`
        ///
        /// * For `projects.locations.workflowTemplates.create`, the resource name of
        ///   the location has the following format:
        ///   `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="template">
        /// Required. The Dataproc workflow template to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual WorkflowTemplate CreateWorkflowTemplate(
            RegionName parent,
            WorkflowTemplate template,
            gaxgrpc::CallSettings callSettings = null) => CreateWorkflowTemplate(
                new CreateWorkflowTemplateRequest
                {
                    ParentAsRegionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Template = gax::GaxPreconditions.CheckNotNull(template, nameof(template)),
                },
                callSettings);

        /// <summary>
        /// Creates new workflow template.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        ///
        /// * For `projects.regions.workflowTemplates,create`, the resource name of the
        ///   region has the following format:
        ///   `projects/{project_id}/regions/{region}`
        ///
        /// * For `projects.locations.workflowTemplates.create`, the resource name of
        ///   the location has the following format:
        ///   `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="template">
        /// Required. The Dataproc workflow template to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<WorkflowTemplate> CreateWorkflowTemplateAsync(
            string parent,
            WorkflowTemplate template,
            gaxgrpc::CallSettings callSettings = null) => CreateWorkflowTemplateAsync(
                new CreateWorkflowTemplateRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Template = gax::GaxPreconditions.CheckNotNull(template, nameof(template)),
                },
                callSettings);

        /// <summary>
        /// Creates new workflow template.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        ///
        /// * For `projects.regions.workflowTemplates,create`, the resource name of the
        ///   region has the following format:
        ///   `projects/{project_id}/regions/{region}`
        ///
        /// * For `projects.locations.workflowTemplates.create`, the resource name of
        ///   the location has the following format:
        ///   `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="template">
        /// Required. The Dataproc workflow template to create.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<WorkflowTemplate> CreateWorkflowTemplateAsync(
            string parent,
            WorkflowTemplate template,
            st::CancellationToken cancellationToken) => CreateWorkflowTemplateAsync(
                parent,
                template,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates new workflow template.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        ///
        /// * For `projects.regions.workflowTemplates,create`, the resource name of the
        ///   region has the following format:
        ///   `projects/{project_id}/regions/{region}`
        ///
        /// * For `projects.locations.workflowTemplates.create`, the resource name of
        ///   the location has the following format:
        ///   `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="template">
        /// Required. The Dataproc workflow template to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual WorkflowTemplate CreateWorkflowTemplate(
            string parent,
            WorkflowTemplate template,
            gaxgrpc::CallSettings callSettings = null) => CreateWorkflowTemplate(
                new CreateWorkflowTemplateRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Template = gax::GaxPreconditions.CheckNotNull(template, nameof(template)),
                },
                callSettings);

        /// <summary>
        /// Creates new workflow template.
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
        public virtual stt::Task<WorkflowTemplate> CreateWorkflowTemplateAsync(
            CreateWorkflowTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates new workflow template.
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
        public virtual stt::Task<WorkflowTemplate> CreateWorkflowTemplateAsync(
            CreateWorkflowTemplateRequest request,
            st::CancellationToken cancellationToken) => CreateWorkflowTemplateAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates new workflow template.
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
        public virtual WorkflowTemplate CreateWorkflowTemplate(
            CreateWorkflowTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Retrieves the latest workflow template.
        ///
        /// Can retrieve previously instantiated template by specifying optional
        /// version parameter.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the workflow template, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        ///
        /// * For `projects.regions.workflowTemplates.get`, the resource name of the
        ///   template has the following format:
        ///   `projects/{project_id}/regions/{region}/workflowTemplates/{template_id}`
        ///
        /// * For `projects.locations.workflowTemplates.get`, the resource name of the
        ///   template has the following format:
        ///   `projects/{project_id}/locations/{location}/workflowTemplates/{template_id}`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<WorkflowTemplate> GetWorkflowTemplateAsync(
            WorkflowTemplateName name,
            gaxgrpc::CallSettings callSettings = null) => GetWorkflowTemplateAsync(
                new GetWorkflowTemplateRequest
                {
                    WorkflowTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Retrieves the latest workflow template.
        ///
        /// Can retrieve previously instantiated template by specifying optional
        /// version parameter.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the workflow template, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        ///
        /// * For `projects.regions.workflowTemplates.get`, the resource name of the
        ///   template has the following format:
        ///   `projects/{project_id}/regions/{region}/workflowTemplates/{template_id}`
        ///
        /// * For `projects.locations.workflowTemplates.get`, the resource name of the
        ///   template has the following format:
        ///   `projects/{project_id}/locations/{location}/workflowTemplates/{template_id}`
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<WorkflowTemplate> GetWorkflowTemplateAsync(
            WorkflowTemplateName name,
            st::CancellationToken cancellationToken) => GetWorkflowTemplateAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the latest workflow template.
        ///
        /// Can retrieve previously instantiated template by specifying optional
        /// version parameter.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the workflow template, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        ///
        /// * For `projects.regions.workflowTemplates.get`, the resource name of the
        ///   template has the following format:
        ///   `projects/{project_id}/regions/{region}/workflowTemplates/{template_id}`
        ///
        /// * For `projects.locations.workflowTemplates.get`, the resource name of the
        ///   template has the following format:
        ///   `projects/{project_id}/locations/{location}/workflowTemplates/{template_id}`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual WorkflowTemplate GetWorkflowTemplate(
            WorkflowTemplateName name,
            gaxgrpc::CallSettings callSettings = null) => GetWorkflowTemplate(
                new GetWorkflowTemplateRequest
                {
                    WorkflowTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Retrieves the latest workflow template.
        ///
        /// Can retrieve previously instantiated template by specifying optional
        /// version parameter.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the workflow template, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        ///
        /// * For `projects.regions.workflowTemplates.get`, the resource name of the
        ///   template has the following format:
        ///   `projects/{project_id}/regions/{region}/workflowTemplates/{template_id}`
        ///
        /// * For `projects.locations.workflowTemplates.get`, the resource name of the
        ///   template has the following format:
        ///   `projects/{project_id}/locations/{location}/workflowTemplates/{template_id}`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<WorkflowTemplate> GetWorkflowTemplateAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetWorkflowTemplateAsync(
                new GetWorkflowTemplateRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Retrieves the latest workflow template.
        ///
        /// Can retrieve previously instantiated template by specifying optional
        /// version parameter.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the workflow template, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        ///
        /// * For `projects.regions.workflowTemplates.get`, the resource name of the
        ///   template has the following format:
        ///   `projects/{project_id}/regions/{region}/workflowTemplates/{template_id}`
        ///
        /// * For `projects.locations.workflowTemplates.get`, the resource name of the
        ///   template has the following format:
        ///   `projects/{project_id}/locations/{location}/workflowTemplates/{template_id}`
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<WorkflowTemplate> GetWorkflowTemplateAsync(
            string name,
            st::CancellationToken cancellationToken) => GetWorkflowTemplateAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the latest workflow template.
        ///
        /// Can retrieve previously instantiated template by specifying optional
        /// version parameter.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the workflow template, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        ///
        /// * For `projects.regions.workflowTemplates.get`, the resource name of the
        ///   template has the following format:
        ///   `projects/{project_id}/regions/{region}/workflowTemplates/{template_id}`
        ///
        /// * For `projects.locations.workflowTemplates.get`, the resource name of the
        ///   template has the following format:
        ///   `projects/{project_id}/locations/{location}/workflowTemplates/{template_id}`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual WorkflowTemplate GetWorkflowTemplate(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetWorkflowTemplate(
                new GetWorkflowTemplateRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Retrieves the latest workflow template.
        ///
        /// Can retrieve previously instantiated template by specifying optional
        /// version parameter.
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
        public virtual stt::Task<WorkflowTemplate> GetWorkflowTemplateAsync(
            GetWorkflowTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Retrieves the latest workflow template.
        ///
        /// Can retrieve previously instantiated template by specifying optional
        /// version parameter.
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
        public virtual stt::Task<WorkflowTemplate> GetWorkflowTemplateAsync(
            GetWorkflowTemplateRequest request,
            st::CancellationToken cancellationToken) => GetWorkflowTemplateAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the latest workflow template.
        ///
        /// Can retrieve previously instantiated template by specifying optional
        /// version parameter.
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
        public virtual WorkflowTemplate GetWorkflowTemplate(
            GetWorkflowTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Instantiates a template and begins execution.
        ///
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        ///
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        ///
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        ///
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the workflow template, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        ///
        /// * For `projects.regions.workflowTemplates.instantiate`, the resource name
        /// of the template has the following format:
        ///   `projects/{project_id}/regions/{region}/workflowTemplates/{template_id}`
        ///
        /// * For `projects.locations.workflowTemplates.instantiate`, the resource name
        ///   of the template has the following format:
        ///   `projects/{project_id}/locations/{location}/workflowTemplates/{template_id}`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, WorkflowMetadata>> InstantiateWorkflowTemplateAsync(
            WorkflowTemplateName name,
            gaxgrpc::CallSettings callSettings = null) => InstantiateWorkflowTemplateAsync(
                new InstantiateWorkflowTemplateRequest
                {
                    WorkflowTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Instantiates a template and begins execution.
        ///
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        ///
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        ///
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        ///
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the workflow template, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        ///
        /// * For `projects.regions.workflowTemplates.instantiate`, the resource name
        /// of the template has the following format:
        ///   `projects/{project_id}/regions/{region}/workflowTemplates/{template_id}`
        ///
        /// * For `projects.locations.workflowTemplates.instantiate`, the resource name
        ///   of the template has the following format:
        ///   `projects/{project_id}/locations/{location}/workflowTemplates/{template_id}`
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, WorkflowMetadata>> InstantiateWorkflowTemplateAsync(
            WorkflowTemplateName name,
            st::CancellationToken cancellationToken) => InstantiateWorkflowTemplateAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Instantiates a template and begins execution.
        ///
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        ///
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        ///
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        ///
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the workflow template, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        ///
        /// * For `projects.regions.workflowTemplates.instantiate`, the resource name
        /// of the template has the following format:
        ///   `projects/{project_id}/regions/{region}/workflowTemplates/{template_id}`
        ///
        /// * For `projects.locations.workflowTemplates.instantiate`, the resource name
        ///   of the template has the following format:
        ///   `projects/{project_id}/locations/{location}/workflowTemplates/{template_id}`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<pbwkt::Empty, WorkflowMetadata> InstantiateWorkflowTemplate(
            WorkflowTemplateName name,
            gaxgrpc::CallSettings callSettings = null) => InstantiateWorkflowTemplate(
                new InstantiateWorkflowTemplateRequest
                {
                    WorkflowTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Instantiates a template and begins execution.
        ///
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        ///
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        ///
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        ///
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the workflow template, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        ///
        /// * For `projects.regions.workflowTemplates.instantiate`, the resource name
        /// of the template has the following format:
        ///   `projects/{project_id}/regions/{region}/workflowTemplates/{template_id}`
        ///
        /// * For `projects.locations.workflowTemplates.instantiate`, the resource name
        ///   of the template has the following format:
        ///   `projects/{project_id}/locations/{location}/workflowTemplates/{template_id}`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, WorkflowMetadata>> InstantiateWorkflowTemplateAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => InstantiateWorkflowTemplateAsync(
                new InstantiateWorkflowTemplateRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Instantiates a template and begins execution.
        ///
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        ///
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        ///
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        ///
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the workflow template, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        ///
        /// * For `projects.regions.workflowTemplates.instantiate`, the resource name
        /// of the template has the following format:
        ///   `projects/{project_id}/regions/{region}/workflowTemplates/{template_id}`
        ///
        /// * For `projects.locations.workflowTemplates.instantiate`, the resource name
        ///   of the template has the following format:
        ///   `projects/{project_id}/locations/{location}/workflowTemplates/{template_id}`
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, WorkflowMetadata>> InstantiateWorkflowTemplateAsync(
            string name,
            st::CancellationToken cancellationToken) => InstantiateWorkflowTemplateAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Instantiates a template and begins execution.
        ///
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        ///
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        ///
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        ///
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the workflow template, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        ///
        /// * For `projects.regions.workflowTemplates.instantiate`, the resource name
        /// of the template has the following format:
        ///   `projects/{project_id}/regions/{region}/workflowTemplates/{template_id}`
        ///
        /// * For `projects.locations.workflowTemplates.instantiate`, the resource name
        ///   of the template has the following format:
        ///   `projects/{project_id}/locations/{location}/workflowTemplates/{template_id}`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<pbwkt::Empty, WorkflowMetadata> InstantiateWorkflowTemplate(
            string name,
            gaxgrpc::CallSettings callSettings = null) => InstantiateWorkflowTemplate(
                new InstantiateWorkflowTemplateRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Instantiates a template and begins execution.
        ///
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        ///
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        ///
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        ///
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the workflow template, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        ///
        /// * For `projects.regions.workflowTemplates.instantiate`, the resource name
        /// of the template has the following format:
        ///   `projects/{project_id}/regions/{region}/workflowTemplates/{template_id}`
        ///
        /// * For `projects.locations.workflowTemplates.instantiate`, the resource name
        ///   of the template has the following format:
        ///   `projects/{project_id}/locations/{location}/workflowTemplates/{template_id}`
        /// </param>
        /// <param name="parameters">
        /// Optional. Map from parameter names to values that should be used for those
        /// parameters. Values may not exceed 100 characters.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, WorkflowMetadata>> InstantiateWorkflowTemplateAsync(
            WorkflowTemplateName name,
            scg::IDictionary<string, string> parameters,
            gaxgrpc::CallSettings callSettings = null) => InstantiateWorkflowTemplateAsync(
                new InstantiateWorkflowTemplateRequest
                {
                    WorkflowTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    Parameters = { parameters ?? gax::EmptyDictionary<string, string>.Instance }, // Optional
                },
                callSettings);

        /// <summary>
        /// Instantiates a template and begins execution.
        ///
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        ///
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        ///
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        ///
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the workflow template, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        ///
        /// * For `projects.regions.workflowTemplates.instantiate`, the resource name
        /// of the template has the following format:
        ///   `projects/{project_id}/regions/{region}/workflowTemplates/{template_id}`
        ///
        /// * For `projects.locations.workflowTemplates.instantiate`, the resource name
        ///   of the template has the following format:
        ///   `projects/{project_id}/locations/{location}/workflowTemplates/{template_id}`
        /// </param>
        /// <param name="parameters">
        /// Optional. Map from parameter names to values that should be used for those
        /// parameters. Values may not exceed 100 characters.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, WorkflowMetadata>> InstantiateWorkflowTemplateAsync(
            WorkflowTemplateName name,
            scg::IDictionary<string, string> parameters,
            st::CancellationToken cancellationToken) => InstantiateWorkflowTemplateAsync(
                name,
                parameters,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Instantiates a template and begins execution.
        ///
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        ///
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        ///
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        ///
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the workflow template, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        ///
        /// * For `projects.regions.workflowTemplates.instantiate`, the resource name
        /// of the template has the following format:
        ///   `projects/{project_id}/regions/{region}/workflowTemplates/{template_id}`
        ///
        /// * For `projects.locations.workflowTemplates.instantiate`, the resource name
        ///   of the template has the following format:
        ///   `projects/{project_id}/locations/{location}/workflowTemplates/{template_id}`
        /// </param>
        /// <param name="parameters">
        /// Optional. Map from parameter names to values that should be used for those
        /// parameters. Values may not exceed 100 characters.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<pbwkt::Empty, WorkflowMetadata> InstantiateWorkflowTemplate(
            WorkflowTemplateName name,
            scg::IDictionary<string, string> parameters,
            gaxgrpc::CallSettings callSettings = null) => InstantiateWorkflowTemplate(
                new InstantiateWorkflowTemplateRequest
                {
                    WorkflowTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    Parameters = { parameters ?? gax::EmptyDictionary<string, string>.Instance }, // Optional
                },
                callSettings);

        /// <summary>
        /// Instantiates a template and begins execution.
        ///
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        ///
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        ///
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        ///
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the workflow template, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        ///
        /// * For `projects.regions.workflowTemplates.instantiate`, the resource name
        /// of the template has the following format:
        ///   `projects/{project_id}/regions/{region}/workflowTemplates/{template_id}`
        ///
        /// * For `projects.locations.workflowTemplates.instantiate`, the resource name
        ///   of the template has the following format:
        ///   `projects/{project_id}/locations/{location}/workflowTemplates/{template_id}`
        /// </param>
        /// <param name="parameters">
        /// Optional. Map from parameter names to values that should be used for those
        /// parameters. Values may not exceed 100 characters.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, WorkflowMetadata>> InstantiateWorkflowTemplateAsync(
            string name,
            scg::IDictionary<string, string> parameters,
            gaxgrpc::CallSettings callSettings = null) => InstantiateWorkflowTemplateAsync(
                new InstantiateWorkflowTemplateRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    Parameters = { parameters ?? gax::EmptyDictionary<string, string>.Instance }, // Optional
                },
                callSettings);

        /// <summary>
        /// Instantiates a template and begins execution.
        ///
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        ///
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        ///
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        ///
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the workflow template, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        ///
        /// * For `projects.regions.workflowTemplates.instantiate`, the resource name
        /// of the template has the following format:
        ///   `projects/{project_id}/regions/{region}/workflowTemplates/{template_id}`
        ///
        /// * For `projects.locations.workflowTemplates.instantiate`, the resource name
        ///   of the template has the following format:
        ///   `projects/{project_id}/locations/{location}/workflowTemplates/{template_id}`
        /// </param>
        /// <param name="parameters">
        /// Optional. Map from parameter names to values that should be used for those
        /// parameters. Values may not exceed 100 characters.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, WorkflowMetadata>> InstantiateWorkflowTemplateAsync(
            string name,
            scg::IDictionary<string, string> parameters,
            st::CancellationToken cancellationToken) => InstantiateWorkflowTemplateAsync(
                name,
                parameters,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Instantiates a template and begins execution.
        ///
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        ///
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        ///
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        ///
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the workflow template, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        ///
        /// * For `projects.regions.workflowTemplates.instantiate`, the resource name
        /// of the template has the following format:
        ///   `projects/{project_id}/regions/{region}/workflowTemplates/{template_id}`
        ///
        /// * For `projects.locations.workflowTemplates.instantiate`, the resource name
        ///   of the template has the following format:
        ///   `projects/{project_id}/locations/{location}/workflowTemplates/{template_id}`
        /// </param>
        /// <param name="parameters">
        /// Optional. Map from parameter names to values that should be used for those
        /// parameters. Values may not exceed 100 characters.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<pbwkt::Empty, WorkflowMetadata> InstantiateWorkflowTemplate(
            string name,
            scg::IDictionary<string, string> parameters,
            gaxgrpc::CallSettings callSettings = null) => InstantiateWorkflowTemplate(
                new InstantiateWorkflowTemplateRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    Parameters = { parameters ?? gax::EmptyDictionary<string, string>.Instance }, // Optional
                },
                callSettings);

        /// <summary>
        /// Instantiates a template and begins execution.
        ///
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        ///
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        ///
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        ///
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
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
        public virtual stt::Task<lro::Operation<pbwkt::Empty, WorkflowMetadata>> InstantiateWorkflowTemplateAsync(
            InstantiateWorkflowTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>InstantiateWorkflowTemplateAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, WorkflowMetadata>> PollOnceInstantiateWorkflowTemplateAsync(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<pbwkt::Empty, WorkflowMetadata>.PollOnceFromNameAsync(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                InstantiateWorkflowTemplateOperationsClient,
                callSettings);

        /// <summary>
        /// Instantiates a template and begins execution.
        ///
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        ///
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        ///
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        ///
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
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
        public virtual lro::Operation<pbwkt::Empty, WorkflowMetadata> InstantiateWorkflowTemplate(
            InstantiateWorkflowTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>InstantiateWorkflowTemplate</c>.
        /// </summary>
        public virtual lro::OperationsClient InstantiateWorkflowTemplateOperationsClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>InstantiateWorkflowTemplate</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<pbwkt::Empty, WorkflowMetadata> PollOnceInstantiateWorkflowTemplate(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<pbwkt::Empty, WorkflowMetadata>.PollOnceFromName(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                InstantiateWorkflowTemplateOperationsClient,
                callSettings);

        /// <summary>
        /// Instantiates a template and begins execution.
        ///
        /// This method is equivalent to executing the sequence
        /// [CreateWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.CreateWorkflowTemplate], [InstantiateWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.InstantiateWorkflowTemplate],
        /// [DeleteWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.DeleteWorkflowTemplate].
        ///
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        ///
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        ///
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        ///
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        ///
        /// * For `projects.regions.workflowTemplates,instantiateinline`, the resource
        ///   name of the region has the following format:
        ///   `projects/{project_id}/regions/{region}`
        ///
        /// * For `projects.locations.workflowTemplates.instantiateinline`, the
        ///   resource name of the location has the following format:
        ///   `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="template">
        /// Required. The workflow template to instantiate.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, WorkflowMetadata>> InstantiateInlineWorkflowTemplateAsync(
            RegionName parent,
            WorkflowTemplate template,
            gaxgrpc::CallSettings callSettings = null) => InstantiateInlineWorkflowTemplateAsync(
                new InstantiateInlineWorkflowTemplateRequest
                {
                    ParentAsRegionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Template = gax::GaxPreconditions.CheckNotNull(template, nameof(template)),
                },
                callSettings);

        /// <summary>
        /// Instantiates a template and begins execution.
        ///
        /// This method is equivalent to executing the sequence
        /// [CreateWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.CreateWorkflowTemplate], [InstantiateWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.InstantiateWorkflowTemplate],
        /// [DeleteWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.DeleteWorkflowTemplate].
        ///
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        ///
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        ///
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        ///
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        ///
        /// * For `projects.regions.workflowTemplates,instantiateinline`, the resource
        ///   name of the region has the following format:
        ///   `projects/{project_id}/regions/{region}`
        ///
        /// * For `projects.locations.workflowTemplates.instantiateinline`, the
        ///   resource name of the location has the following format:
        ///   `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="template">
        /// Required. The workflow template to instantiate.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, WorkflowMetadata>> InstantiateInlineWorkflowTemplateAsync(
            RegionName parent,
            WorkflowTemplate template,
            st::CancellationToken cancellationToken) => InstantiateInlineWorkflowTemplateAsync(
                parent,
                template,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Instantiates a template and begins execution.
        ///
        /// This method is equivalent to executing the sequence
        /// [CreateWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.CreateWorkflowTemplate], [InstantiateWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.InstantiateWorkflowTemplate],
        /// [DeleteWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.DeleteWorkflowTemplate].
        ///
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        ///
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        ///
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        ///
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        ///
        /// * For `projects.regions.workflowTemplates,instantiateinline`, the resource
        ///   name of the region has the following format:
        ///   `projects/{project_id}/regions/{region}`
        ///
        /// * For `projects.locations.workflowTemplates.instantiateinline`, the
        ///   resource name of the location has the following format:
        ///   `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="template">
        /// Required. The workflow template to instantiate.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<pbwkt::Empty, WorkflowMetadata> InstantiateInlineWorkflowTemplate(
            RegionName parent,
            WorkflowTemplate template,
            gaxgrpc::CallSettings callSettings = null) => InstantiateInlineWorkflowTemplate(
                new InstantiateInlineWorkflowTemplateRequest
                {
                    ParentAsRegionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Template = gax::GaxPreconditions.CheckNotNull(template, nameof(template)),
                },
                callSettings);

        /// <summary>
        /// Instantiates a template and begins execution.
        ///
        /// This method is equivalent to executing the sequence
        /// [CreateWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.CreateWorkflowTemplate], [InstantiateWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.InstantiateWorkflowTemplate],
        /// [DeleteWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.DeleteWorkflowTemplate].
        ///
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        ///
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        ///
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        ///
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        ///
        /// * For `projects.regions.workflowTemplates,instantiateinline`, the resource
        ///   name of the region has the following format:
        ///   `projects/{project_id}/regions/{region}`
        ///
        /// * For `projects.locations.workflowTemplates.instantiateinline`, the
        ///   resource name of the location has the following format:
        ///   `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="template">
        /// Required. The workflow template to instantiate.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, WorkflowMetadata>> InstantiateInlineWorkflowTemplateAsync(
            string parent,
            WorkflowTemplate template,
            gaxgrpc::CallSettings callSettings = null) => InstantiateInlineWorkflowTemplateAsync(
                new InstantiateInlineWorkflowTemplateRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Template = gax::GaxPreconditions.CheckNotNull(template, nameof(template)),
                },
                callSettings);

        /// <summary>
        /// Instantiates a template and begins execution.
        ///
        /// This method is equivalent to executing the sequence
        /// [CreateWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.CreateWorkflowTemplate], [InstantiateWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.InstantiateWorkflowTemplate],
        /// [DeleteWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.DeleteWorkflowTemplate].
        ///
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        ///
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        ///
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        ///
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        ///
        /// * For `projects.regions.workflowTemplates,instantiateinline`, the resource
        ///   name of the region has the following format:
        ///   `projects/{project_id}/regions/{region}`
        ///
        /// * For `projects.locations.workflowTemplates.instantiateinline`, the
        ///   resource name of the location has the following format:
        ///   `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="template">
        /// Required. The workflow template to instantiate.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, WorkflowMetadata>> InstantiateInlineWorkflowTemplateAsync(
            string parent,
            WorkflowTemplate template,
            st::CancellationToken cancellationToken) => InstantiateInlineWorkflowTemplateAsync(
                parent,
                template,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Instantiates a template and begins execution.
        ///
        /// This method is equivalent to executing the sequence
        /// [CreateWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.CreateWorkflowTemplate], [InstantiateWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.InstantiateWorkflowTemplate],
        /// [DeleteWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.DeleteWorkflowTemplate].
        ///
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        ///
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        ///
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        ///
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        ///
        /// * For `projects.regions.workflowTemplates,instantiateinline`, the resource
        ///   name of the region has the following format:
        ///   `projects/{project_id}/regions/{region}`
        ///
        /// * For `projects.locations.workflowTemplates.instantiateinline`, the
        ///   resource name of the location has the following format:
        ///   `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="template">
        /// Required. The workflow template to instantiate.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<pbwkt::Empty, WorkflowMetadata> InstantiateInlineWorkflowTemplate(
            string parent,
            WorkflowTemplate template,
            gaxgrpc::CallSettings callSettings = null) => InstantiateInlineWorkflowTemplate(
                new InstantiateInlineWorkflowTemplateRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Template = gax::GaxPreconditions.CheckNotNull(template, nameof(template)),
                },
                callSettings);

        /// <summary>
        /// Instantiates a template and begins execution.
        ///
        /// This method is equivalent to executing the sequence
        /// [CreateWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.CreateWorkflowTemplate], [InstantiateWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.InstantiateWorkflowTemplate],
        /// [DeleteWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.DeleteWorkflowTemplate].
        ///
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        ///
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        ///
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        ///
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
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
        public virtual stt::Task<lro::Operation<pbwkt::Empty, WorkflowMetadata>> InstantiateInlineWorkflowTemplateAsync(
            InstantiateInlineWorkflowTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>InstantiateInlineWorkflowTemplateAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, WorkflowMetadata>> PollOnceInstantiateInlineWorkflowTemplateAsync(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<pbwkt::Empty, WorkflowMetadata>.PollOnceFromNameAsync(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                InstantiateInlineWorkflowTemplateOperationsClient,
                callSettings);

        /// <summary>
        /// Instantiates a template and begins execution.
        ///
        /// This method is equivalent to executing the sequence
        /// [CreateWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.CreateWorkflowTemplate], [InstantiateWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.InstantiateWorkflowTemplate],
        /// [DeleteWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.DeleteWorkflowTemplate].
        ///
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        ///
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        ///
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        ///
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
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
        public virtual lro::Operation<pbwkt::Empty, WorkflowMetadata> InstantiateInlineWorkflowTemplate(
            InstantiateInlineWorkflowTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>InstantiateInlineWorkflowTemplate</c>.
        /// </summary>
        public virtual lro::OperationsClient InstantiateInlineWorkflowTemplateOperationsClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>InstantiateInlineWorkflowTemplate</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<pbwkt::Empty, WorkflowMetadata> PollOnceInstantiateInlineWorkflowTemplate(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<pbwkt::Empty, WorkflowMetadata>.PollOnceFromName(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                InstantiateInlineWorkflowTemplateOperationsClient,
                callSettings);

        /// <summary>
        /// Updates (replaces) workflow template. The updated template
        /// must contain version that matches the current server version.
        /// </summary>
        /// <param name="template">
        /// Required. The updated workflow template.
        ///
        /// The `template.version` field must match the current version.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<WorkflowTemplate> UpdateWorkflowTemplateAsync(
            WorkflowTemplate template,
            gaxgrpc::CallSettings callSettings = null) => UpdateWorkflowTemplateAsync(
                new UpdateWorkflowTemplateRequest
                {
                    Template = gax::GaxPreconditions.CheckNotNull(template, nameof(template)),
                },
                callSettings);

        /// <summary>
        /// Updates (replaces) workflow template. The updated template
        /// must contain version that matches the current server version.
        /// </summary>
        /// <param name="template">
        /// Required. The updated workflow template.
        ///
        /// The `template.version` field must match the current version.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<WorkflowTemplate> UpdateWorkflowTemplateAsync(
            WorkflowTemplate template,
            st::CancellationToken cancellationToken) => UpdateWorkflowTemplateAsync(
                template,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates (replaces) workflow template. The updated template
        /// must contain version that matches the current server version.
        /// </summary>
        /// <param name="template">
        /// Required. The updated workflow template.
        ///
        /// The `template.version` field must match the current version.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual WorkflowTemplate UpdateWorkflowTemplate(
            WorkflowTemplate template,
            gaxgrpc::CallSettings callSettings = null) => UpdateWorkflowTemplate(
                new UpdateWorkflowTemplateRequest
                {
                    Template = gax::GaxPreconditions.CheckNotNull(template, nameof(template)),
                },
                callSettings);

        /// <summary>
        /// Updates (replaces) workflow template. The updated template
        /// must contain version that matches the current server version.
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
        public virtual stt::Task<WorkflowTemplate> UpdateWorkflowTemplateAsync(
            UpdateWorkflowTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates (replaces) workflow template. The updated template
        /// must contain version that matches the current server version.
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
        public virtual stt::Task<WorkflowTemplate> UpdateWorkflowTemplateAsync(
            UpdateWorkflowTemplateRequest request,
            st::CancellationToken cancellationToken) => UpdateWorkflowTemplateAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates (replaces) workflow template. The updated template
        /// must contain version that matches the current server version.
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
        public virtual WorkflowTemplate UpdateWorkflowTemplate(
            UpdateWorkflowTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists workflows that match the specified filter in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        ///
        /// * For `projects.regions.workflowTemplates,list`, the resource
        ///   name of the region has the following format:
        ///   `projects/{project_id}/regions/{region}`
        ///
        /// * For `projects.locations.workflowTemplates.list`, the
        ///   resource name of the location has the following format:
        ///   `projects/{project_id}/locations/{location}`
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
        /// A pageable asynchronous sequence of <see cref="WorkflowTemplate"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkflowTemplatesResponse, WorkflowTemplate> ListWorkflowTemplatesAsync(
            RegionName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListWorkflowTemplatesAsync(
                new ListWorkflowTemplatesRequest
                {
                    ParentAsRegionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists workflows that match the specified filter in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        ///
        /// * For `projects.regions.workflowTemplates,list`, the resource
        ///   name of the region has the following format:
        ///   `projects/{project_id}/regions/{region}`
        ///
        /// * For `projects.locations.workflowTemplates.list`, the
        ///   resource name of the location has the following format:
        ///   `projects/{project_id}/locations/{location}`
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
        /// A pageable sequence of <see cref="WorkflowTemplate"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListWorkflowTemplatesResponse, WorkflowTemplate> ListWorkflowTemplates(
            RegionName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListWorkflowTemplates(
                new ListWorkflowTemplatesRequest
                {
                    ParentAsRegionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists workflows that match the specified filter in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        ///
        /// * For `projects.regions.workflowTemplates,list`, the resource
        ///   name of the region has the following format:
        ///   `projects/{project_id}/regions/{region}`
        ///
        /// * For `projects.locations.workflowTemplates.list`, the
        ///   resource name of the location has the following format:
        ///   `projects/{project_id}/locations/{location}`
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
        /// A pageable asynchronous sequence of <see cref="WorkflowTemplate"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkflowTemplatesResponse, WorkflowTemplate> ListWorkflowTemplatesAsync(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListWorkflowTemplatesAsync(
                new ListWorkflowTemplatesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists workflows that match the specified filter in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        ///
        /// * For `projects.regions.workflowTemplates,list`, the resource
        ///   name of the region has the following format:
        ///   `projects/{project_id}/regions/{region}`
        ///
        /// * For `projects.locations.workflowTemplates.list`, the
        ///   resource name of the location has the following format:
        ///   `projects/{project_id}/locations/{location}`
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
        /// A pageable sequence of <see cref="WorkflowTemplate"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListWorkflowTemplatesResponse, WorkflowTemplate> ListWorkflowTemplates(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListWorkflowTemplates(
                new ListWorkflowTemplatesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists workflows that match the specified filter in the request.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="WorkflowTemplate"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkflowTemplatesResponse, WorkflowTemplate> ListWorkflowTemplatesAsync(
            ListWorkflowTemplatesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists workflows that match the specified filter in the request.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="WorkflowTemplate"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListWorkflowTemplatesResponse, WorkflowTemplate> ListWorkflowTemplates(
            ListWorkflowTemplatesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes a workflow template. It does not cancel in-progress workflows.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the workflow template, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        ///
        /// * For `projects.regions.workflowTemplates.delete`, the resource name
        /// of the template has the following format:
        ///   `projects/{project_id}/regions/{region}/workflowTemplates/{template_id}`
        ///
        /// * For `projects.locations.workflowTemplates.instantiate`, the resource name
        ///   of the template has the following format:
        ///   `projects/{project_id}/locations/{location}/workflowTemplates/{template_id}`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteWorkflowTemplateAsync(
            WorkflowTemplateName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteWorkflowTemplateAsync(
                new DeleteWorkflowTemplateRequest
                {
                    WorkflowTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes a workflow template. It does not cancel in-progress workflows.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the workflow template, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        ///
        /// * For `projects.regions.workflowTemplates.delete`, the resource name
        /// of the template has the following format:
        ///   `projects/{project_id}/regions/{region}/workflowTemplates/{template_id}`
        ///
        /// * For `projects.locations.workflowTemplates.instantiate`, the resource name
        ///   of the template has the following format:
        ///   `projects/{project_id}/locations/{location}/workflowTemplates/{template_id}`
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteWorkflowTemplateAsync(
            WorkflowTemplateName name,
            st::CancellationToken cancellationToken) => DeleteWorkflowTemplateAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a workflow template. It does not cancel in-progress workflows.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the workflow template, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        ///
        /// * For `projects.regions.workflowTemplates.delete`, the resource name
        /// of the template has the following format:
        ///   `projects/{project_id}/regions/{region}/workflowTemplates/{template_id}`
        ///
        /// * For `projects.locations.workflowTemplates.instantiate`, the resource name
        ///   of the template has the following format:
        ///   `projects/{project_id}/locations/{location}/workflowTemplates/{template_id}`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteWorkflowTemplate(
            WorkflowTemplateName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteWorkflowTemplate(
                new DeleteWorkflowTemplateRequest
                {
                    WorkflowTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes a workflow template. It does not cancel in-progress workflows.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the workflow template, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        ///
        /// * For `projects.regions.workflowTemplates.delete`, the resource name
        /// of the template has the following format:
        ///   `projects/{project_id}/regions/{region}/workflowTemplates/{template_id}`
        ///
        /// * For `projects.locations.workflowTemplates.instantiate`, the resource name
        ///   of the template has the following format:
        ///   `projects/{project_id}/locations/{location}/workflowTemplates/{template_id}`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteWorkflowTemplateAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteWorkflowTemplateAsync(
                new DeleteWorkflowTemplateRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes a workflow template. It does not cancel in-progress workflows.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the workflow template, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        ///
        /// * For `projects.regions.workflowTemplates.delete`, the resource name
        /// of the template has the following format:
        ///   `projects/{project_id}/regions/{region}/workflowTemplates/{template_id}`
        ///
        /// * For `projects.locations.workflowTemplates.instantiate`, the resource name
        ///   of the template has the following format:
        ///   `projects/{project_id}/locations/{location}/workflowTemplates/{template_id}`
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteWorkflowTemplateAsync(
            string name,
            st::CancellationToken cancellationToken) => DeleteWorkflowTemplateAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a workflow template. It does not cancel in-progress workflows.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the workflow template, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        ///
        /// * For `projects.regions.workflowTemplates.delete`, the resource name
        /// of the template has the following format:
        ///   `projects/{project_id}/regions/{region}/workflowTemplates/{template_id}`
        ///
        /// * For `projects.locations.workflowTemplates.instantiate`, the resource name
        ///   of the template has the following format:
        ///   `projects/{project_id}/locations/{location}/workflowTemplates/{template_id}`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteWorkflowTemplate(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteWorkflowTemplate(
                new DeleteWorkflowTemplateRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes a workflow template. It does not cancel in-progress workflows.
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
        public virtual stt::Task DeleteWorkflowTemplateAsync(
            DeleteWorkflowTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes a workflow template. It does not cancel in-progress workflows.
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
        public virtual stt::Task DeleteWorkflowTemplateAsync(
            DeleteWorkflowTemplateRequest request,
            st::CancellationToken cancellationToken) => DeleteWorkflowTemplateAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a workflow template. It does not cancel in-progress workflows.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteWorkflowTemplate(
            DeleteWorkflowTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// WorkflowTemplateService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class WorkflowTemplateServiceClientImpl : WorkflowTemplateServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateWorkflowTemplateRequest, WorkflowTemplate> _callCreateWorkflowTemplate;
        private readonly gaxgrpc::ApiCall<GetWorkflowTemplateRequest, WorkflowTemplate> _callGetWorkflowTemplate;
        private readonly gaxgrpc::ApiCall<InstantiateWorkflowTemplateRequest, lro::Operation> _callInstantiateWorkflowTemplate;
        private readonly gaxgrpc::ApiCall<InstantiateInlineWorkflowTemplateRequest, lro::Operation> _callInstantiateInlineWorkflowTemplate;
        private readonly gaxgrpc::ApiCall<UpdateWorkflowTemplateRequest, WorkflowTemplate> _callUpdateWorkflowTemplate;
        private readonly gaxgrpc::ApiCall<ListWorkflowTemplatesRequest, ListWorkflowTemplatesResponse> _callListWorkflowTemplates;
        private readonly gaxgrpc::ApiCall<DeleteWorkflowTemplateRequest, pbwkt::Empty> _callDeleteWorkflowTemplate;

        /// <summary>
        /// Constructs a client wrapper for the WorkflowTemplateService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="WorkflowTemplateServiceSettings"/> used within this client </param>
        public WorkflowTemplateServiceClientImpl(WorkflowTemplateService.WorkflowTemplateServiceClient grpcClient, WorkflowTemplateServiceSettings settings)
        {
            GrpcClient = grpcClient;
            WorkflowTemplateServiceSettings effectiveSettings = settings ?? WorkflowTemplateServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            InstantiateWorkflowTemplateOperationsClient = new lro::OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.InstantiateWorkflowTemplateOperationsSettings);
            InstantiateInlineWorkflowTemplateOperationsClient = new lro::OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.InstantiateInlineWorkflowTemplateOperationsSettings);
            _callCreateWorkflowTemplate = clientHelper.BuildApiCall<CreateWorkflowTemplateRequest, WorkflowTemplate>(
                GrpcClient.CreateWorkflowTemplateAsync, GrpcClient.CreateWorkflowTemplate, effectiveSettings.CreateWorkflowTemplateSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callGetWorkflowTemplate = clientHelper.BuildApiCall<GetWorkflowTemplateRequest, WorkflowTemplate>(
                GrpcClient.GetWorkflowTemplateAsync, GrpcClient.GetWorkflowTemplate, effectiveSettings.GetWorkflowTemplateSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callInstantiateWorkflowTemplate = clientHelper.BuildApiCall<InstantiateWorkflowTemplateRequest, lro::Operation>(
                GrpcClient.InstantiateWorkflowTemplateAsync, GrpcClient.InstantiateWorkflowTemplate, effectiveSettings.InstantiateWorkflowTemplateSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callInstantiateInlineWorkflowTemplate = clientHelper.BuildApiCall<InstantiateInlineWorkflowTemplateRequest, lro::Operation>(
                GrpcClient.InstantiateInlineWorkflowTemplateAsync, GrpcClient.InstantiateInlineWorkflowTemplate, effectiveSettings.InstantiateInlineWorkflowTemplateSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callUpdateWorkflowTemplate = clientHelper.BuildApiCall<UpdateWorkflowTemplateRequest, WorkflowTemplate>(
                GrpcClient.UpdateWorkflowTemplateAsync, GrpcClient.UpdateWorkflowTemplate, effectiveSettings.UpdateWorkflowTemplateSettings)
                .WithGoogleRequestParam("template.name", request => request.Template?.Name);
            _callListWorkflowTemplates = clientHelper.BuildApiCall<ListWorkflowTemplatesRequest, ListWorkflowTemplatesResponse>(
                GrpcClient.ListWorkflowTemplatesAsync, GrpcClient.ListWorkflowTemplates, effectiveSettings.ListWorkflowTemplatesSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callDeleteWorkflowTemplate = clientHelper.BuildApiCall<DeleteWorkflowTemplateRequest, pbwkt::Empty>(
                GrpcClient.DeleteWorkflowTemplateAsync, GrpcClient.DeleteWorkflowTemplate, effectiveSettings.DeleteWorkflowTemplateSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCreateWorkflowTemplate);
            Modify_CreateWorkflowTemplateApiCall(ref _callCreateWorkflowTemplate);
            Modify_ApiCall(ref _callGetWorkflowTemplate);
            Modify_GetWorkflowTemplateApiCall(ref _callGetWorkflowTemplate);
            Modify_ApiCall(ref _callInstantiateWorkflowTemplate);
            Modify_InstantiateWorkflowTemplateApiCall(ref _callInstantiateWorkflowTemplate);
            Modify_ApiCall(ref _callInstantiateInlineWorkflowTemplate);
            Modify_InstantiateInlineWorkflowTemplateApiCall(ref _callInstantiateInlineWorkflowTemplate);
            Modify_ApiCall(ref _callUpdateWorkflowTemplate);
            Modify_UpdateWorkflowTemplateApiCall(ref _callUpdateWorkflowTemplate);
            Modify_ApiCall(ref _callListWorkflowTemplates);
            Modify_ListWorkflowTemplatesApiCall(ref _callListWorkflowTemplates);
            Modify_ApiCall(ref _callDeleteWorkflowTemplate);
            Modify_DeleteWorkflowTemplateApiCall(ref _callDeleteWorkflowTemplate);
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
        partial void Modify_CreateWorkflowTemplateApiCall(ref gaxgrpc::ApiCall<CreateWorkflowTemplateRequest, WorkflowTemplate> call);
        partial void Modify_GetWorkflowTemplateApiCall(ref gaxgrpc::ApiCall<GetWorkflowTemplateRequest, WorkflowTemplate> call);
        partial void Modify_InstantiateWorkflowTemplateApiCall(ref gaxgrpc::ApiCall<InstantiateWorkflowTemplateRequest, lro::Operation> call);
        partial void Modify_InstantiateInlineWorkflowTemplateApiCall(ref gaxgrpc::ApiCall<InstantiateInlineWorkflowTemplateRequest, lro::Operation> call);
        partial void Modify_UpdateWorkflowTemplateApiCall(ref gaxgrpc::ApiCall<UpdateWorkflowTemplateRequest, WorkflowTemplate> call);
        partial void Modify_ListWorkflowTemplatesApiCall(ref gaxgrpc::ApiCall<ListWorkflowTemplatesRequest, ListWorkflowTemplatesResponse> call);
        partial void Modify_DeleteWorkflowTemplateApiCall(ref gaxgrpc::ApiCall<DeleteWorkflowTemplateRequest, pbwkt::Empty> call);
        partial void OnConstruction(WorkflowTemplateService.WorkflowTemplateServiceClient grpcClient, WorkflowTemplateServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC WorkflowTemplateService client.
        /// </summary>
        public override WorkflowTemplateService.WorkflowTemplateServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_CreateWorkflowTemplateRequest(ref CreateWorkflowTemplateRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetWorkflowTemplateRequest(ref GetWorkflowTemplateRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_InstantiateWorkflowTemplateRequest(ref InstantiateWorkflowTemplateRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_InstantiateInlineWorkflowTemplateRequest(ref InstantiateInlineWorkflowTemplateRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateWorkflowTemplateRequest(ref UpdateWorkflowTemplateRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListWorkflowTemplatesRequest(ref ListWorkflowTemplatesRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteWorkflowTemplateRequest(ref DeleteWorkflowTemplateRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates new workflow template.
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
        public override stt::Task<WorkflowTemplate> CreateWorkflowTemplateAsync(
            CreateWorkflowTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateWorkflowTemplateRequest(ref request, ref callSettings);
            return _callCreateWorkflowTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Creates new workflow template.
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
        public override WorkflowTemplate CreateWorkflowTemplate(
            CreateWorkflowTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateWorkflowTemplateRequest(ref request, ref callSettings);
            return _callCreateWorkflowTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the latest workflow template.
        ///
        /// Can retrieve previously instantiated template by specifying optional
        /// version parameter.
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
        public override stt::Task<WorkflowTemplate> GetWorkflowTemplateAsync(
            GetWorkflowTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetWorkflowTemplateRequest(ref request, ref callSettings);
            return _callGetWorkflowTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves the latest workflow template.
        ///
        /// Can retrieve previously instantiated template by specifying optional
        /// version parameter.
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
        public override WorkflowTemplate GetWorkflowTemplate(
            GetWorkflowTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetWorkflowTemplateRequest(ref request, ref callSettings);
            return _callGetWorkflowTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Instantiates a template and begins execution.
        ///
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        ///
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        ///
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        ///
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
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
        public override async stt::Task<lro::Operation<pbwkt::Empty, WorkflowMetadata>> InstantiateWorkflowTemplateAsync(
            InstantiateWorkflowTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InstantiateWorkflowTemplateRequest(ref request, ref callSettings);
            return new lro::Operation<pbwkt::Empty, WorkflowMetadata>(
                await _callInstantiateWorkflowTemplate.Async(request, callSettings).ConfigureAwait(false), InstantiateWorkflowTemplateOperationsClient);
        }

        /// <summary>
        /// Instantiates a template and begins execution.
        ///
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        ///
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        ///
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        ///
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
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
        public override lro::Operation<pbwkt::Empty, WorkflowMetadata> InstantiateWorkflowTemplate(
            InstantiateWorkflowTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InstantiateWorkflowTemplateRequest(ref request, ref callSettings);
            return new lro::Operation<pbwkt::Empty, WorkflowMetadata>(
                _callInstantiateWorkflowTemplate.Sync(request, callSettings), InstantiateWorkflowTemplateOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>InstantiateWorkflowTemplate</c>.
        /// </summary>
        public override lro::OperationsClient InstantiateWorkflowTemplateOperationsClient { get; }

        /// <summary>
        /// Instantiates a template and begins execution.
        ///
        /// This method is equivalent to executing the sequence
        /// [CreateWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.CreateWorkflowTemplate], [InstantiateWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.InstantiateWorkflowTemplate],
        /// [DeleteWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.DeleteWorkflowTemplate].
        ///
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        ///
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        ///
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        ///
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
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
        public override async stt::Task<lro::Operation<pbwkt::Empty, WorkflowMetadata>> InstantiateInlineWorkflowTemplateAsync(
            InstantiateInlineWorkflowTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InstantiateInlineWorkflowTemplateRequest(ref request, ref callSettings);
            return new lro::Operation<pbwkt::Empty, WorkflowMetadata>(
                await _callInstantiateInlineWorkflowTemplate.Async(request, callSettings).ConfigureAwait(false), InstantiateInlineWorkflowTemplateOperationsClient);
        }

        /// <summary>
        /// Instantiates a template and begins execution.
        ///
        /// This method is equivalent to executing the sequence
        /// [CreateWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.CreateWorkflowTemplate], [InstantiateWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.InstantiateWorkflowTemplate],
        /// [DeleteWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.DeleteWorkflowTemplate].
        ///
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        ///
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        ///
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        ///
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
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
        public override lro::Operation<pbwkt::Empty, WorkflowMetadata> InstantiateInlineWorkflowTemplate(
            InstantiateInlineWorkflowTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InstantiateInlineWorkflowTemplateRequest(ref request, ref callSettings);
            return new lro::Operation<pbwkt::Empty, WorkflowMetadata>(
                _callInstantiateInlineWorkflowTemplate.Sync(request, callSettings), InstantiateInlineWorkflowTemplateOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>InstantiateInlineWorkflowTemplate</c>.
        /// </summary>
        public override lro::OperationsClient InstantiateInlineWorkflowTemplateOperationsClient { get; }

        /// <summary>
        /// Updates (replaces) workflow template. The updated template
        /// must contain version that matches the current server version.
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
        public override stt::Task<WorkflowTemplate> UpdateWorkflowTemplateAsync(
            UpdateWorkflowTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateWorkflowTemplateRequest(ref request, ref callSettings);
            return _callUpdateWorkflowTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Updates (replaces) workflow template. The updated template
        /// must contain version that matches the current server version.
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
        public override WorkflowTemplate UpdateWorkflowTemplate(
            UpdateWorkflowTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateWorkflowTemplateRequest(ref request, ref callSettings);
            return _callUpdateWorkflowTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists workflows that match the specified filter in the request.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="WorkflowTemplate"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListWorkflowTemplatesResponse, WorkflowTemplate> ListWorkflowTemplatesAsync(
            ListWorkflowTemplatesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListWorkflowTemplatesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListWorkflowTemplatesRequest, ListWorkflowTemplatesResponse, WorkflowTemplate>(_callListWorkflowTemplates, request, callSettings);
        }

        /// <summary>
        /// Lists workflows that match the specified filter in the request.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="WorkflowTemplate"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListWorkflowTemplatesResponse, WorkflowTemplate> ListWorkflowTemplates(
            ListWorkflowTemplatesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListWorkflowTemplatesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListWorkflowTemplatesRequest, ListWorkflowTemplatesResponse, WorkflowTemplate>(_callListWorkflowTemplates, request, callSettings);
        }

        /// <summary>
        /// Deletes a workflow template. It does not cancel in-progress workflows.
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
        public override stt::Task DeleteWorkflowTemplateAsync(
            DeleteWorkflowTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteWorkflowTemplateRequest(ref request, ref callSettings);
            return _callDeleteWorkflowTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a workflow template. It does not cancel in-progress workflows.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteWorkflowTemplate(
            DeleteWorkflowTemplateRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteWorkflowTemplateRequest(ref request, ref callSettings);
            _callDeleteWorkflowTemplate.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListWorkflowTemplatesRequest : gaxgrpc::IPageRequest { }
    public partial class ListWorkflowTemplatesResponse : gaxgrpc::IPageResponse<WorkflowTemplate>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<WorkflowTemplate> GetEnumerator() => Templates.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    // Partial Grpc class to enable LRO client creation
    public static partial class WorkflowTemplateService
    {
        public partial class WorkflowTemplateServiceClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() => new lro::Operations.OperationsClient(CallInvoker);
        }
    }


}
