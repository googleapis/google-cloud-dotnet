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
using gcl = Google.Cloud.Location;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Kms.V1
{
    /// <summary>Settings for <see cref="AutokeyAdminClient"/> instances.</summary>
    public sealed partial class AutokeyAdminSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AutokeyAdminSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AutokeyAdminSettings"/>.</returns>
        public static AutokeyAdminSettings GetDefault() => new AutokeyAdminSettings();

        /// <summary>Constructs a new <see cref="AutokeyAdminSettings"/> object with default settings.</summary>
        public AutokeyAdminSettings()
        {
        }

        private AutokeyAdminSettings(AutokeyAdminSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            UpdateAutokeyConfigSettings = existing.UpdateAutokeyConfigSettings;
            GetAutokeyConfigSettings = existing.GetAutokeyConfigSettings;
            ShowEffectiveAutokeyConfigSettings = existing.ShowEffectiveAutokeyConfigSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(AutokeyAdminSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AutokeyAdminClient.UpdateAutokeyConfig</c> and <c>AutokeyAdminClient.UpdateAutokeyConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateAutokeyConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AutokeyAdminClient.GetAutokeyConfig</c> and <c>AutokeyAdminClient.GetAutokeyConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAutokeyConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AutokeyAdminClient.ShowEffectiveAutokeyConfig</c> and
        /// <c>AutokeyAdminClient.ShowEffectiveAutokeyConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ShowEffectiveAutokeyConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AutokeyAdminSettings"/> object.</returns>
        public AutokeyAdminSettings Clone() => new AutokeyAdminSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AutokeyAdminClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class AutokeyAdminClientBuilder : gaxgrpc::ClientBuilderBase<AutokeyAdminClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AutokeyAdminSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AutokeyAdminClientBuilder() : base(AutokeyAdminClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AutokeyAdminClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AutokeyAdminClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AutokeyAdminClient Build()
        {
            AutokeyAdminClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AutokeyAdminClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AutokeyAdminClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AutokeyAdminClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AutokeyAdminClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AutokeyAdminClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AutokeyAdminClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AutokeyAdminClient.ChannelPool;
    }

    /// <summary>AutokeyAdmin client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides interfaces for managing [Cloud KMS
    /// Autokey](https://cloud.google.com/kms/help/autokey) folder-level
    /// configurations. A configuration is inherited by all descendent projects. A
    /// configuration at one folder overrides any other configurations in its
    /// ancestry. Setting a configuration on a folder is a prerequisite for Cloud KMS
    /// Autokey, so that users working in a descendant project can request
    /// provisioned [CryptoKeys][google.cloud.kms.v1.CryptoKey], ready for Customer
    /// Managed Encryption Key (CMEK) use, on-demand.
    /// </remarks>
    public abstract partial class AutokeyAdminClient
    {
        /// <summary>
        /// The default endpoint for the AutokeyAdmin service, which is a host of "cloudkms.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloudkms.googleapis.com:443";

        /// <summary>The default AutokeyAdmin scopes.</summary>
        /// <remarks>
        /// The default AutokeyAdmin scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloudkms</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloudkms",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AutokeyAdmin.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AutokeyAdminClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AutokeyAdminClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AutokeyAdminClient"/>.</returns>
        public static stt::Task<AutokeyAdminClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AutokeyAdminClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AutokeyAdminClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AutokeyAdminClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AutokeyAdminClient"/>.</returns>
        public static AutokeyAdminClient Create() => new AutokeyAdminClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AutokeyAdminClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AutokeyAdminSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AutokeyAdminClient"/>.</returns>
        internal static AutokeyAdminClient Create(grpccore::CallInvoker callInvoker, AutokeyAdminSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AutokeyAdmin.AutokeyAdminClient grpcClient = new AutokeyAdmin.AutokeyAdminClient(callInvoker);
            return new AutokeyAdminClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AutokeyAdmin client</summary>
        public virtual AutokeyAdmin.AutokeyAdminClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the [AutokeyConfig][google.cloud.kms.v1.AutokeyConfig] for a
        /// folder. The caller must have both `cloudkms.autokeyConfigs.update`
        /// permission on the parent folder and `cloudkms.cryptoKeys.setIamPolicy`
        /// permission on the provided key project. A
        /// [KeyHandle][google.cloud.kms.v1.KeyHandle] creation in the folder's
        /// descendant projects will use this configuration to determine where to
        /// create the resulting [CryptoKey][google.cloud.kms.v1.CryptoKey].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AutokeyConfig UpdateAutokeyConfig(UpdateAutokeyConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the [AutokeyConfig][google.cloud.kms.v1.AutokeyConfig] for a
        /// folder. The caller must have both `cloudkms.autokeyConfigs.update`
        /// permission on the parent folder and `cloudkms.cryptoKeys.setIamPolicy`
        /// permission on the provided key project. A
        /// [KeyHandle][google.cloud.kms.v1.KeyHandle] creation in the folder's
        /// descendant projects will use this configuration to determine where to
        /// create the resulting [CryptoKey][google.cloud.kms.v1.CryptoKey].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutokeyConfig> UpdateAutokeyConfigAsync(UpdateAutokeyConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the [AutokeyConfig][google.cloud.kms.v1.AutokeyConfig] for a
        /// folder. The caller must have both `cloudkms.autokeyConfigs.update`
        /// permission on the parent folder and `cloudkms.cryptoKeys.setIamPolicy`
        /// permission on the provided key project. A
        /// [KeyHandle][google.cloud.kms.v1.KeyHandle] creation in the folder's
        /// descendant projects will use this configuration to determine where to
        /// create the resulting [CryptoKey][google.cloud.kms.v1.CryptoKey].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutokeyConfig> UpdateAutokeyConfigAsync(UpdateAutokeyConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateAutokeyConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the [AutokeyConfig][google.cloud.kms.v1.AutokeyConfig] for a
        /// folder. The caller must have both `cloudkms.autokeyConfigs.update`
        /// permission on the parent folder and `cloudkms.cryptoKeys.setIamPolicy`
        /// permission on the provided key project. A
        /// [KeyHandle][google.cloud.kms.v1.KeyHandle] creation in the folder's
        /// descendant projects will use this configuration to determine where to
        /// create the resulting [CryptoKey][google.cloud.kms.v1.CryptoKey].
        /// </summary>
        /// <param name="autokeyConfig">
        /// Required. [AutokeyConfig][google.cloud.kms.v1.AutokeyConfig] with values to
        /// update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Masks which fields of the
        /// [AutokeyConfig][google.cloud.kms.v1.AutokeyConfig] to update, e.g.
        /// `keyProject`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AutokeyConfig UpdateAutokeyConfig(AutokeyConfig autokeyConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAutokeyConfig(new UpdateAutokeyConfigRequest
            {
                AutokeyConfig = gax::GaxPreconditions.CheckNotNull(autokeyConfig, nameof(autokeyConfig)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the [AutokeyConfig][google.cloud.kms.v1.AutokeyConfig] for a
        /// folder. The caller must have both `cloudkms.autokeyConfigs.update`
        /// permission on the parent folder and `cloudkms.cryptoKeys.setIamPolicy`
        /// permission on the provided key project. A
        /// [KeyHandle][google.cloud.kms.v1.KeyHandle] creation in the folder's
        /// descendant projects will use this configuration to determine where to
        /// create the resulting [CryptoKey][google.cloud.kms.v1.CryptoKey].
        /// </summary>
        /// <param name="autokeyConfig">
        /// Required. [AutokeyConfig][google.cloud.kms.v1.AutokeyConfig] with values to
        /// update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Masks which fields of the
        /// [AutokeyConfig][google.cloud.kms.v1.AutokeyConfig] to update, e.g.
        /// `keyProject`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutokeyConfig> UpdateAutokeyConfigAsync(AutokeyConfig autokeyConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAutokeyConfigAsync(new UpdateAutokeyConfigRequest
            {
                AutokeyConfig = gax::GaxPreconditions.CheckNotNull(autokeyConfig, nameof(autokeyConfig)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the [AutokeyConfig][google.cloud.kms.v1.AutokeyConfig] for a
        /// folder. The caller must have both `cloudkms.autokeyConfigs.update`
        /// permission on the parent folder and `cloudkms.cryptoKeys.setIamPolicy`
        /// permission on the provided key project. A
        /// [KeyHandle][google.cloud.kms.v1.KeyHandle] creation in the folder's
        /// descendant projects will use this configuration to determine where to
        /// create the resulting [CryptoKey][google.cloud.kms.v1.CryptoKey].
        /// </summary>
        /// <param name="autokeyConfig">
        /// Required. [AutokeyConfig][google.cloud.kms.v1.AutokeyConfig] with values to
        /// update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Masks which fields of the
        /// [AutokeyConfig][google.cloud.kms.v1.AutokeyConfig] to update, e.g.
        /// `keyProject`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutokeyConfig> UpdateAutokeyConfigAsync(AutokeyConfig autokeyConfig, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateAutokeyConfigAsync(autokeyConfig, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the [AutokeyConfig][google.cloud.kms.v1.AutokeyConfig] for a
        /// folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AutokeyConfig GetAutokeyConfig(GetAutokeyConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the [AutokeyConfig][google.cloud.kms.v1.AutokeyConfig] for a
        /// folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutokeyConfig> GetAutokeyConfigAsync(GetAutokeyConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the [AutokeyConfig][google.cloud.kms.v1.AutokeyConfig] for a
        /// folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutokeyConfig> GetAutokeyConfigAsync(GetAutokeyConfigRequest request, st::CancellationToken cancellationToken) =>
            GetAutokeyConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the [AutokeyConfig][google.cloud.kms.v1.AutokeyConfig] for a
        /// folder.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the [AutokeyConfig][google.cloud.kms.v1.AutokeyConfig]
        /// resource, e.g. `folders/{FOLDER_NUMBER}/autokeyConfig`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AutokeyConfig GetAutokeyConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAutokeyConfig(new GetAutokeyConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the [AutokeyConfig][google.cloud.kms.v1.AutokeyConfig] for a
        /// folder.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the [AutokeyConfig][google.cloud.kms.v1.AutokeyConfig]
        /// resource, e.g. `folders/{FOLDER_NUMBER}/autokeyConfig`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutokeyConfig> GetAutokeyConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAutokeyConfigAsync(new GetAutokeyConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the [AutokeyConfig][google.cloud.kms.v1.AutokeyConfig] for a
        /// folder.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the [AutokeyConfig][google.cloud.kms.v1.AutokeyConfig]
        /// resource, e.g. `folders/{FOLDER_NUMBER}/autokeyConfig`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutokeyConfig> GetAutokeyConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetAutokeyConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the [AutokeyConfig][google.cloud.kms.v1.AutokeyConfig] for a
        /// folder.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the [AutokeyConfig][google.cloud.kms.v1.AutokeyConfig]
        /// resource, e.g. `folders/{FOLDER_NUMBER}/autokeyConfig`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AutokeyConfig GetAutokeyConfig(AutokeyConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAutokeyConfig(new GetAutokeyConfigRequest
            {
                AutokeyConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the [AutokeyConfig][google.cloud.kms.v1.AutokeyConfig] for a
        /// folder.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the [AutokeyConfig][google.cloud.kms.v1.AutokeyConfig]
        /// resource, e.g. `folders/{FOLDER_NUMBER}/autokeyConfig`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutokeyConfig> GetAutokeyConfigAsync(AutokeyConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAutokeyConfigAsync(new GetAutokeyConfigRequest
            {
                AutokeyConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the [AutokeyConfig][google.cloud.kms.v1.AutokeyConfig] for a
        /// folder.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the [AutokeyConfig][google.cloud.kms.v1.AutokeyConfig]
        /// resource, e.g. `folders/{FOLDER_NUMBER}/autokeyConfig`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutokeyConfig> GetAutokeyConfigAsync(AutokeyConfigName name, st::CancellationToken cancellationToken) =>
            GetAutokeyConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the effective Cloud KMS Autokey configuration for a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ShowEffectiveAutokeyConfigResponse ShowEffectiveAutokeyConfig(ShowEffectiveAutokeyConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the effective Cloud KMS Autokey configuration for a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ShowEffectiveAutokeyConfigResponse> ShowEffectiveAutokeyConfigAsync(ShowEffectiveAutokeyConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the effective Cloud KMS Autokey configuration for a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ShowEffectiveAutokeyConfigResponse> ShowEffectiveAutokeyConfigAsync(ShowEffectiveAutokeyConfigRequest request, st::CancellationToken cancellationToken) =>
            ShowEffectiveAutokeyConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the effective Cloud KMS Autokey configuration for a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the resource project to the show effective Cloud KMS
        /// Autokey configuration for. This may be helpful for interrogating the effect
        /// of nested folder configurations on a given resource project.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ShowEffectiveAutokeyConfigResponse ShowEffectiveAutokeyConfig(string parent, gaxgrpc::CallSettings callSettings = null) =>
            ShowEffectiveAutokeyConfig(new ShowEffectiveAutokeyConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Returns the effective Cloud KMS Autokey configuration for a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the resource project to the show effective Cloud KMS
        /// Autokey configuration for. This may be helpful for interrogating the effect
        /// of nested folder configurations on a given resource project.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ShowEffectiveAutokeyConfigResponse> ShowEffectiveAutokeyConfigAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            ShowEffectiveAutokeyConfigAsync(new ShowEffectiveAutokeyConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Returns the effective Cloud KMS Autokey configuration for a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the resource project to the show effective Cloud KMS
        /// Autokey configuration for. This may be helpful for interrogating the effect
        /// of nested folder configurations on a given resource project.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ShowEffectiveAutokeyConfigResponse> ShowEffectiveAutokeyConfigAsync(string parent, st::CancellationToken cancellationToken) =>
            ShowEffectiveAutokeyConfigAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the effective Cloud KMS Autokey configuration for a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the resource project to the show effective Cloud KMS
        /// Autokey configuration for. This may be helpful for interrogating the effect
        /// of nested folder configurations on a given resource project.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ShowEffectiveAutokeyConfigResponse ShowEffectiveAutokeyConfig(gagr::ProjectName parent, gaxgrpc::CallSettings callSettings = null) =>
            ShowEffectiveAutokeyConfig(new ShowEffectiveAutokeyConfigRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Returns the effective Cloud KMS Autokey configuration for a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the resource project to the show effective Cloud KMS
        /// Autokey configuration for. This may be helpful for interrogating the effect
        /// of nested folder configurations on a given resource project.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ShowEffectiveAutokeyConfigResponse> ShowEffectiveAutokeyConfigAsync(gagr::ProjectName parent, gaxgrpc::CallSettings callSettings = null) =>
            ShowEffectiveAutokeyConfigAsync(new ShowEffectiveAutokeyConfigRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Returns the effective Cloud KMS Autokey configuration for a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the resource project to the show effective Cloud KMS
        /// Autokey configuration for. This may be helpful for interrogating the effect
        /// of nested folder configurations on a given resource project.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ShowEffectiveAutokeyConfigResponse> ShowEffectiveAutokeyConfigAsync(gagr::ProjectName parent, st::CancellationToken cancellationToken) =>
            ShowEffectiveAutokeyConfigAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AutokeyAdmin client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides interfaces for managing [Cloud KMS
    /// Autokey](https://cloud.google.com/kms/help/autokey) folder-level
    /// configurations. A configuration is inherited by all descendent projects. A
    /// configuration at one folder overrides any other configurations in its
    /// ancestry. Setting a configuration on a folder is a prerequisite for Cloud KMS
    /// Autokey, so that users working in a descendant project can request
    /// provisioned [CryptoKeys][google.cloud.kms.v1.CryptoKey], ready for Customer
    /// Managed Encryption Key (CMEK) use, on-demand.
    /// </remarks>
    public sealed partial class AutokeyAdminClientImpl : AutokeyAdminClient
    {
        private readonly gaxgrpc::ApiCall<UpdateAutokeyConfigRequest, AutokeyConfig> _callUpdateAutokeyConfig;

        private readonly gaxgrpc::ApiCall<GetAutokeyConfigRequest, AutokeyConfig> _callGetAutokeyConfig;

        private readonly gaxgrpc::ApiCall<ShowEffectiveAutokeyConfigRequest, ShowEffectiveAutokeyConfigResponse> _callShowEffectiveAutokeyConfig;

        /// <summary>
        /// Constructs a client wrapper for the AutokeyAdmin service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AutokeyAdminSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AutokeyAdminClientImpl(AutokeyAdmin.AutokeyAdminClient grpcClient, AutokeyAdminSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AutokeyAdminSettings effectiveSettings = settings ?? AutokeyAdminSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callUpdateAutokeyConfig = clientHelper.BuildApiCall<UpdateAutokeyConfigRequest, AutokeyConfig>("UpdateAutokeyConfig", grpcClient.UpdateAutokeyConfigAsync, grpcClient.UpdateAutokeyConfig, effectiveSettings.UpdateAutokeyConfigSettings).WithGoogleRequestParam("autokey_config.name", request => request.AutokeyConfig?.Name);
            Modify_ApiCall(ref _callUpdateAutokeyConfig);
            Modify_UpdateAutokeyConfigApiCall(ref _callUpdateAutokeyConfig);
            _callGetAutokeyConfig = clientHelper.BuildApiCall<GetAutokeyConfigRequest, AutokeyConfig>("GetAutokeyConfig", grpcClient.GetAutokeyConfigAsync, grpcClient.GetAutokeyConfig, effectiveSettings.GetAutokeyConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAutokeyConfig);
            Modify_GetAutokeyConfigApiCall(ref _callGetAutokeyConfig);
            _callShowEffectiveAutokeyConfig = clientHelper.BuildApiCall<ShowEffectiveAutokeyConfigRequest, ShowEffectiveAutokeyConfigResponse>("ShowEffectiveAutokeyConfig", grpcClient.ShowEffectiveAutokeyConfigAsync, grpcClient.ShowEffectiveAutokeyConfig, effectiveSettings.ShowEffectiveAutokeyConfigSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callShowEffectiveAutokeyConfig);
            Modify_ShowEffectiveAutokeyConfigApiCall(ref _callShowEffectiveAutokeyConfig);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_UpdateAutokeyConfigApiCall(ref gaxgrpc::ApiCall<UpdateAutokeyConfigRequest, AutokeyConfig> call);

        partial void Modify_GetAutokeyConfigApiCall(ref gaxgrpc::ApiCall<GetAutokeyConfigRequest, AutokeyConfig> call);

        partial void Modify_ShowEffectiveAutokeyConfigApiCall(ref gaxgrpc::ApiCall<ShowEffectiveAutokeyConfigRequest, ShowEffectiveAutokeyConfigResponse> call);

        partial void OnConstruction(AutokeyAdmin.AutokeyAdminClient grpcClient, AutokeyAdminSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AutokeyAdmin client</summary>
        public override AutokeyAdmin.AutokeyAdminClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_UpdateAutokeyConfigRequest(ref UpdateAutokeyConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAutokeyConfigRequest(ref GetAutokeyConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ShowEffectiveAutokeyConfigRequest(ref ShowEffectiveAutokeyConfigRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Updates the [AutokeyConfig][google.cloud.kms.v1.AutokeyConfig] for a
        /// folder. The caller must have both `cloudkms.autokeyConfigs.update`
        /// permission on the parent folder and `cloudkms.cryptoKeys.setIamPolicy`
        /// permission on the provided key project. A
        /// [KeyHandle][google.cloud.kms.v1.KeyHandle] creation in the folder's
        /// descendant projects will use this configuration to determine where to
        /// create the resulting [CryptoKey][google.cloud.kms.v1.CryptoKey].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AutokeyConfig UpdateAutokeyConfig(UpdateAutokeyConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAutokeyConfigRequest(ref request, ref callSettings);
            return _callUpdateAutokeyConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the [AutokeyConfig][google.cloud.kms.v1.AutokeyConfig] for a
        /// folder. The caller must have both `cloudkms.autokeyConfigs.update`
        /// permission on the parent folder and `cloudkms.cryptoKeys.setIamPolicy`
        /// permission on the provided key project. A
        /// [KeyHandle][google.cloud.kms.v1.KeyHandle] creation in the folder's
        /// descendant projects will use this configuration to determine where to
        /// create the resulting [CryptoKey][google.cloud.kms.v1.CryptoKey].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AutokeyConfig> UpdateAutokeyConfigAsync(UpdateAutokeyConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAutokeyConfigRequest(ref request, ref callSettings);
            return _callUpdateAutokeyConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the [AutokeyConfig][google.cloud.kms.v1.AutokeyConfig] for a
        /// folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AutokeyConfig GetAutokeyConfig(GetAutokeyConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAutokeyConfigRequest(ref request, ref callSettings);
            return _callGetAutokeyConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the [AutokeyConfig][google.cloud.kms.v1.AutokeyConfig] for a
        /// folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AutokeyConfig> GetAutokeyConfigAsync(GetAutokeyConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAutokeyConfigRequest(ref request, ref callSettings);
            return _callGetAutokeyConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the effective Cloud KMS Autokey configuration for a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ShowEffectiveAutokeyConfigResponse ShowEffectiveAutokeyConfig(ShowEffectiveAutokeyConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ShowEffectiveAutokeyConfigRequest(ref request, ref callSettings);
            return _callShowEffectiveAutokeyConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the effective Cloud KMS Autokey configuration for a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ShowEffectiveAutokeyConfigResponse> ShowEffectiveAutokeyConfigAsync(ShowEffectiveAutokeyConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ShowEffectiveAutokeyConfigRequest(ref request, ref callSettings);
            return _callShowEffectiveAutokeyConfig.Async(request, callSettings);
        }
    }

    public static partial class AutokeyAdmin
    {
        public partial class AutokeyAdminClient
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
