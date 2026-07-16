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
    /// <summary>Settings for <see cref="CdnConfigServiceClient"/> instances.</summary>
    public sealed partial class CdnConfigServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CdnConfigServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CdnConfigServiceSettings"/>.</returns>
        public static CdnConfigServiceSettings GetDefault() => new CdnConfigServiceSettings();

        /// <summary>Constructs a new <see cref="CdnConfigServiceSettings"/> object with default settings.</summary>
        public CdnConfigServiceSettings()
        {
        }

        private CdnConfigServiceSettings(CdnConfigServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetCdnConfigSettings = existing.GetCdnConfigSettings;
            ListCdnConfigsSettings = existing.ListCdnConfigsSettings;
            CreateCdnConfigSettings = existing.CreateCdnConfigSettings;
            BatchCreateCdnConfigsSettings = existing.BatchCreateCdnConfigsSettings;
            UpdateCdnConfigSettings = existing.UpdateCdnConfigSettings;
            BatchUpdateCdnConfigsSettings = existing.BatchUpdateCdnConfigsSettings;
            BatchActivateCdnConfigsSettings = existing.BatchActivateCdnConfigsSettings;
            BatchArchiveCdnConfigsSettings = existing.BatchArchiveCdnConfigsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CdnConfigServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CdnConfigServiceClient.GetCdnConfig</c> and <c>CdnConfigServiceClient.GetCdnConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCdnConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CdnConfigServiceClient.ListCdnConfigs</c> and <c>CdnConfigServiceClient.ListCdnConfigsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListCdnConfigsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CdnConfigServiceClient.CreateCdnConfig</c> and <c>CdnConfigServiceClient.CreateCdnConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateCdnConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CdnConfigServiceClient.BatchCreateCdnConfigs</c> and <c>CdnConfigServiceClient.BatchCreateCdnConfigsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchCreateCdnConfigsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CdnConfigServiceClient.UpdateCdnConfig</c> and <c>CdnConfigServiceClient.UpdateCdnConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateCdnConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CdnConfigServiceClient.BatchUpdateCdnConfigs</c> and <c>CdnConfigServiceClient.BatchUpdateCdnConfigsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchUpdateCdnConfigsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CdnConfigServiceClient.BatchActivateCdnConfigs</c> and
        /// <c>CdnConfigServiceClient.BatchActivateCdnConfigsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchActivateCdnConfigsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CdnConfigServiceClient.BatchArchiveCdnConfigs</c> and
        /// <c>CdnConfigServiceClient.BatchArchiveCdnConfigsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchArchiveCdnConfigsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CdnConfigServiceSettings"/> object.</returns>
        public CdnConfigServiceSettings Clone() => new CdnConfigServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CdnConfigServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class CdnConfigServiceClientBuilder : gaxgrpc::ClientBuilderBase<CdnConfigServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CdnConfigServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CdnConfigServiceClientBuilder() : base(CdnConfigServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CdnConfigServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CdnConfigServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CdnConfigServiceClient Build()
        {
            CdnConfigServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CdnConfigServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CdnConfigServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CdnConfigServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CdnConfigServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CdnConfigServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CdnConfigServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CdnConfigServiceClient.ChannelPool;
    }

    /// <summary>CdnConfigService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `CdnConfig` objects.
    /// </remarks>
    public abstract partial class CdnConfigServiceClient
    {
        /// <summary>
        /// The default endpoint for the CdnConfigService service, which is a host of "admanager.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default CdnConfigService scopes.</summary>
        /// <remarks>
        /// The default CdnConfigService scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CdnConfigService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CdnConfigServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CdnConfigServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CdnConfigServiceClient"/>.</returns>
        public static stt::Task<CdnConfigServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CdnConfigServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CdnConfigServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CdnConfigServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CdnConfigServiceClient"/>.</returns>
        public static CdnConfigServiceClient Create() => new CdnConfigServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CdnConfigServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CdnConfigServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CdnConfigServiceClient"/>.</returns>
        internal static CdnConfigServiceClient Create(grpccore::CallInvoker callInvoker, CdnConfigServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CdnConfigService.CdnConfigServiceClient grpcClient = new CdnConfigService.CdnConfigServiceClient(callInvoker);
            return new CdnConfigServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CdnConfigService client</summary>
        public virtual CdnConfigService.CdnConfigServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `CdnConfig` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CdnConfig GetCdnConfig(GetCdnConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `CdnConfig` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CdnConfig> GetCdnConfigAsync(GetCdnConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `CdnConfig` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CdnConfig> GetCdnConfigAsync(GetCdnConfigRequest request, st::CancellationToken cancellationToken) =>
            GetCdnConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `CdnConfig` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CdnConfig.
        /// Format: `networks/{network_code}/cdnConfigs/{cdn_config_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CdnConfig GetCdnConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCdnConfig(new GetCdnConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `CdnConfig` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CdnConfig.
        /// Format: `networks/{network_code}/cdnConfigs/{cdn_config_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CdnConfig> GetCdnConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCdnConfigAsync(new GetCdnConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `CdnConfig` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CdnConfig.
        /// Format: `networks/{network_code}/cdnConfigs/{cdn_config_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CdnConfig> GetCdnConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetCdnConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `CdnConfig` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CdnConfig.
        /// Format: `networks/{network_code}/cdnConfigs/{cdn_config_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CdnConfig GetCdnConfig(CdnConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCdnConfig(new GetCdnConfigRequest
            {
                CdnConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `CdnConfig` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CdnConfig.
        /// Format: `networks/{network_code}/cdnConfigs/{cdn_config_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CdnConfig> GetCdnConfigAsync(CdnConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCdnConfigAsync(new GetCdnConfigRequest
            {
                CdnConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `CdnConfig` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CdnConfig.
        /// Format: `networks/{network_code}/cdnConfigs/{cdn_config_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CdnConfig> GetCdnConfigAsync(CdnConfigName name, st::CancellationToken cancellationToken) =>
            GetCdnConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists `CdnConfig` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CdnConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCdnConfigsResponse, CdnConfig> ListCdnConfigs(ListCdnConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `CdnConfig` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CdnConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCdnConfigsResponse, CdnConfig> ListCdnConfigsAsync(ListCdnConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `CdnConfig` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CdnConfigs.
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
        /// <returns>A pageable sequence of <see cref="CdnConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCdnConfigsResponse, CdnConfig> ListCdnConfigs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCdnConfigsRequest request = new ListCdnConfigsRequest
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
            return ListCdnConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists `CdnConfig` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CdnConfigs.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CdnConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCdnConfigsResponse, CdnConfig> ListCdnConfigsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCdnConfigsRequest request = new ListCdnConfigsRequest
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
            return ListCdnConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists `CdnConfig` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CdnConfigs.
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
        /// <returns>A pageable sequence of <see cref="CdnConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCdnConfigsResponse, CdnConfig> ListCdnConfigs(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCdnConfigsRequest request = new ListCdnConfigsRequest
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
            return ListCdnConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists `CdnConfig` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CdnConfigs.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CdnConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCdnConfigsResponse, CdnConfig> ListCdnConfigsAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCdnConfigsRequest request = new ListCdnConfigsRequest
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
            return ListCdnConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a `CdnConfig` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CdnConfig CreateCdnConfig(CreateCdnConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a `CdnConfig` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CdnConfig> CreateCdnConfigAsync(CreateCdnConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a `CdnConfig` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CdnConfig> CreateCdnConfigAsync(CreateCdnConfigRequest request, st::CancellationToken cancellationToken) =>
            CreateCdnConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a `CdnConfig` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `CdnConfig` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="cdnConfig">
        /// Required. The `CdnConfig` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CdnConfig CreateCdnConfig(string parent, CdnConfig cdnConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateCdnConfig(new CreateCdnConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CdnConfig = gax::GaxPreconditions.CheckNotNull(cdnConfig, nameof(cdnConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a `CdnConfig` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `CdnConfig` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="cdnConfig">
        /// Required. The `CdnConfig` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CdnConfig> CreateCdnConfigAsync(string parent, CdnConfig cdnConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateCdnConfigAsync(new CreateCdnConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CdnConfig = gax::GaxPreconditions.CheckNotNull(cdnConfig, nameof(cdnConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a `CdnConfig` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `CdnConfig` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="cdnConfig">
        /// Required. The `CdnConfig` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CdnConfig> CreateCdnConfigAsync(string parent, CdnConfig cdnConfig, st::CancellationToken cancellationToken) =>
            CreateCdnConfigAsync(parent, cdnConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a `CdnConfig` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `CdnConfig` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="cdnConfig">
        /// Required. The `CdnConfig` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CdnConfig CreateCdnConfig(NetworkName parent, CdnConfig cdnConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateCdnConfig(new CreateCdnConfigRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CdnConfig = gax::GaxPreconditions.CheckNotNull(cdnConfig, nameof(cdnConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a `CdnConfig` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `CdnConfig` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="cdnConfig">
        /// Required. The `CdnConfig` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CdnConfig> CreateCdnConfigAsync(NetworkName parent, CdnConfig cdnConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateCdnConfigAsync(new CreateCdnConfigRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CdnConfig = gax::GaxPreconditions.CheckNotNull(cdnConfig, nameof(cdnConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a `CdnConfig` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `CdnConfig` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="cdnConfig">
        /// Required. The `CdnConfig` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CdnConfig> CreateCdnConfigAsync(NetworkName parent, CdnConfig cdnConfig, st::CancellationToken cancellationToken) =>
            CreateCdnConfigAsync(parent, cdnConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch creates `CdnConfig` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateCdnConfigsResponse BatchCreateCdnConfigs(BatchCreateCdnConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch creates `CdnConfig` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateCdnConfigsResponse> BatchCreateCdnConfigsAsync(BatchCreateCdnConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch creates `CdnConfig` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateCdnConfigsResponse> BatchCreateCdnConfigsAsync(BatchCreateCdnConfigsRequest request, st::CancellationToken cancellationToken) =>
            BatchCreateCdnConfigsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch creates `CdnConfig` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `CdnConfigs` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateCdnConfigRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `CdnConfig` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateCdnConfigsResponse BatchCreateCdnConfigs(string parent, scg::IEnumerable<CreateCdnConfigRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateCdnConfigs(new BatchCreateCdnConfigsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch creates `CdnConfig` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `CdnConfigs` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateCdnConfigRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `CdnConfig` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateCdnConfigsResponse> BatchCreateCdnConfigsAsync(string parent, scg::IEnumerable<CreateCdnConfigRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateCdnConfigsAsync(new BatchCreateCdnConfigsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch creates `CdnConfig` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `CdnConfigs` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateCdnConfigRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `CdnConfig` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateCdnConfigsResponse> BatchCreateCdnConfigsAsync(string parent, scg::IEnumerable<CreateCdnConfigRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateCdnConfigsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch creates `CdnConfig` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `CdnConfigs` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateCdnConfigRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `CdnConfig` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateCdnConfigsResponse BatchCreateCdnConfigs(NetworkName parent, scg::IEnumerable<CreateCdnConfigRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateCdnConfigs(new BatchCreateCdnConfigsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch creates `CdnConfig` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `CdnConfigs` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateCdnConfigRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `CdnConfig` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateCdnConfigsResponse> BatchCreateCdnConfigsAsync(NetworkName parent, scg::IEnumerable<CreateCdnConfigRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateCdnConfigsAsync(new BatchCreateCdnConfigsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch creates `CdnConfig` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `CdnConfigs` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateCdnConfigRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `CdnConfig` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateCdnConfigsResponse> BatchCreateCdnConfigsAsync(NetworkName parent, scg::IEnumerable<CreateCdnConfigRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateCdnConfigsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a `CdnConfig` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CdnConfig UpdateCdnConfig(UpdateCdnConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `CdnConfig` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CdnConfig> UpdateCdnConfigAsync(UpdateCdnConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `CdnConfig` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CdnConfig> UpdateCdnConfigAsync(UpdateCdnConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateCdnConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a `CdnConfig` object.
        /// </summary>
        /// <param name="cdnConfig">
        /// Required. The `CdnConfig` to update.
        /// 
        /// The `CdnConfig`'s `name` is used to identify the `CdnConfig`
        /// to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CdnConfig UpdateCdnConfig(CdnConfig cdnConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCdnConfig(new UpdateCdnConfigRequest
            {
                CdnConfig = gax::GaxPreconditions.CheckNotNull(cdnConfig, nameof(cdnConfig)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a `CdnConfig` object.
        /// </summary>
        /// <param name="cdnConfig">
        /// Required. The `CdnConfig` to update.
        /// 
        /// The `CdnConfig`'s `name` is used to identify the `CdnConfig`
        /// to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CdnConfig> UpdateCdnConfigAsync(CdnConfig cdnConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCdnConfigAsync(new UpdateCdnConfigRequest
            {
                CdnConfig = gax::GaxPreconditions.CheckNotNull(cdnConfig, nameof(cdnConfig)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a `CdnConfig` object.
        /// </summary>
        /// <param name="cdnConfig">
        /// Required. The `CdnConfig` to update.
        /// 
        /// The `CdnConfig`'s `name` is used to identify the `CdnConfig`
        /// to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CdnConfig> UpdateCdnConfigAsync(CdnConfig cdnConfig, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateCdnConfigAsync(cdnConfig, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `CdnConfig` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateCdnConfigsResponse BatchUpdateCdnConfigs(BatchUpdateCdnConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch updates `CdnConfig` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateCdnConfigsResponse> BatchUpdateCdnConfigsAsync(BatchUpdateCdnConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch updates `CdnConfig` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateCdnConfigsResponse> BatchUpdateCdnConfigsAsync(BatchUpdateCdnConfigsRequest request, st::CancellationToken cancellationToken) =>
            BatchUpdateCdnConfigsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `CdnConfig` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `CdnConfigs` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateCdnConfigRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `CdnConfig` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateCdnConfigsResponse BatchUpdateCdnConfigs(string parent, scg::IEnumerable<UpdateCdnConfigRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateCdnConfigs(new BatchUpdateCdnConfigsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `CdnConfig` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `CdnConfigs` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateCdnConfigRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `CdnConfig` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateCdnConfigsResponse> BatchUpdateCdnConfigsAsync(string parent, scg::IEnumerable<UpdateCdnConfigRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateCdnConfigsAsync(new BatchUpdateCdnConfigsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `CdnConfig` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `CdnConfigs` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateCdnConfigRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `CdnConfig` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateCdnConfigsResponse> BatchUpdateCdnConfigsAsync(string parent, scg::IEnumerable<UpdateCdnConfigRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateCdnConfigsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `CdnConfig` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `CdnConfigs` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateCdnConfigRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `CdnConfig` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateCdnConfigsResponse BatchUpdateCdnConfigs(NetworkName parent, scg::IEnumerable<UpdateCdnConfigRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateCdnConfigs(new BatchUpdateCdnConfigsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `CdnConfig` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `CdnConfigs` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateCdnConfigRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `CdnConfig` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateCdnConfigsResponse> BatchUpdateCdnConfigsAsync(NetworkName parent, scg::IEnumerable<UpdateCdnConfigRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateCdnConfigsAsync(new BatchUpdateCdnConfigsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `CdnConfig` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `CdnConfigs` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateCdnConfigRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `CdnConfig` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateCdnConfigsResponse> BatchUpdateCdnConfigsAsync(NetworkName parent, scg::IEnumerable<UpdateCdnConfigRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateCdnConfigsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch activates `CdnConfig` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchActivateCdnConfigsResponse BatchActivateCdnConfigs(BatchActivateCdnConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch activates `CdnConfig` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateCdnConfigsResponse> BatchActivateCdnConfigsAsync(BatchActivateCdnConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch activates `CdnConfig` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateCdnConfigsResponse> BatchActivateCdnConfigsAsync(BatchActivateCdnConfigsRequest request, st::CancellationToken cancellationToken) =>
            BatchActivateCdnConfigsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch activates `CdnConfig` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `CdnConfig` objects to activate.
        /// Format: `networks/{network_code}/cdnConfigs/{cdn_config_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchActivateCdnConfigsResponse BatchActivateCdnConfigs(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateCdnConfigs(new BatchActivateCdnConfigsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch activates `CdnConfig` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `CdnConfig` objects to activate.
        /// Format: `networks/{network_code}/cdnConfigs/{cdn_config_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateCdnConfigsResponse> BatchActivateCdnConfigsAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateCdnConfigsAsync(new BatchActivateCdnConfigsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch activates `CdnConfig` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `CdnConfig` objects to activate.
        /// Format: `networks/{network_code}/cdnConfigs/{cdn_config_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateCdnConfigsResponse> BatchActivateCdnConfigsAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchActivateCdnConfigsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch activates `CdnConfig` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `CdnConfig` objects to activate.
        /// Format: `networks/{network_code}/cdnConfigs/{cdn_config_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchActivateCdnConfigsResponse BatchActivateCdnConfigs(NetworkName parent, scg::IEnumerable<CdnConfigName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateCdnConfigs(new BatchActivateCdnConfigsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CdnConfigNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch activates `CdnConfig` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `CdnConfig` objects to activate.
        /// Format: `networks/{network_code}/cdnConfigs/{cdn_config_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateCdnConfigsResponse> BatchActivateCdnConfigsAsync(NetworkName parent, scg::IEnumerable<CdnConfigName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateCdnConfigsAsync(new BatchActivateCdnConfigsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CdnConfigNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch activates `CdnConfig` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `CdnConfig` objects to activate.
        /// Format: `networks/{network_code}/cdnConfigs/{cdn_config_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateCdnConfigsResponse> BatchActivateCdnConfigsAsync(NetworkName parent, scg::IEnumerable<CdnConfigName> names, st::CancellationToken cancellationToken) =>
            BatchActivateCdnConfigsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch archives `CdnConfig` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchArchiveCdnConfigsResponse BatchArchiveCdnConfigs(BatchArchiveCdnConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch archives `CdnConfig` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveCdnConfigsResponse> BatchArchiveCdnConfigsAsync(BatchArchiveCdnConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch archives `CdnConfig` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveCdnConfigsResponse> BatchArchiveCdnConfigsAsync(BatchArchiveCdnConfigsRequest request, st::CancellationToken cancellationToken) =>
            BatchArchiveCdnConfigsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch archives `CdnConfig` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `CdnConfig` objects to archive.
        /// Format: `networks/{network_code}/cdnConfigs/{cdn_config_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchArchiveCdnConfigsResponse BatchArchiveCdnConfigs(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchArchiveCdnConfigs(new BatchArchiveCdnConfigsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch archives `CdnConfig` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `CdnConfig` objects to archive.
        /// Format: `networks/{network_code}/cdnConfigs/{cdn_config_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveCdnConfigsResponse> BatchArchiveCdnConfigsAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchArchiveCdnConfigsAsync(new BatchArchiveCdnConfigsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch archives `CdnConfig` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `CdnConfig` objects to archive.
        /// Format: `networks/{network_code}/cdnConfigs/{cdn_config_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveCdnConfigsResponse> BatchArchiveCdnConfigsAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchArchiveCdnConfigsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch archives `CdnConfig` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `CdnConfig` objects to archive.
        /// Format: `networks/{network_code}/cdnConfigs/{cdn_config_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchArchiveCdnConfigsResponse BatchArchiveCdnConfigs(NetworkName parent, scg::IEnumerable<CdnConfigName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchArchiveCdnConfigs(new BatchArchiveCdnConfigsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CdnConfigNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch archives `CdnConfig` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `CdnConfig` objects to archive.
        /// Format: `networks/{network_code}/cdnConfigs/{cdn_config_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveCdnConfigsResponse> BatchArchiveCdnConfigsAsync(NetworkName parent, scg::IEnumerable<CdnConfigName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchArchiveCdnConfigsAsync(new BatchArchiveCdnConfigsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CdnConfigNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch archives `CdnConfig` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `CdnConfig` objects to archive.
        /// Format: `networks/{network_code}/cdnConfigs/{cdn_config_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveCdnConfigsResponse> BatchArchiveCdnConfigsAsync(NetworkName parent, scg::IEnumerable<CdnConfigName> names, st::CancellationToken cancellationToken) =>
            BatchArchiveCdnConfigsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CdnConfigService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `CdnConfig` objects.
    /// </remarks>
    public sealed partial class CdnConfigServiceClientImpl : CdnConfigServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetCdnConfigRequest, CdnConfig> _callGetCdnConfig;

        private readonly gaxgrpc::ApiCall<ListCdnConfigsRequest, ListCdnConfigsResponse> _callListCdnConfigs;

        private readonly gaxgrpc::ApiCall<CreateCdnConfigRequest, CdnConfig> _callCreateCdnConfig;

        private readonly gaxgrpc::ApiCall<BatchCreateCdnConfigsRequest, BatchCreateCdnConfigsResponse> _callBatchCreateCdnConfigs;

        private readonly gaxgrpc::ApiCall<UpdateCdnConfigRequest, CdnConfig> _callUpdateCdnConfig;

        private readonly gaxgrpc::ApiCall<BatchUpdateCdnConfigsRequest, BatchUpdateCdnConfigsResponse> _callBatchUpdateCdnConfigs;

        private readonly gaxgrpc::ApiCall<BatchActivateCdnConfigsRequest, BatchActivateCdnConfigsResponse> _callBatchActivateCdnConfigs;

        private readonly gaxgrpc::ApiCall<BatchArchiveCdnConfigsRequest, BatchArchiveCdnConfigsResponse> _callBatchArchiveCdnConfigs;

        /// <summary>
        /// Constructs a client wrapper for the CdnConfigService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CdnConfigServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CdnConfigServiceClientImpl(CdnConfigService.CdnConfigServiceClient grpcClient, CdnConfigServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CdnConfigServiceSettings effectiveSettings = settings ?? CdnConfigServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetCdnConfig = clientHelper.BuildApiCall<GetCdnConfigRequest, CdnConfig>("GetCdnConfig", grpcClient.GetCdnConfigAsync, grpcClient.GetCdnConfig, effectiveSettings.GetCdnConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCdnConfig);
            Modify_GetCdnConfigApiCall(ref _callGetCdnConfig);
            _callListCdnConfigs = clientHelper.BuildApiCall<ListCdnConfigsRequest, ListCdnConfigsResponse>("ListCdnConfigs", grpcClient.ListCdnConfigsAsync, grpcClient.ListCdnConfigs, effectiveSettings.ListCdnConfigsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCdnConfigs);
            Modify_ListCdnConfigsApiCall(ref _callListCdnConfigs);
            _callCreateCdnConfig = clientHelper.BuildApiCall<CreateCdnConfigRequest, CdnConfig>("CreateCdnConfig", grpcClient.CreateCdnConfigAsync, grpcClient.CreateCdnConfig, effectiveSettings.CreateCdnConfigSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateCdnConfig);
            Modify_CreateCdnConfigApiCall(ref _callCreateCdnConfig);
            _callBatchCreateCdnConfigs = clientHelper.BuildApiCall<BatchCreateCdnConfigsRequest, BatchCreateCdnConfigsResponse>("BatchCreateCdnConfigs", grpcClient.BatchCreateCdnConfigsAsync, grpcClient.BatchCreateCdnConfigs, effectiveSettings.BatchCreateCdnConfigsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchCreateCdnConfigs);
            Modify_BatchCreateCdnConfigsApiCall(ref _callBatchCreateCdnConfigs);
            _callUpdateCdnConfig = clientHelper.BuildApiCall<UpdateCdnConfigRequest, CdnConfig>("UpdateCdnConfig", grpcClient.UpdateCdnConfigAsync, grpcClient.UpdateCdnConfig, effectiveSettings.UpdateCdnConfigSettings).WithGoogleRequestParam("cdn_config.name", request => request.CdnConfig?.Name);
            Modify_ApiCall(ref _callUpdateCdnConfig);
            Modify_UpdateCdnConfigApiCall(ref _callUpdateCdnConfig);
            _callBatchUpdateCdnConfigs = clientHelper.BuildApiCall<BatchUpdateCdnConfigsRequest, BatchUpdateCdnConfigsResponse>("BatchUpdateCdnConfigs", grpcClient.BatchUpdateCdnConfigsAsync, grpcClient.BatchUpdateCdnConfigs, effectiveSettings.BatchUpdateCdnConfigsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchUpdateCdnConfigs);
            Modify_BatchUpdateCdnConfigsApiCall(ref _callBatchUpdateCdnConfigs);
            _callBatchActivateCdnConfigs = clientHelper.BuildApiCall<BatchActivateCdnConfigsRequest, BatchActivateCdnConfigsResponse>("BatchActivateCdnConfigs", grpcClient.BatchActivateCdnConfigsAsync, grpcClient.BatchActivateCdnConfigs, effectiveSettings.BatchActivateCdnConfigsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchActivateCdnConfigs);
            Modify_BatchActivateCdnConfigsApiCall(ref _callBatchActivateCdnConfigs);
            _callBatchArchiveCdnConfigs = clientHelper.BuildApiCall<BatchArchiveCdnConfigsRequest, BatchArchiveCdnConfigsResponse>("BatchArchiveCdnConfigs", grpcClient.BatchArchiveCdnConfigsAsync, grpcClient.BatchArchiveCdnConfigs, effectiveSettings.BatchArchiveCdnConfigsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchArchiveCdnConfigs);
            Modify_BatchArchiveCdnConfigsApiCall(ref _callBatchArchiveCdnConfigs);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetCdnConfigApiCall(ref gaxgrpc::ApiCall<GetCdnConfigRequest, CdnConfig> call);

        partial void Modify_ListCdnConfigsApiCall(ref gaxgrpc::ApiCall<ListCdnConfigsRequest, ListCdnConfigsResponse> call);

        partial void Modify_CreateCdnConfigApiCall(ref gaxgrpc::ApiCall<CreateCdnConfigRequest, CdnConfig> call);

        partial void Modify_BatchCreateCdnConfigsApiCall(ref gaxgrpc::ApiCall<BatchCreateCdnConfigsRequest, BatchCreateCdnConfigsResponse> call);

        partial void Modify_UpdateCdnConfigApiCall(ref gaxgrpc::ApiCall<UpdateCdnConfigRequest, CdnConfig> call);

        partial void Modify_BatchUpdateCdnConfigsApiCall(ref gaxgrpc::ApiCall<BatchUpdateCdnConfigsRequest, BatchUpdateCdnConfigsResponse> call);

        partial void Modify_BatchActivateCdnConfigsApiCall(ref gaxgrpc::ApiCall<BatchActivateCdnConfigsRequest, BatchActivateCdnConfigsResponse> call);

        partial void Modify_BatchArchiveCdnConfigsApiCall(ref gaxgrpc::ApiCall<BatchArchiveCdnConfigsRequest, BatchArchiveCdnConfigsResponse> call);

        partial void OnConstruction(CdnConfigService.CdnConfigServiceClient grpcClient, CdnConfigServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CdnConfigService client</summary>
        public override CdnConfigService.CdnConfigServiceClient GrpcClient { get; }

        partial void Modify_GetCdnConfigRequest(ref GetCdnConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCdnConfigsRequest(ref ListCdnConfigsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateCdnConfigRequest(ref CreateCdnConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchCreateCdnConfigsRequest(ref BatchCreateCdnConfigsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateCdnConfigRequest(ref UpdateCdnConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchUpdateCdnConfigsRequest(ref BatchUpdateCdnConfigsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchActivateCdnConfigsRequest(ref BatchActivateCdnConfigsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchArchiveCdnConfigsRequest(ref BatchArchiveCdnConfigsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves a `CdnConfig` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CdnConfig GetCdnConfig(GetCdnConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCdnConfigRequest(ref request, ref callSettings);
            return _callGetCdnConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a `CdnConfig` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CdnConfig> GetCdnConfigAsync(GetCdnConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCdnConfigRequest(ref request, ref callSettings);
            return _callGetCdnConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Lists `CdnConfig` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CdnConfig"/> resources.</returns>
        public override gax::PagedEnumerable<ListCdnConfigsResponse, CdnConfig> ListCdnConfigs(ListCdnConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCdnConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCdnConfigsRequest, ListCdnConfigsResponse, CdnConfig>(_callListCdnConfigs, request, callSettings);
        }

        /// <summary>
        /// Lists `CdnConfig` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CdnConfig"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCdnConfigsResponse, CdnConfig> ListCdnConfigsAsync(ListCdnConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCdnConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCdnConfigsRequest, ListCdnConfigsResponse, CdnConfig>(_callListCdnConfigs, request, callSettings);
        }

        /// <summary>
        /// Creates a `CdnConfig` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CdnConfig CreateCdnConfig(CreateCdnConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCdnConfigRequest(ref request, ref callSettings);
            return _callCreateCdnConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a `CdnConfig` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CdnConfig> CreateCdnConfigAsync(CreateCdnConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCdnConfigRequest(ref request, ref callSettings);
            return _callCreateCdnConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Batch creates `CdnConfig` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchCreateCdnConfigsResponse BatchCreateCdnConfigs(BatchCreateCdnConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateCdnConfigsRequest(ref request, ref callSettings);
            return _callBatchCreateCdnConfigs.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch creates `CdnConfig` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchCreateCdnConfigsResponse> BatchCreateCdnConfigsAsync(BatchCreateCdnConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateCdnConfigsRequest(ref request, ref callSettings);
            return _callBatchCreateCdnConfigs.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a `CdnConfig` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CdnConfig UpdateCdnConfig(UpdateCdnConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCdnConfigRequest(ref request, ref callSettings);
            return _callUpdateCdnConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a `CdnConfig` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CdnConfig> UpdateCdnConfigAsync(UpdateCdnConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCdnConfigRequest(ref request, ref callSettings);
            return _callUpdateCdnConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Batch updates `CdnConfig` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchUpdateCdnConfigsResponse BatchUpdateCdnConfigs(BatchUpdateCdnConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateCdnConfigsRequest(ref request, ref callSettings);
            return _callBatchUpdateCdnConfigs.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch updates `CdnConfig` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchUpdateCdnConfigsResponse> BatchUpdateCdnConfigsAsync(BatchUpdateCdnConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateCdnConfigsRequest(ref request, ref callSettings);
            return _callBatchUpdateCdnConfigs.Async(request, callSettings);
        }

        /// <summary>
        /// Batch activates `CdnConfig` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchActivateCdnConfigsResponse BatchActivateCdnConfigs(BatchActivateCdnConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchActivateCdnConfigsRequest(ref request, ref callSettings);
            return _callBatchActivateCdnConfigs.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch activates `CdnConfig` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchActivateCdnConfigsResponse> BatchActivateCdnConfigsAsync(BatchActivateCdnConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchActivateCdnConfigsRequest(ref request, ref callSettings);
            return _callBatchActivateCdnConfigs.Async(request, callSettings);
        }

        /// <summary>
        /// Batch archives `CdnConfig` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchArchiveCdnConfigsResponse BatchArchiveCdnConfigs(BatchArchiveCdnConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchArchiveCdnConfigsRequest(ref request, ref callSettings);
            return _callBatchArchiveCdnConfigs.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch archives `CdnConfig` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchArchiveCdnConfigsResponse> BatchArchiveCdnConfigsAsync(BatchArchiveCdnConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchArchiveCdnConfigsRequest(ref request, ref callSettings);
            return _callBatchArchiveCdnConfigs.Async(request, callSettings);
        }
    }

    public partial class ListCdnConfigsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCdnConfigsResponse : gaxgrpc::IPageResponse<CdnConfig>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<CdnConfig> GetEnumerator() => CdnConfigs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
