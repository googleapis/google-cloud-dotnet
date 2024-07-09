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
using gciv = Google.Cloud.Iam.V1;
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

namespace Google.Cloud.AIPlatform.V1
{
    /// <summary>Settings for <see cref="FeatureOnlineStoreAdminServiceClient"/> instances.</summary>
    public sealed partial class FeatureOnlineStoreAdminServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="FeatureOnlineStoreAdminServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="FeatureOnlineStoreAdminServiceSettings"/>.</returns>
        public static FeatureOnlineStoreAdminServiceSettings GetDefault() => new FeatureOnlineStoreAdminServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="FeatureOnlineStoreAdminServiceSettings"/> object with default settings.
        /// </summary>
        public FeatureOnlineStoreAdminServiceSettings()
        {
        }

        private FeatureOnlineStoreAdminServiceSettings(FeatureOnlineStoreAdminServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateFeatureOnlineStoreSettings = existing.CreateFeatureOnlineStoreSettings;
            CreateFeatureOnlineStoreOperationsSettings = existing.CreateFeatureOnlineStoreOperationsSettings.Clone();
            GetFeatureOnlineStoreSettings = existing.GetFeatureOnlineStoreSettings;
            ListFeatureOnlineStoresSettings = existing.ListFeatureOnlineStoresSettings;
            UpdateFeatureOnlineStoreSettings = existing.UpdateFeatureOnlineStoreSettings;
            UpdateFeatureOnlineStoreOperationsSettings = existing.UpdateFeatureOnlineStoreOperationsSettings.Clone();
            DeleteFeatureOnlineStoreSettings = existing.DeleteFeatureOnlineStoreSettings;
            DeleteFeatureOnlineStoreOperationsSettings = existing.DeleteFeatureOnlineStoreOperationsSettings.Clone();
            CreateFeatureViewSettings = existing.CreateFeatureViewSettings;
            CreateFeatureViewOperationsSettings = existing.CreateFeatureViewOperationsSettings.Clone();
            GetFeatureViewSettings = existing.GetFeatureViewSettings;
            ListFeatureViewsSettings = existing.ListFeatureViewsSettings;
            UpdateFeatureViewSettings = existing.UpdateFeatureViewSettings;
            UpdateFeatureViewOperationsSettings = existing.UpdateFeatureViewOperationsSettings.Clone();
            DeleteFeatureViewSettings = existing.DeleteFeatureViewSettings;
            DeleteFeatureViewOperationsSettings = existing.DeleteFeatureViewOperationsSettings.Clone();
            SyncFeatureViewSettings = existing.SyncFeatureViewSettings;
            GetFeatureViewSyncSettings = existing.GetFeatureViewSyncSettings;
            ListFeatureViewSyncsSettings = existing.ListFeatureViewSyncsSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(FeatureOnlineStoreAdminServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeatureOnlineStoreAdminServiceClient.CreateFeatureOnlineStore</c> and
        /// <c>FeatureOnlineStoreAdminServiceClient.CreateFeatureOnlineStoreAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateFeatureOnlineStoreSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to
        /// <c>FeatureOnlineStoreAdminServiceClient.CreateFeatureOnlineStore</c> and
        /// <c>FeatureOnlineStoreAdminServiceClient.CreateFeatureOnlineStoreAsync</c>.
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
        public lro::OperationsSettings CreateFeatureOnlineStoreOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeatureOnlineStoreAdminServiceClient.GetFeatureOnlineStore</c> and
        /// <c>FeatureOnlineStoreAdminServiceClient.GetFeatureOnlineStoreAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetFeatureOnlineStoreSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeatureOnlineStoreAdminServiceClient.ListFeatureOnlineStores</c> and
        /// <c>FeatureOnlineStoreAdminServiceClient.ListFeatureOnlineStoresAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListFeatureOnlineStoresSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeatureOnlineStoreAdminServiceClient.UpdateFeatureOnlineStore</c> and
        /// <c>FeatureOnlineStoreAdminServiceClient.UpdateFeatureOnlineStoreAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateFeatureOnlineStoreSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to
        /// <c>FeatureOnlineStoreAdminServiceClient.UpdateFeatureOnlineStore</c> and
        /// <c>FeatureOnlineStoreAdminServiceClient.UpdateFeatureOnlineStoreAsync</c>.
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
        public lro::OperationsSettings UpdateFeatureOnlineStoreOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeatureOnlineStoreAdminServiceClient.DeleteFeatureOnlineStore</c> and
        /// <c>FeatureOnlineStoreAdminServiceClient.DeleteFeatureOnlineStoreAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteFeatureOnlineStoreSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to
        /// <c>FeatureOnlineStoreAdminServiceClient.DeleteFeatureOnlineStore</c> and
        /// <c>FeatureOnlineStoreAdminServiceClient.DeleteFeatureOnlineStoreAsync</c>.
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
        public lro::OperationsSettings DeleteFeatureOnlineStoreOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeatureOnlineStoreAdminServiceClient.CreateFeatureView</c> and
        /// <c>FeatureOnlineStoreAdminServiceClient.CreateFeatureViewAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateFeatureViewSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>FeatureOnlineStoreAdminServiceClient.CreateFeatureView</c>
        /// and <c>FeatureOnlineStoreAdminServiceClient.CreateFeatureViewAsync</c>.
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
        public lro::OperationsSettings CreateFeatureViewOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeatureOnlineStoreAdminServiceClient.GetFeatureView</c> and
        /// <c>FeatureOnlineStoreAdminServiceClient.GetFeatureViewAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetFeatureViewSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeatureOnlineStoreAdminServiceClient.ListFeatureViews</c> and
        /// <c>FeatureOnlineStoreAdminServiceClient.ListFeatureViewsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListFeatureViewsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeatureOnlineStoreAdminServiceClient.UpdateFeatureView</c> and
        /// <c>FeatureOnlineStoreAdminServiceClient.UpdateFeatureViewAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateFeatureViewSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>FeatureOnlineStoreAdminServiceClient.UpdateFeatureView</c>
        /// and <c>FeatureOnlineStoreAdminServiceClient.UpdateFeatureViewAsync</c>.
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
        public lro::OperationsSettings UpdateFeatureViewOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeatureOnlineStoreAdminServiceClient.DeleteFeatureView</c> and
        /// <c>FeatureOnlineStoreAdminServiceClient.DeleteFeatureViewAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteFeatureViewSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>FeatureOnlineStoreAdminServiceClient.DeleteFeatureView</c>
        /// and <c>FeatureOnlineStoreAdminServiceClient.DeleteFeatureViewAsync</c>.
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
        public lro::OperationsSettings DeleteFeatureViewOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeatureOnlineStoreAdminServiceClient.SyncFeatureView</c> and
        /// <c>FeatureOnlineStoreAdminServiceClient.SyncFeatureViewAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SyncFeatureViewSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeatureOnlineStoreAdminServiceClient.GetFeatureViewSync</c> and
        /// <c>FeatureOnlineStoreAdminServiceClient.GetFeatureViewSyncAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetFeatureViewSyncSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeatureOnlineStoreAdminServiceClient.ListFeatureViewSyncs</c> and
        /// <c>FeatureOnlineStoreAdminServiceClient.ListFeatureViewSyncsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListFeatureViewSyncsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="FeatureOnlineStoreAdminServiceSettings"/> object.</returns>
        public FeatureOnlineStoreAdminServiceSettings Clone() => new FeatureOnlineStoreAdminServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="FeatureOnlineStoreAdminServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class FeatureOnlineStoreAdminServiceClientBuilder : gaxgrpc::ClientBuilderBase<FeatureOnlineStoreAdminServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public FeatureOnlineStoreAdminServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public FeatureOnlineStoreAdminServiceClientBuilder() : base(FeatureOnlineStoreAdminServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref FeatureOnlineStoreAdminServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<FeatureOnlineStoreAdminServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override FeatureOnlineStoreAdminServiceClient Build()
        {
            FeatureOnlineStoreAdminServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<FeatureOnlineStoreAdminServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<FeatureOnlineStoreAdminServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private FeatureOnlineStoreAdminServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return FeatureOnlineStoreAdminServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<FeatureOnlineStoreAdminServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return FeatureOnlineStoreAdminServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => FeatureOnlineStoreAdminServiceClient.ChannelPool;
    }

    /// <summary>FeatureOnlineStoreAdminService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The service that handles CRUD and List for resources for
    /// FeatureOnlineStore.
    /// </remarks>
    public abstract partial class FeatureOnlineStoreAdminServiceClient
    {
        /// <summary>
        /// The default endpoint for the FeatureOnlineStoreAdminService service, which is a host of
        /// "aiplatform.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "aiplatform.googleapis.com:443";

        /// <summary>The default FeatureOnlineStoreAdminService scopes.</summary>
        /// <remarks>
        /// The default FeatureOnlineStoreAdminService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(FeatureOnlineStoreAdminService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="FeatureOnlineStoreAdminServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="FeatureOnlineStoreAdminServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="FeatureOnlineStoreAdminServiceClient"/>.</returns>
        public static stt::Task<FeatureOnlineStoreAdminServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new FeatureOnlineStoreAdminServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="FeatureOnlineStoreAdminServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="FeatureOnlineStoreAdminServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="FeatureOnlineStoreAdminServiceClient"/>.</returns>
        public static FeatureOnlineStoreAdminServiceClient Create() =>
            new FeatureOnlineStoreAdminServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="FeatureOnlineStoreAdminServiceClient"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="FeatureOnlineStoreAdminServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="FeatureOnlineStoreAdminServiceClient"/>.</returns>
        internal static FeatureOnlineStoreAdminServiceClient Create(grpccore::CallInvoker callInvoker, FeatureOnlineStoreAdminServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            FeatureOnlineStoreAdminService.FeatureOnlineStoreAdminServiceClient grpcClient = new FeatureOnlineStoreAdminService.FeatureOnlineStoreAdminServiceClient(callInvoker);
            return new FeatureOnlineStoreAdminServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC FeatureOnlineStoreAdminService client</summary>
        public virtual FeatureOnlineStoreAdminService.FeatureOnlineStoreAdminServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new FeatureOnlineStore in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<FeatureOnlineStore, CreateFeatureOnlineStoreOperationMetadata> CreateFeatureOnlineStore(CreateFeatureOnlineStoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new FeatureOnlineStore in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FeatureOnlineStore, CreateFeatureOnlineStoreOperationMetadata>> CreateFeatureOnlineStoreAsync(CreateFeatureOnlineStoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new FeatureOnlineStore in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FeatureOnlineStore, CreateFeatureOnlineStoreOperationMetadata>> CreateFeatureOnlineStoreAsync(CreateFeatureOnlineStoreRequest request, st::CancellationToken cancellationToken) =>
            CreateFeatureOnlineStoreAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateFeatureOnlineStore</c>.</summary>
        public virtual lro::OperationsClient CreateFeatureOnlineStoreOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateFeatureOnlineStore</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<FeatureOnlineStore, CreateFeatureOnlineStoreOperationMetadata> PollOnceCreateFeatureOnlineStore(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<FeatureOnlineStore, CreateFeatureOnlineStoreOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateFeatureOnlineStoreOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateFeatureOnlineStore</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<FeatureOnlineStore, CreateFeatureOnlineStoreOperationMetadata>> PollOnceCreateFeatureOnlineStoreAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<FeatureOnlineStore, CreateFeatureOnlineStoreOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateFeatureOnlineStoreOperationsClient, callSettings);

        /// <summary>
        /// Creates a new FeatureOnlineStore in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create FeatureOnlineStores.
        /// Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="featureOnlineStore">
        /// Required. The FeatureOnlineStore to create.
        /// </param>
        /// <param name="featureOnlineStoreId">
        /// Required. The ID to use for this FeatureOnlineStore, which will become the
        /// final component of the FeatureOnlineStore's resource name.
        /// 
        /// This value may be up to 60 characters, and valid characters are
        /// `[a-z0-9_]`. The first character cannot be a number.
        /// 
        /// The value must be unique within the project and location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<FeatureOnlineStore, CreateFeatureOnlineStoreOperationMetadata> CreateFeatureOnlineStore(string parent, FeatureOnlineStore featureOnlineStore, string featureOnlineStoreId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeatureOnlineStore(new CreateFeatureOnlineStoreRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                FeatureOnlineStore = gax::GaxPreconditions.CheckNotNull(featureOnlineStore, nameof(featureOnlineStore)),
                FeatureOnlineStoreId = gax::GaxPreconditions.CheckNotNullOrEmpty(featureOnlineStoreId, nameof(featureOnlineStoreId)),
            }, callSettings);

        /// <summary>
        /// Creates a new FeatureOnlineStore in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create FeatureOnlineStores.
        /// Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="featureOnlineStore">
        /// Required. The FeatureOnlineStore to create.
        /// </param>
        /// <param name="featureOnlineStoreId">
        /// Required. The ID to use for this FeatureOnlineStore, which will become the
        /// final component of the FeatureOnlineStore's resource name.
        /// 
        /// This value may be up to 60 characters, and valid characters are
        /// `[a-z0-9_]`. The first character cannot be a number.
        /// 
        /// The value must be unique within the project and location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FeatureOnlineStore, CreateFeatureOnlineStoreOperationMetadata>> CreateFeatureOnlineStoreAsync(string parent, FeatureOnlineStore featureOnlineStore, string featureOnlineStoreId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeatureOnlineStoreAsync(new CreateFeatureOnlineStoreRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                FeatureOnlineStore = gax::GaxPreconditions.CheckNotNull(featureOnlineStore, nameof(featureOnlineStore)),
                FeatureOnlineStoreId = gax::GaxPreconditions.CheckNotNullOrEmpty(featureOnlineStoreId, nameof(featureOnlineStoreId)),
            }, callSettings);

        /// <summary>
        /// Creates a new FeatureOnlineStore in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create FeatureOnlineStores.
        /// Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="featureOnlineStore">
        /// Required. The FeatureOnlineStore to create.
        /// </param>
        /// <param name="featureOnlineStoreId">
        /// Required. The ID to use for this FeatureOnlineStore, which will become the
        /// final component of the FeatureOnlineStore's resource name.
        /// 
        /// This value may be up to 60 characters, and valid characters are
        /// `[a-z0-9_]`. The first character cannot be a number.
        /// 
        /// The value must be unique within the project and location.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FeatureOnlineStore, CreateFeatureOnlineStoreOperationMetadata>> CreateFeatureOnlineStoreAsync(string parent, FeatureOnlineStore featureOnlineStore, string featureOnlineStoreId, st::CancellationToken cancellationToken) =>
            CreateFeatureOnlineStoreAsync(parent, featureOnlineStore, featureOnlineStoreId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new FeatureOnlineStore in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create FeatureOnlineStores.
        /// Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="featureOnlineStore">
        /// Required. The FeatureOnlineStore to create.
        /// </param>
        /// <param name="featureOnlineStoreId">
        /// Required. The ID to use for this FeatureOnlineStore, which will become the
        /// final component of the FeatureOnlineStore's resource name.
        /// 
        /// This value may be up to 60 characters, and valid characters are
        /// `[a-z0-9_]`. The first character cannot be a number.
        /// 
        /// The value must be unique within the project and location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<FeatureOnlineStore, CreateFeatureOnlineStoreOperationMetadata> CreateFeatureOnlineStore(gagr::LocationName parent, FeatureOnlineStore featureOnlineStore, string featureOnlineStoreId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeatureOnlineStore(new CreateFeatureOnlineStoreRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                FeatureOnlineStore = gax::GaxPreconditions.CheckNotNull(featureOnlineStore, nameof(featureOnlineStore)),
                FeatureOnlineStoreId = gax::GaxPreconditions.CheckNotNullOrEmpty(featureOnlineStoreId, nameof(featureOnlineStoreId)),
            }, callSettings);

        /// <summary>
        /// Creates a new FeatureOnlineStore in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create FeatureOnlineStores.
        /// Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="featureOnlineStore">
        /// Required. The FeatureOnlineStore to create.
        /// </param>
        /// <param name="featureOnlineStoreId">
        /// Required. The ID to use for this FeatureOnlineStore, which will become the
        /// final component of the FeatureOnlineStore's resource name.
        /// 
        /// This value may be up to 60 characters, and valid characters are
        /// `[a-z0-9_]`. The first character cannot be a number.
        /// 
        /// The value must be unique within the project and location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FeatureOnlineStore, CreateFeatureOnlineStoreOperationMetadata>> CreateFeatureOnlineStoreAsync(gagr::LocationName parent, FeatureOnlineStore featureOnlineStore, string featureOnlineStoreId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeatureOnlineStoreAsync(new CreateFeatureOnlineStoreRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                FeatureOnlineStore = gax::GaxPreconditions.CheckNotNull(featureOnlineStore, nameof(featureOnlineStore)),
                FeatureOnlineStoreId = gax::GaxPreconditions.CheckNotNullOrEmpty(featureOnlineStoreId, nameof(featureOnlineStoreId)),
            }, callSettings);

        /// <summary>
        /// Creates a new FeatureOnlineStore in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create FeatureOnlineStores.
        /// Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="featureOnlineStore">
        /// Required. The FeatureOnlineStore to create.
        /// </param>
        /// <param name="featureOnlineStoreId">
        /// Required. The ID to use for this FeatureOnlineStore, which will become the
        /// final component of the FeatureOnlineStore's resource name.
        /// 
        /// This value may be up to 60 characters, and valid characters are
        /// `[a-z0-9_]`. The first character cannot be a number.
        /// 
        /// The value must be unique within the project and location.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FeatureOnlineStore, CreateFeatureOnlineStoreOperationMetadata>> CreateFeatureOnlineStoreAsync(gagr::LocationName parent, FeatureOnlineStore featureOnlineStore, string featureOnlineStoreId, st::CancellationToken cancellationToken) =>
            CreateFeatureOnlineStoreAsync(parent, featureOnlineStore, featureOnlineStoreId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single FeatureOnlineStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FeatureOnlineStore GetFeatureOnlineStore(GetFeatureOnlineStoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single FeatureOnlineStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeatureOnlineStore> GetFeatureOnlineStoreAsync(GetFeatureOnlineStoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single FeatureOnlineStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeatureOnlineStore> GetFeatureOnlineStoreAsync(GetFeatureOnlineStoreRequest request, st::CancellationToken cancellationToken) =>
            GetFeatureOnlineStoreAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single FeatureOnlineStore.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the FeatureOnlineStore resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FeatureOnlineStore GetFeatureOnlineStore(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeatureOnlineStore(new GetFeatureOnlineStoreRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single FeatureOnlineStore.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the FeatureOnlineStore resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeatureOnlineStore> GetFeatureOnlineStoreAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeatureOnlineStoreAsync(new GetFeatureOnlineStoreRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single FeatureOnlineStore.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the FeatureOnlineStore resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeatureOnlineStore> GetFeatureOnlineStoreAsync(string name, st::CancellationToken cancellationToken) =>
            GetFeatureOnlineStoreAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single FeatureOnlineStore.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the FeatureOnlineStore resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FeatureOnlineStore GetFeatureOnlineStore(FeatureOnlineStoreName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeatureOnlineStore(new GetFeatureOnlineStoreRequest
            {
                FeatureOnlineStoreName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single FeatureOnlineStore.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the FeatureOnlineStore resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeatureOnlineStore> GetFeatureOnlineStoreAsync(FeatureOnlineStoreName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeatureOnlineStoreAsync(new GetFeatureOnlineStoreRequest
            {
                FeatureOnlineStoreName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single FeatureOnlineStore.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the FeatureOnlineStore resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeatureOnlineStore> GetFeatureOnlineStoreAsync(FeatureOnlineStoreName name, st::CancellationToken cancellationToken) =>
            GetFeatureOnlineStoreAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists FeatureOnlineStores in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FeatureOnlineStore"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFeatureOnlineStoresResponse, FeatureOnlineStore> ListFeatureOnlineStores(ListFeatureOnlineStoresRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists FeatureOnlineStores in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FeatureOnlineStore"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFeatureOnlineStoresResponse, FeatureOnlineStore> ListFeatureOnlineStoresAsync(ListFeatureOnlineStoresRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists FeatureOnlineStores in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list FeatureOnlineStores.
        /// Format:
        /// `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="FeatureOnlineStore"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFeatureOnlineStoresResponse, FeatureOnlineStore> ListFeatureOnlineStores(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListFeatureOnlineStores(new ListFeatureOnlineStoresRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists FeatureOnlineStores in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list FeatureOnlineStores.
        /// Format:
        /// `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="FeatureOnlineStore"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFeatureOnlineStoresResponse, FeatureOnlineStore> ListFeatureOnlineStoresAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListFeatureOnlineStoresAsync(new ListFeatureOnlineStoresRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists FeatureOnlineStores in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list FeatureOnlineStores.
        /// Format:
        /// `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="FeatureOnlineStore"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFeatureOnlineStoresResponse, FeatureOnlineStore> ListFeatureOnlineStores(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListFeatureOnlineStores(new ListFeatureOnlineStoresRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists FeatureOnlineStores in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list FeatureOnlineStores.
        /// Format:
        /// `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="FeatureOnlineStore"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFeatureOnlineStoresResponse, FeatureOnlineStore> ListFeatureOnlineStoresAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListFeatureOnlineStoresAsync(new ListFeatureOnlineStoresRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single FeatureOnlineStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<FeatureOnlineStore, UpdateFeatureOnlineStoreOperationMetadata> UpdateFeatureOnlineStore(UpdateFeatureOnlineStoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single FeatureOnlineStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FeatureOnlineStore, UpdateFeatureOnlineStoreOperationMetadata>> UpdateFeatureOnlineStoreAsync(UpdateFeatureOnlineStoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single FeatureOnlineStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FeatureOnlineStore, UpdateFeatureOnlineStoreOperationMetadata>> UpdateFeatureOnlineStoreAsync(UpdateFeatureOnlineStoreRequest request, st::CancellationToken cancellationToken) =>
            UpdateFeatureOnlineStoreAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateFeatureOnlineStore</c>.</summary>
        public virtual lro::OperationsClient UpdateFeatureOnlineStoreOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateFeatureOnlineStore</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<FeatureOnlineStore, UpdateFeatureOnlineStoreOperationMetadata> PollOnceUpdateFeatureOnlineStore(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<FeatureOnlineStore, UpdateFeatureOnlineStoreOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateFeatureOnlineStoreOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateFeatureOnlineStore</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<FeatureOnlineStore, UpdateFeatureOnlineStoreOperationMetadata>> PollOnceUpdateFeatureOnlineStoreAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<FeatureOnlineStore, UpdateFeatureOnlineStoreOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateFeatureOnlineStoreOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single FeatureOnlineStore.
        /// </summary>
        /// <param name="featureOnlineStore">
        /// Required. The FeatureOnlineStore's `name` field is used to identify the
        /// FeatureOnlineStore to be updated. Format:
        /// `projects/{project}/locations/{location}/featureOnlineStores/{feature_online_store}`
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// FeatureOnlineStore resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then only the non-empty fields present in the
        /// request will be overwritten. Set the update_mask to `*` to override all
        /// fields.
        /// 
        /// Updatable fields:
        /// 
        /// * `big_query_source`
        /// * `bigtable`
        /// * `labels`
        /// * `sync_config`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<FeatureOnlineStore, UpdateFeatureOnlineStoreOperationMetadata> UpdateFeatureOnlineStore(FeatureOnlineStore featureOnlineStore, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFeatureOnlineStore(new UpdateFeatureOnlineStoreRequest
            {
                FeatureOnlineStore = gax::GaxPreconditions.CheckNotNull(featureOnlineStore, nameof(featureOnlineStore)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single FeatureOnlineStore.
        /// </summary>
        /// <param name="featureOnlineStore">
        /// Required. The FeatureOnlineStore's `name` field is used to identify the
        /// FeatureOnlineStore to be updated. Format:
        /// `projects/{project}/locations/{location}/featureOnlineStores/{feature_online_store}`
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// FeatureOnlineStore resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then only the non-empty fields present in the
        /// request will be overwritten. Set the update_mask to `*` to override all
        /// fields.
        /// 
        /// Updatable fields:
        /// 
        /// * `big_query_source`
        /// * `bigtable`
        /// * `labels`
        /// * `sync_config`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FeatureOnlineStore, UpdateFeatureOnlineStoreOperationMetadata>> UpdateFeatureOnlineStoreAsync(FeatureOnlineStore featureOnlineStore, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFeatureOnlineStoreAsync(new UpdateFeatureOnlineStoreRequest
            {
                FeatureOnlineStore = gax::GaxPreconditions.CheckNotNull(featureOnlineStore, nameof(featureOnlineStore)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single FeatureOnlineStore.
        /// </summary>
        /// <param name="featureOnlineStore">
        /// Required. The FeatureOnlineStore's `name` field is used to identify the
        /// FeatureOnlineStore to be updated. Format:
        /// `projects/{project}/locations/{location}/featureOnlineStores/{feature_online_store}`
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// FeatureOnlineStore resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then only the non-empty fields present in the
        /// request will be overwritten. Set the update_mask to `*` to override all
        /// fields.
        /// 
        /// Updatable fields:
        /// 
        /// * `big_query_source`
        /// * `bigtable`
        /// * `labels`
        /// * `sync_config`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FeatureOnlineStore, UpdateFeatureOnlineStoreOperationMetadata>> UpdateFeatureOnlineStoreAsync(FeatureOnlineStore featureOnlineStore, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateFeatureOnlineStoreAsync(featureOnlineStore, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single FeatureOnlineStore. The FeatureOnlineStore must not
        /// contain any FeatureViews.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteFeatureOnlineStore(DeleteFeatureOnlineStoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single FeatureOnlineStore. The FeatureOnlineStore must not
        /// contain any FeatureViews.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteFeatureOnlineStoreAsync(DeleteFeatureOnlineStoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single FeatureOnlineStore. The FeatureOnlineStore must not
        /// contain any FeatureViews.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteFeatureOnlineStoreAsync(DeleteFeatureOnlineStoreRequest request, st::CancellationToken cancellationToken) =>
            DeleteFeatureOnlineStoreAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteFeatureOnlineStore</c>.</summary>
        public virtual lro::OperationsClient DeleteFeatureOnlineStoreOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteFeatureOnlineStore</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> PollOnceDeleteFeatureOnlineStore(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteFeatureOnlineStoreOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteFeatureOnlineStore</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> PollOnceDeleteFeatureOnlineStoreAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteFeatureOnlineStoreOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single FeatureOnlineStore. The FeatureOnlineStore must not
        /// contain any FeatureViews.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the FeatureOnlineStore to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featureOnlineStores/{feature_online_store}`
        /// </param>
        /// <param name="force">
        /// If set to true, any FeatureViews and Features for this FeatureOnlineStore
        /// will also be deleted. (Otherwise, the request will only work if the
        /// FeatureOnlineStore has no FeatureViews.)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteFeatureOnlineStore(string name, bool force, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeatureOnlineStore(new DeleteFeatureOnlineStoreRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Force = force,
            }, callSettings);

        /// <summary>
        /// Deletes a single FeatureOnlineStore. The FeatureOnlineStore must not
        /// contain any FeatureViews.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the FeatureOnlineStore to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featureOnlineStores/{feature_online_store}`
        /// </param>
        /// <param name="force">
        /// If set to true, any FeatureViews and Features for this FeatureOnlineStore
        /// will also be deleted. (Otherwise, the request will only work if the
        /// FeatureOnlineStore has no FeatureViews.)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteFeatureOnlineStoreAsync(string name, bool force, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeatureOnlineStoreAsync(new DeleteFeatureOnlineStoreRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Force = force,
            }, callSettings);

        /// <summary>
        /// Deletes a single FeatureOnlineStore. The FeatureOnlineStore must not
        /// contain any FeatureViews.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the FeatureOnlineStore to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featureOnlineStores/{feature_online_store}`
        /// </param>
        /// <param name="force">
        /// If set to true, any FeatureViews and Features for this FeatureOnlineStore
        /// will also be deleted. (Otherwise, the request will only work if the
        /// FeatureOnlineStore has no FeatureViews.)
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteFeatureOnlineStoreAsync(string name, bool force, st::CancellationToken cancellationToken) =>
            DeleteFeatureOnlineStoreAsync(name, force, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single FeatureOnlineStore. The FeatureOnlineStore must not
        /// contain any FeatureViews.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the FeatureOnlineStore to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featureOnlineStores/{feature_online_store}`
        /// </param>
        /// <param name="force">
        /// If set to true, any FeatureViews and Features for this FeatureOnlineStore
        /// will also be deleted. (Otherwise, the request will only work if the
        /// FeatureOnlineStore has no FeatureViews.)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteFeatureOnlineStore(FeatureOnlineStoreName name, bool force, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeatureOnlineStore(new DeleteFeatureOnlineStoreRequest
            {
                FeatureOnlineStoreName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Force = force,
            }, callSettings);

        /// <summary>
        /// Deletes a single FeatureOnlineStore. The FeatureOnlineStore must not
        /// contain any FeatureViews.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the FeatureOnlineStore to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featureOnlineStores/{feature_online_store}`
        /// </param>
        /// <param name="force">
        /// If set to true, any FeatureViews and Features for this FeatureOnlineStore
        /// will also be deleted. (Otherwise, the request will only work if the
        /// FeatureOnlineStore has no FeatureViews.)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteFeatureOnlineStoreAsync(FeatureOnlineStoreName name, bool force, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeatureOnlineStoreAsync(new DeleteFeatureOnlineStoreRequest
            {
                FeatureOnlineStoreName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Force = force,
            }, callSettings);

        /// <summary>
        /// Deletes a single FeatureOnlineStore. The FeatureOnlineStore must not
        /// contain any FeatureViews.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the FeatureOnlineStore to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featureOnlineStores/{feature_online_store}`
        /// </param>
        /// <param name="force">
        /// If set to true, any FeatureViews and Features for this FeatureOnlineStore
        /// will also be deleted. (Otherwise, the request will only work if the
        /// FeatureOnlineStore has no FeatureViews.)
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteFeatureOnlineStoreAsync(FeatureOnlineStoreName name, bool force, st::CancellationToken cancellationToken) =>
            DeleteFeatureOnlineStoreAsync(name, force, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new FeatureView in a given FeatureOnlineStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<FeatureView, CreateFeatureViewOperationMetadata> CreateFeatureView(CreateFeatureViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new FeatureView in a given FeatureOnlineStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FeatureView, CreateFeatureViewOperationMetadata>> CreateFeatureViewAsync(CreateFeatureViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new FeatureView in a given FeatureOnlineStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FeatureView, CreateFeatureViewOperationMetadata>> CreateFeatureViewAsync(CreateFeatureViewRequest request, st::CancellationToken cancellationToken) =>
            CreateFeatureViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateFeatureView</c>.</summary>
        public virtual lro::OperationsClient CreateFeatureViewOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateFeatureView</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<FeatureView, CreateFeatureViewOperationMetadata> PollOnceCreateFeatureView(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<FeatureView, CreateFeatureViewOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateFeatureViewOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateFeatureView</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<FeatureView, CreateFeatureViewOperationMetadata>> PollOnceCreateFeatureViewAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<FeatureView, CreateFeatureViewOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateFeatureViewOperationsClient, callSettings);

        /// <summary>
        /// Creates a new FeatureView in a given FeatureOnlineStore.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the FeatureOnlineStore to create
        /// FeatureViews. Format:
        /// `projects/{project}/locations/{location}/featureOnlineStores/{feature_online_store}`
        /// </param>
        /// <param name="featureView">
        /// Required. The FeatureView to create.
        /// </param>
        /// <param name="featureViewId">
        /// Required. The ID to use for the FeatureView, which will become the final
        /// component of the FeatureView's resource name.
        /// 
        /// This value may be up to 60 characters, and valid characters are
        /// `[a-z0-9_]`. The first character cannot be a number.
        /// 
        /// The value must be unique within a FeatureOnlineStore.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<FeatureView, CreateFeatureViewOperationMetadata> CreateFeatureView(string parent, FeatureView featureView, string featureViewId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeatureView(new CreateFeatureViewRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                FeatureView = gax::GaxPreconditions.CheckNotNull(featureView, nameof(featureView)),
                FeatureViewId = gax::GaxPreconditions.CheckNotNullOrEmpty(featureViewId, nameof(featureViewId)),
            }, callSettings);

        /// <summary>
        /// Creates a new FeatureView in a given FeatureOnlineStore.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the FeatureOnlineStore to create
        /// FeatureViews. Format:
        /// `projects/{project}/locations/{location}/featureOnlineStores/{feature_online_store}`
        /// </param>
        /// <param name="featureView">
        /// Required. The FeatureView to create.
        /// </param>
        /// <param name="featureViewId">
        /// Required. The ID to use for the FeatureView, which will become the final
        /// component of the FeatureView's resource name.
        /// 
        /// This value may be up to 60 characters, and valid characters are
        /// `[a-z0-9_]`. The first character cannot be a number.
        /// 
        /// The value must be unique within a FeatureOnlineStore.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FeatureView, CreateFeatureViewOperationMetadata>> CreateFeatureViewAsync(string parent, FeatureView featureView, string featureViewId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeatureViewAsync(new CreateFeatureViewRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                FeatureView = gax::GaxPreconditions.CheckNotNull(featureView, nameof(featureView)),
                FeatureViewId = gax::GaxPreconditions.CheckNotNullOrEmpty(featureViewId, nameof(featureViewId)),
            }, callSettings);

        /// <summary>
        /// Creates a new FeatureView in a given FeatureOnlineStore.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the FeatureOnlineStore to create
        /// FeatureViews. Format:
        /// `projects/{project}/locations/{location}/featureOnlineStores/{feature_online_store}`
        /// </param>
        /// <param name="featureView">
        /// Required. The FeatureView to create.
        /// </param>
        /// <param name="featureViewId">
        /// Required. The ID to use for the FeatureView, which will become the final
        /// component of the FeatureView's resource name.
        /// 
        /// This value may be up to 60 characters, and valid characters are
        /// `[a-z0-9_]`. The first character cannot be a number.
        /// 
        /// The value must be unique within a FeatureOnlineStore.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FeatureView, CreateFeatureViewOperationMetadata>> CreateFeatureViewAsync(string parent, FeatureView featureView, string featureViewId, st::CancellationToken cancellationToken) =>
            CreateFeatureViewAsync(parent, featureView, featureViewId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new FeatureView in a given FeatureOnlineStore.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the FeatureOnlineStore to create
        /// FeatureViews. Format:
        /// `projects/{project}/locations/{location}/featureOnlineStores/{feature_online_store}`
        /// </param>
        /// <param name="featureView">
        /// Required. The FeatureView to create.
        /// </param>
        /// <param name="featureViewId">
        /// Required. The ID to use for the FeatureView, which will become the final
        /// component of the FeatureView's resource name.
        /// 
        /// This value may be up to 60 characters, and valid characters are
        /// `[a-z0-9_]`. The first character cannot be a number.
        /// 
        /// The value must be unique within a FeatureOnlineStore.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<FeatureView, CreateFeatureViewOperationMetadata> CreateFeatureView(FeatureOnlineStoreName parent, FeatureView featureView, string featureViewId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeatureView(new CreateFeatureViewRequest
            {
                ParentAsFeatureOnlineStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                FeatureView = gax::GaxPreconditions.CheckNotNull(featureView, nameof(featureView)),
                FeatureViewId = gax::GaxPreconditions.CheckNotNullOrEmpty(featureViewId, nameof(featureViewId)),
            }, callSettings);

        /// <summary>
        /// Creates a new FeatureView in a given FeatureOnlineStore.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the FeatureOnlineStore to create
        /// FeatureViews. Format:
        /// `projects/{project}/locations/{location}/featureOnlineStores/{feature_online_store}`
        /// </param>
        /// <param name="featureView">
        /// Required. The FeatureView to create.
        /// </param>
        /// <param name="featureViewId">
        /// Required. The ID to use for the FeatureView, which will become the final
        /// component of the FeatureView's resource name.
        /// 
        /// This value may be up to 60 characters, and valid characters are
        /// `[a-z0-9_]`. The first character cannot be a number.
        /// 
        /// The value must be unique within a FeatureOnlineStore.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FeatureView, CreateFeatureViewOperationMetadata>> CreateFeatureViewAsync(FeatureOnlineStoreName parent, FeatureView featureView, string featureViewId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeatureViewAsync(new CreateFeatureViewRequest
            {
                ParentAsFeatureOnlineStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                FeatureView = gax::GaxPreconditions.CheckNotNull(featureView, nameof(featureView)),
                FeatureViewId = gax::GaxPreconditions.CheckNotNullOrEmpty(featureViewId, nameof(featureViewId)),
            }, callSettings);

        /// <summary>
        /// Creates a new FeatureView in a given FeatureOnlineStore.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the FeatureOnlineStore to create
        /// FeatureViews. Format:
        /// `projects/{project}/locations/{location}/featureOnlineStores/{feature_online_store}`
        /// </param>
        /// <param name="featureView">
        /// Required. The FeatureView to create.
        /// </param>
        /// <param name="featureViewId">
        /// Required. The ID to use for the FeatureView, which will become the final
        /// component of the FeatureView's resource name.
        /// 
        /// This value may be up to 60 characters, and valid characters are
        /// `[a-z0-9_]`. The first character cannot be a number.
        /// 
        /// The value must be unique within a FeatureOnlineStore.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FeatureView, CreateFeatureViewOperationMetadata>> CreateFeatureViewAsync(FeatureOnlineStoreName parent, FeatureView featureView, string featureViewId, st::CancellationToken cancellationToken) =>
            CreateFeatureViewAsync(parent, featureView, featureViewId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single FeatureView.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FeatureView GetFeatureView(GetFeatureViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single FeatureView.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeatureView> GetFeatureViewAsync(GetFeatureViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single FeatureView.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeatureView> GetFeatureViewAsync(GetFeatureViewRequest request, st::CancellationToken cancellationToken) =>
            GetFeatureViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single FeatureView.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the FeatureView resource.
        /// Format:
        /// `projects/{project}/locations/{location}/featureOnlineStores/{feature_online_store}/featureViews/{feature_view}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FeatureView GetFeatureView(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeatureView(new GetFeatureViewRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single FeatureView.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the FeatureView resource.
        /// Format:
        /// `projects/{project}/locations/{location}/featureOnlineStores/{feature_online_store}/featureViews/{feature_view}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeatureView> GetFeatureViewAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeatureViewAsync(new GetFeatureViewRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single FeatureView.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the FeatureView resource.
        /// Format:
        /// `projects/{project}/locations/{location}/featureOnlineStores/{feature_online_store}/featureViews/{feature_view}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeatureView> GetFeatureViewAsync(string name, st::CancellationToken cancellationToken) =>
            GetFeatureViewAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single FeatureView.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the FeatureView resource.
        /// Format:
        /// `projects/{project}/locations/{location}/featureOnlineStores/{feature_online_store}/featureViews/{feature_view}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FeatureView GetFeatureView(FeatureViewName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeatureView(new GetFeatureViewRequest
            {
                FeatureViewName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single FeatureView.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the FeatureView resource.
        /// Format:
        /// `projects/{project}/locations/{location}/featureOnlineStores/{feature_online_store}/featureViews/{feature_view}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeatureView> GetFeatureViewAsync(FeatureViewName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeatureViewAsync(new GetFeatureViewRequest
            {
                FeatureViewName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single FeatureView.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the FeatureView resource.
        /// Format:
        /// `projects/{project}/locations/{location}/featureOnlineStores/{feature_online_store}/featureViews/{feature_view}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeatureView> GetFeatureViewAsync(FeatureViewName name, st::CancellationToken cancellationToken) =>
            GetFeatureViewAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists FeatureViews in a given FeatureOnlineStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FeatureView"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFeatureViewsResponse, FeatureView> ListFeatureViews(ListFeatureViewsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists FeatureViews in a given FeatureOnlineStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FeatureView"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFeatureViewsResponse, FeatureView> ListFeatureViewsAsync(ListFeatureViewsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists FeatureViews in a given FeatureOnlineStore.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the FeatureOnlineStore to list FeatureViews.
        /// Format:
        /// `projects/{project}/locations/{location}/featureOnlineStores/{feature_online_store}`
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
        /// <returns>A pageable sequence of <see cref="FeatureView"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFeatureViewsResponse, FeatureView> ListFeatureViews(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListFeatureViews(new ListFeatureViewsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists FeatureViews in a given FeatureOnlineStore.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the FeatureOnlineStore to list FeatureViews.
        /// Format:
        /// `projects/{project}/locations/{location}/featureOnlineStores/{feature_online_store}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="FeatureView"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFeatureViewsResponse, FeatureView> ListFeatureViewsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListFeatureViewsAsync(new ListFeatureViewsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists FeatureViews in a given FeatureOnlineStore.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the FeatureOnlineStore to list FeatureViews.
        /// Format:
        /// `projects/{project}/locations/{location}/featureOnlineStores/{feature_online_store}`
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
        /// <returns>A pageable sequence of <see cref="FeatureView"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFeatureViewsResponse, FeatureView> ListFeatureViews(FeatureOnlineStoreName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListFeatureViews(new ListFeatureViewsRequest
            {
                ParentAsFeatureOnlineStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists FeatureViews in a given FeatureOnlineStore.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the FeatureOnlineStore to list FeatureViews.
        /// Format:
        /// `projects/{project}/locations/{location}/featureOnlineStores/{feature_online_store}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="FeatureView"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFeatureViewsResponse, FeatureView> ListFeatureViewsAsync(FeatureOnlineStoreName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListFeatureViewsAsync(new ListFeatureViewsRequest
            {
                ParentAsFeatureOnlineStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single FeatureView.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<FeatureView, UpdateFeatureViewOperationMetadata> UpdateFeatureView(UpdateFeatureViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single FeatureView.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FeatureView, UpdateFeatureViewOperationMetadata>> UpdateFeatureViewAsync(UpdateFeatureViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single FeatureView.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FeatureView, UpdateFeatureViewOperationMetadata>> UpdateFeatureViewAsync(UpdateFeatureViewRequest request, st::CancellationToken cancellationToken) =>
            UpdateFeatureViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateFeatureView</c>.</summary>
        public virtual lro::OperationsClient UpdateFeatureViewOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateFeatureView</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<FeatureView, UpdateFeatureViewOperationMetadata> PollOnceUpdateFeatureView(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<FeatureView, UpdateFeatureViewOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateFeatureViewOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateFeatureView</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<FeatureView, UpdateFeatureViewOperationMetadata>> PollOnceUpdateFeatureViewAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<FeatureView, UpdateFeatureViewOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateFeatureViewOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single FeatureView.
        /// </summary>
        /// <param name="featureView">
        /// Required. The FeatureView's `name` field is used to identify the
        /// FeatureView to be updated. Format:
        /// `projects/{project}/locations/{location}/featureOnlineStores/{feature_online_store}/featureViews/{feature_view}`
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// FeatureView resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then only the non-empty fields present in the
        /// request will be overwritten. Set the update_mask to `*` to override all
        /// fields.
        /// 
        /// Updatable fields:
        /// 
        /// * `labels`
        /// * `serviceAgentType`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<FeatureView, UpdateFeatureViewOperationMetadata> UpdateFeatureView(FeatureView featureView, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFeatureView(new UpdateFeatureViewRequest
            {
                FeatureView = gax::GaxPreconditions.CheckNotNull(featureView, nameof(featureView)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single FeatureView.
        /// </summary>
        /// <param name="featureView">
        /// Required. The FeatureView's `name` field is used to identify the
        /// FeatureView to be updated. Format:
        /// `projects/{project}/locations/{location}/featureOnlineStores/{feature_online_store}/featureViews/{feature_view}`
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// FeatureView resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then only the non-empty fields present in the
        /// request will be overwritten. Set the update_mask to `*` to override all
        /// fields.
        /// 
        /// Updatable fields:
        /// 
        /// * `labels`
        /// * `serviceAgentType`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FeatureView, UpdateFeatureViewOperationMetadata>> UpdateFeatureViewAsync(FeatureView featureView, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFeatureViewAsync(new UpdateFeatureViewRequest
            {
                FeatureView = gax::GaxPreconditions.CheckNotNull(featureView, nameof(featureView)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single FeatureView.
        /// </summary>
        /// <param name="featureView">
        /// Required. The FeatureView's `name` field is used to identify the
        /// FeatureView to be updated. Format:
        /// `projects/{project}/locations/{location}/featureOnlineStores/{feature_online_store}/featureViews/{feature_view}`
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// FeatureView resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then only the non-empty fields present in the
        /// request will be overwritten. Set the update_mask to `*` to override all
        /// fields.
        /// 
        /// Updatable fields:
        /// 
        /// * `labels`
        /// * `serviceAgentType`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FeatureView, UpdateFeatureViewOperationMetadata>> UpdateFeatureViewAsync(FeatureView featureView, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateFeatureViewAsync(featureView, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single FeatureView.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteFeatureView(DeleteFeatureViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single FeatureView.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteFeatureViewAsync(DeleteFeatureViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single FeatureView.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteFeatureViewAsync(DeleteFeatureViewRequest request, st::CancellationToken cancellationToken) =>
            DeleteFeatureViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteFeatureView</c>.</summary>
        public virtual lro::OperationsClient DeleteFeatureViewOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteFeatureView</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> PollOnceDeleteFeatureView(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteFeatureViewOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteFeatureView</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> PollOnceDeleteFeatureViewAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteFeatureViewOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single FeatureView.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the FeatureView to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featureOnlineStores/{feature_online_store}/featureViews/{feature_view}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteFeatureView(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeatureView(new DeleteFeatureViewRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single FeatureView.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the FeatureView to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featureOnlineStores/{feature_online_store}/featureViews/{feature_view}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteFeatureViewAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeatureViewAsync(new DeleteFeatureViewRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single FeatureView.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the FeatureView to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featureOnlineStores/{feature_online_store}/featureViews/{feature_view}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteFeatureViewAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteFeatureViewAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single FeatureView.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the FeatureView to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featureOnlineStores/{feature_online_store}/featureViews/{feature_view}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteFeatureView(FeatureViewName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeatureView(new DeleteFeatureViewRequest
            {
                FeatureViewName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single FeatureView.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the FeatureView to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featureOnlineStores/{feature_online_store}/featureViews/{feature_view}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteFeatureViewAsync(FeatureViewName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeatureViewAsync(new DeleteFeatureViewRequest
            {
                FeatureViewName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single FeatureView.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the FeatureView to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/featureOnlineStores/{feature_online_store}/featureViews/{feature_view}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteFeatureViewAsync(FeatureViewName name, st::CancellationToken cancellationToken) =>
            DeleteFeatureViewAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Triggers on-demand sync for the FeatureView.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SyncFeatureViewResponse SyncFeatureView(SyncFeatureViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Triggers on-demand sync for the FeatureView.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SyncFeatureViewResponse> SyncFeatureViewAsync(SyncFeatureViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Triggers on-demand sync for the FeatureView.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SyncFeatureViewResponse> SyncFeatureViewAsync(SyncFeatureViewRequest request, st::CancellationToken cancellationToken) =>
            SyncFeatureViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Triggers on-demand sync for the FeatureView.
        /// </summary>
        /// <param name="featureView">
        /// Required. Format:
        /// `projects/{project}/locations/{location}/featureOnlineStores/{feature_online_store}/featureViews/{feature_view}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SyncFeatureViewResponse SyncFeatureView(string featureView, gaxgrpc::CallSettings callSettings = null) =>
            SyncFeatureView(new SyncFeatureViewRequest
            {
                FeatureView = gax::GaxPreconditions.CheckNotNullOrEmpty(featureView, nameof(featureView)),
            }, callSettings);

        /// <summary>
        /// Triggers on-demand sync for the FeatureView.
        /// </summary>
        /// <param name="featureView">
        /// Required. Format:
        /// `projects/{project}/locations/{location}/featureOnlineStores/{feature_online_store}/featureViews/{feature_view}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SyncFeatureViewResponse> SyncFeatureViewAsync(string featureView, gaxgrpc::CallSettings callSettings = null) =>
            SyncFeatureViewAsync(new SyncFeatureViewRequest
            {
                FeatureView = gax::GaxPreconditions.CheckNotNullOrEmpty(featureView, nameof(featureView)),
            }, callSettings);

        /// <summary>
        /// Triggers on-demand sync for the FeatureView.
        /// </summary>
        /// <param name="featureView">
        /// Required. Format:
        /// `projects/{project}/locations/{location}/featureOnlineStores/{feature_online_store}/featureViews/{feature_view}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SyncFeatureViewResponse> SyncFeatureViewAsync(string featureView, st::CancellationToken cancellationToken) =>
            SyncFeatureViewAsync(featureView, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Triggers on-demand sync for the FeatureView.
        /// </summary>
        /// <param name="featureView">
        /// Required. Format:
        /// `projects/{project}/locations/{location}/featureOnlineStores/{feature_online_store}/featureViews/{feature_view}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SyncFeatureViewResponse SyncFeatureView(FeatureViewName featureView, gaxgrpc::CallSettings callSettings = null) =>
            SyncFeatureView(new SyncFeatureViewRequest
            {
                FeatureViewAsFeatureViewName = gax::GaxPreconditions.CheckNotNull(featureView, nameof(featureView)),
            }, callSettings);

        /// <summary>
        /// Triggers on-demand sync for the FeatureView.
        /// </summary>
        /// <param name="featureView">
        /// Required. Format:
        /// `projects/{project}/locations/{location}/featureOnlineStores/{feature_online_store}/featureViews/{feature_view}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SyncFeatureViewResponse> SyncFeatureViewAsync(FeatureViewName featureView, gaxgrpc::CallSettings callSettings = null) =>
            SyncFeatureViewAsync(new SyncFeatureViewRequest
            {
                FeatureViewAsFeatureViewName = gax::GaxPreconditions.CheckNotNull(featureView, nameof(featureView)),
            }, callSettings);

        /// <summary>
        /// Triggers on-demand sync for the FeatureView.
        /// </summary>
        /// <param name="featureView">
        /// Required. Format:
        /// `projects/{project}/locations/{location}/featureOnlineStores/{feature_online_store}/featureViews/{feature_view}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SyncFeatureViewResponse> SyncFeatureViewAsync(FeatureViewName featureView, st::CancellationToken cancellationToken) =>
            SyncFeatureViewAsync(featureView, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single FeatureViewSync.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FeatureViewSync GetFeatureViewSync(GetFeatureViewSyncRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single FeatureViewSync.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeatureViewSync> GetFeatureViewSyncAsync(GetFeatureViewSyncRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single FeatureViewSync.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeatureViewSync> GetFeatureViewSyncAsync(GetFeatureViewSyncRequest request, st::CancellationToken cancellationToken) =>
            GetFeatureViewSyncAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single FeatureViewSync.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the FeatureViewSync resource.
        /// Format:
        /// `projects/{project}/locations/{location}/featureOnlineStores/{feature_online_store}/featureViews/{feature_view}/featureViewSyncs/{feature_view_sync}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FeatureViewSync GetFeatureViewSync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeatureViewSync(new GetFeatureViewSyncRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single FeatureViewSync.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the FeatureViewSync resource.
        /// Format:
        /// `projects/{project}/locations/{location}/featureOnlineStores/{feature_online_store}/featureViews/{feature_view}/featureViewSyncs/{feature_view_sync}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeatureViewSync> GetFeatureViewSyncAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeatureViewSyncAsync(new GetFeatureViewSyncRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single FeatureViewSync.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the FeatureViewSync resource.
        /// Format:
        /// `projects/{project}/locations/{location}/featureOnlineStores/{feature_online_store}/featureViews/{feature_view}/featureViewSyncs/{feature_view_sync}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeatureViewSync> GetFeatureViewSyncAsync(string name, st::CancellationToken cancellationToken) =>
            GetFeatureViewSyncAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single FeatureViewSync.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the FeatureViewSync resource.
        /// Format:
        /// `projects/{project}/locations/{location}/featureOnlineStores/{feature_online_store}/featureViews/{feature_view}/featureViewSyncs/{feature_view_sync}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FeatureViewSync GetFeatureViewSync(FeatureViewSyncName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeatureViewSync(new GetFeatureViewSyncRequest
            {
                FeatureViewSyncName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single FeatureViewSync.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the FeatureViewSync resource.
        /// Format:
        /// `projects/{project}/locations/{location}/featureOnlineStores/{feature_online_store}/featureViews/{feature_view}/featureViewSyncs/{feature_view_sync}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeatureViewSync> GetFeatureViewSyncAsync(FeatureViewSyncName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeatureViewSyncAsync(new GetFeatureViewSyncRequest
            {
                FeatureViewSyncName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single FeatureViewSync.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the FeatureViewSync resource.
        /// Format:
        /// `projects/{project}/locations/{location}/featureOnlineStores/{feature_online_store}/featureViews/{feature_view}/featureViewSyncs/{feature_view_sync}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeatureViewSync> GetFeatureViewSyncAsync(FeatureViewSyncName name, st::CancellationToken cancellationToken) =>
            GetFeatureViewSyncAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists FeatureViewSyncs in a given FeatureView.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FeatureViewSync"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFeatureViewSyncsResponse, FeatureViewSync> ListFeatureViewSyncs(ListFeatureViewSyncsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists FeatureViewSyncs in a given FeatureView.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FeatureViewSync"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFeatureViewSyncsResponse, FeatureViewSync> ListFeatureViewSyncsAsync(ListFeatureViewSyncsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists FeatureViewSyncs in a given FeatureView.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the FeatureView to list FeatureViewSyncs.
        /// Format:
        /// `projects/{project}/locations/{location}/featureOnlineStores/{feature_online_store}/featureViews/{feature_view}`
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
        /// <returns>A pageable sequence of <see cref="FeatureViewSync"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFeatureViewSyncsResponse, FeatureViewSync> ListFeatureViewSyncs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListFeatureViewSyncs(new ListFeatureViewSyncsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists FeatureViewSyncs in a given FeatureView.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the FeatureView to list FeatureViewSyncs.
        /// Format:
        /// `projects/{project}/locations/{location}/featureOnlineStores/{feature_online_store}/featureViews/{feature_view}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="FeatureViewSync"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFeatureViewSyncsResponse, FeatureViewSync> ListFeatureViewSyncsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListFeatureViewSyncsAsync(new ListFeatureViewSyncsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists FeatureViewSyncs in a given FeatureView.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the FeatureView to list FeatureViewSyncs.
        /// Format:
        /// `projects/{project}/locations/{location}/featureOnlineStores/{feature_online_store}/featureViews/{feature_view}`
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
        /// <returns>A pageable sequence of <see cref="FeatureViewSync"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFeatureViewSyncsResponse, FeatureViewSync> ListFeatureViewSyncs(FeatureViewName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListFeatureViewSyncs(new ListFeatureViewSyncsRequest
            {
                ParentAsFeatureViewName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists FeatureViewSyncs in a given FeatureView.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the FeatureView to list FeatureViewSyncs.
        /// Format:
        /// `projects/{project}/locations/{location}/featureOnlineStores/{feature_online_store}/featureViews/{feature_view}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="FeatureViewSync"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFeatureViewSyncsResponse, FeatureViewSync> ListFeatureViewSyncsAsync(FeatureViewName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListFeatureViewSyncsAsync(new ListFeatureViewSyncsRequest
            {
                ParentAsFeatureViewName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);
    }

    /// <summary>FeatureOnlineStoreAdminService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The service that handles CRUD and List for resources for
    /// FeatureOnlineStore.
    /// </remarks>
    public sealed partial class FeatureOnlineStoreAdminServiceClientImpl : FeatureOnlineStoreAdminServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateFeatureOnlineStoreRequest, lro::Operation> _callCreateFeatureOnlineStore;

        private readonly gaxgrpc::ApiCall<GetFeatureOnlineStoreRequest, FeatureOnlineStore> _callGetFeatureOnlineStore;

        private readonly gaxgrpc::ApiCall<ListFeatureOnlineStoresRequest, ListFeatureOnlineStoresResponse> _callListFeatureOnlineStores;

        private readonly gaxgrpc::ApiCall<UpdateFeatureOnlineStoreRequest, lro::Operation> _callUpdateFeatureOnlineStore;

        private readonly gaxgrpc::ApiCall<DeleteFeatureOnlineStoreRequest, lro::Operation> _callDeleteFeatureOnlineStore;

        private readonly gaxgrpc::ApiCall<CreateFeatureViewRequest, lro::Operation> _callCreateFeatureView;

        private readonly gaxgrpc::ApiCall<GetFeatureViewRequest, FeatureView> _callGetFeatureView;

        private readonly gaxgrpc::ApiCall<ListFeatureViewsRequest, ListFeatureViewsResponse> _callListFeatureViews;

        private readonly gaxgrpc::ApiCall<UpdateFeatureViewRequest, lro::Operation> _callUpdateFeatureView;

        private readonly gaxgrpc::ApiCall<DeleteFeatureViewRequest, lro::Operation> _callDeleteFeatureView;

        private readonly gaxgrpc::ApiCall<SyncFeatureViewRequest, SyncFeatureViewResponse> _callSyncFeatureView;

        private readonly gaxgrpc::ApiCall<GetFeatureViewSyncRequest, FeatureViewSync> _callGetFeatureViewSync;

        private readonly gaxgrpc::ApiCall<ListFeatureViewSyncsRequest, ListFeatureViewSyncsResponse> _callListFeatureViewSyncs;

        /// <summary>
        /// Constructs a client wrapper for the FeatureOnlineStoreAdminService service, with the specified gRPC client
        /// and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="FeatureOnlineStoreAdminServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public FeatureOnlineStoreAdminServiceClientImpl(FeatureOnlineStoreAdminService.FeatureOnlineStoreAdminServiceClient grpcClient, FeatureOnlineStoreAdminServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            FeatureOnlineStoreAdminServiceSettings effectiveSettings = settings ?? FeatureOnlineStoreAdminServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateFeatureOnlineStoreOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateFeatureOnlineStoreOperationsSettings, logger);
            UpdateFeatureOnlineStoreOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateFeatureOnlineStoreOperationsSettings, logger);
            DeleteFeatureOnlineStoreOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteFeatureOnlineStoreOperationsSettings, logger);
            CreateFeatureViewOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateFeatureViewOperationsSettings, logger);
            UpdateFeatureViewOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateFeatureViewOperationsSettings, logger);
            DeleteFeatureViewOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteFeatureViewOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callCreateFeatureOnlineStore = clientHelper.BuildApiCall<CreateFeatureOnlineStoreRequest, lro::Operation>("CreateFeatureOnlineStore", grpcClient.CreateFeatureOnlineStoreAsync, grpcClient.CreateFeatureOnlineStore, effectiveSettings.CreateFeatureOnlineStoreSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateFeatureOnlineStore);
            Modify_CreateFeatureOnlineStoreApiCall(ref _callCreateFeatureOnlineStore);
            _callGetFeatureOnlineStore = clientHelper.BuildApiCall<GetFeatureOnlineStoreRequest, FeatureOnlineStore>("GetFeatureOnlineStore", grpcClient.GetFeatureOnlineStoreAsync, grpcClient.GetFeatureOnlineStore, effectiveSettings.GetFeatureOnlineStoreSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetFeatureOnlineStore);
            Modify_GetFeatureOnlineStoreApiCall(ref _callGetFeatureOnlineStore);
            _callListFeatureOnlineStores = clientHelper.BuildApiCall<ListFeatureOnlineStoresRequest, ListFeatureOnlineStoresResponse>("ListFeatureOnlineStores", grpcClient.ListFeatureOnlineStoresAsync, grpcClient.ListFeatureOnlineStores, effectiveSettings.ListFeatureOnlineStoresSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListFeatureOnlineStores);
            Modify_ListFeatureOnlineStoresApiCall(ref _callListFeatureOnlineStores);
            _callUpdateFeatureOnlineStore = clientHelper.BuildApiCall<UpdateFeatureOnlineStoreRequest, lro::Operation>("UpdateFeatureOnlineStore", grpcClient.UpdateFeatureOnlineStoreAsync, grpcClient.UpdateFeatureOnlineStore, effectiveSettings.UpdateFeatureOnlineStoreSettings).WithGoogleRequestParam("feature_online_store.name", request => request.FeatureOnlineStore?.Name);
            Modify_ApiCall(ref _callUpdateFeatureOnlineStore);
            Modify_UpdateFeatureOnlineStoreApiCall(ref _callUpdateFeatureOnlineStore);
            _callDeleteFeatureOnlineStore = clientHelper.BuildApiCall<DeleteFeatureOnlineStoreRequest, lro::Operation>("DeleteFeatureOnlineStore", grpcClient.DeleteFeatureOnlineStoreAsync, grpcClient.DeleteFeatureOnlineStore, effectiveSettings.DeleteFeatureOnlineStoreSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteFeatureOnlineStore);
            Modify_DeleteFeatureOnlineStoreApiCall(ref _callDeleteFeatureOnlineStore);
            _callCreateFeatureView = clientHelper.BuildApiCall<CreateFeatureViewRequest, lro::Operation>("CreateFeatureView", grpcClient.CreateFeatureViewAsync, grpcClient.CreateFeatureView, effectiveSettings.CreateFeatureViewSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateFeatureView);
            Modify_CreateFeatureViewApiCall(ref _callCreateFeatureView);
            _callGetFeatureView = clientHelper.BuildApiCall<GetFeatureViewRequest, FeatureView>("GetFeatureView", grpcClient.GetFeatureViewAsync, grpcClient.GetFeatureView, effectiveSettings.GetFeatureViewSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetFeatureView);
            Modify_GetFeatureViewApiCall(ref _callGetFeatureView);
            _callListFeatureViews = clientHelper.BuildApiCall<ListFeatureViewsRequest, ListFeatureViewsResponse>("ListFeatureViews", grpcClient.ListFeatureViewsAsync, grpcClient.ListFeatureViews, effectiveSettings.ListFeatureViewsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListFeatureViews);
            Modify_ListFeatureViewsApiCall(ref _callListFeatureViews);
            _callUpdateFeatureView = clientHelper.BuildApiCall<UpdateFeatureViewRequest, lro::Operation>("UpdateFeatureView", grpcClient.UpdateFeatureViewAsync, grpcClient.UpdateFeatureView, effectiveSettings.UpdateFeatureViewSettings).WithGoogleRequestParam("feature_view.name", request => request.FeatureView?.Name);
            Modify_ApiCall(ref _callUpdateFeatureView);
            Modify_UpdateFeatureViewApiCall(ref _callUpdateFeatureView);
            _callDeleteFeatureView = clientHelper.BuildApiCall<DeleteFeatureViewRequest, lro::Operation>("DeleteFeatureView", grpcClient.DeleteFeatureViewAsync, grpcClient.DeleteFeatureView, effectiveSettings.DeleteFeatureViewSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteFeatureView);
            Modify_DeleteFeatureViewApiCall(ref _callDeleteFeatureView);
            _callSyncFeatureView = clientHelper.BuildApiCall<SyncFeatureViewRequest, SyncFeatureViewResponse>("SyncFeatureView", grpcClient.SyncFeatureViewAsync, grpcClient.SyncFeatureView, effectiveSettings.SyncFeatureViewSettings).WithGoogleRequestParam("feature_view", request => request.FeatureView);
            Modify_ApiCall(ref _callSyncFeatureView);
            Modify_SyncFeatureViewApiCall(ref _callSyncFeatureView);
            _callGetFeatureViewSync = clientHelper.BuildApiCall<GetFeatureViewSyncRequest, FeatureViewSync>("GetFeatureViewSync", grpcClient.GetFeatureViewSyncAsync, grpcClient.GetFeatureViewSync, effectiveSettings.GetFeatureViewSyncSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetFeatureViewSync);
            Modify_GetFeatureViewSyncApiCall(ref _callGetFeatureViewSync);
            _callListFeatureViewSyncs = clientHelper.BuildApiCall<ListFeatureViewSyncsRequest, ListFeatureViewSyncsResponse>("ListFeatureViewSyncs", grpcClient.ListFeatureViewSyncsAsync, grpcClient.ListFeatureViewSyncs, effectiveSettings.ListFeatureViewSyncsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListFeatureViewSyncs);
            Modify_ListFeatureViewSyncsApiCall(ref _callListFeatureViewSyncs);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateFeatureOnlineStoreApiCall(ref gaxgrpc::ApiCall<CreateFeatureOnlineStoreRequest, lro::Operation> call);

        partial void Modify_GetFeatureOnlineStoreApiCall(ref gaxgrpc::ApiCall<GetFeatureOnlineStoreRequest, FeatureOnlineStore> call);

        partial void Modify_ListFeatureOnlineStoresApiCall(ref gaxgrpc::ApiCall<ListFeatureOnlineStoresRequest, ListFeatureOnlineStoresResponse> call);

        partial void Modify_UpdateFeatureOnlineStoreApiCall(ref gaxgrpc::ApiCall<UpdateFeatureOnlineStoreRequest, lro::Operation> call);

        partial void Modify_DeleteFeatureOnlineStoreApiCall(ref gaxgrpc::ApiCall<DeleteFeatureOnlineStoreRequest, lro::Operation> call);

        partial void Modify_CreateFeatureViewApiCall(ref gaxgrpc::ApiCall<CreateFeatureViewRequest, lro::Operation> call);

        partial void Modify_GetFeatureViewApiCall(ref gaxgrpc::ApiCall<GetFeatureViewRequest, FeatureView> call);

        partial void Modify_ListFeatureViewsApiCall(ref gaxgrpc::ApiCall<ListFeatureViewsRequest, ListFeatureViewsResponse> call);

        partial void Modify_UpdateFeatureViewApiCall(ref gaxgrpc::ApiCall<UpdateFeatureViewRequest, lro::Operation> call);

        partial void Modify_DeleteFeatureViewApiCall(ref gaxgrpc::ApiCall<DeleteFeatureViewRequest, lro::Operation> call);

        partial void Modify_SyncFeatureViewApiCall(ref gaxgrpc::ApiCall<SyncFeatureViewRequest, SyncFeatureViewResponse> call);

        partial void Modify_GetFeatureViewSyncApiCall(ref gaxgrpc::ApiCall<GetFeatureViewSyncRequest, FeatureViewSync> call);

        partial void Modify_ListFeatureViewSyncsApiCall(ref gaxgrpc::ApiCall<ListFeatureViewSyncsRequest, ListFeatureViewSyncsResponse> call);

        partial void OnConstruction(FeatureOnlineStoreAdminService.FeatureOnlineStoreAdminServiceClient grpcClient, FeatureOnlineStoreAdminServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC FeatureOnlineStoreAdminService client</summary>
        public override FeatureOnlineStoreAdminService.FeatureOnlineStoreAdminServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_CreateFeatureOnlineStoreRequest(ref CreateFeatureOnlineStoreRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetFeatureOnlineStoreRequest(ref GetFeatureOnlineStoreRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListFeatureOnlineStoresRequest(ref ListFeatureOnlineStoresRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateFeatureOnlineStoreRequest(ref UpdateFeatureOnlineStoreRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteFeatureOnlineStoreRequest(ref DeleteFeatureOnlineStoreRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateFeatureViewRequest(ref CreateFeatureViewRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetFeatureViewRequest(ref GetFeatureViewRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListFeatureViewsRequest(ref ListFeatureViewsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateFeatureViewRequest(ref UpdateFeatureViewRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteFeatureViewRequest(ref DeleteFeatureViewRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SyncFeatureViewRequest(ref SyncFeatureViewRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetFeatureViewSyncRequest(ref GetFeatureViewSyncRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListFeatureViewSyncsRequest(ref ListFeatureViewSyncsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateFeatureOnlineStore</c>.</summary>
        public override lro::OperationsClient CreateFeatureOnlineStoreOperationsClient { get; }

        /// <summary>
        /// Creates a new FeatureOnlineStore in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<FeatureOnlineStore, CreateFeatureOnlineStoreOperationMetadata> CreateFeatureOnlineStore(CreateFeatureOnlineStoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFeatureOnlineStoreRequest(ref request, ref callSettings);
            return new lro::Operation<FeatureOnlineStore, CreateFeatureOnlineStoreOperationMetadata>(_callCreateFeatureOnlineStore.Sync(request, callSettings), CreateFeatureOnlineStoreOperationsClient);
        }

        /// <summary>
        /// Creates a new FeatureOnlineStore in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<FeatureOnlineStore, CreateFeatureOnlineStoreOperationMetadata>> CreateFeatureOnlineStoreAsync(CreateFeatureOnlineStoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFeatureOnlineStoreRequest(ref request, ref callSettings);
            return new lro::Operation<FeatureOnlineStore, CreateFeatureOnlineStoreOperationMetadata>(await _callCreateFeatureOnlineStore.Async(request, callSettings).ConfigureAwait(false), CreateFeatureOnlineStoreOperationsClient);
        }

        /// <summary>
        /// Gets details of a single FeatureOnlineStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FeatureOnlineStore GetFeatureOnlineStore(GetFeatureOnlineStoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFeatureOnlineStoreRequest(ref request, ref callSettings);
            return _callGetFeatureOnlineStore.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single FeatureOnlineStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FeatureOnlineStore> GetFeatureOnlineStoreAsync(GetFeatureOnlineStoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFeatureOnlineStoreRequest(ref request, ref callSettings);
            return _callGetFeatureOnlineStore.Async(request, callSettings);
        }

        /// <summary>
        /// Lists FeatureOnlineStores in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FeatureOnlineStore"/> resources.</returns>
        public override gax::PagedEnumerable<ListFeatureOnlineStoresResponse, FeatureOnlineStore> ListFeatureOnlineStores(ListFeatureOnlineStoresRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFeatureOnlineStoresRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListFeatureOnlineStoresRequest, ListFeatureOnlineStoresResponse, FeatureOnlineStore>(_callListFeatureOnlineStores, request, callSettings);
        }

        /// <summary>
        /// Lists FeatureOnlineStores in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FeatureOnlineStore"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListFeatureOnlineStoresResponse, FeatureOnlineStore> ListFeatureOnlineStoresAsync(ListFeatureOnlineStoresRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFeatureOnlineStoresRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListFeatureOnlineStoresRequest, ListFeatureOnlineStoresResponse, FeatureOnlineStore>(_callListFeatureOnlineStores, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateFeatureOnlineStore</c>.</summary>
        public override lro::OperationsClient UpdateFeatureOnlineStoreOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single FeatureOnlineStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<FeatureOnlineStore, UpdateFeatureOnlineStoreOperationMetadata> UpdateFeatureOnlineStore(UpdateFeatureOnlineStoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFeatureOnlineStoreRequest(ref request, ref callSettings);
            return new lro::Operation<FeatureOnlineStore, UpdateFeatureOnlineStoreOperationMetadata>(_callUpdateFeatureOnlineStore.Sync(request, callSettings), UpdateFeatureOnlineStoreOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single FeatureOnlineStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<FeatureOnlineStore, UpdateFeatureOnlineStoreOperationMetadata>> UpdateFeatureOnlineStoreAsync(UpdateFeatureOnlineStoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFeatureOnlineStoreRequest(ref request, ref callSettings);
            return new lro::Operation<FeatureOnlineStore, UpdateFeatureOnlineStoreOperationMetadata>(await _callUpdateFeatureOnlineStore.Async(request, callSettings).ConfigureAwait(false), UpdateFeatureOnlineStoreOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteFeatureOnlineStore</c>.</summary>
        public override lro::OperationsClient DeleteFeatureOnlineStoreOperationsClient { get; }

        /// <summary>
        /// Deletes a single FeatureOnlineStore. The FeatureOnlineStore must not
        /// contain any FeatureViews.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteFeatureOnlineStore(DeleteFeatureOnlineStoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFeatureOnlineStoreRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(_callDeleteFeatureOnlineStore.Sync(request, callSettings), DeleteFeatureOnlineStoreOperationsClient);
        }

        /// <summary>
        /// Deletes a single FeatureOnlineStore. The FeatureOnlineStore must not
        /// contain any FeatureViews.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteFeatureOnlineStoreAsync(DeleteFeatureOnlineStoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFeatureOnlineStoreRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(await _callDeleteFeatureOnlineStore.Async(request, callSettings).ConfigureAwait(false), DeleteFeatureOnlineStoreOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreateFeatureView</c>.</summary>
        public override lro::OperationsClient CreateFeatureViewOperationsClient { get; }

        /// <summary>
        /// Creates a new FeatureView in a given FeatureOnlineStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<FeatureView, CreateFeatureViewOperationMetadata> CreateFeatureView(CreateFeatureViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFeatureViewRequest(ref request, ref callSettings);
            return new lro::Operation<FeatureView, CreateFeatureViewOperationMetadata>(_callCreateFeatureView.Sync(request, callSettings), CreateFeatureViewOperationsClient);
        }

        /// <summary>
        /// Creates a new FeatureView in a given FeatureOnlineStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<FeatureView, CreateFeatureViewOperationMetadata>> CreateFeatureViewAsync(CreateFeatureViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFeatureViewRequest(ref request, ref callSettings);
            return new lro::Operation<FeatureView, CreateFeatureViewOperationMetadata>(await _callCreateFeatureView.Async(request, callSettings).ConfigureAwait(false), CreateFeatureViewOperationsClient);
        }

        /// <summary>
        /// Gets details of a single FeatureView.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FeatureView GetFeatureView(GetFeatureViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFeatureViewRequest(ref request, ref callSettings);
            return _callGetFeatureView.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single FeatureView.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FeatureView> GetFeatureViewAsync(GetFeatureViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFeatureViewRequest(ref request, ref callSettings);
            return _callGetFeatureView.Async(request, callSettings);
        }

        /// <summary>
        /// Lists FeatureViews in a given FeatureOnlineStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FeatureView"/> resources.</returns>
        public override gax::PagedEnumerable<ListFeatureViewsResponse, FeatureView> ListFeatureViews(ListFeatureViewsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFeatureViewsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListFeatureViewsRequest, ListFeatureViewsResponse, FeatureView>(_callListFeatureViews, request, callSettings);
        }

        /// <summary>
        /// Lists FeatureViews in a given FeatureOnlineStore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FeatureView"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListFeatureViewsResponse, FeatureView> ListFeatureViewsAsync(ListFeatureViewsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFeatureViewsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListFeatureViewsRequest, ListFeatureViewsResponse, FeatureView>(_callListFeatureViews, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateFeatureView</c>.</summary>
        public override lro::OperationsClient UpdateFeatureViewOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single FeatureView.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<FeatureView, UpdateFeatureViewOperationMetadata> UpdateFeatureView(UpdateFeatureViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFeatureViewRequest(ref request, ref callSettings);
            return new lro::Operation<FeatureView, UpdateFeatureViewOperationMetadata>(_callUpdateFeatureView.Sync(request, callSettings), UpdateFeatureViewOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single FeatureView.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<FeatureView, UpdateFeatureViewOperationMetadata>> UpdateFeatureViewAsync(UpdateFeatureViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFeatureViewRequest(ref request, ref callSettings);
            return new lro::Operation<FeatureView, UpdateFeatureViewOperationMetadata>(await _callUpdateFeatureView.Async(request, callSettings).ConfigureAwait(false), UpdateFeatureViewOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteFeatureView</c>.</summary>
        public override lro::OperationsClient DeleteFeatureViewOperationsClient { get; }

        /// <summary>
        /// Deletes a single FeatureView.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteFeatureView(DeleteFeatureViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFeatureViewRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(_callDeleteFeatureView.Sync(request, callSettings), DeleteFeatureViewOperationsClient);
        }

        /// <summary>
        /// Deletes a single FeatureView.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteFeatureViewAsync(DeleteFeatureViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFeatureViewRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(await _callDeleteFeatureView.Async(request, callSettings).ConfigureAwait(false), DeleteFeatureViewOperationsClient);
        }

        /// <summary>
        /// Triggers on-demand sync for the FeatureView.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SyncFeatureViewResponse SyncFeatureView(SyncFeatureViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SyncFeatureViewRequest(ref request, ref callSettings);
            return _callSyncFeatureView.Sync(request, callSettings);
        }

        /// <summary>
        /// Triggers on-demand sync for the FeatureView.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SyncFeatureViewResponse> SyncFeatureViewAsync(SyncFeatureViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SyncFeatureViewRequest(ref request, ref callSettings);
            return _callSyncFeatureView.Async(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single FeatureViewSync.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FeatureViewSync GetFeatureViewSync(GetFeatureViewSyncRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFeatureViewSyncRequest(ref request, ref callSettings);
            return _callGetFeatureViewSync.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single FeatureViewSync.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FeatureViewSync> GetFeatureViewSyncAsync(GetFeatureViewSyncRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFeatureViewSyncRequest(ref request, ref callSettings);
            return _callGetFeatureViewSync.Async(request, callSettings);
        }

        /// <summary>
        /// Lists FeatureViewSyncs in a given FeatureView.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FeatureViewSync"/> resources.</returns>
        public override gax::PagedEnumerable<ListFeatureViewSyncsResponse, FeatureViewSync> ListFeatureViewSyncs(ListFeatureViewSyncsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFeatureViewSyncsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListFeatureViewSyncsRequest, ListFeatureViewSyncsResponse, FeatureViewSync>(_callListFeatureViewSyncs, request, callSettings);
        }

        /// <summary>
        /// Lists FeatureViewSyncs in a given FeatureView.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FeatureViewSync"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListFeatureViewSyncsResponse, FeatureViewSync> ListFeatureViewSyncsAsync(ListFeatureViewSyncsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFeatureViewSyncsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListFeatureViewSyncsRequest, ListFeatureViewSyncsResponse, FeatureViewSync>(_callListFeatureViewSyncs, request, callSettings);
        }
    }

    public partial class ListFeatureOnlineStoresRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListFeatureViewsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListFeatureViewSyncsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListFeatureOnlineStoresResponse : gaxgrpc::IPageResponse<FeatureOnlineStore>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<FeatureOnlineStore> GetEnumerator() => FeatureOnlineStores.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListFeatureViewsResponse : gaxgrpc::IPageResponse<FeatureView>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<FeatureView> GetEnumerator() => FeatureViews.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListFeatureViewSyncsResponse : gaxgrpc::IPageResponse<FeatureViewSync>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<FeatureViewSync> GetEnumerator() => FeatureViewSyncs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class FeatureOnlineStoreAdminService
    {
        public partial class FeatureOnlineStoreAdminServiceClient
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

    public static partial class FeatureOnlineStoreAdminService
    {
        public partial class FeatureOnlineStoreAdminServiceClient
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

            /// <summary>
            /// Creates a new instance of <see cref="gciv::IAMPolicy.IAMPolicyClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>
            /// A new <see cref="gciv::IAMPolicy.IAMPolicyClient"/> for the same target as this client.
            /// </returns>
            public virtual gciv::IAMPolicy.IAMPolicyClient CreateIAMPolicyClient() =>
                new gciv::IAMPolicy.IAMPolicyClient(CallInvoker);
        }
    }
}
