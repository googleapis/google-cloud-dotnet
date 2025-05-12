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
using gciv = Google.Cloud.Iam.V1;
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

namespace Google.Cloud.Dataplex.V1
{
    /// <summary>Settings for <see cref="CmekServiceClient"/> instances.</summary>
    public sealed partial class CmekServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CmekServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CmekServiceSettings"/>.</returns>
        public static CmekServiceSettings GetDefault() => new CmekServiceSettings();

        /// <summary>Constructs a new <see cref="CmekServiceSettings"/> object with default settings.</summary>
        public CmekServiceSettings()
        {
        }

        private CmekServiceSettings(CmekServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateEncryptionConfigSettings = existing.CreateEncryptionConfigSettings;
            CreateEncryptionConfigOperationsSettings = existing.CreateEncryptionConfigOperationsSettings.Clone();
            UpdateEncryptionConfigSettings = existing.UpdateEncryptionConfigSettings;
            UpdateEncryptionConfigOperationsSettings = existing.UpdateEncryptionConfigOperationsSettings.Clone();
            DeleteEncryptionConfigSettings = existing.DeleteEncryptionConfigSettings;
            DeleteEncryptionConfigOperationsSettings = existing.DeleteEncryptionConfigOperationsSettings.Clone();
            ListEncryptionConfigsSettings = existing.ListEncryptionConfigsSettings;
            GetEncryptionConfigSettings = existing.GetEncryptionConfigSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(CmekServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CmekServiceClient.CreateEncryptionConfig</c> and <c>CmekServiceClient.CreateEncryptionConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateEncryptionConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>CmekServiceClient.CreateEncryptionConfig</c> and
        /// <c>CmekServiceClient.CreateEncryptionConfigAsync</c>.
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
        public lro::OperationsSettings CreateEncryptionConfigOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CmekServiceClient.UpdateEncryptionConfig</c> and <c>CmekServiceClient.UpdateEncryptionConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateEncryptionConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>CmekServiceClient.UpdateEncryptionConfig</c> and
        /// <c>CmekServiceClient.UpdateEncryptionConfigAsync</c>.
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
        public lro::OperationsSettings UpdateEncryptionConfigOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CmekServiceClient.DeleteEncryptionConfig</c> and <c>CmekServiceClient.DeleteEncryptionConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteEncryptionConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>CmekServiceClient.DeleteEncryptionConfig</c> and
        /// <c>CmekServiceClient.DeleteEncryptionConfigAsync</c>.
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
        public lro::OperationsSettings DeleteEncryptionConfigOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CmekServiceClient.ListEncryptionConfigs</c> and <c>CmekServiceClient.ListEncryptionConfigsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListEncryptionConfigsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CmekServiceClient.GetEncryptionConfig</c> and <c>CmekServiceClient.GetEncryptionConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetEncryptionConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CmekServiceSettings"/> object.</returns>
        public CmekServiceSettings Clone() => new CmekServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CmekServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class CmekServiceClientBuilder : gaxgrpc::ClientBuilderBase<CmekServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CmekServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CmekServiceClientBuilder() : base(CmekServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CmekServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CmekServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CmekServiceClient Build()
        {
            CmekServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CmekServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CmekServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CmekServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CmekServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CmekServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CmekServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CmekServiceClient.ChannelPool;
    }

    /// <summary>CmekService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Dataplex Cmek Service
    /// </remarks>
    public abstract partial class CmekServiceClient
    {
        /// <summary>
        /// The default endpoint for the CmekService service, which is a host of "dataplex.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dataplex.googleapis.com:443";

        /// <summary>The default CmekService scopes.</summary>
        /// <remarks>
        /// The default CmekService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CmekService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CmekServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CmekServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CmekServiceClient"/>.</returns>
        public static stt::Task<CmekServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CmekServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CmekServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CmekServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CmekServiceClient"/>.</returns>
        public static CmekServiceClient Create() => new CmekServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CmekServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CmekServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CmekServiceClient"/>.</returns>
        internal static CmekServiceClient Create(grpccore::CallInvoker callInvoker, CmekServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CmekService.CmekServiceClient grpcClient = new CmekService.CmekServiceClient(callInvoker);
            return new CmekServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CmekService client</summary>
        public virtual CmekService.CmekServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Create an EncryptionConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<EncryptionConfig, OperationMetadata> CreateEncryptionConfig(CreateEncryptionConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create an EncryptionConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EncryptionConfig, OperationMetadata>> CreateEncryptionConfigAsync(CreateEncryptionConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create an EncryptionConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EncryptionConfig, OperationMetadata>> CreateEncryptionConfigAsync(CreateEncryptionConfigRequest request, st::CancellationToken cancellationToken) =>
            CreateEncryptionConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateEncryptionConfig</c>.</summary>
        public virtual lro::OperationsClient CreateEncryptionConfigOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateEncryptionConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<EncryptionConfig, OperationMetadata> PollOnceCreateEncryptionConfig(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<EncryptionConfig, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateEncryptionConfigOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateEncryptionConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<EncryptionConfig, OperationMetadata>> PollOnceCreateEncryptionConfigAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<EncryptionConfig, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateEncryptionConfigOperationsClient, callSettings);

        /// <summary>
        /// Create an EncryptionConfig.
        /// </summary>
        /// <param name="parent">
        /// Required. The location at which the EncryptionConfig is to be created.
        /// </param>
        /// <param name="encryptionConfig">
        /// Required. The EncryptionConfig to create.
        /// </param>
        /// <param name="encryptionConfigId">
        /// Required. The ID of the
        /// [EncryptionConfig][google.cloud.dataplex.v1.EncryptionConfig] to create.
        /// Currently, only a value of "default" is supported.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<EncryptionConfig, OperationMetadata> CreateEncryptionConfig(string parent, EncryptionConfig encryptionConfig, string encryptionConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEncryptionConfig(new CreateEncryptionConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EncryptionConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(encryptionConfigId, nameof(encryptionConfigId)),
                EncryptionConfig = gax::GaxPreconditions.CheckNotNull(encryptionConfig, nameof(encryptionConfig)),
            }, callSettings);

        /// <summary>
        /// Create an EncryptionConfig.
        /// </summary>
        /// <param name="parent">
        /// Required. The location at which the EncryptionConfig is to be created.
        /// </param>
        /// <param name="encryptionConfig">
        /// Required. The EncryptionConfig to create.
        /// </param>
        /// <param name="encryptionConfigId">
        /// Required. The ID of the
        /// [EncryptionConfig][google.cloud.dataplex.v1.EncryptionConfig] to create.
        /// Currently, only a value of "default" is supported.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EncryptionConfig, OperationMetadata>> CreateEncryptionConfigAsync(string parent, EncryptionConfig encryptionConfig, string encryptionConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEncryptionConfigAsync(new CreateEncryptionConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EncryptionConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(encryptionConfigId, nameof(encryptionConfigId)),
                EncryptionConfig = gax::GaxPreconditions.CheckNotNull(encryptionConfig, nameof(encryptionConfig)),
            }, callSettings);

        /// <summary>
        /// Create an EncryptionConfig.
        /// </summary>
        /// <param name="parent">
        /// Required. The location at which the EncryptionConfig is to be created.
        /// </param>
        /// <param name="encryptionConfig">
        /// Required. The EncryptionConfig to create.
        /// </param>
        /// <param name="encryptionConfigId">
        /// Required. The ID of the
        /// [EncryptionConfig][google.cloud.dataplex.v1.EncryptionConfig] to create.
        /// Currently, only a value of "default" is supported.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EncryptionConfig, OperationMetadata>> CreateEncryptionConfigAsync(string parent, EncryptionConfig encryptionConfig, string encryptionConfigId, st::CancellationToken cancellationToken) =>
            CreateEncryptionConfigAsync(parent, encryptionConfig, encryptionConfigId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create an EncryptionConfig.
        /// </summary>
        /// <param name="parent">
        /// Required. The location at which the EncryptionConfig is to be created.
        /// </param>
        /// <param name="encryptionConfig">
        /// Required. The EncryptionConfig to create.
        /// </param>
        /// <param name="encryptionConfigId">
        /// Required. The ID of the
        /// [EncryptionConfig][google.cloud.dataplex.v1.EncryptionConfig] to create.
        /// Currently, only a value of "default" is supported.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<EncryptionConfig, OperationMetadata> CreateEncryptionConfig(OrganizationLocationName parent, EncryptionConfig encryptionConfig, string encryptionConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEncryptionConfig(new CreateEncryptionConfigRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EncryptionConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(encryptionConfigId, nameof(encryptionConfigId)),
                EncryptionConfig = gax::GaxPreconditions.CheckNotNull(encryptionConfig, nameof(encryptionConfig)),
            }, callSettings);

        /// <summary>
        /// Create an EncryptionConfig.
        /// </summary>
        /// <param name="parent">
        /// Required. The location at which the EncryptionConfig is to be created.
        /// </param>
        /// <param name="encryptionConfig">
        /// Required. The EncryptionConfig to create.
        /// </param>
        /// <param name="encryptionConfigId">
        /// Required. The ID of the
        /// [EncryptionConfig][google.cloud.dataplex.v1.EncryptionConfig] to create.
        /// Currently, only a value of "default" is supported.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EncryptionConfig, OperationMetadata>> CreateEncryptionConfigAsync(OrganizationLocationName parent, EncryptionConfig encryptionConfig, string encryptionConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEncryptionConfigAsync(new CreateEncryptionConfigRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EncryptionConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(encryptionConfigId, nameof(encryptionConfigId)),
                EncryptionConfig = gax::GaxPreconditions.CheckNotNull(encryptionConfig, nameof(encryptionConfig)),
            }, callSettings);

