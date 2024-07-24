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
using gagr = Google.Api.Gax.ResourceNames;
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

namespace Google.Cloud.Retail.V2
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
            ListCatalogsSettings = existing.ListCatalogsSettings;
            UpdateCatalogSettings = existing.UpdateCatalogSettings;
            SetDefaultBranchSettings = existing.SetDefaultBranchSettings;
            GetDefaultBranchSettings = existing.GetDefaultBranchSettings;
            GetCompletionConfigSettings = existing.GetCompletionConfigSettings;
            UpdateCompletionConfigSettings = existing.UpdateCompletionConfigSettings;
            GetAttributesConfigSettings = existing.GetAttributesConfigSettings;
            UpdateAttributesConfigSettings = existing.UpdateAttributesConfigSettings;
            AddCatalogAttributeSettings = existing.AddCatalogAttributeSettings;
            RemoveCatalogAttributeSettings = existing.RemoveCatalogAttributeSettings;
            ReplaceCatalogAttributeSettings = existing.ReplaceCatalogAttributeSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CatalogServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CatalogServiceClient.ListCatalogs</c> and <c>CatalogServiceClient.ListCatalogsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 5000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListCatalogsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(5000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CatalogServiceClient.UpdateCatalog</c> and <c>CatalogServiceClient.UpdateCatalogAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 5000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateCatalogSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(5000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CatalogServiceClient.SetDefaultBranch</c> and <c>CatalogServiceClient.SetDefaultBranchAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 5000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetDefaultBranchSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(5000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CatalogServiceClient.GetDefaultBranch</c> and <c>CatalogServiceClient.GetDefaultBranchAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 5000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDefaultBranchSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(5000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CatalogServiceClient.GetCompletionConfig</c> and <c>CatalogServiceClient.GetCompletionConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 5000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCompletionConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(5000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CatalogServiceClient.UpdateCompletionConfig</c> and <c>CatalogServiceClient.UpdateCompletionConfigAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 5000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateCompletionConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(5000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CatalogServiceClient.GetAttributesConfig</c> and <c>CatalogServiceClient.GetAttributesConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 5000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAttributesConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(5000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CatalogServiceClient.UpdateAttributesConfig</c> and <c>CatalogServiceClient.UpdateAttributesConfigAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 5000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateAttributesConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(5000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CatalogServiceClient.AddCatalogAttribute</c> and <c>CatalogServiceClient.AddCatalogAttributeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 5000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AddCatalogAttributeSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(5000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CatalogServiceClient.RemoveCatalogAttribute</c> and <c>CatalogServiceClient.RemoveCatalogAttributeAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 5000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RemoveCatalogAttributeSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(5000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CatalogServiceClient.ReplaceCatalogAttribute</c> and <c>CatalogServiceClient.ReplaceCatalogAttributeAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 5000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReplaceCatalogAttributeSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(5000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

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
    /// Service for managing catalog configuration.
    /// </remarks>
    public abstract partial class CatalogServiceClient
    {
        /// <summary>
        /// The default endpoint for the CatalogService service, which is a host of "retail.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "retail.googleapis.com:443";

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

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the [Catalog][google.cloud.retail.v2.Catalog]s associated with
        /// the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Catalog"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCatalogsResponse, Catalog> ListCatalogs(ListCatalogsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the [Catalog][google.cloud.retail.v2.Catalog]s associated with
        /// the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Catalog"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCatalogsResponse, Catalog> ListCatalogsAsync(ListCatalogsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the [Catalog][google.cloud.retail.v2.Catalog]s associated with
        /// the project.
        /// </summary>
        /// <param name="parent">
        /// Required. The account resource name with an associated location.
        /// 
        /// If the caller does not have permission to list
        /// [Catalog][google.cloud.retail.v2.Catalog]s under this location, regardless
        /// of whether or not this location exists, a PERMISSION_DENIED error is
        /// returned.
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
        /// <returns>A pageable sequence of <see cref="Catalog"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCatalogsResponse, Catalog> ListCatalogs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCatalogsRequest request = new ListCatalogsRequest
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
            return ListCatalogs(request, callSettings);
        }

        /// <summary>
        /// Lists all the [Catalog][google.cloud.retail.v2.Catalog]s associated with
        /// the project.
        /// </summary>
        /// <param name="parent">
        /// Required. The account resource name with an associated location.
        /// 
        /// If the caller does not have permission to list
        /// [Catalog][google.cloud.retail.v2.Catalog]s under this location, regardless
        /// of whether or not this location exists, a PERMISSION_DENIED error is
        /// returned.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Catalog"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCatalogsResponse, Catalog> ListCatalogsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCatalogsRequest request = new ListCatalogsRequest
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
            return ListCatalogsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all the [Catalog][google.cloud.retail.v2.Catalog]s associated with
        /// the project.
        /// </summary>
        /// <param name="parent">
        /// Required. The account resource name with an associated location.
        /// 
        /// If the caller does not have permission to list
        /// [Catalog][google.cloud.retail.v2.Catalog]s under this location, regardless
        /// of whether or not this location exists, a PERMISSION_DENIED error is
        /// returned.
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
        /// <returns>A pageable sequence of <see cref="Catalog"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCatalogsResponse, Catalog> ListCatalogs(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCatalogsRequest request = new ListCatalogsRequest
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
            return ListCatalogs(request, callSettings);
        }

        /// <summary>
        /// Lists all the [Catalog][google.cloud.retail.v2.Catalog]s associated with
        /// the project.
        /// </summary>
        /// <param name="parent">
        /// Required. The account resource name with an associated location.
        /// 
        /// If the caller does not have permission to list
        /// [Catalog][google.cloud.retail.v2.Catalog]s under this location, regardless
        /// of whether or not this location exists, a PERMISSION_DENIED error is
        /// returned.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Catalog"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCatalogsResponse, Catalog> ListCatalogsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCatalogsRequest request = new ListCatalogsRequest
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
            return ListCatalogsAsync(request, callSettings);
        }

        /// <summary>
        /// Updates the [Catalog][google.cloud.retail.v2.Catalog]s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Catalog UpdateCatalog(UpdateCatalogRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the [Catalog][google.cloud.retail.v2.Catalog]s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Catalog> UpdateCatalogAsync(UpdateCatalogRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the [Catalog][google.cloud.retail.v2.Catalog]s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Catalog> UpdateCatalogAsync(UpdateCatalogRequest request, st::CancellationToken cancellationToken) =>
            UpdateCatalogAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the [Catalog][google.cloud.retail.v2.Catalog]s.
        /// </summary>
        /// <param name="catalog">
        /// Required. The [Catalog][google.cloud.retail.v2.Catalog] to update.
        /// 
        /// If the caller does not have permission to update the
        /// [Catalog][google.cloud.retail.v2.Catalog], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [Catalog][google.cloud.retail.v2.Catalog] to update does not exist,
        /// a NOT_FOUND error is returned.
        /// </param>
        /// <param name="updateMask">
        /// Indicates which fields in the provided
        /// [Catalog][google.cloud.retail.v2.Catalog] to update.
        /// 
        /// If an unsupported or unknown field is provided, an INVALID_ARGUMENT error
        /// is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Catalog UpdateCatalog(Catalog catalog, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCatalog(new UpdateCatalogRequest
            {
                Catalog = gax::GaxPreconditions.CheckNotNull(catalog, nameof(catalog)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the [Catalog][google.cloud.retail.v2.Catalog]s.
        /// </summary>
        /// <param name="catalog">
        /// Required. The [Catalog][google.cloud.retail.v2.Catalog] to update.
        /// 
        /// If the caller does not have permission to update the
        /// [Catalog][google.cloud.retail.v2.Catalog], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [Catalog][google.cloud.retail.v2.Catalog] to update does not exist,
        /// a NOT_FOUND error is returned.
        /// </param>
        /// <param name="updateMask">
        /// Indicates which fields in the provided
        /// [Catalog][google.cloud.retail.v2.Catalog] to update.
        /// 
        /// If an unsupported or unknown field is provided, an INVALID_ARGUMENT error
        /// is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Catalog> UpdateCatalogAsync(Catalog catalog, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCatalogAsync(new UpdateCatalogRequest
            {
                Catalog = gax::GaxPreconditions.CheckNotNull(catalog, nameof(catalog)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the [Catalog][google.cloud.retail.v2.Catalog]s.
        /// </summary>
        /// <param name="catalog">
        /// Required. The [Catalog][google.cloud.retail.v2.Catalog] to update.
        /// 
        /// If the caller does not have permission to update the
        /// [Catalog][google.cloud.retail.v2.Catalog], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [Catalog][google.cloud.retail.v2.Catalog] to update does not exist,
        /// a NOT_FOUND error is returned.
        /// </param>
        /// <param name="updateMask">
        /// Indicates which fields in the provided
        /// [Catalog][google.cloud.retail.v2.Catalog] to update.
        /// 
        /// If an unsupported or unknown field is provided, an INVALID_ARGUMENT error
        /// is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Catalog> UpdateCatalogAsync(Catalog catalog, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateCatalogAsync(catalog, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Set a specified branch id as default branch. API methods such as
        /// [SearchService.Search][google.cloud.retail.v2.SearchService.Search],
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct],
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts]
        /// will treat requests using "default_branch" to the actual branch id set as
        /// default.
        /// 
        /// For example, if `projects/*/locations/*/catalogs/*/branches/1` is set as
        /// default, setting
        /// [SearchRequest.branch][google.cloud.retail.v2.SearchRequest.branch] to
        /// `projects/*/locations/*/catalogs/*/branches/default_branch` is equivalent
        /// to setting
        /// [SearchRequest.branch][google.cloud.retail.v2.SearchRequest.branch] to
        /// `projects/*/locations/*/catalogs/*/branches/1`.
        /// 
        /// Using multiple branches can be useful when developers would like
        /// to have a staging branch to test and verify for future usage. When it
        /// becomes ready, developers switch on the staging branch using this API while
        /// keeping using `projects/*/locations/*/catalogs/*/branches/default_branch`
        /// as [SearchRequest.branch][google.cloud.retail.v2.SearchRequest.branch] to
        /// route the traffic to this staging branch.
        /// 
        /// CAUTION: If you have live predict/search traffic, switching the default
        /// branch could potentially cause outages if the ID space of the new branch is
        /// very different from the old one.
        /// 
        /// More specifically:
        /// 
        /// * PredictionService will only return product IDs from branch {newBranch}.
        /// * SearchService will only return product IDs from branch {newBranch}
        /// (if branch is not explicitly set).
        /// * UserEventService will only join events with products from branch
        /// {newBranch}.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void SetDefaultBranch(SetDefaultBranchRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Set a specified branch id as default branch. API methods such as
        /// [SearchService.Search][google.cloud.retail.v2.SearchService.Search],
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct],
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts]
        /// will treat requests using "default_branch" to the actual branch id set as
        /// default.
        /// 
        /// For example, if `projects/*/locations/*/catalogs/*/branches/1` is set as
        /// default, setting
        /// [SearchRequest.branch][google.cloud.retail.v2.SearchRequest.branch] to
        /// `projects/*/locations/*/catalogs/*/branches/default_branch` is equivalent
        /// to setting
        /// [SearchRequest.branch][google.cloud.retail.v2.SearchRequest.branch] to
        /// `projects/*/locations/*/catalogs/*/branches/1`.
        /// 
        /// Using multiple branches can be useful when developers would like
        /// to have a staging branch to test and verify for future usage. When it
        /// becomes ready, developers switch on the staging branch using this API while
        /// keeping using `projects/*/locations/*/catalogs/*/branches/default_branch`
        /// as [SearchRequest.branch][google.cloud.retail.v2.SearchRequest.branch] to
        /// route the traffic to this staging branch.
        /// 
        /// CAUTION: If you have live predict/search traffic, switching the default
        /// branch could potentially cause outages if the ID space of the new branch is
        /// very different from the old one.
        /// 
        /// More specifically:
        /// 
        /// * PredictionService will only return product IDs from branch {newBranch}.
        /// * SearchService will only return product IDs from branch {newBranch}
        /// (if branch is not explicitly set).
        /// * UserEventService will only join events with products from branch
        /// {newBranch}.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task SetDefaultBranchAsync(SetDefaultBranchRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Set a specified branch id as default branch. API methods such as
        /// [SearchService.Search][google.cloud.retail.v2.SearchService.Search],
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct],
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts]
        /// will treat requests using "default_branch" to the actual branch id set as
        /// default.
        /// 
        /// For example, if `projects/*/locations/*/catalogs/*/branches/1` is set as
        /// default, setting
        /// [SearchRequest.branch][google.cloud.retail.v2.SearchRequest.branch] to
        /// `projects/*/locations/*/catalogs/*/branches/default_branch` is equivalent
        /// to setting
        /// [SearchRequest.branch][google.cloud.retail.v2.SearchRequest.branch] to
        /// `projects/*/locations/*/catalogs/*/branches/1`.
        /// 
        /// Using multiple branches can be useful when developers would like
        /// to have a staging branch to test and verify for future usage. When it
        /// becomes ready, developers switch on the staging branch using this API while
        /// keeping using `projects/*/locations/*/catalogs/*/branches/default_branch`
        /// as [SearchRequest.branch][google.cloud.retail.v2.SearchRequest.branch] to
        /// route the traffic to this staging branch.
        /// 
        /// CAUTION: If you have live predict/search traffic, switching the default
        /// branch could potentially cause outages if the ID space of the new branch is
        /// very different from the old one.
        /// 
        /// More specifically:
        /// 
        /// * PredictionService will only return product IDs from branch {newBranch}.
        /// * SearchService will only return product IDs from branch {newBranch}
        /// (if branch is not explicitly set).
        /// * UserEventService will only join events with products from branch
        /// {newBranch}.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task SetDefaultBranchAsync(SetDefaultBranchRequest request, st::CancellationToken cancellationToken) =>
            SetDefaultBranchAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Set a specified branch id as default branch. API methods such as
        /// [SearchService.Search][google.cloud.retail.v2.SearchService.Search],
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct],
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts]
        /// will treat requests using "default_branch" to the actual branch id set as
        /// default.
        /// 
        /// For example, if `projects/*/locations/*/catalogs/*/branches/1` is set as
        /// default, setting
        /// [SearchRequest.branch][google.cloud.retail.v2.SearchRequest.branch] to
        /// `projects/*/locations/*/catalogs/*/branches/default_branch` is equivalent
        /// to setting
        /// [SearchRequest.branch][google.cloud.retail.v2.SearchRequest.branch] to
        /// `projects/*/locations/*/catalogs/*/branches/1`.
        /// 
        /// Using multiple branches can be useful when developers would like
        /// to have a staging branch to test and verify for future usage. When it
        /// becomes ready, developers switch on the staging branch using this API while
        /// keeping using `projects/*/locations/*/catalogs/*/branches/default_branch`
        /// as [SearchRequest.branch][google.cloud.retail.v2.SearchRequest.branch] to
        /// route the traffic to this staging branch.
        /// 
        /// CAUTION: If you have live predict/search traffic, switching the default
        /// branch could potentially cause outages if the ID space of the new branch is
        /// very different from the old one.
        /// 
        /// More specifically:
        /// 
        /// * PredictionService will only return product IDs from branch {newBranch}.
        /// * SearchService will only return product IDs from branch {newBranch}
        /// (if branch is not explicitly set).
        /// * UserEventService will only join events with products from branch
        /// {newBranch}.
        /// </summary>
        /// <param name="catalog">
        /// Full resource name of the catalog, such as
        /// `projects/*/locations/global/catalogs/default_catalog`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void SetDefaultBranch(string catalog, gaxgrpc::CallSettings callSettings = null) =>
            SetDefaultBranch(new SetDefaultBranchRequest
            {
                Catalog = catalog ?? "",
            }, callSettings);

        /// <summary>
        /// Set a specified branch id as default branch. API methods such as
        /// [SearchService.Search][google.cloud.retail.v2.SearchService.Search],
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct],
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts]
        /// will treat requests using "default_branch" to the actual branch id set as
        /// default.
        /// 
        /// For example, if `projects/*/locations/*/catalogs/*/branches/1` is set as
        /// default, setting
        /// [SearchRequest.branch][google.cloud.retail.v2.SearchRequest.branch] to
        /// `projects/*/locations/*/catalogs/*/branches/default_branch` is equivalent
        /// to setting
        /// [SearchRequest.branch][google.cloud.retail.v2.SearchRequest.branch] to
        /// `projects/*/locations/*/catalogs/*/branches/1`.
        /// 
        /// Using multiple branches can be useful when developers would like
        /// to have a staging branch to test and verify for future usage. When it
        /// becomes ready, developers switch on the staging branch using this API while
        /// keeping using `projects/*/locations/*/catalogs/*/branches/default_branch`
        /// as [SearchRequest.branch][google.cloud.retail.v2.SearchRequest.branch] to
        /// route the traffic to this staging branch.
        /// 
        /// CAUTION: If you have live predict/search traffic, switching the default
        /// branch could potentially cause outages if the ID space of the new branch is
        /// very different from the old one.
        /// 
        /// More specifically:
        /// 
        /// * PredictionService will only return product IDs from branch {newBranch}.
        /// * SearchService will only return product IDs from branch {newBranch}
        /// (if branch is not explicitly set).
        /// * UserEventService will only join events with products from branch
        /// {newBranch}.
        /// </summary>
        /// <param name="catalog">
        /// Full resource name of the catalog, such as
        /// `projects/*/locations/global/catalogs/default_catalog`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task SetDefaultBranchAsync(string catalog, gaxgrpc::CallSettings callSettings = null) =>
            SetDefaultBranchAsync(new SetDefaultBranchRequest
            {
                Catalog = catalog ?? "",
            }, callSettings);

        /// <summary>
        /// Set a specified branch id as default branch. API methods such as
        /// [SearchService.Search][google.cloud.retail.v2.SearchService.Search],
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct],
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts]
        /// will treat requests using "default_branch" to the actual branch id set as
        /// default.
        /// 
        /// For example, if `projects/*/locations/*/catalogs/*/branches/1` is set as
        /// default, setting
        /// [SearchRequest.branch][google.cloud.retail.v2.SearchRequest.branch] to
        /// `projects/*/locations/*/catalogs/*/branches/default_branch` is equivalent
        /// to setting
        /// [SearchRequest.branch][google.cloud.retail.v2.SearchRequest.branch] to
        /// `projects/*/locations/*/catalogs/*/branches/1`.
        /// 
        /// Using multiple branches can be useful when developers would like
        /// to have a staging branch to test and verify for future usage. When it
        /// becomes ready, developers switch on the staging branch using this API while
        /// keeping using `projects/*/locations/*/catalogs/*/branches/default_branch`
        /// as [SearchRequest.branch][google.cloud.retail.v2.SearchRequest.branch] to
        /// route the traffic to this staging branch.
        /// 
        /// CAUTION: If you have live predict/search traffic, switching the default
        /// branch could potentially cause outages if the ID space of the new branch is
        /// very different from the old one.
        /// 
        /// More specifically:
        /// 
        /// * PredictionService will only return product IDs from branch {newBranch}.
        /// * SearchService will only return product IDs from branch {newBranch}
        /// (if branch is not explicitly set).
        /// * UserEventService will only join events with products from branch
        /// {newBranch}.
        /// </summary>
        /// <param name="catalog">
        /// Full resource name of the catalog, such as
        /// `projects/*/locations/global/catalogs/default_catalog`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task SetDefaultBranchAsync(string catalog, st::CancellationToken cancellationToken) =>
            SetDefaultBranchAsync(catalog, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Set a specified branch id as default branch. API methods such as
        /// [SearchService.Search][google.cloud.retail.v2.SearchService.Search],
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct],
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts]
        /// will treat requests using "default_branch" to the actual branch id set as
        /// default.
        /// 
        /// For example, if `projects/*/locations/*/catalogs/*/branches/1` is set as
        /// default, setting
        /// [SearchRequest.branch][google.cloud.retail.v2.SearchRequest.branch] to
        /// `projects/*/locations/*/catalogs/*/branches/default_branch` is equivalent
        /// to setting
        /// [SearchRequest.branch][google.cloud.retail.v2.SearchRequest.branch] to
        /// `projects/*/locations/*/catalogs/*/branches/1`.
        /// 
        /// Using multiple branches can be useful when developers would like
        /// to have a staging branch to test and verify for future usage. When it
        /// becomes ready, developers switch on the staging branch using this API while
        /// keeping using `projects/*/locations/*/catalogs/*/branches/default_branch`
        /// as [SearchRequest.branch][google.cloud.retail.v2.SearchRequest.branch] to
        /// route the traffic to this staging branch.
        /// 
        /// CAUTION: If you have live predict/search traffic, switching the default
        /// branch could potentially cause outages if the ID space of the new branch is
        /// very different from the old one.
        /// 
        /// More specifically:
        /// 
        /// * PredictionService will only return product IDs from branch {newBranch}.
        /// * SearchService will only return product IDs from branch {newBranch}
        /// (if branch is not explicitly set).
        /// * UserEventService will only join events with products from branch
        /// {newBranch}.
        /// </summary>
        /// <param name="catalog">
        /// Full resource name of the catalog, such as
        /// `projects/*/locations/global/catalogs/default_catalog`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void SetDefaultBranch(CatalogName catalog, gaxgrpc::CallSettings callSettings = null) =>
            SetDefaultBranch(new SetDefaultBranchRequest
            {
                CatalogAsCatalogName = catalog,
            }, callSettings);

        /// <summary>
        /// Set a specified branch id as default branch. API methods such as
        /// [SearchService.Search][google.cloud.retail.v2.SearchService.Search],
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct],
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts]
        /// will treat requests using "default_branch" to the actual branch id set as
        /// default.
        /// 
        /// For example, if `projects/*/locations/*/catalogs/*/branches/1` is set as
        /// default, setting
        /// [SearchRequest.branch][google.cloud.retail.v2.SearchRequest.branch] to
        /// `projects/*/locations/*/catalogs/*/branches/default_branch` is equivalent
        /// to setting
        /// [SearchRequest.branch][google.cloud.retail.v2.SearchRequest.branch] to
        /// `projects/*/locations/*/catalogs/*/branches/1`.
        /// 
        /// Using multiple branches can be useful when developers would like
        /// to have a staging branch to test and verify for future usage. When it
        /// becomes ready, developers switch on the staging branch using this API while
        /// keeping using `projects/*/locations/*/catalogs/*/branches/default_branch`
        /// as [SearchRequest.branch][google.cloud.retail.v2.SearchRequest.branch] to
        /// route the traffic to this staging branch.
        /// 
        /// CAUTION: If you have live predict/search traffic, switching the default
        /// branch could potentially cause outages if the ID space of the new branch is
        /// very different from the old one.
        /// 
        /// More specifically:
        /// 
        /// * PredictionService will only return product IDs from branch {newBranch}.
        /// * SearchService will only return product IDs from branch {newBranch}
        /// (if branch is not explicitly set).
        /// * UserEventService will only join events with products from branch
        /// {newBranch}.
        /// </summary>
        /// <param name="catalog">
        /// Full resource name of the catalog, such as
        /// `projects/*/locations/global/catalogs/default_catalog`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task SetDefaultBranchAsync(CatalogName catalog, gaxgrpc::CallSettings callSettings = null) =>
            SetDefaultBranchAsync(new SetDefaultBranchRequest
            {
                CatalogAsCatalogName = catalog,
            }, callSettings);

        /// <summary>
        /// Set a specified branch id as default branch. API methods such as
        /// [SearchService.Search][google.cloud.retail.v2.SearchService.Search],
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct],
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts]
        /// will treat requests using "default_branch" to the actual branch id set as
        /// default.
        /// 
        /// For example, if `projects/*/locations/*/catalogs/*/branches/1` is set as
        /// default, setting
        /// [SearchRequest.branch][google.cloud.retail.v2.SearchRequest.branch] to
        /// `projects/*/locations/*/catalogs/*/branches/default_branch` is equivalent
        /// to setting
        /// [SearchRequest.branch][google.cloud.retail.v2.SearchRequest.branch] to
        /// `projects/*/locations/*/catalogs/*/branches/1`.
        /// 
        /// Using multiple branches can be useful when developers would like
        /// to have a staging branch to test and verify for future usage. When it
        /// becomes ready, developers switch on the staging branch using this API while
        /// keeping using `projects/*/locations/*/catalogs/*/branches/default_branch`
        /// as [SearchRequest.branch][google.cloud.retail.v2.SearchRequest.branch] to
        /// route the traffic to this staging branch.
        /// 
        /// CAUTION: If you have live predict/search traffic, switching the default
        /// branch could potentially cause outages if the ID space of the new branch is
        /// very different from the old one.
        /// 
        /// More specifically:
        /// 
        /// * PredictionService will only return product IDs from branch {newBranch}.
        /// * SearchService will only return product IDs from branch {newBranch}
        /// (if branch is not explicitly set).
        /// * UserEventService will only join events with products from branch
        /// {newBranch}.
        /// </summary>
        /// <param name="catalog">
        /// Full resource name of the catalog, such as
        /// `projects/*/locations/global/catalogs/default_catalog`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task SetDefaultBranchAsync(CatalogName catalog, st::CancellationToken cancellationToken) =>
            SetDefaultBranchAsync(catalog, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get which branch is currently default branch set by
        /// [CatalogService.SetDefaultBranch][google.cloud.retail.v2.CatalogService.SetDefaultBranch]
        /// method under a specified parent catalog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GetDefaultBranchResponse GetDefaultBranch(GetDefaultBranchRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get which branch is currently default branch set by
        /// [CatalogService.SetDefaultBranch][google.cloud.retail.v2.CatalogService.SetDefaultBranch]
        /// method under a specified parent catalog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetDefaultBranchResponse> GetDefaultBranchAsync(GetDefaultBranchRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get which branch is currently default branch set by
        /// [CatalogService.SetDefaultBranch][google.cloud.retail.v2.CatalogService.SetDefaultBranch]
        /// method under a specified parent catalog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetDefaultBranchResponse> GetDefaultBranchAsync(GetDefaultBranchRequest request, st::CancellationToken cancellationToken) =>
            GetDefaultBranchAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get which branch is currently default branch set by
        /// [CatalogService.SetDefaultBranch][google.cloud.retail.v2.CatalogService.SetDefaultBranch]
        /// method under a specified parent catalog.
        /// </summary>
        /// <param name="catalog">
        /// The parent catalog resource name, such as
        /// `projects/*/locations/global/catalogs/default_catalog`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GetDefaultBranchResponse GetDefaultBranch(string catalog, gaxgrpc::CallSettings callSettings = null) =>
            GetDefaultBranch(new GetDefaultBranchRequest
            {
                Catalog = catalog ?? "",
            }, callSettings);

        /// <summary>
        /// Get which branch is currently default branch set by
        /// [CatalogService.SetDefaultBranch][google.cloud.retail.v2.CatalogService.SetDefaultBranch]
        /// method under a specified parent catalog.
        /// </summary>
        /// <param name="catalog">
        /// The parent catalog resource name, such as
        /// `projects/*/locations/global/catalogs/default_catalog`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetDefaultBranchResponse> GetDefaultBranchAsync(string catalog, gaxgrpc::CallSettings callSettings = null) =>
            GetDefaultBranchAsync(new GetDefaultBranchRequest
            {
                Catalog = catalog ?? "",
            }, callSettings);

        /// <summary>
        /// Get which branch is currently default branch set by
        /// [CatalogService.SetDefaultBranch][google.cloud.retail.v2.CatalogService.SetDefaultBranch]
        /// method under a specified parent catalog.
        /// </summary>
        /// <param name="catalog">
        /// The parent catalog resource name, such as
        /// `projects/*/locations/global/catalogs/default_catalog`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetDefaultBranchResponse> GetDefaultBranchAsync(string catalog, st::CancellationToken cancellationToken) =>
            GetDefaultBranchAsync(catalog, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get which branch is currently default branch set by
        /// [CatalogService.SetDefaultBranch][google.cloud.retail.v2.CatalogService.SetDefaultBranch]
        /// method under a specified parent catalog.
        /// </summary>
        /// <param name="catalog">
        /// The parent catalog resource name, such as
        /// `projects/*/locations/global/catalogs/default_catalog`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GetDefaultBranchResponse GetDefaultBranch(CatalogName catalog, gaxgrpc::CallSettings callSettings = null) =>
            GetDefaultBranch(new GetDefaultBranchRequest
            {
                CatalogAsCatalogName = catalog,
            }, callSettings);

        /// <summary>
        /// Get which branch is currently default branch set by
        /// [CatalogService.SetDefaultBranch][google.cloud.retail.v2.CatalogService.SetDefaultBranch]
        /// method under a specified parent catalog.
        /// </summary>
        /// <param name="catalog">
        /// The parent catalog resource name, such as
        /// `projects/*/locations/global/catalogs/default_catalog`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetDefaultBranchResponse> GetDefaultBranchAsync(CatalogName catalog, gaxgrpc::CallSettings callSettings = null) =>
            GetDefaultBranchAsync(new GetDefaultBranchRequest
            {
                CatalogAsCatalogName = catalog,
            }, callSettings);

        /// <summary>
        /// Get which branch is currently default branch set by
        /// [CatalogService.SetDefaultBranch][google.cloud.retail.v2.CatalogService.SetDefaultBranch]
        /// method under a specified parent catalog.
        /// </summary>
        /// <param name="catalog">
        /// The parent catalog resource name, such as
        /// `projects/*/locations/global/catalogs/default_catalog`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetDefaultBranchResponse> GetDefaultBranchAsync(CatalogName catalog, st::CancellationToken cancellationToken) =>
            GetDefaultBranchAsync(catalog, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a [CompletionConfig][google.cloud.retail.v2.CompletionConfig].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CompletionConfig GetCompletionConfig(GetCompletionConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a [CompletionConfig][google.cloud.retail.v2.CompletionConfig].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CompletionConfig> GetCompletionConfigAsync(GetCompletionConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a [CompletionConfig][google.cloud.retail.v2.CompletionConfig].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CompletionConfig> GetCompletionConfigAsync(GetCompletionConfigRequest request, st::CancellationToken cancellationToken) =>
            GetCompletionConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a [CompletionConfig][google.cloud.retail.v2.CompletionConfig].
        /// </summary>
        /// <param name="name">
        /// Required. Full CompletionConfig resource name. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/completionConfig`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CompletionConfig GetCompletionConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCompletionConfig(new GetCompletionConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [CompletionConfig][google.cloud.retail.v2.CompletionConfig].
        /// </summary>
        /// <param name="name">
        /// Required. Full CompletionConfig resource name. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/completionConfig`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CompletionConfig> GetCompletionConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCompletionConfigAsync(new GetCompletionConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [CompletionConfig][google.cloud.retail.v2.CompletionConfig].
        /// </summary>
        /// <param name="name">
        /// Required. Full CompletionConfig resource name. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/completionConfig`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CompletionConfig> GetCompletionConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetCompletionConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a [CompletionConfig][google.cloud.retail.v2.CompletionConfig].
        /// </summary>
        /// <param name="name">
        /// Required. Full CompletionConfig resource name. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/completionConfig`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CompletionConfig GetCompletionConfig(CompletionConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCompletionConfig(new GetCompletionConfigRequest
            {
                CompletionConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [CompletionConfig][google.cloud.retail.v2.CompletionConfig].
        /// </summary>
        /// <param name="name">
        /// Required. Full CompletionConfig resource name. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/completionConfig`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CompletionConfig> GetCompletionConfigAsync(CompletionConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCompletionConfigAsync(new GetCompletionConfigRequest
            {
                CompletionConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [CompletionConfig][google.cloud.retail.v2.CompletionConfig].
        /// </summary>
        /// <param name="name">
        /// Required. Full CompletionConfig resource name. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/completionConfig`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CompletionConfig> GetCompletionConfigAsync(CompletionConfigName name, st::CancellationToken cancellationToken) =>
            GetCompletionConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the [CompletionConfig][google.cloud.retail.v2.CompletionConfig]s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CompletionConfig UpdateCompletionConfig(UpdateCompletionConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the [CompletionConfig][google.cloud.retail.v2.CompletionConfig]s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CompletionConfig> UpdateCompletionConfigAsync(UpdateCompletionConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the [CompletionConfig][google.cloud.retail.v2.CompletionConfig]s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CompletionConfig> UpdateCompletionConfigAsync(UpdateCompletionConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateCompletionConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the [CompletionConfig][google.cloud.retail.v2.CompletionConfig]s.
        /// </summary>
        /// <param name="completionConfig">
        /// Required. The [CompletionConfig][google.cloud.retail.v2.CompletionConfig]
        /// to update.
        /// 
        /// If the caller does not have permission to update the
        /// [CompletionConfig][google.cloud.retail.v2.CompletionConfig], then a
        /// PERMISSION_DENIED error is returned.
        /// 
        /// If the [CompletionConfig][google.cloud.retail.v2.CompletionConfig] to
        /// update does not exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="updateMask">
        /// Indicates which fields in the provided
        /// [CompletionConfig][google.cloud.retail.v2.CompletionConfig] to update. The
        /// following are the only supported fields:
        /// 
        /// * [CompletionConfig.matching_order][google.cloud.retail.v2.CompletionConfig.matching_order]
        /// * [CompletionConfig.max_suggestions][google.cloud.retail.v2.CompletionConfig.max_suggestions]
        /// * [CompletionConfig.min_prefix_length][google.cloud.retail.v2.CompletionConfig.min_prefix_length]
        /// * [CompletionConfig.auto_learning][google.cloud.retail.v2.CompletionConfig.auto_learning]
        /// 
        /// If not set, all supported fields are updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CompletionConfig UpdateCompletionConfig(CompletionConfig completionConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCompletionConfig(new UpdateCompletionConfigRequest
            {
                CompletionConfig = gax::GaxPreconditions.CheckNotNull(completionConfig, nameof(completionConfig)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the [CompletionConfig][google.cloud.retail.v2.CompletionConfig]s.
        /// </summary>
        /// <param name="completionConfig">
        /// Required. The [CompletionConfig][google.cloud.retail.v2.CompletionConfig]
        /// to update.
        /// 
        /// If the caller does not have permission to update the
        /// [CompletionConfig][google.cloud.retail.v2.CompletionConfig], then a
        /// PERMISSION_DENIED error is returned.
        /// 
        /// If the [CompletionConfig][google.cloud.retail.v2.CompletionConfig] to
        /// update does not exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="updateMask">
        /// Indicates which fields in the provided
        /// [CompletionConfig][google.cloud.retail.v2.CompletionConfig] to update. The
        /// following are the only supported fields:
        /// 
        /// * [CompletionConfig.matching_order][google.cloud.retail.v2.CompletionConfig.matching_order]
        /// * [CompletionConfig.max_suggestions][google.cloud.retail.v2.CompletionConfig.max_suggestions]
        /// * [CompletionConfig.min_prefix_length][google.cloud.retail.v2.CompletionConfig.min_prefix_length]
        /// * [CompletionConfig.auto_learning][google.cloud.retail.v2.CompletionConfig.auto_learning]
        /// 
        /// If not set, all supported fields are updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CompletionConfig> UpdateCompletionConfigAsync(CompletionConfig completionConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCompletionConfigAsync(new UpdateCompletionConfigRequest
            {
                CompletionConfig = gax::GaxPreconditions.CheckNotNull(completionConfig, nameof(completionConfig)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the [CompletionConfig][google.cloud.retail.v2.CompletionConfig]s.
        /// </summary>
        /// <param name="completionConfig">
        /// Required. The [CompletionConfig][google.cloud.retail.v2.CompletionConfig]
        /// to update.
        /// 
        /// If the caller does not have permission to update the
        /// [CompletionConfig][google.cloud.retail.v2.CompletionConfig], then a
        /// PERMISSION_DENIED error is returned.
        /// 
        /// If the [CompletionConfig][google.cloud.retail.v2.CompletionConfig] to
        /// update does not exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="updateMask">
        /// Indicates which fields in the provided
        /// [CompletionConfig][google.cloud.retail.v2.CompletionConfig] to update. The
        /// following are the only supported fields:
        /// 
        /// * [CompletionConfig.matching_order][google.cloud.retail.v2.CompletionConfig.matching_order]
        /// * [CompletionConfig.max_suggestions][google.cloud.retail.v2.CompletionConfig.max_suggestions]
        /// * [CompletionConfig.min_prefix_length][google.cloud.retail.v2.CompletionConfig.min_prefix_length]
        /// * [CompletionConfig.auto_learning][google.cloud.retail.v2.CompletionConfig.auto_learning]
        /// 
        /// If not set, all supported fields are updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CompletionConfig> UpdateCompletionConfigAsync(CompletionConfig completionConfig, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateCompletionConfigAsync(completionConfig, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an [AttributesConfig][google.cloud.retail.v2.AttributesConfig].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AttributesConfig GetAttributesConfig(GetAttributesConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an [AttributesConfig][google.cloud.retail.v2.AttributesConfig].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AttributesConfig> GetAttributesConfigAsync(GetAttributesConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an [AttributesConfig][google.cloud.retail.v2.AttributesConfig].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AttributesConfig> GetAttributesConfigAsync(GetAttributesConfigRequest request, st::CancellationToken cancellationToken) =>
            GetAttributesConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an [AttributesConfig][google.cloud.retail.v2.AttributesConfig].
        /// </summary>
        /// <param name="name">
        /// Required. Full AttributesConfig resource name. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/attributesConfig`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AttributesConfig GetAttributesConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAttributesConfig(new GetAttributesConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an [AttributesConfig][google.cloud.retail.v2.AttributesConfig].
        /// </summary>
        /// <param name="name">
        /// Required. Full AttributesConfig resource name. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/attributesConfig`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AttributesConfig> GetAttributesConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAttributesConfigAsync(new GetAttributesConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an [AttributesConfig][google.cloud.retail.v2.AttributesConfig].
        /// </summary>
        /// <param name="name">
        /// Required. Full AttributesConfig resource name. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/attributesConfig`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AttributesConfig> GetAttributesConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetAttributesConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an [AttributesConfig][google.cloud.retail.v2.AttributesConfig].
        /// </summary>
        /// <param name="name">
        /// Required. Full AttributesConfig resource name. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/attributesConfig`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AttributesConfig GetAttributesConfig(AttributesConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAttributesConfig(new GetAttributesConfigRequest
            {
                AttributesConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an [AttributesConfig][google.cloud.retail.v2.AttributesConfig].
        /// </summary>
        /// <param name="name">
        /// Required. Full AttributesConfig resource name. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/attributesConfig`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AttributesConfig> GetAttributesConfigAsync(AttributesConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAttributesConfigAsync(new GetAttributesConfigRequest
            {
                AttributesConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an [AttributesConfig][google.cloud.retail.v2.AttributesConfig].
        /// </summary>
        /// <param name="name">
        /// Required. Full AttributesConfig resource name. Format:
        /// `projects/{project_number}/locations/{location_id}/catalogs/{catalog_id}/attributesConfig`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AttributesConfig> GetAttributesConfigAsync(AttributesConfigName name, st::CancellationToken cancellationToken) =>
            GetAttributesConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the [AttributesConfig][google.cloud.retail.v2.AttributesConfig].
        /// 
        /// The catalog attributes in the request will be updated in the catalog, or
        /// inserted if they do not exist. Existing catalog attributes not included in
        /// the request will remain unchanged. Attributes that are assigned to
        /// products, but do not exist at the catalog level, are always included in the
        /// response. The product attribute is assigned default values for missing
        /// catalog attribute fields, e.g., searchable and dynamic facetable options.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AttributesConfig UpdateAttributesConfig(UpdateAttributesConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the [AttributesConfig][google.cloud.retail.v2.AttributesConfig].
        /// 
        /// The catalog attributes in the request will be updated in the catalog, or
        /// inserted if they do not exist. Existing catalog attributes not included in
        /// the request will remain unchanged. Attributes that are assigned to
        /// products, but do not exist at the catalog level, are always included in the
        /// response. The product attribute is assigned default values for missing
        /// catalog attribute fields, e.g., searchable and dynamic facetable options.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AttributesConfig> UpdateAttributesConfigAsync(UpdateAttributesConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the [AttributesConfig][google.cloud.retail.v2.AttributesConfig].
        /// 
        /// The catalog attributes in the request will be updated in the catalog, or
        /// inserted if they do not exist. Existing catalog attributes not included in
        /// the request will remain unchanged. Attributes that are assigned to
        /// products, but do not exist at the catalog level, are always included in the
        /// response. The product attribute is assigned default values for missing
        /// catalog attribute fields, e.g., searchable and dynamic facetable options.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AttributesConfig> UpdateAttributesConfigAsync(UpdateAttributesConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateAttributesConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the [AttributesConfig][google.cloud.retail.v2.AttributesConfig].
        /// 
        /// The catalog attributes in the request will be updated in the catalog, or
        /// inserted if they do not exist. Existing catalog attributes not included in
        /// the request will remain unchanged. Attributes that are assigned to
        /// products, but do not exist at the catalog level, are always included in the
        /// response. The product attribute is assigned default values for missing
        /// catalog attribute fields, e.g., searchable and dynamic facetable options.
        /// </summary>
        /// <param name="attributesConfig">
        /// Required. The [AttributesConfig][google.cloud.retail.v2.AttributesConfig]
        /// to update.
        /// </param>
        /// <param name="updateMask">
        /// Indicates which fields in the provided
        /// [AttributesConfig][google.cloud.retail.v2.AttributesConfig] to update. The
        /// following is the only supported field:
        /// 
        /// * [AttributesConfig.catalog_attributes][google.cloud.retail.v2.AttributesConfig.catalog_attributes]
        /// 
        /// If not set, all supported fields are updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AttributesConfig UpdateAttributesConfig(AttributesConfig attributesConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAttributesConfig(new UpdateAttributesConfigRequest
            {
                AttributesConfig = gax::GaxPreconditions.CheckNotNull(attributesConfig, nameof(attributesConfig)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the [AttributesConfig][google.cloud.retail.v2.AttributesConfig].
        /// 
        /// The catalog attributes in the request will be updated in the catalog, or
        /// inserted if they do not exist. Existing catalog attributes not included in
        /// the request will remain unchanged. Attributes that are assigned to
        /// products, but do not exist at the catalog level, are always included in the
        /// response. The product attribute is assigned default values for missing
        /// catalog attribute fields, e.g., searchable and dynamic facetable options.
        /// </summary>
        /// <param name="attributesConfig">
        /// Required. The [AttributesConfig][google.cloud.retail.v2.AttributesConfig]
        /// to update.
        /// </param>
        /// <param name="updateMask">
        /// Indicates which fields in the provided
        /// [AttributesConfig][google.cloud.retail.v2.AttributesConfig] to update. The
        /// following is the only supported field:
        /// 
        /// * [AttributesConfig.catalog_attributes][google.cloud.retail.v2.AttributesConfig.catalog_attributes]
        /// 
        /// If not set, all supported fields are updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AttributesConfig> UpdateAttributesConfigAsync(AttributesConfig attributesConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAttributesConfigAsync(new UpdateAttributesConfigRequest
            {
                AttributesConfig = gax::GaxPreconditions.CheckNotNull(attributesConfig, nameof(attributesConfig)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the [AttributesConfig][google.cloud.retail.v2.AttributesConfig].
        /// 
        /// The catalog attributes in the request will be updated in the catalog, or
        /// inserted if they do not exist. Existing catalog attributes not included in
        /// the request will remain unchanged. Attributes that are assigned to
        /// products, but do not exist at the catalog level, are always included in the
        /// response. The product attribute is assigned default values for missing
        /// catalog attribute fields, e.g., searchable and dynamic facetable options.
        /// </summary>
        /// <param name="attributesConfig">
        /// Required. The [AttributesConfig][google.cloud.retail.v2.AttributesConfig]
        /// to update.
        /// </param>
        /// <param name="updateMask">
        /// Indicates which fields in the provided
        /// [AttributesConfig][google.cloud.retail.v2.AttributesConfig] to update. The
        /// following is the only supported field:
        /// 
        /// * [AttributesConfig.catalog_attributes][google.cloud.retail.v2.AttributesConfig.catalog_attributes]
        /// 
        /// If not set, all supported fields are updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AttributesConfig> UpdateAttributesConfigAsync(AttributesConfig attributesConfig, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateAttributesConfigAsync(attributesConfig, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds the specified
        /// [CatalogAttribute][google.cloud.retail.v2.CatalogAttribute] to the
        /// [AttributesConfig][google.cloud.retail.v2.AttributesConfig].
        /// 
        /// If the [CatalogAttribute][google.cloud.retail.v2.CatalogAttribute] to add
        /// already exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AttributesConfig AddCatalogAttribute(AddCatalogAttributeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds the specified
        /// [CatalogAttribute][google.cloud.retail.v2.CatalogAttribute] to the
        /// [AttributesConfig][google.cloud.retail.v2.AttributesConfig].
        /// 
        /// If the [CatalogAttribute][google.cloud.retail.v2.CatalogAttribute] to add
        /// already exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AttributesConfig> AddCatalogAttributeAsync(AddCatalogAttributeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds the specified
        /// [CatalogAttribute][google.cloud.retail.v2.CatalogAttribute] to the
        /// [AttributesConfig][google.cloud.retail.v2.AttributesConfig].
        /// 
        /// If the [CatalogAttribute][google.cloud.retail.v2.CatalogAttribute] to add
        /// already exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AttributesConfig> AddCatalogAttributeAsync(AddCatalogAttributeRequest request, st::CancellationToken cancellationToken) =>
            AddCatalogAttributeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes the specified
        /// [CatalogAttribute][google.cloud.retail.v2.CatalogAttribute] from the
        /// [AttributesConfig][google.cloud.retail.v2.AttributesConfig].
        /// 
        /// If the [CatalogAttribute][google.cloud.retail.v2.CatalogAttribute] to
        /// remove does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AttributesConfig RemoveCatalogAttribute(RemoveCatalogAttributeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes the specified
        /// [CatalogAttribute][google.cloud.retail.v2.CatalogAttribute] from the
        /// [AttributesConfig][google.cloud.retail.v2.AttributesConfig].
        /// 
        /// If the [CatalogAttribute][google.cloud.retail.v2.CatalogAttribute] to
        /// remove does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AttributesConfig> RemoveCatalogAttributeAsync(RemoveCatalogAttributeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes the specified
        /// [CatalogAttribute][google.cloud.retail.v2.CatalogAttribute] from the
        /// [AttributesConfig][google.cloud.retail.v2.AttributesConfig].
        /// 
        /// If the [CatalogAttribute][google.cloud.retail.v2.CatalogAttribute] to
        /// remove does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AttributesConfig> RemoveCatalogAttributeAsync(RemoveCatalogAttributeRequest request, st::CancellationToken cancellationToken) =>
            RemoveCatalogAttributeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Replaces the specified
        /// [CatalogAttribute][google.cloud.retail.v2.CatalogAttribute] in the
        /// [AttributesConfig][google.cloud.retail.v2.AttributesConfig] by updating the
        /// catalog attribute with the same
        /// [CatalogAttribute.key][google.cloud.retail.v2.CatalogAttribute.key].
        /// 
        /// If the [CatalogAttribute][google.cloud.retail.v2.CatalogAttribute] to
        /// replace does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AttributesConfig ReplaceCatalogAttribute(ReplaceCatalogAttributeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Replaces the specified
        /// [CatalogAttribute][google.cloud.retail.v2.CatalogAttribute] in the
        /// [AttributesConfig][google.cloud.retail.v2.AttributesConfig] by updating the
        /// catalog attribute with the same
        /// [CatalogAttribute.key][google.cloud.retail.v2.CatalogAttribute.key].
        /// 
        /// If the [CatalogAttribute][google.cloud.retail.v2.CatalogAttribute] to
        /// replace does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AttributesConfig> ReplaceCatalogAttributeAsync(ReplaceCatalogAttributeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Replaces the specified
        /// [CatalogAttribute][google.cloud.retail.v2.CatalogAttribute] in the
        /// [AttributesConfig][google.cloud.retail.v2.AttributesConfig] by updating the
        /// catalog attribute with the same
        /// [CatalogAttribute.key][google.cloud.retail.v2.CatalogAttribute.key].
        /// 
        /// If the [CatalogAttribute][google.cloud.retail.v2.CatalogAttribute] to
        /// replace does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AttributesConfig> ReplaceCatalogAttributeAsync(ReplaceCatalogAttributeRequest request, st::CancellationToken cancellationToken) =>
            ReplaceCatalogAttributeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CatalogService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing catalog configuration.
    /// </remarks>
    public sealed partial class CatalogServiceClientImpl : CatalogServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListCatalogsRequest, ListCatalogsResponse> _callListCatalogs;

        private readonly gaxgrpc::ApiCall<UpdateCatalogRequest, Catalog> _callUpdateCatalog;

        private readonly gaxgrpc::ApiCall<SetDefaultBranchRequest, wkt::Empty> _callSetDefaultBranch;

        private readonly gaxgrpc::ApiCall<GetDefaultBranchRequest, GetDefaultBranchResponse> _callGetDefaultBranch;

        private readonly gaxgrpc::ApiCall<GetCompletionConfigRequest, CompletionConfig> _callGetCompletionConfig;

        private readonly gaxgrpc::ApiCall<UpdateCompletionConfigRequest, CompletionConfig> _callUpdateCompletionConfig;

        private readonly gaxgrpc::ApiCall<GetAttributesConfigRequest, AttributesConfig> _callGetAttributesConfig;

        private readonly gaxgrpc::ApiCall<UpdateAttributesConfigRequest, AttributesConfig> _callUpdateAttributesConfig;

        private readonly gaxgrpc::ApiCall<AddCatalogAttributeRequest, AttributesConfig> _callAddCatalogAttribute;

        private readonly gaxgrpc::ApiCall<RemoveCatalogAttributeRequest, AttributesConfig> _callRemoveCatalogAttribute;

        private readonly gaxgrpc::ApiCall<ReplaceCatalogAttributeRequest, AttributesConfig> _callReplaceCatalogAttribute;

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
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListCatalogs = clientHelper.BuildApiCall<ListCatalogsRequest, ListCatalogsResponse>("ListCatalogs", grpcClient.ListCatalogsAsync, grpcClient.ListCatalogs, effectiveSettings.ListCatalogsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCatalogs);
            Modify_ListCatalogsApiCall(ref _callListCatalogs);
            _callUpdateCatalog = clientHelper.BuildApiCall<UpdateCatalogRequest, Catalog>("UpdateCatalog", grpcClient.UpdateCatalogAsync, grpcClient.UpdateCatalog, effectiveSettings.UpdateCatalogSettings).WithGoogleRequestParam("catalog.name", request => request.Catalog?.Name);
            Modify_ApiCall(ref _callUpdateCatalog);
            Modify_UpdateCatalogApiCall(ref _callUpdateCatalog);
            _callSetDefaultBranch = clientHelper.BuildApiCall<SetDefaultBranchRequest, wkt::Empty>("SetDefaultBranch", grpcClient.SetDefaultBranchAsync, grpcClient.SetDefaultBranch, effectiveSettings.SetDefaultBranchSettings).WithGoogleRequestParam("catalog", request => request.Catalog);
            Modify_ApiCall(ref _callSetDefaultBranch);
            Modify_SetDefaultBranchApiCall(ref _callSetDefaultBranch);
            _callGetDefaultBranch = clientHelper.BuildApiCall<GetDefaultBranchRequest, GetDefaultBranchResponse>("GetDefaultBranch", grpcClient.GetDefaultBranchAsync, grpcClient.GetDefaultBranch, effectiveSettings.GetDefaultBranchSettings).WithGoogleRequestParam("catalog", request => request.Catalog);
            Modify_ApiCall(ref _callGetDefaultBranch);
            Modify_GetDefaultBranchApiCall(ref _callGetDefaultBranch);
            _callGetCompletionConfig = clientHelper.BuildApiCall<GetCompletionConfigRequest, CompletionConfig>("GetCompletionConfig", grpcClient.GetCompletionConfigAsync, grpcClient.GetCompletionConfig, effectiveSettings.GetCompletionConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCompletionConfig);
            Modify_GetCompletionConfigApiCall(ref _callGetCompletionConfig);
            _callUpdateCompletionConfig = clientHelper.BuildApiCall<UpdateCompletionConfigRequest, CompletionConfig>("UpdateCompletionConfig", grpcClient.UpdateCompletionConfigAsync, grpcClient.UpdateCompletionConfig, effectiveSettings.UpdateCompletionConfigSettings).WithGoogleRequestParam("completion_config.name", request => request.CompletionConfig?.Name);
            Modify_ApiCall(ref _callUpdateCompletionConfig);
            Modify_UpdateCompletionConfigApiCall(ref _callUpdateCompletionConfig);
            _callGetAttributesConfig = clientHelper.BuildApiCall<GetAttributesConfigRequest, AttributesConfig>("GetAttributesConfig", grpcClient.GetAttributesConfigAsync, grpcClient.GetAttributesConfig, effectiveSettings.GetAttributesConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAttributesConfig);
            Modify_GetAttributesConfigApiCall(ref _callGetAttributesConfig);
            _callUpdateAttributesConfig = clientHelper.BuildApiCall<UpdateAttributesConfigRequest, AttributesConfig>("UpdateAttributesConfig", grpcClient.UpdateAttributesConfigAsync, grpcClient.UpdateAttributesConfig, effectiveSettings.UpdateAttributesConfigSettings).WithGoogleRequestParam("attributes_config.name", request => request.AttributesConfig?.Name);
            Modify_ApiCall(ref _callUpdateAttributesConfig);
            Modify_UpdateAttributesConfigApiCall(ref _callUpdateAttributesConfig);
            _callAddCatalogAttribute = clientHelper.BuildApiCall<AddCatalogAttributeRequest, AttributesConfig>("AddCatalogAttribute", grpcClient.AddCatalogAttributeAsync, grpcClient.AddCatalogAttribute, effectiveSettings.AddCatalogAttributeSettings).WithGoogleRequestParam("attributes_config", request => request.AttributesConfig);
            Modify_ApiCall(ref _callAddCatalogAttribute);
            Modify_AddCatalogAttributeApiCall(ref _callAddCatalogAttribute);
            _callRemoveCatalogAttribute = clientHelper.BuildApiCall<RemoveCatalogAttributeRequest, AttributesConfig>("RemoveCatalogAttribute", grpcClient.RemoveCatalogAttributeAsync, grpcClient.RemoveCatalogAttribute, effectiveSettings.RemoveCatalogAttributeSettings).WithGoogleRequestParam("attributes_config", request => request.AttributesConfig);
            Modify_ApiCall(ref _callRemoveCatalogAttribute);
            Modify_RemoveCatalogAttributeApiCall(ref _callRemoveCatalogAttribute);
            _callReplaceCatalogAttribute = clientHelper.BuildApiCall<ReplaceCatalogAttributeRequest, AttributesConfig>("ReplaceCatalogAttribute", grpcClient.ReplaceCatalogAttributeAsync, grpcClient.ReplaceCatalogAttribute, effectiveSettings.ReplaceCatalogAttributeSettings).WithGoogleRequestParam("attributes_config", request => request.AttributesConfig);
            Modify_ApiCall(ref _callReplaceCatalogAttribute);
            Modify_ReplaceCatalogAttributeApiCall(ref _callReplaceCatalogAttribute);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListCatalogsApiCall(ref gaxgrpc::ApiCall<ListCatalogsRequest, ListCatalogsResponse> call);

        partial void Modify_UpdateCatalogApiCall(ref gaxgrpc::ApiCall<UpdateCatalogRequest, Catalog> call);

        partial void Modify_SetDefaultBranchApiCall(ref gaxgrpc::ApiCall<SetDefaultBranchRequest, wkt::Empty> call);

        partial void Modify_GetDefaultBranchApiCall(ref gaxgrpc::ApiCall<GetDefaultBranchRequest, GetDefaultBranchResponse> call);

        partial void Modify_GetCompletionConfigApiCall(ref gaxgrpc::ApiCall<GetCompletionConfigRequest, CompletionConfig> call);

        partial void Modify_UpdateCompletionConfigApiCall(ref gaxgrpc::ApiCall<UpdateCompletionConfigRequest, CompletionConfig> call);

        partial void Modify_GetAttributesConfigApiCall(ref gaxgrpc::ApiCall<GetAttributesConfigRequest, AttributesConfig> call);

        partial void Modify_UpdateAttributesConfigApiCall(ref gaxgrpc::ApiCall<UpdateAttributesConfigRequest, AttributesConfig> call);

        partial void Modify_AddCatalogAttributeApiCall(ref gaxgrpc::ApiCall<AddCatalogAttributeRequest, AttributesConfig> call);

        partial void Modify_RemoveCatalogAttributeApiCall(ref gaxgrpc::ApiCall<RemoveCatalogAttributeRequest, AttributesConfig> call);

        partial void Modify_ReplaceCatalogAttributeApiCall(ref gaxgrpc::ApiCall<ReplaceCatalogAttributeRequest, AttributesConfig> call);

        partial void OnConstruction(CatalogService.CatalogServiceClient grpcClient, CatalogServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CatalogService client</summary>
        public override CatalogService.CatalogServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListCatalogsRequest(ref ListCatalogsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateCatalogRequest(ref UpdateCatalogRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetDefaultBranchRequest(ref SetDefaultBranchRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDefaultBranchRequest(ref GetDefaultBranchRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetCompletionConfigRequest(ref GetCompletionConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateCompletionConfigRequest(ref UpdateCompletionConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAttributesConfigRequest(ref GetAttributesConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAttributesConfigRequest(ref UpdateAttributesConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AddCatalogAttributeRequest(ref AddCatalogAttributeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RemoveCatalogAttributeRequest(ref RemoveCatalogAttributeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ReplaceCatalogAttributeRequest(ref ReplaceCatalogAttributeRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists all the [Catalog][google.cloud.retail.v2.Catalog]s associated with
        /// the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Catalog"/> resources.</returns>
        public override gax::PagedEnumerable<ListCatalogsResponse, Catalog> ListCatalogs(ListCatalogsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCatalogsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCatalogsRequest, ListCatalogsResponse, Catalog>(_callListCatalogs, request, callSettings);
        }

        /// <summary>
        /// Lists all the [Catalog][google.cloud.retail.v2.Catalog]s associated with
        /// the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Catalog"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCatalogsResponse, Catalog> ListCatalogsAsync(ListCatalogsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCatalogsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCatalogsRequest, ListCatalogsResponse, Catalog>(_callListCatalogs, request, callSettings);
        }

        /// <summary>
        /// Updates the [Catalog][google.cloud.retail.v2.Catalog]s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Catalog UpdateCatalog(UpdateCatalogRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCatalogRequest(ref request, ref callSettings);
            return _callUpdateCatalog.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the [Catalog][google.cloud.retail.v2.Catalog]s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Catalog> UpdateCatalogAsync(UpdateCatalogRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCatalogRequest(ref request, ref callSettings);
            return _callUpdateCatalog.Async(request, callSettings);
        }

        /// <summary>
        /// Set a specified branch id as default branch. API methods such as
        /// [SearchService.Search][google.cloud.retail.v2.SearchService.Search],
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct],
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts]
        /// will treat requests using "default_branch" to the actual branch id set as
        /// default.
        /// 
        /// For example, if `projects/*/locations/*/catalogs/*/branches/1` is set as
        /// default, setting
        /// [SearchRequest.branch][google.cloud.retail.v2.SearchRequest.branch] to
        /// `projects/*/locations/*/catalogs/*/branches/default_branch` is equivalent
        /// to setting
        /// [SearchRequest.branch][google.cloud.retail.v2.SearchRequest.branch] to
        /// `projects/*/locations/*/catalogs/*/branches/1`.
        /// 
        /// Using multiple branches can be useful when developers would like
        /// to have a staging branch to test and verify for future usage. When it
        /// becomes ready, developers switch on the staging branch using this API while
        /// keeping using `projects/*/locations/*/catalogs/*/branches/default_branch`
        /// as [SearchRequest.branch][google.cloud.retail.v2.SearchRequest.branch] to
        /// route the traffic to this staging branch.
        /// 
        /// CAUTION: If you have live predict/search traffic, switching the default
        /// branch could potentially cause outages if the ID space of the new branch is
        /// very different from the old one.
        /// 
        /// More specifically:
        /// 
        /// * PredictionService will only return product IDs from branch {newBranch}.
        /// * SearchService will only return product IDs from branch {newBranch}
        /// (if branch is not explicitly set).
        /// * UserEventService will only join events with products from branch
        /// {newBranch}.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void SetDefaultBranch(SetDefaultBranchRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetDefaultBranchRequest(ref request, ref callSettings);
            _callSetDefaultBranch.Sync(request, callSettings);
        }

        /// <summary>
        /// Set a specified branch id as default branch. API methods such as
        /// [SearchService.Search][google.cloud.retail.v2.SearchService.Search],
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct],
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts]
        /// will treat requests using "default_branch" to the actual branch id set as
        /// default.
        /// 
        /// For example, if `projects/*/locations/*/catalogs/*/branches/1` is set as
        /// default, setting
        /// [SearchRequest.branch][google.cloud.retail.v2.SearchRequest.branch] to
        /// `projects/*/locations/*/catalogs/*/branches/default_branch` is equivalent
        /// to setting
        /// [SearchRequest.branch][google.cloud.retail.v2.SearchRequest.branch] to
        /// `projects/*/locations/*/catalogs/*/branches/1`.
        /// 
        /// Using multiple branches can be useful when developers would like
        /// to have a staging branch to test and verify for future usage. When it
        /// becomes ready, developers switch on the staging branch using this API while
        /// keeping using `projects/*/locations/*/catalogs/*/branches/default_branch`
        /// as [SearchRequest.branch][google.cloud.retail.v2.SearchRequest.branch] to
        /// route the traffic to this staging branch.
        /// 
        /// CAUTION: If you have live predict/search traffic, switching the default
        /// branch could potentially cause outages if the ID space of the new branch is
        /// very different from the old one.
        /// 
        /// More specifically:
        /// 
        /// * PredictionService will only return product IDs from branch {newBranch}.
        /// * SearchService will only return product IDs from branch {newBranch}
        /// (if branch is not explicitly set).
        /// * UserEventService will only join events with products from branch
        /// {newBranch}.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task SetDefaultBranchAsync(SetDefaultBranchRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetDefaultBranchRequest(ref request, ref callSettings);
            return _callSetDefaultBranch.Async(request, callSettings);
        }

        /// <summary>
        /// Get which branch is currently default branch set by
        /// [CatalogService.SetDefaultBranch][google.cloud.retail.v2.CatalogService.SetDefaultBranch]
        /// method under a specified parent catalog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GetDefaultBranchResponse GetDefaultBranch(GetDefaultBranchRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDefaultBranchRequest(ref request, ref callSettings);
            return _callGetDefaultBranch.Sync(request, callSettings);
        }

        /// <summary>
        /// Get which branch is currently default branch set by
        /// [CatalogService.SetDefaultBranch][google.cloud.retail.v2.CatalogService.SetDefaultBranch]
        /// method under a specified parent catalog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GetDefaultBranchResponse> GetDefaultBranchAsync(GetDefaultBranchRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDefaultBranchRequest(ref request, ref callSettings);
            return _callGetDefaultBranch.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a [CompletionConfig][google.cloud.retail.v2.CompletionConfig].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CompletionConfig GetCompletionConfig(GetCompletionConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCompletionConfigRequest(ref request, ref callSettings);
            return _callGetCompletionConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a [CompletionConfig][google.cloud.retail.v2.CompletionConfig].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CompletionConfig> GetCompletionConfigAsync(GetCompletionConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCompletionConfigRequest(ref request, ref callSettings);
            return _callGetCompletionConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the [CompletionConfig][google.cloud.retail.v2.CompletionConfig]s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CompletionConfig UpdateCompletionConfig(UpdateCompletionConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCompletionConfigRequest(ref request, ref callSettings);
            return _callUpdateCompletionConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the [CompletionConfig][google.cloud.retail.v2.CompletionConfig]s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CompletionConfig> UpdateCompletionConfigAsync(UpdateCompletionConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCompletionConfigRequest(ref request, ref callSettings);
            return _callUpdateCompletionConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Gets an [AttributesConfig][google.cloud.retail.v2.AttributesConfig].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AttributesConfig GetAttributesConfig(GetAttributesConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAttributesConfigRequest(ref request, ref callSettings);
            return _callGetAttributesConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an [AttributesConfig][google.cloud.retail.v2.AttributesConfig].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AttributesConfig> GetAttributesConfigAsync(GetAttributesConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAttributesConfigRequest(ref request, ref callSettings);
            return _callGetAttributesConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the [AttributesConfig][google.cloud.retail.v2.AttributesConfig].
        /// 
        /// The catalog attributes in the request will be updated in the catalog, or
        /// inserted if they do not exist. Existing catalog attributes not included in
        /// the request will remain unchanged. Attributes that are assigned to
        /// products, but do not exist at the catalog level, are always included in the
        /// response. The product attribute is assigned default values for missing
        /// catalog attribute fields, e.g., searchable and dynamic facetable options.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AttributesConfig UpdateAttributesConfig(UpdateAttributesConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAttributesConfigRequest(ref request, ref callSettings);
            return _callUpdateAttributesConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the [AttributesConfig][google.cloud.retail.v2.AttributesConfig].
        /// 
        /// The catalog attributes in the request will be updated in the catalog, or
        /// inserted if they do not exist. Existing catalog attributes not included in
        /// the request will remain unchanged. Attributes that are assigned to
        /// products, but do not exist at the catalog level, are always included in the
        /// response. The product attribute is assigned default values for missing
        /// catalog attribute fields, e.g., searchable and dynamic facetable options.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AttributesConfig> UpdateAttributesConfigAsync(UpdateAttributesConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAttributesConfigRequest(ref request, ref callSettings);
            return _callUpdateAttributesConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Adds the specified
        /// [CatalogAttribute][google.cloud.retail.v2.CatalogAttribute] to the
        /// [AttributesConfig][google.cloud.retail.v2.AttributesConfig].
        /// 
        /// If the [CatalogAttribute][google.cloud.retail.v2.CatalogAttribute] to add
        /// already exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AttributesConfig AddCatalogAttribute(AddCatalogAttributeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddCatalogAttributeRequest(ref request, ref callSettings);
            return _callAddCatalogAttribute.Sync(request, callSettings);
        }

        /// <summary>
        /// Adds the specified
        /// [CatalogAttribute][google.cloud.retail.v2.CatalogAttribute] to the
        /// [AttributesConfig][google.cloud.retail.v2.AttributesConfig].
        /// 
        /// If the [CatalogAttribute][google.cloud.retail.v2.CatalogAttribute] to add
        /// already exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AttributesConfig> AddCatalogAttributeAsync(AddCatalogAttributeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddCatalogAttributeRequest(ref request, ref callSettings);
            return _callAddCatalogAttribute.Async(request, callSettings);
        }

        /// <summary>
        /// Removes the specified
        /// [CatalogAttribute][google.cloud.retail.v2.CatalogAttribute] from the
        /// [AttributesConfig][google.cloud.retail.v2.AttributesConfig].
        /// 
        /// If the [CatalogAttribute][google.cloud.retail.v2.CatalogAttribute] to
        /// remove does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AttributesConfig RemoveCatalogAttribute(RemoveCatalogAttributeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveCatalogAttributeRequest(ref request, ref callSettings);
            return _callRemoveCatalogAttribute.Sync(request, callSettings);
        }

        /// <summary>
        /// Removes the specified
        /// [CatalogAttribute][google.cloud.retail.v2.CatalogAttribute] from the
        /// [AttributesConfig][google.cloud.retail.v2.AttributesConfig].
        /// 
        /// If the [CatalogAttribute][google.cloud.retail.v2.CatalogAttribute] to
        /// remove does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AttributesConfig> RemoveCatalogAttributeAsync(RemoveCatalogAttributeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveCatalogAttributeRequest(ref request, ref callSettings);
            return _callRemoveCatalogAttribute.Async(request, callSettings);
        }

        /// <summary>
        /// Replaces the specified
        /// [CatalogAttribute][google.cloud.retail.v2.CatalogAttribute] in the
        /// [AttributesConfig][google.cloud.retail.v2.AttributesConfig] by updating the
        /// catalog attribute with the same
        /// [CatalogAttribute.key][google.cloud.retail.v2.CatalogAttribute.key].
        /// 
        /// If the [CatalogAttribute][google.cloud.retail.v2.CatalogAttribute] to
        /// replace does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AttributesConfig ReplaceCatalogAttribute(ReplaceCatalogAttributeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReplaceCatalogAttributeRequest(ref request, ref callSettings);
            return _callReplaceCatalogAttribute.Sync(request, callSettings);
        }

        /// <summary>
        /// Replaces the specified
        /// [CatalogAttribute][google.cloud.retail.v2.CatalogAttribute] in the
        /// [AttributesConfig][google.cloud.retail.v2.AttributesConfig] by updating the
        /// catalog attribute with the same
        /// [CatalogAttribute.key][google.cloud.retail.v2.CatalogAttribute.key].
        /// 
        /// If the [CatalogAttribute][google.cloud.retail.v2.CatalogAttribute] to
        /// replace does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AttributesConfig> ReplaceCatalogAttributeAsync(ReplaceCatalogAttributeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReplaceCatalogAttributeRequest(ref request, ref callSettings);
            return _callReplaceCatalogAttribute.Async(request, callSettings);
        }
    }

    public partial class ListCatalogsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCatalogsResponse : gaxgrpc::IPageResponse<Catalog>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Catalog> GetEnumerator() => Catalogs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class CatalogService
    {
        public partial class CatalogServiceClient
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
