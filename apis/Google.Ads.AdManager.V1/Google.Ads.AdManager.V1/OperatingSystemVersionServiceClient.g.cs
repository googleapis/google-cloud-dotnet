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

namespace Google.Ads.AdManager.V1
{
    /// <summary>Settings for <see cref="OperatingSystemVersionServiceClient"/> instances.</summary>
    public sealed partial class OperatingSystemVersionServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="OperatingSystemVersionServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="OperatingSystemVersionServiceSettings"/>.</returns>
        public static OperatingSystemVersionServiceSettings GetDefault() => new OperatingSystemVersionServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="OperatingSystemVersionServiceSettings"/> object with default settings.
        /// </summary>
        public OperatingSystemVersionServiceSettings()
        {
        }

        private OperatingSystemVersionServiceSettings(OperatingSystemVersionServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetOperatingSystemVersionSettings = existing.GetOperatingSystemVersionSettings;
            ListOperatingSystemVersionsSettings = existing.ListOperatingSystemVersionsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(OperatingSystemVersionServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OperatingSystemVersionServiceClient.GetOperatingSystemVersion</c> and
        /// <c>OperatingSystemVersionServiceClient.GetOperatingSystemVersionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetOperatingSystemVersionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OperatingSystemVersionServiceClient.ListOperatingSystemVersions</c> and
        /// <c>OperatingSystemVersionServiceClient.ListOperatingSystemVersionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListOperatingSystemVersionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="OperatingSystemVersionServiceSettings"/> object.</returns>
        public OperatingSystemVersionServiceSettings Clone() => new OperatingSystemVersionServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="OperatingSystemVersionServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class OperatingSystemVersionServiceClientBuilder : gaxgrpc::ClientBuilderBase<OperatingSystemVersionServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public OperatingSystemVersionServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public OperatingSystemVersionServiceClientBuilder() : base(OperatingSystemVersionServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref OperatingSystemVersionServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<OperatingSystemVersionServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override OperatingSystemVersionServiceClient Build()
        {
            OperatingSystemVersionServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<OperatingSystemVersionServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<OperatingSystemVersionServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private OperatingSystemVersionServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return OperatingSystemVersionServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<OperatingSystemVersionServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return OperatingSystemVersionServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => OperatingSystemVersionServiceClient.ChannelPool;
    }

    /// <summary>OperatingSystemVersionService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `OperatingSystemVersion` objects.
    /// </remarks>
    public abstract partial class OperatingSystemVersionServiceClient
    {
        /// <summary>
        /// The default endpoint for the OperatingSystemVersionService service, which is a host of
        /// "admanager.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default OperatingSystemVersionService scopes.</summary>
        /// <remarks>
        /// The default OperatingSystemVersionService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/admanager</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/admanager",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(OperatingSystemVersionService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="OperatingSystemVersionServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="OperatingSystemVersionServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="OperatingSystemVersionServiceClient"/>.</returns>
        public static stt::Task<OperatingSystemVersionServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new OperatingSystemVersionServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="OperatingSystemVersionServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="OperatingSystemVersionServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="OperatingSystemVersionServiceClient"/>.</returns>
        public static OperatingSystemVersionServiceClient Create() =>
            new OperatingSystemVersionServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="OperatingSystemVersionServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="OperatingSystemVersionServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="OperatingSystemVersionServiceClient"/>.</returns>
        internal static OperatingSystemVersionServiceClient Create(grpccore::CallInvoker callInvoker, OperatingSystemVersionServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            OperatingSystemVersionService.OperatingSystemVersionServiceClient grpcClient = new OperatingSystemVersionService.OperatingSystemVersionServiceClient(callInvoker);
            return new OperatingSystemVersionServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC OperatingSystemVersionService client</summary>
        public virtual OperatingSystemVersionService.OperatingSystemVersionServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `OperatingSystemVersion` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual OperatingSystemVersion GetOperatingSystemVersion(GetOperatingSystemVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `OperatingSystemVersion` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OperatingSystemVersion> GetOperatingSystemVersionAsync(GetOperatingSystemVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `OperatingSystemVersion` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OperatingSystemVersion> GetOperatingSystemVersionAsync(GetOperatingSystemVersionRequest request, st::CancellationToken cancellationToken) =>
            GetOperatingSystemVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `OperatingSystemVersion` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the OperatingSystemVersion.
        /// Format:
        /// `networks/{network_code}/operatingSystemVersions/{operating_system_version_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual OperatingSystemVersion GetOperatingSystemVersion(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetOperatingSystemVersion(new GetOperatingSystemVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `OperatingSystemVersion` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the OperatingSystemVersion.
        /// Format:
        /// `networks/{network_code}/operatingSystemVersions/{operating_system_version_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OperatingSystemVersion> GetOperatingSystemVersionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetOperatingSystemVersionAsync(new GetOperatingSystemVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `OperatingSystemVersion` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the OperatingSystemVersion.
        /// Format:
        /// `networks/{network_code}/operatingSystemVersions/{operating_system_version_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OperatingSystemVersion> GetOperatingSystemVersionAsync(string name, st::CancellationToken cancellationToken) =>
            GetOperatingSystemVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `OperatingSystemVersion` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the OperatingSystemVersion.
        /// Format:
        /// `networks/{network_code}/operatingSystemVersions/{operating_system_version_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual OperatingSystemVersion GetOperatingSystemVersion(OperatingSystemVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetOperatingSystemVersion(new GetOperatingSystemVersionRequest
            {
                OperatingSystemVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `OperatingSystemVersion` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the OperatingSystemVersion.
        /// Format:
        /// `networks/{network_code}/operatingSystemVersions/{operating_system_version_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OperatingSystemVersion> GetOperatingSystemVersionAsync(OperatingSystemVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetOperatingSystemVersionAsync(new GetOperatingSystemVersionRequest
            {
                OperatingSystemVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `OperatingSystemVersion` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the OperatingSystemVersion.
        /// Format:
        /// `networks/{network_code}/operatingSystemVersions/{operating_system_version_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OperatingSystemVersion> GetOperatingSystemVersionAsync(OperatingSystemVersionName name, st::CancellationToken cancellationToken) =>
            GetOperatingSystemVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a list of `OperatingSystemVersion` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="OperatingSystemVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOperatingSystemVersionsResponse, OperatingSystemVersion> ListOperatingSystemVersions(ListOperatingSystemVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `OperatingSystemVersion` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="OperatingSystemVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOperatingSystemVersionsResponse, OperatingSystemVersion> ListOperatingSystemVersionsAsync(ListOperatingSystemVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `OperatingSystemVersion` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of
        /// OperatingSystemVersions. Format: `networks/{network_code}`
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
        /// <returns>A pageable sequence of <see cref="OperatingSystemVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOperatingSystemVersionsResponse, OperatingSystemVersion> ListOperatingSystemVersions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOperatingSystemVersionsRequest request = new ListOperatingSystemVersionsRequest
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
            return ListOperatingSystemVersions(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `OperatingSystemVersion` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of
        /// OperatingSystemVersions. Format: `networks/{network_code}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="OperatingSystemVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOperatingSystemVersionsResponse, OperatingSystemVersion> ListOperatingSystemVersionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOperatingSystemVersionsRequest request = new ListOperatingSystemVersionsRequest
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
            return ListOperatingSystemVersionsAsync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `OperatingSystemVersion` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of
        /// OperatingSystemVersions. Format: `networks/{network_code}`
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
        /// <returns>A pageable sequence of <see cref="OperatingSystemVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOperatingSystemVersionsResponse, OperatingSystemVersion> ListOperatingSystemVersions(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOperatingSystemVersionsRequest request = new ListOperatingSystemVersionsRequest
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
            return ListOperatingSystemVersions(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `OperatingSystemVersion` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of
        /// OperatingSystemVersions. Format: `networks/{network_code}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="OperatingSystemVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOperatingSystemVersionsResponse, OperatingSystemVersion> ListOperatingSystemVersionsAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOperatingSystemVersionsRequest request = new ListOperatingSystemVersionsRequest
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
            return ListOperatingSystemVersionsAsync(request, callSettings);
        }
    }

    /// <summary>OperatingSystemVersionService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `OperatingSystemVersion` objects.
    /// </remarks>
    public sealed partial class OperatingSystemVersionServiceClientImpl : OperatingSystemVersionServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetOperatingSystemVersionRequest, OperatingSystemVersion> _callGetOperatingSystemVersion;

        private readonly gaxgrpc::ApiCall<ListOperatingSystemVersionsRequest, ListOperatingSystemVersionsResponse> _callListOperatingSystemVersions;

        /// <summary>
        /// Constructs a client wrapper for the OperatingSystemVersionService service, with the specified gRPC client
        /// and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="OperatingSystemVersionServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public OperatingSystemVersionServiceClientImpl(OperatingSystemVersionService.OperatingSystemVersionServiceClient grpcClient, OperatingSystemVersionServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            OperatingSystemVersionServiceSettings effectiveSettings = settings ?? OperatingSystemVersionServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetOperatingSystemVersion = clientHelper.BuildApiCall<GetOperatingSystemVersionRequest, OperatingSystemVersion>("GetOperatingSystemVersion", grpcClient.GetOperatingSystemVersionAsync, grpcClient.GetOperatingSystemVersion, effectiveSettings.GetOperatingSystemVersionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetOperatingSystemVersion);
            Modify_GetOperatingSystemVersionApiCall(ref _callGetOperatingSystemVersion);
            _callListOperatingSystemVersions = clientHelper.BuildApiCall<ListOperatingSystemVersionsRequest, ListOperatingSystemVersionsResponse>("ListOperatingSystemVersions", grpcClient.ListOperatingSystemVersionsAsync, grpcClient.ListOperatingSystemVersions, effectiveSettings.ListOperatingSystemVersionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListOperatingSystemVersions);
            Modify_ListOperatingSystemVersionsApiCall(ref _callListOperatingSystemVersions);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetOperatingSystemVersionApiCall(ref gaxgrpc::ApiCall<GetOperatingSystemVersionRequest, OperatingSystemVersion> call);

        partial void Modify_ListOperatingSystemVersionsApiCall(ref gaxgrpc::ApiCall<ListOperatingSystemVersionsRequest, ListOperatingSystemVersionsResponse> call);

        partial void OnConstruction(OperatingSystemVersionService.OperatingSystemVersionServiceClient grpcClient, OperatingSystemVersionServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC OperatingSystemVersionService client</summary>
        public override OperatingSystemVersionService.OperatingSystemVersionServiceClient GrpcClient { get; }

        partial void Modify_GetOperatingSystemVersionRequest(ref GetOperatingSystemVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListOperatingSystemVersionsRequest(ref ListOperatingSystemVersionsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// API to retrieve a `OperatingSystemVersion` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override OperatingSystemVersion GetOperatingSystemVersion(GetOperatingSystemVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOperatingSystemVersionRequest(ref request, ref callSettings);
            return _callGetOperatingSystemVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a `OperatingSystemVersion` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<OperatingSystemVersion> GetOperatingSystemVersionAsync(GetOperatingSystemVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOperatingSystemVersionRequest(ref request, ref callSettings);
            return _callGetOperatingSystemVersion.Async(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `OperatingSystemVersion` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="OperatingSystemVersion"/> resources.</returns>
        public override gax::PagedEnumerable<ListOperatingSystemVersionsResponse, OperatingSystemVersion> ListOperatingSystemVersions(ListOperatingSystemVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOperatingSystemVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListOperatingSystemVersionsRequest, ListOperatingSystemVersionsResponse, OperatingSystemVersion>(_callListOperatingSystemVersions, request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `OperatingSystemVersion` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="OperatingSystemVersion"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListOperatingSystemVersionsResponse, OperatingSystemVersion> ListOperatingSystemVersionsAsync(ListOperatingSystemVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOperatingSystemVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListOperatingSystemVersionsRequest, ListOperatingSystemVersionsResponse, OperatingSystemVersion>(_callListOperatingSystemVersions, request, callSettings);
        }
    }

    public partial class ListOperatingSystemVersionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListOperatingSystemVersionsResponse : gaxgrpc::IPageResponse<OperatingSystemVersion>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<OperatingSystemVersion> GetEnumerator() => OperatingSystemVersions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
