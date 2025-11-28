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
using gcl = Google.Cloud.Location;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using lro = Google.LongRunning;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.DiscoveryEngine.V1
{
    /// <summary>Settings for <see cref="UserLicenseServiceClient"/> instances.</summary>
    public sealed partial class UserLicenseServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="UserLicenseServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="UserLicenseServiceSettings"/>.</returns>
        public static UserLicenseServiceSettings GetDefault() => new UserLicenseServiceSettings();

        /// <summary>Constructs a new <see cref="UserLicenseServiceSettings"/> object with default settings.</summary>
        public UserLicenseServiceSettings()
        {
        }

        private UserLicenseServiceSettings(UserLicenseServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListUserLicensesSettings = existing.ListUserLicensesSettings;
            BatchUpdateUserLicensesSettings = existing.BatchUpdateUserLicensesSettings;
            BatchUpdateUserLicensesOperationsSettings = existing.BatchUpdateUserLicensesOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(UserLicenseServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UserLicenseServiceClient.ListUserLicenses</c> and <c>UserLicenseServiceClient.ListUserLicensesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListUserLicensesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UserLicenseServiceClient.BatchUpdateUserLicenses</c> and
        /// <c>UserLicenseServiceClient.BatchUpdateUserLicensesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchUpdateUserLicensesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>UserLicenseServiceClient.BatchUpdateUserLicenses</c> and
        /// <c>UserLicenseServiceClient.BatchUpdateUserLicensesAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings BatchUpdateUserLicensesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="UserLicenseServiceSettings"/> object.</returns>
        public UserLicenseServiceSettings Clone() => new UserLicenseServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="UserLicenseServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class UserLicenseServiceClientBuilder : gaxgrpc::ClientBuilderBase<UserLicenseServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public UserLicenseServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public UserLicenseServiceClientBuilder() : base(UserLicenseServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref UserLicenseServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<UserLicenseServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override UserLicenseServiceClient Build()
        {
            UserLicenseServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<UserLicenseServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<UserLicenseServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private UserLicenseServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return UserLicenseServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<UserLicenseServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return UserLicenseServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => UserLicenseServiceClient.ChannelPool;
    }

    /// <summary>UserLicenseService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing User Licenses.
    /// </remarks>
    public abstract partial class UserLicenseServiceClient
    {
        /// <summary>
        /// The default endpoint for the UserLicenseService service, which is a host of "discoveryengine.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "discoveryengine.googleapis.com:443";

        /// <summary>The default UserLicenseService scopes.</summary>
        /// <remarks>
        /// The default UserLicenseService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(UserLicenseService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="UserLicenseServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="UserLicenseServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="UserLicenseServiceClient"/>.</returns>
        public static stt::Task<UserLicenseServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new UserLicenseServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="UserLicenseServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="UserLicenseServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="UserLicenseServiceClient"/>.</returns>
        public static UserLicenseServiceClient Create() => new UserLicenseServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="UserLicenseServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="UserLicenseServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="UserLicenseServiceClient"/>.</returns>
        internal static UserLicenseServiceClient Create(grpccore::CallInvoker callInvoker, UserLicenseServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            UserLicenseService.UserLicenseServiceClient grpcClient = new UserLicenseService.UserLicenseServiceClient(callInvoker);
            return new UserLicenseServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC UserLicenseService client</summary>
        public virtual UserLicenseService.UserLicenseServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the User Licenses.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="UserLicense"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUserLicensesResponse, UserLicense> ListUserLicenses(ListUserLicensesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the User Licenses.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="UserLicense"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUserLicensesResponse, UserLicense> ListUserLicensesAsync(ListUserLicensesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the User Licenses.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent [UserStore][] resource name, format:
        /// `projects/{project}/locations/{location}/userStores/{user_store_id}`.
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
        /// <returns>A pageable sequence of <see cref="UserLicense"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUserLicensesResponse, UserLicense> ListUserLicenses(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUserLicensesRequest request = new ListUserLicensesRequest
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
            return ListUserLicenses(request, callSettings);
        }

        /// <summary>
        /// Lists the User Licenses.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent [UserStore][] resource name, format:
        /// `projects/{project}/locations/{location}/userStores/{user_store_id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="UserLicense"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUserLicensesResponse, UserLicense> ListUserLicensesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUserLicensesRequest request = new ListUserLicensesRequest
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
            return ListUserLicensesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the User Licenses.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent [UserStore][] resource name, format:
        /// `projects/{project}/locations/{location}/userStores/{user_store_id}`.
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
        /// <returns>A pageable sequence of <see cref="UserLicense"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUserLicensesResponse, UserLicense> ListUserLicenses(UserStoreName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUserLicensesRequest request = new ListUserLicensesRequest
            {
                ParentAsUserStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListUserLicenses(request, callSettings);
        }

        /// <summary>
        /// Lists the User Licenses.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent [UserStore][] resource name, format:
        /// `projects/{project}/locations/{location}/userStores/{user_store_id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="UserLicense"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUserLicensesResponse, UserLicense> ListUserLicensesAsync(UserStoreName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUserLicensesRequest request = new ListUserLicensesRequest
            {
                ParentAsUserStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListUserLicensesAsync(request, callSettings);
        }

        /// <summary>
        /// Updates the User License.
        /// This method is used for batch assign/unassign licenses to users.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchUpdateUserLicensesResponse, BatchUpdateUserLicensesMetadata> BatchUpdateUserLicenses(BatchUpdateUserLicensesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the User License.
        /// This method is used for batch assign/unassign licenses to users.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchUpdateUserLicensesResponse, BatchUpdateUserLicensesMetadata>> BatchUpdateUserLicensesAsync(BatchUpdateUserLicensesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the User License.
        /// This method is used for batch assign/unassign licenses to users.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchUpdateUserLicensesResponse, BatchUpdateUserLicensesMetadata>> BatchUpdateUserLicensesAsync(BatchUpdateUserLicensesRequest request, st::CancellationToken cancellationToken) =>
            BatchUpdateUserLicensesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>BatchUpdateUserLicenses</c>.</summary>
        public virtual lro::OperationsClient BatchUpdateUserLicensesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BatchUpdateUserLicenses</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<BatchUpdateUserLicensesResponse, BatchUpdateUserLicensesMetadata> PollOnceBatchUpdateUserLicenses(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchUpdateUserLicensesResponse, BatchUpdateUserLicensesMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchUpdateUserLicensesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BatchUpdateUserLicenses</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<BatchUpdateUserLicensesResponse, BatchUpdateUserLicensesMetadata>> PollOnceBatchUpdateUserLicensesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchUpdateUserLicensesResponse, BatchUpdateUserLicensesMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchUpdateUserLicensesOperationsClient, callSettings);
    }

    /// <summary>UserLicenseService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing User Licenses.
    /// </remarks>
    public sealed partial class UserLicenseServiceClientImpl : UserLicenseServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListUserLicensesRequest, ListUserLicensesResponse> _callListUserLicenses;

        private readonly gaxgrpc::ApiCall<BatchUpdateUserLicensesRequest, lro::Operation> _callBatchUpdateUserLicenses;

        /// <summary>
        /// Constructs a client wrapper for the UserLicenseService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="UserLicenseServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public UserLicenseServiceClientImpl(UserLicenseService.UserLicenseServiceClient grpcClient, UserLicenseServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            UserLicenseServiceSettings effectiveSettings = settings ?? UserLicenseServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            BatchUpdateUserLicensesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.BatchUpdateUserLicensesOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListUserLicenses = clientHelper.BuildApiCall<ListUserLicensesRequest, ListUserLicensesResponse>("ListUserLicenses", grpcClient.ListUserLicensesAsync, grpcClient.ListUserLicenses, effectiveSettings.ListUserLicensesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListUserLicenses);
            Modify_ListUserLicensesApiCall(ref _callListUserLicenses);
            _callBatchUpdateUserLicenses = clientHelper.BuildApiCall<BatchUpdateUserLicensesRequest, lro::Operation>("BatchUpdateUserLicenses", grpcClient.BatchUpdateUserLicensesAsync, grpcClient.BatchUpdateUserLicenses, effectiveSettings.BatchUpdateUserLicensesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchUpdateUserLicenses);
            Modify_BatchUpdateUserLicensesApiCall(ref _callBatchUpdateUserLicenses);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListUserLicensesApiCall(ref gaxgrpc::ApiCall<ListUserLicensesRequest, ListUserLicensesResponse> call);

        partial void Modify_BatchUpdateUserLicensesApiCall(ref gaxgrpc::ApiCall<BatchUpdateUserLicensesRequest, lro::Operation> call);

        partial void OnConstruction(UserLicenseService.UserLicenseServiceClient grpcClient, UserLicenseServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC UserLicenseService client</summary>
        public override UserLicenseService.UserLicenseServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListUserLicensesRequest(ref ListUserLicensesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchUpdateUserLicensesRequest(ref BatchUpdateUserLicensesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists the User Licenses.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="UserLicense"/> resources.</returns>
        public override gax::PagedEnumerable<ListUserLicensesResponse, UserLicense> ListUserLicenses(ListUserLicensesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUserLicensesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListUserLicensesRequest, ListUserLicensesResponse, UserLicense>(_callListUserLicenses, request, callSettings);
        }

        /// <summary>
        /// Lists the User Licenses.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="UserLicense"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListUserLicensesResponse, UserLicense> ListUserLicensesAsync(ListUserLicensesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUserLicensesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListUserLicensesRequest, ListUserLicensesResponse, UserLicense>(_callListUserLicenses, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>BatchUpdateUserLicenses</c>.</summary>
        public override lro::OperationsClient BatchUpdateUserLicensesOperationsClient { get; }

        /// <summary>
        /// Updates the User License.
        /// This method is used for batch assign/unassign licenses to users.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<BatchUpdateUserLicensesResponse, BatchUpdateUserLicensesMetadata> BatchUpdateUserLicenses(BatchUpdateUserLicensesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateUserLicensesRequest(ref request, ref callSettings);
            return new lro::Operation<BatchUpdateUserLicensesResponse, BatchUpdateUserLicensesMetadata>(_callBatchUpdateUserLicenses.Sync(request, callSettings), BatchUpdateUserLicensesOperationsClient);
        }

        /// <summary>
        /// Updates the User License.
        /// This method is used for batch assign/unassign licenses to users.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<BatchUpdateUserLicensesResponse, BatchUpdateUserLicensesMetadata>> BatchUpdateUserLicensesAsync(BatchUpdateUserLicensesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateUserLicensesRequest(ref request, ref callSettings);
            return new lro::Operation<BatchUpdateUserLicensesResponse, BatchUpdateUserLicensesMetadata>(await _callBatchUpdateUserLicenses.Async(request, callSettings).ConfigureAwait(false), BatchUpdateUserLicensesOperationsClient);
        }
    }

    public partial class ListUserLicensesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListUserLicensesResponse : gaxgrpc::IPageResponse<UserLicense>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<UserLicense> GetEnumerator() => UserLicenses.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class UserLicenseService
    {
        public partial class UserLicenseServiceClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() =>
                new lro::Operations.OperationsClient(CallInvoker);
        }
    }

    public static partial class UserLicenseService
    {
        public partial class UserLicenseServiceClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="gcl::Locations.LocationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>
            /// A new <see cref="gcl::Locations.LocationsClient"/> for the same target as this client.
            /// </returns>
            public virtual gcl::Locations.LocationsClient CreateLocationsClient() =>
                new gcl::Locations.LocationsClient(CallInvoker);
        }
    }
}
