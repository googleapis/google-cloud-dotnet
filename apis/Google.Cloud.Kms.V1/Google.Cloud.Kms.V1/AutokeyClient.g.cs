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
using lro = Google.LongRunning;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.Kms.V1
{
    /// <summary>Settings for <see cref="AutokeyClient"/> instances.</summary>
    public sealed partial class AutokeySettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AutokeySettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AutokeySettings"/>.</returns>
        public static AutokeySettings GetDefault() => new AutokeySettings();

        /// <summary>Constructs a new <see cref="AutokeySettings"/> object with default settings.</summary>
        public AutokeySettings()
        {
        }

        private AutokeySettings(AutokeySettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateKeyHandleSettings = existing.CreateKeyHandleSettings;
            CreateKeyHandleOperationsSettings = existing.CreateKeyHandleOperationsSettings.Clone();
            GetKeyHandleSettings = existing.GetKeyHandleSettings;
            ListKeyHandlesSettings = existing.ListKeyHandlesSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(AutokeySettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AutokeyClient.CreateKeyHandle</c> and <c>AutokeyClient.CreateKeyHandleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateKeyHandleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AutokeyClient.CreateKeyHandle</c> and
        /// <c>AutokeyClient.CreateKeyHandleAsync</c>.
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
        public lro::OperationsSettings CreateKeyHandleOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AutokeyClient.GetKeyHandle</c>
        ///  and <c>AutokeyClient.GetKeyHandleAsync</c>.
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
        public gaxgrpc::CallSettings GetKeyHandleSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AutokeyClient.ListKeyHandles</c> and <c>AutokeyClient.ListKeyHandlesAsync</c>.
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
        public gaxgrpc::CallSettings ListKeyHandlesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AutokeySettings"/> object.</returns>
        public AutokeySettings Clone() => new AutokeySettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AutokeyClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class AutokeyClientBuilder : gaxgrpc::ClientBuilderBase<AutokeyClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AutokeySettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AutokeyClientBuilder() : base(AutokeyClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AutokeyClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AutokeyClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AutokeyClient Build()
        {
            AutokeyClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AutokeyClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AutokeyClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AutokeyClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AutokeyClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AutokeyClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AutokeyClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AutokeyClient.ChannelPool;
    }

    /// <summary>Autokey client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides interfaces for using [Cloud KMS
    /// Autokey](https://cloud.google.com/kms/help/autokey) to provision new
    /// [CryptoKeys][google.cloud.kms.v1.CryptoKey], ready for Customer Managed
    /// Encryption Key (CMEK) use, on-demand. To support certain client tooling, this
    /// feature is modeled around a [KeyHandle][google.cloud.kms.v1.KeyHandle]
    /// resource: creating a [KeyHandle][google.cloud.kms.v1.KeyHandle] in a resource
    /// project and given location triggers Cloud KMS Autokey to provision a
    /// [CryptoKey][google.cloud.kms.v1.CryptoKey] in the configured key project and
    /// the same location.
    /// 
    /// Prior to use in a given resource project,
    /// [UpdateAutokeyConfig][google.cloud.kms.v1.AutokeyAdmin.UpdateAutokeyConfig]
    /// should have been called on an ancestor folder, setting the key project where
    /// Cloud KMS Autokey should create new
    /// [CryptoKeys][google.cloud.kms.v1.CryptoKey]. See documentation for additional
    /// prerequisites. To check what key project, if any, is currently configured on
    /// a resource project's ancestor folder, see
    /// [ShowEffectiveAutokeyConfig][google.cloud.kms.v1.AutokeyAdmin.ShowEffectiveAutokeyConfig].
    /// </remarks>
    public abstract partial class AutokeyClient
    {
        /// <summary>
        /// The default endpoint for the Autokey service, which is a host of "cloudkms.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloudkms.googleapis.com:443";

        /// <summary>The default Autokey scopes.</summary>
        /// <remarks>
        /// The default Autokey scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Autokey.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AutokeyClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="AutokeyClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AutokeyClient"/>.</returns>
        public static stt::Task<AutokeyClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AutokeyClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AutokeyClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="AutokeyClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AutokeyClient"/>.</returns>
        public static AutokeyClient Create() => new AutokeyClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AutokeyClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AutokeySettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AutokeyClient"/>.</returns>
        internal static AutokeyClient Create(grpccore::CallInvoker callInvoker, AutokeySettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Autokey.AutokeyClient grpcClient = new Autokey.AutokeyClient(callInvoker);
            return new AutokeyClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Autokey client</summary>
        public virtual Autokey.AutokeyClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new [KeyHandle][google.cloud.kms.v1.KeyHandle], triggering the
        /// provisioning of a new [CryptoKey][google.cloud.kms.v1.CryptoKey] for CMEK
        /// use with the given resource type in the configured key project and the same
        /// location. [GetOperation][google.longrunning.Operations.GetOperation] should
        /// be used to resolve the resulting long-running operation and get the
        /// resulting [KeyHandle][google.cloud.kms.v1.KeyHandle] and
        /// [CryptoKey][google.cloud.kms.v1.CryptoKey].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<KeyHandle, CreateKeyHandleMetadata> CreateKeyHandle(CreateKeyHandleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new [KeyHandle][google.cloud.kms.v1.KeyHandle], triggering the
        /// provisioning of a new [CryptoKey][google.cloud.kms.v1.CryptoKey] for CMEK
        /// use with the given resource type in the configured key project and the same
        /// location. [GetOperation][google.longrunning.Operations.GetOperation] should
        /// be used to resolve the resulting long-running operation and get the
        /// resulting [KeyHandle][google.cloud.kms.v1.KeyHandle] and
        /// [CryptoKey][google.cloud.kms.v1.CryptoKey].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<KeyHandle, CreateKeyHandleMetadata>> CreateKeyHandleAsync(CreateKeyHandleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new [KeyHandle][google.cloud.kms.v1.KeyHandle], triggering the
        /// provisioning of a new [CryptoKey][google.cloud.kms.v1.CryptoKey] for CMEK
        /// use with the given resource type in the configured key project and the same
        /// location. [GetOperation][google.longrunning.Operations.GetOperation] should
        /// be used to resolve the resulting long-running operation and get the
        /// resulting [KeyHandle][google.cloud.kms.v1.KeyHandle] and
        /// [CryptoKey][google.cloud.kms.v1.CryptoKey].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<KeyHandle, CreateKeyHandleMetadata>> CreateKeyHandleAsync(CreateKeyHandleRequest request, st::CancellationToken cancellationToken) =>
            CreateKeyHandleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateKeyHandle</c>.</summary>
        public virtual lro::OperationsClient CreateKeyHandleOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateKeyHandle</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<KeyHandle, CreateKeyHandleMetadata> PollOnceCreateKeyHandle(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<KeyHandle, CreateKeyHandleMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateKeyHandleOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateKeyHandle</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<KeyHandle, CreateKeyHandleMetadata>> PollOnceCreateKeyHandleAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<KeyHandle, CreateKeyHandleMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateKeyHandleOperationsClient, callSettings);

        /// <summary>
        /// Creates a new [KeyHandle][google.cloud.kms.v1.KeyHandle], triggering the
        /// provisioning of a new [CryptoKey][google.cloud.kms.v1.CryptoKey] for CMEK
        /// use with the given resource type in the configured key project and the same
        /// location. [GetOperation][google.longrunning.Operations.GetOperation] should
        /// be used to resolve the resulting long-running operation and get the
        /// resulting [KeyHandle][google.cloud.kms.v1.KeyHandle] and
        /// [CryptoKey][google.cloud.kms.v1.CryptoKey].
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the resource project and location to create the
        /// [KeyHandle][google.cloud.kms.v1.KeyHandle] in, e.g.
        /// `projects/{PROJECT_ID}/locations/{LOCATION}`.
        /// </param>
        /// <param name="keyHandle">
        /// Required. [KeyHandle][google.cloud.kms.v1.KeyHandle] to create.
        /// </param>
        /// <param name="keyHandleId">
        /// Optional. Id of the [KeyHandle][google.cloud.kms.v1.KeyHandle]. Must be
        /// unique to the resource project and location. If not provided by the caller,
        /// a new UUID is used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<KeyHandle, CreateKeyHandleMetadata> CreateKeyHandle(string parent, KeyHandle keyHandle, string keyHandleId, gaxgrpc::CallSettings callSettings = null) =>
            CreateKeyHandle(new CreateKeyHandleRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                KeyHandleId = keyHandleId ?? "",
                KeyHandle = gax::GaxPreconditions.CheckNotNull(keyHandle, nameof(keyHandle)),
            }, callSettings);

        /// <summary>
        /// Creates a new [KeyHandle][google.cloud.kms.v1.KeyHandle], triggering the
        /// provisioning of a new [CryptoKey][google.cloud.kms.v1.CryptoKey] for CMEK
        /// use with the given resource type in the configured key project and the same
        /// location. [GetOperation][google.longrunning.Operations.GetOperation] should
        /// be used to resolve the resulting long-running operation and get the
        /// resulting [KeyHandle][google.cloud.kms.v1.KeyHandle] and
        /// [CryptoKey][google.cloud.kms.v1.CryptoKey].
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the resource project and location to create the
        /// [KeyHandle][google.cloud.kms.v1.KeyHandle] in, e.g.
        /// `projects/{PROJECT_ID}/locations/{LOCATION}`.
        /// </param>
        /// <param name="keyHandle">
        /// Required. [KeyHandle][google.cloud.kms.v1.KeyHandle] to create.
        /// </param>
        /// <param name="keyHandleId">
        /// Optional. Id of the [KeyHandle][google.cloud.kms.v1.KeyHandle]. Must be
        /// unique to the resource project and location. If not provided by the caller,
        /// a new UUID is used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<KeyHandle, CreateKeyHandleMetadata>> CreateKeyHandleAsync(string parent, KeyHandle keyHandle, string keyHandleId, gaxgrpc::CallSettings callSettings = null) =>
            CreateKeyHandleAsync(new CreateKeyHandleRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                KeyHandleId = keyHandleId ?? "",
                KeyHandle = gax::GaxPreconditions.CheckNotNull(keyHandle, nameof(keyHandle)),
            }, callSettings);

        /// <summary>
        /// Creates a new [KeyHandle][google.cloud.kms.v1.KeyHandle], triggering the
        /// provisioning of a new [CryptoKey][google.cloud.kms.v1.CryptoKey] for CMEK
        /// use with the given resource type in the configured key project and the same
        /// location. [GetOperation][google.longrunning.Operations.GetOperation] should
        /// be used to resolve the resulting long-running operation and get the
        /// resulting [KeyHandle][google.cloud.kms.v1.KeyHandle] and
        /// [CryptoKey][google.cloud.kms.v1.CryptoKey].
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the resource project and location to create the
        /// [KeyHandle][google.cloud.kms.v1.KeyHandle] in, e.g.
        /// `projects/{PROJECT_ID}/locations/{LOCATION}`.
        /// </param>
        /// <param name="keyHandle">
        /// Required. [KeyHandle][google.cloud.kms.v1.KeyHandle] to create.
        /// </param>
        /// <param name="keyHandleId">
        /// Optional. Id of the [KeyHandle][google.cloud.kms.v1.KeyHandle]. Must be
        /// unique to the resource project and location. If not provided by the caller,
        /// a new UUID is used.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<KeyHandle, CreateKeyHandleMetadata>> CreateKeyHandleAsync(string parent, KeyHandle keyHandle, string keyHandleId, st::CancellationToken cancellationToken) =>
            CreateKeyHandleAsync(parent, keyHandle, keyHandleId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new [KeyHandle][google.cloud.kms.v1.KeyHandle], triggering the
        /// provisioning of a new [CryptoKey][google.cloud.kms.v1.CryptoKey] for CMEK
        /// use with the given resource type in the configured key project and the same
        /// location. [GetOperation][google.longrunning.Operations.GetOperation] should
        /// be used to resolve the resulting long-running operation and get the
        /// resulting [KeyHandle][google.cloud.kms.v1.KeyHandle] and
        /// [CryptoKey][google.cloud.kms.v1.CryptoKey].
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the resource project and location to create the
        /// [KeyHandle][google.cloud.kms.v1.KeyHandle] in, e.g.
        /// `projects/{PROJECT_ID}/locations/{LOCATION}`.
        /// </param>
        /// <param name="keyHandle">
        /// Required. [KeyHandle][google.cloud.kms.v1.KeyHandle] to create.
        /// </param>
        /// <param name="keyHandleId">
        /// Optional. Id of the [KeyHandle][google.cloud.kms.v1.KeyHandle]. Must be
        /// unique to the resource project and location. If not provided by the caller,
        /// a new UUID is used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<KeyHandle, CreateKeyHandleMetadata> CreateKeyHandle(gagr::LocationName parent, KeyHandle keyHandle, string keyHandleId, gaxgrpc::CallSettings callSettings = null) =>
            CreateKeyHandle(new CreateKeyHandleRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                KeyHandleId = keyHandleId ?? "",
                KeyHandle = gax::GaxPreconditions.CheckNotNull(keyHandle, nameof(keyHandle)),
            }, callSettings);

        /// <summary>
        /// Creates a new [KeyHandle][google.cloud.kms.v1.KeyHandle], triggering the
        /// provisioning of a new [CryptoKey][google.cloud.kms.v1.CryptoKey] for CMEK
        /// use with the given resource type in the configured key project and the same
        /// location. [GetOperation][google.longrunning.Operations.GetOperation] should
        /// be used to resolve the resulting long-running operation and get the
        /// resulting [KeyHandle][google.cloud.kms.v1.KeyHandle] and
        /// [CryptoKey][google.cloud.kms.v1.CryptoKey].
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the resource project and location to create the
        /// [KeyHandle][google.cloud.kms.v1.KeyHandle] in, e.g.
        /// `projects/{PROJECT_ID}/locations/{LOCATION}`.
        /// </param>
        /// <param name="keyHandle">
        /// Required. [KeyHandle][google.cloud.kms.v1.KeyHandle] to create.
        /// </param>
        /// <param name="keyHandleId">
        /// Optional. Id of the [KeyHandle][google.cloud.kms.v1.KeyHandle]. Must be
        /// unique to the resource project and location. If not provided by the caller,
        /// a new UUID is used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<KeyHandle, CreateKeyHandleMetadata>> CreateKeyHandleAsync(gagr::LocationName parent, KeyHandle keyHandle, string keyHandleId, gaxgrpc::CallSettings callSettings = null) =>
            CreateKeyHandleAsync(new CreateKeyHandleRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                KeyHandleId = keyHandleId ?? "",
                KeyHandle = gax::GaxPreconditions.CheckNotNull(keyHandle, nameof(keyHandle)),
            }, callSettings);

        /// <summary>
        /// Creates a new [KeyHandle][google.cloud.kms.v1.KeyHandle], triggering the
        /// provisioning of a new [CryptoKey][google.cloud.kms.v1.CryptoKey] for CMEK
        /// use with the given resource type in the configured key project and the same
        /// location. [GetOperation][google.longrunning.Operations.GetOperation] should
        /// be used to resolve the resulting long-running operation and get the
        /// resulting [KeyHandle][google.cloud.kms.v1.KeyHandle] and
        /// [CryptoKey][google.cloud.kms.v1.CryptoKey].
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the resource project and location to create the
        /// [KeyHandle][google.cloud.kms.v1.KeyHandle] in, e.g.
        /// `projects/{PROJECT_ID}/locations/{LOCATION}`.
        /// </param>
        /// <param name="keyHandle">
        /// Required. [KeyHandle][google.cloud.kms.v1.KeyHandle] to create.
        /// </param>
        /// <param name="keyHandleId">
        /// Optional. Id of the [KeyHandle][google.cloud.kms.v1.KeyHandle]. Must be
        /// unique to the resource project and location. If not provided by the caller,
        /// a new UUID is used.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<KeyHandle, CreateKeyHandleMetadata>> CreateKeyHandleAsync(gagr::LocationName parent, KeyHandle keyHandle, string keyHandleId, st::CancellationToken cancellationToken) =>
            CreateKeyHandleAsync(parent, keyHandle, keyHandleId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the [KeyHandle][google.cloud.kms.v1.KeyHandle].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual KeyHandle GetKeyHandle(GetKeyHandleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the [KeyHandle][google.cloud.kms.v1.KeyHandle].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KeyHandle> GetKeyHandleAsync(GetKeyHandleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the [KeyHandle][google.cloud.kms.v1.KeyHandle].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KeyHandle> GetKeyHandleAsync(GetKeyHandleRequest request, st::CancellationToken cancellationToken) =>
            GetKeyHandleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the [KeyHandle][google.cloud.kms.v1.KeyHandle].
        /// </summary>
        /// <param name="name">
        /// Required. Name of the [KeyHandle][google.cloud.kms.v1.KeyHandle] resource,
        /// e.g.
        /// `projects/{PROJECT_ID}/locations/{LOCATION}/keyHandles/{KEY_HANDLE_ID}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual KeyHandle GetKeyHandle(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetKeyHandle(new GetKeyHandleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the [KeyHandle][google.cloud.kms.v1.KeyHandle].
        /// </summary>
        /// <param name="name">
        /// Required. Name of the [KeyHandle][google.cloud.kms.v1.KeyHandle] resource,
        /// e.g.
        /// `projects/{PROJECT_ID}/locations/{LOCATION}/keyHandles/{KEY_HANDLE_ID}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KeyHandle> GetKeyHandleAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetKeyHandleAsync(new GetKeyHandleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the [KeyHandle][google.cloud.kms.v1.KeyHandle].
        /// </summary>
        /// <param name="name">
        /// Required. Name of the [KeyHandle][google.cloud.kms.v1.KeyHandle] resource,
        /// e.g.
        /// `projects/{PROJECT_ID}/locations/{LOCATION}/keyHandles/{KEY_HANDLE_ID}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KeyHandle> GetKeyHandleAsync(string name, st::CancellationToken cancellationToken) =>
            GetKeyHandleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the [KeyHandle][google.cloud.kms.v1.KeyHandle].
        /// </summary>
        /// <param name="name">
        /// Required. Name of the [KeyHandle][google.cloud.kms.v1.KeyHandle] resource,
        /// e.g.
        /// `projects/{PROJECT_ID}/locations/{LOCATION}/keyHandles/{KEY_HANDLE_ID}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual KeyHandle GetKeyHandle(KeyHandleName name, gaxgrpc::CallSettings callSettings = null) =>
            GetKeyHandle(new GetKeyHandleRequest
            {
                KeyHandleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the [KeyHandle][google.cloud.kms.v1.KeyHandle].
        /// </summary>
        /// <param name="name">
        /// Required. Name of the [KeyHandle][google.cloud.kms.v1.KeyHandle] resource,
        /// e.g.
        /// `projects/{PROJECT_ID}/locations/{LOCATION}/keyHandles/{KEY_HANDLE_ID}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KeyHandle> GetKeyHandleAsync(KeyHandleName name, gaxgrpc::CallSettings callSettings = null) =>
            GetKeyHandleAsync(new GetKeyHandleRequest
            {
                KeyHandleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the [KeyHandle][google.cloud.kms.v1.KeyHandle].
        /// </summary>
        /// <param name="name">
        /// Required. Name of the [KeyHandle][google.cloud.kms.v1.KeyHandle] resource,
        /// e.g.
        /// `projects/{PROJECT_ID}/locations/{LOCATION}/keyHandles/{KEY_HANDLE_ID}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KeyHandle> GetKeyHandleAsync(KeyHandleName name, st::CancellationToken cancellationToken) =>
            GetKeyHandleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists [KeyHandles][google.cloud.kms.v1.KeyHandle].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="KeyHandle"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListKeyHandlesResponse, KeyHandle> ListKeyHandles(ListKeyHandlesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [KeyHandles][google.cloud.kms.v1.KeyHandle].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="KeyHandle"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListKeyHandlesResponse, KeyHandle> ListKeyHandlesAsync(ListKeyHandlesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [KeyHandles][google.cloud.kms.v1.KeyHandle].
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the resource project and location from which to list
        /// [KeyHandles][google.cloud.kms.v1.KeyHandle], e.g.
        /// `projects/{PROJECT_ID}/locations/{LOCATION}`.
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
        /// <returns>A pageable sequence of <see cref="KeyHandle"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListKeyHandlesResponse, KeyHandle> ListKeyHandles(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListKeyHandlesRequest request = new ListKeyHandlesRequest
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
            return ListKeyHandles(request, callSettings);
        }

        /// <summary>
        /// Lists [KeyHandles][google.cloud.kms.v1.KeyHandle].
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the resource project and location from which to list
        /// [KeyHandles][google.cloud.kms.v1.KeyHandle], e.g.
        /// `projects/{PROJECT_ID}/locations/{LOCATION}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="KeyHandle"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListKeyHandlesResponse, KeyHandle> ListKeyHandlesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListKeyHandlesRequest request = new ListKeyHandlesRequest
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
            return ListKeyHandlesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists [KeyHandles][google.cloud.kms.v1.KeyHandle].
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the resource project and location from which to list
        /// [KeyHandles][google.cloud.kms.v1.KeyHandle], e.g.
        /// `projects/{PROJECT_ID}/locations/{LOCATION}`.
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
        /// <returns>A pageable sequence of <see cref="KeyHandle"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListKeyHandlesResponse, KeyHandle> ListKeyHandles(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListKeyHandlesRequest request = new ListKeyHandlesRequest
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
            return ListKeyHandles(request, callSettings);
        }

        /// <summary>
        /// Lists [KeyHandles][google.cloud.kms.v1.KeyHandle].
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the resource project and location from which to list
        /// [KeyHandles][google.cloud.kms.v1.KeyHandle], e.g.
        /// `projects/{PROJECT_ID}/locations/{LOCATION}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="KeyHandle"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListKeyHandlesResponse, KeyHandle> ListKeyHandlesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListKeyHandlesRequest request = new ListKeyHandlesRequest
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
            return ListKeyHandlesAsync(request, callSettings);
        }
    }

    /// <summary>Autokey client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides interfaces for using [Cloud KMS
    /// Autokey](https://cloud.google.com/kms/help/autokey) to provision new
    /// [CryptoKeys][google.cloud.kms.v1.CryptoKey], ready for Customer Managed
    /// Encryption Key (CMEK) use, on-demand. To support certain client tooling, this
    /// feature is modeled around a [KeyHandle][google.cloud.kms.v1.KeyHandle]
    /// resource: creating a [KeyHandle][google.cloud.kms.v1.KeyHandle] in a resource
    /// project and given location triggers Cloud KMS Autokey to provision a
    /// [CryptoKey][google.cloud.kms.v1.CryptoKey] in the configured key project and
    /// the same location.
    /// 
    /// Prior to use in a given resource project,
    /// [UpdateAutokeyConfig][google.cloud.kms.v1.AutokeyAdmin.UpdateAutokeyConfig]
    /// should have been called on an ancestor folder, setting the key project where
    /// Cloud KMS Autokey should create new
    /// [CryptoKeys][google.cloud.kms.v1.CryptoKey]. See documentation for additional
    /// prerequisites. To check what key project, if any, is currently configured on
    /// a resource project's ancestor folder, see
    /// [ShowEffectiveAutokeyConfig][google.cloud.kms.v1.AutokeyAdmin.ShowEffectiveAutokeyConfig].
    /// </remarks>
    public sealed partial class AutokeyClientImpl : AutokeyClient
    {
        private readonly gaxgrpc::ApiCall<CreateKeyHandleRequest, lro::Operation> _callCreateKeyHandle;

        private readonly gaxgrpc::ApiCall<GetKeyHandleRequest, KeyHandle> _callGetKeyHandle;

        private readonly gaxgrpc::ApiCall<ListKeyHandlesRequest, ListKeyHandlesResponse> _callListKeyHandles;

        /// <summary>
        /// Constructs a client wrapper for the Autokey service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AutokeySettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AutokeyClientImpl(Autokey.AutokeyClient grpcClient, AutokeySettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AutokeySettings effectiveSettings = settings ?? AutokeySettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateKeyHandleOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateKeyHandleOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callCreateKeyHandle = clientHelper.BuildApiCall<CreateKeyHandleRequest, lro::Operation>("CreateKeyHandle", grpcClient.CreateKeyHandleAsync, grpcClient.CreateKeyHandle, effectiveSettings.CreateKeyHandleSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateKeyHandle);
            Modify_CreateKeyHandleApiCall(ref _callCreateKeyHandle);
            _callGetKeyHandle = clientHelper.BuildApiCall<GetKeyHandleRequest, KeyHandle>("GetKeyHandle", grpcClient.GetKeyHandleAsync, grpcClient.GetKeyHandle, effectiveSettings.GetKeyHandleSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetKeyHandle);
            Modify_GetKeyHandleApiCall(ref _callGetKeyHandle);
            _callListKeyHandles = clientHelper.BuildApiCall<ListKeyHandlesRequest, ListKeyHandlesResponse>("ListKeyHandles", grpcClient.ListKeyHandlesAsync, grpcClient.ListKeyHandles, effectiveSettings.ListKeyHandlesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListKeyHandles);
            Modify_ListKeyHandlesApiCall(ref _callListKeyHandles);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateKeyHandleApiCall(ref gaxgrpc::ApiCall<CreateKeyHandleRequest, lro::Operation> call);

        partial void Modify_GetKeyHandleApiCall(ref gaxgrpc::ApiCall<GetKeyHandleRequest, KeyHandle> call);

        partial void Modify_ListKeyHandlesApiCall(ref gaxgrpc::ApiCall<ListKeyHandlesRequest, ListKeyHandlesResponse> call);

        partial void OnConstruction(Autokey.AutokeyClient grpcClient, AutokeySettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Autokey client</summary>
        public override Autokey.AutokeyClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_CreateKeyHandleRequest(ref CreateKeyHandleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetKeyHandleRequest(ref GetKeyHandleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListKeyHandlesRequest(ref ListKeyHandlesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateKeyHandle</c>.</summary>
        public override lro::OperationsClient CreateKeyHandleOperationsClient { get; }

        /// <summary>
        /// Creates a new [KeyHandle][google.cloud.kms.v1.KeyHandle], triggering the
        /// provisioning of a new [CryptoKey][google.cloud.kms.v1.CryptoKey] for CMEK
        /// use with the given resource type in the configured key project and the same
        /// location. [GetOperation][google.longrunning.Operations.GetOperation] should
        /// be used to resolve the resulting long-running operation and get the
        /// resulting [KeyHandle][google.cloud.kms.v1.KeyHandle] and
        /// [CryptoKey][google.cloud.kms.v1.CryptoKey].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<KeyHandle, CreateKeyHandleMetadata> CreateKeyHandle(CreateKeyHandleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateKeyHandleRequest(ref request, ref callSettings);
            return new lro::Operation<KeyHandle, CreateKeyHandleMetadata>(_callCreateKeyHandle.Sync(request, callSettings), CreateKeyHandleOperationsClient);
        }

        /// <summary>
        /// Creates a new [KeyHandle][google.cloud.kms.v1.KeyHandle], triggering the
        /// provisioning of a new [CryptoKey][google.cloud.kms.v1.CryptoKey] for CMEK
        /// use with the given resource type in the configured key project and the same
        /// location. [GetOperation][google.longrunning.Operations.GetOperation] should
        /// be used to resolve the resulting long-running operation and get the
        /// resulting [KeyHandle][google.cloud.kms.v1.KeyHandle] and
        /// [CryptoKey][google.cloud.kms.v1.CryptoKey].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<KeyHandle, CreateKeyHandleMetadata>> CreateKeyHandleAsync(CreateKeyHandleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateKeyHandleRequest(ref request, ref callSettings);
            return new lro::Operation<KeyHandle, CreateKeyHandleMetadata>(await _callCreateKeyHandle.Async(request, callSettings).ConfigureAwait(false), CreateKeyHandleOperationsClient);
        }

        /// <summary>
        /// Returns the [KeyHandle][google.cloud.kms.v1.KeyHandle].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override KeyHandle GetKeyHandle(GetKeyHandleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetKeyHandleRequest(ref request, ref callSettings);
            return _callGetKeyHandle.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the [KeyHandle][google.cloud.kms.v1.KeyHandle].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<KeyHandle> GetKeyHandleAsync(GetKeyHandleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetKeyHandleRequest(ref request, ref callSettings);
            return _callGetKeyHandle.Async(request, callSettings);
        }

        /// <summary>
        /// Lists [KeyHandles][google.cloud.kms.v1.KeyHandle].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="KeyHandle"/> resources.</returns>
        public override gax::PagedEnumerable<ListKeyHandlesResponse, KeyHandle> ListKeyHandles(ListKeyHandlesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListKeyHandlesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListKeyHandlesRequest, ListKeyHandlesResponse, KeyHandle>(_callListKeyHandles, request, callSettings);
        }

        /// <summary>
        /// Lists [KeyHandles][google.cloud.kms.v1.KeyHandle].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="KeyHandle"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListKeyHandlesResponse, KeyHandle> ListKeyHandlesAsync(ListKeyHandlesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListKeyHandlesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListKeyHandlesRequest, ListKeyHandlesResponse, KeyHandle>(_callListKeyHandles, request, callSettings);
        }
    }

    public partial class ListKeyHandlesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListKeyHandlesResponse : gaxgrpc::IPageResponse<KeyHandle>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<KeyHandle> GetEnumerator() => KeyHandles.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Autokey
    {
        public partial class AutokeyClient
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

    public static partial class Autokey
    {
        public partial class AutokeyClient
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
