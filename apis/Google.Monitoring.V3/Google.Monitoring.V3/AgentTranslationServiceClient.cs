// Copyright 2016 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using Google.Api;
using Google.Api.Gax;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Monitoring.V3
{

    /// <summary>
    /// Extension methods to assist with using <see cref="AgentTranslationServiceClient"/>.
    /// </summary>
    public static partial class AgentTranslationServiceExtensions
    {
        /// <summary>
        /// Wrap a GRPC AgentTranslationService client for more convenient use.
        /// </summary>
        /// <param name="grpcClient">A GRPC client to wrap.</param>
        /// <param name="settings">
        /// An optional <see cref="AgentTranslationServiceSettings"/> to configure this wrapper.
        /// If null or not specified, then the default settings are used.
        /// </param>
        /// <returns>A <see cref="AgentTranslationServiceClient"/> that wraps the specified GRPC client.</returns>
        public static AgentTranslationServiceClient ToClient(
            this AgentTranslationService.AgentTranslationServiceClient grpcClient,
            AgentTranslationServiceSettings settings = null
        ) => new AgentTranslationServiceClientImpl(grpcClient, settings);
    }

    /// <summary>
    /// Settings for a AgentTranslationService wrapper.
    /// </summary>
    public sealed partial class AgentTranslationServiceSettings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="AgentTranslationServiceSettings"/>.
        /// </summary>
        /// <returns>A new instance of the default AgentTranslationServiceSettings.</returns>
        public static AgentTranslationServiceSettings GetDefault() => new AgentTranslationServiceSettings();

        /// <summary>
        /// Constructs a new AgentTranslationServiceSettings object with default settings.
        /// </summary>
        public AgentTranslationServiceSettings() { }

        private AgentTranslationServiceSettings(AgentTranslationServiceSettings existing) : base(existing)
        {
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateCollectdTimeSeriesSettings = existing.CreateCollectdTimeSeriesSettings?.Clone();
        }

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="AgentTranslationServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static Predicate<RpcException> IdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes(StatusCode.DeadlineExceeded, StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="AgentTranslationServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static Predicate<RpcException> NonIdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="AgentTranslationServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>The "Default" retry backoff for <see cref="AgentTranslationServiceClient"/> RPC methods.</returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="AgentTranslationServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultRetryBackoff() => new BackoffSettings
        {
            Delay = TimeSpan.FromMilliseconds(100),
            DelayMultiplier = 1.3,
            MaxDelay = TimeSpan.FromMilliseconds(60000),
        };

        /// <summary>
        /// "Default" timeout backoff for <see cref="AgentTranslationServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>The "Default" timeout backoff for <see cref="AgentTranslationServiceClient"/> RPC methods.</returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="AgentTranslationServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 20000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultTimeoutBackoff() => new BackoffSettings
        {
            Delay = TimeSpan.FromMilliseconds(20000),
            DelayMultiplier = 1.0,
            MaxDelay = TimeSpan.FromMilliseconds(20000),
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <see cref="AgentTranslationServiceClient.CreateCollectdTimeSeries"/> and <see cref="AgentTranslationServiceClient.CreateCollectdTimeSeriesAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="AgentTranslationServiceClient.CreateCollectdTimeSeries"/> and
        /// <see cref="AgentTranslationServiceClient.CreateCollectdTimeSeriesAsync"/> <see cref="RetrySettings"/> are:
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
        public CallSettings CreateCollectdTimeSeriesSettings { get; set; } = new CallSettings
        {
            Timing = CallTiming.FromRetry(new RetrySettings
            {
                RetryBackoff = GetDefaultRetryBackoff(),
                TimeoutBackoff = GetDefaultTimeoutBackoff(),
                RetryFilter = NonIdempotentRetryFilter,
                TotalExpiration = Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
            }),
        };


        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this set of AgentTranslationService settings.</returns>
        public AgentTranslationServiceSettings Clone() => new AgentTranslationServiceSettings(this);
    }

    /// <summary>
    /// AgentTranslationService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class AgentTranslationServiceClient
    {
        /// <summary>
        /// The default endpoint for the AgentTranslationService service, which is a host of "monitoring.googleapis.com" and a port of 443.
        /// </summary>
        public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("monitoring.googleapis.com", 443);

        /// <summary>
        /// The default AgentTranslationService scopes
        /// </summary>
        /// <remarks>
        /// The default AgentTranslationService scopes are:
        /// <list type="bullet">
        /// </list>
        /// </remarks>
        public static IReadOnlyList<string> DefaultScopes { get; } = new ReadOnlyCollection<string>(new string[] {
        });

        private static readonly ChannelPool s_channelPool = new ChannelPool(DefaultScopes);

        /// <summary>
        /// Path template for a project resource. Parameters:
        /// <list type="bullet">
        /// <item><description>project</description></item>
        /// </list>
        /// </summary>
        public static PathTemplate ProjectTemplate { get; } = new PathTemplate("projects/{project}");

        /// <summary>
        /// Creates a project resource name from its component IDs.
        /// </summary>
        /// <param name="projectId">The project ID.</param>
        /// <returns>The full project resource name.</returns>
        public static string FormatProjectName(string projectId) => ProjectTemplate.Expand(projectId);

        // Note: we could have parameterless overloads of Create and CreateAsync,
        // documented to just use the default endpoint, settings and credentials.
        // Pros:
        // - Might be more reassuring on first use
        // - Allows method group conversions
        // Con: overloads!

        /// <summary>
        /// Asynchronously creates a <see cref="AgentTranslationServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="AgentTranslationServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="AgentTranslationServiceClient"/>.</returns>
        public static async Task<AgentTranslationServiceClient> CreateAsync(ServiceEndpoint endpoint = null, AgentTranslationServiceSettings settings = null)
        {
            Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="AgentTranslationServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="AgentTranslationServiceSettings"/>.</param>
        /// <returns>The created <see cref="AgentTranslationServiceClient"/>.</returns>
        public static AgentTranslationServiceClient Create(ServiceEndpoint endpoint = null, AgentTranslationServiceSettings settings = null)
        {
            Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="AgentTranslationServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="AgentTranslationServiceSettings"/>.</param>
        /// <returns>The created <see cref="AgentTranslationServiceClient"/>.</returns>
        public static AgentTranslationServiceClient Create(Channel channel, AgentTranslationServiceSettings settings = null)
        {
            GaxPreconditions.CheckNotNull(channel, nameof(channel));
            AgentTranslationService.AgentTranslationServiceClient grpcClient = new AgentTranslationService.AgentTranslationServiceClient(channel);
            return new AgentTranslationServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, AgentTranslationServiceSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, AgentTranslationServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, AgentTranslationServiceSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, AgentTranslationServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying GRPC AgentTranslationService client.
        /// </summary>
        public virtual AgentTranslationService.AgentTranslationServiceClient GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="resource"></param>
        /// <param name="collectdVersion"></param>
        /// <param name="collectdPayloads"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task CreateCollectdTimeSeriesAsync(
            string name,
            MonitoredResource resource,
            string collectdVersion,
            IEnumerable<CollectdPayload> collectdPayloads,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="resource"></param>
        /// <param name="collectdVersion"></param>
        /// <param name="collectdPayloads"></param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task CreateCollectdTimeSeriesAsync(
            string name,
            MonitoredResource resource,
            string collectdVersion,
            IEnumerable<CollectdPayload> collectdPayloads,
            CancellationToken cancellationToken) => CreateCollectdTimeSeriesAsync(
                name,
                resource,
                collectdVersion,
                collectdPayloads,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="resource"></param>
        /// <param name="collectdVersion"></param>
        /// <param name="collectdPayloads"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void CreateCollectdTimeSeries(
            string name,
            MonitoredResource resource,
            string collectdVersion,
            IEnumerable<CollectdPayload> collectdPayloads,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    public sealed partial class AgentTranslationServiceClientImpl : AgentTranslationServiceClient
    {
        private readonly ClientHelper _clientHelper;
        private readonly ApiCall<CreateCollectdTimeSeriesRequest, Empty> _callCreateCollectdTimeSeries;

        public AgentTranslationServiceClientImpl(AgentTranslationService.AgentTranslationServiceClient grpcClient, AgentTranslationServiceSettings settings)
        {
            this.GrpcClient = grpcClient;
            AgentTranslationServiceSettings effectiveSettings = settings ?? AgentTranslationServiceSettings.GetDefault();
            _clientHelper = new ClientHelper(effectiveSettings);
            _callCreateCollectdTimeSeries = _clientHelper.BuildApiCall<CreateCollectdTimeSeriesRequest, Empty>(
                GrpcClient.CreateCollectdTimeSeriesAsync, GrpcClient.CreateCollectdTimeSeries, effectiveSettings.CreateCollectdTimeSeriesSettings);
        }

        public override AgentTranslationService.AgentTranslationServiceClient GrpcClient { get; }

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="resource"></param>
        /// <param name="collectdVersion"></param>
        /// <param name="collectdPayloads"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task CreateCollectdTimeSeriesAsync(
            string name,
            MonitoredResource resource,
            string collectdVersion,
            IEnumerable<CollectdPayload> collectdPayloads,
            CallSettings callSettings = null) => _callCreateCollectdTimeSeries.Async(
                new CreateCollectdTimeSeriesRequest
                {
                    Name = name,
                    Resource = resource,
                    CollectdVersion = collectdVersion,
                    CollectdPayloads = { collectdPayloads },
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="resource"></param>
        /// <param name="collectdVersion"></param>
        /// <param name="collectdPayloads"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void CreateCollectdTimeSeries(
            string name,
            MonitoredResource resource,
            string collectdVersion,
            IEnumerable<CollectdPayload> collectdPayloads,
            CallSettings callSettings = null) => _callCreateCollectdTimeSeries.Sync(
                new CreateCollectdTimeSeriesRequest
                {
                    Name = name,
                    Resource = resource,
                    CollectdVersion = collectdVersion,
                    CollectdPayloads = { collectdPayloads },
                },
                callSettings);

    }

    // Partial classes to enable page-streaming

}