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
    /// <summary>Settings for <see cref="McmEarningsServiceClient"/> instances.</summary>
    public sealed partial class McmEarningsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="McmEarningsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="McmEarningsServiceSettings"/>.</returns>
        public static McmEarningsServiceSettings GetDefault() => new McmEarningsServiceSettings();

        /// <summary>Constructs a new <see cref="McmEarningsServiceSettings"/> object with default settings.</summary>
        public McmEarningsServiceSettings()
        {
        }

        private McmEarningsServiceSettings(McmEarningsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            FetchMcmEarningsSettings = existing.FetchMcmEarningsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(McmEarningsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>McmEarningsServiceClient.FetchMcmEarnings</c> and <c>McmEarningsServiceClient.FetchMcmEarningsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings FetchMcmEarningsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="McmEarningsServiceSettings"/> object.</returns>
        public McmEarningsServiceSettings Clone() => new McmEarningsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="McmEarningsServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class McmEarningsServiceClientBuilder : gaxgrpc::ClientBuilderBase<McmEarningsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public McmEarningsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public McmEarningsServiceClientBuilder() : base(McmEarningsServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref McmEarningsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<McmEarningsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override McmEarningsServiceClient Build()
        {
            McmEarningsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<McmEarningsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<McmEarningsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private McmEarningsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return McmEarningsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<McmEarningsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return McmEarningsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => McmEarningsServiceClient.ChannelPool;
    }

    /// <summary>McmEarningsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `McmEarnings` objects.
    /// </remarks>
    public abstract partial class McmEarningsServiceClient
    {
        /// <summary>
        /// The default endpoint for the McmEarningsService service, which is a host of "admanager.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default McmEarningsService scopes.</summary>
        /// <remarks>
        /// The default McmEarningsService scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(McmEarningsService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="McmEarningsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="McmEarningsServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="McmEarningsServiceClient"/>.</returns>
        public static stt::Task<McmEarningsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new McmEarningsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="McmEarningsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="McmEarningsServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="McmEarningsServiceClient"/>.</returns>
        public static McmEarningsServiceClient Create() => new McmEarningsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="McmEarningsServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="McmEarningsServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="McmEarningsServiceClient"/>.</returns>
        internal static McmEarningsServiceClient Create(grpccore::CallInvoker callInvoker, McmEarningsServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            McmEarningsService.McmEarningsServiceClient grpcClient = new McmEarningsService.McmEarningsServiceClient(callInvoker);
            return new McmEarningsServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC McmEarningsService client</summary>
        public virtual McmEarningsService.McmEarningsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `McmEarnings` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="McmEarnings"/> resources.</returns>
        public virtual gax::PagedEnumerable<FetchMcmEarningsResponse, McmEarnings> FetchMcmEarnings(FetchMcmEarningsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `McmEarnings` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="McmEarnings"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<FetchMcmEarningsResponse, McmEarnings> FetchMcmEarningsAsync(FetchMcmEarningsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `McmEarnings` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of McmEarnings.
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
        /// <returns>A pageable sequence of <see cref="McmEarnings"/> resources.</returns>
        public virtual gax::PagedEnumerable<FetchMcmEarningsResponse, McmEarnings> FetchMcmEarnings(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            FetchMcmEarningsRequest request = new FetchMcmEarningsRequest
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
            return FetchMcmEarnings(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `McmEarnings` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of McmEarnings.
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
        /// <returns>A pageable asynchronous sequence of <see cref="McmEarnings"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<FetchMcmEarningsResponse, McmEarnings> FetchMcmEarningsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            FetchMcmEarningsRequest request = new FetchMcmEarningsRequest
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
            return FetchMcmEarningsAsync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `McmEarnings` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of McmEarnings.
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
        /// <returns>A pageable sequence of <see cref="McmEarnings"/> resources.</returns>
        public virtual gax::PagedEnumerable<FetchMcmEarningsResponse, McmEarnings> FetchMcmEarnings(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            FetchMcmEarningsRequest request = new FetchMcmEarningsRequest
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
            return FetchMcmEarnings(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `McmEarnings` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of McmEarnings.
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
        /// <returns>A pageable asynchronous sequence of <see cref="McmEarnings"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<FetchMcmEarningsResponse, McmEarnings> FetchMcmEarningsAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            FetchMcmEarningsRequest request = new FetchMcmEarningsRequest
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
            return FetchMcmEarningsAsync(request, callSettings);
        }
    }

    /// <summary>McmEarningsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `McmEarnings` objects.
    /// </remarks>
    public sealed partial class McmEarningsServiceClientImpl : McmEarningsServiceClient
    {
        private readonly gaxgrpc::ApiCall<FetchMcmEarningsRequest, FetchMcmEarningsResponse> _callFetchMcmEarnings;

        /// <summary>
        /// Constructs a client wrapper for the McmEarningsService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="McmEarningsServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public McmEarningsServiceClientImpl(McmEarningsService.McmEarningsServiceClient grpcClient, McmEarningsServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            McmEarningsServiceSettings effectiveSettings = settings ?? McmEarningsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callFetchMcmEarnings = clientHelper.BuildApiCall<FetchMcmEarningsRequest, FetchMcmEarningsResponse>("FetchMcmEarnings", grpcClient.FetchMcmEarningsAsync, grpcClient.FetchMcmEarnings, effectiveSettings.FetchMcmEarningsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callFetchMcmEarnings);
            Modify_FetchMcmEarningsApiCall(ref _callFetchMcmEarnings);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_FetchMcmEarningsApiCall(ref gaxgrpc::ApiCall<FetchMcmEarningsRequest, FetchMcmEarningsResponse> call);

        partial void OnConstruction(McmEarningsService.McmEarningsServiceClient grpcClient, McmEarningsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC McmEarningsService client</summary>
        public override McmEarningsService.McmEarningsServiceClient GrpcClient { get; }

        partial void Modify_FetchMcmEarningsRequest(ref FetchMcmEarningsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// API to retrieve a list of `McmEarnings` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="McmEarnings"/> resources.</returns>
        public override gax::PagedEnumerable<FetchMcmEarningsResponse, McmEarnings> FetchMcmEarnings(FetchMcmEarningsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchMcmEarningsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<FetchMcmEarningsRequest, FetchMcmEarningsResponse, McmEarnings>(_callFetchMcmEarnings, request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `McmEarnings` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="McmEarnings"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<FetchMcmEarningsResponse, McmEarnings> FetchMcmEarningsAsync(FetchMcmEarningsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchMcmEarningsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<FetchMcmEarningsRequest, FetchMcmEarningsResponse, McmEarnings>(_callFetchMcmEarnings, request, callSettings);
        }
    }

    public partial class FetchMcmEarningsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class FetchMcmEarningsResponse : gaxgrpc::IPageResponse<McmEarnings>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<McmEarnings> GetEnumerator() => McmEarnings.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
