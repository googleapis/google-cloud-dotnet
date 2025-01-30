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
using gcl = Google.Cloud.Location;
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
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.DiscoveryEngine.V1Beta
{
    /// <summary>Settings for <see cref="SampleQueryServiceClient"/> instances.</summary>
    public sealed partial class SampleQueryServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SampleQueryServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SampleQueryServiceSettings"/>.</returns>
        public static SampleQueryServiceSettings GetDefault() => new SampleQueryServiceSettings();

        /// <summary>Constructs a new <see cref="SampleQueryServiceSettings"/> object with default settings.</summary>
        public SampleQueryServiceSettings()
        {
        }

        private SampleQueryServiceSettings(SampleQueryServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetSampleQuerySettings = existing.GetSampleQuerySettings;
            ListSampleQueriesSettings = existing.ListSampleQueriesSettings;
            CreateSampleQuerySettings = existing.CreateSampleQuerySettings;
            UpdateSampleQuerySettings = existing.UpdateSampleQuerySettings;
            DeleteSampleQuerySettings = existing.DeleteSampleQuerySettings;
            ImportSampleQueriesSettings = existing.ImportSampleQueriesSettings;
            ImportSampleQueriesOperationsSettings = existing.ImportSampleQueriesOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SampleQueryServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SampleQueryServiceClient.GetSampleQuery</c> and <c>SampleQueryServiceClient.GetSampleQueryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSampleQuerySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SampleQueryServiceClient.ListSampleQueries</c> and <c>SampleQueryServiceClient.ListSampleQueriesAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSampleQueriesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SampleQueryServiceClient.CreateSampleQuery</c> and <c>SampleQueryServiceClient.CreateSampleQueryAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSampleQuerySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SampleQueryServiceClient.UpdateSampleQuery</c> and <c>SampleQueryServiceClient.UpdateSampleQueryAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSampleQuerySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SampleQueryServiceClient.DeleteSampleQuery</c> and <c>SampleQueryServiceClient.DeleteSampleQueryAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSampleQuerySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SampleQueryServiceClient.ImportSampleQueries</c> and <c>SampleQueryServiceClient.ImportSampleQueriesAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ImportSampleQueriesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>SampleQueryServiceClient.ImportSampleQueries</c> and
        /// <c>SampleQueryServiceClient.ImportSampleQueriesAsync</c>.
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
        public lro::OperationsSettings ImportSampleQueriesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SampleQueryServiceSettings"/> object.</returns>
        public SampleQueryServiceSettings Clone() => new SampleQueryServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SampleQueryServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class SampleQueryServiceClientBuilder : gaxgrpc::ClientBuilderBase<SampleQueryServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SampleQueryServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SampleQueryServiceClientBuilder() : base(SampleQueryServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref SampleQueryServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SampleQueryServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SampleQueryServiceClient Build()
        {
            SampleQueryServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SampleQueryServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SampleQueryServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SampleQueryServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SampleQueryServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<SampleQueryServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SampleQueryServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SampleQueryServiceClient.ChannelPool;
    }

    /// <summary>SampleQueryService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing
    /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery]s,
    /// </remarks>
    public abstract partial class SampleQueryServiceClient
    {
        /// <summary>
        /// The default endpoint for the SampleQueryService service, which is a host of "discoveryengine.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "discoveryengine.googleapis.com:443";

        /// <summary>The default SampleQueryService scopes.</summary>
        /// <remarks>
        /// The default SampleQueryService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(SampleQueryService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="SampleQueryServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="SampleQueryServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SampleQueryServiceClient"/>.</returns>
        public static stt::Task<SampleQueryServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SampleQueryServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SampleQueryServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="SampleQueryServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="SampleQueryServiceClient"/>.</returns>
        public static SampleQueryServiceClient Create() => new SampleQueryServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SampleQueryServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SampleQueryServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="SampleQueryServiceClient"/>.</returns>
        internal static SampleQueryServiceClient Create(grpccore::CallInvoker callInvoker, SampleQueryServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SampleQueryService.SampleQueryServiceClient grpcClient = new SampleQueryService.SampleQueryServiceClient(callInvoker);
            return new SampleQueryServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC SampleQueryService client</summary>
        public virtual SampleQueryService.SampleQueryServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SampleQuery GetSampleQuery(GetSampleQueryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SampleQuery> GetSampleQueryAsync(GetSampleQueryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SampleQuery> GetSampleQueryAsync(GetSampleQueryRequest request, st::CancellationToken cancellationToken) =>
            GetSampleQueryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery], such as
        /// `projects/{project}/locations/{location}/sampleQuerySets/{sample_query_set}/sampleQueries/{sample_query}`.
        /// 
        /// If the caller does not have permission to access the
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery], regardless
        /// of whether or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the requested
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery] does not
        /// exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SampleQuery GetSampleQuery(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSampleQuery(new GetSampleQueryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery], such as
        /// `projects/{project}/locations/{location}/sampleQuerySets/{sample_query_set}/sampleQueries/{sample_query}`.
        /// 
        /// If the caller does not have permission to access the
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery], regardless
        /// of whether or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the requested
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery] does not
        /// exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SampleQuery> GetSampleQueryAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSampleQueryAsync(new GetSampleQueryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery], such as
        /// `projects/{project}/locations/{location}/sampleQuerySets/{sample_query_set}/sampleQueries/{sample_query}`.
        /// 
        /// If the caller does not have permission to access the
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery], regardless
        /// of whether or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the requested
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery] does not
        /// exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SampleQuery> GetSampleQueryAsync(string name, st::CancellationToken cancellationToken) =>
            GetSampleQueryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery], such as
        /// `projects/{project}/locations/{location}/sampleQuerySets/{sample_query_set}/sampleQueries/{sample_query}`.
        /// 
        /// If the caller does not have permission to access the
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery], regardless
        /// of whether or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the requested
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery] does not
        /// exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SampleQuery GetSampleQuery(SampleQueryName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSampleQuery(new GetSampleQueryRequest
            {
                SampleQueryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery], such as
        /// `projects/{project}/locations/{location}/sampleQuerySets/{sample_query_set}/sampleQueries/{sample_query}`.
        /// 
        /// If the caller does not have permission to access the
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery], regardless
        /// of whether or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the requested
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery] does not
        /// exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SampleQuery> GetSampleQueryAsync(SampleQueryName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSampleQueryAsync(new GetSampleQueryRequest
            {
                SampleQueryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery], such as
        /// `projects/{project}/locations/{location}/sampleQuerySets/{sample_query_set}/sampleQueries/{sample_query}`.
        /// 
        /// If the caller does not have permission to access the
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery], regardless
        /// of whether or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the requested
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery] does not
        /// exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SampleQuery> GetSampleQueryAsync(SampleQueryName name, st::CancellationToken cancellationToken) =>
            GetSampleQueryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a list of
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery]s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SampleQuery"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSampleQueriesResponse, SampleQuery> ListSampleQueries(ListSampleQueriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a list of
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery]s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SampleQuery"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSampleQueriesResponse, SampleQuery> ListSampleQueriesAsync(ListSampleQueriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a list of
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery]s.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent sample query set resource name, such as
        /// `projects/{project}/locations/{location}/sampleQuerySets/{sampleQuerySet}`.
        /// 
        /// If the caller does not have permission to list
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery]s under this
        /// sample query set, regardless of whether or not this sample query set
        /// exists, a `PERMISSION_DENIED` error is returned.
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
        /// <returns>A pageable sequence of <see cref="SampleQuery"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSampleQueriesResponse, SampleQuery> ListSampleQueries(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSampleQueriesRequest request = new ListSampleQueriesRequest
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
            return ListSampleQueries(request, callSettings);
        }

        /// <summary>
        /// Gets a list of
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery]s.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent sample query set resource name, such as
        /// `projects/{project}/locations/{location}/sampleQuerySets/{sampleQuerySet}`.
        /// 
        /// If the caller does not have permission to list
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery]s under this
        /// sample query set, regardless of whether or not this sample query set
        /// exists, a `PERMISSION_DENIED` error is returned.
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
        /// <returns>A pageable asynchronous sequence of <see cref="SampleQuery"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSampleQueriesResponse, SampleQuery> ListSampleQueriesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSampleQueriesRequest request = new ListSampleQueriesRequest
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
            return ListSampleQueriesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a list of
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery]s.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent sample query set resource name, such as
        /// `projects/{project}/locations/{location}/sampleQuerySets/{sampleQuerySet}`.
        /// 
        /// If the caller does not have permission to list
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery]s under this
        /// sample query set, regardless of whether or not this sample query set
        /// exists, a `PERMISSION_DENIED` error is returned.
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
        /// <returns>A pageable sequence of <see cref="SampleQuery"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSampleQueriesResponse, SampleQuery> ListSampleQueries(SampleQuerySetName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSampleQueriesRequest request = new ListSampleQueriesRequest
            {
                ParentAsSampleQuerySetName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSampleQueries(request, callSettings);
        }

        /// <summary>
        /// Gets a list of
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery]s.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent sample query set resource name, such as
        /// `projects/{project}/locations/{location}/sampleQuerySets/{sampleQuerySet}`.
        /// 
        /// If the caller does not have permission to list
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery]s under this
        /// sample query set, regardless of whether or not this sample query set
        /// exists, a `PERMISSION_DENIED` error is returned.
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
        /// <returns>A pageable asynchronous sequence of <see cref="SampleQuery"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSampleQueriesResponse, SampleQuery> ListSampleQueriesAsync(SampleQuerySetName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSampleQueriesRequest request = new ListSampleQueriesRequest
            {
                ParentAsSampleQuerySetName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSampleQueriesAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SampleQuery CreateSampleQuery(CreateSampleQueryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SampleQuery> CreateSampleQueryAsync(CreateSampleQueryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SampleQuery> CreateSampleQueryAsync(CreateSampleQueryRequest request, st::CancellationToken cancellationToken) =>
            CreateSampleQueryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery]
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, such as
        /// `projects/{project}/locations/{location}/sampleQuerySets/{sampleQuerySet}`.
        /// </param>
        /// <param name="sampleQuery">
        /// Required. The
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery] to create.
        /// </param>
        /// <param name="sampleQueryId">
        /// Required. The ID to use for the
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery], which will
        /// become the final component of the
        /// [SampleQuery.name][google.cloud.discoveryengine.v1beta.SampleQuery.name].
        /// 
        /// If the caller does not have permission to create the
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery], regardless
        /// of whether or not it exists, a `PERMISSION_DENIED` error is returned.
        /// 
        /// This field must be unique among all
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery]s with the
        /// same
        /// [parent][google.cloud.discoveryengine.v1beta.CreateSampleQueryRequest.parent].
        /// Otherwise, an `ALREADY_EXISTS` error is returned.
        /// 
        /// This field must conform to [RFC-1034](https://tools.ietf.org/html/rfc1034)
        /// standard with a length limit of 63 characters. Otherwise, an
        /// `INVALID_ARGUMENT` error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SampleQuery CreateSampleQuery(string parent, SampleQuery sampleQuery, string sampleQueryId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSampleQuery(new CreateSampleQueryRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SampleQuery = gax::GaxPreconditions.CheckNotNull(sampleQuery, nameof(sampleQuery)),
                SampleQueryId = gax::GaxPreconditions.CheckNotNullOrEmpty(sampleQueryId, nameof(sampleQueryId)),
            }, callSettings);

        /// <summary>
        /// Creates a [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery]
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, such as
        /// `projects/{project}/locations/{location}/sampleQuerySets/{sampleQuerySet}`.
        /// </param>
        /// <param name="sampleQuery">
        /// Required. The
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery] to create.
        /// </param>
        /// <param name="sampleQueryId">
        /// Required. The ID to use for the
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery], which will
        /// become the final component of the
        /// [SampleQuery.name][google.cloud.discoveryengine.v1beta.SampleQuery.name].
        /// 
        /// If the caller does not have permission to create the
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery], regardless
        /// of whether or not it exists, a `PERMISSION_DENIED` error is returned.
        /// 
        /// This field must be unique among all
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery]s with the
        /// same
        /// [parent][google.cloud.discoveryengine.v1beta.CreateSampleQueryRequest.parent].
        /// Otherwise, an `ALREADY_EXISTS` error is returned.
        /// 
        /// This field must conform to [RFC-1034](https://tools.ietf.org/html/rfc1034)
        /// standard with a length limit of 63 characters. Otherwise, an
        /// `INVALID_ARGUMENT` error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SampleQuery> CreateSampleQueryAsync(string parent, SampleQuery sampleQuery, string sampleQueryId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSampleQueryAsync(new CreateSampleQueryRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SampleQuery = gax::GaxPreconditions.CheckNotNull(sampleQuery, nameof(sampleQuery)),
                SampleQueryId = gax::GaxPreconditions.CheckNotNullOrEmpty(sampleQueryId, nameof(sampleQueryId)),
            }, callSettings);

        /// <summary>
        /// Creates a [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery]
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, such as
        /// `projects/{project}/locations/{location}/sampleQuerySets/{sampleQuerySet}`.
        /// </param>
        /// <param name="sampleQuery">
        /// Required. The
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery] to create.
        /// </param>
        /// <param name="sampleQueryId">
        /// Required. The ID to use for the
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery], which will
        /// become the final component of the
        /// [SampleQuery.name][google.cloud.discoveryengine.v1beta.SampleQuery.name].
        /// 
        /// If the caller does not have permission to create the
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery], regardless
        /// of whether or not it exists, a `PERMISSION_DENIED` error is returned.
        /// 
        /// This field must be unique among all
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery]s with the
        /// same
        /// [parent][google.cloud.discoveryengine.v1beta.CreateSampleQueryRequest.parent].
        /// Otherwise, an `ALREADY_EXISTS` error is returned.
        /// 
        /// This field must conform to [RFC-1034](https://tools.ietf.org/html/rfc1034)
        /// standard with a length limit of 63 characters. Otherwise, an
        /// `INVALID_ARGUMENT` error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SampleQuery> CreateSampleQueryAsync(string parent, SampleQuery sampleQuery, string sampleQueryId, st::CancellationToken cancellationToken) =>
            CreateSampleQueryAsync(parent, sampleQuery, sampleQueryId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery]
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, such as
        /// `projects/{project}/locations/{location}/sampleQuerySets/{sampleQuerySet}`.
        /// </param>
        /// <param name="sampleQuery">
        /// Required. The
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery] to create.
        /// </param>
        /// <param name="sampleQueryId">
        /// Required. The ID to use for the
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery], which will
        /// become the final component of the
        /// [SampleQuery.name][google.cloud.discoveryengine.v1beta.SampleQuery.name].
        /// 
        /// If the caller does not have permission to create the
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery], regardless
        /// of whether or not it exists, a `PERMISSION_DENIED` error is returned.
        /// 
        /// This field must be unique among all
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery]s with the
        /// same
        /// [parent][google.cloud.discoveryengine.v1beta.CreateSampleQueryRequest.parent].
        /// Otherwise, an `ALREADY_EXISTS` error is returned.
        /// 
        /// This field must conform to [RFC-1034](https://tools.ietf.org/html/rfc1034)
        /// standard with a length limit of 63 characters. Otherwise, an
        /// `INVALID_ARGUMENT` error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SampleQuery CreateSampleQuery(SampleQuerySetName parent, SampleQuery sampleQuery, string sampleQueryId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSampleQuery(new CreateSampleQueryRequest
            {
                ParentAsSampleQuerySetName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SampleQuery = gax::GaxPreconditions.CheckNotNull(sampleQuery, nameof(sampleQuery)),
                SampleQueryId = gax::GaxPreconditions.CheckNotNullOrEmpty(sampleQueryId, nameof(sampleQueryId)),
            }, callSettings);

        /// <summary>
        /// Creates a [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery]
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, such as
        /// `projects/{project}/locations/{location}/sampleQuerySets/{sampleQuerySet}`.
        /// </param>
        /// <param name="sampleQuery">
        /// Required. The
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery] to create.
        /// </param>
        /// <param name="sampleQueryId">
        /// Required. The ID to use for the
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery], which will
        /// become the final component of the
        /// [SampleQuery.name][google.cloud.discoveryengine.v1beta.SampleQuery.name].
        /// 
        /// If the caller does not have permission to create the
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery], regardless
        /// of whether or not it exists, a `PERMISSION_DENIED` error is returned.
        /// 
        /// This field must be unique among all
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery]s with the
        /// same
        /// [parent][google.cloud.discoveryengine.v1beta.CreateSampleQueryRequest.parent].
        /// Otherwise, an `ALREADY_EXISTS` error is returned.
        /// 
        /// This field must conform to [RFC-1034](https://tools.ietf.org/html/rfc1034)
        /// standard with a length limit of 63 characters. Otherwise, an
        /// `INVALID_ARGUMENT` error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SampleQuery> CreateSampleQueryAsync(SampleQuerySetName parent, SampleQuery sampleQuery, string sampleQueryId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSampleQueryAsync(new CreateSampleQueryRequest
            {
                ParentAsSampleQuerySetName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SampleQuery = gax::GaxPreconditions.CheckNotNull(sampleQuery, nameof(sampleQuery)),
                SampleQueryId = gax::GaxPreconditions.CheckNotNullOrEmpty(sampleQueryId, nameof(sampleQueryId)),
            }, callSettings);

        /// <summary>
        /// Creates a [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery]
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, such as
        /// `projects/{project}/locations/{location}/sampleQuerySets/{sampleQuerySet}`.
        /// </param>
        /// <param name="sampleQuery">
        /// Required. The
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery] to create.
        /// </param>
        /// <param name="sampleQueryId">
        /// Required. The ID to use for the
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery], which will
        /// become the final component of the
        /// [SampleQuery.name][google.cloud.discoveryengine.v1beta.SampleQuery.name].
        /// 
        /// If the caller does not have permission to create the
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery], regardless
        /// of whether or not it exists, a `PERMISSION_DENIED` error is returned.
        /// 
        /// This field must be unique among all
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery]s with the
        /// same
        /// [parent][google.cloud.discoveryengine.v1beta.CreateSampleQueryRequest.parent].
        /// Otherwise, an `ALREADY_EXISTS` error is returned.
        /// 
        /// This field must conform to [RFC-1034](https://tools.ietf.org/html/rfc1034)
        /// standard with a length limit of 63 characters. Otherwise, an
        /// `INVALID_ARGUMENT` error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SampleQuery> CreateSampleQueryAsync(SampleQuerySetName parent, SampleQuery sampleQuery, string sampleQueryId, st::CancellationToken cancellationToken) =>
            CreateSampleQueryAsync(parent, sampleQuery, sampleQueryId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SampleQuery UpdateSampleQuery(UpdateSampleQueryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SampleQuery> UpdateSampleQueryAsync(UpdateSampleQueryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SampleQuery> UpdateSampleQueryAsync(UpdateSampleQueryRequest request, st::CancellationToken cancellationToken) =>
            UpdateSampleQueryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery].
        /// </summary>
        /// <param name="sampleQuery">
        /// Required. The simple query to update.
        /// 
        /// If the caller does not have permission to update the
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery], regardless
        /// of whether or not it exists, a `PERMISSION_DENIED` error is returned.
        /// 
        /// If the [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery] to
        /// update does not exist a `NOT_FOUND` error is returned.
        /// </param>
        /// <param name="updateMask">
        /// Indicates which fields in the provided imported 'simple query' to update.
        /// If not set, will by default update all fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SampleQuery UpdateSampleQuery(SampleQuery sampleQuery, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSampleQuery(new UpdateSampleQueryRequest
            {
                SampleQuery = gax::GaxPreconditions.CheckNotNull(sampleQuery, nameof(sampleQuery)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery].
        /// </summary>
        /// <param name="sampleQuery">
        /// Required. The simple query to update.
        /// 
        /// If the caller does not have permission to update the
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery], regardless
        /// of whether or not it exists, a `PERMISSION_DENIED` error is returned.
        /// 
        /// If the [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery] to
        /// update does not exist a `NOT_FOUND` error is returned.
        /// </param>
        /// <param name="updateMask">
        /// Indicates which fields in the provided imported 'simple query' to update.
        /// If not set, will by default update all fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SampleQuery> UpdateSampleQueryAsync(SampleQuery sampleQuery, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSampleQueryAsync(new UpdateSampleQueryRequest
            {
                SampleQuery = gax::GaxPreconditions.CheckNotNull(sampleQuery, nameof(sampleQuery)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery].
        /// </summary>
        /// <param name="sampleQuery">
        /// Required. The simple query to update.
        /// 
        /// If the caller does not have permission to update the
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery], regardless
        /// of whether or not it exists, a `PERMISSION_DENIED` error is returned.
        /// 
        /// If the [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery] to
        /// update does not exist a `NOT_FOUND` error is returned.
        /// </param>
        /// <param name="updateMask">
        /// Indicates which fields in the provided imported 'simple query' to update.
        /// If not set, will by default update all fields.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SampleQuery> UpdateSampleQueryAsync(SampleQuery sampleQuery, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSampleQueryAsync(sampleQuery, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSampleQuery(DeleteSampleQueryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSampleQueryAsync(DeleteSampleQueryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSampleQueryAsync(DeleteSampleQueryRequest request, st::CancellationToken cancellationToken) =>
            DeleteSampleQueryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery], such as
        /// `projects/{project}/locations/{location}/sampleQuerySets/{sample_query_set}/sampleQueries/{sample_query}`.
        /// 
        /// If the caller does not have permission to delete the
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery], regardless
        /// of whether or not it exists, a `PERMISSION_DENIED` error is returned.
        /// 
        /// If the [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery] to
        /// delete does not exist, a `NOT_FOUND` error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSampleQuery(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSampleQuery(new DeleteSampleQueryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery], such as
        /// `projects/{project}/locations/{location}/sampleQuerySets/{sample_query_set}/sampleQueries/{sample_query}`.
        /// 
        /// If the caller does not have permission to delete the
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery], regardless
        /// of whether or not it exists, a `PERMISSION_DENIED` error is returned.
        /// 
        /// If the [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery] to
        /// delete does not exist, a `NOT_FOUND` error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSampleQueryAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSampleQueryAsync(new DeleteSampleQueryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery], such as
        /// `projects/{project}/locations/{location}/sampleQuerySets/{sample_query_set}/sampleQueries/{sample_query}`.
        /// 
        /// If the caller does not have permission to delete the
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery], regardless
        /// of whether or not it exists, a `PERMISSION_DENIED` error is returned.
        /// 
        /// If the [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery] to
        /// delete does not exist, a `NOT_FOUND` error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSampleQueryAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteSampleQueryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery], such as
        /// `projects/{project}/locations/{location}/sampleQuerySets/{sample_query_set}/sampleQueries/{sample_query}`.
        /// 
        /// If the caller does not have permission to delete the
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery], regardless
        /// of whether or not it exists, a `PERMISSION_DENIED` error is returned.
        /// 
        /// If the [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery] to
        /// delete does not exist, a `NOT_FOUND` error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSampleQuery(SampleQueryName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSampleQuery(new DeleteSampleQueryRequest
            {
                SampleQueryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery], such as
        /// `projects/{project}/locations/{location}/sampleQuerySets/{sample_query_set}/sampleQueries/{sample_query}`.
        /// 
        /// If the caller does not have permission to delete the
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery], regardless
        /// of whether or not it exists, a `PERMISSION_DENIED` error is returned.
        /// 
        /// If the [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery] to
        /// delete does not exist, a `NOT_FOUND` error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSampleQueryAsync(SampleQueryName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSampleQueryAsync(new DeleteSampleQueryRequest
            {
                SampleQueryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery], such as
        /// `projects/{project}/locations/{location}/sampleQuerySets/{sample_query_set}/sampleQueries/{sample_query}`.
        /// 
        /// If the caller does not have permission to delete the
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery], regardless
        /// of whether or not it exists, a `PERMISSION_DENIED` error is returned.
        /// 
        /// If the [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery] to
        /// delete does not exist, a `NOT_FOUND` error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSampleQueryAsync(SampleQueryName name, st::CancellationToken cancellationToken) =>
            DeleteSampleQueryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Bulk import of multiple
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery]s. Sample
        /// queries that already exist may be deleted.
        /// 
        /// Note: It is possible for a subset of the
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery]s to be
        /// successfully imported.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportSampleQueriesResponse, ImportSampleQueriesMetadata> ImportSampleQueries(ImportSampleQueriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Bulk import of multiple
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery]s. Sample
        /// queries that already exist may be deleted.
        /// 
        /// Note: It is possible for a subset of the
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery]s to be
        /// successfully imported.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportSampleQueriesResponse, ImportSampleQueriesMetadata>> ImportSampleQueriesAsync(ImportSampleQueriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Bulk import of multiple
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery]s. Sample
        /// queries that already exist may be deleted.
        /// 
        /// Note: It is possible for a subset of the
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery]s to be
        /// successfully imported.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportSampleQueriesResponse, ImportSampleQueriesMetadata>> ImportSampleQueriesAsync(ImportSampleQueriesRequest request, st::CancellationToken cancellationToken) =>
            ImportSampleQueriesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ImportSampleQueries</c>.</summary>
        public virtual lro::OperationsClient ImportSampleQueriesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ImportSampleQueries</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ImportSampleQueriesResponse, ImportSampleQueriesMetadata> PollOnceImportSampleQueries(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportSampleQueriesResponse, ImportSampleQueriesMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportSampleQueriesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ImportSampleQueries</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ImportSampleQueriesResponse, ImportSampleQueriesMetadata>> PollOnceImportSampleQueriesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportSampleQueriesResponse, ImportSampleQueriesMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportSampleQueriesOperationsClient, callSettings);
    }

    /// <summary>SampleQueryService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing
    /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery]s,
    /// </remarks>
    public sealed partial class SampleQueryServiceClientImpl : SampleQueryServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetSampleQueryRequest, SampleQuery> _callGetSampleQuery;

        private readonly gaxgrpc::ApiCall<ListSampleQueriesRequest, ListSampleQueriesResponse> _callListSampleQueries;

        private readonly gaxgrpc::ApiCall<CreateSampleQueryRequest, SampleQuery> _callCreateSampleQuery;

        private readonly gaxgrpc::ApiCall<UpdateSampleQueryRequest, SampleQuery> _callUpdateSampleQuery;

        private readonly gaxgrpc::ApiCall<DeleteSampleQueryRequest, wkt::Empty> _callDeleteSampleQuery;

        private readonly gaxgrpc::ApiCall<ImportSampleQueriesRequest, lro::Operation> _callImportSampleQueries;

        /// <summary>
        /// Constructs a client wrapper for the SampleQueryService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SampleQueryServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public SampleQueryServiceClientImpl(SampleQueryService.SampleQueryServiceClient grpcClient, SampleQueryServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            SampleQueryServiceSettings effectiveSettings = settings ?? SampleQueryServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            ImportSampleQueriesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ImportSampleQueriesOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callGetSampleQuery = clientHelper.BuildApiCall<GetSampleQueryRequest, SampleQuery>("GetSampleQuery", grpcClient.GetSampleQueryAsync, grpcClient.GetSampleQuery, effectiveSettings.GetSampleQuerySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSampleQuery);
            Modify_GetSampleQueryApiCall(ref _callGetSampleQuery);
            _callListSampleQueries = clientHelper.BuildApiCall<ListSampleQueriesRequest, ListSampleQueriesResponse>("ListSampleQueries", grpcClient.ListSampleQueriesAsync, grpcClient.ListSampleQueries, effectiveSettings.ListSampleQueriesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSampleQueries);
            Modify_ListSampleQueriesApiCall(ref _callListSampleQueries);
            _callCreateSampleQuery = clientHelper.BuildApiCall<CreateSampleQueryRequest, SampleQuery>("CreateSampleQuery", grpcClient.CreateSampleQueryAsync, grpcClient.CreateSampleQuery, effectiveSettings.CreateSampleQuerySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSampleQuery);
            Modify_CreateSampleQueryApiCall(ref _callCreateSampleQuery);
            _callUpdateSampleQuery = clientHelper.BuildApiCall<UpdateSampleQueryRequest, SampleQuery>("UpdateSampleQuery", grpcClient.UpdateSampleQueryAsync, grpcClient.UpdateSampleQuery, effectiveSettings.UpdateSampleQuerySettings).WithGoogleRequestParam("sample_query.name", request => request.SampleQuery?.Name);
            Modify_ApiCall(ref _callUpdateSampleQuery);
            Modify_UpdateSampleQueryApiCall(ref _callUpdateSampleQuery);
            _callDeleteSampleQuery = clientHelper.BuildApiCall<DeleteSampleQueryRequest, wkt::Empty>("DeleteSampleQuery", grpcClient.DeleteSampleQueryAsync, grpcClient.DeleteSampleQuery, effectiveSettings.DeleteSampleQuerySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteSampleQuery);
            Modify_DeleteSampleQueryApiCall(ref _callDeleteSampleQuery);
            _callImportSampleQueries = clientHelper.BuildApiCall<ImportSampleQueriesRequest, lro::Operation>("ImportSampleQueries", grpcClient.ImportSampleQueriesAsync, grpcClient.ImportSampleQueries, effectiveSettings.ImportSampleQueriesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callImportSampleQueries);
            Modify_ImportSampleQueriesApiCall(ref _callImportSampleQueries);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetSampleQueryApiCall(ref gaxgrpc::ApiCall<GetSampleQueryRequest, SampleQuery> call);

        partial void Modify_ListSampleQueriesApiCall(ref gaxgrpc::ApiCall<ListSampleQueriesRequest, ListSampleQueriesResponse> call);

        partial void Modify_CreateSampleQueryApiCall(ref gaxgrpc::ApiCall<CreateSampleQueryRequest, SampleQuery> call);

        partial void Modify_UpdateSampleQueryApiCall(ref gaxgrpc::ApiCall<UpdateSampleQueryRequest, SampleQuery> call);

        partial void Modify_DeleteSampleQueryApiCall(ref gaxgrpc::ApiCall<DeleteSampleQueryRequest, wkt::Empty> call);

        partial void Modify_ImportSampleQueriesApiCall(ref gaxgrpc::ApiCall<ImportSampleQueriesRequest, lro::Operation> call);

        partial void OnConstruction(SampleQueryService.SampleQueryServiceClient grpcClient, SampleQueryServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SampleQueryService client</summary>
        public override SampleQueryService.SampleQueryServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_GetSampleQueryRequest(ref GetSampleQueryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSampleQueriesRequest(ref ListSampleQueriesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateSampleQueryRequest(ref CreateSampleQueryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSampleQueryRequest(ref UpdateSampleQueryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSampleQueryRequest(ref DeleteSampleQueryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ImportSampleQueriesRequest(ref ImportSampleQueriesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets a [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SampleQuery GetSampleQuery(GetSampleQueryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSampleQueryRequest(ref request, ref callSettings);
            return _callGetSampleQuery.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SampleQuery> GetSampleQueryAsync(GetSampleQueryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSampleQueryRequest(ref request, ref callSettings);
            return _callGetSampleQuery.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a list of
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery]s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SampleQuery"/> resources.</returns>
        public override gax::PagedEnumerable<ListSampleQueriesResponse, SampleQuery> ListSampleQueries(ListSampleQueriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSampleQueriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSampleQueriesRequest, ListSampleQueriesResponse, SampleQuery>(_callListSampleQueries, request, callSettings);
        }

        /// <summary>
        /// Gets a list of
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery]s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SampleQuery"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSampleQueriesResponse, SampleQuery> ListSampleQueriesAsync(ListSampleQueriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSampleQueriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSampleQueriesRequest, ListSampleQueriesResponse, SampleQuery>(_callListSampleQueries, request, callSettings);
        }

        /// <summary>
        /// Creates a [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SampleQuery CreateSampleQuery(CreateSampleQueryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSampleQueryRequest(ref request, ref callSettings);
            return _callCreateSampleQuery.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SampleQuery> CreateSampleQueryAsync(CreateSampleQueryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSampleQueryRequest(ref request, ref callSettings);
            return _callCreateSampleQuery.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SampleQuery UpdateSampleQuery(UpdateSampleQueryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSampleQueryRequest(ref request, ref callSettings);
            return _callUpdateSampleQuery.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SampleQuery> UpdateSampleQueryAsync(UpdateSampleQueryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSampleQueryRequest(ref request, ref callSettings);
            return _callUpdateSampleQuery.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteSampleQuery(DeleteSampleQueryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSampleQueryRequest(ref request, ref callSettings);
            _callDeleteSampleQuery.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteSampleQueryAsync(DeleteSampleQueryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSampleQueryRequest(ref request, ref callSettings);
            return _callDeleteSampleQuery.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>ImportSampleQueries</c>.</summary>
        public override lro::OperationsClient ImportSampleQueriesOperationsClient { get; }

        /// <summary>
        /// Bulk import of multiple
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery]s. Sample
        /// queries that already exist may be deleted.
        /// 
        /// Note: It is possible for a subset of the
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery]s to be
        /// successfully imported.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ImportSampleQueriesResponse, ImportSampleQueriesMetadata> ImportSampleQueries(ImportSampleQueriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportSampleQueriesRequest(ref request, ref callSettings);
            return new lro::Operation<ImportSampleQueriesResponse, ImportSampleQueriesMetadata>(_callImportSampleQueries.Sync(request, callSettings), ImportSampleQueriesOperationsClient);
        }

        /// <summary>
        /// Bulk import of multiple
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery]s. Sample
        /// queries that already exist may be deleted.
        /// 
        /// Note: It is possible for a subset of the
        /// [SampleQuery][google.cloud.discoveryengine.v1beta.SampleQuery]s to be
        /// successfully imported.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ImportSampleQueriesResponse, ImportSampleQueriesMetadata>> ImportSampleQueriesAsync(ImportSampleQueriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportSampleQueriesRequest(ref request, ref callSettings);
            return new lro::Operation<ImportSampleQueriesResponse, ImportSampleQueriesMetadata>(await _callImportSampleQueries.Async(request, callSettings).ConfigureAwait(false), ImportSampleQueriesOperationsClient);
        }
    }

    public partial class ListSampleQueriesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSampleQueriesResponse : gaxgrpc::IPageResponse<SampleQuery>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<SampleQuery> GetEnumerator() => SampleQueries.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class SampleQueryService
    {
        public partial class SampleQueryServiceClient
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

    public static partial class SampleQueryService
    {
        public partial class SampleQueryServiceClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="gcl::Locations.LocationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>
            /// A new <see cref="gcl::Locations.LocationsClient"/> for the same target as this client.
            /// </returns>
            public virtual gcl::Locations.LocationsClient CreateLocationsClient() =>
                new gcl::Locations.LocationsClient(CallInvoker);
        }
    }
}
