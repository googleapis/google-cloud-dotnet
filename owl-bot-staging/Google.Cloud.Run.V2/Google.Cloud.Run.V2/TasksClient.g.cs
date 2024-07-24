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
using gcl = Google.Cloud.Location;
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

namespace Google.Cloud.Run.V2
{
    /// <summary>Settings for <see cref="TasksClient"/> instances.</summary>
    public sealed partial class TasksSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="TasksSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="TasksSettings"/>.</returns>
        public static TasksSettings GetDefault() => new TasksSettings();

        /// <summary>Constructs a new <see cref="TasksSettings"/> object with default settings.</summary>
        public TasksSettings()
        {
        }

        private TasksSettings(TasksSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetTaskSettings = existing.GetTaskSettings;
            ListTasksSettings = existing.ListTasksSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(TasksSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>TasksClient.GetTask</c> and
        /// <c>TasksClient.GetTaskAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetTaskSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>TasksClient.ListTasks</c>
        /// and <c>TasksClient.ListTasksAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTasksSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="TasksSettings"/> object.</returns>
        public TasksSettings Clone() => new TasksSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="TasksClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class TasksClientBuilder : gaxgrpc::ClientBuilderBase<TasksClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public TasksSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public TasksClientBuilder() : base(TasksClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref TasksClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<TasksClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override TasksClient Build()
        {
            TasksClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<TasksClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<TasksClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private TasksClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return TasksClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<TasksClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return TasksClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => TasksClient.ChannelPool;
    }

    /// <summary>Tasks client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Cloud Run Task Control Plane API.
    /// </remarks>
    public abstract partial class TasksClient
    {
        /// <summary>
        /// The default endpoint for the Tasks service, which is a host of "run.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "run.googleapis.com:443";

        /// <summary>The default Tasks scopes.</summary>
        /// <remarks>
        /// The default Tasks scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Tasks.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="TasksClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="TasksClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="TasksClient"/>.</returns>
        public static stt::Task<TasksClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new TasksClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="TasksClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="TasksClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="TasksClient"/>.</returns>
        public static TasksClient Create() => new TasksClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="TasksClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="TasksSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="TasksClient"/>.</returns>
        internal static TasksClient Create(grpccore::CallInvoker callInvoker, TasksSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Tasks.TasksClient grpcClient = new Tasks.TasksClient(callInvoker);
            return new TasksClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Tasks client</summary>
        public virtual Tasks.TasksClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about a Task.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Task GetTask(GetTaskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about a Task.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Task> GetTaskAsync(GetTaskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about a Task.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Task> GetTaskAsync(GetTaskRequest request, st::CancellationToken cancellationToken) =>
            GetTaskAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about a Task.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of the Task.
        /// Format:
        /// projects/{project}/locations/{location}/jobs/{job}/executions/{execution}/tasks/{task}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Task GetTask(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTask(new GetTaskRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a Task.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of the Task.
        /// Format:
        /// projects/{project}/locations/{location}/jobs/{job}/executions/{execution}/tasks/{task}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Task> GetTaskAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTaskAsync(new GetTaskRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a Task.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of the Task.
        /// Format:
        /// projects/{project}/locations/{location}/jobs/{job}/executions/{execution}/tasks/{task}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Task> GetTaskAsync(string name, st::CancellationToken cancellationToken) =>
            GetTaskAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about a Task.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of the Task.
        /// Format:
        /// projects/{project}/locations/{location}/jobs/{job}/executions/{execution}/tasks/{task}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Task GetTask(TaskName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTask(new GetTaskRequest
            {
                TaskName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a Task.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of the Task.
        /// Format:
        /// projects/{project}/locations/{location}/jobs/{job}/executions/{execution}/tasks/{task}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Task> GetTaskAsync(TaskName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTaskAsync(new GetTaskRequest
            {
                TaskName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a Task.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of the Task.
        /// Format:
        /// projects/{project}/locations/{location}/jobs/{job}/executions/{execution}/tasks/{task}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Task> GetTaskAsync(TaskName name, st::CancellationToken cancellationToken) =>
            GetTaskAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Tasks from an Execution of a Job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Task"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTasksResponse, Task> ListTasks(ListTasksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Tasks from an Execution of a Job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Task"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTasksResponse, Task> ListTasksAsync(ListTasksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Tasks from an Execution of a Job.
        /// </summary>
        /// <param name="parent">
        /// Required. The Execution from which the Tasks should be listed.
        /// To list all Tasks across Executions of a Job, use "-" instead of Execution
        /// name. To list all Tasks across Jobs, use "-" instead of Job name. Format:
        /// projects/{project}/locations/{location}/jobs/{job}/executions/{execution}
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
        /// <returns>A pageable sequence of <see cref="Task"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTasksResponse, Task> ListTasks(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTasksRequest request = new ListTasksRequest
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
            return ListTasks(request, callSettings);
        }

        /// <summary>
        /// Lists Tasks from an Execution of a Job.
        /// </summary>
        /// <param name="parent">
        /// Required. The Execution from which the Tasks should be listed.
        /// To list all Tasks across Executions of a Job, use "-" instead of Execution
        /// name. To list all Tasks across Jobs, use "-" instead of Job name. Format:
        /// projects/{project}/locations/{location}/jobs/{job}/executions/{execution}
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
        /// <returns>A pageable asynchronous sequence of <see cref="Task"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTasksResponse, Task> ListTasksAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTasksRequest request = new ListTasksRequest
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
            return ListTasksAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Tasks from an Execution of a Job.
        /// </summary>
        /// <param name="parent">
        /// Required. The Execution from which the Tasks should be listed.
        /// To list all Tasks across Executions of a Job, use "-" instead of Execution
        /// name. To list all Tasks across Jobs, use "-" instead of Job name. Format:
        /// projects/{project}/locations/{location}/jobs/{job}/executions/{execution}
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
        /// <returns>A pageable sequence of <see cref="Task"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTasksResponse, Task> ListTasks(ExecutionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTasksRequest request = new ListTasksRequest
            {
                ParentAsExecutionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTasks(request, callSettings);
        }

        /// <summary>
        /// Lists Tasks from an Execution of a Job.
        /// </summary>
        /// <param name="parent">
        /// Required. The Execution from which the Tasks should be listed.
        /// To list all Tasks across Executions of a Job, use "-" instead of Execution
        /// name. To list all Tasks across Jobs, use "-" instead of Job name. Format:
        /// projects/{project}/locations/{location}/jobs/{job}/executions/{execution}
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
        /// <returns>A pageable asynchronous sequence of <see cref="Task"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTasksResponse, Task> ListTasksAsync(ExecutionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTasksRequest request = new ListTasksRequest
            {
                ParentAsExecutionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTasksAsync(request, callSettings);
        }
    }

    /// <summary>Tasks client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Cloud Run Task Control Plane API.
    /// </remarks>
    public sealed partial class TasksClientImpl : TasksClient
    {
        private readonly gaxgrpc::ApiCall<GetTaskRequest, Task> _callGetTask;

        private readonly gaxgrpc::ApiCall<ListTasksRequest, ListTasksResponse> _callListTasks;

        /// <summary>
        /// Constructs a client wrapper for the Tasks service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="TasksSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public TasksClientImpl(Tasks.TasksClient grpcClient, TasksSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            TasksSettings effectiveSettings = settings ?? TasksSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callGetTask = clientHelper.BuildApiCall<GetTaskRequest, Task>("GetTask", grpcClient.GetTaskAsync, grpcClient.GetTask, effectiveSettings.GetTaskSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTask);
            Modify_GetTaskApiCall(ref _callGetTask);
            _callListTasks = clientHelper.BuildApiCall<ListTasksRequest, ListTasksResponse>("ListTasks", grpcClient.ListTasksAsync, grpcClient.ListTasks, effectiveSettings.ListTasksSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTasks);
            Modify_ListTasksApiCall(ref _callListTasks);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetTaskApiCall(ref gaxgrpc::ApiCall<GetTaskRequest, Task> call);

        partial void Modify_ListTasksApiCall(ref gaxgrpc::ApiCall<ListTasksRequest, ListTasksResponse> call);

        partial void OnConstruction(Tasks.TasksClient grpcClient, TasksSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Tasks client</summary>
        public override Tasks.TasksClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_GetTaskRequest(ref GetTaskRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTasksRequest(ref ListTasksRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets information about a Task.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Task GetTask(GetTaskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTaskRequest(ref request, ref callSettings);
            return _callGetTask.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets information about a Task.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Task> GetTaskAsync(GetTaskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTaskRequest(ref request, ref callSettings);
            return _callGetTask.Async(request, callSettings);
        }

        /// <summary>
        /// Lists Tasks from an Execution of a Job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Task"/> resources.</returns>
        public override gax::PagedEnumerable<ListTasksResponse, Task> ListTasks(ListTasksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTasksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTasksRequest, ListTasksResponse, Task>(_callListTasks, request, callSettings);
        }

        /// <summary>
        /// Lists Tasks from an Execution of a Job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Task"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTasksResponse, Task> ListTasksAsync(ListTasksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTasksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTasksRequest, ListTasksResponse, Task>(_callListTasks, request, callSettings);
        }
    }

    public partial class ListTasksRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTasksResponse : gaxgrpc::IPageResponse<Task>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Task> GetEnumerator() => Tasks.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Tasks
    {
        public partial class TasksClient
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
