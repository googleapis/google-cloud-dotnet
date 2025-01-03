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

namespace Google.Cloud.Billing.V1
{
    /// <summary>Settings for <see cref="CloudCatalogClient"/> instances.</summary>
    public sealed partial class CloudCatalogSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CloudCatalogSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CloudCatalogSettings"/>.</returns>
        public static CloudCatalogSettings GetDefault() => new CloudCatalogSettings();

        /// <summary>Constructs a new <see cref="CloudCatalogSettings"/> object with default settings.</summary>
        public CloudCatalogSettings()
        {
        }

        private CloudCatalogSettings(CloudCatalogSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListServicesSettings = existing.ListServicesSettings;
            ListSkusSettings = existing.ListSkusSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CloudCatalogSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudCatalogClient.ListServices</c> and <c>CloudCatalogClient.ListServicesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListServicesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>CloudCatalogClient.ListSkus</c>
        ///  and <c>CloudCatalogClient.ListSkusAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSkusSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CloudCatalogSettings"/> object.</returns>
        public CloudCatalogSettings Clone() => new CloudCatalogSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CloudCatalogClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class CloudCatalogClientBuilder : gaxgrpc::ClientBuilderBase<CloudCatalogClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CloudCatalogSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CloudCatalogClientBuilder() : base(CloudCatalogClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CloudCatalogClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CloudCatalogClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CloudCatalogClient Build()
        {
            CloudCatalogClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CloudCatalogClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CloudCatalogClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CloudCatalogClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CloudCatalogClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CloudCatalogClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CloudCatalogClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CloudCatalogClient.ChannelPool;
    }

    /// <summary>CloudCatalog client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A catalog of Google Cloud Platform services and SKUs.
    /// Provides pricing information and metadata on Google Cloud Platform services
    /// and SKUs.
    /// </remarks>
    public abstract partial class CloudCatalogClient
    {
        /// <summary>
        /// The default endpoint for the CloudCatalog service, which is a host of "cloudbilling.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloudbilling.googleapis.com:443";

        /// <summary>The default CloudCatalog scopes.</summary>
        /// <remarks>
        /// The default CloudCatalog scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-billing</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-billing.readonly</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-billing",
            "https://www.googleapis.com/auth/cloud-billing.readonly",
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CloudCatalog.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CloudCatalogClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CloudCatalogClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CloudCatalogClient"/>.</returns>
        public static stt::Task<CloudCatalogClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CloudCatalogClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CloudCatalogClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CloudCatalogClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CloudCatalogClient"/>.</returns>
        public static CloudCatalogClient Create() => new CloudCatalogClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CloudCatalogClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CloudCatalogSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CloudCatalogClient"/>.</returns>
        internal static CloudCatalogClient Create(grpccore::CallInvoker callInvoker, CloudCatalogSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CloudCatalog.CloudCatalogClient grpcClient = new CloudCatalog.CloudCatalogClient(callInvoker);
            return new CloudCatalogClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CloudCatalog client</summary>
        public virtual CloudCatalog.CloudCatalogClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all public cloud services.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Service"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServicesResponse, Service> ListServices(ListServicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all public cloud services.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Service"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServicesResponse, Service> ListServicesAsync(ListServicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all public cloud services.
        /// </summary>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Service"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServicesResponse, Service> ListServices(string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServicesRequest request = new ListServicesRequest { };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListServices(request, callSettings);
        }

        /// <summary>
        /// Lists all public cloud services.
        /// </summary>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Service"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServicesResponse, Service> ListServicesAsync(string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServicesRequest request = new ListServicesRequest { };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListServicesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all publicly available SKUs for a given cloud service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Sku"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSkusResponse, Sku> ListSkus(ListSkusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all publicly available SKUs for a given cloud service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Sku"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSkusResponse, Sku> ListSkusAsync(ListSkusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all publicly available SKUs for a given cloud service.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the service.
        /// Example: "services/6F81-5844-456A"
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
        /// <returns>A pageable sequence of <see cref="Sku"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSkusResponse, Sku> ListSkus(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSkusRequest request = new ListSkusRequest
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
            return ListSkus(request, callSettings);
        }

        /// <summary>
        /// Lists all publicly available SKUs for a given cloud service.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the service.
        /// Example: "services/6F81-5844-456A"
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
        /// <returns>A pageable asynchronous sequence of <see cref="Sku"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSkusResponse, Sku> ListSkusAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSkusRequest request = new ListSkusRequest
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
            return ListSkusAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all publicly available SKUs for a given cloud service.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the service.
        /// Example: "services/6F81-5844-456A"
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
        /// <returns>A pageable sequence of <see cref="Sku"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSkusResponse, Sku> ListSkus(ServiceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSkusRequest request = new ListSkusRequest
            {
                ParentAsServiceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSkus(request, callSettings);
        }

        /// <summary>
        /// Lists all publicly available SKUs for a given cloud service.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the service.
        /// Example: "services/6F81-5844-456A"
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
        /// <returns>A pageable asynchronous sequence of <see cref="Sku"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSkusResponse, Sku> ListSkusAsync(ServiceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSkusRequest request = new ListSkusRequest
            {
                ParentAsServiceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSkusAsync(request, callSettings);
        }
    }

    /// <summary>CloudCatalog client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A catalog of Google Cloud Platform services and SKUs.
    /// Provides pricing information and metadata on Google Cloud Platform services
    /// and SKUs.
    /// </remarks>
    public sealed partial class CloudCatalogClientImpl : CloudCatalogClient
    {
        private readonly gaxgrpc::ApiCall<ListServicesRequest, ListServicesResponse> _callListServices;

        private readonly gaxgrpc::ApiCall<ListSkusRequest, ListSkusResponse> _callListSkus;

        /// <summary>
        /// Constructs a client wrapper for the CloudCatalog service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CloudCatalogSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CloudCatalogClientImpl(CloudCatalog.CloudCatalogClient grpcClient, CloudCatalogSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CloudCatalogSettings effectiveSettings = settings ?? CloudCatalogSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callListServices = clientHelper.BuildApiCall<ListServicesRequest, ListServicesResponse>("ListServices", grpcClient.ListServicesAsync, grpcClient.ListServices, effectiveSettings.ListServicesSettings);
            Modify_ApiCall(ref _callListServices);
            Modify_ListServicesApiCall(ref _callListServices);
            _callListSkus = clientHelper.BuildApiCall<ListSkusRequest, ListSkusResponse>("ListSkus", grpcClient.ListSkusAsync, grpcClient.ListSkus, effectiveSettings.ListSkusSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSkus);
            Modify_ListSkusApiCall(ref _callListSkus);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListServicesApiCall(ref gaxgrpc::ApiCall<ListServicesRequest, ListServicesResponse> call);

        partial void Modify_ListSkusApiCall(ref gaxgrpc::ApiCall<ListSkusRequest, ListSkusResponse> call);

        partial void OnConstruction(CloudCatalog.CloudCatalogClient grpcClient, CloudCatalogSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CloudCatalog client</summary>
        public override CloudCatalog.CloudCatalogClient GrpcClient { get; }

        partial void Modify_ListServicesRequest(ref ListServicesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSkusRequest(ref ListSkusRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists all public cloud services.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Service"/> resources.</returns>
        public override gax::PagedEnumerable<ListServicesResponse, Service> ListServices(ListServicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServicesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListServicesRequest, ListServicesResponse, Service>(_callListServices, request, callSettings);
        }

        /// <summary>
        /// Lists all public cloud services.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Service"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListServicesResponse, Service> ListServicesAsync(ListServicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServicesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListServicesRequest, ListServicesResponse, Service>(_callListServices, request, callSettings);
        }

        /// <summary>
        /// Lists all publicly available SKUs for a given cloud service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Sku"/> resources.</returns>
        public override gax::PagedEnumerable<ListSkusResponse, Sku> ListSkus(ListSkusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSkusRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSkusRequest, ListSkusResponse, Sku>(_callListSkus, request, callSettings);
        }

        /// <summary>
        /// Lists all publicly available SKUs for a given cloud service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Sku"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSkusResponse, Sku> ListSkusAsync(ListSkusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSkusRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSkusRequest, ListSkusResponse, Sku>(_callListSkus, request, callSettings);
        }
    }

    public partial class ListServicesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSkusRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListServicesResponse : gaxgrpc::IPageResponse<Service>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Service> GetEnumerator() => Services.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListSkusResponse : gaxgrpc::IPageResponse<Sku>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Sku> GetEnumerator() => Skus.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
