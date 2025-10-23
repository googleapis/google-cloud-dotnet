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
    /// <summary>Settings for <see cref="DeviceManufacturerServiceClient"/> instances.</summary>
    public sealed partial class DeviceManufacturerServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DeviceManufacturerServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DeviceManufacturerServiceSettings"/>.</returns>
        public static DeviceManufacturerServiceSettings GetDefault() => new DeviceManufacturerServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="DeviceManufacturerServiceSettings"/> object with default settings.
        /// </summary>
        public DeviceManufacturerServiceSettings()
        {
        }

        private DeviceManufacturerServiceSettings(DeviceManufacturerServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetDeviceManufacturerSettings = existing.GetDeviceManufacturerSettings;
            ListDeviceManufacturersSettings = existing.ListDeviceManufacturersSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DeviceManufacturerServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeviceManufacturerServiceClient.GetDeviceManufacturer</c> and
        /// <c>DeviceManufacturerServiceClient.GetDeviceManufacturerAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDeviceManufacturerSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeviceManufacturerServiceClient.ListDeviceManufacturers</c> and
        /// <c>DeviceManufacturerServiceClient.ListDeviceManufacturersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDeviceManufacturersSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DeviceManufacturerServiceSettings"/> object.</returns>
        public DeviceManufacturerServiceSettings Clone() => new DeviceManufacturerServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DeviceManufacturerServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class DeviceManufacturerServiceClientBuilder : gaxgrpc::ClientBuilderBase<DeviceManufacturerServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DeviceManufacturerServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DeviceManufacturerServiceClientBuilder() : base(DeviceManufacturerServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DeviceManufacturerServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DeviceManufacturerServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DeviceManufacturerServiceClient Build()
        {
            DeviceManufacturerServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DeviceManufacturerServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DeviceManufacturerServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DeviceManufacturerServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DeviceManufacturerServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DeviceManufacturerServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DeviceManufacturerServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DeviceManufacturerServiceClient.ChannelPool;
    }

    /// <summary>DeviceManufacturerService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `DeviceManufacturer` objects.
    /// </remarks>
    public abstract partial class DeviceManufacturerServiceClient
    {
        /// <summary>
        /// The default endpoint for the DeviceManufacturerService service, which is a host of
        /// "admanager.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default DeviceManufacturerService scopes.</summary>
        /// <remarks>
        /// The default DeviceManufacturerService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/admanager</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/admanager",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(DeviceManufacturerService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DeviceManufacturerServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="DeviceManufacturerServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DeviceManufacturerServiceClient"/>.</returns>
        public static stt::Task<DeviceManufacturerServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DeviceManufacturerServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DeviceManufacturerServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="DeviceManufacturerServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DeviceManufacturerServiceClient"/>.</returns>
        public static DeviceManufacturerServiceClient Create() => new DeviceManufacturerServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DeviceManufacturerServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DeviceManufacturerServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DeviceManufacturerServiceClient"/>.</returns>
        internal static DeviceManufacturerServiceClient Create(grpccore::CallInvoker callInvoker, DeviceManufacturerServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DeviceManufacturerService.DeviceManufacturerServiceClient grpcClient = new DeviceManufacturerService.DeviceManufacturerServiceClient(callInvoker);
            return new DeviceManufacturerServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC DeviceManufacturerService client</summary>
        public virtual DeviceManufacturerService.DeviceManufacturerServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `DeviceManufacturer` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeviceManufacturer GetDeviceManufacturer(GetDeviceManufacturerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `DeviceManufacturer` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceManufacturer> GetDeviceManufacturerAsync(GetDeviceManufacturerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `DeviceManufacturer` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceManufacturer> GetDeviceManufacturerAsync(GetDeviceManufacturerRequest request, st::CancellationToken cancellationToken) =>
            GetDeviceManufacturerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `DeviceManufacturer` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DeviceManufacturer.
        /// Format:
        /// `networks/{network_code}/deviceManufacturers/{device_manufacturer_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeviceManufacturer GetDeviceManufacturer(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeviceManufacturer(new GetDeviceManufacturerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `DeviceManufacturer` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DeviceManufacturer.
        /// Format:
        /// `networks/{network_code}/deviceManufacturers/{device_manufacturer_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceManufacturer> GetDeviceManufacturerAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeviceManufacturerAsync(new GetDeviceManufacturerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `DeviceManufacturer` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DeviceManufacturer.
        /// Format:
        /// `networks/{network_code}/deviceManufacturers/{device_manufacturer_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceManufacturer> GetDeviceManufacturerAsync(string name, st::CancellationToken cancellationToken) =>
            GetDeviceManufacturerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `DeviceManufacturer` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DeviceManufacturer.
        /// Format:
        /// `networks/{network_code}/deviceManufacturers/{device_manufacturer_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeviceManufacturer GetDeviceManufacturer(DeviceManufacturerName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeviceManufacturer(new GetDeviceManufacturerRequest
            {
                DeviceManufacturerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `DeviceManufacturer` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DeviceManufacturer.
        /// Format:
        /// `networks/{network_code}/deviceManufacturers/{device_manufacturer_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceManufacturer> GetDeviceManufacturerAsync(DeviceManufacturerName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeviceManufacturerAsync(new GetDeviceManufacturerRequest
            {
                DeviceManufacturerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `DeviceManufacturer` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DeviceManufacturer.
        /// Format:
        /// `networks/{network_code}/deviceManufacturers/{device_manufacturer_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceManufacturer> GetDeviceManufacturerAsync(DeviceManufacturerName name, st::CancellationToken cancellationToken) =>
            GetDeviceManufacturerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a list of `DeviceManufacturer` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DeviceManufacturer"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeviceManufacturersResponse, DeviceManufacturer> ListDeviceManufacturers(ListDeviceManufacturersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `DeviceManufacturer` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DeviceManufacturer"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeviceManufacturersResponse, DeviceManufacturer> ListDeviceManufacturersAsync(ListDeviceManufacturersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `DeviceManufacturer` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of DeviceManufacturers.
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
        /// <returns>A pageable sequence of <see cref="DeviceManufacturer"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeviceManufacturersResponse, DeviceManufacturer> ListDeviceManufacturers(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeviceManufacturersRequest request = new ListDeviceManufacturersRequest
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
            return ListDeviceManufacturers(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `DeviceManufacturer` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of DeviceManufacturers.
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
        /// <returns>A pageable asynchronous sequence of <see cref="DeviceManufacturer"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeviceManufacturersResponse, DeviceManufacturer> ListDeviceManufacturersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeviceManufacturersRequest request = new ListDeviceManufacturersRequest
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
            return ListDeviceManufacturersAsync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `DeviceManufacturer` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of DeviceManufacturers.
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
        /// <returns>A pageable sequence of <see cref="DeviceManufacturer"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeviceManufacturersResponse, DeviceManufacturer> ListDeviceManufacturers(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeviceManufacturersRequest request = new ListDeviceManufacturersRequest
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
            return ListDeviceManufacturers(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `DeviceManufacturer` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of DeviceManufacturers.
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
        /// <returns>A pageable asynchronous sequence of <see cref="DeviceManufacturer"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeviceManufacturersResponse, DeviceManufacturer> ListDeviceManufacturersAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeviceManufacturersRequest request = new ListDeviceManufacturersRequest
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
            return ListDeviceManufacturersAsync(request, callSettings);
        }
    }

    /// <summary>DeviceManufacturerService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `DeviceManufacturer` objects.
    /// </remarks>
    public sealed partial class DeviceManufacturerServiceClientImpl : DeviceManufacturerServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetDeviceManufacturerRequest, DeviceManufacturer> _callGetDeviceManufacturer;

        private readonly gaxgrpc::ApiCall<ListDeviceManufacturersRequest, ListDeviceManufacturersResponse> _callListDeviceManufacturers;

        /// <summary>
        /// Constructs a client wrapper for the DeviceManufacturerService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="DeviceManufacturerServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DeviceManufacturerServiceClientImpl(DeviceManufacturerService.DeviceManufacturerServiceClient grpcClient, DeviceManufacturerServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DeviceManufacturerServiceSettings effectiveSettings = settings ?? DeviceManufacturerServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetDeviceManufacturer = clientHelper.BuildApiCall<GetDeviceManufacturerRequest, DeviceManufacturer>("GetDeviceManufacturer", grpcClient.GetDeviceManufacturerAsync, grpcClient.GetDeviceManufacturer, effectiveSettings.GetDeviceManufacturerSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDeviceManufacturer);
            Modify_GetDeviceManufacturerApiCall(ref _callGetDeviceManufacturer);
            _callListDeviceManufacturers = clientHelper.BuildApiCall<ListDeviceManufacturersRequest, ListDeviceManufacturersResponse>("ListDeviceManufacturers", grpcClient.ListDeviceManufacturersAsync, grpcClient.ListDeviceManufacturers, effectiveSettings.ListDeviceManufacturersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDeviceManufacturers);
            Modify_ListDeviceManufacturersApiCall(ref _callListDeviceManufacturers);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetDeviceManufacturerApiCall(ref gaxgrpc::ApiCall<GetDeviceManufacturerRequest, DeviceManufacturer> call);

        partial void Modify_ListDeviceManufacturersApiCall(ref gaxgrpc::ApiCall<ListDeviceManufacturersRequest, ListDeviceManufacturersResponse> call);

        partial void OnConstruction(DeviceManufacturerService.DeviceManufacturerServiceClient grpcClient, DeviceManufacturerServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DeviceManufacturerService client</summary>
        public override DeviceManufacturerService.DeviceManufacturerServiceClient GrpcClient { get; }

        partial void Modify_GetDeviceManufacturerRequest(ref GetDeviceManufacturerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDeviceManufacturersRequest(ref ListDeviceManufacturersRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// API to retrieve a `DeviceManufacturer` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DeviceManufacturer GetDeviceManufacturer(GetDeviceManufacturerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDeviceManufacturerRequest(ref request, ref callSettings);
            return _callGetDeviceManufacturer.Sync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a `DeviceManufacturer` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DeviceManufacturer> GetDeviceManufacturerAsync(GetDeviceManufacturerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDeviceManufacturerRequest(ref request, ref callSettings);
            return _callGetDeviceManufacturer.Async(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `DeviceManufacturer` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DeviceManufacturer"/> resources.</returns>
        public override gax::PagedEnumerable<ListDeviceManufacturersResponse, DeviceManufacturer> ListDeviceManufacturers(ListDeviceManufacturersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDeviceManufacturersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDeviceManufacturersRequest, ListDeviceManufacturersResponse, DeviceManufacturer>(_callListDeviceManufacturers, request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `DeviceManufacturer` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DeviceManufacturer"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDeviceManufacturersResponse, DeviceManufacturer> ListDeviceManufacturersAsync(ListDeviceManufacturersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDeviceManufacturersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDeviceManufacturersRequest, ListDeviceManufacturersResponse, DeviceManufacturer>(_callListDeviceManufacturers, request, callSettings);
        }
    }

    public partial class ListDeviceManufacturersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDeviceManufacturersResponse : gaxgrpc::IPageResponse<DeviceManufacturer>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DeviceManufacturer> GetEnumerator() => DeviceManufacturers.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
