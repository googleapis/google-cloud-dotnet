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
using gciv = Google.Cloud.Iam.V1;
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

namespace Google.Cloud.AIPlatform.V1Beta1
{
    /// <summary>Settings for <see cref="ExtensionExecutionServiceClient"/> instances.</summary>
    public sealed partial class ExtensionExecutionServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ExtensionExecutionServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ExtensionExecutionServiceSettings"/>.</returns>
        public static ExtensionExecutionServiceSettings GetDefault() => new ExtensionExecutionServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ExtensionExecutionServiceSettings"/> object with default settings.
        /// </summary>
        public ExtensionExecutionServiceSettings()
        {
        }

        private ExtensionExecutionServiceSettings(ExtensionExecutionServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ExecuteExtensionSettings = existing.ExecuteExtensionSettings;
            QueryExtensionSettings = existing.QueryExtensionSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(ExtensionExecutionServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ExtensionExecutionServiceClient.ExecuteExtension</c> and
        /// <c>ExtensionExecutionServiceClient.ExecuteExtensionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExecuteExtensionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ExtensionExecutionServiceClient.QueryExtension</c> and
        /// <c>ExtensionExecutionServiceClient.QueryExtensionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings QueryExtensionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ExtensionExecutionServiceSettings"/> object.</returns>
        public ExtensionExecutionServiceSettings Clone() => new ExtensionExecutionServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ExtensionExecutionServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class ExtensionExecutionServiceClientBuilder : gaxgrpc::ClientBuilderBase<ExtensionExecutionServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ExtensionExecutionServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ExtensionExecutionServiceClientBuilder() : base(ExtensionExecutionServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ExtensionExecutionServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ExtensionExecutionServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ExtensionExecutionServiceClient Build()
        {
            ExtensionExecutionServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ExtensionExecutionServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ExtensionExecutionServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ExtensionExecutionServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ExtensionExecutionServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ExtensionExecutionServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ExtensionExecutionServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ExtensionExecutionServiceClient.ChannelPool;
    }

    /// <summary>ExtensionExecutionService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service for Extension execution.
    /// </remarks>
    public abstract partial class ExtensionExecutionServiceClient
    {
        /// <summary>
        /// The default endpoint for the ExtensionExecutionService service, which is a host of
        /// "aiplatform.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "aiplatform.googleapis.com:443";

        /// <summary>The default ExtensionExecutionService scopes.</summary>
        /// <remarks>
        /// The default ExtensionExecutionService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ExtensionExecutionService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ExtensionExecutionServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="ExtensionExecutionServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ExtensionExecutionServiceClient"/>.</returns>
        public static stt::Task<ExtensionExecutionServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ExtensionExecutionServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ExtensionExecutionServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="ExtensionExecutionServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ExtensionExecutionServiceClient"/>.</returns>
        public static ExtensionExecutionServiceClient Create() => new ExtensionExecutionServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ExtensionExecutionServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ExtensionExecutionServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ExtensionExecutionServiceClient"/>.</returns>
        internal static ExtensionExecutionServiceClient Create(grpccore::CallInvoker callInvoker, ExtensionExecutionServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ExtensionExecutionService.ExtensionExecutionServiceClient grpcClient = new ExtensionExecutionService.ExtensionExecutionServiceClient(callInvoker);
            return new ExtensionExecutionServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ExtensionExecutionService client</summary>
        public virtual ExtensionExecutionService.ExtensionExecutionServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Executes the request against a given extension.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ExecuteExtensionResponse ExecuteExtension(ExecuteExtensionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Executes the request against a given extension.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExecuteExtensionResponse> ExecuteExtensionAsync(ExecuteExtensionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Executes the request against a given extension.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExecuteExtensionResponse> ExecuteExtensionAsync(ExecuteExtensionRequest request, st::CancellationToken cancellationToken) =>
            ExecuteExtensionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Executes the request against a given extension.
        /// </summary>
        /// <param name="name">
        /// Required. Name (identifier) of the extension;
        /// Format:
        /// `projects/{project}/locations/{location}/extensions/{extension}`
        /// </param>
        /// <param name="operationId">
        /// Required. The desired ID of the operation to be executed in this extension
        /// as defined in
        /// [ExtensionOperation.operation_id][google.cloud.aiplatform.v1beta1.ExtensionOperation.operation_id].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ExecuteExtensionResponse ExecuteExtension(string name, string operationId, gaxgrpc::CallSettings callSettings = null) =>
            ExecuteExtension(new ExecuteExtensionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                OperationId = gax::GaxPreconditions.CheckNotNullOrEmpty(operationId, nameof(operationId)),
            }, callSettings);

        /// <summary>
        /// Executes the request against a given extension.
        /// </summary>
        /// <param name="name">
        /// Required. Name (identifier) of the extension;
        /// Format:
        /// `projects/{project}/locations/{location}/extensions/{extension}`
        /// </param>
        /// <param name="operationId">
        /// Required. The desired ID of the operation to be executed in this extension
        /// as defined in
        /// [ExtensionOperation.operation_id][google.cloud.aiplatform.v1beta1.ExtensionOperation.operation_id].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExecuteExtensionResponse> ExecuteExtensionAsync(string name, string operationId, gaxgrpc::CallSettings callSettings = null) =>
            ExecuteExtensionAsync(new ExecuteExtensionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                OperationId = gax::GaxPreconditions.CheckNotNullOrEmpty(operationId, nameof(operationId)),
            }, callSettings);

        /// <summary>
        /// Executes the request against a given extension.
        /// </summary>
        /// <param name="name">
        /// Required. Name (identifier) of the extension;
        /// Format:
        /// `projects/{project}/locations/{location}/extensions/{extension}`
        /// </param>
        /// <param name="operationId">
        /// Required. The desired ID of the operation to be executed in this extension
        /// as defined in
        /// [ExtensionOperation.operation_id][google.cloud.aiplatform.v1beta1.ExtensionOperation.operation_id].
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExecuteExtensionResponse> ExecuteExtensionAsync(string name, string operationId, st::CancellationToken cancellationToken) =>
            ExecuteExtensionAsync(name, operationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Executes the request against a given extension.
        /// </summary>
        /// <param name="name">
        /// Required. Name (identifier) of the extension;
        /// Format:
        /// `projects/{project}/locations/{location}/extensions/{extension}`
        /// </param>
        /// <param name="operationId">
        /// Required. The desired ID of the operation to be executed in this extension
        /// as defined in
        /// [ExtensionOperation.operation_id][google.cloud.aiplatform.v1beta1.ExtensionOperation.operation_id].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ExecuteExtensionResponse ExecuteExtension(ExtensionName name, string operationId, gaxgrpc::CallSettings callSettings = null) =>
            ExecuteExtension(new ExecuteExtensionRequest
            {
                ExtensionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                OperationId = gax::GaxPreconditions.CheckNotNullOrEmpty(operationId, nameof(operationId)),
            }, callSettings);

        /// <summary>
        /// Executes the request against a given extension.
        /// </summary>
        /// <param name="name">
        /// Required. Name (identifier) of the extension;
        /// Format:
        /// `projects/{project}/locations/{location}/extensions/{extension}`
        /// </param>
        /// <param name="operationId">
        /// Required. The desired ID of the operation to be executed in this extension
        /// as defined in
        /// [ExtensionOperation.operation_id][google.cloud.aiplatform.v1beta1.ExtensionOperation.operation_id].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExecuteExtensionResponse> ExecuteExtensionAsync(ExtensionName name, string operationId, gaxgrpc::CallSettings callSettings = null) =>
            ExecuteExtensionAsync(new ExecuteExtensionRequest
            {
                ExtensionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                OperationId = gax::GaxPreconditions.CheckNotNullOrEmpty(operationId, nameof(operationId)),
            }, callSettings);

        /// <summary>
        /// Executes the request against a given extension.
        /// </summary>
        /// <param name="name">
        /// Required. Name (identifier) of the extension;
        /// Format:
        /// `projects/{project}/locations/{location}/extensions/{extension}`
        /// </param>
        /// <param name="operationId">
        /// Required. The desired ID of the operation to be executed in this extension
        /// as defined in
        /// [ExtensionOperation.operation_id][google.cloud.aiplatform.v1beta1.ExtensionOperation.operation_id].
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExecuteExtensionResponse> ExecuteExtensionAsync(ExtensionName name, string operationId, st::CancellationToken cancellationToken) =>
            ExecuteExtensionAsync(name, operationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Queries an extension with a default controller.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QueryExtensionResponse QueryExtension(QueryExtensionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Queries an extension with a default controller.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QueryExtensionResponse> QueryExtensionAsync(QueryExtensionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Queries an extension with a default controller.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QueryExtensionResponse> QueryExtensionAsync(QueryExtensionRequest request, st::CancellationToken cancellationToken) =>
            QueryExtensionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Queries an extension with a default controller.
        /// </summary>
        /// <param name="name">
        /// Required. Name (identifier) of the extension;
        /// Format:
        /// `projects/{project}/locations/{location}/extensions/{extension}`
        /// </param>
        /// <param name="contents">
        /// Required. The content of the current conversation with the model.
        /// 
        /// For single-turn queries, this is a single instance. For multi-turn queries,
        /// this is a repeated field that contains conversation history + latest
        /// request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QueryExtensionResponse QueryExtension(string name, scg::IEnumerable<Content> contents, gaxgrpc::CallSettings callSettings = null) =>
            QueryExtension(new QueryExtensionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Contents =
                {
                    gax::GaxPreconditions.CheckNotNull(contents, nameof(contents)),
                },
            }, callSettings);

        /// <summary>
        /// Queries an extension with a default controller.
        /// </summary>
        /// <param name="name">
        /// Required. Name (identifier) of the extension;
        /// Format:
        /// `projects/{project}/locations/{location}/extensions/{extension}`
        /// </param>
        /// <param name="contents">
        /// Required. The content of the current conversation with the model.
        /// 
        /// For single-turn queries, this is a single instance. For multi-turn queries,
        /// this is a repeated field that contains conversation history + latest
        /// request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QueryExtensionResponse> QueryExtensionAsync(string name, scg::IEnumerable<Content> contents, gaxgrpc::CallSettings callSettings = null) =>
            QueryExtensionAsync(new QueryExtensionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Contents =
                {
                    gax::GaxPreconditions.CheckNotNull(contents, nameof(contents)),
                },
            }, callSettings);

        /// <summary>
        /// Queries an extension with a default controller.
        /// </summary>
        /// <param name="name">
        /// Required. Name (identifier) of the extension;
        /// Format:
        /// `projects/{project}/locations/{location}/extensions/{extension}`
        /// </param>
        /// <param name="contents">
        /// Required. The content of the current conversation with the model.
        /// 
        /// For single-turn queries, this is a single instance. For multi-turn queries,
        /// this is a repeated field that contains conversation history + latest
        /// request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QueryExtensionResponse> QueryExtensionAsync(string name, scg::IEnumerable<Content> contents, st::CancellationToken cancellationToken) =>
            QueryExtensionAsync(name, contents, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Queries an extension with a default controller.
        /// </summary>
        /// <param name="name">
        /// Required. Name (identifier) of the extension;
        /// Format:
        /// `projects/{project}/locations/{location}/extensions/{extension}`
        /// </param>
        /// <param name="contents">
        /// Required. The content of the current conversation with the model.
        /// 
        /// For single-turn queries, this is a single instance. For multi-turn queries,
        /// this is a repeated field that contains conversation history + latest
        /// request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QueryExtensionResponse QueryExtension(ExtensionName name, scg::IEnumerable<Content> contents, gaxgrpc::CallSettings callSettings = null) =>
            QueryExtension(new QueryExtensionRequest
            {
                ExtensionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Contents =
                {
                    gax::GaxPreconditions.CheckNotNull(contents, nameof(contents)),
                },
            }, callSettings);

        /// <summary>
        /// Queries an extension with a default controller.
        /// </summary>
        /// <param name="name">
        /// Required. Name (identifier) of the extension;
        /// Format:
        /// `projects/{project}/locations/{location}/extensions/{extension}`
        /// </param>
        /// <param name="contents">
        /// Required. The content of the current conversation with the model.
        /// 
        /// For single-turn queries, this is a single instance. For multi-turn queries,
        /// this is a repeated field that contains conversation history + latest
        /// request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QueryExtensionResponse> QueryExtensionAsync(ExtensionName name, scg::IEnumerable<Content> contents, gaxgrpc::CallSettings callSettings = null) =>
            QueryExtensionAsync(new QueryExtensionRequest
            {
                ExtensionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Contents =
                {
                    gax::GaxPreconditions.CheckNotNull(contents, nameof(contents)),
                },
            }, callSettings);

        /// <summary>
        /// Queries an extension with a default controller.
        /// </summary>
        /// <param name="name">
        /// Required. Name (identifier) of the extension;
        /// Format:
        /// `projects/{project}/locations/{location}/extensions/{extension}`
        /// </param>
        /// <param name="contents">
        /// Required. The content of the current conversation with the model.
        /// 
        /// For single-turn queries, this is a single instance. For multi-turn queries,
        /// this is a repeated field that contains conversation history + latest
        /// request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QueryExtensionResponse> QueryExtensionAsync(ExtensionName name, scg::IEnumerable<Content> contents, st::CancellationToken cancellationToken) =>
            QueryExtensionAsync(name, contents, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ExtensionExecutionService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service for Extension execution.
    /// </remarks>
    public sealed partial class ExtensionExecutionServiceClientImpl : ExtensionExecutionServiceClient
    {
        private readonly gaxgrpc::ApiCall<ExecuteExtensionRequest, ExecuteExtensionResponse> _callExecuteExtension;

        private readonly gaxgrpc::ApiCall<QueryExtensionRequest, QueryExtensionResponse> _callQueryExtension;

        /// <summary>
        /// Constructs a client wrapper for the ExtensionExecutionService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="ExtensionExecutionServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ExtensionExecutionServiceClientImpl(ExtensionExecutionService.ExtensionExecutionServiceClient grpcClient, ExtensionExecutionServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ExtensionExecutionServiceSettings effectiveSettings = settings ?? ExtensionExecutionServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callExecuteExtension = clientHelper.BuildApiCall<ExecuteExtensionRequest, ExecuteExtensionResponse>("ExecuteExtension", grpcClient.ExecuteExtensionAsync, grpcClient.ExecuteExtension, effectiveSettings.ExecuteExtensionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callExecuteExtension);
            Modify_ExecuteExtensionApiCall(ref _callExecuteExtension);
            _callQueryExtension = clientHelper.BuildApiCall<QueryExtensionRequest, QueryExtensionResponse>("QueryExtension", grpcClient.QueryExtensionAsync, grpcClient.QueryExtension, effectiveSettings.QueryExtensionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callQueryExtension);
            Modify_QueryExtensionApiCall(ref _callQueryExtension);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ExecuteExtensionApiCall(ref gaxgrpc::ApiCall<ExecuteExtensionRequest, ExecuteExtensionResponse> call);

        partial void Modify_QueryExtensionApiCall(ref gaxgrpc::ApiCall<QueryExtensionRequest, QueryExtensionResponse> call);

        partial void OnConstruction(ExtensionExecutionService.ExtensionExecutionServiceClient grpcClient, ExtensionExecutionServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ExtensionExecutionService client</summary>
        public override ExtensionExecutionService.ExtensionExecutionServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ExecuteExtensionRequest(ref ExecuteExtensionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_QueryExtensionRequest(ref QueryExtensionRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Executes the request against a given extension.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ExecuteExtensionResponse ExecuteExtension(ExecuteExtensionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExecuteExtensionRequest(ref request, ref callSettings);
            return _callExecuteExtension.Sync(request, callSettings);
        }

        /// <summary>
        /// Executes the request against a given extension.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ExecuteExtensionResponse> ExecuteExtensionAsync(ExecuteExtensionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExecuteExtensionRequest(ref request, ref callSettings);
            return _callExecuteExtension.Async(request, callSettings);
        }

        /// <summary>
        /// Queries an extension with a default controller.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override QueryExtensionResponse QueryExtension(QueryExtensionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryExtensionRequest(ref request, ref callSettings);
            return _callQueryExtension.Sync(request, callSettings);
        }

        /// <summary>
        /// Queries an extension with a default controller.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<QueryExtensionResponse> QueryExtensionAsync(QueryExtensionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryExtensionRequest(ref request, ref callSettings);
            return _callQueryExtension.Async(request, callSettings);
        }
    }

    public static partial class ExtensionExecutionService
    {
        public partial class ExtensionExecutionServiceClient
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
