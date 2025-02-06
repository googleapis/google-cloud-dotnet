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
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.Dialogflow.Cx.V3
{
    /// <summary>Settings for <see cref="DeploymentsClient"/> instances.</summary>
    public sealed partial class DeploymentsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DeploymentsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DeploymentsSettings"/>.</returns>
        public static DeploymentsSettings GetDefault() => new DeploymentsSettings();

        /// <summary>Constructs a new <see cref="DeploymentsSettings"/> object with default settings.</summary>
        public DeploymentsSettings()
        {
        }

        private DeploymentsSettings(DeploymentsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListDeploymentsSettings = existing.ListDeploymentsSettings;
            GetDeploymentSettings = existing.GetDeploymentSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DeploymentsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeploymentsClient.ListDeployments</c> and <c>DeploymentsClient.ListDeploymentsAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDeploymentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeploymentsClient.GetDeployment</c> and <c>DeploymentsClient.GetDeploymentAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDeploymentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DeploymentsSettings"/> object.</returns>
        public DeploymentsSettings Clone() => new DeploymentsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DeploymentsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class DeploymentsClientBuilder : gaxgrpc::ClientBuilderBase<DeploymentsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DeploymentsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DeploymentsClientBuilder() : base(DeploymentsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DeploymentsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DeploymentsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DeploymentsClient Build()
        {
            DeploymentsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DeploymentsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DeploymentsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DeploymentsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DeploymentsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DeploymentsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DeploymentsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DeploymentsClient.ChannelPool;
    }

    /// <summary>Deployments client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing [Deployments][google.cloud.dialogflow.cx.v3.Deployment].
    /// </remarks>
    public abstract partial class DeploymentsClient
    {
        /// <summary>
        /// The default endpoint for the Deployments service, which is a host of "dialogflow.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dialogflow.googleapis.com:443";

        /// <summary>The default Deployments scopes.</summary>
        /// <remarks>
        /// The default Deployments scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/dialogflow</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/dialogflow",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Deployments.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DeploymentsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DeploymentsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DeploymentsClient"/>.</returns>
        public static stt::Task<DeploymentsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DeploymentsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DeploymentsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DeploymentsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DeploymentsClient"/>.</returns>
        public static DeploymentsClient Create() => new DeploymentsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DeploymentsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DeploymentsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DeploymentsClient"/>.</returns>
        internal static DeploymentsClient Create(grpccore::CallInvoker callInvoker, DeploymentsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Deployments.DeploymentsClient grpcClient = new Deployments.DeploymentsClient(callInvoker);
            return new DeploymentsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Deployments client</summary>
        public virtual Deployments.DeploymentsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all deployments in the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Deployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeploymentsResponse, Deployment> ListDeployments(ListDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all deployments in the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Deployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeploymentsResponse, Deployment> ListDeploymentsAsync(ListDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all deployments in the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="parent">
        /// Required. The [Environment][google.cloud.dialogflow.cx.v3.Environment] to
        /// list all environments for. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;`.
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
        /// <returns>A pageable sequence of <see cref="Deployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeploymentsResponse, Deployment> ListDeployments(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeploymentsRequest request = new ListDeploymentsRequest
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
            return ListDeployments(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all deployments in the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="parent">
        /// Required. The [Environment][google.cloud.dialogflow.cx.v3.Environment] to
        /// list all environments for. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Deployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeploymentsResponse, Deployment> ListDeploymentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeploymentsRequest request = new ListDeploymentsRequest
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
            return ListDeploymentsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all deployments in the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="parent">
        /// Required. The [Environment][google.cloud.dialogflow.cx.v3.Environment] to
        /// list all environments for. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;`.
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
        /// <returns>A pageable sequence of <see cref="Deployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeploymentsResponse, Deployment> ListDeployments(EnvironmentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeploymentsRequest request = new ListDeploymentsRequest
            {
                ParentAsEnvironmentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDeployments(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all deployments in the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="parent">
        /// Required. The [Environment][google.cloud.dialogflow.cx.v3.Environment] to
        /// list all environments for. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Deployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeploymentsResponse, Deployment> ListDeploymentsAsync(EnvironmentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeploymentsRequest request = new ListDeploymentsRequest
            {
                ParentAsEnvironmentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDeploymentsAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified
        /// [Deployment][google.cloud.dialogflow.cx.v3.Deployment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Deployment GetDeployment(GetDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified
        /// [Deployment][google.cloud.dialogflow.cx.v3.Deployment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> GetDeploymentAsync(GetDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified
        /// [Deployment][google.cloud.dialogflow.cx.v3.Deployment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> GetDeploymentAsync(GetDeploymentRequest request, st::CancellationToken cancellationToken) =>
            GetDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified
        /// [Deployment][google.cloud.dialogflow.cx.v3.Deployment].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [Deployment][google.cloud.dialogflow.cx.v3.Deployment]. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;/deployments/&lt;DeploymentID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Deployment GetDeployment(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeployment(new GetDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified
        /// [Deployment][google.cloud.dialogflow.cx.v3.Deployment].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [Deployment][google.cloud.dialogflow.cx.v3.Deployment]. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;/deployments/&lt;DeploymentID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> GetDeploymentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeploymentAsync(new GetDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified
        /// [Deployment][google.cloud.dialogflow.cx.v3.Deployment].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [Deployment][google.cloud.dialogflow.cx.v3.Deployment]. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;/deployments/&lt;DeploymentID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> GetDeploymentAsync(string name, st::CancellationToken cancellationToken) =>
            GetDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified
        /// [Deployment][google.cloud.dialogflow.cx.v3.Deployment].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [Deployment][google.cloud.dialogflow.cx.v3.Deployment]. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;/deployments/&lt;DeploymentID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Deployment GetDeployment(DeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeployment(new GetDeploymentRequest
            {
                DeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified
        /// [Deployment][google.cloud.dialogflow.cx.v3.Deployment].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [Deployment][google.cloud.dialogflow.cx.v3.Deployment]. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;/deployments/&lt;DeploymentID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> GetDeploymentAsync(DeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeploymentAsync(new GetDeploymentRequest
            {
                DeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified
        /// [Deployment][google.cloud.dialogflow.cx.v3.Deployment].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [Deployment][google.cloud.dialogflow.cx.v3.Deployment]. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;/deployments/&lt;DeploymentID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> GetDeploymentAsync(DeploymentName name, st::CancellationToken cancellationToken) =>
            GetDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Deployments client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing [Deployments][google.cloud.dialogflow.cx.v3.Deployment].
    /// </remarks>
    public sealed partial class DeploymentsClientImpl : DeploymentsClient
    {
        private readonly gaxgrpc::ApiCall<ListDeploymentsRequest, ListDeploymentsResponse> _callListDeployments;

        private readonly gaxgrpc::ApiCall<GetDeploymentRequest, Deployment> _callGetDeployment;

        /// <summary>
        /// Constructs a client wrapper for the Deployments service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DeploymentsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DeploymentsClientImpl(Deployments.DeploymentsClient grpcClient, DeploymentsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DeploymentsSettings effectiveSettings = settings ?? DeploymentsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListDeployments = clientHelper.BuildApiCall<ListDeploymentsRequest, ListDeploymentsResponse>("ListDeployments", grpcClient.ListDeploymentsAsync, grpcClient.ListDeployments, effectiveSettings.ListDeploymentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDeployments);
            Modify_ListDeploymentsApiCall(ref _callListDeployments);
            _callGetDeployment = clientHelper.BuildApiCall<GetDeploymentRequest, Deployment>("GetDeployment", grpcClient.GetDeploymentAsync, grpcClient.GetDeployment, effectiveSettings.GetDeploymentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDeployment);
            Modify_GetDeploymentApiCall(ref _callGetDeployment);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListDeploymentsApiCall(ref gaxgrpc::ApiCall<ListDeploymentsRequest, ListDeploymentsResponse> call);

        partial void Modify_GetDeploymentApiCall(ref gaxgrpc::ApiCall<GetDeploymentRequest, Deployment> call);

        partial void OnConstruction(Deployments.DeploymentsClient grpcClient, DeploymentsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Deployments client</summary>
        public override Deployments.DeploymentsClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListDeploymentsRequest(ref ListDeploymentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDeploymentRequest(ref GetDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the list of all deployments in the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Deployment"/> resources.</returns>
        public override gax::PagedEnumerable<ListDeploymentsResponse, Deployment> ListDeployments(ListDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDeploymentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDeploymentsRequest, ListDeploymentsResponse, Deployment>(_callListDeployments, request, callSettings);
        }

        /// <summary>
        /// Returns the list of all deployments in the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Deployment"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDeploymentsResponse, Deployment> ListDeploymentsAsync(ListDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDeploymentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDeploymentsRequest, ListDeploymentsResponse, Deployment>(_callListDeployments, request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified
        /// [Deployment][google.cloud.dialogflow.cx.v3.Deployment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Deployment GetDeployment(GetDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDeploymentRequest(ref request, ref callSettings);
            return _callGetDeployment.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified
        /// [Deployment][google.cloud.dialogflow.cx.v3.Deployment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Deployment> GetDeploymentAsync(GetDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDeploymentRequest(ref request, ref callSettings);
            return _callGetDeployment.Async(request, callSettings);
        }
    }

    public partial class ListDeploymentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDeploymentsResponse : gaxgrpc::IPageResponse<Deployment>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Deployment> GetEnumerator() => Deployments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Deployments
    {
        public partial class DeploymentsClient
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
