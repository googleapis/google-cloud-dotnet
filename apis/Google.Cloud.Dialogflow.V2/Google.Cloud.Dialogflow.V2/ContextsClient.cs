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
    /// Settings for a <see cref="ContextsClient"/>.
    /// </summary>
    public sealed partial class ContextsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="ContextsSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="ContextsSettings"/>.
        /// </returns>
        public static ContextsSettings GetDefault() => new ContextsSettings();

        /// <summary>
        /// Constructs a new <see cref="ContextsSettings"/> object with default settings.
        /// </summary>
        public ContextsSettings() { }

        private ContextsSettings(ContextsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListContextsSettings = existing.ListContextsSettings;
            GetContextSettings = existing.GetContextSettings;
            CreateContextSettings = existing.CreateContextSettings;
            UpdateContextSettings = existing.UpdateContextSettings;
            DeleteContextSettings = existing.DeleteContextSettings;
            DeleteAllContextsSettings = existing.DeleteAllContextsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ContextsSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="ContextsClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="ContextsClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="ContextsClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="ContextsClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="ContextsClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="ContextsClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="ContextsClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="ContextsClient"/> RPC methods is defined as:
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
        /// <c>ContextsClient.ListContexts</c> and <c>ContextsClient.ListContextsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ContextsClient.ListContexts</c> and
        /// <c>ContextsClient.ListContextsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListContextsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContextsClient.GetContext</c> and <c>ContextsClient.GetContextAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ContextsClient.GetContext</c> and
        /// <c>ContextsClient.GetContextAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetContextSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContextsClient.CreateContext</c> and <c>ContextsClient.CreateContextAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ContextsClient.CreateContext</c> and
        /// <c>ContextsClient.CreateContextAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings CreateContextSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContextsClient.UpdateContext</c> and <c>ContextsClient.UpdateContextAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ContextsClient.UpdateContext</c> and
        /// <c>ContextsClient.UpdateContextAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings UpdateContextSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContextsClient.DeleteContext</c> and <c>ContextsClient.DeleteContextAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ContextsClient.DeleteContext</c> and
        /// <c>ContextsClient.DeleteContextAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings DeleteContextSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContextsClient.DeleteAllContexts</c> and <c>ContextsClient.DeleteAllContextsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ContextsClient.DeleteAllContexts</c> and
        /// <c>ContextsClient.DeleteAllContextsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings DeleteAllContextsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="ContextsSettings"/> object.</returns>
        public ContextsSettings Clone() => new ContextsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ContextsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class ContextsClientBuilder : gaxgrpc::ClientBuilderBase<ContextsClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public ContextsSettings Settings { get; set; }

        /// <inheritdoc/>
        public override ContextsClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ContextsClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<ContextsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ContextsClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => ContextsClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => ContextsClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => ContextsClient.ChannelPool;
    }

    /// <summary>
    /// Contexts client wrapper, for convenient use.
    /// </summary>
    public abstract partial class ContextsClient
    {
        /// <summary>
        /// The default endpoint for the Contexts service, which is a host of "dialogflow.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("dialogflow.googleapis.com", 443);

        /// <summary>
        /// The default Contexts scopes.
        /// </summary>
        /// <remarks>
        /// The default Contexts scopes are:
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
        /// Asynchronously creates a <see cref="ContextsClient"/>, applying defaults for all unspecified settings,
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
        /// ContextsClient client = await ContextsClient.CreateAsync();
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
        ///     ContextsClient.DefaultEndpoint.Host, ContextsClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ContextsClient client = ContextsClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ContextsSettings"/>.</param>
        /// <returns>The task representing the created <see cref="ContextsClient"/>.</returns>
        public static async stt::Task<ContextsClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, ContextsSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="ContextsClient"/>, applying defaults for all unspecified settings,
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
        /// ContextsClient client = ContextsClient.Create();
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
        ///     ContextsClient.DefaultEndpoint.Host, ContextsClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ContextsClient client = ContextsClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ContextsSettings"/>.</param>
        /// <returns>The created <see cref="ContextsClient"/>.</returns>
        public static ContextsClient Create(gaxgrpc::ServiceEndpoint endpoint = null, ContextsSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="ContextsClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="ContextsSettings"/>.</param>
        /// <returns>The created <see cref="ContextsClient"/>.</returns>
        public static ContextsClient Create(grpccore::Channel channel, ContextsSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="ContextsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="ContextsSettings"/>.</param>
        /// <returns>The created <see cref="ContextsClient"/>.</returns>
        public static ContextsClient Create(grpccore::CallInvoker callInvoker, ContextsSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Contexts.ContextsClient grpcClient = new Contexts.ContextsClient(callInvoker);
            return new ContextsClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, ContextsSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, ContextsSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, ContextsSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, ContextsSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC Contexts client.
        /// </summary>
        public virtual Contexts.ContextsClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Returns the list of all contexts in the specified session.
        /// </summary>
        /// <param name="parent">
        /// Required. The session to list all contexts from.
        /// Format: `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;`.
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
        /// A pageable asynchronous sequence of <see cref="Context"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListContextsResponse, Context> ListContextsAsync(
            SessionName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListContextsAsync(
                new ListContextsRequest
                {
                    ParentAsSessionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns the list of all contexts in the specified session.
        /// </summary>
        /// <param name="parent">
        /// Required. The session to list all contexts from.
        /// Format: `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;`.
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
        /// A pageable sequence of <see cref="Context"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListContextsResponse, Context> ListContexts(
            SessionName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListContexts(
                new ListContextsRequest
                {
                    ParentAsSessionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns the list of all contexts in the specified session.
        /// </summary>
        /// <param name="parent">
        /// Required. The session to list all contexts from.
        /// Format: `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;`.
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
        /// A pageable asynchronous sequence of <see cref="Context"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListContextsResponse, Context> ListContextsAsync(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListContextsAsync(
                new ListContextsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns the list of all contexts in the specified session.
        /// </summary>
        /// <param name="parent">
        /// Required. The session to list all contexts from.
        /// Format: `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;`.
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
        /// A pageable sequence of <see cref="Context"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListContextsResponse, Context> ListContexts(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListContexts(
                new ListContextsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns the list of all contexts in the specified session.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Context"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListContextsResponse, Context> ListContextsAsync(
            ListContextsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns the list of all contexts in the specified session.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Context"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListContextsResponse, Context> ListContexts(
            ListContextsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Retrieves the specified context.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the context. Format:
        /// `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;/contexts/&lt;Context ID&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Context> GetContextAsync(
            ContextName name,
            gaxgrpc::CallSettings callSettings = null) => GetContextAsync(
                new GetContextRequest
                {
                    ContextName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Retrieves the specified context.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the context. Format:
        /// `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;/contexts/&lt;Context ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Context> GetContextAsync(
            ContextName name,
            st::CancellationToken cancellationToken) => GetContextAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified context.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the context. Format:
        /// `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;/contexts/&lt;Context ID&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Context GetContext(
            ContextName name,
            gaxgrpc::CallSettings callSettings = null) => GetContext(
                new GetContextRequest
                {
                    ContextName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Retrieves the specified context.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the context. Format:
        /// `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;/contexts/&lt;Context ID&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Context> GetContextAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetContextAsync(
                new GetContextRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Retrieves the specified context.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the context. Format:
        /// `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;/contexts/&lt;Context ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Context> GetContextAsync(
            string name,
            st::CancellationToken cancellationToken) => GetContextAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified context.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the context. Format:
        /// `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;/contexts/&lt;Context ID&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Context GetContext(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetContext(
                new GetContextRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Retrieves the specified context.
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
        public virtual stt::Task<Context> GetContextAsync(
            GetContextRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Retrieves the specified context.
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
        public virtual stt::Task<Context> GetContextAsync(
            GetContextRequest request,
            st::CancellationToken cancellationToken) => GetContextAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified context.
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
        public virtual Context GetContext(
            GetContextRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a context.
        ///
        /// If the specified context already exists, overrides the context.
        /// </summary>
        /// <param name="parent">
        /// Required. The session to create a context for.
        /// Format: `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;`.
        /// </param>
        /// <param name="context">
        /// Required. The context to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Context> CreateContextAsync(
            SessionName parent,
            Context context,
            gaxgrpc::CallSettings callSettings = null) => CreateContextAsync(
                new CreateContextRequest
                {
                    ParentAsSessionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Context = gax::GaxPreconditions.CheckNotNull(context, nameof(context)),
                },
                callSettings);

        /// <summary>
        /// Creates a context.
        ///
        /// If the specified context already exists, overrides the context.
        /// </summary>
        /// <param name="parent">
        /// Required. The session to create a context for.
        /// Format: `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;`.
        /// </param>
        /// <param name="context">
        /// Required. The context to create.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Context> CreateContextAsync(
            SessionName parent,
            Context context,
            st::CancellationToken cancellationToken) => CreateContextAsync(
                parent,
                context,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a context.
        ///
        /// If the specified context already exists, overrides the context.
        /// </summary>
        /// <param name="parent">
        /// Required. The session to create a context for.
        /// Format: `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;`.
        /// </param>
        /// <param name="context">
        /// Required. The context to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Context CreateContext(
            SessionName parent,
            Context context,
            gaxgrpc::CallSettings callSettings = null) => CreateContext(
                new CreateContextRequest
                {
                    ParentAsSessionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Context = gax::GaxPreconditions.CheckNotNull(context, nameof(context)),
                },
                callSettings);

        /// <summary>
        /// Creates a context.
        ///
        /// If the specified context already exists, overrides the context.
        /// </summary>
        /// <param name="parent">
        /// Required. The session to create a context for.
        /// Format: `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;`.
        /// </param>
        /// <param name="context">
        /// Required. The context to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Context> CreateContextAsync(
            string parent,
            Context context,
            gaxgrpc::CallSettings callSettings = null) => CreateContextAsync(
                new CreateContextRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Context = gax::GaxPreconditions.CheckNotNull(context, nameof(context)),
                },
                callSettings);

        /// <summary>
        /// Creates a context.
        ///
        /// If the specified context already exists, overrides the context.
        /// </summary>
        /// <param name="parent">
        /// Required. The session to create a context for.
        /// Format: `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;`.
        /// </param>
        /// <param name="context">
        /// Required. The context to create.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Context> CreateContextAsync(
            string parent,
            Context context,
            st::CancellationToken cancellationToken) => CreateContextAsync(
                parent,
                context,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a context.
        ///
        /// If the specified context already exists, overrides the context.
        /// </summary>
        /// <param name="parent">
        /// Required. The session to create a context for.
        /// Format: `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;`.
        /// </param>
        /// <param name="context">
        /// Required. The context to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Context CreateContext(
            string parent,
            Context context,
            gaxgrpc::CallSettings callSettings = null) => CreateContext(
                new CreateContextRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Context = gax::GaxPreconditions.CheckNotNull(context, nameof(context)),
                },
                callSettings);

        /// <summary>
        /// Creates a context.
        ///
        /// If the specified context already exists, overrides the context.
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
        public virtual stt::Task<Context> CreateContextAsync(
            CreateContextRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a context.
        ///
        /// If the specified context already exists, overrides the context.
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
        public virtual stt::Task<Context> CreateContextAsync(
            CreateContextRequest request,
            st::CancellationToken cancellationToken) => CreateContextAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a context.
        ///
        /// If the specified context already exists, overrides the context.
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
        public virtual Context CreateContext(
            CreateContextRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates the specified context.
        /// </summary>
        /// <param name="context">
        /// Required. The context to update.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Context> UpdateContextAsync(
            Context context,
            gaxgrpc::CallSettings callSettings = null) => UpdateContextAsync(
                new UpdateContextRequest
                {
                    Context = gax::GaxPreconditions.CheckNotNull(context, nameof(context)),
                },
                callSettings);

        /// <summary>
        /// Updates the specified context.
        /// </summary>
        /// <param name="context">
        /// Required. The context to update.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Context> UpdateContextAsync(
            Context context,
            st::CancellationToken cancellationToken) => UpdateContextAsync(
                context,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified context.
        /// </summary>
        /// <param name="context">
        /// Required. The context to update.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Context UpdateContext(
            Context context,
            gaxgrpc::CallSettings callSettings = null) => UpdateContext(
                new UpdateContextRequest
                {
                    Context = gax::GaxPreconditions.CheckNotNull(context, nameof(context)),
                },
                callSettings);

        /// <summary>
        /// Updates the specified context.
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
        public virtual stt::Task<Context> UpdateContextAsync(
            UpdateContextRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates the specified context.
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
        public virtual stt::Task<Context> UpdateContextAsync(
            UpdateContextRequest request,
            st::CancellationToken cancellationToken) => UpdateContextAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified context.
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
        public virtual Context UpdateContext(
            UpdateContextRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes the specified context.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the context to delete. Format:
        /// `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;/contexts/&lt;Context ID&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteContextAsync(
            ContextName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteContextAsync(
                new DeleteContextRequest
                {
                    ContextName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes the specified context.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the context to delete. Format:
        /// `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;/contexts/&lt;Context ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteContextAsync(
            ContextName name,
            st::CancellationToken cancellationToken) => DeleteContextAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified context.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the context to delete. Format:
        /// `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;/contexts/&lt;Context ID&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteContext(
            ContextName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteContext(
                new DeleteContextRequest
                {
                    ContextName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes the specified context.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the context to delete. Format:
        /// `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;/contexts/&lt;Context ID&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteContextAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteContextAsync(
                new DeleteContextRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes the specified context.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the context to delete. Format:
        /// `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;/contexts/&lt;Context ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteContextAsync(
            string name,
            st::CancellationToken cancellationToken) => DeleteContextAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified context.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the context to delete. Format:
        /// `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;/contexts/&lt;Context ID&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteContext(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteContext(
                new DeleteContextRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes the specified context.
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
        public virtual stt::Task DeleteContextAsync(
            DeleteContextRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes the specified context.
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
        public virtual stt::Task DeleteContextAsync(
            DeleteContextRequest request,
            st::CancellationToken cancellationToken) => DeleteContextAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified context.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteContext(
            DeleteContextRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes all active contexts in the specified session.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the session to delete all contexts from. Format:
        /// `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteAllContextsAsync(
            SessionName parent,
            gaxgrpc::CallSettings callSettings = null) => DeleteAllContextsAsync(
                new DeleteAllContextsRequest
                {
                    ParentAsSessionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                },
                callSettings);

        /// <summary>
        /// Deletes all active contexts in the specified session.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the session to delete all contexts from. Format:
        /// `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteAllContextsAsync(
            SessionName parent,
            st::CancellationToken cancellationToken) => DeleteAllContextsAsync(
                parent,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes all active contexts in the specified session.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the session to delete all contexts from. Format:
        /// `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteAllContexts(
            SessionName parent,
            gaxgrpc::CallSettings callSettings = null) => DeleteAllContexts(
                new DeleteAllContextsRequest
                {
                    ParentAsSessionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                },
                callSettings);

        /// <summary>
        /// Deletes all active contexts in the specified session.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the session to delete all contexts from. Format:
        /// `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteAllContextsAsync(
            string parent,
            gaxgrpc::CallSettings callSettings = null) => DeleteAllContextsAsync(
                new DeleteAllContextsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                },
                callSettings);

        /// <summary>
        /// Deletes all active contexts in the specified session.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the session to delete all contexts from. Format:
        /// `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteAllContextsAsync(
            string parent,
            st::CancellationToken cancellationToken) => DeleteAllContextsAsync(
                parent,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes all active contexts in the specified session.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the session to delete all contexts from. Format:
        /// `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteAllContexts(
            string parent,
            gaxgrpc::CallSettings callSettings = null) => DeleteAllContexts(
                new DeleteAllContextsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                },
                callSettings);

        /// <summary>
        /// Deletes all active contexts in the specified session.
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
        public virtual stt::Task DeleteAllContextsAsync(
            DeleteAllContextsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes all active contexts in the specified session.
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
        public virtual stt::Task DeleteAllContextsAsync(
            DeleteAllContextsRequest request,
            st::CancellationToken cancellationToken) => DeleteAllContextsAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes all active contexts in the specified session.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteAllContexts(
            DeleteAllContextsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// Contexts client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class ContextsClientImpl : ContextsClient
    {
        private readonly gaxgrpc::ApiCall<ListContextsRequest, ListContextsResponse> _callListContexts;
        private readonly gaxgrpc::ApiCall<GetContextRequest, Context> _callGetContext;
        private readonly gaxgrpc::ApiCall<CreateContextRequest, Context> _callCreateContext;
        private readonly gaxgrpc::ApiCall<UpdateContextRequest, Context> _callUpdateContext;
        private readonly gaxgrpc::ApiCall<DeleteContextRequest, pbwkt::Empty> _callDeleteContext;
        private readonly gaxgrpc::ApiCall<DeleteAllContextsRequest, pbwkt::Empty> _callDeleteAllContexts;

        /// <summary>
        /// Constructs a client wrapper for the Contexts service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ContextsSettings"/> used within this client </param>
        public ContextsClientImpl(Contexts.ContextsClient grpcClient, ContextsSettings settings)
        {
            GrpcClient = grpcClient;
            ContextsSettings effectiveSettings = settings ?? ContextsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callListContexts = clientHelper.BuildApiCall<ListContextsRequest, ListContextsResponse>(
                GrpcClient.ListContextsAsync, GrpcClient.ListContexts, effectiveSettings.ListContextsSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callGetContext = clientHelper.BuildApiCall<GetContextRequest, Context>(
                GrpcClient.GetContextAsync, GrpcClient.GetContext, effectiveSettings.GetContextSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callCreateContext = clientHelper.BuildApiCall<CreateContextRequest, Context>(
                GrpcClient.CreateContextAsync, GrpcClient.CreateContext, effectiveSettings.CreateContextSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callUpdateContext = clientHelper.BuildApiCall<UpdateContextRequest, Context>(
                GrpcClient.UpdateContextAsync, GrpcClient.UpdateContext, effectiveSettings.UpdateContextSettings)
                .WithGoogleRequestParam("context.name", request => request.Context?.Name);
            _callDeleteContext = clientHelper.BuildApiCall<DeleteContextRequest, pbwkt::Empty>(
                GrpcClient.DeleteContextAsync, GrpcClient.DeleteContext, effectiveSettings.DeleteContextSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callDeleteAllContexts = clientHelper.BuildApiCall<DeleteAllContextsRequest, pbwkt::Empty>(
                GrpcClient.DeleteAllContextsAsync, GrpcClient.DeleteAllContexts, effectiveSettings.DeleteAllContextsSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListContexts);
            Modify_ListContextsApiCall(ref _callListContexts);
            Modify_ApiCall(ref _callGetContext);
            Modify_GetContextApiCall(ref _callGetContext);
            Modify_ApiCall(ref _callCreateContext);
            Modify_CreateContextApiCall(ref _callCreateContext);
            Modify_ApiCall(ref _callUpdateContext);
            Modify_UpdateContextApiCall(ref _callUpdateContext);
            Modify_ApiCall(ref _callDeleteContext);
            Modify_DeleteContextApiCall(ref _callDeleteContext);
            Modify_ApiCall(ref _callDeleteAllContexts);
            Modify_DeleteAllContextsApiCall(ref _callDeleteAllContexts);
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
        partial void Modify_ListContextsApiCall(ref gaxgrpc::ApiCall<ListContextsRequest, ListContextsResponse> call);
        partial void Modify_GetContextApiCall(ref gaxgrpc::ApiCall<GetContextRequest, Context> call);
        partial void Modify_CreateContextApiCall(ref gaxgrpc::ApiCall<CreateContextRequest, Context> call);
        partial void Modify_UpdateContextApiCall(ref gaxgrpc::ApiCall<UpdateContextRequest, Context> call);
        partial void Modify_DeleteContextApiCall(ref gaxgrpc::ApiCall<DeleteContextRequest, pbwkt::Empty> call);
        partial void Modify_DeleteAllContextsApiCall(ref gaxgrpc::ApiCall<DeleteAllContextsRequest, pbwkt::Empty> call);
        partial void OnConstruction(Contexts.ContextsClient grpcClient, ContextsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC Contexts client.
        /// </summary>
        public override Contexts.ContextsClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_ListContextsRequest(ref ListContextsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetContextRequest(ref GetContextRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateContextRequest(ref CreateContextRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateContextRequest(ref UpdateContextRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteContextRequest(ref DeleteContextRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteAllContextsRequest(ref DeleteAllContextsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the list of all contexts in the specified session.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Context"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListContextsResponse, Context> ListContextsAsync(
            ListContextsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListContextsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListContextsRequest, ListContextsResponse, Context>(_callListContexts, request, callSettings);
        }

        /// <summary>
        /// Returns the list of all contexts in the specified session.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Context"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListContextsResponse, Context> ListContexts(
            ListContextsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListContextsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListContextsRequest, ListContextsResponse, Context>(_callListContexts, request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified context.
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
        public override stt::Task<Context> GetContextAsync(
            GetContextRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetContextRequest(ref request, ref callSettings);
            return _callGetContext.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified context.
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
        public override Context GetContext(
            GetContextRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetContextRequest(ref request, ref callSettings);
            return _callGetContext.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a context.
        ///
        /// If the specified context already exists, overrides the context.
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
        public override stt::Task<Context> CreateContextAsync(
            CreateContextRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateContextRequest(ref request, ref callSettings);
            return _callCreateContext.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a context.
        ///
        /// If the specified context already exists, overrides the context.
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
        public override Context CreateContext(
            CreateContextRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateContextRequest(ref request, ref callSettings);
            return _callCreateContext.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the specified context.
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
        public override stt::Task<Context> UpdateContextAsync(
            UpdateContextRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateContextRequest(ref request, ref callSettings);
            return _callUpdateContext.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the specified context.
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
        public override Context UpdateContext(
            UpdateContextRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateContextRequest(ref request, ref callSettings);
            return _callUpdateContext.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified context.
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
        public override stt::Task DeleteContextAsync(
            DeleteContextRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteContextRequest(ref request, ref callSettings);
            return _callDeleteContext.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified context.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteContext(
            DeleteContextRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteContextRequest(ref request, ref callSettings);
            _callDeleteContext.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes all active contexts in the specified session.
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
        public override stt::Task DeleteAllContextsAsync(
            DeleteAllContextsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAllContextsRequest(ref request, ref callSettings);
            return _callDeleteAllContexts.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes all active contexts in the specified session.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteAllContexts(
            DeleteAllContextsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAllContextsRequest(ref request, ref callSettings);
            _callDeleteAllContexts.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListContextsRequest : gaxgrpc::IPageRequest { }
    public partial class ListContextsResponse : gaxgrpc::IPageResponse<Context>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<Context> GetEnumerator() => Contexts.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }


}
