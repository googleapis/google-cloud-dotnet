// Copyright 2026 Google LLC
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

namespace Google.Ads.AdManager.V1
{
    /// <summary>Settings for <see cref="DaiAuthenticationKeyServiceClient"/> instances.</summary>
    public sealed partial class DaiAuthenticationKeyServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DaiAuthenticationKeyServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DaiAuthenticationKeyServiceSettings"/>.</returns>
        public static DaiAuthenticationKeyServiceSettings GetDefault() => new DaiAuthenticationKeyServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="DaiAuthenticationKeyServiceSettings"/> object with default settings.
        /// </summary>
        public DaiAuthenticationKeyServiceSettings()
        {
        }

        private DaiAuthenticationKeyServiceSettings(DaiAuthenticationKeyServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetDaiAuthenticationKeySettings = existing.GetDaiAuthenticationKeySettings;
            ListDaiAuthenticationKeysSettings = existing.ListDaiAuthenticationKeysSettings;
            CreateDaiAuthenticationKeySettings = existing.CreateDaiAuthenticationKeySettings;
            BatchCreateDaiAuthenticationKeysSettings = existing.BatchCreateDaiAuthenticationKeysSettings;
            UpdateDaiAuthenticationKeySettings = existing.UpdateDaiAuthenticationKeySettings;
            BatchUpdateDaiAuthenticationKeysSettings = existing.BatchUpdateDaiAuthenticationKeysSettings;
            BatchActivateDaiAuthenticationKeysSettings = existing.BatchActivateDaiAuthenticationKeysSettings;
            BatchDeactivateDaiAuthenticationKeysSettings = existing.BatchDeactivateDaiAuthenticationKeysSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DaiAuthenticationKeyServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DaiAuthenticationKeyServiceClient.GetDaiAuthenticationKey</c> and
        /// <c>DaiAuthenticationKeyServiceClient.GetDaiAuthenticationKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDaiAuthenticationKeySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DaiAuthenticationKeyServiceClient.ListDaiAuthenticationKeys</c> and
        /// <c>DaiAuthenticationKeyServiceClient.ListDaiAuthenticationKeysAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDaiAuthenticationKeysSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DaiAuthenticationKeyServiceClient.CreateDaiAuthenticationKey</c> and
        /// <c>DaiAuthenticationKeyServiceClient.CreateDaiAuthenticationKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateDaiAuthenticationKeySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DaiAuthenticationKeyServiceClient.BatchCreateDaiAuthenticationKeys</c> and
        /// <c>DaiAuthenticationKeyServiceClient.BatchCreateDaiAuthenticationKeysAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchCreateDaiAuthenticationKeysSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DaiAuthenticationKeyServiceClient.UpdateDaiAuthenticationKey</c> and
        /// <c>DaiAuthenticationKeyServiceClient.UpdateDaiAuthenticationKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDaiAuthenticationKeySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DaiAuthenticationKeyServiceClient.BatchUpdateDaiAuthenticationKeys</c> and
        /// <c>DaiAuthenticationKeyServiceClient.BatchUpdateDaiAuthenticationKeysAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchUpdateDaiAuthenticationKeysSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DaiAuthenticationKeyServiceClient.BatchActivateDaiAuthenticationKeys</c> and
        /// <c>DaiAuthenticationKeyServiceClient.BatchActivateDaiAuthenticationKeysAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchActivateDaiAuthenticationKeysSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DaiAuthenticationKeyServiceClient.BatchDeactivateDaiAuthenticationKeys</c> and
        /// <c>DaiAuthenticationKeyServiceClient.BatchDeactivateDaiAuthenticationKeysAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchDeactivateDaiAuthenticationKeysSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DaiAuthenticationKeyServiceSettings"/> object.</returns>
        public DaiAuthenticationKeyServiceSettings Clone() => new DaiAuthenticationKeyServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DaiAuthenticationKeyServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class DaiAuthenticationKeyServiceClientBuilder : gaxgrpc::ClientBuilderBase<DaiAuthenticationKeyServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DaiAuthenticationKeyServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DaiAuthenticationKeyServiceClientBuilder() : base(DaiAuthenticationKeyServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DaiAuthenticationKeyServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DaiAuthenticationKeyServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DaiAuthenticationKeyServiceClient Build()
        {
            DaiAuthenticationKeyServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DaiAuthenticationKeyServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DaiAuthenticationKeyServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DaiAuthenticationKeyServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DaiAuthenticationKeyServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DaiAuthenticationKeyServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DaiAuthenticationKeyServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DaiAuthenticationKeyServiceClient.ChannelPool;
    }

    /// <summary>DaiAuthenticationKeyService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `DaiAuthenticationKey` objects.
    /// </remarks>
    public abstract partial class DaiAuthenticationKeyServiceClient
    {
        /// <summary>
        /// The default endpoint for the DaiAuthenticationKeyService service, which is a host of
        /// "admanager.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default DaiAuthenticationKeyService scopes.</summary>
        /// <remarks>
        /// The default DaiAuthenticationKeyService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/admanager</description></item>
        /// <item><description>https://www.googleapis.com/auth/admanager.readonly</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/admanager",
            "https://www.googleapis.com/auth/admanager.readonly",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(DaiAuthenticationKeyService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DaiAuthenticationKeyServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="DaiAuthenticationKeyServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DaiAuthenticationKeyServiceClient"/>.</returns>
        public static stt::Task<DaiAuthenticationKeyServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DaiAuthenticationKeyServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DaiAuthenticationKeyServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="DaiAuthenticationKeyServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DaiAuthenticationKeyServiceClient"/>.</returns>
        public static DaiAuthenticationKeyServiceClient Create() => new DaiAuthenticationKeyServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DaiAuthenticationKeyServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DaiAuthenticationKeyServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DaiAuthenticationKeyServiceClient"/>.</returns>
        internal static DaiAuthenticationKeyServiceClient Create(grpccore::CallInvoker callInvoker, DaiAuthenticationKeyServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DaiAuthenticationKeyService.DaiAuthenticationKeyServiceClient grpcClient = new DaiAuthenticationKeyService.DaiAuthenticationKeyServiceClient(callInvoker);
            return new DaiAuthenticationKeyServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC DaiAuthenticationKeyService client</summary>
        public virtual DaiAuthenticationKeyService.DaiAuthenticationKeyServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `DaiAuthenticationKey` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DaiAuthenticationKey GetDaiAuthenticationKey(GetDaiAuthenticationKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `DaiAuthenticationKey` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DaiAuthenticationKey> GetDaiAuthenticationKeyAsync(GetDaiAuthenticationKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `DaiAuthenticationKey` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DaiAuthenticationKey> GetDaiAuthenticationKeyAsync(GetDaiAuthenticationKeyRequest request, st::CancellationToken cancellationToken) =>
            GetDaiAuthenticationKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `DaiAuthenticationKey` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the `DaiAuthenticationKey`.
        /// Format:
        /// `networks/{network_code}/daiAuthenticationKeys/{dai_authentication_key_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DaiAuthenticationKey GetDaiAuthenticationKey(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDaiAuthenticationKey(new GetDaiAuthenticationKeyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `DaiAuthenticationKey` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the `DaiAuthenticationKey`.
        /// Format:
        /// `networks/{network_code}/daiAuthenticationKeys/{dai_authentication_key_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DaiAuthenticationKey> GetDaiAuthenticationKeyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDaiAuthenticationKeyAsync(new GetDaiAuthenticationKeyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `DaiAuthenticationKey` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the `DaiAuthenticationKey`.
        /// Format:
        /// `networks/{network_code}/daiAuthenticationKeys/{dai_authentication_key_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DaiAuthenticationKey> GetDaiAuthenticationKeyAsync(string name, st::CancellationToken cancellationToken) =>
            GetDaiAuthenticationKeyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `DaiAuthenticationKey` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the `DaiAuthenticationKey`.
        /// Format:
        /// `networks/{network_code}/daiAuthenticationKeys/{dai_authentication_key_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DaiAuthenticationKey GetDaiAuthenticationKey(DaiAuthenticationKeyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDaiAuthenticationKey(new GetDaiAuthenticationKeyRequest
            {
                DaiAuthenticationKeyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `DaiAuthenticationKey` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the `DaiAuthenticationKey`.
        /// Format:
        /// `networks/{network_code}/daiAuthenticationKeys/{dai_authentication_key_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DaiAuthenticationKey> GetDaiAuthenticationKeyAsync(DaiAuthenticationKeyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDaiAuthenticationKeyAsync(new GetDaiAuthenticationKeyRequest
            {
                DaiAuthenticationKeyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `DaiAuthenticationKey` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the `DaiAuthenticationKey`.
        /// Format:
        /// `networks/{network_code}/daiAuthenticationKeys/{dai_authentication_key_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DaiAuthenticationKey> GetDaiAuthenticationKeyAsync(DaiAuthenticationKeyName name, st::CancellationToken cancellationToken) =>
            GetDaiAuthenticationKeyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DaiAuthenticationKey"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDaiAuthenticationKeysResponse, DaiAuthenticationKey> ListDaiAuthenticationKeys(ListDaiAuthenticationKeysRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DaiAuthenticationKey"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDaiAuthenticationKeysResponse, DaiAuthenticationKey> ListDaiAuthenticationKeysAsync(ListDaiAuthenticationKeysRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of DaiAuthenticationKeys.
        /// Format: `networks/{network_code}`
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
        /// <returns>A pageable sequence of <see cref="DaiAuthenticationKey"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDaiAuthenticationKeysResponse, DaiAuthenticationKey> ListDaiAuthenticationKeys(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDaiAuthenticationKeysRequest request = new ListDaiAuthenticationKeysRequest
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
            return ListDaiAuthenticationKeys(request, callSettings);
        }

        /// <summary>
        /// Lists `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of DaiAuthenticationKeys.
        /// Format: `networks/{network_code}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="DaiAuthenticationKey"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDaiAuthenticationKeysResponse, DaiAuthenticationKey> ListDaiAuthenticationKeysAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDaiAuthenticationKeysRequest request = new ListDaiAuthenticationKeysRequest
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
            return ListDaiAuthenticationKeysAsync(request, callSettings);
        }

        /// <summary>
        /// Lists `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of DaiAuthenticationKeys.
        /// Format: `networks/{network_code}`
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
        /// <returns>A pageable sequence of <see cref="DaiAuthenticationKey"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDaiAuthenticationKeysResponse, DaiAuthenticationKey> ListDaiAuthenticationKeys(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDaiAuthenticationKeysRequest request = new ListDaiAuthenticationKeysRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDaiAuthenticationKeys(request, callSettings);
        }

        /// <summary>
        /// Lists `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of DaiAuthenticationKeys.
        /// Format: `networks/{network_code}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="DaiAuthenticationKey"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDaiAuthenticationKeysResponse, DaiAuthenticationKey> ListDaiAuthenticationKeysAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDaiAuthenticationKeysRequest request = new ListDaiAuthenticationKeysRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDaiAuthenticationKeysAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a `DaiAuthenticationKey` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DaiAuthenticationKey CreateDaiAuthenticationKey(CreateDaiAuthenticationKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a `DaiAuthenticationKey` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DaiAuthenticationKey> CreateDaiAuthenticationKeyAsync(CreateDaiAuthenticationKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a `DaiAuthenticationKey` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DaiAuthenticationKey> CreateDaiAuthenticationKeyAsync(CreateDaiAuthenticationKeyRequest request, st::CancellationToken cancellationToken) =>
            CreateDaiAuthenticationKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a `DaiAuthenticationKey` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `DaiAuthenticationKey` will be
        /// created. Format: `networks/{network_code}`
        /// </param>
        /// <param name="daiAuthenticationKey">
        /// Required. The `DaiAuthenticationKey` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DaiAuthenticationKey CreateDaiAuthenticationKey(string parent, DaiAuthenticationKey daiAuthenticationKey, gaxgrpc::CallSettings callSettings = null) =>
            CreateDaiAuthenticationKey(new CreateDaiAuthenticationKeyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DaiAuthenticationKey = gax::GaxPreconditions.CheckNotNull(daiAuthenticationKey, nameof(daiAuthenticationKey)),
            }, callSettings);

        /// <summary>
        /// Creates a `DaiAuthenticationKey` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `DaiAuthenticationKey` will be
        /// created. Format: `networks/{network_code}`
        /// </param>
        /// <param name="daiAuthenticationKey">
        /// Required. The `DaiAuthenticationKey` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DaiAuthenticationKey> CreateDaiAuthenticationKeyAsync(string parent, DaiAuthenticationKey daiAuthenticationKey, gaxgrpc::CallSettings callSettings = null) =>
            CreateDaiAuthenticationKeyAsync(new CreateDaiAuthenticationKeyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DaiAuthenticationKey = gax::GaxPreconditions.CheckNotNull(daiAuthenticationKey, nameof(daiAuthenticationKey)),
            }, callSettings);

        /// <summary>
        /// Creates a `DaiAuthenticationKey` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `DaiAuthenticationKey` will be
        /// created. Format: `networks/{network_code}`
        /// </param>
        /// <param name="daiAuthenticationKey">
        /// Required. The `DaiAuthenticationKey` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DaiAuthenticationKey> CreateDaiAuthenticationKeyAsync(string parent, DaiAuthenticationKey daiAuthenticationKey, st::CancellationToken cancellationToken) =>
            CreateDaiAuthenticationKeyAsync(parent, daiAuthenticationKey, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a `DaiAuthenticationKey` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `DaiAuthenticationKey` will be
        /// created. Format: `networks/{network_code}`
        /// </param>
        /// <param name="daiAuthenticationKey">
        /// Required. The `DaiAuthenticationKey` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DaiAuthenticationKey CreateDaiAuthenticationKey(NetworkName parent, DaiAuthenticationKey daiAuthenticationKey, gaxgrpc::CallSettings callSettings = null) =>
            CreateDaiAuthenticationKey(new CreateDaiAuthenticationKeyRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DaiAuthenticationKey = gax::GaxPreconditions.CheckNotNull(daiAuthenticationKey, nameof(daiAuthenticationKey)),
            }, callSettings);

        /// <summary>
        /// Creates a `DaiAuthenticationKey` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `DaiAuthenticationKey` will be
        /// created. Format: `networks/{network_code}`
        /// </param>
        /// <param name="daiAuthenticationKey">
        /// Required. The `DaiAuthenticationKey` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DaiAuthenticationKey> CreateDaiAuthenticationKeyAsync(NetworkName parent, DaiAuthenticationKey daiAuthenticationKey, gaxgrpc::CallSettings callSettings = null) =>
            CreateDaiAuthenticationKeyAsync(new CreateDaiAuthenticationKeyRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DaiAuthenticationKey = gax::GaxPreconditions.CheckNotNull(daiAuthenticationKey, nameof(daiAuthenticationKey)),
            }, callSettings);

        /// <summary>
        /// Creates a `DaiAuthenticationKey` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `DaiAuthenticationKey` will be
        /// created. Format: `networks/{network_code}`
        /// </param>
        /// <param name="daiAuthenticationKey">
        /// Required. The `DaiAuthenticationKey` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DaiAuthenticationKey> CreateDaiAuthenticationKeyAsync(NetworkName parent, DaiAuthenticationKey daiAuthenticationKey, st::CancellationToken cancellationToken) =>
            CreateDaiAuthenticationKeyAsync(parent, daiAuthenticationKey, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch creates `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateDaiAuthenticationKeysResponse BatchCreateDaiAuthenticationKeys(BatchCreateDaiAuthenticationKeysRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch creates `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateDaiAuthenticationKeysResponse> BatchCreateDaiAuthenticationKeysAsync(BatchCreateDaiAuthenticationKeysRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch creates `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateDaiAuthenticationKeysResponse> BatchCreateDaiAuthenticationKeysAsync(BatchCreateDaiAuthenticationKeysRequest request, st::CancellationToken cancellationToken) =>
            BatchCreateDaiAuthenticationKeysAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch creates `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `DaiAuthenticationKeys` will be
        /// created. Format: `networks/{network_code}` The parent field in the
        /// CreateDaiAuthenticationKeyRequest must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The `DaiAuthenticationKey` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateDaiAuthenticationKeysResponse BatchCreateDaiAuthenticationKeys(string parent, scg::IEnumerable<CreateDaiAuthenticationKeyRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateDaiAuthenticationKeys(new BatchCreateDaiAuthenticationKeysRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch creates `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `DaiAuthenticationKeys` will be
        /// created. Format: `networks/{network_code}` The parent field in the
        /// CreateDaiAuthenticationKeyRequest must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The `DaiAuthenticationKey` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateDaiAuthenticationKeysResponse> BatchCreateDaiAuthenticationKeysAsync(string parent, scg::IEnumerable<CreateDaiAuthenticationKeyRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateDaiAuthenticationKeysAsync(new BatchCreateDaiAuthenticationKeysRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch creates `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `DaiAuthenticationKeys` will be
        /// created. Format: `networks/{network_code}` The parent field in the
        /// CreateDaiAuthenticationKeyRequest must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The `DaiAuthenticationKey` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateDaiAuthenticationKeysResponse> BatchCreateDaiAuthenticationKeysAsync(string parent, scg::IEnumerable<CreateDaiAuthenticationKeyRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateDaiAuthenticationKeysAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch creates `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `DaiAuthenticationKeys` will be
        /// created. Format: `networks/{network_code}` The parent field in the
        /// CreateDaiAuthenticationKeyRequest must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The `DaiAuthenticationKey` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateDaiAuthenticationKeysResponse BatchCreateDaiAuthenticationKeys(NetworkName parent, scg::IEnumerable<CreateDaiAuthenticationKeyRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateDaiAuthenticationKeys(new BatchCreateDaiAuthenticationKeysRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch creates `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `DaiAuthenticationKeys` will be
        /// created. Format: `networks/{network_code}` The parent field in the
        /// CreateDaiAuthenticationKeyRequest must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The `DaiAuthenticationKey` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateDaiAuthenticationKeysResponse> BatchCreateDaiAuthenticationKeysAsync(NetworkName parent, scg::IEnumerable<CreateDaiAuthenticationKeyRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateDaiAuthenticationKeysAsync(new BatchCreateDaiAuthenticationKeysRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch creates `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `DaiAuthenticationKeys` will be
        /// created. Format: `networks/{network_code}` The parent field in the
        /// CreateDaiAuthenticationKeyRequest must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The `DaiAuthenticationKey` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateDaiAuthenticationKeysResponse> BatchCreateDaiAuthenticationKeysAsync(NetworkName parent, scg::IEnumerable<CreateDaiAuthenticationKeyRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateDaiAuthenticationKeysAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a `DaiAuthenticationKey` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DaiAuthenticationKey UpdateDaiAuthenticationKey(UpdateDaiAuthenticationKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `DaiAuthenticationKey` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DaiAuthenticationKey> UpdateDaiAuthenticationKeyAsync(UpdateDaiAuthenticationKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `DaiAuthenticationKey` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DaiAuthenticationKey> UpdateDaiAuthenticationKeyAsync(UpdateDaiAuthenticationKeyRequest request, st::CancellationToken cancellationToken) =>
            UpdateDaiAuthenticationKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a `DaiAuthenticationKey` object.
        /// </summary>
        /// <param name="daiAuthenticationKey">
        /// Required. The `DaiAuthenticationKey` to update.
        /// 
        /// The `DaiAuthenticationKey`'s `name` is used to identify the
        /// `DaiAuthenticationKey` to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DaiAuthenticationKey UpdateDaiAuthenticationKey(DaiAuthenticationKey daiAuthenticationKey, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDaiAuthenticationKey(new UpdateDaiAuthenticationKeyRequest
            {
                DaiAuthenticationKey = gax::GaxPreconditions.CheckNotNull(daiAuthenticationKey, nameof(daiAuthenticationKey)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a `DaiAuthenticationKey` object.
        /// </summary>
        /// <param name="daiAuthenticationKey">
        /// Required. The `DaiAuthenticationKey` to update.
        /// 
        /// The `DaiAuthenticationKey`'s `name` is used to identify the
        /// `DaiAuthenticationKey` to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DaiAuthenticationKey> UpdateDaiAuthenticationKeyAsync(DaiAuthenticationKey daiAuthenticationKey, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDaiAuthenticationKeyAsync(new UpdateDaiAuthenticationKeyRequest
            {
                DaiAuthenticationKey = gax::GaxPreconditions.CheckNotNull(daiAuthenticationKey, nameof(daiAuthenticationKey)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a `DaiAuthenticationKey` object.
        /// </summary>
        /// <param name="daiAuthenticationKey">
        /// Required. The `DaiAuthenticationKey` to update.
        /// 
        /// The `DaiAuthenticationKey`'s `name` is used to identify the
        /// `DaiAuthenticationKey` to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DaiAuthenticationKey> UpdateDaiAuthenticationKeyAsync(DaiAuthenticationKey daiAuthenticationKey, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDaiAuthenticationKeyAsync(daiAuthenticationKey, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateDaiAuthenticationKeysResponse BatchUpdateDaiAuthenticationKeys(BatchUpdateDaiAuthenticationKeysRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch updates `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateDaiAuthenticationKeysResponse> BatchUpdateDaiAuthenticationKeysAsync(BatchUpdateDaiAuthenticationKeysRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch updates `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateDaiAuthenticationKeysResponse> BatchUpdateDaiAuthenticationKeysAsync(BatchUpdateDaiAuthenticationKeysRequest request, st::CancellationToken cancellationToken) =>
            BatchUpdateDaiAuthenticationKeysAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `DaiAuthenticationKeys` will be
        /// updated. Format: `networks/{network_code}` The parent field in the
        /// UpdateDaiAuthenticationKeyRequest must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The `DaiAuthenticationKey` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateDaiAuthenticationKeysResponse BatchUpdateDaiAuthenticationKeys(string parent, scg::IEnumerable<UpdateDaiAuthenticationKeyRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateDaiAuthenticationKeys(new BatchUpdateDaiAuthenticationKeysRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `DaiAuthenticationKeys` will be
        /// updated. Format: `networks/{network_code}` The parent field in the
        /// UpdateDaiAuthenticationKeyRequest must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The `DaiAuthenticationKey` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateDaiAuthenticationKeysResponse> BatchUpdateDaiAuthenticationKeysAsync(string parent, scg::IEnumerable<UpdateDaiAuthenticationKeyRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateDaiAuthenticationKeysAsync(new BatchUpdateDaiAuthenticationKeysRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `DaiAuthenticationKeys` will be
        /// updated. Format: `networks/{network_code}` The parent field in the
        /// UpdateDaiAuthenticationKeyRequest must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The `DaiAuthenticationKey` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateDaiAuthenticationKeysResponse> BatchUpdateDaiAuthenticationKeysAsync(string parent, scg::IEnumerable<UpdateDaiAuthenticationKeyRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateDaiAuthenticationKeysAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `DaiAuthenticationKeys` will be
        /// updated. Format: `networks/{network_code}` The parent field in the
        /// UpdateDaiAuthenticationKeyRequest must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The `DaiAuthenticationKey` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateDaiAuthenticationKeysResponse BatchUpdateDaiAuthenticationKeys(NetworkName parent, scg::IEnumerable<UpdateDaiAuthenticationKeyRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateDaiAuthenticationKeys(new BatchUpdateDaiAuthenticationKeysRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `DaiAuthenticationKeys` will be
        /// updated. Format: `networks/{network_code}` The parent field in the
        /// UpdateDaiAuthenticationKeyRequest must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The `DaiAuthenticationKey` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateDaiAuthenticationKeysResponse> BatchUpdateDaiAuthenticationKeysAsync(NetworkName parent, scg::IEnumerable<UpdateDaiAuthenticationKeyRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateDaiAuthenticationKeysAsync(new BatchUpdateDaiAuthenticationKeysRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `DaiAuthenticationKeys` will be
        /// updated. Format: `networks/{network_code}` The parent field in the
        /// UpdateDaiAuthenticationKeyRequest must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The `DaiAuthenticationKey` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateDaiAuthenticationKeysResponse> BatchUpdateDaiAuthenticationKeysAsync(NetworkName parent, scg::IEnumerable<UpdateDaiAuthenticationKeyRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateDaiAuthenticationKeysAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Activates a list of `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchActivateDaiAuthenticationKeysResponse BatchActivateDaiAuthenticationKeys(BatchActivateDaiAuthenticationKeysRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Activates a list of `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateDaiAuthenticationKeysResponse> BatchActivateDaiAuthenticationKeysAsync(BatchActivateDaiAuthenticationKeysRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Activates a list of `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateDaiAuthenticationKeysResponse> BatchActivateDaiAuthenticationKeysAsync(BatchActivateDaiAuthenticationKeysRequest request, st::CancellationToken cancellationToken) =>
            BatchActivateDaiAuthenticationKeysAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Activates a list of `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the DaiAuthenticationKey.
        /// Format:
        /// `networks/{network_code}/daiAuthenticationKeys/{dai_authentication_key}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchActivateDaiAuthenticationKeysResponse BatchActivateDaiAuthenticationKeys(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateDaiAuthenticationKeys(new BatchActivateDaiAuthenticationKeysRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Activates a list of `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the DaiAuthenticationKey.
        /// Format:
        /// `networks/{network_code}/daiAuthenticationKeys/{dai_authentication_key}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateDaiAuthenticationKeysResponse> BatchActivateDaiAuthenticationKeysAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateDaiAuthenticationKeysAsync(new BatchActivateDaiAuthenticationKeysRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Activates a list of `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the DaiAuthenticationKey.
        /// Format:
        /// `networks/{network_code}/daiAuthenticationKeys/{dai_authentication_key}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateDaiAuthenticationKeysResponse> BatchActivateDaiAuthenticationKeysAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchActivateDaiAuthenticationKeysAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Activates a list of `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the DaiAuthenticationKey.
        /// Format:
        /// `networks/{network_code}/daiAuthenticationKeys/{dai_authentication_key}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchActivateDaiAuthenticationKeysResponse BatchActivateDaiAuthenticationKeys(NetworkName parent, scg::IEnumerable<DaiAuthenticationKeyName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateDaiAuthenticationKeys(new BatchActivateDaiAuthenticationKeysRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DaiAuthenticationKeyNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Activates a list of `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the DaiAuthenticationKey.
        /// Format:
        /// `networks/{network_code}/daiAuthenticationKeys/{dai_authentication_key}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateDaiAuthenticationKeysResponse> BatchActivateDaiAuthenticationKeysAsync(NetworkName parent, scg::IEnumerable<DaiAuthenticationKeyName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateDaiAuthenticationKeysAsync(new BatchActivateDaiAuthenticationKeysRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DaiAuthenticationKeyNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Activates a list of `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the DaiAuthenticationKey.
        /// Format:
        /// `networks/{network_code}/daiAuthenticationKeys/{dai_authentication_key}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateDaiAuthenticationKeysResponse> BatchActivateDaiAuthenticationKeysAsync(NetworkName parent, scg::IEnumerable<DaiAuthenticationKeyName> names, st::CancellationToken cancellationToken) =>
            BatchActivateDaiAuthenticationKeysAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deactivates a list of `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDeactivateDaiAuthenticationKeysResponse BatchDeactivateDaiAuthenticationKeys(BatchDeactivateDaiAuthenticationKeysRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deactivates a list of `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateDaiAuthenticationKeysResponse> BatchDeactivateDaiAuthenticationKeysAsync(BatchDeactivateDaiAuthenticationKeysRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deactivates a list of `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateDaiAuthenticationKeysResponse> BatchDeactivateDaiAuthenticationKeysAsync(BatchDeactivateDaiAuthenticationKeysRequest request, st::CancellationToken cancellationToken) =>
            BatchDeactivateDaiAuthenticationKeysAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deactivates a list of `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the DaiAuthenticationKey.
        /// Format:
        /// `networks/{network_code}/daiAuthenticationKeys/{dai_authentication_key}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDeactivateDaiAuthenticationKeysResponse BatchDeactivateDaiAuthenticationKeys(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateDaiAuthenticationKeys(new BatchDeactivateDaiAuthenticationKeysRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deactivates a list of `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the DaiAuthenticationKey.
        /// Format:
        /// `networks/{network_code}/daiAuthenticationKeys/{dai_authentication_key}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateDaiAuthenticationKeysResponse> BatchDeactivateDaiAuthenticationKeysAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateDaiAuthenticationKeysAsync(new BatchDeactivateDaiAuthenticationKeysRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deactivates a list of `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the DaiAuthenticationKey.
        /// Format:
        /// `networks/{network_code}/daiAuthenticationKeys/{dai_authentication_key}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateDaiAuthenticationKeysResponse> BatchDeactivateDaiAuthenticationKeysAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchDeactivateDaiAuthenticationKeysAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deactivates a list of `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the DaiAuthenticationKey.
        /// Format:
        /// `networks/{network_code}/daiAuthenticationKeys/{dai_authentication_key}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDeactivateDaiAuthenticationKeysResponse BatchDeactivateDaiAuthenticationKeys(NetworkName parent, scg::IEnumerable<DaiAuthenticationKeyName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateDaiAuthenticationKeys(new BatchDeactivateDaiAuthenticationKeysRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DaiAuthenticationKeyNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deactivates a list of `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the DaiAuthenticationKey.
        /// Format:
        /// `networks/{network_code}/daiAuthenticationKeys/{dai_authentication_key}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateDaiAuthenticationKeysResponse> BatchDeactivateDaiAuthenticationKeysAsync(NetworkName parent, scg::IEnumerable<DaiAuthenticationKeyName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateDaiAuthenticationKeysAsync(new BatchDeactivateDaiAuthenticationKeysRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DaiAuthenticationKeyNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deactivates a list of `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the DaiAuthenticationKey.
        /// Format:
        /// `networks/{network_code}/daiAuthenticationKeys/{dai_authentication_key}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateDaiAuthenticationKeysResponse> BatchDeactivateDaiAuthenticationKeysAsync(NetworkName parent, scg::IEnumerable<DaiAuthenticationKeyName> names, st::CancellationToken cancellationToken) =>
            BatchDeactivateDaiAuthenticationKeysAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>DaiAuthenticationKeyService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `DaiAuthenticationKey` objects.
    /// </remarks>
    public sealed partial class DaiAuthenticationKeyServiceClientImpl : DaiAuthenticationKeyServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetDaiAuthenticationKeyRequest, DaiAuthenticationKey> _callGetDaiAuthenticationKey;

        private readonly gaxgrpc::ApiCall<ListDaiAuthenticationKeysRequest, ListDaiAuthenticationKeysResponse> _callListDaiAuthenticationKeys;

        private readonly gaxgrpc::ApiCall<CreateDaiAuthenticationKeyRequest, DaiAuthenticationKey> _callCreateDaiAuthenticationKey;

        private readonly gaxgrpc::ApiCall<BatchCreateDaiAuthenticationKeysRequest, BatchCreateDaiAuthenticationKeysResponse> _callBatchCreateDaiAuthenticationKeys;

        private readonly gaxgrpc::ApiCall<UpdateDaiAuthenticationKeyRequest, DaiAuthenticationKey> _callUpdateDaiAuthenticationKey;

        private readonly gaxgrpc::ApiCall<BatchUpdateDaiAuthenticationKeysRequest, BatchUpdateDaiAuthenticationKeysResponse> _callBatchUpdateDaiAuthenticationKeys;

        private readonly gaxgrpc::ApiCall<BatchActivateDaiAuthenticationKeysRequest, BatchActivateDaiAuthenticationKeysResponse> _callBatchActivateDaiAuthenticationKeys;

        private readonly gaxgrpc::ApiCall<BatchDeactivateDaiAuthenticationKeysRequest, BatchDeactivateDaiAuthenticationKeysResponse> _callBatchDeactivateDaiAuthenticationKeys;

        /// <summary>
        /// Constructs a client wrapper for the DaiAuthenticationKeyService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="DaiAuthenticationKeyServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DaiAuthenticationKeyServiceClientImpl(DaiAuthenticationKeyService.DaiAuthenticationKeyServiceClient grpcClient, DaiAuthenticationKeyServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DaiAuthenticationKeyServiceSettings effectiveSettings = settings ?? DaiAuthenticationKeyServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetDaiAuthenticationKey = clientHelper.BuildApiCall<GetDaiAuthenticationKeyRequest, DaiAuthenticationKey>("GetDaiAuthenticationKey", grpcClient.GetDaiAuthenticationKeyAsync, grpcClient.GetDaiAuthenticationKey, effectiveSettings.GetDaiAuthenticationKeySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDaiAuthenticationKey);
            Modify_GetDaiAuthenticationKeyApiCall(ref _callGetDaiAuthenticationKey);
            _callListDaiAuthenticationKeys = clientHelper.BuildApiCall<ListDaiAuthenticationKeysRequest, ListDaiAuthenticationKeysResponse>("ListDaiAuthenticationKeys", grpcClient.ListDaiAuthenticationKeysAsync, grpcClient.ListDaiAuthenticationKeys, effectiveSettings.ListDaiAuthenticationKeysSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDaiAuthenticationKeys);
            Modify_ListDaiAuthenticationKeysApiCall(ref _callListDaiAuthenticationKeys);
            _callCreateDaiAuthenticationKey = clientHelper.BuildApiCall<CreateDaiAuthenticationKeyRequest, DaiAuthenticationKey>("CreateDaiAuthenticationKey", grpcClient.CreateDaiAuthenticationKeyAsync, grpcClient.CreateDaiAuthenticationKey, effectiveSettings.CreateDaiAuthenticationKeySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDaiAuthenticationKey);
            Modify_CreateDaiAuthenticationKeyApiCall(ref _callCreateDaiAuthenticationKey);
            _callBatchCreateDaiAuthenticationKeys = clientHelper.BuildApiCall<BatchCreateDaiAuthenticationKeysRequest, BatchCreateDaiAuthenticationKeysResponse>("BatchCreateDaiAuthenticationKeys", grpcClient.BatchCreateDaiAuthenticationKeysAsync, grpcClient.BatchCreateDaiAuthenticationKeys, effectiveSettings.BatchCreateDaiAuthenticationKeysSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchCreateDaiAuthenticationKeys);
            Modify_BatchCreateDaiAuthenticationKeysApiCall(ref _callBatchCreateDaiAuthenticationKeys);
            _callUpdateDaiAuthenticationKey = clientHelper.BuildApiCall<UpdateDaiAuthenticationKeyRequest, DaiAuthenticationKey>("UpdateDaiAuthenticationKey", grpcClient.UpdateDaiAuthenticationKeyAsync, grpcClient.UpdateDaiAuthenticationKey, effectiveSettings.UpdateDaiAuthenticationKeySettings).WithGoogleRequestParam("dai_authentication_key.name", request => request.DaiAuthenticationKey?.Name);
            Modify_ApiCall(ref _callUpdateDaiAuthenticationKey);
            Modify_UpdateDaiAuthenticationKeyApiCall(ref _callUpdateDaiAuthenticationKey);
            _callBatchUpdateDaiAuthenticationKeys = clientHelper.BuildApiCall<BatchUpdateDaiAuthenticationKeysRequest, BatchUpdateDaiAuthenticationKeysResponse>("BatchUpdateDaiAuthenticationKeys", grpcClient.BatchUpdateDaiAuthenticationKeysAsync, grpcClient.BatchUpdateDaiAuthenticationKeys, effectiveSettings.BatchUpdateDaiAuthenticationKeysSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchUpdateDaiAuthenticationKeys);
            Modify_BatchUpdateDaiAuthenticationKeysApiCall(ref _callBatchUpdateDaiAuthenticationKeys);
            _callBatchActivateDaiAuthenticationKeys = clientHelper.BuildApiCall<BatchActivateDaiAuthenticationKeysRequest, BatchActivateDaiAuthenticationKeysResponse>("BatchActivateDaiAuthenticationKeys", grpcClient.BatchActivateDaiAuthenticationKeysAsync, grpcClient.BatchActivateDaiAuthenticationKeys, effectiveSettings.BatchActivateDaiAuthenticationKeysSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchActivateDaiAuthenticationKeys);
            Modify_BatchActivateDaiAuthenticationKeysApiCall(ref _callBatchActivateDaiAuthenticationKeys);
            _callBatchDeactivateDaiAuthenticationKeys = clientHelper.BuildApiCall<BatchDeactivateDaiAuthenticationKeysRequest, BatchDeactivateDaiAuthenticationKeysResponse>("BatchDeactivateDaiAuthenticationKeys", grpcClient.BatchDeactivateDaiAuthenticationKeysAsync, grpcClient.BatchDeactivateDaiAuthenticationKeys, effectiveSettings.BatchDeactivateDaiAuthenticationKeysSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchDeactivateDaiAuthenticationKeys);
            Modify_BatchDeactivateDaiAuthenticationKeysApiCall(ref _callBatchDeactivateDaiAuthenticationKeys);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetDaiAuthenticationKeyApiCall(ref gaxgrpc::ApiCall<GetDaiAuthenticationKeyRequest, DaiAuthenticationKey> call);

        partial void Modify_ListDaiAuthenticationKeysApiCall(ref gaxgrpc::ApiCall<ListDaiAuthenticationKeysRequest, ListDaiAuthenticationKeysResponse> call);

        partial void Modify_CreateDaiAuthenticationKeyApiCall(ref gaxgrpc::ApiCall<CreateDaiAuthenticationKeyRequest, DaiAuthenticationKey> call);

        partial void Modify_BatchCreateDaiAuthenticationKeysApiCall(ref gaxgrpc::ApiCall<BatchCreateDaiAuthenticationKeysRequest, BatchCreateDaiAuthenticationKeysResponse> call);

        partial void Modify_UpdateDaiAuthenticationKeyApiCall(ref gaxgrpc::ApiCall<UpdateDaiAuthenticationKeyRequest, DaiAuthenticationKey> call);

        partial void Modify_BatchUpdateDaiAuthenticationKeysApiCall(ref gaxgrpc::ApiCall<BatchUpdateDaiAuthenticationKeysRequest, BatchUpdateDaiAuthenticationKeysResponse> call);

        partial void Modify_BatchActivateDaiAuthenticationKeysApiCall(ref gaxgrpc::ApiCall<BatchActivateDaiAuthenticationKeysRequest, BatchActivateDaiAuthenticationKeysResponse> call);

        partial void Modify_BatchDeactivateDaiAuthenticationKeysApiCall(ref gaxgrpc::ApiCall<BatchDeactivateDaiAuthenticationKeysRequest, BatchDeactivateDaiAuthenticationKeysResponse> call);

        partial void OnConstruction(DaiAuthenticationKeyService.DaiAuthenticationKeyServiceClient grpcClient, DaiAuthenticationKeyServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DaiAuthenticationKeyService client</summary>
        public override DaiAuthenticationKeyService.DaiAuthenticationKeyServiceClient GrpcClient { get; }

        partial void Modify_GetDaiAuthenticationKeyRequest(ref GetDaiAuthenticationKeyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDaiAuthenticationKeysRequest(ref ListDaiAuthenticationKeysRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateDaiAuthenticationKeyRequest(ref CreateDaiAuthenticationKeyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchCreateDaiAuthenticationKeysRequest(ref BatchCreateDaiAuthenticationKeysRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDaiAuthenticationKeyRequest(ref UpdateDaiAuthenticationKeyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchUpdateDaiAuthenticationKeysRequest(ref BatchUpdateDaiAuthenticationKeysRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchActivateDaiAuthenticationKeysRequest(ref BatchActivateDaiAuthenticationKeysRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchDeactivateDaiAuthenticationKeysRequest(ref BatchDeactivateDaiAuthenticationKeysRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves a `DaiAuthenticationKey` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DaiAuthenticationKey GetDaiAuthenticationKey(GetDaiAuthenticationKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDaiAuthenticationKeyRequest(ref request, ref callSettings);
            return _callGetDaiAuthenticationKey.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a `DaiAuthenticationKey` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DaiAuthenticationKey> GetDaiAuthenticationKeyAsync(GetDaiAuthenticationKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDaiAuthenticationKeyRequest(ref request, ref callSettings);
            return _callGetDaiAuthenticationKey.Async(request, callSettings);
        }

        /// <summary>
        /// Lists `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DaiAuthenticationKey"/> resources.</returns>
        public override gax::PagedEnumerable<ListDaiAuthenticationKeysResponse, DaiAuthenticationKey> ListDaiAuthenticationKeys(ListDaiAuthenticationKeysRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDaiAuthenticationKeysRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDaiAuthenticationKeysRequest, ListDaiAuthenticationKeysResponse, DaiAuthenticationKey>(_callListDaiAuthenticationKeys, request, callSettings);
        }

        /// <summary>
        /// Lists `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DaiAuthenticationKey"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDaiAuthenticationKeysResponse, DaiAuthenticationKey> ListDaiAuthenticationKeysAsync(ListDaiAuthenticationKeysRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDaiAuthenticationKeysRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDaiAuthenticationKeysRequest, ListDaiAuthenticationKeysResponse, DaiAuthenticationKey>(_callListDaiAuthenticationKeys, request, callSettings);
        }

        /// <summary>
        /// Creates a `DaiAuthenticationKey` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DaiAuthenticationKey CreateDaiAuthenticationKey(CreateDaiAuthenticationKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDaiAuthenticationKeyRequest(ref request, ref callSettings);
            return _callCreateDaiAuthenticationKey.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a `DaiAuthenticationKey` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DaiAuthenticationKey> CreateDaiAuthenticationKeyAsync(CreateDaiAuthenticationKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDaiAuthenticationKeyRequest(ref request, ref callSettings);
            return _callCreateDaiAuthenticationKey.Async(request, callSettings);
        }

        /// <summary>
        /// Batch creates `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchCreateDaiAuthenticationKeysResponse BatchCreateDaiAuthenticationKeys(BatchCreateDaiAuthenticationKeysRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateDaiAuthenticationKeysRequest(ref request, ref callSettings);
            return _callBatchCreateDaiAuthenticationKeys.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch creates `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchCreateDaiAuthenticationKeysResponse> BatchCreateDaiAuthenticationKeysAsync(BatchCreateDaiAuthenticationKeysRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateDaiAuthenticationKeysRequest(ref request, ref callSettings);
            return _callBatchCreateDaiAuthenticationKeys.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a `DaiAuthenticationKey` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DaiAuthenticationKey UpdateDaiAuthenticationKey(UpdateDaiAuthenticationKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDaiAuthenticationKeyRequest(ref request, ref callSettings);
            return _callUpdateDaiAuthenticationKey.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a `DaiAuthenticationKey` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DaiAuthenticationKey> UpdateDaiAuthenticationKeyAsync(UpdateDaiAuthenticationKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDaiAuthenticationKeyRequest(ref request, ref callSettings);
            return _callUpdateDaiAuthenticationKey.Async(request, callSettings);
        }

        /// <summary>
        /// Batch updates `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchUpdateDaiAuthenticationKeysResponse BatchUpdateDaiAuthenticationKeys(BatchUpdateDaiAuthenticationKeysRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateDaiAuthenticationKeysRequest(ref request, ref callSettings);
            return _callBatchUpdateDaiAuthenticationKeys.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch updates `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchUpdateDaiAuthenticationKeysResponse> BatchUpdateDaiAuthenticationKeysAsync(BatchUpdateDaiAuthenticationKeysRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateDaiAuthenticationKeysRequest(ref request, ref callSettings);
            return _callBatchUpdateDaiAuthenticationKeys.Async(request, callSettings);
        }

        /// <summary>
        /// Activates a list of `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchActivateDaiAuthenticationKeysResponse BatchActivateDaiAuthenticationKeys(BatchActivateDaiAuthenticationKeysRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchActivateDaiAuthenticationKeysRequest(ref request, ref callSettings);
            return _callBatchActivateDaiAuthenticationKeys.Sync(request, callSettings);
        }

        /// <summary>
        /// Activates a list of `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchActivateDaiAuthenticationKeysResponse> BatchActivateDaiAuthenticationKeysAsync(BatchActivateDaiAuthenticationKeysRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchActivateDaiAuthenticationKeysRequest(ref request, ref callSettings);
            return _callBatchActivateDaiAuthenticationKeys.Async(request, callSettings);
        }

        /// <summary>
        /// Deactivates a list of `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchDeactivateDaiAuthenticationKeysResponse BatchDeactivateDaiAuthenticationKeys(BatchDeactivateDaiAuthenticationKeysRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeactivateDaiAuthenticationKeysRequest(ref request, ref callSettings);
            return _callBatchDeactivateDaiAuthenticationKeys.Sync(request, callSettings);
        }

        /// <summary>
        /// Deactivates a list of `DaiAuthenticationKey` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchDeactivateDaiAuthenticationKeysResponse> BatchDeactivateDaiAuthenticationKeysAsync(BatchDeactivateDaiAuthenticationKeysRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeactivateDaiAuthenticationKeysRequest(ref request, ref callSettings);
            return _callBatchDeactivateDaiAuthenticationKeys.Async(request, callSettings);
        }
    }

    public partial class ListDaiAuthenticationKeysRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDaiAuthenticationKeysResponse : gaxgrpc::IPageResponse<DaiAuthenticationKey>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DaiAuthenticationKey> GetEnumerator() => DaiAuthenticationKeys.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
