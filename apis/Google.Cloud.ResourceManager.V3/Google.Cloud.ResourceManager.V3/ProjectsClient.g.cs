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

namespace Google.Cloud.ResourceManager.V3
{
    /// <summary>Settings for <see cref="ProjectsClient"/> instances.</summary>
    public sealed partial class ProjectsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ProjectsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ProjectsSettings"/>.</returns>
        public static ProjectsSettings GetDefault() => new ProjectsSettings();

        /// <summary>Constructs a new <see cref="ProjectsSettings"/> object with default settings.</summary>
        public ProjectsSettings()
        {
        }

        private ProjectsSettings(ProjectsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetProjectSettings = existing.GetProjectSettings;
            ListProjectsSettings = existing.ListProjectsSettings;
            SearchProjectsSettings = existing.SearchProjectsSettings;
            CreateProjectSettings = existing.CreateProjectSettings;
            CreateProjectOperationsSettings = existing.CreateProjectOperationsSettings.Clone();
            UpdateProjectSettings = existing.UpdateProjectSettings;
            UpdateProjectOperationsSettings = existing.UpdateProjectOperationsSettings.Clone();
            MoveProjectSettings = existing.MoveProjectSettings;
            MoveProjectOperationsSettings = existing.MoveProjectOperationsSettings.Clone();
            DeleteProjectSettings = existing.DeleteProjectSettings;
            DeleteProjectOperationsSettings = existing.DeleteProjectOperationsSettings.Clone();
            UndeleteProjectSettings = existing.UndeleteProjectSettings;
            UndeleteProjectOperationsSettings = existing.UndeleteProjectOperationsSettings.Clone();
            GetIamPolicySettings = existing.GetIamPolicySettings;
            SetIamPolicySettings = existing.SetIamPolicySettings;
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ProjectsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ProjectsClient.GetProject</c>
        ///  and <c>ProjectsClient.GetProjectAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetProjectSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ProjectsClient.ListProjects</c>
        ///  and <c>ProjectsClient.ListProjectsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListProjectsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProjectsClient.SearchProjects</c> and <c>ProjectsClient.SearchProjectsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchProjectsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProjectsClient.CreateProject</c> and <c>ProjectsClient.CreateProjectAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateProjectSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ProjectsClient.CreateProject</c> and
        /// <c>ProjectsClient.CreateProjectAsync</c>.
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
        public lro::OperationsSettings CreateProjectOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProjectsClient.UpdateProject</c> and <c>ProjectsClient.UpdateProjectAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateProjectSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ProjectsClient.UpdateProject</c> and
        /// <c>ProjectsClient.UpdateProjectAsync</c>.
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
        public lro::OperationsSettings UpdateProjectOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ProjectsClient.MoveProject</c>
        ///  and <c>ProjectsClient.MoveProjectAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MoveProjectSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ProjectsClient.MoveProject</c> and
        /// <c>ProjectsClient.MoveProjectAsync</c>.
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
        public lro::OperationsSettings MoveProjectOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProjectsClient.DeleteProject</c> and <c>ProjectsClient.DeleteProjectAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteProjectSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ProjectsClient.DeleteProject</c> and
        /// <c>ProjectsClient.DeleteProjectAsync</c>.
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
        public lro::OperationsSettings DeleteProjectOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProjectsClient.UndeleteProject</c> and <c>ProjectsClient.UndeleteProjectAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UndeleteProjectSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ProjectsClient.UndeleteProject</c> and
        /// <c>ProjectsClient.UndeleteProjectAsync</c>.
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
        public lro::OperationsSettings UndeleteProjectOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ProjectsClient.GetIamPolicy</c>
        ///  and <c>ProjectsClient.GetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetIamPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ProjectsClient.SetIamPolicy</c>
        ///  and <c>ProjectsClient.SetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProjectsClient.TestIamPermissions</c> and <c>ProjectsClient.TestIamPermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TestIamPermissionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ProjectsSettings"/> object.</returns>
        public ProjectsSettings Clone() => new ProjectsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ProjectsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class ProjectsClientBuilder : gaxgrpc::ClientBuilderBase<ProjectsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ProjectsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ProjectsClientBuilder() : base(ProjectsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ProjectsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ProjectsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ProjectsClient Build()
        {
            ProjectsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ProjectsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ProjectsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ProjectsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ProjectsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ProjectsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ProjectsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ProjectsClient.ChannelPool;
    }

    /// <summary>Projects client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Manages Google Cloud Projects.
    /// </remarks>
    public abstract partial class ProjectsClient
    {
        /// <summary>
        /// The default endpoint for the Projects service, which is a host of "cloudresourcemanager.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloudresourcemanager.googleapis.com:443";

        /// <summary>The default Projects scopes.</summary>
        /// <remarks>
        /// The default Projects scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform.read-only</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud-platform.read-only",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Projects.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ProjectsClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="ProjectsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ProjectsClient"/>.</returns>
        public static stt::Task<ProjectsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ProjectsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ProjectsClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="ProjectsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ProjectsClient"/>.</returns>
        public static ProjectsClient Create() => new ProjectsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ProjectsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ProjectsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ProjectsClient"/>.</returns>
        internal static ProjectsClient Create(grpccore::CallInvoker callInvoker, ProjectsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Projects.ProjectsClient grpcClient = new Projects.ProjectsClient(callInvoker);
            return new ProjectsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Projects client</summary>
        public virtual Projects.ProjectsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the project identified by the specified `name` (for example,
        /// `projects/415104041262`).
        /// 
        /// The caller must have `resourcemanager.projects.get` permission
        /// for this project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Project GetProject(GetProjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the project identified by the specified `name` (for example,
        /// `projects/415104041262`).
        /// 
        /// The caller must have `resourcemanager.projects.get` permission
        /// for this project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Project> GetProjectAsync(GetProjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the project identified by the specified `name` (for example,
        /// `projects/415104041262`).
        /// 
        /// The caller must have `resourcemanager.projects.get` permission
        /// for this project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Project> GetProjectAsync(GetProjectRequest request, st::CancellationToken cancellationToken) =>
            GetProjectAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the project identified by the specified `name` (for example,
        /// `projects/415104041262`).
        /// 
        /// The caller must have `resourcemanager.projects.get` permission
        /// for this project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the project (for example, `projects/415104041262`).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Project GetProject(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProject(new GetProjectRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the project identified by the specified `name` (for example,
        /// `projects/415104041262`).
        /// 
        /// The caller must have `resourcemanager.projects.get` permission
        /// for this project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the project (for example, `projects/415104041262`).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Project> GetProjectAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProjectAsync(new GetProjectRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the project identified by the specified `name` (for example,
        /// `projects/415104041262`).
        /// 
        /// The caller must have `resourcemanager.projects.get` permission
        /// for this project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the project (for example, `projects/415104041262`).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Project> GetProjectAsync(string name, st::CancellationToken cancellationToken) =>
            GetProjectAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the project identified by the specified `name` (for example,
        /// `projects/415104041262`).
        /// 
        /// The caller must have `resourcemanager.projects.get` permission
        /// for this project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the project (for example, `projects/415104041262`).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Project GetProject(gagr::ProjectName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProject(new GetProjectRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the project identified by the specified `name` (for example,
        /// `projects/415104041262`).
        /// 
        /// The caller must have `resourcemanager.projects.get` permission
        /// for this project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the project (for example, `projects/415104041262`).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Project> GetProjectAsync(gagr::ProjectName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProjectAsync(new GetProjectRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the project identified by the specified `name` (for example,
        /// `projects/415104041262`).
        /// 
        /// The caller must have `resourcemanager.projects.get` permission
        /// for this project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the project (for example, `projects/415104041262`).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Project> GetProjectAsync(gagr::ProjectName name, st::CancellationToken cancellationToken) =>
            GetProjectAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists projects that are direct children of the specified folder or
        /// organization resource. `list()` provides a strongly consistent view of the
        /// projects underneath the specified parent resource. `list()` returns
        /// projects sorted based upon the (ascending) lexical ordering of their
        /// `display_name`. The caller must have `resourcemanager.projects.list`
        /// permission on the identified parent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Project"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProjectsResponse, Project> ListProjects(ListProjectsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists projects that are direct children of the specified folder or
        /// organization resource. `list()` provides a strongly consistent view of the
        /// projects underneath the specified parent resource. `list()` returns
        /// projects sorted based upon the (ascending) lexical ordering of their
        /// `display_name`. The caller must have `resourcemanager.projects.list`
        /// permission on the identified parent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Project"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProjectsResponse, Project> ListProjectsAsync(ListProjectsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists projects that are direct children of the specified folder or
        /// organization resource. `list()` provides a strongly consistent view of the
        /// projects underneath the specified parent resource. `list()` returns
        /// projects sorted based upon the (ascending) lexical ordering of their
        /// `display_name`. The caller must have `resourcemanager.projects.list`
        /// permission on the identified parent.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource whose projects are being listed.
        /// Only children of this parent resource are listed; descendants are not
        /// listed.
        /// 
        /// If the parent is a folder, use the value `folders/{folder_id}`. If the
        /// parent is an organization, use the value `organizations/{org_id}`.
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
        /// <returns>A pageable sequence of <see cref="Project"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProjectsResponse, Project> ListProjects(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProjectsRequest request = new ListProjectsRequest
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
            return ListProjects(request, callSettings);
        }

        /// <summary>
        /// Lists projects that are direct children of the specified folder or
        /// organization resource. `list()` provides a strongly consistent view of the
        /// projects underneath the specified parent resource. `list()` returns
        /// projects sorted based upon the (ascending) lexical ordering of their
        /// `display_name`. The caller must have `resourcemanager.projects.list`
        /// permission on the identified parent.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource whose projects are being listed.
        /// Only children of this parent resource are listed; descendants are not
        /// listed.
        /// 
        /// If the parent is a folder, use the value `folders/{folder_id}`. If the
        /// parent is an organization, use the value `organizations/{org_id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Project"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProjectsResponse, Project> ListProjectsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProjectsRequest request = new ListProjectsRequest
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
            return ListProjectsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists projects that are direct children of the specified folder or
        /// organization resource. `list()` provides a strongly consistent view of the
        /// projects underneath the specified parent resource. `list()` returns
        /// projects sorted based upon the (ascending) lexical ordering of their
        /// `display_name`. The caller must have `resourcemanager.projects.list`
        /// permission on the identified parent.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource whose projects are being listed.
        /// Only children of this parent resource are listed; descendants are not
        /// listed.
        /// 
        /// If the parent is a folder, use the value `folders/{folder_id}`. If the
        /// parent is an organization, use the value `organizations/{org_id}`.
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
        /// <returns>A pageable sequence of <see cref="Project"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProjectsResponse, Project> ListProjects(gax::IResourceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProjectsRequest request = new ListProjectsRequest
            {
                ParentAsResourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListProjects(request, callSettings);
        }

        /// <summary>
        /// Lists projects that are direct children of the specified folder or
        /// organization resource. `list()` provides a strongly consistent view of the
        /// projects underneath the specified parent resource. `list()` returns
        /// projects sorted based upon the (ascending) lexical ordering of their
        /// `display_name`. The caller must have `resourcemanager.projects.list`
        /// permission on the identified parent.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource whose projects are being listed.
        /// Only children of this parent resource are listed; descendants are not
        /// listed.
        /// 
        /// If the parent is a folder, use the value `folders/{folder_id}`. If the
        /// parent is an organization, use the value `organizations/{org_id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Project"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProjectsResponse, Project> ListProjectsAsync(gax::IResourceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProjectsRequest request = new ListProjectsRequest
            {
                ParentAsResourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListProjectsAsync(request, callSettings);
        }

        /// <summary>
        /// Search for projects that the caller has both `resourcemanager.projects.get`
        /// permission on, and also satisfy the specified query.
        /// 
        /// This method returns projects in an unspecified order.
        /// 
        /// This method is eventually consistent with project mutations; this means
        /// that a newly created project may not appear in the results or recent
        /// updates to an existing project may not be reflected in the results. To
        /// retrieve the latest state of a project, use the
        /// [GetProject][google.cloud.resourcemanager.v3.Projects.GetProject] method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Project"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchProjectsResponse, Project> SearchProjects(SearchProjectsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Search for projects that the caller has both `resourcemanager.projects.get`
        /// permission on, and also satisfy the specified query.
        /// 
        /// This method returns projects in an unspecified order.
        /// 
        /// This method is eventually consistent with project mutations; this means
        /// that a newly created project may not appear in the results or recent
        /// updates to an existing project may not be reflected in the results. To
        /// retrieve the latest state of a project, use the
        /// [GetProject][google.cloud.resourcemanager.v3.Projects.GetProject] method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Project"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchProjectsResponse, Project> SearchProjectsAsync(SearchProjectsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Search for projects that the caller has both `resourcemanager.projects.get`
        /// permission on, and also satisfy the specified query.
        /// 
        /// This method returns projects in an unspecified order.
        /// 
        /// This method is eventually consistent with project mutations; this means
        /// that a newly created project may not appear in the results or recent
        /// updates to an existing project may not be reflected in the results. To
        /// retrieve the latest state of a project, use the
        /// [GetProject][google.cloud.resourcemanager.v3.Projects.GetProject] method.
        /// </summary>
        /// <param name="query">
        /// Optional. A query string for searching for projects that the caller has
        /// `resourcemanager.projects.get` permission to. If multiple fields are
        /// included in the query, then it will return results that match any of the
        /// fields. Some eligible fields are:
        /// 
        /// - **`displayName`, `name`**: Filters by displayName.
        /// - **`parent`**: Project's parent (for example: `folders/123`,
        /// `organizations/*`). Prefer `parent` field over `parent.type` and
        /// `parent.id`.
        /// - **`parent.type`**: Parent's type: `folder` or `organization`.
        /// - **`parent.id`**: Parent's id number (for example: `123`).
        /// - **`id`, `projectId`**: Filters by projectId.
        /// - **`state`, `lifecycleState`**: Filters by state.
        /// - **`labels`**: Filters by label name or value.
        /// - **`labels.&lt;key&gt;` (where `&lt;key&gt;` is the name of a label)**: Filters by label
        /// name.
        /// 
        /// Search expressions are case insensitive.
        /// 
        /// Some examples queries:
        /// 
        /// 
        /// - **`name:how*`**: The project's name starts with "how".
        /// - **`name:Howl`**: The project's name is `Howl` or `howl`.
        /// - **`name:HOWL`**: Equivalent to above.
        /// - **`NAME:howl`**: Equivalent to above.
        /// - **`labels.color:*`**: The project has the label `color`.
        /// - **`labels.color:red`**:  The project's label `color` has the value `red`.
        /// - **`labels.color:red labels.size:big`**: The project's label `color` has
        /// the value `red` or its label `size` has the value `big`.
        /// 
        /// If no query is specified, the call will return projects for which the user
        /// has the `resourcemanager.projects.get` permission.
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
        /// <returns>A pageable sequence of <see cref="Project"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchProjectsResponse, Project> SearchProjects(string query, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchProjectsRequest request = new SearchProjectsRequest { Query = query ?? "", };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchProjects(request, callSettings);
        }

        /// <summary>
        /// Search for projects that the caller has both `resourcemanager.projects.get`
        /// permission on, and also satisfy the specified query.
        /// 
        /// This method returns projects in an unspecified order.
        /// 
        /// This method is eventually consistent with project mutations; this means
        /// that a newly created project may not appear in the results or recent
        /// updates to an existing project may not be reflected in the results. To
        /// retrieve the latest state of a project, use the
        /// [GetProject][google.cloud.resourcemanager.v3.Projects.GetProject] method.
        /// </summary>
        /// <param name="query">
        /// Optional. A query string for searching for projects that the caller has
        /// `resourcemanager.projects.get` permission to. If multiple fields are
        /// included in the query, then it will return results that match any of the
        /// fields. Some eligible fields are:
        /// 
        /// - **`displayName`, `name`**: Filters by displayName.
        /// - **`parent`**: Project's parent (for example: `folders/123`,
        /// `organizations/*`). Prefer `parent` field over `parent.type` and
        /// `parent.id`.
        /// - **`parent.type`**: Parent's type: `folder` or `organization`.
        /// - **`parent.id`**: Parent's id number (for example: `123`).
        /// - **`id`, `projectId`**: Filters by projectId.
        /// - **`state`, `lifecycleState`**: Filters by state.
        /// - **`labels`**: Filters by label name or value.
        /// - **`labels.&lt;key&gt;` (where `&lt;key&gt;` is the name of a label)**: Filters by label
        /// name.
        /// 
        /// Search expressions are case insensitive.
        /// 
        /// Some examples queries:
        /// 
        /// 
        /// - **`name:how*`**: The project's name starts with "how".
        /// - **`name:Howl`**: The project's name is `Howl` or `howl`.
        /// - **`name:HOWL`**: Equivalent to above.
        /// - **`NAME:howl`**: Equivalent to above.
        /// - **`labels.color:*`**: The project has the label `color`.
        /// - **`labels.color:red`**:  The project's label `color` has the value `red`.
        /// - **`labels.color:red labels.size:big`**: The project's label `color` has
        /// the value `red` or its label `size` has the value `big`.
        /// 
        /// If no query is specified, the call will return projects for which the user
        /// has the `resourcemanager.projects.get` permission.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Project"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchProjectsResponse, Project> SearchProjectsAsync(string query, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchProjectsRequest request = new SearchProjectsRequest { Query = query ?? "", };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchProjectsAsync(request, callSettings);
        }

        /// <summary>
        /// Request that a new project be created. The result is an `Operation` which
        /// can be used to track the creation process. This process usually takes a few
        /// seconds, but can sometimes take much longer. The tracking `Operation` is
        /// automatically deleted after a few hours, so there is no need to call
        /// `DeleteOperation`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Project, CreateProjectMetadata> CreateProject(CreateProjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Request that a new project be created. The result is an `Operation` which
        /// can be used to track the creation process. This process usually takes a few
        /// seconds, but can sometimes take much longer. The tracking `Operation` is
        /// automatically deleted after a few hours, so there is no need to call
        /// `DeleteOperation`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Project, CreateProjectMetadata>> CreateProjectAsync(CreateProjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Request that a new project be created. The result is an `Operation` which
        /// can be used to track the creation process. This process usually takes a few
        /// seconds, but can sometimes take much longer. The tracking `Operation` is
        /// automatically deleted after a few hours, so there is no need to call
        /// `DeleteOperation`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Project, CreateProjectMetadata>> CreateProjectAsync(CreateProjectRequest request, st::CancellationToken cancellationToken) =>
            CreateProjectAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateProject</c>.</summary>
        public virtual lro::OperationsClient CreateProjectOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateProject</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Project, CreateProjectMetadata> PollOnceCreateProject(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Project, CreateProjectMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateProjectOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateProject</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Project, CreateProjectMetadata>> PollOnceCreateProjectAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Project, CreateProjectMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateProjectOperationsClient, callSettings);

        /// <summary>
        /// Request that a new project be created. The result is an `Operation` which
        /// can be used to track the creation process. This process usually takes a few
        /// seconds, but can sometimes take much longer. The tracking `Operation` is
        /// automatically deleted after a few hours, so there is no need to call
        /// `DeleteOperation`.
        /// </summary>
        /// <param name="project">
        /// Required. The Project to create.
        /// 
        /// Project ID is required. If the requested ID is unavailable, the request
        /// fails.
        /// 
        /// If the `parent` field is set, the `resourcemanager.projects.create`
        /// permission is checked on the parent resource. If no parent is set and
        /// the authorization credentials belong to an Organization, the parent
        /// will be set to that Organization.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Project, CreateProjectMetadata> CreateProject(Project project, gaxgrpc::CallSettings callSettings = null) =>
            CreateProject(new CreateProjectRequest
            {
                Project = gax::GaxPreconditions.CheckNotNull(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Request that a new project be created. The result is an `Operation` which
        /// can be used to track the creation process. This process usually takes a few
        /// seconds, but can sometimes take much longer. The tracking `Operation` is
        /// automatically deleted after a few hours, so there is no need to call
        /// `DeleteOperation`.
        /// </summary>
        /// <param name="project">
        /// Required. The Project to create.
        /// 
        /// Project ID is required. If the requested ID is unavailable, the request
        /// fails.
        /// 
        /// If the `parent` field is set, the `resourcemanager.projects.create`
        /// permission is checked on the parent resource. If no parent is set and
        /// the authorization credentials belong to an Organization, the parent
        /// will be set to that Organization.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Project, CreateProjectMetadata>> CreateProjectAsync(Project project, gaxgrpc::CallSettings callSettings = null) =>
            CreateProjectAsync(new CreateProjectRequest
            {
                Project = gax::GaxPreconditions.CheckNotNull(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Request that a new project be created. The result is an `Operation` which
        /// can be used to track the creation process. This process usually takes a few
        /// seconds, but can sometimes take much longer. The tracking `Operation` is
        /// automatically deleted after a few hours, so there is no need to call
        /// `DeleteOperation`.
        /// </summary>
        /// <param name="project">
        /// Required. The Project to create.
        /// 
        /// Project ID is required. If the requested ID is unavailable, the request
        /// fails.
        /// 
        /// If the `parent` field is set, the `resourcemanager.projects.create`
        /// permission is checked on the parent resource. If no parent is set and
        /// the authorization credentials belong to an Organization, the parent
        /// will be set to that Organization.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Project, CreateProjectMetadata>> CreateProjectAsync(Project project, st::CancellationToken cancellationToken) =>
            CreateProjectAsync(project, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the `display_name` and labels of the project identified by the
        /// specified `name` (for example, `projects/415104041262`). Deleting all
        /// labels requires an update mask for labels field.
        /// 
        /// The caller must have `resourcemanager.projects.update` permission for this
        /// project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Project, UpdateProjectMetadata> UpdateProject(UpdateProjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the `display_name` and labels of the project identified by the
        /// specified `name` (for example, `projects/415104041262`). Deleting all
        /// labels requires an update mask for labels field.
        /// 
        /// The caller must have `resourcemanager.projects.update` permission for this
        /// project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Project, UpdateProjectMetadata>> UpdateProjectAsync(UpdateProjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the `display_name` and labels of the project identified by the
        /// specified `name` (for example, `projects/415104041262`). Deleting all
        /// labels requires an update mask for labels field.
        /// 
        /// The caller must have `resourcemanager.projects.update` permission for this
        /// project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Project, UpdateProjectMetadata>> UpdateProjectAsync(UpdateProjectRequest request, st::CancellationToken cancellationToken) =>
            UpdateProjectAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateProject</c>.</summary>
        public virtual lro::OperationsClient UpdateProjectOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateProject</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Project, UpdateProjectMetadata> PollOnceUpdateProject(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Project, UpdateProjectMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateProjectOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateProject</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Project, UpdateProjectMetadata>> PollOnceUpdateProjectAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Project, UpdateProjectMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateProjectOperationsClient, callSettings);

        /// <summary>
        /// Updates the `display_name` and labels of the project identified by the
        /// specified `name` (for example, `projects/415104041262`). Deleting all
        /// labels requires an update mask for labels field.
        /// 
        /// The caller must have `resourcemanager.projects.update` permission for this
        /// project.
        /// </summary>
        /// <param name="project">
        /// Required. The new definition of the project.
        /// </param>
        /// <param name="updateMask">
        /// Optional. An update mask to selectively update fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Project, UpdateProjectMetadata> UpdateProject(Project project, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateProject(new UpdateProjectRequest
            {
                Project = gax::GaxPreconditions.CheckNotNull(project, nameof(project)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the `display_name` and labels of the project identified by the
        /// specified `name` (for example, `projects/415104041262`). Deleting all
        /// labels requires an update mask for labels field.
        /// 
        /// The caller must have `resourcemanager.projects.update` permission for this
        /// project.
        /// </summary>
        /// <param name="project">
        /// Required. The new definition of the project.
        /// </param>
        /// <param name="updateMask">
        /// Optional. An update mask to selectively update fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Project, UpdateProjectMetadata>> UpdateProjectAsync(Project project, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateProjectAsync(new UpdateProjectRequest
            {
                Project = gax::GaxPreconditions.CheckNotNull(project, nameof(project)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the `display_name` and labels of the project identified by the
        /// specified `name` (for example, `projects/415104041262`). Deleting all
        /// labels requires an update mask for labels field.
        /// 
        /// The caller must have `resourcemanager.projects.update` permission for this
        /// project.
        /// </summary>
        /// <param name="project">
        /// Required. The new definition of the project.
        /// </param>
        /// <param name="updateMask">
        /// Optional. An update mask to selectively update fields.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Project, UpdateProjectMetadata>> UpdateProjectAsync(Project project, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateProjectAsync(project, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Move a project to another place in your resource hierarchy, under a new
        /// resource parent.
        /// 
        /// Returns an operation which can be used to track the process of the project
        /// move workflow.
        /// Upon success, the `Operation.response` field will be populated with the
        /// moved project.
        /// 
        /// The caller must have `resourcemanager.projects.move` permission on the
        /// project, on the project's current and proposed new parent.
        /// 
        /// If project has no current parent, or it currently does not have an
        /// associated organization resource, you will also need the
        /// `resourcemanager.projects.setIamPolicy` permission in the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Project, MoveProjectMetadata> MoveProject(MoveProjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Move a project to another place in your resource hierarchy, under a new
        /// resource parent.
        /// 
        /// Returns an operation which can be used to track the process of the project
        /// move workflow.
        /// Upon success, the `Operation.response` field will be populated with the
        /// moved project.
        /// 
        /// The caller must have `resourcemanager.projects.move` permission on the
        /// project, on the project's current and proposed new parent.
        /// 
        /// If project has no current parent, or it currently does not have an
        /// associated organization resource, you will also need the
        /// `resourcemanager.projects.setIamPolicy` permission in the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Project, MoveProjectMetadata>> MoveProjectAsync(MoveProjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Move a project to another place in your resource hierarchy, under a new
        /// resource parent.
        /// 
        /// Returns an operation which can be used to track the process of the project
        /// move workflow.
        /// Upon success, the `Operation.response` field will be populated with the
        /// moved project.
        /// 
        /// The caller must have `resourcemanager.projects.move` permission on the
        /// project, on the project's current and proposed new parent.
        /// 
        /// If project has no current parent, or it currently does not have an
        /// associated organization resource, you will also need the
        /// `resourcemanager.projects.setIamPolicy` permission in the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Project, MoveProjectMetadata>> MoveProjectAsync(MoveProjectRequest request, st::CancellationToken cancellationToken) =>
            MoveProjectAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>MoveProject</c>.</summary>
        public virtual lro::OperationsClient MoveProjectOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>MoveProject</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Project, MoveProjectMetadata> PollOnceMoveProject(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Project, MoveProjectMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), MoveProjectOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>MoveProject</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Project, MoveProjectMetadata>> PollOnceMoveProjectAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Project, MoveProjectMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), MoveProjectOperationsClient, callSettings);

        /// <summary>
        /// Move a project to another place in your resource hierarchy, under a new
        /// resource parent.
        /// 
        /// Returns an operation which can be used to track the process of the project
        /// move workflow.
        /// Upon success, the `Operation.response` field will be populated with the
        /// moved project.
        /// 
        /// The caller must have `resourcemanager.projects.move` permission on the
        /// project, on the project's current and proposed new parent.
        /// 
        /// If project has no current parent, or it currently does not have an
        /// associated organization resource, you will also need the
        /// `resourcemanager.projects.setIamPolicy` permission in the project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the project to move.
        /// </param>
        /// <param name="destinationParent">
        /// Required. The new parent to move the Project under.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Project, MoveProjectMetadata> MoveProject(string name, string destinationParent, gaxgrpc::CallSettings callSettings = null) =>
            MoveProject(new MoveProjectRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                DestinationParent = gax::GaxPreconditions.CheckNotNullOrEmpty(destinationParent, nameof(destinationParent)),
            }, callSettings);

        /// <summary>
        /// Move a project to another place in your resource hierarchy, under a new
        /// resource parent.
        /// 
        /// Returns an operation which can be used to track the process of the project
        /// move workflow.
        /// Upon success, the `Operation.response` field will be populated with the
        /// moved project.
        /// 
        /// The caller must have `resourcemanager.projects.move` permission on the
        /// project, on the project's current and proposed new parent.
        /// 
        /// If project has no current parent, or it currently does not have an
        /// associated organization resource, you will also need the
        /// `resourcemanager.projects.setIamPolicy` permission in the project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the project to move.
        /// </param>
        /// <param name="destinationParent">
        /// Required. The new parent to move the Project under.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Project, MoveProjectMetadata>> MoveProjectAsync(string name, string destinationParent, gaxgrpc::CallSettings callSettings = null) =>
            MoveProjectAsync(new MoveProjectRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                DestinationParent = gax::GaxPreconditions.CheckNotNullOrEmpty(destinationParent, nameof(destinationParent)),
            }, callSettings);

        /// <summary>
        /// Move a project to another place in your resource hierarchy, under a new
        /// resource parent.
        /// 
        /// Returns an operation which can be used to track the process of the project
        /// move workflow.
        /// Upon success, the `Operation.response` field will be populated with the
        /// moved project.
        /// 
        /// The caller must have `resourcemanager.projects.move` permission on the
        /// project, on the project's current and proposed new parent.
        /// 
        /// If project has no current parent, or it currently does not have an
        /// associated organization resource, you will also need the
        /// `resourcemanager.projects.setIamPolicy` permission in the project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the project to move.
        /// </param>
        /// <param name="destinationParent">
        /// Required. The new parent to move the Project under.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Project, MoveProjectMetadata>> MoveProjectAsync(string name, string destinationParent, st::CancellationToken cancellationToken) =>
            MoveProjectAsync(name, destinationParent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Move a project to another place in your resource hierarchy, under a new
        /// resource parent.
        /// 
        /// Returns an operation which can be used to track the process of the project
        /// move workflow.
        /// Upon success, the `Operation.response` field will be populated with the
        /// moved project.
        /// 
        /// The caller must have `resourcemanager.projects.move` permission on the
        /// project, on the project's current and proposed new parent.
        /// 
        /// If project has no current parent, or it currently does not have an
        /// associated organization resource, you will also need the
        /// `resourcemanager.projects.setIamPolicy` permission in the project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the project to move.
        /// </param>
        /// <param name="destinationParent">
        /// Required. The new parent to move the Project under.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Project, MoveProjectMetadata> MoveProject(gagr::ProjectName name, gax::IResourceName destinationParent, gaxgrpc::CallSettings callSettings = null) =>
            MoveProject(new MoveProjectRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                DestinationParentAsResourceName = gax::GaxPreconditions.CheckNotNull(destinationParent, nameof(destinationParent)),
            }, callSettings);

        /// <summary>
        /// Move a project to another place in your resource hierarchy, under a new
        /// resource parent.
        /// 
        /// Returns an operation which can be used to track the process of the project
        /// move workflow.
        /// Upon success, the `Operation.response` field will be populated with the
        /// moved project.
        /// 
        /// The caller must have `resourcemanager.projects.move` permission on the
        /// project, on the project's current and proposed new parent.
        /// 
        /// If project has no current parent, or it currently does not have an
        /// associated organization resource, you will also need the
        /// `resourcemanager.projects.setIamPolicy` permission in the project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the project to move.
        /// </param>
        /// <param name="destinationParent">
        /// Required. The new parent to move the Project under.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Project, MoveProjectMetadata>> MoveProjectAsync(gagr::ProjectName name, gax::IResourceName destinationParent, gaxgrpc::CallSettings callSettings = null) =>
            MoveProjectAsync(new MoveProjectRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                DestinationParentAsResourceName = gax::GaxPreconditions.CheckNotNull(destinationParent, nameof(destinationParent)),
            }, callSettings);

        /// <summary>
        /// Move a project to another place in your resource hierarchy, under a new
        /// resource parent.
        /// 
        /// Returns an operation which can be used to track the process of the project
        /// move workflow.
        /// Upon success, the `Operation.response` field will be populated with the
        /// moved project.
        /// 
        /// The caller must have `resourcemanager.projects.move` permission on the
        /// project, on the project's current and proposed new parent.
        /// 
        /// If project has no current parent, or it currently does not have an
        /// associated organization resource, you will also need the
        /// `resourcemanager.projects.setIamPolicy` permission in the project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the project to move.
        /// </param>
        /// <param name="destinationParent">
        /// Required. The new parent to move the Project under.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Project, MoveProjectMetadata>> MoveProjectAsync(gagr::ProjectName name, gax::IResourceName destinationParent, st::CancellationToken cancellationToken) =>
            MoveProjectAsync(name, destinationParent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Marks the project identified by the specified
        /// `name` (for example, `projects/415104041262`) for deletion.
        /// 
        /// This method will only affect the project if it has a lifecycle state of
        /// [ACTIVE][google.cloud.resourcemanager.v3.Project.State.ACTIVE].
        /// 
        /// This method changes the Project's lifecycle state from
        /// [ACTIVE][google.cloud.resourcemanager.v3.Project.State.ACTIVE]
        /// to
        /// [DELETE_REQUESTED][google.cloud.resourcemanager.v3.Project.State.DELETE_REQUESTED].
        /// The deletion starts at an unspecified time,
        /// at which point the Project is no longer accessible.
        /// 
        /// Until the deletion completes, you can check the lifecycle state
        /// checked by retrieving the project with [GetProject]
        /// [google.cloud.resourcemanager.v3.Projects.GetProject],
        /// and the project remains visible to [ListProjects]
        /// [google.cloud.resourcemanager.v3.Projects.ListProjects].
        /// However, you cannot update the project.
        /// 
        /// After the deletion completes, the project is not retrievable by
        /// the  [GetProject]
        /// [google.cloud.resourcemanager.v3.Projects.GetProject],
        /// [ListProjects]
        /// [google.cloud.resourcemanager.v3.Projects.ListProjects], and
        /// [SearchProjects][google.cloud.resourcemanager.v3.Projects.SearchProjects]
        /// methods.
        /// 
        /// This method behaves idempotently, such that deleting a `DELETE_REQUESTED`
        /// project will not cause an error, but also won't do anything.
        /// 
        /// The caller must have `resourcemanager.projects.delete` permissions for this
        /// project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Project, DeleteProjectMetadata> DeleteProject(DeleteProjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Marks the project identified by the specified
        /// `name` (for example, `projects/415104041262`) for deletion.
        /// 
        /// This method will only affect the project if it has a lifecycle state of
        /// [ACTIVE][google.cloud.resourcemanager.v3.Project.State.ACTIVE].
        /// 
        /// This method changes the Project's lifecycle state from
        /// [ACTIVE][google.cloud.resourcemanager.v3.Project.State.ACTIVE]
        /// to
        /// [DELETE_REQUESTED][google.cloud.resourcemanager.v3.Project.State.DELETE_REQUESTED].
        /// The deletion starts at an unspecified time,
        /// at which point the Project is no longer accessible.
        /// 
        /// Until the deletion completes, you can check the lifecycle state
        /// checked by retrieving the project with [GetProject]
        /// [google.cloud.resourcemanager.v3.Projects.GetProject],
        /// and the project remains visible to [ListProjects]
        /// [google.cloud.resourcemanager.v3.Projects.ListProjects].
        /// However, you cannot update the project.
        /// 
        /// After the deletion completes, the project is not retrievable by
        /// the  [GetProject]
        /// [google.cloud.resourcemanager.v3.Projects.GetProject],
        /// [ListProjects]
        /// [google.cloud.resourcemanager.v3.Projects.ListProjects], and
        /// [SearchProjects][google.cloud.resourcemanager.v3.Projects.SearchProjects]
        /// methods.
        /// 
        /// This method behaves idempotently, such that deleting a `DELETE_REQUESTED`
        /// project will not cause an error, but also won't do anything.
        /// 
        /// The caller must have `resourcemanager.projects.delete` permissions for this
        /// project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Project, DeleteProjectMetadata>> DeleteProjectAsync(DeleteProjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Marks the project identified by the specified
        /// `name` (for example, `projects/415104041262`) for deletion.
        /// 
        /// This method will only affect the project if it has a lifecycle state of
        /// [ACTIVE][google.cloud.resourcemanager.v3.Project.State.ACTIVE].
        /// 
        /// This method changes the Project's lifecycle state from
        /// [ACTIVE][google.cloud.resourcemanager.v3.Project.State.ACTIVE]
        /// to
        /// [DELETE_REQUESTED][google.cloud.resourcemanager.v3.Project.State.DELETE_REQUESTED].
        /// The deletion starts at an unspecified time,
        /// at which point the Project is no longer accessible.
        /// 
        /// Until the deletion completes, you can check the lifecycle state
        /// checked by retrieving the project with [GetProject]
        /// [google.cloud.resourcemanager.v3.Projects.GetProject],
        /// and the project remains visible to [ListProjects]
        /// [google.cloud.resourcemanager.v3.Projects.ListProjects].
        /// However, you cannot update the project.
        /// 
        /// After the deletion completes, the project is not retrievable by
        /// the  [GetProject]
        /// [google.cloud.resourcemanager.v3.Projects.GetProject],
        /// [ListProjects]
        /// [google.cloud.resourcemanager.v3.Projects.ListProjects], and
        /// [SearchProjects][google.cloud.resourcemanager.v3.Projects.SearchProjects]
        /// methods.
        /// 
        /// This method behaves idempotently, such that deleting a `DELETE_REQUESTED`
        /// project will not cause an error, but also won't do anything.
        /// 
        /// The caller must have `resourcemanager.projects.delete` permissions for this
        /// project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Project, DeleteProjectMetadata>> DeleteProjectAsync(DeleteProjectRequest request, st::CancellationToken cancellationToken) =>
            DeleteProjectAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteProject</c>.</summary>
        public virtual lro::OperationsClient DeleteProjectOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteProject</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Project, DeleteProjectMetadata> PollOnceDeleteProject(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Project, DeleteProjectMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteProjectOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteProject</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Project, DeleteProjectMetadata>> PollOnceDeleteProjectAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Project, DeleteProjectMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteProjectOperationsClient, callSettings);

        /// <summary>
        /// Marks the project identified by the specified
        /// `name` (for example, `projects/415104041262`) for deletion.
        /// 
        /// This method will only affect the project if it has a lifecycle state of
        /// [ACTIVE][google.cloud.resourcemanager.v3.Project.State.ACTIVE].
        /// 
        /// This method changes the Project's lifecycle state from
        /// [ACTIVE][google.cloud.resourcemanager.v3.Project.State.ACTIVE]
        /// to
        /// [DELETE_REQUESTED][google.cloud.resourcemanager.v3.Project.State.DELETE_REQUESTED].
        /// The deletion starts at an unspecified time,
        /// at which point the Project is no longer accessible.
        /// 
        /// Until the deletion completes, you can check the lifecycle state
        /// checked by retrieving the project with [GetProject]
        /// [google.cloud.resourcemanager.v3.Projects.GetProject],
        /// and the project remains visible to [ListProjects]
        /// [google.cloud.resourcemanager.v3.Projects.ListProjects].
        /// However, you cannot update the project.
        /// 
        /// After the deletion completes, the project is not retrievable by
        /// the  [GetProject]
        /// [google.cloud.resourcemanager.v3.Projects.GetProject],
        /// [ListProjects]
        /// [google.cloud.resourcemanager.v3.Projects.ListProjects], and
        /// [SearchProjects][google.cloud.resourcemanager.v3.Projects.SearchProjects]
        /// methods.
        /// 
        /// This method behaves idempotently, such that deleting a `DELETE_REQUESTED`
        /// project will not cause an error, but also won't do anything.
        /// 
        /// The caller must have `resourcemanager.projects.delete` permissions for this
        /// project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Project (for example, `projects/415104041262`).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Project, DeleteProjectMetadata> DeleteProject(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProject(new DeleteProjectRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Marks the project identified by the specified
        /// `name` (for example, `projects/415104041262`) for deletion.
        /// 
        /// This method will only affect the project if it has a lifecycle state of
        /// [ACTIVE][google.cloud.resourcemanager.v3.Project.State.ACTIVE].
        /// 
        /// This method changes the Project's lifecycle state from
        /// [ACTIVE][google.cloud.resourcemanager.v3.Project.State.ACTIVE]
        /// to
        /// [DELETE_REQUESTED][google.cloud.resourcemanager.v3.Project.State.DELETE_REQUESTED].
        /// The deletion starts at an unspecified time,
        /// at which point the Project is no longer accessible.
        /// 
        /// Until the deletion completes, you can check the lifecycle state
        /// checked by retrieving the project with [GetProject]
        /// [google.cloud.resourcemanager.v3.Projects.GetProject],
        /// and the project remains visible to [ListProjects]
        /// [google.cloud.resourcemanager.v3.Projects.ListProjects].
        /// However, you cannot update the project.
        /// 
        /// After the deletion completes, the project is not retrievable by
        /// the  [GetProject]
        /// [google.cloud.resourcemanager.v3.Projects.GetProject],
        /// [ListProjects]
        /// [google.cloud.resourcemanager.v3.Projects.ListProjects], and
        /// [SearchProjects][google.cloud.resourcemanager.v3.Projects.SearchProjects]
        /// methods.
        /// 
        /// This method behaves idempotently, such that deleting a `DELETE_REQUESTED`
        /// project will not cause an error, but also won't do anything.
        /// 
        /// The caller must have `resourcemanager.projects.delete` permissions for this
        /// project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Project (for example, `projects/415104041262`).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Project, DeleteProjectMetadata>> DeleteProjectAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProjectAsync(new DeleteProjectRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Marks the project identified by the specified
        /// `name` (for example, `projects/415104041262`) for deletion.
        /// 
        /// This method will only affect the project if it has a lifecycle state of
        /// [ACTIVE][google.cloud.resourcemanager.v3.Project.State.ACTIVE].
        /// 
        /// This method changes the Project's lifecycle state from
        /// [ACTIVE][google.cloud.resourcemanager.v3.Project.State.ACTIVE]
        /// to
        /// [DELETE_REQUESTED][google.cloud.resourcemanager.v3.Project.State.DELETE_REQUESTED].
        /// The deletion starts at an unspecified time,
        /// at which point the Project is no longer accessible.
        /// 
        /// Until the deletion completes, you can check the lifecycle state
        /// checked by retrieving the project with [GetProject]
        /// [google.cloud.resourcemanager.v3.Projects.GetProject],
        /// and the project remains visible to [ListProjects]
        /// [google.cloud.resourcemanager.v3.Projects.ListProjects].
        /// However, you cannot update the project.
        /// 
        /// After the deletion completes, the project is not retrievable by
        /// the  [GetProject]
        /// [google.cloud.resourcemanager.v3.Projects.GetProject],
        /// [ListProjects]
        /// [google.cloud.resourcemanager.v3.Projects.ListProjects], and
        /// [SearchProjects][google.cloud.resourcemanager.v3.Projects.SearchProjects]
        /// methods.
        /// 
        /// This method behaves idempotently, such that deleting a `DELETE_REQUESTED`
        /// project will not cause an error, but also won't do anything.
        /// 
        /// The caller must have `resourcemanager.projects.delete` permissions for this
        /// project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Project (for example, `projects/415104041262`).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Project, DeleteProjectMetadata>> DeleteProjectAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteProjectAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Marks the project identified by the specified
        /// `name` (for example, `projects/415104041262`) for deletion.
        /// 
        /// This method will only affect the project if it has a lifecycle state of
        /// [ACTIVE][google.cloud.resourcemanager.v3.Project.State.ACTIVE].
        /// 
        /// This method changes the Project's lifecycle state from
        /// [ACTIVE][google.cloud.resourcemanager.v3.Project.State.ACTIVE]
        /// to
        /// [DELETE_REQUESTED][google.cloud.resourcemanager.v3.Project.State.DELETE_REQUESTED].
        /// The deletion starts at an unspecified time,
        /// at which point the Project is no longer accessible.
        /// 
        /// Until the deletion completes, you can check the lifecycle state
        /// checked by retrieving the project with [GetProject]
        /// [google.cloud.resourcemanager.v3.Projects.GetProject],
        /// and the project remains visible to [ListProjects]
        /// [google.cloud.resourcemanager.v3.Projects.ListProjects].
        /// However, you cannot update the project.
        /// 
        /// After the deletion completes, the project is not retrievable by
        /// the  [GetProject]
        /// [google.cloud.resourcemanager.v3.Projects.GetProject],
        /// [ListProjects]
        /// [google.cloud.resourcemanager.v3.Projects.ListProjects], and
        /// [SearchProjects][google.cloud.resourcemanager.v3.Projects.SearchProjects]
        /// methods.
        /// 
        /// This method behaves idempotently, such that deleting a `DELETE_REQUESTED`
        /// project will not cause an error, but also won't do anything.
        /// 
        /// The caller must have `resourcemanager.projects.delete` permissions for this
        /// project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Project (for example, `projects/415104041262`).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Project, DeleteProjectMetadata> DeleteProject(gagr::ProjectName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProject(new DeleteProjectRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Marks the project identified by the specified
        /// `name` (for example, `projects/415104041262`) for deletion.
        /// 
        /// This method will only affect the project if it has a lifecycle state of
        /// [ACTIVE][google.cloud.resourcemanager.v3.Project.State.ACTIVE].
        /// 
        /// This method changes the Project's lifecycle state from
        /// [ACTIVE][google.cloud.resourcemanager.v3.Project.State.ACTIVE]
        /// to
        /// [DELETE_REQUESTED][google.cloud.resourcemanager.v3.Project.State.DELETE_REQUESTED].
        /// The deletion starts at an unspecified time,
        /// at which point the Project is no longer accessible.
        /// 
        /// Until the deletion completes, you can check the lifecycle state
        /// checked by retrieving the project with [GetProject]
        /// [google.cloud.resourcemanager.v3.Projects.GetProject],
        /// and the project remains visible to [ListProjects]
        /// [google.cloud.resourcemanager.v3.Projects.ListProjects].
        /// However, you cannot update the project.
        /// 
        /// After the deletion completes, the project is not retrievable by
        /// the  [GetProject]
        /// [google.cloud.resourcemanager.v3.Projects.GetProject],
        /// [ListProjects]
        /// [google.cloud.resourcemanager.v3.Projects.ListProjects], and
        /// [SearchProjects][google.cloud.resourcemanager.v3.Projects.SearchProjects]
        /// methods.
        /// 
        /// This method behaves idempotently, such that deleting a `DELETE_REQUESTED`
        /// project will not cause an error, but also won't do anything.
        /// 
        /// The caller must have `resourcemanager.projects.delete` permissions for this
        /// project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Project (for example, `projects/415104041262`).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Project, DeleteProjectMetadata>> DeleteProjectAsync(gagr::ProjectName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProjectAsync(new DeleteProjectRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Marks the project identified by the specified
        /// `name` (for example, `projects/415104041262`) for deletion.
        /// 
        /// This method will only affect the project if it has a lifecycle state of
        /// [ACTIVE][google.cloud.resourcemanager.v3.Project.State.ACTIVE].
        /// 
        /// This method changes the Project's lifecycle state from
        /// [ACTIVE][google.cloud.resourcemanager.v3.Project.State.ACTIVE]
        /// to
        /// [DELETE_REQUESTED][google.cloud.resourcemanager.v3.Project.State.DELETE_REQUESTED].
        /// The deletion starts at an unspecified time,
        /// at which point the Project is no longer accessible.
        /// 
        /// Until the deletion completes, you can check the lifecycle state
        /// checked by retrieving the project with [GetProject]
        /// [google.cloud.resourcemanager.v3.Projects.GetProject],
        /// and the project remains visible to [ListProjects]
        /// [google.cloud.resourcemanager.v3.Projects.ListProjects].
        /// However, you cannot update the project.
        /// 
        /// After the deletion completes, the project is not retrievable by
        /// the  [GetProject]
        /// [google.cloud.resourcemanager.v3.Projects.GetProject],
        /// [ListProjects]
        /// [google.cloud.resourcemanager.v3.Projects.ListProjects], and
        /// [SearchProjects][google.cloud.resourcemanager.v3.Projects.SearchProjects]
        /// methods.
        /// 
        /// This method behaves idempotently, such that deleting a `DELETE_REQUESTED`
        /// project will not cause an error, but also won't do anything.
        /// 
        /// The caller must have `resourcemanager.projects.delete` permissions for this
        /// project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Project (for example, `projects/415104041262`).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Project, DeleteProjectMetadata>> DeleteProjectAsync(gagr::ProjectName name, st::CancellationToken cancellationToken) =>
            DeleteProjectAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Restores the project identified by the specified
        /// `name` (for example, `projects/415104041262`).
        /// You can only use this method for a project that has a lifecycle state of
        /// [DELETE_REQUESTED]
        /// [Projects.State.DELETE_REQUESTED].
        /// After deletion starts, the project cannot be restored.
        /// 
        /// The caller must have `resourcemanager.projects.undelete` permission for
        /// this project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Project, UndeleteProjectMetadata> UndeleteProject(UndeleteProjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Restores the project identified by the specified
        /// `name` (for example, `projects/415104041262`).
        /// You can only use this method for a project that has a lifecycle state of
        /// [DELETE_REQUESTED]
        /// [Projects.State.DELETE_REQUESTED].
        /// After deletion starts, the project cannot be restored.
        /// 
        /// The caller must have `resourcemanager.projects.undelete` permission for
        /// this project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Project, UndeleteProjectMetadata>> UndeleteProjectAsync(UndeleteProjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Restores the project identified by the specified
        /// `name` (for example, `projects/415104041262`).
        /// You can only use this method for a project that has a lifecycle state of
        /// [DELETE_REQUESTED]
        /// [Projects.State.DELETE_REQUESTED].
        /// After deletion starts, the project cannot be restored.
        /// 
        /// The caller must have `resourcemanager.projects.undelete` permission for
        /// this project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Project, UndeleteProjectMetadata>> UndeleteProjectAsync(UndeleteProjectRequest request, st::CancellationToken cancellationToken) =>
            UndeleteProjectAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UndeleteProject</c>.</summary>
        public virtual lro::OperationsClient UndeleteProjectOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UndeleteProject</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Project, UndeleteProjectMetadata> PollOnceUndeleteProject(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Project, UndeleteProjectMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UndeleteProjectOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UndeleteProject</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Project, UndeleteProjectMetadata>> PollOnceUndeleteProjectAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Project, UndeleteProjectMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UndeleteProjectOperationsClient, callSettings);

        /// <summary>
        /// Restores the project identified by the specified
        /// `name` (for example, `projects/415104041262`).
        /// You can only use this method for a project that has a lifecycle state of
        /// [DELETE_REQUESTED]
        /// [Projects.State.DELETE_REQUESTED].
        /// After deletion starts, the project cannot be restored.
        /// 
        /// The caller must have `resourcemanager.projects.undelete` permission for
        /// this project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the project (for example, `projects/415104041262`).
        /// 
        /// Required.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Project, UndeleteProjectMetadata> UndeleteProject(string name, gaxgrpc::CallSettings callSettings = null) =>
            UndeleteProject(new UndeleteProjectRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Restores the project identified by the specified
        /// `name` (for example, `projects/415104041262`).
        /// You can only use this method for a project that has a lifecycle state of
        /// [DELETE_REQUESTED]
        /// [Projects.State.DELETE_REQUESTED].
        /// After deletion starts, the project cannot be restored.
        /// 
        /// The caller must have `resourcemanager.projects.undelete` permission for
        /// this project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the project (for example, `projects/415104041262`).
        /// 
        /// Required.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Project, UndeleteProjectMetadata>> UndeleteProjectAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            UndeleteProjectAsync(new UndeleteProjectRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Restores the project identified by the specified
        /// `name` (for example, `projects/415104041262`).
        /// You can only use this method for a project that has a lifecycle state of
        /// [DELETE_REQUESTED]
        /// [Projects.State.DELETE_REQUESTED].
        /// After deletion starts, the project cannot be restored.
        /// 
        /// The caller must have `resourcemanager.projects.undelete` permission for
        /// this project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the project (for example, `projects/415104041262`).
        /// 
        /// Required.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Project, UndeleteProjectMetadata>> UndeleteProjectAsync(string name, st::CancellationToken cancellationToken) =>
            UndeleteProjectAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Restores the project identified by the specified
        /// `name` (for example, `projects/415104041262`).
        /// You can only use this method for a project that has a lifecycle state of
        /// [DELETE_REQUESTED]
        /// [Projects.State.DELETE_REQUESTED].
        /// After deletion starts, the project cannot be restored.
        /// 
        /// The caller must have `resourcemanager.projects.undelete` permission for
        /// this project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the project (for example, `projects/415104041262`).
        /// 
        /// Required.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Project, UndeleteProjectMetadata> UndeleteProject(gagr::ProjectName name, gaxgrpc::CallSettings callSettings = null) =>
            UndeleteProject(new UndeleteProjectRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Restores the project identified by the specified
        /// `name` (for example, `projects/415104041262`).
        /// You can only use this method for a project that has a lifecycle state of
        /// [DELETE_REQUESTED]
        /// [Projects.State.DELETE_REQUESTED].
        /// After deletion starts, the project cannot be restored.
        /// 
        /// The caller must have `resourcemanager.projects.undelete` permission for
        /// this project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the project (for example, `projects/415104041262`).
        /// 
        /// Required.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Project, UndeleteProjectMetadata>> UndeleteProjectAsync(gagr::ProjectName name, gaxgrpc::CallSettings callSettings = null) =>
            UndeleteProjectAsync(new UndeleteProjectRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Restores the project identified by the specified
        /// `name` (for example, `projects/415104041262`).
        /// You can only use this method for a project that has a lifecycle state of
        /// [DELETE_REQUESTED]
        /// [Projects.State.DELETE_REQUESTED].
        /// After deletion starts, the project cannot be restored.
        /// 
        /// The caller must have `resourcemanager.projects.undelete` permission for
        /// this project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the project (for example, `projects/415104041262`).
        /// 
        /// Required.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Project, UndeleteProjectMetadata>> UndeleteProjectAsync(gagr::ProjectName name, st::CancellationToken cancellationToken) =>
            UndeleteProjectAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the IAM access control policy for the specified project, in the
        /// format `projects/{ProjectIdOrNumber}` e.g. projects/123.
        /// Permission is denied if the policy or the resource do not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the IAM access control policy for the specified project, in the
        /// format `projects/{ProjectIdOrNumber}` e.g. projects/123.
        /// Permission is denied if the policy or the resource do not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the IAM access control policy for the specified project, in the
        /// format `projects/{ProjectIdOrNumber}` e.g. projects/123.
        /// Permission is denied if the policy or the resource do not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the IAM access control policy for the specified project, in the
        /// format `projects/{ProjectIdOrNumber}` e.g. projects/123.
        /// Permission is denied if the policy or the resource do not exist.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(string resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicy(new gciv::GetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Returns the IAM access control policy for the specified project, in the
        /// format `projects/{ProjectIdOrNumber}` e.g. projects/123.
        /// Permission is denied if the policy or the resource do not exist.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(string resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicyAsync(new gciv::GetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Returns the IAM access control policy for the specified project, in the
        /// format `projects/{ProjectIdOrNumber}` e.g. projects/123.
        /// Permission is denied if the policy or the resource do not exist.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(string resource, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the IAM access control policy for the specified project, in the
        /// format `projects/{ProjectIdOrNumber}` e.g. projects/123.
        /// Permission is denied if the policy or the resource do not exist.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(gax::IResourceName resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicy(new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Returns the IAM access control policy for the specified project, in the
        /// format `projects/{ProjectIdOrNumber}` e.g. projects/123.
        /// Permission is denied if the policy or the resource do not exist.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gax::IResourceName resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicyAsync(new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Returns the IAM access control policy for the specified project, in the
        /// format `projects/{ProjectIdOrNumber}` e.g. projects/123.
        /// Permission is denied if the policy or the resource do not exist.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gax::IResourceName resource, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the IAM access control policy for the specified project, in the
        /// format `projects/{ProjectIdOrNumber}` e.g. projects/123.
        /// 
        /// CAUTION: This method will replace the existing policy, and cannot be used
        /// to append additional IAM settings.
        /// 
        /// Note: Removing service accounts from policies or changing their roles can
        /// render services completely inoperable. It is important to understand how
        /// the service account is being used before removing or updating its roles.
        /// 
        /// The following constraints apply when using `setIamPolicy()`:
        /// 
        /// + Project does not support `allUsers` and `allAuthenticatedUsers` as
        /// `members` in a `Binding` of a `Policy`.
        /// 
        /// + The owner role can be granted to a `user`, `serviceAccount`, or a group
        /// that is part of an organization. For example,
        /// group@myownpersonaldomain.com could be added as an owner to a project in
        /// the myownpersonaldomain.com organization, but not the examplepetstore.com
        /// organization.
        /// 
        /// + Service accounts can be made owners of a project directly
        /// without any restrictions. However, to be added as an owner, a user must be
        /// invited using the Cloud Platform console and must accept the invitation.
        /// 
        /// + A user cannot be granted the owner role using `setIamPolicy()`. The user
        /// must be granted the owner role using the Cloud Platform Console and must
        /// explicitly accept the invitation.
        /// 
        /// + Invitations to grant the owner role cannot be sent using
        /// `setIamPolicy()`;
        /// they must be sent only using the Cloud Platform Console.
        /// 
        /// + If the project is not part of an organization, there must be at least
        /// one owner who has accepted the Terms of Service (ToS) agreement in the
        /// policy. Calling `setIamPolicy()` to remove the last ToS-accepted owner
        /// from the policy will fail. This restriction also applies to legacy
        /// projects that no longer have owners who have accepted the ToS. Edits to
        /// IAM policies will be rejected until the lack of a ToS-accepting owner is
        /// rectified. If the project is part of an organization, you can remove all
        /// owners, potentially making the organization inaccessible.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the IAM access control policy for the specified project, in the
        /// format `projects/{ProjectIdOrNumber}` e.g. projects/123.
        /// 
        /// CAUTION: This method will replace the existing policy, and cannot be used
        /// to append additional IAM settings.
        /// 
        /// Note: Removing service accounts from policies or changing their roles can
        /// render services completely inoperable. It is important to understand how
        /// the service account is being used before removing or updating its roles.
        /// 
        /// The following constraints apply when using `setIamPolicy()`:
        /// 
        /// + Project does not support `allUsers` and `allAuthenticatedUsers` as
        /// `members` in a `Binding` of a `Policy`.
        /// 
        /// + The owner role can be granted to a `user`, `serviceAccount`, or a group
        /// that is part of an organization. For example,
        /// group@myownpersonaldomain.com could be added as an owner to a project in
        /// the myownpersonaldomain.com organization, but not the examplepetstore.com
        /// organization.
        /// 
        /// + Service accounts can be made owners of a project directly
        /// without any restrictions. However, to be added as an owner, a user must be
        /// invited using the Cloud Platform console and must accept the invitation.
        /// 
        /// + A user cannot be granted the owner role using `setIamPolicy()`. The user
        /// must be granted the owner role using the Cloud Platform Console and must
        /// explicitly accept the invitation.
        /// 
        /// + Invitations to grant the owner role cannot be sent using
        /// `setIamPolicy()`;
        /// they must be sent only using the Cloud Platform Console.
        /// 
        /// + If the project is not part of an organization, there must be at least
        /// one owner who has accepted the Terms of Service (ToS) agreement in the
        /// policy. Calling `setIamPolicy()` to remove the last ToS-accepted owner
        /// from the policy will fail. This restriction also applies to legacy
        /// projects that no longer have owners who have accepted the ToS. Edits to
        /// IAM policies will be rejected until the lack of a ToS-accepting owner is
        /// rectified. If the project is part of an organization, you can remove all
        /// owners, potentially making the organization inaccessible.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the IAM access control policy for the specified project, in the
        /// format `projects/{ProjectIdOrNumber}` e.g. projects/123.
        /// 
        /// CAUTION: This method will replace the existing policy, and cannot be used
        /// to append additional IAM settings.
        /// 
        /// Note: Removing service accounts from policies or changing their roles can
        /// render services completely inoperable. It is important to understand how
        /// the service account is being used before removing or updating its roles.
        /// 
        /// The following constraints apply when using `setIamPolicy()`:
        /// 
        /// + Project does not support `allUsers` and `allAuthenticatedUsers` as
        /// `members` in a `Binding` of a `Policy`.
        /// 
        /// + The owner role can be granted to a `user`, `serviceAccount`, or a group
        /// that is part of an organization. For example,
        /// group@myownpersonaldomain.com could be added as an owner to a project in
        /// the myownpersonaldomain.com organization, but not the examplepetstore.com
        /// organization.
        /// 
        /// + Service accounts can be made owners of a project directly
        /// without any restrictions. However, to be added as an owner, a user must be
        /// invited using the Cloud Platform console and must accept the invitation.
        /// 
        /// + A user cannot be granted the owner role using `setIamPolicy()`. The user
        /// must be granted the owner role using the Cloud Platform Console and must
        /// explicitly accept the invitation.
        /// 
        /// + Invitations to grant the owner role cannot be sent using
        /// `setIamPolicy()`;
        /// they must be sent only using the Cloud Platform Console.
        /// 
        /// + If the project is not part of an organization, there must be at least
        /// one owner who has accepted the Terms of Service (ToS) agreement in the
        /// policy. Calling `setIamPolicy()` to remove the last ToS-accepted owner
        /// from the policy will fail. This restriction also applies to legacy
        /// projects that no longer have owners who have accepted the ToS. Edits to
        /// IAM policies will be rejected until the lack of a ToS-accepting owner is
        /// rectified. If the project is part of an organization, you can remove all
        /// owners, potentially making the organization inaccessible.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the IAM access control policy for the specified project, in the
        /// format `projects/{ProjectIdOrNumber}` e.g. projects/123.
        /// 
        /// CAUTION: This method will replace the existing policy, and cannot be used
        /// to append additional IAM settings.
        /// 
        /// Note: Removing service accounts from policies or changing their roles can
        /// render services completely inoperable. It is important to understand how
        /// the service account is being used before removing or updating its roles.
        /// 
        /// The following constraints apply when using `setIamPolicy()`:
        /// 
        /// + Project does not support `allUsers` and `allAuthenticatedUsers` as
        /// `members` in a `Binding` of a `Policy`.
        /// 
        /// + The owner role can be granted to a `user`, `serviceAccount`, or a group
        /// that is part of an organization. For example,
        /// group@myownpersonaldomain.com could be added as an owner to a project in
        /// the myownpersonaldomain.com organization, but not the examplepetstore.com
        /// organization.
        /// 
        /// + Service accounts can be made owners of a project directly
        /// without any restrictions. However, to be added as an owner, a user must be
        /// invited using the Cloud Platform console and must accept the invitation.
        /// 
        /// + A user cannot be granted the owner role using `setIamPolicy()`. The user
        /// must be granted the owner role using the Cloud Platform Console and must
        /// explicitly accept the invitation.
        /// 
        /// + Invitations to grant the owner role cannot be sent using
        /// `setIamPolicy()`;
        /// they must be sent only using the Cloud Platform Console.
        /// 
        /// + If the project is not part of an organization, there must be at least
        /// one owner who has accepted the Terms of Service (ToS) agreement in the
        /// policy. Calling `setIamPolicy()` to remove the last ToS-accepted owner
        /// from the policy will fail. This restriction also applies to legacy
        /// projects that no longer have owners who have accepted the ToS. Edits to
        /// IAM policies will be rejected until the lack of a ToS-accepting owner is
        /// rectified. If the project is part of an organization, you can remove all
        /// owners, potentially making the organization inaccessible.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(string resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicy(new gciv::SetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Sets the IAM access control policy for the specified project, in the
        /// format `projects/{ProjectIdOrNumber}` e.g. projects/123.
        /// 
        /// CAUTION: This method will replace the existing policy, and cannot be used
        /// to append additional IAM settings.
        /// 
        /// Note: Removing service accounts from policies or changing their roles can
        /// render services completely inoperable. It is important to understand how
        /// the service account is being used before removing or updating its roles.
        /// 
        /// The following constraints apply when using `setIamPolicy()`:
        /// 
        /// + Project does not support `allUsers` and `allAuthenticatedUsers` as
        /// `members` in a `Binding` of a `Policy`.
        /// 
        /// + The owner role can be granted to a `user`, `serviceAccount`, or a group
        /// that is part of an organization. For example,
        /// group@myownpersonaldomain.com could be added as an owner to a project in
        /// the myownpersonaldomain.com organization, but not the examplepetstore.com
        /// organization.
        /// 
        /// + Service accounts can be made owners of a project directly
        /// without any restrictions. However, to be added as an owner, a user must be
        /// invited using the Cloud Platform console and must accept the invitation.
        /// 
        /// + A user cannot be granted the owner role using `setIamPolicy()`. The user
        /// must be granted the owner role using the Cloud Platform Console and must
        /// explicitly accept the invitation.
        /// 
        /// + Invitations to grant the owner role cannot be sent using
        /// `setIamPolicy()`;
        /// they must be sent only using the Cloud Platform Console.
        /// 
        /// + If the project is not part of an organization, there must be at least
        /// one owner who has accepted the Terms of Service (ToS) agreement in the
        /// policy. Calling `setIamPolicy()` to remove the last ToS-accepted owner
        /// from the policy will fail. This restriction also applies to legacy
        /// projects that no longer have owners who have accepted the ToS. Edits to
        /// IAM policies will be rejected until the lack of a ToS-accepting owner is
        /// rectified. If the project is part of an organization, you can remove all
        /// owners, potentially making the organization inaccessible.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(string resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicyAsync(new gciv::SetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Sets the IAM access control policy for the specified project, in the
        /// format `projects/{ProjectIdOrNumber}` e.g. projects/123.
        /// 
        /// CAUTION: This method will replace the existing policy, and cannot be used
        /// to append additional IAM settings.
        /// 
        /// Note: Removing service accounts from policies or changing their roles can
        /// render services completely inoperable. It is important to understand how
        /// the service account is being used before removing or updating its roles.
        /// 
        /// The following constraints apply when using `setIamPolicy()`:
        /// 
        /// + Project does not support `allUsers` and `allAuthenticatedUsers` as
        /// `members` in a `Binding` of a `Policy`.
        /// 
        /// + The owner role can be granted to a `user`, `serviceAccount`, or a group
        /// that is part of an organization. For example,
        /// group@myownpersonaldomain.com could be added as an owner to a project in
        /// the myownpersonaldomain.com organization, but not the examplepetstore.com
        /// organization.
        /// 
        /// + Service accounts can be made owners of a project directly
        /// without any restrictions. However, to be added as an owner, a user must be
        /// invited using the Cloud Platform console and must accept the invitation.
        /// 
        /// + A user cannot be granted the owner role using `setIamPolicy()`. The user
        /// must be granted the owner role using the Cloud Platform Console and must
        /// explicitly accept the invitation.
        /// 
        /// + Invitations to grant the owner role cannot be sent using
        /// `setIamPolicy()`;
        /// they must be sent only using the Cloud Platform Console.
        /// 
        /// + If the project is not part of an organization, there must be at least
        /// one owner who has accepted the Terms of Service (ToS) agreement in the
        /// policy. Calling `setIamPolicy()` to remove the last ToS-accepted owner
        /// from the policy will fail. This restriction also applies to legacy
        /// projects that no longer have owners who have accepted the ToS. Edits to
        /// IAM policies will be rejected until the lack of a ToS-accepting owner is
        /// rectified. If the project is part of an organization, you can remove all
        /// owners, potentially making the organization inaccessible.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(string resource, gciv::Policy policy, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(resource, policy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the IAM access control policy for the specified project, in the
        /// format `projects/{ProjectIdOrNumber}` e.g. projects/123.
        /// 
        /// CAUTION: This method will replace the existing policy, and cannot be used
        /// to append additional IAM settings.
        /// 
        /// Note: Removing service accounts from policies or changing their roles can
        /// render services completely inoperable. It is important to understand how
        /// the service account is being used before removing or updating its roles.
        /// 
        /// The following constraints apply when using `setIamPolicy()`:
        /// 
        /// + Project does not support `allUsers` and `allAuthenticatedUsers` as
        /// `members` in a `Binding` of a `Policy`.
        /// 
        /// + The owner role can be granted to a `user`, `serviceAccount`, or a group
        /// that is part of an organization. For example,
        /// group@myownpersonaldomain.com could be added as an owner to a project in
        /// the myownpersonaldomain.com organization, but not the examplepetstore.com
        /// organization.
        /// 
        /// + Service accounts can be made owners of a project directly
        /// without any restrictions. However, to be added as an owner, a user must be
        /// invited using the Cloud Platform console and must accept the invitation.
        /// 
        /// + A user cannot be granted the owner role using `setIamPolicy()`. The user
        /// must be granted the owner role using the Cloud Platform Console and must
        /// explicitly accept the invitation.
        /// 
        /// + Invitations to grant the owner role cannot be sent using
        /// `setIamPolicy()`;
        /// they must be sent only using the Cloud Platform Console.
        /// 
        /// + If the project is not part of an organization, there must be at least
        /// one owner who has accepted the Terms of Service (ToS) agreement in the
        /// policy. Calling `setIamPolicy()` to remove the last ToS-accepted owner
        /// from the policy will fail. This restriction also applies to legacy
        /// projects that no longer have owners who have accepted the ToS. Edits to
        /// IAM policies will be rejected until the lack of a ToS-accepting owner is
        /// rectified. If the project is part of an organization, you can remove all
        /// owners, potentially making the organization inaccessible.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(gax::IResourceName resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicy(new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Sets the IAM access control policy for the specified project, in the
        /// format `projects/{ProjectIdOrNumber}` e.g. projects/123.
        /// 
        /// CAUTION: This method will replace the existing policy, and cannot be used
        /// to append additional IAM settings.
        /// 
        /// Note: Removing service accounts from policies or changing their roles can
        /// render services completely inoperable. It is important to understand how
        /// the service account is being used before removing or updating its roles.
        /// 
        /// The following constraints apply when using `setIamPolicy()`:
        /// 
        /// + Project does not support `allUsers` and `allAuthenticatedUsers` as
        /// `members` in a `Binding` of a `Policy`.
        /// 
        /// + The owner role can be granted to a `user`, `serviceAccount`, or a group
        /// that is part of an organization. For example,
        /// group@myownpersonaldomain.com could be added as an owner to a project in
        /// the myownpersonaldomain.com organization, but not the examplepetstore.com
        /// organization.
        /// 
        /// + Service accounts can be made owners of a project directly
        /// without any restrictions. However, to be added as an owner, a user must be
        /// invited using the Cloud Platform console and must accept the invitation.
        /// 
        /// + A user cannot be granted the owner role using `setIamPolicy()`. The user
        /// must be granted the owner role using the Cloud Platform Console and must
        /// explicitly accept the invitation.
        /// 
        /// + Invitations to grant the owner role cannot be sent using
        /// `setIamPolicy()`;
        /// they must be sent only using the Cloud Platform Console.
        /// 
        /// + If the project is not part of an organization, there must be at least
        /// one owner who has accepted the Terms of Service (ToS) agreement in the
        /// policy. Calling `setIamPolicy()` to remove the last ToS-accepted owner
        /// from the policy will fail. This restriction also applies to legacy
        /// projects that no longer have owners who have accepted the ToS. Edits to
        /// IAM policies will be rejected until the lack of a ToS-accepting owner is
        /// rectified. If the project is part of an organization, you can remove all
        /// owners, potentially making the organization inaccessible.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gax::IResourceName resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicyAsync(new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Sets the IAM access control policy for the specified project, in the
        /// format `projects/{ProjectIdOrNumber}` e.g. projects/123.
        /// 
        /// CAUTION: This method will replace the existing policy, and cannot be used
        /// to append additional IAM settings.
        /// 
        /// Note: Removing service accounts from policies or changing their roles can
        /// render services completely inoperable. It is important to understand how
        /// the service account is being used before removing or updating its roles.
        /// 
        /// The following constraints apply when using `setIamPolicy()`:
        /// 
        /// + Project does not support `allUsers` and `allAuthenticatedUsers` as
        /// `members` in a `Binding` of a `Policy`.
        /// 
        /// + The owner role can be granted to a `user`, `serviceAccount`, or a group
        /// that is part of an organization. For example,
        /// group@myownpersonaldomain.com could be added as an owner to a project in
        /// the myownpersonaldomain.com organization, but not the examplepetstore.com
        /// organization.
        /// 
        /// + Service accounts can be made owners of a project directly
        /// without any restrictions. However, to be added as an owner, a user must be
        /// invited using the Cloud Platform console and must accept the invitation.
        /// 
        /// + A user cannot be granted the owner role using `setIamPolicy()`. The user
        /// must be granted the owner role using the Cloud Platform Console and must
        /// explicitly accept the invitation.
        /// 
        /// + Invitations to grant the owner role cannot be sent using
        /// `setIamPolicy()`;
        /// they must be sent only using the Cloud Platform Console.
        /// 
        /// + If the project is not part of an organization, there must be at least
        /// one owner who has accepted the Terms of Service (ToS) agreement in the
        /// policy. Calling `setIamPolicy()` to remove the last ToS-accepted owner
        /// from the policy will fail. This restriction also applies to legacy
        /// projects that no longer have owners who have accepted the ToS. Edits to
        /// IAM policies will be rejected until the lack of a ToS-accepting owner is
        /// rectified. If the project is part of an organization, you can remove all
        /// owners, potentially making the organization inaccessible.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gax::IResourceName resource, gciv::Policy policy, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(resource, policy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that a caller has on the specified project, in the
        /// format `projects/{ProjectIdOrNumber}` e.g. projects/123..
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns permissions that a caller has on the specified project, in the
        /// format `projects/{ProjectIdOrNumber}` e.g. projects/123..
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns permissions that a caller has on the specified project, in the
        /// format `projects/{ProjectIdOrNumber}` e.g. projects/123..
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that a caller has on the specified project, in the
        /// format `projects/{ProjectIdOrNumber}` e.g. projects/123..
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(string resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissions(new gciv::TestIamPermissionsRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Returns permissions that a caller has on the specified project, in the
        /// format `projects/{ProjectIdOrNumber}` e.g. projects/123..
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(string resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissionsAsync(new gciv::TestIamPermissionsRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Returns permissions that a caller has on the specified project, in the
        /// format `projects/{ProjectIdOrNumber}` e.g. projects/123..
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(string resource, scg::IEnumerable<string> permissions, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(resource, permissions, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that a caller has on the specified project, in the
        /// format `projects/{ProjectIdOrNumber}` e.g. projects/123..
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(gax::IResourceName resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissions(new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Returns permissions that a caller has on the specified project, in the
        /// format `projects/{ProjectIdOrNumber}` e.g. projects/123..
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gax::IResourceName resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissionsAsync(new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Returns permissions that a caller has on the specified project, in the
        /// format `projects/{ProjectIdOrNumber}` e.g. projects/123..
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gax::IResourceName resource, scg::IEnumerable<string> permissions, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(resource, permissions, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Projects client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Manages Google Cloud Projects.
    /// </remarks>
    public sealed partial class ProjectsClientImpl : ProjectsClient
    {
        private readonly gaxgrpc::ApiCall<GetProjectRequest, Project> _callGetProject;

        private readonly gaxgrpc::ApiCall<ListProjectsRequest, ListProjectsResponse> _callListProjects;

        private readonly gaxgrpc::ApiCall<SearchProjectsRequest, SearchProjectsResponse> _callSearchProjects;

        private readonly gaxgrpc::ApiCall<CreateProjectRequest, lro::Operation> _callCreateProject;

        private readonly gaxgrpc::ApiCall<UpdateProjectRequest, lro::Operation> _callUpdateProject;

        private readonly gaxgrpc::ApiCall<MoveProjectRequest, lro::Operation> _callMoveProject;

        private readonly gaxgrpc::ApiCall<DeleteProjectRequest, lro::Operation> _callDeleteProject;

        private readonly gaxgrpc::ApiCall<UndeleteProjectRequest, lro::Operation> _callUndeleteProject;

        private readonly gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> _callGetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> _callSetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> _callTestIamPermissions;

        /// <summary>
        /// Constructs a client wrapper for the Projects service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ProjectsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ProjectsClientImpl(Projects.ProjectsClient grpcClient, ProjectsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ProjectsSettings effectiveSettings = settings ?? ProjectsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateProjectOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateProjectOperationsSettings, logger);
            UpdateProjectOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateProjectOperationsSettings, logger);
            MoveProjectOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.MoveProjectOperationsSettings, logger);
            DeleteProjectOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteProjectOperationsSettings, logger);
            UndeleteProjectOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UndeleteProjectOperationsSettings, logger);
            _callGetProject = clientHelper.BuildApiCall<GetProjectRequest, Project>("GetProject", grpcClient.GetProjectAsync, grpcClient.GetProject, effectiveSettings.GetProjectSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetProject);
            Modify_GetProjectApiCall(ref _callGetProject);
            _callListProjects = clientHelper.BuildApiCall<ListProjectsRequest, ListProjectsResponse>("ListProjects", grpcClient.ListProjectsAsync, grpcClient.ListProjects, effectiveSettings.ListProjectsSettings);
            Modify_ApiCall(ref _callListProjects);
            Modify_ListProjectsApiCall(ref _callListProjects);
            _callSearchProjects = clientHelper.BuildApiCall<SearchProjectsRequest, SearchProjectsResponse>("SearchProjects", grpcClient.SearchProjectsAsync, grpcClient.SearchProjects, effectiveSettings.SearchProjectsSettings);
            Modify_ApiCall(ref _callSearchProjects);
            Modify_SearchProjectsApiCall(ref _callSearchProjects);
            _callCreateProject = clientHelper.BuildApiCall<CreateProjectRequest, lro::Operation>("CreateProject", grpcClient.CreateProjectAsync, grpcClient.CreateProject, effectiveSettings.CreateProjectSettings);
            Modify_ApiCall(ref _callCreateProject);
            Modify_CreateProjectApiCall(ref _callCreateProject);
            _callUpdateProject = clientHelper.BuildApiCall<UpdateProjectRequest, lro::Operation>("UpdateProject", grpcClient.UpdateProjectAsync, grpcClient.UpdateProject, effectiveSettings.UpdateProjectSettings).WithGoogleRequestParam("project.name", request => request.Project?.Name);
            Modify_ApiCall(ref _callUpdateProject);
            Modify_UpdateProjectApiCall(ref _callUpdateProject);
            _callMoveProject = clientHelper.BuildApiCall<MoveProjectRequest, lro::Operation>("MoveProject", grpcClient.MoveProjectAsync, grpcClient.MoveProject, effectiveSettings.MoveProjectSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callMoveProject);
            Modify_MoveProjectApiCall(ref _callMoveProject);
            _callDeleteProject = clientHelper.BuildApiCall<DeleteProjectRequest, lro::Operation>("DeleteProject", grpcClient.DeleteProjectAsync, grpcClient.DeleteProject, effectiveSettings.DeleteProjectSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteProject);
            Modify_DeleteProjectApiCall(ref _callDeleteProject);
            _callUndeleteProject = clientHelper.BuildApiCall<UndeleteProjectRequest, lro::Operation>("UndeleteProject", grpcClient.UndeleteProjectAsync, grpcClient.UndeleteProject, effectiveSettings.UndeleteProjectSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUndeleteProject);
            Modify_UndeleteProjectApiCall(ref _callUndeleteProject);
            _callGetIamPolicy = clientHelper.BuildApiCall<gciv::GetIamPolicyRequest, gciv::Policy>("GetIamPolicy", grpcClient.GetIamPolicyAsync, grpcClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callGetIamPolicy);
            Modify_GetIamPolicyApiCall(ref _callGetIamPolicy);
            _callSetIamPolicy = clientHelper.BuildApiCall<gciv::SetIamPolicyRequest, gciv::Policy>("SetIamPolicy", grpcClient.SetIamPolicyAsync, grpcClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callSetIamPolicy);
            Modify_SetIamPolicyApiCall(ref _callSetIamPolicy);
            _callTestIamPermissions = clientHelper.BuildApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse>("TestIamPermissions", grpcClient.TestIamPermissionsAsync, grpcClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callTestIamPermissions);
            Modify_TestIamPermissionsApiCall(ref _callTestIamPermissions);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetProjectApiCall(ref gaxgrpc::ApiCall<GetProjectRequest, Project> call);

        partial void Modify_ListProjectsApiCall(ref gaxgrpc::ApiCall<ListProjectsRequest, ListProjectsResponse> call);

        partial void Modify_SearchProjectsApiCall(ref gaxgrpc::ApiCall<SearchProjectsRequest, SearchProjectsResponse> call);

        partial void Modify_CreateProjectApiCall(ref gaxgrpc::ApiCall<CreateProjectRequest, lro::Operation> call);

        partial void Modify_UpdateProjectApiCall(ref gaxgrpc::ApiCall<UpdateProjectRequest, lro::Operation> call);

        partial void Modify_MoveProjectApiCall(ref gaxgrpc::ApiCall<MoveProjectRequest, lro::Operation> call);

        partial void Modify_DeleteProjectApiCall(ref gaxgrpc::ApiCall<DeleteProjectRequest, lro::Operation> call);

        partial void Modify_UndeleteProjectApiCall(ref gaxgrpc::ApiCall<UndeleteProjectRequest, lro::Operation> call);

        partial void Modify_GetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_SetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_TestIamPermissionsApiCall(ref gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> call);

        partial void OnConstruction(Projects.ProjectsClient grpcClient, ProjectsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Projects client</summary>
        public override Projects.ProjectsClient GrpcClient { get; }

        partial void Modify_GetProjectRequest(ref GetProjectRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListProjectsRequest(ref ListProjectsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchProjectsRequest(ref SearchProjectsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateProjectRequest(ref CreateProjectRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateProjectRequest(ref UpdateProjectRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MoveProjectRequest(ref MoveProjectRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteProjectRequest(ref DeleteProjectRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UndeleteProjectRequest(ref UndeleteProjectRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIamPolicyRequest(ref gciv::GetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetIamPolicyRequest(ref gciv::SetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TestIamPermissionsRequest(ref gciv::TestIamPermissionsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves the project identified by the specified `name` (for example,
        /// `projects/415104041262`).
        /// 
        /// The caller must have `resourcemanager.projects.get` permission
        /// for this project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Project GetProject(GetProjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProjectRequest(ref request, ref callSettings);
            return _callGetProject.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the project identified by the specified `name` (for example,
        /// `projects/415104041262`).
        /// 
        /// The caller must have `resourcemanager.projects.get` permission
        /// for this project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Project> GetProjectAsync(GetProjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProjectRequest(ref request, ref callSettings);
            return _callGetProject.Async(request, callSettings);
        }

        /// <summary>
        /// Lists projects that are direct children of the specified folder or
        /// organization resource. `list()` provides a strongly consistent view of the
        /// projects underneath the specified parent resource. `list()` returns
        /// projects sorted based upon the (ascending) lexical ordering of their
        /// `display_name`. The caller must have `resourcemanager.projects.list`
        /// permission on the identified parent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Project"/> resources.</returns>
        public override gax::PagedEnumerable<ListProjectsResponse, Project> ListProjects(ListProjectsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProjectsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListProjectsRequest, ListProjectsResponse, Project>(_callListProjects, request, callSettings);
        }

        /// <summary>
        /// Lists projects that are direct children of the specified folder or
        /// organization resource. `list()` provides a strongly consistent view of the
        /// projects underneath the specified parent resource. `list()` returns
        /// projects sorted based upon the (ascending) lexical ordering of their
        /// `display_name`. The caller must have `resourcemanager.projects.list`
        /// permission on the identified parent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Project"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListProjectsResponse, Project> ListProjectsAsync(ListProjectsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProjectsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListProjectsRequest, ListProjectsResponse, Project>(_callListProjects, request, callSettings);
        }

        /// <summary>
        /// Search for projects that the caller has both `resourcemanager.projects.get`
        /// permission on, and also satisfy the specified query.
        /// 
        /// This method returns projects in an unspecified order.
        /// 
        /// This method is eventually consistent with project mutations; this means
        /// that a newly created project may not appear in the results or recent
        /// updates to an existing project may not be reflected in the results. To
        /// retrieve the latest state of a project, use the
        /// [GetProject][google.cloud.resourcemanager.v3.Projects.GetProject] method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Project"/> resources.</returns>
        public override gax::PagedEnumerable<SearchProjectsResponse, Project> SearchProjects(SearchProjectsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchProjectsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchProjectsRequest, SearchProjectsResponse, Project>(_callSearchProjects, request, callSettings);
        }

        /// <summary>
        /// Search for projects that the caller has both `resourcemanager.projects.get`
        /// permission on, and also satisfy the specified query.
        /// 
        /// This method returns projects in an unspecified order.
        /// 
        /// This method is eventually consistent with project mutations; this means
        /// that a newly created project may not appear in the results or recent
        /// updates to an existing project may not be reflected in the results. To
        /// retrieve the latest state of a project, use the
        /// [GetProject][google.cloud.resourcemanager.v3.Projects.GetProject] method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Project"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SearchProjectsResponse, Project> SearchProjectsAsync(SearchProjectsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchProjectsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchProjectsRequest, SearchProjectsResponse, Project>(_callSearchProjects, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateProject</c>.</summary>
        public override lro::OperationsClient CreateProjectOperationsClient { get; }

        /// <summary>
        /// Request that a new project be created. The result is an `Operation` which
        /// can be used to track the creation process. This process usually takes a few
        /// seconds, but can sometimes take much longer. The tracking `Operation` is
        /// automatically deleted after a few hours, so there is no need to call
        /// `DeleteOperation`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Project, CreateProjectMetadata> CreateProject(CreateProjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateProjectRequest(ref request, ref callSettings);
            return new lro::Operation<Project, CreateProjectMetadata>(_callCreateProject.Sync(request, callSettings), CreateProjectOperationsClient);
        }

        /// <summary>
        /// Request that a new project be created. The result is an `Operation` which
        /// can be used to track the creation process. This process usually takes a few
        /// seconds, but can sometimes take much longer. The tracking `Operation` is
        /// automatically deleted after a few hours, so there is no need to call
        /// `DeleteOperation`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Project, CreateProjectMetadata>> CreateProjectAsync(CreateProjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateProjectRequest(ref request, ref callSettings);
            return new lro::Operation<Project, CreateProjectMetadata>(await _callCreateProject.Async(request, callSettings).ConfigureAwait(false), CreateProjectOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateProject</c>.</summary>
        public override lro::OperationsClient UpdateProjectOperationsClient { get; }

        /// <summary>
        /// Updates the `display_name` and labels of the project identified by the
        /// specified `name` (for example, `projects/415104041262`). Deleting all
        /// labels requires an update mask for labels field.
        /// 
        /// The caller must have `resourcemanager.projects.update` permission for this
        /// project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Project, UpdateProjectMetadata> UpdateProject(UpdateProjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateProjectRequest(ref request, ref callSettings);
            return new lro::Operation<Project, UpdateProjectMetadata>(_callUpdateProject.Sync(request, callSettings), UpdateProjectOperationsClient);
        }

        /// <summary>
        /// Updates the `display_name` and labels of the project identified by the
        /// specified `name` (for example, `projects/415104041262`). Deleting all
        /// labels requires an update mask for labels field.
        /// 
        /// The caller must have `resourcemanager.projects.update` permission for this
        /// project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Project, UpdateProjectMetadata>> UpdateProjectAsync(UpdateProjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateProjectRequest(ref request, ref callSettings);
            return new lro::Operation<Project, UpdateProjectMetadata>(await _callUpdateProject.Async(request, callSettings).ConfigureAwait(false), UpdateProjectOperationsClient);
        }

        /// <summary>The long-running operations client for <c>MoveProject</c>.</summary>
        public override lro::OperationsClient MoveProjectOperationsClient { get; }

        /// <summary>
        /// Move a project to another place in your resource hierarchy, under a new
        /// resource parent.
        /// 
        /// Returns an operation which can be used to track the process of the project
        /// move workflow.
        /// Upon success, the `Operation.response` field will be populated with the
        /// moved project.
        /// 
        /// The caller must have `resourcemanager.projects.move` permission on the
        /// project, on the project's current and proposed new parent.
        /// 
        /// If project has no current parent, or it currently does not have an
        /// associated organization resource, you will also need the
        /// `resourcemanager.projects.setIamPolicy` permission in the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Project, MoveProjectMetadata> MoveProject(MoveProjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MoveProjectRequest(ref request, ref callSettings);
            return new lro::Operation<Project, MoveProjectMetadata>(_callMoveProject.Sync(request, callSettings), MoveProjectOperationsClient);
        }

        /// <summary>
        /// Move a project to another place in your resource hierarchy, under a new
        /// resource parent.
        /// 
        /// Returns an operation which can be used to track the process of the project
        /// move workflow.
        /// Upon success, the `Operation.response` field will be populated with the
        /// moved project.
        /// 
        /// The caller must have `resourcemanager.projects.move` permission on the
        /// project, on the project's current and proposed new parent.
        /// 
        /// If project has no current parent, or it currently does not have an
        /// associated organization resource, you will also need the
        /// `resourcemanager.projects.setIamPolicy` permission in the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Project, MoveProjectMetadata>> MoveProjectAsync(MoveProjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MoveProjectRequest(ref request, ref callSettings);
            return new lro::Operation<Project, MoveProjectMetadata>(await _callMoveProject.Async(request, callSettings).ConfigureAwait(false), MoveProjectOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteProject</c>.</summary>
        public override lro::OperationsClient DeleteProjectOperationsClient { get; }

        /// <summary>
        /// Marks the project identified by the specified
        /// `name` (for example, `projects/415104041262`) for deletion.
        /// 
        /// This method will only affect the project if it has a lifecycle state of
        /// [ACTIVE][google.cloud.resourcemanager.v3.Project.State.ACTIVE].
        /// 
        /// This method changes the Project's lifecycle state from
        /// [ACTIVE][google.cloud.resourcemanager.v3.Project.State.ACTIVE]
        /// to
        /// [DELETE_REQUESTED][google.cloud.resourcemanager.v3.Project.State.DELETE_REQUESTED].
        /// The deletion starts at an unspecified time,
        /// at which point the Project is no longer accessible.
        /// 
        /// Until the deletion completes, you can check the lifecycle state
        /// checked by retrieving the project with [GetProject]
        /// [google.cloud.resourcemanager.v3.Projects.GetProject],
        /// and the project remains visible to [ListProjects]
        /// [google.cloud.resourcemanager.v3.Projects.ListProjects].
        /// However, you cannot update the project.
        /// 
        /// After the deletion completes, the project is not retrievable by
        /// the  [GetProject]
        /// [google.cloud.resourcemanager.v3.Projects.GetProject],
        /// [ListProjects]
        /// [google.cloud.resourcemanager.v3.Projects.ListProjects], and
        /// [SearchProjects][google.cloud.resourcemanager.v3.Projects.SearchProjects]
        /// methods.
        /// 
        /// This method behaves idempotently, such that deleting a `DELETE_REQUESTED`
        /// project will not cause an error, but also won't do anything.
        /// 
        /// The caller must have `resourcemanager.projects.delete` permissions for this
        /// project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Project, DeleteProjectMetadata> DeleteProject(DeleteProjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteProjectRequest(ref request, ref callSettings);
            return new lro::Operation<Project, DeleteProjectMetadata>(_callDeleteProject.Sync(request, callSettings), DeleteProjectOperationsClient);
        }

        /// <summary>
        /// Marks the project identified by the specified
        /// `name` (for example, `projects/415104041262`) for deletion.
        /// 
        /// This method will only affect the project if it has a lifecycle state of
        /// [ACTIVE][google.cloud.resourcemanager.v3.Project.State.ACTIVE].
        /// 
        /// This method changes the Project's lifecycle state from
        /// [ACTIVE][google.cloud.resourcemanager.v3.Project.State.ACTIVE]
        /// to
        /// [DELETE_REQUESTED][google.cloud.resourcemanager.v3.Project.State.DELETE_REQUESTED].
        /// The deletion starts at an unspecified time,
        /// at which point the Project is no longer accessible.
        /// 
        /// Until the deletion completes, you can check the lifecycle state
        /// checked by retrieving the project with [GetProject]
        /// [google.cloud.resourcemanager.v3.Projects.GetProject],
        /// and the project remains visible to [ListProjects]
        /// [google.cloud.resourcemanager.v3.Projects.ListProjects].
        /// However, you cannot update the project.
        /// 
        /// After the deletion completes, the project is not retrievable by
        /// the  [GetProject]
        /// [google.cloud.resourcemanager.v3.Projects.GetProject],
        /// [ListProjects]
        /// [google.cloud.resourcemanager.v3.Projects.ListProjects], and
        /// [SearchProjects][google.cloud.resourcemanager.v3.Projects.SearchProjects]
        /// methods.
        /// 
        /// This method behaves idempotently, such that deleting a `DELETE_REQUESTED`
        /// project will not cause an error, but also won't do anything.
        /// 
        /// The caller must have `resourcemanager.projects.delete` permissions for this
        /// project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Project, DeleteProjectMetadata>> DeleteProjectAsync(DeleteProjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteProjectRequest(ref request, ref callSettings);
            return new lro::Operation<Project, DeleteProjectMetadata>(await _callDeleteProject.Async(request, callSettings).ConfigureAwait(false), DeleteProjectOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UndeleteProject</c>.</summary>
        public override lro::OperationsClient UndeleteProjectOperationsClient { get; }

        /// <summary>
        /// Restores the project identified by the specified
        /// `name` (for example, `projects/415104041262`).
        /// You can only use this method for a project that has a lifecycle state of
        /// [DELETE_REQUESTED]
        /// [Projects.State.DELETE_REQUESTED].
        /// After deletion starts, the project cannot be restored.
        /// 
        /// The caller must have `resourcemanager.projects.undelete` permission for
        /// this project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Project, UndeleteProjectMetadata> UndeleteProject(UndeleteProjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeleteProjectRequest(ref request, ref callSettings);
            return new lro::Operation<Project, UndeleteProjectMetadata>(_callUndeleteProject.Sync(request, callSettings), UndeleteProjectOperationsClient);
        }

        /// <summary>
        /// Restores the project identified by the specified
        /// `name` (for example, `projects/415104041262`).
        /// You can only use this method for a project that has a lifecycle state of
        /// [DELETE_REQUESTED]
        /// [Projects.State.DELETE_REQUESTED].
        /// After deletion starts, the project cannot be restored.
        /// 
        /// The caller must have `resourcemanager.projects.undelete` permission for
        /// this project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Project, UndeleteProjectMetadata>> UndeleteProjectAsync(UndeleteProjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeleteProjectRequest(ref request, ref callSettings);
            return new lro::Operation<Project, UndeleteProjectMetadata>(await _callUndeleteProject.Async(request, callSettings).ConfigureAwait(false), UndeleteProjectOperationsClient);
        }

        /// <summary>
        /// Returns the IAM access control policy for the specified project, in the
        /// format `projects/{ProjectIdOrNumber}` e.g. projects/123.
        /// Permission is denied if the policy or the resource do not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the IAM access control policy for the specified project, in the
        /// format `projects/{ProjectIdOrNumber}` e.g. projects/123.
        /// Permission is denied if the policy or the resource do not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the IAM access control policy for the specified project, in the
        /// format `projects/{ProjectIdOrNumber}` e.g. projects/123.
        /// 
        /// CAUTION: This method will replace the existing policy, and cannot be used
        /// to append additional IAM settings.
        /// 
        /// Note: Removing service accounts from policies or changing their roles can
        /// render services completely inoperable. It is important to understand how
        /// the service account is being used before removing or updating its roles.
        /// 
        /// The following constraints apply when using `setIamPolicy()`:
        /// 
        /// + Project does not support `allUsers` and `allAuthenticatedUsers` as
        /// `members` in a `Binding` of a `Policy`.
        /// 
        /// + The owner role can be granted to a `user`, `serviceAccount`, or a group
        /// that is part of an organization. For example,
        /// group@myownpersonaldomain.com could be added as an owner to a project in
        /// the myownpersonaldomain.com organization, but not the examplepetstore.com
        /// organization.
        /// 
        /// + Service accounts can be made owners of a project directly
        /// without any restrictions. However, to be added as an owner, a user must be
        /// invited using the Cloud Platform console and must accept the invitation.
        /// 
        /// + A user cannot be granted the owner role using `setIamPolicy()`. The user
        /// must be granted the owner role using the Cloud Platform Console and must
        /// explicitly accept the invitation.
        /// 
        /// + Invitations to grant the owner role cannot be sent using
        /// `setIamPolicy()`;
        /// they must be sent only using the Cloud Platform Console.
        /// 
        /// + If the project is not part of an organization, there must be at least
        /// one owner who has accepted the Terms of Service (ToS) agreement in the
        /// policy. Calling `setIamPolicy()` to remove the last ToS-accepted owner
        /// from the policy will fail. This restriction also applies to legacy
        /// projects that no longer have owners who have accepted the ToS. Edits to
        /// IAM policies will be rejected until the lack of a ToS-accepting owner is
        /// rectified. If the project is part of an organization, you can remove all
        /// owners, potentially making the organization inaccessible.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the IAM access control policy for the specified project, in the
        /// format `projects/{ProjectIdOrNumber}` e.g. projects/123.
        /// 
        /// CAUTION: This method will replace the existing policy, and cannot be used
        /// to append additional IAM settings.
        /// 
        /// Note: Removing service accounts from policies or changing their roles can
        /// render services completely inoperable. It is important to understand how
        /// the service account is being used before removing or updating its roles.
        /// 
        /// The following constraints apply when using `setIamPolicy()`:
        /// 
        /// + Project does not support `allUsers` and `allAuthenticatedUsers` as
        /// `members` in a `Binding` of a `Policy`.
        /// 
        /// + The owner role can be granted to a `user`, `serviceAccount`, or a group
        /// that is part of an organization. For example,
        /// group@myownpersonaldomain.com could be added as an owner to a project in
        /// the myownpersonaldomain.com organization, but not the examplepetstore.com
        /// organization.
        /// 
        /// + Service accounts can be made owners of a project directly
        /// without any restrictions. However, to be added as an owner, a user must be
        /// invited using the Cloud Platform console and must accept the invitation.
        /// 
        /// + A user cannot be granted the owner role using `setIamPolicy()`. The user
        /// must be granted the owner role using the Cloud Platform Console and must
        /// explicitly accept the invitation.
        /// 
        /// + Invitations to grant the owner role cannot be sent using
        /// `setIamPolicy()`;
        /// they must be sent only using the Cloud Platform Console.
        /// 
        /// + If the project is not part of an organization, there must be at least
        /// one owner who has accepted the Terms of Service (ToS) agreement in the
        /// policy. Calling `setIamPolicy()` to remove the last ToS-accepted owner
        /// from the policy will fail. This restriction also applies to legacy
        /// projects that no longer have owners who have accepted the ToS. Edits to
        /// IAM policies will be rejected until the lack of a ToS-accepting owner is
        /// rectified. If the project is part of an organization, you can remove all
        /// owners, potentially making the organization inaccessible.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified project, in the
        /// format `projects/{ProjectIdOrNumber}` e.g. projects/123..
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified project, in the
        /// format `projects/{ProjectIdOrNumber}` e.g. projects/123..
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Async(request, callSettings);
        }
    }

    public partial class ListProjectsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchProjectsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListProjectsResponse : gaxgrpc::IPageResponse<Project>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Project> GetEnumerator() => Projects.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class SearchProjectsResponse : gaxgrpc::IPageResponse<Project>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Project> GetEnumerator() => Projects.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Projects
    {
        public partial class ProjectsClient
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
}
