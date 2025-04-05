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
using gcl = Google.Cloud.Location;
using gcwcv = Google.Cloud.Workflows.Common.V1Beta;
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
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Workflows.V1Beta
{
    /// <summary>Settings for <see cref="WorkflowsClient"/> instances.</summary>
    public sealed partial class WorkflowsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="WorkflowsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="WorkflowsSettings"/>.</returns>
        public static WorkflowsSettings GetDefault() => new WorkflowsSettings();

        /// <summary>Constructs a new <see cref="WorkflowsSettings"/> object with default settings.</summary>
        public WorkflowsSettings()
        {
        }

        private WorkflowsSettings(WorkflowsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListWorkflowsSettings = existing.ListWorkflowsSettings;
            GetWorkflowSettings = existing.GetWorkflowSettings;
            CreateWorkflowSettings = existing.CreateWorkflowSettings;
            CreateWorkflowOperationsSettings = existing.CreateWorkflowOperationsSettings.Clone();
            DeleteWorkflowSettings = existing.DeleteWorkflowSettings;
            DeleteWorkflowOperationsSettings = existing.DeleteWorkflowOperationsSettings.Clone();
            UpdateWorkflowSettings = existing.UpdateWorkflowSettings;
            UpdateWorkflowOperationsSettings = existing.UpdateWorkflowOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(WorkflowsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkflowsClient.ListWorkflows</c> and <c>WorkflowsClient.ListWorkflowsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListWorkflowsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>WorkflowsClient.GetWorkflow</c>
        ///  and <c>WorkflowsClient.GetWorkflowAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetWorkflowSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkflowsClient.CreateWorkflow</c> and <c>WorkflowsClient.CreateWorkflowAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateWorkflowSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>WorkflowsClient.CreateWorkflow</c> and
        /// <c>WorkflowsClient.CreateWorkflowAsync</c>.
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
        public lro::OperationsSettings CreateWorkflowOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkflowsClient.DeleteWorkflow</c> and <c>WorkflowsClient.DeleteWorkflowAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteWorkflowSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>WorkflowsClient.DeleteWorkflow</c> and
        /// <c>WorkflowsClient.DeleteWorkflowAsync</c>.
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
        public lro::OperationsSettings DeleteWorkflowOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkflowsClient.UpdateWorkflow</c> and <c>WorkflowsClient.UpdateWorkflowAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateWorkflowSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>WorkflowsClient.UpdateWorkflow</c> and
        /// <c>WorkflowsClient.UpdateWorkflowAsync</c>.
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
        public lro::OperationsSettings UpdateWorkflowOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="WorkflowsSettings"/> object.</returns>
        public WorkflowsSettings Clone() => new WorkflowsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="WorkflowsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class WorkflowsClientBuilder : gaxgrpc::ClientBuilderBase<WorkflowsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public WorkflowsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public WorkflowsClientBuilder() : base(WorkflowsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref WorkflowsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<WorkflowsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override WorkflowsClient Build()
        {
            WorkflowsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<WorkflowsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<WorkflowsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private WorkflowsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return WorkflowsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<WorkflowsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return WorkflowsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => WorkflowsClient.ChannelPool;
    }

    /// <summary>Workflows client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Workflows is used to deploy and execute workflow programs.
    /// Workflows makes sure the program executes reliably, despite hardware and
    /// networking interruptions.
    /// </remarks>
    public abstract partial class WorkflowsClient
    {
        /// <summary>
        /// The default endpoint for the Workflows service, which is a host of "workflows.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "workflows.googleapis.com:443";

        /// <summary>The default Workflows scopes.</summary>
        /// <remarks>
        /// The default Workflows scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Workflows.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="WorkflowsClient"/> using the default credentials, endpoint and settings.
        /// To specify custom credentials or other settings, use <see cref="WorkflowsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="WorkflowsClient"/>.</returns>
        public static stt::Task<WorkflowsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new WorkflowsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="WorkflowsClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="WorkflowsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="WorkflowsClient"/>.</returns>
        public static WorkflowsClient Create() => new WorkflowsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="WorkflowsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="WorkflowsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="WorkflowsClient"/>.</returns>
        internal static WorkflowsClient Create(grpccore::CallInvoker callInvoker, WorkflowsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Workflows.WorkflowsClient grpcClient = new Workflows.WorkflowsClient(callInvoker);
            return new WorkflowsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Workflows client</summary>
        public virtual Workflows.WorkflowsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Workflows in a given project and location.
        /// The default order is not specified.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Workflow"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWorkflowsResponse, Workflow> ListWorkflows(ListWorkflowsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Workflows in a given project and location.
        /// The default order is not specified.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Workflow"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkflowsResponse, Workflow> ListWorkflowsAsync(ListWorkflowsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Workflows in a given project and location.
        /// The default order is not specified.
        /// </summary>
        /// <param name="parent">
        /// Required. Project and location from which the workflows should be listed.
        /// Format: projects/{project}/locations/{location}
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
        /// <returns>A pageable sequence of <see cref="Workflow"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWorkflowsResponse, Workflow> ListWorkflows(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkflowsRequest request = new ListWorkflowsRequest
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
            return ListWorkflows(request, callSettings);
        }

        /// <summary>
        /// Lists Workflows in a given project and location.
        /// The default order is not specified.
        /// </summary>
        /// <param name="parent">
        /// Required. Project and location from which the workflows should be listed.
        /// Format: projects/{project}/locations/{location}
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
        /// <returns>A pageable asynchronous sequence of <see cref="Workflow"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkflowsResponse, Workflow> ListWorkflowsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkflowsRequest request = new ListWorkflowsRequest
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
            return ListWorkflowsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Workflows in a given project and location.
        /// The default order is not specified.
        /// </summary>
        /// <param name="parent">
        /// Required. Project and location from which the workflows should be listed.
        /// Format: projects/{project}/locations/{location}
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
        /// <returns>A pageable sequence of <see cref="Workflow"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWorkflowsResponse, Workflow> ListWorkflows(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkflowsRequest request = new ListWorkflowsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListWorkflows(request, callSettings);
        }

        /// <summary>
        /// Lists Workflows in a given project and location.
        /// The default order is not specified.
        /// </summary>
        /// <param name="parent">
        /// Required. Project and location from which the workflows should be listed.
        /// Format: projects/{project}/locations/{location}
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
        /// <returns>A pageable asynchronous sequence of <see cref="Workflow"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkflowsResponse, Workflow> ListWorkflowsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkflowsRequest request = new ListWorkflowsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListWorkflowsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Workflow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Workflow GetWorkflow(GetWorkflowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Workflow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workflow> GetWorkflowAsync(GetWorkflowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Workflow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workflow> GetWorkflowAsync(GetWorkflowRequest request, st::CancellationToken cancellationToken) =>
            GetWorkflowAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Workflow.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the workflow which information should be retrieved.
        /// Format: projects/{project}/locations/{location}/workflows/{workflow}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Workflow GetWorkflow(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkflow(new GetWorkflowRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Workflow.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the workflow which information should be retrieved.
        /// Format: projects/{project}/locations/{location}/workflows/{workflow}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workflow> GetWorkflowAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkflowAsync(new GetWorkflowRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Workflow.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the workflow which information should be retrieved.
        /// Format: projects/{project}/locations/{location}/workflows/{workflow}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workflow> GetWorkflowAsync(string name, st::CancellationToken cancellationToken) =>
            GetWorkflowAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Workflow.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the workflow which information should be retrieved.
        /// Format: projects/{project}/locations/{location}/workflows/{workflow}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Workflow GetWorkflow(gcwcv::WorkflowName name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkflow(new GetWorkflowRequest
            {
                WorkflowName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Workflow.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the workflow which information should be retrieved.
        /// Format: projects/{project}/locations/{location}/workflows/{workflow}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workflow> GetWorkflowAsync(gcwcv::WorkflowName name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkflowAsync(new GetWorkflowRequest
            {
                WorkflowName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Workflow.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the workflow which information should be retrieved.
        /// Format: projects/{project}/locations/{location}/workflows/{workflow}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workflow> GetWorkflowAsync(gcwcv::WorkflowName name, st::CancellationToken cancellationToken) =>
            GetWorkflowAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new workflow. If a workflow with the specified name already
        /// exists in the specified project and location, the long running operation
        /// will return [ALREADY_EXISTS][google.rpc.Code.ALREADY_EXISTS] error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Workflow, OperationMetadata> CreateWorkflow(CreateWorkflowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new workflow. If a workflow with the specified name already
        /// exists in the specified project and location, the long running operation
        /// will return [ALREADY_EXISTS][google.rpc.Code.ALREADY_EXISTS] error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workflow, OperationMetadata>> CreateWorkflowAsync(CreateWorkflowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new workflow. If a workflow with the specified name already
        /// exists in the specified project and location, the long running operation
        /// will return [ALREADY_EXISTS][google.rpc.Code.ALREADY_EXISTS] error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workflow, OperationMetadata>> CreateWorkflowAsync(CreateWorkflowRequest request, st::CancellationToken cancellationToken) =>
            CreateWorkflowAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateWorkflow</c>.</summary>
        public virtual lro::OperationsClient CreateWorkflowOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateWorkflow</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Workflow, OperationMetadata> PollOnceCreateWorkflow(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Workflow, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateWorkflowOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateWorkflow</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Workflow, OperationMetadata>> PollOnceCreateWorkflowAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Workflow, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateWorkflowOperationsClient, callSettings);

        /// <summary>
        /// Creates a new workflow. If a workflow with the specified name already
        /// exists in the specified project and location, the long running operation
        /// will return [ALREADY_EXISTS][google.rpc.Code.ALREADY_EXISTS] error.
        /// </summary>
        /// <param name="parent">
        /// Required. Project and location in which the workflow should be created.
        /// Format:  projects/{project}/locations/{location}
        /// </param>
        /// <param name="workflow">
        /// Required. Workflow to be created.
        /// </param>
        /// <param name="workflowId">
        /// Required. The ID of the workflow to be created. It has to fulfill the
        /// following requirements:
        /// 
        /// * Must contain only letters, numbers, underscores and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-64 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the customer project and location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Workflow, OperationMetadata> CreateWorkflow(string parent, Workflow workflow, string workflowId, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkflow(new CreateWorkflowRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Workflow = gax::GaxPreconditions.CheckNotNull(workflow, nameof(workflow)),
                WorkflowId = gax::GaxPreconditions.CheckNotNullOrEmpty(workflowId, nameof(workflowId)),
            }, callSettings);

        /// <summary>
        /// Creates a new workflow. If a workflow with the specified name already
        /// exists in the specified project and location, the long running operation
        /// will return [ALREADY_EXISTS][google.rpc.Code.ALREADY_EXISTS] error.
        /// </summary>
        /// <param name="parent">
        /// Required. Project and location in which the workflow should be created.
        /// Format:  projects/{project}/locations/{location}
        /// </param>
        /// <param name="workflow">
        /// Required. Workflow to be created.
        /// </param>
        /// <param name="workflowId">
        /// Required. The ID of the workflow to be created. It has to fulfill the
        /// following requirements:
        /// 
        /// * Must contain only letters, numbers, underscores and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-64 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the customer project and location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workflow, OperationMetadata>> CreateWorkflowAsync(string parent, Workflow workflow, string workflowId, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkflowAsync(new CreateWorkflowRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Workflow = gax::GaxPreconditions.CheckNotNull(workflow, nameof(workflow)),
                WorkflowId = gax::GaxPreconditions.CheckNotNullOrEmpty(workflowId, nameof(workflowId)),
            }, callSettings);

        /// <summary>
        /// Creates a new workflow. If a workflow with the specified name already
        /// exists in the specified project and location, the long running operation
        /// will return [ALREADY_EXISTS][google.rpc.Code.ALREADY_EXISTS] error.
        /// </summary>
        /// <param name="parent">
        /// Required. Project and location in which the workflow should be created.
        /// Format:  projects/{project}/locations/{location}
        /// </param>
        /// <param name="workflow">
        /// Required. Workflow to be created.
        /// </param>
        /// <param name="workflowId">
        /// Required. The ID of the workflow to be created. It has to fulfill the
        /// following requirements:
        /// 
        /// * Must contain only letters, numbers, underscores and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-64 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the customer project and location.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workflow, OperationMetadata>> CreateWorkflowAsync(string parent, Workflow workflow, string workflowId, st::CancellationToken cancellationToken) =>
            CreateWorkflowAsync(parent, workflow, workflowId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new workflow. If a workflow with the specified name already
        /// exists in the specified project and location, the long running operation
        /// will return [ALREADY_EXISTS][google.rpc.Code.ALREADY_EXISTS] error.
        /// </summary>
        /// <param name="parent">
        /// Required. Project and location in which the workflow should be created.
        /// Format:  projects/{project}/locations/{location}
        /// </param>
        /// <param name="workflow">
        /// Required. Workflow to be created.
        /// </param>
        /// <param name="workflowId">
        /// Required. The ID of the workflow to be created. It has to fulfill the
        /// following requirements:
        /// 
        /// * Must contain only letters, numbers, underscores and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-64 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the customer project and location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Workflow, OperationMetadata> CreateWorkflow(gagr::LocationName parent, Workflow workflow, string workflowId, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkflow(new CreateWorkflowRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Workflow = gax::GaxPreconditions.CheckNotNull(workflow, nameof(workflow)),
                WorkflowId = gax::GaxPreconditions.CheckNotNullOrEmpty(workflowId, nameof(workflowId)),
            }, callSettings);

        /// <summary>
        /// Creates a new workflow. If a workflow with the specified name already
        /// exists in the specified project and location, the long running operation
        /// will return [ALREADY_EXISTS][google.rpc.Code.ALREADY_EXISTS] error.
        /// </summary>
        /// <param name="parent">
        /// Required. Project and location in which the workflow should be created.
        /// Format:  projects/{project}/locations/{location}
        /// </param>
        /// <param name="workflow">
        /// Required. Workflow to be created.
        /// </param>
        /// <param name="workflowId">
        /// Required. The ID of the workflow to be created. It has to fulfill the
        /// following requirements:
        /// 
        /// * Must contain only letters, numbers, underscores and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-64 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the customer project and location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workflow, OperationMetadata>> CreateWorkflowAsync(gagr::LocationName parent, Workflow workflow, string workflowId, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkflowAsync(new CreateWorkflowRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Workflow = gax::GaxPreconditions.CheckNotNull(workflow, nameof(workflow)),
                WorkflowId = gax::GaxPreconditions.CheckNotNullOrEmpty(workflowId, nameof(workflowId)),
            }, callSettings);

        /// <summary>
        /// Creates a new workflow. If a workflow with the specified name already
        /// exists in the specified project and location, the long running operation
        /// will return [ALREADY_EXISTS][google.rpc.Code.ALREADY_EXISTS] error.
        /// </summary>
        /// <param name="parent">
        /// Required. Project and location in which the workflow should be created.
        /// Format:  projects/{project}/locations/{location}
        /// </param>
        /// <param name="workflow">
        /// Required. Workflow to be created.
        /// </param>
        /// <param name="workflowId">
        /// Required. The ID of the workflow to be created. It has to fulfill the
        /// following requirements:
        /// 
        /// * Must contain only letters, numbers, underscores and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-64 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the customer project and location.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workflow, OperationMetadata>> CreateWorkflowAsync(gagr::LocationName parent, Workflow workflow, string workflowId, st::CancellationToken cancellationToken) =>
            CreateWorkflowAsync(parent, workflow, workflowId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a workflow with the specified name.
        /// This method also cancels and deletes all running executions of the
        /// workflow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteWorkflow(DeleteWorkflowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a workflow with the specified name.
        /// This method also cancels and deletes all running executions of the
        /// workflow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteWorkflowAsync(DeleteWorkflowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a workflow with the specified name.
        /// This method also cancels and deletes all running executions of the
        /// workflow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteWorkflowAsync(DeleteWorkflowRequest request, st::CancellationToken cancellationToken) =>
            DeleteWorkflowAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteWorkflow</c>.</summary>
        public virtual lro::OperationsClient DeleteWorkflowOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteWorkflow</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteWorkflow(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteWorkflowOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteWorkflow</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteWorkflowAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteWorkflowOperationsClient, callSettings);

        /// <summary>
        /// Deletes a workflow with the specified name.
        /// This method also cancels and deletes all running executions of the
        /// workflow.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the workflow to be deleted.
        /// Format: projects/{project}/locations/{location}/workflows/{workflow}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteWorkflow(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkflow(new DeleteWorkflowRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a workflow with the specified name.
        /// This method also cancels and deletes all running executions of the
        /// workflow.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the workflow to be deleted.
        /// Format: projects/{project}/locations/{location}/workflows/{workflow}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteWorkflowAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkflowAsync(new DeleteWorkflowRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a workflow with the specified name.
        /// This method also cancels and deletes all running executions of the
        /// workflow.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the workflow to be deleted.
        /// Format: projects/{project}/locations/{location}/workflows/{workflow}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteWorkflowAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteWorkflowAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a workflow with the specified name.
        /// This method also cancels and deletes all running executions of the
        /// workflow.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the workflow to be deleted.
        /// Format: projects/{project}/locations/{location}/workflows/{workflow}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteWorkflow(gcwcv::WorkflowName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkflow(new DeleteWorkflowRequest
            {
                WorkflowName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a workflow with the specified name.
        /// This method also cancels and deletes all running executions of the
        /// workflow.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the workflow to be deleted.
        /// Format: projects/{project}/locations/{location}/workflows/{workflow}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteWorkflowAsync(gcwcv::WorkflowName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkflowAsync(new DeleteWorkflowRequest
            {
                WorkflowName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a workflow with the specified name.
        /// This method also cancels and deletes all running executions of the
        /// workflow.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the workflow to be deleted.
        /// Format: projects/{project}/locations/{location}/workflows/{workflow}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteWorkflowAsync(gcwcv::WorkflowName name, st::CancellationToken cancellationToken) =>
            DeleteWorkflowAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing workflow.
        /// Running this method has no impact on already running executions of the
        /// workflow. A new revision of the workflow may be created as a result of a
        /// successful update operation. In that case, such revision will be used
        /// in new workflow executions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Workflow, OperationMetadata> UpdateWorkflow(UpdateWorkflowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing workflow.
        /// Running this method has no impact on already running executions of the
        /// workflow. A new revision of the workflow may be created as a result of a
        /// successful update operation. In that case, such revision will be used
        /// in new workflow executions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workflow, OperationMetadata>> UpdateWorkflowAsync(UpdateWorkflowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing workflow.
        /// Running this method has no impact on already running executions of the
        /// workflow. A new revision of the workflow may be created as a result of a
        /// successful update operation. In that case, such revision will be used
        /// in new workflow executions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workflow, OperationMetadata>> UpdateWorkflowAsync(UpdateWorkflowRequest request, st::CancellationToken cancellationToken) =>
            UpdateWorkflowAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateWorkflow</c>.</summary>
        public virtual lro::OperationsClient UpdateWorkflowOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateWorkflow</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Workflow, OperationMetadata> PollOnceUpdateWorkflow(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Workflow, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateWorkflowOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateWorkflow</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Workflow, OperationMetadata>> PollOnceUpdateWorkflowAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Workflow, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateWorkflowOperationsClient, callSettings);

        /// <summary>
        /// Updates an existing workflow.
        /// Running this method has no impact on already running executions of the
        /// workflow. A new revision of the workflow may be created as a result of a
        /// successful update operation. In that case, such revision will be used
        /// in new workflow executions.
        /// </summary>
        /// <param name="workflow">
        /// Required. Workflow to be updated.
        /// </param>
        /// <param name="updateMask">
        /// List of fields to be updated. If not present, the entire workflow
        /// will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Workflow, OperationMetadata> UpdateWorkflow(Workflow workflow, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateWorkflow(new UpdateWorkflowRequest
            {
                Workflow = gax::GaxPreconditions.CheckNotNull(workflow, nameof(workflow)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an existing workflow.
        /// Running this method has no impact on already running executions of the
        /// workflow. A new revision of the workflow may be created as a result of a
        /// successful update operation. In that case, such revision will be used
        /// in new workflow executions.
        /// </summary>
        /// <param name="workflow">
        /// Required. Workflow to be updated.
        /// </param>
        /// <param name="updateMask">
        /// List of fields to be updated. If not present, the entire workflow
        /// will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workflow, OperationMetadata>> UpdateWorkflowAsync(Workflow workflow, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateWorkflowAsync(new UpdateWorkflowRequest
            {
                Workflow = gax::GaxPreconditions.CheckNotNull(workflow, nameof(workflow)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an existing workflow.
        /// Running this method has no impact on already running executions of the
        /// workflow. A new revision of the workflow may be created as a result of a
        /// successful update operation. In that case, such revision will be used
        /// in new workflow executions.
        /// </summary>
        /// <param name="workflow">
        /// Required. Workflow to be updated.
        /// </param>
        /// <param name="updateMask">
        /// List of fields to be updated. If not present, the entire workflow
        /// will be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Workflow, OperationMetadata>> UpdateWorkflowAsync(Workflow workflow, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateWorkflowAsync(workflow, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Workflows client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Workflows is used to deploy and execute workflow programs.
    /// Workflows makes sure the program executes reliably, despite hardware and
    /// networking interruptions.
    /// </remarks>
    public sealed partial class WorkflowsClientImpl : WorkflowsClient
    {
        private readonly gaxgrpc::ApiCall<ListWorkflowsRequest, ListWorkflowsResponse> _callListWorkflows;

        private readonly gaxgrpc::ApiCall<GetWorkflowRequest, Workflow> _callGetWorkflow;

        private readonly gaxgrpc::ApiCall<CreateWorkflowRequest, lro::Operation> _callCreateWorkflow;

        private readonly gaxgrpc::ApiCall<DeleteWorkflowRequest, lro::Operation> _callDeleteWorkflow;

        private readonly gaxgrpc::ApiCall<UpdateWorkflowRequest, lro::Operation> _callUpdateWorkflow;

        /// <summary>
        /// Constructs a client wrapper for the Workflows service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="WorkflowsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public WorkflowsClientImpl(Workflows.WorkflowsClient grpcClient, WorkflowsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            WorkflowsSettings effectiveSettings = settings ?? WorkflowsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateWorkflowOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateWorkflowOperationsSettings, logger);
            DeleteWorkflowOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteWorkflowOperationsSettings, logger);
            UpdateWorkflowOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateWorkflowOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListWorkflows = clientHelper.BuildApiCall<ListWorkflowsRequest, ListWorkflowsResponse>("ListWorkflows", grpcClient.ListWorkflowsAsync, grpcClient.ListWorkflows, effectiveSettings.ListWorkflowsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListWorkflows);
            Modify_ListWorkflowsApiCall(ref _callListWorkflows);
            _callGetWorkflow = clientHelper.BuildApiCall<GetWorkflowRequest, Workflow>("GetWorkflow", grpcClient.GetWorkflowAsync, grpcClient.GetWorkflow, effectiveSettings.GetWorkflowSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetWorkflow);
            Modify_GetWorkflowApiCall(ref _callGetWorkflow);
            _callCreateWorkflow = clientHelper.BuildApiCall<CreateWorkflowRequest, lro::Operation>("CreateWorkflow", grpcClient.CreateWorkflowAsync, grpcClient.CreateWorkflow, effectiveSettings.CreateWorkflowSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateWorkflow);
            Modify_CreateWorkflowApiCall(ref _callCreateWorkflow);
            _callDeleteWorkflow = clientHelper.BuildApiCall<DeleteWorkflowRequest, lro::Operation>("DeleteWorkflow", grpcClient.DeleteWorkflowAsync, grpcClient.DeleteWorkflow, effectiveSettings.DeleteWorkflowSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteWorkflow);
            Modify_DeleteWorkflowApiCall(ref _callDeleteWorkflow);
            _callUpdateWorkflow = clientHelper.BuildApiCall<UpdateWorkflowRequest, lro::Operation>("UpdateWorkflow", grpcClient.UpdateWorkflowAsync, grpcClient.UpdateWorkflow, effectiveSettings.UpdateWorkflowSettings).WithGoogleRequestParam("workflow.name", request => request.Workflow?.Name);
            Modify_ApiCall(ref _callUpdateWorkflow);
            Modify_UpdateWorkflowApiCall(ref _callUpdateWorkflow);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListWorkflowsApiCall(ref gaxgrpc::ApiCall<ListWorkflowsRequest, ListWorkflowsResponse> call);

        partial void Modify_GetWorkflowApiCall(ref gaxgrpc::ApiCall<GetWorkflowRequest, Workflow> call);

        partial void Modify_CreateWorkflowApiCall(ref gaxgrpc::ApiCall<CreateWorkflowRequest, lro::Operation> call);

        partial void Modify_DeleteWorkflowApiCall(ref gaxgrpc::ApiCall<DeleteWorkflowRequest, lro::Operation> call);

        partial void Modify_UpdateWorkflowApiCall(ref gaxgrpc::ApiCall<UpdateWorkflowRequest, lro::Operation> call);

        partial void OnConstruction(Workflows.WorkflowsClient grpcClient, WorkflowsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Workflows client</summary>
        public override Workflows.WorkflowsClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListWorkflowsRequest(ref ListWorkflowsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetWorkflowRequest(ref GetWorkflowRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateWorkflowRequest(ref CreateWorkflowRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteWorkflowRequest(ref DeleteWorkflowRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateWorkflowRequest(ref UpdateWorkflowRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists Workflows in a given project and location.
        /// The default order is not specified.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Workflow"/> resources.</returns>
        public override gax::PagedEnumerable<ListWorkflowsResponse, Workflow> ListWorkflows(ListWorkflowsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListWorkflowsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListWorkflowsRequest, ListWorkflowsResponse, Workflow>(_callListWorkflows, request, callSettings);
        }

        /// <summary>
        /// Lists Workflows in a given project and location.
        /// The default order is not specified.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Workflow"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListWorkflowsResponse, Workflow> ListWorkflowsAsync(ListWorkflowsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListWorkflowsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListWorkflowsRequest, ListWorkflowsResponse, Workflow>(_callListWorkflows, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Workflow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Workflow GetWorkflow(GetWorkflowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetWorkflowRequest(ref request, ref callSettings);
            return _callGetWorkflow.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Workflow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Workflow> GetWorkflowAsync(GetWorkflowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetWorkflowRequest(ref request, ref callSettings);
            return _callGetWorkflow.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateWorkflow</c>.</summary>
        public override lro::OperationsClient CreateWorkflowOperationsClient { get; }

        /// <summary>
        /// Creates a new workflow. If a workflow with the specified name already
        /// exists in the specified project and location, the long running operation
        /// will return [ALREADY_EXISTS][google.rpc.Code.ALREADY_EXISTS] error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Workflow, OperationMetadata> CreateWorkflow(CreateWorkflowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateWorkflowRequest(ref request, ref callSettings);
            return new lro::Operation<Workflow, OperationMetadata>(_callCreateWorkflow.Sync(request, callSettings), CreateWorkflowOperationsClient);
        }

        /// <summary>
        /// Creates a new workflow. If a workflow with the specified name already
        /// exists in the specified project and location, the long running operation
        /// will return [ALREADY_EXISTS][google.rpc.Code.ALREADY_EXISTS] error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Workflow, OperationMetadata>> CreateWorkflowAsync(CreateWorkflowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateWorkflowRequest(ref request, ref callSettings);
            return new lro::Operation<Workflow, OperationMetadata>(await _callCreateWorkflow.Async(request, callSettings).ConfigureAwait(false), CreateWorkflowOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteWorkflow</c>.</summary>
        public override lro::OperationsClient DeleteWorkflowOperationsClient { get; }

        /// <summary>
        /// Deletes a workflow with the specified name.
        /// This method also cancels and deletes all running executions of the
        /// workflow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteWorkflow(DeleteWorkflowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteWorkflowRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteWorkflow.Sync(request, callSettings), DeleteWorkflowOperationsClient);
        }

        /// <summary>
        /// Deletes a workflow with the specified name.
        /// This method also cancels and deletes all running executions of the
        /// workflow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteWorkflowAsync(DeleteWorkflowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteWorkflowRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteWorkflow.Async(request, callSettings).ConfigureAwait(false), DeleteWorkflowOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateWorkflow</c>.</summary>
        public override lro::OperationsClient UpdateWorkflowOperationsClient { get; }

        /// <summary>
        /// Updates an existing workflow.
        /// Running this method has no impact on already running executions of the
        /// workflow. A new revision of the workflow may be created as a result of a
        /// successful update operation. In that case, such revision will be used
        /// in new workflow executions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Workflow, OperationMetadata> UpdateWorkflow(UpdateWorkflowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateWorkflowRequest(ref request, ref callSettings);
            return new lro::Operation<Workflow, OperationMetadata>(_callUpdateWorkflow.Sync(request, callSettings), UpdateWorkflowOperationsClient);
        }

        /// <summary>
        /// Updates an existing workflow.
        /// Running this method has no impact on already running executions of the
        /// workflow. A new revision of the workflow may be created as a result of a
        /// successful update operation. In that case, such revision will be used
        /// in new workflow executions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Workflow, OperationMetadata>> UpdateWorkflowAsync(UpdateWorkflowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateWorkflowRequest(ref request, ref callSettings);
            return new lro::Operation<Workflow, OperationMetadata>(await _callUpdateWorkflow.Async(request, callSettings).ConfigureAwait(false), UpdateWorkflowOperationsClient);
        }
    }

    public partial class ListWorkflowsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListWorkflowsResponse : gaxgrpc::IPageResponse<Workflow>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Workflow> GetEnumerator() => Workflows.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Workflows
    {
        public partial class WorkflowsClient
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

    public static partial class Workflows
    {
        public partial class WorkflowsClient
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
