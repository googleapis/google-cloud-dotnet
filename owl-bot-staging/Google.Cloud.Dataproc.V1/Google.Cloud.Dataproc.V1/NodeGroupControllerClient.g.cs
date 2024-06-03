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

namespace Google.Cloud.Dataproc.V1
{
    /// <summary>Settings for <see cref="NodeGroupControllerClient"/> instances.</summary>
    public sealed partial class NodeGroupControllerSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="NodeGroupControllerSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="NodeGroupControllerSettings"/>.</returns>
        public static NodeGroupControllerSettings GetDefault() => new NodeGroupControllerSettings();

        /// <summary>Constructs a new <see cref="NodeGroupControllerSettings"/> object with default settings.</summary>
        public NodeGroupControllerSettings()
        {
        }

        private NodeGroupControllerSettings(NodeGroupControllerSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateNodeGroupSettings = existing.CreateNodeGroupSettings;
            CreateNodeGroupOperationsSettings = existing.CreateNodeGroupOperationsSettings.Clone();
            ResizeNodeGroupSettings = existing.ResizeNodeGroupSettings;
            ResizeNodeGroupOperationsSettings = existing.ResizeNodeGroupOperationsSettings.Clone();
            GetNodeGroupSettings = existing.GetNodeGroupSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(NodeGroupControllerSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NodeGroupControllerClient.CreateNodeGroup</c> and <c>NodeGroupControllerClient.CreateNodeGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateNodeGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>NodeGroupControllerClient.CreateNodeGroup</c> and
        /// <c>NodeGroupControllerClient.CreateNodeGroupAsync</c>.
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
        public lro::OperationsSettings CreateNodeGroupOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NodeGroupControllerClient.ResizeNodeGroup</c> and <c>NodeGroupControllerClient.ResizeNodeGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ResizeNodeGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>NodeGroupControllerClient.ResizeNodeGroup</c> and
        /// <c>NodeGroupControllerClient.ResizeNodeGroupAsync</c>.
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
        public lro::OperationsSettings ResizeNodeGroupOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NodeGroupControllerClient.GetNodeGroup</c> and <c>NodeGroupControllerClient.GetNodeGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetNodeGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="NodeGroupControllerSettings"/> object.</returns>
        public NodeGroupControllerSettings Clone() => new NodeGroupControllerSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="NodeGroupControllerClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class NodeGroupControllerClientBuilder : gaxgrpc::ClientBuilderBase<NodeGroupControllerClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public NodeGroupControllerSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public NodeGroupControllerClientBuilder() : base(NodeGroupControllerClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref NodeGroupControllerClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<NodeGroupControllerClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override NodeGroupControllerClient Build()
        {
            NodeGroupControllerClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<NodeGroupControllerClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<NodeGroupControllerClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private NodeGroupControllerClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return NodeGroupControllerClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<NodeGroupControllerClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return NodeGroupControllerClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => NodeGroupControllerClient.ChannelPool;
    }

    /// <summary>NodeGroupController client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The `NodeGroupControllerService` provides methods to manage node groups
    /// of Compute Engine managed instances.
    /// </remarks>
    public abstract partial class NodeGroupControllerClient
    {
        /// <summary>
        /// The default endpoint for the NodeGroupController service, which is a host of "dataproc.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dataproc.googleapis.com:443";

        /// <summary>The default NodeGroupController scopes.</summary>
        /// <remarks>
        /// The default NodeGroupController scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(NodeGroupController.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="NodeGroupControllerClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="NodeGroupControllerClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="NodeGroupControllerClient"/>.</returns>
        public static stt::Task<NodeGroupControllerClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new NodeGroupControllerClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="NodeGroupControllerClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="NodeGroupControllerClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="NodeGroupControllerClient"/>.</returns>
        public static NodeGroupControllerClient Create() => new NodeGroupControllerClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="NodeGroupControllerClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="NodeGroupControllerSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="NodeGroupControllerClient"/>.</returns>
        internal static NodeGroupControllerClient Create(grpccore::CallInvoker callInvoker, NodeGroupControllerSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            NodeGroupController.NodeGroupControllerClient grpcClient = new NodeGroupController.NodeGroupControllerClient(callInvoker);
            return new NodeGroupControllerClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC NodeGroupController client</summary>
        public virtual NodeGroupController.NodeGroupControllerClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a node group in a cluster. The returned
        /// [Operation.metadata][google.longrunning.Operation.metadata] is
        /// [NodeGroupOperationMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#nodegroupoperationmetadata).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<NodeGroup, NodeGroupOperationMetadata> CreateNodeGroup(CreateNodeGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a node group in a cluster. The returned
        /// [Operation.metadata][google.longrunning.Operation.metadata] is
        /// [NodeGroupOperationMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#nodegroupoperationmetadata).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<NodeGroup, NodeGroupOperationMetadata>> CreateNodeGroupAsync(CreateNodeGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a node group in a cluster. The returned
        /// [Operation.metadata][google.longrunning.Operation.metadata] is
        /// [NodeGroupOperationMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#nodegroupoperationmetadata).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<NodeGroup, NodeGroupOperationMetadata>> CreateNodeGroupAsync(CreateNodeGroupRequest request, st::CancellationToken cancellationToken) =>
            CreateNodeGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateNodeGroup</c>.</summary>
        public virtual lro::OperationsClient CreateNodeGroupOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateNodeGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<NodeGroup, NodeGroupOperationMetadata> PollOnceCreateNodeGroup(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<NodeGroup, NodeGroupOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateNodeGroupOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateNodeGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<NodeGroup, NodeGroupOperationMetadata>> PollOnceCreateNodeGroupAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<NodeGroup, NodeGroupOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateNodeGroupOperationsClient, callSettings);

        /// <summary>
        /// Creates a node group in a cluster. The returned
        /// [Operation.metadata][google.longrunning.Operation.metadata] is
        /// [NodeGroupOperationMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#nodegroupoperationmetadata).
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this node group will be created.
        /// Format: `projects/{project}/regions/{region}/clusters/{cluster}`
        /// </param>
        /// <param name="nodeGroup">
        /// Required. The node group to create.
        /// </param>
        /// <param name="nodeGroupId">
        /// Optional. An optional node group ID. Generated if not specified.
        /// 
        /// The ID must contain only letters (a-z, A-Z), numbers (0-9),
        /// underscores (_), and hyphens (-). Cannot begin or end with underscore
        /// or hyphen. Must consist of from 3 to 33 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<NodeGroup, NodeGroupOperationMetadata> CreateNodeGroup(string parent, NodeGroup nodeGroup, string nodeGroupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateNodeGroup(new CreateNodeGroupRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                NodeGroup = gax::GaxPreconditions.CheckNotNull(nodeGroup, nameof(nodeGroup)),
                NodeGroupId = nodeGroupId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a node group in a cluster. The returned
        /// [Operation.metadata][google.longrunning.Operation.metadata] is
        /// [NodeGroupOperationMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#nodegroupoperationmetadata).
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this node group will be created.
        /// Format: `projects/{project}/regions/{region}/clusters/{cluster}`
        /// </param>
        /// <param name="nodeGroup">
        /// Required. The node group to create.
        /// </param>
        /// <param name="nodeGroupId">
        /// Optional. An optional node group ID. Generated if not specified.
        /// 
        /// The ID must contain only letters (a-z, A-Z), numbers (0-9),
        /// underscores (_), and hyphens (-). Cannot begin or end with underscore
        /// or hyphen. Must consist of from 3 to 33 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<NodeGroup, NodeGroupOperationMetadata>> CreateNodeGroupAsync(string parent, NodeGroup nodeGroup, string nodeGroupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateNodeGroupAsync(new CreateNodeGroupRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                NodeGroup = gax::GaxPreconditions.CheckNotNull(nodeGroup, nameof(nodeGroup)),
                NodeGroupId = nodeGroupId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a node group in a cluster. The returned
        /// [Operation.metadata][google.longrunning.Operation.metadata] is
        /// [NodeGroupOperationMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#nodegroupoperationmetadata).
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this node group will be created.
        /// Format: `projects/{project}/regions/{region}/clusters/{cluster}`
        /// </param>
        /// <param name="nodeGroup">
        /// Required. The node group to create.
        /// </param>
        /// <param name="nodeGroupId">
        /// Optional. An optional node group ID. Generated if not specified.
        /// 
        /// The ID must contain only letters (a-z, A-Z), numbers (0-9),
        /// underscores (_), and hyphens (-). Cannot begin or end with underscore
        /// or hyphen. Must consist of from 3 to 33 characters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<NodeGroup, NodeGroupOperationMetadata>> CreateNodeGroupAsync(string parent, NodeGroup nodeGroup, string nodeGroupId, st::CancellationToken cancellationToken) =>
            CreateNodeGroupAsync(parent, nodeGroup, nodeGroupId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a node group in a cluster. The returned
        /// [Operation.metadata][google.longrunning.Operation.metadata] is
        /// [NodeGroupOperationMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#nodegroupoperationmetadata).
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this node group will be created.
        /// Format: `projects/{project}/regions/{region}/clusters/{cluster}`
        /// </param>
        /// <param name="nodeGroup">
        /// Required. The node group to create.
        /// </param>
        /// <param name="nodeGroupId">
        /// Optional. An optional node group ID. Generated if not specified.
        /// 
        /// The ID must contain only letters (a-z, A-Z), numbers (0-9),
        /// underscores (_), and hyphens (-). Cannot begin or end with underscore
        /// or hyphen. Must consist of from 3 to 33 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<NodeGroup, NodeGroupOperationMetadata> CreateNodeGroup(ClusterRegionName parent, NodeGroup nodeGroup, string nodeGroupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateNodeGroup(new CreateNodeGroupRequest
            {
                ParentAsClusterRegionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                NodeGroup = gax::GaxPreconditions.CheckNotNull(nodeGroup, nameof(nodeGroup)),
                NodeGroupId = nodeGroupId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a node group in a cluster. The returned
        /// [Operation.metadata][google.longrunning.Operation.metadata] is
        /// [NodeGroupOperationMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#nodegroupoperationmetadata).
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this node group will be created.
        /// Format: `projects/{project}/regions/{region}/clusters/{cluster}`
        /// </param>
        /// <param name="nodeGroup">
        /// Required. The node group to create.
        /// </param>
        /// <param name="nodeGroupId">
        /// Optional. An optional node group ID. Generated if not specified.
        /// 
        /// The ID must contain only letters (a-z, A-Z), numbers (0-9),
        /// underscores (_), and hyphens (-). Cannot begin or end with underscore
        /// or hyphen. Must consist of from 3 to 33 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<NodeGroup, NodeGroupOperationMetadata>> CreateNodeGroupAsync(ClusterRegionName parent, NodeGroup nodeGroup, string nodeGroupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateNodeGroupAsync(new CreateNodeGroupRequest
            {
                ParentAsClusterRegionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                NodeGroup = gax::GaxPreconditions.CheckNotNull(nodeGroup, nameof(nodeGroup)),
                NodeGroupId = nodeGroupId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a node group in a cluster. The returned
        /// [Operation.metadata][google.longrunning.Operation.metadata] is
        /// [NodeGroupOperationMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#nodegroupoperationmetadata).
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this node group will be created.
        /// Format: `projects/{project}/regions/{region}/clusters/{cluster}`
        /// </param>
        /// <param name="nodeGroup">
        /// Required. The node group to create.
        /// </param>
        /// <param name="nodeGroupId">
        /// Optional. An optional node group ID. Generated if not specified.
        /// 
        /// The ID must contain only letters (a-z, A-Z), numbers (0-9),
        /// underscores (_), and hyphens (-). Cannot begin or end with underscore
        /// or hyphen. Must consist of from 3 to 33 characters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<NodeGroup, NodeGroupOperationMetadata>> CreateNodeGroupAsync(ClusterRegionName parent, NodeGroup nodeGroup, string nodeGroupId, st::CancellationToken cancellationToken) =>
            CreateNodeGroupAsync(parent, nodeGroup, nodeGroupId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resizes a node group in a cluster. The returned
        /// [Operation.metadata][google.longrunning.Operation.metadata] is
        /// [NodeGroupOperationMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#nodegroupoperationmetadata).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<NodeGroup, NodeGroupOperationMetadata> ResizeNodeGroup(ResizeNodeGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resizes a node group in a cluster. The returned
        /// [Operation.metadata][google.longrunning.Operation.metadata] is
        /// [NodeGroupOperationMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#nodegroupoperationmetadata).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<NodeGroup, NodeGroupOperationMetadata>> ResizeNodeGroupAsync(ResizeNodeGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resizes a node group in a cluster. The returned
        /// [Operation.metadata][google.longrunning.Operation.metadata] is
        /// [NodeGroupOperationMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#nodegroupoperationmetadata).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<NodeGroup, NodeGroupOperationMetadata>> ResizeNodeGroupAsync(ResizeNodeGroupRequest request, st::CancellationToken cancellationToken) =>
            ResizeNodeGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ResizeNodeGroup</c>.</summary>
        public virtual lro::OperationsClient ResizeNodeGroupOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ResizeNodeGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<NodeGroup, NodeGroupOperationMetadata> PollOnceResizeNodeGroup(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<NodeGroup, NodeGroupOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ResizeNodeGroupOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ResizeNodeGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<NodeGroup, NodeGroupOperationMetadata>> PollOnceResizeNodeGroupAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<NodeGroup, NodeGroupOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ResizeNodeGroupOperationsClient, callSettings);

        /// <summary>
        /// Resizes a node group in a cluster. The returned
        /// [Operation.metadata][google.longrunning.Operation.metadata] is
        /// [NodeGroupOperationMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#nodegroupoperationmetadata).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the node group to resize.
        /// Format:
        /// `projects/{project}/regions/{region}/clusters/{cluster}/nodeGroups/{nodeGroup}`
        /// </param>
        /// <param name="size">
        /// Required. The number of running instances for the node group to maintain.
        /// The group adds or removes instances to maintain the number of instances
        /// specified by this parameter.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<NodeGroup, NodeGroupOperationMetadata> ResizeNodeGroup(string name, int size, gaxgrpc::CallSettings callSettings = null) =>
            ResizeNodeGroup(new ResizeNodeGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Size = size,
            }, callSettings);

        /// <summary>
        /// Resizes a node group in a cluster. The returned
        /// [Operation.metadata][google.longrunning.Operation.metadata] is
        /// [NodeGroupOperationMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#nodegroupoperationmetadata).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the node group to resize.
        /// Format:
        /// `projects/{project}/regions/{region}/clusters/{cluster}/nodeGroups/{nodeGroup}`
        /// </param>
        /// <param name="size">
        /// Required. The number of running instances for the node group to maintain.
        /// The group adds or removes instances to maintain the number of instances
        /// specified by this parameter.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<NodeGroup, NodeGroupOperationMetadata>> ResizeNodeGroupAsync(string name, int size, gaxgrpc::CallSettings callSettings = null) =>
            ResizeNodeGroupAsync(new ResizeNodeGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Size = size,
            }, callSettings);

        /// <summary>
        /// Resizes a node group in a cluster. The returned
        /// [Operation.metadata][google.longrunning.Operation.metadata] is
        /// [NodeGroupOperationMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#nodegroupoperationmetadata).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the node group to resize.
        /// Format:
        /// `projects/{project}/regions/{region}/clusters/{cluster}/nodeGroups/{nodeGroup}`
        /// </param>
        /// <param name="size">
        /// Required. The number of running instances for the node group to maintain.
        /// The group adds or removes instances to maintain the number of instances
        /// specified by this parameter.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<NodeGroup, NodeGroupOperationMetadata>> ResizeNodeGroupAsync(string name, int size, st::CancellationToken cancellationToken) =>
            ResizeNodeGroupAsync(name, size, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the resource representation for a node group in a
        /// cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NodeGroup GetNodeGroup(GetNodeGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the resource representation for a node group in a
        /// cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NodeGroup> GetNodeGroupAsync(GetNodeGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the resource representation for a node group in a
        /// cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NodeGroup> GetNodeGroupAsync(GetNodeGroupRequest request, st::CancellationToken cancellationToken) =>
            GetNodeGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the resource representation for a node group in a
        /// cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the node group to retrieve.
        /// Format:
        /// `projects/{project}/regions/{region}/clusters/{cluster}/nodeGroups/{nodeGroup}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NodeGroup GetNodeGroup(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNodeGroup(new GetNodeGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the resource representation for a node group in a
        /// cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the node group to retrieve.
        /// Format:
        /// `projects/{project}/regions/{region}/clusters/{cluster}/nodeGroups/{nodeGroup}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NodeGroup> GetNodeGroupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNodeGroupAsync(new GetNodeGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the resource representation for a node group in a
        /// cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the node group to retrieve.
        /// Format:
        /// `projects/{project}/regions/{region}/clusters/{cluster}/nodeGroups/{nodeGroup}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NodeGroup> GetNodeGroupAsync(string name, st::CancellationToken cancellationToken) =>
            GetNodeGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the resource representation for a node group in a
        /// cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the node group to retrieve.
        /// Format:
        /// `projects/{project}/regions/{region}/clusters/{cluster}/nodeGroups/{nodeGroup}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NodeGroup GetNodeGroup(NodeGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNodeGroup(new GetNodeGroupRequest
            {
                NodeGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the resource representation for a node group in a
        /// cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the node group to retrieve.
        /// Format:
        /// `projects/{project}/regions/{region}/clusters/{cluster}/nodeGroups/{nodeGroup}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NodeGroup> GetNodeGroupAsync(NodeGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNodeGroupAsync(new GetNodeGroupRequest
            {
                NodeGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the resource representation for a node group in a
        /// cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the node group to retrieve.
        /// Format:
        /// `projects/{project}/regions/{region}/clusters/{cluster}/nodeGroups/{nodeGroup}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NodeGroup> GetNodeGroupAsync(NodeGroupName name, st::CancellationToken cancellationToken) =>
            GetNodeGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>NodeGroupController client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The `NodeGroupControllerService` provides methods to manage node groups
    /// of Compute Engine managed instances.
    /// </remarks>
    public sealed partial class NodeGroupControllerClientImpl : NodeGroupControllerClient
    {
        private readonly gaxgrpc::ApiCall<CreateNodeGroupRequest, lro::Operation> _callCreateNodeGroup;

        private readonly gaxgrpc::ApiCall<ResizeNodeGroupRequest, lro::Operation> _callResizeNodeGroup;

        private readonly gaxgrpc::ApiCall<GetNodeGroupRequest, NodeGroup> _callGetNodeGroup;

        /// <summary>
        /// Constructs a client wrapper for the NodeGroupController service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="NodeGroupControllerSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public NodeGroupControllerClientImpl(NodeGroupController.NodeGroupControllerClient grpcClient, NodeGroupControllerSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            NodeGroupControllerSettings effectiveSettings = settings ?? NodeGroupControllerSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateNodeGroupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateNodeGroupOperationsSettings, logger);
            ResizeNodeGroupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ResizeNodeGroupOperationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callCreateNodeGroup = clientHelper.BuildApiCall<CreateNodeGroupRequest, lro::Operation>("CreateNodeGroup", grpcClient.CreateNodeGroupAsync, grpcClient.CreateNodeGroup, effectiveSettings.CreateNodeGroupSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateNodeGroup);
            Modify_CreateNodeGroupApiCall(ref _callCreateNodeGroup);
            _callResizeNodeGroup = clientHelper.BuildApiCall<ResizeNodeGroupRequest, lro::Operation>("ResizeNodeGroup", grpcClient.ResizeNodeGroupAsync, grpcClient.ResizeNodeGroup, effectiveSettings.ResizeNodeGroupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callResizeNodeGroup);
            Modify_ResizeNodeGroupApiCall(ref _callResizeNodeGroup);
            _callGetNodeGroup = clientHelper.BuildApiCall<GetNodeGroupRequest, NodeGroup>("GetNodeGroup", grpcClient.GetNodeGroupAsync, grpcClient.GetNodeGroup, effectiveSettings.GetNodeGroupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetNodeGroup);
            Modify_GetNodeGroupApiCall(ref _callGetNodeGroup);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateNodeGroupApiCall(ref gaxgrpc::ApiCall<CreateNodeGroupRequest, lro::Operation> call);

        partial void Modify_ResizeNodeGroupApiCall(ref gaxgrpc::ApiCall<ResizeNodeGroupRequest, lro::Operation> call);

        partial void Modify_GetNodeGroupApiCall(ref gaxgrpc::ApiCall<GetNodeGroupRequest, NodeGroup> call);

        partial void OnConstruction(NodeGroupController.NodeGroupControllerClient grpcClient, NodeGroupControllerSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC NodeGroupController client</summary>
        public override NodeGroupController.NodeGroupControllerClient GrpcClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_CreateNodeGroupRequest(ref CreateNodeGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ResizeNodeGroupRequest(ref ResizeNodeGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetNodeGroupRequest(ref GetNodeGroupRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateNodeGroup</c>.</summary>
        public override lro::OperationsClient CreateNodeGroupOperationsClient { get; }

        /// <summary>
        /// Creates a node group in a cluster. The returned
        /// [Operation.metadata][google.longrunning.Operation.metadata] is
        /// [NodeGroupOperationMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#nodegroupoperationmetadata).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<NodeGroup, NodeGroupOperationMetadata> CreateNodeGroup(CreateNodeGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateNodeGroupRequest(ref request, ref callSettings);
            return new lro::Operation<NodeGroup, NodeGroupOperationMetadata>(_callCreateNodeGroup.Sync(request, callSettings), CreateNodeGroupOperationsClient);
        }

        /// <summary>
        /// Creates a node group in a cluster. The returned
        /// [Operation.metadata][google.longrunning.Operation.metadata] is
        /// [NodeGroupOperationMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#nodegroupoperationmetadata).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<NodeGroup, NodeGroupOperationMetadata>> CreateNodeGroupAsync(CreateNodeGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateNodeGroupRequest(ref request, ref callSettings);
            return new lro::Operation<NodeGroup, NodeGroupOperationMetadata>(await _callCreateNodeGroup.Async(request, callSettings).ConfigureAwait(false), CreateNodeGroupOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ResizeNodeGroup</c>.</summary>
        public override lro::OperationsClient ResizeNodeGroupOperationsClient { get; }

        /// <summary>
        /// Resizes a node group in a cluster. The returned
        /// [Operation.metadata][google.longrunning.Operation.metadata] is
        /// [NodeGroupOperationMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#nodegroupoperationmetadata).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<NodeGroup, NodeGroupOperationMetadata> ResizeNodeGroup(ResizeNodeGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResizeNodeGroupRequest(ref request, ref callSettings);
            return new lro::Operation<NodeGroup, NodeGroupOperationMetadata>(_callResizeNodeGroup.Sync(request, callSettings), ResizeNodeGroupOperationsClient);
        }

        /// <summary>
        /// Resizes a node group in a cluster. The returned
        /// [Operation.metadata][google.longrunning.Operation.metadata] is
        /// [NodeGroupOperationMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#nodegroupoperationmetadata).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<NodeGroup, NodeGroupOperationMetadata>> ResizeNodeGroupAsync(ResizeNodeGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResizeNodeGroupRequest(ref request, ref callSettings);
            return new lro::Operation<NodeGroup, NodeGroupOperationMetadata>(await _callResizeNodeGroup.Async(request, callSettings).ConfigureAwait(false), ResizeNodeGroupOperationsClient);
        }

        /// <summary>
        /// Gets the resource representation for a node group in a
        /// cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override NodeGroup GetNodeGroup(GetNodeGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNodeGroupRequest(ref request, ref callSettings);
            return _callGetNodeGroup.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the resource representation for a node group in a
        /// cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<NodeGroup> GetNodeGroupAsync(GetNodeGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNodeGroupRequest(ref request, ref callSettings);
            return _callGetNodeGroup.Async(request, callSettings);
        }
    }

    public static partial class NodeGroupController
    {
        public partial class NodeGroupControllerClient
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

    public static partial class NodeGroupController
    {
        public partial class NodeGroupControllerClient
        {
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
