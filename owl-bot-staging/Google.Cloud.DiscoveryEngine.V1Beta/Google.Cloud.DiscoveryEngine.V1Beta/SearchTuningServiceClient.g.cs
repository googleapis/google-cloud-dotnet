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
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.DiscoveryEngine.V1Beta
{
    /// <summary>Settings for <see cref="SearchTuningServiceClient"/> instances.</summary>
    public sealed partial class SearchTuningServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SearchTuningServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SearchTuningServiceSettings"/>.</returns>
        public static SearchTuningServiceSettings GetDefault() => new SearchTuningServiceSettings();

        /// <summary>Constructs a new <see cref="SearchTuningServiceSettings"/> object with default settings.</summary>
        public SearchTuningServiceSettings()
        {
        }

        private SearchTuningServiceSettings(SearchTuningServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            TrainCustomModelSettings = existing.TrainCustomModelSettings;
            TrainCustomModelOperationsSettings = existing.TrainCustomModelOperationsSettings.Clone();
            ListCustomModelsSettings = existing.ListCustomModelsSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SearchTuningServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SearchTuningServiceClient.TrainCustomModel</c> and <c>SearchTuningServiceClient.TrainCustomModelAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TrainCustomModelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>SearchTuningServiceClient.TrainCustomModel</c> and
        /// <c>SearchTuningServiceClient.TrainCustomModelAsync</c>.
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
        public lro::OperationsSettings TrainCustomModelOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SearchTuningServiceClient.ListCustomModels</c> and <c>SearchTuningServiceClient.ListCustomModelsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListCustomModelsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SearchTuningServiceSettings"/> object.</returns>
        public SearchTuningServiceSettings Clone() => new SearchTuningServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SearchTuningServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class SearchTuningServiceClientBuilder : gaxgrpc::ClientBuilderBase<SearchTuningServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SearchTuningServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SearchTuningServiceClientBuilder() : base(SearchTuningServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref SearchTuningServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SearchTuningServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SearchTuningServiceClient Build()
        {
            SearchTuningServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SearchTuningServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SearchTuningServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SearchTuningServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SearchTuningServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<SearchTuningServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SearchTuningServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SearchTuningServiceClient.ChannelPool;
    }

    /// <summary>SearchTuningService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for search tuning.
    /// </remarks>
    public abstract partial class SearchTuningServiceClient
    {
        /// <summary>
        /// The default endpoint for the SearchTuningService service, which is a host of
        /// "discoveryengine.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "discoveryengine.googleapis.com:443";

        /// <summary>The default SearchTuningService scopes.</summary>
        /// <remarks>
        /// The default SearchTuningService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(SearchTuningService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="SearchTuningServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="SearchTuningServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SearchTuningServiceClient"/>.</returns>
        public static stt::Task<SearchTuningServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SearchTuningServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SearchTuningServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="SearchTuningServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SearchTuningServiceClient"/>.</returns>
        public static SearchTuningServiceClient Create() => new SearchTuningServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SearchTuningServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SearchTuningServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="SearchTuningServiceClient"/>.</returns>
        internal static SearchTuningServiceClient Create(grpccore::CallInvoker callInvoker, SearchTuningServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SearchTuningService.SearchTuningServiceClient grpcClient = new SearchTuningService.SearchTuningServiceClient(callInvoker);
            return new SearchTuningServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC SearchTuningService client</summary>
        public virtual SearchTuningService.SearchTuningServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Trains a custom model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TrainCustomModelResponse, TrainCustomModelMetadata> TrainCustomModel(TrainCustomModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Trains a custom model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TrainCustomModelResponse, TrainCustomModelMetadata>> TrainCustomModelAsync(TrainCustomModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Trains a custom model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TrainCustomModelResponse, TrainCustomModelMetadata>> TrainCustomModelAsync(TrainCustomModelRequest request, st::CancellationToken cancellationToken) =>
            TrainCustomModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>TrainCustomModel</c>.</summary>
        public virtual lro::OperationsClient TrainCustomModelOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>TrainCustomModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<TrainCustomModelResponse, TrainCustomModelMetadata> PollOnceTrainCustomModel(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<TrainCustomModelResponse, TrainCustomModelMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), TrainCustomModelOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>TrainCustomModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<TrainCustomModelResponse, TrainCustomModelMetadata>> PollOnceTrainCustomModelAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<TrainCustomModelResponse, TrainCustomModelMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), TrainCustomModelOperationsClient, callSettings);

        /// <summary>
        /// Gets a list of all the custom models.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListCustomModelsResponse ListCustomModels(ListCustomModelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a list of all the custom models.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListCustomModelsResponse> ListCustomModelsAsync(ListCustomModelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a list of all the custom models.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListCustomModelsResponse> ListCustomModelsAsync(ListCustomModelsRequest request, st::CancellationToken cancellationToken) =>
            ListCustomModelsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>SearchTuningService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for search tuning.
    /// </remarks>
    public sealed partial class SearchTuningServiceClientImpl : SearchTuningServiceClient
    {
        private readonly gaxgrpc::ApiCall<TrainCustomModelRequest, lro::Operation> _callTrainCustomModel;

        private readonly gaxgrpc::ApiCall<ListCustomModelsRequest, ListCustomModelsResponse> _callListCustomModels;

        /// <summary>
        /// Constructs a client wrapper for the SearchTuningService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SearchTuningServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public SearchTuningServiceClientImpl(SearchTuningService.SearchTuningServiceClient grpcClient, SearchTuningServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            SearchTuningServiceSettings effectiveSettings = settings ?? SearchTuningServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            TrainCustomModelOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.TrainCustomModelOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callTrainCustomModel = clientHelper.BuildApiCall<TrainCustomModelRequest, lro::Operation>("TrainCustomModel", grpcClient.TrainCustomModelAsync, grpcClient.TrainCustomModel, effectiveSettings.TrainCustomModelSettings).WithGoogleRequestParam("data_store", request => request.DataStore);
            Modify_ApiCall(ref _callTrainCustomModel);
            Modify_TrainCustomModelApiCall(ref _callTrainCustomModel);
            _callListCustomModels = clientHelper.BuildApiCall<ListCustomModelsRequest, ListCustomModelsResponse>("ListCustomModels", grpcClient.ListCustomModelsAsync, grpcClient.ListCustomModels, effectiveSettings.ListCustomModelsSettings).WithGoogleRequestParam("data_store", request => request.DataStore);
            Modify_ApiCall(ref _callListCustomModels);
            Modify_ListCustomModelsApiCall(ref _callListCustomModels);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_TrainCustomModelApiCall(ref gaxgrpc::ApiCall<TrainCustomModelRequest, lro::Operation> call);

        partial void Modify_ListCustomModelsApiCall(ref gaxgrpc::ApiCall<ListCustomModelsRequest, ListCustomModelsResponse> call);

        partial void OnConstruction(SearchTuningService.SearchTuningServiceClient grpcClient, SearchTuningServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SearchTuningService client</summary>
        public override SearchTuningService.SearchTuningServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_TrainCustomModelRequest(ref TrainCustomModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCustomModelsRequest(ref ListCustomModelsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>TrainCustomModel</c>.</summary>
        public override lro::OperationsClient TrainCustomModelOperationsClient { get; }

        /// <summary>
        /// Trains a custom model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<TrainCustomModelResponse, TrainCustomModelMetadata> TrainCustomModel(TrainCustomModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TrainCustomModelRequest(ref request, ref callSettings);
            return new lro::Operation<TrainCustomModelResponse, TrainCustomModelMetadata>(_callTrainCustomModel.Sync(request, callSettings), TrainCustomModelOperationsClient);
        }

        /// <summary>
        /// Trains a custom model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<TrainCustomModelResponse, TrainCustomModelMetadata>> TrainCustomModelAsync(TrainCustomModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TrainCustomModelRequest(ref request, ref callSettings);
            return new lro::Operation<TrainCustomModelResponse, TrainCustomModelMetadata>(await _callTrainCustomModel.Async(request, callSettings).ConfigureAwait(false), TrainCustomModelOperationsClient);
        }

        /// <summary>
        /// Gets a list of all the custom models.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ListCustomModelsResponse ListCustomModels(ListCustomModelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCustomModelsRequest(ref request, ref callSettings);
            return _callListCustomModels.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a list of all the custom models.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ListCustomModelsResponse> ListCustomModelsAsync(ListCustomModelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCustomModelsRequest(ref request, ref callSettings);
            return _callListCustomModels.Async(request, callSettings);
        }
    }

    public static partial class SearchTuningService
    {
        public partial class SearchTuningServiceClient
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

    public static partial class SearchTuningService
    {
        public partial class SearchTuningServiceClient
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
