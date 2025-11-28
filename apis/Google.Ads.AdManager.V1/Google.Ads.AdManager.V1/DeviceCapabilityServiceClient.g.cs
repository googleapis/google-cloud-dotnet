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
    /// <summary>Settings for <see cref="DeviceCapabilityServiceClient"/> instances.</summary>
    public sealed partial class DeviceCapabilityServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DeviceCapabilityServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DeviceCapabilityServiceSettings"/>.</returns>
        public static DeviceCapabilityServiceSettings GetDefault() => new DeviceCapabilityServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="DeviceCapabilityServiceSettings"/> object with default settings.
        /// </summary>
        public DeviceCapabilityServiceSettings()
        {
        }

        private DeviceCapabilityServiceSettings(DeviceCapabilityServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetDeviceCapabilitySettings = existing.GetDeviceCapabilitySettings;
            ListDeviceCapabilitiesSettings = existing.ListDeviceCapabilitiesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DeviceCapabilityServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeviceCapabilityServiceClient.GetDeviceCapability</c> and
        /// <c>DeviceCapabilityServiceClient.GetDeviceCapabilityAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDeviceCapabilitySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeviceCapabilityServiceClient.ListDeviceCapabilities</c> and
        /// <c>DeviceCapabilityServiceClient.ListDeviceCapabilitiesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDeviceCapabilitiesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DeviceCapabilityServiceSettings"/> object.</returns>
        public DeviceCapabilityServiceSettings Clone() => new DeviceCapabilityServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DeviceCapabilityServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class DeviceCapabilityServiceClientBuilder : gaxgrpc::ClientBuilderBase<DeviceCapabilityServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DeviceCapabilityServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DeviceCapabilityServiceClientBuilder() : base(DeviceCapabilityServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DeviceCapabilityServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DeviceCapabilityServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DeviceCapabilityServiceClient Build()
        {
            DeviceCapabilityServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DeviceCapabilityServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DeviceCapabilityServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DeviceCapabilityServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DeviceCapabilityServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DeviceCapabilityServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DeviceCapabilityServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DeviceCapabilityServiceClient.ChannelPool;
    }

    /// <summary>DeviceCapabilityService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `DeviceCapability` objects.
    /// </remarks>
    public abstract partial class DeviceCapabilityServiceClient
    {
        /// <summary>
        /// The default endpoint for the DeviceCapabilityService service, which is a host of "admanager.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default DeviceCapabilityService scopes.</summary>
        /// <remarks>
        /// The default DeviceCapabilityService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/admanager</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/admanager",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(DeviceCapabilityService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DeviceCapabilityServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="DeviceCapabilityServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DeviceCapabilityServiceClient"/>.</returns>
        public static stt::Task<DeviceCapabilityServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DeviceCapabilityServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DeviceCapabilityServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="DeviceCapabilityServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DeviceCapabilityServiceClient"/>.</returns>
        public static DeviceCapabilityServiceClient Create() => new DeviceCapabilityServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DeviceCapabilityServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DeviceCapabilityServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DeviceCapabilityServiceClient"/>.</returns>
        internal static DeviceCapabilityServiceClient Create(grpccore::CallInvoker callInvoker, DeviceCapabilityServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DeviceCapabilityService.DeviceCapabilityServiceClient grpcClient = new DeviceCapabilityService.DeviceCapabilityServiceClient(callInvoker);
            return new DeviceCapabilityServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC DeviceCapabilityService client</summary>
        public virtual DeviceCapabilityService.DeviceCapabilityServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `DeviceCapability` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeviceCapability GetDeviceCapability(GetDeviceCapabilityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `DeviceCapability` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceCapability> GetDeviceCapabilityAsync(GetDeviceCapabilityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `DeviceCapability` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceCapability> GetDeviceCapabilityAsync(GetDeviceCapabilityRequest request, st::CancellationToken cancellationToken) =>
            GetDeviceCapabilityAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `DeviceCapability` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DeviceCapability.
        /// Format: `networks/{network_code}/deviceCapabilities/{device_capability_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeviceCapability GetDeviceCapability(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeviceCapability(new GetDeviceCapabilityRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `DeviceCapability` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DeviceCapability.
        /// Format: `networks/{network_code}/deviceCapabilities/{device_capability_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceCapability> GetDeviceCapabilityAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeviceCapabilityAsync(new GetDeviceCapabilityRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `DeviceCapability` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DeviceCapability.
        /// Format: `networks/{network_code}/deviceCapabilities/{device_capability_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceCapability> GetDeviceCapabilityAsync(string name, st::CancellationToken cancellationToken) =>
            GetDeviceCapabilityAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `DeviceCapability` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DeviceCapability.
        /// Format: `networks/{network_code}/deviceCapabilities/{device_capability_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeviceCapability GetDeviceCapability(DeviceCapabilityName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeviceCapability(new GetDeviceCapabilityRequest
            {
                DeviceCapabilityName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `DeviceCapability` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DeviceCapability.
        /// Format: `networks/{network_code}/deviceCapabilities/{device_capability_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceCapability> GetDeviceCapabilityAsync(DeviceCapabilityName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeviceCapabilityAsync(new GetDeviceCapabilityRequest
            {
                DeviceCapabilityName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `DeviceCapability` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DeviceCapability.
        /// Format: `networks/{network_code}/deviceCapabilities/{device_capability_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceCapability> GetDeviceCapabilityAsync(DeviceCapabilityName name, st::CancellationToken cancellationToken) =>
            GetDeviceCapabilityAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a list of `DeviceCapability` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DeviceCapability"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeviceCapabilitiesResponse, DeviceCapability> ListDeviceCapabilities(ListDeviceCapabilitiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `DeviceCapability` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DeviceCapability"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeviceCapabilitiesResponse, DeviceCapability> ListDeviceCapabilitiesAsync(ListDeviceCapabilitiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `DeviceCapability` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of DeviceCapabilities.
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
        /// <returns>A pageable sequence of <see cref="DeviceCapability"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeviceCapabilitiesResponse, DeviceCapability> ListDeviceCapabilities(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeviceCapabilitiesRequest request = new ListDeviceCapabilitiesRequest
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
            return ListDeviceCapabilities(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `DeviceCapability` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of DeviceCapabilities.
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
        /// <returns>A pageable asynchronous sequence of <see cref="DeviceCapability"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeviceCapabilitiesResponse, DeviceCapability> ListDeviceCapabilitiesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeviceCapabilitiesRequest request = new ListDeviceCapabilitiesRequest
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
            return ListDeviceCapabilitiesAsync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `DeviceCapability` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of DeviceCapabilities.
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
        /// <returns>A pageable sequence of <see cref="DeviceCapability"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeviceCapabilitiesResponse, DeviceCapability> ListDeviceCapabilities(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeviceCapabilitiesRequest request = new ListDeviceCapabilitiesRequest
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
            return ListDeviceCapabilities(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `DeviceCapability` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of DeviceCapabilities.
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
        /// <returns>A pageable asynchronous sequence of <see cref="DeviceCapability"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeviceCapabilitiesResponse, DeviceCapability> ListDeviceCapabilitiesAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeviceCapabilitiesRequest request = new ListDeviceCapabilitiesRequest
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
            return ListDeviceCapabilitiesAsync(request, callSettings);
        }
    }

    /// <summary>DeviceCapabilityService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `DeviceCapability` objects.
    /// </remarks>
    public sealed partial class DeviceCapabilityServiceClientImpl : DeviceCapabilityServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetDeviceCapabilityRequest, DeviceCapability> _callGetDeviceCapability;

        private readonly gaxgrpc::ApiCall<ListDeviceCapabilitiesRequest, ListDeviceCapabilitiesResponse> _callListDeviceCapabilities;

        /// <summary>
        /// Constructs a client wrapper for the DeviceCapabilityService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="DeviceCapabilityServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DeviceCapabilityServiceClientImpl(DeviceCapabilityService.DeviceCapabilityServiceClient grpcClient, DeviceCapabilityServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DeviceCapabilityServiceSettings effectiveSettings = settings ?? DeviceCapabilityServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetDeviceCapability = clientHelper.BuildApiCall<GetDeviceCapabilityRequest, DeviceCapability>("GetDeviceCapability", grpcClient.GetDeviceCapabilityAsync, grpcClient.GetDeviceCapability, effectiveSettings.GetDeviceCapabilitySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDeviceCapability);
            Modify_GetDeviceCapabilityApiCall(ref _callGetDeviceCapability);
            _callListDeviceCapabilities = clientHelper.BuildApiCall<ListDeviceCapabilitiesRequest, ListDeviceCapabilitiesResponse>("ListDeviceCapabilities", grpcClient.ListDeviceCapabilitiesAsync, grpcClient.ListDeviceCapabilities, effectiveSettings.ListDeviceCapabilitiesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDeviceCapabilities);
            Modify_ListDeviceCapabilitiesApiCall(ref _callListDeviceCapabilities);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetDeviceCapabilityApiCall(ref gaxgrpc::ApiCall<GetDeviceCapabilityRequest, DeviceCapability> call);

        partial void Modify_ListDeviceCapabilitiesApiCall(ref gaxgrpc::ApiCall<ListDeviceCapabilitiesRequest, ListDeviceCapabilitiesResponse> call);

        partial void OnConstruction(DeviceCapabilityService.DeviceCapabilityServiceClient grpcClient, DeviceCapabilityServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DeviceCapabilityService client</summary>
        public override DeviceCapabilityService.DeviceCapabilityServiceClient GrpcClient { get; }

        partial void Modify_GetDeviceCapabilityRequest(ref GetDeviceCapabilityRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDeviceCapabilitiesRequest(ref ListDeviceCapabilitiesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// API to retrieve a `DeviceCapability` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DeviceCapability GetDeviceCapability(GetDeviceCapabilityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDeviceCapabilityRequest(ref request, ref callSettings);
            return _callGetDeviceCapability.Sync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a `DeviceCapability` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DeviceCapability> GetDeviceCapabilityAsync(GetDeviceCapabilityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDeviceCapabilityRequest(ref request, ref callSettings);
            return _callGetDeviceCapability.Async(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `DeviceCapability` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DeviceCapability"/> resources.</returns>
        public override gax::PagedEnumerable<ListDeviceCapabilitiesResponse, DeviceCapability> ListDeviceCapabilities(ListDeviceCapabilitiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDeviceCapabilitiesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDeviceCapabilitiesRequest, ListDeviceCapabilitiesResponse, DeviceCapability>(_callListDeviceCapabilities, request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `DeviceCapability` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DeviceCapability"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDeviceCapabilitiesResponse, DeviceCapability> ListDeviceCapabilitiesAsync(ListDeviceCapabilitiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDeviceCapabilitiesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDeviceCapabilitiesRequest, ListDeviceCapabilitiesResponse, DeviceCapability>(_callListDeviceCapabilities, request, callSettings);
        }
    }

    public partial class ListDeviceCapabilitiesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDeviceCapabilitiesResponse : gaxgrpc::IPageResponse<DeviceCapability>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DeviceCapability> GetEnumerator() => DeviceCapabilities.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
