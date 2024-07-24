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
    /// <summary>Settings for <see cref="SiteSearchEngineServiceClient"/> instances.</summary>
    public sealed partial class SiteSearchEngineServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SiteSearchEngineServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SiteSearchEngineServiceSettings"/>.</returns>
        public static SiteSearchEngineServiceSettings GetDefault() => new SiteSearchEngineServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="SiteSearchEngineServiceSettings"/> object with default settings.
        /// </summary>
        public SiteSearchEngineServiceSettings()
        {
        }

        private SiteSearchEngineServiceSettings(SiteSearchEngineServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetSiteSearchEngineSettings = existing.GetSiteSearchEngineSettings;
            CreateTargetSiteSettings = existing.CreateTargetSiteSettings;
            CreateTargetSiteOperationsSettings = existing.CreateTargetSiteOperationsSettings.Clone();
            BatchCreateTargetSitesSettings = existing.BatchCreateTargetSitesSettings;
            BatchCreateTargetSitesOperationsSettings = existing.BatchCreateTargetSitesOperationsSettings.Clone();
            GetTargetSiteSettings = existing.GetTargetSiteSettings;
            UpdateTargetSiteSettings = existing.UpdateTargetSiteSettings;
            UpdateTargetSiteOperationsSettings = existing.UpdateTargetSiteOperationsSettings.Clone();
            DeleteTargetSiteSettings = existing.DeleteTargetSiteSettings;
            DeleteTargetSiteOperationsSettings = existing.DeleteTargetSiteOperationsSettings.Clone();
            ListTargetSitesSettings = existing.ListTargetSitesSettings;
            EnableAdvancedSiteSearchSettings = existing.EnableAdvancedSiteSearchSettings;
            EnableAdvancedSiteSearchOperationsSettings = existing.EnableAdvancedSiteSearchOperationsSettings.Clone();
            DisableAdvancedSiteSearchSettings = existing.DisableAdvancedSiteSearchSettings;
            DisableAdvancedSiteSearchOperationsSettings = existing.DisableAdvancedSiteSearchOperationsSettings.Clone();
            RecrawlUrisSettings = existing.RecrawlUrisSettings;
            RecrawlUrisOperationsSettings = existing.RecrawlUrisOperationsSettings.Clone();
            BatchVerifyTargetSitesSettings = existing.BatchVerifyTargetSitesSettings;
            BatchVerifyTargetSitesOperationsSettings = existing.BatchVerifyTargetSitesOperationsSettings.Clone();
            FetchDomainVerificationStatusSettings = existing.FetchDomainVerificationStatusSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SiteSearchEngineServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SiteSearchEngineServiceClient.GetSiteSearchEngine</c> and
        /// <c>SiteSearchEngineServiceClient.GetSiteSearchEngineAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSiteSearchEngineSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SiteSearchEngineServiceClient.CreateTargetSite</c> and
        /// <c>SiteSearchEngineServiceClient.CreateTargetSiteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateTargetSiteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>SiteSearchEngineServiceClient.CreateTargetSite</c> and
        /// <c>SiteSearchEngineServiceClient.CreateTargetSiteAsync</c>.
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
        public lro::OperationsSettings CreateTargetSiteOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SiteSearchEngineServiceClient.BatchCreateTargetSites</c> and
        /// <c>SiteSearchEngineServiceClient.BatchCreateTargetSitesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchCreateTargetSitesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>SiteSearchEngineServiceClient.BatchCreateTargetSites</c> and
        /// <c>SiteSearchEngineServiceClient.BatchCreateTargetSitesAsync</c>.
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
        public lro::OperationsSettings BatchCreateTargetSitesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SiteSearchEngineServiceClient.GetTargetSite</c> and <c>SiteSearchEngineServiceClient.GetTargetSiteAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetTargetSiteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SiteSearchEngineServiceClient.UpdateTargetSite</c> and
        /// <c>SiteSearchEngineServiceClient.UpdateTargetSiteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateTargetSiteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>SiteSearchEngineServiceClient.UpdateTargetSite</c> and
        /// <c>SiteSearchEngineServiceClient.UpdateTargetSiteAsync</c>.
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
        public lro::OperationsSettings UpdateTargetSiteOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SiteSearchEngineServiceClient.DeleteTargetSite</c> and
        /// <c>SiteSearchEngineServiceClient.DeleteTargetSiteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteTargetSiteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>SiteSearchEngineServiceClient.DeleteTargetSite</c> and
        /// <c>SiteSearchEngineServiceClient.DeleteTargetSiteAsync</c>.
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
        public lro::OperationsSettings DeleteTargetSiteOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SiteSearchEngineServiceClient.ListTargetSites</c> and
        /// <c>SiteSearchEngineServiceClient.ListTargetSitesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTargetSitesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SiteSearchEngineServiceClient.EnableAdvancedSiteSearch</c> and
        /// <c>SiteSearchEngineServiceClient.EnableAdvancedSiteSearchAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings EnableAdvancedSiteSearchSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>SiteSearchEngineServiceClient.EnableAdvancedSiteSearch</c>
        /// and <c>SiteSearchEngineServiceClient.EnableAdvancedSiteSearchAsync</c>.
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
        public lro::OperationsSettings EnableAdvancedSiteSearchOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SiteSearchEngineServiceClient.DisableAdvancedSiteSearch</c> and
        /// <c>SiteSearchEngineServiceClient.DisableAdvancedSiteSearchAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DisableAdvancedSiteSearchSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>SiteSearchEngineServiceClient.DisableAdvancedSiteSearch</c>
        /// and <c>SiteSearchEngineServiceClient.DisableAdvancedSiteSearchAsync</c>.
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
        public lro::OperationsSettings DisableAdvancedSiteSearchOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SiteSearchEngineServiceClient.RecrawlUris</c> and <c>SiteSearchEngineServiceClient.RecrawlUrisAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RecrawlUrisSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>SiteSearchEngineServiceClient.RecrawlUris</c> and
        /// <c>SiteSearchEngineServiceClient.RecrawlUrisAsync</c>.
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
        public lro::OperationsSettings RecrawlUrisOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SiteSearchEngineServiceClient.BatchVerifyTargetSites</c> and
        /// <c>SiteSearchEngineServiceClient.BatchVerifyTargetSitesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchVerifyTargetSitesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>SiteSearchEngineServiceClient.BatchVerifyTargetSites</c> and
        /// <c>SiteSearchEngineServiceClient.BatchVerifyTargetSitesAsync</c>.
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
        public lro::OperationsSettings BatchVerifyTargetSitesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SiteSearchEngineServiceClient.FetchDomainVerificationStatus</c> and
        /// <c>SiteSearchEngineServiceClient.FetchDomainVerificationStatusAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings FetchDomainVerificationStatusSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SiteSearchEngineServiceSettings"/> object.</returns>
        public SiteSearchEngineServiceSettings Clone() => new SiteSearchEngineServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SiteSearchEngineServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class SiteSearchEngineServiceClientBuilder : gaxgrpc::ClientBuilderBase<SiteSearchEngineServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SiteSearchEngineServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SiteSearchEngineServiceClientBuilder() : base(SiteSearchEngineServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref SiteSearchEngineServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SiteSearchEngineServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SiteSearchEngineServiceClient Build()
        {
            SiteSearchEngineServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SiteSearchEngineServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SiteSearchEngineServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SiteSearchEngineServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SiteSearchEngineServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<SiteSearchEngineServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SiteSearchEngineServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SiteSearchEngineServiceClient.ChannelPool;
    }

    /// <summary>SiteSearchEngineService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing site search related resources.
    /// </remarks>
    public abstract partial class SiteSearchEngineServiceClient
    {
        /// <summary>
        /// The default endpoint for the SiteSearchEngineService service, which is a host of
        /// "discoveryengine.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "discoveryengine.googleapis.com:443";

        /// <summary>The default SiteSearchEngineService scopes.</summary>
        /// <remarks>
        /// The default SiteSearchEngineService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(SiteSearchEngineService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="SiteSearchEngineServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="SiteSearchEngineServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SiteSearchEngineServiceClient"/>.</returns>
        public static stt::Task<SiteSearchEngineServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SiteSearchEngineServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SiteSearchEngineServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="SiteSearchEngineServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SiteSearchEngineServiceClient"/>.</returns>
        public static SiteSearchEngineServiceClient Create() => new SiteSearchEngineServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SiteSearchEngineServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SiteSearchEngineServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="SiteSearchEngineServiceClient"/>.</returns>
        internal static SiteSearchEngineServiceClient Create(grpccore::CallInvoker callInvoker, SiteSearchEngineServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SiteSearchEngineService.SiteSearchEngineServiceClient grpcClient = new SiteSearchEngineService.SiteSearchEngineServiceClient(callInvoker);
            return new SiteSearchEngineServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC SiteSearchEngineService client</summary>
        public virtual SiteSearchEngineService.SiteSearchEngineServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the
        /// [SiteSearchEngine][google.cloud.discoveryengine.v1beta.SiteSearchEngine].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SiteSearchEngine GetSiteSearchEngine(GetSiteSearchEngineRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the
        /// [SiteSearchEngine][google.cloud.discoveryengine.v1beta.SiteSearchEngine].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SiteSearchEngine> GetSiteSearchEngineAsync(GetSiteSearchEngineRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the
        /// [SiteSearchEngine][google.cloud.discoveryengine.v1beta.SiteSearchEngine].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SiteSearchEngine> GetSiteSearchEngineAsync(GetSiteSearchEngineRequest request, st::CancellationToken cancellationToken) =>
            GetSiteSearchEngineAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the
        /// [SiteSearchEngine][google.cloud.discoveryengine.v1beta.SiteSearchEngine].
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of
        /// [SiteSearchEngine][google.cloud.discoveryengine.v1beta.SiteSearchEngine],
        /// such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine`.
        /// 
        /// If the caller does not have permission to access the [SiteSearchEngine],
        /// regardless of whether or not it exists, a PERMISSION_DENIED error is
        /// returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SiteSearchEngine GetSiteSearchEngine(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSiteSearchEngine(new GetSiteSearchEngineRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the
        /// [SiteSearchEngine][google.cloud.discoveryengine.v1beta.SiteSearchEngine].
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of
        /// [SiteSearchEngine][google.cloud.discoveryengine.v1beta.SiteSearchEngine],
        /// such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine`.
        /// 
        /// If the caller does not have permission to access the [SiteSearchEngine],
        /// regardless of whether or not it exists, a PERMISSION_DENIED error is
        /// returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SiteSearchEngine> GetSiteSearchEngineAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSiteSearchEngineAsync(new GetSiteSearchEngineRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the
        /// [SiteSearchEngine][google.cloud.discoveryengine.v1beta.SiteSearchEngine].
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of
        /// [SiteSearchEngine][google.cloud.discoveryengine.v1beta.SiteSearchEngine],
        /// such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine`.
        /// 
        /// If the caller does not have permission to access the [SiteSearchEngine],
        /// regardless of whether or not it exists, a PERMISSION_DENIED error is
        /// returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SiteSearchEngine> GetSiteSearchEngineAsync(string name, st::CancellationToken cancellationToken) =>
            GetSiteSearchEngineAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the
        /// [SiteSearchEngine][google.cloud.discoveryengine.v1beta.SiteSearchEngine].
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of
        /// [SiteSearchEngine][google.cloud.discoveryengine.v1beta.SiteSearchEngine],
        /// such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine`.
        /// 
        /// If the caller does not have permission to access the [SiteSearchEngine],
        /// regardless of whether or not it exists, a PERMISSION_DENIED error is
        /// returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SiteSearchEngine GetSiteSearchEngine(SiteSearchEngineName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSiteSearchEngine(new GetSiteSearchEngineRequest
            {
                SiteSearchEngineName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the
        /// [SiteSearchEngine][google.cloud.discoveryengine.v1beta.SiteSearchEngine].
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of
        /// [SiteSearchEngine][google.cloud.discoveryengine.v1beta.SiteSearchEngine],
        /// such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine`.
        /// 
        /// If the caller does not have permission to access the [SiteSearchEngine],
        /// regardless of whether or not it exists, a PERMISSION_DENIED error is
        /// returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SiteSearchEngine> GetSiteSearchEngineAsync(SiteSearchEngineName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSiteSearchEngineAsync(new GetSiteSearchEngineRequest
            {
                SiteSearchEngineName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the
        /// [SiteSearchEngine][google.cloud.discoveryengine.v1beta.SiteSearchEngine].
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of
        /// [SiteSearchEngine][google.cloud.discoveryengine.v1beta.SiteSearchEngine],
        /// such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine`.
        /// 
        /// If the caller does not have permission to access the [SiteSearchEngine],
        /// regardless of whether or not it exists, a PERMISSION_DENIED error is
        /// returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SiteSearchEngine> GetSiteSearchEngineAsync(SiteSearchEngineName name, st::CancellationToken cancellationToken) =>
            GetSiteSearchEngineAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TargetSite, CreateTargetSiteMetadata> CreateTargetSite(CreateTargetSiteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TargetSite, CreateTargetSiteMetadata>> CreateTargetSiteAsync(CreateTargetSiteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TargetSite, CreateTargetSiteMetadata>> CreateTargetSiteAsync(CreateTargetSiteRequest request, st::CancellationToken cancellationToken) =>
            CreateTargetSiteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateTargetSite</c>.</summary>
        public virtual lro::OperationsClient CreateTargetSiteOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateTargetSite</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<TargetSite, CreateTargetSiteMetadata> PollOnceCreateTargetSite(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<TargetSite, CreateTargetSiteMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateTargetSiteOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateTargetSite</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<TargetSite, CreateTargetSiteMetadata>> PollOnceCreateTargetSiteAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<TargetSite, CreateTargetSiteMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateTargetSiteOperationsClient, callSettings);

        /// <summary>
        /// Creates a [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite].
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name of
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite], such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine`.
        /// </param>
        /// <param name="targetSite">
        /// Required. The [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite]
        /// to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TargetSite, CreateTargetSiteMetadata> CreateTargetSite(string parent, TargetSite targetSite, gaxgrpc::CallSettings callSettings = null) =>
            CreateTargetSite(new CreateTargetSiteRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TargetSite = gax::GaxPreconditions.CheckNotNull(targetSite, nameof(targetSite)),
            }, callSettings);

        /// <summary>
        /// Creates a [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite].
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name of
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite], such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine`.
        /// </param>
        /// <param name="targetSite">
        /// Required. The [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite]
        /// to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TargetSite, CreateTargetSiteMetadata>> CreateTargetSiteAsync(string parent, TargetSite targetSite, gaxgrpc::CallSettings callSettings = null) =>
            CreateTargetSiteAsync(new CreateTargetSiteRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TargetSite = gax::GaxPreconditions.CheckNotNull(targetSite, nameof(targetSite)),
            }, callSettings);

        /// <summary>
        /// Creates a [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite].
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name of
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite], such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine`.
        /// </param>
        /// <param name="targetSite">
        /// Required. The [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite]
        /// to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TargetSite, CreateTargetSiteMetadata>> CreateTargetSiteAsync(string parent, TargetSite targetSite, st::CancellationToken cancellationToken) =>
            CreateTargetSiteAsync(parent, targetSite, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite].
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name of
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite], such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine`.
        /// </param>
        /// <param name="targetSite">
        /// Required. The [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite]
        /// to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TargetSite, CreateTargetSiteMetadata> CreateTargetSite(SiteSearchEngineName parent, TargetSite targetSite, gaxgrpc::CallSettings callSettings = null) =>
            CreateTargetSite(new CreateTargetSiteRequest
            {
                ParentAsSiteSearchEngineName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TargetSite = gax::GaxPreconditions.CheckNotNull(targetSite, nameof(targetSite)),
            }, callSettings);

        /// <summary>
        /// Creates a [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite].
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name of
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite], such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine`.
        /// </param>
        /// <param name="targetSite">
        /// Required. The [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite]
        /// to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TargetSite, CreateTargetSiteMetadata>> CreateTargetSiteAsync(SiteSearchEngineName parent, TargetSite targetSite, gaxgrpc::CallSettings callSettings = null) =>
            CreateTargetSiteAsync(new CreateTargetSiteRequest
            {
                ParentAsSiteSearchEngineName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TargetSite = gax::GaxPreconditions.CheckNotNull(targetSite, nameof(targetSite)),
            }, callSettings);

        /// <summary>
        /// Creates a [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite].
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name of
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite], such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine`.
        /// </param>
        /// <param name="targetSite">
        /// Required. The [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite]
        /// to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TargetSite, CreateTargetSiteMetadata>> CreateTargetSiteAsync(SiteSearchEngineName parent, TargetSite targetSite, st::CancellationToken cancellationToken) =>
            CreateTargetSiteAsync(parent, targetSite, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite] in a
        /// batch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchCreateTargetSitesResponse, BatchCreateTargetSiteMetadata> BatchCreateTargetSites(BatchCreateTargetSitesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite] in a
        /// batch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchCreateTargetSitesResponse, BatchCreateTargetSiteMetadata>> BatchCreateTargetSitesAsync(BatchCreateTargetSitesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite] in a
        /// batch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchCreateTargetSitesResponse, BatchCreateTargetSiteMetadata>> BatchCreateTargetSitesAsync(BatchCreateTargetSitesRequest request, st::CancellationToken cancellationToken) =>
            BatchCreateTargetSitesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>BatchCreateTargetSites</c>.</summary>
        public virtual lro::OperationsClient BatchCreateTargetSitesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BatchCreateTargetSites</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<BatchCreateTargetSitesResponse, BatchCreateTargetSiteMetadata> PollOnceBatchCreateTargetSites(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchCreateTargetSitesResponse, BatchCreateTargetSiteMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchCreateTargetSitesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BatchCreateTargetSites</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<BatchCreateTargetSitesResponse, BatchCreateTargetSiteMetadata>> PollOnceBatchCreateTargetSitesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchCreateTargetSitesResponse, BatchCreateTargetSiteMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchCreateTargetSitesOperationsClient, callSettings);

        /// <summary>
        /// Gets a [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TargetSite GetTargetSite(GetTargetSiteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetSite> GetTargetSiteAsync(GetTargetSiteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetSite> GetTargetSiteAsync(GetTargetSiteRequest request, st::CancellationToken cancellationToken) =>
            GetTargetSiteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite], such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine/targetSites/{target_site}`.
        /// 
        /// If the caller does not have permission to access the
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the requested
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite] does not
        /// exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TargetSite GetTargetSite(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTargetSite(new GetTargetSiteRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite], such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine/targetSites/{target_site}`.
        /// 
        /// If the caller does not have permission to access the
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the requested
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite] does not
        /// exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetSite> GetTargetSiteAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTargetSiteAsync(new GetTargetSiteRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite], such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine/targetSites/{target_site}`.
        /// 
        /// If the caller does not have permission to access the
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the requested
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite] does not
        /// exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetSite> GetTargetSiteAsync(string name, st::CancellationToken cancellationToken) =>
            GetTargetSiteAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite], such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine/targetSites/{target_site}`.
        /// 
        /// If the caller does not have permission to access the
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the requested
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite] does not
        /// exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TargetSite GetTargetSite(TargetSiteName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTargetSite(new GetTargetSiteRequest
            {
                TargetSiteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite], such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine/targetSites/{target_site}`.
        /// 
        /// If the caller does not have permission to access the
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the requested
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite] does not
        /// exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetSite> GetTargetSiteAsync(TargetSiteName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTargetSiteAsync(new GetTargetSiteRequest
            {
                TargetSiteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite], such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine/targetSites/{target_site}`.
        /// 
        /// If the caller does not have permission to access the
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the requested
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite] does not
        /// exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetSite> GetTargetSiteAsync(TargetSiteName name, st::CancellationToken cancellationToken) =>
            GetTargetSiteAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TargetSite, UpdateTargetSiteMetadata> UpdateTargetSite(UpdateTargetSiteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TargetSite, UpdateTargetSiteMetadata>> UpdateTargetSiteAsync(UpdateTargetSiteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TargetSite, UpdateTargetSiteMetadata>> UpdateTargetSiteAsync(UpdateTargetSiteRequest request, st::CancellationToken cancellationToken) =>
            UpdateTargetSiteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateTargetSite</c>.</summary>
        public virtual lro::OperationsClient UpdateTargetSiteOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateTargetSite</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<TargetSite, UpdateTargetSiteMetadata> PollOnceUpdateTargetSite(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<TargetSite, UpdateTargetSiteMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateTargetSiteOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateTargetSite</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<TargetSite, UpdateTargetSiteMetadata>> PollOnceUpdateTargetSiteAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<TargetSite, UpdateTargetSiteMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateTargetSiteOperationsClient, callSettings);

        /// <summary>
        /// Updates a [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite].
        /// </summary>
        /// <param name="targetSite">
        /// Required. The target site to update.
        /// If the caller does not have permission to update the
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite] to
        /// update does not exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TargetSite, UpdateTargetSiteMetadata> UpdateTargetSite(TargetSite targetSite, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTargetSite(new UpdateTargetSiteRequest
            {
                TargetSite = gax::GaxPreconditions.CheckNotNull(targetSite, nameof(targetSite)),
            }, callSettings);

        /// <summary>
        /// Updates a [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite].
        /// </summary>
        /// <param name="targetSite">
        /// Required. The target site to update.
        /// If the caller does not have permission to update the
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite] to
        /// update does not exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TargetSite, UpdateTargetSiteMetadata>> UpdateTargetSiteAsync(TargetSite targetSite, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTargetSiteAsync(new UpdateTargetSiteRequest
            {
                TargetSite = gax::GaxPreconditions.CheckNotNull(targetSite, nameof(targetSite)),
            }, callSettings);

        /// <summary>
        /// Updates a [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite].
        /// </summary>
        /// <param name="targetSite">
        /// Required. The target site to update.
        /// If the caller does not have permission to update the
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite] to
        /// update does not exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TargetSite, UpdateTargetSiteMetadata>> UpdateTargetSiteAsync(TargetSite targetSite, st::CancellationToken cancellationToken) =>
            UpdateTargetSiteAsync(targetSite, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteTargetSiteMetadata> DeleteTargetSite(DeleteTargetSiteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteTargetSiteMetadata>> DeleteTargetSiteAsync(DeleteTargetSiteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteTargetSiteMetadata>> DeleteTargetSiteAsync(DeleteTargetSiteRequest request, st::CancellationToken cancellationToken) =>
            DeleteTargetSiteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteTargetSite</c>.</summary>
        public virtual lro::OperationsClient DeleteTargetSiteOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteTargetSite</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteTargetSiteMetadata> PollOnceDeleteTargetSite(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteTargetSiteMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteTargetSiteOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteTargetSite</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteTargetSiteMetadata>> PollOnceDeleteTargetSiteAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteTargetSiteMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteTargetSiteOperationsClient, callSettings);

        /// <summary>
        /// Deletes a [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite], such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine/targetSites/{target_site}`.
        /// 
        /// If the caller does not have permission to access the
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the requested
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite] does not
        /// exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteTargetSiteMetadata> DeleteTargetSite(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTargetSite(new DeleteTargetSiteRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite], such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine/targetSites/{target_site}`.
        /// 
        /// If the caller does not have permission to access the
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the requested
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite] does not
        /// exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteTargetSiteMetadata>> DeleteTargetSiteAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTargetSiteAsync(new DeleteTargetSiteRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite], such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine/targetSites/{target_site}`.
        /// 
        /// If the caller does not have permission to access the
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the requested
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite] does not
        /// exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteTargetSiteMetadata>> DeleteTargetSiteAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteTargetSiteAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite], such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine/targetSites/{target_site}`.
        /// 
        /// If the caller does not have permission to access the
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the requested
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite] does not
        /// exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteTargetSiteMetadata> DeleteTargetSite(TargetSiteName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTargetSite(new DeleteTargetSiteRequest
            {
                TargetSiteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite], such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine/targetSites/{target_site}`.
        /// 
        /// If the caller does not have permission to access the
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the requested
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite] does not
        /// exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteTargetSiteMetadata>> DeleteTargetSiteAsync(TargetSiteName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTargetSiteAsync(new DeleteTargetSiteRequest
            {
                TargetSiteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite], such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine/targetSites/{target_site}`.
        /// 
        /// If the caller does not have permission to access the
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the requested
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite] does not
        /// exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteTargetSiteMetadata>> DeleteTargetSiteAsync(TargetSiteName name, st::CancellationToken cancellationToken) =>
            DeleteTargetSiteAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a list of
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite]s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TargetSite"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTargetSitesResponse, TargetSite> ListTargetSites(ListTargetSitesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a list of
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite]s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TargetSite"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTargetSitesResponse, TargetSite> ListTargetSitesAsync(ListTargetSitesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a list of
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite]s.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent site search engine resource name, such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine`.
        /// 
        /// If the caller does not have permission to list
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite]s under this
        /// site search engine, regardless of whether or not this branch exists, a
        /// PERMISSION_DENIED error is returned.
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
        /// <returns>A pageable sequence of <see cref="TargetSite"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTargetSitesResponse, TargetSite> ListTargetSites(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTargetSitesRequest request = new ListTargetSitesRequest
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
            return ListTargetSites(request, callSettings);
        }

        /// <summary>
        /// Gets a list of
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite]s.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent site search engine resource name, such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine`.
        /// 
        /// If the caller does not have permission to list
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite]s under this
        /// site search engine, regardless of whether or not this branch exists, a
        /// PERMISSION_DENIED error is returned.
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
        /// <returns>A pageable asynchronous sequence of <see cref="TargetSite"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTargetSitesResponse, TargetSite> ListTargetSitesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTargetSitesRequest request = new ListTargetSitesRequest
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
            return ListTargetSitesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a list of
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite]s.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent site search engine resource name, such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine`.
        /// 
        /// If the caller does not have permission to list
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite]s under this
        /// site search engine, regardless of whether or not this branch exists, a
        /// PERMISSION_DENIED error is returned.
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
        /// <returns>A pageable sequence of <see cref="TargetSite"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTargetSitesResponse, TargetSite> ListTargetSites(SiteSearchEngineName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTargetSitesRequest request = new ListTargetSitesRequest
            {
                ParentAsSiteSearchEngineName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTargetSites(request, callSettings);
        }

        /// <summary>
        /// Gets a list of
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite]s.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent site search engine resource name, such as
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine`.
        /// 
        /// If the caller does not have permission to list
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite]s under this
        /// site search engine, regardless of whether or not this branch exists, a
        /// PERMISSION_DENIED error is returned.
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
        /// <returns>A pageable asynchronous sequence of <see cref="TargetSite"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTargetSitesResponse, TargetSite> ListTargetSitesAsync(SiteSearchEngineName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTargetSitesRequest request = new ListTargetSitesRequest
            {
                ParentAsSiteSearchEngineName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTargetSitesAsync(request, callSettings);
        }

        /// <summary>
        /// Upgrade from basic site search to advanced site search.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<EnableAdvancedSiteSearchResponse, EnableAdvancedSiteSearchMetadata> EnableAdvancedSiteSearch(EnableAdvancedSiteSearchRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Upgrade from basic site search to advanced site search.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EnableAdvancedSiteSearchResponse, EnableAdvancedSiteSearchMetadata>> EnableAdvancedSiteSearchAsync(EnableAdvancedSiteSearchRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Upgrade from basic site search to advanced site search.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EnableAdvancedSiteSearchResponse, EnableAdvancedSiteSearchMetadata>> EnableAdvancedSiteSearchAsync(EnableAdvancedSiteSearchRequest request, st::CancellationToken cancellationToken) =>
            EnableAdvancedSiteSearchAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>EnableAdvancedSiteSearch</c>.</summary>
        public virtual lro::OperationsClient EnableAdvancedSiteSearchOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>EnableAdvancedSiteSearch</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<EnableAdvancedSiteSearchResponse, EnableAdvancedSiteSearchMetadata> PollOnceEnableAdvancedSiteSearch(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<EnableAdvancedSiteSearchResponse, EnableAdvancedSiteSearchMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), EnableAdvancedSiteSearchOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>EnableAdvancedSiteSearch</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<EnableAdvancedSiteSearchResponse, EnableAdvancedSiteSearchMetadata>> PollOnceEnableAdvancedSiteSearchAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<EnableAdvancedSiteSearchResponse, EnableAdvancedSiteSearchMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), EnableAdvancedSiteSearchOperationsClient, callSettings);

        /// <summary>
        /// Downgrade from advanced site search to basic site search.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DisableAdvancedSiteSearchResponse, DisableAdvancedSiteSearchMetadata> DisableAdvancedSiteSearch(DisableAdvancedSiteSearchRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Downgrade from advanced site search to basic site search.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DisableAdvancedSiteSearchResponse, DisableAdvancedSiteSearchMetadata>> DisableAdvancedSiteSearchAsync(DisableAdvancedSiteSearchRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Downgrade from advanced site search to basic site search.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DisableAdvancedSiteSearchResponse, DisableAdvancedSiteSearchMetadata>> DisableAdvancedSiteSearchAsync(DisableAdvancedSiteSearchRequest request, st::CancellationToken cancellationToken) =>
            DisableAdvancedSiteSearchAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DisableAdvancedSiteSearch</c>.</summary>
        public virtual lro::OperationsClient DisableAdvancedSiteSearchOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DisableAdvancedSiteSearch</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DisableAdvancedSiteSearchResponse, DisableAdvancedSiteSearchMetadata> PollOnceDisableAdvancedSiteSearch(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DisableAdvancedSiteSearchResponse, DisableAdvancedSiteSearchMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DisableAdvancedSiteSearchOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DisableAdvancedSiteSearch</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DisableAdvancedSiteSearchResponse, DisableAdvancedSiteSearchMetadata>> PollOnceDisableAdvancedSiteSearchAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DisableAdvancedSiteSearchResponse, DisableAdvancedSiteSearchMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DisableAdvancedSiteSearchOperationsClient, callSettings);

        /// <summary>
        /// Request on-demand recrawl for a list of URIs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RecrawlUrisResponse, RecrawlUrisMetadata> RecrawlUris(RecrawlUrisRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Request on-demand recrawl for a list of URIs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RecrawlUrisResponse, RecrawlUrisMetadata>> RecrawlUrisAsync(RecrawlUrisRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Request on-demand recrawl for a list of URIs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RecrawlUrisResponse, RecrawlUrisMetadata>> RecrawlUrisAsync(RecrawlUrisRequest request, st::CancellationToken cancellationToken) =>
            RecrawlUrisAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RecrawlUris</c>.</summary>
        public virtual lro::OperationsClient RecrawlUrisOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RecrawlUris</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<RecrawlUrisResponse, RecrawlUrisMetadata> PollOnceRecrawlUris(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RecrawlUrisResponse, RecrawlUrisMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RecrawlUrisOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RecrawlUris</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<RecrawlUrisResponse, RecrawlUrisMetadata>> PollOnceRecrawlUrisAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RecrawlUrisResponse, RecrawlUrisMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RecrawlUrisOperationsClient, callSettings);

        /// <summary>
        /// Verify target sites' ownership and validity.
        /// This API sends all the target sites under site search engine for
        /// verification.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchVerifyTargetSitesResponse, BatchVerifyTargetSitesMetadata> BatchVerifyTargetSites(BatchVerifyTargetSitesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Verify target sites' ownership and validity.
        /// This API sends all the target sites under site search engine for
        /// verification.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchVerifyTargetSitesResponse, BatchVerifyTargetSitesMetadata>> BatchVerifyTargetSitesAsync(BatchVerifyTargetSitesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Verify target sites' ownership and validity.
        /// This API sends all the target sites under site search engine for
        /// verification.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchVerifyTargetSitesResponse, BatchVerifyTargetSitesMetadata>> BatchVerifyTargetSitesAsync(BatchVerifyTargetSitesRequest request, st::CancellationToken cancellationToken) =>
            BatchVerifyTargetSitesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>BatchVerifyTargetSites</c>.</summary>
        public virtual lro::OperationsClient BatchVerifyTargetSitesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BatchVerifyTargetSites</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<BatchVerifyTargetSitesResponse, BatchVerifyTargetSitesMetadata> PollOnceBatchVerifyTargetSites(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchVerifyTargetSitesResponse, BatchVerifyTargetSitesMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchVerifyTargetSitesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BatchVerifyTargetSites</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<BatchVerifyTargetSitesResponse, BatchVerifyTargetSitesMetadata>> PollOnceBatchVerifyTargetSitesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchVerifyTargetSitesResponse, BatchVerifyTargetSitesMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchVerifyTargetSitesOperationsClient, callSettings);

        /// <summary>
        /// Returns list of target sites with its domain verification status.
        /// This method can only be called under data store with BASIC_SITE_SEARCH
        /// state at the moment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TargetSite"/> resources.</returns>
        public virtual gax::PagedEnumerable<FetchDomainVerificationStatusResponse, TargetSite> FetchDomainVerificationStatus(FetchDomainVerificationStatusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns list of target sites with its domain verification status.
        /// This method can only be called under data store with BASIC_SITE_SEARCH
        /// state at the moment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TargetSite"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<FetchDomainVerificationStatusResponse, TargetSite> FetchDomainVerificationStatusAsync(FetchDomainVerificationStatusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();
    }

    /// <summary>SiteSearchEngineService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing site search related resources.
    /// </remarks>
    public sealed partial class SiteSearchEngineServiceClientImpl : SiteSearchEngineServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetSiteSearchEngineRequest, SiteSearchEngine> _callGetSiteSearchEngine;

        private readonly gaxgrpc::ApiCall<CreateTargetSiteRequest, lro::Operation> _callCreateTargetSite;

        private readonly gaxgrpc::ApiCall<BatchCreateTargetSitesRequest, lro::Operation> _callBatchCreateTargetSites;

        private readonly gaxgrpc::ApiCall<GetTargetSiteRequest, TargetSite> _callGetTargetSite;

        private readonly gaxgrpc::ApiCall<UpdateTargetSiteRequest, lro::Operation> _callUpdateTargetSite;

        private readonly gaxgrpc::ApiCall<DeleteTargetSiteRequest, lro::Operation> _callDeleteTargetSite;

        private readonly gaxgrpc::ApiCall<ListTargetSitesRequest, ListTargetSitesResponse> _callListTargetSites;

        private readonly gaxgrpc::ApiCall<EnableAdvancedSiteSearchRequest, lro::Operation> _callEnableAdvancedSiteSearch;

        private readonly gaxgrpc::ApiCall<DisableAdvancedSiteSearchRequest, lro::Operation> _callDisableAdvancedSiteSearch;

        private readonly gaxgrpc::ApiCall<RecrawlUrisRequest, lro::Operation> _callRecrawlUris;

        private readonly gaxgrpc::ApiCall<BatchVerifyTargetSitesRequest, lro::Operation> _callBatchVerifyTargetSites;

        private readonly gaxgrpc::ApiCall<FetchDomainVerificationStatusRequest, FetchDomainVerificationStatusResponse> _callFetchDomainVerificationStatus;

        /// <summary>
        /// Constructs a client wrapper for the SiteSearchEngineService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="SiteSearchEngineServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public SiteSearchEngineServiceClientImpl(SiteSearchEngineService.SiteSearchEngineServiceClient grpcClient, SiteSearchEngineServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            SiteSearchEngineServiceSettings effectiveSettings = settings ?? SiteSearchEngineServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateTargetSiteOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateTargetSiteOperationsSettings, logger);
            BatchCreateTargetSitesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.BatchCreateTargetSitesOperationsSettings, logger);
            UpdateTargetSiteOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateTargetSiteOperationsSettings, logger);
            DeleteTargetSiteOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteTargetSiteOperationsSettings, logger);
            EnableAdvancedSiteSearchOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.EnableAdvancedSiteSearchOperationsSettings, logger);
            DisableAdvancedSiteSearchOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DisableAdvancedSiteSearchOperationsSettings, logger);
            RecrawlUrisOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RecrawlUrisOperationsSettings, logger);
            BatchVerifyTargetSitesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.BatchVerifyTargetSitesOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callGetSiteSearchEngine = clientHelper.BuildApiCall<GetSiteSearchEngineRequest, SiteSearchEngine>("GetSiteSearchEngine", grpcClient.GetSiteSearchEngineAsync, grpcClient.GetSiteSearchEngine, effectiveSettings.GetSiteSearchEngineSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSiteSearchEngine);
            Modify_GetSiteSearchEngineApiCall(ref _callGetSiteSearchEngine);
            _callCreateTargetSite = clientHelper.BuildApiCall<CreateTargetSiteRequest, lro::Operation>("CreateTargetSite", grpcClient.CreateTargetSiteAsync, grpcClient.CreateTargetSite, effectiveSettings.CreateTargetSiteSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateTargetSite);
            Modify_CreateTargetSiteApiCall(ref _callCreateTargetSite);
            _callBatchCreateTargetSites = clientHelper.BuildApiCall<BatchCreateTargetSitesRequest, lro::Operation>("BatchCreateTargetSites", grpcClient.BatchCreateTargetSitesAsync, grpcClient.BatchCreateTargetSites, effectiveSettings.BatchCreateTargetSitesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchCreateTargetSites);
            Modify_BatchCreateTargetSitesApiCall(ref _callBatchCreateTargetSites);
            _callGetTargetSite = clientHelper.BuildApiCall<GetTargetSiteRequest, TargetSite>("GetTargetSite", grpcClient.GetTargetSiteAsync, grpcClient.GetTargetSite, effectiveSettings.GetTargetSiteSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTargetSite);
            Modify_GetTargetSiteApiCall(ref _callGetTargetSite);
            _callUpdateTargetSite = clientHelper.BuildApiCall<UpdateTargetSiteRequest, lro::Operation>("UpdateTargetSite", grpcClient.UpdateTargetSiteAsync, grpcClient.UpdateTargetSite, effectiveSettings.UpdateTargetSiteSettings).WithGoogleRequestParam("target_site.name", request => request.TargetSite?.Name);
            Modify_ApiCall(ref _callUpdateTargetSite);
            Modify_UpdateTargetSiteApiCall(ref _callUpdateTargetSite);
            _callDeleteTargetSite = clientHelper.BuildApiCall<DeleteTargetSiteRequest, lro::Operation>("DeleteTargetSite", grpcClient.DeleteTargetSiteAsync, grpcClient.DeleteTargetSite, effectiveSettings.DeleteTargetSiteSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteTargetSite);
            Modify_DeleteTargetSiteApiCall(ref _callDeleteTargetSite);
            _callListTargetSites = clientHelper.BuildApiCall<ListTargetSitesRequest, ListTargetSitesResponse>("ListTargetSites", grpcClient.ListTargetSitesAsync, grpcClient.ListTargetSites, effectiveSettings.ListTargetSitesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTargetSites);
            Modify_ListTargetSitesApiCall(ref _callListTargetSites);
            _callEnableAdvancedSiteSearch = clientHelper.BuildApiCall<EnableAdvancedSiteSearchRequest, lro::Operation>("EnableAdvancedSiteSearch", grpcClient.EnableAdvancedSiteSearchAsync, grpcClient.EnableAdvancedSiteSearch, effectiveSettings.EnableAdvancedSiteSearchSettings).WithGoogleRequestParam("site_search_engine", request => request.SiteSearchEngine);
            Modify_ApiCall(ref _callEnableAdvancedSiteSearch);
            Modify_EnableAdvancedSiteSearchApiCall(ref _callEnableAdvancedSiteSearch);
            _callDisableAdvancedSiteSearch = clientHelper.BuildApiCall<DisableAdvancedSiteSearchRequest, lro::Operation>("DisableAdvancedSiteSearch", grpcClient.DisableAdvancedSiteSearchAsync, grpcClient.DisableAdvancedSiteSearch, effectiveSettings.DisableAdvancedSiteSearchSettings).WithGoogleRequestParam("site_search_engine", request => request.SiteSearchEngine);
            Modify_ApiCall(ref _callDisableAdvancedSiteSearch);
            Modify_DisableAdvancedSiteSearchApiCall(ref _callDisableAdvancedSiteSearch);
            _callRecrawlUris = clientHelper.BuildApiCall<RecrawlUrisRequest, lro::Operation>("RecrawlUris", grpcClient.RecrawlUrisAsync, grpcClient.RecrawlUris, effectiveSettings.RecrawlUrisSettings).WithGoogleRequestParam("site_search_engine", request => request.SiteSearchEngine);
            Modify_ApiCall(ref _callRecrawlUris);
            Modify_RecrawlUrisApiCall(ref _callRecrawlUris);
            _callBatchVerifyTargetSites = clientHelper.BuildApiCall<BatchVerifyTargetSitesRequest, lro::Operation>("BatchVerifyTargetSites", grpcClient.BatchVerifyTargetSitesAsync, grpcClient.BatchVerifyTargetSites, effectiveSettings.BatchVerifyTargetSitesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchVerifyTargetSites);
            Modify_BatchVerifyTargetSitesApiCall(ref _callBatchVerifyTargetSites);
            _callFetchDomainVerificationStatus = clientHelper.BuildApiCall<FetchDomainVerificationStatusRequest, FetchDomainVerificationStatusResponse>("FetchDomainVerificationStatus", grpcClient.FetchDomainVerificationStatusAsync, grpcClient.FetchDomainVerificationStatus, effectiveSettings.FetchDomainVerificationStatusSettings).WithGoogleRequestParam("site_search_engine", request => request.SiteSearchEngine);
            Modify_ApiCall(ref _callFetchDomainVerificationStatus);
            Modify_FetchDomainVerificationStatusApiCall(ref _callFetchDomainVerificationStatus);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetSiteSearchEngineApiCall(ref gaxgrpc::ApiCall<GetSiteSearchEngineRequest, SiteSearchEngine> call);

        partial void Modify_CreateTargetSiteApiCall(ref gaxgrpc::ApiCall<CreateTargetSiteRequest, lro::Operation> call);

        partial void Modify_BatchCreateTargetSitesApiCall(ref gaxgrpc::ApiCall<BatchCreateTargetSitesRequest, lro::Operation> call);

        partial void Modify_GetTargetSiteApiCall(ref gaxgrpc::ApiCall<GetTargetSiteRequest, TargetSite> call);

        partial void Modify_UpdateTargetSiteApiCall(ref gaxgrpc::ApiCall<UpdateTargetSiteRequest, lro::Operation> call);

        partial void Modify_DeleteTargetSiteApiCall(ref gaxgrpc::ApiCall<DeleteTargetSiteRequest, lro::Operation> call);

        partial void Modify_ListTargetSitesApiCall(ref gaxgrpc::ApiCall<ListTargetSitesRequest, ListTargetSitesResponse> call);

        partial void Modify_EnableAdvancedSiteSearchApiCall(ref gaxgrpc::ApiCall<EnableAdvancedSiteSearchRequest, lro::Operation> call);

        partial void Modify_DisableAdvancedSiteSearchApiCall(ref gaxgrpc::ApiCall<DisableAdvancedSiteSearchRequest, lro::Operation> call);

        partial void Modify_RecrawlUrisApiCall(ref gaxgrpc::ApiCall<RecrawlUrisRequest, lro::Operation> call);

        partial void Modify_BatchVerifyTargetSitesApiCall(ref gaxgrpc::ApiCall<BatchVerifyTargetSitesRequest, lro::Operation> call);

        partial void Modify_FetchDomainVerificationStatusApiCall(ref gaxgrpc::ApiCall<FetchDomainVerificationStatusRequest, FetchDomainVerificationStatusResponse> call);

        partial void OnConstruction(SiteSearchEngineService.SiteSearchEngineServiceClient grpcClient, SiteSearchEngineServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SiteSearchEngineService client</summary>
        public override SiteSearchEngineService.SiteSearchEngineServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_GetSiteSearchEngineRequest(ref GetSiteSearchEngineRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateTargetSiteRequest(ref CreateTargetSiteRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchCreateTargetSitesRequest(ref BatchCreateTargetSitesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTargetSiteRequest(ref GetTargetSiteRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateTargetSiteRequest(ref UpdateTargetSiteRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteTargetSiteRequest(ref DeleteTargetSiteRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTargetSitesRequest(ref ListTargetSitesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_EnableAdvancedSiteSearchRequest(ref EnableAdvancedSiteSearchRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DisableAdvancedSiteSearchRequest(ref DisableAdvancedSiteSearchRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RecrawlUrisRequest(ref RecrawlUrisRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchVerifyTargetSitesRequest(ref BatchVerifyTargetSitesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FetchDomainVerificationStatusRequest(ref FetchDomainVerificationStatusRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets the
        /// [SiteSearchEngine][google.cloud.discoveryengine.v1beta.SiteSearchEngine].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SiteSearchEngine GetSiteSearchEngine(GetSiteSearchEngineRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSiteSearchEngineRequest(ref request, ref callSettings);
            return _callGetSiteSearchEngine.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the
        /// [SiteSearchEngine][google.cloud.discoveryengine.v1beta.SiteSearchEngine].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SiteSearchEngine> GetSiteSearchEngineAsync(GetSiteSearchEngineRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSiteSearchEngineRequest(ref request, ref callSettings);
            return _callGetSiteSearchEngine.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateTargetSite</c>.</summary>
        public override lro::OperationsClient CreateTargetSiteOperationsClient { get; }

        /// <summary>
        /// Creates a [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<TargetSite, CreateTargetSiteMetadata> CreateTargetSite(CreateTargetSiteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTargetSiteRequest(ref request, ref callSettings);
            return new lro::Operation<TargetSite, CreateTargetSiteMetadata>(_callCreateTargetSite.Sync(request, callSettings), CreateTargetSiteOperationsClient);
        }

        /// <summary>
        /// Creates a [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<TargetSite, CreateTargetSiteMetadata>> CreateTargetSiteAsync(CreateTargetSiteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTargetSiteRequest(ref request, ref callSettings);
            return new lro::Operation<TargetSite, CreateTargetSiteMetadata>(await _callCreateTargetSite.Async(request, callSettings).ConfigureAwait(false), CreateTargetSiteOperationsClient);
        }

        /// <summary>The long-running operations client for <c>BatchCreateTargetSites</c>.</summary>
        public override lro::OperationsClient BatchCreateTargetSitesOperationsClient { get; }

        /// <summary>
        /// Creates [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite] in a
        /// batch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<BatchCreateTargetSitesResponse, BatchCreateTargetSiteMetadata> BatchCreateTargetSites(BatchCreateTargetSitesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateTargetSitesRequest(ref request, ref callSettings);
            return new lro::Operation<BatchCreateTargetSitesResponse, BatchCreateTargetSiteMetadata>(_callBatchCreateTargetSites.Sync(request, callSettings), BatchCreateTargetSitesOperationsClient);
        }

        /// <summary>
        /// Creates [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite] in a
        /// batch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<BatchCreateTargetSitesResponse, BatchCreateTargetSiteMetadata>> BatchCreateTargetSitesAsync(BatchCreateTargetSitesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateTargetSitesRequest(ref request, ref callSettings);
            return new lro::Operation<BatchCreateTargetSitesResponse, BatchCreateTargetSiteMetadata>(await _callBatchCreateTargetSites.Async(request, callSettings).ConfigureAwait(false), BatchCreateTargetSitesOperationsClient);
        }

        /// <summary>
        /// Gets a [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TargetSite GetTargetSite(GetTargetSiteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTargetSiteRequest(ref request, ref callSettings);
            return _callGetTargetSite.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TargetSite> GetTargetSiteAsync(GetTargetSiteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTargetSiteRequest(ref request, ref callSettings);
            return _callGetTargetSite.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateTargetSite</c>.</summary>
        public override lro::OperationsClient UpdateTargetSiteOperationsClient { get; }

        /// <summary>
        /// Updates a [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<TargetSite, UpdateTargetSiteMetadata> UpdateTargetSite(UpdateTargetSiteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTargetSiteRequest(ref request, ref callSettings);
            return new lro::Operation<TargetSite, UpdateTargetSiteMetadata>(_callUpdateTargetSite.Sync(request, callSettings), UpdateTargetSiteOperationsClient);
        }

        /// <summary>
        /// Updates a [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<TargetSite, UpdateTargetSiteMetadata>> UpdateTargetSiteAsync(UpdateTargetSiteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTargetSiteRequest(ref request, ref callSettings);
            return new lro::Operation<TargetSite, UpdateTargetSiteMetadata>(await _callUpdateTargetSite.Async(request, callSettings).ConfigureAwait(false), UpdateTargetSiteOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteTargetSite</c>.</summary>
        public override lro::OperationsClient DeleteTargetSiteOperationsClient { get; }

        /// <summary>
        /// Deletes a [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteTargetSiteMetadata> DeleteTargetSite(DeleteTargetSiteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTargetSiteRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteTargetSiteMetadata>(_callDeleteTargetSite.Sync(request, callSettings), DeleteTargetSiteOperationsClient);
        }

        /// <summary>
        /// Deletes a [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteTargetSiteMetadata>> DeleteTargetSiteAsync(DeleteTargetSiteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTargetSiteRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteTargetSiteMetadata>(await _callDeleteTargetSite.Async(request, callSettings).ConfigureAwait(false), DeleteTargetSiteOperationsClient);
        }

        /// <summary>
        /// Gets a list of
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite]s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TargetSite"/> resources.</returns>
        public override gax::PagedEnumerable<ListTargetSitesResponse, TargetSite> ListTargetSites(ListTargetSitesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTargetSitesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTargetSitesRequest, ListTargetSitesResponse, TargetSite>(_callListTargetSites, request, callSettings);
        }

        /// <summary>
        /// Gets a list of
        /// [TargetSite][google.cloud.discoveryengine.v1beta.TargetSite]s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TargetSite"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTargetSitesResponse, TargetSite> ListTargetSitesAsync(ListTargetSitesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTargetSitesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTargetSitesRequest, ListTargetSitesResponse, TargetSite>(_callListTargetSites, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>EnableAdvancedSiteSearch</c>.</summary>
        public override lro::OperationsClient EnableAdvancedSiteSearchOperationsClient { get; }

        /// <summary>
        /// Upgrade from basic site search to advanced site search.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<EnableAdvancedSiteSearchResponse, EnableAdvancedSiteSearchMetadata> EnableAdvancedSiteSearch(EnableAdvancedSiteSearchRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EnableAdvancedSiteSearchRequest(ref request, ref callSettings);
            return new lro::Operation<EnableAdvancedSiteSearchResponse, EnableAdvancedSiteSearchMetadata>(_callEnableAdvancedSiteSearch.Sync(request, callSettings), EnableAdvancedSiteSearchOperationsClient);
        }

        /// <summary>
        /// Upgrade from basic site search to advanced site search.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<EnableAdvancedSiteSearchResponse, EnableAdvancedSiteSearchMetadata>> EnableAdvancedSiteSearchAsync(EnableAdvancedSiteSearchRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EnableAdvancedSiteSearchRequest(ref request, ref callSettings);
            return new lro::Operation<EnableAdvancedSiteSearchResponse, EnableAdvancedSiteSearchMetadata>(await _callEnableAdvancedSiteSearch.Async(request, callSettings).ConfigureAwait(false), EnableAdvancedSiteSearchOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DisableAdvancedSiteSearch</c>.</summary>
        public override lro::OperationsClient DisableAdvancedSiteSearchOperationsClient { get; }

        /// <summary>
        /// Downgrade from advanced site search to basic site search.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DisableAdvancedSiteSearchResponse, DisableAdvancedSiteSearchMetadata> DisableAdvancedSiteSearch(DisableAdvancedSiteSearchRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DisableAdvancedSiteSearchRequest(ref request, ref callSettings);
            return new lro::Operation<DisableAdvancedSiteSearchResponse, DisableAdvancedSiteSearchMetadata>(_callDisableAdvancedSiteSearch.Sync(request, callSettings), DisableAdvancedSiteSearchOperationsClient);
        }

        /// <summary>
        /// Downgrade from advanced site search to basic site search.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DisableAdvancedSiteSearchResponse, DisableAdvancedSiteSearchMetadata>> DisableAdvancedSiteSearchAsync(DisableAdvancedSiteSearchRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DisableAdvancedSiteSearchRequest(ref request, ref callSettings);
            return new lro::Operation<DisableAdvancedSiteSearchResponse, DisableAdvancedSiteSearchMetadata>(await _callDisableAdvancedSiteSearch.Async(request, callSettings).ConfigureAwait(false), DisableAdvancedSiteSearchOperationsClient);
        }

        /// <summary>The long-running operations client for <c>RecrawlUris</c>.</summary>
        public override lro::OperationsClient RecrawlUrisOperationsClient { get; }

        /// <summary>
        /// Request on-demand recrawl for a list of URIs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<RecrawlUrisResponse, RecrawlUrisMetadata> RecrawlUris(RecrawlUrisRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RecrawlUrisRequest(ref request, ref callSettings);
            return new lro::Operation<RecrawlUrisResponse, RecrawlUrisMetadata>(_callRecrawlUris.Sync(request, callSettings), RecrawlUrisOperationsClient);
        }

        /// <summary>
        /// Request on-demand recrawl for a list of URIs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<RecrawlUrisResponse, RecrawlUrisMetadata>> RecrawlUrisAsync(RecrawlUrisRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RecrawlUrisRequest(ref request, ref callSettings);
            return new lro::Operation<RecrawlUrisResponse, RecrawlUrisMetadata>(await _callRecrawlUris.Async(request, callSettings).ConfigureAwait(false), RecrawlUrisOperationsClient);
        }

        /// <summary>The long-running operations client for <c>BatchVerifyTargetSites</c>.</summary>
        public override lro::OperationsClient BatchVerifyTargetSitesOperationsClient { get; }

        /// <summary>
        /// Verify target sites' ownership and validity.
        /// This API sends all the target sites under site search engine for
        /// verification.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<BatchVerifyTargetSitesResponse, BatchVerifyTargetSitesMetadata> BatchVerifyTargetSites(BatchVerifyTargetSitesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchVerifyTargetSitesRequest(ref request, ref callSettings);
            return new lro::Operation<BatchVerifyTargetSitesResponse, BatchVerifyTargetSitesMetadata>(_callBatchVerifyTargetSites.Sync(request, callSettings), BatchVerifyTargetSitesOperationsClient);
        }

        /// <summary>
        /// Verify target sites' ownership and validity.
        /// This API sends all the target sites under site search engine for
        /// verification.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<BatchVerifyTargetSitesResponse, BatchVerifyTargetSitesMetadata>> BatchVerifyTargetSitesAsync(BatchVerifyTargetSitesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchVerifyTargetSitesRequest(ref request, ref callSettings);
            return new lro::Operation<BatchVerifyTargetSitesResponse, BatchVerifyTargetSitesMetadata>(await _callBatchVerifyTargetSites.Async(request, callSettings).ConfigureAwait(false), BatchVerifyTargetSitesOperationsClient);
        }

        /// <summary>
        /// Returns list of target sites with its domain verification status.
        /// This method can only be called under data store with BASIC_SITE_SEARCH
        /// state at the moment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TargetSite"/> resources.</returns>
        public override gax::PagedEnumerable<FetchDomainVerificationStatusResponse, TargetSite> FetchDomainVerificationStatus(FetchDomainVerificationStatusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchDomainVerificationStatusRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<FetchDomainVerificationStatusRequest, FetchDomainVerificationStatusResponse, TargetSite>(_callFetchDomainVerificationStatus, request, callSettings);
        }

        /// <summary>
        /// Returns list of target sites with its domain verification status.
        /// This method can only be called under data store with BASIC_SITE_SEARCH
        /// state at the moment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TargetSite"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<FetchDomainVerificationStatusResponse, TargetSite> FetchDomainVerificationStatusAsync(FetchDomainVerificationStatusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchDomainVerificationStatusRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<FetchDomainVerificationStatusRequest, FetchDomainVerificationStatusResponse, TargetSite>(_callFetchDomainVerificationStatus, request, callSettings);
        }
    }

    public partial class ListTargetSitesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class FetchDomainVerificationStatusRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTargetSitesResponse : gaxgrpc::IPageResponse<TargetSite>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<TargetSite> GetEnumerator() => TargetSites.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class FetchDomainVerificationStatusResponse : gaxgrpc::IPageResponse<TargetSite>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<TargetSite> GetEnumerator() => TargetSites.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class SiteSearchEngineService
    {
        public partial class SiteSearchEngineServiceClient
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

    public static partial class SiteSearchEngineService
    {
        public partial class SiteSearchEngineServiceClient
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
