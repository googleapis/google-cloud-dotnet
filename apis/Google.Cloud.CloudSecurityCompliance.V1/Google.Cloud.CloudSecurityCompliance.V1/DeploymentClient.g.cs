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
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.CloudSecurityCompliance.V1
{
    /// <summary>Settings for <see cref="DeploymentClient"/> instances.</summary>
    public sealed partial class DeploymentSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DeploymentSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DeploymentSettings"/>.</returns>
        public static DeploymentSettings GetDefault() => new DeploymentSettings();

        /// <summary>Constructs a new <see cref="DeploymentSettings"/> object with default settings.</summary>
        public DeploymentSettings()
        {
        }

        private DeploymentSettings(DeploymentSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateFrameworkDeploymentSettings = existing.CreateFrameworkDeploymentSettings;
            CreateFrameworkDeploymentOperationsSettings = existing.CreateFrameworkDeploymentOperationsSettings.Clone();
            DeleteFrameworkDeploymentSettings = existing.DeleteFrameworkDeploymentSettings;
            DeleteFrameworkDeploymentOperationsSettings = existing.DeleteFrameworkDeploymentOperationsSettings.Clone();
            GetFrameworkDeploymentSettings = existing.GetFrameworkDeploymentSettings;
            ListFrameworkDeploymentsSettings = existing.ListFrameworkDeploymentsSettings;
            GetCloudControlDeploymentSettings = existing.GetCloudControlDeploymentSettings;
            ListCloudControlDeploymentsSettings = existing.ListCloudControlDeploymentsSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DeploymentSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeploymentClient.CreateFrameworkDeployment</c> and <c>DeploymentClient.CreateFrameworkDeploymentAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateFrameworkDeploymentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DeploymentClient.CreateFrameworkDeployment</c> and
        /// <c>DeploymentClient.CreateFrameworkDeploymentAsync</c>.
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
        public lro::OperationsSettings CreateFrameworkDeploymentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeploymentClient.DeleteFrameworkDeployment</c> and <c>DeploymentClient.DeleteFrameworkDeploymentAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteFrameworkDeploymentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DeploymentClient.DeleteFrameworkDeployment</c> and
        /// <c>DeploymentClient.DeleteFrameworkDeploymentAsync</c>.
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
        public lro::OperationsSettings DeleteFrameworkDeploymentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeploymentClient.GetFrameworkDeployment</c> and <c>DeploymentClient.GetFrameworkDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetFrameworkDeploymentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeploymentClient.ListFrameworkDeployments</c> and <c>DeploymentClient.ListFrameworkDeploymentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListFrameworkDeploymentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeploymentClient.GetCloudControlDeployment</c> and <c>DeploymentClient.GetCloudControlDeploymentAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCloudControlDeploymentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeploymentClient.ListCloudControlDeployments</c> and <c>DeploymentClient.ListCloudControlDeploymentsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListCloudControlDeploymentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DeploymentSettings"/> object.</returns>
        public DeploymentSettings Clone() => new DeploymentSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DeploymentClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class DeploymentClientBuilder : gaxgrpc::ClientBuilderBase<DeploymentClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DeploymentSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DeploymentClientBuilder() : base(DeploymentClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DeploymentClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DeploymentClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DeploymentClient Build()
        {
            DeploymentClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DeploymentClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DeploymentClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DeploymentClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DeploymentClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DeploymentClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DeploymentClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DeploymentClient.ChannelPool;
    }

    /// <summary>Deployment client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public abstract partial class DeploymentClient
    {
        /// <summary>
        /// The default endpoint for the Deployment service, which is a host of "cloudsecuritycompliance.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloudsecuritycompliance.googleapis.com:443";

        /// <summary>The default Deployment scopes.</summary>
        /// <remarks>
        /// The default Deployment scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Deployment.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DeploymentClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DeploymentClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DeploymentClient"/>.</returns>
        public static stt::Task<DeploymentClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DeploymentClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DeploymentClient"/> using the default credentials, endpoint and settings.
        /// To specify custom credentials or other settings, use <see cref="DeploymentClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DeploymentClient"/>.</returns>
        public static DeploymentClient Create() => new DeploymentClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DeploymentClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DeploymentSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DeploymentClient"/>.</returns>
        internal static DeploymentClient Create(grpccore::CallInvoker callInvoker, DeploymentSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Deployment.DeploymentClient grpcClient = new Deployment.DeploymentClient(callInvoker);
            return new DeploymentClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Deployment client</summary>
        public virtual Deployment.DeploymentClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new FrameworkDeployment in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<FrameworkDeployment, OperationMetadata> CreateFrameworkDeployment(CreateFrameworkDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new FrameworkDeployment in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FrameworkDeployment, OperationMetadata>> CreateFrameworkDeploymentAsync(CreateFrameworkDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new FrameworkDeployment in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FrameworkDeployment, OperationMetadata>> CreateFrameworkDeploymentAsync(CreateFrameworkDeploymentRequest request, st::CancellationToken cancellationToken) =>
            CreateFrameworkDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateFrameworkDeployment</c>.</summary>
        public virtual lro::OperationsClient CreateFrameworkDeploymentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateFrameworkDeployment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<FrameworkDeployment, OperationMetadata> PollOnceCreateFrameworkDeployment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<FrameworkDeployment, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateFrameworkDeploymentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateFrameworkDeployment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<FrameworkDeployment, OperationMetadata>> PollOnceCreateFrameworkDeploymentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<FrameworkDeployment, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateFrameworkDeploymentOperationsClient, callSettings);

        /// <summary>
        /// Creates a new FrameworkDeployment in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent. Supported formats:
        /// organizations/{organization}/locations/{location}
        /// Only global location is supported.
        /// </param>
        /// <param name="frameworkDeployment">
        /// Required. The resource being created.
        /// </param>
        /// <param name="frameworkDeploymentId">
        /// Optional. User provided identifier. It should be unique in scope of a
        /// parent Please note that this is optional and if not provided, a random UUID
        /// will be generated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<FrameworkDeployment, OperationMetadata> CreateFrameworkDeployment(string parent, FrameworkDeployment frameworkDeployment, string frameworkDeploymentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFrameworkDeployment(new CreateFrameworkDeploymentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                FrameworkDeploymentId = frameworkDeploymentId ?? "",
                FrameworkDeployment = gax::GaxPreconditions.CheckNotNull(frameworkDeployment, nameof(frameworkDeployment)),
            }, callSettings);

        /// <summary>
        /// Creates a new FrameworkDeployment in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent. Supported formats:
        /// organizations/{organization}/locations/{location}
        /// Only global location is supported.
        /// </param>
        /// <param name="frameworkDeployment">
        /// Required. The resource being created.
        /// </param>
        /// <param name="frameworkDeploymentId">
        /// Optional. User provided identifier. It should be unique in scope of a
        /// parent Please note that this is optional and if not provided, a random UUID
        /// will be generated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FrameworkDeployment, OperationMetadata>> CreateFrameworkDeploymentAsync(string parent, FrameworkDeployment frameworkDeployment, string frameworkDeploymentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFrameworkDeploymentAsync(new CreateFrameworkDeploymentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                FrameworkDeploymentId = frameworkDeploymentId ?? "",
                FrameworkDeployment = gax::GaxPreconditions.CheckNotNull(frameworkDeployment, nameof(frameworkDeployment)),
            }, callSettings);

        /// <summary>
        /// Creates a new FrameworkDeployment in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent. Supported formats:
        /// organizations/{organization}/locations/{location}
        /// Only global location is supported.
        /// </param>
        /// <param name="frameworkDeployment">
        /// Required. The resource being created.
        /// </param>
        /// <param name="frameworkDeploymentId">
        /// Optional. User provided identifier. It should be unique in scope of a
        /// parent Please note that this is optional and if not provided, a random UUID
        /// will be generated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FrameworkDeployment, OperationMetadata>> CreateFrameworkDeploymentAsync(string parent, FrameworkDeployment frameworkDeployment, string frameworkDeploymentId, st::CancellationToken cancellationToken) =>
            CreateFrameworkDeploymentAsync(parent, frameworkDeployment, frameworkDeploymentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new FrameworkDeployment in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent. Supported formats:
        /// organizations/{organization}/locations/{location}
        /// Only global location is supported.
        /// </param>
        /// <param name="frameworkDeployment">
        /// Required. The resource being created.
        /// </param>
        /// <param name="frameworkDeploymentId">
        /// Optional. User provided identifier. It should be unique in scope of a
        /// parent Please note that this is optional and if not provided, a random UUID
        /// will be generated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<FrameworkDeployment, OperationMetadata> CreateFrameworkDeployment(OrganizationLocationName parent, FrameworkDeployment frameworkDeployment, string frameworkDeploymentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFrameworkDeployment(new CreateFrameworkDeploymentRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                FrameworkDeploymentId = frameworkDeploymentId ?? "",
                FrameworkDeployment = gax::GaxPreconditions.CheckNotNull(frameworkDeployment, nameof(frameworkDeployment)),
            }, callSettings);

        /// <summary>
        /// Creates a new FrameworkDeployment in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent. Supported formats:
        /// organizations/{organization}/locations/{location}
        /// Only global location is supported.
        /// </param>
        /// <param name="frameworkDeployment">
        /// Required. The resource being created.
        /// </param>
        /// <param name="frameworkDeploymentId">
        /// Optional. User provided identifier. It should be unique in scope of a
        /// parent Please note that this is optional and if not provided, a random UUID
        /// will be generated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FrameworkDeployment, OperationMetadata>> CreateFrameworkDeploymentAsync(OrganizationLocationName parent, FrameworkDeployment frameworkDeployment, string frameworkDeploymentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFrameworkDeploymentAsync(new CreateFrameworkDeploymentRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                FrameworkDeploymentId = frameworkDeploymentId ?? "",
                FrameworkDeployment = gax::GaxPreconditions.CheckNotNull(frameworkDeployment, nameof(frameworkDeployment)),
            }, callSettings);

        /// <summary>
        /// Creates a new FrameworkDeployment in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent. Supported formats:
        /// organizations/{organization}/locations/{location}
        /// Only global location is supported.
        /// </param>
        /// <param name="frameworkDeployment">
        /// Required. The resource being created.
        /// </param>
        /// <param name="frameworkDeploymentId">
        /// Optional. User provided identifier. It should be unique in scope of a
        /// parent Please note that this is optional and if not provided, a random UUID
        /// will be generated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FrameworkDeployment, OperationMetadata>> CreateFrameworkDeploymentAsync(OrganizationLocationName parent, FrameworkDeployment frameworkDeployment, string frameworkDeploymentId, st::CancellationToken cancellationToken) =>
            CreateFrameworkDeploymentAsync(parent, frameworkDeployment, frameworkDeploymentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single FrameworkDeployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteFrameworkDeployment(DeleteFrameworkDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single FrameworkDeployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFrameworkDeploymentAsync(DeleteFrameworkDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single FrameworkDeployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFrameworkDeploymentAsync(DeleteFrameworkDeploymentRequest request, st::CancellationToken cancellationToken) =>
            DeleteFrameworkDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteFrameworkDeployment</c>.</summary>
        public virtual lro::OperationsClient DeleteFrameworkDeploymentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteFrameworkDeployment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteFrameworkDeployment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteFrameworkDeploymentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteFrameworkDeployment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteFrameworkDeploymentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteFrameworkDeploymentOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single FrameworkDeployment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the framework deployment to be deleted
        /// FrameworkDeployment name in either of the following formats:
        /// organizations/{organization}/locations/{location}/frameworkDeployments/{framework_deployment_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteFrameworkDeployment(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFrameworkDeployment(new DeleteFrameworkDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single FrameworkDeployment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the framework deployment to be deleted
        /// FrameworkDeployment name in either of the following formats:
        /// organizations/{organization}/locations/{location}/frameworkDeployments/{framework_deployment_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFrameworkDeploymentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFrameworkDeploymentAsync(new DeleteFrameworkDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single FrameworkDeployment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the framework deployment to be deleted
        /// FrameworkDeployment name in either of the following formats:
        /// organizations/{organization}/locations/{location}/frameworkDeployments/{framework_deployment_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFrameworkDeploymentAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteFrameworkDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single FrameworkDeployment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the framework deployment to be deleted
        /// FrameworkDeployment name in either of the following formats:
        /// organizations/{organization}/locations/{location}/frameworkDeployments/{framework_deployment_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteFrameworkDeployment(FrameworkDeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFrameworkDeployment(new DeleteFrameworkDeploymentRequest
            {
                FrameworkDeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single FrameworkDeployment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the framework deployment to be deleted
        /// FrameworkDeployment name in either of the following formats:
        /// organizations/{organization}/locations/{location}/frameworkDeployments/{framework_deployment_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFrameworkDeploymentAsync(FrameworkDeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFrameworkDeploymentAsync(new DeleteFrameworkDeploymentRequest
            {
                FrameworkDeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single FrameworkDeployment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the framework deployment to be deleted
        /// FrameworkDeployment name in either of the following formats:
        /// organizations/{organization}/locations/{location}/frameworkDeployments/{framework_deployment_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFrameworkDeploymentAsync(FrameworkDeploymentName name, st::CancellationToken cancellationToken) =>
            DeleteFrameworkDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single FrameworkDeployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FrameworkDeployment GetFrameworkDeployment(GetFrameworkDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single FrameworkDeployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FrameworkDeployment> GetFrameworkDeploymentAsync(GetFrameworkDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single FrameworkDeployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FrameworkDeployment> GetFrameworkDeploymentAsync(GetFrameworkDeploymentRequest request, st::CancellationToken cancellationToken) =>
            GetFrameworkDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single FrameworkDeployment.
        /// </summary>
        /// <param name="name">
        /// Required. FrameworkDeployment name in either of the following formats:
        /// organizations/{organization}/locations/{location}/frameworkDeployments/{framework_deployment_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FrameworkDeployment GetFrameworkDeployment(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFrameworkDeployment(new GetFrameworkDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single FrameworkDeployment.
        /// </summary>
        /// <param name="name">
        /// Required. FrameworkDeployment name in either of the following formats:
        /// organizations/{organization}/locations/{location}/frameworkDeployments/{framework_deployment_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FrameworkDeployment> GetFrameworkDeploymentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFrameworkDeploymentAsync(new GetFrameworkDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single FrameworkDeployment.
        /// </summary>
        /// <param name="name">
        /// Required. FrameworkDeployment name in either of the following formats:
        /// organizations/{organization}/locations/{location}/frameworkDeployments/{framework_deployment_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FrameworkDeployment> GetFrameworkDeploymentAsync(string name, st::CancellationToken cancellationToken) =>
            GetFrameworkDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single FrameworkDeployment.
        /// </summary>
        /// <param name="name">
        /// Required. FrameworkDeployment name in either of the following formats:
        /// organizations/{organization}/locations/{location}/frameworkDeployments/{framework_deployment_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FrameworkDeployment GetFrameworkDeployment(FrameworkDeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFrameworkDeployment(new GetFrameworkDeploymentRequest
            {
                FrameworkDeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single FrameworkDeployment.
        /// </summary>
        /// <param name="name">
        /// Required. FrameworkDeployment name in either of the following formats:
        /// organizations/{organization}/locations/{location}/frameworkDeployments/{framework_deployment_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FrameworkDeployment> GetFrameworkDeploymentAsync(FrameworkDeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFrameworkDeploymentAsync(new GetFrameworkDeploymentRequest
            {
                FrameworkDeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single FrameworkDeployment.
        /// </summary>
        /// <param name="name">
        /// Required. FrameworkDeployment name in either of the following formats:
        /// organizations/{organization}/locations/{location}/frameworkDeployments/{framework_deployment_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FrameworkDeployment> GetFrameworkDeploymentAsync(FrameworkDeploymentName name, st::CancellationToken cancellationToken) =>
            GetFrameworkDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists FrameworkDeployments in a given parent and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FrameworkDeployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFrameworkDeploymentsResponse, FrameworkDeployment> ListFrameworkDeployments(ListFrameworkDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists FrameworkDeployments in a given parent and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FrameworkDeployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFrameworkDeploymentsResponse, FrameworkDeployment> ListFrameworkDeploymentsAsync(ListFrameworkDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists FrameworkDeployments in a given parent and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListFrameworkDeploymentsRequest.
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
        /// <returns>A pageable sequence of <see cref="FrameworkDeployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFrameworkDeploymentsResponse, FrameworkDeployment> ListFrameworkDeployments(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFrameworkDeploymentsRequest request = new ListFrameworkDeploymentsRequest
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
            return ListFrameworkDeployments(request, callSettings);
        }

        /// <summary>
        /// Lists FrameworkDeployments in a given parent and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListFrameworkDeploymentsRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="FrameworkDeployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFrameworkDeploymentsResponse, FrameworkDeployment> ListFrameworkDeploymentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFrameworkDeploymentsRequest request = new ListFrameworkDeploymentsRequest
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
            return ListFrameworkDeploymentsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists FrameworkDeployments in a given parent and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListFrameworkDeploymentsRequest.
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
        /// <returns>A pageable sequence of <see cref="FrameworkDeployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFrameworkDeploymentsResponse, FrameworkDeployment> ListFrameworkDeployments(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFrameworkDeploymentsRequest request = new ListFrameworkDeploymentsRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListFrameworkDeployments(request, callSettings);
        }

        /// <summary>
        /// Lists FrameworkDeployments in a given parent and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListFrameworkDeploymentsRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="FrameworkDeployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFrameworkDeploymentsResponse, FrameworkDeployment> ListFrameworkDeploymentsAsync(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFrameworkDeploymentsRequest request = new ListFrameworkDeploymentsRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListFrameworkDeploymentsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single CloudControlDeployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CloudControlDeployment GetCloudControlDeployment(GetCloudControlDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single CloudControlDeployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloudControlDeployment> GetCloudControlDeploymentAsync(GetCloudControlDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single CloudControlDeployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloudControlDeployment> GetCloudControlDeploymentAsync(GetCloudControlDeploymentRequest request, st::CancellationToken cancellationToken) =>
            GetCloudControlDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single CloudControlDeployment.
        /// </summary>
        /// <param name="name">
        /// Required. CloudControlDeployment name in either of the following formats:
        /// organizations/{organization}/locations/{location}/cloudControlDeployments/{cloud_control_deployment_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CloudControlDeployment GetCloudControlDeployment(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCloudControlDeployment(new GetCloudControlDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single CloudControlDeployment.
        /// </summary>
        /// <param name="name">
        /// Required. CloudControlDeployment name in either of the following formats:
        /// organizations/{organization}/locations/{location}/cloudControlDeployments/{cloud_control_deployment_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloudControlDeployment> GetCloudControlDeploymentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCloudControlDeploymentAsync(new GetCloudControlDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single CloudControlDeployment.
        /// </summary>
        /// <param name="name">
        /// Required. CloudControlDeployment name in either of the following formats:
        /// organizations/{organization}/locations/{location}/cloudControlDeployments/{cloud_control_deployment_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloudControlDeployment> GetCloudControlDeploymentAsync(string name, st::CancellationToken cancellationToken) =>
            GetCloudControlDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single CloudControlDeployment.
        /// </summary>
        /// <param name="name">
        /// Required. CloudControlDeployment name in either of the following formats:
        /// organizations/{organization}/locations/{location}/cloudControlDeployments/{cloud_control_deployment_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CloudControlDeployment GetCloudControlDeployment(CloudControlDeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCloudControlDeployment(new GetCloudControlDeploymentRequest
            {
                CloudControlDeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single CloudControlDeployment.
        /// </summary>
        /// <param name="name">
        /// Required. CloudControlDeployment name in either of the following formats:
        /// organizations/{organization}/locations/{location}/cloudControlDeployments/{cloud_control_deployment_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloudControlDeployment> GetCloudControlDeploymentAsync(CloudControlDeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCloudControlDeploymentAsync(new GetCloudControlDeploymentRequest
            {
                CloudControlDeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single CloudControlDeployment.
        /// </summary>
        /// <param name="name">
        /// Required. CloudControlDeployment name in either of the following formats:
        /// organizations/{organization}/locations/{location}/cloudControlDeployments/{cloud_control_deployment_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloudControlDeployment> GetCloudControlDeploymentAsync(CloudControlDeploymentName name, st::CancellationToken cancellationToken) =>
            GetCloudControlDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists CloudControlDeployments under a given parent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CloudControlDeployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCloudControlDeploymentsResponse, CloudControlDeployment> ListCloudControlDeployments(ListCloudControlDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists CloudControlDeployments under a given parent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CloudControlDeployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCloudControlDeploymentsResponse, CloudControlDeployment> ListCloudControlDeploymentsAsync(ListCloudControlDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists CloudControlDeployments under a given parent.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListCloudControlDeploymentsRequest.
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
        /// <returns>A pageable sequence of <see cref="CloudControlDeployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCloudControlDeploymentsResponse, CloudControlDeployment> ListCloudControlDeployments(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCloudControlDeploymentsRequest request = new ListCloudControlDeploymentsRequest
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
            return ListCloudControlDeployments(request, callSettings);
        }

        /// <summary>
        /// Lists CloudControlDeployments under a given parent.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListCloudControlDeploymentsRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CloudControlDeployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCloudControlDeploymentsResponse, CloudControlDeployment> ListCloudControlDeploymentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCloudControlDeploymentsRequest request = new ListCloudControlDeploymentsRequest
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
            return ListCloudControlDeploymentsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists CloudControlDeployments under a given parent.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListCloudControlDeploymentsRequest.
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
        /// <returns>A pageable sequence of <see cref="CloudControlDeployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCloudControlDeploymentsResponse, CloudControlDeployment> ListCloudControlDeployments(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCloudControlDeploymentsRequest request = new ListCloudControlDeploymentsRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCloudControlDeployments(request, callSettings);
        }

        /// <summary>
        /// Lists CloudControlDeployments under a given parent.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListCloudControlDeploymentsRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CloudControlDeployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCloudControlDeploymentsResponse, CloudControlDeployment> ListCloudControlDeploymentsAsync(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCloudControlDeploymentsRequest request = new ListCloudControlDeploymentsRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCloudControlDeploymentsAsync(request, callSettings);
        }
    }

    /// <summary>Deployment client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public sealed partial class DeploymentClientImpl : DeploymentClient
    {
        private readonly gaxgrpc::ApiCall<CreateFrameworkDeploymentRequest, lro::Operation> _callCreateFrameworkDeployment;

        private readonly gaxgrpc::ApiCall<DeleteFrameworkDeploymentRequest, lro::Operation> _callDeleteFrameworkDeployment;

        private readonly gaxgrpc::ApiCall<GetFrameworkDeploymentRequest, FrameworkDeployment> _callGetFrameworkDeployment;

        private readonly gaxgrpc::ApiCall<ListFrameworkDeploymentsRequest, ListFrameworkDeploymentsResponse> _callListFrameworkDeployments;

        private readonly gaxgrpc::ApiCall<GetCloudControlDeploymentRequest, CloudControlDeployment> _callGetCloudControlDeployment;

        private readonly gaxgrpc::ApiCall<ListCloudControlDeploymentsRequest, ListCloudControlDeploymentsResponse> _callListCloudControlDeployments;

        /// <summary>
        /// Constructs a client wrapper for the Deployment service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DeploymentSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DeploymentClientImpl(Deployment.DeploymentClient grpcClient, DeploymentSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DeploymentSettings effectiveSettings = settings ?? DeploymentSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateFrameworkDeploymentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateFrameworkDeploymentOperationsSettings, logger);
            DeleteFrameworkDeploymentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteFrameworkDeploymentOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callCreateFrameworkDeployment = clientHelper.BuildApiCall<CreateFrameworkDeploymentRequest, lro::Operation>("CreateFrameworkDeployment", grpcClient.CreateFrameworkDeploymentAsync, grpcClient.CreateFrameworkDeployment, effectiveSettings.CreateFrameworkDeploymentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateFrameworkDeployment);
            Modify_CreateFrameworkDeploymentApiCall(ref _callCreateFrameworkDeployment);
            _callDeleteFrameworkDeployment = clientHelper.BuildApiCall<DeleteFrameworkDeploymentRequest, lro::Operation>("DeleteFrameworkDeployment", grpcClient.DeleteFrameworkDeploymentAsync, grpcClient.DeleteFrameworkDeployment, effectiveSettings.DeleteFrameworkDeploymentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteFrameworkDeployment);
            Modify_DeleteFrameworkDeploymentApiCall(ref _callDeleteFrameworkDeployment);
            _callGetFrameworkDeployment = clientHelper.BuildApiCall<GetFrameworkDeploymentRequest, FrameworkDeployment>("GetFrameworkDeployment", grpcClient.GetFrameworkDeploymentAsync, grpcClient.GetFrameworkDeployment, effectiveSettings.GetFrameworkDeploymentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetFrameworkDeployment);
            Modify_GetFrameworkDeploymentApiCall(ref _callGetFrameworkDeployment);
            _callListFrameworkDeployments = clientHelper.BuildApiCall<ListFrameworkDeploymentsRequest, ListFrameworkDeploymentsResponse>("ListFrameworkDeployments", grpcClient.ListFrameworkDeploymentsAsync, grpcClient.ListFrameworkDeployments, effectiveSettings.ListFrameworkDeploymentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListFrameworkDeployments);
            Modify_ListFrameworkDeploymentsApiCall(ref _callListFrameworkDeployments);
            _callGetCloudControlDeployment = clientHelper.BuildApiCall<GetCloudControlDeploymentRequest, CloudControlDeployment>("GetCloudControlDeployment", grpcClient.GetCloudControlDeploymentAsync, grpcClient.GetCloudControlDeployment, effectiveSettings.GetCloudControlDeploymentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCloudControlDeployment);
            Modify_GetCloudControlDeploymentApiCall(ref _callGetCloudControlDeployment);
            _callListCloudControlDeployments = clientHelper.BuildApiCall<ListCloudControlDeploymentsRequest, ListCloudControlDeploymentsResponse>("ListCloudControlDeployments", grpcClient.ListCloudControlDeploymentsAsync, grpcClient.ListCloudControlDeployments, effectiveSettings.ListCloudControlDeploymentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCloudControlDeployments);
            Modify_ListCloudControlDeploymentsApiCall(ref _callListCloudControlDeployments);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateFrameworkDeploymentApiCall(ref gaxgrpc::ApiCall<CreateFrameworkDeploymentRequest, lro::Operation> call);

        partial void Modify_DeleteFrameworkDeploymentApiCall(ref gaxgrpc::ApiCall<DeleteFrameworkDeploymentRequest, lro::Operation> call);

        partial void Modify_GetFrameworkDeploymentApiCall(ref gaxgrpc::ApiCall<GetFrameworkDeploymentRequest, FrameworkDeployment> call);

        partial void Modify_ListFrameworkDeploymentsApiCall(ref gaxgrpc::ApiCall<ListFrameworkDeploymentsRequest, ListFrameworkDeploymentsResponse> call);

        partial void Modify_GetCloudControlDeploymentApiCall(ref gaxgrpc::ApiCall<GetCloudControlDeploymentRequest, CloudControlDeployment> call);

        partial void Modify_ListCloudControlDeploymentsApiCall(ref gaxgrpc::ApiCall<ListCloudControlDeploymentsRequest, ListCloudControlDeploymentsResponse> call);

        partial void OnConstruction(Deployment.DeploymentClient grpcClient, DeploymentSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Deployment client</summary>
        public override Deployment.DeploymentClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_CreateFrameworkDeploymentRequest(ref CreateFrameworkDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteFrameworkDeploymentRequest(ref DeleteFrameworkDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetFrameworkDeploymentRequest(ref GetFrameworkDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListFrameworkDeploymentsRequest(ref ListFrameworkDeploymentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetCloudControlDeploymentRequest(ref GetCloudControlDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCloudControlDeploymentsRequest(ref ListCloudControlDeploymentsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateFrameworkDeployment</c>.</summary>
        public override lro::OperationsClient CreateFrameworkDeploymentOperationsClient { get; }

        /// <summary>
        /// Creates a new FrameworkDeployment in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<FrameworkDeployment, OperationMetadata> CreateFrameworkDeployment(CreateFrameworkDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFrameworkDeploymentRequest(ref request, ref callSettings);
            return new lro::Operation<FrameworkDeployment, OperationMetadata>(_callCreateFrameworkDeployment.Sync(request, callSettings), CreateFrameworkDeploymentOperationsClient);
        }

        /// <summary>
        /// Creates a new FrameworkDeployment in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<FrameworkDeployment, OperationMetadata>> CreateFrameworkDeploymentAsync(CreateFrameworkDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFrameworkDeploymentRequest(ref request, ref callSettings);
            return new lro::Operation<FrameworkDeployment, OperationMetadata>(await _callCreateFrameworkDeployment.Async(request, callSettings).ConfigureAwait(false), CreateFrameworkDeploymentOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteFrameworkDeployment</c>.</summary>
        public override lro::OperationsClient DeleteFrameworkDeploymentOperationsClient { get; }

        /// <summary>
        /// Deletes a single FrameworkDeployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteFrameworkDeployment(DeleteFrameworkDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFrameworkDeploymentRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteFrameworkDeployment.Sync(request, callSettings), DeleteFrameworkDeploymentOperationsClient);
        }

        /// <summary>
        /// Deletes a single FrameworkDeployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFrameworkDeploymentAsync(DeleteFrameworkDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFrameworkDeploymentRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteFrameworkDeployment.Async(request, callSettings).ConfigureAwait(false), DeleteFrameworkDeploymentOperationsClient);
        }

        /// <summary>
        /// Gets details of a single FrameworkDeployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FrameworkDeployment GetFrameworkDeployment(GetFrameworkDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFrameworkDeploymentRequest(ref request, ref callSettings);
            return _callGetFrameworkDeployment.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single FrameworkDeployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FrameworkDeployment> GetFrameworkDeploymentAsync(GetFrameworkDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFrameworkDeploymentRequest(ref request, ref callSettings);
            return _callGetFrameworkDeployment.Async(request, callSettings);
        }

        /// <summary>
        /// Lists FrameworkDeployments in a given parent and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FrameworkDeployment"/> resources.</returns>
        public override gax::PagedEnumerable<ListFrameworkDeploymentsResponse, FrameworkDeployment> ListFrameworkDeployments(ListFrameworkDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFrameworkDeploymentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListFrameworkDeploymentsRequest, ListFrameworkDeploymentsResponse, FrameworkDeployment>(_callListFrameworkDeployments, request, callSettings);
        }

        /// <summary>
        /// Lists FrameworkDeployments in a given parent and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FrameworkDeployment"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListFrameworkDeploymentsResponse, FrameworkDeployment> ListFrameworkDeploymentsAsync(ListFrameworkDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFrameworkDeploymentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListFrameworkDeploymentsRequest, ListFrameworkDeploymentsResponse, FrameworkDeployment>(_callListFrameworkDeployments, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single CloudControlDeployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CloudControlDeployment GetCloudControlDeployment(GetCloudControlDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCloudControlDeploymentRequest(ref request, ref callSettings);
            return _callGetCloudControlDeployment.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single CloudControlDeployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CloudControlDeployment> GetCloudControlDeploymentAsync(GetCloudControlDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCloudControlDeploymentRequest(ref request, ref callSettings);
            return _callGetCloudControlDeployment.Async(request, callSettings);
        }

        /// <summary>
        /// Lists CloudControlDeployments under a given parent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CloudControlDeployment"/> resources.</returns>
        public override gax::PagedEnumerable<ListCloudControlDeploymentsResponse, CloudControlDeployment> ListCloudControlDeployments(ListCloudControlDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCloudControlDeploymentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCloudControlDeploymentsRequest, ListCloudControlDeploymentsResponse, CloudControlDeployment>(_callListCloudControlDeployments, request, callSettings);
        }

        /// <summary>
        /// Lists CloudControlDeployments under a given parent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CloudControlDeployment"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCloudControlDeploymentsResponse, CloudControlDeployment> ListCloudControlDeploymentsAsync(ListCloudControlDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCloudControlDeploymentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCloudControlDeploymentsRequest, ListCloudControlDeploymentsResponse, CloudControlDeployment>(_callListCloudControlDeployments, request, callSettings);
        }
    }

    public partial class ListFrameworkDeploymentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCloudControlDeploymentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListFrameworkDeploymentsResponse : gaxgrpc::IPageResponse<FrameworkDeployment>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<FrameworkDeployment> GetEnumerator() => FrameworkDeployments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListCloudControlDeploymentsResponse : gaxgrpc::IPageResponse<CloudControlDeployment>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<CloudControlDeployment> GetEnumerator() => CloudControlDeployments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Deployment
    {
        public partial class DeploymentClient
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

    public static partial class Deployment
    {
        public partial class DeploymentClient
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
