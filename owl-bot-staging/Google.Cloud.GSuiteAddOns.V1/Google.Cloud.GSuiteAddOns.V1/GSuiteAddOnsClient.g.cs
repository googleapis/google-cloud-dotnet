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
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.GSuiteAddOns.V1
{
    /// <summary>Settings for <see cref="GSuiteAddOnsClient"/> instances.</summary>
    public sealed partial class GSuiteAddOnsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="GSuiteAddOnsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="GSuiteAddOnsSettings"/>.</returns>
        public static GSuiteAddOnsSettings GetDefault() => new GSuiteAddOnsSettings();

        /// <summary>Constructs a new <see cref="GSuiteAddOnsSettings"/> object with default settings.</summary>
        public GSuiteAddOnsSettings()
        {
        }

        private GSuiteAddOnsSettings(GSuiteAddOnsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetAuthorizationSettings = existing.GetAuthorizationSettings;
            CreateDeploymentSettings = existing.CreateDeploymentSettings;
            ReplaceDeploymentSettings = existing.ReplaceDeploymentSettings;
            GetDeploymentSettings = existing.GetDeploymentSettings;
            ListDeploymentsSettings = existing.ListDeploymentsSettings;
            DeleteDeploymentSettings = existing.DeleteDeploymentSettings;
            InstallDeploymentSettings = existing.InstallDeploymentSettings;
            UninstallDeploymentSettings = existing.UninstallDeploymentSettings;
            GetInstallStatusSettings = existing.GetInstallStatusSettings;
            OnCopy(existing);
        }

        partial void OnCopy(GSuiteAddOnsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GSuiteAddOnsClient.GetAuthorization</c> and <c>GSuiteAddOnsClient.GetAuthorizationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAuthorizationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GSuiteAddOnsClient.CreateDeployment</c> and <c>GSuiteAddOnsClient.CreateDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateDeploymentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GSuiteAddOnsClient.ReplaceDeployment</c> and <c>GSuiteAddOnsClient.ReplaceDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReplaceDeploymentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GSuiteAddOnsClient.GetDeployment</c> and <c>GSuiteAddOnsClient.GetDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDeploymentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GSuiteAddOnsClient.ListDeployments</c> and <c>GSuiteAddOnsClient.ListDeploymentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDeploymentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GSuiteAddOnsClient.DeleteDeployment</c> and <c>GSuiteAddOnsClient.DeleteDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteDeploymentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GSuiteAddOnsClient.InstallDeployment</c> and <c>GSuiteAddOnsClient.InstallDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings InstallDeploymentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GSuiteAddOnsClient.UninstallDeployment</c> and <c>GSuiteAddOnsClient.UninstallDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UninstallDeploymentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GSuiteAddOnsClient.GetInstallStatus</c> and <c>GSuiteAddOnsClient.GetInstallStatusAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetInstallStatusSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="GSuiteAddOnsSettings"/> object.</returns>
        public GSuiteAddOnsSettings Clone() => new GSuiteAddOnsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="GSuiteAddOnsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class GSuiteAddOnsClientBuilder : gaxgrpc::ClientBuilderBase<GSuiteAddOnsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public GSuiteAddOnsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public GSuiteAddOnsClientBuilder() : base(GSuiteAddOnsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref GSuiteAddOnsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<GSuiteAddOnsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override GSuiteAddOnsClient Build()
        {
            GSuiteAddOnsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<GSuiteAddOnsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<GSuiteAddOnsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private GSuiteAddOnsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return GSuiteAddOnsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<GSuiteAddOnsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return GSuiteAddOnsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => GSuiteAddOnsClient.ChannelPool;
    }

    /// <summary>GSuiteAddOns client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service for managing Google Workspace Add-ons deployments.
    /// 
    /// A Google Workspace Add-on is a third-party embedded component that can be
    /// installed in Google Workspace Applications like Gmail, Calendar, Drive, and
    /// the Google Docs, Sheets, and Slides editors. Google Workspace Add-ons can
    /// display UI cards, receive contextual information from the host application,
    /// and perform actions in the host application (See:
    /// https://developers.google.com/gsuite/add-ons/overview for more information).
    /// 
    /// A Google Workspace Add-on deployment resource specifies metadata about the
    /// add-on, including a specification of the entry points in the host application
    /// that trigger add-on executions (see:
    /// https://developers.google.com/gsuite/add-ons/concepts/gsuite-manifests).
    /// Add-on deployments defined via the Google Workspace Add-ons API define their
    /// entrypoints using HTTPS URLs (See:
    /// https://developers.google.com/gsuite/add-ons/guides/alternate-runtimes),
    /// 
    /// A Google Workspace Add-on deployment can be installed in developer mode,
    /// which allows an add-on developer to test the experience an end-user would see
    /// when installing and running the add-on in their G Suite applications.  When
    /// running in developer mode, more detailed error messages are exposed in the
    /// add-on UI to aid in debugging.
    /// 
    /// A Google Workspace Add-on deployment can be published to Google Workspace
    /// Marketplace, which allows other Google Workspace users to discover and
    /// install the add-on.  See:
    /// https://developers.google.com/gsuite/add-ons/how-tos/publish-add-on-overview
    /// for details.
    /// </remarks>
    public abstract partial class GSuiteAddOnsClient
    {
        /// <summary>
        /// The default endpoint for the GSuiteAddOns service, which is a host of "gsuiteaddons.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "gsuiteaddons.googleapis.com:443";

        /// <summary>The default GSuiteAddOns scopes.</summary>
        /// <remarks>
        /// The default GSuiteAddOns scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(GSuiteAddOns.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="GSuiteAddOnsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="GSuiteAddOnsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="GSuiteAddOnsClient"/>.</returns>
        public static stt::Task<GSuiteAddOnsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new GSuiteAddOnsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="GSuiteAddOnsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="GSuiteAddOnsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="GSuiteAddOnsClient"/>.</returns>
        public static GSuiteAddOnsClient Create() => new GSuiteAddOnsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="GSuiteAddOnsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="GSuiteAddOnsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="GSuiteAddOnsClient"/>.</returns>
        internal static GSuiteAddOnsClient Create(grpccore::CallInvoker callInvoker, GSuiteAddOnsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            GSuiteAddOns.GSuiteAddOnsClient grpcClient = new GSuiteAddOns.GSuiteAddOnsClient(callInvoker);
            return new GSuiteAddOnsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC GSuiteAddOns client</summary>
        public virtual GSuiteAddOns.GSuiteAddOnsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the authorization information for deployments in a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Authorization GetAuthorization(GetAuthorizationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the authorization information for deployments in a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Authorization> GetAuthorizationAsync(GetAuthorizationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the authorization information for deployments in a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Authorization> GetAuthorizationAsync(GetAuthorizationRequest request, st::CancellationToken cancellationToken) =>
            GetAuthorizationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the authorization information for deployments in a given project.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the project for which to get the Google Workspace Add-ons
        /// authorization information.
        /// 
        /// Example: `projects/my_project/authorization`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Authorization GetAuthorization(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAuthorization(new GetAuthorizationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the authorization information for deployments in a given project.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the project for which to get the Google Workspace Add-ons
        /// authorization information.
        /// 
        /// Example: `projects/my_project/authorization`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Authorization> GetAuthorizationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAuthorizationAsync(new GetAuthorizationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the authorization information for deployments in a given project.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the project for which to get the Google Workspace Add-ons
        /// authorization information.
        /// 
        /// Example: `projects/my_project/authorization`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Authorization> GetAuthorizationAsync(string name, st::CancellationToken cancellationToken) =>
            GetAuthorizationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the authorization information for deployments in a given project.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the project for which to get the Google Workspace Add-ons
        /// authorization information.
        /// 
        /// Example: `projects/my_project/authorization`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Authorization GetAuthorization(AuthorizationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAuthorization(new GetAuthorizationRequest
            {
                AuthorizationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the authorization information for deployments in a given project.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the project for which to get the Google Workspace Add-ons
        /// authorization information.
        /// 
        /// Example: `projects/my_project/authorization`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Authorization> GetAuthorizationAsync(AuthorizationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAuthorizationAsync(new GetAuthorizationRequest
            {
                AuthorizationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the authorization information for deployments in a given project.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the project for which to get the Google Workspace Add-ons
        /// authorization information.
        /// 
        /// Example: `projects/my_project/authorization`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Authorization> GetAuthorizationAsync(AuthorizationName name, st::CancellationToken cancellationToken) =>
            GetAuthorizationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a deployment with the specified name and configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Deployment CreateDeployment(CreateDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a deployment with the specified name and configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> CreateDeploymentAsync(CreateDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a deployment with the specified name and configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> CreateDeploymentAsync(CreateDeploymentRequest request, st::CancellationToken cancellationToken) =>
            CreateDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a deployment with the specified name and configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the project in which to create the deployment.
        /// 
        /// Example: `projects/my_project`.
        /// </param>
        /// <param name="deployment">
        /// Required. The deployment to create (deployment.name cannot be set).
        /// </param>
        /// <param name="deploymentId">
        /// Required. The id to use for this deployment.  The full name of the created
        /// resource will be `projects/&lt;project_number&gt;/deployments/&lt;deployment_id&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Deployment CreateDeployment(string parent, Deployment deployment, string deploymentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeployment(new CreateDeploymentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DeploymentId = gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentId, nameof(deploymentId)),
                Deployment = gax::GaxPreconditions.CheckNotNull(deployment, nameof(deployment)),
            }, callSettings);

        /// <summary>
        /// Creates a deployment with the specified name and configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the project in which to create the deployment.
        /// 
        /// Example: `projects/my_project`.
        /// </param>
        /// <param name="deployment">
        /// Required. The deployment to create (deployment.name cannot be set).
        /// </param>
        /// <param name="deploymentId">
        /// Required. The id to use for this deployment.  The full name of the created
        /// resource will be `projects/&lt;project_number&gt;/deployments/&lt;deployment_id&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> CreateDeploymentAsync(string parent, Deployment deployment, string deploymentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeploymentAsync(new CreateDeploymentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DeploymentId = gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentId, nameof(deploymentId)),
                Deployment = gax::GaxPreconditions.CheckNotNull(deployment, nameof(deployment)),
            }, callSettings);

        /// <summary>
        /// Creates a deployment with the specified name and configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the project in which to create the deployment.
        /// 
        /// Example: `projects/my_project`.
        /// </param>
        /// <param name="deployment">
        /// Required. The deployment to create (deployment.name cannot be set).
        /// </param>
        /// <param name="deploymentId">
        /// Required. The id to use for this deployment.  The full name of the created
        /// resource will be `projects/&lt;project_number&gt;/deployments/&lt;deployment_id&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> CreateDeploymentAsync(string parent, Deployment deployment, string deploymentId, st::CancellationToken cancellationToken) =>
            CreateDeploymentAsync(parent, deployment, deploymentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a deployment with the specified name and configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the project in which to create the deployment.
        /// 
        /// Example: `projects/my_project`.
        /// </param>
        /// <param name="deployment">
        /// Required. The deployment to create (deployment.name cannot be set).
        /// </param>
        /// <param name="deploymentId">
        /// Required. The id to use for this deployment.  The full name of the created
        /// resource will be `projects/&lt;project_number&gt;/deployments/&lt;deployment_id&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Deployment CreateDeployment(gagr::ProjectName parent, Deployment deployment, string deploymentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeployment(new CreateDeploymentRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DeploymentId = gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentId, nameof(deploymentId)),
                Deployment = gax::GaxPreconditions.CheckNotNull(deployment, nameof(deployment)),
            }, callSettings);

        /// <summary>
        /// Creates a deployment with the specified name and configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the project in which to create the deployment.
        /// 
        /// Example: `projects/my_project`.
        /// </param>
        /// <param name="deployment">
        /// Required. The deployment to create (deployment.name cannot be set).
        /// </param>
        /// <param name="deploymentId">
        /// Required. The id to use for this deployment.  The full name of the created
        /// resource will be `projects/&lt;project_number&gt;/deployments/&lt;deployment_id&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> CreateDeploymentAsync(gagr::ProjectName parent, Deployment deployment, string deploymentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeploymentAsync(new CreateDeploymentRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DeploymentId = gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentId, nameof(deploymentId)),
                Deployment = gax::GaxPreconditions.CheckNotNull(deployment, nameof(deployment)),
            }, callSettings);

        /// <summary>
        /// Creates a deployment with the specified name and configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the project in which to create the deployment.
        /// 
        /// Example: `projects/my_project`.
        /// </param>
        /// <param name="deployment">
        /// Required. The deployment to create (deployment.name cannot be set).
        /// </param>
        /// <param name="deploymentId">
        /// Required. The id to use for this deployment.  The full name of the created
        /// resource will be `projects/&lt;project_number&gt;/deployments/&lt;deployment_id&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> CreateDeploymentAsync(gagr::ProjectName parent, Deployment deployment, string deploymentId, st::CancellationToken cancellationToken) =>
            CreateDeploymentAsync(parent, deployment, deploymentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or replaces a deployment with the specified name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Deployment ReplaceDeployment(ReplaceDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or replaces a deployment with the specified name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> ReplaceDeploymentAsync(ReplaceDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or replaces a deployment with the specified name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> ReplaceDeploymentAsync(ReplaceDeploymentRequest request, st::CancellationToken cancellationToken) =>
            ReplaceDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or replaces a deployment with the specified name.
        /// </summary>
        /// <param name="deployment">
        /// Required. The deployment to create or replace.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Deployment ReplaceDeployment(Deployment deployment, gaxgrpc::CallSettings callSettings = null) =>
            ReplaceDeployment(new ReplaceDeploymentRequest
            {
                Deployment = gax::GaxPreconditions.CheckNotNull(deployment, nameof(deployment)),
            }, callSettings);

        /// <summary>
        /// Creates or replaces a deployment with the specified name.
        /// </summary>
        /// <param name="deployment">
        /// Required. The deployment to create or replace.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> ReplaceDeploymentAsync(Deployment deployment, gaxgrpc::CallSettings callSettings = null) =>
            ReplaceDeploymentAsync(new ReplaceDeploymentRequest
            {
                Deployment = gax::GaxPreconditions.CheckNotNull(deployment, nameof(deployment)),
            }, callSettings);

        /// <summary>
        /// Creates or replaces a deployment with the specified name.
        /// </summary>
        /// <param name="deployment">
        /// Required. The deployment to create or replace.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> ReplaceDeploymentAsync(Deployment deployment, st::CancellationToken cancellationToken) =>
            ReplaceDeploymentAsync(deployment, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the deployment with the specified name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Deployment GetDeployment(GetDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the deployment with the specified name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> GetDeploymentAsync(GetDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the deployment with the specified name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> GetDeploymentAsync(GetDeploymentRequest request, st::CancellationToken cancellationToken) =>
            GetDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the deployment with the specified name.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the deployment to get.
        /// 
        /// Example:  `projects/my_project/deployments/my_deployment`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Deployment GetDeployment(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeployment(new GetDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the deployment with the specified name.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the deployment to get.
        /// 
        /// Example:  `projects/my_project/deployments/my_deployment`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> GetDeploymentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeploymentAsync(new GetDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the deployment with the specified name.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the deployment to get.
        /// 
        /// Example:  `projects/my_project/deployments/my_deployment`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> GetDeploymentAsync(string name, st::CancellationToken cancellationToken) =>
            GetDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the deployment with the specified name.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the deployment to get.
        /// 
        /// Example:  `projects/my_project/deployments/my_deployment`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Deployment GetDeployment(DeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeployment(new GetDeploymentRequest
            {
                DeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the deployment with the specified name.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the deployment to get.
        /// 
        /// Example:  `projects/my_project/deployments/my_deployment`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> GetDeploymentAsync(DeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeploymentAsync(new GetDeploymentRequest
            {
                DeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the deployment with the specified name.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the deployment to get.
        /// 
        /// Example:  `projects/my_project/deployments/my_deployment`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> GetDeploymentAsync(DeploymentName name, st::CancellationToken cancellationToken) =>
            GetDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all deployments in a particular project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Deployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeploymentsResponse, Deployment> ListDeployments(ListDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all deployments in a particular project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Deployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeploymentsResponse, Deployment> ListDeploymentsAsync(ListDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all deployments in a particular project.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the project in which to create the deployment.
        /// 
        /// Example: `projects/my_project`.
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
        /// Lists all deployments in a particular project.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the project in which to create the deployment.
        /// 
        /// Example: `projects/my_project`.
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
        /// Lists all deployments in a particular project.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the project in which to create the deployment.
        /// 
        /// Example: `projects/my_project`.
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
        public virtual gax::PagedEnumerable<ListDeploymentsResponse, Deployment> ListDeployments(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeploymentsRequest request = new ListDeploymentsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Lists all deployments in a particular project.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the project in which to create the deployment.
        /// 
        /// Example: `projects/my_project`.
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
        public virtual gax::PagedAsyncEnumerable<ListDeploymentsResponse, Deployment> ListDeploymentsAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeploymentsRequest request = new ListDeploymentsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Deletes the deployment with the given name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDeployment(DeleteDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the deployment with the given name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDeploymentAsync(DeleteDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the deployment with the given name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDeploymentAsync(DeleteDeploymentRequest request, st::CancellationToken cancellationToken) =>
            DeleteDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the deployment with the given name.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the deployment to delete.
        /// 
        /// Example:  `projects/my_project/deployments/my_deployment`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDeployment(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDeployment(new DeleteDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the deployment with the given name.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the deployment to delete.
        /// 
        /// Example:  `projects/my_project/deployments/my_deployment`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDeploymentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDeploymentAsync(new DeleteDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the deployment with the given name.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the deployment to delete.
        /// 
        /// Example:  `projects/my_project/deployments/my_deployment`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDeploymentAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the deployment with the given name.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the deployment to delete.
        /// 
        /// Example:  `projects/my_project/deployments/my_deployment`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDeployment(DeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDeployment(new DeleteDeploymentRequest
            {
                DeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the deployment with the given name.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the deployment to delete.
        /// 
        /// Example:  `projects/my_project/deployments/my_deployment`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDeploymentAsync(DeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDeploymentAsync(new DeleteDeploymentRequest
            {
                DeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the deployment with the given name.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the deployment to delete.
        /// 
        /// Example:  `projects/my_project/deployments/my_deployment`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDeploymentAsync(DeploymentName name, st::CancellationToken cancellationToken) =>
            DeleteDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Installs a deployment in developer mode.
        /// See:
        /// https://developers.google.com/gsuite/add-ons/how-tos/testing-gsuite-addons.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void InstallDeployment(InstallDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Installs a deployment in developer mode.
        /// See:
        /// https://developers.google.com/gsuite/add-ons/how-tos/testing-gsuite-addons.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task InstallDeploymentAsync(InstallDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Installs a deployment in developer mode.
        /// See:
        /// https://developers.google.com/gsuite/add-ons/how-tos/testing-gsuite-addons.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task InstallDeploymentAsync(InstallDeploymentRequest request, st::CancellationToken cancellationToken) =>
            InstallDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Installs a deployment in developer mode.
        /// See:
        /// https://developers.google.com/gsuite/add-ons/how-tos/testing-gsuite-addons.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the deployment to install.
        /// 
        /// Example:  `projects/my_project/deployments/my_deployment`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void InstallDeployment(string name, gaxgrpc::CallSettings callSettings = null) =>
            InstallDeployment(new InstallDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Installs a deployment in developer mode.
        /// See:
        /// https://developers.google.com/gsuite/add-ons/how-tos/testing-gsuite-addons.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the deployment to install.
        /// 
        /// Example:  `projects/my_project/deployments/my_deployment`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task InstallDeploymentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            InstallDeploymentAsync(new InstallDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Installs a deployment in developer mode.
        /// See:
        /// https://developers.google.com/gsuite/add-ons/how-tos/testing-gsuite-addons.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the deployment to install.
        /// 
        /// Example:  `projects/my_project/deployments/my_deployment`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task InstallDeploymentAsync(string name, st::CancellationToken cancellationToken) =>
            InstallDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Installs a deployment in developer mode.
        /// See:
        /// https://developers.google.com/gsuite/add-ons/how-tos/testing-gsuite-addons.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the deployment to install.
        /// 
        /// Example:  `projects/my_project/deployments/my_deployment`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void InstallDeployment(DeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            InstallDeployment(new InstallDeploymentRequest
            {
                DeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Installs a deployment in developer mode.
        /// See:
        /// https://developers.google.com/gsuite/add-ons/how-tos/testing-gsuite-addons.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the deployment to install.
        /// 
        /// Example:  `projects/my_project/deployments/my_deployment`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task InstallDeploymentAsync(DeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            InstallDeploymentAsync(new InstallDeploymentRequest
            {
                DeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Installs a deployment in developer mode.
        /// See:
        /// https://developers.google.com/gsuite/add-ons/how-tos/testing-gsuite-addons.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the deployment to install.
        /// 
        /// Example:  `projects/my_project/deployments/my_deployment`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task InstallDeploymentAsync(DeploymentName name, st::CancellationToken cancellationToken) =>
            InstallDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Uninstalls a developer mode deployment.
        /// See:
        /// https://developers.google.com/gsuite/add-ons/how-tos/testing-gsuite-addons.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void UninstallDeployment(UninstallDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Uninstalls a developer mode deployment.
        /// See:
        /// https://developers.google.com/gsuite/add-ons/how-tos/testing-gsuite-addons.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task UninstallDeploymentAsync(UninstallDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Uninstalls a developer mode deployment.
        /// See:
        /// https://developers.google.com/gsuite/add-ons/how-tos/testing-gsuite-addons.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task UninstallDeploymentAsync(UninstallDeploymentRequest request, st::CancellationToken cancellationToken) =>
            UninstallDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Uninstalls a developer mode deployment.
        /// See:
        /// https://developers.google.com/gsuite/add-ons/how-tos/testing-gsuite-addons.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the deployment to install.
        /// 
        /// Example:  `projects/my_project/deployments/my_deployment`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void UninstallDeployment(string name, gaxgrpc::CallSettings callSettings = null) =>
            UninstallDeployment(new UninstallDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Uninstalls a developer mode deployment.
        /// See:
        /// https://developers.google.com/gsuite/add-ons/how-tos/testing-gsuite-addons.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the deployment to install.
        /// 
        /// Example:  `projects/my_project/deployments/my_deployment`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task UninstallDeploymentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            UninstallDeploymentAsync(new UninstallDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Uninstalls a developer mode deployment.
        /// See:
        /// https://developers.google.com/gsuite/add-ons/how-tos/testing-gsuite-addons.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the deployment to install.
        /// 
        /// Example:  `projects/my_project/deployments/my_deployment`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task UninstallDeploymentAsync(string name, st::CancellationToken cancellationToken) =>
            UninstallDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Uninstalls a developer mode deployment.
        /// See:
        /// https://developers.google.com/gsuite/add-ons/how-tos/testing-gsuite-addons.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the deployment to install.
        /// 
        /// Example:  `projects/my_project/deployments/my_deployment`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void UninstallDeployment(DeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            UninstallDeployment(new UninstallDeploymentRequest
            {
                DeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Uninstalls a developer mode deployment.
        /// See:
        /// https://developers.google.com/gsuite/add-ons/how-tos/testing-gsuite-addons.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the deployment to install.
        /// 
        /// Example:  `projects/my_project/deployments/my_deployment`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task UninstallDeploymentAsync(DeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            UninstallDeploymentAsync(new UninstallDeploymentRequest
            {
                DeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Uninstalls a developer mode deployment.
        /// See:
        /// https://developers.google.com/gsuite/add-ons/how-tos/testing-gsuite-addons.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the deployment to install.
        /// 
        /// Example:  `projects/my_project/deployments/my_deployment`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task UninstallDeploymentAsync(DeploymentName name, st::CancellationToken cancellationToken) =>
            UninstallDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches the install status of a developer mode deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InstallStatus GetInstallStatus(GetInstallStatusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches the install status of a developer mode deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstallStatus> GetInstallStatusAsync(GetInstallStatusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches the install status of a developer mode deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstallStatus> GetInstallStatusAsync(GetInstallStatusRequest request, st::CancellationToken cancellationToken) =>
            GetInstallStatusAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches the install status of a developer mode deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the deployment.
        /// 
        /// Example:  `projects/my_project/deployments/my_deployment/installStatus`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InstallStatus GetInstallStatus(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstallStatus(new GetInstallStatusRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches the install status of a developer mode deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the deployment.
        /// 
        /// Example:  `projects/my_project/deployments/my_deployment/installStatus`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstallStatus> GetInstallStatusAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstallStatusAsync(new GetInstallStatusRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches the install status of a developer mode deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the deployment.
        /// 
        /// Example:  `projects/my_project/deployments/my_deployment/installStatus`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstallStatus> GetInstallStatusAsync(string name, st::CancellationToken cancellationToken) =>
            GetInstallStatusAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches the install status of a developer mode deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the deployment.
        /// 
        /// Example:  `projects/my_project/deployments/my_deployment/installStatus`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InstallStatus GetInstallStatus(InstallStatusName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstallStatus(new GetInstallStatusRequest
            {
                InstallStatusName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches the install status of a developer mode deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the deployment.
        /// 
        /// Example:  `projects/my_project/deployments/my_deployment/installStatus`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstallStatus> GetInstallStatusAsync(InstallStatusName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstallStatusAsync(new GetInstallStatusRequest
            {
                InstallStatusName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches the install status of a developer mode deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the deployment.
        /// 
        /// Example:  `projects/my_project/deployments/my_deployment/installStatus`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstallStatus> GetInstallStatusAsync(InstallStatusName name, st::CancellationToken cancellationToken) =>
            GetInstallStatusAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>GSuiteAddOns client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service for managing Google Workspace Add-ons deployments.
    /// 
    /// A Google Workspace Add-on is a third-party embedded component that can be
    /// installed in Google Workspace Applications like Gmail, Calendar, Drive, and
    /// the Google Docs, Sheets, and Slides editors. Google Workspace Add-ons can
    /// display UI cards, receive contextual information from the host application,
    /// and perform actions in the host application (See:
    /// https://developers.google.com/gsuite/add-ons/overview for more information).
    /// 
    /// A Google Workspace Add-on deployment resource specifies metadata about the
    /// add-on, including a specification of the entry points in the host application
    /// that trigger add-on executions (see:
    /// https://developers.google.com/gsuite/add-ons/concepts/gsuite-manifests).
    /// Add-on deployments defined via the Google Workspace Add-ons API define their
    /// entrypoints using HTTPS URLs (See:
    /// https://developers.google.com/gsuite/add-ons/guides/alternate-runtimes),
    /// 
    /// A Google Workspace Add-on deployment can be installed in developer mode,
    /// which allows an add-on developer to test the experience an end-user would see
    /// when installing and running the add-on in their G Suite applications.  When
    /// running in developer mode, more detailed error messages are exposed in the
    /// add-on UI to aid in debugging.
    /// 
    /// A Google Workspace Add-on deployment can be published to Google Workspace
    /// Marketplace, which allows other Google Workspace users to discover and
    /// install the add-on.  See:
    /// https://developers.google.com/gsuite/add-ons/how-tos/publish-add-on-overview
    /// for details.
    /// </remarks>
    public sealed partial class GSuiteAddOnsClientImpl : GSuiteAddOnsClient
    {
        private readonly gaxgrpc::ApiCall<GetAuthorizationRequest, Authorization> _callGetAuthorization;

        private readonly gaxgrpc::ApiCall<CreateDeploymentRequest, Deployment> _callCreateDeployment;

        private readonly gaxgrpc::ApiCall<ReplaceDeploymentRequest, Deployment> _callReplaceDeployment;

        private readonly gaxgrpc::ApiCall<GetDeploymentRequest, Deployment> _callGetDeployment;

        private readonly gaxgrpc::ApiCall<ListDeploymentsRequest, ListDeploymentsResponse> _callListDeployments;

        private readonly gaxgrpc::ApiCall<DeleteDeploymentRequest, wkt::Empty> _callDeleteDeployment;

        private readonly gaxgrpc::ApiCall<InstallDeploymentRequest, wkt::Empty> _callInstallDeployment;

        private readonly gaxgrpc::ApiCall<UninstallDeploymentRequest, wkt::Empty> _callUninstallDeployment;

        private readonly gaxgrpc::ApiCall<GetInstallStatusRequest, InstallStatus> _callGetInstallStatus;

        /// <summary>
        /// Constructs a client wrapper for the GSuiteAddOns service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="GSuiteAddOnsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public GSuiteAddOnsClientImpl(GSuiteAddOns.GSuiteAddOnsClient grpcClient, GSuiteAddOnsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            GSuiteAddOnsSettings effectiveSettings = settings ?? GSuiteAddOnsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetAuthorization = clientHelper.BuildApiCall<GetAuthorizationRequest, Authorization>("GetAuthorization", grpcClient.GetAuthorizationAsync, grpcClient.GetAuthorization, effectiveSettings.GetAuthorizationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAuthorization);
            Modify_GetAuthorizationApiCall(ref _callGetAuthorization);
            _callCreateDeployment = clientHelper.BuildApiCall<CreateDeploymentRequest, Deployment>("CreateDeployment", grpcClient.CreateDeploymentAsync, grpcClient.CreateDeployment, effectiveSettings.CreateDeploymentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDeployment);
            Modify_CreateDeploymentApiCall(ref _callCreateDeployment);
            _callReplaceDeployment = clientHelper.BuildApiCall<ReplaceDeploymentRequest, Deployment>("ReplaceDeployment", grpcClient.ReplaceDeploymentAsync, grpcClient.ReplaceDeployment, effectiveSettings.ReplaceDeploymentSettings).WithGoogleRequestParam("deployment.name", request => request.Deployment?.Name);
            Modify_ApiCall(ref _callReplaceDeployment);
            Modify_ReplaceDeploymentApiCall(ref _callReplaceDeployment);
            _callGetDeployment = clientHelper.BuildApiCall<GetDeploymentRequest, Deployment>("GetDeployment", grpcClient.GetDeploymentAsync, grpcClient.GetDeployment, effectiveSettings.GetDeploymentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDeployment);
            Modify_GetDeploymentApiCall(ref _callGetDeployment);
            _callListDeployments = clientHelper.BuildApiCall<ListDeploymentsRequest, ListDeploymentsResponse>("ListDeployments", grpcClient.ListDeploymentsAsync, grpcClient.ListDeployments, effectiveSettings.ListDeploymentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDeployments);
            Modify_ListDeploymentsApiCall(ref _callListDeployments);
            _callDeleteDeployment = clientHelper.BuildApiCall<DeleteDeploymentRequest, wkt::Empty>("DeleteDeployment", grpcClient.DeleteDeploymentAsync, grpcClient.DeleteDeployment, effectiveSettings.DeleteDeploymentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDeployment);
            Modify_DeleteDeploymentApiCall(ref _callDeleteDeployment);
            _callInstallDeployment = clientHelper.BuildApiCall<InstallDeploymentRequest, wkt::Empty>("InstallDeployment", grpcClient.InstallDeploymentAsync, grpcClient.InstallDeployment, effectiveSettings.InstallDeploymentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callInstallDeployment);
            Modify_InstallDeploymentApiCall(ref _callInstallDeployment);
            _callUninstallDeployment = clientHelper.BuildApiCall<UninstallDeploymentRequest, wkt::Empty>("UninstallDeployment", grpcClient.UninstallDeploymentAsync, grpcClient.UninstallDeployment, effectiveSettings.UninstallDeploymentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUninstallDeployment);
            Modify_UninstallDeploymentApiCall(ref _callUninstallDeployment);
            _callGetInstallStatus = clientHelper.BuildApiCall<GetInstallStatusRequest, InstallStatus>("GetInstallStatus", grpcClient.GetInstallStatusAsync, grpcClient.GetInstallStatus, effectiveSettings.GetInstallStatusSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetInstallStatus);
            Modify_GetInstallStatusApiCall(ref _callGetInstallStatus);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetAuthorizationApiCall(ref gaxgrpc::ApiCall<GetAuthorizationRequest, Authorization> call);

        partial void Modify_CreateDeploymentApiCall(ref gaxgrpc::ApiCall<CreateDeploymentRequest, Deployment> call);

        partial void Modify_ReplaceDeploymentApiCall(ref gaxgrpc::ApiCall<ReplaceDeploymentRequest, Deployment> call);

        partial void Modify_GetDeploymentApiCall(ref gaxgrpc::ApiCall<GetDeploymentRequest, Deployment> call);

        partial void Modify_ListDeploymentsApiCall(ref gaxgrpc::ApiCall<ListDeploymentsRequest, ListDeploymentsResponse> call);

        partial void Modify_DeleteDeploymentApiCall(ref gaxgrpc::ApiCall<DeleteDeploymentRequest, wkt::Empty> call);

        partial void Modify_InstallDeploymentApiCall(ref gaxgrpc::ApiCall<InstallDeploymentRequest, wkt::Empty> call);

        partial void Modify_UninstallDeploymentApiCall(ref gaxgrpc::ApiCall<UninstallDeploymentRequest, wkt::Empty> call);

        partial void Modify_GetInstallStatusApiCall(ref gaxgrpc::ApiCall<GetInstallStatusRequest, InstallStatus> call);

        partial void OnConstruction(GSuiteAddOns.GSuiteAddOnsClient grpcClient, GSuiteAddOnsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC GSuiteAddOns client</summary>
        public override GSuiteAddOns.GSuiteAddOnsClient GrpcClient { get; }

        partial void Modify_GetAuthorizationRequest(ref GetAuthorizationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateDeploymentRequest(ref CreateDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ReplaceDeploymentRequest(ref ReplaceDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDeploymentRequest(ref GetDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDeploymentsRequest(ref ListDeploymentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDeploymentRequest(ref DeleteDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_InstallDeploymentRequest(ref InstallDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UninstallDeploymentRequest(ref UninstallDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetInstallStatusRequest(ref GetInstallStatusRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets the authorization information for deployments in a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Authorization GetAuthorization(GetAuthorizationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAuthorizationRequest(ref request, ref callSettings);
            return _callGetAuthorization.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the authorization information for deployments in a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Authorization> GetAuthorizationAsync(GetAuthorizationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAuthorizationRequest(ref request, ref callSettings);
            return _callGetAuthorization.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a deployment with the specified name and configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Deployment CreateDeployment(CreateDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDeploymentRequest(ref request, ref callSettings);
            return _callCreateDeployment.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a deployment with the specified name and configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Deployment> CreateDeploymentAsync(CreateDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDeploymentRequest(ref request, ref callSettings);
            return _callCreateDeployment.Async(request, callSettings);
        }

        /// <summary>
        /// Creates or replaces a deployment with the specified name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Deployment ReplaceDeployment(ReplaceDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReplaceDeploymentRequest(ref request, ref callSettings);
            return _callReplaceDeployment.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates or replaces a deployment with the specified name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Deployment> ReplaceDeploymentAsync(ReplaceDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReplaceDeploymentRequest(ref request, ref callSettings);
            return _callReplaceDeployment.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the deployment with the specified name.
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
        /// Gets the deployment with the specified name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Deployment> GetDeploymentAsync(GetDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDeploymentRequest(ref request, ref callSettings);
            return _callGetDeployment.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all deployments in a particular project.
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
        /// Lists all deployments in a particular project.
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
        /// Deletes the deployment with the given name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteDeployment(DeleteDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDeploymentRequest(ref request, ref callSettings);
            _callDeleteDeployment.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the deployment with the given name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteDeploymentAsync(DeleteDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDeploymentRequest(ref request, ref callSettings);
            return _callDeleteDeployment.Async(request, callSettings);
        }

        /// <summary>
        /// Installs a deployment in developer mode.
        /// See:
        /// https://developers.google.com/gsuite/add-ons/how-tos/testing-gsuite-addons.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void InstallDeployment(InstallDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InstallDeploymentRequest(ref request, ref callSettings);
            _callInstallDeployment.Sync(request, callSettings);
        }

        /// <summary>
        /// Installs a deployment in developer mode.
        /// See:
        /// https://developers.google.com/gsuite/add-ons/how-tos/testing-gsuite-addons.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task InstallDeploymentAsync(InstallDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InstallDeploymentRequest(ref request, ref callSettings);
            return _callInstallDeployment.Async(request, callSettings);
        }

        /// <summary>
        /// Uninstalls a developer mode deployment.
        /// See:
        /// https://developers.google.com/gsuite/add-ons/how-tos/testing-gsuite-addons.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void UninstallDeployment(UninstallDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UninstallDeploymentRequest(ref request, ref callSettings);
            _callUninstallDeployment.Sync(request, callSettings);
        }

        /// <summary>
        /// Uninstalls a developer mode deployment.
        /// See:
        /// https://developers.google.com/gsuite/add-ons/how-tos/testing-gsuite-addons.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task UninstallDeploymentAsync(UninstallDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UninstallDeploymentRequest(ref request, ref callSettings);
            return _callUninstallDeployment.Async(request, callSettings);
        }

        /// <summary>
        /// Fetches the install status of a developer mode deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override InstallStatus GetInstallStatus(GetInstallStatusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInstallStatusRequest(ref request, ref callSettings);
            return _callGetInstallStatus.Sync(request, callSettings);
        }

        /// <summary>
        /// Fetches the install status of a developer mode deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<InstallStatus> GetInstallStatusAsync(GetInstallStatusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInstallStatusRequest(ref request, ref callSettings);
            return _callGetInstallStatus.Async(request, callSettings);
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
}
