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

using Google.Api.Gax;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Logging.V2
{

    /// <summary>
    /// Extension methods to assist with using <see cref="ConfigServiceV2Client"/>.
    /// </summary>
    public static partial class ConfigServiceV2Extensions
    {
        /// <summary>
        /// Wrap a GRPC ConfigServiceV2 client for more convenient use.
        /// </summary>
        /// <param name="grpcClient">A GRPC client to wrap.</param>
        /// <param name="settings">
        /// An optional <see cref="ConfigServiceV2Settings"/> to configure this wrapper.
        /// If null or not specified, then the default settings are used.
        /// </param>
        /// <returns>A <see cref="ConfigServiceV2Client"/> that wraps the specified GRPC client.</returns>
        public static ConfigServiceV2Client ToClient(
            this ConfigServiceV2.ConfigServiceV2Client grpcClient,
            ConfigServiceV2Settings settings = null
        ) => new ConfigServiceV2ClientImpl(grpcClient, settings);
    }

    /// <summary>
    /// Settings for a ConfigServiceV2 wrapper.
    /// </summary>
    public sealed partial class ConfigServiceV2Settings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="ConfigServiceV2Settings"/>.
        /// </summary>
        /// <returns>A new instance of the default ConfigServiceV2Settings.</returns>
        public static ConfigServiceV2Settings GetDefault() => new ConfigServiceV2Settings();

        /// <summary>
        /// Constructs a new ConfigServiceV2Settings object with default settings.
        /// </summary>
        public ConfigServiceV2Settings() { }

        private ConfigServiceV2Settings(ConfigServiceV2Settings existing) : base(existing)
        {
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListSinksSettings = existing.ListSinksSettings?.Clone();
            GetSinkSettings = existing.GetSinkSettings?.Clone();
            CreateSinkSettings = existing.CreateSinkSettings?.Clone();
            UpdateSinkSettings = existing.UpdateSinkSettings?.Clone();
            DeleteSinkSettings = existing.DeleteSinkSettings?.Clone();
        }

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="ConfigServiceV2Client"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="ConfigServiceV2Client"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static Predicate<RpcException> NonIdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="ConfigServiceV2Client"/> RPC methods.
        /// </summary>
        /// <returns>The "Default" retry backoff for <see cref="ConfigServiceV2Client"/> RPC methods.</returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="ConfigServiceV2Client"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.2</description></item>
        /// <item><description>Maximum delay: 1000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultRetryBackoff() => new BackoffSettings
        {
            Delay = TimeSpan.FromMilliseconds(100),
            DelayMultiplier = 1.2,
            MaxDelay = TimeSpan.FromMilliseconds(1000),
        };

        /// <summary>
        /// "Default" timeout backoff for <see cref="ConfigServiceV2Client"/> RPC methods.
        /// </summary>
        /// <returns>The "Default" timeout backoff for <see cref="ConfigServiceV2Client"/> RPC methods.</returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="ConfigServiceV2Client"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 2000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.5</description></item>
        /// <item><description>Maximum timeout: 30000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultTimeoutBackoff() => new BackoffSettings
        {
            Delay = TimeSpan.FromMilliseconds(2000),
            DelayMultiplier = 1.5,
            MaxDelay = TimeSpan.FromMilliseconds(30000),
        };

        /// <summary>
        /// <see cref="CallSettings"/> for asynchronous and synchronous calls to
        /// <see cref="ConfigServiceV2Client.ListSinksPageStream"/> and <see cref="ConfigServiceV2Client.ListSinksPageStreamAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="ConfigServiceV2Client.ListSinksPageStream"/> and
        /// <see cref="ConfigServiceV2Client.ListSinksPageStreamAsync"/> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.2</description></item>
        /// <item><description>Retry maximum delay: 1000 milliseconds</description></item>
        /// <item><description>Initial timeout: 2000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.5</description></item>
        /// <item><description>Timeout maximum delay: 30000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 45000 milliseconds.
        /// </remarks>
        public CallSettings ListSinksSettings { get; set; } = new CallSettings
        {
            RetrySettings = new RetrySettings
            {
                RetryBackoff = GetDefaultRetryBackoff(),
                TimeoutBackoff = GetDefaultTimeoutBackoff(),
                RetryFilter = IdempotentRetryFilter,
            },
            Expiration = Expiration.FromTimeout(TimeSpan.FromMilliseconds(45000)),
        };

        /// <summary>
        /// <see cref="CallSettings"/> for asynchronous and synchronous calls to
        /// <see cref="ConfigServiceV2Client.GetSink"/> and <see cref="ConfigServiceV2Client.GetSinkAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="ConfigServiceV2Client.GetSink"/> and
        /// <see cref="ConfigServiceV2Client.GetSinkAsync"/> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.2</description></item>
        /// <item><description>Retry maximum delay: 1000 milliseconds</description></item>
        /// <item><description>Initial timeout: 2000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.5</description></item>
        /// <item><description>Timeout maximum delay: 30000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 45000 milliseconds.
        /// </remarks>
        public CallSettings GetSinkSettings { get; set; } = new CallSettings
        {
            RetrySettings = new RetrySettings
            {
                RetryBackoff = GetDefaultRetryBackoff(),
                TimeoutBackoff = GetDefaultTimeoutBackoff(),
                RetryFilter = IdempotentRetryFilter,
            },
            Expiration = Expiration.FromTimeout(TimeSpan.FromMilliseconds(45000)),
        };

        /// <summary>
        /// <see cref="CallSettings"/> for asynchronous and synchronous calls to
        /// <see cref="ConfigServiceV2Client.CreateSink"/> and <see cref="ConfigServiceV2Client.CreateSinkAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="ConfigServiceV2Client.CreateSink"/> and
        /// <see cref="ConfigServiceV2Client.CreateSinkAsync"/> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.2</description></item>
        /// <item><description>Retry maximum delay: 1000 milliseconds</description></item>
        /// <item><description>Initial timeout: 2000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.5</description></item>
        /// <item><description>Timeout maximum delay: 30000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 45000 milliseconds.
        /// </remarks>
        public CallSettings CreateSinkSettings { get; set; } = new CallSettings
        {
            RetrySettings = new RetrySettings
            {
                RetryBackoff = GetDefaultRetryBackoff(),
                TimeoutBackoff = GetDefaultTimeoutBackoff(),
                RetryFilter = NonIdempotentRetryFilter,
            },
            Expiration = Expiration.FromTimeout(TimeSpan.FromMilliseconds(45000)),
        };

        /// <summary>
        /// <see cref="CallSettings"/> for asynchronous and synchronous calls to
        /// <see cref="ConfigServiceV2Client.UpdateSink"/> and <see cref="ConfigServiceV2Client.UpdateSinkAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="ConfigServiceV2Client.UpdateSink"/> and
        /// <see cref="ConfigServiceV2Client.UpdateSinkAsync"/> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.2</description></item>
        /// <item><description>Retry maximum delay: 1000 milliseconds</description></item>
        /// <item><description>Initial timeout: 2000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.5</description></item>
        /// <item><description>Timeout maximum delay: 30000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 45000 milliseconds.
        /// </remarks>
        public CallSettings UpdateSinkSettings { get; set; } = new CallSettings
        {
            RetrySettings = new RetrySettings
            {
                RetryBackoff = GetDefaultRetryBackoff(),
                TimeoutBackoff = GetDefaultTimeoutBackoff(),
                RetryFilter = NonIdempotentRetryFilter,
            },
            Expiration = Expiration.FromTimeout(TimeSpan.FromMilliseconds(45000)),
        };

        /// <summary>
        /// <see cref="CallSettings"/> for asynchronous and synchronous calls to
        /// <see cref="ConfigServiceV2Client.DeleteSink"/> and <see cref="ConfigServiceV2Client.DeleteSinkAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="ConfigServiceV2Client.DeleteSink"/> and
        /// <see cref="ConfigServiceV2Client.DeleteSinkAsync"/> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.2</description></item>
        /// <item><description>Retry maximum delay: 1000 milliseconds</description></item>
        /// <item><description>Initial timeout: 2000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.5</description></item>
        /// <item><description>Timeout maximum delay: 30000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 45000 milliseconds.
        /// </remarks>
        public CallSettings DeleteSinkSettings { get; set; } = new CallSettings
        {
            RetrySettings = new RetrySettings
            {
                RetryBackoff = GetDefaultRetryBackoff(),
                TimeoutBackoff = GetDefaultTimeoutBackoff(),
                RetryFilter = IdempotentRetryFilter,
            },
            Expiration = Expiration.FromTimeout(TimeSpan.FromMilliseconds(45000)),
        };


        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this set of ConfigServiceV2 settings.</returns>
        public ConfigServiceV2Settings Clone() => new ConfigServiceV2Settings(this);
    }

    /// <summary>
    /// ConfigServiceV2 client wrapper, for convenient use.
    /// </summary>
    public abstract partial class ConfigServiceV2Client
    {
        private static readonly ChannelPool s_channelPool = new ChannelPool();

        /// <summary>
        /// The default endpoint for the ConfigServiceV2 service, which is a host of "logging.googleapis.com" and a port of 443.
        /// </summary>
        public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("logging.googleapis.com", 443);

        /// <summary>
        /// The default ConfigServiceV2 scopes
        /// </summary>
        /// <remarks>
        /// The default ConfigServiceV2 scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/logging.write"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/logging.admin"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/logging.read"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform.read-only"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// </list>
        /// </remarks>
        public static IReadOnlyList<string> DefaultScopes { get; } = new ReadOnlyCollection<string>(new[] {
            "https://www.googleapis.com/auth/logging.write",
            "https://www.googleapis.com/auth/logging.admin",
            "https://www.googleapis.com/auth/logging.read",
            "https://www.googleapis.com/auth/cloud-platform.read-only",
            "https://www.googleapis.com/auth/cloud-platform",
        });

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
        public static string GetProjectName(string projectId) => ProjectTemplate.Expand(projectId);

        /// <summary>
        /// Path template for a sink resource. Parameters:
        /// <list type="bullet">
        /// <item><description>project</description></item>
        /// <item><description>sink</description></item>
        /// </list>
        /// </summary>
        public static PathTemplate SinkTemplate { get; } = new PathTemplate("projects/{project}/sinks/{sink}");

        /// <summary>
        /// Creates a sink resource name from its component IDs.
        /// </summary>
        /// <param name="projectId">The project ID.</param>
        /// <param name="sinkId">The sink ID.</param>
        /// <returns>The full sink resource name.</returns>
        public static string GetSinkName(string projectId, string sinkId) => SinkTemplate.Expand(projectId, sinkId);

        // Note: we could have parameterless overloads of Create and CreateAsync,
        // documented to just use the default endpoint, settings and credentials.
        // Pros:
        // - Might be more reassuring on first use
        // - Allows method group conversions
        // Con: overloads!

        /// <summary>
        /// Asynchronously creates a <see cref="ConfigServiceV2Client"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ConfigServiceV2Settings"/>.</param>
        /// <returns>The task representing the created <see cref="ConfigServiceV2Client"/>.</returns>
        public static async Task<ConfigServiceV2Client> CreateAsync(ServiceEndpoint endpoint = null, ConfigServiceV2Settings settings = null)
        {
            Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="ConfigServiceV2Client"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ConfigServiceV2Settings"/>.</param>
        /// <returns>The created <see cref="ConfigServiceV2Client"/>.</returns>
        public static ConfigServiceV2Client Create(ServiceEndpoint endpoint = null, ConfigServiceV2Settings settings = null)
        {
            Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="ConfigServiceV2Client"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="ConfigServiceV2Settings"/>.</param>
        /// <returns>The created <see cref="ConfigServiceV2Client"/>.</returns>
        public static ConfigServiceV2Client Create(Channel channel, ConfigServiceV2Settings settings = null)
        {
            GaxPreconditions.CheckNotNull(channel, nameof(channel));
            ConfigServiceV2.ConfigServiceV2Client grpcClient = new ConfigServiceV2.ConfigServiceV2Client(channel);
            return new ConfigServiceV2ClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, ConfigServiceV2Settings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, ConfigServiceV2Settings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, ConfigServiceV2Settings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, ConfigServiceV2Settings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying GRPC ConfigServiceV2 client.
        /// </summary>
        public virtual ConfigServiceV2.ConfigServiceV2Client GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Lists sinks.
        /// </summary>
        /// <param name="project_name">
        /// Required. The resource name of the project containing the sinks.
        /// Example: `"projects/my-logging-project"`, `"projects/01234567890"`.
        /// </param>
        /// <param name="pageToken">The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.</param>
        /// <param name="pageSize">The size of page to request.
        /// The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>An asynchronous sequence of pages of LogSink items.</returns>
        public virtual IPagedAsyncEnumerable<ListSinksResponse, LogSink> ListSinksPageStreamAsync(
            string projectName,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists sinks.
        /// </summary>
        /// <param name="project_name">
        /// Required. The resource name of the project containing the sinks.
        /// Example: `"projects/my-logging-project"`, `"projects/01234567890"`.
        /// </param>
        /// <param name="pageToken">The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.</param>
        /// <param name="pageSize">The size of page to request.
        /// The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A sequence of pages of LogSink items.</returns>
        public virtual IPagedEnumerable<ListSinksResponse, LogSink> ListSinksPageStream(
            string projectName,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a sink.
        /// </summary>
        /// <param name="sink_name">
        /// The resource name of the sink to return.
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<LogSink> GetSinkAsync(
            string sinkName,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a sink.
        /// </summary>
        /// <param name="sink_name">
        /// The resource name of the sink to return.
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<LogSink> GetSinkAsync(
            string sinkName,
            CancellationToken cancellationToken) => GetSinkAsync(
                sinkName,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Gets a sink.
        /// </summary>
        /// <param name="sink_name">
        /// The resource name of the sink to return.
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogSink GetSink(
            string sinkName,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a sink.
        /// </summary>
        /// <param name="project_name">
        /// The resource name of the project in which to create the sink.
        /// Example: `"projects/my-project-id"`.
        ///
        /// The new sink must be provided in the request.
        /// </param>
        /// <param name="sink">
        /// The new sink, which must not have an identifier that already
        /// exists.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<LogSink> CreateSinkAsync(
            string projectName,
            LogSink sink,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a sink.
        /// </summary>
        /// <param name="project_name">
        /// The resource name of the project in which to create the sink.
        /// Example: `"projects/my-project-id"`.
        ///
        /// The new sink must be provided in the request.
        /// </param>
        /// <param name="sink">
        /// The new sink, which must not have an identifier that already
        /// exists.
        /// </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<LogSink> CreateSinkAsync(
            string projectName,
            LogSink sink,
            CancellationToken cancellationToken) => CreateSinkAsync(
                projectName,
                sink,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Creates a sink.
        /// </summary>
        /// <param name="project_name">
        /// The resource name of the project in which to create the sink.
        /// Example: `"projects/my-project-id"`.
        ///
        /// The new sink must be provided in the request.
        /// </param>
        /// <param name="sink">
        /// The new sink, which must not have an identifier that already
        /// exists.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogSink CreateSink(
            string projectName,
            LogSink sink,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates or updates a sink.
        /// </summary>
        /// <param name="sink_name">
        /// The resource name of the sink to update.
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        ///
        /// The updated sink must be provided in the request and have the
        /// same name that is specified in `sinkName`.  If the sink does not
        /// exist, it is created.
        /// </param>
        /// <param name="sink">
        /// The updated sink, whose name must be the same as the sink
        /// identifier in `sinkName`.  If `sinkName` does not exist, then
        /// this method creates a new sink.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<LogSink> UpdateSinkAsync(
            string sinkName,
            LogSink sink,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates or updates a sink.
        /// </summary>
        /// <param name="sink_name">
        /// The resource name of the sink to update.
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        ///
        /// The updated sink must be provided in the request and have the
        /// same name that is specified in `sinkName`.  If the sink does not
        /// exist, it is created.
        /// </param>
        /// <param name="sink">
        /// The updated sink, whose name must be the same as the sink
        /// identifier in `sinkName`.  If `sinkName` does not exist, then
        /// this method creates a new sink.
        /// </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<LogSink> UpdateSinkAsync(
            string sinkName,
            LogSink sink,
            CancellationToken cancellationToken) => UpdateSinkAsync(
                sinkName,
                sink,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Creates or updates a sink.
        /// </summary>
        /// <param name="sink_name">
        /// The resource name of the sink to update.
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        ///
        /// The updated sink must be provided in the request and have the
        /// same name that is specified in `sinkName`.  If the sink does not
        /// exist, it is created.
        /// </param>
        /// <param name="sink">
        /// The updated sink, whose name must be the same as the sink
        /// identifier in `sinkName`.  If `sinkName` does not exist, then
        /// this method creates a new sink.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogSink UpdateSink(
            string sinkName,
            LogSink sink,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes a sink.
        /// </summary>
        /// <param name="sink_name">
        /// The resource name of the sink to delete.
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task DeleteSinkAsync(
            string sinkName,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes a sink.
        /// </summary>
        /// <param name="sink_name">
        /// The resource name of the sink to delete.
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task DeleteSinkAsync(
            string sinkName,
            CancellationToken cancellationToken) => DeleteSinkAsync(
                sinkName,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Deletes a sink.
        /// </summary>
        /// <param name="sink_name">
        /// The resource name of the sink to delete.
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSink(
            string sinkName,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    public sealed partial class ConfigServiceV2ClientImpl : ConfigServiceV2Client
    {
        private readonly ClientHelper _clientHelper;
        private readonly ApiCall<ListSinksRequest, ListSinksResponse> _callListSinks;
        private readonly ApiCall<GetSinkRequest, LogSink> _callGetSink;
        private readonly ApiCall<CreateSinkRequest, LogSink> _callCreateSink;
        private readonly ApiCall<UpdateSinkRequest, LogSink> _callUpdateSink;
        private readonly ApiCall<DeleteSinkRequest, Empty> _callDeleteSink;

        public ConfigServiceV2ClientImpl(ConfigServiceV2.ConfigServiceV2Client grpcClient, ConfigServiceV2Settings settings)
        {
            this.GrpcClient = grpcClient;
            ConfigServiceV2Settings effectiveSettings = settings ?? ConfigServiceV2Settings.GetDefault();
            _clientHelper = new ClientHelper(effectiveSettings);
            _callListSinks = _clientHelper.BuildApiCall<ListSinksRequest, ListSinksResponse>(
                GrpcClient.ListSinksAsync, GrpcClient.ListSinks, effectiveSettings.ListSinksSettings);
            _callGetSink = _clientHelper.BuildApiCall<GetSinkRequest, LogSink>(
                GrpcClient.GetSinkAsync, GrpcClient.GetSink, effectiveSettings.GetSinkSettings);
            _callCreateSink = _clientHelper.BuildApiCall<CreateSinkRequest, LogSink>(
                GrpcClient.CreateSinkAsync, GrpcClient.CreateSink, effectiveSettings.CreateSinkSettings);
            _callUpdateSink = _clientHelper.BuildApiCall<UpdateSinkRequest, LogSink>(
                GrpcClient.UpdateSinkAsync, GrpcClient.UpdateSink, effectiveSettings.UpdateSinkSettings);
            _callDeleteSink = _clientHelper.BuildApiCall<DeleteSinkRequest, Empty>(
                GrpcClient.DeleteSinkAsync, GrpcClient.DeleteSink, effectiveSettings.DeleteSinkSettings);
        }

        public override ConfigServiceV2.ConfigServiceV2Client GrpcClient { get; }

        /// <summary>
        /// Lists sinks.
        /// </summary>
        /// <param name="project_name">
        /// Required. The resource name of the project containing the sinks.
        /// Example: `"projects/my-logging-project"`, `"projects/01234567890"`.
        /// </param>
        /// <param name="pageToken">The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.</param>
        /// <param name="pageSize">The size of page to request.
        /// The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>An asynchronous sequence of pages of LogSink items.</returns>
        public override IPagedAsyncEnumerable<ListSinksResponse, LogSink> ListSinksPageStreamAsync(
            string projectName,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => new PagedAsyncEnumerable<ListSinksRequest, ListSinksResponse, LogSink>(
                _callListSinks,
                new ListSinksRequest
                {
                    ProjectName = projectName,
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists sinks.
        /// </summary>
        /// <param name="project_name">
        /// Required. The resource name of the project containing the sinks.
        /// Example: `"projects/my-logging-project"`, `"projects/01234567890"`.
        /// </param>
        /// <param name="pageToken">The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.</param>
        /// <param name="pageSize">The size of page to request.
        /// The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A sequence of pages of LogSink items.</returns>
        public override IPagedEnumerable<ListSinksResponse, LogSink> ListSinksPageStream(
            string projectName,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => new PagedEnumerable<ListSinksRequest, ListSinksResponse, LogSink>(
                _callListSinks,
                new ListSinksRequest
                {
                    ProjectName = projectName,
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Gets a sink.
        /// </summary>
        /// <param name="sink_name">
        /// The resource name of the sink to return.
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<LogSink> GetSinkAsync(
            string sinkName,
            CallSettings callSettings = null) => _callGetSink.Async(
                new GetSinkRequest
                {
                    SinkName = sinkName,
                },
                callSettings);

        /// <summary>
        /// Gets a sink.
        /// </summary>
        /// <param name="sink_name">
        /// The resource name of the sink to return.
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LogSink GetSink(
            string sinkName,
            CallSettings callSettings = null) => _callGetSink.Sync(
                new GetSinkRequest
                {
                    SinkName = sinkName,
                },
                callSettings);

        /// <summary>
        /// Creates a sink.
        /// </summary>
        /// <param name="project_name">
        /// The resource name of the project in which to create the sink.
        /// Example: `"projects/my-project-id"`.
        ///
        /// The new sink must be provided in the request.
        /// </param>
        /// <param name="sink">
        /// The new sink, which must not have an identifier that already
        /// exists.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<LogSink> CreateSinkAsync(
            string projectName,
            LogSink sink,
            CallSettings callSettings = null) => _callCreateSink.Async(
                new CreateSinkRequest
                {
                    ProjectName = projectName,
                    Sink = sink,
                },
                callSettings);

        /// <summary>
        /// Creates a sink.
        /// </summary>
        /// <param name="project_name">
        /// The resource name of the project in which to create the sink.
        /// Example: `"projects/my-project-id"`.
        ///
        /// The new sink must be provided in the request.
        /// </param>
        /// <param name="sink">
        /// The new sink, which must not have an identifier that already
        /// exists.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LogSink CreateSink(
            string projectName,
            LogSink sink,
            CallSettings callSettings = null) => _callCreateSink.Sync(
                new CreateSinkRequest
                {
                    ProjectName = projectName,
                    Sink = sink,
                },
                callSettings);

        /// <summary>
        /// Creates or updates a sink.
        /// </summary>
        /// <param name="sink_name">
        /// The resource name of the sink to update.
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        ///
        /// The updated sink must be provided in the request and have the
        /// same name that is specified in `sinkName`.  If the sink does not
        /// exist, it is created.
        /// </param>
        /// <param name="sink">
        /// The updated sink, whose name must be the same as the sink
        /// identifier in `sinkName`.  If `sinkName` does not exist, then
        /// this method creates a new sink.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<LogSink> UpdateSinkAsync(
            string sinkName,
            LogSink sink,
            CallSettings callSettings = null) => _callUpdateSink.Async(
                new UpdateSinkRequest
                {
                    SinkName = sinkName,
                    Sink = sink,
                },
                callSettings);

        /// <summary>
        /// Creates or updates a sink.
        /// </summary>
        /// <param name="sink_name">
        /// The resource name of the sink to update.
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        ///
        /// The updated sink must be provided in the request and have the
        /// same name that is specified in `sinkName`.  If the sink does not
        /// exist, it is created.
        /// </param>
        /// <param name="sink">
        /// The updated sink, whose name must be the same as the sink
        /// identifier in `sinkName`.  If `sinkName` does not exist, then
        /// this method creates a new sink.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LogSink UpdateSink(
            string sinkName,
            LogSink sink,
            CallSettings callSettings = null) => _callUpdateSink.Sync(
                new UpdateSinkRequest
                {
                    SinkName = sinkName,
                    Sink = sink,
                },
                callSettings);

        /// <summary>
        /// Deletes a sink.
        /// </summary>
        /// <param name="sink_name">
        /// The resource name of the sink to delete.
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task DeleteSinkAsync(
            string sinkName,
            CallSettings callSettings = null) => _callDeleteSink.Async(
                new DeleteSinkRequest
                {
                    SinkName = sinkName,
                },
                callSettings);

        /// <summary>
        /// Deletes a sink.
        /// </summary>
        /// <param name="sink_name">
        /// The resource name of the sink to delete.
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteSink(
            string sinkName,
            CallSettings callSettings = null) => _callDeleteSink.Sync(
                new DeleteSinkRequest
                {
                    SinkName = sinkName,
                },
                callSettings);

    }

    // Partial classes to enable page-streaming

    public partial class ListSinksRequest : IPageRequest { }
    public partial class ListSinksResponse : IPageResponse<LogSink>
    {
        public IEnumerator<LogSink> GetEnumerator() => Sinks.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

}