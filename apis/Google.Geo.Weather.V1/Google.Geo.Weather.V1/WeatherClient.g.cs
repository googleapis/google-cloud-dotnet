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

namespace Google.Geo.Weather.V1
{
    /// <summary>Settings for <see cref="WeatherClient"/> instances.</summary>
    public sealed partial class WeatherSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="WeatherSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="WeatherSettings"/>.</returns>
        public static WeatherSettings GetDefault() => new WeatherSettings();

        /// <summary>Constructs a new <see cref="WeatherSettings"/> object with default settings.</summary>
        public WeatherSettings()
        {
        }

        private WeatherSettings(WeatherSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            LookupCurrentConditionsSettings = existing.LookupCurrentConditionsSettings;
            LookupForecastHoursSettings = existing.LookupForecastHoursSettings;
            LookupForecastDaysSettings = existing.LookupForecastDaysSettings;
            LookupHistoryHoursSettings = existing.LookupHistoryHoursSettings;
            LookupPublicAlertsSettings = existing.LookupPublicAlertsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(WeatherSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WeatherClient.LookupCurrentConditions</c> and <c>WeatherClient.LookupCurrentConditionsAsync</c>.
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
        public gaxgrpc::CallSettings LookupCurrentConditionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WeatherClient.LookupForecastHours</c> and <c>WeatherClient.LookupForecastHoursAsync</c>.
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
        public gaxgrpc::CallSettings LookupForecastHoursSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WeatherClient.LookupForecastDays</c> and <c>WeatherClient.LookupForecastDaysAsync</c>.
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
        public gaxgrpc::CallSettings LookupForecastDaysSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WeatherClient.LookupHistoryHours</c> and <c>WeatherClient.LookupHistoryHoursAsync</c>.
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
        public gaxgrpc::CallSettings LookupHistoryHoursSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WeatherClient.LookupPublicAlerts</c> and <c>WeatherClient.LookupPublicAlertsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings LookupPublicAlertsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="WeatherSettings"/> object.</returns>
        public WeatherSettings Clone() => new WeatherSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="WeatherClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class WeatherClientBuilder : gaxgrpc::ClientBuilderBase<WeatherClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public WeatherSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public WeatherClientBuilder() : base(WeatherClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref WeatherClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<WeatherClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override WeatherClient Build()
        {
            WeatherClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<WeatherClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<WeatherClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private WeatherClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return WeatherClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<WeatherClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return WeatherClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => WeatherClient.ChannelPool;
    }

    /// <summary>Weather client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service definition for the Weather API.
    /// </remarks>
    public abstract partial class WeatherClient
    {
        /// <summary>
        /// The default endpoint for the Weather service, which is a host of "weather.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "weather.googleapis.com:443";

        /// <summary>The default Weather scopes.</summary>
        /// <remarks>
        /// The default Weather scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Weather.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="WeatherClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="WeatherClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="WeatherClient"/>.</returns>
        public static stt::Task<WeatherClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new WeatherClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="WeatherClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="WeatherClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="WeatherClient"/>.</returns>
        public static WeatherClient Create() => new WeatherClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="WeatherClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="WeatherSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="WeatherClient"/>.</returns>
        internal static WeatherClient Create(grpccore::CallInvoker callInvoker, WeatherSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Weather.WeatherClient grpcClient = new Weather.WeatherClient(callInvoker);
            return new WeatherClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Weather client</summary>
        public virtual Weather.WeatherClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the current weather conditions at a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LookupCurrentConditionsResponse LookupCurrentConditions(LookupCurrentConditionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the current weather conditions at a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LookupCurrentConditionsResponse> LookupCurrentConditionsAsync(LookupCurrentConditionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the current weather conditions at a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LookupCurrentConditionsResponse> LookupCurrentConditionsAsync(LookupCurrentConditionsRequest request, st::CancellationToken cancellationToken) =>
            LookupCurrentConditionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns up to 240 hours of hourly forecasts at a given location, starting
        /// from the current hour.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ForecastHour"/> resources.</returns>
        public virtual gax::PagedEnumerable<LookupForecastHoursResponse, ForecastHour> LookupForecastHours(LookupForecastHoursRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns up to 240 hours of hourly forecasts at a given location, starting
        /// from the current hour.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ForecastHour"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<LookupForecastHoursResponse, ForecastHour> LookupForecastHoursAsync(LookupForecastHoursRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns up to 10 days of daily forecasts at a given location, starting from
        /// the current day.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ForecastDay"/> resources.</returns>
        public virtual gax::PagedEnumerable<LookupForecastDaysResponse, ForecastDay> LookupForecastDays(LookupForecastDaysRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns up to 10 days of daily forecasts at a given location, starting from
        /// the current day.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ForecastDay"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<LookupForecastDaysResponse, ForecastDay> LookupForecastDaysAsync(LookupForecastDaysRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns up to 24 hours of hourly historical weather data at a given
        /// location, starting from the last hour.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="HistoryHour"/> resources.</returns>
        public virtual gax::PagedEnumerable<LookupHistoryHoursResponse, HistoryHour> LookupHistoryHours(LookupHistoryHoursRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns up to 24 hours of hourly historical weather data at a given
        /// location, starting from the last hour.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="HistoryHour"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<LookupHistoryHoursResponse, HistoryHour> LookupHistoryHoursAsync(LookupHistoryHoursRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns public weather alerts for a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PublicAlerts"/> resources.</returns>
        public virtual gax::PagedEnumerable<LookupPublicAlertsResponse, PublicAlerts> LookupPublicAlerts(LookupPublicAlertsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns public weather alerts for a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PublicAlerts"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<LookupPublicAlertsResponse, PublicAlerts> LookupPublicAlertsAsync(LookupPublicAlertsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();
    }

    /// <summary>Weather client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service definition for the Weather API.
    /// </remarks>
    public sealed partial class WeatherClientImpl : WeatherClient
    {
        private readonly gaxgrpc::ApiCall<LookupCurrentConditionsRequest, LookupCurrentConditionsResponse> _callLookupCurrentConditions;

        private readonly gaxgrpc::ApiCall<LookupForecastHoursRequest, LookupForecastHoursResponse> _callLookupForecastHours;

        private readonly gaxgrpc::ApiCall<LookupForecastDaysRequest, LookupForecastDaysResponse> _callLookupForecastDays;

        private readonly gaxgrpc::ApiCall<LookupHistoryHoursRequest, LookupHistoryHoursResponse> _callLookupHistoryHours;

        private readonly gaxgrpc::ApiCall<LookupPublicAlertsRequest, LookupPublicAlertsResponse> _callLookupPublicAlerts;

        /// <summary>
        /// Constructs a client wrapper for the Weather service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="WeatherSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public WeatherClientImpl(Weather.WeatherClient grpcClient, WeatherSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            WeatherSettings effectiveSettings = settings ?? WeatherSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callLookupCurrentConditions = clientHelper.BuildApiCall<LookupCurrentConditionsRequest, LookupCurrentConditionsResponse>("LookupCurrentConditions", grpcClient.LookupCurrentConditionsAsync, grpcClient.LookupCurrentConditions, effectiveSettings.LookupCurrentConditionsSettings);
            Modify_ApiCall(ref _callLookupCurrentConditions);
            Modify_LookupCurrentConditionsApiCall(ref _callLookupCurrentConditions);
            _callLookupForecastHours = clientHelper.BuildApiCall<LookupForecastHoursRequest, LookupForecastHoursResponse>("LookupForecastHours", grpcClient.LookupForecastHoursAsync, grpcClient.LookupForecastHours, effectiveSettings.LookupForecastHoursSettings);
            Modify_ApiCall(ref _callLookupForecastHours);
            Modify_LookupForecastHoursApiCall(ref _callLookupForecastHours);
            _callLookupForecastDays = clientHelper.BuildApiCall<LookupForecastDaysRequest, LookupForecastDaysResponse>("LookupForecastDays", grpcClient.LookupForecastDaysAsync, grpcClient.LookupForecastDays, effectiveSettings.LookupForecastDaysSettings);
            Modify_ApiCall(ref _callLookupForecastDays);
            Modify_LookupForecastDaysApiCall(ref _callLookupForecastDays);
            _callLookupHistoryHours = clientHelper.BuildApiCall<LookupHistoryHoursRequest, LookupHistoryHoursResponse>("LookupHistoryHours", grpcClient.LookupHistoryHoursAsync, grpcClient.LookupHistoryHours, effectiveSettings.LookupHistoryHoursSettings);
            Modify_ApiCall(ref _callLookupHistoryHours);
            Modify_LookupHistoryHoursApiCall(ref _callLookupHistoryHours);
            _callLookupPublicAlerts = clientHelper.BuildApiCall<LookupPublicAlertsRequest, LookupPublicAlertsResponse>("LookupPublicAlerts", grpcClient.LookupPublicAlertsAsync, grpcClient.LookupPublicAlerts, effectiveSettings.LookupPublicAlertsSettings);
            Modify_ApiCall(ref _callLookupPublicAlerts);
            Modify_LookupPublicAlertsApiCall(ref _callLookupPublicAlerts);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_LookupCurrentConditionsApiCall(ref gaxgrpc::ApiCall<LookupCurrentConditionsRequest, LookupCurrentConditionsResponse> call);

        partial void Modify_LookupForecastHoursApiCall(ref gaxgrpc::ApiCall<LookupForecastHoursRequest, LookupForecastHoursResponse> call);

        partial void Modify_LookupForecastDaysApiCall(ref gaxgrpc::ApiCall<LookupForecastDaysRequest, LookupForecastDaysResponse> call);

        partial void Modify_LookupHistoryHoursApiCall(ref gaxgrpc::ApiCall<LookupHistoryHoursRequest, LookupHistoryHoursResponse> call);

        partial void Modify_LookupPublicAlertsApiCall(ref gaxgrpc::ApiCall<LookupPublicAlertsRequest, LookupPublicAlertsResponse> call);

        partial void OnConstruction(Weather.WeatherClient grpcClient, WeatherSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Weather client</summary>
        public override Weather.WeatherClient GrpcClient { get; }

        partial void Modify_LookupCurrentConditionsRequest(ref LookupCurrentConditionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_LookupForecastHoursRequest(ref LookupForecastHoursRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_LookupForecastDaysRequest(ref LookupForecastDaysRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_LookupHistoryHoursRequest(ref LookupHistoryHoursRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_LookupPublicAlertsRequest(ref LookupPublicAlertsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the current weather conditions at a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LookupCurrentConditionsResponse LookupCurrentConditions(LookupCurrentConditionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LookupCurrentConditionsRequest(ref request, ref callSettings);
            return _callLookupCurrentConditions.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the current weather conditions at a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LookupCurrentConditionsResponse> LookupCurrentConditionsAsync(LookupCurrentConditionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LookupCurrentConditionsRequest(ref request, ref callSettings);
            return _callLookupCurrentConditions.Async(request, callSettings);
        }

        /// <summary>
        /// Returns up to 240 hours of hourly forecasts at a given location, starting
        /// from the current hour.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ForecastHour"/> resources.</returns>
        public override gax::PagedEnumerable<LookupForecastHoursResponse, ForecastHour> LookupForecastHours(LookupForecastHoursRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LookupForecastHoursRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<LookupForecastHoursRequest, LookupForecastHoursResponse, ForecastHour>(_callLookupForecastHours, request, callSettings);
        }

        /// <summary>
        /// Returns up to 240 hours of hourly forecasts at a given location, starting
        /// from the current hour.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ForecastHour"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<LookupForecastHoursResponse, ForecastHour> LookupForecastHoursAsync(LookupForecastHoursRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LookupForecastHoursRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<LookupForecastHoursRequest, LookupForecastHoursResponse, ForecastHour>(_callLookupForecastHours, request, callSettings);
        }

        /// <summary>
        /// Returns up to 10 days of daily forecasts at a given location, starting from
        /// the current day.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ForecastDay"/> resources.</returns>
        public override gax::PagedEnumerable<LookupForecastDaysResponse, ForecastDay> LookupForecastDays(LookupForecastDaysRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LookupForecastDaysRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<LookupForecastDaysRequest, LookupForecastDaysResponse, ForecastDay>(_callLookupForecastDays, request, callSettings);
        }

        /// <summary>
        /// Returns up to 10 days of daily forecasts at a given location, starting from
        /// the current day.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ForecastDay"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<LookupForecastDaysResponse, ForecastDay> LookupForecastDaysAsync(LookupForecastDaysRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LookupForecastDaysRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<LookupForecastDaysRequest, LookupForecastDaysResponse, ForecastDay>(_callLookupForecastDays, request, callSettings);
        }

        /// <summary>
        /// Returns up to 24 hours of hourly historical weather data at a given
        /// location, starting from the last hour.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="HistoryHour"/> resources.</returns>
        public override gax::PagedEnumerable<LookupHistoryHoursResponse, HistoryHour> LookupHistoryHours(LookupHistoryHoursRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LookupHistoryHoursRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<LookupHistoryHoursRequest, LookupHistoryHoursResponse, HistoryHour>(_callLookupHistoryHours, request, callSettings);
        }

        /// <summary>
        /// Returns up to 24 hours of hourly historical weather data at a given
        /// location, starting from the last hour.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="HistoryHour"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<LookupHistoryHoursResponse, HistoryHour> LookupHistoryHoursAsync(LookupHistoryHoursRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LookupHistoryHoursRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<LookupHistoryHoursRequest, LookupHistoryHoursResponse, HistoryHour>(_callLookupHistoryHours, request, callSettings);
        }

        /// <summary>
        /// Returns public weather alerts for a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PublicAlerts"/> resources.</returns>
        public override gax::PagedEnumerable<LookupPublicAlertsResponse, PublicAlerts> LookupPublicAlerts(LookupPublicAlertsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LookupPublicAlertsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<LookupPublicAlertsRequest, LookupPublicAlertsResponse, PublicAlerts>(_callLookupPublicAlerts, request, callSettings);
        }

        /// <summary>
        /// Returns public weather alerts for a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PublicAlerts"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<LookupPublicAlertsResponse, PublicAlerts> LookupPublicAlertsAsync(LookupPublicAlertsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LookupPublicAlertsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<LookupPublicAlertsRequest, LookupPublicAlertsResponse, PublicAlerts>(_callLookupPublicAlerts, request, callSettings);
        }
    }

    public partial class LookupForecastHoursRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class LookupForecastDaysRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class LookupHistoryHoursRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class LookupPublicAlertsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class LookupForecastHoursResponse : gaxgrpc::IPageResponse<ForecastHour>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ForecastHour> GetEnumerator() => ForecastHours.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class LookupForecastDaysResponse : gaxgrpc::IPageResponse<ForecastDay>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ForecastDay> GetEnumerator() => ForecastDays.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class LookupHistoryHoursResponse : gaxgrpc::IPageResponse<HistoryHour>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<HistoryHour> GetEnumerator() => HistoryHours.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class LookupPublicAlertsResponse : gaxgrpc::IPageResponse<PublicAlerts>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<PublicAlerts> GetEnumerator() => WeatherAlerts.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
