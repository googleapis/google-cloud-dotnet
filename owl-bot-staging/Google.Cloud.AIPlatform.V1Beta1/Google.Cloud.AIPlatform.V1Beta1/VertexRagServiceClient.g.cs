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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gciv = Google.Cloud.Iam.V1;
using gcl = Google.Cloud.Location;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using linq = System.Linq;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.AIPlatform.V1Beta1
{
    /// <summary>Settings for <see cref="VertexRagServiceClient"/> instances.</summary>
    public sealed partial class VertexRagServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="VertexRagServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="VertexRagServiceSettings"/>.</returns>
        public static VertexRagServiceSettings GetDefault() => new VertexRagServiceSettings();

        /// <summary>Constructs a new <see cref="VertexRagServiceSettings"/> object with default settings.</summary>
        public VertexRagServiceSettings()
        {
        }

        private VertexRagServiceSettings(VertexRagServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            RetrieveContextsSettings = existing.RetrieveContextsSettings;
            AugmentPromptSettings = existing.AugmentPromptSettings;
            CorroborateContentSettings = existing.CorroborateContentSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(VertexRagServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VertexRagServiceClient.RetrieveContexts</c> and <c>VertexRagServiceClient.RetrieveContextsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RetrieveContextsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VertexRagServiceClient.AugmentPrompt</c> and <c>VertexRagServiceClient.AugmentPromptAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AugmentPromptSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VertexRagServiceClient.CorroborateContent</c> and <c>VertexRagServiceClient.CorroborateContentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CorroborateContentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="VertexRagServiceSettings"/> object.</returns>
        public VertexRagServiceSettings Clone() => new VertexRagServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="VertexRagServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class VertexRagServiceClientBuilder : gaxgrpc::ClientBuilderBase<VertexRagServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public VertexRagServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public VertexRagServiceClientBuilder() : base(VertexRagServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref VertexRagServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<VertexRagServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override VertexRagServiceClient Build()
        {
            VertexRagServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<VertexRagServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<VertexRagServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private VertexRagServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return VertexRagServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<VertexRagServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return VertexRagServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => VertexRagServiceClient.ChannelPool;
    }

    /// <summary>VertexRagService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service for retrieving relevant contexts.
    /// </remarks>
    public abstract partial class VertexRagServiceClient
    {
        /// <summary>
        /// The default endpoint for the VertexRagService service, which is a host of "aiplatform.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "aiplatform.googleapis.com:443";

        /// <summary>The default VertexRagService scopes.</summary>
        /// <remarks>
        /// The default VertexRagService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(VertexRagService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="VertexRagServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="VertexRagServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="VertexRagServiceClient"/>.</returns>
        public static stt::Task<VertexRagServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new VertexRagServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="VertexRagServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="VertexRagServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="VertexRagServiceClient"/>.</returns>
        public static VertexRagServiceClient Create() => new VertexRagServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="VertexRagServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="VertexRagServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="VertexRagServiceClient"/>.</returns>
        internal static VertexRagServiceClient Create(grpccore::CallInvoker callInvoker, VertexRagServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            VertexRagService.VertexRagServiceClient grpcClient = new VertexRagService.VertexRagServiceClient(callInvoker);
            return new VertexRagServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC VertexRagService client</summary>
        public virtual VertexRagService.VertexRagServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves relevant contexts for a query.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RetrieveContextsResponse RetrieveContexts(RetrieveContextsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves relevant contexts for a query.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RetrieveContextsResponse> RetrieveContextsAsync(RetrieveContextsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves relevant contexts for a query.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RetrieveContextsResponse> RetrieveContextsAsync(RetrieveContextsRequest request, st::CancellationToken cancellationToken) =>
            RetrieveContextsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves relevant contexts for a query.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location from which to retrieve
        /// RagContexts. The users must have permission to make a call in the project.
        /// Format:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="query">
        /// Required. Single RAG retrieve query.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RetrieveContextsResponse RetrieveContexts(string parent, RagQuery query, gaxgrpc::CallSettings callSettings = null) =>
            RetrieveContexts(new RetrieveContextsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Query = gax::GaxPreconditions.CheckNotNull(query, nameof(query)),
            }, callSettings);

        /// <summary>
        /// Retrieves relevant contexts for a query.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location from which to retrieve
        /// RagContexts. The users must have permission to make a call in the project.
        /// Format:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="query">
        /// Required. Single RAG retrieve query.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RetrieveContextsResponse> RetrieveContextsAsync(string parent, RagQuery query, gaxgrpc::CallSettings callSettings = null) =>
            RetrieveContextsAsync(new RetrieveContextsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Query = gax::GaxPreconditions.CheckNotNull(query, nameof(query)),
            }, callSettings);

        /// <summary>
        /// Retrieves relevant contexts for a query.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location from which to retrieve
        /// RagContexts. The users must have permission to make a call in the project.
        /// Format:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="query">
        /// Required. Single RAG retrieve query.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RetrieveContextsResponse> RetrieveContextsAsync(string parent, RagQuery query, st::CancellationToken cancellationToken) =>
            RetrieveContextsAsync(parent, query, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves relevant contexts for a query.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location from which to retrieve
        /// RagContexts. The users must have permission to make a call in the project.
        /// Format:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="query">
        /// Required. Single RAG retrieve query.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RetrieveContextsResponse RetrieveContexts(gagr::LocationName parent, RagQuery query, gaxgrpc::CallSettings callSettings = null) =>
            RetrieveContexts(new RetrieveContextsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Query = gax::GaxPreconditions.CheckNotNull(query, nameof(query)),
            }, callSettings);

        /// <summary>
        /// Retrieves relevant contexts for a query.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location from which to retrieve
        /// RagContexts. The users must have permission to make a call in the project.
        /// Format:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="query">
        /// Required. Single RAG retrieve query.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RetrieveContextsResponse> RetrieveContextsAsync(gagr::LocationName parent, RagQuery query, gaxgrpc::CallSettings callSettings = null) =>
            RetrieveContextsAsync(new RetrieveContextsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Query = gax::GaxPreconditions.CheckNotNull(query, nameof(query)),
            }, callSettings);

        /// <summary>
        /// Retrieves relevant contexts for a query.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location from which to retrieve
        /// RagContexts. The users must have permission to make a call in the project.
        /// Format:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="query">
        /// Required. Single RAG retrieve query.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RetrieveContextsResponse> RetrieveContextsAsync(gagr::LocationName parent, RagQuery query, st::CancellationToken cancellationToken) =>
            RetrieveContextsAsync(parent, query, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Given an input prompt, it returns augmented prompt from vertex rag store
        /// to guide LLM towards generating grounded responses.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AugmentPromptResponse AugmentPrompt(AugmentPromptRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Given an input prompt, it returns augmented prompt from vertex rag store
        /// to guide LLM towards generating grounded responses.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AugmentPromptResponse> AugmentPromptAsync(AugmentPromptRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Given an input prompt, it returns augmented prompt from vertex rag store
        /// to guide LLM towards generating grounded responses.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AugmentPromptResponse> AugmentPromptAsync(AugmentPromptRequest request, st::CancellationToken cancellationToken) =>
            AugmentPromptAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Given an input prompt, it returns augmented prompt from vertex rag store
        /// to guide LLM towards generating grounded responses.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location from which to augment prompt.
        /// The users must have permission to make a call in the project.
        /// Format:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="model">
        /// Optional. Metadata of the backend deployed model.
        /// </param>
        /// <param name="vertexRagStore">
        /// Optional. Retrieves contexts from the Vertex RagStore.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AugmentPromptResponse AugmentPrompt(string parent, AugmentPromptRequest.Types.Model model, VertexRagStore vertexRagStore, gaxgrpc::CallSettings callSettings = null) =>
            AugmentPrompt(new AugmentPromptRequest
            {
                VertexRagStore = vertexRagStore,
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Model = model,
            }, callSettings);

        /// <summary>
        /// Given an input prompt, it returns augmented prompt from vertex rag store
        /// to guide LLM towards generating grounded responses.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location from which to augment prompt.
        /// The users must have permission to make a call in the project.
        /// Format:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="model">
        /// Optional. Metadata of the backend deployed model.
        /// </param>
        /// <param name="vertexRagStore">
        /// Optional. Retrieves contexts from the Vertex RagStore.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AugmentPromptResponse> AugmentPromptAsync(string parent, AugmentPromptRequest.Types.Model model, VertexRagStore vertexRagStore, gaxgrpc::CallSettings callSettings = null) =>
            AugmentPromptAsync(new AugmentPromptRequest
            {
                VertexRagStore = vertexRagStore,
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Model = model,
            }, callSettings);

        /// <summary>
        /// Given an input prompt, it returns augmented prompt from vertex rag store
        /// to guide LLM towards generating grounded responses.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location from which to augment prompt.
        /// The users must have permission to make a call in the project.
        /// Format:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="model">
        /// Optional. Metadata of the backend deployed model.
        /// </param>
        /// <param name="vertexRagStore">
        /// Optional. Retrieves contexts from the Vertex RagStore.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AugmentPromptResponse> AugmentPromptAsync(string parent, AugmentPromptRequest.Types.Model model, VertexRagStore vertexRagStore, st::CancellationToken cancellationToken) =>
            AugmentPromptAsync(parent, model, vertexRagStore, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Given an input prompt, it returns augmented prompt from vertex rag store
        /// to guide LLM towards generating grounded responses.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location from which to augment prompt.
        /// The users must have permission to make a call in the project.
        /// Format:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="model">
        /// Optional. Metadata of the backend deployed model.
        /// </param>
        /// <param name="vertexRagStore">
        /// Optional. Retrieves contexts from the Vertex RagStore.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AugmentPromptResponse AugmentPrompt(gagr::LocationName parent, AugmentPromptRequest.Types.Model model, VertexRagStore vertexRagStore, gaxgrpc::CallSettings callSettings = null) =>
            AugmentPrompt(new AugmentPromptRequest
            {
                VertexRagStore = vertexRagStore,
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Model = model,
            }, callSettings);

        /// <summary>
        /// Given an input prompt, it returns augmented prompt from vertex rag store
        /// to guide LLM towards generating grounded responses.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location from which to augment prompt.
        /// The users must have permission to make a call in the project.
        /// Format:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="model">
        /// Optional. Metadata of the backend deployed model.
        /// </param>
        /// <param name="vertexRagStore">
        /// Optional. Retrieves contexts from the Vertex RagStore.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AugmentPromptResponse> AugmentPromptAsync(gagr::LocationName parent, AugmentPromptRequest.Types.Model model, VertexRagStore vertexRagStore, gaxgrpc::CallSettings callSettings = null) =>
            AugmentPromptAsync(new AugmentPromptRequest
            {
                VertexRagStore = vertexRagStore,
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Model = model,
            }, callSettings);

        /// <summary>
        /// Given an input prompt, it returns augmented prompt from vertex rag store
        /// to guide LLM towards generating grounded responses.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location from which to augment prompt.
        /// The users must have permission to make a call in the project.
        /// Format:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="model">
        /// Optional. Metadata of the backend deployed model.
        /// </param>
        /// <param name="vertexRagStore">
        /// Optional. Retrieves contexts from the Vertex RagStore.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AugmentPromptResponse> AugmentPromptAsync(gagr::LocationName parent, AugmentPromptRequest.Types.Model model, VertexRagStore vertexRagStore, st::CancellationToken cancellationToken) =>
            AugmentPromptAsync(parent, model, vertexRagStore, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Given an input text, it returns a score that evaluates the factuality of
        /// the text. It also extracts and returns claims from the text and provides
        /// supporting facts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CorroborateContentResponse CorroborateContent(CorroborateContentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Given an input text, it returns a score that evaluates the factuality of
        /// the text. It also extracts and returns claims from the text and provides
        /// supporting facts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CorroborateContentResponse> CorroborateContentAsync(CorroborateContentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Given an input text, it returns a score that evaluates the factuality of
        /// the text. It also extracts and returns claims from the text and provides
        /// supporting facts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CorroborateContentResponse> CorroborateContentAsync(CorroborateContentRequest request, st::CancellationToken cancellationToken) =>
            CorroborateContentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Given an input text, it returns a score that evaluates the factuality of
        /// the text. It also extracts and returns claims from the text and provides
        /// supporting facts.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location from which to corroborate text.
        /// The users must have permission to make a call in the project.
        /// Format:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="content">
        /// Optional. Input content to corroborate, only text format is supported for
        /// now.
        /// </param>
        /// <param name="facts">
        /// Optional. Facts used to generate the text can also be used to corroborate
        /// the text.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CorroborateContentResponse CorroborateContent(string parent, Content content, scg::IEnumerable<Fact> facts, gaxgrpc::CallSettings callSettings = null) =>
            CorroborateContent(new CorroborateContentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Content = content,
                Facts =
                {
                    facts ?? linq::Enumerable.Empty<Fact>(),
                },
            }, callSettings);

        /// <summary>
        /// Given an input text, it returns a score that evaluates the factuality of
        /// the text. It also extracts and returns claims from the text and provides
        /// supporting facts.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location from which to corroborate text.
        /// The users must have permission to make a call in the project.
        /// Format:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="content">
        /// Optional. Input content to corroborate, only text format is supported for
        /// now.
        /// </param>
        /// <param name="facts">
        /// Optional. Facts used to generate the text can also be used to corroborate
        /// the text.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CorroborateContentResponse> CorroborateContentAsync(string parent, Content content, scg::IEnumerable<Fact> facts, gaxgrpc::CallSettings callSettings = null) =>
            CorroborateContentAsync(new CorroborateContentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Content = content,
                Facts =
                {
                    facts ?? linq::Enumerable.Empty<Fact>(),
                },
            }, callSettings);

        /// <summary>
        /// Given an input text, it returns a score that evaluates the factuality of
        /// the text. It also extracts and returns claims from the text and provides
        /// supporting facts.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location from which to corroborate text.
        /// The users must have permission to make a call in the project.
        /// Format:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="content">
        /// Optional. Input content to corroborate, only text format is supported for
        /// now.
        /// </param>
        /// <param name="facts">
        /// Optional. Facts used to generate the text can also be used to corroborate
        /// the text.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CorroborateContentResponse> CorroborateContentAsync(string parent, Content content, scg::IEnumerable<Fact> facts, st::CancellationToken cancellationToken) =>
            CorroborateContentAsync(parent, content, facts, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Given an input text, it returns a score that evaluates the factuality of
        /// the text. It also extracts and returns claims from the text and provides
        /// supporting facts.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location from which to corroborate text.
        /// The users must have permission to make a call in the project.
        /// Format:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="content">
        /// Optional. Input content to corroborate, only text format is supported for
        /// now.
        /// </param>
        /// <param name="facts">
        /// Optional. Facts used to generate the text can also be used to corroborate
        /// the text.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CorroborateContentResponse CorroborateContent(gagr::LocationName parent, Content content, scg::IEnumerable<Fact> facts, gaxgrpc::CallSettings callSettings = null) =>
            CorroborateContent(new CorroborateContentRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Content = content,
                Facts =
                {
                    facts ?? linq::Enumerable.Empty<Fact>(),
                },
            }, callSettings);

        /// <summary>
        /// Given an input text, it returns a score that evaluates the factuality of
        /// the text. It also extracts and returns claims from the text and provides
        /// supporting facts.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location from which to corroborate text.
        /// The users must have permission to make a call in the project.
        /// Format:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="content">
        /// Optional. Input content to corroborate, only text format is supported for
        /// now.
        /// </param>
        /// <param name="facts">
        /// Optional. Facts used to generate the text can also be used to corroborate
        /// the text.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CorroborateContentResponse> CorroborateContentAsync(gagr::LocationName parent, Content content, scg::IEnumerable<Fact> facts, gaxgrpc::CallSettings callSettings = null) =>
            CorroborateContentAsync(new CorroborateContentRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Content = content,
                Facts =
                {
                    facts ?? linq::Enumerable.Empty<Fact>(),
                },
            }, callSettings);

        /// <summary>
        /// Given an input text, it returns a score that evaluates the factuality of
        /// the text. It also extracts and returns claims from the text and provides
        /// supporting facts.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location from which to corroborate text.
        /// The users must have permission to make a call in the project.
        /// Format:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="content">
        /// Optional. Input content to corroborate, only text format is supported for
        /// now.
        /// </param>
        /// <param name="facts">
        /// Optional. Facts used to generate the text can also be used to corroborate
        /// the text.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CorroborateContentResponse> CorroborateContentAsync(gagr::LocationName parent, Content content, scg::IEnumerable<Fact> facts, st::CancellationToken cancellationToken) =>
            CorroborateContentAsync(parent, content, facts, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>VertexRagService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service for retrieving relevant contexts.
    /// </remarks>
    public sealed partial class VertexRagServiceClientImpl : VertexRagServiceClient
    {
        private readonly gaxgrpc::ApiCall<RetrieveContextsRequest, RetrieveContextsResponse> _callRetrieveContexts;

        private readonly gaxgrpc::ApiCall<AugmentPromptRequest, AugmentPromptResponse> _callAugmentPrompt;

        private readonly gaxgrpc::ApiCall<CorroborateContentRequest, CorroborateContentResponse> _callCorroborateContent;

        /// <summary>
        /// Constructs a client wrapper for the VertexRagService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="VertexRagServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public VertexRagServiceClientImpl(VertexRagService.VertexRagServiceClient grpcClient, VertexRagServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            VertexRagServiceSettings effectiveSettings = settings ?? VertexRagServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callRetrieveContexts = clientHelper.BuildApiCall<RetrieveContextsRequest, RetrieveContextsResponse>("RetrieveContexts", grpcClient.RetrieveContextsAsync, grpcClient.RetrieveContexts, effectiveSettings.RetrieveContextsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callRetrieveContexts);
            Modify_RetrieveContextsApiCall(ref _callRetrieveContexts);
            _callAugmentPrompt = clientHelper.BuildApiCall<AugmentPromptRequest, AugmentPromptResponse>("AugmentPrompt", grpcClient.AugmentPromptAsync, grpcClient.AugmentPrompt, effectiveSettings.AugmentPromptSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callAugmentPrompt);
            Modify_AugmentPromptApiCall(ref _callAugmentPrompt);
            _callCorroborateContent = clientHelper.BuildApiCall<CorroborateContentRequest, CorroborateContentResponse>("CorroborateContent", grpcClient.CorroborateContentAsync, grpcClient.CorroborateContent, effectiveSettings.CorroborateContentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCorroborateContent);
            Modify_CorroborateContentApiCall(ref _callCorroborateContent);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_RetrieveContextsApiCall(ref gaxgrpc::ApiCall<RetrieveContextsRequest, RetrieveContextsResponse> call);

        partial void Modify_AugmentPromptApiCall(ref gaxgrpc::ApiCall<AugmentPromptRequest, AugmentPromptResponse> call);

        partial void Modify_CorroborateContentApiCall(ref gaxgrpc::ApiCall<CorroborateContentRequest, CorroborateContentResponse> call);

        partial void OnConstruction(VertexRagService.VertexRagServiceClient grpcClient, VertexRagServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC VertexRagService client</summary>
        public override VertexRagService.VertexRagServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_RetrieveContextsRequest(ref RetrieveContextsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AugmentPromptRequest(ref AugmentPromptRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CorroborateContentRequest(ref CorroborateContentRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves relevant contexts for a query.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RetrieveContextsResponse RetrieveContexts(RetrieveContextsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RetrieveContextsRequest(ref request, ref callSettings);
            return _callRetrieveContexts.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves relevant contexts for a query.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RetrieveContextsResponse> RetrieveContextsAsync(RetrieveContextsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RetrieveContextsRequest(ref request, ref callSettings);
            return _callRetrieveContexts.Async(request, callSettings);
        }

        /// <summary>
        /// Given an input prompt, it returns augmented prompt from vertex rag store
        /// to guide LLM towards generating grounded responses.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AugmentPromptResponse AugmentPrompt(AugmentPromptRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AugmentPromptRequest(ref request, ref callSettings);
            return _callAugmentPrompt.Sync(request, callSettings);
        }

        /// <summary>
        /// Given an input prompt, it returns augmented prompt from vertex rag store
        /// to guide LLM towards generating grounded responses.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AugmentPromptResponse> AugmentPromptAsync(AugmentPromptRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AugmentPromptRequest(ref request, ref callSettings);
            return _callAugmentPrompt.Async(request, callSettings);
        }

        /// <summary>
        /// Given an input text, it returns a score that evaluates the factuality of
        /// the text. It also extracts and returns claims from the text and provides
        /// supporting facts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CorroborateContentResponse CorroborateContent(CorroborateContentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CorroborateContentRequest(ref request, ref callSettings);
            return _callCorroborateContent.Sync(request, callSettings);
        }

        /// <summary>
        /// Given an input text, it returns a score that evaluates the factuality of
        /// the text. It also extracts and returns claims from the text and provides
        /// supporting facts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CorroborateContentResponse> CorroborateContentAsync(CorroborateContentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CorroborateContentRequest(ref request, ref callSettings);
            return _callCorroborateContent.Async(request, callSettings);
        }
    }

    public static partial class VertexRagService
    {
        public partial class VertexRagServiceClient
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

            /// <summary>
            /// Creates a new instance of <see cref="gciv::IAMPolicy.IAMPolicyClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>
            /// A new <see cref="gciv::IAMPolicy.IAMPolicyClient"/> for the same target as this client.
            /// </returns>
            public virtual gciv::IAMPolicy.IAMPolicyClient CreateIAMPolicyClient() =>
                new gciv::IAMPolicy.IAMPolicyClient(CallInvoker);
        }
    }
}
