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

namespace Google.Shopping.Merchant.Accounts.V1Beta
{
    /// <summary>Settings for <see cref="OmnichannelSettingsServiceClient"/> instances.</summary>
    public sealed partial class OmnichannelSettingsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="OmnichannelSettingsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="OmnichannelSettingsServiceSettings"/>.</returns>
        public static OmnichannelSettingsServiceSettings GetDefault() => new OmnichannelSettingsServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="OmnichannelSettingsServiceSettings"/> object with default settings.
        /// </summary>
        public OmnichannelSettingsServiceSettings()
        {
        }

        private OmnichannelSettingsServiceSettings(OmnichannelSettingsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetOmnichannelSettingSettings = existing.GetOmnichannelSettingSettings;
            ListOmnichannelSettingsSettings = existing.ListOmnichannelSettingsSettings;
            CreateOmnichannelSettingSettings = existing.CreateOmnichannelSettingSettings;
            UpdateOmnichannelSettingSettings = existing.UpdateOmnichannelSettingSettings;
            RequestInventoryVerificationSettings = existing.RequestInventoryVerificationSettings;
            OnCopy(existing);
        }

        partial void OnCopy(OmnichannelSettingsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OmnichannelSettingsServiceClient.GetOmnichannelSetting</c> and
        /// <c>OmnichannelSettingsServiceClient.GetOmnichannelSettingAsync</c>.
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
        public gaxgrpc::CallSettings GetOmnichannelSettingSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OmnichannelSettingsServiceClient.ListOmnichannelSettings</c> and
        /// <c>OmnichannelSettingsServiceClient.ListOmnichannelSettingsAsync</c>.
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
        public gaxgrpc::CallSettings ListOmnichannelSettingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OmnichannelSettingsServiceClient.CreateOmnichannelSetting</c> and
        /// <c>OmnichannelSettingsServiceClient.CreateOmnichannelSettingAsync</c>.
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
        public gaxgrpc::CallSettings CreateOmnichannelSettingSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OmnichannelSettingsServiceClient.UpdateOmnichannelSetting</c> and
        /// <c>OmnichannelSettingsServiceClient.UpdateOmnichannelSettingAsync</c>.
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
        public gaxgrpc::CallSettings UpdateOmnichannelSettingSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OmnichannelSettingsServiceClient.RequestInventoryVerification</c> and
        /// <c>OmnichannelSettingsServiceClient.RequestInventoryVerificationAsync</c>.
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
        public gaxgrpc::CallSettings RequestInventoryVerificationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="OmnichannelSettingsServiceSettings"/> object.</returns>
        public OmnichannelSettingsServiceSettings Clone() => new OmnichannelSettingsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="OmnichannelSettingsServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class OmnichannelSettingsServiceClientBuilder : gaxgrpc::ClientBuilderBase<OmnichannelSettingsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public OmnichannelSettingsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public OmnichannelSettingsServiceClientBuilder() : base(OmnichannelSettingsServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref OmnichannelSettingsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<OmnichannelSettingsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override OmnichannelSettingsServiceClient Build()
        {
            OmnichannelSettingsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<OmnichannelSettingsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<OmnichannelSettingsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private OmnichannelSettingsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return OmnichannelSettingsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<OmnichannelSettingsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return OmnichannelSettingsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => OmnichannelSettingsServiceClient.ChannelPool;
    }

    /// <summary>OmnichannelSettingsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The service facilitates the management of a merchant's omnichannel settings.
    /// ## This API defines the following resource model:
    /// 
    /// [OmnichannelSetting][google.shopping.merchant.accounts.v1.OmnichannelSetting]
    /// </remarks>
    public abstract partial class OmnichannelSettingsServiceClient
    {
        /// <summary>
        /// The default endpoint for the OmnichannelSettingsService service, which is a host of
        /// "merchantapi.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "merchantapi.googleapis.com:443";

        /// <summary>The default OmnichannelSettingsService scopes.</summary>
        /// <remarks>
        /// The default OmnichannelSettingsService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/content</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/content",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(OmnichannelSettingsService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="OmnichannelSettingsServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="OmnichannelSettingsServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="OmnichannelSettingsServiceClient"/>.</returns>
        public static stt::Task<OmnichannelSettingsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new OmnichannelSettingsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="OmnichannelSettingsServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="OmnichannelSettingsServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="OmnichannelSettingsServiceClient"/>.</returns>
        public static OmnichannelSettingsServiceClient Create() => new OmnichannelSettingsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="OmnichannelSettingsServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="OmnichannelSettingsServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="OmnichannelSettingsServiceClient"/>.</returns>
        internal static OmnichannelSettingsServiceClient Create(grpccore::CallInvoker callInvoker, OmnichannelSettingsServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            OmnichannelSettingsService.OmnichannelSettingsServiceClient grpcClient = new OmnichannelSettingsService.OmnichannelSettingsServiceClient(callInvoker);
            return new OmnichannelSettingsServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC OmnichannelSettingsService client</summary>
        public virtual OmnichannelSettingsService.OmnichannelSettingsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Get the omnichannel settings for a given merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual OmnichannelSetting GetOmnichannelSetting(GetOmnichannelSettingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get the omnichannel settings for a given merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OmnichannelSetting> GetOmnichannelSettingAsync(GetOmnichannelSettingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get the omnichannel settings for a given merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OmnichannelSetting> GetOmnichannelSettingAsync(GetOmnichannelSettingRequest request, st::CancellationToken cancellationToken) =>
            GetOmnichannelSettingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the omnichannel settings for a given merchant.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the omnichannel setting to retrieve.
        /// Format: `accounts/{account}/omnichannelSettings/{omnichannel_setting}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual OmnichannelSetting GetOmnichannelSetting(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetOmnichannelSetting(new GetOmnichannelSettingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the omnichannel settings for a given merchant.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the omnichannel setting to retrieve.
        /// Format: `accounts/{account}/omnichannelSettings/{omnichannel_setting}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OmnichannelSetting> GetOmnichannelSettingAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetOmnichannelSettingAsync(new GetOmnichannelSettingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the omnichannel settings for a given merchant.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the omnichannel setting to retrieve.
        /// Format: `accounts/{account}/omnichannelSettings/{omnichannel_setting}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OmnichannelSetting> GetOmnichannelSettingAsync(string name, st::CancellationToken cancellationToken) =>
            GetOmnichannelSettingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the omnichannel settings for a given merchant.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the omnichannel setting to retrieve.
        /// Format: `accounts/{account}/omnichannelSettings/{omnichannel_setting}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual OmnichannelSetting GetOmnichannelSetting(OmnichannelSettingName name, gaxgrpc::CallSettings callSettings = null) =>
            GetOmnichannelSetting(new GetOmnichannelSettingRequest
            {
                OmnichannelSettingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the omnichannel settings for a given merchant.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the omnichannel setting to retrieve.
        /// Format: `accounts/{account}/omnichannelSettings/{omnichannel_setting}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OmnichannelSetting> GetOmnichannelSettingAsync(OmnichannelSettingName name, gaxgrpc::CallSettings callSettings = null) =>
            GetOmnichannelSettingAsync(new GetOmnichannelSettingRequest
            {
                OmnichannelSettingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the omnichannel settings for a given merchant.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the omnichannel setting to retrieve.
        /// Format: `accounts/{account}/omnichannelSettings/{omnichannel_setting}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OmnichannelSetting> GetOmnichannelSettingAsync(OmnichannelSettingName name, st::CancellationToken cancellationToken) =>
            GetOmnichannelSettingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List all the omnichannel settings for a given merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="OmnichannelSetting"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOmnichannelSettingsResponse, OmnichannelSetting> ListOmnichannelSettings(ListOmnichannelSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all the omnichannel settings for a given merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="OmnichannelSetting"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOmnichannelSettingsResponse, OmnichannelSetting> ListOmnichannelSettingsAsync(ListOmnichannelSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all the omnichannel settings for a given merchant.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of omnichannel settings.
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
        /// <returns>A pageable sequence of <see cref="OmnichannelSetting"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOmnichannelSettingsResponse, OmnichannelSetting> ListOmnichannelSettings(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOmnichannelSettingsRequest request = new ListOmnichannelSettingsRequest
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
            return ListOmnichannelSettings(request, callSettings);
        }

        /// <summary>
        /// List all the omnichannel settings for a given merchant.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of omnichannel settings.
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
        /// <returns>A pageable asynchronous sequence of <see cref="OmnichannelSetting"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOmnichannelSettingsResponse, OmnichannelSetting> ListOmnichannelSettingsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOmnichannelSettingsRequest request = new ListOmnichannelSettingsRequest
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
            return ListOmnichannelSettingsAsync(request, callSettings);
        }

        /// <summary>
        /// List all the omnichannel settings for a given merchant.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of omnichannel settings.
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
        /// <returns>A pageable sequence of <see cref="OmnichannelSetting"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOmnichannelSettingsResponse, OmnichannelSetting> ListOmnichannelSettings(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOmnichannelSettingsRequest request = new ListOmnichannelSettingsRequest
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
            return ListOmnichannelSettings(request, callSettings);
        }

        /// <summary>
        /// List all the omnichannel settings for a given merchant.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of omnichannel settings.
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
        /// <returns>A pageable asynchronous sequence of <see cref="OmnichannelSetting"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOmnichannelSettingsResponse, OmnichannelSetting> ListOmnichannelSettingsAsync(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOmnichannelSettingsRequest request = new ListOmnichannelSettingsRequest
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
            return ListOmnichannelSettingsAsync(request, callSettings);
        }

        /// <summary>
        /// Create the omnichannel settings for a given merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual OmnichannelSetting CreateOmnichannelSetting(CreateOmnichannelSettingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create the omnichannel settings for a given merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OmnichannelSetting> CreateOmnichannelSettingAsync(CreateOmnichannelSettingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create the omnichannel settings for a given merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OmnichannelSetting> CreateOmnichannelSettingAsync(CreateOmnichannelSettingRequest request, st::CancellationToken cancellationToken) =>
            CreateOmnichannelSettingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create the omnichannel settings for a given merchant.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this omnichannel setting will be
        /// created. Format: `accounts/{account}`
        /// </param>
        /// <param name="omnichannelSetting">
        /// Required. The omnichannel setting to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual OmnichannelSetting CreateOmnichannelSetting(string parent, OmnichannelSetting omnichannelSetting, gaxgrpc::CallSettings callSettings = null) =>
            CreateOmnichannelSetting(new CreateOmnichannelSettingRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                OmnichannelSetting = gax::GaxPreconditions.CheckNotNull(omnichannelSetting, nameof(omnichannelSetting)),
            }, callSettings);

        /// <summary>
        /// Create the omnichannel settings for a given merchant.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this omnichannel setting will be
        /// created. Format: `accounts/{account}`
        /// </param>
        /// <param name="omnichannelSetting">
        /// Required. The omnichannel setting to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OmnichannelSetting> CreateOmnichannelSettingAsync(string parent, OmnichannelSetting omnichannelSetting, gaxgrpc::CallSettings callSettings = null) =>
            CreateOmnichannelSettingAsync(new CreateOmnichannelSettingRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                OmnichannelSetting = gax::GaxPreconditions.CheckNotNull(omnichannelSetting, nameof(omnichannelSetting)),
            }, callSettings);

        /// <summary>
        /// Create the omnichannel settings for a given merchant.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this omnichannel setting will be
        /// created. Format: `accounts/{account}`
        /// </param>
        /// <param name="omnichannelSetting">
        /// Required. The omnichannel setting to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OmnichannelSetting> CreateOmnichannelSettingAsync(string parent, OmnichannelSetting omnichannelSetting, st::CancellationToken cancellationToken) =>
            CreateOmnichannelSettingAsync(parent, omnichannelSetting, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create the omnichannel settings for a given merchant.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this omnichannel setting will be
        /// created. Format: `accounts/{account}`
        /// </param>
        /// <param name="omnichannelSetting">
        /// Required. The omnichannel setting to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual OmnichannelSetting CreateOmnichannelSetting(AccountName parent, OmnichannelSetting omnichannelSetting, gaxgrpc::CallSettings callSettings = null) =>
            CreateOmnichannelSetting(new CreateOmnichannelSettingRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OmnichannelSetting = gax::GaxPreconditions.CheckNotNull(omnichannelSetting, nameof(omnichannelSetting)),
            }, callSettings);

        /// <summary>
        /// Create the omnichannel settings for a given merchant.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this omnichannel setting will be
        /// created. Format: `accounts/{account}`
        /// </param>
        /// <param name="omnichannelSetting">
        /// Required. The omnichannel setting to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OmnichannelSetting> CreateOmnichannelSettingAsync(AccountName parent, OmnichannelSetting omnichannelSetting, gaxgrpc::CallSettings callSettings = null) =>
            CreateOmnichannelSettingAsync(new CreateOmnichannelSettingRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OmnichannelSetting = gax::GaxPreconditions.CheckNotNull(omnichannelSetting, nameof(omnichannelSetting)),
            }, callSettings);

        /// <summary>
        /// Create the omnichannel settings for a given merchant.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this omnichannel setting will be
        /// created. Format: `accounts/{account}`
        /// </param>
        /// <param name="omnichannelSetting">
        /// Required. The omnichannel setting to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OmnichannelSetting> CreateOmnichannelSettingAsync(AccountName parent, OmnichannelSetting omnichannelSetting, st::CancellationToken cancellationToken) =>
            CreateOmnichannelSettingAsync(parent, omnichannelSetting, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update the omnichannel setting for a given merchant in a given country.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual OmnichannelSetting UpdateOmnichannelSetting(UpdateOmnichannelSettingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update the omnichannel setting for a given merchant in a given country.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OmnichannelSetting> UpdateOmnichannelSettingAsync(UpdateOmnichannelSettingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update the omnichannel setting for a given merchant in a given country.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OmnichannelSetting> UpdateOmnichannelSettingAsync(UpdateOmnichannelSettingRequest request, st::CancellationToken cancellationToken) =>
            UpdateOmnichannelSettingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update the omnichannel setting for a given merchant in a given country.
        /// </summary>
        /// <param name="omnichannelSetting">
        /// Required. The omnichannel setting to update.
        /// 
        /// The omnichannel setting's `name` field is used to identify the
        /// omnichannel setting to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated.
        /// 
        /// The following fields are supported in snake_case only:
        /// - `lsf_type`
        /// - `in_stock`
        /// - `pickup`
        /// - `odo`
        /// - `about`
        /// - `inventory_verification`
        /// 
        /// Full replacement with wildcard `*`is supported, while empty/implied update
        /// mask is not.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual OmnichannelSetting UpdateOmnichannelSetting(OmnichannelSetting omnichannelSetting, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateOmnichannelSetting(new UpdateOmnichannelSettingRequest
            {
                OmnichannelSetting = gax::GaxPreconditions.CheckNotNull(omnichannelSetting, nameof(omnichannelSetting)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Update the omnichannel setting for a given merchant in a given country.
        /// </summary>
        /// <param name="omnichannelSetting">
        /// Required. The omnichannel setting to update.
        /// 
        /// The omnichannel setting's `name` field is used to identify the
        /// omnichannel setting to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated.
        /// 
        /// The following fields are supported in snake_case only:
        /// - `lsf_type`
        /// - `in_stock`
        /// - `pickup`
        /// - `odo`
        /// - `about`
        /// - `inventory_verification`
        /// 
        /// Full replacement with wildcard `*`is supported, while empty/implied update
        /// mask is not.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OmnichannelSetting> UpdateOmnichannelSettingAsync(OmnichannelSetting omnichannelSetting, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateOmnichannelSettingAsync(new UpdateOmnichannelSettingRequest
            {
                OmnichannelSetting = gax::GaxPreconditions.CheckNotNull(omnichannelSetting, nameof(omnichannelSetting)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Update the omnichannel setting for a given merchant in a given country.
        /// </summary>
        /// <param name="omnichannelSetting">
        /// Required. The omnichannel setting to update.
        /// 
        /// The omnichannel setting's `name` field is used to identify the
        /// omnichannel setting to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to be updated.
        /// 
        /// The following fields are supported in snake_case only:
        /// - `lsf_type`
        /// - `in_stock`
        /// - `pickup`
        /// - `odo`
        /// - `about`
        /// - `inventory_verification`
        /// 
        /// Full replacement with wildcard `*`is supported, while empty/implied update
        /// mask is not.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OmnichannelSetting> UpdateOmnichannelSettingAsync(OmnichannelSetting omnichannelSetting, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateOmnichannelSettingAsync(omnichannelSetting, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Requests inventory verification for a given merchant in a given country.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RequestInventoryVerificationResponse RequestInventoryVerification(RequestInventoryVerificationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Requests inventory verification for a given merchant in a given country.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RequestInventoryVerificationResponse> RequestInventoryVerificationAsync(RequestInventoryVerificationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Requests inventory verification for a given merchant in a given country.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RequestInventoryVerificationResponse> RequestInventoryVerificationAsync(RequestInventoryVerificationRequest request, st::CancellationToken cancellationToken) =>
            RequestInventoryVerificationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Requests inventory verification for a given merchant in a given country.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the omnichannel setting to request inventory
        /// verification. Format:
        /// `accounts/{account}/omnichannelSettings/{omnichannel_setting}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RequestInventoryVerificationResponse RequestInventoryVerification(string name, gaxgrpc::CallSettings callSettings = null) =>
            RequestInventoryVerification(new RequestInventoryVerificationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Requests inventory verification for a given merchant in a given country.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the omnichannel setting to request inventory
        /// verification. Format:
        /// `accounts/{account}/omnichannelSettings/{omnichannel_setting}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RequestInventoryVerificationResponse> RequestInventoryVerificationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            RequestInventoryVerificationAsync(new RequestInventoryVerificationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Requests inventory verification for a given merchant in a given country.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the omnichannel setting to request inventory
        /// verification. Format:
        /// `accounts/{account}/omnichannelSettings/{omnichannel_setting}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RequestInventoryVerificationResponse> RequestInventoryVerificationAsync(string name, st::CancellationToken cancellationToken) =>
            RequestInventoryVerificationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Requests inventory verification for a given merchant in a given country.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the omnichannel setting to request inventory
        /// verification. Format:
        /// `accounts/{account}/omnichannelSettings/{omnichannel_setting}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RequestInventoryVerificationResponse RequestInventoryVerification(OmnichannelSettingName name, gaxgrpc::CallSettings callSettings = null) =>
            RequestInventoryVerification(new RequestInventoryVerificationRequest
            {
                OmnichannelSettingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Requests inventory verification for a given merchant in a given country.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the omnichannel setting to request inventory
        /// verification. Format:
        /// `accounts/{account}/omnichannelSettings/{omnichannel_setting}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RequestInventoryVerificationResponse> RequestInventoryVerificationAsync(OmnichannelSettingName name, gaxgrpc::CallSettings callSettings = null) =>
            RequestInventoryVerificationAsync(new RequestInventoryVerificationRequest
            {
                OmnichannelSettingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Requests inventory verification for a given merchant in a given country.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the omnichannel setting to request inventory
        /// verification. Format:
        /// `accounts/{account}/omnichannelSettings/{omnichannel_setting}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RequestInventoryVerificationResponse> RequestInventoryVerificationAsync(OmnichannelSettingName name, st::CancellationToken cancellationToken) =>
            RequestInventoryVerificationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>OmnichannelSettingsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The service facilitates the management of a merchant's omnichannel settings.
    /// ## This API defines the following resource model:
    /// 
    /// [OmnichannelSetting][google.shopping.merchant.accounts.v1.OmnichannelSetting]
    /// </remarks>
    public sealed partial class OmnichannelSettingsServiceClientImpl : OmnichannelSettingsServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetOmnichannelSettingRequest, OmnichannelSetting> _callGetOmnichannelSetting;

        private readonly gaxgrpc::ApiCall<ListOmnichannelSettingsRequest, ListOmnichannelSettingsResponse> _callListOmnichannelSettings;

        private readonly gaxgrpc::ApiCall<CreateOmnichannelSettingRequest, OmnichannelSetting> _callCreateOmnichannelSetting;

        private readonly gaxgrpc::ApiCall<UpdateOmnichannelSettingRequest, OmnichannelSetting> _callUpdateOmnichannelSetting;

        private readonly gaxgrpc::ApiCall<RequestInventoryVerificationRequest, RequestInventoryVerificationResponse> _callRequestInventoryVerification;

        /// <summary>
        /// Constructs a client wrapper for the OmnichannelSettingsService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="OmnichannelSettingsServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public OmnichannelSettingsServiceClientImpl(OmnichannelSettingsService.OmnichannelSettingsServiceClient grpcClient, OmnichannelSettingsServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            OmnichannelSettingsServiceSettings effectiveSettings = settings ?? OmnichannelSettingsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetOmnichannelSetting = clientHelper.BuildApiCall<GetOmnichannelSettingRequest, OmnichannelSetting>("GetOmnichannelSetting", grpcClient.GetOmnichannelSettingAsync, grpcClient.GetOmnichannelSetting, effectiveSettings.GetOmnichannelSettingSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetOmnichannelSetting);
            Modify_GetOmnichannelSettingApiCall(ref _callGetOmnichannelSetting);
            _callListOmnichannelSettings = clientHelper.BuildApiCall<ListOmnichannelSettingsRequest, ListOmnichannelSettingsResponse>("ListOmnichannelSettings", grpcClient.ListOmnichannelSettingsAsync, grpcClient.ListOmnichannelSettings, effectiveSettings.ListOmnichannelSettingsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListOmnichannelSettings);
            Modify_ListOmnichannelSettingsApiCall(ref _callListOmnichannelSettings);
            _callCreateOmnichannelSetting = clientHelper.BuildApiCall<CreateOmnichannelSettingRequest, OmnichannelSetting>("CreateOmnichannelSetting", grpcClient.CreateOmnichannelSettingAsync, grpcClient.CreateOmnichannelSetting, effectiveSettings.CreateOmnichannelSettingSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateOmnichannelSetting);
            Modify_CreateOmnichannelSettingApiCall(ref _callCreateOmnichannelSetting);
            _callUpdateOmnichannelSetting = clientHelper.BuildApiCall<UpdateOmnichannelSettingRequest, OmnichannelSetting>("UpdateOmnichannelSetting", grpcClient.UpdateOmnichannelSettingAsync, grpcClient.UpdateOmnichannelSetting, effectiveSettings.UpdateOmnichannelSettingSettings).WithGoogleRequestParam("omnichannel_setting.name", request => request.OmnichannelSetting?.Name);
            Modify_ApiCall(ref _callUpdateOmnichannelSetting);
            Modify_UpdateOmnichannelSettingApiCall(ref _callUpdateOmnichannelSetting);
            _callRequestInventoryVerification = clientHelper.BuildApiCall<RequestInventoryVerificationRequest, RequestInventoryVerificationResponse>("RequestInventoryVerification", grpcClient.RequestInventoryVerificationAsync, grpcClient.RequestInventoryVerification, effectiveSettings.RequestInventoryVerificationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRequestInventoryVerification);
            Modify_RequestInventoryVerificationApiCall(ref _callRequestInventoryVerification);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetOmnichannelSettingApiCall(ref gaxgrpc::ApiCall<GetOmnichannelSettingRequest, OmnichannelSetting> call);

        partial void Modify_ListOmnichannelSettingsApiCall(ref gaxgrpc::ApiCall<ListOmnichannelSettingsRequest, ListOmnichannelSettingsResponse> call);

        partial void Modify_CreateOmnichannelSettingApiCall(ref gaxgrpc::ApiCall<CreateOmnichannelSettingRequest, OmnichannelSetting> call);

        partial void Modify_UpdateOmnichannelSettingApiCall(ref gaxgrpc::ApiCall<UpdateOmnichannelSettingRequest, OmnichannelSetting> call);

        partial void Modify_RequestInventoryVerificationApiCall(ref gaxgrpc::ApiCall<RequestInventoryVerificationRequest, RequestInventoryVerificationResponse> call);

        partial void OnConstruction(OmnichannelSettingsService.OmnichannelSettingsServiceClient grpcClient, OmnichannelSettingsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC OmnichannelSettingsService client</summary>
        public override OmnichannelSettingsService.OmnichannelSettingsServiceClient GrpcClient { get; }

        partial void Modify_GetOmnichannelSettingRequest(ref GetOmnichannelSettingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListOmnichannelSettingsRequest(ref ListOmnichannelSettingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateOmnichannelSettingRequest(ref CreateOmnichannelSettingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateOmnichannelSettingRequest(ref UpdateOmnichannelSettingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RequestInventoryVerificationRequest(ref RequestInventoryVerificationRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Get the omnichannel settings for a given merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override OmnichannelSetting GetOmnichannelSetting(GetOmnichannelSettingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOmnichannelSettingRequest(ref request, ref callSettings);
            return _callGetOmnichannelSetting.Sync(request, callSettings);
        }

        /// <summary>
        /// Get the omnichannel settings for a given merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<OmnichannelSetting> GetOmnichannelSettingAsync(GetOmnichannelSettingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOmnichannelSettingRequest(ref request, ref callSettings);
            return _callGetOmnichannelSetting.Async(request, callSettings);
        }

        /// <summary>
        /// List all the omnichannel settings for a given merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="OmnichannelSetting"/> resources.</returns>
        public override gax::PagedEnumerable<ListOmnichannelSettingsResponse, OmnichannelSetting> ListOmnichannelSettings(ListOmnichannelSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOmnichannelSettingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListOmnichannelSettingsRequest, ListOmnichannelSettingsResponse, OmnichannelSetting>(_callListOmnichannelSettings, request, callSettings);
        }

        /// <summary>
        /// List all the omnichannel settings for a given merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="OmnichannelSetting"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListOmnichannelSettingsResponse, OmnichannelSetting> ListOmnichannelSettingsAsync(ListOmnichannelSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOmnichannelSettingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListOmnichannelSettingsRequest, ListOmnichannelSettingsResponse, OmnichannelSetting>(_callListOmnichannelSettings, request, callSettings);
        }

        /// <summary>
        /// Create the omnichannel settings for a given merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override OmnichannelSetting CreateOmnichannelSetting(CreateOmnichannelSettingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateOmnichannelSettingRequest(ref request, ref callSettings);
            return _callCreateOmnichannelSetting.Sync(request, callSettings);
        }

        /// <summary>
        /// Create the omnichannel settings for a given merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<OmnichannelSetting> CreateOmnichannelSettingAsync(CreateOmnichannelSettingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateOmnichannelSettingRequest(ref request, ref callSettings);
            return _callCreateOmnichannelSetting.Async(request, callSettings);
        }

        /// <summary>
        /// Update the omnichannel setting for a given merchant in a given country.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override OmnichannelSetting UpdateOmnichannelSetting(UpdateOmnichannelSettingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateOmnichannelSettingRequest(ref request, ref callSettings);
            return _callUpdateOmnichannelSetting.Sync(request, callSettings);
        }

        /// <summary>
        /// Update the omnichannel setting for a given merchant in a given country.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<OmnichannelSetting> UpdateOmnichannelSettingAsync(UpdateOmnichannelSettingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateOmnichannelSettingRequest(ref request, ref callSettings);
            return _callUpdateOmnichannelSetting.Async(request, callSettings);
        }

        /// <summary>
        /// Requests inventory verification for a given merchant in a given country.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RequestInventoryVerificationResponse RequestInventoryVerification(RequestInventoryVerificationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RequestInventoryVerificationRequest(ref request, ref callSettings);
            return _callRequestInventoryVerification.Sync(request, callSettings);
        }

        /// <summary>
        /// Requests inventory verification for a given merchant in a given country.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RequestInventoryVerificationResponse> RequestInventoryVerificationAsync(RequestInventoryVerificationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RequestInventoryVerificationRequest(ref request, ref callSettings);
            return _callRequestInventoryVerification.Async(request, callSettings);
        }
    }

    public partial class ListOmnichannelSettingsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListOmnichannelSettingsResponse : gaxgrpc::IPageResponse<OmnichannelSetting>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<OmnichannelSetting> GetEnumerator() => OmnichannelSettings.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
