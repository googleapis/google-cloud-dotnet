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
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Shopping.Merchant.Accounts.V1
{
    /// <summary>Settings for <see cref="RegionsServiceClient"/> instances.</summary>
    public sealed partial class RegionsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="RegionsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="RegionsServiceSettings"/>.</returns>
        public static RegionsServiceSettings GetDefault() => new RegionsServiceSettings();

        /// <summary>Constructs a new <see cref="RegionsServiceSettings"/> object with default settings.</summary>
        public RegionsServiceSettings()
        {
        }

        private RegionsServiceSettings(RegionsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetRegionSettings = existing.GetRegionSettings;
            CreateRegionSettings = existing.CreateRegionSettings;
            BatchCreateRegionsSettings = existing.BatchCreateRegionsSettings;
            UpdateRegionSettings = existing.UpdateRegionSettings;
            BatchUpdateRegionsSettings = existing.BatchUpdateRegionsSettings;
            DeleteRegionSettings = existing.DeleteRegionSettings;
            BatchDeleteRegionsSettings = existing.BatchDeleteRegionsSettings;
            ListRegionsSettings = existing.ListRegionsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(RegionsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegionsServiceClient.GetRegion</c> and <c>RegionsServiceClient.GetRegionAsync</c>.
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
        public gaxgrpc::CallSettings GetRegionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegionsServiceClient.CreateRegion</c> and <c>RegionsServiceClient.CreateRegionAsync</c>.
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
        public gaxgrpc::CallSettings CreateRegionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegionsServiceClient.BatchCreateRegions</c> and <c>RegionsServiceClient.BatchCreateRegionsAsync</c>.
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
        public gaxgrpc::CallSettings BatchCreateRegionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegionsServiceClient.UpdateRegion</c> and <c>RegionsServiceClient.UpdateRegionAsync</c>.
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
        public gaxgrpc::CallSettings UpdateRegionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegionsServiceClient.BatchUpdateRegions</c> and <c>RegionsServiceClient.BatchUpdateRegionsAsync</c>.
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
        public gaxgrpc::CallSettings BatchUpdateRegionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegionsServiceClient.DeleteRegion</c> and <c>RegionsServiceClient.DeleteRegionAsync</c>.
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
        public gaxgrpc::CallSettings DeleteRegionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegionsServiceClient.BatchDeleteRegions</c> and <c>RegionsServiceClient.BatchDeleteRegionsAsync</c>.
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
        public gaxgrpc::CallSettings BatchDeleteRegionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegionsServiceClient.ListRegions</c> and <c>RegionsServiceClient.ListRegionsAsync</c>.
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
        public gaxgrpc::CallSettings ListRegionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="RegionsServiceSettings"/> object.</returns>
        public RegionsServiceSettings Clone() => new RegionsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="RegionsServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class RegionsServiceClientBuilder : gaxgrpc::ClientBuilderBase<RegionsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public RegionsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public RegionsServiceClientBuilder() : base(RegionsServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref RegionsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<RegionsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override RegionsServiceClient Build()
        {
            RegionsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<RegionsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<RegionsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private RegionsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return RegionsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<RegionsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return RegionsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => RegionsServiceClient.ChannelPool;
    }

    /// <summary>RegionsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Manages regions configuration.
    /// 
    /// This API defines the following resource model:
    /// 
    /// - [Region][google.shopping.merchant.accounts.v1.Region]
    /// </remarks>
    public abstract partial class RegionsServiceClient
    {
        /// <summary>
        /// The default endpoint for the RegionsService service, which is a host of "merchantapi.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "merchantapi.googleapis.com:443";

        /// <summary>The default RegionsService scopes.</summary>
        /// <remarks>
        /// The default RegionsService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/content</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/content",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(RegionsService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="RegionsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="RegionsServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="RegionsServiceClient"/>.</returns>
        public static stt::Task<RegionsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new RegionsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="RegionsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="RegionsServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="RegionsServiceClient"/>.</returns>
        public static RegionsServiceClient Create() => new RegionsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="RegionsServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="RegionsServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="RegionsServiceClient"/>.</returns>
        internal static RegionsServiceClient Create(grpccore::CallInvoker callInvoker, RegionsServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            RegionsService.RegionsServiceClient grpcClient = new RegionsService.RegionsServiceClient(callInvoker);
            return new RegionsServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC RegionsService client</summary>
        public virtual RegionsService.RegionsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a region defined in your Merchant Center account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Region GetRegion(GetRegionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a region defined in your Merchant Center account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Region> GetRegionAsync(GetRegionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a region defined in your Merchant Center account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Region> GetRegionAsync(GetRegionRequest request, st::CancellationToken cancellationToken) =>
            GetRegionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a region defined in your Merchant Center account.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the region to retrieve.
        /// Format: `accounts/{account}/regions/{region}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Region GetRegion(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRegion(new GetRegionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a region defined in your Merchant Center account.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the region to retrieve.
        /// Format: `accounts/{account}/regions/{region}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Region> GetRegionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRegionAsync(new GetRegionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a region defined in your Merchant Center account.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the region to retrieve.
        /// Format: `accounts/{account}/regions/{region}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Region> GetRegionAsync(string name, st::CancellationToken cancellationToken) =>
            GetRegionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a region defined in your Merchant Center account.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the region to retrieve.
        /// Format: `accounts/{account}/regions/{region}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Region GetRegion(RegionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRegion(new GetRegionRequest
            {
                RegionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a region defined in your Merchant Center account.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the region to retrieve.
        /// Format: `accounts/{account}/regions/{region}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Region> GetRegionAsync(RegionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRegionAsync(new GetRegionRequest
            {
                RegionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a region defined in your Merchant Center account.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the region to retrieve.
        /// Format: `accounts/{account}/regions/{region}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Region> GetRegionAsync(RegionName name, st::CancellationToken cancellationToken) =>
            GetRegionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a region definition in your Merchant Center account. Executing this
        /// method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Region CreateRegion(CreateRegionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a region definition in your Merchant Center account. Executing this
        /// method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Region> CreateRegionAsync(CreateRegionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a region definition in your Merchant Center account. Executing this
        /// method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Region> CreateRegionAsync(CreateRegionRequest request, st::CancellationToken cancellationToken) =>
            CreateRegionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a region definition in your Merchant Center account. Executing this
        /// method requires admin access.
        /// </summary>
        /// <param name="parent">
        /// Required. The account to create a region for.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="region">
        /// Required. The region to create.
        /// </param>
        /// <param name="regionId">
        /// Required. The identifier for the region, unique over all regions of the
        /// same account.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Region CreateRegion(string parent, Region region, string regionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRegion(new CreateRegionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                RegionId = gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)),
                Region = gax::GaxPreconditions.CheckNotNull(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Creates a region definition in your Merchant Center account. Executing this
        /// method requires admin access.
        /// </summary>
        /// <param name="parent">
        /// Required. The account to create a region for.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="region">
        /// Required. The region to create.
        /// </param>
        /// <param name="regionId">
        /// Required. The identifier for the region, unique over all regions of the
        /// same account.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Region> CreateRegionAsync(string parent, Region region, string regionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRegionAsync(new CreateRegionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                RegionId = gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)),
                Region = gax::GaxPreconditions.CheckNotNull(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Creates a region definition in your Merchant Center account. Executing this
        /// method requires admin access.
        /// </summary>
        /// <param name="parent">
        /// Required. The account to create a region for.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="region">
        /// Required. The region to create.
        /// </param>
        /// <param name="regionId">
        /// Required. The identifier for the region, unique over all regions of the
        /// same account.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Region> CreateRegionAsync(string parent, Region region, string regionId, st::CancellationToken cancellationToken) =>
            CreateRegionAsync(parent, region, regionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a region definition in your Merchant Center account. Executing this
        /// method requires admin access.
        /// </summary>
        /// <param name="parent">
        /// Required. The account to create a region for.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="region">
        /// Required. The region to create.
        /// </param>
        /// <param name="regionId">
        /// Required. The identifier for the region, unique over all regions of the
        /// same account.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Region CreateRegion(AccountName parent, Region region, string regionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRegion(new CreateRegionRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                RegionId = gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)),
                Region = gax::GaxPreconditions.CheckNotNull(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Creates a region definition in your Merchant Center account. Executing this
        /// method requires admin access.
        /// </summary>
        /// <param name="parent">
        /// Required. The account to create a region for.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="region">
        /// Required. The region to create.
        /// </param>
        /// <param name="regionId">
        /// Required. The identifier for the region, unique over all regions of the
        /// same account.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Region> CreateRegionAsync(AccountName parent, Region region, string regionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRegionAsync(new CreateRegionRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                RegionId = gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)),
                Region = gax::GaxPreconditions.CheckNotNull(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Creates a region definition in your Merchant Center account. Executing this
        /// method requires admin access.
        /// </summary>
        /// <param name="parent">
        /// Required. The account to create a region for.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="region">
        /// Required. The region to create.
        /// </param>
        /// <param name="regionId">
        /// Required. The identifier for the region, unique over all regions of the
        /// same account.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Region> CreateRegionAsync(AccountName parent, Region region, string regionId, st::CancellationToken cancellationToken) =>
            CreateRegionAsync(parent, region, regionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates one or more regions in your Merchant Center account.
        /// Executing this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateRegionsResponse BatchCreateRegions(BatchCreateRegionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates one or more regions in your Merchant Center account.
        /// Executing this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateRegionsResponse> BatchCreateRegionsAsync(BatchCreateRegionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates one or more regions in your Merchant Center account.
        /// Executing this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateRegionsResponse> BatchCreateRegionsAsync(BatchCreateRegionsRequest request, st::CancellationToken cancellationToken) =>
            BatchCreateRegionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a region definition in your Merchant Center account.
        /// Executing this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Region UpdateRegion(UpdateRegionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a region definition in your Merchant Center account.
        /// Executing this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Region> UpdateRegionAsync(UpdateRegionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a region definition in your Merchant Center account.
        /// Executing this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Region> UpdateRegionAsync(UpdateRegionRequest request, st::CancellationToken cancellationToken) =>
            UpdateRegionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a region definition in your Merchant Center account.
        /// Executing this method requires admin access.
        /// </summary>
        /// <param name="region">
        /// Required. The updated region.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The comma-separated field mask indicating the fields to update.
        /// Example:
        /// `"displayName,postalCodeArea.regionCode"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Region UpdateRegion(Region region, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateRegion(new UpdateRegionRequest
            {
                Region = gax::GaxPreconditions.CheckNotNull(region, nameof(region)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a region definition in your Merchant Center account.
        /// Executing this method requires admin access.
        /// </summary>
        /// <param name="region">
        /// Required. The updated region.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The comma-separated field mask indicating the fields to update.
        /// Example:
        /// `"displayName,postalCodeArea.regionCode"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Region> UpdateRegionAsync(Region region, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateRegionAsync(new UpdateRegionRequest
            {
                Region = gax::GaxPreconditions.CheckNotNull(region, nameof(region)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a region definition in your Merchant Center account.
        /// Executing this method requires admin access.
        /// </summary>
        /// <param name="region">
        /// Required. The updated region.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The comma-separated field mask indicating the fields to update.
        /// Example:
        /// `"displayName,postalCodeArea.regionCode"`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Region> UpdateRegionAsync(Region region, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateRegionAsync(region, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates one or more regions in your Merchant Center account.
        /// Executing this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateRegionsResponse BatchUpdateRegions(BatchUpdateRegionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates one or more regions in your Merchant Center account.
        /// Executing this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateRegionsResponse> BatchUpdateRegionsAsync(BatchUpdateRegionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates one or more regions in your Merchant Center account.
        /// Executing this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateRegionsResponse> BatchUpdateRegionsAsync(BatchUpdateRegionsRequest request, st::CancellationToken cancellationToken) =>
            BatchUpdateRegionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a region definition from your Merchant Center account. Executing
        /// this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteRegion(DeleteRegionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a region definition from your Merchant Center account. Executing
        /// this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRegionAsync(DeleteRegionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a region definition from your Merchant Center account. Executing
        /// this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRegionAsync(DeleteRegionRequest request, st::CancellationToken cancellationToken) =>
            DeleteRegionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a region definition from your Merchant Center account. Executing
        /// this method requires admin access.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the region to delete.
        /// Format: `accounts/{account}/regions/{region}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteRegion(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRegion(new DeleteRegionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a region definition from your Merchant Center account. Executing
        /// this method requires admin access.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the region to delete.
        /// Format: `accounts/{account}/regions/{region}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRegionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRegionAsync(new DeleteRegionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a region definition from your Merchant Center account. Executing
        /// this method requires admin access.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the region to delete.
        /// Format: `accounts/{account}/regions/{region}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRegionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteRegionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a region definition from your Merchant Center account. Executing
        /// this method requires admin access.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the region to delete.
        /// Format: `accounts/{account}/regions/{region}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteRegion(RegionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRegion(new DeleteRegionRequest
            {
                RegionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a region definition from your Merchant Center account. Executing
        /// this method requires admin access.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the region to delete.
        /// Format: `accounts/{account}/regions/{region}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRegionAsync(RegionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRegionAsync(new DeleteRegionRequest
            {
                RegionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a region definition from your Merchant Center account. Executing
        /// this method requires admin access.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the region to delete.
        /// Format: `accounts/{account}/regions/{region}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRegionAsync(RegionName name, st::CancellationToken cancellationToken) =>
            DeleteRegionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes multiple regions by name from your Merchant Center account.
        /// Executing this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void BatchDeleteRegions(BatchDeleteRegionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes multiple regions by name from your Merchant Center account.
        /// Executing this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchDeleteRegionsAsync(BatchDeleteRegionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes multiple regions by name from your Merchant Center account.
        /// Executing this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchDeleteRegionsAsync(BatchDeleteRegionsRequest request, st::CancellationToken cancellationToken) =>
            BatchDeleteRegionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the regions in your Merchant Center account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Region"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRegionsResponse, Region> ListRegions(ListRegionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the regions in your Merchant Center account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Region"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRegionsResponse, Region> ListRegionsAsync(ListRegionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the regions in your Merchant Center account.
        /// </summary>
        /// <param name="parent">
        /// Required. The account to list regions for.
        /// Format: `accounts/{account}`
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
        /// <returns>A pageable sequence of <see cref="Region"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRegionsResponse, Region> ListRegions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRegionsRequest request = new ListRegionsRequest
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
            return ListRegions(request, callSettings);
        }

        /// <summary>
        /// Lists the regions in your Merchant Center account.
        /// </summary>
        /// <param name="parent">
        /// Required. The account to list regions for.
        /// Format: `accounts/{account}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Region"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRegionsResponse, Region> ListRegionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRegionsRequest request = new ListRegionsRequest
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
            return ListRegionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the regions in your Merchant Center account.
        /// </summary>
        /// <param name="parent">
        /// Required. The account to list regions for.
        /// Format: `accounts/{account}`
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
        /// <returns>A pageable sequence of <see cref="Region"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRegionsResponse, Region> ListRegions(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRegionsRequest request = new ListRegionsRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListRegions(request, callSettings);
        }

        /// <summary>
        /// Lists the regions in your Merchant Center account.
        /// </summary>
        /// <param name="parent">
        /// Required. The account to list regions for.
        /// Format: `accounts/{account}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Region"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRegionsResponse, Region> ListRegionsAsync(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRegionsRequest request = new ListRegionsRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListRegionsAsync(request, callSettings);
        }
    }

    /// <summary>RegionsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Manages regions configuration.
    /// 
    /// This API defines the following resource model:
    /// 
    /// - [Region][google.shopping.merchant.accounts.v1.Region]
    /// </remarks>
    public sealed partial class RegionsServiceClientImpl : RegionsServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetRegionRequest, Region> _callGetRegion;

        private readonly gaxgrpc::ApiCall<CreateRegionRequest, Region> _callCreateRegion;

        private readonly gaxgrpc::ApiCall<BatchCreateRegionsRequest, BatchCreateRegionsResponse> _callBatchCreateRegions;

        private readonly gaxgrpc::ApiCall<UpdateRegionRequest, Region> _callUpdateRegion;

        private readonly gaxgrpc::ApiCall<BatchUpdateRegionsRequest, BatchUpdateRegionsResponse> _callBatchUpdateRegions;

        private readonly gaxgrpc::ApiCall<DeleteRegionRequest, wkt::Empty> _callDeleteRegion;

        private readonly gaxgrpc::ApiCall<BatchDeleteRegionsRequest, wkt::Empty> _callBatchDeleteRegions;

        private readonly gaxgrpc::ApiCall<ListRegionsRequest, ListRegionsResponse> _callListRegions;

        /// <summary>
        /// Constructs a client wrapper for the RegionsService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="RegionsServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public RegionsServiceClientImpl(RegionsService.RegionsServiceClient grpcClient, RegionsServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            RegionsServiceSettings effectiveSettings = settings ?? RegionsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetRegion = clientHelper.BuildApiCall<GetRegionRequest, Region>("GetRegion", grpcClient.GetRegionAsync, grpcClient.GetRegion, effectiveSettings.GetRegionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetRegion);
            Modify_GetRegionApiCall(ref _callGetRegion);
            _callCreateRegion = clientHelper.BuildApiCall<CreateRegionRequest, Region>("CreateRegion", grpcClient.CreateRegionAsync, grpcClient.CreateRegion, effectiveSettings.CreateRegionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateRegion);
            Modify_CreateRegionApiCall(ref _callCreateRegion);
            _callBatchCreateRegions = clientHelper.BuildApiCall<BatchCreateRegionsRequest, BatchCreateRegionsResponse>("BatchCreateRegions", grpcClient.BatchCreateRegionsAsync, grpcClient.BatchCreateRegions, effectiveSettings.BatchCreateRegionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchCreateRegions);
            Modify_BatchCreateRegionsApiCall(ref _callBatchCreateRegions);
            _callUpdateRegion = clientHelper.BuildApiCall<UpdateRegionRequest, Region>("UpdateRegion", grpcClient.UpdateRegionAsync, grpcClient.UpdateRegion, effectiveSettings.UpdateRegionSettings).WithGoogleRequestParam("region.name", request => request.Region?.Name);
            Modify_ApiCall(ref _callUpdateRegion);
            Modify_UpdateRegionApiCall(ref _callUpdateRegion);
            _callBatchUpdateRegions = clientHelper.BuildApiCall<BatchUpdateRegionsRequest, BatchUpdateRegionsResponse>("BatchUpdateRegions", grpcClient.BatchUpdateRegionsAsync, grpcClient.BatchUpdateRegions, effectiveSettings.BatchUpdateRegionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchUpdateRegions);
            Modify_BatchUpdateRegionsApiCall(ref _callBatchUpdateRegions);
            _callDeleteRegion = clientHelper.BuildApiCall<DeleteRegionRequest, wkt::Empty>("DeleteRegion", grpcClient.DeleteRegionAsync, grpcClient.DeleteRegion, effectiveSettings.DeleteRegionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteRegion);
            Modify_DeleteRegionApiCall(ref _callDeleteRegion);
            _callBatchDeleteRegions = clientHelper.BuildApiCall<BatchDeleteRegionsRequest, wkt::Empty>("BatchDeleteRegions", grpcClient.BatchDeleteRegionsAsync, grpcClient.BatchDeleteRegions, effectiveSettings.BatchDeleteRegionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchDeleteRegions);
            Modify_BatchDeleteRegionsApiCall(ref _callBatchDeleteRegions);
            _callListRegions = clientHelper.BuildApiCall<ListRegionsRequest, ListRegionsResponse>("ListRegions", grpcClient.ListRegionsAsync, grpcClient.ListRegions, effectiveSettings.ListRegionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListRegions);
            Modify_ListRegionsApiCall(ref _callListRegions);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetRegionApiCall(ref gaxgrpc::ApiCall<GetRegionRequest, Region> call);

        partial void Modify_CreateRegionApiCall(ref gaxgrpc::ApiCall<CreateRegionRequest, Region> call);

        partial void Modify_BatchCreateRegionsApiCall(ref gaxgrpc::ApiCall<BatchCreateRegionsRequest, BatchCreateRegionsResponse> call);

        partial void Modify_UpdateRegionApiCall(ref gaxgrpc::ApiCall<UpdateRegionRequest, Region> call);

        partial void Modify_BatchUpdateRegionsApiCall(ref gaxgrpc::ApiCall<BatchUpdateRegionsRequest, BatchUpdateRegionsResponse> call);

        partial void Modify_DeleteRegionApiCall(ref gaxgrpc::ApiCall<DeleteRegionRequest, wkt::Empty> call);

        partial void Modify_BatchDeleteRegionsApiCall(ref gaxgrpc::ApiCall<BatchDeleteRegionsRequest, wkt::Empty> call);

        partial void Modify_ListRegionsApiCall(ref gaxgrpc::ApiCall<ListRegionsRequest, ListRegionsResponse> call);

        partial void OnConstruction(RegionsService.RegionsServiceClient grpcClient, RegionsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC RegionsService client</summary>
        public override RegionsService.RegionsServiceClient GrpcClient { get; }

        partial void Modify_GetRegionRequest(ref GetRegionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateRegionRequest(ref CreateRegionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchCreateRegionsRequest(ref BatchCreateRegionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateRegionRequest(ref UpdateRegionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchUpdateRegionsRequest(ref BatchUpdateRegionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteRegionRequest(ref DeleteRegionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchDeleteRegionsRequest(ref BatchDeleteRegionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRegionsRequest(ref ListRegionsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves a region defined in your Merchant Center account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Region GetRegion(GetRegionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRegionRequest(ref request, ref callSettings);
            return _callGetRegion.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a region defined in your Merchant Center account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Region> GetRegionAsync(GetRegionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRegionRequest(ref request, ref callSettings);
            return _callGetRegion.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a region definition in your Merchant Center account. Executing this
        /// method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Region CreateRegion(CreateRegionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateRegionRequest(ref request, ref callSettings);
            return _callCreateRegion.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a region definition in your Merchant Center account. Executing this
        /// method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Region> CreateRegionAsync(CreateRegionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateRegionRequest(ref request, ref callSettings);
            return _callCreateRegion.Async(request, callSettings);
        }

        /// <summary>
        /// Creates one or more regions in your Merchant Center account.
        /// Executing this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchCreateRegionsResponse BatchCreateRegions(BatchCreateRegionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateRegionsRequest(ref request, ref callSettings);
            return _callBatchCreateRegions.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates one or more regions in your Merchant Center account.
        /// Executing this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchCreateRegionsResponse> BatchCreateRegionsAsync(BatchCreateRegionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateRegionsRequest(ref request, ref callSettings);
            return _callBatchCreateRegions.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a region definition in your Merchant Center account.
        /// Executing this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Region UpdateRegion(UpdateRegionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateRegionRequest(ref request, ref callSettings);
            return _callUpdateRegion.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a region definition in your Merchant Center account.
        /// Executing this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Region> UpdateRegionAsync(UpdateRegionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateRegionRequest(ref request, ref callSettings);
            return _callUpdateRegion.Async(request, callSettings);
        }

        /// <summary>
        /// Updates one or more regions in your Merchant Center account.
        /// Executing this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchUpdateRegionsResponse BatchUpdateRegions(BatchUpdateRegionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateRegionsRequest(ref request, ref callSettings);
            return _callBatchUpdateRegions.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates one or more regions in your Merchant Center account.
        /// Executing this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchUpdateRegionsResponse> BatchUpdateRegionsAsync(BatchUpdateRegionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateRegionsRequest(ref request, ref callSettings);
            return _callBatchUpdateRegions.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a region definition from your Merchant Center account. Executing
        /// this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteRegion(DeleteRegionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRegionRequest(ref request, ref callSettings);
            _callDeleteRegion.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a region definition from your Merchant Center account. Executing
        /// this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteRegionAsync(DeleteRegionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRegionRequest(ref request, ref callSettings);
            return _callDeleteRegion.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes multiple regions by name from your Merchant Center account.
        /// Executing this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void BatchDeleteRegions(BatchDeleteRegionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeleteRegionsRequest(ref request, ref callSettings);
            _callBatchDeleteRegions.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes multiple regions by name from your Merchant Center account.
        /// Executing this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task BatchDeleteRegionsAsync(BatchDeleteRegionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeleteRegionsRequest(ref request, ref callSettings);
            return _callBatchDeleteRegions.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the regions in your Merchant Center account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Region"/> resources.</returns>
        public override gax::PagedEnumerable<ListRegionsResponse, Region> ListRegions(ListRegionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRegionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRegionsRequest, ListRegionsResponse, Region>(_callListRegions, request, callSettings);
        }

        /// <summary>
        /// Lists the regions in your Merchant Center account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Region"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListRegionsResponse, Region> ListRegionsAsync(ListRegionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRegionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRegionsRequest, ListRegionsResponse, Region>(_callListRegions, request, callSettings);
        }
    }

    public partial class ListRegionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListRegionsResponse : gaxgrpc::IPageResponse<Region>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Region> GetEnumerator() => Regions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
