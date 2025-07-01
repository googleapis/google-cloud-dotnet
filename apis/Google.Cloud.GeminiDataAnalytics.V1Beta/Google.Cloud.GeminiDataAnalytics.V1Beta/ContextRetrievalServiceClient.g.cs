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
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.GeminiDataAnalytics.V1Beta
{
    /// <summary>Settings for <see cref="ContextRetrievalServiceClient"/> instances.</summary>
    public sealed partial class ContextRetrievalServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ContextRetrievalServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ContextRetrievalServiceSettings"/>.</returns>
        public static ContextRetrievalServiceSettings GetDefault() => new ContextRetrievalServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ContextRetrievalServiceSettings"/> object with default settings.
        /// </summary>
        public ContextRetrievalServiceSettings()
        {
        }

        private ContextRetrievalServiceSettings(ContextRetrievalServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            RetrieveBigQueryTableContextSettings = existing.RetrieveBigQueryTableContextSettings;
            RetrieveBigQueryTableContextsSettings = existing.RetrieveBigQueryTableContextsSettings;
            RetrieveBigQueryTableContextsFromRecentTablesSettings = existing.RetrieveBigQueryTableContextsFromRecentTablesSettings;
            RetrieveBigQueryTableSuggestedDescriptionsSettings = existing.RetrieveBigQueryTableSuggestedDescriptionsSettings;
            RetrieveBigQueryTableSuggestedExamplesSettings = existing.RetrieveBigQueryTableSuggestedExamplesSettings;
            RetrieveBigQueryRecentRelevantTablesSettings = existing.RetrieveBigQueryRecentRelevantTablesSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ContextRetrievalServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContextRetrievalServiceClient.RetrieveBigQueryTableContext</c> and
        /// <c>ContextRetrievalServiceClient.RetrieveBigQueryTableContextAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RetrieveBigQueryTableContextSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContextRetrievalServiceClient.RetrieveBigQueryTableContexts</c> and
        /// <c>ContextRetrievalServiceClient.RetrieveBigQueryTableContextsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RetrieveBigQueryTableContextsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContextRetrievalServiceClient.RetrieveBigQueryTableContextsFromRecentTables</c> and
        /// <c>ContextRetrievalServiceClient.RetrieveBigQueryTableContextsFromRecentTablesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RetrieveBigQueryTableContextsFromRecentTablesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContextRetrievalServiceClient.RetrieveBigQueryTableSuggestedDescriptions</c> and
        /// <c>ContextRetrievalServiceClient.RetrieveBigQueryTableSuggestedDescriptionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RetrieveBigQueryTableSuggestedDescriptionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContextRetrievalServiceClient.RetrieveBigQueryTableSuggestedExamples</c> and
        /// <c>ContextRetrievalServiceClient.RetrieveBigQueryTableSuggestedExamplesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RetrieveBigQueryTableSuggestedExamplesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContextRetrievalServiceClient.RetrieveBigQueryRecentRelevantTables</c> and
        /// <c>ContextRetrievalServiceClient.RetrieveBigQueryRecentRelevantTablesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RetrieveBigQueryRecentRelevantTablesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ContextRetrievalServiceSettings"/> object.</returns>
        public ContextRetrievalServiceSettings Clone() => new ContextRetrievalServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ContextRetrievalServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class ContextRetrievalServiceClientBuilder : gaxgrpc::ClientBuilderBase<ContextRetrievalServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ContextRetrievalServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ContextRetrievalServiceClientBuilder() : base(ContextRetrievalServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ContextRetrievalServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ContextRetrievalServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ContextRetrievalServiceClient Build()
        {
            ContextRetrievalServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ContextRetrievalServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ContextRetrievalServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ContextRetrievalServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ContextRetrievalServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ContextRetrievalServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ContextRetrievalServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ContextRetrievalServiceClient.ChannelPool;
    }

    /// <summary>ContextRetrievalService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to ask a natural language question with a provided project,
    /// returns BigQuery tables that are relevant to the question within the project
    /// scope that is accessible to the user, along with contextual data including
    /// table schema information as well as sample values.
    /// </remarks>
    public abstract partial class ContextRetrievalServiceClient
    {
        /// <summary>
        /// The default endpoint for the ContextRetrievalService service, which is a host of
        /// "geminidataanalytics.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "geminidataanalytics.googleapis.com:443";

        /// <summary>The default ContextRetrievalService scopes.</summary>
        /// <remarks>
        /// The default ContextRetrievalService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ContextRetrievalService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ContextRetrievalServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="ContextRetrievalServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ContextRetrievalServiceClient"/>.</returns>
        public static stt::Task<ContextRetrievalServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ContextRetrievalServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ContextRetrievalServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="ContextRetrievalServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ContextRetrievalServiceClient"/>.</returns>
        public static ContextRetrievalServiceClient Create() => new ContextRetrievalServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ContextRetrievalServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ContextRetrievalServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ContextRetrievalServiceClient"/>.</returns>
        internal static ContextRetrievalServiceClient Create(grpccore::CallInvoker callInvoker, ContextRetrievalServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ContextRetrievalService.ContextRetrievalServiceClient grpcClient = new ContextRetrievalService.ContextRetrievalServiceClient(callInvoker);
            return new ContextRetrievalServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ContextRetrievalService client</summary>
        public virtual ContextRetrievalService.ContextRetrievalServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves BigQuery table contextual data for provided table references.
        /// Contextual data includes table schema information as well as sample
        /// values.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RetrieveBigQueryTableContextResponse RetrieveBigQueryTableContext(RetrieveBigQueryTableContextRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves BigQuery table contextual data for provided table references.
        /// Contextual data includes table schema information as well as sample
        /// values.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RetrieveBigQueryTableContextResponse> RetrieveBigQueryTableContextAsync(RetrieveBigQueryTableContextRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves BigQuery table contextual data for provided table references.
        /// Contextual data includes table schema information as well as sample
        /// values.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RetrieveBigQueryTableContextResponse> RetrieveBigQueryTableContextAsync(RetrieveBigQueryTableContextRequest request, st::CancellationToken cancellationToken) =>
            RetrieveBigQueryTableContextAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves BigQuery table contextual data for provided table references.
        /// Contextual data includes table schema information as well as sample
        /// values.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RetrieveBigQueryTableContextsResponse RetrieveBigQueryTableContexts(RetrieveBigQueryTableContextsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves BigQuery table contextual data for provided table references.
        /// Contextual data includes table schema information as well as sample
        /// values.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RetrieveBigQueryTableContextsResponse> RetrieveBigQueryTableContextsAsync(RetrieveBigQueryTableContextsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves BigQuery table contextual data for provided table references.
        /// Contextual data includes table schema information as well as sample
        /// values.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RetrieveBigQueryTableContextsResponse> RetrieveBigQueryTableContextsAsync(RetrieveBigQueryTableContextsRequest request, st::CancellationToken cancellationToken) =>
            RetrieveBigQueryTableContextsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves BigQuery table contextual data from recently accessed tables.
        /// Contextual data includes table schema information as well as sample
        /// values.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RetrieveBigQueryTableContextsFromRecentTablesResponse RetrieveBigQueryTableContextsFromRecentTables(RetrieveBigQueryTableContextsFromRecentTablesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves BigQuery table contextual data from recently accessed tables.
        /// Contextual data includes table schema information as well as sample
        /// values.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RetrieveBigQueryTableContextsFromRecentTablesResponse> RetrieveBigQueryTableContextsFromRecentTablesAsync(RetrieveBigQueryTableContextsFromRecentTablesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves BigQuery table contextual data from recently accessed tables.
        /// Contextual data includes table schema information as well as sample
        /// values.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RetrieveBigQueryTableContextsFromRecentTablesResponse> RetrieveBigQueryTableContextsFromRecentTablesAsync(RetrieveBigQueryTableContextsFromRecentTablesRequest request, st::CancellationToken cancellationToken) =>
            RetrieveBigQueryTableContextsFromRecentTablesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves BigQuery table schema with suggested table and column
        /// descriptions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RetrieveBigQueryTableSuggestedDescriptionsResponse RetrieveBigQueryTableSuggestedDescriptions(RetrieveBigQueryTableSuggestedDescriptionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves BigQuery table schema with suggested table and column
        /// descriptions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RetrieveBigQueryTableSuggestedDescriptionsResponse> RetrieveBigQueryTableSuggestedDescriptionsAsync(RetrieveBigQueryTableSuggestedDescriptionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves BigQuery table schema with suggested table and column
        /// descriptions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RetrieveBigQueryTableSuggestedDescriptionsResponse> RetrieveBigQueryTableSuggestedDescriptionsAsync(RetrieveBigQueryTableSuggestedDescriptionsRequest request, st::CancellationToken cancellationToken) =>
            RetrieveBigQueryTableSuggestedDescriptionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves BigQuery table schema with suggested NL-SQL examples.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RetrieveBigQueryTableSuggestedExamplesResponse RetrieveBigQueryTableSuggestedExamples(RetrieveBigQueryTableSuggestedExamplesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves BigQuery table schema with suggested NL-SQL examples.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RetrieveBigQueryTableSuggestedExamplesResponse> RetrieveBigQueryTableSuggestedExamplesAsync(RetrieveBigQueryTableSuggestedExamplesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves BigQuery table schema with suggested NL-SQL examples.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RetrieveBigQueryTableSuggestedExamplesResponse> RetrieveBigQueryTableSuggestedExamplesAsync(RetrieveBigQueryTableSuggestedExamplesRequest request, st::CancellationToken cancellationToken) =>
            RetrieveBigQueryTableSuggestedExamplesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves BigQuery table references from recently accessed tables.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RetrieveBigQueryRecentRelevantTablesResponse RetrieveBigQueryRecentRelevantTables(RetrieveBigQueryRecentRelevantTablesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves BigQuery table references from recently accessed tables.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RetrieveBigQueryRecentRelevantTablesResponse> RetrieveBigQueryRecentRelevantTablesAsync(RetrieveBigQueryRecentRelevantTablesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves BigQuery table references from recently accessed tables.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RetrieveBigQueryRecentRelevantTablesResponse> RetrieveBigQueryRecentRelevantTablesAsync(RetrieveBigQueryRecentRelevantTablesRequest request, st::CancellationToken cancellationToken) =>
            RetrieveBigQueryRecentRelevantTablesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ContextRetrievalService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to ask a natural language question with a provided project,
    /// returns BigQuery tables that are relevant to the question within the project
    /// scope that is accessible to the user, along with contextual data including
    /// table schema information as well as sample values.
    /// </remarks>
    public sealed partial class ContextRetrievalServiceClientImpl : ContextRetrievalServiceClient
    {
        private readonly gaxgrpc::ApiCall<RetrieveBigQueryTableContextRequest, RetrieveBigQueryTableContextResponse> _callRetrieveBigQueryTableContext;

        private readonly gaxgrpc::ApiCall<RetrieveBigQueryTableContextsRequest, RetrieveBigQueryTableContextsResponse> _callRetrieveBigQueryTableContexts;

        private readonly gaxgrpc::ApiCall<RetrieveBigQueryTableContextsFromRecentTablesRequest, RetrieveBigQueryTableContextsFromRecentTablesResponse> _callRetrieveBigQueryTableContextsFromRecentTables;

        private readonly gaxgrpc::ApiCall<RetrieveBigQueryTableSuggestedDescriptionsRequest, RetrieveBigQueryTableSuggestedDescriptionsResponse> _callRetrieveBigQueryTableSuggestedDescriptions;

        private readonly gaxgrpc::ApiCall<RetrieveBigQueryTableSuggestedExamplesRequest, RetrieveBigQueryTableSuggestedExamplesResponse> _callRetrieveBigQueryTableSuggestedExamples;

        private readonly gaxgrpc::ApiCall<RetrieveBigQueryRecentRelevantTablesRequest, RetrieveBigQueryRecentRelevantTablesResponse> _callRetrieveBigQueryRecentRelevantTables;

        /// <summary>
        /// Constructs a client wrapper for the ContextRetrievalService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="ContextRetrievalServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ContextRetrievalServiceClientImpl(ContextRetrievalService.ContextRetrievalServiceClient grpcClient, ContextRetrievalServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ContextRetrievalServiceSettings effectiveSettings = settings ?? ContextRetrievalServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callRetrieveBigQueryTableContext = clientHelper.BuildApiCall<RetrieveBigQueryTableContextRequest, RetrieveBigQueryTableContextResponse>("RetrieveBigQueryTableContext", grpcClient.RetrieveBigQueryTableContextAsync, grpcClient.RetrieveBigQueryTableContext, effectiveSettings.RetrieveBigQueryTableContextSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callRetrieveBigQueryTableContext);
            Modify_RetrieveBigQueryTableContextApiCall(ref _callRetrieveBigQueryTableContext);
            _callRetrieveBigQueryTableContexts = clientHelper.BuildApiCall<RetrieveBigQueryTableContextsRequest, RetrieveBigQueryTableContextsResponse>("RetrieveBigQueryTableContexts", grpcClient.RetrieveBigQueryTableContextsAsync, grpcClient.RetrieveBigQueryTableContexts, effectiveSettings.RetrieveBigQueryTableContextsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callRetrieveBigQueryTableContexts);
            Modify_RetrieveBigQueryTableContextsApiCall(ref _callRetrieveBigQueryTableContexts);
            _callRetrieveBigQueryTableContextsFromRecentTables = clientHelper.BuildApiCall<RetrieveBigQueryTableContextsFromRecentTablesRequest, RetrieveBigQueryTableContextsFromRecentTablesResponse>("RetrieveBigQueryTableContextsFromRecentTables", grpcClient.RetrieveBigQueryTableContextsFromRecentTablesAsync, grpcClient.RetrieveBigQueryTableContextsFromRecentTables, effectiveSettings.RetrieveBigQueryTableContextsFromRecentTablesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callRetrieveBigQueryTableContextsFromRecentTables);
            Modify_RetrieveBigQueryTableContextsFromRecentTablesApiCall(ref _callRetrieveBigQueryTableContextsFromRecentTables);
            _callRetrieveBigQueryTableSuggestedDescriptions = clientHelper.BuildApiCall<RetrieveBigQueryTableSuggestedDescriptionsRequest, RetrieveBigQueryTableSuggestedDescriptionsResponse>("RetrieveBigQueryTableSuggestedDescriptions", grpcClient.RetrieveBigQueryTableSuggestedDescriptionsAsync, grpcClient.RetrieveBigQueryTableSuggestedDescriptions, effectiveSettings.RetrieveBigQueryTableSuggestedDescriptionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callRetrieveBigQueryTableSuggestedDescriptions);
            Modify_RetrieveBigQueryTableSuggestedDescriptionsApiCall(ref _callRetrieveBigQueryTableSuggestedDescriptions);
            _callRetrieveBigQueryTableSuggestedExamples = clientHelper.BuildApiCall<RetrieveBigQueryTableSuggestedExamplesRequest, RetrieveBigQueryTableSuggestedExamplesResponse>("RetrieveBigQueryTableSuggestedExamples", grpcClient.RetrieveBigQueryTableSuggestedExamplesAsync, grpcClient.RetrieveBigQueryTableSuggestedExamples, effectiveSettings.RetrieveBigQueryTableSuggestedExamplesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callRetrieveBigQueryTableSuggestedExamples);
            Modify_RetrieveBigQueryTableSuggestedExamplesApiCall(ref _callRetrieveBigQueryTableSuggestedExamples);
            _callRetrieveBigQueryRecentRelevantTables = clientHelper.BuildApiCall<RetrieveBigQueryRecentRelevantTablesRequest, RetrieveBigQueryRecentRelevantTablesResponse>("RetrieveBigQueryRecentRelevantTables", grpcClient.RetrieveBigQueryRecentRelevantTablesAsync, grpcClient.RetrieveBigQueryRecentRelevantTables, effectiveSettings.RetrieveBigQueryRecentRelevantTablesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callRetrieveBigQueryRecentRelevantTables);
            Modify_RetrieveBigQueryRecentRelevantTablesApiCall(ref _callRetrieveBigQueryRecentRelevantTables);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_RetrieveBigQueryTableContextApiCall(ref gaxgrpc::ApiCall<RetrieveBigQueryTableContextRequest, RetrieveBigQueryTableContextResponse> call);

        partial void Modify_RetrieveBigQueryTableContextsApiCall(ref gaxgrpc::ApiCall<RetrieveBigQueryTableContextsRequest, RetrieveBigQueryTableContextsResponse> call);

        partial void Modify_RetrieveBigQueryTableContextsFromRecentTablesApiCall(ref gaxgrpc::ApiCall<RetrieveBigQueryTableContextsFromRecentTablesRequest, RetrieveBigQueryTableContextsFromRecentTablesResponse> call);

        partial void Modify_RetrieveBigQueryTableSuggestedDescriptionsApiCall(ref gaxgrpc::ApiCall<RetrieveBigQueryTableSuggestedDescriptionsRequest, RetrieveBigQueryTableSuggestedDescriptionsResponse> call);

        partial void Modify_RetrieveBigQueryTableSuggestedExamplesApiCall(ref gaxgrpc::ApiCall<RetrieveBigQueryTableSuggestedExamplesRequest, RetrieveBigQueryTableSuggestedExamplesResponse> call);

        partial void Modify_RetrieveBigQueryRecentRelevantTablesApiCall(ref gaxgrpc::ApiCall<RetrieveBigQueryRecentRelevantTablesRequest, RetrieveBigQueryRecentRelevantTablesResponse> call);

        partial void OnConstruction(ContextRetrievalService.ContextRetrievalServiceClient grpcClient, ContextRetrievalServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ContextRetrievalService client</summary>
        public override ContextRetrievalService.ContextRetrievalServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_RetrieveBigQueryTableContextRequest(ref RetrieveBigQueryTableContextRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RetrieveBigQueryTableContextsRequest(ref RetrieveBigQueryTableContextsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RetrieveBigQueryTableContextsFromRecentTablesRequest(ref RetrieveBigQueryTableContextsFromRecentTablesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RetrieveBigQueryTableSuggestedDescriptionsRequest(ref RetrieveBigQueryTableSuggestedDescriptionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RetrieveBigQueryTableSuggestedExamplesRequest(ref RetrieveBigQueryTableSuggestedExamplesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RetrieveBigQueryRecentRelevantTablesRequest(ref RetrieveBigQueryRecentRelevantTablesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves BigQuery table contextual data for provided table references.
        /// Contextual data includes table schema information as well as sample
        /// values.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RetrieveBigQueryTableContextResponse RetrieveBigQueryTableContext(RetrieveBigQueryTableContextRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RetrieveBigQueryTableContextRequest(ref request, ref callSettings);
            return _callRetrieveBigQueryTableContext.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves BigQuery table contextual data for provided table references.
        /// Contextual data includes table schema information as well as sample
        /// values.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RetrieveBigQueryTableContextResponse> RetrieveBigQueryTableContextAsync(RetrieveBigQueryTableContextRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RetrieveBigQueryTableContextRequest(ref request, ref callSettings);
            return _callRetrieveBigQueryTableContext.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves BigQuery table contextual data for provided table references.
        /// Contextual data includes table schema information as well as sample
        /// values.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RetrieveBigQueryTableContextsResponse RetrieveBigQueryTableContexts(RetrieveBigQueryTableContextsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RetrieveBigQueryTableContextsRequest(ref request, ref callSettings);
            return _callRetrieveBigQueryTableContexts.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves BigQuery table contextual data for provided table references.
        /// Contextual data includes table schema information as well as sample
        /// values.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RetrieveBigQueryTableContextsResponse> RetrieveBigQueryTableContextsAsync(RetrieveBigQueryTableContextsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RetrieveBigQueryTableContextsRequest(ref request, ref callSettings);
            return _callRetrieveBigQueryTableContexts.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves BigQuery table contextual data from recently accessed tables.
        /// Contextual data includes table schema information as well as sample
        /// values.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RetrieveBigQueryTableContextsFromRecentTablesResponse RetrieveBigQueryTableContextsFromRecentTables(RetrieveBigQueryTableContextsFromRecentTablesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RetrieveBigQueryTableContextsFromRecentTablesRequest(ref request, ref callSettings);
            return _callRetrieveBigQueryTableContextsFromRecentTables.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves BigQuery table contextual data from recently accessed tables.
        /// Contextual data includes table schema information as well as sample
        /// values.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RetrieveBigQueryTableContextsFromRecentTablesResponse> RetrieveBigQueryTableContextsFromRecentTablesAsync(RetrieveBigQueryTableContextsFromRecentTablesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RetrieveBigQueryTableContextsFromRecentTablesRequest(ref request, ref callSettings);
            return _callRetrieveBigQueryTableContextsFromRecentTables.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves BigQuery table schema with suggested table and column
        /// descriptions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RetrieveBigQueryTableSuggestedDescriptionsResponse RetrieveBigQueryTableSuggestedDescriptions(RetrieveBigQueryTableSuggestedDescriptionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RetrieveBigQueryTableSuggestedDescriptionsRequest(ref request, ref callSettings);
            return _callRetrieveBigQueryTableSuggestedDescriptions.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves BigQuery table schema with suggested table and column
        /// descriptions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RetrieveBigQueryTableSuggestedDescriptionsResponse> RetrieveBigQueryTableSuggestedDescriptionsAsync(RetrieveBigQueryTableSuggestedDescriptionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RetrieveBigQueryTableSuggestedDescriptionsRequest(ref request, ref callSettings);
            return _callRetrieveBigQueryTableSuggestedDescriptions.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves BigQuery table schema with suggested NL-SQL examples.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RetrieveBigQueryTableSuggestedExamplesResponse RetrieveBigQueryTableSuggestedExamples(RetrieveBigQueryTableSuggestedExamplesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RetrieveBigQueryTableSuggestedExamplesRequest(ref request, ref callSettings);
            return _callRetrieveBigQueryTableSuggestedExamples.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves BigQuery table schema with suggested NL-SQL examples.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RetrieveBigQueryTableSuggestedExamplesResponse> RetrieveBigQueryTableSuggestedExamplesAsync(RetrieveBigQueryTableSuggestedExamplesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RetrieveBigQueryTableSuggestedExamplesRequest(ref request, ref callSettings);
            return _callRetrieveBigQueryTableSuggestedExamples.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves BigQuery table references from recently accessed tables.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RetrieveBigQueryRecentRelevantTablesResponse RetrieveBigQueryRecentRelevantTables(RetrieveBigQueryRecentRelevantTablesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RetrieveBigQueryRecentRelevantTablesRequest(ref request, ref callSettings);
            return _callRetrieveBigQueryRecentRelevantTables.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves BigQuery table references from recently accessed tables.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RetrieveBigQueryRecentRelevantTablesResponse> RetrieveBigQueryRecentRelevantTablesAsync(RetrieveBigQueryRecentRelevantTablesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RetrieveBigQueryRecentRelevantTablesRequest(ref request, ref callSettings);
            return _callRetrieveBigQueryRecentRelevantTables.Async(request, callSettings);
        }
    }

    public static partial class ContextRetrievalService
    {
        public partial class ContextRetrievalServiceClient
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
