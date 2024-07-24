// Copyright 2024 Google LLC
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
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.RecommendationEngine.V1Beta1
{
    /// <summary>Settings for <see cref="CatalogServiceClient"/> instances.</summary>
    public sealed partial class CatalogServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CatalogServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CatalogServiceSettings"/>.</returns>
        public static CatalogServiceSettings GetDefault() => new CatalogServiceSettings();

        /// <summary>Constructs a new <see cref="CatalogServiceSettings"/> object with default settings.</summary>
        public CatalogServiceSettings()
        {
        }

        private CatalogServiceSettings(CatalogServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateCatalogItemSettings = existing.CreateCatalogItemSettings;
            GetCatalogItemSettings = existing.GetCatalogItemSettings;
            ListCatalogItemsSettings = existing.ListCatalogItemsSettings;
            UpdateCatalogItemSettings = existing.UpdateCatalogItemSettings;
            DeleteCatalogItemSettings = existing.DeleteCatalogItemSettings;
            ImportCatalogItemsSettings = existing.ImportCatalogItemsSettings;
            ImportCatalogItemsOperationsSettings = existing.ImportCatalogItemsOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(CatalogServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CatalogServiceClient.CreateCatalogItem</c> and <c>CatalogServiceClient.CreateCatalogItemAsync</c>.
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
        public gaxgrpc::CallSettings CreateCatalogItemSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CatalogServiceClient.GetCatalogItem</c> and <c>CatalogServiceClient.GetCatalogItemAsync</c>.
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
        public gaxgrpc::CallSettings GetCatalogItemSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CatalogServiceClient.ListCatalogItems</c> and <c>CatalogServiceClient.ListCatalogItemsAsync</c>.
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
        public gaxgrpc::CallSettings ListCatalogItemsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CatalogServiceClient.UpdateCatalogItem</c> and <c>CatalogServiceClient.UpdateCatalogItemAsync</c>.
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
        public gaxgrpc::CallSettings UpdateCatalogItemSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CatalogServiceClient.DeleteCatalogItem</c> and <c>CatalogServiceClient.DeleteCatalogItemAsync</c>.
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
        public gaxgrpc::CallSettings DeleteCatalogItemSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CatalogServiceClient.ImportCatalogItems</c> and <c>CatalogServiceClient.ImportCatalogItemsAsync</c>.
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
        public gaxgrpc::CallSettings ImportCatalogItemsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CatalogServiceClient.ImportCatalogItems</c> and
        /// <c>CatalogServiceClient.ImportCatalogItemsAsync</c>.
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
        public lro::OperationsSettings ImportCatalogItemsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CatalogServiceSettings"/> object.</returns>
        public CatalogServiceSettings Clone() => new CatalogServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CatalogServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class CatalogServiceClientBuilder : gaxgrpc::ClientBuilderBase<CatalogServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CatalogServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CatalogServiceClientBuilder() : base(CatalogServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CatalogServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CatalogServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CatalogServiceClient Build()
        {
            CatalogServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CatalogServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CatalogServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CatalogServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CatalogServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CatalogServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CatalogServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CatalogServiceClient.ChannelPool;
    }

    /// <summary>CatalogService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for ingesting catalog information of the customer's website.
    /// </remarks>
    public abstract partial class CatalogServiceClient
    {
        /// <summary>
        /// The default endpoint for the CatalogService service, which is a host of
        /// "recommendationengine.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "recommendationengine.googleapis.com:443";

        /// <summary>The default CatalogService scopes.</summary>
        /// <remarks>
        /// The default CatalogService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CatalogService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CatalogServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CatalogServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CatalogServiceClient"/>.</returns>
        public static stt::Task<CatalogServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CatalogServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CatalogServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CatalogServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CatalogServiceClient"/>.</returns>
        public static CatalogServiceClient Create() => new CatalogServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CatalogServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CatalogServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CatalogServiceClient"/>.</returns>
        internal static CatalogServiceClient Create(grpccore::CallInvoker callInvoker, CatalogServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CatalogService.CatalogServiceClient grpcClient = new CatalogService.CatalogServiceClient(callInvoker);
            return new CatalogServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CatalogService client</summary>
        public virtual CatalogService.CatalogServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a catalog item.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CatalogItem CreateCatalogItem(CreateCatalogItemRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a catalog item.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CatalogItem> CreateCatalogItemAsync(CreateCatalogItemRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a catalog item.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CatalogItem> CreateCatalogItemAsync(CreateCatalogItemRequest request, st::CancellationToken cancellationToken) =>
            CreateCatalogItemAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a catalog item.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent catalog resource name, such as
        /// `projects/*/locations/global/catalogs/default_catalog`.
        /// </param>
        /// <param name="catalogItem">
        /// Required. The catalog item to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CatalogItem CreateCatalogItem(string parent, CatalogItem catalogItem, gaxgrpc::CallSettings callSettings = null) =>
            CreateCatalogItem(new CreateCatalogItemRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CatalogItem = gax::GaxPreconditions.CheckNotNull(catalogItem, nameof(catalogItem)),
            }, callSettings);

        /// <summary>
        /// Creates a catalog item.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent catalog resource name, such as
        /// `projects/*/locations/global/catalogs/default_catalog`.
        /// </param>
        /// <param name="catalogItem">
        /// Required. The catalog item to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CatalogItem> CreateCatalogItemAsync(string parent, CatalogItem catalogItem, gaxgrpc::CallSettings callSettings = null) =>
            CreateCatalogItemAsync(new CreateCatalogItemRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CatalogItem = gax::GaxPreconditions.CheckNotNull(catalogItem, nameof(catalogItem)),
            }, callSettings);

        /// <summary>
        /// Creates a catalog item.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent catalog resource name, such as
        /// `projects/*/locations/global/catalogs/default_catalog`.
        /// </param>
        /// <param name="catalogItem">
        /// Required. The catalog item to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CatalogItem> CreateCatalogItemAsync(string parent, CatalogItem catalogItem, st::CancellationToken cancellationToken) =>
            CreateCatalogItemAsync(parent, catalogItem, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a catalog item.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent catalog resource name, such as
        /// `projects/*/locations/global/catalogs/default_catalog`.
        /// </param>
        /// <param name="catalogItem">
        /// Required. The catalog item to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CatalogItem CreateCatalogItem(CatalogName parent, CatalogItem catalogItem, gaxgrpc::CallSettings callSettings = null) =>
            CreateCatalogItem(new CreateCatalogItemRequest
            {
                ParentAsCatalogName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CatalogItem = gax::GaxPreconditions.CheckNotNull(catalogItem, nameof(catalogItem)),
            }, callSettings);

        /// <summary>
        /// Creates a catalog item.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent catalog resource name, such as
        /// `projects/*/locations/global/catalogs/default_catalog`.
        /// </param>
        /// <param name="catalogItem">
        /// Required. The catalog item to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CatalogItem> CreateCatalogItemAsync(CatalogName parent, CatalogItem catalogItem, gaxgrpc::CallSettings callSettings = null) =>
            CreateCatalogItemAsync(new CreateCatalogItemRequest
            {
                ParentAsCatalogName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CatalogItem = gax::GaxPreconditions.CheckNotNull(catalogItem, nameof(catalogItem)),
            }, callSettings);

        /// <summary>
        /// Creates a catalog item.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent catalog resource name, such as
        /// `projects/*/locations/global/catalogs/default_catalog`.
        /// </param>
        /// <param name="catalogItem">
        /// Required. The catalog item to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CatalogItem> CreateCatalogItemAsync(CatalogName parent, CatalogItem catalogItem, st::CancellationToken cancellationToken) =>
            CreateCatalogItemAsync(parent, catalogItem, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a specific catalog item.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CatalogItem GetCatalogItem(GetCatalogItemRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a specific catalog item.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CatalogItem> GetCatalogItemAsync(GetCatalogItemRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a specific catalog item.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CatalogItem> GetCatalogItemAsync(GetCatalogItemRequest request, st::CancellationToken cancellationToken) =>
            GetCatalogItemAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a specific catalog item.
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of catalog item, such as
        /// `projects/*/locations/global/catalogs/default_catalog/catalogitems/some_catalog_item_id`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CatalogItem GetCatalogItem(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCatalogItem(new GetCatalogItemRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a specific catalog item.
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of catalog item, such as
        /// `projects/*/locations/global/catalogs/default_catalog/catalogitems/some_catalog_item_id`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CatalogItem> GetCatalogItemAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCatalogItemAsync(new GetCatalogItemRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a specific catalog item.
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of catalog item, such as
        /// `projects/*/locations/global/catalogs/default_catalog/catalogitems/some_catalog_item_id`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CatalogItem> GetCatalogItemAsync(string name, st::CancellationToken cancellationToken) =>
            GetCatalogItemAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a specific catalog item.
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of catalog item, such as
        /// `projects/*/locations/global/catalogs/default_catalog/catalogitems/some_catalog_item_id`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CatalogItem GetCatalogItem(CatalogItemPathName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCatalogItem(new GetCatalogItemRequest
            {
                CatalogItemPathName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a specific catalog item.
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of catalog item, such as
        /// `projects/*/locations/global/catalogs/default_catalog/catalogitems/some_catalog_item_id`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CatalogItem> GetCatalogItemAsync(CatalogItemPathName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCatalogItemAsync(new GetCatalogItemRequest
            {
                CatalogItemPathName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a specific catalog item.
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of catalog item, such as
        /// `projects/*/locations/global/catalogs/default_catalog/catalogitems/some_catalog_item_id`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CatalogItem> GetCatalogItemAsync(CatalogItemPathName name, st::CancellationToken cancellationToken) =>
            GetCatalogItemAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a list of catalog items.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CatalogItem"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCatalogItemsResponse, CatalogItem> ListCatalogItems(ListCatalogItemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a list of catalog items.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CatalogItem"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCatalogItemsResponse, CatalogItem> ListCatalogItemsAsync(ListCatalogItemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a list of catalog items.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent catalog resource name, such as
        /// `projects/*/locations/global/catalogs/default_catalog`.
        /// </param>
        /// <param name="filter">
        /// Optional. A filter to apply on the list results.
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
        /// <returns>A pageable sequence of <see cref="CatalogItem"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCatalogItemsResponse, CatalogItem> ListCatalogItems(string parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCatalogItemsRequest request = new ListCatalogItemsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Filter = filter ?? "",
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCatalogItems(request, callSettings);
        }

        /// <summary>
        /// Gets a list of catalog items.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent catalog resource name, such as
        /// `projects/*/locations/global/catalogs/default_catalog`.
        /// </param>
        /// <param name="filter">
        /// Optional. A filter to apply on the list results.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CatalogItem"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCatalogItemsResponse, CatalogItem> ListCatalogItemsAsync(string parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCatalogItemsRequest request = new ListCatalogItemsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Filter = filter ?? "",
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCatalogItemsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a list of catalog items.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent catalog resource name, such as
        /// `projects/*/locations/global/catalogs/default_catalog`.
        /// </param>
        /// <param name="filter">
        /// Optional. A filter to apply on the list results.
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
        /// <returns>A pageable sequence of <see cref="CatalogItem"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCatalogItemsResponse, CatalogItem> ListCatalogItems(CatalogName parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCatalogItemsRequest request = new ListCatalogItemsRequest
            {
                ParentAsCatalogName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Filter = filter ?? "",
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCatalogItems(request, callSettings);
        }

        /// <summary>
        /// Gets a list of catalog items.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent catalog resource name, such as
        /// `projects/*/locations/global/catalogs/default_catalog`.
        /// </param>
        /// <param name="filter">
        /// Optional. A filter to apply on the list results.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CatalogItem"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCatalogItemsResponse, CatalogItem> ListCatalogItemsAsync(CatalogName parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCatalogItemsRequest request = new ListCatalogItemsRequest
            {
                ParentAsCatalogName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Filter = filter ?? "",
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCatalogItemsAsync(request, callSettings);
        }

        /// <summary>
        /// Updates a catalog item. Partial updating is supported. Non-existing
        /// items will be created.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CatalogItem UpdateCatalogItem(UpdateCatalogItemRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a catalog item. Partial updating is supported. Non-existing
        /// items will be created.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CatalogItem> UpdateCatalogItemAsync(UpdateCatalogItemRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a catalog item. Partial updating is supported. Non-existing
        /// items will be created.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CatalogItem> UpdateCatalogItemAsync(UpdateCatalogItemRequest request, st::CancellationToken cancellationToken) =>
            UpdateCatalogItemAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a catalog item. Partial updating is supported. Non-existing
        /// items will be created.
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of catalog item, such as
        /// `projects/*/locations/global/catalogs/default_catalog/catalogItems/some_catalog_item_id`.
        /// </param>
        /// <param name="catalogItem">
        /// Required. The catalog item to update/create. The 'catalog_item_id' field
        /// has to match that in the 'name'.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Indicates which fields in the provided 'item' to update. If not
        /// set, will by default update all fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CatalogItem UpdateCatalogItem(string name, CatalogItem catalogItem, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCatalogItem(new UpdateCatalogItemRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                CatalogItem = gax::GaxPreconditions.CheckNotNull(catalogItem, nameof(catalogItem)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a catalog item. Partial updating is supported. Non-existing
        /// items will be created.
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of catalog item, such as
        /// `projects/*/locations/global/catalogs/default_catalog/catalogItems/some_catalog_item_id`.
        /// </param>
        /// <param name="catalogItem">
        /// Required. The catalog item to update/create. The 'catalog_item_id' field
        /// has to match that in the 'name'.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Indicates which fields in the provided 'item' to update. If not
        /// set, will by default update all fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CatalogItem> UpdateCatalogItemAsync(string name, CatalogItem catalogItem, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCatalogItemAsync(new UpdateCatalogItemRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                CatalogItem = gax::GaxPreconditions.CheckNotNull(catalogItem, nameof(catalogItem)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a catalog item. Partial updating is supported. Non-existing
        /// items will be created.
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of catalog item, such as
        /// `projects/*/locations/global/catalogs/default_catalog/catalogItems/some_catalog_item_id`.
        /// </param>
        /// <param name="catalogItem">
        /// Required. The catalog item to update/create. The 'catalog_item_id' field
        /// has to match that in the 'name'.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Indicates which fields in the provided 'item' to update. If not
        /// set, will by default update all fields.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CatalogItem> UpdateCatalogItemAsync(string name, CatalogItem catalogItem, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateCatalogItemAsync(name, catalogItem, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a catalog item. Partial updating is supported. Non-existing
        /// items will be created.
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of catalog item, such as
        /// `projects/*/locations/global/catalogs/default_catalog/catalogItems/some_catalog_item_id`.
        /// </param>
        /// <param name="catalogItem">
        /// Required. The catalog item to update/create. The 'catalog_item_id' field
        /// has to match that in the 'name'.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Indicates which fields in the provided 'item' to update. If not
        /// set, will by default update all fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CatalogItem UpdateCatalogItem(CatalogItemPathName name, CatalogItem catalogItem, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCatalogItem(new UpdateCatalogItemRequest
            {
                CatalogItemPathName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                CatalogItem = gax::GaxPreconditions.CheckNotNull(catalogItem, nameof(catalogItem)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a catalog item. Partial updating is supported. Non-existing
        /// items will be created.
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of catalog item, such as
        /// `projects/*/locations/global/catalogs/default_catalog/catalogItems/some_catalog_item_id`.
        /// </param>
        /// <param name="catalogItem">
        /// Required. The catalog item to update/create. The 'catalog_item_id' field
        /// has to match that in the 'name'.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Indicates which fields in the provided 'item' to update. If not
        /// set, will by default update all fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CatalogItem> UpdateCatalogItemAsync(CatalogItemPathName name, CatalogItem catalogItem, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCatalogItemAsync(new UpdateCatalogItemRequest
            {
                CatalogItemPathName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                CatalogItem = gax::GaxPreconditions.CheckNotNull(catalogItem, nameof(catalogItem)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a catalog item. Partial updating is supported. Non-existing
        /// items will be created.
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of catalog item, such as
        /// `projects/*/locations/global/catalogs/default_catalog/catalogItems/some_catalog_item_id`.
        /// </param>
        /// <param name="catalogItem">
        /// Required. The catalog item to update/create. The 'catalog_item_id' field
        /// has to match that in the 'name'.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Indicates which fields in the provided 'item' to update. If not
        /// set, will by default update all fields.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CatalogItem> UpdateCatalogItemAsync(CatalogItemPathName name, CatalogItem catalogItem, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateCatalogItemAsync(name, catalogItem, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a catalog item.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteCatalogItem(DeleteCatalogItemRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a catalog item.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCatalogItemAsync(DeleteCatalogItemRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a catalog item.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCatalogItemAsync(DeleteCatalogItemRequest request, st::CancellationToken cancellationToken) =>
            DeleteCatalogItemAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a catalog item.
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of catalog item, such as
        /// `projects/*/locations/global/catalogs/default_catalog/catalogItems/some_catalog_item_id`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteCatalogItem(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCatalogItem(new DeleteCatalogItemRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a catalog item.
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of catalog item, such as
        /// `projects/*/locations/global/catalogs/default_catalog/catalogItems/some_catalog_item_id`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCatalogItemAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCatalogItemAsync(new DeleteCatalogItemRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a catalog item.
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of catalog item, such as
        /// `projects/*/locations/global/catalogs/default_catalog/catalogItems/some_catalog_item_id`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCatalogItemAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteCatalogItemAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a catalog item.
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of catalog item, such as
        /// `projects/*/locations/global/catalogs/default_catalog/catalogItems/some_catalog_item_id`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteCatalogItem(CatalogItemPathName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCatalogItem(new DeleteCatalogItemRequest
            {
                CatalogItemPathName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a catalog item.
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of catalog item, such as
        /// `projects/*/locations/global/catalogs/default_catalog/catalogItems/some_catalog_item_id`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCatalogItemAsync(CatalogItemPathName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCatalogItemAsync(new DeleteCatalogItemRequest
            {
                CatalogItemPathName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a catalog item.
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of catalog item, such as
        /// `projects/*/locations/global/catalogs/default_catalog/catalogItems/some_catalog_item_id`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCatalogItemAsync(CatalogItemPathName name, st::CancellationToken cancellationToken) =>
            DeleteCatalogItemAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Bulk import of multiple catalog items. Request processing may be
        /// synchronous. No partial updating supported. Non-existing items will be
        /// created.
        /// 
        /// Operation.response is of type ImportResponse. Note that it is
        /// possible for a subset of the items to be successfully updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportCatalogItemsResponse, ImportMetadata> ImportCatalogItems(ImportCatalogItemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Bulk import of multiple catalog items. Request processing may be
        /// synchronous. No partial updating supported. Non-existing items will be
        /// created.
        /// 
        /// Operation.response is of type ImportResponse. Note that it is
        /// possible for a subset of the items to be successfully updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportCatalogItemsResponse, ImportMetadata>> ImportCatalogItemsAsync(ImportCatalogItemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Bulk import of multiple catalog items. Request processing may be
        /// synchronous. No partial updating supported. Non-existing items will be
        /// created.
        /// 
        /// Operation.response is of type ImportResponse. Note that it is
        /// possible for a subset of the items to be successfully updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportCatalogItemsResponse, ImportMetadata>> ImportCatalogItemsAsync(ImportCatalogItemsRequest request, st::CancellationToken cancellationToken) =>
            ImportCatalogItemsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ImportCatalogItems</c>.</summary>
        public virtual lro::OperationsClient ImportCatalogItemsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ImportCatalogItems</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ImportCatalogItemsResponse, ImportMetadata> PollOnceImportCatalogItems(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportCatalogItemsResponse, ImportMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportCatalogItemsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ImportCatalogItems</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ImportCatalogItemsResponse, ImportMetadata>> PollOnceImportCatalogItemsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportCatalogItemsResponse, ImportMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportCatalogItemsOperationsClient, callSettings);

        /// <summary>
        /// Bulk import of multiple catalog items. Request processing may be
        /// synchronous. No partial updating supported. Non-existing items will be
        /// created.
        /// 
        /// Operation.response is of type ImportResponse. Note that it is
        /// possible for a subset of the items to be successfully updated.
        /// </summary>
        /// <param name="parent">
        /// Required. `projects/1234/locations/global/catalogs/default_catalog`
        /// </param>
        /// <param name="requestId">
        /// Optional. Unique identifier provided by client, within the ancestor
        /// dataset scope. Ensures idempotency and used for request deduplication.
        /// Server-generated if unspecified. Up to 128 characters long. This is
        /// returned as google.longrunning.Operation.name in the response.
        /// </param>
        /// <param name="inputConfig">
        /// Required. The desired input location of the data.
        /// </param>
        /// <param name="errorsConfig">
        /// Optional. The desired location of errors incurred during the Import.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportCatalogItemsResponse, ImportMetadata> ImportCatalogItems(string parent, string requestId, InputConfig inputConfig, ImportErrorsConfig errorsConfig, gaxgrpc::CallSettings callSettings = null) =>
            ImportCatalogItems(new ImportCatalogItemsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                RequestId = requestId ?? "",
                InputConfig = gax::GaxPreconditions.CheckNotNull(inputConfig, nameof(inputConfig)),
                ErrorsConfig = errorsConfig,
            }, callSettings);

        /// <summary>
        /// Bulk import of multiple catalog items. Request processing may be
        /// synchronous. No partial updating supported. Non-existing items will be
        /// created.
        /// 
        /// Operation.response is of type ImportResponse. Note that it is
        /// possible for a subset of the items to be successfully updated.
        /// </summary>
        /// <param name="parent">
        /// Required. `projects/1234/locations/global/catalogs/default_catalog`
        /// </param>
        /// <param name="requestId">
        /// Optional. Unique identifier provided by client, within the ancestor
        /// dataset scope. Ensures idempotency and used for request deduplication.
        /// Server-generated if unspecified. Up to 128 characters long. This is
        /// returned as google.longrunning.Operation.name in the response.
        /// </param>
        /// <param name="inputConfig">
        /// Required. The desired input location of the data.
        /// </param>
        /// <param name="errorsConfig">
        /// Optional. The desired location of errors incurred during the Import.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportCatalogItemsResponse, ImportMetadata>> ImportCatalogItemsAsync(string parent, string requestId, InputConfig inputConfig, ImportErrorsConfig errorsConfig, gaxgrpc::CallSettings callSettings = null) =>
            ImportCatalogItemsAsync(new ImportCatalogItemsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                RequestId = requestId ?? "",
                InputConfig = gax::GaxPreconditions.CheckNotNull(inputConfig, nameof(inputConfig)),
                ErrorsConfig = errorsConfig,
            }, callSettings);

        /// <summary>
        /// Bulk import of multiple catalog items. Request processing may be
        /// synchronous. No partial updating supported. Non-existing items will be
        /// created.
        /// 
        /// Operation.response is of type ImportResponse. Note that it is
        /// possible for a subset of the items to be successfully updated.
        /// </summary>
        /// <param name="parent">
        /// Required. `projects/1234/locations/global/catalogs/default_catalog`
        /// </param>
        /// <param name="requestId">
        /// Optional. Unique identifier provided by client, within the ancestor
        /// dataset scope. Ensures idempotency and used for request deduplication.
        /// Server-generated if unspecified. Up to 128 characters long. This is
        /// returned as google.longrunning.Operation.name in the response.
        /// </param>
        /// <param name="inputConfig">
        /// Required. The desired input location of the data.
        /// </param>
        /// <param name="errorsConfig">
        /// Optional. The desired location of errors incurred during the Import.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportCatalogItemsResponse, ImportMetadata>> ImportCatalogItemsAsync(string parent, string requestId, InputConfig inputConfig, ImportErrorsConfig errorsConfig, st::CancellationToken cancellationToken) =>
            ImportCatalogItemsAsync(parent, requestId, inputConfig, errorsConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Bulk import of multiple catalog items. Request processing may be
        /// synchronous. No partial updating supported. Non-existing items will be
        /// created.
        /// 
        /// Operation.response is of type ImportResponse. Note that it is
        /// possible for a subset of the items to be successfully updated.
        /// </summary>
        /// <param name="parent">
        /// Required. `projects/1234/locations/global/catalogs/default_catalog`
        /// </param>
        /// <param name="requestId">
        /// Optional. Unique identifier provided by client, within the ancestor
        /// dataset scope. Ensures idempotency and used for request deduplication.
        /// Server-generated if unspecified. Up to 128 characters long. This is
        /// returned as google.longrunning.Operation.name in the response.
        /// </param>
        /// <param name="inputConfig">
        /// Required. The desired input location of the data.
        /// </param>
        /// <param name="errorsConfig">
        /// Optional. The desired location of errors incurred during the Import.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportCatalogItemsResponse, ImportMetadata> ImportCatalogItems(CatalogName parent, string requestId, InputConfig inputConfig, ImportErrorsConfig errorsConfig, gaxgrpc::CallSettings callSettings = null) =>
            ImportCatalogItems(new ImportCatalogItemsRequest
            {
                ParentAsCatalogName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                RequestId = requestId ?? "",
                InputConfig = gax::GaxPreconditions.CheckNotNull(inputConfig, nameof(inputConfig)),
                ErrorsConfig = errorsConfig,
            }, callSettings);

        /// <summary>
        /// Bulk import of multiple catalog items. Request processing may be
        /// synchronous. No partial updating supported. Non-existing items will be
        /// created.
        /// 
        /// Operation.response is of type ImportResponse. Note that it is
        /// possible for a subset of the items to be successfully updated.
        /// </summary>
        /// <param name="parent">
        /// Required. `projects/1234/locations/global/catalogs/default_catalog`
        /// </param>
        /// <param name="requestId">
        /// Optional. Unique identifier provided by client, within the ancestor
        /// dataset scope. Ensures idempotency and used for request deduplication.
        /// Server-generated if unspecified. Up to 128 characters long. This is
        /// returned as google.longrunning.Operation.name in the response.
        /// </param>
        /// <param name="inputConfig">
        /// Required. The desired input location of the data.
        /// </param>
        /// <param name="errorsConfig">
        /// Optional. The desired location of errors incurred during the Import.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportCatalogItemsResponse, ImportMetadata>> ImportCatalogItemsAsync(CatalogName parent, string requestId, InputConfig inputConfig, ImportErrorsConfig errorsConfig, gaxgrpc::CallSettings callSettings = null) =>
            ImportCatalogItemsAsync(new ImportCatalogItemsRequest
            {
                ParentAsCatalogName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                RequestId = requestId ?? "",
                InputConfig = gax::GaxPreconditions.CheckNotNull(inputConfig, nameof(inputConfig)),
                ErrorsConfig = errorsConfig,
            }, callSettings);

        /// <summary>
        /// Bulk import of multiple catalog items. Request processing may be
        /// synchronous. No partial updating supported. Non-existing items will be
        /// created.
        /// 
        /// Operation.response is of type ImportResponse. Note that it is
        /// possible for a subset of the items to be successfully updated.
        /// </summary>
        /// <param name="parent">
        /// Required. `projects/1234/locations/global/catalogs/default_catalog`
        /// </param>
        /// <param name="requestId">
        /// Optional. Unique identifier provided by client, within the ancestor
        /// dataset scope. Ensures idempotency and used for request deduplication.
        /// Server-generated if unspecified. Up to 128 characters long. This is
        /// returned as google.longrunning.Operation.name in the response.
        /// </param>
        /// <param name="inputConfig">
        /// Required. The desired input location of the data.
        /// </param>
        /// <param name="errorsConfig">
        /// Optional. The desired location of errors incurred during the Import.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportCatalogItemsResponse, ImportMetadata>> ImportCatalogItemsAsync(CatalogName parent, string requestId, InputConfig inputConfig, ImportErrorsConfig errorsConfig, st::CancellationToken cancellationToken) =>
            ImportCatalogItemsAsync(parent, requestId, inputConfig, errorsConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CatalogService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for ingesting catalog information of the customer's website.
    /// </remarks>
    public sealed partial class CatalogServiceClientImpl : CatalogServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateCatalogItemRequest, CatalogItem> _callCreateCatalogItem;

        private readonly gaxgrpc::ApiCall<GetCatalogItemRequest, CatalogItem> _callGetCatalogItem;

        private readonly gaxgrpc::ApiCall<ListCatalogItemsRequest, ListCatalogItemsResponse> _callListCatalogItems;

        private readonly gaxgrpc::ApiCall<UpdateCatalogItemRequest, CatalogItem> _callUpdateCatalogItem;

        private readonly gaxgrpc::ApiCall<DeleteCatalogItemRequest, wkt::Empty> _callDeleteCatalogItem;

        private readonly gaxgrpc::ApiCall<ImportCatalogItemsRequest, lro::Operation> _callImportCatalogItems;

        /// <summary>
        /// Constructs a client wrapper for the CatalogService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CatalogServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CatalogServiceClientImpl(CatalogService.CatalogServiceClient grpcClient, CatalogServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CatalogServiceSettings effectiveSettings = settings ?? CatalogServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            ImportCatalogItemsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ImportCatalogItemsOperationsSettings, logger);
            _callCreateCatalogItem = clientHelper.BuildApiCall<CreateCatalogItemRequest, CatalogItem>("CreateCatalogItem", grpcClient.CreateCatalogItemAsync, grpcClient.CreateCatalogItem, effectiveSettings.CreateCatalogItemSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateCatalogItem);
            Modify_CreateCatalogItemApiCall(ref _callCreateCatalogItem);
            _callGetCatalogItem = clientHelper.BuildApiCall<GetCatalogItemRequest, CatalogItem>("GetCatalogItem", grpcClient.GetCatalogItemAsync, grpcClient.GetCatalogItem, effectiveSettings.GetCatalogItemSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCatalogItem);
            Modify_GetCatalogItemApiCall(ref _callGetCatalogItem);
            _callListCatalogItems = clientHelper.BuildApiCall<ListCatalogItemsRequest, ListCatalogItemsResponse>("ListCatalogItems", grpcClient.ListCatalogItemsAsync, grpcClient.ListCatalogItems, effectiveSettings.ListCatalogItemsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCatalogItems);
            Modify_ListCatalogItemsApiCall(ref _callListCatalogItems);
            _callUpdateCatalogItem = clientHelper.BuildApiCall<UpdateCatalogItemRequest, CatalogItem>("UpdateCatalogItem", grpcClient.UpdateCatalogItemAsync, grpcClient.UpdateCatalogItem, effectiveSettings.UpdateCatalogItemSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateCatalogItem);
            Modify_UpdateCatalogItemApiCall(ref _callUpdateCatalogItem);
            _callDeleteCatalogItem = clientHelper.BuildApiCall<DeleteCatalogItemRequest, wkt::Empty>("DeleteCatalogItem", grpcClient.DeleteCatalogItemAsync, grpcClient.DeleteCatalogItem, effectiveSettings.DeleteCatalogItemSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteCatalogItem);
            Modify_DeleteCatalogItemApiCall(ref _callDeleteCatalogItem);
            _callImportCatalogItems = clientHelper.BuildApiCall<ImportCatalogItemsRequest, lro::Operation>("ImportCatalogItems", grpcClient.ImportCatalogItemsAsync, grpcClient.ImportCatalogItems, effectiveSettings.ImportCatalogItemsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callImportCatalogItems);
            Modify_ImportCatalogItemsApiCall(ref _callImportCatalogItems);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateCatalogItemApiCall(ref gaxgrpc::ApiCall<CreateCatalogItemRequest, CatalogItem> call);

        partial void Modify_GetCatalogItemApiCall(ref gaxgrpc::ApiCall<GetCatalogItemRequest, CatalogItem> call);

        partial void Modify_ListCatalogItemsApiCall(ref gaxgrpc::ApiCall<ListCatalogItemsRequest, ListCatalogItemsResponse> call);

        partial void Modify_UpdateCatalogItemApiCall(ref gaxgrpc::ApiCall<UpdateCatalogItemRequest, CatalogItem> call);

        partial void Modify_DeleteCatalogItemApiCall(ref gaxgrpc::ApiCall<DeleteCatalogItemRequest, wkt::Empty> call);

        partial void Modify_ImportCatalogItemsApiCall(ref gaxgrpc::ApiCall<ImportCatalogItemsRequest, lro::Operation> call);

        partial void OnConstruction(CatalogService.CatalogServiceClient grpcClient, CatalogServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CatalogService client</summary>
        public override CatalogService.CatalogServiceClient GrpcClient { get; }

        partial void Modify_CreateCatalogItemRequest(ref CreateCatalogItemRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetCatalogItemRequest(ref GetCatalogItemRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCatalogItemsRequest(ref ListCatalogItemsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateCatalogItemRequest(ref UpdateCatalogItemRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteCatalogItemRequest(ref DeleteCatalogItemRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ImportCatalogItemsRequest(ref ImportCatalogItemsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a catalog item.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CatalogItem CreateCatalogItem(CreateCatalogItemRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCatalogItemRequest(ref request, ref callSettings);
            return _callCreateCatalogItem.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a catalog item.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CatalogItem> CreateCatalogItemAsync(CreateCatalogItemRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCatalogItemRequest(ref request, ref callSettings);
            return _callCreateCatalogItem.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a specific catalog item.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CatalogItem GetCatalogItem(GetCatalogItemRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCatalogItemRequest(ref request, ref callSettings);
            return _callGetCatalogItem.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a specific catalog item.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CatalogItem> GetCatalogItemAsync(GetCatalogItemRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCatalogItemRequest(ref request, ref callSettings);
            return _callGetCatalogItem.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a list of catalog items.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CatalogItem"/> resources.</returns>
        public override gax::PagedEnumerable<ListCatalogItemsResponse, CatalogItem> ListCatalogItems(ListCatalogItemsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCatalogItemsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCatalogItemsRequest, ListCatalogItemsResponse, CatalogItem>(_callListCatalogItems, request, callSettings);
        }

        /// <summary>
        /// Gets a list of catalog items.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CatalogItem"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCatalogItemsResponse, CatalogItem> ListCatalogItemsAsync(ListCatalogItemsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCatalogItemsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCatalogItemsRequest, ListCatalogItemsResponse, CatalogItem>(_callListCatalogItems, request, callSettings);
        }

        /// <summary>
        /// Updates a catalog item. Partial updating is supported. Non-existing
        /// items will be created.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CatalogItem UpdateCatalogItem(UpdateCatalogItemRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCatalogItemRequest(ref request, ref callSettings);
            return _callUpdateCatalogItem.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a catalog item. Partial updating is supported. Non-existing
        /// items will be created.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CatalogItem> UpdateCatalogItemAsync(UpdateCatalogItemRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCatalogItemRequest(ref request, ref callSettings);
            return _callUpdateCatalogItem.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a catalog item.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteCatalogItem(DeleteCatalogItemRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCatalogItemRequest(ref request, ref callSettings);
            _callDeleteCatalogItem.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a catalog item.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteCatalogItemAsync(DeleteCatalogItemRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCatalogItemRequest(ref request, ref callSettings);
            return _callDeleteCatalogItem.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>ImportCatalogItems</c>.</summary>
        public override lro::OperationsClient ImportCatalogItemsOperationsClient { get; }

        /// <summary>
        /// Bulk import of multiple catalog items. Request processing may be
        /// synchronous. No partial updating supported. Non-existing items will be
        /// created.
        /// 
        /// Operation.response is of type ImportResponse. Note that it is
        /// possible for a subset of the items to be successfully updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ImportCatalogItemsResponse, ImportMetadata> ImportCatalogItems(ImportCatalogItemsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportCatalogItemsRequest(ref request, ref callSettings);
            return new lro::Operation<ImportCatalogItemsResponse, ImportMetadata>(_callImportCatalogItems.Sync(request, callSettings), ImportCatalogItemsOperationsClient);
        }

        /// <summary>
        /// Bulk import of multiple catalog items. Request processing may be
        /// synchronous. No partial updating supported. Non-existing items will be
        /// created.
        /// 
        /// Operation.response is of type ImportResponse. Note that it is
        /// possible for a subset of the items to be successfully updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ImportCatalogItemsResponse, ImportMetadata>> ImportCatalogItemsAsync(ImportCatalogItemsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportCatalogItemsRequest(ref request, ref callSettings);
            return new lro::Operation<ImportCatalogItemsResponse, ImportMetadata>(await _callImportCatalogItems.Async(request, callSettings).ConfigureAwait(false), ImportCatalogItemsOperationsClient);
        }
    }

    public partial class ListCatalogItemsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCatalogItemsResponse : gaxgrpc::IPageResponse<CatalogItem>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<CatalogItem> GetEnumerator() => CatalogItems.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class CatalogService
    {
        public partial class CatalogServiceClient
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
