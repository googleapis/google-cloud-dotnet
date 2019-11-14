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

namespace Google.Cloud.ErrorReporting.V1Beta1
{
    /// <summary>
    /// Settings for a <see cref="ErrorStatsServiceClient"/>.
    /// </summary>
    public sealed partial class ErrorStatsServiceSettings : gaxgrpc::ServiceSettingsBase
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
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListGroupStatsSettings = existing.ListGroupStatsSettings;
            ListEventsSettings = existing.ListEventsSettings;
            DeleteEventsSettings = existing.DeleteEventsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ErrorStatsServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="ErrorStatsServiceClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="ErrorStatsServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

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
        public static gaxgrpc::BackoffSettings GetDefaultRetryBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(100),
            maxDelay: sys::TimeSpan.FromMilliseconds(60000),
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
        public static gaxgrpc::BackoffSettings GetDefaultTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(20000),
            maxDelay: sys::TimeSpan.FromMilliseconds(20000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ErrorStatsServiceClient.ListGroupStats</c> and <c>ErrorStatsServiceClient.ListGroupStatsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ErrorStatsServiceClient.ListGroupStats</c> and
        /// <c>ErrorStatsServiceClient.ListGroupStatsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListGroupStatsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ErrorStatsServiceClient.ListEvents</c> and <c>ErrorStatsServiceClient.ListEventsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ErrorStatsServiceClient.ListEvents</c> and
        /// <c>ErrorStatsServiceClient.ListEventsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListEventsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ErrorStatsServiceClient.DeleteEvents</c> and <c>ErrorStatsServiceClient.DeleteEventsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ErrorStatsServiceClient.DeleteEvents</c> and
        /// <c>ErrorStatsServiceClient.DeleteEventsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings DeleteEventsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="ErrorStatsServiceSettings"/> object.</returns>
        public ErrorStatsServiceSettings Clone() => new ErrorStatsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ErrorStatsServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class ErrorStatsServiceClientBuilder : gaxgrpc::ClientBuilderBase<ErrorStatsServiceClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public ErrorStatsServiceSettings Settings { get; set; }

        /// <inheritdoc/>
        public override ErrorStatsServiceClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ErrorStatsServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<ErrorStatsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ErrorStatsServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => ErrorStatsServiceClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => ErrorStatsServiceClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => ErrorStatsServiceClient.ChannelPool;
    }

