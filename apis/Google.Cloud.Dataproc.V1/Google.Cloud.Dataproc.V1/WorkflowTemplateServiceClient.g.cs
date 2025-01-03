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

namespace Google.Cloud.Dataproc.V1
{
    /// <summary>Settings for <see cref="WorkflowTemplateServiceClient"/> instances.</summary>
    public sealed partial class WorkflowTemplateServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="WorkflowTemplateServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="WorkflowTemplateServiceSettings"/>.</returns>
        public static WorkflowTemplateServiceSettings GetDefault() => new WorkflowTemplateServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="WorkflowTemplateServiceSettings"/> object with default settings.
        /// </summary>
        public WorkflowTemplateServiceSettings()
        {
        }

        private WorkflowTemplateServiceSettings(WorkflowTemplateServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateWorkflowTemplateSettings = existing.CreateWorkflowTemplateSettings;
            GetWorkflowTemplateSettings = existing.GetWorkflowTemplateSettings;
            InstantiateWorkflowTemplateSettings = existing.InstantiateWorkflowTemplateSettings;
            InstantiateWorkflowTemplateOperationsSettings = existing.InstantiateWorkflowTemplateOperationsSettings.Clone();
            InstantiateInlineWorkflowTemplateSettings = existing.InstantiateInlineWorkflowTemplateSettings;
            InstantiateInlineWorkflowTemplateOperationsSettings = existing.InstantiateInlineWorkflowTemplateOperationsSettings.Clone();
            UpdateWorkflowTemplateSettings = existing.UpdateWorkflowTemplateSettings;
            ListWorkflowTemplatesSettings = existing.ListWorkflowTemplatesSettings;
            DeleteWorkflowTemplateSettings = existing.DeleteWorkflowTemplateSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(WorkflowTemplateServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkflowTemplateServiceClient.CreateWorkflowTemplate</c> and
        /// <c>WorkflowTemplateServiceClient.CreateWorkflowTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateWorkflowTemplateSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkflowTemplateServiceClient.GetWorkflowTemplate</c> and
        /// <c>WorkflowTemplateServiceClient.GetWorkflowTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Internal"/>, <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetWorkflowTemplateSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkflowTemplateServiceClient.InstantiateWorkflowTemplate</c> and
        /// <c>WorkflowTemplateServiceClient.InstantiateWorkflowTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings InstantiateWorkflowTemplateSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>WorkflowTemplateServiceClient.InstantiateWorkflowTemplate</c>
        ///  and <c>WorkflowTemplateServiceClient.InstantiateWorkflowTemplateAsync</c>.
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
        public lro::OperationsSettings InstantiateWorkflowTemplateOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkflowTemplateServiceClient.InstantiateInlineWorkflowTemplate</c> and
        /// <c>WorkflowTemplateServiceClient.InstantiateInlineWorkflowTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings InstantiateInlineWorkflowTemplateSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to
        /// <c>WorkflowTemplateServiceClient.InstantiateInlineWorkflowTemplate</c> and
        /// <c>WorkflowTemplateServiceClient.InstantiateInlineWorkflowTemplateAsync</c>.
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
        public lro::OperationsSettings InstantiateInlineWorkflowTemplateOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkflowTemplateServiceClient.UpdateWorkflowTemplate</c> and
        /// <c>WorkflowTemplateServiceClient.UpdateWorkflowTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateWorkflowTemplateSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkflowTemplateServiceClient.ListWorkflowTemplates</c> and
        /// <c>WorkflowTemplateServiceClient.ListWorkflowTemplatesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Internal"/>, <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListWorkflowTemplatesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkflowTemplateServiceClient.DeleteWorkflowTemplate</c> and
        /// <c>WorkflowTemplateServiceClient.DeleteWorkflowTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteWorkflowTemplateSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="WorkflowTemplateServiceSettings"/> object.</returns>
        public WorkflowTemplateServiceSettings Clone() => new WorkflowTemplateServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="WorkflowTemplateServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class WorkflowTemplateServiceClientBuilder : gaxgrpc::ClientBuilderBase<WorkflowTemplateServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public WorkflowTemplateServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public WorkflowTemplateServiceClientBuilder() : base(WorkflowTemplateServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref WorkflowTemplateServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<WorkflowTemplateServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override WorkflowTemplateServiceClient Build()
        {
            WorkflowTemplateServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<WorkflowTemplateServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<WorkflowTemplateServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private WorkflowTemplateServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return WorkflowTemplateServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<WorkflowTemplateServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return WorkflowTemplateServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => WorkflowTemplateServiceClient.ChannelPool;
    }

    /// <summary>WorkflowTemplateService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The API interface for managing Workflow Templates in the
    /// Dataproc API.
    /// </remarks>
    public abstract partial class WorkflowTemplateServiceClient
    {
        /// <summary>
        /// The default endpoint for the WorkflowTemplateService service, which is a host of "dataproc.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dataproc.googleapis.com:443";

        /// <summary>The default WorkflowTemplateService scopes.</summary>
        /// <remarks>
        /// The default WorkflowTemplateService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(WorkflowTemplateService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="WorkflowTemplateServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="WorkflowTemplateServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="WorkflowTemplateServiceClient"/>.</returns>
        public static stt::Task<WorkflowTemplateServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new WorkflowTemplateServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="WorkflowTemplateServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="WorkflowTemplateServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="WorkflowTemplateServiceClient"/>.</returns>
        public static WorkflowTemplateServiceClient Create() => new WorkflowTemplateServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="WorkflowTemplateServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="WorkflowTemplateServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="WorkflowTemplateServiceClient"/>.</returns>
        internal static WorkflowTemplateServiceClient Create(grpccore::CallInvoker callInvoker, WorkflowTemplateServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            WorkflowTemplateService.WorkflowTemplateServiceClient grpcClient = new WorkflowTemplateService.WorkflowTemplateServiceClient(callInvoker);
            return new WorkflowTemplateServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC WorkflowTemplateService client</summary>
        public virtual WorkflowTemplateService.WorkflowTemplateServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates new workflow template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WorkflowTemplate CreateWorkflowTemplate(CreateWorkflowTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates new workflow template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkflowTemplate> CreateWorkflowTemplateAsync(CreateWorkflowTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates new workflow template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkflowTemplate> CreateWorkflowTemplateAsync(CreateWorkflowTemplateRequest request, st::CancellationToken cancellationToken) =>
            CreateWorkflowTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates new workflow template.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.workflowTemplates.create`, the resource name of the
        /// region has the following format:
        /// `projects/{project_id}/regions/{region}`
        /// 
        /// * For `projects.locations.workflowTemplates.create`, the resource name of
        /// the location has the following format:
        /// `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="template">
        /// Required. The Dataproc workflow template to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WorkflowTemplate CreateWorkflowTemplate(string parent, WorkflowTemplate template, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkflowTemplate(new CreateWorkflowTemplateRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Template = gax::GaxPreconditions.CheckNotNull(template, nameof(template)),
            }, callSettings);

        /// <summary>
        /// Creates new workflow template.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.workflowTemplates.create`, the resource name of the
        /// region has the following format:
        /// `projects/{project_id}/regions/{region}`
        /// 
        /// * For `projects.locations.workflowTemplates.create`, the resource name of
        /// the location has the following format:
        /// `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="template">
        /// Required. The Dataproc workflow template to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkflowTemplate> CreateWorkflowTemplateAsync(string parent, WorkflowTemplate template, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkflowTemplateAsync(new CreateWorkflowTemplateRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Template = gax::GaxPreconditions.CheckNotNull(template, nameof(template)),
            }, callSettings);

        /// <summary>
        /// Creates new workflow template.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.workflowTemplates.create`, the resource name of the
        /// region has the following format:
        /// `projects/{project_id}/regions/{region}`
        /// 
        /// * For `projects.locations.workflowTemplates.create`, the resource name of
        /// the location has the following format:
        /// `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="template">
        /// Required. The Dataproc workflow template to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkflowTemplate> CreateWorkflowTemplateAsync(string parent, WorkflowTemplate template, st::CancellationToken cancellationToken) =>
            CreateWorkflowTemplateAsync(parent, template, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates new workflow template.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.workflowTemplates.create`, the resource name of the
        /// region has the following format:
        /// `projects/{project_id}/regions/{region}`
        /// 
        /// * For `projects.locations.workflowTemplates.create`, the resource name of
        /// the location has the following format:
        /// `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="template">
        /// Required. The Dataproc workflow template to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WorkflowTemplate CreateWorkflowTemplate(RegionName parent, WorkflowTemplate template, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkflowTemplate(new CreateWorkflowTemplateRequest
            {
                ParentAsRegionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Template = gax::GaxPreconditions.CheckNotNull(template, nameof(template)),
            }, callSettings);

        /// <summary>
        /// Creates new workflow template.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.workflowTemplates.create`, the resource name of the
        /// region has the following format:
        /// `projects/{project_id}/regions/{region}`
        /// 
        /// * For `projects.locations.workflowTemplates.create`, the resource name of
        /// the location has the following format:
        /// `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="template">
        /// Required. The Dataproc workflow template to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkflowTemplate> CreateWorkflowTemplateAsync(RegionName parent, WorkflowTemplate template, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkflowTemplateAsync(new CreateWorkflowTemplateRequest
            {
                ParentAsRegionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Template = gax::GaxPreconditions.CheckNotNull(template, nameof(template)),
            }, callSettings);

        /// <summary>
        /// Creates new workflow template.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.workflowTemplates.create`, the resource name of the
        /// region has the following format:
        /// `projects/{project_id}/regions/{region}`
        /// 
        /// * For `projects.locations.workflowTemplates.create`, the resource name of
        /// the location has the following format:
        /// `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="template">
        /// Required. The Dataproc workflow template to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkflowTemplate> CreateWorkflowTemplateAsync(RegionName parent, WorkflowTemplate template, st::CancellationToken cancellationToken) =>
            CreateWorkflowTemplateAsync(parent, template, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates new workflow template.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.workflowTemplates.create`, the resource name of the
        /// region has the following format:
        /// `projects/{project_id}/regions/{region}`
        /// 
        /// * For `projects.locations.workflowTemplates.create`, the resource name of
        /// the location has the following format:
        /// `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="template">
        /// Required. The Dataproc workflow template to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WorkflowTemplate CreateWorkflowTemplate(gagr::LocationName parent, WorkflowTemplate template, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkflowTemplate(new CreateWorkflowTemplateRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Template = gax::GaxPreconditions.CheckNotNull(template, nameof(template)),
            }, callSettings);

