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
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.DiscoveryEngine.V1
{
    /// <summary>Settings for <see cref="CmekConfigServiceClient"/> instances.</summary>
    public sealed partial class CmekConfigServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CmekConfigServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CmekConfigServiceSettings"/>.</returns>
        public static CmekConfigServiceSettings GetDefault() => new CmekConfigServiceSettings();

        /// <summary>Constructs a new <see cref="CmekConfigServiceSettings"/> object with default settings.</summary>
        public CmekConfigServiceSettings()
        {
        }

        private CmekConfigServiceSettings(CmekConfigServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            UpdateCmekConfigSettings = existing.UpdateCmekConfigSettings;
            UpdateCmekConfigOperationsSettings = existing.UpdateCmekConfigOperationsSettings.Clone();
            GetCmekConfigSettings = existing.GetCmekConfigSettings;
            ListCmekConfigsSettings = existing.ListCmekConfigsSettings;
            DeleteCmekConfigSettings = existing.DeleteCmekConfigSettings;
            DeleteCmekConfigOperationsSettings = existing.DeleteCmekConfigOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CmekConfigServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CmekConfigServiceClient.UpdateCmekConfig</c> and <c>CmekConfigServiceClient.UpdateCmekConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateCmekConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>CmekConfigServiceClient.UpdateCmekConfig</c> and
        /// <c>CmekConfigServiceClient.UpdateCmekConfigAsync</c>.
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
        public lro::OperationsSettings UpdateCmekConfigOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CmekConfigServiceClient.GetCmekConfig</c> and <c>CmekConfigServiceClient.GetCmekConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCmekConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CmekConfigServiceClient.ListCmekConfigs</c> and <c>CmekConfigServiceClient.ListCmekConfigsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListCmekConfigsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CmekConfigServiceClient.DeleteCmekConfig</c> and <c>CmekConfigServiceClient.DeleteCmekConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteCmekConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>CmekConfigServiceClient.DeleteCmekConfig</c> and
        /// <c>CmekConfigServiceClient.DeleteCmekConfigAsync</c>.
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
        public lro::OperationsSettings DeleteCmekConfigOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CmekConfigServiceSettings"/> object.</returns>
        public CmekConfigServiceSettings Clone() => new CmekConfigServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CmekConfigServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class CmekConfigServiceClientBuilder : gaxgrpc::ClientBuilderBase<CmekConfigServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CmekConfigServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CmekConfigServiceClientBuilder() : base(CmekConfigServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CmekConfigServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CmekConfigServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CmekConfigServiceClient Build()
        {
            CmekConfigServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CmekConfigServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CmekConfigServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CmekConfigServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CmekConfigServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CmekConfigServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CmekConfigServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CmekConfigServiceClient.ChannelPool;
    }

    /// <summary>CmekConfigService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing CMEK related tasks
    /// </remarks>
    public abstract partial class CmekConfigServiceClient
    {
        /// <summary>
        /// The default endpoint for the CmekConfigService service, which is a host of "discoveryengine.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "discoveryengine.googleapis.com:443";

        /// <summary>The default CmekConfigService scopes.</summary>
        /// <remarks>
        /// The default CmekConfigService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CmekConfigService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CmekConfigServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CmekConfigServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CmekConfigServiceClient"/>.</returns>
        public static stt::Task<CmekConfigServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CmekConfigServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CmekConfigServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CmekConfigServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CmekConfigServiceClient"/>.</returns>
        public static CmekConfigServiceClient Create() => new CmekConfigServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CmekConfigServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CmekConfigServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CmekConfigServiceClient"/>.</returns>
        internal static CmekConfigServiceClient Create(grpccore::CallInvoker callInvoker, CmekConfigServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CmekConfigService.CmekConfigServiceClient grpcClient = new CmekConfigService.CmekConfigServiceClient(callInvoker);
            return new CmekConfigServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CmekConfigService client</summary>
        public virtual CmekConfigService.CmekConfigServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Provisions a CMEK key for use in a location of a customer's project.
        /// This method will also conduct location validation on the provided
        /// cmekConfig to make sure the key is valid and can be used in the
        /// selected location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CmekConfig, UpdateCmekConfigMetadata> UpdateCmekConfig(UpdateCmekConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Provisions a CMEK key for use in a location of a customer's project.
        /// This method will also conduct location validation on the provided
        /// cmekConfig to make sure the key is valid and can be used in the
        /// selected location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CmekConfig, UpdateCmekConfigMetadata>> UpdateCmekConfigAsync(UpdateCmekConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Provisions a CMEK key for use in a location of a customer's project.
        /// This method will also conduct location validation on the provided
        /// cmekConfig to make sure the key is valid and can be used in the
        /// selected location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CmekConfig, UpdateCmekConfigMetadata>> UpdateCmekConfigAsync(UpdateCmekConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateCmekConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateCmekConfig</c>.</summary>
        public virtual lro::OperationsClient UpdateCmekConfigOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateCmekConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<CmekConfig, UpdateCmekConfigMetadata> PollOnceUpdateCmekConfig(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CmekConfig, UpdateCmekConfigMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateCmekConfigOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateCmekConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<CmekConfig, UpdateCmekConfigMetadata>> PollOnceUpdateCmekConfigAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CmekConfig, UpdateCmekConfigMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateCmekConfigOperationsClient, callSettings);

        /// <summary>
        /// Provisions a CMEK key for use in a location of a customer's project.
        /// This method will also conduct location validation on the provided
        /// cmekConfig to make sure the key is valid and can be used in the
        /// selected location.
        /// </summary>
        /// <param name="config">
        /// Required. The CmekConfig resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CmekConfig, UpdateCmekConfigMetadata> UpdateCmekConfig(CmekConfig config, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCmekConfig(new UpdateCmekConfigRequest
            {
                Config = gax::GaxPreconditions.CheckNotNull(config, nameof(config)),
            }, callSettings);

        /// <summary>
        /// Provisions a CMEK key for use in a location of a customer's project.
        /// This method will also conduct location validation on the provided
        /// cmekConfig to make sure the key is valid and can be used in the
        /// selected location.
        /// </summary>
        /// <param name="config">
        /// Required. The CmekConfig resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CmekConfig, UpdateCmekConfigMetadata>> UpdateCmekConfigAsync(CmekConfig config, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCmekConfigAsync(new UpdateCmekConfigRequest
            {
                Config = gax::GaxPreconditions.CheckNotNull(config, nameof(config)),
            }, callSettings);

        /// <summary>
        /// Provisions a CMEK key for use in a location of a customer's project.
        /// This method will also conduct location validation on the provided
        /// cmekConfig to make sure the key is valid and can be used in the
        /// selected location.
        /// </summary>
        /// <param name="config">
        /// Required. The CmekConfig resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CmekConfig, UpdateCmekConfigMetadata>> UpdateCmekConfigAsync(CmekConfig config, st::CancellationToken cancellationToken) =>
            UpdateCmekConfigAsync(config, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the [CmekConfig][google.cloud.discoveryengine.v1.CmekConfig].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CmekConfig GetCmekConfig(GetCmekConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the [CmekConfig][google.cloud.discoveryengine.v1.CmekConfig].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CmekConfig> GetCmekConfigAsync(GetCmekConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the [CmekConfig][google.cloud.discoveryengine.v1.CmekConfig].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CmekConfig> GetCmekConfigAsync(GetCmekConfigRequest request, st::CancellationToken cancellationToken) =>
            GetCmekConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the [CmekConfig][google.cloud.discoveryengine.v1.CmekConfig].
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of
        /// [CmekConfig][google.cloud.discoveryengine.v1.CmekConfig], such as
        /// `projects/*/locations/*/cmekConfig` or
        /// `projects/*/locations/*/cmekConfigs/*`.
        /// 
        /// If the caller does not have permission to access the
        /// [CmekConfig][google.cloud.discoveryengine.v1.CmekConfig], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CmekConfig GetCmekConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCmekConfig(new GetCmekConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the [CmekConfig][google.cloud.discoveryengine.v1.CmekConfig].
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of
        /// [CmekConfig][google.cloud.discoveryengine.v1.CmekConfig], such as
        /// `projects/*/locations/*/cmekConfig` or
        /// `projects/*/locations/*/cmekConfigs/*`.
        /// 
        /// If the caller does not have permission to access the
        /// [CmekConfig][google.cloud.discoveryengine.v1.CmekConfig], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CmekConfig> GetCmekConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCmekConfigAsync(new GetCmekConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the [CmekConfig][google.cloud.discoveryengine.v1.CmekConfig].
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of
        /// [CmekConfig][google.cloud.discoveryengine.v1.CmekConfig], such as
        /// `projects/*/locations/*/cmekConfig` or
        /// `projects/*/locations/*/cmekConfigs/*`.
        /// 
        /// If the caller does not have permission to access the
        /// [CmekConfig][google.cloud.discoveryengine.v1.CmekConfig], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CmekConfig> GetCmekConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetCmekConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the [CmekConfig][google.cloud.discoveryengine.v1.CmekConfig].
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of
        /// [CmekConfig][google.cloud.discoveryengine.v1.CmekConfig], such as
        /// `projects/*/locations/*/cmekConfig` or
        /// `projects/*/locations/*/cmekConfigs/*`.
        /// 
        /// If the caller does not have permission to access the
        /// [CmekConfig][google.cloud.discoveryengine.v1.CmekConfig], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CmekConfig GetCmekConfig(CmekConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCmekConfig(new GetCmekConfigRequest
            {
                CmekConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the [CmekConfig][google.cloud.discoveryengine.v1.CmekConfig].
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of
        /// [CmekConfig][google.cloud.discoveryengine.v1.CmekConfig], such as
        /// `projects/*/locations/*/cmekConfig` or
        /// `projects/*/locations/*/cmekConfigs/*`.
        /// 
        /// If the caller does not have permission to access the
        /// [CmekConfig][google.cloud.discoveryengine.v1.CmekConfig], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CmekConfig> GetCmekConfigAsync(CmekConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCmekConfigAsync(new GetCmekConfigRequest
            {
                CmekConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the [CmekConfig][google.cloud.discoveryengine.v1.CmekConfig].
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of
        /// [CmekConfig][google.cloud.discoveryengine.v1.CmekConfig], such as
        /// `projects/*/locations/*/cmekConfig` or
        /// `projects/*/locations/*/cmekConfigs/*`.
        /// 
        /// If the caller does not have permission to access the
        /// [CmekConfig][google.cloud.discoveryengine.v1.CmekConfig], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CmekConfig> GetCmekConfigAsync(CmekConfigName name, st::CancellationToken cancellationToken) =>
            GetCmekConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all the [CmekConfig][google.cloud.discoveryengine.v1.CmekConfig]s
        /// with the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListCmekConfigsResponse ListCmekConfigs(ListCmekConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the [CmekConfig][google.cloud.discoveryengine.v1.CmekConfig]s
        /// with the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListCmekConfigsResponse> ListCmekConfigsAsync(ListCmekConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the [CmekConfig][google.cloud.discoveryengine.v1.CmekConfig]s
        /// with the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListCmekConfigsResponse> ListCmekConfigsAsync(ListCmekConfigsRequest request, st::CancellationToken cancellationToken) =>
            ListCmekConfigsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all the [CmekConfig][google.cloud.discoveryengine.v1.CmekConfig]s
        /// with the project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location resource name, such as
        /// `projects/{project}/locations/{location}`.
        /// 
        /// If the caller does not have permission to list
        /// [CmekConfig][google.cloud.discoveryengine.v1.CmekConfig]s under this
        /// location, regardless of whether or not a CmekConfig exists, a
        /// PERMISSION_DENIED error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListCmekConfigsResponse ListCmekConfigs(string parent, gaxgrpc::CallSettings callSettings = null) =>
            ListCmekConfigs(new ListCmekConfigsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Lists all the [CmekConfig][google.cloud.discoveryengine.v1.CmekConfig]s
        /// with the project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location resource name, such as
        /// `projects/{project}/locations/{location}`.
        /// 
        /// If the caller does not have permission to list
        /// [CmekConfig][google.cloud.discoveryengine.v1.CmekConfig]s under this
        /// location, regardless of whether or not a CmekConfig exists, a
        /// PERMISSION_DENIED error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListCmekConfigsResponse> ListCmekConfigsAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            ListCmekConfigsAsync(new ListCmekConfigsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Lists all the [CmekConfig][google.cloud.discoveryengine.v1.CmekConfig]s
        /// with the project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location resource name, such as
        /// `projects/{project}/locations/{location}`.
        /// 
        /// If the caller does not have permission to list
        /// [CmekConfig][google.cloud.discoveryengine.v1.CmekConfig]s under this
        /// location, regardless of whether or not a CmekConfig exists, a
        /// PERMISSION_DENIED error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListCmekConfigsResponse> ListCmekConfigsAsync(string parent, st::CancellationToken cancellationToken) =>
            ListCmekConfigsAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all the [CmekConfig][google.cloud.discoveryengine.v1.CmekConfig]s
        /// with the project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location resource name, such as
        /// `projects/{project}/locations/{location}`.
        /// 
        /// If the caller does not have permission to list
        /// [CmekConfig][google.cloud.discoveryengine.v1.CmekConfig]s under this
        /// location, regardless of whether or not a CmekConfig exists, a
        /// PERMISSION_DENIED error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListCmekConfigsResponse ListCmekConfigs(LocationName parent, gaxgrpc::CallSettings callSettings = null) =>
            ListCmekConfigs(new ListCmekConfigsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Lists all the [CmekConfig][google.cloud.discoveryengine.v1.CmekConfig]s
        /// with the project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location resource name, such as
        /// `projects/{project}/locations/{location}`.
        /// 
        /// If the caller does not have permission to list
        /// [CmekConfig][google.cloud.discoveryengine.v1.CmekConfig]s under this
        /// location, regardless of whether or not a CmekConfig exists, a
        /// PERMISSION_DENIED error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListCmekConfigsResponse> ListCmekConfigsAsync(LocationName parent, gaxgrpc::CallSettings callSettings = null) =>
            ListCmekConfigsAsync(new ListCmekConfigsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Lists all the [CmekConfig][google.cloud.discoveryengine.v1.CmekConfig]s
        /// with the project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location resource name, such as
        /// `projects/{project}/locations/{location}`.
        /// 
        /// If the caller does not have permission to list
        /// [CmekConfig][google.cloud.discoveryengine.v1.CmekConfig]s under this
        /// location, regardless of whether or not a CmekConfig exists, a
        /// PERMISSION_DENIED error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListCmekConfigsResponse> ListCmekConfigsAsync(LocationName parent, st::CancellationToken cancellationToken) =>
            ListCmekConfigsAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// De-provisions a CmekConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteCmekConfigMetadata> DeleteCmekConfig(DeleteCmekConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// De-provisions a CmekConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteCmekConfigMetadata>> DeleteCmekConfigAsync(DeleteCmekConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// De-provisions a CmekConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteCmekConfigMetadata>> DeleteCmekConfigAsync(DeleteCmekConfigRequest request, st::CancellationToken cancellationToken) =>
            DeleteCmekConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteCmekConfig</c>.</summary>
        public virtual lro::OperationsClient DeleteCmekConfigOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteCmekConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteCmekConfigMetadata> PollOnceDeleteCmekConfig(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteCmekConfigMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteCmekConfigOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteCmekConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteCmekConfigMetadata>> PollOnceDeleteCmekConfigAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteCmekConfigMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteCmekConfigOperationsClient, callSettings);

        /// <summary>
        /// De-provisions a CmekConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [CmekConfig][google.cloud.discoveryengine.v1.CmekConfig] to delete, such as
        /// `projects/{project}/locations/{location}/cmekConfigs/{cmek_config}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteCmekConfigMetadata> DeleteCmekConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCmekConfig(new DeleteCmekConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// De-provisions a CmekConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [CmekConfig][google.cloud.discoveryengine.v1.CmekConfig] to delete, such as
        /// `projects/{project}/locations/{location}/cmekConfigs/{cmek_config}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteCmekConfigMetadata>> DeleteCmekConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCmekConfigAsync(new DeleteCmekConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// De-provisions a CmekConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [CmekConfig][google.cloud.discoveryengine.v1.CmekConfig] to delete, such as
        /// `projects/{project}/locations/{location}/cmekConfigs/{cmek_config}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteCmekConfigMetadata>> DeleteCmekConfigAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteCmekConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// De-provisions a CmekConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [CmekConfig][google.cloud.discoveryengine.v1.CmekConfig] to delete, such as
        /// `projects/{project}/locations/{location}/cmekConfigs/{cmek_config}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteCmekConfigMetadata> DeleteCmekConfig(CmekConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCmekConfig(new DeleteCmekConfigRequest
            {
                CmekConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// De-provisions a CmekConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [CmekConfig][google.cloud.discoveryengine.v1.CmekConfig] to delete, such as
        /// `projects/{project}/locations/{location}/cmekConfigs/{cmek_config}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteCmekConfigMetadata>> DeleteCmekConfigAsync(CmekConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCmekConfigAsync(new DeleteCmekConfigRequest
            {
                CmekConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// De-provisions a CmekConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [CmekConfig][google.cloud.discoveryengine.v1.CmekConfig] to delete, such as
        /// `projects/{project}/locations/{location}/cmekConfigs/{cmek_config}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteCmekConfigMetadata>> DeleteCmekConfigAsync(CmekConfigName name, st::CancellationToken cancellationToken) =>
            DeleteCmekConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CmekConfigService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing CMEK related tasks
    /// </remarks>
    public sealed partial class CmekConfigServiceClientImpl : CmekConfigServiceClient
    {
        private readonly gaxgrpc::ApiCall<UpdateCmekConfigRequest, lro::Operation> _callUpdateCmekConfig;

        private readonly gaxgrpc::ApiCall<GetCmekConfigRequest, CmekConfig> _callGetCmekConfig;

        private readonly gaxgrpc::ApiCall<ListCmekConfigsRequest, ListCmekConfigsResponse> _callListCmekConfigs;

        private readonly gaxgrpc::ApiCall<DeleteCmekConfigRequest, lro::Operation> _callDeleteCmekConfig;

        /// <summary>
        /// Constructs a client wrapper for the CmekConfigService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CmekConfigServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CmekConfigServiceClientImpl(CmekConfigService.CmekConfigServiceClient grpcClient, CmekConfigServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CmekConfigServiceSettings effectiveSettings = settings ?? CmekConfigServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            UpdateCmekConfigOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateCmekConfigOperationsSettings, logger);
            DeleteCmekConfigOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteCmekConfigOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callUpdateCmekConfig = clientHelper.BuildApiCall<UpdateCmekConfigRequest, lro::Operation>("UpdateCmekConfig", grpcClient.UpdateCmekConfigAsync, grpcClient.UpdateCmekConfig, effectiveSettings.UpdateCmekConfigSettings).WithGoogleRequestParam("config.name", request => request.Config?.Name);
            Modify_ApiCall(ref _callUpdateCmekConfig);
            Modify_UpdateCmekConfigApiCall(ref _callUpdateCmekConfig);
            _callGetCmekConfig = clientHelper.BuildApiCall<GetCmekConfigRequest, CmekConfig>("GetCmekConfig", grpcClient.GetCmekConfigAsync, grpcClient.GetCmekConfig, effectiveSettings.GetCmekConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCmekConfig);
            Modify_GetCmekConfigApiCall(ref _callGetCmekConfig);
            _callListCmekConfigs = clientHelper.BuildApiCall<ListCmekConfigsRequest, ListCmekConfigsResponse>("ListCmekConfigs", grpcClient.ListCmekConfigsAsync, grpcClient.ListCmekConfigs, effectiveSettings.ListCmekConfigsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCmekConfigs);
            Modify_ListCmekConfigsApiCall(ref _callListCmekConfigs);
            _callDeleteCmekConfig = clientHelper.BuildApiCall<DeleteCmekConfigRequest, lro::Operation>("DeleteCmekConfig", grpcClient.DeleteCmekConfigAsync, grpcClient.DeleteCmekConfig, effectiveSettings.DeleteCmekConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteCmekConfig);
            Modify_DeleteCmekConfigApiCall(ref _callDeleteCmekConfig);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_UpdateCmekConfigApiCall(ref gaxgrpc::ApiCall<UpdateCmekConfigRequest, lro::Operation> call);

        partial void Modify_GetCmekConfigApiCall(ref gaxgrpc::ApiCall<GetCmekConfigRequest, CmekConfig> call);

        partial void Modify_ListCmekConfigsApiCall(ref gaxgrpc::ApiCall<ListCmekConfigsRequest, ListCmekConfigsResponse> call);

        partial void Modify_DeleteCmekConfigApiCall(ref gaxgrpc::ApiCall<DeleteCmekConfigRequest, lro::Operation> call);

        partial void OnConstruction(CmekConfigService.CmekConfigServiceClient grpcClient, CmekConfigServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CmekConfigService client</summary>
        public override CmekConfigService.CmekConfigServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_UpdateCmekConfigRequest(ref UpdateCmekConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetCmekConfigRequest(ref GetCmekConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCmekConfigsRequest(ref ListCmekConfigsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteCmekConfigRequest(ref DeleteCmekConfigRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>UpdateCmekConfig</c>.</summary>
        public override lro::OperationsClient UpdateCmekConfigOperationsClient { get; }

        /// <summary>
        /// Provisions a CMEK key for use in a location of a customer's project.
        /// This method will also conduct location validation on the provided
        /// cmekConfig to make sure the key is valid and can be used in the
        /// selected location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<CmekConfig, UpdateCmekConfigMetadata> UpdateCmekConfig(UpdateCmekConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCmekConfigRequest(ref request, ref callSettings);
            return new lro::Operation<CmekConfig, UpdateCmekConfigMetadata>(_callUpdateCmekConfig.Sync(request, callSettings), UpdateCmekConfigOperationsClient);
        }

        /// <summary>
        /// Provisions a CMEK key for use in a location of a customer's project.
        /// This method will also conduct location validation on the provided
        /// cmekConfig to make sure the key is valid and can be used in the
        /// selected location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<CmekConfig, UpdateCmekConfigMetadata>> UpdateCmekConfigAsync(UpdateCmekConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCmekConfigRequest(ref request, ref callSettings);
            return new lro::Operation<CmekConfig, UpdateCmekConfigMetadata>(await _callUpdateCmekConfig.Async(request, callSettings).ConfigureAwait(false), UpdateCmekConfigOperationsClient);
        }

        /// <summary>
        /// Gets the [CmekConfig][google.cloud.discoveryengine.v1.CmekConfig].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CmekConfig GetCmekConfig(GetCmekConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCmekConfigRequest(ref request, ref callSettings);
            return _callGetCmekConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the [CmekConfig][google.cloud.discoveryengine.v1.CmekConfig].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CmekConfig> GetCmekConfigAsync(GetCmekConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCmekConfigRequest(ref request, ref callSettings);
            return _callGetCmekConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all the [CmekConfig][google.cloud.discoveryengine.v1.CmekConfig]s
        /// with the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ListCmekConfigsResponse ListCmekConfigs(ListCmekConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCmekConfigsRequest(ref request, ref callSettings);
            return _callListCmekConfigs.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists all the [CmekConfig][google.cloud.discoveryengine.v1.CmekConfig]s
        /// with the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ListCmekConfigsResponse> ListCmekConfigsAsync(ListCmekConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCmekConfigsRequest(ref request, ref callSettings);
            return _callListCmekConfigs.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteCmekConfig</c>.</summary>
        public override lro::OperationsClient DeleteCmekConfigOperationsClient { get; }

        /// <summary>
        /// De-provisions a CmekConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteCmekConfigMetadata> DeleteCmekConfig(DeleteCmekConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCmekConfigRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteCmekConfigMetadata>(_callDeleteCmekConfig.Sync(request, callSettings), DeleteCmekConfigOperationsClient);
        }

        /// <summary>
        /// De-provisions a CmekConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteCmekConfigMetadata>> DeleteCmekConfigAsync(DeleteCmekConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCmekConfigRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteCmekConfigMetadata>(await _callDeleteCmekConfig.Async(request, callSettings).ConfigureAwait(false), DeleteCmekConfigOperationsClient);
        }
    }

    public static partial class CmekConfigService
    {
        public partial class CmekConfigServiceClient
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

    public static partial class CmekConfigService
    {
        public partial class CmekConfigServiceClient
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
