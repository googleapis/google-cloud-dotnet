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

namespace Google.Cloud.Workflows.Executions.V1Beta
{
    /// <summary>Settings for <see cref="ExecutionsClient"/> instances.</summary>
    public sealed partial class ExecutionsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ExecutionsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ExecutionsSettings"/>.</returns>
        public static ExecutionsSettings GetDefault() => new ExecutionsSettings();

        /// <summary>Constructs a new <see cref="ExecutionsSettings"/> object with default settings.</summary>
        public ExecutionsSettings()
        {
        }

        private ExecutionsSettings(ExecutionsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListExecutionsSettings = existing.ListExecutionsSettings;
            CreateExecutionSettings = existing.CreateExecutionSettings;
            GetExecutionSettings = existing.GetExecutionSettings;
            CancelExecutionSettings = existing.CancelExecutionSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ExecutionsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ExecutionsClient.ListExecutions</c> and <c>ExecutionsClient.ListExecutionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListExecutionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ExecutionsClient.CreateExecution</c> and <c>ExecutionsClient.CreateExecutionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateExecutionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ExecutionsClient.GetExecution</c> and <c>ExecutionsClient.GetExecutionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetExecutionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ExecutionsClient.CancelExecution</c> and <c>ExecutionsClient.CancelExecutionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CancelExecutionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ExecutionsSettings"/> object.</returns>
        public ExecutionsSettings Clone() => new ExecutionsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ExecutionsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class ExecutionsClientBuilder : gaxgrpc::ClientBuilderBase<ExecutionsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ExecutionsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ExecutionsClientBuilder() : base(ExecutionsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ExecutionsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ExecutionsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ExecutionsClient Build()
        {
            ExecutionsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ExecutionsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ExecutionsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ExecutionsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ExecutionsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ExecutionsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ExecutionsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ExecutionsClient.ChannelPool;
    }

    /// <summary>Executions client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Executions is used to start and manage running instances of
    /// [Workflows][google.cloud.workflows.v1beta.Workflow] called executions.
    /// </remarks>
    public abstract partial class ExecutionsClient
    {
        /// <summary>
        /// The default endpoint for the Executions service, which is a host of "workflowexecutions.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "workflowexecutions.googleapis.com:443";

        /// <summary>The default Executions scopes.</summary>
        /// <remarks>
        /// The default Executions scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Executions.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ExecutionsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ExecutionsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ExecutionsClient"/>.</returns>
        public static stt::Task<ExecutionsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ExecutionsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ExecutionsClient"/> using the default credentials, endpoint and settings.
        /// To specify custom credentials or other settings, use <see cref="ExecutionsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ExecutionsClient"/>.</returns>
        public static ExecutionsClient Create() => new ExecutionsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ExecutionsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ExecutionsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ExecutionsClient"/>.</returns>
        internal static ExecutionsClient Create(grpccore::CallInvoker callInvoker, ExecutionsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Executions.ExecutionsClient grpcClient = new Executions.ExecutionsClient(callInvoker);
            return new ExecutionsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Executions client</summary>
        public virtual Executions.ExecutionsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of executions which belong to the workflow with
        /// the given name. The method returns executions of all workflow
        /// revisions. Returned executions are ordered by their start time (newest
        /// first).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Execution"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExecutionsResponse, Execution> ListExecutions(ListExecutionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of executions which belong to the workflow with
        /// the given name. The method returns executions of all workflow
        /// revisions. Returned executions are ordered by their start time (newest
        /// first).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Execution"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExecutionsResponse, Execution> ListExecutionsAsync(ListExecutionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of executions which belong to the workflow with
        /// the given name. The method returns executions of all workflow
        /// revisions. Returned executions are ordered by their start time (newest
        /// first).
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the workflow for which the executions should be listed.
        /// Format: projects/{project}/locations/{location}/workflows/{workflow}
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
        /// <returns>A pageable sequence of <see cref="Execution"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExecutionsResponse, Execution> ListExecutions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExecutionsRequest request = new ListExecutionsRequest
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
            return ListExecutions(request, callSettings);
        }

        /// <summary>
        /// Returns a list of executions which belong to the workflow with
        /// the given name. The method returns executions of all workflow
        /// revisions. Returned executions are ordered by their start time (newest
        /// first).
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the workflow for which the executions should be listed.
        /// Format: projects/{project}/locations/{location}/workflows/{workflow}
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
        /// <returns>A pageable asynchronous sequence of <see cref="Execution"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExecutionsResponse, Execution> ListExecutionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExecutionsRequest request = new ListExecutionsRequest
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
            return ListExecutionsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns a list of executions which belong to the workflow with
        /// the given name. The method returns executions of all workflow
        /// revisions. Returned executions are ordered by their start time (newest
        /// first).
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the workflow for which the executions should be listed.
        /// Format: projects/{project}/locations/{location}/workflows/{workflow}
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
        /// <returns>A pageable sequence of <see cref="Execution"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExecutionsResponse, Execution> ListExecutions(WorkflowName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExecutionsRequest request = new ListExecutionsRequest
            {
                ParentAsWorkflowName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListExecutions(request, callSettings);
        }

        /// <summary>
        /// Returns a list of executions which belong to the workflow with
        /// the given name. The method returns executions of all workflow
        /// revisions. Returned executions are ordered by their start time (newest
        /// first).
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the workflow for which the executions should be listed.
        /// Format: projects/{project}/locations/{location}/workflows/{workflow}
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
        /// <returns>A pageable asynchronous sequence of <see cref="Execution"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExecutionsResponse, Execution> ListExecutionsAsync(WorkflowName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExecutionsRequest request = new ListExecutionsRequest
            {
                ParentAsWorkflowName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListExecutionsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a new execution using the latest revision of the given workflow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Execution CreateExecution(CreateExecutionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new execution using the latest revision of the given workflow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Execution> CreateExecutionAsync(CreateExecutionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new execution using the latest revision of the given workflow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Execution> CreateExecutionAsync(CreateExecutionRequest request, st::CancellationToken cancellationToken) =>
            CreateExecutionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new execution using the latest revision of the given workflow.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the workflow for which an execution should be created.
        /// Format: projects/{project}/locations/{location}/workflows/{workflow}
        /// The latest revision of the workflow will be used.
        /// </param>
        /// <param name="execution">
        /// Required. Execution to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Execution CreateExecution(string parent, Execution execution, gaxgrpc::CallSettings callSettings = null) =>
            CreateExecution(new CreateExecutionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Execution = gax::GaxPreconditions.CheckNotNull(execution, nameof(execution)),
            }, callSettings);

        /// <summary>
        /// Creates a new execution using the latest revision of the given workflow.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the workflow for which an execution should be created.
        /// Format: projects/{project}/locations/{location}/workflows/{workflow}
        /// The latest revision of the workflow will be used.
        /// </param>
        /// <param name="execution">
        /// Required. Execution to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Execution> CreateExecutionAsync(string parent, Execution execution, gaxgrpc::CallSettings callSettings = null) =>
            CreateExecutionAsync(new CreateExecutionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Execution = gax::GaxPreconditions.CheckNotNull(execution, nameof(execution)),
            }, callSettings);

        /// <summary>
        /// Creates a new execution using the latest revision of the given workflow.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the workflow for which an execution should be created.
        /// Format: projects/{project}/locations/{location}/workflows/{workflow}
        /// The latest revision of the workflow will be used.
        /// </param>
        /// <param name="execution">
        /// Required. Execution to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Execution> CreateExecutionAsync(string parent, Execution execution, st::CancellationToken cancellationToken) =>
            CreateExecutionAsync(parent, execution, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new execution using the latest revision of the given workflow.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the workflow for which an execution should be created.
        /// Format: projects/{project}/locations/{location}/workflows/{workflow}
        /// The latest revision of the workflow will be used.
        /// </param>
        /// <param name="execution">
        /// Required. Execution to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Execution CreateExecution(WorkflowName parent, Execution execution, gaxgrpc::CallSettings callSettings = null) =>
            CreateExecution(new CreateExecutionRequest
            {
                ParentAsWorkflowName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Execution = gax::GaxPreconditions.CheckNotNull(execution, nameof(execution)),
            }, callSettings);

        /// <summary>
        /// Creates a new execution using the latest revision of the given workflow.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the workflow for which an execution should be created.
        /// Format: projects/{project}/locations/{location}/workflows/{workflow}
        /// The latest revision of the workflow will be used.
        /// </param>
        /// <param name="execution">
        /// Required. Execution to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Execution> CreateExecutionAsync(WorkflowName parent, Execution execution, gaxgrpc::CallSettings callSettings = null) =>
            CreateExecutionAsync(new CreateExecutionRequest
            {
                ParentAsWorkflowName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Execution = gax::GaxPreconditions.CheckNotNull(execution, nameof(execution)),
            }, callSettings);

        /// <summary>
        /// Creates a new execution using the latest revision of the given workflow.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the workflow for which an execution should be created.
        /// Format: projects/{project}/locations/{location}/workflows/{workflow}
        /// The latest revision of the workflow will be used.
        /// </param>
        /// <param name="execution">
        /// Required. Execution to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Execution> CreateExecutionAsync(WorkflowName parent, Execution execution, st::CancellationToken cancellationToken) =>
            CreateExecutionAsync(parent, execution, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns an execution of the given name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Execution GetExecution(GetExecutionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns an execution of the given name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Execution> GetExecutionAsync(GetExecutionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns an execution of the given name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Execution> GetExecutionAsync(GetExecutionRequest request, st::CancellationToken cancellationToken) =>
            GetExecutionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns an execution of the given name.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the execution to be retrieved.
        /// Format:
        /// projects/{project}/locations/{location}/workflows/{workflow}/executions/{execution}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Execution GetExecution(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetExecution(new GetExecutionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns an execution of the given name.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the execution to be retrieved.
        /// Format:
        /// projects/{project}/locations/{location}/workflows/{workflow}/executions/{execution}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Execution> GetExecutionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetExecutionAsync(new GetExecutionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns an execution of the given name.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the execution to be retrieved.
        /// Format:
        /// projects/{project}/locations/{location}/workflows/{workflow}/executions/{execution}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Execution> GetExecutionAsync(string name, st::CancellationToken cancellationToken) =>
            GetExecutionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns an execution of the given name.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the execution to be retrieved.
        /// Format:
        /// projects/{project}/locations/{location}/workflows/{workflow}/executions/{execution}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Execution GetExecution(ExecutionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetExecution(new GetExecutionRequest
            {
                ExecutionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns an execution of the given name.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the execution to be retrieved.
        /// Format:
        /// projects/{project}/locations/{location}/workflows/{workflow}/executions/{execution}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Execution> GetExecutionAsync(ExecutionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetExecutionAsync(new GetExecutionRequest
            {
                ExecutionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns an execution of the given name.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the execution to be retrieved.
        /// Format:
        /// projects/{project}/locations/{location}/workflows/{workflow}/executions/{execution}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Execution> GetExecutionAsync(ExecutionName name, st::CancellationToken cancellationToken) =>
            GetExecutionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels an execution of the given name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Execution CancelExecution(CancelExecutionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancels an execution of the given name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Execution> CancelExecutionAsync(CancelExecutionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancels an execution of the given name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Execution> CancelExecutionAsync(CancelExecutionRequest request, st::CancellationToken cancellationToken) =>
            CancelExecutionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels an execution of the given name.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the execution to be cancelled.
        /// Format:
        /// projects/{project}/locations/{location}/workflows/{workflow}/executions/{execution}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Execution CancelExecution(string name, gaxgrpc::CallSettings callSettings = null) =>
            CancelExecution(new CancelExecutionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels an execution of the given name.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the execution to be cancelled.
        /// Format:
        /// projects/{project}/locations/{location}/workflows/{workflow}/executions/{execution}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Execution> CancelExecutionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            CancelExecutionAsync(new CancelExecutionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels an execution of the given name.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the execution to be cancelled.
        /// Format:
        /// projects/{project}/locations/{location}/workflows/{workflow}/executions/{execution}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Execution> CancelExecutionAsync(string name, st::CancellationToken cancellationToken) =>
            CancelExecutionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels an execution of the given name.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the execution to be cancelled.
        /// Format:
        /// projects/{project}/locations/{location}/workflows/{workflow}/executions/{execution}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Execution CancelExecution(ExecutionName name, gaxgrpc::CallSettings callSettings = null) =>
            CancelExecution(new CancelExecutionRequest
            {
                ExecutionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels an execution of the given name.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the execution to be cancelled.
        /// Format:
        /// projects/{project}/locations/{location}/workflows/{workflow}/executions/{execution}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Execution> CancelExecutionAsync(ExecutionName name, gaxgrpc::CallSettings callSettings = null) =>
            CancelExecutionAsync(new CancelExecutionRequest
            {
                ExecutionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels an execution of the given name.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the execution to be cancelled.
        /// Format:
        /// projects/{project}/locations/{location}/workflows/{workflow}/executions/{execution}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Execution> CancelExecutionAsync(ExecutionName name, st::CancellationToken cancellationToken) =>
            CancelExecutionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Executions client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Executions is used to start and manage running instances of
    /// [Workflows][google.cloud.workflows.v1beta.Workflow] called executions.
    /// </remarks>
    public sealed partial class ExecutionsClientImpl : ExecutionsClient
    {
        private readonly gaxgrpc::ApiCall<ListExecutionsRequest, ListExecutionsResponse> _callListExecutions;

        private readonly gaxgrpc::ApiCall<CreateExecutionRequest, Execution> _callCreateExecution;

        private readonly gaxgrpc::ApiCall<GetExecutionRequest, Execution> _callGetExecution;

        private readonly gaxgrpc::ApiCall<CancelExecutionRequest, Execution> _callCancelExecution;

        /// <summary>
        /// Constructs a client wrapper for the Executions service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ExecutionsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ExecutionsClientImpl(Executions.ExecutionsClient grpcClient, ExecutionsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ExecutionsSettings effectiveSettings = settings ?? ExecutionsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callListExecutions = clientHelper.BuildApiCall<ListExecutionsRequest, ListExecutionsResponse>("ListExecutions", grpcClient.ListExecutionsAsync, grpcClient.ListExecutions, effectiveSettings.ListExecutionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListExecutions);
            Modify_ListExecutionsApiCall(ref _callListExecutions);
            _callCreateExecution = clientHelper.BuildApiCall<CreateExecutionRequest, Execution>("CreateExecution", grpcClient.CreateExecutionAsync, grpcClient.CreateExecution, effectiveSettings.CreateExecutionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateExecution);
            Modify_CreateExecutionApiCall(ref _callCreateExecution);
            _callGetExecution = clientHelper.BuildApiCall<GetExecutionRequest, Execution>("GetExecution", grpcClient.GetExecutionAsync, grpcClient.GetExecution, effectiveSettings.GetExecutionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetExecution);
            Modify_GetExecutionApiCall(ref _callGetExecution);
            _callCancelExecution = clientHelper.BuildApiCall<CancelExecutionRequest, Execution>("CancelExecution", grpcClient.CancelExecutionAsync, grpcClient.CancelExecution, effectiveSettings.CancelExecutionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCancelExecution);
            Modify_CancelExecutionApiCall(ref _callCancelExecution);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListExecutionsApiCall(ref gaxgrpc::ApiCall<ListExecutionsRequest, ListExecutionsResponse> call);

        partial void Modify_CreateExecutionApiCall(ref gaxgrpc::ApiCall<CreateExecutionRequest, Execution> call);

        partial void Modify_GetExecutionApiCall(ref gaxgrpc::ApiCall<GetExecutionRequest, Execution> call);

        partial void Modify_CancelExecutionApiCall(ref gaxgrpc::ApiCall<CancelExecutionRequest, Execution> call);

        partial void OnConstruction(Executions.ExecutionsClient grpcClient, ExecutionsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Executions client</summary>
        public override Executions.ExecutionsClient GrpcClient { get; }

        partial void Modify_ListExecutionsRequest(ref ListExecutionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateExecutionRequest(ref CreateExecutionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetExecutionRequest(ref GetExecutionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CancelExecutionRequest(ref CancelExecutionRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns a list of executions which belong to the workflow with
        /// the given name. The method returns executions of all workflow
        /// revisions. Returned executions are ordered by their start time (newest
        /// first).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Execution"/> resources.</returns>
        public override gax::PagedEnumerable<ListExecutionsResponse, Execution> ListExecutions(ListExecutionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListExecutionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListExecutionsRequest, ListExecutionsResponse, Execution>(_callListExecutions, request, callSettings);
        }

        /// <summary>
        /// Returns a list of executions which belong to the workflow with
        /// the given name. The method returns executions of all workflow
        /// revisions. Returned executions are ordered by their start time (newest
        /// first).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Execution"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListExecutionsResponse, Execution> ListExecutionsAsync(ListExecutionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListExecutionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListExecutionsRequest, ListExecutionsResponse, Execution>(_callListExecutions, request, callSettings);
        }

        /// <summary>
        /// Creates a new execution using the latest revision of the given workflow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Execution CreateExecution(CreateExecutionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateExecutionRequest(ref request, ref callSettings);
            return _callCreateExecution.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new execution using the latest revision of the given workflow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Execution> CreateExecutionAsync(CreateExecutionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateExecutionRequest(ref request, ref callSettings);
            return _callCreateExecution.Async(request, callSettings);
        }

        /// <summary>
        /// Returns an execution of the given name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Execution GetExecution(GetExecutionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetExecutionRequest(ref request, ref callSettings);
            return _callGetExecution.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns an execution of the given name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Execution> GetExecutionAsync(GetExecutionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetExecutionRequest(ref request, ref callSettings);
            return _callGetExecution.Async(request, callSettings);
        }

        /// <summary>
        /// Cancels an execution of the given name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Execution CancelExecution(CancelExecutionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelExecutionRequest(ref request, ref callSettings);
            return _callCancelExecution.Sync(request, callSettings);
        }

        /// <summary>
        /// Cancels an execution of the given name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Execution> CancelExecutionAsync(CancelExecutionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelExecutionRequest(ref request, ref callSettings);
            return _callCancelExecution.Async(request, callSettings);
        }
    }

    public partial class ListExecutionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListExecutionsResponse : gaxgrpc::IPageResponse<Execution>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Execution> GetEnumerator() => Executions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
