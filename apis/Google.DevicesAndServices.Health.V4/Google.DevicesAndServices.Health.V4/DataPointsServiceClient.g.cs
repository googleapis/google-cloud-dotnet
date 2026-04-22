// Copyright 2026 Google LLC
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
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using lro = Google.LongRunning;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.DevicesAndServices.Health.V4
{
    /// <summary>Settings for <see cref="DataPointsServiceClient"/> instances.</summary>
    public sealed partial class DataPointsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DataPointsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DataPointsServiceSettings"/>.</returns>
        public static DataPointsServiceSettings GetDefault() => new DataPointsServiceSettings();

        /// <summary>Constructs a new <see cref="DataPointsServiceSettings"/> object with default settings.</summary>
        public DataPointsServiceSettings()
        {
        }

        private DataPointsServiceSettings(DataPointsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListDataPointsSettings = existing.ListDataPointsSettings;
            CreateDataPointSettings = existing.CreateDataPointSettings;
            CreateDataPointOperationsSettings = existing.CreateDataPointOperationsSettings.Clone();
            UpdateDataPointSettings = existing.UpdateDataPointSettings;
            UpdateDataPointOperationsSettings = existing.UpdateDataPointOperationsSettings.Clone();
            BatchDeleteDataPointsSettings = existing.BatchDeleteDataPointsSettings;
            BatchDeleteDataPointsOperationsSettings = existing.BatchDeleteDataPointsOperationsSettings.Clone();
            ReconcileDataPointsSettings = existing.ReconcileDataPointsSettings;
            RollUpDataPointsSettings = existing.RollUpDataPointsSettings;
            DailyRollUpDataPointsSettings = existing.DailyRollUpDataPointsSettings;
            ExportExerciseTcxSettings = existing.ExportExerciseTcxSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DataPointsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataPointsServiceClient.ListDataPoints</c> and <c>DataPointsServiceClient.ListDataPointsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDataPointsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataPointsServiceClient.CreateDataPoint</c> and <c>DataPointsServiceClient.CreateDataPointAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateDataPointSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataPointsServiceClient.CreateDataPoint</c> and
        /// <c>DataPointsServiceClient.CreateDataPointAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings CreateDataPointOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataPointsServiceClient.UpdateDataPoint</c> and <c>DataPointsServiceClient.UpdateDataPointAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDataPointSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataPointsServiceClient.UpdateDataPoint</c> and
        /// <c>DataPointsServiceClient.UpdateDataPointAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings UpdateDataPointOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataPointsServiceClient.BatchDeleteDataPoints</c> and
        /// <c>DataPointsServiceClient.BatchDeleteDataPointsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchDeleteDataPointsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataPointsServiceClient.BatchDeleteDataPoints</c> and
        /// <c>DataPointsServiceClient.BatchDeleteDataPointsAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings BatchDeleteDataPointsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataPointsServiceClient.ReconcileDataPoints</c> and <c>DataPointsServiceClient.ReconcileDataPointsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReconcileDataPointsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataPointsServiceClient.RollUpDataPoints</c> and <c>DataPointsServiceClient.RollUpDataPointsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RollUpDataPointsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataPointsServiceClient.DailyRollUpDataPoints</c> and
        /// <c>DataPointsServiceClient.DailyRollUpDataPointsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DailyRollUpDataPointsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataPointsServiceClient.ExportExerciseTcx</c> and <c>DataPointsServiceClient.ExportExerciseTcxAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExportExerciseTcxSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DataPointsServiceSettings"/> object.</returns>
        public DataPointsServiceSettings Clone() => new DataPointsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DataPointsServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class DataPointsServiceClientBuilder : gaxgrpc::ClientBuilderBase<DataPointsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DataPointsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DataPointsServiceClientBuilder() : base(DataPointsServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DataPointsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DataPointsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DataPointsServiceClient Build()
        {
            DataPointsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DataPointsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DataPointsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DataPointsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DataPointsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DataPointsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DataPointsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DataPointsServiceClient.ChannelPool;
    }

    /// <summary>DataPointsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Data Points Service exposing the user's health and fitness measured and
    /// derived data.
    /// </remarks>
    public abstract partial class DataPointsServiceClient
    {
        /// <summary>
        /// The default endpoint for the DataPointsService service, which is a host of "health.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "health.googleapis.com:443";

        /// <summary>The default DataPointsService scopes.</summary>
        /// <remarks>The default DataPointsService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(DataPointsService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DataPointsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DataPointsServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DataPointsServiceClient"/>.</returns>
        public static stt::Task<DataPointsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DataPointsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DataPointsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DataPointsServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DataPointsServiceClient"/>.</returns>
        public static DataPointsServiceClient Create() => new DataPointsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DataPointsServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DataPointsServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DataPointsServiceClient"/>.</returns>
        internal static DataPointsServiceClient Create(grpccore::CallInvoker callInvoker, DataPointsServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DataPointsService.DataPointsServiceClient grpcClient = new DataPointsService.DataPointsServiceClient(callInvoker);
            return new DataPointsServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC DataPointsService client</summary>
        public virtual DataPointsService.DataPointsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Query user health and fitness data points.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataPoint"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataPointsResponse, DataPoint> ListDataPoints(ListDataPointsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Query user health and fitness data points.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataPoint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataPointsResponse, DataPoint> ListDataPointsAsync(ListDataPointsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Query user health and fitness data points.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent data type of the Data Point collection.
        /// 
        /// Format: `users/me/dataTypes/{data_type}`, e.g.:
        /// 
        /// - `users/me/dataTypes/steps`
        /// - `users/me/dataTypes/weight`
        /// 
        /// For a list of the supported data types see the [DataPoint
        /// data][google.devicesandservices.health.v4.DataPoint] union
        /// field.
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
        /// <returns>A pageable sequence of <see cref="DataPoint"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataPointsResponse, DataPoint> ListDataPoints(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataPointsRequest request = new ListDataPointsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDataPoints(request, callSettings);
        }

        /// <summary>
        /// Query user health and fitness data points.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent data type of the Data Point collection.
        /// 
        /// Format: `users/me/dataTypes/{data_type}`, e.g.:
        /// 
        /// - `users/me/dataTypes/steps`
        /// - `users/me/dataTypes/weight`
        /// 
        /// For a list of the supported data types see the [DataPoint
        /// data][google.devicesandservices.health.v4.DataPoint] union
        /// field.
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataPoint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataPointsResponse, DataPoint> ListDataPointsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataPointsRequest request = new ListDataPointsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDataPointsAsync(request, callSettings);
        }

        /// <summary>
        /// Query user health and fitness data points.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent data type of the Data Point collection.
        /// 
        /// Format: `users/me/dataTypes/{data_type}`, e.g.:
        /// 
        /// - `users/me/dataTypes/steps`
        /// - `users/me/dataTypes/weight`
        /// 
        /// For a list of the supported data types see the [DataPoint
        /// data][google.devicesandservices.health.v4.DataPoint] union
        /// field.
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
        /// <returns>A pageable sequence of <see cref="DataPoint"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataPointsResponse, DataPoint> ListDataPoints(DataTypeName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataPointsRequest request = new ListDataPointsRequest
            {
                ParentAsDataTypeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDataPoints(request, callSettings);
        }

        /// <summary>
        /// Query user health and fitness data points.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent data type of the Data Point collection.
        /// 
        /// Format: `users/me/dataTypes/{data_type}`, e.g.:
        /// 
        /// - `users/me/dataTypes/steps`
        /// - `users/me/dataTypes/weight`
        /// 
        /// For a list of the supported data types see the [DataPoint
        /// data][google.devicesandservices.health.v4.DataPoint] union
        /// field.
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataPoint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataPointsResponse, DataPoint> ListDataPointsAsync(DataTypeName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataPointsRequest request = new ListDataPointsRequest
            {
                ParentAsDataTypeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDataPointsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a single identifiable data point.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DataPoint, CreateDataPointOperationMetadata> CreateDataPoint(CreateDataPointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a single identifiable data point.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataPoint, CreateDataPointOperationMetadata>> CreateDataPointAsync(CreateDataPointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a single identifiable data point.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataPoint, CreateDataPointOperationMetadata>> CreateDataPointAsync(CreateDataPointRequest request, st::CancellationToken cancellationToken) =>
            CreateDataPointAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateDataPoint</c>.</summary>
        public virtual lro::OperationsClient CreateDataPointOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateDataPoint</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DataPoint, CreateDataPointOperationMetadata> PollOnceCreateDataPoint(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DataPoint, CreateDataPointOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateDataPointOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateDataPoint</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DataPoint, CreateDataPointOperationMetadata>> PollOnceCreateDataPointAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DataPoint, CreateDataPointOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateDataPointOperationsClient, callSettings);

        /// <summary>
        /// Creates a single identifiable data point.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name where the data point will be created.
        /// Format: `users/{user}/dataTypes/{data_type}`
        /// </param>
        /// <param name="dataPoint">
        /// Required. The data point to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DataPoint, CreateDataPointOperationMetadata> CreateDataPoint(string parent, DataPoint dataPoint, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataPoint(new CreateDataPointRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DataPoint = gax::GaxPreconditions.CheckNotNull(dataPoint, nameof(dataPoint)),
            }, callSettings);

        /// <summary>
        /// Creates a single identifiable data point.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name where the data point will be created.
        /// Format: `users/{user}/dataTypes/{data_type}`
        /// </param>
        /// <param name="dataPoint">
        /// Required. The data point to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataPoint, CreateDataPointOperationMetadata>> CreateDataPointAsync(string parent, DataPoint dataPoint, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataPointAsync(new CreateDataPointRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DataPoint = gax::GaxPreconditions.CheckNotNull(dataPoint, nameof(dataPoint)),
            }, callSettings);

        /// <summary>
        /// Creates a single identifiable data point.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name where the data point will be created.
        /// Format: `users/{user}/dataTypes/{data_type}`
        /// </param>
        /// <param name="dataPoint">
        /// Required. The data point to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataPoint, CreateDataPointOperationMetadata>> CreateDataPointAsync(string parent, DataPoint dataPoint, st::CancellationToken cancellationToken) =>
            CreateDataPointAsync(parent, dataPoint, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a single identifiable data point.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name where the data point will be created.
        /// Format: `users/{user}/dataTypes/{data_type}`
        /// </param>
        /// <param name="dataPoint">
        /// Required. The data point to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DataPoint, CreateDataPointOperationMetadata> CreateDataPoint(DataTypeName parent, DataPoint dataPoint, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataPoint(new CreateDataPointRequest
            {
                ParentAsDataTypeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DataPoint = gax::GaxPreconditions.CheckNotNull(dataPoint, nameof(dataPoint)),
            }, callSettings);

        /// <summary>
        /// Creates a single identifiable data point.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name where the data point will be created.
        /// Format: `users/{user}/dataTypes/{data_type}`
        /// </param>
        /// <param name="dataPoint">
        /// Required. The data point to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataPoint, CreateDataPointOperationMetadata>> CreateDataPointAsync(DataTypeName parent, DataPoint dataPoint, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataPointAsync(new CreateDataPointRequest
            {
                ParentAsDataTypeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DataPoint = gax::GaxPreconditions.CheckNotNull(dataPoint, nameof(dataPoint)),
            }, callSettings);

        /// <summary>
        /// Creates a single identifiable data point.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name where the data point will be created.
        /// Format: `users/{user}/dataTypes/{data_type}`
        /// </param>
        /// <param name="dataPoint">
        /// Required. The data point to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataPoint, CreateDataPointOperationMetadata>> CreateDataPointAsync(DataTypeName parent, DataPoint dataPoint, st::CancellationToken cancellationToken) =>
            CreateDataPointAsync(parent, dataPoint, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a single identifiable data point. If a data point with the
        /// specified `name` is not found, the request will fail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DataPoint, UpdateDataPointOperationMetadata> UpdateDataPoint(UpdateDataPointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a single identifiable data point. If a data point with the
        /// specified `name` is not found, the request will fail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataPoint, UpdateDataPointOperationMetadata>> UpdateDataPointAsync(UpdateDataPointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a single identifiable data point. If a data point with the
        /// specified `name` is not found, the request will fail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataPoint, UpdateDataPointOperationMetadata>> UpdateDataPointAsync(UpdateDataPointRequest request, st::CancellationToken cancellationToken) =>
            UpdateDataPointAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateDataPoint</c>.</summary>
        public virtual lro::OperationsClient UpdateDataPointOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateDataPoint</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DataPoint, UpdateDataPointOperationMetadata> PollOnceUpdateDataPoint(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DataPoint, UpdateDataPointOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateDataPointOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateDataPoint</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DataPoint, UpdateDataPointOperationMetadata>> PollOnceUpdateDataPointAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DataPoint, UpdateDataPointOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateDataPointOperationsClient, callSettings);

        /// <summary>
        /// Updates a single identifiable data point. If a data point with the
        /// specified `name` is not found, the request will fail.
        /// </summary>
        /// <param name="dataPoint">
        /// Required. The data point to update
        /// 
        /// The data point's `name` field is used to identify the data point to update.
        /// 
        /// Format: `users/{user}/dataTypes/{data_type}/dataPoints/{data_point}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DataPoint, UpdateDataPointOperationMetadata> UpdateDataPoint(DataPoint dataPoint, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataPoint(new UpdateDataPointRequest
            {
                DataPoint = gax::GaxPreconditions.CheckNotNull(dataPoint, nameof(dataPoint)),
            }, callSettings);

        /// <summary>
        /// Updates a single identifiable data point. If a data point with the
        /// specified `name` is not found, the request will fail.
        /// </summary>
        /// <param name="dataPoint">
        /// Required. The data point to update
        /// 
        /// The data point's `name` field is used to identify the data point to update.
        /// 
        /// Format: `users/{user}/dataTypes/{data_type}/dataPoints/{data_point}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataPoint, UpdateDataPointOperationMetadata>> UpdateDataPointAsync(DataPoint dataPoint, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataPointAsync(new UpdateDataPointRequest
            {
                DataPoint = gax::GaxPreconditions.CheckNotNull(dataPoint, nameof(dataPoint)),
            }, callSettings);

        /// <summary>
        /// Updates a single identifiable data point. If a data point with the
        /// specified `name` is not found, the request will fail.
        /// </summary>
        /// <param name="dataPoint">
        /// Required. The data point to update
        /// 
        /// The data point's `name` field is used to identify the data point to update.
        /// 
        /// Format: `users/{user}/dataTypes/{data_type}/dataPoints/{data_point}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataPoint, UpdateDataPointOperationMetadata>> UpdateDataPointAsync(DataPoint dataPoint, st::CancellationToken cancellationToken) =>
            UpdateDataPointAsync(dataPoint, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a batch of identifyable data points.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchDeleteDataPointsResponse, BatchDeleteDataPointsOperationMetadata> BatchDeleteDataPoints(BatchDeleteDataPointsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a batch of identifyable data points.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchDeleteDataPointsResponse, BatchDeleteDataPointsOperationMetadata>> BatchDeleteDataPointsAsync(BatchDeleteDataPointsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a batch of identifyable data points.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchDeleteDataPointsResponse, BatchDeleteDataPointsOperationMetadata>> BatchDeleteDataPointsAsync(BatchDeleteDataPointsRequest request, st::CancellationToken cancellationToken) =>
            BatchDeleteDataPointsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>BatchDeleteDataPoints</c>.</summary>
        public virtual lro::OperationsClient BatchDeleteDataPointsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>BatchDeleteDataPoints</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<BatchDeleteDataPointsResponse, BatchDeleteDataPointsOperationMetadata> PollOnceBatchDeleteDataPoints(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchDeleteDataPointsResponse, BatchDeleteDataPointsOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchDeleteDataPointsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BatchDeleteDataPoints</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<BatchDeleteDataPointsResponse, BatchDeleteDataPointsOperationMetadata>> PollOnceBatchDeleteDataPointsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchDeleteDataPointsResponse, BatchDeleteDataPointsOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchDeleteDataPointsOperationsClient, callSettings);

        /// <summary>
        /// Reconcile data points from multiple data sources into a single data stream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ReconciledDataPoint"/> resources.</returns>
        public virtual gax::PagedEnumerable<ReconcileDataPointsResponse, ReconciledDataPoint> ReconcileDataPoints(ReconcileDataPointsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reconcile data points from multiple data sources into a single data stream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ReconciledDataPoint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ReconcileDataPointsResponse, ReconciledDataPoint> ReconcileDataPointsAsync(ReconcileDataPointsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Roll up data points over physical time intervals for supported data types.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RollupDataPoint"/> resources.</returns>
        public virtual gax::PagedEnumerable<RollUpDataPointsResponse, RollupDataPoint> RollUpDataPoints(RollUpDataPointsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Roll up data points over physical time intervals for supported data types.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RollupDataPoint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<RollUpDataPointsResponse, RollupDataPoint> RollUpDataPointsAsync(RollUpDataPointsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Roll up data points over civil time intervals for supported data types.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DailyRollUpDataPointsResponse DailyRollUpDataPoints(DailyRollUpDataPointsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Roll up data points over civil time intervals for supported data types.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DailyRollUpDataPointsResponse> DailyRollUpDataPointsAsync(DailyRollUpDataPointsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Roll up data points over civil time intervals for supported data types.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DailyRollUpDataPointsResponse> DailyRollUpDataPointsAsync(DailyRollUpDataPointsRequest request, st::CancellationToken cancellationToken) =>
            DailyRollUpDataPointsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports exercise data in TCX format.
        /// 
        /// 
        /// Note: While the Authorization section below states that any one of the
        /// listed scopes is accepted, this specific method requires the user to
        /// provide both one of the `activity_and_fitness` scopes (`normal` or
        /// `readonly`) AND one of the `location` scopes (`normal` or `readonly`) in
        /// their access token to succeed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ExportExerciseTcxResponse ExportExerciseTcx(ExportExerciseTcxRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports exercise data in TCX format.
        /// 
        /// 
        /// Note: While the Authorization section below states that any one of the
        /// listed scopes is accepted, this specific method requires the user to
        /// provide both one of the `activity_and_fitness` scopes (`normal` or
        /// `readonly`) AND one of the `location` scopes (`normal` or `readonly`) in
        /// their access token to succeed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExportExerciseTcxResponse> ExportExerciseTcxAsync(ExportExerciseTcxRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports exercise data in TCX format.
        /// 
        /// 
        /// Note: While the Authorization section below states that any one of the
        /// listed scopes is accepted, this specific method requires the user to
        /// provide both one of the `activity_and_fitness` scopes (`normal` or
        /// `readonly`) AND one of the `location` scopes (`normal` or `readonly`) in
        /// their access token to succeed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExportExerciseTcxResponse> ExportExerciseTcxAsync(ExportExerciseTcxRequest request, st::CancellationToken cancellationToken) =>
            ExportExerciseTcxAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports exercise data in TCX format.
        /// 
        /// 
        /// Note: While the Authorization section below states that any one of the
        /// listed scopes is accepted, this specific method requires the user to
        /// provide both one of the `activity_and_fitness` scopes (`normal` or
        /// `readonly`) AND one of the `location` scopes (`normal` or `readonly`) in
        /// their access token to succeed.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the exercise data point to export.
        /// 
        /// Format: `users/{user}/dataTypes/exercise/dataPoints/{data_point}`
        /// Example: `users/me/dataTypes/exercise/dataPoints/2026443605080188808`
        /// 
        /// The `{user}` is the alias `"me"` currently. Future versions may support
        /// user IDs.
        /// The `{data_point}` ID maps to the exercise ID, which is a long integer.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ExportExerciseTcxResponse ExportExerciseTcx(string name, gaxgrpc::CallSettings callSettings = null) =>
            ExportExerciseTcx(new ExportExerciseTcxRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Exports exercise data in TCX format.
        /// 
        /// 
        /// Note: While the Authorization section below states that any one of the
        /// listed scopes is accepted, this specific method requires the user to
        /// provide both one of the `activity_and_fitness` scopes (`normal` or
        /// `readonly`) AND one of the `location` scopes (`normal` or `readonly`) in
        /// their access token to succeed.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the exercise data point to export.
        /// 
        /// Format: `users/{user}/dataTypes/exercise/dataPoints/{data_point}`
        /// Example: `users/me/dataTypes/exercise/dataPoints/2026443605080188808`
        /// 
        /// The `{user}` is the alias `"me"` currently. Future versions may support
        /// user IDs.
        /// The `{data_point}` ID maps to the exercise ID, which is a long integer.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExportExerciseTcxResponse> ExportExerciseTcxAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ExportExerciseTcxAsync(new ExportExerciseTcxRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Exports exercise data in TCX format.
        /// 
        /// 
        /// Note: While the Authorization section below states that any one of the
        /// listed scopes is accepted, this specific method requires the user to
        /// provide both one of the `activity_and_fitness` scopes (`normal` or
        /// `readonly`) AND one of the `location` scopes (`normal` or `readonly`) in
        /// their access token to succeed.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the exercise data point to export.
        /// 
        /// Format: `users/{user}/dataTypes/exercise/dataPoints/{data_point}`
        /// Example: `users/me/dataTypes/exercise/dataPoints/2026443605080188808`
        /// 
        /// The `{user}` is the alias `"me"` currently. Future versions may support
        /// user IDs.
        /// The `{data_point}` ID maps to the exercise ID, which is a long integer.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExportExerciseTcxResponse> ExportExerciseTcxAsync(string name, st::CancellationToken cancellationToken) =>
            ExportExerciseTcxAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports exercise data in TCX format.
        /// 
        /// 
        /// Note: While the Authorization section below states that any one of the
        /// listed scopes is accepted, this specific method requires the user to
        /// provide both one of the `activity_and_fitness` scopes (`normal` or
        /// `readonly`) AND one of the `location` scopes (`normal` or `readonly`) in
        /// their access token to succeed.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the exercise data point to export.
        /// 
        /// Format: `users/{user}/dataTypes/exercise/dataPoints/{data_point}`
        /// Example: `users/me/dataTypes/exercise/dataPoints/2026443605080188808`
        /// 
        /// The `{user}` is the alias `"me"` currently. Future versions may support
        /// user IDs.
        /// The `{data_point}` ID maps to the exercise ID, which is a long integer.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ExportExerciseTcxResponse ExportExerciseTcx(DataPointName name, gaxgrpc::CallSettings callSettings = null) =>
            ExportExerciseTcx(new ExportExerciseTcxRequest
            {
                DataPointName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Exports exercise data in TCX format.
        /// 
        /// 
        /// Note: While the Authorization section below states that any one of the
        /// listed scopes is accepted, this specific method requires the user to
        /// provide both one of the `activity_and_fitness` scopes (`normal` or
        /// `readonly`) AND one of the `location` scopes (`normal` or `readonly`) in
        /// their access token to succeed.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the exercise data point to export.
        /// 
        /// Format: `users/{user}/dataTypes/exercise/dataPoints/{data_point}`
        /// Example: `users/me/dataTypes/exercise/dataPoints/2026443605080188808`
        /// 
        /// The `{user}` is the alias `"me"` currently. Future versions may support
        /// user IDs.
        /// The `{data_point}` ID maps to the exercise ID, which is a long integer.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExportExerciseTcxResponse> ExportExerciseTcxAsync(DataPointName name, gaxgrpc::CallSettings callSettings = null) =>
            ExportExerciseTcxAsync(new ExportExerciseTcxRequest
            {
                DataPointName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Exports exercise data in TCX format.
        /// 
        /// 
        /// Note: While the Authorization section below states that any one of the
        /// listed scopes is accepted, this specific method requires the user to
        /// provide both one of the `activity_and_fitness` scopes (`normal` or
        /// `readonly`) AND one of the `location` scopes (`normal` or `readonly`) in
        /// their access token to succeed.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the exercise data point to export.
        /// 
        /// Format: `users/{user}/dataTypes/exercise/dataPoints/{data_point}`
        /// Example: `users/me/dataTypes/exercise/dataPoints/2026443605080188808`
        /// 
        /// The `{user}` is the alias `"me"` currently. Future versions may support
        /// user IDs.
        /// The `{data_point}` ID maps to the exercise ID, which is a long integer.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExportExerciseTcxResponse> ExportExerciseTcxAsync(DataPointName name, st::CancellationToken cancellationToken) =>
            ExportExerciseTcxAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>DataPointsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Data Points Service exposing the user's health and fitness measured and
    /// derived data.
    /// </remarks>
    public sealed partial class DataPointsServiceClientImpl : DataPointsServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListDataPointsRequest, ListDataPointsResponse> _callListDataPoints;

        private readonly gaxgrpc::ApiCall<CreateDataPointRequest, lro::Operation> _callCreateDataPoint;

        private readonly gaxgrpc::ApiCall<UpdateDataPointRequest, lro::Operation> _callUpdateDataPoint;

        private readonly gaxgrpc::ApiCall<BatchDeleteDataPointsRequest, lro::Operation> _callBatchDeleteDataPoints;

        private readonly gaxgrpc::ApiCall<ReconcileDataPointsRequest, ReconcileDataPointsResponse> _callReconcileDataPoints;

        private readonly gaxgrpc::ApiCall<RollUpDataPointsRequest, RollUpDataPointsResponse> _callRollUpDataPoints;

        private readonly gaxgrpc::ApiCall<DailyRollUpDataPointsRequest, DailyRollUpDataPointsResponse> _callDailyRollUpDataPoints;

        private readonly gaxgrpc::ApiCall<ExportExerciseTcxRequest, ExportExerciseTcxResponse> _callExportExerciseTcx;

        /// <summary>
        /// Constructs a client wrapper for the DataPointsService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DataPointsServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DataPointsServiceClientImpl(DataPointsService.DataPointsServiceClient grpcClient, DataPointsServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DataPointsServiceSettings effectiveSettings = settings ?? DataPointsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateDataPointOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateDataPointOperationsSettings, logger);
            UpdateDataPointOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateDataPointOperationsSettings, logger);
            BatchDeleteDataPointsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.BatchDeleteDataPointsOperationsSettings, logger);
            _callListDataPoints = clientHelper.BuildApiCall<ListDataPointsRequest, ListDataPointsResponse>("ListDataPoints", grpcClient.ListDataPointsAsync, grpcClient.ListDataPoints, effectiveSettings.ListDataPointsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDataPoints);
            Modify_ListDataPointsApiCall(ref _callListDataPoints);
            _callCreateDataPoint = clientHelper.BuildApiCall<CreateDataPointRequest, lro::Operation>("CreateDataPoint", grpcClient.CreateDataPointAsync, grpcClient.CreateDataPoint, effectiveSettings.CreateDataPointSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDataPoint);
            Modify_CreateDataPointApiCall(ref _callCreateDataPoint);
            _callUpdateDataPoint = clientHelper.BuildApiCall<UpdateDataPointRequest, lro::Operation>("UpdateDataPoint", grpcClient.UpdateDataPointAsync, grpcClient.UpdateDataPoint, effectiveSettings.UpdateDataPointSettings).WithGoogleRequestParam("data_point.name", request => request.DataPoint?.Name);
            Modify_ApiCall(ref _callUpdateDataPoint);
            Modify_UpdateDataPointApiCall(ref _callUpdateDataPoint);
            _callBatchDeleteDataPoints = clientHelper.BuildApiCall<BatchDeleteDataPointsRequest, lro::Operation>("BatchDeleteDataPoints", grpcClient.BatchDeleteDataPointsAsync, grpcClient.BatchDeleteDataPoints, effectiveSettings.BatchDeleteDataPointsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchDeleteDataPoints);
            Modify_BatchDeleteDataPointsApiCall(ref _callBatchDeleteDataPoints);
            _callReconcileDataPoints = clientHelper.BuildApiCall<ReconcileDataPointsRequest, ReconcileDataPointsResponse>("ReconcileDataPoints", grpcClient.ReconcileDataPointsAsync, grpcClient.ReconcileDataPoints, effectiveSettings.ReconcileDataPointsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callReconcileDataPoints);
            Modify_ReconcileDataPointsApiCall(ref _callReconcileDataPoints);
            _callRollUpDataPoints = clientHelper.BuildApiCall<RollUpDataPointsRequest, RollUpDataPointsResponse>("RollUpDataPoints", grpcClient.RollUpDataPointsAsync, grpcClient.RollUpDataPoints, effectiveSettings.RollUpDataPointsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callRollUpDataPoints);
            Modify_RollUpDataPointsApiCall(ref _callRollUpDataPoints);
            _callDailyRollUpDataPoints = clientHelper.BuildApiCall<DailyRollUpDataPointsRequest, DailyRollUpDataPointsResponse>("DailyRollUpDataPoints", grpcClient.DailyRollUpDataPointsAsync, grpcClient.DailyRollUpDataPoints, effectiveSettings.DailyRollUpDataPointsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callDailyRollUpDataPoints);
            Modify_DailyRollUpDataPointsApiCall(ref _callDailyRollUpDataPoints);
            _callExportExerciseTcx = clientHelper.BuildApiCall<ExportExerciseTcxRequest, ExportExerciseTcxResponse>("ExportExerciseTcx", grpcClient.ExportExerciseTcxAsync, grpcClient.ExportExerciseTcx, effectiveSettings.ExportExerciseTcxSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callExportExerciseTcx);
            Modify_ExportExerciseTcxApiCall(ref _callExportExerciseTcx);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListDataPointsApiCall(ref gaxgrpc::ApiCall<ListDataPointsRequest, ListDataPointsResponse> call);

        partial void Modify_CreateDataPointApiCall(ref gaxgrpc::ApiCall<CreateDataPointRequest, lro::Operation> call);

        partial void Modify_UpdateDataPointApiCall(ref gaxgrpc::ApiCall<UpdateDataPointRequest, lro::Operation> call);

        partial void Modify_BatchDeleteDataPointsApiCall(ref gaxgrpc::ApiCall<BatchDeleteDataPointsRequest, lro::Operation> call);

        partial void Modify_ReconcileDataPointsApiCall(ref gaxgrpc::ApiCall<ReconcileDataPointsRequest, ReconcileDataPointsResponse> call);

        partial void Modify_RollUpDataPointsApiCall(ref gaxgrpc::ApiCall<RollUpDataPointsRequest, RollUpDataPointsResponse> call);

        partial void Modify_DailyRollUpDataPointsApiCall(ref gaxgrpc::ApiCall<DailyRollUpDataPointsRequest, DailyRollUpDataPointsResponse> call);

        partial void Modify_ExportExerciseTcxApiCall(ref gaxgrpc::ApiCall<ExportExerciseTcxRequest, ExportExerciseTcxResponse> call);

        partial void OnConstruction(DataPointsService.DataPointsServiceClient grpcClient, DataPointsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DataPointsService client</summary>
        public override DataPointsService.DataPointsServiceClient GrpcClient { get; }

        partial void Modify_ListDataPointsRequest(ref ListDataPointsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateDataPointRequest(ref CreateDataPointRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDataPointRequest(ref UpdateDataPointRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchDeleteDataPointsRequest(ref BatchDeleteDataPointsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ReconcileDataPointsRequest(ref ReconcileDataPointsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RollUpDataPointsRequest(ref RollUpDataPointsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DailyRollUpDataPointsRequest(ref DailyRollUpDataPointsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExportExerciseTcxRequest(ref ExportExerciseTcxRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Query user health and fitness data points.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataPoint"/> resources.</returns>
        public override gax::PagedEnumerable<ListDataPointsResponse, DataPoint> ListDataPoints(ListDataPointsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataPointsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDataPointsRequest, ListDataPointsResponse, DataPoint>(_callListDataPoints, request, callSettings);
        }

        /// <summary>
        /// Query user health and fitness data points.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataPoint"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDataPointsResponse, DataPoint> ListDataPointsAsync(ListDataPointsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataPointsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDataPointsRequest, ListDataPointsResponse, DataPoint>(_callListDataPoints, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateDataPoint</c>.</summary>
        public override lro::OperationsClient CreateDataPointOperationsClient { get; }

        /// <summary>
        /// Creates a single identifiable data point.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DataPoint, CreateDataPointOperationMetadata> CreateDataPoint(CreateDataPointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDataPointRequest(ref request, ref callSettings);
            return new lro::Operation<DataPoint, CreateDataPointOperationMetadata>(_callCreateDataPoint.Sync(request, callSettings), CreateDataPointOperationsClient);
        }

        /// <summary>
        /// Creates a single identifiable data point.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DataPoint, CreateDataPointOperationMetadata>> CreateDataPointAsync(CreateDataPointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDataPointRequest(ref request, ref callSettings);
            return new lro::Operation<DataPoint, CreateDataPointOperationMetadata>(await _callCreateDataPoint.Async(request, callSettings).ConfigureAwait(false), CreateDataPointOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateDataPoint</c>.</summary>
        public override lro::OperationsClient UpdateDataPointOperationsClient { get; }

        /// <summary>
        /// Updates a single identifiable data point. If a data point with the
        /// specified `name` is not found, the request will fail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DataPoint, UpdateDataPointOperationMetadata> UpdateDataPoint(UpdateDataPointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDataPointRequest(ref request, ref callSettings);
            return new lro::Operation<DataPoint, UpdateDataPointOperationMetadata>(_callUpdateDataPoint.Sync(request, callSettings), UpdateDataPointOperationsClient);
        }

        /// <summary>
        /// Updates a single identifiable data point. If a data point with the
        /// specified `name` is not found, the request will fail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DataPoint, UpdateDataPointOperationMetadata>> UpdateDataPointAsync(UpdateDataPointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDataPointRequest(ref request, ref callSettings);
            return new lro::Operation<DataPoint, UpdateDataPointOperationMetadata>(await _callUpdateDataPoint.Async(request, callSettings).ConfigureAwait(false), UpdateDataPointOperationsClient);
        }

        /// <summary>The long-running operations client for <c>BatchDeleteDataPoints</c>.</summary>
        public override lro::OperationsClient BatchDeleteDataPointsOperationsClient { get; }

        /// <summary>
        /// Delete a batch of identifyable data points.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<BatchDeleteDataPointsResponse, BatchDeleteDataPointsOperationMetadata> BatchDeleteDataPoints(BatchDeleteDataPointsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeleteDataPointsRequest(ref request, ref callSettings);
            return new lro::Operation<BatchDeleteDataPointsResponse, BatchDeleteDataPointsOperationMetadata>(_callBatchDeleteDataPoints.Sync(request, callSettings), BatchDeleteDataPointsOperationsClient);
        }

        /// <summary>
        /// Delete a batch of identifyable data points.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<BatchDeleteDataPointsResponse, BatchDeleteDataPointsOperationMetadata>> BatchDeleteDataPointsAsync(BatchDeleteDataPointsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeleteDataPointsRequest(ref request, ref callSettings);
            return new lro::Operation<BatchDeleteDataPointsResponse, BatchDeleteDataPointsOperationMetadata>(await _callBatchDeleteDataPoints.Async(request, callSettings).ConfigureAwait(false), BatchDeleteDataPointsOperationsClient);
        }

        /// <summary>
        /// Reconcile data points from multiple data sources into a single data stream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ReconciledDataPoint"/> resources.</returns>
        public override gax::PagedEnumerable<ReconcileDataPointsResponse, ReconciledDataPoint> ReconcileDataPoints(ReconcileDataPointsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReconcileDataPointsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ReconcileDataPointsRequest, ReconcileDataPointsResponse, ReconciledDataPoint>(_callReconcileDataPoints, request, callSettings);
        }

        /// <summary>
        /// Reconcile data points from multiple data sources into a single data stream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ReconciledDataPoint"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ReconcileDataPointsResponse, ReconciledDataPoint> ReconcileDataPointsAsync(ReconcileDataPointsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReconcileDataPointsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ReconcileDataPointsRequest, ReconcileDataPointsResponse, ReconciledDataPoint>(_callReconcileDataPoints, request, callSettings);
        }

        /// <summary>
        /// Roll up data points over physical time intervals for supported data types.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RollupDataPoint"/> resources.</returns>
        public override gax::PagedEnumerable<RollUpDataPointsResponse, RollupDataPoint> RollUpDataPoints(RollUpDataPointsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RollUpDataPointsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<RollUpDataPointsRequest, RollUpDataPointsResponse, RollupDataPoint>(_callRollUpDataPoints, request, callSettings);
        }

        /// <summary>
        /// Roll up data points over physical time intervals for supported data types.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RollupDataPoint"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<RollUpDataPointsResponse, RollupDataPoint> RollUpDataPointsAsync(RollUpDataPointsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RollUpDataPointsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<RollUpDataPointsRequest, RollUpDataPointsResponse, RollupDataPoint>(_callRollUpDataPoints, request, callSettings);
        }

        /// <summary>
        /// Roll up data points over civil time intervals for supported data types.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DailyRollUpDataPointsResponse DailyRollUpDataPoints(DailyRollUpDataPointsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DailyRollUpDataPointsRequest(ref request, ref callSettings);
            return _callDailyRollUpDataPoints.Sync(request, callSettings);
        }

        /// <summary>
        /// Roll up data points over civil time intervals for supported data types.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DailyRollUpDataPointsResponse> DailyRollUpDataPointsAsync(DailyRollUpDataPointsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DailyRollUpDataPointsRequest(ref request, ref callSettings);
            return _callDailyRollUpDataPoints.Async(request, callSettings);
        }

        /// <summary>
        /// Exports exercise data in TCX format.
        /// 
        /// 
        /// Note: While the Authorization section below states that any one of the
        /// listed scopes is accepted, this specific method requires the user to
        /// provide both one of the `activity_and_fitness` scopes (`normal` or
        /// `readonly`) AND one of the `location` scopes (`normal` or `readonly`) in
        /// their access token to succeed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ExportExerciseTcxResponse ExportExerciseTcx(ExportExerciseTcxRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportExerciseTcxRequest(ref request, ref callSettings);
            return _callExportExerciseTcx.Sync(request, callSettings);
        }

        /// <summary>
        /// Exports exercise data in TCX format.
        /// 
        /// 
        /// Note: While the Authorization section below states that any one of the
        /// listed scopes is accepted, this specific method requires the user to
        /// provide both one of the `activity_and_fitness` scopes (`normal` or
        /// `readonly`) AND one of the `location` scopes (`normal` or `readonly`) in
        /// their access token to succeed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ExportExerciseTcxResponse> ExportExerciseTcxAsync(ExportExerciseTcxRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportExerciseTcxRequest(ref request, ref callSettings);
            return _callExportExerciseTcx.Async(request, callSettings);
        }
    }

    public partial class ListDataPointsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ReconcileDataPointsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class RollUpDataPointsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDataPointsResponse : gaxgrpc::IPageResponse<DataPoint>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DataPoint> GetEnumerator() => DataPoints.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ReconcileDataPointsResponse : gaxgrpc::IPageResponse<ReconciledDataPoint>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ReconciledDataPoint> GetEnumerator() => DataPoints.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class RollUpDataPointsResponse : gaxgrpc::IPageResponse<RollupDataPoint>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<RollupDataPoint> GetEnumerator() => RollupDataPoints.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class DataPointsService
    {
        public partial class DataPointsServiceClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() =>
                new lro::Operations.OperationsClient(CallInvoker);
        }
    }
}
