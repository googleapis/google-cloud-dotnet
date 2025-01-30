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
    /// <summary>Settings for <see cref="SampleQuerySetServiceClient"/> instances.</summary>
    public sealed partial class SampleQuerySetServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SampleQuerySetServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SampleQuerySetServiceSettings"/>.</returns>
        public static SampleQuerySetServiceSettings GetDefault() => new SampleQuerySetServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="SampleQuerySetServiceSettings"/> object with default settings.
        /// </summary>
        public SampleQuerySetServiceSettings()
        {
        }

        private SampleQuerySetServiceSettings(SampleQuerySetServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetSampleQuerySetSettings = existing.GetSampleQuerySetSettings;
            ListSampleQuerySetsSettings = existing.ListSampleQuerySetsSettings;
            CreateSampleQuerySetSettings = existing.CreateSampleQuerySetSettings;
            UpdateSampleQuerySetSettings = existing.UpdateSampleQuerySetSettings;
            DeleteSampleQuerySetSettings = existing.DeleteSampleQuerySetSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SampleQuerySetServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SampleQuerySetServiceClient.GetSampleQuerySet</c> and
        /// <c>SampleQuerySetServiceClient.GetSampleQuerySetAsync</c>.
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
        public gaxgrpc::CallSettings GetSampleQuerySetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SampleQuerySetServiceClient.ListSampleQuerySets</c> and
        /// <c>SampleQuerySetServiceClient.ListSampleQuerySetsAsync</c>.
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
        public gaxgrpc::CallSettings ListSampleQuerySetsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SampleQuerySetServiceClient.CreateSampleQuerySet</c> and
        /// <c>SampleQuerySetServiceClient.CreateSampleQuerySetAsync</c>.
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
        public gaxgrpc::CallSettings CreateSampleQuerySetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SampleQuerySetServiceClient.UpdateSampleQuerySet</c> and
        /// <c>SampleQuerySetServiceClient.UpdateSampleQuerySetAsync</c>.
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
        public gaxgrpc::CallSettings UpdateSampleQuerySetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SampleQuerySetServiceClient.DeleteSampleQuerySet</c> and
        /// <c>SampleQuerySetServiceClient.DeleteSampleQuerySetAsync</c>.
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
        public gaxgrpc::CallSettings DeleteSampleQuerySetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SampleQuerySetServiceSettings"/> object.</returns>
        public SampleQuerySetServiceSettings Clone() => new SampleQuerySetServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SampleQuerySetServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class SampleQuerySetServiceClientBuilder : gaxgrpc::ClientBuilderBase<SampleQuerySetServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SampleQuerySetServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SampleQuerySetServiceClientBuilder() : base(SampleQuerySetServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref SampleQuerySetServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SampleQuerySetServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SampleQuerySetServiceClient Build()
        {
            SampleQuerySetServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SampleQuerySetServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SampleQuerySetServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SampleQuerySetServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SampleQuerySetServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<SampleQuerySetServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SampleQuerySetServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SampleQuerySetServiceClient.ChannelPool;
    }

    /// <summary>SampleQuerySetService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing
    /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet]s,
    /// </remarks>
    public abstract partial class SampleQuerySetServiceClient
    {
        /// <summary>
        /// The default endpoint for the SampleQuerySetService service, which is a host of
        /// "discoveryengine.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "discoveryengine.googleapis.com:443";

        /// <summary>The default SampleQuerySetService scopes.</summary>
        /// <remarks>
        /// The default SampleQuerySetService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(SampleQuerySetService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="SampleQuerySetServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="SampleQuerySetServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SampleQuerySetServiceClient"/>.</returns>
        public static stt::Task<SampleQuerySetServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SampleQuerySetServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SampleQuerySetServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="SampleQuerySetServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SampleQuerySetServiceClient"/>.</returns>
        public static SampleQuerySetServiceClient Create() => new SampleQuerySetServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SampleQuerySetServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SampleQuerySetServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="SampleQuerySetServiceClient"/>.</returns>
        internal static SampleQuerySetServiceClient Create(grpccore::CallInvoker callInvoker, SampleQuerySetServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SampleQuerySetService.SampleQuerySetServiceClient grpcClient = new SampleQuerySetService.SampleQuerySetServiceClient(callInvoker);
            return new SampleQuerySetServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC SampleQuerySetService client</summary>
        public virtual SampleQuerySetService.SampleQuerySetServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SampleQuerySet GetSampleQuerySet(GetSampleQuerySetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SampleQuerySet> GetSampleQuerySetAsync(GetSampleQuerySetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SampleQuerySet> GetSampleQuerySetAsync(GetSampleQuerySetRequest request, st::CancellationToken cancellationToken) =>
            GetSampleQuerySetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet], such
        /// as
        /// `projects/{project}/locations/{location}/sampleQuerySets/{sample_query_set}`.
        /// 
        /// If the caller does not have permission to access the
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet],
        /// regardless of whether or not it exists, a PERMISSION_DENIED error is
        /// returned.
        /// 
        /// If the requested
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet] does
        /// not exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SampleQuerySet GetSampleQuerySet(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSampleQuerySet(new GetSampleQuerySetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet], such
        /// as
        /// `projects/{project}/locations/{location}/sampleQuerySets/{sample_query_set}`.
        /// 
        /// If the caller does not have permission to access the
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet],
        /// regardless of whether or not it exists, a PERMISSION_DENIED error is
        /// returned.
        /// 
        /// If the requested
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet] does
        /// not exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SampleQuerySet> GetSampleQuerySetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSampleQuerySetAsync(new GetSampleQuerySetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet], such
        /// as
        /// `projects/{project}/locations/{location}/sampleQuerySets/{sample_query_set}`.
        /// 
        /// If the caller does not have permission to access the
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet],
        /// regardless of whether or not it exists, a PERMISSION_DENIED error is
        /// returned.
        /// 
        /// If the requested
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet] does
        /// not exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SampleQuerySet> GetSampleQuerySetAsync(string name, st::CancellationToken cancellationToken) =>
            GetSampleQuerySetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet], such
        /// as
        /// `projects/{project}/locations/{location}/sampleQuerySets/{sample_query_set}`.
        /// 
        /// If the caller does not have permission to access the
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet],
        /// regardless of whether or not it exists, a PERMISSION_DENIED error is
        /// returned.
        /// 
        /// If the requested
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet] does
        /// not exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SampleQuerySet GetSampleQuerySet(SampleQuerySetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSampleQuerySet(new GetSampleQuerySetRequest
            {
                SampleQuerySetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet], such
        /// as
        /// `projects/{project}/locations/{location}/sampleQuerySets/{sample_query_set}`.
        /// 
        /// If the caller does not have permission to access the
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet],
        /// regardless of whether or not it exists, a PERMISSION_DENIED error is
        /// returned.
        /// 
        /// If the requested
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet] does
        /// not exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SampleQuerySet> GetSampleQuerySetAsync(SampleQuerySetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSampleQuerySetAsync(new GetSampleQuerySetRequest
            {
                SampleQuerySetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet], such
        /// as
        /// `projects/{project}/locations/{location}/sampleQuerySets/{sample_query_set}`.
        /// 
        /// If the caller does not have permission to access the
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet],
        /// regardless of whether or not it exists, a PERMISSION_DENIED error is
        /// returned.
        /// 
        /// If the requested
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet] does
        /// not exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SampleQuerySet> GetSampleQuerySetAsync(SampleQuerySetName name, st::CancellationToken cancellationToken) =>
            GetSampleQuerySetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a list of
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet]s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SampleQuerySet"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSampleQuerySetsResponse, SampleQuerySet> ListSampleQuerySets(ListSampleQuerySetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a list of
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet]s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SampleQuerySet"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSampleQuerySetsResponse, SampleQuerySet> ListSampleQuerySetsAsync(ListSampleQuerySetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a list of
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet]s.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location resource name, such as
        /// `projects/{project}/locations/{location}`.
        /// 
        /// If the caller does not have permission to list
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet]s under
        /// this location, regardless of whether or not this location exists, a
        /// `PERMISSION_DENIED` error is returned.
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
        /// <returns>A pageable sequence of <see cref="SampleQuerySet"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSampleQuerySetsResponse, SampleQuerySet> ListSampleQuerySets(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSampleQuerySetsRequest request = new ListSampleQuerySetsRequest
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
            return ListSampleQuerySets(request, callSettings);
        }

        /// <summary>
        /// Gets a list of
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet]s.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location resource name, such as
        /// `projects/{project}/locations/{location}`.
        /// 
        /// If the caller does not have permission to list
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet]s under
        /// this location, regardless of whether or not this location exists, a
        /// `PERMISSION_DENIED` error is returned.
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
        /// <returns>A pageable asynchronous sequence of <see cref="SampleQuerySet"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSampleQuerySetsResponse, SampleQuerySet> ListSampleQuerySetsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSampleQuerySetsRequest request = new ListSampleQuerySetsRequest
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
            return ListSampleQuerySetsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a list of
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet]s.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location resource name, such as
        /// `projects/{project}/locations/{location}`.
        /// 
        /// If the caller does not have permission to list
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet]s under
        /// this location, regardless of whether or not this location exists, a
        /// `PERMISSION_DENIED` error is returned.
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
        /// <returns>A pageable sequence of <see cref="SampleQuerySet"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSampleQuerySetsResponse, SampleQuerySet> ListSampleQuerySets(LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSampleQuerySetsRequest request = new ListSampleQuerySetsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSampleQuerySets(request, callSettings);
        }

        /// <summary>
        /// Gets a list of
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet]s.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location resource name, such as
        /// `projects/{project}/locations/{location}`.
        /// 
        /// If the caller does not have permission to list
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet]s under
        /// this location, regardless of whether or not this location exists, a
        /// `PERMISSION_DENIED` error is returned.
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
        /// <returns>A pageable asynchronous sequence of <see cref="SampleQuerySet"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSampleQuerySetsResponse, SampleQuerySet> ListSampleQuerySetsAsync(LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSampleQuerySetsRequest request = new ListSampleQuerySetsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSampleQuerySetsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SampleQuerySet CreateSampleQuerySet(CreateSampleQuerySetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SampleQuerySet> CreateSampleQuerySetAsync(CreateSampleQuerySetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SampleQuerySet> CreateSampleQuerySetAsync(CreateSampleQuerySetRequest request, st::CancellationToken cancellationToken) =>
            CreateSampleQuerySetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet]
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, such as
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="sampleQuerySet">
        /// Required. The
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet] to
        /// create.
        /// </param>
        /// <param name="sampleQuerySetId">
        /// Required. The ID to use for the
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet], which
        /// will become the final component of the
        /// [SampleQuerySet.name][google.cloud.discoveryengine.v1beta.SampleQuerySet.name].
        /// 
        /// If the caller does not have permission to create the
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet],
        /// regardless of whether or not it exists, a `PERMISSION_DENIED` error is
        /// returned.
        /// 
        /// This field must be unique among all
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet]s with
        /// the same
        /// [parent][google.cloud.discoveryengine.v1beta.CreateSampleQuerySetRequest.parent].
        /// Otherwise, an `ALREADY_EXISTS` error is returned.
        /// 
        /// This field must conform to [RFC-1034](https://tools.ietf.org/html/rfc1034)
        /// standard with a length limit of 63 characters. Otherwise, an
        /// `INVALID_ARGUMENT` error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SampleQuerySet CreateSampleQuerySet(string parent, SampleQuerySet sampleQuerySet, string sampleQuerySetId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSampleQuerySet(new CreateSampleQuerySetRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SampleQuerySet = gax::GaxPreconditions.CheckNotNull(sampleQuerySet, nameof(sampleQuerySet)),
                SampleQuerySetId = gax::GaxPreconditions.CheckNotNullOrEmpty(sampleQuerySetId, nameof(sampleQuerySetId)),
            }, callSettings);

        /// <summary>
        /// Creates a
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet]
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, such as
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="sampleQuerySet">
        /// Required. The
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet] to
        /// create.
        /// </param>
        /// <param name="sampleQuerySetId">
        /// Required. The ID to use for the
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet], which
        /// will become the final component of the
        /// [SampleQuerySet.name][google.cloud.discoveryengine.v1beta.SampleQuerySet.name].
        /// 
        /// If the caller does not have permission to create the
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet],
        /// regardless of whether or not it exists, a `PERMISSION_DENIED` error is
        /// returned.
        /// 
        /// This field must be unique among all
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet]s with
        /// the same
        /// [parent][google.cloud.discoveryengine.v1beta.CreateSampleQuerySetRequest.parent].
        /// Otherwise, an `ALREADY_EXISTS` error is returned.
        /// 
        /// This field must conform to [RFC-1034](https://tools.ietf.org/html/rfc1034)
        /// standard with a length limit of 63 characters. Otherwise, an
        /// `INVALID_ARGUMENT` error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SampleQuerySet> CreateSampleQuerySetAsync(string parent, SampleQuerySet sampleQuerySet, string sampleQuerySetId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSampleQuerySetAsync(new CreateSampleQuerySetRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SampleQuerySet = gax::GaxPreconditions.CheckNotNull(sampleQuerySet, nameof(sampleQuerySet)),
                SampleQuerySetId = gax::GaxPreconditions.CheckNotNullOrEmpty(sampleQuerySetId, nameof(sampleQuerySetId)),
            }, callSettings);

        /// <summary>
        /// Creates a
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet]
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, such as
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="sampleQuerySet">
        /// Required. The
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet] to
        /// create.
        /// </param>
        /// <param name="sampleQuerySetId">
        /// Required. The ID to use for the
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet], which
        /// will become the final component of the
        /// [SampleQuerySet.name][google.cloud.discoveryengine.v1beta.SampleQuerySet.name].
        /// 
        /// If the caller does not have permission to create the
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet],
        /// regardless of whether or not it exists, a `PERMISSION_DENIED` error is
        /// returned.
        /// 
        /// This field must be unique among all
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet]s with
        /// the same
        /// [parent][google.cloud.discoveryengine.v1beta.CreateSampleQuerySetRequest.parent].
        /// Otherwise, an `ALREADY_EXISTS` error is returned.
        /// 
        /// This field must conform to [RFC-1034](https://tools.ietf.org/html/rfc1034)
        /// standard with a length limit of 63 characters. Otherwise, an
        /// `INVALID_ARGUMENT` error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SampleQuerySet> CreateSampleQuerySetAsync(string parent, SampleQuerySet sampleQuerySet, string sampleQuerySetId, st::CancellationToken cancellationToken) =>
            CreateSampleQuerySetAsync(parent, sampleQuerySet, sampleQuerySetId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet]
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, such as
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="sampleQuerySet">
        /// Required. The
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet] to
        /// create.
        /// </param>
        /// <param name="sampleQuerySetId">
        /// Required. The ID to use for the
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet], which
        /// will become the final component of the
        /// [SampleQuerySet.name][google.cloud.discoveryengine.v1beta.SampleQuerySet.name].
        /// 
        /// If the caller does not have permission to create the
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet],
        /// regardless of whether or not it exists, a `PERMISSION_DENIED` error is
        /// returned.
        /// 
        /// This field must be unique among all
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet]s with
        /// the same
        /// [parent][google.cloud.discoveryengine.v1beta.CreateSampleQuerySetRequest.parent].
        /// Otherwise, an `ALREADY_EXISTS` error is returned.
        /// 
        /// This field must conform to [RFC-1034](https://tools.ietf.org/html/rfc1034)
        /// standard with a length limit of 63 characters. Otherwise, an
        /// `INVALID_ARGUMENT` error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SampleQuerySet CreateSampleQuerySet(LocationName parent, SampleQuerySet sampleQuerySet, string sampleQuerySetId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSampleQuerySet(new CreateSampleQuerySetRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SampleQuerySet = gax::GaxPreconditions.CheckNotNull(sampleQuerySet, nameof(sampleQuerySet)),
                SampleQuerySetId = gax::GaxPreconditions.CheckNotNullOrEmpty(sampleQuerySetId, nameof(sampleQuerySetId)),
            }, callSettings);

        /// <summary>
        /// Creates a
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet]
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, such as
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="sampleQuerySet">
        /// Required. The
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet] to
        /// create.
        /// </param>
        /// <param name="sampleQuerySetId">
        /// Required. The ID to use for the
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet], which
        /// will become the final component of the
        /// [SampleQuerySet.name][google.cloud.discoveryengine.v1beta.SampleQuerySet.name].
        /// 
        /// If the caller does not have permission to create the
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet],
        /// regardless of whether or not it exists, a `PERMISSION_DENIED` error is
        /// returned.
        /// 
        /// This field must be unique among all
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet]s with
        /// the same
        /// [parent][google.cloud.discoveryengine.v1beta.CreateSampleQuerySetRequest.parent].
        /// Otherwise, an `ALREADY_EXISTS` error is returned.
        /// 
        /// This field must conform to [RFC-1034](https://tools.ietf.org/html/rfc1034)
        /// standard with a length limit of 63 characters. Otherwise, an
        /// `INVALID_ARGUMENT` error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SampleQuerySet> CreateSampleQuerySetAsync(LocationName parent, SampleQuerySet sampleQuerySet, string sampleQuerySetId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSampleQuerySetAsync(new CreateSampleQuerySetRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SampleQuerySet = gax::GaxPreconditions.CheckNotNull(sampleQuerySet, nameof(sampleQuerySet)),
                SampleQuerySetId = gax::GaxPreconditions.CheckNotNullOrEmpty(sampleQuerySetId, nameof(sampleQuerySetId)),
            }, callSettings);

        /// <summary>
        /// Creates a
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet]
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, such as
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="sampleQuerySet">
        /// Required. The
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet] to
        /// create.
        /// </param>
        /// <param name="sampleQuerySetId">
        /// Required. The ID to use for the
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet], which
        /// will become the final component of the
        /// [SampleQuerySet.name][google.cloud.discoveryengine.v1beta.SampleQuerySet.name].
        /// 
        /// If the caller does not have permission to create the
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet],
        /// regardless of whether or not it exists, a `PERMISSION_DENIED` error is
        /// returned.
        /// 
        /// This field must be unique among all
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet]s with
        /// the same
        /// [parent][google.cloud.discoveryengine.v1beta.CreateSampleQuerySetRequest.parent].
        /// Otherwise, an `ALREADY_EXISTS` error is returned.
        /// 
        /// This field must conform to [RFC-1034](https://tools.ietf.org/html/rfc1034)
        /// standard with a length limit of 63 characters. Otherwise, an
        /// `INVALID_ARGUMENT` error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SampleQuerySet> CreateSampleQuerySetAsync(LocationName parent, SampleQuerySet sampleQuerySet, string sampleQuerySetId, st::CancellationToken cancellationToken) =>
            CreateSampleQuerySetAsync(parent, sampleQuerySet, sampleQuerySetId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SampleQuerySet UpdateSampleQuerySet(UpdateSampleQuerySetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SampleQuerySet> UpdateSampleQuerySetAsync(UpdateSampleQuerySetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SampleQuerySet> UpdateSampleQuerySetAsync(UpdateSampleQuerySetRequest request, st::CancellationToken cancellationToken) =>
            UpdateSampleQuerySetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet].
        /// </summary>
        /// <param name="sampleQuerySet">
        /// Required. The sample query set to update.
        /// 
        /// If the caller does not have permission to update the
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet],
        /// regardless of whether or not it exists, a `PERMISSION_DENIED` error is
        /// returned.
        /// 
        /// If the [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet]
        /// to update does not exist a `NOT_FOUND` error is returned.
        /// </param>
        /// <param name="updateMask">
        /// Indicates which fields in the provided imported 'sample query set' to
        /// update. If not set, will by default update all fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SampleQuerySet UpdateSampleQuerySet(SampleQuerySet sampleQuerySet, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSampleQuerySet(new UpdateSampleQuerySetRequest
            {
                SampleQuerySet = gax::GaxPreconditions.CheckNotNull(sampleQuerySet, nameof(sampleQuerySet)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet].
        /// </summary>
        /// <param name="sampleQuerySet">
        /// Required. The sample query set to update.
        /// 
        /// If the caller does not have permission to update the
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet],
        /// regardless of whether or not it exists, a `PERMISSION_DENIED` error is
        /// returned.
        /// 
        /// If the [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet]
        /// to update does not exist a `NOT_FOUND` error is returned.
        /// </param>
        /// <param name="updateMask">
        /// Indicates which fields in the provided imported 'sample query set' to
        /// update. If not set, will by default update all fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SampleQuerySet> UpdateSampleQuerySetAsync(SampleQuerySet sampleQuerySet, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSampleQuerySetAsync(new UpdateSampleQuerySetRequest
            {
                SampleQuerySet = gax::GaxPreconditions.CheckNotNull(sampleQuerySet, nameof(sampleQuerySet)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet].
        /// </summary>
        /// <param name="sampleQuerySet">
        /// Required. The sample query set to update.
        /// 
        /// If the caller does not have permission to update the
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet],
        /// regardless of whether or not it exists, a `PERMISSION_DENIED` error is
        /// returned.
        /// 
        /// If the [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet]
        /// to update does not exist a `NOT_FOUND` error is returned.
        /// </param>
        /// <param name="updateMask">
        /// Indicates which fields in the provided imported 'sample query set' to
        /// update. If not set, will by default update all fields.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SampleQuerySet> UpdateSampleQuerySetAsync(SampleQuerySet sampleQuerySet, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSampleQuerySetAsync(sampleQuerySet, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSampleQuerySet(DeleteSampleQuerySetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSampleQuerySetAsync(DeleteSampleQuerySetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSampleQuerySetAsync(DeleteSampleQuerySetRequest request, st::CancellationToken cancellationToken) =>
            DeleteSampleQuerySetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet], such
        /// as
        /// `projects/{project}/locations/{location}/sampleQuerySets/{sample_query_set}`.
        /// 
        /// If the caller does not have permission to delete the
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet],
        /// regardless of whether or not it exists, a `PERMISSION_DENIED` error is
        /// returned.
        /// 
        /// If the [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet]
        /// to delete does not exist, a `NOT_FOUND` error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSampleQuerySet(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSampleQuerySet(new DeleteSampleQuerySetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet], such
        /// as
        /// `projects/{project}/locations/{location}/sampleQuerySets/{sample_query_set}`.
        /// 
        /// If the caller does not have permission to delete the
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet],
        /// regardless of whether or not it exists, a `PERMISSION_DENIED` error is
        /// returned.
        /// 
        /// If the [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet]
        /// to delete does not exist, a `NOT_FOUND` error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSampleQuerySetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSampleQuerySetAsync(new DeleteSampleQuerySetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet], such
        /// as
        /// `projects/{project}/locations/{location}/sampleQuerySets/{sample_query_set}`.
        /// 
        /// If the caller does not have permission to delete the
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet],
        /// regardless of whether or not it exists, a `PERMISSION_DENIED` error is
        /// returned.
        /// 
        /// If the [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet]
        /// to delete does not exist, a `NOT_FOUND` error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSampleQuerySetAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteSampleQuerySetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet], such
        /// as
        /// `projects/{project}/locations/{location}/sampleQuerySets/{sample_query_set}`.
        /// 
        /// If the caller does not have permission to delete the
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet],
        /// regardless of whether or not it exists, a `PERMISSION_DENIED` error is
        /// returned.
        /// 
        /// If the [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet]
        /// to delete does not exist, a `NOT_FOUND` error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSampleQuerySet(SampleQuerySetName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSampleQuerySet(new DeleteSampleQuerySetRequest
            {
                SampleQuerySetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet], such
        /// as
        /// `projects/{project}/locations/{location}/sampleQuerySets/{sample_query_set}`.
        /// 
        /// If the caller does not have permission to delete the
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet],
        /// regardless of whether or not it exists, a `PERMISSION_DENIED` error is
        /// returned.
        /// 
        /// If the [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet]
        /// to delete does not exist, a `NOT_FOUND` error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSampleQuerySetAsync(SampleQuerySetName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSampleQuerySetAsync(new DeleteSampleQuerySetRequest
            {
                SampleQuerySetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet], such
        /// as
        /// `projects/{project}/locations/{location}/sampleQuerySets/{sample_query_set}`.
        /// 
        /// If the caller does not have permission to delete the
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet],
        /// regardless of whether or not it exists, a `PERMISSION_DENIED` error is
        /// returned.
        /// 
        /// If the [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet]
        /// to delete does not exist, a `NOT_FOUND` error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSampleQuerySetAsync(SampleQuerySetName name, st::CancellationToken cancellationToken) =>
            DeleteSampleQuerySetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>SampleQuerySetService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing
    /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet]s,
    /// </remarks>
    public sealed partial class SampleQuerySetServiceClientImpl : SampleQuerySetServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetSampleQuerySetRequest, SampleQuerySet> _callGetSampleQuerySet;

        private readonly gaxgrpc::ApiCall<ListSampleQuerySetsRequest, ListSampleQuerySetsResponse> _callListSampleQuerySets;

        private readonly gaxgrpc::ApiCall<CreateSampleQuerySetRequest, SampleQuerySet> _callCreateSampleQuerySet;

        private readonly gaxgrpc::ApiCall<UpdateSampleQuerySetRequest, SampleQuerySet> _callUpdateSampleQuerySet;

        private readonly gaxgrpc::ApiCall<DeleteSampleQuerySetRequest, wkt::Empty> _callDeleteSampleQuerySet;

        /// <summary>
        /// Constructs a client wrapper for the SampleQuerySetService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SampleQuerySetServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public SampleQuerySetServiceClientImpl(SampleQuerySetService.SampleQuerySetServiceClient grpcClient, SampleQuerySetServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            SampleQuerySetServiceSettings effectiveSettings = settings ?? SampleQuerySetServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callGetSampleQuerySet = clientHelper.BuildApiCall<GetSampleQuerySetRequest, SampleQuerySet>("GetSampleQuerySet", grpcClient.GetSampleQuerySetAsync, grpcClient.GetSampleQuerySet, effectiveSettings.GetSampleQuerySetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSampleQuerySet);
            Modify_GetSampleQuerySetApiCall(ref _callGetSampleQuerySet);
            _callListSampleQuerySets = clientHelper.BuildApiCall<ListSampleQuerySetsRequest, ListSampleQuerySetsResponse>("ListSampleQuerySets", grpcClient.ListSampleQuerySetsAsync, grpcClient.ListSampleQuerySets, effectiveSettings.ListSampleQuerySetsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSampleQuerySets);
            Modify_ListSampleQuerySetsApiCall(ref _callListSampleQuerySets);
            _callCreateSampleQuerySet = clientHelper.BuildApiCall<CreateSampleQuerySetRequest, SampleQuerySet>("CreateSampleQuerySet", grpcClient.CreateSampleQuerySetAsync, grpcClient.CreateSampleQuerySet, effectiveSettings.CreateSampleQuerySetSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSampleQuerySet);
            Modify_CreateSampleQuerySetApiCall(ref _callCreateSampleQuerySet);
            _callUpdateSampleQuerySet = clientHelper.BuildApiCall<UpdateSampleQuerySetRequest, SampleQuerySet>("UpdateSampleQuerySet", grpcClient.UpdateSampleQuerySetAsync, grpcClient.UpdateSampleQuerySet, effectiveSettings.UpdateSampleQuerySetSettings).WithGoogleRequestParam("sample_query_set.name", request => request.SampleQuerySet?.Name);
            Modify_ApiCall(ref _callUpdateSampleQuerySet);
            Modify_UpdateSampleQuerySetApiCall(ref _callUpdateSampleQuerySet);
            _callDeleteSampleQuerySet = clientHelper.BuildApiCall<DeleteSampleQuerySetRequest, wkt::Empty>("DeleteSampleQuerySet", grpcClient.DeleteSampleQuerySetAsync, grpcClient.DeleteSampleQuerySet, effectiveSettings.DeleteSampleQuerySetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteSampleQuerySet);
            Modify_DeleteSampleQuerySetApiCall(ref _callDeleteSampleQuerySet);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetSampleQuerySetApiCall(ref gaxgrpc::ApiCall<GetSampleQuerySetRequest, SampleQuerySet> call);

        partial void Modify_ListSampleQuerySetsApiCall(ref gaxgrpc::ApiCall<ListSampleQuerySetsRequest, ListSampleQuerySetsResponse> call);

        partial void Modify_CreateSampleQuerySetApiCall(ref gaxgrpc::ApiCall<CreateSampleQuerySetRequest, SampleQuerySet> call);

        partial void Modify_UpdateSampleQuerySetApiCall(ref gaxgrpc::ApiCall<UpdateSampleQuerySetRequest, SampleQuerySet> call);

        partial void Modify_DeleteSampleQuerySetApiCall(ref gaxgrpc::ApiCall<DeleteSampleQuerySetRequest, wkt::Empty> call);

        partial void OnConstruction(SampleQuerySetService.SampleQuerySetServiceClient grpcClient, SampleQuerySetServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SampleQuerySetService client</summary>
        public override SampleQuerySetService.SampleQuerySetServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_GetSampleQuerySetRequest(ref GetSampleQuerySetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSampleQuerySetsRequest(ref ListSampleQuerySetsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateSampleQuerySetRequest(ref CreateSampleQuerySetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSampleQuerySetRequest(ref UpdateSampleQuerySetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSampleQuerySetRequest(ref DeleteSampleQuerySetRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets a
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SampleQuerySet GetSampleQuerySet(GetSampleQuerySetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSampleQuerySetRequest(ref request, ref callSettings);
            return _callGetSampleQuerySet.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SampleQuerySet> GetSampleQuerySetAsync(GetSampleQuerySetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSampleQuerySetRequest(ref request, ref callSettings);
            return _callGetSampleQuerySet.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a list of
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet]s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SampleQuerySet"/> resources.</returns>
        public override gax::PagedEnumerable<ListSampleQuerySetsResponse, SampleQuerySet> ListSampleQuerySets(ListSampleQuerySetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSampleQuerySetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSampleQuerySetsRequest, ListSampleQuerySetsResponse, SampleQuerySet>(_callListSampleQuerySets, request, callSettings);
        }

        /// <summary>
        /// Gets a list of
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet]s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SampleQuerySet"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSampleQuerySetsResponse, SampleQuerySet> ListSampleQuerySetsAsync(ListSampleQuerySetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSampleQuerySetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSampleQuerySetsRequest, ListSampleQuerySetsResponse, SampleQuerySet>(_callListSampleQuerySets, request, callSettings);
        }

        /// <summary>
        /// Creates a
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SampleQuerySet CreateSampleQuerySet(CreateSampleQuerySetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSampleQuerySetRequest(ref request, ref callSettings);
            return _callCreateSampleQuerySet.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SampleQuerySet> CreateSampleQuerySetAsync(CreateSampleQuerySetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSampleQuerySetRequest(ref request, ref callSettings);
            return _callCreateSampleQuerySet.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SampleQuerySet UpdateSampleQuerySet(UpdateSampleQuerySetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSampleQuerySetRequest(ref request, ref callSettings);
            return _callUpdateSampleQuerySet.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SampleQuerySet> UpdateSampleQuerySetAsync(UpdateSampleQuerySetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSampleQuerySetRequest(ref request, ref callSettings);
            return _callUpdateSampleQuerySet.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteSampleQuerySet(DeleteSampleQuerySetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSampleQuerySetRequest(ref request, ref callSettings);
            _callDeleteSampleQuerySet.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a
        /// [SampleQuerySet][google.cloud.discoveryengine.v1beta.SampleQuerySet].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteSampleQuerySetAsync(DeleteSampleQuerySetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSampleQuerySetRequest(ref request, ref callSettings);
            return _callDeleteSampleQuerySet.Async(request, callSettings);
        }
    }

    public partial class ListSampleQuerySetsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSampleQuerySetsResponse : gaxgrpc::IPageResponse<SampleQuerySet>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<SampleQuerySet> GetEnumerator() => SampleQuerySets.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class SampleQuerySetService
    {
        public partial class SampleQuerySetServiceClient
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
