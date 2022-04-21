// Copyright 2022 Google LLC
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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.DataQnA.V1Alpha
{
    /// <summary>Settings for <see cref="AutoSuggestionServiceClient"/> instances.</summary>
    public sealed partial class AutoSuggestionServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AutoSuggestionServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AutoSuggestionServiceSettings"/>.</returns>
        public static AutoSuggestionServiceSettings GetDefault() => new AutoSuggestionServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="AutoSuggestionServiceSettings"/> object with default settings.
        /// </summary>
        public AutoSuggestionServiceSettings()
        {
        }

        private AutoSuggestionServiceSettings(AutoSuggestionServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            SuggestQueriesSettings = existing.SuggestQueriesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AutoSuggestionServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AutoSuggestionServiceClient.SuggestQueries</c> and <c>AutoSuggestionServiceClient.SuggestQueriesAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 2 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SuggestQueriesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(2000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AutoSuggestionServiceSettings"/> object.</returns>
        public AutoSuggestionServiceSettings Clone() => new AutoSuggestionServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AutoSuggestionServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class AutoSuggestionServiceClientBuilder : gaxgrpc::ClientBuilderBase<AutoSuggestionServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AutoSuggestionServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AutoSuggestionServiceClientBuilder() : base(AutoSuggestionServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AutoSuggestionServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AutoSuggestionServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AutoSuggestionServiceClient Build()
        {
            AutoSuggestionServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AutoSuggestionServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AutoSuggestionServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AutoSuggestionServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AutoSuggestionServiceClient.Create(callInvoker, Settings, Logger);
        }

        private async stt::Task<AutoSuggestionServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AutoSuggestionServiceClient.Create(callInvoker, Settings, Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AutoSuggestionServiceClient.ChannelPool;
    }

    /// <summary>AutoSuggestionService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// This stateless API provides automatic suggestions for natural language
    /// queries for the data sources in the provided project and location.
    /// 
    /// The service provides a resourceless operation `suggestQueries` that can be
    /// called to get a list of suggestions for a given incomplete query and scope
    /// (or list of scopes) under which the query is to be interpreted.
    /// 
    /// There are two types of suggestions, ENTITY for single entity suggestions
    /// and TEMPLATE for full sentences. By default, both types are returned.
    /// 
    /// Example Request:
    /// ```
    /// GetSuggestions({
    /// parent: "locations/us/projects/my-project"
    /// scopes:
    /// "//bigquery.googleapis.com/projects/my-project/datasets/my-dataset/tables/my-table"
    /// query: "top it"
    /// })
    /// ```
    /// 
    /// The service will retrieve information based on the given scope(s) and give
    /// suggestions based on that (e.g. "top item" for "top it" if "item" is a known
    /// dimension for the provided scope).
    /// ```
    /// suggestions {
    /// suggestion_info {
    /// annotated_suggestion {
    /// text_formatted: "top item by sum of usd_revenue_net"
    /// markups {
    /// type: DIMENSION
    /// start_char_index: 4
    /// length: 4
    /// }
    /// markups {
    /// type: METRIC
    /// start_char_index: 19
    /// length: 15
    /// }
    /// }
    /// query_matches {
    /// start_char_index: 0
    /// length: 6
    /// }
    /// }
    /// suggestion_type: TEMPLATE
    /// ranking_score: 0.9
    /// }
    /// suggestions {
    /// suggestion_info {
    /// annotated_suggestion {
    /// text_formatted: "item"
    /// markups {
    /// type: DIMENSION
    /// start_char_index: 4
    /// length: 2
    /// }
    /// }
    /// query_matches {
    /// start_char_index: 0
    /// length: 6
    /// }
    /// }
    /// suggestion_type: ENTITY
    /// ranking_score: 0.8
    /// }
    /// ```
    /// </remarks>
    public abstract partial class AutoSuggestionServiceClient
    {
        /// <summary>
        /// The default endpoint for the AutoSuggestionService service, which is a host of "dataqna.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dataqna.googleapis.com:443";

        /// <summary>The default AutoSuggestionService scopes.</summary>
        /// <remarks>
        /// The default AutoSuggestionService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        internal static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AutoSuggestionService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AutoSuggestionServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="AutoSuggestionServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AutoSuggestionServiceClient"/>.</returns>
        public static stt::Task<AutoSuggestionServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AutoSuggestionServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AutoSuggestionServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="AutoSuggestionServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AutoSuggestionServiceClient"/>.</returns>
        public static AutoSuggestionServiceClient Create() => new AutoSuggestionServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AutoSuggestionServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AutoSuggestionServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AutoSuggestionServiceClient"/>.</returns>
        internal static AutoSuggestionServiceClient Create(grpccore::CallInvoker callInvoker, AutoSuggestionServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AutoSuggestionService.AutoSuggestionServiceClient grpcClient = new AutoSuggestionService.AutoSuggestionServiceClient(callInvoker);
            return new AutoSuggestionServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AutoSuggestionService client</summary>
        public virtual AutoSuggestionService.AutoSuggestionServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a list of suggestions based on a prefix string.
        /// AutoSuggestion tolerance should be less than 1 second.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SuggestQueriesResponse SuggestQueries(SuggestQueriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a list of suggestions based on a prefix string.
        /// AutoSuggestion tolerance should be less than 1 second.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestQueriesResponse> SuggestQueriesAsync(SuggestQueriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a list of suggestions based on a prefix string.
        /// AutoSuggestion tolerance should be less than 1 second.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestQueriesResponse> SuggestQueriesAsync(SuggestQueriesRequest request, st::CancellationToken cancellationToken) =>
            SuggestQueriesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AutoSuggestionService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// This stateless API provides automatic suggestions for natural language
    /// queries for the data sources in the provided project and location.
    /// 
    /// The service provides a resourceless operation `suggestQueries` that can be
    /// called to get a list of suggestions for a given incomplete query and scope
    /// (or list of scopes) under which the query is to be interpreted.
    /// 
    /// There are two types of suggestions, ENTITY for single entity suggestions
    /// and TEMPLATE for full sentences. By default, both types are returned.
    /// 
    /// Example Request:
    /// ```
    /// GetSuggestions({
    /// parent: "locations/us/projects/my-project"
    /// scopes:
    /// "//bigquery.googleapis.com/projects/my-project/datasets/my-dataset/tables/my-table"
    /// query: "top it"
    /// })
    /// ```
    /// 
    /// The service will retrieve information based on the given scope(s) and give
    /// suggestions based on that (e.g. "top item" for "top it" if "item" is a known
    /// dimension for the provided scope).
    /// ```
    /// suggestions {
    /// suggestion_info {
    /// annotated_suggestion {
    /// text_formatted: "top item by sum of usd_revenue_net"
    /// markups {
    /// type: DIMENSION
    /// start_char_index: 4
    /// length: 4
    /// }
    /// markups {
    /// type: METRIC
    /// start_char_index: 19
    /// length: 15
    /// }
    /// }
    /// query_matches {
    /// start_char_index: 0
    /// length: 6
    /// }
    /// }
    /// suggestion_type: TEMPLATE
    /// ranking_score: 0.9
    /// }
    /// suggestions {
    /// suggestion_info {
    /// annotated_suggestion {
    /// text_formatted: "item"
    /// markups {
    /// type: DIMENSION
    /// start_char_index: 4
    /// length: 2
    /// }
    /// }
    /// query_matches {
    /// start_char_index: 0
    /// length: 6
    /// }
    /// }
    /// suggestion_type: ENTITY
    /// ranking_score: 0.8
    /// }
    /// ```
    /// </remarks>
    public sealed partial class AutoSuggestionServiceClientImpl : AutoSuggestionServiceClient
    {
        private readonly gaxgrpc::ApiCall<SuggestQueriesRequest, SuggestQueriesResponse> _callSuggestQueries;

        /// <summary>
        /// Constructs a client wrapper for the AutoSuggestionService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AutoSuggestionServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AutoSuggestionServiceClientImpl(AutoSuggestionService.AutoSuggestionServiceClient grpcClient, AutoSuggestionServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AutoSuggestionServiceSettings effectiveSettings = settings ?? AutoSuggestionServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            _callSuggestQueries = clientHelper.BuildApiCall<SuggestQueriesRequest, SuggestQueriesResponse>("SuggestQueries", grpcClient.SuggestQueriesAsync, grpcClient.SuggestQueries, effectiveSettings.SuggestQueriesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callSuggestQueries);
            Modify_SuggestQueriesApiCall(ref _callSuggestQueries);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_SuggestQueriesApiCall(ref gaxgrpc::ApiCall<SuggestQueriesRequest, SuggestQueriesResponse> call);

        partial void OnConstruction(AutoSuggestionService.AutoSuggestionServiceClient grpcClient, AutoSuggestionServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AutoSuggestionService client</summary>
        public override AutoSuggestionService.AutoSuggestionServiceClient GrpcClient { get; }

        partial void Modify_SuggestQueriesRequest(ref SuggestQueriesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets a list of suggestions based on a prefix string.
        /// AutoSuggestion tolerance should be less than 1 second.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SuggestQueriesResponse SuggestQueries(SuggestQueriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SuggestQueriesRequest(ref request, ref callSettings);
            return _callSuggestQueries.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a list of suggestions based on a prefix string.
        /// AutoSuggestion tolerance should be less than 1 second.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SuggestQueriesResponse> SuggestQueriesAsync(SuggestQueriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SuggestQueriesRequest(ref request, ref callSettings);
            return _callSuggestQueries.Async(request, callSettings);
        }
    }
}
