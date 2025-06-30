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
    /// <summary>Settings for <see cref="ProgrammaticBuyerServiceClient"/> instances.</summary>
    public sealed partial class ProgrammaticBuyerServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ProgrammaticBuyerServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ProgrammaticBuyerServiceSettings"/>.</returns>
        public static ProgrammaticBuyerServiceSettings GetDefault() => new ProgrammaticBuyerServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ProgrammaticBuyerServiceSettings"/> object with default settings.
        /// </summary>
        public ProgrammaticBuyerServiceSettings()
        {
        }

        private ProgrammaticBuyerServiceSettings(ProgrammaticBuyerServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetProgrammaticBuyerSettings = existing.GetProgrammaticBuyerSettings;
            ListProgrammaticBuyersSettings = existing.ListProgrammaticBuyersSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ProgrammaticBuyerServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProgrammaticBuyerServiceClient.GetProgrammaticBuyer</c> and
        /// <c>ProgrammaticBuyerServiceClient.GetProgrammaticBuyerAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetProgrammaticBuyerSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProgrammaticBuyerServiceClient.ListProgrammaticBuyers</c> and
        /// <c>ProgrammaticBuyerServiceClient.ListProgrammaticBuyersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListProgrammaticBuyersSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ProgrammaticBuyerServiceSettings"/> object.</returns>
        public ProgrammaticBuyerServiceSettings Clone() => new ProgrammaticBuyerServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ProgrammaticBuyerServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class ProgrammaticBuyerServiceClientBuilder : gaxgrpc::ClientBuilderBase<ProgrammaticBuyerServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ProgrammaticBuyerServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ProgrammaticBuyerServiceClientBuilder() : base(ProgrammaticBuyerServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ProgrammaticBuyerServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ProgrammaticBuyerServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ProgrammaticBuyerServiceClient Build()
        {
            ProgrammaticBuyerServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ProgrammaticBuyerServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ProgrammaticBuyerServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ProgrammaticBuyerServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ProgrammaticBuyerServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ProgrammaticBuyerServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ProgrammaticBuyerServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ProgrammaticBuyerServiceClient.ChannelPool;
    }

    /// <summary>ProgrammaticBuyerService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `ProgrammaticBuyer` objects.
    /// </remarks>
    public abstract partial class ProgrammaticBuyerServiceClient
    {
        /// <summary>
        /// The default endpoint for the ProgrammaticBuyerService service, which is a host of "admanager.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default ProgrammaticBuyerService scopes.</summary>
        /// <remarks>
        /// The default ProgrammaticBuyerService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/admanager</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/admanager",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ProgrammaticBuyerService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ProgrammaticBuyerServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="ProgrammaticBuyerServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ProgrammaticBuyerServiceClient"/>.</returns>
        public static stt::Task<ProgrammaticBuyerServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ProgrammaticBuyerServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ProgrammaticBuyerServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="ProgrammaticBuyerServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ProgrammaticBuyerServiceClient"/>.</returns>
        public static ProgrammaticBuyerServiceClient Create() => new ProgrammaticBuyerServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ProgrammaticBuyerServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ProgrammaticBuyerServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ProgrammaticBuyerServiceClient"/>.</returns>
        internal static ProgrammaticBuyerServiceClient Create(grpccore::CallInvoker callInvoker, ProgrammaticBuyerServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ProgrammaticBuyerService.ProgrammaticBuyerServiceClient grpcClient = new ProgrammaticBuyerService.ProgrammaticBuyerServiceClient(callInvoker);
            return new ProgrammaticBuyerServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ProgrammaticBuyerService client</summary>
        public virtual ProgrammaticBuyerService.ProgrammaticBuyerServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `ProgrammaticBuyer` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProgrammaticBuyer GetProgrammaticBuyer(GetProgrammaticBuyerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `ProgrammaticBuyer` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProgrammaticBuyer> GetProgrammaticBuyerAsync(GetProgrammaticBuyerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `ProgrammaticBuyer` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProgrammaticBuyer> GetProgrammaticBuyerAsync(GetProgrammaticBuyerRequest request, st::CancellationToken cancellationToken) =>
            GetProgrammaticBuyerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `ProgrammaticBuyer` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ProgrammaticBuyer.
        /// Format:
        /// `networks/{network_code}/programmaticBuyers/{buyer_account_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProgrammaticBuyer GetProgrammaticBuyer(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProgrammaticBuyer(new GetProgrammaticBuyerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `ProgrammaticBuyer` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ProgrammaticBuyer.
        /// Format:
        /// `networks/{network_code}/programmaticBuyers/{buyer_account_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProgrammaticBuyer> GetProgrammaticBuyerAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProgrammaticBuyerAsync(new GetProgrammaticBuyerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `ProgrammaticBuyer` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ProgrammaticBuyer.
        /// Format:
        /// `networks/{network_code}/programmaticBuyers/{buyer_account_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProgrammaticBuyer> GetProgrammaticBuyerAsync(string name, st::CancellationToken cancellationToken) =>
            GetProgrammaticBuyerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `ProgrammaticBuyer` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ProgrammaticBuyer.
        /// Format:
        /// `networks/{network_code}/programmaticBuyers/{buyer_account_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProgrammaticBuyer GetProgrammaticBuyer(ProgrammaticBuyerName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProgrammaticBuyer(new GetProgrammaticBuyerRequest
            {
                ProgrammaticBuyerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `ProgrammaticBuyer` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ProgrammaticBuyer.
        /// Format:
        /// `networks/{network_code}/programmaticBuyers/{buyer_account_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProgrammaticBuyer> GetProgrammaticBuyerAsync(ProgrammaticBuyerName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProgrammaticBuyerAsync(new GetProgrammaticBuyerRequest
            {
                ProgrammaticBuyerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `ProgrammaticBuyer` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ProgrammaticBuyer.
        /// Format:
        /// `networks/{network_code}/programmaticBuyers/{buyer_account_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProgrammaticBuyer> GetProgrammaticBuyerAsync(ProgrammaticBuyerName name, st::CancellationToken cancellationToken) =>
            GetProgrammaticBuyerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a list of `ProgrammaticBuyer` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ProgrammaticBuyer"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProgrammaticBuyersResponse, ProgrammaticBuyer> ListProgrammaticBuyers(ListProgrammaticBuyersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `ProgrammaticBuyer` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ProgrammaticBuyer"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProgrammaticBuyersResponse, ProgrammaticBuyer> ListProgrammaticBuyersAsync(ListProgrammaticBuyersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `ProgrammaticBuyer` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of ProgrammaticBuyers.
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
        /// <returns>A pageable sequence of <see cref="ProgrammaticBuyer"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProgrammaticBuyersResponse, ProgrammaticBuyer> ListProgrammaticBuyers(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProgrammaticBuyersRequest request = new ListProgrammaticBuyersRequest
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
            return ListProgrammaticBuyers(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `ProgrammaticBuyer` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of ProgrammaticBuyers.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ProgrammaticBuyer"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProgrammaticBuyersResponse, ProgrammaticBuyer> ListProgrammaticBuyersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProgrammaticBuyersRequest request = new ListProgrammaticBuyersRequest
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
            return ListProgrammaticBuyersAsync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `ProgrammaticBuyer` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of ProgrammaticBuyers.
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
        /// <returns>A pageable sequence of <see cref="ProgrammaticBuyer"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProgrammaticBuyersResponse, ProgrammaticBuyer> ListProgrammaticBuyers(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProgrammaticBuyersRequest request = new ListProgrammaticBuyersRequest
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
            return ListProgrammaticBuyers(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `ProgrammaticBuyer` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of ProgrammaticBuyers.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ProgrammaticBuyer"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProgrammaticBuyersResponse, ProgrammaticBuyer> ListProgrammaticBuyersAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProgrammaticBuyersRequest request = new ListProgrammaticBuyersRequest
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
            return ListProgrammaticBuyersAsync(request, callSettings);
        }
    }

    /// <summary>ProgrammaticBuyerService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `ProgrammaticBuyer` objects.
    /// </remarks>
    public sealed partial class ProgrammaticBuyerServiceClientImpl : ProgrammaticBuyerServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetProgrammaticBuyerRequest, ProgrammaticBuyer> _callGetProgrammaticBuyer;

        private readonly gaxgrpc::ApiCall<ListProgrammaticBuyersRequest, ListProgrammaticBuyersResponse> _callListProgrammaticBuyers;

        /// <summary>
        /// Constructs a client wrapper for the ProgrammaticBuyerService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="ProgrammaticBuyerServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ProgrammaticBuyerServiceClientImpl(ProgrammaticBuyerService.ProgrammaticBuyerServiceClient grpcClient, ProgrammaticBuyerServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ProgrammaticBuyerServiceSettings effectiveSettings = settings ?? ProgrammaticBuyerServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetProgrammaticBuyer = clientHelper.BuildApiCall<GetProgrammaticBuyerRequest, ProgrammaticBuyer>("GetProgrammaticBuyer", grpcClient.GetProgrammaticBuyerAsync, grpcClient.GetProgrammaticBuyer, effectiveSettings.GetProgrammaticBuyerSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetProgrammaticBuyer);
            Modify_GetProgrammaticBuyerApiCall(ref _callGetProgrammaticBuyer);
            _callListProgrammaticBuyers = clientHelper.BuildApiCall<ListProgrammaticBuyersRequest, ListProgrammaticBuyersResponse>("ListProgrammaticBuyers", grpcClient.ListProgrammaticBuyersAsync, grpcClient.ListProgrammaticBuyers, effectiveSettings.ListProgrammaticBuyersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListProgrammaticBuyers);
            Modify_ListProgrammaticBuyersApiCall(ref _callListProgrammaticBuyers);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetProgrammaticBuyerApiCall(ref gaxgrpc::ApiCall<GetProgrammaticBuyerRequest, ProgrammaticBuyer> call);

        partial void Modify_ListProgrammaticBuyersApiCall(ref gaxgrpc::ApiCall<ListProgrammaticBuyersRequest, ListProgrammaticBuyersResponse> call);

        partial void OnConstruction(ProgrammaticBuyerService.ProgrammaticBuyerServiceClient grpcClient, ProgrammaticBuyerServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ProgrammaticBuyerService client</summary>
        public override ProgrammaticBuyerService.ProgrammaticBuyerServiceClient GrpcClient { get; }

        partial void Modify_GetProgrammaticBuyerRequest(ref GetProgrammaticBuyerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListProgrammaticBuyersRequest(ref ListProgrammaticBuyersRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// API to retrieve a `ProgrammaticBuyer` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ProgrammaticBuyer GetProgrammaticBuyer(GetProgrammaticBuyerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProgrammaticBuyerRequest(ref request, ref callSettings);
            return _callGetProgrammaticBuyer.Sync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a `ProgrammaticBuyer` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ProgrammaticBuyer> GetProgrammaticBuyerAsync(GetProgrammaticBuyerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProgrammaticBuyerRequest(ref request, ref callSettings);
            return _callGetProgrammaticBuyer.Async(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `ProgrammaticBuyer` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ProgrammaticBuyer"/> resources.</returns>
        public override gax::PagedEnumerable<ListProgrammaticBuyersResponse, ProgrammaticBuyer> ListProgrammaticBuyers(ListProgrammaticBuyersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProgrammaticBuyersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListProgrammaticBuyersRequest, ListProgrammaticBuyersResponse, ProgrammaticBuyer>(_callListProgrammaticBuyers, request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `ProgrammaticBuyer` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ProgrammaticBuyer"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListProgrammaticBuyersResponse, ProgrammaticBuyer> ListProgrammaticBuyersAsync(ListProgrammaticBuyersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProgrammaticBuyersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListProgrammaticBuyersRequest, ListProgrammaticBuyersResponse, ProgrammaticBuyer>(_callListProgrammaticBuyers, request, callSettings);
        }
    }

    public partial class ListProgrammaticBuyersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListProgrammaticBuyersResponse : gaxgrpc::IPageResponse<ProgrammaticBuyer>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ProgrammaticBuyer> GetEnumerator() => ProgrammaticBuyers.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
