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

namespace Google.Cloud.DatabaseCenter.V1Beta
{
    /// <summary>Settings for <see cref="DatabaseCenterClient"/> instances.</summary>
    public sealed partial class DatabaseCenterSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DatabaseCenterSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DatabaseCenterSettings"/>.</returns>
        public static DatabaseCenterSettings GetDefault() => new DatabaseCenterSettings();

        /// <summary>Constructs a new <see cref="DatabaseCenterSettings"/> object with default settings.</summary>
        public DatabaseCenterSettings()
        {
        }

        private DatabaseCenterSettings(DatabaseCenterSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            QueryProductsSettings = existing.QueryProductsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DatabaseCenterSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatabaseCenterClient.QueryProducts</c> and <c>DatabaseCenterClient.QueryProductsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings QueryProductsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DatabaseCenterSettings"/> object.</returns>
        public DatabaseCenterSettings Clone() => new DatabaseCenterSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DatabaseCenterClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class DatabaseCenterClientBuilder : gaxgrpc::ClientBuilderBase<DatabaseCenterClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DatabaseCenterSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DatabaseCenterClientBuilder() : base(DatabaseCenterClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DatabaseCenterClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DatabaseCenterClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DatabaseCenterClient Build()
        {
            DatabaseCenterClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DatabaseCenterClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DatabaseCenterClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DatabaseCenterClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DatabaseCenterClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DatabaseCenterClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DatabaseCenterClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DatabaseCenterClient.ChannelPool;
    }

    /// <summary>DatabaseCenter client wrapper, for convenient use.</summary>
    /// <remarks>
    /// DatabaseCenter contains methods to query fleet view for database resources.
    /// </remarks>
    public abstract partial class DatabaseCenterClient
    {
        /// <summary>
        /// The default endpoint for the DatabaseCenter service, which is a host of "databasecenter.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "databasecenter.googleapis.com:443";

        /// <summary>The default DatabaseCenter scopes.</summary>
        /// <remarks>
        /// The default DatabaseCenter scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(DatabaseCenter.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DatabaseCenterClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DatabaseCenterClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DatabaseCenterClient"/>.</returns>
        public static stt::Task<DatabaseCenterClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DatabaseCenterClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DatabaseCenterClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DatabaseCenterClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DatabaseCenterClient"/>.</returns>
        public static DatabaseCenterClient Create() => new DatabaseCenterClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DatabaseCenterClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DatabaseCenterSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DatabaseCenterClient"/>.</returns>
        internal static DatabaseCenterClient Create(grpccore::CallInvoker callInvoker, DatabaseCenterSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DatabaseCenter.DatabaseCenterClient grpcClient = new DatabaseCenter.DatabaseCenterClient(callInvoker);
            return new DatabaseCenterClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC DatabaseCenter client</summary>
        public virtual DatabaseCenter.DatabaseCenterClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// QueryProducts provides a list of all possible products which can be used to
        /// filter database resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Product"/> resources.</returns>
        public virtual gax::PagedEnumerable<QueryProductsResponse, Product> QueryProducts(QueryProductsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// QueryProducts provides a list of all possible products which can be used to
        /// filter database resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Product"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<QueryProductsResponse, Product> QueryProductsAsync(QueryProductsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();
    }

    /// <summary>DatabaseCenter client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// DatabaseCenter contains methods to query fleet view for database resources.
    /// </remarks>
    public sealed partial class DatabaseCenterClientImpl : DatabaseCenterClient
    {
        private readonly gaxgrpc::ApiCall<QueryProductsRequest, QueryProductsResponse> _callQueryProducts;

        /// <summary>
        /// Constructs a client wrapper for the DatabaseCenter service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DatabaseCenterSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DatabaseCenterClientImpl(DatabaseCenter.DatabaseCenterClient grpcClient, DatabaseCenterSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DatabaseCenterSettings effectiveSettings = settings ?? DatabaseCenterSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callQueryProducts = clientHelper.BuildApiCall<QueryProductsRequest, QueryProductsResponse>("QueryProducts", grpcClient.QueryProductsAsync, grpcClient.QueryProducts, effectiveSettings.QueryProductsSettings);
            Modify_ApiCall(ref _callQueryProducts);
            Modify_QueryProductsApiCall(ref _callQueryProducts);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_QueryProductsApiCall(ref gaxgrpc::ApiCall<QueryProductsRequest, QueryProductsResponse> call);

        partial void OnConstruction(DatabaseCenter.DatabaseCenterClient grpcClient, DatabaseCenterSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DatabaseCenter client</summary>
        public override DatabaseCenter.DatabaseCenterClient GrpcClient { get; }

        partial void Modify_QueryProductsRequest(ref QueryProductsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// QueryProducts provides a list of all possible products which can be used to
        /// filter database resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Product"/> resources.</returns>
        public override gax::PagedEnumerable<QueryProductsResponse, Product> QueryProducts(QueryProductsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryProductsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<QueryProductsRequest, QueryProductsResponse, Product>(_callQueryProducts, request, callSettings);
        }

        /// <summary>
        /// QueryProducts provides a list of all possible products which can be used to
        /// filter database resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Product"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<QueryProductsResponse, Product> QueryProductsAsync(QueryProductsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryProductsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<QueryProductsRequest, QueryProductsResponse, Product>(_callQueryProducts, request, callSettings);
        }
    }

    public partial class QueryProductsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class QueryProductsResponse : gaxgrpc::IPageResponse<Product>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Product> GetEnumerator() => Products.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
