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
using lro = Google.LongRunning;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.Compute.V1
{
    /// <summary>Settings for <see cref="GlobalOrganizationOperationsClient"/> instances.</summary>
    public sealed partial class GlobalOrganizationOperationsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="GlobalOrganizationOperationsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="GlobalOrganizationOperationsSettings"/>.</returns>
        public static GlobalOrganizationOperationsSettings GetDefault() => new GlobalOrganizationOperationsSettings();

        /// <summary>
        /// Constructs a new <see cref="GlobalOrganizationOperationsSettings"/> object with default settings.
        /// </summary>
        public GlobalOrganizationOperationsSettings()
        {
        }

        private GlobalOrganizationOperationsSettings(GlobalOrganizationOperationsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            DeleteSettings = existing.DeleteSettings;
            GetSettings = existing.GetSettings;
            ListSettings = existing.ListSettings;
            OnCopy(existing);
        }

        partial void OnCopy(GlobalOrganizationOperationsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GlobalOrganizationOperationsClient.Delete</c> and <c>GlobalOrganizationOperationsClient.DeleteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GlobalOrganizationOperationsClient.Get</c> and <c>GlobalOrganizationOperationsClient.GetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GlobalOrganizationOperationsClient.List</c> and <c>GlobalOrganizationOperationsClient.ListAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="GlobalOrganizationOperationsSettings"/> object.</returns>
        public GlobalOrganizationOperationsSettings Clone() => new GlobalOrganizationOperationsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="GlobalOrganizationOperationsClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class GlobalOrganizationOperationsClientBuilder : gaxgrpc::ClientBuilderBase<GlobalOrganizationOperationsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public GlobalOrganizationOperationsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public GlobalOrganizationOperationsClientBuilder() : base(GlobalOrganizationOperationsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref GlobalOrganizationOperationsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<GlobalOrganizationOperationsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override GlobalOrganizationOperationsClient Build()
        {
            GlobalOrganizationOperationsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<GlobalOrganizationOperationsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<GlobalOrganizationOperationsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private GlobalOrganizationOperationsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return GlobalOrganizationOperationsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<GlobalOrganizationOperationsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return GlobalOrganizationOperationsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => GlobalOrganizationOperationsClient.ChannelPool;
    }

    /// <summary>GlobalOrganizationOperations client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The GlobalOrganizationOperations API.
    /// </remarks>
    public abstract partial class GlobalOrganizationOperationsClient
    {
        /// <summary>
        /// The default endpoint for the GlobalOrganizationOperations service, which is a host of
        /// "compute.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default GlobalOrganizationOperations scopes.</summary>
        /// <remarks>
        /// The default GlobalOrganizationOperations scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/compute</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/compute",
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(GlobalOrganizationOperations.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="GlobalOrganizationOperationsClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="GlobalOrganizationOperationsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="GlobalOrganizationOperationsClient"/>.</returns>
        public static stt::Task<GlobalOrganizationOperationsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new GlobalOrganizationOperationsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="GlobalOrganizationOperationsClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="GlobalOrganizationOperationsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="GlobalOrganizationOperationsClient"/>.</returns>
        public static GlobalOrganizationOperationsClient Create() => new GlobalOrganizationOperationsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="GlobalOrganizationOperationsClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="GlobalOrganizationOperationsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="GlobalOrganizationOperationsClient"/>.</returns>
        internal static GlobalOrganizationOperationsClient Create(grpccore::CallInvoker callInvoker, GlobalOrganizationOperationsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            GlobalOrganizationOperations.GlobalOrganizationOperationsClient grpcClient = new GlobalOrganizationOperations.GlobalOrganizationOperationsClient(callInvoker);
            return new GlobalOrganizationOperationsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC GlobalOrganizationOperations client</summary>
        public virtual GlobalOrganizationOperations.GlobalOrganizationOperationsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified Operations resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeleteGlobalOrganizationOperationResponse Delete(DeleteGlobalOrganizationOperationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified Operations resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeleteGlobalOrganizationOperationResponse> DeleteAsync(DeleteGlobalOrganizationOperationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified Operations resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeleteGlobalOrganizationOperationResponse> DeleteAsync(DeleteGlobalOrganizationOperationRequest request, st::CancellationToken cancellationToken) =>
            DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified Operations resource.
        /// </summary>
        /// <param name="operation">
        /// Name of the Operations resource to delete, or its unique numeric identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeleteGlobalOrganizationOperationResponse Delete(string operation, gaxgrpc::CallSettings callSettings = null) =>
            Delete(new DeleteGlobalOrganizationOperationRequest
            {
                Operation = gax::GaxPreconditions.CheckNotNullOrEmpty(operation, nameof(operation)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified Operations resource.
        /// </summary>
        /// <param name="operation">
        /// Name of the Operations resource to delete, or its unique numeric identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeleteGlobalOrganizationOperationResponse> DeleteAsync(string operation, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAsync(new DeleteGlobalOrganizationOperationRequest
            {
                Operation = gax::GaxPreconditions.CheckNotNullOrEmpty(operation, nameof(operation)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified Operations resource.
        /// </summary>
        /// <param name="operation">
        /// Name of the Operations resource to delete, or its unique numeric identifier.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeleteGlobalOrganizationOperationResponse> DeleteAsync(string operation, st::CancellationToken cancellationToken) =>
            DeleteAsync(operation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified Operations resource. Gets a list of operations by making a `list()` request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Get(GetGlobalOrganizationOperationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified Operations resource. Gets a list of operations by making a `list()` request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> GetAsync(GetGlobalOrganizationOperationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified Operations resource. Gets a list of operations by making a `list()` request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> GetAsync(GetGlobalOrganizationOperationRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified Operations resource. Gets a list of operations by making a `list()` request.
        /// </summary>
        /// <param name="operation">
        /// Name of the Operations resource to return, or its unique numeric identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Get(string operation, gaxgrpc::CallSettings callSettings = null) =>
            Get(new GetGlobalOrganizationOperationRequest
            {
                Operation = gax::GaxPreconditions.CheckNotNullOrEmpty(operation, nameof(operation)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified Operations resource. Gets a list of operations by making a `list()` request.
        /// </summary>
        /// <param name="operation">
        /// Name of the Operations resource to return, or its unique numeric identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> GetAsync(string operation, gaxgrpc::CallSettings callSettings = null) =>
            GetAsync(new GetGlobalOrganizationOperationRequest
            {
                Operation = gax::GaxPreconditions.CheckNotNullOrEmpty(operation, nameof(operation)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified Operations resource. Gets a list of operations by making a `list()` request.
        /// </summary>
        /// <param name="operation">
        /// Name of the Operations resource to return, or its unique numeric identifier.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> GetAsync(string operation, st::CancellationToken cancellationToken) =>
            GetAsync(operation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a list of Operation resources contained within the specified organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Operation"/> resources.</returns>
        public virtual gax::PagedEnumerable<OperationList, Operation> List(ListGlobalOrganizationOperationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of Operation resources contained within the specified organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Operation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<OperationList, Operation> ListAsync(ListGlobalOrganizationOperationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of Operation resources contained within the specified organization.
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
        /// <returns>A pageable sequence of <see cref="Operation"/> resources.</returns>
        public virtual gax::PagedEnumerable<OperationList, Operation> List(string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGlobalOrganizationOperationsRequest request = new ListGlobalOrganizationOperationsRequest { };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return List(request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of Operation resources contained within the specified organization.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Operation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<OperationList, Operation> ListAsync(string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGlobalOrganizationOperationsRequest request = new ListGlobalOrganizationOperationsRequest { };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAsync(request, callSettings);
        }
    }

    /// <summary>GlobalOrganizationOperations client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The GlobalOrganizationOperations API.
    /// </remarks>
    public sealed partial class GlobalOrganizationOperationsClientImpl : GlobalOrganizationOperationsClient
    {
        private readonly gaxgrpc::ApiCall<DeleteGlobalOrganizationOperationRequest, DeleteGlobalOrganizationOperationResponse> _callDelete;

        private readonly gaxgrpc::ApiCall<GetGlobalOrganizationOperationRequest, Operation> _callGet;

        private readonly gaxgrpc::ApiCall<ListGlobalOrganizationOperationsRequest, OperationList> _callList;

        /// <summary>
        /// Constructs a client wrapper for the GlobalOrganizationOperations service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="GlobalOrganizationOperationsSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public GlobalOrganizationOperationsClientImpl(GlobalOrganizationOperations.GlobalOrganizationOperationsClient grpcClient, GlobalOrganizationOperationsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            GlobalOrganizationOperationsSettings effectiveSettings = settings ?? GlobalOrganizationOperationsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callDelete = clientHelper.BuildApiCall<DeleteGlobalOrganizationOperationRequest, DeleteGlobalOrganizationOperationResponse>("Delete", grpcClient.DeleteAsync, grpcClient.Delete, effectiveSettings.DeleteSettings).WithGoogleRequestParam("operation", request => request.Operation);
            Modify_ApiCall(ref _callDelete);
            Modify_DeleteApiCall(ref _callDelete);
            _callGet = clientHelper.BuildApiCall<GetGlobalOrganizationOperationRequest, Operation>("Get", grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("operation", request => request.Operation);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callList = clientHelper.BuildApiCall<ListGlobalOrganizationOperationsRequest, OperationList>("List", grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_DeleteApiCall(ref gaxgrpc::ApiCall<DeleteGlobalOrganizationOperationRequest, DeleteGlobalOrganizationOperationResponse> call);

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetGlobalOrganizationOperationRequest, Operation> call);

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<ListGlobalOrganizationOperationsRequest, OperationList> call);

        partial void OnConstruction(GlobalOrganizationOperations.GlobalOrganizationOperationsClient grpcClient, GlobalOrganizationOperationsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC GlobalOrganizationOperations client</summary>
        public override GlobalOrganizationOperations.GlobalOrganizationOperationsClient GrpcClient { get; }

        partial void Modify_DeleteGlobalOrganizationOperationRequest(ref DeleteGlobalOrganizationOperationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetGlobalOrganizationOperationRequest(ref GetGlobalOrganizationOperationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListGlobalOrganizationOperationsRequest(ref ListGlobalOrganizationOperationsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Deletes the specified Operations resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DeleteGlobalOrganizationOperationResponse Delete(DeleteGlobalOrganizationOperationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGlobalOrganizationOperationRequest(ref request, ref callSettings);
            return _callDelete.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified Operations resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DeleteGlobalOrganizationOperationResponse> DeleteAsync(DeleteGlobalOrganizationOperationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGlobalOrganizationOperationRequest(ref request, ref callSettings);
            return _callDelete.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified Operations resource. Gets a list of operations by making a `list()` request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Get(GetGlobalOrganizationOperationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGlobalOrganizationOperationRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified Operations resource. Gets a list of operations by making a `list()` request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> GetAsync(GetGlobalOrganizationOperationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGlobalOrganizationOperationRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of Operation resources contained within the specified organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Operation"/> resources.</returns>
        public override gax::PagedEnumerable<OperationList, Operation> List(ListGlobalOrganizationOperationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGlobalOrganizationOperationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListGlobalOrganizationOperationsRequest, OperationList, Operation>(_callList, request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of Operation resources contained within the specified organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Operation"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<OperationList, Operation> ListAsync(ListGlobalOrganizationOperationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGlobalOrganizationOperationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListGlobalOrganizationOperationsRequest, OperationList, Operation>(_callList, request, callSettings);
        }
    }

    public partial class ListGlobalOrganizationOperationsRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public static partial class GlobalOrganizationOperations
    {
        public partial class GlobalOrganizationOperationsClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/>using the specified call
            /// invoker, but redirecting Google.LongRunning RPCs to GlobalOrganizationOperations RPCs.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            internal static lro::Operations.OperationsClient CreateOperationsClient(grpccore::CallInvoker callInvoker)
            {
                grpccore::CallInvoker forwardingCallInvoker = gaxgrpc::ForwardingCallInvoker<lro::GetOperationRequest>.Create(callInvoker, "/google.longrunning.Operations/GetOperation", __Method_Get, GetGlobalOrganizationOperationRequest.ParseLroRequest, (request, response) => response.ToLroResponse(request.Name));
                return new lro::Operations.OperationsClient(forwardingCallInvoker);
            }
        }
    }
}
