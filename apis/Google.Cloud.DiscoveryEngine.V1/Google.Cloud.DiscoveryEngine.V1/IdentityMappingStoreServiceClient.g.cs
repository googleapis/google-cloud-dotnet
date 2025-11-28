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

namespace Google.Cloud.DiscoveryEngine.V1
{
    /// <summary>Settings for <see cref="IdentityMappingStoreServiceClient"/> instances.</summary>
    public sealed partial class IdentityMappingStoreServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="IdentityMappingStoreServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="IdentityMappingStoreServiceSettings"/>.</returns>
        public static IdentityMappingStoreServiceSettings GetDefault() => new IdentityMappingStoreServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="IdentityMappingStoreServiceSettings"/> object with default settings.
        /// </summary>
        public IdentityMappingStoreServiceSettings()
        {
        }

        private IdentityMappingStoreServiceSettings(IdentityMappingStoreServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateIdentityMappingStoreSettings = existing.CreateIdentityMappingStoreSettings;
            GetIdentityMappingStoreSettings = existing.GetIdentityMappingStoreSettings;
            DeleteIdentityMappingStoreSettings = existing.DeleteIdentityMappingStoreSettings;
            DeleteIdentityMappingStoreOperationsSettings = existing.DeleteIdentityMappingStoreOperationsSettings.Clone();
            ImportIdentityMappingsSettings = existing.ImportIdentityMappingsSettings;
            ImportIdentityMappingsOperationsSettings = existing.ImportIdentityMappingsOperationsSettings.Clone();
            PurgeIdentityMappingsSettings = existing.PurgeIdentityMappingsSettings;
            PurgeIdentityMappingsOperationsSettings = existing.PurgeIdentityMappingsOperationsSettings.Clone();
            ListIdentityMappingsSettings = existing.ListIdentityMappingsSettings;
            ListIdentityMappingStoresSettings = existing.ListIdentityMappingStoresSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(IdentityMappingStoreServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IdentityMappingStoreServiceClient.CreateIdentityMappingStore</c> and
        /// <c>IdentityMappingStoreServiceClient.CreateIdentityMappingStoreAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateIdentityMappingStoreSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IdentityMappingStoreServiceClient.GetIdentityMappingStore</c> and
        /// <c>IdentityMappingStoreServiceClient.GetIdentityMappingStoreAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetIdentityMappingStoreSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IdentityMappingStoreServiceClient.DeleteIdentityMappingStore</c> and
        /// <c>IdentityMappingStoreServiceClient.DeleteIdentityMappingStoreAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteIdentityMappingStoreSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>IdentityMappingStoreServiceClient.DeleteIdentityMappingStore</c>
        ///  and <c>IdentityMappingStoreServiceClient.DeleteIdentityMappingStoreAsync</c>.
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
        public lro::OperationsSettings DeleteIdentityMappingStoreOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IdentityMappingStoreServiceClient.ImportIdentityMappings</c> and
        /// <c>IdentityMappingStoreServiceClient.ImportIdentityMappingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ImportIdentityMappingsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>IdentityMappingStoreServiceClient.ImportIdentityMappings</c>
        /// and <c>IdentityMappingStoreServiceClient.ImportIdentityMappingsAsync</c>.
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
        public lro::OperationsSettings ImportIdentityMappingsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IdentityMappingStoreServiceClient.PurgeIdentityMappings</c> and
        /// <c>IdentityMappingStoreServiceClient.PurgeIdentityMappingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PurgeIdentityMappingsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>IdentityMappingStoreServiceClient.PurgeIdentityMappings</c>
        /// and <c>IdentityMappingStoreServiceClient.PurgeIdentityMappingsAsync</c>.
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
        public lro::OperationsSettings PurgeIdentityMappingsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IdentityMappingStoreServiceClient.ListIdentityMappings</c> and
        /// <c>IdentityMappingStoreServiceClient.ListIdentityMappingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListIdentityMappingsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IdentityMappingStoreServiceClient.ListIdentityMappingStores</c> and
        /// <c>IdentityMappingStoreServiceClient.ListIdentityMappingStoresAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListIdentityMappingStoresSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="IdentityMappingStoreServiceSettings"/> object.</returns>
        public IdentityMappingStoreServiceSettings Clone() => new IdentityMappingStoreServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="IdentityMappingStoreServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class IdentityMappingStoreServiceClientBuilder : gaxgrpc::ClientBuilderBase<IdentityMappingStoreServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public IdentityMappingStoreServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public IdentityMappingStoreServiceClientBuilder() : base(IdentityMappingStoreServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref IdentityMappingStoreServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<IdentityMappingStoreServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override IdentityMappingStoreServiceClient Build()
        {
            IdentityMappingStoreServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<IdentityMappingStoreServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<IdentityMappingStoreServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private IdentityMappingStoreServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return IdentityMappingStoreServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<IdentityMappingStoreServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return IdentityMappingStoreServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => IdentityMappingStoreServiceClient.ChannelPool;
    }

    /// <summary>IdentityMappingStoreService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing Identity Mapping Stores.
    /// </remarks>
    public abstract partial class IdentityMappingStoreServiceClient
    {
        /// <summary>
        /// The default endpoint for the IdentityMappingStoreService service, which is a host of
        /// "discoveryengine.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "discoveryengine.googleapis.com:443";

        /// <summary>The default IdentityMappingStoreService scopes.</summary>
        /// <remarks>
        /// The default IdentityMappingStoreService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(IdentityMappingStoreService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="IdentityMappingStoreServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="IdentityMappingStoreServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="IdentityMappingStoreServiceClient"/>.</returns>
        public static stt::Task<IdentityMappingStoreServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new IdentityMappingStoreServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="IdentityMappingStoreServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="IdentityMappingStoreServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="IdentityMappingStoreServiceClient"/>.</returns>
        public static IdentityMappingStoreServiceClient Create() => new IdentityMappingStoreServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="IdentityMappingStoreServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="IdentityMappingStoreServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="IdentityMappingStoreServiceClient"/>.</returns>
        internal static IdentityMappingStoreServiceClient Create(grpccore::CallInvoker callInvoker, IdentityMappingStoreServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            IdentityMappingStoreService.IdentityMappingStoreServiceClient grpcClient = new IdentityMappingStoreService.IdentityMappingStoreServiceClient(callInvoker);
            return new IdentityMappingStoreServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC IdentityMappingStoreService client</summary>
        public virtual IdentityMappingStoreService.IdentityMappingStoreServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Identity Mapping Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IdentityMappingStore CreateIdentityMappingStore(CreateIdentityMappingStoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Identity Mapping Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IdentityMappingStore> CreateIdentityMappingStoreAsync(CreateIdentityMappingStoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Identity Mapping Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IdentityMappingStore> CreateIdentityMappingStoreAsync(CreateIdentityMappingStoreRequest request, st::CancellationToken cancellationToken) =>
            CreateIdentityMappingStoreAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Identity Mapping Store.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection resource name, such as
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="identityMappingStore">
        /// Required. The Identity Mapping Store to create.
        /// </param>
        /// <param name="identityMappingStoreId">
        /// Required. The ID of the Identity Mapping Store to create.
        /// 
        /// The ID must contain only letters (a-z, A-Z), numbers (0-9), underscores
        /// (_), and hyphens (-). The maximum length is 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IdentityMappingStore CreateIdentityMappingStore(string parent, IdentityMappingStore identityMappingStore, string identityMappingStoreId, gaxgrpc::CallSettings callSettings = null) =>
            CreateIdentityMappingStore(new CreateIdentityMappingStoreRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                IdentityMappingStoreId = gax::GaxPreconditions.CheckNotNullOrEmpty(identityMappingStoreId, nameof(identityMappingStoreId)),
                IdentityMappingStore = gax::GaxPreconditions.CheckNotNull(identityMappingStore, nameof(identityMappingStore)),
            }, callSettings);

        /// <summary>
        /// Creates a new Identity Mapping Store.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection resource name, such as
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="identityMappingStore">
        /// Required. The Identity Mapping Store to create.
        /// </param>
        /// <param name="identityMappingStoreId">
        /// Required. The ID of the Identity Mapping Store to create.
        /// 
        /// The ID must contain only letters (a-z, A-Z), numbers (0-9), underscores
        /// (_), and hyphens (-). The maximum length is 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IdentityMappingStore> CreateIdentityMappingStoreAsync(string parent, IdentityMappingStore identityMappingStore, string identityMappingStoreId, gaxgrpc::CallSettings callSettings = null) =>
            CreateIdentityMappingStoreAsync(new CreateIdentityMappingStoreRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                IdentityMappingStoreId = gax::GaxPreconditions.CheckNotNullOrEmpty(identityMappingStoreId, nameof(identityMappingStoreId)),
                IdentityMappingStore = gax::GaxPreconditions.CheckNotNull(identityMappingStore, nameof(identityMappingStore)),
            }, callSettings);

        /// <summary>
        /// Creates a new Identity Mapping Store.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection resource name, such as
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="identityMappingStore">
        /// Required. The Identity Mapping Store to create.
        /// </param>
        /// <param name="identityMappingStoreId">
        /// Required. The ID of the Identity Mapping Store to create.
        /// 
        /// The ID must contain only letters (a-z, A-Z), numbers (0-9), underscores
        /// (_), and hyphens (-). The maximum length is 63 characters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IdentityMappingStore> CreateIdentityMappingStoreAsync(string parent, IdentityMappingStore identityMappingStore, string identityMappingStoreId, st::CancellationToken cancellationToken) =>
            CreateIdentityMappingStoreAsync(parent, identityMappingStore, identityMappingStoreId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Identity Mapping Store.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection resource name, such as
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="identityMappingStore">
        /// Required. The Identity Mapping Store to create.
        /// </param>
        /// <param name="identityMappingStoreId">
        /// Required. The ID of the Identity Mapping Store to create.
        /// 
        /// The ID must contain only letters (a-z, A-Z), numbers (0-9), underscores
        /// (_), and hyphens (-). The maximum length is 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IdentityMappingStore CreateIdentityMappingStore(LocationName parent, IdentityMappingStore identityMappingStore, string identityMappingStoreId, gaxgrpc::CallSettings callSettings = null) =>
            CreateIdentityMappingStore(new CreateIdentityMappingStoreRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                IdentityMappingStoreId = gax::GaxPreconditions.CheckNotNullOrEmpty(identityMappingStoreId, nameof(identityMappingStoreId)),
                IdentityMappingStore = gax::GaxPreconditions.CheckNotNull(identityMappingStore, nameof(identityMappingStore)),
            }, callSettings);

        /// <summary>
        /// Creates a new Identity Mapping Store.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection resource name, such as
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="identityMappingStore">
        /// Required. The Identity Mapping Store to create.
        /// </param>
        /// <param name="identityMappingStoreId">
        /// Required. The ID of the Identity Mapping Store to create.
        /// 
        /// The ID must contain only letters (a-z, A-Z), numbers (0-9), underscores
        /// (_), and hyphens (-). The maximum length is 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IdentityMappingStore> CreateIdentityMappingStoreAsync(LocationName parent, IdentityMappingStore identityMappingStore, string identityMappingStoreId, gaxgrpc::CallSettings callSettings = null) =>
            CreateIdentityMappingStoreAsync(new CreateIdentityMappingStoreRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                IdentityMappingStoreId = gax::GaxPreconditions.CheckNotNullOrEmpty(identityMappingStoreId, nameof(identityMappingStoreId)),
                IdentityMappingStore = gax::GaxPreconditions.CheckNotNull(identityMappingStore, nameof(identityMappingStore)),
            }, callSettings);

        /// <summary>
        /// Creates a new Identity Mapping Store.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection resource name, such as
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="identityMappingStore">
        /// Required. The Identity Mapping Store to create.
        /// </param>
        /// <param name="identityMappingStoreId">
        /// Required. The ID of the Identity Mapping Store to create.
        /// 
        /// The ID must contain only letters (a-z, A-Z), numbers (0-9), underscores
        /// (_), and hyphens (-). The maximum length is 63 characters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IdentityMappingStore> CreateIdentityMappingStoreAsync(LocationName parent, IdentityMappingStore identityMappingStore, string identityMappingStoreId, st::CancellationToken cancellationToken) =>
            CreateIdentityMappingStoreAsync(parent, identityMappingStore, identityMappingStoreId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the Identity Mapping Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IdentityMappingStore GetIdentityMappingStore(GetIdentityMappingStoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the Identity Mapping Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IdentityMappingStore> GetIdentityMappingStoreAsync(GetIdentityMappingStoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the Identity Mapping Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IdentityMappingStore> GetIdentityMappingStoreAsync(GetIdentityMappingStoreRequest request, st::CancellationToken cancellationToken) =>
            GetIdentityMappingStoreAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the Identity Mapping Store.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Identity Mapping Store to get.
        /// Format:
        /// `projects/{project}/locations/{location}/identityMappingStores/{identityMappingStore}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IdentityMappingStore GetIdentityMappingStore(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetIdentityMappingStore(new GetIdentityMappingStoreRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the Identity Mapping Store.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Identity Mapping Store to get.
        /// Format:
        /// `projects/{project}/locations/{location}/identityMappingStores/{identityMappingStore}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IdentityMappingStore> GetIdentityMappingStoreAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetIdentityMappingStoreAsync(new GetIdentityMappingStoreRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the Identity Mapping Store.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Identity Mapping Store to get.
        /// Format:
        /// `projects/{project}/locations/{location}/identityMappingStores/{identityMappingStore}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IdentityMappingStore> GetIdentityMappingStoreAsync(string name, st::CancellationToken cancellationToken) =>
            GetIdentityMappingStoreAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the Identity Mapping Store.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Identity Mapping Store to get.
        /// Format:
        /// `projects/{project}/locations/{location}/identityMappingStores/{identityMappingStore}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IdentityMappingStore GetIdentityMappingStore(IdentityMappingStoreName name, gaxgrpc::CallSettings callSettings = null) =>
            GetIdentityMappingStore(new GetIdentityMappingStoreRequest
            {
                IdentityMappingStoreName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the Identity Mapping Store.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Identity Mapping Store to get.
        /// Format:
        /// `projects/{project}/locations/{location}/identityMappingStores/{identityMappingStore}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IdentityMappingStore> GetIdentityMappingStoreAsync(IdentityMappingStoreName name, gaxgrpc::CallSettings callSettings = null) =>
            GetIdentityMappingStoreAsync(new GetIdentityMappingStoreRequest
            {
                IdentityMappingStoreName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the Identity Mapping Store.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Identity Mapping Store to get.
        /// Format:
        /// `projects/{project}/locations/{location}/identityMappingStores/{identityMappingStore}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IdentityMappingStore> GetIdentityMappingStoreAsync(IdentityMappingStoreName name, st::CancellationToken cancellationToken) =>
            GetIdentityMappingStoreAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the Identity Mapping Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteIdentityMappingStoreMetadata> DeleteIdentityMappingStore(DeleteIdentityMappingStoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the Identity Mapping Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteIdentityMappingStoreMetadata>> DeleteIdentityMappingStoreAsync(DeleteIdentityMappingStoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the Identity Mapping Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteIdentityMappingStoreMetadata>> DeleteIdentityMappingStoreAsync(DeleteIdentityMappingStoreRequest request, st::CancellationToken cancellationToken) =>
            DeleteIdentityMappingStoreAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteIdentityMappingStore</c>.</summary>
        public virtual lro::OperationsClient DeleteIdentityMappingStoreOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteIdentityMappingStore</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteIdentityMappingStoreMetadata> PollOnceDeleteIdentityMappingStore(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteIdentityMappingStoreMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteIdentityMappingStoreOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteIdentityMappingStore</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteIdentityMappingStoreMetadata>> PollOnceDeleteIdentityMappingStoreAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteIdentityMappingStoreMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteIdentityMappingStoreOperationsClient, callSettings);

        /// <summary>
        /// Deletes the Identity Mapping Store.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Identity Mapping Store to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/identityMappingStores/{identityMappingStore}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteIdentityMappingStoreMetadata> DeleteIdentityMappingStore(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIdentityMappingStore(new DeleteIdentityMappingStoreRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the Identity Mapping Store.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Identity Mapping Store to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/identityMappingStores/{identityMappingStore}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteIdentityMappingStoreMetadata>> DeleteIdentityMappingStoreAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIdentityMappingStoreAsync(new DeleteIdentityMappingStoreRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the Identity Mapping Store.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Identity Mapping Store to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/identityMappingStores/{identityMappingStore}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteIdentityMappingStoreMetadata>> DeleteIdentityMappingStoreAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteIdentityMappingStoreAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the Identity Mapping Store.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Identity Mapping Store to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/identityMappingStores/{identityMappingStore}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteIdentityMappingStoreMetadata> DeleteIdentityMappingStore(IdentityMappingStoreName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIdentityMappingStore(new DeleteIdentityMappingStoreRequest
            {
                IdentityMappingStoreName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the Identity Mapping Store.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Identity Mapping Store to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/identityMappingStores/{identityMappingStore}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteIdentityMappingStoreMetadata>> DeleteIdentityMappingStoreAsync(IdentityMappingStoreName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIdentityMappingStoreAsync(new DeleteIdentityMappingStoreRequest
            {
                IdentityMappingStoreName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the Identity Mapping Store.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Identity Mapping Store to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/identityMappingStores/{identityMappingStore}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteIdentityMappingStoreMetadata>> DeleteIdentityMappingStoreAsync(IdentityMappingStoreName name, st::CancellationToken cancellationToken) =>
            DeleteIdentityMappingStoreAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports a list of Identity Mapping Entries to an Identity Mapping Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportIdentityMappingsResponse, IdentityMappingEntryOperationMetadata> ImportIdentityMappings(ImportIdentityMappingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports a list of Identity Mapping Entries to an Identity Mapping Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportIdentityMappingsResponse, IdentityMappingEntryOperationMetadata>> ImportIdentityMappingsAsync(ImportIdentityMappingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports a list of Identity Mapping Entries to an Identity Mapping Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportIdentityMappingsResponse, IdentityMappingEntryOperationMetadata>> ImportIdentityMappingsAsync(ImportIdentityMappingsRequest request, st::CancellationToken cancellationToken) =>
            ImportIdentityMappingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ImportIdentityMappings</c>.</summary>
        public virtual lro::OperationsClient ImportIdentityMappingsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ImportIdentityMappings</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ImportIdentityMappingsResponse, IdentityMappingEntryOperationMetadata> PollOnceImportIdentityMappings(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportIdentityMappingsResponse, IdentityMappingEntryOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportIdentityMappingsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ImportIdentityMappings</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ImportIdentityMappingsResponse, IdentityMappingEntryOperationMetadata>> PollOnceImportIdentityMappingsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportIdentityMappingsResponse, IdentityMappingEntryOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportIdentityMappingsOperationsClient, callSettings);

        /// <summary>
        /// Purges specified or all Identity Mapping Entries from an Identity Mapping
        /// Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, IdentityMappingEntryOperationMetadata> PurgeIdentityMappings(PurgeIdentityMappingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Purges specified or all Identity Mapping Entries from an Identity Mapping
        /// Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, IdentityMappingEntryOperationMetadata>> PurgeIdentityMappingsAsync(PurgeIdentityMappingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Purges specified or all Identity Mapping Entries from an Identity Mapping
        /// Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, IdentityMappingEntryOperationMetadata>> PurgeIdentityMappingsAsync(PurgeIdentityMappingsRequest request, st::CancellationToken cancellationToken) =>
            PurgeIdentityMappingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>PurgeIdentityMappings</c>.</summary>
        public virtual lro::OperationsClient PurgeIdentityMappingsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>PurgeIdentityMappings</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, IdentityMappingEntryOperationMetadata> PollOncePurgeIdentityMappings(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, IdentityMappingEntryOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PurgeIdentityMappingsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>PurgeIdentityMappings</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, IdentityMappingEntryOperationMetadata>> PollOncePurgeIdentityMappingsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, IdentityMappingEntryOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PurgeIdentityMappingsOperationsClient, callSettings);

        /// <summary>
        /// Lists Identity Mappings in an Identity Mapping Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="IdentityMappingEntry"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListIdentityMappingsResponse, IdentityMappingEntry> ListIdentityMappings(ListIdentityMappingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Identity Mappings in an Identity Mapping Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="IdentityMappingEntry"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListIdentityMappingsResponse, IdentityMappingEntry> ListIdentityMappingsAsync(ListIdentityMappingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all Identity Mapping Stores.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="IdentityMappingStore"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListIdentityMappingStoresResponse, IdentityMappingStore> ListIdentityMappingStores(ListIdentityMappingStoresRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all Identity Mapping Stores.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="IdentityMappingStore"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListIdentityMappingStoresResponse, IdentityMappingStore> ListIdentityMappingStoresAsync(ListIdentityMappingStoresRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all Identity Mapping Stores.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the Identity Mapping Stores to list.
        /// Format:
        /// `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="IdentityMappingStore"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListIdentityMappingStoresResponse, IdentityMappingStore> ListIdentityMappingStores(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListIdentityMappingStoresRequest request = new ListIdentityMappingStoresRequest
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
            return ListIdentityMappingStores(request, callSettings);
        }

        /// <summary>
        /// Lists all Identity Mapping Stores.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the Identity Mapping Stores to list.
        /// Format:
        /// `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="IdentityMappingStore"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListIdentityMappingStoresResponse, IdentityMappingStore> ListIdentityMappingStoresAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListIdentityMappingStoresRequest request = new ListIdentityMappingStoresRequest
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
            return ListIdentityMappingStoresAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all Identity Mapping Stores.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the Identity Mapping Stores to list.
        /// Format:
        /// `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="IdentityMappingStore"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListIdentityMappingStoresResponse, IdentityMappingStore> ListIdentityMappingStores(LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListIdentityMappingStoresRequest request = new ListIdentityMappingStoresRequest
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
            return ListIdentityMappingStores(request, callSettings);
        }

        /// <summary>
        /// Lists all Identity Mapping Stores.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the Identity Mapping Stores to list.
        /// Format:
        /// `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="IdentityMappingStore"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListIdentityMappingStoresResponse, IdentityMappingStore> ListIdentityMappingStoresAsync(LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListIdentityMappingStoresRequest request = new ListIdentityMappingStoresRequest
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
            return ListIdentityMappingStoresAsync(request, callSettings);
        }
    }

    /// <summary>IdentityMappingStoreService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing Identity Mapping Stores.
    /// </remarks>
    public sealed partial class IdentityMappingStoreServiceClientImpl : IdentityMappingStoreServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateIdentityMappingStoreRequest, IdentityMappingStore> _callCreateIdentityMappingStore;

        private readonly gaxgrpc::ApiCall<GetIdentityMappingStoreRequest, IdentityMappingStore> _callGetIdentityMappingStore;

        private readonly gaxgrpc::ApiCall<DeleteIdentityMappingStoreRequest, lro::Operation> _callDeleteIdentityMappingStore;

        private readonly gaxgrpc::ApiCall<ImportIdentityMappingsRequest, lro::Operation> _callImportIdentityMappings;

        private readonly gaxgrpc::ApiCall<PurgeIdentityMappingsRequest, lro::Operation> _callPurgeIdentityMappings;

        private readonly gaxgrpc::ApiCall<ListIdentityMappingsRequest, ListIdentityMappingsResponse> _callListIdentityMappings;

        private readonly gaxgrpc::ApiCall<ListIdentityMappingStoresRequest, ListIdentityMappingStoresResponse> _callListIdentityMappingStores;

        /// <summary>
        /// Constructs a client wrapper for the IdentityMappingStoreService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="IdentityMappingStoreServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public IdentityMappingStoreServiceClientImpl(IdentityMappingStoreService.IdentityMappingStoreServiceClient grpcClient, IdentityMappingStoreServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            IdentityMappingStoreServiceSettings effectiveSettings = settings ?? IdentityMappingStoreServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            DeleteIdentityMappingStoreOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteIdentityMappingStoreOperationsSettings, logger);
            ImportIdentityMappingsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ImportIdentityMappingsOperationsSettings, logger);
            PurgeIdentityMappingsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.PurgeIdentityMappingsOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callCreateIdentityMappingStore = clientHelper.BuildApiCall<CreateIdentityMappingStoreRequest, IdentityMappingStore>("CreateIdentityMappingStore", grpcClient.CreateIdentityMappingStoreAsync, grpcClient.CreateIdentityMappingStore, effectiveSettings.CreateIdentityMappingStoreSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateIdentityMappingStore);
            Modify_CreateIdentityMappingStoreApiCall(ref _callCreateIdentityMappingStore);
            _callGetIdentityMappingStore = clientHelper.BuildApiCall<GetIdentityMappingStoreRequest, IdentityMappingStore>("GetIdentityMappingStore", grpcClient.GetIdentityMappingStoreAsync, grpcClient.GetIdentityMappingStore, effectiveSettings.GetIdentityMappingStoreSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetIdentityMappingStore);
            Modify_GetIdentityMappingStoreApiCall(ref _callGetIdentityMappingStore);
            _callDeleteIdentityMappingStore = clientHelper.BuildApiCall<DeleteIdentityMappingStoreRequest, lro::Operation>("DeleteIdentityMappingStore", grpcClient.DeleteIdentityMappingStoreAsync, grpcClient.DeleteIdentityMappingStore, effectiveSettings.DeleteIdentityMappingStoreSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteIdentityMappingStore);
            Modify_DeleteIdentityMappingStoreApiCall(ref _callDeleteIdentityMappingStore);
            _callImportIdentityMappings = clientHelper.BuildApiCall<ImportIdentityMappingsRequest, lro::Operation>("ImportIdentityMappings", grpcClient.ImportIdentityMappingsAsync, grpcClient.ImportIdentityMappings, effectiveSettings.ImportIdentityMappingsSettings).WithGoogleRequestParam("identity_mapping_store", request => request.IdentityMappingStore);
            Modify_ApiCall(ref _callImportIdentityMappings);
            Modify_ImportIdentityMappingsApiCall(ref _callImportIdentityMappings);
            _callPurgeIdentityMappings = clientHelper.BuildApiCall<PurgeIdentityMappingsRequest, lro::Operation>("PurgeIdentityMappings", grpcClient.PurgeIdentityMappingsAsync, grpcClient.PurgeIdentityMappings, effectiveSettings.PurgeIdentityMappingsSettings).WithGoogleRequestParam("identity_mapping_store", request => request.IdentityMappingStore);
            Modify_ApiCall(ref _callPurgeIdentityMappings);
            Modify_PurgeIdentityMappingsApiCall(ref _callPurgeIdentityMappings);
            _callListIdentityMappings = clientHelper.BuildApiCall<ListIdentityMappingsRequest, ListIdentityMappingsResponse>("ListIdentityMappings", grpcClient.ListIdentityMappingsAsync, grpcClient.ListIdentityMappings, effectiveSettings.ListIdentityMappingsSettings).WithGoogleRequestParam("identity_mapping_store", request => request.IdentityMappingStore);
            Modify_ApiCall(ref _callListIdentityMappings);
            Modify_ListIdentityMappingsApiCall(ref _callListIdentityMappings);
            _callListIdentityMappingStores = clientHelper.BuildApiCall<ListIdentityMappingStoresRequest, ListIdentityMappingStoresResponse>("ListIdentityMappingStores", grpcClient.ListIdentityMappingStoresAsync, grpcClient.ListIdentityMappingStores, effectiveSettings.ListIdentityMappingStoresSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListIdentityMappingStores);
            Modify_ListIdentityMappingStoresApiCall(ref _callListIdentityMappingStores);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateIdentityMappingStoreApiCall(ref gaxgrpc::ApiCall<CreateIdentityMappingStoreRequest, IdentityMappingStore> call);

        partial void Modify_GetIdentityMappingStoreApiCall(ref gaxgrpc::ApiCall<GetIdentityMappingStoreRequest, IdentityMappingStore> call);

        partial void Modify_DeleteIdentityMappingStoreApiCall(ref gaxgrpc::ApiCall<DeleteIdentityMappingStoreRequest, lro::Operation> call);

        partial void Modify_ImportIdentityMappingsApiCall(ref gaxgrpc::ApiCall<ImportIdentityMappingsRequest, lro::Operation> call);

        partial void Modify_PurgeIdentityMappingsApiCall(ref gaxgrpc::ApiCall<PurgeIdentityMappingsRequest, lro::Operation> call);

        partial void Modify_ListIdentityMappingsApiCall(ref gaxgrpc::ApiCall<ListIdentityMappingsRequest, ListIdentityMappingsResponse> call);

        partial void Modify_ListIdentityMappingStoresApiCall(ref gaxgrpc::ApiCall<ListIdentityMappingStoresRequest, ListIdentityMappingStoresResponse> call);

        partial void OnConstruction(IdentityMappingStoreService.IdentityMappingStoreServiceClient grpcClient, IdentityMappingStoreServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC IdentityMappingStoreService client</summary>
        public override IdentityMappingStoreService.IdentityMappingStoreServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_CreateIdentityMappingStoreRequest(ref CreateIdentityMappingStoreRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIdentityMappingStoreRequest(ref GetIdentityMappingStoreRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteIdentityMappingStoreRequest(ref DeleteIdentityMappingStoreRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ImportIdentityMappingsRequest(ref ImportIdentityMappingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PurgeIdentityMappingsRequest(ref PurgeIdentityMappingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListIdentityMappingsRequest(ref ListIdentityMappingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListIdentityMappingStoresRequest(ref ListIdentityMappingStoresRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a new Identity Mapping Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override IdentityMappingStore CreateIdentityMappingStore(CreateIdentityMappingStoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateIdentityMappingStoreRequest(ref request, ref callSettings);
            return _callCreateIdentityMappingStore.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new Identity Mapping Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<IdentityMappingStore> CreateIdentityMappingStoreAsync(CreateIdentityMappingStoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateIdentityMappingStoreRequest(ref request, ref callSettings);
            return _callCreateIdentityMappingStore.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the Identity Mapping Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override IdentityMappingStore GetIdentityMappingStore(GetIdentityMappingStoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIdentityMappingStoreRequest(ref request, ref callSettings);
            return _callGetIdentityMappingStore.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the Identity Mapping Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<IdentityMappingStore> GetIdentityMappingStoreAsync(GetIdentityMappingStoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIdentityMappingStoreRequest(ref request, ref callSettings);
            return _callGetIdentityMappingStore.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteIdentityMappingStore</c>.</summary>
        public override lro::OperationsClient DeleteIdentityMappingStoreOperationsClient { get; }

        /// <summary>
        /// Deletes the Identity Mapping Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteIdentityMappingStoreMetadata> DeleteIdentityMappingStore(DeleteIdentityMappingStoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteIdentityMappingStoreRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteIdentityMappingStoreMetadata>(_callDeleteIdentityMappingStore.Sync(request, callSettings), DeleteIdentityMappingStoreOperationsClient);
        }

        /// <summary>
        /// Deletes the Identity Mapping Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteIdentityMappingStoreMetadata>> DeleteIdentityMappingStoreAsync(DeleteIdentityMappingStoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteIdentityMappingStoreRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteIdentityMappingStoreMetadata>(await _callDeleteIdentityMappingStore.Async(request, callSettings).ConfigureAwait(false), DeleteIdentityMappingStoreOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ImportIdentityMappings</c>.</summary>
        public override lro::OperationsClient ImportIdentityMappingsOperationsClient { get; }

        /// <summary>
        /// Imports a list of Identity Mapping Entries to an Identity Mapping Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ImportIdentityMappingsResponse, IdentityMappingEntryOperationMetadata> ImportIdentityMappings(ImportIdentityMappingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportIdentityMappingsRequest(ref request, ref callSettings);
            return new lro::Operation<ImportIdentityMappingsResponse, IdentityMappingEntryOperationMetadata>(_callImportIdentityMappings.Sync(request, callSettings), ImportIdentityMappingsOperationsClient);
        }

        /// <summary>
        /// Imports a list of Identity Mapping Entries to an Identity Mapping Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ImportIdentityMappingsResponse, IdentityMappingEntryOperationMetadata>> ImportIdentityMappingsAsync(ImportIdentityMappingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportIdentityMappingsRequest(ref request, ref callSettings);
            return new lro::Operation<ImportIdentityMappingsResponse, IdentityMappingEntryOperationMetadata>(await _callImportIdentityMappings.Async(request, callSettings).ConfigureAwait(false), ImportIdentityMappingsOperationsClient);
        }

        /// <summary>The long-running operations client for <c>PurgeIdentityMappings</c>.</summary>
        public override lro::OperationsClient PurgeIdentityMappingsOperationsClient { get; }

        /// <summary>
        /// Purges specified or all Identity Mapping Entries from an Identity Mapping
        /// Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, IdentityMappingEntryOperationMetadata> PurgeIdentityMappings(PurgeIdentityMappingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PurgeIdentityMappingsRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, IdentityMappingEntryOperationMetadata>(_callPurgeIdentityMappings.Sync(request, callSettings), PurgeIdentityMappingsOperationsClient);
        }

        /// <summary>
        /// Purges specified or all Identity Mapping Entries from an Identity Mapping
        /// Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, IdentityMappingEntryOperationMetadata>> PurgeIdentityMappingsAsync(PurgeIdentityMappingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PurgeIdentityMappingsRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, IdentityMappingEntryOperationMetadata>(await _callPurgeIdentityMappings.Async(request, callSettings).ConfigureAwait(false), PurgeIdentityMappingsOperationsClient);
        }

        /// <summary>
        /// Lists Identity Mappings in an Identity Mapping Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="IdentityMappingEntry"/> resources.</returns>
        public override gax::PagedEnumerable<ListIdentityMappingsResponse, IdentityMappingEntry> ListIdentityMappings(ListIdentityMappingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListIdentityMappingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListIdentityMappingsRequest, ListIdentityMappingsResponse, IdentityMappingEntry>(_callListIdentityMappings, request, callSettings);
        }

        /// <summary>
        /// Lists Identity Mappings in an Identity Mapping Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="IdentityMappingEntry"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListIdentityMappingsResponse, IdentityMappingEntry> ListIdentityMappingsAsync(ListIdentityMappingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListIdentityMappingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListIdentityMappingsRequest, ListIdentityMappingsResponse, IdentityMappingEntry>(_callListIdentityMappings, request, callSettings);
        }

        /// <summary>
        /// Lists all Identity Mapping Stores.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="IdentityMappingStore"/> resources.</returns>
        public override gax::PagedEnumerable<ListIdentityMappingStoresResponse, IdentityMappingStore> ListIdentityMappingStores(ListIdentityMappingStoresRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListIdentityMappingStoresRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListIdentityMappingStoresRequest, ListIdentityMappingStoresResponse, IdentityMappingStore>(_callListIdentityMappingStores, request, callSettings);
        }

        /// <summary>
        /// Lists all Identity Mapping Stores.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="IdentityMappingStore"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListIdentityMappingStoresResponse, IdentityMappingStore> ListIdentityMappingStoresAsync(ListIdentityMappingStoresRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListIdentityMappingStoresRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListIdentityMappingStoresRequest, ListIdentityMappingStoresResponse, IdentityMappingStore>(_callListIdentityMappingStores, request, callSettings);
        }
    }

    public partial class ListIdentityMappingsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListIdentityMappingStoresRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListIdentityMappingsResponse : gaxgrpc::IPageResponse<IdentityMappingEntry>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<IdentityMappingEntry> GetEnumerator() => IdentityMappingEntries.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListIdentityMappingStoresResponse : gaxgrpc::IPageResponse<IdentityMappingStore>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<IdentityMappingStore> GetEnumerator() => IdentityMappingStores.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class IdentityMappingStoreService
    {
        public partial class IdentityMappingStoreServiceClient
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

    public static partial class IdentityMappingStoreService
    {
        public partial class IdentityMappingStoreServiceClient
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
