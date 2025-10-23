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
    /// <summary>Settings for <see cref="ApplicationServiceClient"/> instances.</summary>
    public sealed partial class ApplicationServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ApplicationServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ApplicationServiceSettings"/>.</returns>
        public static ApplicationServiceSettings GetDefault() => new ApplicationServiceSettings();

        /// <summary>Constructs a new <see cref="ApplicationServiceSettings"/> object with default settings.</summary>
        public ApplicationServiceSettings()
        {
        }

        private ApplicationServiceSettings(ApplicationServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetApplicationSettings = existing.GetApplicationSettings;
            ListApplicationsSettings = existing.ListApplicationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ApplicationServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApplicationServiceClient.GetApplication</c> and <c>ApplicationServiceClient.GetApplicationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetApplicationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApplicationServiceClient.ListApplications</c> and <c>ApplicationServiceClient.ListApplicationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListApplicationsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ApplicationServiceSettings"/> object.</returns>
        public ApplicationServiceSettings Clone() => new ApplicationServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ApplicationServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class ApplicationServiceClientBuilder : gaxgrpc::ClientBuilderBase<ApplicationServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ApplicationServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ApplicationServiceClientBuilder() : base(ApplicationServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ApplicationServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ApplicationServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ApplicationServiceClient Build()
        {
            ApplicationServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ApplicationServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ApplicationServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ApplicationServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ApplicationServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ApplicationServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ApplicationServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ApplicationServiceClient.ChannelPool;
    }

    /// <summary>ApplicationService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `Application` objects.
    /// </remarks>
    public abstract partial class ApplicationServiceClient
    {
        /// <summary>
        /// The default endpoint for the ApplicationService service, which is a host of "admanager.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default ApplicationService scopes.</summary>
        /// <remarks>
        /// The default ApplicationService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/admanager</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/admanager",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ApplicationService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ApplicationServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ApplicationServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ApplicationServiceClient"/>.</returns>
        public static stt::Task<ApplicationServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ApplicationServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ApplicationServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ApplicationServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="ApplicationServiceClient"/>.</returns>
        public static ApplicationServiceClient Create() => new ApplicationServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ApplicationServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ApplicationServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ApplicationServiceClient"/>.</returns>
        internal static ApplicationServiceClient Create(grpccore::CallInvoker callInvoker, ApplicationServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ApplicationService.ApplicationServiceClient grpcClient = new ApplicationService.ApplicationServiceClient(callInvoker);
            return new ApplicationServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ApplicationService client</summary>
        public virtual ApplicationService.ApplicationServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `Application` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Application GetApplication(GetApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `Application` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> GetApplicationAsync(GetApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `Application` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> GetApplicationAsync(GetApplicationRequest request, st::CancellationToken cancellationToken) =>
            GetApplicationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `Application` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Application.
        /// Format: `networks/{network_code}/applications/{application_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Application GetApplication(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetApplication(new GetApplicationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `Application` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Application.
        /// Format: `networks/{network_code}/applications/{application_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> GetApplicationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetApplicationAsync(new GetApplicationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `Application` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Application.
        /// Format: `networks/{network_code}/applications/{application_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> GetApplicationAsync(string name, st::CancellationToken cancellationToken) =>
            GetApplicationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `Application` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Application.
        /// Format: `networks/{network_code}/applications/{application_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Application GetApplication(ApplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetApplication(new GetApplicationRequest
            {
                ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `Application` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Application.
        /// Format: `networks/{network_code}/applications/{application_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> GetApplicationAsync(ApplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetApplicationAsync(new GetApplicationRequest
            {
                ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `Application` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Application.
        /// Format: `networks/{network_code}/applications/{application_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> GetApplicationAsync(ApplicationName name, st::CancellationToken cancellationToken) =>
            GetApplicationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a list of `Application` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Application"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListApplicationsResponse, Application> ListApplications(ListApplicationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `Application` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Application"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListApplicationsResponse, Application> ListApplicationsAsync(ListApplicationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `Application` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Applications.
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
        /// <returns>A pageable sequence of <see cref="Application"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListApplicationsResponse, Application> ListApplications(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApplicationsRequest request = new ListApplicationsRequest
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
            return ListApplications(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `Application` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Applications.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Application"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListApplicationsResponse, Application> ListApplicationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApplicationsRequest request = new ListApplicationsRequest
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
            return ListApplicationsAsync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `Application` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Applications.
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
        /// <returns>A pageable sequence of <see cref="Application"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListApplicationsResponse, Application> ListApplications(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApplicationsRequest request = new ListApplicationsRequest
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
            return ListApplications(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `Application` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Applications.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Application"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListApplicationsResponse, Application> ListApplicationsAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApplicationsRequest request = new ListApplicationsRequest
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
            return ListApplicationsAsync(request, callSettings);
        }
    }

    /// <summary>ApplicationService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `Application` objects.
    /// </remarks>
    public sealed partial class ApplicationServiceClientImpl : ApplicationServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetApplicationRequest, Application> _callGetApplication;

        private readonly gaxgrpc::ApiCall<ListApplicationsRequest, ListApplicationsResponse> _callListApplications;

        /// <summary>
        /// Constructs a client wrapper for the ApplicationService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ApplicationServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ApplicationServiceClientImpl(ApplicationService.ApplicationServiceClient grpcClient, ApplicationServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ApplicationServiceSettings effectiveSettings = settings ?? ApplicationServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetApplication = clientHelper.BuildApiCall<GetApplicationRequest, Application>("GetApplication", grpcClient.GetApplicationAsync, grpcClient.GetApplication, effectiveSettings.GetApplicationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetApplication);
            Modify_GetApplicationApiCall(ref _callGetApplication);
            _callListApplications = clientHelper.BuildApiCall<ListApplicationsRequest, ListApplicationsResponse>("ListApplications", grpcClient.ListApplicationsAsync, grpcClient.ListApplications, effectiveSettings.ListApplicationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListApplications);
            Modify_ListApplicationsApiCall(ref _callListApplications);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetApplicationApiCall(ref gaxgrpc::ApiCall<GetApplicationRequest, Application> call);

        partial void Modify_ListApplicationsApiCall(ref gaxgrpc::ApiCall<ListApplicationsRequest, ListApplicationsResponse> call);

        partial void OnConstruction(ApplicationService.ApplicationServiceClient grpcClient, ApplicationServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ApplicationService client</summary>
        public override ApplicationService.ApplicationServiceClient GrpcClient { get; }

        partial void Modify_GetApplicationRequest(ref GetApplicationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListApplicationsRequest(ref ListApplicationsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// API to retrieve a `Application` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Application GetApplication(GetApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetApplicationRequest(ref request, ref callSettings);
            return _callGetApplication.Sync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a `Application` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Application> GetApplicationAsync(GetApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetApplicationRequest(ref request, ref callSettings);
            return _callGetApplication.Async(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `Application` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Application"/> resources.</returns>
        public override gax::PagedEnumerable<ListApplicationsResponse, Application> ListApplications(ListApplicationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListApplicationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListApplicationsRequest, ListApplicationsResponse, Application>(_callListApplications, request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `Application` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Application"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListApplicationsResponse, Application> ListApplicationsAsync(ListApplicationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListApplicationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListApplicationsRequest, ListApplicationsResponse, Application>(_callListApplications, request, callSettings);
        }
    }

    public partial class ListApplicationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListApplicationsResponse : gaxgrpc::IPageResponse<Application>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Application> GetEnumerator() => Applications.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