    /// <summary>
    /// ErrorStatsService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class ErrorStatsServiceClient
    {
        /// <summary>
        /// The default endpoint for the ErrorStatsService service, which is a host of "clouderrorreporting.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("clouderrorreporting.googleapis.com", 443);

        /// <summary>
        /// The default ErrorStatsService scopes.
        /// </summary>
        /// <remarks>
        /// The default ErrorStatsService scopes are:
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
        /// Asynchronously creates a <see cref="ErrorStatsServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.ErrorReporting.V1Beta1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// ErrorStatsServiceClient client = await ErrorStatsServiceClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.ErrorReporting.V1Beta1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     ErrorStatsServiceClient.DefaultEndpoint.Host, ErrorStatsServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ErrorStatsServiceClient client = ErrorStatsServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ErrorStatsServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="ErrorStatsServiceClient"/>.</returns>
        public static async stt::Task<ErrorStatsServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, ErrorStatsServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="ErrorStatsServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.ErrorReporting.V1Beta1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// ErrorStatsServiceClient client = ErrorStatsServiceClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.ErrorReporting.V1Beta1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     ErrorStatsServiceClient.DefaultEndpoint.Host, ErrorStatsServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ErrorStatsServiceClient client = ErrorStatsServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ErrorStatsServiceSettings"/>.</param>
        /// <returns>The created <see cref="ErrorStatsServiceClient"/>.</returns>
        public static ErrorStatsServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, ErrorStatsServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="ErrorStatsServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="ErrorStatsServiceSettings"/>.</param>
        /// <returns>The created <see cref="ErrorStatsServiceClient"/>.</returns>
        public static ErrorStatsServiceClient Create(grpccore::Channel channel, ErrorStatsServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="ErrorStatsServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="ErrorStatsServiceSettings"/>.</param>
        /// <returns>The created <see cref="ErrorStatsServiceClient"/>.</returns>
        public static ErrorStatsServiceClient Create(grpccore::CallInvoker callInvoker, ErrorStatsServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ErrorStatsService.ErrorStatsServiceClient grpcClient = new ErrorStatsService.ErrorStatsServiceClient(callInvoker);
            return new ErrorStatsServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, ErrorStatsServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, ErrorStatsServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, ErrorStatsServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, ErrorStatsServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC ErrorStatsService client.
        /// </summary>
        public virtual ErrorStatsService.ErrorStatsServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Lists the specified groups.
        /// </summary>
        /// <param name="projectName">
        /// Required. The resource name of the Google Cloud Platform project. Written
        /// as &lt;code&gt;projects/&lt;/code&gt; plus the
        /// &lt;a href="https://support.google.com/cloud/answer/6158840"&gt;Google Cloud
        /// Platform project ID&lt;/a&gt;.
        ///
        /// Example: &lt;code&gt;projects/my-project-123&lt;/code&gt;.
        /// </param>
        /// <param name="timeRange">
        /// Optional. List data for the given time range.
        /// If not set, a default time range is used. The field
        /// &lt;code&gt;time_range_begin&lt;/code&gt; in the response will specify the beginning
        /// of this time range.
        /// Only &lt;code&gt;ErrorGroupStats&lt;/code&gt; with a non-zero count in the given time
        /// range are returned, unless the request contains an explicit
        /// &lt;code&gt;group_id&lt;/code&gt; list. If a &lt;code&gt;group_id&lt;/code&gt; list is given, also
        /// &lt;code&gt;ErrorGroupStats&lt;/code&gt; with zero occurrences are returned.
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
        public virtual gax::PagedAsyncEnumerable<ListGroupStatsResponse, ErrorGroupStats> ListGroupStatsAsync(
            ProjectName projectName,
            QueryTimeRange timeRange,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListGroupStatsAsync(
                new ListGroupStatsRequest
                {
                    ProjectNameAsProjectName = gax::GaxPreconditions.CheckNotNull(projectName, nameof(projectName)),
                    TimeRange = timeRange, // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the specified groups.
        /// </summary>
        /// <param name="projectName">
        /// Required. The resource name of the Google Cloud Platform project. Written
        /// as &lt;code&gt;projects/&lt;/code&gt; plus the
        /// &lt;a href="https://support.google.com/cloud/answer/6158840"&gt;Google Cloud
        /// Platform project ID&lt;/a&gt;.
        ///
        /// Example: &lt;code&gt;projects/my-project-123&lt;/code&gt;.
        /// </param>
        /// <param name="timeRange">
        /// Optional. List data for the given time range.
        /// If not set, a default time range is used. The field
        /// &lt;code&gt;time_range_begin&lt;/code&gt; in the response will specify the beginning
        /// of this time range.
        /// Only &lt;code&gt;ErrorGroupStats&lt;/code&gt; with a non-zero count in the given time
        /// range are returned, unless the request contains an explicit
        /// &lt;code&gt;group_id&lt;/code&gt; list. If a &lt;code&gt;group_id&lt;/code&gt; list is given, also
        /// &lt;code&gt;ErrorGroupStats&lt;/code&gt; with zero occurrences are returned.
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
        public virtual gax::PagedEnumerable<ListGroupStatsResponse, ErrorGroupStats> ListGroupStats(
            ProjectName projectName,
            QueryTimeRange timeRange,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListGroupStats(
                new ListGroupStatsRequest
                {
                    ProjectNameAsProjectName = gax::GaxPreconditions.CheckNotNull(projectName, nameof(projectName)),
                    TimeRange = timeRange, // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the specified groups.
        /// </summary>
        /// <param name="projectName">
        /// Required. The resource name of the Google Cloud Platform project. Written
        /// as &lt;code&gt;projects/&lt;/code&gt; plus the
        /// &lt;a href="https://support.google.com/cloud/answer/6158840"&gt;Google Cloud
        /// Platform project ID&lt;/a&gt;.
        ///
        /// Example: &lt;code&gt;projects/my-project-123&lt;/code&gt;.
        /// </param>
        /// <param name="timeRange">
        /// Optional. List data for the given time range.
        /// If not set, a default time range is used. The field
        /// &lt;code&gt;time_range_begin&lt;/code&gt; in the response will specify the beginning
        /// of this time range.
        /// Only &lt;code&gt;ErrorGroupStats&lt;/code&gt; with a non-zero count in the given time
        /// range are returned, unless the request contains an explicit
        /// &lt;code&gt;group_id&lt;/code&gt; list. If a &lt;code&gt;group_id&lt;/code&gt; list is given, also
        /// &lt;code&gt;ErrorGroupStats&lt;/code&gt; with zero occurrences are returned.
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
        public virtual gax::PagedAsyncEnumerable<ListGroupStatsResponse, ErrorGroupStats> ListGroupStatsAsync(
            string projectName,
            QueryTimeRange timeRange,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListGroupStatsAsync(
                new ListGroupStatsRequest
                {
                    ProjectName = gax::GaxPreconditions.CheckNotNullOrEmpty(projectName, nameof(projectName)),
                    TimeRange = timeRange, // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the specified groups.
        /// </summary>
        /// <param name="projectName">
        /// Required. The resource name of the Google Cloud Platform project. Written
        /// as &lt;code&gt;projects/&lt;/code&gt; plus the
        /// &lt;a href="https://support.google.com/cloud/answer/6158840"&gt;Google Cloud
        /// Platform project ID&lt;/a&gt;.
        ///
        /// Example: &lt;code&gt;projects/my-project-123&lt;/code&gt;.
        /// </param>
        /// <param name="timeRange">
        /// Optional. List data for the given time range.
        /// If not set, a default time range is used. The field
        /// &lt;code&gt;time_range_begin&lt;/code&gt; in the response will specify the beginning
        /// of this time range.
        /// Only &lt;code&gt;ErrorGroupStats&lt;/code&gt; with a non-zero count in the given time
        /// range are returned, unless the request contains an explicit
        /// &lt;code&gt;group_id&lt;/code&gt; list. If a &lt;code&gt;group_id&lt;/code&gt; list is given, also
        /// &lt;code&gt;ErrorGroupStats&lt;/code&gt; with zero occurrences are returned.
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
        public virtual gax::PagedEnumerable<ListGroupStatsResponse, ErrorGroupStats> ListGroupStats(
            string projectName,
            QueryTimeRange timeRange,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListGroupStats(
                new ListGroupStatsRequest
                {
                    ProjectName = gax::GaxPreconditions.CheckNotNullOrEmpty(projectName, nameof(projectName)),
                    TimeRange = timeRange, // Optional
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
        public virtual gax::PagedAsyncEnumerable<ListGroupStatsResponse, ErrorGroupStats> ListGroupStatsAsync(
            ListGroupStatsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        public virtual gax::PagedEnumerable<ListGroupStatsResponse, ErrorGroupStats> ListGroupStats(
            ListGroupStatsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists the specified events.
        /// </summary>
        /// <param name="projectName">
        /// Required. The resource name of the Google Cloud Platform project. Written
        /// as `projects/` plus the
        /// [Google Cloud Platform project
        /// ID](https://support.google.com/cloud/answer/6158840).
        /// Example: `projects/my-project-123`.
        /// </param>
        /// <param name="groupId">
        /// Required. The group for which events shall be returned.
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
        public virtual gax::PagedAsyncEnumerable<ListEventsResponse, ErrorEvent> ListEventsAsync(
            ProjectName projectName,
            string groupId,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListEventsAsync(
                new ListEventsRequest
                {
                    ProjectNameAsProjectName = gax::GaxPreconditions.CheckNotNull(projectName, nameof(projectName)),
                    GroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(groupId, nameof(groupId)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the specified events.
        /// </summary>
        /// <param name="projectName">
        /// Required. The resource name of the Google Cloud Platform project. Written
        /// as `projects/` plus the
        /// [Google Cloud Platform project
        /// ID](https://support.google.com/cloud/answer/6158840).
        /// Example: `projects/my-project-123`.
        /// </param>
        /// <param name="groupId">
        /// Required. The group for which events shall be returned.
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
        public virtual gax::PagedEnumerable<ListEventsResponse, ErrorEvent> ListEvents(
            ProjectName projectName,
            string groupId,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListEvents(
                new ListEventsRequest
                {
                    ProjectNameAsProjectName = gax::GaxPreconditions.CheckNotNull(projectName, nameof(projectName)),
                    GroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(groupId, nameof(groupId)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the specified events.
        /// </summary>
        /// <param name="projectName">
        /// Required. The resource name of the Google Cloud Platform project. Written
        /// as `projects/` plus the
        /// [Google Cloud Platform project
        /// ID](https://support.google.com/cloud/answer/6158840).
        /// Example: `projects/my-project-123`.
        /// </param>
        /// <param name="groupId">
        /// Required. The group for which events shall be returned.
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
        public virtual gax::PagedAsyncEnumerable<ListEventsResponse, ErrorEvent> ListEventsAsync(
            string projectName,
            string groupId,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListEventsAsync(
                new ListEventsRequest
                {
                    ProjectName = gax::GaxPreconditions.CheckNotNullOrEmpty(projectName, nameof(projectName)),
                    GroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(groupId, nameof(groupId)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the specified events.
        /// </summary>
        /// <param name="projectName">
        /// Required. The resource name of the Google Cloud Platform project. Written
        /// as `projects/` plus the
        /// [Google Cloud Platform project
        /// ID](https://support.google.com/cloud/answer/6158840).
        /// Example: `projects/my-project-123`.
        /// </param>
        /// <param name="groupId">
        /// Required. The group for which events shall be returned.
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
        public virtual gax::PagedEnumerable<ListEventsResponse, ErrorEvent> ListEvents(
            string projectName,
            string groupId,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListEvents(
                new ListEventsRequest
                {
                    ProjectName = gax::GaxPreconditions.CheckNotNullOrEmpty(projectName, nameof(projectName)),
                    GroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(groupId, nameof(groupId)),
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
        public virtual gax::PagedAsyncEnumerable<ListEventsResponse, ErrorEvent> ListEventsAsync(
            ListEventsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        public virtual gax::PagedEnumerable<ListEventsResponse, ErrorEvent> ListEvents(
            ListEventsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes all error events of a given project.
        /// </summary>
        /// <param name="projectName">
        /// Required. The resource name of the Google Cloud Platform project. Written
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
        public virtual stt::Task<DeleteEventsResponse> DeleteEventsAsync(
            ProjectName projectName,
            gaxgrpc::CallSettings callSettings = null) => DeleteEventsAsync(
                new DeleteEventsRequest
                {
                    ProjectNameAsProjectName = gax::GaxPreconditions.CheckNotNull(projectName, nameof(projectName)),
                },
                callSettings);

        /// <summary>
        /// Deletes all error events of a given project.
        /// </summary>
        /// <param name="projectName">
        /// Required. The resource name of the Google Cloud Platform project. Written
        /// as `projects/` plus the
        /// [Google Cloud Platform project
        /// ID](https://support.google.com/cloud/answer/6158840).
        /// Example: `projects/my-project-123`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<DeleteEventsResponse> DeleteEventsAsync(
            ProjectName projectName,
            st::CancellationToken cancellationToken) => DeleteEventsAsync(
                projectName,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes all error events of a given project.
        /// </summary>
        /// <param name="projectName">
        /// Required. The resource name of the Google Cloud Platform project. Written
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
            gaxgrpc::CallSettings callSettings = null) => DeleteEvents(
                new DeleteEventsRequest
                {
                    ProjectNameAsProjectName = gax::GaxPreconditions.CheckNotNull(projectName, nameof(projectName)),
                },
                callSettings);

        /// <summary>
        /// Deletes all error events of a given project.
        /// </summary>
        /// <param name="projectName">
        /// Required. The resource name of the Google Cloud Platform project. Written
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
        public virtual stt::Task<DeleteEventsResponse> DeleteEventsAsync(
            string projectName,
            gaxgrpc::CallSettings callSettings = null) => DeleteEventsAsync(
                new DeleteEventsRequest
                {
                    ProjectName = gax::GaxPreconditions.CheckNotNullOrEmpty(projectName, nameof(projectName)),
                },
                callSettings);

        /// <summary>
        /// Deletes all error events of a given project.
        /// </summary>
        /// <param name="projectName">
        /// Required. The resource name of the Google Cloud Platform project. Written
        /// as `projects/` plus the
        /// [Google Cloud Platform project
        /// ID](https://support.google.com/cloud/answer/6158840).
        /// Example: `projects/my-project-123`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<DeleteEventsResponse> DeleteEventsAsync(
            string projectName,
            st::CancellationToken cancellationToken) => DeleteEventsAsync(
                projectName,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes all error events of a given project.
        /// </summary>
        /// <param name="projectName">
        /// Required. The resource name of the Google Cloud Platform project. Written
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
            string projectName,
            gaxgrpc::CallSettings callSettings = null) => DeleteEvents(
                new DeleteEventsRequest
                {
                    ProjectName = gax::GaxPreconditions.CheckNotNullOrEmpty(projectName, nameof(projectName)),
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
        public virtual stt::Task<DeleteEventsResponse> DeleteEventsAsync(
            DeleteEventsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes all error events of a given project.
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
        public virtual stt::Task<DeleteEventsResponse> DeleteEventsAsync(
            DeleteEventsRequest request,
            st::CancellationToken cancellationToken) => DeleteEventsAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// ErrorStatsService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class ErrorStatsServiceClientImpl : ErrorStatsServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListGroupStatsRequest, ListGroupStatsResponse> _callListGroupStats;
        private readonly gaxgrpc::ApiCall<ListEventsRequest, ListEventsResponse> _callListEvents;
        private readonly gaxgrpc::ApiCall<DeleteEventsRequest, DeleteEventsResponse> _callDeleteEvents;

        /// <summary>
        /// Constructs a client wrapper for the ErrorStatsService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ErrorStatsServiceSettings"/> used within this client </param>
        public ErrorStatsServiceClientImpl(ErrorStatsService.ErrorStatsServiceClient grpcClient, ErrorStatsServiceSettings settings)
        {
            GrpcClient = grpcClient;
            ErrorStatsServiceSettings effectiveSettings = settings ?? ErrorStatsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callListGroupStats = clientHelper.BuildApiCall<ListGroupStatsRequest, ListGroupStatsResponse>(
                GrpcClient.ListGroupStatsAsync, GrpcClient.ListGroupStats, effectiveSettings.ListGroupStatsSettings)
                .WithGoogleRequestParam("project_name", request => request.ProjectName);
            _callListEvents = clientHelper.BuildApiCall<ListEventsRequest, ListEventsResponse>(
                GrpcClient.ListEventsAsync, GrpcClient.ListEvents, effectiveSettings.ListEventsSettings)
                .WithGoogleRequestParam("project_name", request => request.ProjectName);
            _callDeleteEvents = clientHelper.BuildApiCall<DeleteEventsRequest, DeleteEventsResponse>(
                GrpcClient.DeleteEventsAsync, GrpcClient.DeleteEvents, effectiveSettings.DeleteEventsSettings)
                .WithGoogleRequestParam("project_name", request => request.ProjectName);
            Modify_ApiCall(ref _callListGroupStats);
            Modify_ListGroupStatsApiCall(ref _callListGroupStats);
            Modify_ApiCall(ref _callListEvents);
            Modify_ListEventsApiCall(ref _callListEvents);
            Modify_ApiCall(ref _callDeleteEvents);
            Modify_DeleteEventsApiCall(ref _callDeleteEvents);
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
        partial void Modify_ListGroupStatsApiCall(ref gaxgrpc::ApiCall<ListGroupStatsRequest, ListGroupStatsResponse> call);
        partial void Modify_ListEventsApiCall(ref gaxgrpc::ApiCall<ListEventsRequest, ListEventsResponse> call);
        partial void Modify_DeleteEventsApiCall(ref gaxgrpc::ApiCall<DeleteEventsRequest, DeleteEventsResponse> call);
        partial void OnConstruction(ErrorStatsService.ErrorStatsServiceClient grpcClient, ErrorStatsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC ErrorStatsService client.
        /// </summary>
        public override ErrorStatsService.ErrorStatsServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_ListGroupStatsRequest(ref ListGroupStatsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListEventsRequest(ref ListEventsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteEventsRequest(ref DeleteEventsRequest request, ref gaxgrpc::CallSettings settings);

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
        public override gax::PagedAsyncEnumerable<ListGroupStatsResponse, ErrorGroupStats> ListGroupStatsAsync(
            ListGroupStatsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGroupStatsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListGroupStatsRequest, ListGroupStatsResponse, ErrorGroupStats>(_callListGroupStats, request, callSettings);
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
        public override gax::PagedEnumerable<ListGroupStatsResponse, ErrorGroupStats> ListGroupStats(
            ListGroupStatsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGroupStatsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListGroupStatsRequest, ListGroupStatsResponse, ErrorGroupStats>(_callListGroupStats, request, callSettings);
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
        public override gax::PagedAsyncEnumerable<ListEventsResponse, ErrorEvent> ListEventsAsync(
            ListEventsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEventsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEventsRequest, ListEventsResponse, ErrorEvent>(_callListEvents, request, callSettings);
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
        public override gax::PagedEnumerable<ListEventsResponse, ErrorEvent> ListEvents(
            ListEventsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEventsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEventsRequest, ListEventsResponse, ErrorEvent>(_callListEvents, request, callSettings);
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
        public override stt::Task<DeleteEventsResponse> DeleteEventsAsync(
            DeleteEventsRequest request,
            gaxgrpc::CallSettings callSettings = null)
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
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEventsRequest(ref request, ref callSettings);
            return _callDeleteEvents.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListGroupStatsRequest : gaxgrpc::IPageRequest { }
    public partial class ListGroupStatsResponse : gaxgrpc::IPageResponse<ErrorGroupStats>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<ErrorGroupStats> GetEnumerator() => ErrorGroupStats.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListEventsRequest : gaxgrpc::IPageRequest { }
    public partial class ListEventsResponse : gaxgrpc::IPageResponse<ErrorEvent>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<ErrorEvent> GetEnumerator() => ErrorEvents.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }


}
