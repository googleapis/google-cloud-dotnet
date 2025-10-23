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
    /// <summary>Settings for <see cref="MobileDeviceServiceClient"/> instances.</summary>
    public sealed partial class MobileDeviceServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="MobileDeviceServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="MobileDeviceServiceSettings"/>.</returns>
        public static MobileDeviceServiceSettings GetDefault() => new MobileDeviceServiceSettings();

        /// <summary>Constructs a new <see cref="MobileDeviceServiceSettings"/> object with default settings.</summary>
        public MobileDeviceServiceSettings()
        {
        }

        private MobileDeviceServiceSettings(MobileDeviceServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetMobileDeviceSettings = existing.GetMobileDeviceSettings;
            ListMobileDevicesSettings = existing.ListMobileDevicesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(MobileDeviceServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MobileDeviceServiceClient.GetMobileDevice</c> and <c>MobileDeviceServiceClient.GetMobileDeviceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetMobileDeviceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MobileDeviceServiceClient.ListMobileDevices</c> and <c>MobileDeviceServiceClient.ListMobileDevicesAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListMobileDevicesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="MobileDeviceServiceSettings"/> object.</returns>
        public MobileDeviceServiceSettings Clone() => new MobileDeviceServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="MobileDeviceServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class MobileDeviceServiceClientBuilder : gaxgrpc::ClientBuilderBase<MobileDeviceServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public MobileDeviceServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public MobileDeviceServiceClientBuilder() : base(MobileDeviceServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref MobileDeviceServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<MobileDeviceServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override MobileDeviceServiceClient Build()
        {
            MobileDeviceServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<MobileDeviceServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<MobileDeviceServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private MobileDeviceServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return MobileDeviceServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<MobileDeviceServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return MobileDeviceServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => MobileDeviceServiceClient.ChannelPool;
    }

    /// <summary>MobileDeviceService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `MobileDevice` objects.
    /// </remarks>
    public abstract partial class MobileDeviceServiceClient
    {
        /// <summary>
        /// The default endpoint for the MobileDeviceService service, which is a host of "admanager.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default MobileDeviceService scopes.</summary>
        /// <remarks>
        /// The default MobileDeviceService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/admanager</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/admanager",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(MobileDeviceService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="MobileDeviceServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="MobileDeviceServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="MobileDeviceServiceClient"/>.</returns>
        public static stt::Task<MobileDeviceServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new MobileDeviceServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="MobileDeviceServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="MobileDeviceServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="MobileDeviceServiceClient"/>.</returns>
        public static MobileDeviceServiceClient Create() => new MobileDeviceServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="MobileDeviceServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="MobileDeviceServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="MobileDeviceServiceClient"/>.</returns>
        internal static MobileDeviceServiceClient Create(grpccore::CallInvoker callInvoker, MobileDeviceServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            MobileDeviceService.MobileDeviceServiceClient grpcClient = new MobileDeviceService.MobileDeviceServiceClient(callInvoker);
            return new MobileDeviceServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC MobileDeviceService client</summary>
        public virtual MobileDeviceService.MobileDeviceServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `MobileDevice` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MobileDevice GetMobileDevice(GetMobileDeviceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `MobileDevice` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MobileDevice> GetMobileDeviceAsync(GetMobileDeviceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `MobileDevice` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MobileDevice> GetMobileDeviceAsync(GetMobileDeviceRequest request, st::CancellationToken cancellationToken) =>
            GetMobileDeviceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `MobileDevice` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the MobileDevice.
        /// Format: `networks/{network_code}/mobileDevices/{mobile_device_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MobileDevice GetMobileDevice(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMobileDevice(new GetMobileDeviceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `MobileDevice` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the MobileDevice.
        /// Format: `networks/{network_code}/mobileDevices/{mobile_device_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MobileDevice> GetMobileDeviceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMobileDeviceAsync(new GetMobileDeviceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `MobileDevice` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the MobileDevice.
        /// Format: `networks/{network_code}/mobileDevices/{mobile_device_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MobileDevice> GetMobileDeviceAsync(string name, st::CancellationToken cancellationToken) =>
            GetMobileDeviceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `MobileDevice` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the MobileDevice.
        /// Format: `networks/{network_code}/mobileDevices/{mobile_device_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MobileDevice GetMobileDevice(MobileDeviceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMobileDevice(new GetMobileDeviceRequest
            {
                MobileDeviceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `MobileDevice` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the MobileDevice.
        /// Format: `networks/{network_code}/mobileDevices/{mobile_device_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MobileDevice> GetMobileDeviceAsync(MobileDeviceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMobileDeviceAsync(new GetMobileDeviceRequest
            {
                MobileDeviceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `MobileDevice` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the MobileDevice.
        /// Format: `networks/{network_code}/mobileDevices/{mobile_device_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MobileDevice> GetMobileDeviceAsync(MobileDeviceName name, st::CancellationToken cancellationToken) =>
            GetMobileDeviceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a list of `MobileDevice` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MobileDevice"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMobileDevicesResponse, MobileDevice> ListMobileDevices(ListMobileDevicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `MobileDevice` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MobileDevice"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMobileDevicesResponse, MobileDevice> ListMobileDevicesAsync(ListMobileDevicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `MobileDevice` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of MobileDevices.
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
        /// <returns>A pageable sequence of <see cref="MobileDevice"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMobileDevicesResponse, MobileDevice> ListMobileDevices(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMobileDevicesRequest request = new ListMobileDevicesRequest
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
            return ListMobileDevices(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `MobileDevice` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of MobileDevices.
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
        /// <returns>A pageable asynchronous sequence of <see cref="MobileDevice"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMobileDevicesResponse, MobileDevice> ListMobileDevicesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMobileDevicesRequest request = new ListMobileDevicesRequest
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
            return ListMobileDevicesAsync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `MobileDevice` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of MobileDevices.
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
        /// <returns>A pageable sequence of <see cref="MobileDevice"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMobileDevicesResponse, MobileDevice> ListMobileDevices(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMobileDevicesRequest request = new ListMobileDevicesRequest
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
            return ListMobileDevices(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `MobileDevice` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of MobileDevices.
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
        /// <returns>A pageable asynchronous sequence of <see cref="MobileDevice"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMobileDevicesResponse, MobileDevice> ListMobileDevicesAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMobileDevicesRequest request = new ListMobileDevicesRequest
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
            return ListMobileDevicesAsync(request, callSettings);
        }
    }

    /// <summary>MobileDeviceService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `MobileDevice` objects.
    /// </remarks>
    public sealed partial class MobileDeviceServiceClientImpl : MobileDeviceServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetMobileDeviceRequest, MobileDevice> _callGetMobileDevice;

        private readonly gaxgrpc::ApiCall<ListMobileDevicesRequest, ListMobileDevicesResponse> _callListMobileDevices;

        /// <summary>
        /// Constructs a client wrapper for the MobileDeviceService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="MobileDeviceServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public MobileDeviceServiceClientImpl(MobileDeviceService.MobileDeviceServiceClient grpcClient, MobileDeviceServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            MobileDeviceServiceSettings effectiveSettings = settings ?? MobileDeviceServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetMobileDevice = clientHelper.BuildApiCall<GetMobileDeviceRequest, MobileDevice>("GetMobileDevice", grpcClient.GetMobileDeviceAsync, grpcClient.GetMobileDevice, effectiveSettings.GetMobileDeviceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetMobileDevice);
            Modify_GetMobileDeviceApiCall(ref _callGetMobileDevice);
            _callListMobileDevices = clientHelper.BuildApiCall<ListMobileDevicesRequest, ListMobileDevicesResponse>("ListMobileDevices", grpcClient.ListMobileDevicesAsync, grpcClient.ListMobileDevices, effectiveSettings.ListMobileDevicesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListMobileDevices);
            Modify_ListMobileDevicesApiCall(ref _callListMobileDevices);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetMobileDeviceApiCall(ref gaxgrpc::ApiCall<GetMobileDeviceRequest, MobileDevice> call);

        partial void Modify_ListMobileDevicesApiCall(ref gaxgrpc::ApiCall<ListMobileDevicesRequest, ListMobileDevicesResponse> call);

        partial void OnConstruction(MobileDeviceService.MobileDeviceServiceClient grpcClient, MobileDeviceServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC MobileDeviceService client</summary>
        public override MobileDeviceService.MobileDeviceServiceClient GrpcClient { get; }

        partial void Modify_GetMobileDeviceRequest(ref GetMobileDeviceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListMobileDevicesRequest(ref ListMobileDevicesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// API to retrieve a `MobileDevice` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MobileDevice GetMobileDevice(GetMobileDeviceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMobileDeviceRequest(ref request, ref callSettings);
            return _callGetMobileDevice.Sync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a `MobileDevice` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MobileDevice> GetMobileDeviceAsync(GetMobileDeviceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMobileDeviceRequest(ref request, ref callSettings);
            return _callGetMobileDevice.Async(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `MobileDevice` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MobileDevice"/> resources.</returns>
        public override gax::PagedEnumerable<ListMobileDevicesResponse, MobileDevice> ListMobileDevices(ListMobileDevicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMobileDevicesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListMobileDevicesRequest, ListMobileDevicesResponse, MobileDevice>(_callListMobileDevices, request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `MobileDevice` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MobileDevice"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListMobileDevicesResponse, MobileDevice> ListMobileDevicesAsync(ListMobileDevicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMobileDevicesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListMobileDevicesRequest, ListMobileDevicesResponse, MobileDevice>(_callListMobileDevices, request, callSettings);
        }
    }

    public partial class ListMobileDevicesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListMobileDevicesResponse : gaxgrpc::IPageResponse<MobileDevice>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<MobileDevice> GetEnumerator() => MobileDevices.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