        /// <summary>
        /// Create an EncryptionConfig.
        /// </summary>
        /// <param name="parent">
        /// Required. The location at which the EncryptionConfig is to be created.
        /// </param>
        /// <param name="encryptionConfig">
        /// Required. The EncryptionConfig to create.
        /// </param>
        /// <param name="encryptionConfigId">
        /// Required. The ID of the
        /// [EncryptionConfig][google.cloud.dataplex.v1.EncryptionConfig] to create.
        /// Currently, only a value of "default" is supported.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EncryptionConfig, OperationMetadata>> CreateEncryptionConfigAsync(OrganizationLocationName parent, EncryptionConfig encryptionConfig, string encryptionConfigId, st::CancellationToken cancellationToken) =>
            CreateEncryptionConfigAsync(parent, encryptionConfig, encryptionConfigId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update an EncryptionConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<EncryptionConfig, OperationMetadata> UpdateEncryptionConfig(UpdateEncryptionConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update an EncryptionConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EncryptionConfig, OperationMetadata>> UpdateEncryptionConfigAsync(UpdateEncryptionConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update an EncryptionConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EncryptionConfig, OperationMetadata>> UpdateEncryptionConfigAsync(UpdateEncryptionConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateEncryptionConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateEncryptionConfig</c>.</summary>
        public virtual lro::OperationsClient UpdateEncryptionConfigOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateEncryptionConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<EncryptionConfig, OperationMetadata> PollOnceUpdateEncryptionConfig(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<EncryptionConfig, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateEncryptionConfigOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateEncryptionConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<EncryptionConfig, OperationMetadata>> PollOnceUpdateEncryptionConfigAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<EncryptionConfig, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateEncryptionConfigOperationsClient, callSettings);

        /// <summary>
        /// Update an EncryptionConfig.
        /// </summary>
        /// <param name="encryptionConfig">
        /// Required. The EncryptionConfig to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Mask of fields to update.
        /// The service treats an omitted field mask as an implied field mask
        /// equivalent to all fields that are populated (have a non-empty value).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<EncryptionConfig, OperationMetadata> UpdateEncryptionConfig(EncryptionConfig encryptionConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEncryptionConfig(new UpdateEncryptionConfigRequest
            {
                EncryptionConfig = gax::GaxPreconditions.CheckNotNull(encryptionConfig, nameof(encryptionConfig)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update an EncryptionConfig.
        /// </summary>
        /// <param name="encryptionConfig">
        /// Required. The EncryptionConfig to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Mask of fields to update.
        /// The service treats an omitted field mask as an implied field mask
        /// equivalent to all fields that are populated (have a non-empty value).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EncryptionConfig, OperationMetadata>> UpdateEncryptionConfigAsync(EncryptionConfig encryptionConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEncryptionConfigAsync(new UpdateEncryptionConfigRequest
            {
                EncryptionConfig = gax::GaxPreconditions.CheckNotNull(encryptionConfig, nameof(encryptionConfig)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update an EncryptionConfig.
        /// </summary>
        /// <param name="encryptionConfig">
        /// Required. The EncryptionConfig to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Mask of fields to update.
        /// The service treats an omitted field mask as an implied field mask
        /// equivalent to all fields that are populated (have a non-empty value).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EncryptionConfig, OperationMetadata>> UpdateEncryptionConfigAsync(EncryptionConfig encryptionConfig, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateEncryptionConfigAsync(encryptionConfig, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete an EncryptionConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteEncryptionConfig(DeleteEncryptionConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete an EncryptionConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEncryptionConfigAsync(DeleteEncryptionConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete an EncryptionConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEncryptionConfigAsync(DeleteEncryptionConfigRequest request, st::CancellationToken cancellationToken) =>
            DeleteEncryptionConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteEncryptionConfig</c>.</summary>
        public virtual lro::OperationsClient DeleteEncryptionConfigOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteEncryptionConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteEncryptionConfig(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteEncryptionConfigOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteEncryptionConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteEncryptionConfigAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteEncryptionConfigOperationsClient, callSettings);

        /// <summary>
        /// Delete an EncryptionConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the EncryptionConfig to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteEncryptionConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEncryptionConfig(new DeleteEncryptionConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete an EncryptionConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the EncryptionConfig to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEncryptionConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEncryptionConfigAsync(new DeleteEncryptionConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete an EncryptionConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the EncryptionConfig to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEncryptionConfigAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteEncryptionConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete an EncryptionConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the EncryptionConfig to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteEncryptionConfig(EncryptionConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEncryptionConfig(new DeleteEncryptionConfigRequest
            {
                EncryptionConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete an EncryptionConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the EncryptionConfig to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEncryptionConfigAsync(EncryptionConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEncryptionConfigAsync(new DeleteEncryptionConfigRequest
            {
                EncryptionConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete an EncryptionConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the EncryptionConfig to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEncryptionConfigAsync(EncryptionConfigName name, st::CancellationToken cancellationToken) =>
            DeleteEncryptionConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List EncryptionConfigs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EncryptionConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEncryptionConfigsResponse, EncryptionConfig> ListEncryptionConfigs(ListEncryptionConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List EncryptionConfigs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="EncryptionConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEncryptionConfigsResponse, EncryptionConfig> ListEncryptionConfigsAsync(ListEncryptionConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List EncryptionConfigs.
        /// </summary>
        /// <param name="parent">
        /// Required. The location for which the EncryptionConfig is to be listed.
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
        /// <returns>A pageable sequence of <see cref="EncryptionConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEncryptionConfigsResponse, EncryptionConfig> ListEncryptionConfigs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEncryptionConfigsRequest request = new ListEncryptionConfigsRequest
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
            return ListEncryptionConfigs(request, callSettings);
        }

        /// <summary>
        /// List EncryptionConfigs.
        /// </summary>
        /// <param name="parent">
        /// Required. The location for which the EncryptionConfig is to be listed.
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
        /// <returns>A pageable asynchronous sequence of <see cref="EncryptionConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEncryptionConfigsResponse, EncryptionConfig> ListEncryptionConfigsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEncryptionConfigsRequest request = new ListEncryptionConfigsRequest
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
            return ListEncryptionConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// List EncryptionConfigs.
        /// </summary>
        /// <param name="parent">
        /// Required. The location for which the EncryptionConfig is to be listed.
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
        /// <returns>A pageable sequence of <see cref="EncryptionConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEncryptionConfigsResponse, EncryptionConfig> ListEncryptionConfigs(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEncryptionConfigsRequest request = new ListEncryptionConfigsRequest
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
            return ListEncryptionConfigs(request, callSettings);
        }

        /// <summary>
        /// List EncryptionConfigs.
        /// </summary>
        /// <param name="parent">
        /// Required. The location for which the EncryptionConfig is to be listed.
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
        /// <returns>A pageable asynchronous sequence of <see cref="EncryptionConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEncryptionConfigsResponse, EncryptionConfig> ListEncryptionConfigsAsync(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEncryptionConfigsRequest request = new ListEncryptionConfigsRequest
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
            return ListEncryptionConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Get an EncryptionConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EncryptionConfig GetEncryptionConfig(GetEncryptionConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get an EncryptionConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EncryptionConfig> GetEncryptionConfigAsync(GetEncryptionConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get an EncryptionConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EncryptionConfig> GetEncryptionConfigAsync(GetEncryptionConfigRequest request, st::CancellationToken cancellationToken) =>
            GetEncryptionConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get an EncryptionConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the EncryptionConfig to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EncryptionConfig GetEncryptionConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEncryptionConfig(new GetEncryptionConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get an EncryptionConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the EncryptionConfig to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EncryptionConfig> GetEncryptionConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEncryptionConfigAsync(new GetEncryptionConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get an EncryptionConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the EncryptionConfig to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EncryptionConfig> GetEncryptionConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetEncryptionConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get an EncryptionConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the EncryptionConfig to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EncryptionConfig GetEncryptionConfig(EncryptionConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEncryptionConfig(new GetEncryptionConfigRequest
            {
                EncryptionConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get an EncryptionConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the EncryptionConfig to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EncryptionConfig> GetEncryptionConfigAsync(EncryptionConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEncryptionConfigAsync(new GetEncryptionConfigRequest
            {
                EncryptionConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get an EncryptionConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the EncryptionConfig to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EncryptionConfig> GetEncryptionConfigAsync(EncryptionConfigName name, st::CancellationToken cancellationToken) =>
            GetEncryptionConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CmekService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Dataplex Cmek Service
    /// </remarks>
    public sealed partial class CmekServiceClientImpl : CmekServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateEncryptionConfigRequest, lro::Operation> _callCreateEncryptionConfig;

        private readonly gaxgrpc::ApiCall<UpdateEncryptionConfigRequest, lro::Operation> _callUpdateEncryptionConfig;

        private readonly gaxgrpc::ApiCall<DeleteEncryptionConfigRequest, lro::Operation> _callDeleteEncryptionConfig;

        private readonly gaxgrpc::ApiCall<ListEncryptionConfigsRequest, ListEncryptionConfigsResponse> _callListEncryptionConfigs;

        private readonly gaxgrpc::ApiCall<GetEncryptionConfigRequest, EncryptionConfig> _callGetEncryptionConfig;

        /// <summary>
        /// Constructs a client wrapper for the CmekService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CmekServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CmekServiceClientImpl(CmekService.CmekServiceClient grpcClient, CmekServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CmekServiceSettings effectiveSettings = settings ?? CmekServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateEncryptionConfigOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateEncryptionConfigOperationsSettings, logger);
            UpdateEncryptionConfigOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateEncryptionConfigOperationsSettings, logger);
            DeleteEncryptionConfigOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteEncryptionConfigOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callCreateEncryptionConfig = clientHelper.BuildApiCall<CreateEncryptionConfigRequest, lro::Operation>("CreateEncryptionConfig", grpcClient.CreateEncryptionConfigAsync, grpcClient.CreateEncryptionConfig, effectiveSettings.CreateEncryptionConfigSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateEncryptionConfig);
            Modify_CreateEncryptionConfigApiCall(ref _callCreateEncryptionConfig);
            _callUpdateEncryptionConfig = clientHelper.BuildApiCall<UpdateEncryptionConfigRequest, lro::Operation>("UpdateEncryptionConfig", grpcClient.UpdateEncryptionConfigAsync, grpcClient.UpdateEncryptionConfig, effectiveSettings.UpdateEncryptionConfigSettings).WithGoogleRequestParam("encryption_config.name", request => request.EncryptionConfig?.Name);
            Modify_ApiCall(ref _callUpdateEncryptionConfig);
            Modify_UpdateEncryptionConfigApiCall(ref _callUpdateEncryptionConfig);
            _callDeleteEncryptionConfig = clientHelper.BuildApiCall<DeleteEncryptionConfigRequest, lro::Operation>("DeleteEncryptionConfig", grpcClient.DeleteEncryptionConfigAsync, grpcClient.DeleteEncryptionConfig, effectiveSettings.DeleteEncryptionConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteEncryptionConfig);
            Modify_DeleteEncryptionConfigApiCall(ref _callDeleteEncryptionConfig);
            _callListEncryptionConfigs = clientHelper.BuildApiCall<ListEncryptionConfigsRequest, ListEncryptionConfigsResponse>("ListEncryptionConfigs", grpcClient.ListEncryptionConfigsAsync, grpcClient.ListEncryptionConfigs, effectiveSettings.ListEncryptionConfigsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEncryptionConfigs);
            Modify_ListEncryptionConfigsApiCall(ref _callListEncryptionConfigs);
            _callGetEncryptionConfig = clientHelper.BuildApiCall<GetEncryptionConfigRequest, EncryptionConfig>("GetEncryptionConfig", grpcClient.GetEncryptionConfigAsync, grpcClient.GetEncryptionConfig, effectiveSettings.GetEncryptionConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEncryptionConfig);
            Modify_GetEncryptionConfigApiCall(ref _callGetEncryptionConfig);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateEncryptionConfigApiCall(ref gaxgrpc::ApiCall<CreateEncryptionConfigRequest, lro::Operation> call);

        partial void Modify_UpdateEncryptionConfigApiCall(ref gaxgrpc::ApiCall<UpdateEncryptionConfigRequest, lro::Operation> call);

        partial void Modify_DeleteEncryptionConfigApiCall(ref gaxgrpc::ApiCall<DeleteEncryptionConfigRequest, lro::Operation> call);

        partial void Modify_ListEncryptionConfigsApiCall(ref gaxgrpc::ApiCall<ListEncryptionConfigsRequest, ListEncryptionConfigsResponse> call);

        partial void Modify_GetEncryptionConfigApiCall(ref gaxgrpc::ApiCall<GetEncryptionConfigRequest, EncryptionConfig> call);

        partial void OnConstruction(CmekService.CmekServiceClient grpcClient, CmekServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CmekService client</summary>
        public override CmekService.CmekServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_CreateEncryptionConfigRequest(ref CreateEncryptionConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateEncryptionConfigRequest(ref UpdateEncryptionConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteEncryptionConfigRequest(ref DeleteEncryptionConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListEncryptionConfigsRequest(ref ListEncryptionConfigsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetEncryptionConfigRequest(ref GetEncryptionConfigRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateEncryptionConfig</c>.</summary>
        public override lro::OperationsClient CreateEncryptionConfigOperationsClient { get; }

        /// <summary>
        /// Create an EncryptionConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<EncryptionConfig, OperationMetadata> CreateEncryptionConfig(CreateEncryptionConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEncryptionConfigRequest(ref request, ref callSettings);
            return new lro::Operation<EncryptionConfig, OperationMetadata>(_callCreateEncryptionConfig.Sync(request, callSettings), CreateEncryptionConfigOperationsClient);
        }

        /// <summary>
        /// Create an EncryptionConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<EncryptionConfig, OperationMetadata>> CreateEncryptionConfigAsync(CreateEncryptionConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEncryptionConfigRequest(ref request, ref callSettings);
            return new lro::Operation<EncryptionConfig, OperationMetadata>(await _callCreateEncryptionConfig.Async(request, callSettings).ConfigureAwait(false), CreateEncryptionConfigOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateEncryptionConfig</c>.</summary>
        public override lro::OperationsClient UpdateEncryptionConfigOperationsClient { get; }

        /// <summary>
        /// Update an EncryptionConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<EncryptionConfig, OperationMetadata> UpdateEncryptionConfig(UpdateEncryptionConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEncryptionConfigRequest(ref request, ref callSettings);
            return new lro::Operation<EncryptionConfig, OperationMetadata>(_callUpdateEncryptionConfig.Sync(request, callSettings), UpdateEncryptionConfigOperationsClient);
        }

        /// <summary>
        /// Update an EncryptionConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<EncryptionConfig, OperationMetadata>> UpdateEncryptionConfigAsync(UpdateEncryptionConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEncryptionConfigRequest(ref request, ref callSettings);
            return new lro::Operation<EncryptionConfig, OperationMetadata>(await _callUpdateEncryptionConfig.Async(request, callSettings).ConfigureAwait(false), UpdateEncryptionConfigOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteEncryptionConfig</c>.</summary>
        public override lro::OperationsClient DeleteEncryptionConfigOperationsClient { get; }

        /// <summary>
        /// Delete an EncryptionConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteEncryptionConfig(DeleteEncryptionConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEncryptionConfigRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteEncryptionConfig.Sync(request, callSettings), DeleteEncryptionConfigOperationsClient);
        }

        /// <summary>
        /// Delete an EncryptionConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEncryptionConfigAsync(DeleteEncryptionConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEncryptionConfigRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteEncryptionConfig.Async(request, callSettings).ConfigureAwait(false), DeleteEncryptionConfigOperationsClient);
        }

        /// <summary>
        /// List EncryptionConfigs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EncryptionConfig"/> resources.</returns>
        public override gax::PagedEnumerable<ListEncryptionConfigsResponse, EncryptionConfig> ListEncryptionConfigs(ListEncryptionConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEncryptionConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEncryptionConfigsRequest, ListEncryptionConfigsResponse, EncryptionConfig>(_callListEncryptionConfigs, request, callSettings);
        }

        /// <summary>
        /// List EncryptionConfigs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="EncryptionConfig"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListEncryptionConfigsResponse, EncryptionConfig> ListEncryptionConfigsAsync(ListEncryptionConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEncryptionConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEncryptionConfigsRequest, ListEncryptionConfigsResponse, EncryptionConfig>(_callListEncryptionConfigs, request, callSettings);
        }

        /// <summary>
        /// Get an EncryptionConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EncryptionConfig GetEncryptionConfig(GetEncryptionConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEncryptionConfigRequest(ref request, ref callSettings);
            return _callGetEncryptionConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Get an EncryptionConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EncryptionConfig> GetEncryptionConfigAsync(GetEncryptionConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEncryptionConfigRequest(ref request, ref callSettings);
            return _callGetEncryptionConfig.Async(request, callSettings);
        }
    }

    public partial class ListEncryptionConfigsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEncryptionConfigsResponse : gaxgrpc::IPageResponse<EncryptionConfig>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<EncryptionConfig> GetEnumerator() => EncryptionConfigs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class CmekService
    {
        public partial class CmekServiceClient
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

    public static partial class CmekService
    {
        public partial class CmekServiceClient
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
