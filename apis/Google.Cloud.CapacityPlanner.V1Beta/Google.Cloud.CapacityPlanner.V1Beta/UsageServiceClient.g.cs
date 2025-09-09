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
using lro = Google.LongRunning;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.CapacityPlanner.V1Beta
{
    /// <summary>Settings for <see cref="UsageServiceClient"/> instances.</summary>
    public sealed partial class UsageServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="UsageServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="UsageServiceSettings"/>.</returns>
        public static UsageServiceSettings GetDefault() => new UsageServiceSettings();

        /// <summary>Constructs a new <see cref="UsageServiceSettings"/> object with default settings.</summary>
        public UsageServiceSettings()
        {
        }

        private UsageServiceSettings(UsageServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            QueryUsageHistoriesSettings = existing.QueryUsageHistoriesSettings;
            QueryForecastsSettings = existing.QueryForecastsSettings;
            QueryReservationsSettings = existing.QueryReservationsSettings;
            ExportUsageHistoriesSettings = existing.ExportUsageHistoriesSettings;
            ExportUsageHistoriesOperationsSettings = existing.ExportUsageHistoriesOperationsSettings.Clone();
            ExportForecastsSettings = existing.ExportForecastsSettings;
            ExportForecastsOperationsSettings = existing.ExportForecastsOperationsSettings.Clone();
            ExportReservationsUsageSettings = existing.ExportReservationsUsageSettings;
            ExportReservationsUsageOperationsSettings = existing.ExportReservationsUsageOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(UsageServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UsageServiceClient.QueryUsageHistories</c> and <c>UsageServiceClient.QueryUsageHistoriesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>, <see cref="grpccore::StatusCode.Internal"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings QueryUsageHistoriesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UsageServiceClient.QueryForecasts</c> and <c>UsageServiceClient.QueryForecastsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>, <see cref="grpccore::StatusCode.Internal"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings QueryForecastsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UsageServiceClient.QueryReservations</c> and <c>UsageServiceClient.QueryReservationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>, <see cref="grpccore::StatusCode.Internal"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings QueryReservationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UsageServiceClient.ExportUsageHistories</c> and <c>UsageServiceClient.ExportUsageHistoriesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>, <see cref="grpccore::StatusCode.Internal"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExportUsageHistoriesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>UsageServiceClient.ExportUsageHistories</c> and
        /// <c>UsageServiceClient.ExportUsageHistoriesAsync</c>.
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
        public lro::OperationsSettings ExportUsageHistoriesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UsageServiceClient.ExportForecasts</c> and <c>UsageServiceClient.ExportForecastsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>, <see cref="grpccore::StatusCode.Internal"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExportForecastsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>UsageServiceClient.ExportForecasts</c> and
        /// <c>UsageServiceClient.ExportForecastsAsync</c>.
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
        public lro::OperationsSettings ExportForecastsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UsageServiceClient.ExportReservationsUsage</c> and <c>UsageServiceClient.ExportReservationsUsageAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>, <see cref="grpccore::StatusCode.Internal"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExportReservationsUsageSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>UsageServiceClient.ExportReservationsUsage</c> and
        /// <c>UsageServiceClient.ExportReservationsUsageAsync</c>.
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
        public lro::OperationsSettings ExportReservationsUsageOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="UsageServiceSettings"/> object.</returns>
        public UsageServiceSettings Clone() => new UsageServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="UsageServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class UsageServiceClientBuilder : gaxgrpc::ClientBuilderBase<UsageServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public UsageServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public UsageServiceClientBuilder() : base(UsageServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref UsageServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<UsageServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override UsageServiceClient Build()
        {
            UsageServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<UsageServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<UsageServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private UsageServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return UsageServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<UsageServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return UsageServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => UsageServiceClient.ChannelPool;
    }

    /// <summary>UsageService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides access to historical and forecasted usage data.
    /// </remarks>
    public abstract partial class UsageServiceClient
    {
        /// <summary>
        /// The default endpoint for the UsageService service, which is a host of "capacityplanner.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "capacityplanner.googleapis.com:443";

        /// <summary>The default UsageService scopes.</summary>
        /// <remarks>
        /// The default UsageService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/devstorage.full_control</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/devstorage.full_control",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(UsageService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="UsageServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="UsageServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="UsageServiceClient"/>.</returns>
        public static stt::Task<UsageServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new UsageServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="UsageServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="UsageServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="UsageServiceClient"/>.</returns>
        public static UsageServiceClient Create() => new UsageServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="UsageServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="UsageServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="UsageServiceClient"/>.</returns>
        internal static UsageServiceClient Create(grpccore::CallInvoker callInvoker, UsageServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            UsageService.UsageServiceClient grpcClient = new UsageService.UsageServiceClient(callInvoker);
            return new UsageServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC UsageService client</summary>
        public virtual UsageService.UsageServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of the usage histories that are in the parent parameter
        /// and match your specified filters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QueryUsageHistoriesResponse QueryUsageHistories(QueryUsageHistoriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of the usage histories that are in the parent parameter
        /// and match your specified filters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QueryUsageHistoriesResponse> QueryUsageHistoriesAsync(QueryUsageHistoriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of the usage histories that are in the parent parameter
        /// and match your specified filters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QueryUsageHistoriesResponse> QueryUsageHistoriesAsync(QueryUsageHistoriesRequest request, st::CancellationToken cancellationToken) =>
            QueryUsageHistoriesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a list of the forecasts that are in the parent parameter
        /// and match your specified filters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QueryForecastsResponse QueryForecasts(QueryForecastsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of the forecasts that are in the parent parameter
        /// and match your specified filters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QueryForecastsResponse> QueryForecastsAsync(QueryForecastsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of the forecasts that are in the parent parameter
        /// and match your specified filters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QueryForecastsResponse> QueryForecastsAsync(QueryForecastsRequest request, st::CancellationToken cancellationToken) =>
            QueryForecastsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a list of the reservations that are in the parent parameter
        /// and match your specified filters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QueryReservationsResponse QueryReservations(QueryReservationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of the reservations that are in the parent parameter
        /// and match your specified filters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QueryReservationsResponse> QueryReservationsAsync(QueryReservationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of the reservations that are in the parent parameter
        /// and match your specified filters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QueryReservationsResponse> QueryReservationsAsync(QueryReservationsRequest request, st::CancellationToken cancellationToken) =>
            QueryReservationsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a list of the reservations that are in the parent parameter
        /// and match your specified filters.
        /// </summary>
        /// <param name="parent">
        /// Required. The compute engine resource and location for the time series
        /// values to return. The format is:
        /// 
        /// projects/{project}/locations/{location} or
        /// organizations/{organization}/locations/{location} or
        /// folders/{folder}/locations/{location}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QueryReservationsResponse QueryReservations(string parent, gaxgrpc::CallSettings callSettings = null) =>
            QueryReservations(new QueryReservationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Returns a list of the reservations that are in the parent parameter
        /// and match your specified filters.
        /// </summary>
        /// <param name="parent">
        /// Required. The compute engine resource and location for the time series
        /// values to return. The format is:
        /// 
        /// projects/{project}/locations/{location} or
        /// organizations/{organization}/locations/{location} or
        /// folders/{folder}/locations/{location}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QueryReservationsResponse> QueryReservationsAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            QueryReservationsAsync(new QueryReservationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Returns a list of the reservations that are in the parent parameter
        /// and match your specified filters.
        /// </summary>
        /// <param name="parent">
        /// Required. The compute engine resource and location for the time series
        /// values to return. The format is:
        /// 
        /// projects/{project}/locations/{location} or
        /// organizations/{organization}/locations/{location} or
        /// folders/{folder}/locations/{location}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QueryReservationsResponse> QueryReservationsAsync(string parent, st::CancellationToken cancellationToken) =>
            QueryReservationsAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a list of the reservations that are in the parent parameter
        /// and match your specified filters.
        /// </summary>
        /// <param name="parent">
        /// Required. The compute engine resource and location for the time series
        /// values to return. The format is:
        /// 
        /// projects/{project}/locations/{location} or
        /// organizations/{organization}/locations/{location} or
        /// folders/{folder}/locations/{location}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QueryReservationsResponse QueryReservations(gagr::LocationName parent, gaxgrpc::CallSettings callSettings = null) =>
            QueryReservations(new QueryReservationsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Returns a list of the reservations that are in the parent parameter
        /// and match your specified filters.
        /// </summary>
        /// <param name="parent">
        /// Required. The compute engine resource and location for the time series
        /// values to return. The format is:
        /// 
        /// projects/{project}/locations/{location} or
        /// organizations/{organization}/locations/{location} or
        /// folders/{folder}/locations/{location}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QueryReservationsResponse> QueryReservationsAsync(gagr::LocationName parent, gaxgrpc::CallSettings callSettings = null) =>
            QueryReservationsAsync(new QueryReservationsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Returns a list of the reservations that are in the parent parameter
        /// and match your specified filters.
        /// </summary>
        /// <param name="parent">
        /// Required. The compute engine resource and location for the time series
        /// values to return. The format is:
        /// 
        /// projects/{project}/locations/{location} or
        /// organizations/{organization}/locations/{location} or
        /// folders/{folder}/locations/{location}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QueryReservationsResponse> QueryReservationsAsync(gagr::LocationName parent, st::CancellationToken cancellationToken) =>
            QueryReservationsAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports historical usage data requested by user into either an existing
        /// Cloud Storage bucket or a BigQuery table.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportUsageHistoriesResponse, OperationMetadata> ExportUsageHistories(ExportUsageHistoriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports historical usage data requested by user into either an existing
        /// Cloud Storage bucket or a BigQuery table.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportUsageHistoriesResponse, OperationMetadata>> ExportUsageHistoriesAsync(ExportUsageHistoriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports historical usage data requested by user into either an existing
        /// Cloud Storage bucket or a BigQuery table.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportUsageHistoriesResponse, OperationMetadata>> ExportUsageHistoriesAsync(ExportUsageHistoriesRequest request, st::CancellationToken cancellationToken) =>
            ExportUsageHistoriesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ExportUsageHistories</c>.</summary>
        public virtual lro::OperationsClient ExportUsageHistoriesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ExportUsageHistories</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ExportUsageHistoriesResponse, OperationMetadata> PollOnceExportUsageHistories(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportUsageHistoriesResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportUsageHistoriesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExportUsageHistories</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ExportUsageHistoriesResponse, OperationMetadata>> PollOnceExportUsageHistoriesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportUsageHistoriesResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportUsageHistoriesOperationsClient, callSettings);

        /// <summary>
        /// Exports forecasted usage data requested by user into either an existing
        /// Cloud Storage bucket or a BigQuery table.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportForecastsResponse, OperationMetadata> ExportForecasts(ExportForecastsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports forecasted usage data requested by user into either an existing
        /// Cloud Storage bucket or a BigQuery table.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportForecastsResponse, OperationMetadata>> ExportForecastsAsync(ExportForecastsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports forecasted usage data requested by user into either an existing
        /// Cloud Storage bucket or a BigQuery table.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportForecastsResponse, OperationMetadata>> ExportForecastsAsync(ExportForecastsRequest request, st::CancellationToken cancellationToken) =>
            ExportForecastsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ExportForecasts</c>.</summary>
        public virtual lro::OperationsClient ExportForecastsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ExportForecasts</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ExportForecastsResponse, OperationMetadata> PollOnceExportForecasts(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportForecastsResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportForecastsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExportForecasts</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ExportForecastsResponse, OperationMetadata>> PollOnceExportForecastsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportForecastsResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportForecastsOperationsClient, callSettings);

        /// <summary>
        /// Exports reservations usage data requested by user into either an existing
        /// Cloud Storage bucket or a new/existing BigQuery table.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportReservationsUsageResponse, OperationMetadata> ExportReservationsUsage(ExportReservationsUsageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports reservations usage data requested by user into either an existing
        /// Cloud Storage bucket or a new/existing BigQuery table.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportReservationsUsageResponse, OperationMetadata>> ExportReservationsUsageAsync(ExportReservationsUsageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports reservations usage data requested by user into either an existing
        /// Cloud Storage bucket or a new/existing BigQuery table.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportReservationsUsageResponse, OperationMetadata>> ExportReservationsUsageAsync(ExportReservationsUsageRequest request, st::CancellationToken cancellationToken) =>
            ExportReservationsUsageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ExportReservationsUsage</c>.</summary>
        public virtual lro::OperationsClient ExportReservationsUsageOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExportReservationsUsage</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ExportReservationsUsageResponse, OperationMetadata> PollOnceExportReservationsUsage(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportReservationsUsageResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportReservationsUsageOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExportReservationsUsage</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ExportReservationsUsageResponse, OperationMetadata>> PollOnceExportReservationsUsageAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportReservationsUsageResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportReservationsUsageOperationsClient, callSettings);
    }

    /// <summary>UsageService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides access to historical and forecasted usage data.
    /// </remarks>
    public sealed partial class UsageServiceClientImpl : UsageServiceClient
    {
        private readonly gaxgrpc::ApiCall<QueryUsageHistoriesRequest, QueryUsageHistoriesResponse> _callQueryUsageHistories;

        private readonly gaxgrpc::ApiCall<QueryForecastsRequest, QueryForecastsResponse> _callQueryForecasts;

        private readonly gaxgrpc::ApiCall<QueryReservationsRequest, QueryReservationsResponse> _callQueryReservations;

        private readonly gaxgrpc::ApiCall<ExportUsageHistoriesRequest, lro::Operation> _callExportUsageHistories;

        private readonly gaxgrpc::ApiCall<ExportForecastsRequest, lro::Operation> _callExportForecasts;

        private readonly gaxgrpc::ApiCall<ExportReservationsUsageRequest, lro::Operation> _callExportReservationsUsage;

        /// <summary>
        /// Constructs a client wrapper for the UsageService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="UsageServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public UsageServiceClientImpl(UsageService.UsageServiceClient grpcClient, UsageServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            UsageServiceSettings effectiveSettings = settings ?? UsageServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            ExportUsageHistoriesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ExportUsageHistoriesOperationsSettings, logger);
            ExportForecastsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ExportForecastsOperationsSettings, logger);
            ExportReservationsUsageOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ExportReservationsUsageOperationsSettings, logger);
            _callQueryUsageHistories = clientHelper.BuildApiCall<QueryUsageHistoriesRequest, QueryUsageHistoriesResponse>("QueryUsageHistories", grpcClient.QueryUsageHistoriesAsync, grpcClient.QueryUsageHistories, effectiveSettings.QueryUsageHistoriesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callQueryUsageHistories);
            Modify_QueryUsageHistoriesApiCall(ref _callQueryUsageHistories);
            _callQueryForecasts = clientHelper.BuildApiCall<QueryForecastsRequest, QueryForecastsResponse>("QueryForecasts", grpcClient.QueryForecastsAsync, grpcClient.QueryForecasts, effectiveSettings.QueryForecastsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callQueryForecasts);
            Modify_QueryForecastsApiCall(ref _callQueryForecasts);
            _callQueryReservations = clientHelper.BuildApiCall<QueryReservationsRequest, QueryReservationsResponse>("QueryReservations", grpcClient.QueryReservationsAsync, grpcClient.QueryReservations, effectiveSettings.QueryReservationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callQueryReservations);
            Modify_QueryReservationsApiCall(ref _callQueryReservations);
            _callExportUsageHistories = clientHelper.BuildApiCall<ExportUsageHistoriesRequest, lro::Operation>("ExportUsageHistories", grpcClient.ExportUsageHistoriesAsync, grpcClient.ExportUsageHistories, effectiveSettings.ExportUsageHistoriesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callExportUsageHistories);
            Modify_ExportUsageHistoriesApiCall(ref _callExportUsageHistories);
            _callExportForecasts = clientHelper.BuildApiCall<ExportForecastsRequest, lro::Operation>("ExportForecasts", grpcClient.ExportForecastsAsync, grpcClient.ExportForecasts, effectiveSettings.ExportForecastsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callExportForecasts);
            Modify_ExportForecastsApiCall(ref _callExportForecasts);
            _callExportReservationsUsage = clientHelper.BuildApiCall<ExportReservationsUsageRequest, lro::Operation>("ExportReservationsUsage", grpcClient.ExportReservationsUsageAsync, grpcClient.ExportReservationsUsage, effectiveSettings.ExportReservationsUsageSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callExportReservationsUsage);
            Modify_ExportReservationsUsageApiCall(ref _callExportReservationsUsage);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_QueryUsageHistoriesApiCall(ref gaxgrpc::ApiCall<QueryUsageHistoriesRequest, QueryUsageHistoriesResponse> call);

        partial void Modify_QueryForecastsApiCall(ref gaxgrpc::ApiCall<QueryForecastsRequest, QueryForecastsResponse> call);

        partial void Modify_QueryReservationsApiCall(ref gaxgrpc::ApiCall<QueryReservationsRequest, QueryReservationsResponse> call);

        partial void Modify_ExportUsageHistoriesApiCall(ref gaxgrpc::ApiCall<ExportUsageHistoriesRequest, lro::Operation> call);

        partial void Modify_ExportForecastsApiCall(ref gaxgrpc::ApiCall<ExportForecastsRequest, lro::Operation> call);

        partial void Modify_ExportReservationsUsageApiCall(ref gaxgrpc::ApiCall<ExportReservationsUsageRequest, lro::Operation> call);

        partial void OnConstruction(UsageService.UsageServiceClient grpcClient, UsageServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC UsageService client</summary>
        public override UsageService.UsageServiceClient GrpcClient { get; }

        partial void Modify_QueryUsageHistoriesRequest(ref QueryUsageHistoriesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_QueryForecastsRequest(ref QueryForecastsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_QueryReservationsRequest(ref QueryReservationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExportUsageHistoriesRequest(ref ExportUsageHistoriesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExportForecastsRequest(ref ExportForecastsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExportReservationsUsageRequest(ref ExportReservationsUsageRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns a list of the usage histories that are in the parent parameter
        /// and match your specified filters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override QueryUsageHistoriesResponse QueryUsageHistories(QueryUsageHistoriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryUsageHistoriesRequest(ref request, ref callSettings);
            return _callQueryUsageHistories.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns a list of the usage histories that are in the parent parameter
        /// and match your specified filters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<QueryUsageHistoriesResponse> QueryUsageHistoriesAsync(QueryUsageHistoriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryUsageHistoriesRequest(ref request, ref callSettings);
            return _callQueryUsageHistories.Async(request, callSettings);
        }

        /// <summary>
        /// Returns a list of the forecasts that are in the parent parameter
        /// and match your specified filters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override QueryForecastsResponse QueryForecasts(QueryForecastsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryForecastsRequest(ref request, ref callSettings);
            return _callQueryForecasts.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns a list of the forecasts that are in the parent parameter
        /// and match your specified filters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<QueryForecastsResponse> QueryForecastsAsync(QueryForecastsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryForecastsRequest(ref request, ref callSettings);
            return _callQueryForecasts.Async(request, callSettings);
        }

        /// <summary>
        /// Returns a list of the reservations that are in the parent parameter
        /// and match your specified filters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override QueryReservationsResponse QueryReservations(QueryReservationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryReservationsRequest(ref request, ref callSettings);
            return _callQueryReservations.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns a list of the reservations that are in the parent parameter
        /// and match your specified filters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<QueryReservationsResponse> QueryReservationsAsync(QueryReservationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryReservationsRequest(ref request, ref callSettings);
            return _callQueryReservations.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>ExportUsageHistories</c>.</summary>
        public override lro::OperationsClient ExportUsageHistoriesOperationsClient { get; }

        /// <summary>
        /// Exports historical usage data requested by user into either an existing
        /// Cloud Storage bucket or a BigQuery table.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ExportUsageHistoriesResponse, OperationMetadata> ExportUsageHistories(ExportUsageHistoriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportUsageHistoriesRequest(ref request, ref callSettings);
            return new lro::Operation<ExportUsageHistoriesResponse, OperationMetadata>(_callExportUsageHistories.Sync(request, callSettings), ExportUsageHistoriesOperationsClient);
        }

        /// <summary>
        /// Exports historical usage data requested by user into either an existing
        /// Cloud Storage bucket or a BigQuery table.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ExportUsageHistoriesResponse, OperationMetadata>> ExportUsageHistoriesAsync(ExportUsageHistoriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportUsageHistoriesRequest(ref request, ref callSettings);
            return new lro::Operation<ExportUsageHistoriesResponse, OperationMetadata>(await _callExportUsageHistories.Async(request, callSettings).ConfigureAwait(false), ExportUsageHistoriesOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ExportForecasts</c>.</summary>
        public override lro::OperationsClient ExportForecastsOperationsClient { get; }

        /// <summary>
        /// Exports forecasted usage data requested by user into either an existing
        /// Cloud Storage bucket or a BigQuery table.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ExportForecastsResponse, OperationMetadata> ExportForecasts(ExportForecastsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportForecastsRequest(ref request, ref callSettings);
            return new lro::Operation<ExportForecastsResponse, OperationMetadata>(_callExportForecasts.Sync(request, callSettings), ExportForecastsOperationsClient);
        }

        /// <summary>
        /// Exports forecasted usage data requested by user into either an existing
        /// Cloud Storage bucket or a BigQuery table.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ExportForecastsResponse, OperationMetadata>> ExportForecastsAsync(ExportForecastsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportForecastsRequest(ref request, ref callSettings);
            return new lro::Operation<ExportForecastsResponse, OperationMetadata>(await _callExportForecasts.Async(request, callSettings).ConfigureAwait(false), ExportForecastsOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ExportReservationsUsage</c>.</summary>
        public override lro::OperationsClient ExportReservationsUsageOperationsClient { get; }

        /// <summary>
        /// Exports reservations usage data requested by user into either an existing
        /// Cloud Storage bucket or a new/existing BigQuery table.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ExportReservationsUsageResponse, OperationMetadata> ExportReservationsUsage(ExportReservationsUsageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportReservationsUsageRequest(ref request, ref callSettings);
            return new lro::Operation<ExportReservationsUsageResponse, OperationMetadata>(_callExportReservationsUsage.Sync(request, callSettings), ExportReservationsUsageOperationsClient);
        }

        /// <summary>
        /// Exports reservations usage data requested by user into either an existing
        /// Cloud Storage bucket or a new/existing BigQuery table.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ExportReservationsUsageResponse, OperationMetadata>> ExportReservationsUsageAsync(ExportReservationsUsageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportReservationsUsageRequest(ref request, ref callSettings);
            return new lro::Operation<ExportReservationsUsageResponse, OperationMetadata>(await _callExportReservationsUsage.Async(request, callSettings).ConfigureAwait(false), ExportReservationsUsageOperationsClient);
        }
    }

    public static partial class UsageService
    {
        public partial class UsageServiceClient
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
