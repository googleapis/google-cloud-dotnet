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
using lro = Google.LongRunning;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.DiscoveryEngine.V1Beta
{
    /// <summary>Settings for <see cref="ProjectServiceClient"/> instances.</summary>
    public sealed partial class ProjectServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ProjectServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ProjectServiceSettings"/>.</returns>
        public static ProjectServiceSettings GetDefault() => new ProjectServiceSettings();

        /// <summary>Constructs a new <see cref="ProjectServiceSettings"/> object with default settings.</summary>
        public ProjectServiceSettings()
        {
        }

        private ProjectServiceSettings(ProjectServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ProvisionProjectSettings = existing.ProvisionProjectSettings;
            ProvisionProjectOperationsSettings = existing.ProvisionProjectOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ProjectServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProjectServiceClient.ProvisionProject</c> and <c>ProjectServiceClient.ProvisionProjectAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ProvisionProjectSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ProjectServiceClient.ProvisionProject</c> and
        /// <c>ProjectServiceClient.ProvisionProjectAsync</c>.
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
        public lro::OperationsSettings ProvisionProjectOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ProjectServiceSettings"/> object.</returns>
        public ProjectServiceSettings Clone() => new ProjectServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ProjectServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class ProjectServiceClientBuilder : gaxgrpc::ClientBuilderBase<ProjectServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ProjectServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ProjectServiceClientBuilder() : base(ProjectServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ProjectServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ProjectServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ProjectServiceClient Build()
        {
            ProjectServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ProjectServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ProjectServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ProjectServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ProjectServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ProjectServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ProjectServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ProjectServiceClient.ChannelPool;
    }

    /// <summary>ProjectService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for operations on the
    /// [Project][google.cloud.discoveryengine.v1beta.Project].
    /// </remarks>
    public abstract partial class ProjectServiceClient
    {
        /// <summary>
        /// The default endpoint for the ProjectService service, which is a host of "discoveryengine.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "discoveryengine.googleapis.com:443";

        /// <summary>The default ProjectService scopes.</summary>
        /// <remarks>
        /// The default ProjectService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ProjectService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ProjectServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ProjectServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ProjectServiceClient"/>.</returns>
        public static stt::Task<ProjectServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ProjectServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ProjectServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ProjectServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ProjectServiceClient"/>.</returns>
        public static ProjectServiceClient Create() => new ProjectServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ProjectServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ProjectServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ProjectServiceClient"/>.</returns>
        internal static ProjectServiceClient Create(grpccore::CallInvoker callInvoker, ProjectServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ProjectService.ProjectServiceClient grpcClient = new ProjectService.ProjectServiceClient(callInvoker);
            return new ProjectServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ProjectService client</summary>
        public virtual ProjectService.ProjectServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Provisions the project resource. During the
        /// process, related systems will get prepared and initialized.
        /// 
        /// Caller must read the [Terms for data
        /// use](https://cloud.google.com/retail/data-use-terms), and optionally
        /// specify in request to provide consent to that service terms.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Project, ProvisionProjectMetadata> ProvisionProject(ProvisionProjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Provisions the project resource. During the
        /// process, related systems will get prepared and initialized.
        /// 
        /// Caller must read the [Terms for data
        /// use](https://cloud.google.com/retail/data-use-terms), and optionally
        /// specify in request to provide consent to that service terms.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Project, ProvisionProjectMetadata>> ProvisionProjectAsync(ProvisionProjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Provisions the project resource. During the
        /// process, related systems will get prepared and initialized.
        /// 
        /// Caller must read the [Terms for data
        /// use](https://cloud.google.com/retail/data-use-terms), and optionally
        /// specify in request to provide consent to that service terms.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Project, ProvisionProjectMetadata>> ProvisionProjectAsync(ProvisionProjectRequest request, st::CancellationToken cancellationToken) =>
            ProvisionProjectAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ProvisionProject</c>.</summary>
        public virtual lro::OperationsClient ProvisionProjectOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ProvisionProject</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Project, ProvisionProjectMetadata> PollOnceProvisionProject(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Project, ProvisionProjectMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ProvisionProjectOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ProvisionProject</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Project, ProvisionProjectMetadata>> PollOnceProvisionProjectAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Project, ProvisionProjectMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ProvisionProjectOperationsClient, callSettings);

        /// <summary>
        /// Provisions the project resource. During the
        /// process, related systems will get prepared and initialized.
        /// 
        /// Caller must read the [Terms for data
        /// use](https://cloud.google.com/retail/data-use-terms), and optionally
        /// specify in request to provide consent to that service terms.
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of a
        /// [Project][google.cloud.discoveryengine.v1beta.Project], such as
        /// `projects/{project_id_or_number}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Project, ProvisionProjectMetadata> ProvisionProject(string name, gaxgrpc::CallSettings callSettings = null) =>
            ProvisionProject(new ProvisionProjectRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Provisions the project resource. During the
        /// process, related systems will get prepared and initialized.
        /// 
        /// Caller must read the [Terms for data
        /// use](https://cloud.google.com/retail/data-use-terms), and optionally
        /// specify in request to provide consent to that service terms.
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of a
        /// [Project][google.cloud.discoveryengine.v1beta.Project], such as
        /// `projects/{project_id_or_number}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Project, ProvisionProjectMetadata>> ProvisionProjectAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ProvisionProjectAsync(new ProvisionProjectRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Provisions the project resource. During the
        /// process, related systems will get prepared and initialized.
        /// 
        /// Caller must read the [Terms for data
        /// use](https://cloud.google.com/retail/data-use-terms), and optionally
        /// specify in request to provide consent to that service terms.
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of a
        /// [Project][google.cloud.discoveryengine.v1beta.Project], such as
        /// `projects/{project_id_or_number}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Project, ProvisionProjectMetadata>> ProvisionProjectAsync(string name, st::CancellationToken cancellationToken) =>
            ProvisionProjectAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Provisions the project resource. During the
        /// process, related systems will get prepared and initialized.
        /// 
        /// Caller must read the [Terms for data
        /// use](https://cloud.google.com/retail/data-use-terms), and optionally
        /// specify in request to provide consent to that service terms.
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of a
        /// [Project][google.cloud.discoveryengine.v1beta.Project], such as
        /// `projects/{project_id_or_number}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Project, ProvisionProjectMetadata> ProvisionProject(ProjectName name, gaxgrpc::CallSettings callSettings = null) =>
            ProvisionProject(new ProvisionProjectRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Provisions the project resource. During the
        /// process, related systems will get prepared and initialized.
        /// 
        /// Caller must read the [Terms for data
        /// use](https://cloud.google.com/retail/data-use-terms), and optionally
        /// specify in request to provide consent to that service terms.
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of a
        /// [Project][google.cloud.discoveryengine.v1beta.Project], such as
        /// `projects/{project_id_or_number}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Project, ProvisionProjectMetadata>> ProvisionProjectAsync(ProjectName name, gaxgrpc::CallSettings callSettings = null) =>
            ProvisionProjectAsync(new ProvisionProjectRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Provisions the project resource. During the
        /// process, related systems will get prepared and initialized.
        /// 
        /// Caller must read the [Terms for data
        /// use](https://cloud.google.com/retail/data-use-terms), and optionally
        /// specify in request to provide consent to that service terms.
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of a
        /// [Project][google.cloud.discoveryengine.v1beta.Project], such as
        /// `projects/{project_id_or_number}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Project, ProvisionProjectMetadata>> ProvisionProjectAsync(ProjectName name, st::CancellationToken cancellationToken) =>
            ProvisionProjectAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ProjectService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for operations on the
    /// [Project][google.cloud.discoveryengine.v1beta.Project].
    /// </remarks>
    public sealed partial class ProjectServiceClientImpl : ProjectServiceClient
    {
        private readonly gaxgrpc::ApiCall<ProvisionProjectRequest, lro::Operation> _callProvisionProject;

        /// <summary>
        /// Constructs a client wrapper for the ProjectService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ProjectServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ProjectServiceClientImpl(ProjectService.ProjectServiceClient grpcClient, ProjectServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ProjectServiceSettings effectiveSettings = settings ?? ProjectServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            ProvisionProjectOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ProvisionProjectOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callProvisionProject = clientHelper.BuildApiCall<ProvisionProjectRequest, lro::Operation>("ProvisionProject", grpcClient.ProvisionProjectAsync, grpcClient.ProvisionProject, effectiveSettings.ProvisionProjectSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callProvisionProject);
            Modify_ProvisionProjectApiCall(ref _callProvisionProject);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ProvisionProjectApiCall(ref gaxgrpc::ApiCall<ProvisionProjectRequest, lro::Operation> call);

        partial void OnConstruction(ProjectService.ProjectServiceClient grpcClient, ProjectServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ProjectService client</summary>
        public override ProjectService.ProjectServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ProvisionProjectRequest(ref ProvisionProjectRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>ProvisionProject</c>.</summary>
        public override lro::OperationsClient ProvisionProjectOperationsClient { get; }

        /// <summary>
        /// Provisions the project resource. During the
        /// process, related systems will get prepared and initialized.
        /// 
        /// Caller must read the [Terms for data
        /// use](https://cloud.google.com/retail/data-use-terms), and optionally
        /// specify in request to provide consent to that service terms.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Project, ProvisionProjectMetadata> ProvisionProject(ProvisionProjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ProvisionProjectRequest(ref request, ref callSettings);
            return new lro::Operation<Project, ProvisionProjectMetadata>(_callProvisionProject.Sync(request, callSettings), ProvisionProjectOperationsClient);
        }

        /// <summary>
        /// Provisions the project resource. During the
        /// process, related systems will get prepared and initialized.
        /// 
        /// Caller must read the [Terms for data
        /// use](https://cloud.google.com/retail/data-use-terms), and optionally
        /// specify in request to provide consent to that service terms.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Project, ProvisionProjectMetadata>> ProvisionProjectAsync(ProvisionProjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ProvisionProjectRequest(ref request, ref callSettings);
            return new lro::Operation<Project, ProvisionProjectMetadata>(await _callProvisionProject.Async(request, callSettings).ConfigureAwait(false), ProvisionProjectOperationsClient);
        }
    }

    public static partial class ProjectService
    {
        public partial class ProjectServiceClient
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

    public static partial class ProjectService
    {
        public partial class ProjectServiceClient
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
