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

namespace Google.Cloud.AppEngine.V1
{
    /// <summary>Settings for <see cref="VersionsClient"/> instances.</summary>
    public sealed partial class VersionsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="VersionsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="VersionsSettings"/>.</returns>
        public static VersionsSettings GetDefault() => new VersionsSettings();

        /// <summary>Constructs a new <see cref="VersionsSettings"/> object with default settings.</summary>
        public VersionsSettings()
        {
        }

        private VersionsSettings(VersionsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListVersionsSettings = existing.ListVersionsSettings;
            GetVersionSettings = existing.GetVersionSettings;
            CreateVersionSettings = existing.CreateVersionSettings;
            CreateVersionOperationsSettings = existing.CreateVersionOperationsSettings.Clone();
            UpdateVersionSettings = existing.UpdateVersionSettings;
            UpdateVersionOperationsSettings = existing.UpdateVersionOperationsSettings.Clone();
            DeleteVersionSettings = existing.DeleteVersionSettings;
            DeleteVersionOperationsSettings = existing.DeleteVersionOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(VersionsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>VersionsClient.ListVersions</c>
        ///  and <c>VersionsClient.ListVersionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListVersionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>VersionsClient.GetVersion</c>
        ///  and <c>VersionsClient.GetVersionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetVersionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VersionsClient.CreateVersion</c> and <c>VersionsClient.CreateVersionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateVersionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VersionsClient.CreateVersion</c> and
        /// <c>VersionsClient.CreateVersionAsync</c>.
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
        public lro::OperationsSettings CreateVersionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VersionsClient.UpdateVersion</c> and <c>VersionsClient.UpdateVersionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateVersionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VersionsClient.UpdateVersion</c> and
        /// <c>VersionsClient.UpdateVersionAsync</c>.
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
        public lro::OperationsSettings UpdateVersionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VersionsClient.DeleteVersion</c> and <c>VersionsClient.DeleteVersionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteVersionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VersionsClient.DeleteVersion</c> and
        /// <c>VersionsClient.DeleteVersionAsync</c>.
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
        public lro::OperationsSettings DeleteVersionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="VersionsSettings"/> object.</returns>
        public VersionsSettings Clone() => new VersionsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="VersionsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class VersionsClientBuilder : gaxgrpc::ClientBuilderBase<VersionsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public VersionsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public VersionsClientBuilder() : base(VersionsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref VersionsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<VersionsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override VersionsClient Build()
        {
            VersionsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<VersionsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<VersionsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private VersionsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return VersionsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<VersionsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return VersionsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => VersionsClient.ChannelPool;
    }

    /// <summary>Versions client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Manages versions of a service.
    /// </remarks>
    public abstract partial class VersionsClient
    {
        /// <summary>
        /// The default endpoint for the Versions service, which is a host of "appengine.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "appengine.googleapis.com:443";

        /// <summary>The default Versions scopes.</summary>
        /// <remarks>
        /// The default Versions scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/appengine.admin</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform.read-only</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/appengine.admin",
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud-platform.read-only",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Versions.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="VersionsClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="VersionsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="VersionsClient"/>.</returns>
        public static stt::Task<VersionsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new VersionsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="VersionsClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="VersionsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="VersionsClient"/>.</returns>
        public static VersionsClient Create() => new VersionsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="VersionsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="VersionsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="VersionsClient"/>.</returns>
        internal static VersionsClient Create(grpccore::CallInvoker callInvoker, VersionsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Versions.VersionsClient grpcClient = new Versions.VersionsClient(callInvoker);
            return new VersionsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Versions client</summary>
        public virtual Versions.VersionsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the versions of a service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Version"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVersionsResponse, Version> ListVersions(ListVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the versions of a service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Version"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVersionsResponse, Version> ListVersionsAsync(ListVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the specified Version resource.
        /// By default, only a `BASIC_VIEW` will be returned.
        /// Specify the `FULL_VIEW` parameter to get the full resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Version GetVersion(GetVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the specified Version resource.
        /// By default, only a `BASIC_VIEW` will be returned.
        /// Specify the `FULL_VIEW` parameter to get the full resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Version> GetVersionAsync(GetVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the specified Version resource.
        /// By default, only a `BASIC_VIEW` will be returned.
        /// Specify the `FULL_VIEW` parameter to get the full resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Version> GetVersionAsync(GetVersionRequest request, st::CancellationToken cancellationToken) =>
            GetVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deploys code and resource files to a new version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Version, CreateVersionMetadataV1> CreateVersion(CreateVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deploys code and resource files to a new version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Version, CreateVersionMetadataV1>> CreateVersionAsync(CreateVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deploys code and resource files to a new version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Version, CreateVersionMetadataV1>> CreateVersionAsync(CreateVersionRequest request, st::CancellationToken cancellationToken) =>
            CreateVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateVersion</c>.</summary>
        public virtual lro::OperationsClient CreateVersionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateVersion</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Version, CreateVersionMetadataV1> PollOnceCreateVersion(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Version, CreateVersionMetadataV1>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateVersionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateVersion</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Version, CreateVersionMetadataV1>> PollOnceCreateVersionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Version, CreateVersionMetadataV1>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateVersionOperationsClient, callSettings);

        /// <summary>
        /// Updates the specified Version resource.
        /// You can specify the following fields depending on the App Engine
        /// environment and type of scaling that the version resource uses:
        /// 
        /// **Standard environment**
        /// 
        /// * [`instance_class`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#Version.FIELDS.instance_class)
        /// 
        /// *automatic scaling* in the standard environment:
        /// 
        /// * [`automatic_scaling.min_idle_instances`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#Version.FIELDS.automatic_scaling)
        /// * [`automatic_scaling.max_idle_instances`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#Version.FIELDS.automatic_scaling)
        /// * [`automaticScaling.standard_scheduler_settings.max_instances`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#StandardSchedulerSettings)
        /// * [`automaticScaling.standard_scheduler_settings.min_instances`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#StandardSchedulerSettings)
        /// * [`automaticScaling.standard_scheduler_settings.target_cpu_utilization`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#StandardSchedulerSettings)
        /// * [`automaticScaling.standard_scheduler_settings.target_throughput_utilization`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#StandardSchedulerSettings)
        /// 
        /// *basic scaling* or *manual scaling* in the standard environment:
        /// 
        /// * [`serving_status`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#Version.FIELDS.serving_status)
        /// * [`manual_scaling.instances`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#manualscaling)
        /// 
        /// **Flexible environment**
        /// 
        /// * [`serving_status`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#Version.FIELDS.serving_status)
        /// 
        /// *automatic scaling* in the flexible environment:
        /// 
        /// * [`automatic_scaling.min_total_instances`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#Version.FIELDS.automatic_scaling)
        /// * [`automatic_scaling.max_total_instances`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#Version.FIELDS.automatic_scaling)
        /// * [`automatic_scaling.cool_down_period_sec`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#Version.FIELDS.automatic_scaling)
        /// * [`automatic_scaling.cpu_utilization.target_utilization`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#Version.FIELDS.automatic_scaling)
        /// 
        /// *manual scaling* in the flexible environment:
        /// 
        /// * [`manual_scaling.instances`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#manualscaling)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Version, OperationMetadataV1> UpdateVersion(UpdateVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified Version resource.
        /// You can specify the following fields depending on the App Engine
        /// environment and type of scaling that the version resource uses:
        /// 
        /// **Standard environment**
        /// 
        /// * [`instance_class`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#Version.FIELDS.instance_class)
        /// 
        /// *automatic scaling* in the standard environment:
        /// 
        /// * [`automatic_scaling.min_idle_instances`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#Version.FIELDS.automatic_scaling)
        /// * [`automatic_scaling.max_idle_instances`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#Version.FIELDS.automatic_scaling)
        /// * [`automaticScaling.standard_scheduler_settings.max_instances`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#StandardSchedulerSettings)
        /// * [`automaticScaling.standard_scheduler_settings.min_instances`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#StandardSchedulerSettings)
        /// * [`automaticScaling.standard_scheduler_settings.target_cpu_utilization`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#StandardSchedulerSettings)
        /// * [`automaticScaling.standard_scheduler_settings.target_throughput_utilization`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#StandardSchedulerSettings)
        /// 
        /// *basic scaling* or *manual scaling* in the standard environment:
        /// 
        /// * [`serving_status`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#Version.FIELDS.serving_status)
        /// * [`manual_scaling.instances`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#manualscaling)
        /// 
        /// **Flexible environment**
        /// 
        /// * [`serving_status`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#Version.FIELDS.serving_status)
        /// 
        /// *automatic scaling* in the flexible environment:
        /// 
        /// * [`automatic_scaling.min_total_instances`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#Version.FIELDS.automatic_scaling)
        /// * [`automatic_scaling.max_total_instances`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#Version.FIELDS.automatic_scaling)
        /// * [`automatic_scaling.cool_down_period_sec`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#Version.FIELDS.automatic_scaling)
        /// * [`automatic_scaling.cpu_utilization.target_utilization`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#Version.FIELDS.automatic_scaling)
        /// 
        /// *manual scaling* in the flexible environment:
        /// 
        /// * [`manual_scaling.instances`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#manualscaling)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Version, OperationMetadataV1>> UpdateVersionAsync(UpdateVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified Version resource.
        /// You can specify the following fields depending on the App Engine
        /// environment and type of scaling that the version resource uses:
        /// 
        /// **Standard environment**
        /// 
        /// * [`instance_class`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#Version.FIELDS.instance_class)
        /// 
        /// *automatic scaling* in the standard environment:
        /// 
        /// * [`automatic_scaling.min_idle_instances`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#Version.FIELDS.automatic_scaling)
        /// * [`automatic_scaling.max_idle_instances`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#Version.FIELDS.automatic_scaling)
        /// * [`automaticScaling.standard_scheduler_settings.max_instances`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#StandardSchedulerSettings)
        /// * [`automaticScaling.standard_scheduler_settings.min_instances`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#StandardSchedulerSettings)
        /// * [`automaticScaling.standard_scheduler_settings.target_cpu_utilization`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#StandardSchedulerSettings)
        /// * [`automaticScaling.standard_scheduler_settings.target_throughput_utilization`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#StandardSchedulerSettings)
        /// 
        /// *basic scaling* or *manual scaling* in the standard environment:
        /// 
        /// * [`serving_status`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#Version.FIELDS.serving_status)
        /// * [`manual_scaling.instances`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#manualscaling)
        /// 
        /// **Flexible environment**
        /// 
        /// * [`serving_status`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#Version.FIELDS.serving_status)
        /// 
        /// *automatic scaling* in the flexible environment:
        /// 
        /// * [`automatic_scaling.min_total_instances`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#Version.FIELDS.automatic_scaling)
        /// * [`automatic_scaling.max_total_instances`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#Version.FIELDS.automatic_scaling)
        /// * [`automatic_scaling.cool_down_period_sec`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#Version.FIELDS.automatic_scaling)
        /// * [`automatic_scaling.cpu_utilization.target_utilization`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#Version.FIELDS.automatic_scaling)
        /// 
        /// *manual scaling* in the flexible environment:
        /// 
        /// * [`manual_scaling.instances`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#manualscaling)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Version, OperationMetadataV1>> UpdateVersionAsync(UpdateVersionRequest request, st::CancellationToken cancellationToken) =>
            UpdateVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateVersion</c>.</summary>
        public virtual lro::OperationsClient UpdateVersionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateVersion</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Version, OperationMetadataV1> PollOnceUpdateVersion(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Version, OperationMetadataV1>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateVersionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateVersion</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Version, OperationMetadataV1>> PollOnceUpdateVersionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Version, OperationMetadataV1>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateVersionOperationsClient, callSettings);

        /// <summary>
        /// Deletes an existing Version resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadataV1> DeleteVersion(DeleteVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an existing Version resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadataV1>> DeleteVersionAsync(DeleteVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an existing Version resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadataV1>> DeleteVersionAsync(DeleteVersionRequest request, st::CancellationToken cancellationToken) =>
            DeleteVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteVersion</c>.</summary>
        public virtual lro::OperationsClient DeleteVersionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteVersion</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadataV1> PollOnceDeleteVersion(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadataV1>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteVersionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteVersion</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadataV1>> PollOnceDeleteVersionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadataV1>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteVersionOperationsClient, callSettings);
    }

    /// <summary>Versions client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Manages versions of a service.
    /// </remarks>
    public sealed partial class VersionsClientImpl : VersionsClient
    {
        private readonly gaxgrpc::ApiCall<ListVersionsRequest, ListVersionsResponse> _callListVersions;

        private readonly gaxgrpc::ApiCall<GetVersionRequest, Version> _callGetVersion;

        private readonly gaxgrpc::ApiCall<CreateVersionRequest, lro::Operation> _callCreateVersion;

        private readonly gaxgrpc::ApiCall<UpdateVersionRequest, lro::Operation> _callUpdateVersion;

        private readonly gaxgrpc::ApiCall<DeleteVersionRequest, lro::Operation> _callDeleteVersion;

        /// <summary>
        /// Constructs a client wrapper for the Versions service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="VersionsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public VersionsClientImpl(Versions.VersionsClient grpcClient, VersionsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            VersionsSettings effectiveSettings = settings ?? VersionsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateVersionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateVersionOperationsSettings, logger);
            UpdateVersionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateVersionOperationsSettings, logger);
            DeleteVersionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteVersionOperationsSettings, logger);
            _callListVersions = clientHelper.BuildApiCall<ListVersionsRequest, ListVersionsResponse>("ListVersions", grpcClient.ListVersionsAsync, grpcClient.ListVersions, effectiveSettings.ListVersionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListVersions);
            Modify_ListVersionsApiCall(ref _callListVersions);
            _callGetVersion = clientHelper.BuildApiCall<GetVersionRequest, Version>("GetVersion", grpcClient.GetVersionAsync, grpcClient.GetVersion, effectiveSettings.GetVersionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetVersion);
            Modify_GetVersionApiCall(ref _callGetVersion);
            _callCreateVersion = clientHelper.BuildApiCall<CreateVersionRequest, lro::Operation>("CreateVersion", grpcClient.CreateVersionAsync, grpcClient.CreateVersion, effectiveSettings.CreateVersionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateVersion);
            Modify_CreateVersionApiCall(ref _callCreateVersion);
            _callUpdateVersion = clientHelper.BuildApiCall<UpdateVersionRequest, lro::Operation>("UpdateVersion", grpcClient.UpdateVersionAsync, grpcClient.UpdateVersion, effectiveSettings.UpdateVersionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateVersion);
            Modify_UpdateVersionApiCall(ref _callUpdateVersion);
            _callDeleteVersion = clientHelper.BuildApiCall<DeleteVersionRequest, lro::Operation>("DeleteVersion", grpcClient.DeleteVersionAsync, grpcClient.DeleteVersion, effectiveSettings.DeleteVersionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteVersion);
            Modify_DeleteVersionApiCall(ref _callDeleteVersion);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListVersionsApiCall(ref gaxgrpc::ApiCall<ListVersionsRequest, ListVersionsResponse> call);

        partial void Modify_GetVersionApiCall(ref gaxgrpc::ApiCall<GetVersionRequest, Version> call);

        partial void Modify_CreateVersionApiCall(ref gaxgrpc::ApiCall<CreateVersionRequest, lro::Operation> call);

        partial void Modify_UpdateVersionApiCall(ref gaxgrpc::ApiCall<UpdateVersionRequest, lro::Operation> call);

        partial void Modify_DeleteVersionApiCall(ref gaxgrpc::ApiCall<DeleteVersionRequest, lro::Operation> call);

        partial void OnConstruction(Versions.VersionsClient grpcClient, VersionsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Versions client</summary>
        public override Versions.VersionsClient GrpcClient { get; }

        partial void Modify_ListVersionsRequest(ref ListVersionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetVersionRequest(ref GetVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateVersionRequest(ref CreateVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateVersionRequest(ref UpdateVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteVersionRequest(ref DeleteVersionRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists the versions of a service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Version"/> resources.</returns>
        public override gax::PagedEnumerable<ListVersionsResponse, Version> ListVersions(ListVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListVersionsRequest, ListVersionsResponse, Version>(_callListVersions, request, callSettings);
        }

        /// <summary>
        /// Lists the versions of a service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Version"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListVersionsResponse, Version> ListVersionsAsync(ListVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListVersionsRequest, ListVersionsResponse, Version>(_callListVersions, request, callSettings);
        }

        /// <summary>
        /// Gets the specified Version resource.
        /// By default, only a `BASIC_VIEW` will be returned.
        /// Specify the `FULL_VIEW` parameter to get the full resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Version GetVersion(GetVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVersionRequest(ref request, ref callSettings);
            return _callGetVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the specified Version resource.
        /// By default, only a `BASIC_VIEW` will be returned.
        /// Specify the `FULL_VIEW` parameter to get the full resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Version> GetVersionAsync(GetVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVersionRequest(ref request, ref callSettings);
            return _callGetVersion.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateVersion</c>.</summary>
        public override lro::OperationsClient CreateVersionOperationsClient { get; }

        /// <summary>
        /// Deploys code and resource files to a new version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Version, CreateVersionMetadataV1> CreateVersion(CreateVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateVersionRequest(ref request, ref callSettings);
            return new lro::Operation<Version, CreateVersionMetadataV1>(_callCreateVersion.Sync(request, callSettings), CreateVersionOperationsClient);
        }

        /// <summary>
        /// Deploys code and resource files to a new version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Version, CreateVersionMetadataV1>> CreateVersionAsync(CreateVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateVersionRequest(ref request, ref callSettings);
            return new lro::Operation<Version, CreateVersionMetadataV1>(await _callCreateVersion.Async(request, callSettings).ConfigureAwait(false), CreateVersionOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateVersion</c>.</summary>
        public override lro::OperationsClient UpdateVersionOperationsClient { get; }

        /// <summary>
        /// Updates the specified Version resource.
        /// You can specify the following fields depending on the App Engine
        /// environment and type of scaling that the version resource uses:
        /// 
        /// **Standard environment**
        /// 
        /// * [`instance_class`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#Version.FIELDS.instance_class)
        /// 
        /// *automatic scaling* in the standard environment:
        /// 
        /// * [`automatic_scaling.min_idle_instances`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#Version.FIELDS.automatic_scaling)
        /// * [`automatic_scaling.max_idle_instances`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#Version.FIELDS.automatic_scaling)
        /// * [`automaticScaling.standard_scheduler_settings.max_instances`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#StandardSchedulerSettings)
        /// * [`automaticScaling.standard_scheduler_settings.min_instances`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#StandardSchedulerSettings)
        /// * [`automaticScaling.standard_scheduler_settings.target_cpu_utilization`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#StandardSchedulerSettings)
        /// * [`automaticScaling.standard_scheduler_settings.target_throughput_utilization`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#StandardSchedulerSettings)
        /// 
        /// *basic scaling* or *manual scaling* in the standard environment:
        /// 
        /// * [`serving_status`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#Version.FIELDS.serving_status)
        /// * [`manual_scaling.instances`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#manualscaling)
        /// 
        /// **Flexible environment**
        /// 
        /// * [`serving_status`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#Version.FIELDS.serving_status)
        /// 
        /// *automatic scaling* in the flexible environment:
        /// 
        /// * [`automatic_scaling.min_total_instances`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#Version.FIELDS.automatic_scaling)
        /// * [`automatic_scaling.max_total_instances`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#Version.FIELDS.automatic_scaling)
        /// * [`automatic_scaling.cool_down_period_sec`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#Version.FIELDS.automatic_scaling)
        /// * [`automatic_scaling.cpu_utilization.target_utilization`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#Version.FIELDS.automatic_scaling)
        /// 
        /// *manual scaling* in the flexible environment:
        /// 
        /// * [`manual_scaling.instances`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#manualscaling)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Version, OperationMetadataV1> UpdateVersion(UpdateVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateVersionRequest(ref request, ref callSettings);
            return new lro::Operation<Version, OperationMetadataV1>(_callUpdateVersion.Sync(request, callSettings), UpdateVersionOperationsClient);
        }

        /// <summary>
        /// Updates the specified Version resource.
        /// You can specify the following fields depending on the App Engine
        /// environment and type of scaling that the version resource uses:
        /// 
        /// **Standard environment**
        /// 
        /// * [`instance_class`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#Version.FIELDS.instance_class)
        /// 
        /// *automatic scaling* in the standard environment:
        /// 
        /// * [`automatic_scaling.min_idle_instances`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#Version.FIELDS.automatic_scaling)
        /// * [`automatic_scaling.max_idle_instances`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#Version.FIELDS.automatic_scaling)
        /// * [`automaticScaling.standard_scheduler_settings.max_instances`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#StandardSchedulerSettings)
        /// * [`automaticScaling.standard_scheduler_settings.min_instances`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#StandardSchedulerSettings)
        /// * [`automaticScaling.standard_scheduler_settings.target_cpu_utilization`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#StandardSchedulerSettings)
        /// * [`automaticScaling.standard_scheduler_settings.target_throughput_utilization`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#StandardSchedulerSettings)
        /// 
        /// *basic scaling* or *manual scaling* in the standard environment:
        /// 
        /// * [`serving_status`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#Version.FIELDS.serving_status)
        /// * [`manual_scaling.instances`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#manualscaling)
        /// 
        /// **Flexible environment**
        /// 
        /// * [`serving_status`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#Version.FIELDS.serving_status)
        /// 
        /// *automatic scaling* in the flexible environment:
        /// 
        /// * [`automatic_scaling.min_total_instances`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#Version.FIELDS.automatic_scaling)
        /// * [`automatic_scaling.max_total_instances`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#Version.FIELDS.automatic_scaling)
        /// * [`automatic_scaling.cool_down_period_sec`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#Version.FIELDS.automatic_scaling)
        /// * [`automatic_scaling.cpu_utilization.target_utilization`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#Version.FIELDS.automatic_scaling)
        /// 
        /// *manual scaling* in the flexible environment:
        /// 
        /// * [`manual_scaling.instances`](https://cloud.google.com/appengine/docs/admin-api/reference/rest/v1/apps.services.versions#manualscaling)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Version, OperationMetadataV1>> UpdateVersionAsync(UpdateVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateVersionRequest(ref request, ref callSettings);
            return new lro::Operation<Version, OperationMetadataV1>(await _callUpdateVersion.Async(request, callSettings).ConfigureAwait(false), UpdateVersionOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteVersion</c>.</summary>
        public override lro::OperationsClient DeleteVersionOperationsClient { get; }

        /// <summary>
        /// Deletes an existing Version resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadataV1> DeleteVersion(DeleteVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteVersionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadataV1>(_callDeleteVersion.Sync(request, callSettings), DeleteVersionOperationsClient);
        }

        /// <summary>
        /// Deletes an existing Version resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadataV1>> DeleteVersionAsync(DeleteVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteVersionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadataV1>(await _callDeleteVersion.Async(request, callSettings).ConfigureAwait(false), DeleteVersionOperationsClient);
        }
    }

    public partial class ListVersionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListVersionsResponse : gaxgrpc::IPageResponse<Version>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Version> GetEnumerator() => Versions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Versions
    {
        public partial class VersionsClient
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
