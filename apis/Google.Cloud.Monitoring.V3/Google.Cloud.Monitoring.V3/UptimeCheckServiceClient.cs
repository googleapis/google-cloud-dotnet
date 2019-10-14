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

namespace Google.Cloud.Monitoring.V3
{
    /// <summary>
    /// Settings for a <see cref="UptimeCheckServiceClient"/>.
    /// </summary>
    public sealed partial class UptimeCheckServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="UptimeCheckServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="UptimeCheckServiceSettings"/>.
        /// </returns>
        public static UptimeCheckServiceSettings GetDefault() => new UptimeCheckServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="UptimeCheckServiceSettings"/> object with default settings.
        /// </summary>
        public UptimeCheckServiceSettings() { }

        private UptimeCheckServiceSettings(UptimeCheckServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListUptimeCheckConfigsSettings = existing.ListUptimeCheckConfigsSettings;
            GetUptimeCheckConfigSettings = existing.GetUptimeCheckConfigSettings;
            CreateUptimeCheckConfigSettings = existing.CreateUptimeCheckConfigSettings;
            UpdateUptimeCheckConfigSettings = existing.UpdateUptimeCheckConfigSettings;
            DeleteUptimeCheckConfigSettings = existing.DeleteUptimeCheckConfigSettings;
            ListUptimeCheckIpsSettings = existing.ListUptimeCheckIpsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(UptimeCheckServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="UptimeCheckServiceClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="UptimeCheckServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="UptimeCheckServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="UptimeCheckServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="UptimeCheckServiceClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="UptimeCheckServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="UptimeCheckServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="UptimeCheckServiceClient"/> RPC methods is defined as:
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
        /// <c>UptimeCheckServiceClient.ListUptimeCheckConfigs</c> and <c>UptimeCheckServiceClient.ListUptimeCheckConfigsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>UptimeCheckServiceClient.ListUptimeCheckConfigs</c> and
        /// <c>UptimeCheckServiceClient.ListUptimeCheckConfigsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListUptimeCheckConfigsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UptimeCheckServiceClient.GetUptimeCheckConfig</c> and <c>UptimeCheckServiceClient.GetUptimeCheckConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>UptimeCheckServiceClient.GetUptimeCheckConfig</c> and
        /// <c>UptimeCheckServiceClient.GetUptimeCheckConfigAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetUptimeCheckConfigSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UptimeCheckServiceClient.CreateUptimeCheckConfig</c> and <c>UptimeCheckServiceClient.CreateUptimeCheckConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>UptimeCheckServiceClient.CreateUptimeCheckConfig</c> and
        /// <c>UptimeCheckServiceClient.CreateUptimeCheckConfigAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings CreateUptimeCheckConfigSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UptimeCheckServiceClient.UpdateUptimeCheckConfig</c> and <c>UptimeCheckServiceClient.UpdateUptimeCheckConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>UptimeCheckServiceClient.UpdateUptimeCheckConfig</c> and
        /// <c>UptimeCheckServiceClient.UpdateUptimeCheckConfigAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings UpdateUptimeCheckConfigSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UptimeCheckServiceClient.DeleteUptimeCheckConfig</c> and <c>UptimeCheckServiceClient.DeleteUptimeCheckConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>UptimeCheckServiceClient.DeleteUptimeCheckConfig</c> and
        /// <c>UptimeCheckServiceClient.DeleteUptimeCheckConfigAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings DeleteUptimeCheckConfigSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UptimeCheckServiceClient.ListUptimeCheckIps</c> and <c>UptimeCheckServiceClient.ListUptimeCheckIpsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>UptimeCheckServiceClient.ListUptimeCheckIps</c> and
        /// <c>UptimeCheckServiceClient.ListUptimeCheckIpsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListUptimeCheckIpsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="UptimeCheckServiceSettings"/> object.</returns>
        public UptimeCheckServiceSettings Clone() => new UptimeCheckServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="UptimeCheckServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class UptimeCheckServiceClientBuilder : gaxgrpc::ClientBuilderBase<UptimeCheckServiceClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public UptimeCheckServiceSettings Settings { get; set; }

        /// <inheritdoc/>
        public override UptimeCheckServiceClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return UptimeCheckServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<UptimeCheckServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return UptimeCheckServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => UptimeCheckServiceClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => UptimeCheckServiceClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => UptimeCheckServiceClient.ChannelPool;
    }

    /// <summary>
    /// UptimeCheckService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class UptimeCheckServiceClient
    {
        /// <summary>
        /// The default endpoint for the UptimeCheckService service, which is a host of "monitoring.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("monitoring.googleapis.com", 443);

        /// <summary>
        /// The default UptimeCheckService scopes.
        /// </summary>
        /// <remarks>
        /// The default UptimeCheckService scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/monitoring"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/monitoring.read"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/monitoring.write"</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/monitoring",
            "https://www.googleapis.com/auth/monitoring.read",
            "https://www.googleapis.com/auth/monitoring.write",
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="UptimeCheckServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Monitoring.V3;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// UptimeCheckServiceClient client = await UptimeCheckServiceClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Monitoring.V3;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     UptimeCheckServiceClient.DefaultEndpoint.Host, UptimeCheckServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// UptimeCheckServiceClient client = UptimeCheckServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="UptimeCheckServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="UptimeCheckServiceClient"/>.</returns>
        public static async stt::Task<UptimeCheckServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, UptimeCheckServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="UptimeCheckServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Monitoring.V3;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// UptimeCheckServiceClient client = UptimeCheckServiceClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Monitoring.V3;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     UptimeCheckServiceClient.DefaultEndpoint.Host, UptimeCheckServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// UptimeCheckServiceClient client = UptimeCheckServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="UptimeCheckServiceSettings"/>.</param>
        /// <returns>The created <see cref="UptimeCheckServiceClient"/>.</returns>
        public static UptimeCheckServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, UptimeCheckServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="UptimeCheckServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="UptimeCheckServiceSettings"/>.</param>
        /// <returns>The created <see cref="UptimeCheckServiceClient"/>.</returns>
        public static UptimeCheckServiceClient Create(grpccore::Channel channel, UptimeCheckServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="UptimeCheckServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="UptimeCheckServiceSettings"/>.</param>
        /// <returns>The created <see cref="UptimeCheckServiceClient"/>.</returns>
        public static UptimeCheckServiceClient Create(grpccore::CallInvoker callInvoker, UptimeCheckServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            UptimeCheckService.UptimeCheckServiceClient grpcClient = new UptimeCheckService.UptimeCheckServiceClient(callInvoker);
            return new UptimeCheckServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, UptimeCheckServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, UptimeCheckServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, UptimeCheckServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, UptimeCheckServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC UptimeCheckService client.
        /// </summary>
        public virtual UptimeCheckService.UptimeCheckServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Lists the existing valid Uptime check configurations for the project
        /// (leaving out any invalid configurations).
        /// </summary>
        /// <param name="parent">
        /// The project whose Uptime check configurations are listed. The format
        ///   is `projects/[PROJECT_ID]`.
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
        /// A pageable asynchronous sequence of <see cref="UptimeCheckConfig"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListUptimeCheckConfigsResponse, UptimeCheckConfig> ListUptimeCheckConfigsAsync(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListUptimeCheckConfigsAsync(
                new ListUptimeCheckConfigsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the existing valid Uptime check configurations for the project
        /// (leaving out any invalid configurations).
        /// </summary>
        /// <param name="parent">
        /// The project whose Uptime check configurations are listed. The format
        ///   is `projects/[PROJECT_ID]`.
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
        /// A pageable sequence of <see cref="UptimeCheckConfig"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListUptimeCheckConfigsResponse, UptimeCheckConfig> ListUptimeCheckConfigs(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListUptimeCheckConfigs(
                new ListUptimeCheckConfigsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the existing valid Uptime check configurations for the project
        /// (leaving out any invalid configurations).
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="UptimeCheckConfig"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListUptimeCheckConfigsResponse, UptimeCheckConfig> ListUptimeCheckConfigsAsync(
            ListUptimeCheckConfigsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists the existing valid Uptime check configurations for the project
        /// (leaving out any invalid configurations).
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="UptimeCheckConfig"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListUptimeCheckConfigsResponse, UptimeCheckConfig> ListUptimeCheckConfigs(
            ListUptimeCheckConfigsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets a single Uptime check configuration.
        /// </summary>
        /// <param name="name">
        /// The Uptime check configuration to retrieve. The format
        ///   is `projects/[PROJECT_ID]/uptimeCheckConfigs/[UPTIME_CHECK_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<UptimeCheckConfig> GetUptimeCheckConfigAsync(
            UptimeCheckConfigName name,
            gaxgrpc::CallSettings callSettings = null) => GetUptimeCheckConfigAsync(
                new GetUptimeCheckConfigRequest
                {
                    UptimeCheckConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets a single Uptime check configuration.
        /// </summary>
        /// <param name="name">
        /// The Uptime check configuration to retrieve. The format
        ///   is `projects/[PROJECT_ID]/uptimeCheckConfigs/[UPTIME_CHECK_ID]`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<UptimeCheckConfig> GetUptimeCheckConfigAsync(
            UptimeCheckConfigName name,
            st::CancellationToken cancellationToken) => GetUptimeCheckConfigAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single Uptime check configuration.
        /// </summary>
        /// <param name="name">
        /// The Uptime check configuration to retrieve. The format
        ///   is `projects/[PROJECT_ID]/uptimeCheckConfigs/[UPTIME_CHECK_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual UptimeCheckConfig GetUptimeCheckConfig(
            UptimeCheckConfigName name,
            gaxgrpc::CallSettings callSettings = null) => GetUptimeCheckConfig(
                new GetUptimeCheckConfigRequest
                {
                    UptimeCheckConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets a single Uptime check configuration.
        /// </summary>
        /// <param name="name">
        /// The Uptime check configuration to retrieve. The format
        ///   is `projects/[PROJECT_ID]/uptimeCheckConfigs/[UPTIME_CHECK_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<UptimeCheckConfig> GetUptimeCheckConfigAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetUptimeCheckConfigAsync(
                new GetUptimeCheckConfigRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets a single Uptime check configuration.
        /// </summary>
        /// <param name="name">
        /// The Uptime check configuration to retrieve. The format
        ///   is `projects/[PROJECT_ID]/uptimeCheckConfigs/[UPTIME_CHECK_ID]`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<UptimeCheckConfig> GetUptimeCheckConfigAsync(
            string name,
            st::CancellationToken cancellationToken) => GetUptimeCheckConfigAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single Uptime check configuration.
        /// </summary>
        /// <param name="name">
        /// The Uptime check configuration to retrieve. The format
        ///   is `projects/[PROJECT_ID]/uptimeCheckConfigs/[UPTIME_CHECK_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual UptimeCheckConfig GetUptimeCheckConfig(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetUptimeCheckConfig(
                new GetUptimeCheckConfigRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets a single Uptime check configuration.
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
        public virtual stt::Task<UptimeCheckConfig> GetUptimeCheckConfigAsync(
            GetUptimeCheckConfigRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets a single Uptime check configuration.
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
        public virtual stt::Task<UptimeCheckConfig> GetUptimeCheckConfigAsync(
            GetUptimeCheckConfigRequest request,
            st::CancellationToken cancellationToken) => GetUptimeCheckConfigAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single Uptime check configuration.
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
        public virtual UptimeCheckConfig GetUptimeCheckConfig(
            GetUptimeCheckConfigRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a new Uptime check configuration.
        /// </summary>
        /// <param name="parent">
        /// The project in which to create the Uptime check. The format
        ///   is `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="uptimeCheckConfig">
        /// The new Uptime check configuration.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<UptimeCheckConfig> CreateUptimeCheckConfigAsync(
            string parent,
            UptimeCheckConfig uptimeCheckConfig,
            gaxgrpc::CallSettings callSettings = null) => CreateUptimeCheckConfigAsync(
                new CreateUptimeCheckConfigRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    UptimeCheckConfig = gax::GaxPreconditions.CheckNotNull(uptimeCheckConfig, nameof(uptimeCheckConfig)),
                },
                callSettings);

        /// <summary>
        /// Creates a new Uptime check configuration.
        /// </summary>
        /// <param name="parent">
        /// The project in which to create the Uptime check. The format
        ///   is `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="uptimeCheckConfig">
        /// The new Uptime check configuration.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<UptimeCheckConfig> CreateUptimeCheckConfigAsync(
            string parent,
            UptimeCheckConfig uptimeCheckConfig,
            st::CancellationToken cancellationToken) => CreateUptimeCheckConfigAsync(
                parent,
                uptimeCheckConfig,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Uptime check configuration.
        /// </summary>
        /// <param name="parent">
        /// The project in which to create the Uptime check. The format
        ///   is `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="uptimeCheckConfig">
        /// The new Uptime check configuration.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual UptimeCheckConfig CreateUptimeCheckConfig(
            string parent,
            UptimeCheckConfig uptimeCheckConfig,
            gaxgrpc::CallSettings callSettings = null) => CreateUptimeCheckConfig(
                new CreateUptimeCheckConfigRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    UptimeCheckConfig = gax::GaxPreconditions.CheckNotNull(uptimeCheckConfig, nameof(uptimeCheckConfig)),
                },
                callSettings);

        /// <summary>
        /// Creates a new Uptime check configuration.
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
        public virtual stt::Task<UptimeCheckConfig> CreateUptimeCheckConfigAsync(
            CreateUptimeCheckConfigRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a new Uptime check configuration.
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
        public virtual stt::Task<UptimeCheckConfig> CreateUptimeCheckConfigAsync(
            CreateUptimeCheckConfigRequest request,
            st::CancellationToken cancellationToken) => CreateUptimeCheckConfigAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Uptime check configuration.
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
        public virtual UptimeCheckConfig CreateUptimeCheckConfig(
            CreateUptimeCheckConfigRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates an Uptime check configuration. You can either replace the entire
        /// configuration with a new one or replace only certain fields in the current
        /// configuration by specifying the fields to be updated via `updateMask`.
        /// Returns the updated configuration.
        /// </summary>
        /// <param name="uptimeCheckConfig">
        /// Required. If an `updateMask` has been specified, this field gives
        /// the values for the set of fields mentioned in the `updateMask`. If an
        /// `updateMask` has not been given, this Uptime check configuration replaces
        /// the current configuration. If a field is mentioned in `updateMask` but
        /// the corresonding field is omitted in this partial Uptime check
        /// configuration, it has the effect of deleting/clearing the field from the
        /// configuration on the server.
        ///
        /// The following fields can be updated: `display_name`,
        /// `http_check`, `tcp_check`, `timeout`, `content_matchers`, and
        /// `selected_regions`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<UptimeCheckConfig> UpdateUptimeCheckConfigAsync(
            UptimeCheckConfig uptimeCheckConfig,
            gaxgrpc::CallSettings callSettings = null) => UpdateUptimeCheckConfigAsync(
                new UpdateUptimeCheckConfigRequest
                {
                    UptimeCheckConfig = gax::GaxPreconditions.CheckNotNull(uptimeCheckConfig, nameof(uptimeCheckConfig)),
                },
                callSettings);

        /// <summary>
        /// Updates an Uptime check configuration. You can either replace the entire
        /// configuration with a new one or replace only certain fields in the current
        /// configuration by specifying the fields to be updated via `updateMask`.
        /// Returns the updated configuration.
        /// </summary>
        /// <param name="uptimeCheckConfig">
        /// Required. If an `updateMask` has been specified, this field gives
        /// the values for the set of fields mentioned in the `updateMask`. If an
        /// `updateMask` has not been given, this Uptime check configuration replaces
        /// the current configuration. If a field is mentioned in `updateMask` but
        /// the corresonding field is omitted in this partial Uptime check
        /// configuration, it has the effect of deleting/clearing the field from the
        /// configuration on the server.
        ///
        /// The following fields can be updated: `display_name`,
        /// `http_check`, `tcp_check`, `timeout`, `content_matchers`, and
        /// `selected_regions`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<UptimeCheckConfig> UpdateUptimeCheckConfigAsync(
            UptimeCheckConfig uptimeCheckConfig,
            st::CancellationToken cancellationToken) => UpdateUptimeCheckConfigAsync(
                uptimeCheckConfig,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an Uptime check configuration. You can either replace the entire
        /// configuration with a new one or replace only certain fields in the current
        /// configuration by specifying the fields to be updated via `updateMask`.
        /// Returns the updated configuration.
        /// </summary>
        /// <param name="uptimeCheckConfig">
        /// Required. If an `updateMask` has been specified, this field gives
        /// the values for the set of fields mentioned in the `updateMask`. If an
        /// `updateMask` has not been given, this Uptime check configuration replaces
        /// the current configuration. If a field is mentioned in `updateMask` but
        /// the corresonding field is omitted in this partial Uptime check
        /// configuration, it has the effect of deleting/clearing the field from the
        /// configuration on the server.
        ///
        /// The following fields can be updated: `display_name`,
        /// `http_check`, `tcp_check`, `timeout`, `content_matchers`, and
        /// `selected_regions`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual UptimeCheckConfig UpdateUptimeCheckConfig(
            UptimeCheckConfig uptimeCheckConfig,
            gaxgrpc::CallSettings callSettings = null) => UpdateUptimeCheckConfig(
                new UpdateUptimeCheckConfigRequest
                {
                    UptimeCheckConfig = gax::GaxPreconditions.CheckNotNull(uptimeCheckConfig, nameof(uptimeCheckConfig)),
                },
                callSettings);

        /// <summary>
        /// Updates an Uptime check configuration. You can either replace the entire
        /// configuration with a new one or replace only certain fields in the current
        /// configuration by specifying the fields to be updated via `updateMask`.
        /// Returns the updated configuration.
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
        public virtual stt::Task<UptimeCheckConfig> UpdateUptimeCheckConfigAsync(
            UpdateUptimeCheckConfigRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates an Uptime check configuration. You can either replace the entire
        /// configuration with a new one or replace only certain fields in the current
        /// configuration by specifying the fields to be updated via `updateMask`.
        /// Returns the updated configuration.
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
        public virtual stt::Task<UptimeCheckConfig> UpdateUptimeCheckConfigAsync(
            UpdateUptimeCheckConfigRequest request,
            st::CancellationToken cancellationToken) => UpdateUptimeCheckConfigAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an Uptime check configuration. You can either replace the entire
        /// configuration with a new one or replace only certain fields in the current
        /// configuration by specifying the fields to be updated via `updateMask`.
        /// Returns the updated configuration.
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
        public virtual UptimeCheckConfig UpdateUptimeCheckConfig(
            UpdateUptimeCheckConfigRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes an Uptime check configuration. Note that this method will fail
        /// if the Uptime check configuration is referenced by an alert policy or
        /// other dependent configs that would be rendered invalid by the deletion.
        /// </summary>
        /// <param name="name">
        /// The Uptime check configuration to delete. The format
        ///   is `projects/[PROJECT_ID]/uptimeCheckConfigs/[UPTIME_CHECK_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteUptimeCheckConfigAsync(
            UptimeCheckConfigName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteUptimeCheckConfigAsync(
                new DeleteUptimeCheckConfigRequest
                {
                    UptimeCheckConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes an Uptime check configuration. Note that this method will fail
        /// if the Uptime check configuration is referenced by an alert policy or
        /// other dependent configs that would be rendered invalid by the deletion.
        /// </summary>
        /// <param name="name">
        /// The Uptime check configuration to delete. The format
        ///   is `projects/[PROJECT_ID]/uptimeCheckConfigs/[UPTIME_CHECK_ID]`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteUptimeCheckConfigAsync(
            UptimeCheckConfigName name,
            st::CancellationToken cancellationToken) => DeleteUptimeCheckConfigAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an Uptime check configuration. Note that this method will fail
        /// if the Uptime check configuration is referenced by an alert policy or
        /// other dependent configs that would be rendered invalid by the deletion.
        /// </summary>
        /// <param name="name">
        /// The Uptime check configuration to delete. The format
        ///   is `projects/[PROJECT_ID]/uptimeCheckConfigs/[UPTIME_CHECK_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteUptimeCheckConfig(
            UptimeCheckConfigName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteUptimeCheckConfig(
                new DeleteUptimeCheckConfigRequest
                {
                    UptimeCheckConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes an Uptime check configuration. Note that this method will fail
        /// if the Uptime check configuration is referenced by an alert policy or
        /// other dependent configs that would be rendered invalid by the deletion.
        /// </summary>
        /// <param name="name">
        /// The Uptime check configuration to delete. The format
        ///   is `projects/[PROJECT_ID]/uptimeCheckConfigs/[UPTIME_CHECK_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteUptimeCheckConfigAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteUptimeCheckConfigAsync(
                new DeleteUptimeCheckConfigRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes an Uptime check configuration. Note that this method will fail
        /// if the Uptime check configuration is referenced by an alert policy or
        /// other dependent configs that would be rendered invalid by the deletion.
        /// </summary>
        /// <param name="name">
        /// The Uptime check configuration to delete. The format
        ///   is `projects/[PROJECT_ID]/uptimeCheckConfigs/[UPTIME_CHECK_ID]`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteUptimeCheckConfigAsync(
            string name,
            st::CancellationToken cancellationToken) => DeleteUptimeCheckConfigAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an Uptime check configuration. Note that this method will fail
        /// if the Uptime check configuration is referenced by an alert policy or
        /// other dependent configs that would be rendered invalid by the deletion.
        /// </summary>
        /// <param name="name">
        /// The Uptime check configuration to delete. The format
        ///   is `projects/[PROJECT_ID]/uptimeCheckConfigs/[UPTIME_CHECK_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteUptimeCheckConfig(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteUptimeCheckConfig(
                new DeleteUptimeCheckConfigRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes an Uptime check configuration. Note that this method will fail
        /// if the Uptime check configuration is referenced by an alert policy or
        /// other dependent configs that would be rendered invalid by the deletion.
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
        public virtual stt::Task DeleteUptimeCheckConfigAsync(
            DeleteUptimeCheckConfigRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes an Uptime check configuration. Note that this method will fail
        /// if the Uptime check configuration is referenced by an alert policy or
        /// other dependent configs that would be rendered invalid by the deletion.
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
        public virtual stt::Task DeleteUptimeCheckConfigAsync(
            DeleteUptimeCheckConfigRequest request,
            st::CancellationToken cancellationToken) => DeleteUptimeCheckConfigAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an Uptime check configuration. Note that this method will fail
        /// if the Uptime check configuration is referenced by an alert policy or
        /// other dependent configs that would be rendered invalid by the deletion.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteUptimeCheckConfig(
            DeleteUptimeCheckConfigRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns the list of IP addresses that checkers run from
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="UptimeCheckIp"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListUptimeCheckIpsResponse, UptimeCheckIp> ListUptimeCheckIpsAsync(
            ListUptimeCheckIpsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns the list of IP addresses that checkers run from
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="UptimeCheckIp"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListUptimeCheckIpsResponse, UptimeCheckIp> ListUptimeCheckIps(
            ListUptimeCheckIpsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// UptimeCheckService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class UptimeCheckServiceClientImpl : UptimeCheckServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListUptimeCheckConfigsRequest, ListUptimeCheckConfigsResponse> _callListUptimeCheckConfigs;
        private readonly gaxgrpc::ApiCall<GetUptimeCheckConfigRequest, UptimeCheckConfig> _callGetUptimeCheckConfig;
        private readonly gaxgrpc::ApiCall<CreateUptimeCheckConfigRequest, UptimeCheckConfig> _callCreateUptimeCheckConfig;
        private readonly gaxgrpc::ApiCall<UpdateUptimeCheckConfigRequest, UptimeCheckConfig> _callUpdateUptimeCheckConfig;
        private readonly gaxgrpc::ApiCall<DeleteUptimeCheckConfigRequest, pbwkt::Empty> _callDeleteUptimeCheckConfig;
        private readonly gaxgrpc::ApiCall<ListUptimeCheckIpsRequest, ListUptimeCheckIpsResponse> _callListUptimeCheckIps;

        /// <summary>
        /// Constructs a client wrapper for the UptimeCheckService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="UptimeCheckServiceSettings"/> used within this client </param>
        public UptimeCheckServiceClientImpl(UptimeCheckService.UptimeCheckServiceClient grpcClient, UptimeCheckServiceSettings settings)
        {
            GrpcClient = grpcClient;
            UptimeCheckServiceSettings effectiveSettings = settings ?? UptimeCheckServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callListUptimeCheckConfigs = clientHelper.BuildApiCall<ListUptimeCheckConfigsRequest, ListUptimeCheckConfigsResponse>(
                GrpcClient.ListUptimeCheckConfigsAsync, GrpcClient.ListUptimeCheckConfigs, effectiveSettings.ListUptimeCheckConfigsSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callGetUptimeCheckConfig = clientHelper.BuildApiCall<GetUptimeCheckConfigRequest, UptimeCheckConfig>(
                GrpcClient.GetUptimeCheckConfigAsync, GrpcClient.GetUptimeCheckConfig, effectiveSettings.GetUptimeCheckConfigSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callCreateUptimeCheckConfig = clientHelper.BuildApiCall<CreateUptimeCheckConfigRequest, UptimeCheckConfig>(
                GrpcClient.CreateUptimeCheckConfigAsync, GrpcClient.CreateUptimeCheckConfig, effectiveSettings.CreateUptimeCheckConfigSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callUpdateUptimeCheckConfig = clientHelper.BuildApiCall<UpdateUptimeCheckConfigRequest, UptimeCheckConfig>(
                GrpcClient.UpdateUptimeCheckConfigAsync, GrpcClient.UpdateUptimeCheckConfig, effectiveSettings.UpdateUptimeCheckConfigSettings)
                .WithGoogleRequestParam("uptime_check_config.name", request => request.UptimeCheckConfig?.Name);
            _callDeleteUptimeCheckConfig = clientHelper.BuildApiCall<DeleteUptimeCheckConfigRequest, pbwkt::Empty>(
                GrpcClient.DeleteUptimeCheckConfigAsync, GrpcClient.DeleteUptimeCheckConfig, effectiveSettings.DeleteUptimeCheckConfigSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callListUptimeCheckIps = clientHelper.BuildApiCall<ListUptimeCheckIpsRequest, ListUptimeCheckIpsResponse>(
                GrpcClient.ListUptimeCheckIpsAsync, GrpcClient.ListUptimeCheckIps, effectiveSettings.ListUptimeCheckIpsSettings);
            Modify_ApiCall(ref _callListUptimeCheckConfigs);
            Modify_ListUptimeCheckConfigsApiCall(ref _callListUptimeCheckConfigs);
            Modify_ApiCall(ref _callGetUptimeCheckConfig);
            Modify_GetUptimeCheckConfigApiCall(ref _callGetUptimeCheckConfig);
            Modify_ApiCall(ref _callCreateUptimeCheckConfig);
            Modify_CreateUptimeCheckConfigApiCall(ref _callCreateUptimeCheckConfig);
            Modify_ApiCall(ref _callUpdateUptimeCheckConfig);
            Modify_UpdateUptimeCheckConfigApiCall(ref _callUpdateUptimeCheckConfig);
            Modify_ApiCall(ref _callDeleteUptimeCheckConfig);
            Modify_DeleteUptimeCheckConfigApiCall(ref _callDeleteUptimeCheckConfig);
            Modify_ApiCall(ref _callListUptimeCheckIps);
            Modify_ListUptimeCheckIpsApiCall(ref _callListUptimeCheckIps);
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
        partial void Modify_ListUptimeCheckConfigsApiCall(ref gaxgrpc::ApiCall<ListUptimeCheckConfigsRequest, ListUptimeCheckConfigsResponse> call);
        partial void Modify_GetUptimeCheckConfigApiCall(ref gaxgrpc::ApiCall<GetUptimeCheckConfigRequest, UptimeCheckConfig> call);
        partial void Modify_CreateUptimeCheckConfigApiCall(ref gaxgrpc::ApiCall<CreateUptimeCheckConfigRequest, UptimeCheckConfig> call);
        partial void Modify_UpdateUptimeCheckConfigApiCall(ref gaxgrpc::ApiCall<UpdateUptimeCheckConfigRequest, UptimeCheckConfig> call);
        partial void Modify_DeleteUptimeCheckConfigApiCall(ref gaxgrpc::ApiCall<DeleteUptimeCheckConfigRequest, pbwkt::Empty> call);
        partial void Modify_ListUptimeCheckIpsApiCall(ref gaxgrpc::ApiCall<ListUptimeCheckIpsRequest, ListUptimeCheckIpsResponse> call);
        partial void OnConstruction(UptimeCheckService.UptimeCheckServiceClient grpcClient, UptimeCheckServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC UptimeCheckService client.
        /// </summary>
        public override UptimeCheckService.UptimeCheckServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_ListUptimeCheckConfigsRequest(ref ListUptimeCheckConfigsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetUptimeCheckConfigRequest(ref GetUptimeCheckConfigRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateUptimeCheckConfigRequest(ref CreateUptimeCheckConfigRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateUptimeCheckConfigRequest(ref UpdateUptimeCheckConfigRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteUptimeCheckConfigRequest(ref DeleteUptimeCheckConfigRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListUptimeCheckIpsRequest(ref ListUptimeCheckIpsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists the existing valid Uptime check configurations for the project
        /// (leaving out any invalid configurations).
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="UptimeCheckConfig"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListUptimeCheckConfigsResponse, UptimeCheckConfig> ListUptimeCheckConfigsAsync(
            ListUptimeCheckConfigsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUptimeCheckConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListUptimeCheckConfigsRequest, ListUptimeCheckConfigsResponse, UptimeCheckConfig>(_callListUptimeCheckConfigs, request, callSettings);
        }

        /// <summary>
        /// Lists the existing valid Uptime check configurations for the project
        /// (leaving out any invalid configurations).
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="UptimeCheckConfig"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListUptimeCheckConfigsResponse, UptimeCheckConfig> ListUptimeCheckConfigs(
            ListUptimeCheckConfigsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUptimeCheckConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListUptimeCheckConfigsRequest, ListUptimeCheckConfigsResponse, UptimeCheckConfig>(_callListUptimeCheckConfigs, request, callSettings);
        }

        /// <summary>
        /// Gets a single Uptime check configuration.
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
        public override stt::Task<UptimeCheckConfig> GetUptimeCheckConfigAsync(
            GetUptimeCheckConfigRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetUptimeCheckConfigRequest(ref request, ref callSettings);
            return _callGetUptimeCheckConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a single Uptime check configuration.
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
        public override UptimeCheckConfig GetUptimeCheckConfig(
            GetUptimeCheckConfigRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetUptimeCheckConfigRequest(ref request, ref callSettings);
            return _callGetUptimeCheckConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new Uptime check configuration.
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
        public override stt::Task<UptimeCheckConfig> CreateUptimeCheckConfigAsync(
            CreateUptimeCheckConfigRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateUptimeCheckConfigRequest(ref request, ref callSettings);
            return _callCreateUptimeCheckConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new Uptime check configuration.
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
        public override UptimeCheckConfig CreateUptimeCheckConfig(
            CreateUptimeCheckConfigRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateUptimeCheckConfigRequest(ref request, ref callSettings);
            return _callCreateUptimeCheckConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an Uptime check configuration. You can either replace the entire
        /// configuration with a new one or replace only certain fields in the current
        /// configuration by specifying the fields to be updated via `updateMask`.
        /// Returns the updated configuration.
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
        public override stt::Task<UptimeCheckConfig> UpdateUptimeCheckConfigAsync(
            UpdateUptimeCheckConfigRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateUptimeCheckConfigRequest(ref request, ref callSettings);
            return _callUpdateUptimeCheckConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an Uptime check configuration. You can either replace the entire
        /// configuration with a new one or replace only certain fields in the current
        /// configuration by specifying the fields to be updated via `updateMask`.
        /// Returns the updated configuration.
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
        public override UptimeCheckConfig UpdateUptimeCheckConfig(
            UpdateUptimeCheckConfigRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateUptimeCheckConfigRequest(ref request, ref callSettings);
            return _callUpdateUptimeCheckConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an Uptime check configuration. Note that this method will fail
        /// if the Uptime check configuration is referenced by an alert policy or
        /// other dependent configs that would be rendered invalid by the deletion.
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
        public override stt::Task DeleteUptimeCheckConfigAsync(
            DeleteUptimeCheckConfigRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteUptimeCheckConfigRequest(ref request, ref callSettings);
            return _callDeleteUptimeCheckConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes an Uptime check configuration. Note that this method will fail
        /// if the Uptime check configuration is referenced by an alert policy or
        /// other dependent configs that would be rendered invalid by the deletion.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteUptimeCheckConfig(
            DeleteUptimeCheckConfigRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteUptimeCheckConfigRequest(ref request, ref callSettings);
            _callDeleteUptimeCheckConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the list of IP addresses that checkers run from
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="UptimeCheckIp"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListUptimeCheckIpsResponse, UptimeCheckIp> ListUptimeCheckIpsAsync(
            ListUptimeCheckIpsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUptimeCheckIpsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListUptimeCheckIpsRequest, ListUptimeCheckIpsResponse, UptimeCheckIp>(_callListUptimeCheckIps, request, callSettings);
        }

        /// <summary>
        /// Returns the list of IP addresses that checkers run from
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="UptimeCheckIp"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListUptimeCheckIpsResponse, UptimeCheckIp> ListUptimeCheckIps(
            ListUptimeCheckIpsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUptimeCheckIpsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListUptimeCheckIpsRequest, ListUptimeCheckIpsResponse, UptimeCheckIp>(_callListUptimeCheckIps, request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListUptimeCheckConfigsRequest : gaxgrpc::IPageRequest { }
    public partial class ListUptimeCheckConfigsResponse : gaxgrpc::IPageResponse<UptimeCheckConfig>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<UptimeCheckConfig> GetEnumerator() => UptimeCheckConfigs.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListUptimeCheckIpsRequest : gaxgrpc::IPageRequest { }
    public partial class ListUptimeCheckIpsResponse : gaxgrpc::IPageResponse<UptimeCheckIp>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<UptimeCheckIp> GetEnumerator() => UptimeCheckIps.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }


}