        /// <summary>
        /// Creates new workflow template.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.workflowTemplates.create`, the resource name of the
        /// region has the following format:
        /// `projects/{project_id}/regions/{region}`
        /// 
        /// * For `projects.locations.workflowTemplates.create`, the resource name of
        /// the location has the following format:
        /// `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="template">
        /// Required. The Dataproc workflow template to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkflowTemplate> CreateWorkflowTemplateAsync(gagr::LocationName parent, WorkflowTemplate template, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkflowTemplateAsync(new CreateWorkflowTemplateRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Template = gax::GaxPreconditions.CheckNotNull(template, nameof(template)),
            }, callSettings);

        /// <summary>
        /// Creates new workflow template.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.workflowTemplates.create`, the resource name of the
        /// region has the following format:
        /// `projects/{project_id}/regions/{region}`
        /// 
        /// * For `projects.locations.workflowTemplates.create`, the resource name of
        /// the location has the following format:
        /// `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="template">
        /// Required. The Dataproc workflow template to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkflowTemplate> CreateWorkflowTemplateAsync(gagr::LocationName parent, WorkflowTemplate template, st::CancellationToken cancellationToken) =>
            CreateWorkflowTemplateAsync(parent, template, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the latest workflow template.
        /// 
        /// Can retrieve previously instantiated template by specifying optional
        /// version parameter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WorkflowTemplate GetWorkflowTemplate(GetWorkflowTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the latest workflow template.
        /// 
        /// Can retrieve previously instantiated template by specifying optional
        /// version parameter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkflowTemplate> GetWorkflowTemplateAsync(GetWorkflowTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the latest workflow template.
        /// 
        /// Can retrieve previously instantiated template by specifying optional
        /// version parameter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkflowTemplate> GetWorkflowTemplateAsync(GetWorkflowTemplateRequest request, st::CancellationToken cancellationToken) =>
            GetWorkflowTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the latest workflow template.
        /// 
        /// Can retrieve previously instantiated template by specifying optional
        /// version parameter.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the workflow template, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.workflowTemplates.get`, the resource name of the
        /// template has the following format:
        /// `projects/{project_id}/regions/{region}/workflowTemplates/{template_id}`
        /// 
        /// * For `projects.locations.workflowTemplates.get`, the resource name of the
        /// template has the following format:
        /// `projects/{project_id}/locations/{location}/workflowTemplates/{template_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WorkflowTemplate GetWorkflowTemplate(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkflowTemplate(new GetWorkflowTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the latest workflow template.
        /// 
        /// Can retrieve previously instantiated template by specifying optional
        /// version parameter.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the workflow template, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.workflowTemplates.get`, the resource name of the
        /// template has the following format:
        /// `projects/{project_id}/regions/{region}/workflowTemplates/{template_id}`
        /// 
        /// * For `projects.locations.workflowTemplates.get`, the resource name of the
        /// template has the following format:
        /// `projects/{project_id}/locations/{location}/workflowTemplates/{template_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkflowTemplate> GetWorkflowTemplateAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkflowTemplateAsync(new GetWorkflowTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the latest workflow template.
        /// 
        /// Can retrieve previously instantiated template by specifying optional
        /// version parameter.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the workflow template, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.workflowTemplates.get`, the resource name of the
        /// template has the following format:
        /// `projects/{project_id}/regions/{region}/workflowTemplates/{template_id}`
        /// 
        /// * For `projects.locations.workflowTemplates.get`, the resource name of the
        /// template has the following format:
        /// `projects/{project_id}/locations/{location}/workflowTemplates/{template_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkflowTemplate> GetWorkflowTemplateAsync(string name, st::CancellationToken cancellationToken) =>
            GetWorkflowTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the latest workflow template.
        /// 
        /// Can retrieve previously instantiated template by specifying optional
        /// version parameter.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the workflow template, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.workflowTemplates.get`, the resource name of the
        /// template has the following format:
        /// `projects/{project_id}/regions/{region}/workflowTemplates/{template_id}`
        /// 
        /// * For `projects.locations.workflowTemplates.get`, the resource name of the
        /// template has the following format:
        /// `projects/{project_id}/locations/{location}/workflowTemplates/{template_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WorkflowTemplate GetWorkflowTemplate(WorkflowTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkflowTemplate(new GetWorkflowTemplateRequest
            {
                WorkflowTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the latest workflow template.
        /// 
        /// Can retrieve previously instantiated template by specifying optional
        /// version parameter.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the workflow template, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.workflowTemplates.get`, the resource name of the
        /// template has the following format:
        /// `projects/{project_id}/regions/{region}/workflowTemplates/{template_id}`
        /// 
        /// * For `projects.locations.workflowTemplates.get`, the resource name of the
        /// template has the following format:
        /// `projects/{project_id}/locations/{location}/workflowTemplates/{template_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkflowTemplate> GetWorkflowTemplateAsync(WorkflowTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkflowTemplateAsync(new GetWorkflowTemplateRequest
            {
                WorkflowTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the latest workflow template.
        /// 
        /// Can retrieve previously instantiated template by specifying optional
        /// version parameter.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the workflow template, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.workflowTemplates.get`, the resource name of the
        /// template has the following format:
        /// `projects/{project_id}/regions/{region}/workflowTemplates/{template_id}`
        /// 
        /// * For `projects.locations.workflowTemplates.get`, the resource name of the
        /// template has the following format:
        /// `projects/{project_id}/locations/{location}/workflowTemplates/{template_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkflowTemplate> GetWorkflowTemplateAsync(WorkflowTemplateName name, st::CancellationToken cancellationToken) =>
            GetWorkflowTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Instantiates a template and begins execution.
        /// 
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        /// 
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        /// 
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](https://cloud.google.com/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        /// 
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, WorkflowMetadata> InstantiateWorkflowTemplate(InstantiateWorkflowTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Instantiates a template and begins execution.
        /// 
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        /// 
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        /// 
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](https://cloud.google.com/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        /// 
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, WorkflowMetadata>> InstantiateWorkflowTemplateAsync(InstantiateWorkflowTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Instantiates a template and begins execution.
        /// 
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        /// 
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        /// 
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](https://cloud.google.com/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        /// 
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, WorkflowMetadata>> InstantiateWorkflowTemplateAsync(InstantiateWorkflowTemplateRequest request, st::CancellationToken cancellationToken) =>
            InstantiateWorkflowTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>InstantiateWorkflowTemplate</c>.</summary>
        public virtual lro::OperationsClient InstantiateWorkflowTemplateOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>InstantiateWorkflowTemplate</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, WorkflowMetadata> PollOnceInstantiateWorkflowTemplate(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, WorkflowMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), InstantiateWorkflowTemplateOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>InstantiateWorkflowTemplate</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, WorkflowMetadata>> PollOnceInstantiateWorkflowTemplateAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, WorkflowMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), InstantiateWorkflowTemplateOperationsClient, callSettings);

        /// <summary>
        /// Instantiates a template and begins execution.
        /// 
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        /// 
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        /// 
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](https://cloud.google.com/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        /// 
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the workflow template, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.workflowTemplates.instantiate`, the resource name
        /// of the template has the following format:
        /// `projects/{project_id}/regions/{region}/workflowTemplates/{template_id}`
        /// 
        /// * For `projects.locations.workflowTemplates.instantiate`, the resource name
        /// of the template has the following format:
        /// `projects/{project_id}/locations/{location}/workflowTemplates/{template_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, WorkflowMetadata> InstantiateWorkflowTemplate(string name, gaxgrpc::CallSettings callSettings = null) =>
            InstantiateWorkflowTemplate(new InstantiateWorkflowTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Instantiates a template and begins execution.
        /// 
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        /// 
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        /// 
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](https://cloud.google.com/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        /// 
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the workflow template, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.workflowTemplates.instantiate`, the resource name
        /// of the template has the following format:
        /// `projects/{project_id}/regions/{region}/workflowTemplates/{template_id}`
        /// 
        /// * For `projects.locations.workflowTemplates.instantiate`, the resource name
        /// of the template has the following format:
        /// `projects/{project_id}/locations/{location}/workflowTemplates/{template_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, WorkflowMetadata>> InstantiateWorkflowTemplateAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            InstantiateWorkflowTemplateAsync(new InstantiateWorkflowTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Instantiates a template and begins execution.
        /// 
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        /// 
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        /// 
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](https://cloud.google.com/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        /// 
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the workflow template, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.workflowTemplates.instantiate`, the resource name
        /// of the template has the following format:
        /// `projects/{project_id}/regions/{region}/workflowTemplates/{template_id}`
        /// 
        /// * For `projects.locations.workflowTemplates.instantiate`, the resource name
        /// of the template has the following format:
        /// `projects/{project_id}/locations/{location}/workflowTemplates/{template_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, WorkflowMetadata>> InstantiateWorkflowTemplateAsync(string name, st::CancellationToken cancellationToken) =>
            InstantiateWorkflowTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Instantiates a template and begins execution.
        /// 
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        /// 
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        /// 
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](https://cloud.google.com/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        /// 
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the workflow template, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.workflowTemplates.instantiate`, the resource name
        /// of the template has the following format:
        /// `projects/{project_id}/regions/{region}/workflowTemplates/{template_id}`
        /// 
        /// * For `projects.locations.workflowTemplates.instantiate`, the resource name
        /// of the template has the following format:
        /// `projects/{project_id}/locations/{location}/workflowTemplates/{template_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, WorkflowMetadata> InstantiateWorkflowTemplate(WorkflowTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            InstantiateWorkflowTemplate(new InstantiateWorkflowTemplateRequest
            {
                WorkflowTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Instantiates a template and begins execution.
        /// 
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        /// 
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        /// 
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](https://cloud.google.com/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        /// 
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the workflow template, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.workflowTemplates.instantiate`, the resource name
        /// of the template has the following format:
        /// `projects/{project_id}/regions/{region}/workflowTemplates/{template_id}`
        /// 
        /// * For `projects.locations.workflowTemplates.instantiate`, the resource name
        /// of the template has the following format:
        /// `projects/{project_id}/locations/{location}/workflowTemplates/{template_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, WorkflowMetadata>> InstantiateWorkflowTemplateAsync(WorkflowTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            InstantiateWorkflowTemplateAsync(new InstantiateWorkflowTemplateRequest
            {
                WorkflowTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Instantiates a template and begins execution.
        /// 
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        /// 
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        /// 
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](https://cloud.google.com/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        /// 
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the workflow template, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.workflowTemplates.instantiate`, the resource name
        /// of the template has the following format:
        /// `projects/{project_id}/regions/{region}/workflowTemplates/{template_id}`
        /// 
        /// * For `projects.locations.workflowTemplates.instantiate`, the resource name
        /// of the template has the following format:
        /// `projects/{project_id}/locations/{location}/workflowTemplates/{template_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, WorkflowMetadata>> InstantiateWorkflowTemplateAsync(WorkflowTemplateName name, st::CancellationToken cancellationToken) =>
            InstantiateWorkflowTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Instantiates a template and begins execution.
        /// 
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        /// 
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        /// 
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](https://cloud.google.com/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        /// 
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the workflow template, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.workflowTemplates.instantiate`, the resource name
        /// of the template has the following format:
        /// `projects/{project_id}/regions/{region}/workflowTemplates/{template_id}`
        /// 
        /// * For `projects.locations.workflowTemplates.instantiate`, the resource name
        /// of the template has the following format:
        /// `projects/{project_id}/locations/{location}/workflowTemplates/{template_id}`
        /// </param>
        /// <param name="parameters">
        /// Optional. Map from parameter names to values that should be used for those
        /// parameters. Values may not exceed 1000 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, WorkflowMetadata> InstantiateWorkflowTemplate(string name, scg::IDictionary<string, string> parameters, gaxgrpc::CallSettings callSettings = null) =>
            InstantiateWorkflowTemplate(new InstantiateWorkflowTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Parameters =
                {
                    parameters ?? new scg::Dictionary<string, string>(),
                },
            }, callSettings);

        /// <summary>
        /// Instantiates a template and begins execution.
        /// 
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        /// 
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        /// 
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](https://cloud.google.com/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        /// 
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the workflow template, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.workflowTemplates.instantiate`, the resource name
        /// of the template has the following format:
        /// `projects/{project_id}/regions/{region}/workflowTemplates/{template_id}`
        /// 
        /// * For `projects.locations.workflowTemplates.instantiate`, the resource name
        /// of the template has the following format:
        /// `projects/{project_id}/locations/{location}/workflowTemplates/{template_id}`
        /// </param>
        /// <param name="parameters">
        /// Optional. Map from parameter names to values that should be used for those
        /// parameters. Values may not exceed 1000 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, WorkflowMetadata>> InstantiateWorkflowTemplateAsync(string name, scg::IDictionary<string, string> parameters, gaxgrpc::CallSettings callSettings = null) =>
            InstantiateWorkflowTemplateAsync(new InstantiateWorkflowTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Parameters =
                {
                    parameters ?? new scg::Dictionary<string, string>(),
                },
            }, callSettings);

        /// <summary>
        /// Instantiates a template and begins execution.
        /// 
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        /// 
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        /// 
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](https://cloud.google.com/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        /// 
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the workflow template, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.workflowTemplates.instantiate`, the resource name
        /// of the template has the following format:
        /// `projects/{project_id}/regions/{region}/workflowTemplates/{template_id}`
        /// 
        /// * For `projects.locations.workflowTemplates.instantiate`, the resource name
        /// of the template has the following format:
        /// `projects/{project_id}/locations/{location}/workflowTemplates/{template_id}`
        /// </param>
        /// <param name="parameters">
        /// Optional. Map from parameter names to values that should be used for those
        /// parameters. Values may not exceed 1000 characters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, WorkflowMetadata>> InstantiateWorkflowTemplateAsync(string name, scg::IDictionary<string, string> parameters, st::CancellationToken cancellationToken) =>
            InstantiateWorkflowTemplateAsync(name, parameters, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Instantiates a template and begins execution.
        /// 
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        /// 
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        /// 
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](https://cloud.google.com/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        /// 
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the workflow template, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.workflowTemplates.instantiate`, the resource name
        /// of the template has the following format:
        /// `projects/{project_id}/regions/{region}/workflowTemplates/{template_id}`
        /// 
        /// * For `projects.locations.workflowTemplates.instantiate`, the resource name
        /// of the template has the following format:
        /// `projects/{project_id}/locations/{location}/workflowTemplates/{template_id}`
        /// </param>
        /// <param name="parameters">
        /// Optional. Map from parameter names to values that should be used for those
        /// parameters. Values may not exceed 1000 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, WorkflowMetadata> InstantiateWorkflowTemplate(WorkflowTemplateName name, scg::IDictionary<string, string> parameters, gaxgrpc::CallSettings callSettings = null) =>
            InstantiateWorkflowTemplate(new InstantiateWorkflowTemplateRequest
            {
                WorkflowTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Parameters =
                {
                    parameters ?? new scg::Dictionary<string, string>(),
                },
            }, callSettings);

        /// <summary>
        /// Instantiates a template and begins execution.
        /// 
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        /// 
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        /// 
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](https://cloud.google.com/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        /// 
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the workflow template, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.workflowTemplates.instantiate`, the resource name
        /// of the template has the following format:
        /// `projects/{project_id}/regions/{region}/workflowTemplates/{template_id}`
        /// 
        /// * For `projects.locations.workflowTemplates.instantiate`, the resource name
        /// of the template has the following format:
        /// `projects/{project_id}/locations/{location}/workflowTemplates/{template_id}`
        /// </param>
        /// <param name="parameters">
        /// Optional. Map from parameter names to values that should be used for those
        /// parameters. Values may not exceed 1000 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, WorkflowMetadata>> InstantiateWorkflowTemplateAsync(WorkflowTemplateName name, scg::IDictionary<string, string> parameters, gaxgrpc::CallSettings callSettings = null) =>
            InstantiateWorkflowTemplateAsync(new InstantiateWorkflowTemplateRequest
            {
                WorkflowTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Parameters =
                {
                    parameters ?? new scg::Dictionary<string, string>(),
                },
            }, callSettings);

        /// <summary>
        /// Instantiates a template and begins execution.
        /// 
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        /// 
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        /// 
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](https://cloud.google.com/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        /// 
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the workflow template, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.workflowTemplates.instantiate`, the resource name
        /// of the template has the following format:
        /// `projects/{project_id}/regions/{region}/workflowTemplates/{template_id}`
        /// 
        /// * For `projects.locations.workflowTemplates.instantiate`, the resource name
        /// of the template has the following format:
        /// `projects/{project_id}/locations/{location}/workflowTemplates/{template_id}`
        /// </param>
        /// <param name="parameters">
        /// Optional. Map from parameter names to values that should be used for those
        /// parameters. Values may not exceed 1000 characters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, WorkflowMetadata>> InstantiateWorkflowTemplateAsync(WorkflowTemplateName name, scg::IDictionary<string, string> parameters, st::CancellationToken cancellationToken) =>
            InstantiateWorkflowTemplateAsync(name, parameters, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Instantiates a template and begins execution.
        /// 
        /// This method is equivalent to executing the sequence
        /// [CreateWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.CreateWorkflowTemplate],
        /// [InstantiateWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.InstantiateWorkflowTemplate],
        /// [DeleteWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.DeleteWorkflowTemplate].
        /// 
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        /// 
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        /// 
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](https://cloud.google.com/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        /// 
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, WorkflowMetadata> InstantiateInlineWorkflowTemplate(InstantiateInlineWorkflowTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Instantiates a template and begins execution.
        /// 
        /// This method is equivalent to executing the sequence
        /// [CreateWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.CreateWorkflowTemplate],
        /// [InstantiateWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.InstantiateWorkflowTemplate],
        /// [DeleteWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.DeleteWorkflowTemplate].
        /// 
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        /// 
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        /// 
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](https://cloud.google.com/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        /// 
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, WorkflowMetadata>> InstantiateInlineWorkflowTemplateAsync(InstantiateInlineWorkflowTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Instantiates a template and begins execution.
        /// 
        /// This method is equivalent to executing the sequence
        /// [CreateWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.CreateWorkflowTemplate],
        /// [InstantiateWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.InstantiateWorkflowTemplate],
        /// [DeleteWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.DeleteWorkflowTemplate].
        /// 
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        /// 
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        /// 
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](https://cloud.google.com/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        /// 
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, WorkflowMetadata>> InstantiateInlineWorkflowTemplateAsync(InstantiateInlineWorkflowTemplateRequest request, st::CancellationToken cancellationToken) =>
            InstantiateInlineWorkflowTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>InstantiateInlineWorkflowTemplate</c>.</summary>
        public virtual lro::OperationsClient InstantiateInlineWorkflowTemplateOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>InstantiateInlineWorkflowTemplate</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, WorkflowMetadata> PollOnceInstantiateInlineWorkflowTemplate(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, WorkflowMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), InstantiateInlineWorkflowTemplateOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>InstantiateInlineWorkflowTemplate</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, WorkflowMetadata>> PollOnceInstantiateInlineWorkflowTemplateAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, WorkflowMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), InstantiateInlineWorkflowTemplateOperationsClient, callSettings);

        /// <summary>
        /// Instantiates a template and begins execution.
        /// 
        /// This method is equivalent to executing the sequence
        /// [CreateWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.CreateWorkflowTemplate],
        /// [InstantiateWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.InstantiateWorkflowTemplate],
        /// [DeleteWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.DeleteWorkflowTemplate].
        /// 
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        /// 
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        /// 
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](https://cloud.google.com/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        /// 
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.workflowTemplates,instantiateinline`, the resource
        /// name of the region has the following format:
        /// `projects/{project_id}/regions/{region}`
        /// 
        /// * For `projects.locations.workflowTemplates.instantiateinline`, the
        /// resource name of the location has the following format:
        /// `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="template">
        /// Required. The workflow template to instantiate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, WorkflowMetadata> InstantiateInlineWorkflowTemplate(string parent, WorkflowTemplate template, gaxgrpc::CallSettings callSettings = null) =>
            InstantiateInlineWorkflowTemplate(new InstantiateInlineWorkflowTemplateRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Template = gax::GaxPreconditions.CheckNotNull(template, nameof(template)),
            }, callSettings);

        /// <summary>
        /// Instantiates a template and begins execution.
        /// 
        /// This method is equivalent to executing the sequence
        /// [CreateWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.CreateWorkflowTemplate],
        /// [InstantiateWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.InstantiateWorkflowTemplate],
        /// [DeleteWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.DeleteWorkflowTemplate].
        /// 
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        /// 
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        /// 
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](https://cloud.google.com/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        /// 
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.workflowTemplates,instantiateinline`, the resource
        /// name of the region has the following format:
        /// `projects/{project_id}/regions/{region}`
        /// 
        /// * For `projects.locations.workflowTemplates.instantiateinline`, the
        /// resource name of the location has the following format:
        /// `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="template">
        /// Required. The workflow template to instantiate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, WorkflowMetadata>> InstantiateInlineWorkflowTemplateAsync(string parent, WorkflowTemplate template, gaxgrpc::CallSettings callSettings = null) =>
            InstantiateInlineWorkflowTemplateAsync(new InstantiateInlineWorkflowTemplateRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Template = gax::GaxPreconditions.CheckNotNull(template, nameof(template)),
            }, callSettings);

        /// <summary>
        /// Instantiates a template and begins execution.
        /// 
        /// This method is equivalent to executing the sequence
        /// [CreateWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.CreateWorkflowTemplate],
        /// [InstantiateWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.InstantiateWorkflowTemplate],
        /// [DeleteWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.DeleteWorkflowTemplate].
        /// 
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        /// 
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        /// 
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](https://cloud.google.com/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        /// 
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.workflowTemplates,instantiateinline`, the resource
        /// name of the region has the following format:
        /// `projects/{project_id}/regions/{region}`
        /// 
        /// * For `projects.locations.workflowTemplates.instantiateinline`, the
        /// resource name of the location has the following format:
        /// `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="template">
        /// Required. The workflow template to instantiate.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, WorkflowMetadata>> InstantiateInlineWorkflowTemplateAsync(string parent, WorkflowTemplate template, st::CancellationToken cancellationToken) =>
            InstantiateInlineWorkflowTemplateAsync(parent, template, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Instantiates a template and begins execution.
        /// 
        /// This method is equivalent to executing the sequence
        /// [CreateWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.CreateWorkflowTemplate],
        /// [InstantiateWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.InstantiateWorkflowTemplate],
        /// [DeleteWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.DeleteWorkflowTemplate].
        /// 
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        /// 
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        /// 
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](https://cloud.google.com/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        /// 
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.workflowTemplates,instantiateinline`, the resource
        /// name of the region has the following format:
        /// `projects/{project_id}/regions/{region}`
        /// 
        /// * For `projects.locations.workflowTemplates.instantiateinline`, the
        /// resource name of the location has the following format:
        /// `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="template">
        /// Required. The workflow template to instantiate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, WorkflowMetadata> InstantiateInlineWorkflowTemplate(RegionName parent, WorkflowTemplate template, gaxgrpc::CallSettings callSettings = null) =>
            InstantiateInlineWorkflowTemplate(new InstantiateInlineWorkflowTemplateRequest
            {
                ParentAsRegionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Template = gax::GaxPreconditions.CheckNotNull(template, nameof(template)),
            }, callSettings);

        /// <summary>
        /// Instantiates a template and begins execution.
        /// 
        /// This method is equivalent to executing the sequence
        /// [CreateWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.CreateWorkflowTemplate],
        /// [InstantiateWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.InstantiateWorkflowTemplate],
        /// [DeleteWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.DeleteWorkflowTemplate].
        /// 
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        /// 
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        /// 
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](https://cloud.google.com/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        /// 
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.workflowTemplates,instantiateinline`, the resource
        /// name of the region has the following format:
        /// `projects/{project_id}/regions/{region}`
        /// 
        /// * For `projects.locations.workflowTemplates.instantiateinline`, the
        /// resource name of the location has the following format:
        /// `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="template">
        /// Required. The workflow template to instantiate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, WorkflowMetadata>> InstantiateInlineWorkflowTemplateAsync(RegionName parent, WorkflowTemplate template, gaxgrpc::CallSettings callSettings = null) =>
            InstantiateInlineWorkflowTemplateAsync(new InstantiateInlineWorkflowTemplateRequest
            {
                ParentAsRegionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Template = gax::GaxPreconditions.CheckNotNull(template, nameof(template)),
            }, callSettings);

        /// <summary>
        /// Instantiates a template and begins execution.
        /// 
        /// This method is equivalent to executing the sequence
        /// [CreateWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.CreateWorkflowTemplate],
        /// [InstantiateWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.InstantiateWorkflowTemplate],
        /// [DeleteWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.DeleteWorkflowTemplate].
        /// 
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        /// 
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        /// 
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](https://cloud.google.com/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        /// 
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.workflowTemplates,instantiateinline`, the resource
        /// name of the region has the following format:
        /// `projects/{project_id}/regions/{region}`
        /// 
        /// * For `projects.locations.workflowTemplates.instantiateinline`, the
        /// resource name of the location has the following format:
        /// `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="template">
        /// Required. The workflow template to instantiate.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, WorkflowMetadata>> InstantiateInlineWorkflowTemplateAsync(RegionName parent, WorkflowTemplate template, st::CancellationToken cancellationToken) =>
            InstantiateInlineWorkflowTemplateAsync(parent, template, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Instantiates a template and begins execution.
        /// 
        /// This method is equivalent to executing the sequence
        /// [CreateWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.CreateWorkflowTemplate],
        /// [InstantiateWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.InstantiateWorkflowTemplate],
        /// [DeleteWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.DeleteWorkflowTemplate].
        /// 
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        /// 
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        /// 
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](https://cloud.google.com/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        /// 
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.workflowTemplates,instantiateinline`, the resource
        /// name of the region has the following format:
        /// `projects/{project_id}/regions/{region}`
        /// 
        /// * For `projects.locations.workflowTemplates.instantiateinline`, the
        /// resource name of the location has the following format:
        /// `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="template">
        /// Required. The workflow template to instantiate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, WorkflowMetadata> InstantiateInlineWorkflowTemplate(gagr::LocationName parent, WorkflowTemplate template, gaxgrpc::CallSettings callSettings = null) =>
            InstantiateInlineWorkflowTemplate(new InstantiateInlineWorkflowTemplateRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Template = gax::GaxPreconditions.CheckNotNull(template, nameof(template)),
            }, callSettings);

        /// <summary>
        /// Instantiates a template and begins execution.
        /// 
        /// This method is equivalent to executing the sequence
        /// [CreateWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.CreateWorkflowTemplate],
        /// [InstantiateWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.InstantiateWorkflowTemplate],
        /// [DeleteWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.DeleteWorkflowTemplate].
        /// 
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        /// 
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        /// 
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](https://cloud.google.com/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        /// 
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.workflowTemplates,instantiateinline`, the resource
        /// name of the region has the following format:
        /// `projects/{project_id}/regions/{region}`
        /// 
        /// * For `projects.locations.workflowTemplates.instantiateinline`, the
        /// resource name of the location has the following format:
        /// `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="template">
        /// Required. The workflow template to instantiate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, WorkflowMetadata>> InstantiateInlineWorkflowTemplateAsync(gagr::LocationName parent, WorkflowTemplate template, gaxgrpc::CallSettings callSettings = null) =>
            InstantiateInlineWorkflowTemplateAsync(new InstantiateInlineWorkflowTemplateRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Template = gax::GaxPreconditions.CheckNotNull(template, nameof(template)),
            }, callSettings);

        /// <summary>
        /// Instantiates a template and begins execution.
        /// 
        /// This method is equivalent to executing the sequence
        /// [CreateWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.CreateWorkflowTemplate],
        /// [InstantiateWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.InstantiateWorkflowTemplate],
        /// [DeleteWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.DeleteWorkflowTemplate].
        /// 
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        /// 
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        /// 
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](https://cloud.google.com/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        /// 
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.workflowTemplates,instantiateinline`, the resource
        /// name of the region has the following format:
        /// `projects/{project_id}/regions/{region}`
        /// 
        /// * For `projects.locations.workflowTemplates.instantiateinline`, the
        /// resource name of the location has the following format:
        /// `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="template">
        /// Required. The workflow template to instantiate.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, WorkflowMetadata>> InstantiateInlineWorkflowTemplateAsync(gagr::LocationName parent, WorkflowTemplate template, st::CancellationToken cancellationToken) =>
            InstantiateInlineWorkflowTemplateAsync(parent, template, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates (replaces) workflow template. The updated template
        /// must contain version that matches the current server version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WorkflowTemplate UpdateWorkflowTemplate(UpdateWorkflowTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates (replaces) workflow template. The updated template
        /// must contain version that matches the current server version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkflowTemplate> UpdateWorkflowTemplateAsync(UpdateWorkflowTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates (replaces) workflow template. The updated template
        /// must contain version that matches the current server version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkflowTemplate> UpdateWorkflowTemplateAsync(UpdateWorkflowTemplateRequest request, st::CancellationToken cancellationToken) =>
            UpdateWorkflowTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates (replaces) workflow template. The updated template
        /// must contain version that matches the current server version.
        /// </summary>
        /// <param name="template">
        /// Required. The updated workflow template.
        /// 
        /// The `template.version` field must match the current version.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WorkflowTemplate UpdateWorkflowTemplate(WorkflowTemplate template, gaxgrpc::CallSettings callSettings = null) =>
            UpdateWorkflowTemplate(new UpdateWorkflowTemplateRequest
            {
                Template = gax::GaxPreconditions.CheckNotNull(template, nameof(template)),
            }, callSettings);

        /// <summary>
        /// Updates (replaces) workflow template. The updated template
        /// must contain version that matches the current server version.
        /// </summary>
        /// <param name="template">
        /// Required. The updated workflow template.
        /// 
        /// The `template.version` field must match the current version.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkflowTemplate> UpdateWorkflowTemplateAsync(WorkflowTemplate template, gaxgrpc::CallSettings callSettings = null) =>
            UpdateWorkflowTemplateAsync(new UpdateWorkflowTemplateRequest
            {
                Template = gax::GaxPreconditions.CheckNotNull(template, nameof(template)),
            }, callSettings);

        /// <summary>
        /// Updates (replaces) workflow template. The updated template
        /// must contain version that matches the current server version.
        /// </summary>
        /// <param name="template">
        /// Required. The updated workflow template.
        /// 
        /// The `template.version` field must match the current version.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkflowTemplate> UpdateWorkflowTemplateAsync(WorkflowTemplate template, st::CancellationToken cancellationToken) =>
            UpdateWorkflowTemplateAsync(template, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists workflows that match the specified filter in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="WorkflowTemplate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWorkflowTemplatesResponse, WorkflowTemplate> ListWorkflowTemplates(ListWorkflowTemplatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists workflows that match the specified filter in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="WorkflowTemplate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkflowTemplatesResponse, WorkflowTemplate> ListWorkflowTemplatesAsync(ListWorkflowTemplatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists workflows that match the specified filter in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.workflowTemplates,list`, the resource
        /// name of the region has the following format:
        /// `projects/{project_id}/regions/{region}`
        /// 
        /// * For `projects.locations.workflowTemplates.list`, the
        /// resource name of the location has the following format:
        /// `projects/{project_id}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="WorkflowTemplate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWorkflowTemplatesResponse, WorkflowTemplate> ListWorkflowTemplates(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkflowTemplatesRequest request = new ListWorkflowTemplatesRequest
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
            return ListWorkflowTemplates(request, callSettings);
        }

        /// <summary>
        /// Lists workflows that match the specified filter in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.workflowTemplates,list`, the resource
        /// name of the region has the following format:
        /// `projects/{project_id}/regions/{region}`
        /// 
        /// * For `projects.locations.workflowTemplates.list`, the
        /// resource name of the location has the following format:
        /// `projects/{project_id}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="WorkflowTemplate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkflowTemplatesResponse, WorkflowTemplate> ListWorkflowTemplatesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkflowTemplatesRequest request = new ListWorkflowTemplatesRequest
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
            return ListWorkflowTemplatesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists workflows that match the specified filter in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.workflowTemplates,list`, the resource
        /// name of the region has the following format:
        /// `projects/{project_id}/regions/{region}`
        /// 
        /// * For `projects.locations.workflowTemplates.list`, the
        /// resource name of the location has the following format:
        /// `projects/{project_id}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="WorkflowTemplate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWorkflowTemplatesResponse, WorkflowTemplate> ListWorkflowTemplates(RegionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkflowTemplatesRequest request = new ListWorkflowTemplatesRequest
            {
                ParentAsRegionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListWorkflowTemplates(request, callSettings);
        }

        /// <summary>
        /// Lists workflows that match the specified filter in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.workflowTemplates,list`, the resource
        /// name of the region has the following format:
        /// `projects/{project_id}/regions/{region}`
        /// 
        /// * For `projects.locations.workflowTemplates.list`, the
        /// resource name of the location has the following format:
        /// `projects/{project_id}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="WorkflowTemplate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkflowTemplatesResponse, WorkflowTemplate> ListWorkflowTemplatesAsync(RegionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkflowTemplatesRequest request = new ListWorkflowTemplatesRequest
            {
                ParentAsRegionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListWorkflowTemplatesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists workflows that match the specified filter in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.workflowTemplates,list`, the resource
        /// name of the region has the following format:
        /// `projects/{project_id}/regions/{region}`
        /// 
        /// * For `projects.locations.workflowTemplates.list`, the
        /// resource name of the location has the following format:
        /// `projects/{project_id}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="WorkflowTemplate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWorkflowTemplatesResponse, WorkflowTemplate> ListWorkflowTemplates(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkflowTemplatesRequest request = new ListWorkflowTemplatesRequest
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
            return ListWorkflowTemplates(request, callSettings);
        }

        /// <summary>
        /// Lists workflows that match the specified filter in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.workflowTemplates,list`, the resource
        /// name of the region has the following format:
        /// `projects/{project_id}/regions/{region}`
        /// 
        /// * For `projects.locations.workflowTemplates.list`, the
        /// resource name of the location has the following format:
        /// `projects/{project_id}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="WorkflowTemplate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkflowTemplatesResponse, WorkflowTemplate> ListWorkflowTemplatesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkflowTemplatesRequest request = new ListWorkflowTemplatesRequest
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
            return ListWorkflowTemplatesAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes a workflow template. It does not cancel in-progress workflows.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteWorkflowTemplate(DeleteWorkflowTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a workflow template. It does not cancel in-progress workflows.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteWorkflowTemplateAsync(DeleteWorkflowTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a workflow template. It does not cancel in-progress workflows.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteWorkflowTemplateAsync(DeleteWorkflowTemplateRequest request, st::CancellationToken cancellationToken) =>
            DeleteWorkflowTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a workflow template. It does not cancel in-progress workflows.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the workflow template, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.workflowTemplates.delete`, the resource name
        /// of the template has the following format:
        /// `projects/{project_id}/regions/{region}/workflowTemplates/{template_id}`
        /// 
        /// * For `projects.locations.workflowTemplates.instantiate`, the resource name
        /// of the template has the following format:
        /// `projects/{project_id}/locations/{location}/workflowTemplates/{template_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteWorkflowTemplate(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkflowTemplate(new DeleteWorkflowTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a workflow template. It does not cancel in-progress workflows.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the workflow template, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.workflowTemplates.delete`, the resource name
        /// of the template has the following format:
        /// `projects/{project_id}/regions/{region}/workflowTemplates/{template_id}`
        /// 
        /// * For `projects.locations.workflowTemplates.instantiate`, the resource name
        /// of the template has the following format:
        /// `projects/{project_id}/locations/{location}/workflowTemplates/{template_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteWorkflowTemplateAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkflowTemplateAsync(new DeleteWorkflowTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a workflow template. It does not cancel in-progress workflows.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the workflow template, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.workflowTemplates.delete`, the resource name
        /// of the template has the following format:
        /// `projects/{project_id}/regions/{region}/workflowTemplates/{template_id}`
        /// 
        /// * For `projects.locations.workflowTemplates.instantiate`, the resource name
        /// of the template has the following format:
        /// `projects/{project_id}/locations/{location}/workflowTemplates/{template_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteWorkflowTemplateAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteWorkflowTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a workflow template. It does not cancel in-progress workflows.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the workflow template, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.workflowTemplates.delete`, the resource name
        /// of the template has the following format:
        /// `projects/{project_id}/regions/{region}/workflowTemplates/{template_id}`
        /// 
        /// * For `projects.locations.workflowTemplates.instantiate`, the resource name
        /// of the template has the following format:
        /// `projects/{project_id}/locations/{location}/workflowTemplates/{template_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteWorkflowTemplate(WorkflowTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkflowTemplate(new DeleteWorkflowTemplateRequest
            {
                WorkflowTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a workflow template. It does not cancel in-progress workflows.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the workflow template, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.workflowTemplates.delete`, the resource name
        /// of the template has the following format:
        /// `projects/{project_id}/regions/{region}/workflowTemplates/{template_id}`
        /// 
        /// * For `projects.locations.workflowTemplates.instantiate`, the resource name
        /// of the template has the following format:
        /// `projects/{project_id}/locations/{location}/workflowTemplates/{template_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteWorkflowTemplateAsync(WorkflowTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkflowTemplateAsync(new DeleteWorkflowTemplateRequest
            {
                WorkflowTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a workflow template. It does not cancel in-progress workflows.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the workflow template, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.workflowTemplates.delete`, the resource name
        /// of the template has the following format:
        /// `projects/{project_id}/regions/{region}/workflowTemplates/{template_id}`
        /// 
        /// * For `projects.locations.workflowTemplates.instantiate`, the resource name
        /// of the template has the following format:
        /// `projects/{project_id}/locations/{location}/workflowTemplates/{template_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteWorkflowTemplateAsync(WorkflowTemplateName name, st::CancellationToken cancellationToken) =>
            DeleteWorkflowTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>WorkflowTemplateService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The API interface for managing Workflow Templates in the
    /// Dataproc API.
    /// </remarks>
    public sealed partial class WorkflowTemplateServiceClientImpl : WorkflowTemplateServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateWorkflowTemplateRequest, WorkflowTemplate> _callCreateWorkflowTemplate;

        private readonly gaxgrpc::ApiCall<GetWorkflowTemplateRequest, WorkflowTemplate> _callGetWorkflowTemplate;

        private readonly gaxgrpc::ApiCall<InstantiateWorkflowTemplateRequest, lro::Operation> _callInstantiateWorkflowTemplate;

        private readonly gaxgrpc::ApiCall<InstantiateInlineWorkflowTemplateRequest, lro::Operation> _callInstantiateInlineWorkflowTemplate;

        private readonly gaxgrpc::ApiCall<UpdateWorkflowTemplateRequest, WorkflowTemplate> _callUpdateWorkflowTemplate;

        private readonly gaxgrpc::ApiCall<ListWorkflowTemplatesRequest, ListWorkflowTemplatesResponse> _callListWorkflowTemplates;

        private readonly gaxgrpc::ApiCall<DeleteWorkflowTemplateRequest, wkt::Empty> _callDeleteWorkflowTemplate;

        /// <summary>
        /// Constructs a client wrapper for the WorkflowTemplateService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="WorkflowTemplateServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public WorkflowTemplateServiceClientImpl(WorkflowTemplateService.WorkflowTemplateServiceClient grpcClient, WorkflowTemplateServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            WorkflowTemplateServiceSettings effectiveSettings = settings ?? WorkflowTemplateServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            InstantiateWorkflowTemplateOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.InstantiateWorkflowTemplateOperationsSettings, logger);
            InstantiateInlineWorkflowTemplateOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.InstantiateInlineWorkflowTemplateOperationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callCreateWorkflowTemplate = clientHelper.BuildApiCall<CreateWorkflowTemplateRequest, WorkflowTemplate>("CreateWorkflowTemplate", grpcClient.CreateWorkflowTemplateAsync, grpcClient.CreateWorkflowTemplate, effectiveSettings.CreateWorkflowTemplateSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateWorkflowTemplate);
            Modify_CreateWorkflowTemplateApiCall(ref _callCreateWorkflowTemplate);
            _callGetWorkflowTemplate = clientHelper.BuildApiCall<GetWorkflowTemplateRequest, WorkflowTemplate>("GetWorkflowTemplate", grpcClient.GetWorkflowTemplateAsync, grpcClient.GetWorkflowTemplate, effectiveSettings.GetWorkflowTemplateSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetWorkflowTemplate);
            Modify_GetWorkflowTemplateApiCall(ref _callGetWorkflowTemplate);
            _callInstantiateWorkflowTemplate = clientHelper.BuildApiCall<InstantiateWorkflowTemplateRequest, lro::Operation>("InstantiateWorkflowTemplate", grpcClient.InstantiateWorkflowTemplateAsync, grpcClient.InstantiateWorkflowTemplate, effectiveSettings.InstantiateWorkflowTemplateSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callInstantiateWorkflowTemplate);
            Modify_InstantiateWorkflowTemplateApiCall(ref _callInstantiateWorkflowTemplate);
            _callInstantiateInlineWorkflowTemplate = clientHelper.BuildApiCall<InstantiateInlineWorkflowTemplateRequest, lro::Operation>("InstantiateInlineWorkflowTemplate", grpcClient.InstantiateInlineWorkflowTemplateAsync, grpcClient.InstantiateInlineWorkflowTemplate, effectiveSettings.InstantiateInlineWorkflowTemplateSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callInstantiateInlineWorkflowTemplate);
            Modify_InstantiateInlineWorkflowTemplateApiCall(ref _callInstantiateInlineWorkflowTemplate);
            _callUpdateWorkflowTemplate = clientHelper.BuildApiCall<UpdateWorkflowTemplateRequest, WorkflowTemplate>("UpdateWorkflowTemplate", grpcClient.UpdateWorkflowTemplateAsync, grpcClient.UpdateWorkflowTemplate, effectiveSettings.UpdateWorkflowTemplateSettings).WithGoogleRequestParam("template.name", request => request.Template?.Name);
            Modify_ApiCall(ref _callUpdateWorkflowTemplate);
            Modify_UpdateWorkflowTemplateApiCall(ref _callUpdateWorkflowTemplate);
            _callListWorkflowTemplates = clientHelper.BuildApiCall<ListWorkflowTemplatesRequest, ListWorkflowTemplatesResponse>("ListWorkflowTemplates", grpcClient.ListWorkflowTemplatesAsync, grpcClient.ListWorkflowTemplates, effectiveSettings.ListWorkflowTemplatesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListWorkflowTemplates);
            Modify_ListWorkflowTemplatesApiCall(ref _callListWorkflowTemplates);
            _callDeleteWorkflowTemplate = clientHelper.BuildApiCall<DeleteWorkflowTemplateRequest, wkt::Empty>("DeleteWorkflowTemplate", grpcClient.DeleteWorkflowTemplateAsync, grpcClient.DeleteWorkflowTemplate, effectiveSettings.DeleteWorkflowTemplateSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteWorkflowTemplate);
            Modify_DeleteWorkflowTemplateApiCall(ref _callDeleteWorkflowTemplate);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateWorkflowTemplateApiCall(ref gaxgrpc::ApiCall<CreateWorkflowTemplateRequest, WorkflowTemplate> call);

        partial void Modify_GetWorkflowTemplateApiCall(ref gaxgrpc::ApiCall<GetWorkflowTemplateRequest, WorkflowTemplate> call);

        partial void Modify_InstantiateWorkflowTemplateApiCall(ref gaxgrpc::ApiCall<InstantiateWorkflowTemplateRequest, lro::Operation> call);

        partial void Modify_InstantiateInlineWorkflowTemplateApiCall(ref gaxgrpc::ApiCall<InstantiateInlineWorkflowTemplateRequest, lro::Operation> call);

        partial void Modify_UpdateWorkflowTemplateApiCall(ref gaxgrpc::ApiCall<UpdateWorkflowTemplateRequest, WorkflowTemplate> call);

        partial void Modify_ListWorkflowTemplatesApiCall(ref gaxgrpc::ApiCall<ListWorkflowTemplatesRequest, ListWorkflowTemplatesResponse> call);

        partial void Modify_DeleteWorkflowTemplateApiCall(ref gaxgrpc::ApiCall<DeleteWorkflowTemplateRequest, wkt::Empty> call);

        partial void OnConstruction(WorkflowTemplateService.WorkflowTemplateServiceClient grpcClient, WorkflowTemplateServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC WorkflowTemplateService client</summary>
        public override WorkflowTemplateService.WorkflowTemplateServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_CreateWorkflowTemplateRequest(ref CreateWorkflowTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetWorkflowTemplateRequest(ref GetWorkflowTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_InstantiateWorkflowTemplateRequest(ref InstantiateWorkflowTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_InstantiateInlineWorkflowTemplateRequest(ref InstantiateInlineWorkflowTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateWorkflowTemplateRequest(ref UpdateWorkflowTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListWorkflowTemplatesRequest(ref ListWorkflowTemplatesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteWorkflowTemplateRequest(ref DeleteWorkflowTemplateRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates new workflow template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override WorkflowTemplate CreateWorkflowTemplate(CreateWorkflowTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateWorkflowTemplateRequest(ref request, ref callSettings);
            return _callCreateWorkflowTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates new workflow template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<WorkflowTemplate> CreateWorkflowTemplateAsync(CreateWorkflowTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateWorkflowTemplateRequest(ref request, ref callSettings);
            return _callCreateWorkflowTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves the latest workflow template.
        /// 
        /// Can retrieve previously instantiated template by specifying optional
        /// version parameter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override WorkflowTemplate GetWorkflowTemplate(GetWorkflowTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetWorkflowTemplateRequest(ref request, ref callSettings);
            return _callGetWorkflowTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the latest workflow template.
        /// 
        /// Can retrieve previously instantiated template by specifying optional
        /// version parameter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<WorkflowTemplate> GetWorkflowTemplateAsync(GetWorkflowTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetWorkflowTemplateRequest(ref request, ref callSettings);
            return _callGetWorkflowTemplate.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>InstantiateWorkflowTemplate</c>.</summary>
        public override lro::OperationsClient InstantiateWorkflowTemplateOperationsClient { get; }

        /// <summary>
        /// Instantiates a template and begins execution.
        /// 
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        /// 
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        /// 
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](https://cloud.google.com/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        /// 
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, WorkflowMetadata> InstantiateWorkflowTemplate(InstantiateWorkflowTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InstantiateWorkflowTemplateRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, WorkflowMetadata>(_callInstantiateWorkflowTemplate.Sync(request, callSettings), InstantiateWorkflowTemplateOperationsClient);
        }

        /// <summary>
        /// Instantiates a template and begins execution.
        /// 
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        /// 
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        /// 
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](https://cloud.google.com/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        /// 
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, WorkflowMetadata>> InstantiateWorkflowTemplateAsync(InstantiateWorkflowTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InstantiateWorkflowTemplateRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, WorkflowMetadata>(await _callInstantiateWorkflowTemplate.Async(request, callSettings).ConfigureAwait(false), InstantiateWorkflowTemplateOperationsClient);
        }

        /// <summary>The long-running operations client for <c>InstantiateInlineWorkflowTemplate</c>.</summary>
        public override lro::OperationsClient InstantiateInlineWorkflowTemplateOperationsClient { get; }

        /// <summary>
        /// Instantiates a template and begins execution.
        /// 
        /// This method is equivalent to executing the sequence
        /// [CreateWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.CreateWorkflowTemplate],
        /// [InstantiateWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.InstantiateWorkflowTemplate],
        /// [DeleteWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.DeleteWorkflowTemplate].
        /// 
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        /// 
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        /// 
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](https://cloud.google.com/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        /// 
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, WorkflowMetadata> InstantiateInlineWorkflowTemplate(InstantiateInlineWorkflowTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InstantiateInlineWorkflowTemplateRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, WorkflowMetadata>(_callInstantiateInlineWorkflowTemplate.Sync(request, callSettings), InstantiateInlineWorkflowTemplateOperationsClient);
        }

        /// <summary>
        /// Instantiates a template and begins execution.
        /// 
        /// This method is equivalent to executing the sequence
        /// [CreateWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.CreateWorkflowTemplate],
        /// [InstantiateWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.InstantiateWorkflowTemplate],
        /// [DeleteWorkflowTemplate][google.cloud.dataproc.v1.WorkflowTemplateService.DeleteWorkflowTemplate].
        /// 
        /// The returned Operation can be used to track execution of
        /// workflow by polling
        /// [operations.get][google.longrunning.Operations.GetOperation].
        /// The Operation will complete when entire workflow is finished.
        /// 
        /// The running workflow can be aborted via
        /// [operations.cancel][google.longrunning.Operations.CancelOperation].
        /// This will cause any inflight jobs to be cancelled and workflow-owned
        /// clusters to be deleted.
        /// 
        /// The [Operation.metadata][google.longrunning.Operation.metadata] will be
        /// [WorkflowMetadata](https://cloud.google.com/dataproc/docs/reference/rpc/google.cloud.dataproc.v1#workflowmetadata).
        /// Also see [Using
        /// WorkflowMetadata](https://cloud.google.com/dataproc/docs/concepts/workflows/debugging#using_workflowmetadata).
        /// 
        /// On successful completion,
        /// [Operation.response][google.longrunning.Operation.response] will be
        /// [Empty][google.protobuf.Empty].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, WorkflowMetadata>> InstantiateInlineWorkflowTemplateAsync(InstantiateInlineWorkflowTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InstantiateInlineWorkflowTemplateRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, WorkflowMetadata>(await _callInstantiateInlineWorkflowTemplate.Async(request, callSettings).ConfigureAwait(false), InstantiateInlineWorkflowTemplateOperationsClient);
        }

        /// <summary>
        /// Updates (replaces) workflow template. The updated template
        /// must contain version that matches the current server version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override WorkflowTemplate UpdateWorkflowTemplate(UpdateWorkflowTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateWorkflowTemplateRequest(ref request, ref callSettings);
            return _callUpdateWorkflowTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates (replaces) workflow template. The updated template
        /// must contain version that matches the current server version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<WorkflowTemplate> UpdateWorkflowTemplateAsync(UpdateWorkflowTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateWorkflowTemplateRequest(ref request, ref callSettings);
            return _callUpdateWorkflowTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Lists workflows that match the specified filter in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="WorkflowTemplate"/> resources.</returns>
        public override gax::PagedEnumerable<ListWorkflowTemplatesResponse, WorkflowTemplate> ListWorkflowTemplates(ListWorkflowTemplatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListWorkflowTemplatesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListWorkflowTemplatesRequest, ListWorkflowTemplatesResponse, WorkflowTemplate>(_callListWorkflowTemplates, request, callSettings);
        }

        /// <summary>
        /// Lists workflows that match the specified filter in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="WorkflowTemplate"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListWorkflowTemplatesResponse, WorkflowTemplate> ListWorkflowTemplatesAsync(ListWorkflowTemplatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListWorkflowTemplatesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListWorkflowTemplatesRequest, ListWorkflowTemplatesResponse, WorkflowTemplate>(_callListWorkflowTemplates, request, callSettings);
        }

        /// <summary>
        /// Deletes a workflow template. It does not cancel in-progress workflows.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteWorkflowTemplate(DeleteWorkflowTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteWorkflowTemplateRequest(ref request, ref callSettings);
            _callDeleteWorkflowTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a workflow template. It does not cancel in-progress workflows.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteWorkflowTemplateAsync(DeleteWorkflowTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteWorkflowTemplateRequest(ref request, ref callSettings);
            return _callDeleteWorkflowTemplate.Async(request, callSettings);
        }
    }

    public partial class ListWorkflowTemplatesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListWorkflowTemplatesResponse : gaxgrpc::IPageResponse<WorkflowTemplate>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<WorkflowTemplate> GetEnumerator() => Templates.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class WorkflowTemplateService
    {
        public partial class WorkflowTemplateServiceClient
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

    public static partial class WorkflowTemplateService
    {
        public partial class WorkflowTemplateServiceClient
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
