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
    /// <summary>Settings for <see cref="MobileDeviceSubmodelServiceClient"/> instances.</summary>
    public sealed partial class MobileDeviceSubmodelServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="MobileDeviceSubmodelServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="MobileDeviceSubmodelServiceSettings"/>.</returns>
        public static MobileDeviceSubmodelServiceSettings GetDefault() => new MobileDeviceSubmodelServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="MobileDeviceSubmodelServiceSettings"/> object with default settings.
        /// </summary>
        public MobileDeviceSubmodelServiceSettings()
        {
        }

        private MobileDeviceSubmodelServiceSettings(MobileDeviceSubmodelServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetMobileDeviceSubmodelSettings = existing.GetMobileDeviceSubmodelSettings;
            ListMobileDeviceSubmodelsSettings = existing.ListMobileDeviceSubmodelsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(MobileDeviceSubmodelServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MobileDeviceSubmodelServiceClient.GetMobileDeviceSubmodel</c> and
        /// <c>MobileDeviceSubmodelServiceClient.GetMobileDeviceSubmodelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetMobileDeviceSubmodelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MobileDeviceSubmodelServiceClient.ListMobileDeviceSubmodels</c> and
        /// <c>MobileDeviceSubmodelServiceClient.ListMobileDeviceSubmodelsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListMobileDeviceSubmodelsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="MobileDeviceSubmodelServiceSettings"/> object.</returns>
        public MobileDeviceSubmodelServiceSettings Clone() => new MobileDeviceSubmodelServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="MobileDeviceSubmodelServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class MobileDeviceSubmodelServiceClientBuilder : gaxgrpc::ClientBuilderBase<MobileDeviceSubmodelServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public MobileDeviceSubmodelServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public MobileDeviceSubmodelServiceClientBuilder() : base(MobileDeviceSubmodelServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref MobileDeviceSubmodelServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<MobileDeviceSubmodelServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override MobileDeviceSubmodelServiceClient Build()
        {
            MobileDeviceSubmodelServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<MobileDeviceSubmodelServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<MobileDeviceSubmodelServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private MobileDeviceSubmodelServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return MobileDeviceSubmodelServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<MobileDeviceSubmodelServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return MobileDeviceSubmodelServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => MobileDeviceSubmodelServiceClient.ChannelPool;
    }

    /// <summary>MobileDeviceSubmodelService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `MobileDeviceSubmodel` objects.
    /// </remarks>
    public abstract partial class MobileDeviceSubmodelServiceClient
    {
        /// <summary>
        /// The default endpoint for the MobileDeviceSubmodelService service, which is a host of
        /// "admanager.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default MobileDeviceSubmodelService scopes.</summary>
        /// <remarks>
        /// The default MobileDeviceSubmodelService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/admanager</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/admanager",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(MobileDeviceSubmodelService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="MobileDeviceSubmodelServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="MobileDeviceSubmodelServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="MobileDeviceSubmodelServiceClient"/>.</returns>
        public static stt::Task<MobileDeviceSubmodelServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new MobileDeviceSubmodelServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="MobileDeviceSubmodelServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="MobileDeviceSubmodelServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="MobileDeviceSubmodelServiceClient"/>.</returns>
        public static MobileDeviceSubmodelServiceClient Create() => new MobileDeviceSubmodelServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="MobileDeviceSubmodelServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="MobileDeviceSubmodelServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="MobileDeviceSubmodelServiceClient"/>.</returns>
        internal static MobileDeviceSubmodelServiceClient Create(grpccore::CallInvoker callInvoker, MobileDeviceSubmodelServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            MobileDeviceSubmodelService.MobileDeviceSubmodelServiceClient grpcClient = new MobileDeviceSubmodelService.MobileDeviceSubmodelServiceClient(callInvoker);
            return new MobileDeviceSubmodelServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC MobileDeviceSubmodelService client</summary>
        public virtual MobileDeviceSubmodelService.MobileDeviceSubmodelServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `MobileDeviceSubmodel` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MobileDeviceSubmodel GetMobileDeviceSubmodel(GetMobileDeviceSubmodelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `MobileDeviceSubmodel` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MobileDeviceSubmodel> GetMobileDeviceSubmodelAsync(GetMobileDeviceSubmodelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `MobileDeviceSubmodel` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MobileDeviceSubmodel> GetMobileDeviceSubmodelAsync(GetMobileDeviceSubmodelRequest request, st::CancellationToken cancellationToken) =>
            GetMobileDeviceSubmodelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `MobileDeviceSubmodel` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the MobileDeviceSubmodel.
        /// Format:
        /// `networks/{network_code}/mobileDeviceSubmodels/{mobile_device_submodel_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MobileDeviceSubmodel GetMobileDeviceSubmodel(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMobileDeviceSubmodel(new GetMobileDeviceSubmodelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `MobileDeviceSubmodel` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the MobileDeviceSubmodel.
        /// Format:
        /// `networks/{network_code}/mobileDeviceSubmodels/{mobile_device_submodel_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MobileDeviceSubmodel> GetMobileDeviceSubmodelAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMobileDeviceSubmodelAsync(new GetMobileDeviceSubmodelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `MobileDeviceSubmodel` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the MobileDeviceSubmodel.
        /// Format:
        /// `networks/{network_code}/mobileDeviceSubmodels/{mobile_device_submodel_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MobileDeviceSubmodel> GetMobileDeviceSubmodelAsync(string name, st::CancellationToken cancellationToken) =>
            GetMobileDeviceSubmodelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `MobileDeviceSubmodel` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the MobileDeviceSubmodel.
        /// Format:
        /// `networks/{network_code}/mobileDeviceSubmodels/{mobile_device_submodel_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MobileDeviceSubmodel GetMobileDeviceSubmodel(MobileDeviceSubmodelName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMobileDeviceSubmodel(new GetMobileDeviceSubmodelRequest
            {
                MobileDeviceSubmodelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `MobileDeviceSubmodel` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the MobileDeviceSubmodel.
        /// Format:
        /// `networks/{network_code}/mobileDeviceSubmodels/{mobile_device_submodel_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MobileDeviceSubmodel> GetMobileDeviceSubmodelAsync(MobileDeviceSubmodelName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMobileDeviceSubmodelAsync(new GetMobileDeviceSubmodelRequest
            {
                MobileDeviceSubmodelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `MobileDeviceSubmodel` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the MobileDeviceSubmodel.
        /// Format:
        /// `networks/{network_code}/mobileDeviceSubmodels/{mobile_device_submodel_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MobileDeviceSubmodel> GetMobileDeviceSubmodelAsync(MobileDeviceSubmodelName name, st::CancellationToken cancellationToken) =>
            GetMobileDeviceSubmodelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a list of `MobileDeviceSubmodel` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MobileDeviceSubmodel"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMobileDeviceSubmodelsResponse, MobileDeviceSubmodel> ListMobileDeviceSubmodels(ListMobileDeviceSubmodelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `MobileDeviceSubmodel` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MobileDeviceSubmodel"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMobileDeviceSubmodelsResponse, MobileDeviceSubmodel> ListMobileDeviceSubmodelsAsync(ListMobileDeviceSubmodelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `MobileDeviceSubmodel` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of MobileDeviceSubmodels.
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
        /// <returns>A pageable sequence of <see cref="MobileDeviceSubmodel"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMobileDeviceSubmodelsResponse, MobileDeviceSubmodel> ListMobileDeviceSubmodels(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMobileDeviceSubmodelsRequest request = new ListMobileDeviceSubmodelsRequest
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
            return ListMobileDeviceSubmodels(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `MobileDeviceSubmodel` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of MobileDeviceSubmodels.
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
        /// <returns>A pageable asynchronous sequence of <see cref="MobileDeviceSubmodel"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMobileDeviceSubmodelsResponse, MobileDeviceSubmodel> ListMobileDeviceSubmodelsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMobileDeviceSubmodelsRequest request = new ListMobileDeviceSubmodelsRequest
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
            return ListMobileDeviceSubmodelsAsync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `MobileDeviceSubmodel` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of MobileDeviceSubmodels.
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
        /// <returns>A pageable sequence of <see cref="MobileDeviceSubmodel"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMobileDeviceSubmodelsResponse, MobileDeviceSubmodel> ListMobileDeviceSubmodels(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMobileDeviceSubmodelsRequest request = new ListMobileDeviceSubmodelsRequest
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
            return ListMobileDeviceSubmodels(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `MobileDeviceSubmodel` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of MobileDeviceSubmodels.
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
        /// <returns>A pageable asynchronous sequence of <see cref="MobileDeviceSubmodel"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMobileDeviceSubmodelsResponse, MobileDeviceSubmodel> ListMobileDeviceSubmodelsAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMobileDeviceSubmodelsRequest request = new ListMobileDeviceSubmodelsRequest
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
            return ListMobileDeviceSubmodelsAsync(request, callSettings);
        }
    }

    /// <summary>MobileDeviceSubmodelService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `MobileDeviceSubmodel` objects.
    /// </remarks>
    public sealed partial class MobileDeviceSubmodelServiceClientImpl : MobileDeviceSubmodelServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetMobileDeviceSubmodelRequest, MobileDeviceSubmodel> _callGetMobileDeviceSubmodel;

        private readonly gaxgrpc::ApiCall<ListMobileDeviceSubmodelsRequest, ListMobileDeviceSubmodelsResponse> _callListMobileDeviceSubmodels;

        /// <summary>
        /// Constructs a client wrapper for the MobileDeviceSubmodelService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="MobileDeviceSubmodelServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public MobileDeviceSubmodelServiceClientImpl(MobileDeviceSubmodelService.MobileDeviceSubmodelServiceClient grpcClient, MobileDeviceSubmodelServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            MobileDeviceSubmodelServiceSettings effectiveSettings = settings ?? MobileDeviceSubmodelServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetMobileDeviceSubmodel = clientHelper.BuildApiCall<GetMobileDeviceSubmodelRequest, MobileDeviceSubmodel>("GetMobileDeviceSubmodel", grpcClient.GetMobileDeviceSubmodelAsync, grpcClient.GetMobileDeviceSubmodel, effectiveSettings.GetMobileDeviceSubmodelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetMobileDeviceSubmodel);
            Modify_GetMobileDeviceSubmodelApiCall(ref _callGetMobileDeviceSubmodel);
            _callListMobileDeviceSubmodels = clientHelper.BuildApiCall<ListMobileDeviceSubmodelsRequest, ListMobileDeviceSubmodelsResponse>("ListMobileDeviceSubmodels", grpcClient.ListMobileDeviceSubmodelsAsync, grpcClient.ListMobileDeviceSubmodels, effectiveSettings.ListMobileDeviceSubmodelsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListMobileDeviceSubmodels);
            Modify_ListMobileDeviceSubmodelsApiCall(ref _callListMobileDeviceSubmodels);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetMobileDeviceSubmodelApiCall(ref gaxgrpc::ApiCall<GetMobileDeviceSubmodelRequest, MobileDeviceSubmodel> call);

        partial void Modify_ListMobileDeviceSubmodelsApiCall(ref gaxgrpc::ApiCall<ListMobileDeviceSubmodelsRequest, ListMobileDeviceSubmodelsResponse> call);

        partial void OnConstruction(MobileDeviceSubmodelService.MobileDeviceSubmodelServiceClient grpcClient, MobileDeviceSubmodelServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC MobileDeviceSubmodelService client</summary>
        public override MobileDeviceSubmodelService.MobileDeviceSubmodelServiceClient GrpcClient { get; }

        partial void Modify_GetMobileDeviceSubmodelRequest(ref GetMobileDeviceSubmodelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListMobileDeviceSubmodelsRequest(ref ListMobileDeviceSubmodelsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// API to retrieve a `MobileDeviceSubmodel` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MobileDeviceSubmodel GetMobileDeviceSubmodel(GetMobileDeviceSubmodelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMobileDeviceSubmodelRequest(ref request, ref callSettings);
            return _callGetMobileDeviceSubmodel.Sync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a `MobileDeviceSubmodel` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MobileDeviceSubmodel> GetMobileDeviceSubmodelAsync(GetMobileDeviceSubmodelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMobileDeviceSubmodelRequest(ref request, ref callSettings);
            return _callGetMobileDeviceSubmodel.Async(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `MobileDeviceSubmodel` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MobileDeviceSubmodel"/> resources.</returns>
        public override gax::PagedEnumerable<ListMobileDeviceSubmodelsResponse, MobileDeviceSubmodel> ListMobileDeviceSubmodels(ListMobileDeviceSubmodelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMobileDeviceSubmodelsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListMobileDeviceSubmodelsRequest, ListMobileDeviceSubmodelsResponse, MobileDeviceSubmodel>(_callListMobileDeviceSubmodels, request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `MobileDeviceSubmodel` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MobileDeviceSubmodel"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListMobileDeviceSubmodelsResponse, MobileDeviceSubmodel> ListMobileDeviceSubmodelsAsync(ListMobileDeviceSubmodelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMobileDeviceSubmodelsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListMobileDeviceSubmodelsRequest, ListMobileDeviceSubmodelsResponse, MobileDeviceSubmodel>(_callListMobileDeviceSubmodels, request, callSettings);
        }
    }

    public partial class ListMobileDeviceSubmodelsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListMobileDeviceSubmodelsResponse : gaxgrpc::IPageResponse<MobileDeviceSubmodel>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<MobileDeviceSubmodel> GetEnumerator() => MobileDeviceSubmodels.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
