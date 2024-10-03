// Copyright 2024 Google LLC
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
    /// <summary>Settings for <see cref="CompanyServiceClient"/> instances.</summary>
    public sealed partial class CompanyServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CompanyServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CompanyServiceSettings"/>.</returns>
        public static CompanyServiceSettings GetDefault() => new CompanyServiceSettings();

        /// <summary>Constructs a new <see cref="CompanyServiceSettings"/> object with default settings.</summary>
        public CompanyServiceSettings()
        {
        }

        private CompanyServiceSettings(CompanyServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetCompanySettings = existing.GetCompanySettings;
            ListCompaniesSettings = existing.ListCompaniesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CompanyServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CompanyServiceClient.GetCompany</c> and <c>CompanyServiceClient.GetCompanyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCompanySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CompanyServiceClient.ListCompanies</c> and <c>CompanyServiceClient.ListCompaniesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListCompaniesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CompanyServiceSettings"/> object.</returns>
        public CompanyServiceSettings Clone() => new CompanyServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CompanyServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class CompanyServiceClientBuilder : gaxgrpc::ClientBuilderBase<CompanyServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CompanyServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CompanyServiceClientBuilder() : base(CompanyServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CompanyServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CompanyServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CompanyServiceClient Build()
        {
            CompanyServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CompanyServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CompanyServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CompanyServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CompanyServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CompanyServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CompanyServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CompanyServiceClient.ChannelPool;
    }

    /// <summary>CompanyService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `Company` objects.
    /// </remarks>
    public abstract partial class CompanyServiceClient
    {
        /// <summary>
        /// The default endpoint for the CompanyService service, which is a host of "admanager.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default CompanyService scopes.</summary>
        /// <remarks>The default CompanyService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CompanyService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CompanyServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CompanyServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CompanyServiceClient"/>.</returns>
        public static stt::Task<CompanyServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CompanyServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CompanyServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CompanyServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CompanyServiceClient"/>.</returns>
        public static CompanyServiceClient Create() => new CompanyServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CompanyServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CompanyServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CompanyServiceClient"/>.</returns>
        internal static CompanyServiceClient Create(grpccore::CallInvoker callInvoker, CompanyServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CompanyService.CompanyServiceClient grpcClient = new CompanyService.CompanyServiceClient(callInvoker);
            return new CompanyServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CompanyService client</summary>
        public virtual CompanyService.CompanyServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `Company` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Company GetCompany(GetCompanyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `Company` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Company> GetCompanyAsync(GetCompanyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `Company` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Company> GetCompanyAsync(GetCompanyRequest request, st::CancellationToken cancellationToken) =>
            GetCompanyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `Company` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Company.
        /// Format: `networks/{network_code}/companies/{company_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Company GetCompany(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCompany(new GetCompanyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `Company` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Company.
        /// Format: `networks/{network_code}/companies/{company_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Company> GetCompanyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCompanyAsync(new GetCompanyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `Company` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Company.
        /// Format: `networks/{network_code}/companies/{company_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Company> GetCompanyAsync(string name, st::CancellationToken cancellationToken) =>
            GetCompanyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `Company` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Company.
        /// Format: `networks/{network_code}/companies/{company_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Company GetCompany(CompanyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCompany(new GetCompanyRequest
            {
                CompanyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `Company` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Company.
        /// Format: `networks/{network_code}/companies/{company_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Company> GetCompanyAsync(CompanyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCompanyAsync(new GetCompanyRequest
            {
                CompanyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `Company` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Company.
        /// Format: `networks/{network_code}/companies/{company_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Company> GetCompanyAsync(CompanyName name, st::CancellationToken cancellationToken) =>
            GetCompanyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a list of `Company` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Company"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCompaniesResponse, Company> ListCompanies(ListCompaniesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `Company` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Company"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCompaniesResponse, Company> ListCompaniesAsync(ListCompaniesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `Company` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Companies.
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
        /// <returns>A pageable sequence of <see cref="Company"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCompaniesResponse, Company> ListCompanies(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCompaniesRequest request = new ListCompaniesRequest
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
            return ListCompanies(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `Company` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Companies.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Company"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCompaniesResponse, Company> ListCompaniesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCompaniesRequest request = new ListCompaniesRequest
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
            return ListCompaniesAsync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `Company` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Companies.
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
        /// <returns>A pageable sequence of <see cref="Company"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCompaniesResponse, Company> ListCompanies(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCompaniesRequest request = new ListCompaniesRequest
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
            return ListCompanies(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `Company` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Companies.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Company"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCompaniesResponse, Company> ListCompaniesAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCompaniesRequest request = new ListCompaniesRequest
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
            return ListCompaniesAsync(request, callSettings);
        }
    }

    /// <summary>CompanyService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `Company` objects.
    /// </remarks>
    public sealed partial class CompanyServiceClientImpl : CompanyServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetCompanyRequest, Company> _callGetCompany;

        private readonly gaxgrpc::ApiCall<ListCompaniesRequest, ListCompaniesResponse> _callListCompanies;

        /// <summary>
        /// Constructs a client wrapper for the CompanyService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CompanyServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CompanyServiceClientImpl(CompanyService.CompanyServiceClient grpcClient, CompanyServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CompanyServiceSettings effectiveSettings = settings ?? CompanyServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetCompany = clientHelper.BuildApiCall<GetCompanyRequest, Company>("GetCompany", grpcClient.GetCompanyAsync, grpcClient.GetCompany, effectiveSettings.GetCompanySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCompany);
            Modify_GetCompanyApiCall(ref _callGetCompany);
            _callListCompanies = clientHelper.BuildApiCall<ListCompaniesRequest, ListCompaniesResponse>("ListCompanies", grpcClient.ListCompaniesAsync, grpcClient.ListCompanies, effectiveSettings.ListCompaniesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCompanies);
            Modify_ListCompaniesApiCall(ref _callListCompanies);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetCompanyApiCall(ref gaxgrpc::ApiCall<GetCompanyRequest, Company> call);

        partial void Modify_ListCompaniesApiCall(ref gaxgrpc::ApiCall<ListCompaniesRequest, ListCompaniesResponse> call);

        partial void OnConstruction(CompanyService.CompanyServiceClient grpcClient, CompanyServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CompanyService client</summary>
        public override CompanyService.CompanyServiceClient GrpcClient { get; }

        partial void Modify_GetCompanyRequest(ref GetCompanyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCompaniesRequest(ref ListCompaniesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// API to retrieve a `Company` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Company GetCompany(GetCompanyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCompanyRequest(ref request, ref callSettings);
            return _callGetCompany.Sync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a `Company` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Company> GetCompanyAsync(GetCompanyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCompanyRequest(ref request, ref callSettings);
            return _callGetCompany.Async(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `Company` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Company"/> resources.</returns>
        public override gax::PagedEnumerable<ListCompaniesResponse, Company> ListCompanies(ListCompaniesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCompaniesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCompaniesRequest, ListCompaniesResponse, Company>(_callListCompanies, request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `Company` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Company"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCompaniesResponse, Company> ListCompaniesAsync(ListCompaniesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCompaniesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCompaniesRequest, ListCompaniesResponse, Company>(_callListCompanies, request, callSettings);
        }
    }

    public partial class ListCompaniesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCompaniesResponse : gaxgrpc::IPageResponse<Company>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Company> GetEnumerator() => Companies.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
