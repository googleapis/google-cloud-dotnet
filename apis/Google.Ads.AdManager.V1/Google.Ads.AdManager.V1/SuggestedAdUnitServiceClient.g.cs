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
    /// <summary>Settings for <see cref="SuggestedAdUnitServiceClient"/> instances.</summary>
    public sealed partial class SuggestedAdUnitServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SuggestedAdUnitServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SuggestedAdUnitServiceSettings"/>.</returns>
        public static SuggestedAdUnitServiceSettings GetDefault() => new SuggestedAdUnitServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="SuggestedAdUnitServiceSettings"/> object with default settings.
        /// </summary>
        public SuggestedAdUnitServiceSettings()
        {
        }

        private SuggestedAdUnitServiceSettings(SuggestedAdUnitServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetSuggestedAdUnitSettings = existing.GetSuggestedAdUnitSettings;
            ListSuggestedAdUnitsSettings = existing.ListSuggestedAdUnitsSettings;
            BatchApproveSuggestedAdUnitsSettings = existing.BatchApproveSuggestedAdUnitsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SuggestedAdUnitServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SuggestedAdUnitServiceClient.GetSuggestedAdUnit</c> and
        /// <c>SuggestedAdUnitServiceClient.GetSuggestedAdUnitAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSuggestedAdUnitSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SuggestedAdUnitServiceClient.ListSuggestedAdUnits</c> and
        /// <c>SuggestedAdUnitServiceClient.ListSuggestedAdUnitsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSuggestedAdUnitsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SuggestedAdUnitServiceClient.BatchApproveSuggestedAdUnits</c> and
        /// <c>SuggestedAdUnitServiceClient.BatchApproveSuggestedAdUnitsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchApproveSuggestedAdUnitsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SuggestedAdUnitServiceSettings"/> object.</returns>
        public SuggestedAdUnitServiceSettings Clone() => new SuggestedAdUnitServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SuggestedAdUnitServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class SuggestedAdUnitServiceClientBuilder : gaxgrpc::ClientBuilderBase<SuggestedAdUnitServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SuggestedAdUnitServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SuggestedAdUnitServiceClientBuilder() : base(SuggestedAdUnitServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref SuggestedAdUnitServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SuggestedAdUnitServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SuggestedAdUnitServiceClient Build()
        {
            SuggestedAdUnitServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SuggestedAdUnitServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SuggestedAdUnitServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SuggestedAdUnitServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SuggestedAdUnitServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<SuggestedAdUnitServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SuggestedAdUnitServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SuggestedAdUnitServiceClient.ChannelPool;
    }

    /// <summary>SuggestedAdUnitService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `SuggestedAdUnit` objects.
    /// </remarks>
    public abstract partial class SuggestedAdUnitServiceClient
    {
        /// <summary>
        /// The default endpoint for the SuggestedAdUnitService service, which is a host of "admanager.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default SuggestedAdUnitService scopes.</summary>
        /// <remarks>
        /// The default SuggestedAdUnitService scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(SuggestedAdUnitService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="SuggestedAdUnitServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="SuggestedAdUnitServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SuggestedAdUnitServiceClient"/>.</returns>
        public static stt::Task<SuggestedAdUnitServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SuggestedAdUnitServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SuggestedAdUnitServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="SuggestedAdUnitServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SuggestedAdUnitServiceClient"/>.</returns>
        public static SuggestedAdUnitServiceClient Create() => new SuggestedAdUnitServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SuggestedAdUnitServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SuggestedAdUnitServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="SuggestedAdUnitServiceClient"/>.</returns>
        internal static SuggestedAdUnitServiceClient Create(grpccore::CallInvoker callInvoker, SuggestedAdUnitServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SuggestedAdUnitService.SuggestedAdUnitServiceClient grpcClient = new SuggestedAdUnitService.SuggestedAdUnitServiceClient(callInvoker);
            return new SuggestedAdUnitServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC SuggestedAdUnitService client</summary>
        public virtual SuggestedAdUnitService.SuggestedAdUnitServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Get a `SuggestedAdUnit` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SuggestedAdUnit GetSuggestedAdUnit(GetSuggestedAdUnitRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a `SuggestedAdUnit` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestedAdUnit> GetSuggestedAdUnitAsync(GetSuggestedAdUnitRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a `SuggestedAdUnit` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestedAdUnit> GetSuggestedAdUnitAsync(GetSuggestedAdUnitRequest request, st::CancellationToken cancellationToken) =>
            GetSuggestedAdUnitAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a `SuggestedAdUnit` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the `SuggestedAdUnit`.
        /// Format: `networks/{network_code}/suggestedAdUnits/{suggested_ad_unit_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SuggestedAdUnit GetSuggestedAdUnit(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSuggestedAdUnit(new GetSuggestedAdUnitRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a `SuggestedAdUnit` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the `SuggestedAdUnit`.
        /// Format: `networks/{network_code}/suggestedAdUnits/{suggested_ad_unit_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestedAdUnit> GetSuggestedAdUnitAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSuggestedAdUnitAsync(new GetSuggestedAdUnitRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a `SuggestedAdUnit` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the `SuggestedAdUnit`.
        /// Format: `networks/{network_code}/suggestedAdUnits/{suggested_ad_unit_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestedAdUnit> GetSuggestedAdUnitAsync(string name, st::CancellationToken cancellationToken) =>
            GetSuggestedAdUnitAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a `SuggestedAdUnit` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the `SuggestedAdUnit`.
        /// Format: `networks/{network_code}/suggestedAdUnits/{suggested_ad_unit_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SuggestedAdUnit GetSuggestedAdUnit(SuggestedAdUnitName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSuggestedAdUnit(new GetSuggestedAdUnitRequest
            {
                SuggestedAdUnitName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a `SuggestedAdUnit` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the `SuggestedAdUnit`.
        /// Format: `networks/{network_code}/suggestedAdUnits/{suggested_ad_unit_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestedAdUnit> GetSuggestedAdUnitAsync(SuggestedAdUnitName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSuggestedAdUnitAsync(new GetSuggestedAdUnitRequest
            {
                SuggestedAdUnitName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a `SuggestedAdUnit` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the `SuggestedAdUnit`.
        /// Format: `networks/{network_code}/suggestedAdUnits/{suggested_ad_unit_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestedAdUnit> GetSuggestedAdUnitAsync(SuggestedAdUnitName name, st::CancellationToken cancellationToken) =>
            GetSuggestedAdUnitAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve a list of `SuggestedAdUnit` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SuggestedAdUnit"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSuggestedAdUnitsResponse, SuggestedAdUnit> ListSuggestedAdUnits(ListSuggestedAdUnitsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve a list of `SuggestedAdUnit` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SuggestedAdUnit"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSuggestedAdUnitsResponse, SuggestedAdUnit> ListSuggestedAdUnitsAsync(ListSuggestedAdUnitsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve a list of `SuggestedAdUnit` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of SuggestedAdUnits.
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
        /// <returns>A pageable sequence of <see cref="SuggestedAdUnit"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSuggestedAdUnitsResponse, SuggestedAdUnit> ListSuggestedAdUnits(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSuggestedAdUnitsRequest request = new ListSuggestedAdUnitsRequest
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
            return ListSuggestedAdUnits(request, callSettings);
        }

        /// <summary>
        /// Retrieve a list of `SuggestedAdUnit` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of SuggestedAdUnits.
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
        /// <returns>A pageable asynchronous sequence of <see cref="SuggestedAdUnit"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSuggestedAdUnitsResponse, SuggestedAdUnit> ListSuggestedAdUnitsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSuggestedAdUnitsRequest request = new ListSuggestedAdUnitsRequest
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
            return ListSuggestedAdUnitsAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieve a list of `SuggestedAdUnit` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of SuggestedAdUnits.
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
        /// <returns>A pageable sequence of <see cref="SuggestedAdUnit"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSuggestedAdUnitsResponse, SuggestedAdUnit> ListSuggestedAdUnits(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSuggestedAdUnitsRequest request = new ListSuggestedAdUnitsRequest
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
            return ListSuggestedAdUnits(request, callSettings);
        }

        /// <summary>
        /// Retrieve a list of `SuggestedAdUnit` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of SuggestedAdUnits.
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
        /// <returns>A pageable asynchronous sequence of <see cref="SuggestedAdUnit"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSuggestedAdUnitsResponse, SuggestedAdUnit> ListSuggestedAdUnitsAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSuggestedAdUnitsRequest request = new ListSuggestedAdUnitsRequest
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
            return ListSuggestedAdUnitsAsync(request, callSettings);
        }

        /// <summary>
        /// Bulk approve `SuggestedAdUnit` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchApproveSuggestedAdUnitsResponse BatchApproveSuggestedAdUnits(BatchApproveSuggestedAdUnitsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Bulk approve `SuggestedAdUnit` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchApproveSuggestedAdUnitsResponse> BatchApproveSuggestedAdUnitsAsync(BatchApproveSuggestedAdUnitsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Bulk approve `SuggestedAdUnit` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchApproveSuggestedAdUnitsResponse> BatchApproveSuggestedAdUnitsAsync(BatchApproveSuggestedAdUnitsRequest request, st::CancellationToken cancellationToken) =>
            BatchApproveSuggestedAdUnitsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Bulk approve `SuggestedAdUnit` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the `SuggestedAdUnit` objects to approve.
        /// Format: `networks/{network_code}/suggestedAdUnits/{suggested_ad_unit_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchApproveSuggestedAdUnitsResponse BatchApproveSuggestedAdUnits(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchApproveSuggestedAdUnits(new BatchApproveSuggestedAdUnitsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Bulk approve `SuggestedAdUnit` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the `SuggestedAdUnit` objects to approve.
        /// Format: `networks/{network_code}/suggestedAdUnits/{suggested_ad_unit_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchApproveSuggestedAdUnitsResponse> BatchApproveSuggestedAdUnitsAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchApproveSuggestedAdUnitsAsync(new BatchApproveSuggestedAdUnitsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Bulk approve `SuggestedAdUnit` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the `SuggestedAdUnit` objects to approve.
        /// Format: `networks/{network_code}/suggestedAdUnits/{suggested_ad_unit_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchApproveSuggestedAdUnitsResponse> BatchApproveSuggestedAdUnitsAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchApproveSuggestedAdUnitsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Bulk approve `SuggestedAdUnit` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the `SuggestedAdUnit` objects to approve.
        /// Format: `networks/{network_code}/suggestedAdUnits/{suggested_ad_unit_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchApproveSuggestedAdUnitsResponse BatchApproveSuggestedAdUnits(NetworkName parent, scg::IEnumerable<SuggestedAdUnitName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchApproveSuggestedAdUnits(new BatchApproveSuggestedAdUnitsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SuggestedAdUnitNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Bulk approve `SuggestedAdUnit` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the `SuggestedAdUnit` objects to approve.
        /// Format: `networks/{network_code}/suggestedAdUnits/{suggested_ad_unit_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchApproveSuggestedAdUnitsResponse> BatchApproveSuggestedAdUnitsAsync(NetworkName parent, scg::IEnumerable<SuggestedAdUnitName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchApproveSuggestedAdUnitsAsync(new BatchApproveSuggestedAdUnitsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SuggestedAdUnitNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Bulk approve `SuggestedAdUnit` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the `SuggestedAdUnit` objects to approve.
        /// Format: `networks/{network_code}/suggestedAdUnits/{suggested_ad_unit_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchApproveSuggestedAdUnitsResponse> BatchApproveSuggestedAdUnitsAsync(NetworkName parent, scg::IEnumerable<SuggestedAdUnitName> names, st::CancellationToken cancellationToken) =>
            BatchApproveSuggestedAdUnitsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>SuggestedAdUnitService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `SuggestedAdUnit` objects.
    /// </remarks>
    public sealed partial class SuggestedAdUnitServiceClientImpl : SuggestedAdUnitServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetSuggestedAdUnitRequest, SuggestedAdUnit> _callGetSuggestedAdUnit;

        private readonly gaxgrpc::ApiCall<ListSuggestedAdUnitsRequest, ListSuggestedAdUnitsResponse> _callListSuggestedAdUnits;

        private readonly gaxgrpc::ApiCall<BatchApproveSuggestedAdUnitsRequest, BatchApproveSuggestedAdUnitsResponse> _callBatchApproveSuggestedAdUnits;

        /// <summary>
        /// Constructs a client wrapper for the SuggestedAdUnitService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="SuggestedAdUnitServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public SuggestedAdUnitServiceClientImpl(SuggestedAdUnitService.SuggestedAdUnitServiceClient grpcClient, SuggestedAdUnitServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            SuggestedAdUnitServiceSettings effectiveSettings = settings ?? SuggestedAdUnitServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetSuggestedAdUnit = clientHelper.BuildApiCall<GetSuggestedAdUnitRequest, SuggestedAdUnit>("GetSuggestedAdUnit", grpcClient.GetSuggestedAdUnitAsync, grpcClient.GetSuggestedAdUnit, effectiveSettings.GetSuggestedAdUnitSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSuggestedAdUnit);
            Modify_GetSuggestedAdUnitApiCall(ref _callGetSuggestedAdUnit);
            _callListSuggestedAdUnits = clientHelper.BuildApiCall<ListSuggestedAdUnitsRequest, ListSuggestedAdUnitsResponse>("ListSuggestedAdUnits", grpcClient.ListSuggestedAdUnitsAsync, grpcClient.ListSuggestedAdUnits, effectiveSettings.ListSuggestedAdUnitsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSuggestedAdUnits);
            Modify_ListSuggestedAdUnitsApiCall(ref _callListSuggestedAdUnits);
            _callBatchApproveSuggestedAdUnits = clientHelper.BuildApiCall<BatchApproveSuggestedAdUnitsRequest, BatchApproveSuggestedAdUnitsResponse>("BatchApproveSuggestedAdUnits", grpcClient.BatchApproveSuggestedAdUnitsAsync, grpcClient.BatchApproveSuggestedAdUnits, effectiveSettings.BatchApproveSuggestedAdUnitsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchApproveSuggestedAdUnits);
            Modify_BatchApproveSuggestedAdUnitsApiCall(ref _callBatchApproveSuggestedAdUnits);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetSuggestedAdUnitApiCall(ref gaxgrpc::ApiCall<GetSuggestedAdUnitRequest, SuggestedAdUnit> call);

        partial void Modify_ListSuggestedAdUnitsApiCall(ref gaxgrpc::ApiCall<ListSuggestedAdUnitsRequest, ListSuggestedAdUnitsResponse> call);

        partial void Modify_BatchApproveSuggestedAdUnitsApiCall(ref gaxgrpc::ApiCall<BatchApproveSuggestedAdUnitsRequest, BatchApproveSuggestedAdUnitsResponse> call);

        partial void OnConstruction(SuggestedAdUnitService.SuggestedAdUnitServiceClient grpcClient, SuggestedAdUnitServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SuggestedAdUnitService client</summary>
        public override SuggestedAdUnitService.SuggestedAdUnitServiceClient GrpcClient { get; }

        partial void Modify_GetSuggestedAdUnitRequest(ref GetSuggestedAdUnitRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSuggestedAdUnitsRequest(ref ListSuggestedAdUnitsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchApproveSuggestedAdUnitsRequest(ref BatchApproveSuggestedAdUnitsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Get a `SuggestedAdUnit` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SuggestedAdUnit GetSuggestedAdUnit(GetSuggestedAdUnitRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSuggestedAdUnitRequest(ref request, ref callSettings);
            return _callGetSuggestedAdUnit.Sync(request, callSettings);
        }

        /// <summary>
        /// Get a `SuggestedAdUnit` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SuggestedAdUnit> GetSuggestedAdUnitAsync(GetSuggestedAdUnitRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSuggestedAdUnitRequest(ref request, ref callSettings);
            return _callGetSuggestedAdUnit.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieve a list of `SuggestedAdUnit` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SuggestedAdUnit"/> resources.</returns>
        public override gax::PagedEnumerable<ListSuggestedAdUnitsResponse, SuggestedAdUnit> ListSuggestedAdUnits(ListSuggestedAdUnitsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSuggestedAdUnitsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSuggestedAdUnitsRequest, ListSuggestedAdUnitsResponse, SuggestedAdUnit>(_callListSuggestedAdUnits, request, callSettings);
        }

        /// <summary>
        /// Retrieve a list of `SuggestedAdUnit` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SuggestedAdUnit"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSuggestedAdUnitsResponse, SuggestedAdUnit> ListSuggestedAdUnitsAsync(ListSuggestedAdUnitsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSuggestedAdUnitsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSuggestedAdUnitsRequest, ListSuggestedAdUnitsResponse, SuggestedAdUnit>(_callListSuggestedAdUnits, request, callSettings);
        }

        /// <summary>
        /// Bulk approve `SuggestedAdUnit` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchApproveSuggestedAdUnitsResponse BatchApproveSuggestedAdUnits(BatchApproveSuggestedAdUnitsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchApproveSuggestedAdUnitsRequest(ref request, ref callSettings);
            return _callBatchApproveSuggestedAdUnits.Sync(request, callSettings);
        }

        /// <summary>
        /// Bulk approve `SuggestedAdUnit` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchApproveSuggestedAdUnitsResponse> BatchApproveSuggestedAdUnitsAsync(BatchApproveSuggestedAdUnitsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchApproveSuggestedAdUnitsRequest(ref request, ref callSettings);
            return _callBatchApproveSuggestedAdUnits.Async(request, callSettings);
        }
    }

    public partial class ListSuggestedAdUnitsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSuggestedAdUnitsResponse : gaxgrpc::IPageResponse<SuggestedAdUnit>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<SuggestedAdUnit> GetEnumerator() => SuggestedAdUnits.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
