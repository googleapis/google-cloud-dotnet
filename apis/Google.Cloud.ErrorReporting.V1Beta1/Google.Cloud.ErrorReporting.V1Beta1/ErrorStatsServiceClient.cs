// Copyright 2017, Google Inc. All rights reserved.
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
using Google.Api.Gax.Grpc;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.ErrorReporting.V1Beta1
{
    /// <summary>
    /// Settings for a <see cref="ErrorStatsServiceClient"/>.
    /// </summary>
    public sealed partial class ErrorStatsServiceSettings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="ErrorStatsServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="ErrorStatsServiceSettings"/>.
        /// </returns>
        public static ErrorStatsServiceSettings GetDefault() => new ErrorStatsServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ErrorStatsServiceSettings"/> object with default settings.
        /// </summary>
        public ErrorStatsServiceSettings() { }

        private ErrorStatsServiceSettings(ErrorStatsServiceSettings existing) : base(existing)
        {
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListGroupStatsSettings = existing.ListGroupStatsSettings;
            ListEventsSettings = existing.ListEventsSettings;
            DeleteEventsSettings = existing.DeleteEventsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ErrorStatsServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="ErrorStatsServiceClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="ErrorStatsServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static Predicate<RpcException> NonIdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="ErrorStatsServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="ErrorStatsServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="ErrorStatsServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultRetryBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(100),
            maxDelay: TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "Default" timeout backoff for <see cref="ErrorStatsServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="ErrorStatsServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="ErrorStatsServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 20000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultTimeoutBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(20000),
            maxDelay: TimeSpan.FromMilliseconds(20000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ErrorStatsServiceClient.ListGroupStats</c> and <c>ErrorStatsServiceClient.ListGroupStatsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ErrorStatsServiceClient.ListGroupStats</c> and
        /// <c>ErrorStatsServiceClient.ListGroupStatsAsync</c> <see cref="RetrySettings"/> are:
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
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings ListGroupStatsSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ErrorStatsServiceClient.ListEvents</c> and <c>ErrorStatsServiceClient.ListEventsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ErrorStatsServiceClient.ListEvents</c> and
        /// <c>ErrorStatsServiceClient.ListEventsAsync</c> <see cref="RetrySettings"/> are:
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
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings ListEventsSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ErrorStatsServiceClient.DeleteEvents</c> and <c>ErrorStatsServiceClient.DeleteEventsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ErrorStatsServiceClient.DeleteEvents</c> and
        /// <c>ErrorStatsServiceClient.DeleteEventsAsync</c> <see cref="RetrySettings"/> are:
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
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings DeleteEventsSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="ErrorStatsServiceSettings"/> object.</returns>
        public ErrorStatsServiceSettings Clone() => new ErrorStatsServiceSettings(this);
    }

    /// <summary>
    /// ErrorStatsService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class ErrorStatsServiceClient
    {
        /// <summary>
        /// The default endpoint for the ErrorStatsService service, which is a host of "clouderrorreporting.googleapis.com" and a port of 443.
        /// </summary>
        public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("clouderrorreporting.googleapis.com", 443);

        /// <summary>
        /// The default ErrorStatsService scopes.
        /// </summary>
        /// <remarks>
        /// The default ErrorStatsService scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// </list>
        /// </remarks>
        public static IReadOnlyList<string> DefaultScopes { get; } = new ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        private static readonly ChannelPool s_channelPool = new ChannelPool(DefaultScopes);

        // Note: we could have parameterless overloads of Create and CreateAsync,
        // documented to just use the default endpoint, settings and credentials.
        // Pros:
        // - Might be more reassuring on first use
        // - Allows method group conversions
        // Con: overloads!

        /// <summary>
        /// Asynchronously creates a <see cref="ErrorStatsServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ErrorStatsServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="ErrorStatsServiceClient"/>.</returns>
        public static async Task<ErrorStatsServiceClient> CreateAsync(ServiceEndpoint endpoint = null, ErrorStatsServiceSettings settings = null)
        {
            Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="ErrorStatsServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ErrorStatsServiceSettings"/>.</param>
        /// <returns>The created <see cref="ErrorStatsServiceClient"/>.</returns>
        public static ErrorStatsServiceClient Create(ServiceEndpoint endpoint = null, ErrorStatsServiceSettings settings = null)
        {
            Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="ErrorStatsServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="ErrorStatsServiceSettings"/>.</param>
        /// <returns>The created <see cref="ErrorStatsServiceClient"/>.</returns>
        public static ErrorStatsServiceClient Create(Channel channel, ErrorStatsServiceSettings settings = null)
        {
            GaxPreconditions.CheckNotNull(channel, nameof(channel));
            ErrorStatsService.ErrorStatsServiceClient grpcClient = new ErrorStatsService.ErrorStatsServiceClient(channel);
            return new ErrorStatsServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, ErrorStatsServiceSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, ErrorStatsServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, ErrorStatsServiceSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, ErrorStatsServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC ErrorStatsService client.
        /// </summary>
        public virtual ErrorStatsService.ErrorStatsServiceClient GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Lists the specified groups.
        /// </summary>
        /// <param name="projectName">
        /// [Required] The resource name of the Google Cloud Platform project. Written
        /// as &lt;code&gt;projects/&lt;/code&gt; plus the
        /// &lt;a href="https://support.google.com/cloud/answer/6158840"&gt;Google Cloud
        /// Platform project ID&lt;/a&gt;.
        ///
        /// Example: &lt;code&gt;projects/my-project-123&lt;/code&gt;.
        /// </param>
        /// <param name="timeRange">
        /// [Optional] List data for the given time range.
        /// If not set a default time range is used. The field time_range_begin
        /// in the response will specify the beginning of this time range.
        /// Only &lt;code&gt;ErrorGroupStats&lt;/code&gt; with a non-zero count in the given time
        /// range are returned, unless the request contains an explicit group_id list.
        /// If a group_id list is given, also &lt;code&gt;ErrorGroupStats&lt;/code&gt; with zero
        /// occurrences are returned.
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
        /// A pageable asynchronous sequence of <see cref="ErrorGroupStats"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListGroupStatsResponse, ErrorGroupStats> ListGroupStatsAsync(
            ProjectName projectName,
            QueryTimeRange timeRange,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListGroupStatsAsync(
                new ListGroupStatsRequest
                {
                    ProjectNameAsProjectName = GaxPreconditions.CheckNotNull(projectName, nameof(projectName)),
                    TimeRange = GaxPreconditions.CheckNotNull(timeRange, nameof(timeRange)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the specified groups.
        /// </summary>
        /// <param name="projectName">
        /// [Required] The resource name of the Google Cloud Platform project. Written
        /// as &lt;code&gt;projects/&lt;/code&gt; plus the
        /// &lt;a href="https://support.google.com/cloud/answer/6158840"&gt;Google Cloud
        /// Platform project ID&lt;/a&gt;.
        ///
        /// Example: &lt;code&gt;projects/my-project-123&lt;/code&gt;.
        /// </param>
        /// <param name="timeRange">
        /// [Optional] List data for the given time range.
        /// If not set a default time range is used. The field time_range_begin
        /// in the response will specify the beginning of this time range.
        /// Only &lt;code&gt;ErrorGroupStats&lt;/code&gt; with a non-zero count in the given time
        /// range are returned, unless the request contains an explicit group_id list.
        /// If a group_id list is given, also &lt;code&gt;ErrorGroupStats&lt;/code&gt; with zero
        /// occurrences are returned.
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
        /// A pageable sequence of <see cref="ErrorGroupStats"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListGroupStatsResponse, ErrorGroupStats> ListGroupStats(
            ProjectName projectName,
            QueryTimeRange timeRange,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListGroupStats(
                new ListGroupStatsRequest
                {
                    ProjectNameAsProjectName = GaxPreconditions.CheckNotNull(projectName, nameof(projectName)),
                    TimeRange = GaxPreconditions.CheckNotNull(timeRange, nameof(timeRange)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the specified groups.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ErrorGroupStats"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListGroupStatsResponse, ErrorGroupStats> ListGroupStatsAsync(
            ListGroupStatsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists the specified groups.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="ErrorGroupStats"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListGroupStatsResponse, ErrorGroupStats> ListGroupStats(
            ListGroupStatsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists the specified events.
        /// </summary>
        /// <param name="projectName">
        /// [Required] The resource name of the Google Cloud Platform project. Written
        /// as `projects/` plus the
        /// [Google Cloud Platform project
        /// ID](https://support.google.com/cloud/answer/6158840).
        /// Example: `projects/my-project-123`.
        /// </param>
        /// <param name="groupId">
        /// [Required] The group for which events shall be returned.
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
        /// A pageable asynchronous sequence of <see cref="ErrorEvent"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListEventsResponse, ErrorEvent> ListEventsAsync(
            ProjectName projectName,
            string groupId,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListEventsAsync(
                new ListEventsRequest
                {
                    ProjectNameAsProjectName = GaxPreconditions.CheckNotNull(projectName, nameof(projectName)),
                    GroupId = GaxPreconditions.CheckNotNullOrEmpty(groupId, nameof(groupId)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the specified events.
        /// </summary>
        /// <param name="projectName">
        /// [Required] The resource name of the Google Cloud Platform project. Written
        /// as `projects/` plus the
        /// [Google Cloud Platform project
        /// ID](https://support.google.com/cloud/answer/6158840).
        /// Example: `projects/my-project-123`.
        /// </param>
        /// <param name="groupId">
        /// [Required] The group for which events shall be returned.
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
        /// A pageable sequence of <see cref="ErrorEvent"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListEventsResponse, ErrorEvent> ListEvents(
            ProjectName projectName,
            string groupId,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListEvents(
                new ListEventsRequest
                {
                    ProjectNameAsProjectName = GaxPreconditions.CheckNotNull(projectName, nameof(projectName)),
                    GroupId = GaxPreconditions.CheckNotNullOrEmpty(groupId, nameof(groupId)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the specified events.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ErrorEvent"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListEventsResponse, ErrorEvent> ListEventsAsync(
            ListEventsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists the specified events.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="ErrorEvent"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListEventsResponse, ErrorEvent> ListEvents(
            ListEventsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes all error events of a given project.
        /// </summary>
        /// <param name="projectName">
        /// [Required] The resource name of the Google Cloud Platform project. Written
        /// as `projects/` plus the
        /// [Google Cloud Platform project
        /// ID](https://support.google.com/cloud/answer/6158840).
        /// Example: `projects/my-project-123`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<DeleteEventsResponse> DeleteEventsAsync(
            ProjectName projectName,
            CallSettings callSettings = null) => DeleteEventsAsync(
                new DeleteEventsRequest
                {
                    ProjectNameAsProjectName = GaxPreconditions.CheckNotNull(projectName, nameof(projectName)),
                },
                callSettings);

        /// <summary>
        /// Deletes all error events of a given project.
        /// </summary>
        /// <param name="projectName">
        /// [Required] The resource name of the Google Cloud Platform project. Written
        /// as `projects/` plus the
        /// [Google Cloud Platform project
        /// ID](https://support.google.com/cloud/answer/6158840).
        /// Example: `projects/my-project-123`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<DeleteEventsResponse> DeleteEventsAsync(
            ProjectName projectName,
            CancellationToken cancellationToken) => DeleteEventsAsync(
                projectName,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes all error events of a given project.
        /// </summary>
        /// <param name="projectName">
        /// [Required] The resource name of the Google Cloud Platform project. Written
        /// as `projects/` plus the
        /// [Google Cloud Platform project
        /// ID](https://support.google.com/cloud/answer/6158840).
        /// Example: `projects/my-project-123`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual DeleteEventsResponse DeleteEvents(
            ProjectName projectName,
            CallSettings callSettings = null) => DeleteEvents(
                new DeleteEventsRequest
                {
                    ProjectNameAsProjectName = GaxPreconditions.CheckNotNull(projectName, nameof(projectName)),
                },
                callSettings);

        /// <summary>
        /// Deletes all error events of a given project.
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
        public virtual Task<DeleteEventsResponse> DeleteEventsAsync(
            DeleteEventsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes all error events of a given project.
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
        public virtual DeleteEventsResponse DeleteEvents(
            DeleteEventsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    /// <summary>
    /// ErrorStatsService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class ErrorStatsServiceClientImpl : ErrorStatsServiceClient
    {
        private readonly ApiCall<ListGroupStatsRequest, ListGroupStatsResponse> _callListGroupStats;
        private readonly ApiCall<ListEventsRequest, ListEventsResponse> _callListEvents;
        private readonly ApiCall<DeleteEventsRequest, DeleteEventsResponse> _callDeleteEvents;

        /// <summary>
        /// Constructs a client wrapper for the ErrorStatsService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ErrorStatsServiceSettings"/> used within this client </param>
        public ErrorStatsServiceClientImpl(ErrorStatsService.ErrorStatsServiceClient grpcClient, ErrorStatsServiceSettings settings)
        {
            this.GrpcClient = grpcClient;
            ErrorStatsServiceSettings effectiveSettings = settings ?? ErrorStatsServiceSettings.GetDefault();
            ClientHelper clientHelper = new ClientHelper(effectiveSettings);
            _callListGroupStats = clientHelper.BuildApiCall<ListGroupStatsRequest, ListGroupStatsResponse>(
                GrpcClient.ListGroupStatsAsync, GrpcClient.ListGroupStats, effectiveSettings.ListGroupStatsSettings);
            _callListEvents = clientHelper.BuildApiCall<ListEventsRequest, ListEventsResponse>(
                GrpcClient.ListEventsAsync, GrpcClient.ListEvents, effectiveSettings.ListEventsSettings);
            _callDeleteEvents = clientHelper.BuildApiCall<DeleteEventsRequest, DeleteEventsResponse>(
                GrpcClient.DeleteEventsAsync, GrpcClient.DeleteEvents, effectiveSettings.DeleteEventsSettings);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void OnConstruction(ErrorStatsService.ErrorStatsServiceClient grpcClient, ErrorStatsServiceSettings effectiveSettings, ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC ErrorStatsService client.
        /// </summary>
        public override ErrorStatsService.ErrorStatsServiceClient GrpcClient { get; }

        // Partial modifier methods contain '_' to ensure no name conflicts with RPC methods.
        partial void Modify_ListGroupStatsRequest(ref ListGroupStatsRequest request, ref CallSettings settings);
        partial void Modify_ListEventsRequest(ref ListEventsRequest request, ref CallSettings settings);
        partial void Modify_DeleteEventsRequest(ref DeleteEventsRequest request, ref CallSettings settings);

        /// <summary>
        /// Lists the specified groups.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ErrorGroupStats"/> resources.
        /// </returns>
        public override PagedAsyncEnumerable<ListGroupStatsResponse, ErrorGroupStats> ListGroupStatsAsync(
            ListGroupStatsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListGroupStatsRequest(ref request, ref callSettings);
            return new GrpcPagedAsyncEnumerable<ListGroupStatsRequest, ListGroupStatsResponse, ErrorGroupStats>(_callListGroupStats, request, callSettings);
        }

        /// <summary>
        /// Lists the specified groups.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="ErrorGroupStats"/> resources.
        /// </returns>
        public override PagedEnumerable<ListGroupStatsResponse, ErrorGroupStats> ListGroupStats(
            ListGroupStatsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListGroupStatsRequest(ref request, ref callSettings);
            return new GrpcPagedEnumerable<ListGroupStatsRequest, ListGroupStatsResponse, ErrorGroupStats>(_callListGroupStats, request, callSettings);
        }

        /// <summary>
        /// Lists the specified events.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ErrorEvent"/> resources.
        /// </returns>
        public override PagedAsyncEnumerable<ListEventsResponse, ErrorEvent> ListEventsAsync(
            ListEventsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListEventsRequest(ref request, ref callSettings);
            return new GrpcPagedAsyncEnumerable<ListEventsRequest, ListEventsResponse, ErrorEvent>(_callListEvents, request, callSettings);
        }

        /// <summary>
        /// Lists the specified events.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="ErrorEvent"/> resources.
        /// </returns>
        public override PagedEnumerable<ListEventsResponse, ErrorEvent> ListEvents(
            ListEventsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListEventsRequest(ref request, ref callSettings);
            return new GrpcPagedEnumerable<ListEventsRequest, ListEventsResponse, ErrorEvent>(_callListEvents, request, callSettings);
        }

        /// <summary>
        /// Deletes all error events of a given project.
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
        public override Task<DeleteEventsResponse> DeleteEventsAsync(
            DeleteEventsRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteEventsRequest(ref request, ref callSettings);
            return _callDeleteEvents.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes all error events of a given project.
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
        public override DeleteEventsResponse DeleteEvents(
            DeleteEventsRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteEventsRequest(ref request, ref callSettings);
            return _callDeleteEvents.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListGroupStatsRequest : IPageRequest { }
    public partial class ListGroupStatsResponse : IPageResponse<ErrorGroupStats>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public IEnumerator<ErrorGroupStats> GetEnumerator() => ErrorGroupStats.GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListEventsRequest : IPageRequest { }
    public partial class ListEventsResponse : IPageResponse<ErrorEvent>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public IEnumerator<ErrorEvent> GetEnumerator() => ErrorEvents.GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

}
