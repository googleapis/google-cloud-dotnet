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

namespace Google.Shopping.Merchant.Lfp.V1Beta
{
    /// <summary>Settings for <see cref="LfpStoreServiceClient"/> instances.</summary>
    public sealed partial class LfpStoreServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="LfpStoreServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="LfpStoreServiceSettings"/>.</returns>
        public static LfpStoreServiceSettings GetDefault() => new LfpStoreServiceSettings();

        /// <summary>Constructs a new <see cref="LfpStoreServiceSettings"/> object with default settings.</summary>
        public LfpStoreServiceSettings()
        {
        }

        private LfpStoreServiceSettings(LfpStoreServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetLfpStoreSettings = existing.GetLfpStoreSettings;
            InsertLfpStoreSettings = existing.InsertLfpStoreSettings;
            DeleteLfpStoreSettings = existing.DeleteLfpStoreSettings;
            ListLfpStoresSettings = existing.ListLfpStoresSettings;
            OnCopy(existing);
        }

        partial void OnCopy(LfpStoreServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LfpStoreServiceClient.GetLfpStore</c> and <c>LfpStoreServiceClient.GetLfpStoreAsync</c>.
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
        public gaxgrpc::CallSettings GetLfpStoreSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LfpStoreServiceClient.InsertLfpStore</c> and <c>LfpStoreServiceClient.InsertLfpStoreAsync</c>.
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
        public gaxgrpc::CallSettings InsertLfpStoreSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LfpStoreServiceClient.DeleteLfpStore</c> and <c>LfpStoreServiceClient.DeleteLfpStoreAsync</c>.
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
        public gaxgrpc::CallSettings DeleteLfpStoreSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LfpStoreServiceClient.ListLfpStores</c> and <c>LfpStoreServiceClient.ListLfpStoresAsync</c>.
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
        public gaxgrpc::CallSettings ListLfpStoresSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="LfpStoreServiceSettings"/> object.</returns>
        public LfpStoreServiceSettings Clone() => new LfpStoreServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="LfpStoreServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class LfpStoreServiceClientBuilder : gaxgrpc::ClientBuilderBase<LfpStoreServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public LfpStoreServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public LfpStoreServiceClientBuilder() : base(LfpStoreServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref LfpStoreServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<LfpStoreServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override LfpStoreServiceClient Build()
        {
            LfpStoreServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<LfpStoreServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<LfpStoreServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private LfpStoreServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return LfpStoreServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<LfpStoreServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return LfpStoreServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => LfpStoreServiceClient.ChannelPool;
    }

    /// <summary>LfpStoreService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for a [LFP
    /// partner](https://support.google.com/merchants/answer/7676652) to submit local
    /// stores for a merchant.
    /// </remarks>
    public abstract partial class LfpStoreServiceClient
    {
        /// <summary>
        /// The default endpoint for the LfpStoreService service, which is a host of "merchantapi.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "merchantapi.googleapis.com:443";

        /// <summary>The default LfpStoreService scopes.</summary>
        /// <remarks>
        /// The default LfpStoreService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/content</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/content",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(LfpStoreService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="LfpStoreServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="LfpStoreServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="LfpStoreServiceClient"/>.</returns>
        public static stt::Task<LfpStoreServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new LfpStoreServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="LfpStoreServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="LfpStoreServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="LfpStoreServiceClient"/>.</returns>
        public static LfpStoreServiceClient Create() => new LfpStoreServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="LfpStoreServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="LfpStoreServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="LfpStoreServiceClient"/>.</returns>
        internal static LfpStoreServiceClient Create(grpccore::CallInvoker callInvoker, LfpStoreServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            LfpStoreService.LfpStoreServiceClient grpcClient = new LfpStoreService.LfpStoreServiceClient(callInvoker);
            return new LfpStoreServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC LfpStoreService client</summary>
        public virtual LfpStoreService.LfpStoreServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves information about a store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LfpStore GetLfpStore(GetLfpStoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves information about a store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LfpStore> GetLfpStoreAsync(GetLfpStoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves information about a store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LfpStore> GetLfpStoreAsync(GetLfpStoreRequest request, st::CancellationToken cancellationToken) =>
            GetLfpStoreAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves information about a store.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the store to retrieve.
        /// Format: `accounts/{account}/lfpStores/{target_merchant}~{store_code}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LfpStore GetLfpStore(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetLfpStore(new GetLfpStoreRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves information about a store.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the store to retrieve.
        /// Format: `accounts/{account}/lfpStores/{target_merchant}~{store_code}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LfpStore> GetLfpStoreAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetLfpStoreAsync(new GetLfpStoreRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves information about a store.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the store to retrieve.
        /// Format: `accounts/{account}/lfpStores/{target_merchant}~{store_code}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LfpStore> GetLfpStoreAsync(string name, st::CancellationToken cancellationToken) =>
            GetLfpStoreAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves information about a store.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the store to retrieve.
        /// Format: `accounts/{account}/lfpStores/{target_merchant}~{store_code}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LfpStore GetLfpStore(LfpStoreName name, gaxgrpc::CallSettings callSettings = null) =>
            GetLfpStore(new GetLfpStoreRequest
            {
                LfpStoreName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves information about a store.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the store to retrieve.
        /// Format: `accounts/{account}/lfpStores/{target_merchant}~{store_code}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LfpStore> GetLfpStoreAsync(LfpStoreName name, gaxgrpc::CallSettings callSettings = null) =>
            GetLfpStoreAsync(new GetLfpStoreRequest
            {
                LfpStoreName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves information about a store.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the store to retrieve.
        /// Format: `accounts/{account}/lfpStores/{target_merchant}~{store_code}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LfpStore> GetLfpStoreAsync(LfpStoreName name, st::CancellationToken cancellationToken) =>
            GetLfpStoreAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Inserts a store for the target merchant. If the store with the same store
        /// code already exists, it will be replaced.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LfpStore InsertLfpStore(InsertLfpStoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Inserts a store for the target merchant. If the store with the same store
        /// code already exists, it will be replaced.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LfpStore> InsertLfpStoreAsync(InsertLfpStoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Inserts a store for the target merchant. If the store with the same store
        /// code already exists, it will be replaced.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LfpStore> InsertLfpStoreAsync(InsertLfpStoreRequest request, st::CancellationToken cancellationToken) =>
            InsertLfpStoreAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Inserts a store for the target merchant. If the store with the same store
        /// code already exists, it will be replaced.
        /// </summary>
        /// <param name="parent">
        /// Required. The LFP provider account
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="lfpStore">
        /// Required. The store to insert.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LfpStore InsertLfpStore(string parent, LfpStore lfpStore, gaxgrpc::CallSettings callSettings = null) =>
            InsertLfpStore(new InsertLfpStoreRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                LfpStore = gax::GaxPreconditions.CheckNotNull(lfpStore, nameof(lfpStore)),
            }, callSettings);

        /// <summary>
        /// Inserts a store for the target merchant. If the store with the same store
        /// code already exists, it will be replaced.
        /// </summary>
        /// <param name="parent">
        /// Required. The LFP provider account
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="lfpStore">
        /// Required. The store to insert.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LfpStore> InsertLfpStoreAsync(string parent, LfpStore lfpStore, gaxgrpc::CallSettings callSettings = null) =>
            InsertLfpStoreAsync(new InsertLfpStoreRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                LfpStore = gax::GaxPreconditions.CheckNotNull(lfpStore, nameof(lfpStore)),
            }, callSettings);

        /// <summary>
        /// Inserts a store for the target merchant. If the store with the same store
        /// code already exists, it will be replaced.
        /// </summary>
        /// <param name="parent">
        /// Required. The LFP provider account
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="lfpStore">
        /// Required. The store to insert.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LfpStore> InsertLfpStoreAsync(string parent, LfpStore lfpStore, st::CancellationToken cancellationToken) =>
            InsertLfpStoreAsync(parent, lfpStore, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Inserts a store for the target merchant. If the store with the same store
        /// code already exists, it will be replaced.
        /// </summary>
        /// <param name="parent">
        /// Required. The LFP provider account
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="lfpStore">
        /// Required. The store to insert.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LfpStore InsertLfpStore(AccountName parent, LfpStore lfpStore, gaxgrpc::CallSettings callSettings = null) =>
            InsertLfpStore(new InsertLfpStoreRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LfpStore = gax::GaxPreconditions.CheckNotNull(lfpStore, nameof(lfpStore)),
            }, callSettings);

        /// <summary>
        /// Inserts a store for the target merchant. If the store with the same store
        /// code already exists, it will be replaced.
        /// </summary>
        /// <param name="parent">
        /// Required. The LFP provider account
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="lfpStore">
        /// Required. The store to insert.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LfpStore> InsertLfpStoreAsync(AccountName parent, LfpStore lfpStore, gaxgrpc::CallSettings callSettings = null) =>
            InsertLfpStoreAsync(new InsertLfpStoreRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LfpStore = gax::GaxPreconditions.CheckNotNull(lfpStore, nameof(lfpStore)),
            }, callSettings);

        /// <summary>
        /// Inserts a store for the target merchant. If the store with the same store
        /// code already exists, it will be replaced.
        /// </summary>
        /// <param name="parent">
        /// Required. The LFP provider account
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="lfpStore">
        /// Required. The store to insert.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LfpStore> InsertLfpStoreAsync(AccountName parent, LfpStore lfpStore, st::CancellationToken cancellationToken) =>
            InsertLfpStoreAsync(parent, lfpStore, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a store for a target merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteLfpStore(DeleteLfpStoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a store for a target merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteLfpStoreAsync(DeleteLfpStoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a store for a target merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteLfpStoreAsync(DeleteLfpStoreRequest request, st::CancellationToken cancellationToken) =>
            DeleteLfpStoreAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a store for a target merchant.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the store to delete for the target merchant account.
        /// Format: `accounts/{account}/lfpStores/{target_merchant}~{store_code}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteLfpStore(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteLfpStore(new DeleteLfpStoreRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a store for a target merchant.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the store to delete for the target merchant account.
        /// Format: `accounts/{account}/lfpStores/{target_merchant}~{store_code}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteLfpStoreAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteLfpStoreAsync(new DeleteLfpStoreRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a store for a target merchant.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the store to delete for the target merchant account.
        /// Format: `accounts/{account}/lfpStores/{target_merchant}~{store_code}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteLfpStoreAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteLfpStoreAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a store for a target merchant.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the store to delete for the target merchant account.
        /// Format: `accounts/{account}/lfpStores/{target_merchant}~{store_code}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteLfpStore(LfpStoreName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteLfpStore(new DeleteLfpStoreRequest
            {
                LfpStoreName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a store for a target merchant.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the store to delete for the target merchant account.
        /// Format: `accounts/{account}/lfpStores/{target_merchant}~{store_code}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteLfpStoreAsync(LfpStoreName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteLfpStoreAsync(new DeleteLfpStoreRequest
            {
                LfpStoreName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a store for a target merchant.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the store to delete for the target merchant account.
        /// Format: `accounts/{account}/lfpStores/{target_merchant}~{store_code}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteLfpStoreAsync(LfpStoreName name, st::CancellationToken cancellationToken) =>
            DeleteLfpStoreAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the stores of the target merchant, specified by the filter in
        /// `ListLfpStoresRequest`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LfpStore"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLfpStoresResponse, LfpStore> ListLfpStores(ListLfpStoresRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the stores of the target merchant, specified by the filter in
        /// `ListLfpStoresRequest`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LfpStore"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLfpStoresResponse, LfpStore> ListLfpStoresAsync(ListLfpStoresRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the stores of the target merchant, specified by the filter in
        /// `ListLfpStoresRequest`.
        /// </summary>
        /// <param name="parent">
        /// Required. The LFP partner.
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
        /// <returns>A pageable sequence of <see cref="LfpStore"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLfpStoresResponse, LfpStore> ListLfpStores(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLfpStoresRequest request = new ListLfpStoresRequest
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
            return ListLfpStores(request, callSettings);
        }

        /// <summary>
        /// Lists the stores of the target merchant, specified by the filter in
        /// `ListLfpStoresRequest`.
        /// </summary>
        /// <param name="parent">
        /// Required. The LFP partner.
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
        /// <returns>A pageable asynchronous sequence of <see cref="LfpStore"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLfpStoresResponse, LfpStore> ListLfpStoresAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLfpStoresRequest request = new ListLfpStoresRequest
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
            return ListLfpStoresAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the stores of the target merchant, specified by the filter in
        /// `ListLfpStoresRequest`.
        /// </summary>
        /// <param name="parent">
        /// Required. The LFP partner.
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
        /// <returns>A pageable sequence of <see cref="LfpStore"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLfpStoresResponse, LfpStore> ListLfpStores(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLfpStoresRequest request = new ListLfpStoresRequest
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
            return ListLfpStores(request, callSettings);
        }

        /// <summary>
        /// Lists the stores of the target merchant, specified by the filter in
        /// `ListLfpStoresRequest`.
        /// </summary>
        /// <param name="parent">
        /// Required. The LFP partner.
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
        /// <returns>A pageable asynchronous sequence of <see cref="LfpStore"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLfpStoresResponse, LfpStore> ListLfpStoresAsync(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLfpStoresRequest request = new ListLfpStoresRequest
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
            return ListLfpStoresAsync(request, callSettings);
        }
    }

    /// <summary>LfpStoreService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for a [LFP
    /// partner](https://support.google.com/merchants/answer/7676652) to submit local
    /// stores for a merchant.
    /// </remarks>
    public sealed partial class LfpStoreServiceClientImpl : LfpStoreServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetLfpStoreRequest, LfpStore> _callGetLfpStore;

        private readonly gaxgrpc::ApiCall<InsertLfpStoreRequest, LfpStore> _callInsertLfpStore;

        private readonly gaxgrpc::ApiCall<DeleteLfpStoreRequest, wkt::Empty> _callDeleteLfpStore;

        private readonly gaxgrpc::ApiCall<ListLfpStoresRequest, ListLfpStoresResponse> _callListLfpStores;

        /// <summary>
        /// Constructs a client wrapper for the LfpStoreService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="LfpStoreServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public LfpStoreServiceClientImpl(LfpStoreService.LfpStoreServiceClient grpcClient, LfpStoreServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            LfpStoreServiceSettings effectiveSettings = settings ?? LfpStoreServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetLfpStore = clientHelper.BuildApiCall<GetLfpStoreRequest, LfpStore>("GetLfpStore", grpcClient.GetLfpStoreAsync, grpcClient.GetLfpStore, effectiveSettings.GetLfpStoreSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetLfpStore);
            Modify_GetLfpStoreApiCall(ref _callGetLfpStore);
            _callInsertLfpStore = clientHelper.BuildApiCall<InsertLfpStoreRequest, LfpStore>("InsertLfpStore", grpcClient.InsertLfpStoreAsync, grpcClient.InsertLfpStore, effectiveSettings.InsertLfpStoreSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callInsertLfpStore);
            Modify_InsertLfpStoreApiCall(ref _callInsertLfpStore);
            _callDeleteLfpStore = clientHelper.BuildApiCall<DeleteLfpStoreRequest, wkt::Empty>("DeleteLfpStore", grpcClient.DeleteLfpStoreAsync, grpcClient.DeleteLfpStore, effectiveSettings.DeleteLfpStoreSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteLfpStore);
            Modify_DeleteLfpStoreApiCall(ref _callDeleteLfpStore);
            _callListLfpStores = clientHelper.BuildApiCall<ListLfpStoresRequest, ListLfpStoresResponse>("ListLfpStores", grpcClient.ListLfpStoresAsync, grpcClient.ListLfpStores, effectiveSettings.ListLfpStoresSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListLfpStores);
            Modify_ListLfpStoresApiCall(ref _callListLfpStores);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetLfpStoreApiCall(ref gaxgrpc::ApiCall<GetLfpStoreRequest, LfpStore> call);

        partial void Modify_InsertLfpStoreApiCall(ref gaxgrpc::ApiCall<InsertLfpStoreRequest, LfpStore> call);

        partial void Modify_DeleteLfpStoreApiCall(ref gaxgrpc::ApiCall<DeleteLfpStoreRequest, wkt::Empty> call);

        partial void Modify_ListLfpStoresApiCall(ref gaxgrpc::ApiCall<ListLfpStoresRequest, ListLfpStoresResponse> call);

        partial void OnConstruction(LfpStoreService.LfpStoreServiceClient grpcClient, LfpStoreServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC LfpStoreService client</summary>
        public override LfpStoreService.LfpStoreServiceClient GrpcClient { get; }

        partial void Modify_GetLfpStoreRequest(ref GetLfpStoreRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_InsertLfpStoreRequest(ref InsertLfpStoreRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteLfpStoreRequest(ref DeleteLfpStoreRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListLfpStoresRequest(ref ListLfpStoresRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves information about a store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LfpStore GetLfpStore(GetLfpStoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLfpStoreRequest(ref request, ref callSettings);
            return _callGetLfpStore.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves information about a store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LfpStore> GetLfpStoreAsync(GetLfpStoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLfpStoreRequest(ref request, ref callSettings);
            return _callGetLfpStore.Async(request, callSettings);
        }

        /// <summary>
        /// Inserts a store for the target merchant. If the store with the same store
        /// code already exists, it will be replaced.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LfpStore InsertLfpStore(InsertLfpStoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertLfpStoreRequest(ref request, ref callSettings);
            return _callInsertLfpStore.Sync(request, callSettings);
        }

        /// <summary>
        /// Inserts a store for the target merchant. If the store with the same store
        /// code already exists, it will be replaced.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LfpStore> InsertLfpStoreAsync(InsertLfpStoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertLfpStoreRequest(ref request, ref callSettings);
            return _callInsertLfpStore.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a store for a target merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteLfpStore(DeleteLfpStoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteLfpStoreRequest(ref request, ref callSettings);
            _callDeleteLfpStore.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a store for a target merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteLfpStoreAsync(DeleteLfpStoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteLfpStoreRequest(ref request, ref callSettings);
            return _callDeleteLfpStore.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the stores of the target merchant, specified by the filter in
        /// `ListLfpStoresRequest`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LfpStore"/> resources.</returns>
        public override gax::PagedEnumerable<ListLfpStoresResponse, LfpStore> ListLfpStores(ListLfpStoresRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLfpStoresRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListLfpStoresRequest, ListLfpStoresResponse, LfpStore>(_callListLfpStores, request, callSettings);
        }

        /// <summary>
        /// Lists the stores of the target merchant, specified by the filter in
        /// `ListLfpStoresRequest`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LfpStore"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListLfpStoresResponse, LfpStore> ListLfpStoresAsync(ListLfpStoresRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLfpStoresRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListLfpStoresRequest, ListLfpStoresResponse, LfpStore>(_callListLfpStores, request, callSettings);
        }
    }

    public partial class ListLfpStoresRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListLfpStoresResponse : gaxgrpc::IPageResponse<LfpStore>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<LfpStore> GetEnumerator() => LfpStores.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
