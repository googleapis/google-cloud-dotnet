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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.ErrorReporting.V1Beta1
{
    /// <summary>Settings for <see cref="ErrorStatsServiceClient"/> instances.</summary>
    public sealed partial class ErrorStatsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ErrorStatsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ErrorStatsServiceSettings"/>.</returns>
        public static ErrorStatsServiceSettings GetDefault() => new ErrorStatsServiceSettings();

        /// <summary>Constructs a new <see cref="ErrorStatsServiceSettings"/> object with default settings.</summary>
        public ErrorStatsServiceSettings()
        {
        }

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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ErrorStatsServiceClient.ListGroupStats</c> and <c>ErrorStatsServiceClient.ListGroupStatsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListGroupStatsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ErrorStatsServiceClient.ListEvents</c> and <c>ErrorStatsServiceClient.ListEventsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListEventsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ErrorStatsServiceClient.DeleteEvents</c> and <c>ErrorStatsServiceClient.DeleteEventsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteEventsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ErrorStatsServiceSettings"/> object.</returns>
        public ErrorStatsServiceSettings Clone() => new ErrorStatsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ErrorStatsServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class ErrorStatsServiceClientBuilder : gaxgrpc::ClientBuilderBase<ErrorStatsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ErrorStatsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ErrorStatsServiceClientBuilder() : base(ErrorStatsServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ErrorStatsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ErrorStatsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ErrorStatsServiceClient Build()
        {
            ErrorStatsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ErrorStatsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ErrorStatsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ErrorStatsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ErrorStatsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ErrorStatsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ErrorStatsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ErrorStatsServiceClient.ChannelPool;
    }

    /// <summary>ErrorStatsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// An API for retrieving and managing error statistics as well as data for
    /// individual events.
    /// </remarks>
    public abstract partial class ErrorStatsServiceClient
    {
        /// <summary>
        /// The default endpoint for the ErrorStatsService service, which is a host of
        /// "clouderrorreporting.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "clouderrorreporting.googleapis.com:443";

        /// <summary>The default ErrorStatsService scopes.</summary>
        /// <remarks>
        /// The default ErrorStatsService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ErrorStatsService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ErrorStatsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ErrorStatsServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ErrorStatsServiceClient"/>.</returns>
        public static stt::Task<ErrorStatsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ErrorStatsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ErrorStatsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ErrorStatsServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ErrorStatsServiceClient"/>.</returns>
        public static ErrorStatsServiceClient Create() => new ErrorStatsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ErrorStatsServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ErrorStatsServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ErrorStatsServiceClient"/>.</returns>
        internal static ErrorStatsServiceClient Create(grpccore::CallInvoker callInvoker, ErrorStatsServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ErrorStatsService.ErrorStatsServiceClient grpcClient = new ErrorStatsService.ErrorStatsServiceClient(callInvoker);
            return new ErrorStatsServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ErrorStatsService client</summary>
        public virtual ErrorStatsService.ErrorStatsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the specified groups.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ErrorGroupStats"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGroupStatsResponse, ErrorGroupStats> ListGroupStats(ListGroupStatsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the specified groups.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ErrorGroupStats"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGroupStatsResponse, ErrorGroupStats> ListGroupStatsAsync(ListGroupStatsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the specified groups.
        /// </summary>
        /// <param name="projectName">
        /// Required. The resource name of the Google Cloud Platform project. Written
        /// as `projects/{projectID}` or `projects/{projectNumber}`, where
        /// `{projectID}` and `{projectNumber}` can be found in the
        /// [Google Cloud console](https://support.google.com/cloud/answer/6158840).
        /// It may also include a location, such as
        /// `projects/{projectID}/locations/{location}` where `{location}` is a cloud
        /// region.
        /// 
        /// Examples: `projects/my-project-123`, `projects/5551234`,
        /// `projects/my-project-123/locations/us-central1`,
        /// `projects/5551234/locations/us-central1`.
        /// 
        /// For a list of supported locations, see [Supported
        /// Regions](https://cloud.google.com/logging/docs/region-support). `global` is
        /// the default when unspecified. Use `-` as a wildcard to request group stats
        /// from all regions.
        /// </param>
        /// <param name="timeRange">
        /// Optional. List data for the given time range.
        /// If not set, a default time range is used. The field
        /// [time_range_begin]
        /// [google.devtools.clouderrorreporting.v1beta1.ListGroupStatsResponse.time_range_begin]
        /// in the response will specify the beginning of this time range. Only
        /// [ErrorGroupStats]
        /// [google.devtools.clouderrorreporting.v1beta1.ErrorGroupStats] with a
        /// non-zero count in the given time range are returned, unless the request
        /// contains an explicit [group_id]
        /// [google.devtools.clouderrorreporting.v1beta1.ListGroupStatsRequest.group_id]
        /// list. If a [group_id]
        /// [google.devtools.clouderrorreporting.v1beta1.ListGroupStatsRequest.group_id]
        /// list is given, also [ErrorGroupStats]
        /// [google.devtools.clouderrorreporting.v1beta1.ErrorGroupStats] with zero
        /// occurrences are returned.
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
        /// <returns>A pageable sequence of <see cref="ErrorGroupStats"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGroupStatsResponse, ErrorGroupStats> ListGroupStats(string projectName, QueryTimeRange timeRange, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGroupStatsRequest request = new ListGroupStatsRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNullOrEmpty(projectName, nameof(projectName)),
                TimeRange = timeRange,
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListGroupStats(request, callSettings);
        }

        /// <summary>
        /// Lists the specified groups.
        /// </summary>
        /// <param name="projectName">
        /// Required. The resource name of the Google Cloud Platform project. Written
        /// as `projects/{projectID}` or `projects/{projectNumber}`, where
        /// `{projectID}` and `{projectNumber}` can be found in the
        /// [Google Cloud console](https://support.google.com/cloud/answer/6158840).
        /// It may also include a location, such as
        /// `projects/{projectID}/locations/{location}` where `{location}` is a cloud
        /// region.
        /// 
        /// Examples: `projects/my-project-123`, `projects/5551234`,
        /// `projects/my-project-123/locations/us-central1`,
        /// `projects/5551234/locations/us-central1`.
        /// 
        /// For a list of supported locations, see [Supported
        /// Regions](https://cloud.google.com/logging/docs/region-support). `global` is
        /// the default when unspecified. Use `-` as a wildcard to request group stats
        /// from all regions.
        /// </param>
        /// <param name="timeRange">
        /// Optional. List data for the given time range.
        /// If not set, a default time range is used. The field
        /// [time_range_begin]
        /// [google.devtools.clouderrorreporting.v1beta1.ListGroupStatsResponse.time_range_begin]
        /// in the response will specify the beginning of this time range. Only
        /// [ErrorGroupStats]
        /// [google.devtools.clouderrorreporting.v1beta1.ErrorGroupStats] with a
        /// non-zero count in the given time range are returned, unless the request
        /// contains an explicit [group_id]
        /// [google.devtools.clouderrorreporting.v1beta1.ListGroupStatsRequest.group_id]
        /// list. If a [group_id]
        /// [google.devtools.clouderrorreporting.v1beta1.ListGroupStatsRequest.group_id]
        /// list is given, also [ErrorGroupStats]
        /// [google.devtools.clouderrorreporting.v1beta1.ErrorGroupStats] with zero
        /// occurrences are returned.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ErrorGroupStats"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGroupStatsResponse, ErrorGroupStats> ListGroupStatsAsync(string projectName, QueryTimeRange timeRange, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGroupStatsRequest request = new ListGroupStatsRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNullOrEmpty(projectName, nameof(projectName)),
                TimeRange = timeRange,
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListGroupStatsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the specified groups.
        /// </summary>
        /// <param name="projectName">
        /// Required. The resource name of the Google Cloud Platform project. Written
        /// as `projects/{projectID}` or `projects/{projectNumber}`, where
        /// `{projectID}` and `{projectNumber}` can be found in the
        /// [Google Cloud console](https://support.google.com/cloud/answer/6158840).
        /// It may also include a location, such as
        /// `projects/{projectID}/locations/{location}` where `{location}` is a cloud
        /// region.
        /// 
        /// Examples: `projects/my-project-123`, `projects/5551234`,
        /// `projects/my-project-123/locations/us-central1`,
        /// `projects/5551234/locations/us-central1`.
        /// 
        /// For a list of supported locations, see [Supported
        /// Regions](https://cloud.google.com/logging/docs/region-support). `global` is
        /// the default when unspecified. Use `-` as a wildcard to request group stats
        /// from all regions.
        /// </param>
        /// <param name="timeRange">
        /// Optional. List data for the given time range.
        /// If not set, a default time range is used. The field
        /// [time_range_begin]
        /// [google.devtools.clouderrorreporting.v1beta1.ListGroupStatsResponse.time_range_begin]
        /// in the response will specify the beginning of this time range. Only
        /// [ErrorGroupStats]
        /// [google.devtools.clouderrorreporting.v1beta1.ErrorGroupStats] with a
        /// non-zero count in the given time range are returned, unless the request
        /// contains an explicit [group_id]
        /// [google.devtools.clouderrorreporting.v1beta1.ListGroupStatsRequest.group_id]
        /// list. If a [group_id]
        /// [google.devtools.clouderrorreporting.v1beta1.ListGroupStatsRequest.group_id]
        /// list is given, also [ErrorGroupStats]
        /// [google.devtools.clouderrorreporting.v1beta1.ErrorGroupStats] with zero
        /// occurrences are returned.
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
        /// <returns>A pageable sequence of <see cref="ErrorGroupStats"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGroupStatsResponse, ErrorGroupStats> ListGroupStats(gagr::ProjectName projectName, QueryTimeRange timeRange, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGroupStatsRequest request = new ListGroupStatsRequest
            {
                ProjectNameAsProjectName = gax::GaxPreconditions.CheckNotNull(projectName, nameof(projectName)),
                TimeRange = timeRange,
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListGroupStats(request, callSettings);
        }

        /// <summary>
        /// Lists the specified groups.
        /// </summary>
        /// <param name="projectName">
        /// Required. The resource name of the Google Cloud Platform project. Written
        /// as `projects/{projectID}` or `projects/{projectNumber}`, where
        /// `{projectID}` and `{projectNumber}` can be found in the
        /// [Google Cloud console](https://support.google.com/cloud/answer/6158840).
        /// It may also include a location, such as
        /// `projects/{projectID}/locations/{location}` where `{location}` is a cloud
        /// region.
        /// 
        /// Examples: `projects/my-project-123`, `projects/5551234`,
        /// `projects/my-project-123/locations/us-central1`,
        /// `projects/5551234/locations/us-central1`.
        /// 
        /// For a list of supported locations, see [Supported
        /// Regions](https://cloud.google.com/logging/docs/region-support). `global` is
        /// the default when unspecified. Use `-` as a wildcard to request group stats
        /// from all regions.
        /// </param>
        /// <param name="timeRange">
        /// Optional. List data for the given time range.
        /// If not set, a default time range is used. The field
        /// [time_range_begin]
        /// [google.devtools.clouderrorreporting.v1beta1.ListGroupStatsResponse.time_range_begin]
        /// in the response will specify the beginning of this time range. Only
        /// [ErrorGroupStats]
        /// [google.devtools.clouderrorreporting.v1beta1.ErrorGroupStats] with a
        /// non-zero count in the given time range are returned, unless the request
        /// contains an explicit [group_id]
        /// [google.devtools.clouderrorreporting.v1beta1.ListGroupStatsRequest.group_id]
        /// list. If a [group_id]
        /// [google.devtools.clouderrorreporting.v1beta1.ListGroupStatsRequest.group_id]
        /// list is given, also [ErrorGroupStats]
        /// [google.devtools.clouderrorreporting.v1beta1.ErrorGroupStats] with zero
        /// occurrences are returned.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ErrorGroupStats"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGroupStatsResponse, ErrorGroupStats> ListGroupStatsAsync(gagr::ProjectName projectName, QueryTimeRange timeRange, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGroupStatsRequest request = new ListGroupStatsRequest
            {
                ProjectNameAsProjectName = gax::GaxPreconditions.CheckNotNull(projectName, nameof(projectName)),
                TimeRange = timeRange,
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListGroupStatsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the specified events.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ErrorEvent"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEventsResponse, ErrorEvent> ListEvents(ListEventsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the specified events.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ErrorEvent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEventsResponse, ErrorEvent> ListEventsAsync(ListEventsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the specified events.
        /// </summary>
        /// <param name="projectName">
        /// Required. The resource name of the Google Cloud Platform project. Written
        /// as `projects/{projectID}` or `projects/{projectID}/locations/{location}`,
        /// where `{projectID}` is the [Google Cloud Platform project
        /// ID](https://support.google.com/cloud/answer/6158840) and `{location}` is
        /// a Cloud region.
        /// 
        /// Examples: `projects/my-project-123`,
        /// `projects/my-project-123/locations/global`.
        /// 
        /// For a list of supported locations, see [Supported
        /// Regions](https://cloud.google.com/logging/docs/region-support). `global` is
        /// the default when unspecified.
        /// </param>
        /// <param name="groupId">
        /// Required. The group for which events shall be returned.
        /// The `group_id` is a unique identifier for a particular error group. The
        /// identifier is derived from key parts of the error-log content and is
        /// treated as Service Data. For information about how Service Data
        /// is handled, see [Google Cloud Privacy
        /// Notice](https://cloud.google.com/terms/cloud-privacy-notice).
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
        /// <returns>A pageable sequence of <see cref="ErrorEvent"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEventsResponse, ErrorEvent> ListEvents(string projectName, string groupId, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEventsRequest request = new ListEventsRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNullOrEmpty(projectName, nameof(projectName)),
                GroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(groupId, nameof(groupId)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEvents(request, callSettings);
        }

        /// <summary>
        /// Lists the specified events.
        /// </summary>
        /// <param name="projectName">
        /// Required. The resource name of the Google Cloud Platform project. Written
        /// as `projects/{projectID}` or `projects/{projectID}/locations/{location}`,
        /// where `{projectID}` is the [Google Cloud Platform project
        /// ID](https://support.google.com/cloud/answer/6158840) and `{location}` is
        /// a Cloud region.
        /// 
        /// Examples: `projects/my-project-123`,
        /// `projects/my-project-123/locations/global`.
        /// 
        /// For a list of supported locations, see [Supported
        /// Regions](https://cloud.google.com/logging/docs/region-support). `global` is
        /// the default when unspecified.
        /// </param>
        /// <param name="groupId">
        /// Required. The group for which events shall be returned.
        /// The `group_id` is a unique identifier for a particular error group. The
        /// identifier is derived from key parts of the error-log content and is
        /// treated as Service Data. For information about how Service Data
        /// is handled, see [Google Cloud Privacy
        /// Notice](https://cloud.google.com/terms/cloud-privacy-notice).
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
        /// <returns>A pageable asynchronous sequence of <see cref="ErrorEvent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEventsResponse, ErrorEvent> ListEventsAsync(string projectName, string groupId, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEventsRequest request = new ListEventsRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNullOrEmpty(projectName, nameof(projectName)),
                GroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(groupId, nameof(groupId)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEventsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the specified events.
        /// </summary>
        /// <param name="projectName">
        /// Required. The resource name of the Google Cloud Platform project. Written
        /// as `projects/{projectID}` or `projects/{projectID}/locations/{location}`,
        /// where `{projectID}` is the [Google Cloud Platform project
        /// ID](https://support.google.com/cloud/answer/6158840) and `{location}` is
        /// a Cloud region.
        /// 
        /// Examples: `projects/my-project-123`,
        /// `projects/my-project-123/locations/global`.
        /// 
        /// For a list of supported locations, see [Supported
        /// Regions](https://cloud.google.com/logging/docs/region-support). `global` is
        /// the default when unspecified.
        /// </param>
        /// <param name="groupId">
        /// Required. The group for which events shall be returned.
        /// The `group_id` is a unique identifier for a particular error group. The
        /// identifier is derived from key parts of the error-log content and is
        /// treated as Service Data. For information about how Service Data
        /// is handled, see [Google Cloud Privacy
        /// Notice](https://cloud.google.com/terms/cloud-privacy-notice).
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
        /// <returns>A pageable sequence of <see cref="ErrorEvent"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEventsResponse, ErrorEvent> ListEvents(gagr::ProjectName projectName, string groupId, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEventsRequest request = new ListEventsRequest
            {
                ProjectNameAsProjectName = gax::GaxPreconditions.CheckNotNull(projectName, nameof(projectName)),
                GroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(groupId, nameof(groupId)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEvents(request, callSettings);
        }

        /// <summary>
        /// Lists the specified events.
        /// </summary>
        /// <param name="projectName">
        /// Required. The resource name of the Google Cloud Platform project. Written
        /// as `projects/{projectID}` or `projects/{projectID}/locations/{location}`,
        /// where `{projectID}` is the [Google Cloud Platform project
        /// ID](https://support.google.com/cloud/answer/6158840) and `{location}` is
        /// a Cloud region.
        /// 
        /// Examples: `projects/my-project-123`,
        /// `projects/my-project-123/locations/global`.
        /// 
        /// For a list of supported locations, see [Supported
        /// Regions](https://cloud.google.com/logging/docs/region-support). `global` is
        /// the default when unspecified.
        /// </param>
        /// <param name="groupId">
        /// Required. The group for which events shall be returned.
        /// The `group_id` is a unique identifier for a particular error group. The
        /// identifier is derived from key parts of the error-log content and is
        /// treated as Service Data. For information about how Service Data
        /// is handled, see [Google Cloud Privacy
        /// Notice](https://cloud.google.com/terms/cloud-privacy-notice).
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
        /// <returns>A pageable asynchronous sequence of <see cref="ErrorEvent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEventsResponse, ErrorEvent> ListEventsAsync(gagr::ProjectName projectName, string groupId, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEventsRequest request = new ListEventsRequest
            {
                ProjectNameAsProjectName = gax::GaxPreconditions.CheckNotNull(projectName, nameof(projectName)),
                GroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(groupId, nameof(groupId)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEventsAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes all error events of a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeleteEventsResponse DeleteEvents(DeleteEventsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes all error events of a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeleteEventsResponse> DeleteEventsAsync(DeleteEventsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes all error events of a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeleteEventsResponse> DeleteEventsAsync(DeleteEventsRequest request, st::CancellationToken cancellationToken) =>
            DeleteEventsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes all error events of a given project.
        /// </summary>
        /// <param name="projectName">
        /// Required. The resource name of the Google Cloud Platform project. Written
        /// as `projects/{projectID}` or `projects/{projectID}/locations/{location}`,
        /// where `{projectID}` is the [Google Cloud Platform project
        /// ID](https://support.google.com/cloud/answer/6158840) and `{location}` is
        /// a Cloud region.
        /// 
        /// Examples: `projects/my-project-123`,
        /// `projects/my-project-123/locations/global`.
        /// 
        /// For a list of supported locations, see [Supported
        /// Regions](https://cloud.google.com/logging/docs/region-support). `global` is
        /// the default when unspecified.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeleteEventsResponse DeleteEvents(string projectName, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEvents(new DeleteEventsRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNullOrEmpty(projectName, nameof(projectName)),
            }, callSettings);

        /// <summary>
        /// Deletes all error events of a given project.
        /// </summary>
        /// <param name="projectName">
        /// Required. The resource name of the Google Cloud Platform project. Written
        /// as `projects/{projectID}` or `projects/{projectID}/locations/{location}`,
        /// where `{projectID}` is the [Google Cloud Platform project
        /// ID](https://support.google.com/cloud/answer/6158840) and `{location}` is
        /// a Cloud region.
        /// 
        /// Examples: `projects/my-project-123`,
        /// `projects/my-project-123/locations/global`.
        /// 
        /// For a list of supported locations, see [Supported
        /// Regions](https://cloud.google.com/logging/docs/region-support). `global` is
        /// the default when unspecified.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeleteEventsResponse> DeleteEventsAsync(string projectName, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEventsAsync(new DeleteEventsRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNullOrEmpty(projectName, nameof(projectName)),
            }, callSettings);

        /// <summary>
        /// Deletes all error events of a given project.
        /// </summary>
        /// <param name="projectName">
        /// Required. The resource name of the Google Cloud Platform project. Written
        /// as `projects/{projectID}` or `projects/{projectID}/locations/{location}`,
        /// where `{projectID}` is the [Google Cloud Platform project
        /// ID](https://support.google.com/cloud/answer/6158840) and `{location}` is
        /// a Cloud region.
        /// 
        /// Examples: `projects/my-project-123`,
        /// `projects/my-project-123/locations/global`.
        /// 
        /// For a list of supported locations, see [Supported
        /// Regions](https://cloud.google.com/logging/docs/region-support). `global` is
        /// the default when unspecified.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeleteEventsResponse> DeleteEventsAsync(string projectName, st::CancellationToken cancellationToken) =>
            DeleteEventsAsync(projectName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes all error events of a given project.
        /// </summary>
        /// <param name="projectName">
        /// Required. The resource name of the Google Cloud Platform project. Written
        /// as `projects/{projectID}` or `projects/{projectID}/locations/{location}`,
        /// where `{projectID}` is the [Google Cloud Platform project
        /// ID](https://support.google.com/cloud/answer/6158840) and `{location}` is
        /// a Cloud region.
        /// 
        /// Examples: `projects/my-project-123`,
        /// `projects/my-project-123/locations/global`.
        /// 
        /// For a list of supported locations, see [Supported
        /// Regions](https://cloud.google.com/logging/docs/region-support). `global` is
        /// the default when unspecified.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeleteEventsResponse DeleteEvents(gagr::ProjectName projectName, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEvents(new DeleteEventsRequest
            {
                ProjectNameAsProjectName = gax::GaxPreconditions.CheckNotNull(projectName, nameof(projectName)),
            }, callSettings);

        /// <summary>
        /// Deletes all error events of a given project.
        /// </summary>
        /// <param name="projectName">
        /// Required. The resource name of the Google Cloud Platform project. Written
        /// as `projects/{projectID}` or `projects/{projectID}/locations/{location}`,
        /// where `{projectID}` is the [Google Cloud Platform project
        /// ID](https://support.google.com/cloud/answer/6158840) and `{location}` is
        /// a Cloud region.
        /// 
        /// Examples: `projects/my-project-123`,
        /// `projects/my-project-123/locations/global`.
        /// 
        /// For a list of supported locations, see [Supported
        /// Regions](https://cloud.google.com/logging/docs/region-support). `global` is
        /// the default when unspecified.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeleteEventsResponse> DeleteEventsAsync(gagr::ProjectName projectName, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEventsAsync(new DeleteEventsRequest
            {
                ProjectNameAsProjectName = gax::GaxPreconditions.CheckNotNull(projectName, nameof(projectName)),
            }, callSettings);

        /// <summary>
        /// Deletes all error events of a given project.
        /// </summary>
        /// <param name="projectName">
        /// Required. The resource name of the Google Cloud Platform project. Written
        /// as `projects/{projectID}` or `projects/{projectID}/locations/{location}`,
        /// where `{projectID}` is the [Google Cloud Platform project
        /// ID](https://support.google.com/cloud/answer/6158840) and `{location}` is
        /// a Cloud region.
        /// 
        /// Examples: `projects/my-project-123`,
        /// `projects/my-project-123/locations/global`.
        /// 
        /// For a list of supported locations, see [Supported
        /// Regions](https://cloud.google.com/logging/docs/region-support). `global` is
        /// the default when unspecified.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeleteEventsResponse> DeleteEventsAsync(gagr::ProjectName projectName, st::CancellationToken cancellationToken) =>
            DeleteEventsAsync(projectName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ErrorStatsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// An API for retrieving and managing error statistics as well as data for
    /// individual events.
    /// </remarks>
    public sealed partial class ErrorStatsServiceClientImpl : ErrorStatsServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListGroupStatsRequest, ListGroupStatsResponse> _callListGroupStats;

        private readonly gaxgrpc::ApiCall<ListEventsRequest, ListEventsResponse> _callListEvents;

        private readonly gaxgrpc::ApiCall<DeleteEventsRequest, DeleteEventsResponse> _callDeleteEvents;

        /// <summary>
        /// Constructs a client wrapper for the ErrorStatsService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ErrorStatsServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ErrorStatsServiceClientImpl(ErrorStatsService.ErrorStatsServiceClient grpcClient, ErrorStatsServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ErrorStatsServiceSettings effectiveSettings = settings ?? ErrorStatsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callListGroupStats = clientHelper.BuildApiCall<ListGroupStatsRequest, ListGroupStatsResponse>("ListGroupStats", grpcClient.ListGroupStatsAsync, grpcClient.ListGroupStats, effectiveSettings.ListGroupStatsSettings).WithGoogleRequestParam("project_name", request => request.ProjectName);
            Modify_ApiCall(ref _callListGroupStats);
            Modify_ListGroupStatsApiCall(ref _callListGroupStats);
            _callListEvents = clientHelper.BuildApiCall<ListEventsRequest, ListEventsResponse>("ListEvents", grpcClient.ListEventsAsync, grpcClient.ListEvents, effectiveSettings.ListEventsSettings).WithGoogleRequestParam("project_name", request => request.ProjectName);
            Modify_ApiCall(ref _callListEvents);
            Modify_ListEventsApiCall(ref _callListEvents);
            _callDeleteEvents = clientHelper.BuildApiCall<DeleteEventsRequest, DeleteEventsResponse>("DeleteEvents", grpcClient.DeleteEventsAsync, grpcClient.DeleteEvents, effectiveSettings.DeleteEventsSettings).WithGoogleRequestParam("project_name", request => request.ProjectName);
            Modify_ApiCall(ref _callDeleteEvents);
            Modify_DeleteEventsApiCall(ref _callDeleteEvents);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListGroupStatsApiCall(ref gaxgrpc::ApiCall<ListGroupStatsRequest, ListGroupStatsResponse> call);

        partial void Modify_ListEventsApiCall(ref gaxgrpc::ApiCall<ListEventsRequest, ListEventsResponse> call);

        partial void Modify_DeleteEventsApiCall(ref gaxgrpc::ApiCall<DeleteEventsRequest, DeleteEventsResponse> call);

        partial void OnConstruction(ErrorStatsService.ErrorStatsServiceClient grpcClient, ErrorStatsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ErrorStatsService client</summary>
        public override ErrorStatsService.ErrorStatsServiceClient GrpcClient { get; }

        partial void Modify_ListGroupStatsRequest(ref ListGroupStatsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListEventsRequest(ref ListEventsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteEventsRequest(ref DeleteEventsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists the specified groups.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ErrorGroupStats"/> resources.</returns>
        public override gax::PagedEnumerable<ListGroupStatsResponse, ErrorGroupStats> ListGroupStats(ListGroupStatsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGroupStatsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListGroupStatsRequest, ListGroupStatsResponse, ErrorGroupStats>(_callListGroupStats, request, callSettings);
        }

        /// <summary>
        /// Lists the specified groups.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ErrorGroupStats"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListGroupStatsResponse, ErrorGroupStats> ListGroupStatsAsync(ListGroupStatsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGroupStatsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListGroupStatsRequest, ListGroupStatsResponse, ErrorGroupStats>(_callListGroupStats, request, callSettings);
        }

        /// <summary>
        /// Lists the specified events.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ErrorEvent"/> resources.</returns>
        public override gax::PagedEnumerable<ListEventsResponse, ErrorEvent> ListEvents(ListEventsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEventsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEventsRequest, ListEventsResponse, ErrorEvent>(_callListEvents, request, callSettings);
        }

        /// <summary>
        /// Lists the specified events.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ErrorEvent"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListEventsResponse, ErrorEvent> ListEventsAsync(ListEventsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEventsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEventsRequest, ListEventsResponse, ErrorEvent>(_callListEvents, request, callSettings);
        }

        /// <summary>
        /// Deletes all error events of a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DeleteEventsResponse DeleteEvents(DeleteEventsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEventsRequest(ref request, ref callSettings);
            return _callDeleteEvents.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes all error events of a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DeleteEventsResponse> DeleteEventsAsync(DeleteEventsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEventsRequest(ref request, ref callSettings);
            return _callDeleteEvents.Async(request, callSettings);
        }
    }

    public partial class ListGroupStatsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEventsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListGroupStatsResponse : gaxgrpc::IPageResponse<ErrorGroupStats>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ErrorGroupStats> GetEnumerator() => ErrorGroupStats.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListEventsResponse : gaxgrpc::IPageResponse<ErrorEvent>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ErrorEvent> GetEnumerator() => ErrorEvents.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
