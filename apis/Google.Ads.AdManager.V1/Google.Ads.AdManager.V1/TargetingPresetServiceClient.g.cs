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

namespace Google.Ads.AdManager.V1
{
    /// <summary>Settings for <see cref="TargetingPresetServiceClient"/> instances.</summary>
    public sealed partial class TargetingPresetServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="TargetingPresetServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="TargetingPresetServiceSettings"/>.</returns>
        public static TargetingPresetServiceSettings GetDefault() => new TargetingPresetServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="TargetingPresetServiceSettings"/> object with default settings.
        /// </summary>
        public TargetingPresetServiceSettings()
        {
        }

        private TargetingPresetServiceSettings(TargetingPresetServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetTargetingPresetSettings = existing.GetTargetingPresetSettings;
            ListTargetingPresetsSettings = existing.ListTargetingPresetsSettings;
            CreateTargetingPresetSettings = existing.CreateTargetingPresetSettings;
            BatchCreateTargetingPresetsSettings = existing.BatchCreateTargetingPresetsSettings;
            BatchDeactivateTargetingPresetsSettings = existing.BatchDeactivateTargetingPresetsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(TargetingPresetServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TargetingPresetServiceClient.GetTargetingPreset</c> and
        /// <c>TargetingPresetServiceClient.GetTargetingPresetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetTargetingPresetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TargetingPresetServiceClient.ListTargetingPresets</c> and
        /// <c>TargetingPresetServiceClient.ListTargetingPresetsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTargetingPresetsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TargetingPresetServiceClient.CreateTargetingPreset</c> and
        /// <c>TargetingPresetServiceClient.CreateTargetingPresetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateTargetingPresetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TargetingPresetServiceClient.BatchCreateTargetingPresets</c> and
        /// <c>TargetingPresetServiceClient.BatchCreateTargetingPresetsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchCreateTargetingPresetsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TargetingPresetServiceClient.BatchDeactivateTargetingPresets</c> and
        /// <c>TargetingPresetServiceClient.BatchDeactivateTargetingPresetsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchDeactivateTargetingPresetsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="TargetingPresetServiceSettings"/> object.</returns>
        public TargetingPresetServiceSettings Clone() => new TargetingPresetServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="TargetingPresetServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class TargetingPresetServiceClientBuilder : gaxgrpc::ClientBuilderBase<TargetingPresetServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public TargetingPresetServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public TargetingPresetServiceClientBuilder() : base(TargetingPresetServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref TargetingPresetServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<TargetingPresetServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override TargetingPresetServiceClient Build()
        {
            TargetingPresetServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<TargetingPresetServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<TargetingPresetServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private TargetingPresetServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return TargetingPresetServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<TargetingPresetServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return TargetingPresetServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => TargetingPresetServiceClient.ChannelPool;
    }

    /// <summary>TargetingPresetService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `TargetingPreset` objects.
    /// </remarks>
    public abstract partial class TargetingPresetServiceClient
    {
        /// <summary>
        /// The default endpoint for the TargetingPresetService service, which is a host of "admanager.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default TargetingPresetService scopes.</summary>
        /// <remarks>
        /// The default TargetingPresetService scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(TargetingPresetService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="TargetingPresetServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="TargetingPresetServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="TargetingPresetServiceClient"/>.</returns>
        public static stt::Task<TargetingPresetServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new TargetingPresetServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="TargetingPresetServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="TargetingPresetServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="TargetingPresetServiceClient"/>.</returns>
        public static TargetingPresetServiceClient Create() => new TargetingPresetServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="TargetingPresetServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="TargetingPresetServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="TargetingPresetServiceClient"/>.</returns>
        internal static TargetingPresetServiceClient Create(grpccore::CallInvoker callInvoker, TargetingPresetServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            TargetingPresetService.TargetingPresetServiceClient grpcClient = new TargetingPresetService.TargetingPresetServiceClient(callInvoker);
            return new TargetingPresetServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC TargetingPresetService client</summary>
        public virtual TargetingPresetService.TargetingPresetServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `TargetingPreset` object.
        /// Note: Deactivated targeting presets are "logically deleted" (filtered out)
        /// by the get logic in the manager layer, so they will not be returned by the
        /// `GetTargetingPreset` RPC.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TargetingPreset GetTargetingPreset(GetTargetingPresetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `TargetingPreset` object.
        /// Note: Deactivated targeting presets are "logically deleted" (filtered out)
        /// by the get logic in the manager layer, so they will not be returned by the
        /// `GetTargetingPreset` RPC.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetingPreset> GetTargetingPresetAsync(GetTargetingPresetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `TargetingPreset` object.
        /// Note: Deactivated targeting presets are "logically deleted" (filtered out)
        /// by the get logic in the manager layer, so they will not be returned by the
        /// `GetTargetingPreset` RPC.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetingPreset> GetTargetingPresetAsync(GetTargetingPresetRequest request, st::CancellationToken cancellationToken) =>
            GetTargetingPresetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `TargetingPreset` object.
        /// Note: Deactivated targeting presets are "logically deleted" (filtered out)
        /// by the get logic in the manager layer, so they will not be returned by the
        /// `GetTargetingPreset` RPC.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the TargetingPreset.
        /// Format: `networks/{network_code}/targetingPresets/{targeting_preset_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TargetingPreset GetTargetingPreset(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTargetingPreset(new GetTargetingPresetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `TargetingPreset` object.
        /// Note: Deactivated targeting presets are "logically deleted" (filtered out)
        /// by the get logic in the manager layer, so they will not be returned by the
        /// `GetTargetingPreset` RPC.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the TargetingPreset.
        /// Format: `networks/{network_code}/targetingPresets/{targeting_preset_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetingPreset> GetTargetingPresetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTargetingPresetAsync(new GetTargetingPresetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `TargetingPreset` object.
        /// Note: Deactivated targeting presets are "logically deleted" (filtered out)
        /// by the get logic in the manager layer, so they will not be returned by the
        /// `GetTargetingPreset` RPC.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the TargetingPreset.
        /// Format: `networks/{network_code}/targetingPresets/{targeting_preset_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetingPreset> GetTargetingPresetAsync(string name, st::CancellationToken cancellationToken) =>
            GetTargetingPresetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `TargetingPreset` object.
        /// Note: Deactivated targeting presets are "logically deleted" (filtered out)
        /// by the get logic in the manager layer, so they will not be returned by the
        /// `GetTargetingPreset` RPC.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the TargetingPreset.
        /// Format: `networks/{network_code}/targetingPresets/{targeting_preset_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TargetingPreset GetTargetingPreset(TargetingPresetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTargetingPreset(new GetTargetingPresetRequest
            {
                TargetingPresetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `TargetingPreset` object.
        /// Note: Deactivated targeting presets are "logically deleted" (filtered out)
        /// by the get logic in the manager layer, so they will not be returned by the
        /// `GetTargetingPreset` RPC.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the TargetingPreset.
        /// Format: `networks/{network_code}/targetingPresets/{targeting_preset_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetingPreset> GetTargetingPresetAsync(TargetingPresetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTargetingPresetAsync(new GetTargetingPresetRequest
            {
                TargetingPresetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `TargetingPreset` object.
        /// Note: Deactivated targeting presets are "logically deleted" (filtered out)
        /// by the get logic in the manager layer, so they will not be returned by the
        /// `GetTargetingPreset` RPC.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the TargetingPreset.
        /// Format: `networks/{network_code}/targetingPresets/{targeting_preset_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetingPreset> GetTargetingPresetAsync(TargetingPresetName name, st::CancellationToken cancellationToken) =>
            GetTargetingPresetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists `TargetingPreset` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TargetingPreset"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTargetingPresetsResponse, TargetingPreset> ListTargetingPresets(ListTargetingPresetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `TargetingPreset` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TargetingPreset"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTargetingPresetsResponse, TargetingPreset> ListTargetingPresetsAsync(ListTargetingPresetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `TargetingPreset` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of TargetingPresets.
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
        /// <returns>A pageable sequence of <see cref="TargetingPreset"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTargetingPresetsResponse, TargetingPreset> ListTargetingPresets(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTargetingPresetsRequest request = new ListTargetingPresetsRequest
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
            return ListTargetingPresets(request, callSettings);
        }

        /// <summary>
        /// Lists `TargetingPreset` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of TargetingPresets.
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
        /// <returns>A pageable asynchronous sequence of <see cref="TargetingPreset"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTargetingPresetsResponse, TargetingPreset> ListTargetingPresetsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTargetingPresetsRequest request = new ListTargetingPresetsRequest
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
            return ListTargetingPresetsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists `TargetingPreset` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of TargetingPresets.
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
        /// <returns>A pageable sequence of <see cref="TargetingPreset"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTargetingPresetsResponse, TargetingPreset> ListTargetingPresets(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTargetingPresetsRequest request = new ListTargetingPresetsRequest
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
            return ListTargetingPresets(request, callSettings);
        }

        /// <summary>
        /// Lists `TargetingPreset` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of TargetingPresets.
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
        /// <returns>A pageable asynchronous sequence of <see cref="TargetingPreset"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTargetingPresetsResponse, TargetingPreset> ListTargetingPresetsAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTargetingPresetsRequest request = new ListTargetingPresetsRequest
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
            return ListTargetingPresetsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a `TargetingPreset` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TargetingPreset CreateTargetingPreset(CreateTargetingPresetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a `TargetingPreset` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetingPreset> CreateTargetingPresetAsync(CreateTargetingPresetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a `TargetingPreset` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetingPreset> CreateTargetingPresetAsync(CreateTargetingPresetRequest request, st::CancellationToken cancellationToken) =>
            CreateTargetingPresetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a `TargetingPreset` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `TargetingPreset` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="targetingPreset">
        /// Required. The `TargetingPreset` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TargetingPreset CreateTargetingPreset(string parent, TargetingPreset targetingPreset, gaxgrpc::CallSettings callSettings = null) =>
            CreateTargetingPreset(new CreateTargetingPresetRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TargetingPreset = gax::GaxPreconditions.CheckNotNull(targetingPreset, nameof(targetingPreset)),
            }, callSettings);

        /// <summary>
        /// Creates a `TargetingPreset` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `TargetingPreset` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="targetingPreset">
        /// Required. The `TargetingPreset` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetingPreset> CreateTargetingPresetAsync(string parent, TargetingPreset targetingPreset, gaxgrpc::CallSettings callSettings = null) =>
            CreateTargetingPresetAsync(new CreateTargetingPresetRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TargetingPreset = gax::GaxPreconditions.CheckNotNull(targetingPreset, nameof(targetingPreset)),
            }, callSettings);

        /// <summary>
        /// Creates a `TargetingPreset` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `TargetingPreset` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="targetingPreset">
        /// Required. The `TargetingPreset` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetingPreset> CreateTargetingPresetAsync(string parent, TargetingPreset targetingPreset, st::CancellationToken cancellationToken) =>
            CreateTargetingPresetAsync(parent, targetingPreset, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a `TargetingPreset` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `TargetingPreset` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="targetingPreset">
        /// Required. The `TargetingPreset` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TargetingPreset CreateTargetingPreset(NetworkName parent, TargetingPreset targetingPreset, gaxgrpc::CallSettings callSettings = null) =>
            CreateTargetingPreset(new CreateTargetingPresetRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TargetingPreset = gax::GaxPreconditions.CheckNotNull(targetingPreset, nameof(targetingPreset)),
            }, callSettings);

        /// <summary>
        /// Creates a `TargetingPreset` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `TargetingPreset` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="targetingPreset">
        /// Required. The `TargetingPreset` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetingPreset> CreateTargetingPresetAsync(NetworkName parent, TargetingPreset targetingPreset, gaxgrpc::CallSettings callSettings = null) =>
            CreateTargetingPresetAsync(new CreateTargetingPresetRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TargetingPreset = gax::GaxPreconditions.CheckNotNull(targetingPreset, nameof(targetingPreset)),
            }, callSettings);

        /// <summary>
        /// Creates a `TargetingPreset` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `TargetingPreset` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="targetingPreset">
        /// Required. The `TargetingPreset` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetingPreset> CreateTargetingPresetAsync(NetworkName parent, TargetingPreset targetingPreset, st::CancellationToken cancellationToken) =>
            CreateTargetingPresetAsync(parent, targetingPreset, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates `TargetingPreset` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateTargetingPresetsResponse BatchCreateTargetingPresets(BatchCreateTargetingPresetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates `TargetingPreset` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateTargetingPresetsResponse> BatchCreateTargetingPresetsAsync(BatchCreateTargetingPresetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates `TargetingPreset` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateTargetingPresetsResponse> BatchCreateTargetingPresetsAsync(BatchCreateTargetingPresetsRequest request, st::CancellationToken cancellationToken) =>
            BatchCreateTargetingPresetsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates `TargetingPreset` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `TargetingPresets` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateTargetingPresetRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `TargetingPreset` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateTargetingPresetsResponse BatchCreateTargetingPresets(string parent, scg::IEnumerable<CreateTargetingPresetRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateTargetingPresets(new BatchCreateTargetingPresetsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates `TargetingPreset` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `TargetingPresets` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateTargetingPresetRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `TargetingPreset` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateTargetingPresetsResponse> BatchCreateTargetingPresetsAsync(string parent, scg::IEnumerable<CreateTargetingPresetRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateTargetingPresetsAsync(new BatchCreateTargetingPresetsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates `TargetingPreset` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `TargetingPresets` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateTargetingPresetRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `TargetingPreset` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateTargetingPresetsResponse> BatchCreateTargetingPresetsAsync(string parent, scg::IEnumerable<CreateTargetingPresetRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateTargetingPresetsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates `TargetingPreset` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `TargetingPresets` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateTargetingPresetRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `TargetingPreset` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateTargetingPresetsResponse BatchCreateTargetingPresets(NetworkName parent, scg::IEnumerable<CreateTargetingPresetRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateTargetingPresets(new BatchCreateTargetingPresetsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates `TargetingPreset` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `TargetingPresets` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateTargetingPresetRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `TargetingPreset` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateTargetingPresetsResponse> BatchCreateTargetingPresetsAsync(NetworkName parent, scg::IEnumerable<CreateTargetingPresetRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateTargetingPresetsAsync(new BatchCreateTargetingPresetsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates `TargetingPreset` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `TargetingPresets` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateTargetingPresetRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `TargetingPreset` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateTargetingPresetsResponse> BatchCreateTargetingPresetsAsync(NetworkName parent, scg::IEnumerable<CreateTargetingPresetRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateTargetingPresetsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch deactivates `TargetingPreset` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDeactivateTargetingPresetsResponse BatchDeactivateTargetingPresets(BatchDeactivateTargetingPresetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch deactivates `TargetingPreset` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateTargetingPresetsResponse> BatchDeactivateTargetingPresetsAsync(BatchDeactivateTargetingPresetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch deactivates `TargetingPreset` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateTargetingPresetsResponse> BatchDeactivateTargetingPresetsAsync(BatchDeactivateTargetingPresetsRequest request, st::CancellationToken cancellationToken) =>
            BatchDeactivateTargetingPresetsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch deactivates `TargetingPreset` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="requests">
        /// Required. The `TargetingPreset` objects to deactivate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDeactivateTargetingPresetsResponse BatchDeactivateTargetingPresets(string parent, scg::IEnumerable<DeactivateTargetingPresetRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateTargetingPresets(new BatchDeactivateTargetingPresetsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch deactivates `TargetingPreset` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="requests">
        /// Required. The `TargetingPreset` objects to deactivate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateTargetingPresetsResponse> BatchDeactivateTargetingPresetsAsync(string parent, scg::IEnumerable<DeactivateTargetingPresetRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateTargetingPresetsAsync(new BatchDeactivateTargetingPresetsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch deactivates `TargetingPreset` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="requests">
        /// Required. The `TargetingPreset` objects to deactivate.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateTargetingPresetsResponse> BatchDeactivateTargetingPresetsAsync(string parent, scg::IEnumerable<DeactivateTargetingPresetRequest> requests, st::CancellationToken cancellationToken) =>
            BatchDeactivateTargetingPresetsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch deactivates `TargetingPreset` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="requests">
        /// Required. The `TargetingPreset` objects to deactivate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDeactivateTargetingPresetsResponse BatchDeactivateTargetingPresets(NetworkName parent, scg::IEnumerable<DeactivateTargetingPresetRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateTargetingPresets(new BatchDeactivateTargetingPresetsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch deactivates `TargetingPreset` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="requests">
        /// Required. The `TargetingPreset` objects to deactivate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateTargetingPresetsResponse> BatchDeactivateTargetingPresetsAsync(NetworkName parent, scg::IEnumerable<DeactivateTargetingPresetRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateTargetingPresetsAsync(new BatchDeactivateTargetingPresetsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch deactivates `TargetingPreset` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="requests">
        /// Required. The `TargetingPreset` objects to deactivate.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateTargetingPresetsResponse> BatchDeactivateTargetingPresetsAsync(NetworkName parent, scg::IEnumerable<DeactivateTargetingPresetRequest> requests, st::CancellationToken cancellationToken) =>
            BatchDeactivateTargetingPresetsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>TargetingPresetService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `TargetingPreset` objects.
    /// </remarks>
    public sealed partial class TargetingPresetServiceClientImpl : TargetingPresetServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetTargetingPresetRequest, TargetingPreset> _callGetTargetingPreset;

        private readonly gaxgrpc::ApiCall<ListTargetingPresetsRequest, ListTargetingPresetsResponse> _callListTargetingPresets;

        private readonly gaxgrpc::ApiCall<CreateTargetingPresetRequest, TargetingPreset> _callCreateTargetingPreset;

        private readonly gaxgrpc::ApiCall<BatchCreateTargetingPresetsRequest, BatchCreateTargetingPresetsResponse> _callBatchCreateTargetingPresets;

        private readonly gaxgrpc::ApiCall<BatchDeactivateTargetingPresetsRequest, BatchDeactivateTargetingPresetsResponse> _callBatchDeactivateTargetingPresets;

        /// <summary>
        /// Constructs a client wrapper for the TargetingPresetService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="TargetingPresetServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public TargetingPresetServiceClientImpl(TargetingPresetService.TargetingPresetServiceClient grpcClient, TargetingPresetServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            TargetingPresetServiceSettings effectiveSettings = settings ?? TargetingPresetServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetTargetingPreset = clientHelper.BuildApiCall<GetTargetingPresetRequest, TargetingPreset>("GetTargetingPreset", grpcClient.GetTargetingPresetAsync, grpcClient.GetTargetingPreset, effectiveSettings.GetTargetingPresetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTargetingPreset);
            Modify_GetTargetingPresetApiCall(ref _callGetTargetingPreset);
            _callListTargetingPresets = clientHelper.BuildApiCall<ListTargetingPresetsRequest, ListTargetingPresetsResponse>("ListTargetingPresets", grpcClient.ListTargetingPresetsAsync, grpcClient.ListTargetingPresets, effectiveSettings.ListTargetingPresetsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTargetingPresets);
            Modify_ListTargetingPresetsApiCall(ref _callListTargetingPresets);
            _callCreateTargetingPreset = clientHelper.BuildApiCall<CreateTargetingPresetRequest, TargetingPreset>("CreateTargetingPreset", grpcClient.CreateTargetingPresetAsync, grpcClient.CreateTargetingPreset, effectiveSettings.CreateTargetingPresetSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateTargetingPreset);
            Modify_CreateTargetingPresetApiCall(ref _callCreateTargetingPreset);
            _callBatchCreateTargetingPresets = clientHelper.BuildApiCall<BatchCreateTargetingPresetsRequest, BatchCreateTargetingPresetsResponse>("BatchCreateTargetingPresets", grpcClient.BatchCreateTargetingPresetsAsync, grpcClient.BatchCreateTargetingPresets, effectiveSettings.BatchCreateTargetingPresetsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchCreateTargetingPresets);
            Modify_BatchCreateTargetingPresetsApiCall(ref _callBatchCreateTargetingPresets);
            _callBatchDeactivateTargetingPresets = clientHelper.BuildApiCall<BatchDeactivateTargetingPresetsRequest, BatchDeactivateTargetingPresetsResponse>("BatchDeactivateTargetingPresets", grpcClient.BatchDeactivateTargetingPresetsAsync, grpcClient.BatchDeactivateTargetingPresets, effectiveSettings.BatchDeactivateTargetingPresetsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchDeactivateTargetingPresets);
            Modify_BatchDeactivateTargetingPresetsApiCall(ref _callBatchDeactivateTargetingPresets);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetTargetingPresetApiCall(ref gaxgrpc::ApiCall<GetTargetingPresetRequest, TargetingPreset> call);

        partial void Modify_ListTargetingPresetsApiCall(ref gaxgrpc::ApiCall<ListTargetingPresetsRequest, ListTargetingPresetsResponse> call);

        partial void Modify_CreateTargetingPresetApiCall(ref gaxgrpc::ApiCall<CreateTargetingPresetRequest, TargetingPreset> call);

        partial void Modify_BatchCreateTargetingPresetsApiCall(ref gaxgrpc::ApiCall<BatchCreateTargetingPresetsRequest, BatchCreateTargetingPresetsResponse> call);

        partial void Modify_BatchDeactivateTargetingPresetsApiCall(ref gaxgrpc::ApiCall<BatchDeactivateTargetingPresetsRequest, BatchDeactivateTargetingPresetsResponse> call);

        partial void OnConstruction(TargetingPresetService.TargetingPresetServiceClient grpcClient, TargetingPresetServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC TargetingPresetService client</summary>
        public override TargetingPresetService.TargetingPresetServiceClient GrpcClient { get; }

        partial void Modify_GetTargetingPresetRequest(ref GetTargetingPresetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTargetingPresetsRequest(ref ListTargetingPresetsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateTargetingPresetRequest(ref CreateTargetingPresetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchCreateTargetingPresetsRequest(ref BatchCreateTargetingPresetsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchDeactivateTargetingPresetsRequest(ref BatchDeactivateTargetingPresetsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves a `TargetingPreset` object.
        /// Note: Deactivated targeting presets are "logically deleted" (filtered out)
        /// by the get logic in the manager layer, so they will not be returned by the
        /// `GetTargetingPreset` RPC.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TargetingPreset GetTargetingPreset(GetTargetingPresetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTargetingPresetRequest(ref request, ref callSettings);
            return _callGetTargetingPreset.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a `TargetingPreset` object.
        /// Note: Deactivated targeting presets are "logically deleted" (filtered out)
        /// by the get logic in the manager layer, so they will not be returned by the
        /// `GetTargetingPreset` RPC.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TargetingPreset> GetTargetingPresetAsync(GetTargetingPresetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTargetingPresetRequest(ref request, ref callSettings);
            return _callGetTargetingPreset.Async(request, callSettings);
        }

        /// <summary>
        /// Lists `TargetingPreset` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TargetingPreset"/> resources.</returns>
        public override gax::PagedEnumerable<ListTargetingPresetsResponse, TargetingPreset> ListTargetingPresets(ListTargetingPresetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTargetingPresetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTargetingPresetsRequest, ListTargetingPresetsResponse, TargetingPreset>(_callListTargetingPresets, request, callSettings);
        }

        /// <summary>
        /// Lists `TargetingPreset` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TargetingPreset"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTargetingPresetsResponse, TargetingPreset> ListTargetingPresetsAsync(ListTargetingPresetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTargetingPresetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTargetingPresetsRequest, ListTargetingPresetsResponse, TargetingPreset>(_callListTargetingPresets, request, callSettings);
        }

        /// <summary>
        /// Creates a `TargetingPreset` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TargetingPreset CreateTargetingPreset(CreateTargetingPresetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTargetingPresetRequest(ref request, ref callSettings);
            return _callCreateTargetingPreset.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a `TargetingPreset` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TargetingPreset> CreateTargetingPresetAsync(CreateTargetingPresetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTargetingPresetRequest(ref request, ref callSettings);
            return _callCreateTargetingPreset.Async(request, callSettings);
        }

        /// <summary>
        /// Creates `TargetingPreset` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchCreateTargetingPresetsResponse BatchCreateTargetingPresets(BatchCreateTargetingPresetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateTargetingPresetsRequest(ref request, ref callSettings);
            return _callBatchCreateTargetingPresets.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates `TargetingPreset` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchCreateTargetingPresetsResponse> BatchCreateTargetingPresetsAsync(BatchCreateTargetingPresetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateTargetingPresetsRequest(ref request, ref callSettings);
            return _callBatchCreateTargetingPresets.Async(request, callSettings);
        }

        /// <summary>
        /// Batch deactivates `TargetingPreset` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchDeactivateTargetingPresetsResponse BatchDeactivateTargetingPresets(BatchDeactivateTargetingPresetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeactivateTargetingPresetsRequest(ref request, ref callSettings);
            return _callBatchDeactivateTargetingPresets.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch deactivates `TargetingPreset` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchDeactivateTargetingPresetsResponse> BatchDeactivateTargetingPresetsAsync(BatchDeactivateTargetingPresetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeactivateTargetingPresetsRequest(ref request, ref callSettings);
            return _callBatchDeactivateTargetingPresets.Async(request, callSettings);
        }
    }

    public partial class ListTargetingPresetsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTargetingPresetsResponse : gaxgrpc::IPageResponse<TargetingPreset>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<TargetingPreset> GetEnumerator() => TargetingPresets.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
