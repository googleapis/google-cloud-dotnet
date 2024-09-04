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

namespace Google.Cloud.ApiHub.V1
{
    /// <summary>Settings for <see cref="ProvisioningClient"/> instances.</summary>
    public sealed partial class ProvisioningSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ProvisioningSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ProvisioningSettings"/>.</returns>
        public static ProvisioningSettings GetDefault() => new ProvisioningSettings();

        /// <summary>Constructs a new <see cref="ProvisioningSettings"/> object with default settings.</summary>
        public ProvisioningSettings()
        {
        }

        private ProvisioningSettings(ProvisioningSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateApiHubInstanceSettings = existing.CreateApiHubInstanceSettings;
            CreateApiHubInstanceOperationsSettings = existing.CreateApiHubInstanceOperationsSettings.Clone();
            GetApiHubInstanceSettings = existing.GetApiHubInstanceSettings;
            LookupApiHubInstanceSettings = existing.LookupApiHubInstanceSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ProvisioningSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProvisioningClient.CreateApiHubInstance</c> and <c>ProvisioningClient.CreateApiHubInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateApiHubInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ProvisioningClient.CreateApiHubInstance</c> and
        /// <c>ProvisioningClient.CreateApiHubInstanceAsync</c>.
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
        public lro::OperationsSettings CreateApiHubInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProvisioningClient.GetApiHubInstance</c> and <c>ProvisioningClient.GetApiHubInstanceAsync</c>.
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
        public gaxgrpc::CallSettings GetApiHubInstanceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProvisioningClient.LookupApiHubInstance</c> and <c>ProvisioningClient.LookupApiHubInstanceAsync</c>.
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
        public gaxgrpc::CallSettings LookupApiHubInstanceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ProvisioningSettings"/> object.</returns>
        public ProvisioningSettings Clone() => new ProvisioningSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ProvisioningClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class ProvisioningClientBuilder : gaxgrpc::ClientBuilderBase<ProvisioningClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ProvisioningSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ProvisioningClientBuilder() : base(ProvisioningClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ProvisioningClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ProvisioningClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ProvisioningClient Build()
        {
            ProvisioningClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ProvisioningClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ProvisioningClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ProvisioningClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ProvisioningClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ProvisioningClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ProvisioningClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ProvisioningClient.ChannelPool;
    }

    /// <summary>Provisioning client wrapper, for convenient use.</summary>
    /// <remarks>
    /// This service is used for managing the data plane provisioning of the API hub.
    /// </remarks>
    public abstract partial class ProvisioningClient
    {
        /// <summary>
        /// The default endpoint for the Provisioning service, which is a host of "apihub.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "apihub.googleapis.com:443";

        /// <summary>The default Provisioning scopes.</summary>
        /// <remarks>
        /// The default Provisioning scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Provisioning.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ProvisioningClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ProvisioningClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ProvisioningClient"/>.</returns>
        public static stt::Task<ProvisioningClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ProvisioningClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ProvisioningClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ProvisioningClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ProvisioningClient"/>.</returns>
        public static ProvisioningClient Create() => new ProvisioningClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ProvisioningClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ProvisioningSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ProvisioningClient"/>.</returns>
        internal static ProvisioningClient Create(grpccore::CallInvoker callInvoker, ProvisioningSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Provisioning.ProvisioningClient grpcClient = new Provisioning.ProvisioningClient(callInvoker);
            return new ProvisioningClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Provisioning client</summary>
        public virtual Provisioning.ProvisioningClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Provisions instance resources for the API Hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ApiHubInstance, OperationMetadata> CreateApiHubInstance(CreateApiHubInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Provisions instance resources for the API Hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ApiHubInstance, OperationMetadata>> CreateApiHubInstanceAsync(CreateApiHubInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Provisions instance resources for the API Hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ApiHubInstance, OperationMetadata>> CreateApiHubInstanceAsync(CreateApiHubInstanceRequest request, st::CancellationToken cancellationToken) =>
            CreateApiHubInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateApiHubInstance</c>.</summary>
        public virtual lro::OperationsClient CreateApiHubInstanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateApiHubInstance</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ApiHubInstance, OperationMetadata> PollOnceCreateApiHubInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ApiHubInstance, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateApiHubInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateApiHubInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ApiHubInstance, OperationMetadata>> PollOnceCreateApiHubInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ApiHubInstance, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateApiHubInstanceOperationsClient, callSettings);

        /// <summary>
        /// Provisions instance resources for the API Hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for the Api Hub instance resource.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="apiHubInstance">
        /// Required. The ApiHub instance.
        /// </param>
        /// <param name="apiHubInstanceId">
        /// Optional. Identifier to assign to the Api Hub instance. Must be unique
        /// within scope of the parent resource. If the field is not provided, system
        /// generated id will be used.
        /// 
        /// This value should be 4-40 characters, and valid characters
        /// are `/[a-z][A-Z][0-9]-_/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ApiHubInstance, OperationMetadata> CreateApiHubInstance(string parent, ApiHubInstance apiHubInstance, string apiHubInstanceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateApiHubInstance(new CreateApiHubInstanceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ApiHubInstanceId = apiHubInstanceId ?? "",
                ApiHubInstance = gax::GaxPreconditions.CheckNotNull(apiHubInstance, nameof(apiHubInstance)),
            }, callSettings);

        /// <summary>
        /// Provisions instance resources for the API Hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for the Api Hub instance resource.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="apiHubInstance">
        /// Required. The ApiHub instance.
        /// </param>
        /// <param name="apiHubInstanceId">
        /// Optional. Identifier to assign to the Api Hub instance. Must be unique
        /// within scope of the parent resource. If the field is not provided, system
        /// generated id will be used.
        /// 
        /// This value should be 4-40 characters, and valid characters
        /// are `/[a-z][A-Z][0-9]-_/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ApiHubInstance, OperationMetadata>> CreateApiHubInstanceAsync(string parent, ApiHubInstance apiHubInstance, string apiHubInstanceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateApiHubInstanceAsync(new CreateApiHubInstanceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ApiHubInstanceId = apiHubInstanceId ?? "",
                ApiHubInstance = gax::GaxPreconditions.CheckNotNull(apiHubInstance, nameof(apiHubInstance)),
            }, callSettings);

        /// <summary>
        /// Provisions instance resources for the API Hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for the Api Hub instance resource.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="apiHubInstance">
        /// Required. The ApiHub instance.
        /// </param>
        /// <param name="apiHubInstanceId">
        /// Optional. Identifier to assign to the Api Hub instance. Must be unique
        /// within scope of the parent resource. If the field is not provided, system
        /// generated id will be used.
        /// 
        /// This value should be 4-40 characters, and valid characters
        /// are `/[a-z][A-Z][0-9]-_/`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ApiHubInstance, OperationMetadata>> CreateApiHubInstanceAsync(string parent, ApiHubInstance apiHubInstance, string apiHubInstanceId, st::CancellationToken cancellationToken) =>
            CreateApiHubInstanceAsync(parent, apiHubInstance, apiHubInstanceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Provisions instance resources for the API Hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for the Api Hub instance resource.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="apiHubInstance">
        /// Required. The ApiHub instance.
        /// </param>
        /// <param name="apiHubInstanceId">
        /// Optional. Identifier to assign to the Api Hub instance. Must be unique
        /// within scope of the parent resource. If the field is not provided, system
        /// generated id will be used.
        /// 
        /// This value should be 4-40 characters, and valid characters
        /// are `/[a-z][A-Z][0-9]-_/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ApiHubInstance, OperationMetadata> CreateApiHubInstance(gagr::LocationName parent, ApiHubInstance apiHubInstance, string apiHubInstanceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateApiHubInstance(new CreateApiHubInstanceRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ApiHubInstanceId = apiHubInstanceId ?? "",
                ApiHubInstance = gax::GaxPreconditions.CheckNotNull(apiHubInstance, nameof(apiHubInstance)),
            }, callSettings);

        /// <summary>
        /// Provisions instance resources for the API Hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for the Api Hub instance resource.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="apiHubInstance">
        /// Required. The ApiHub instance.
        /// </param>
        /// <param name="apiHubInstanceId">
        /// Optional. Identifier to assign to the Api Hub instance. Must be unique
        /// within scope of the parent resource. If the field is not provided, system
        /// generated id will be used.
        /// 
        /// This value should be 4-40 characters, and valid characters
        /// are `/[a-z][A-Z][0-9]-_/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ApiHubInstance, OperationMetadata>> CreateApiHubInstanceAsync(gagr::LocationName parent, ApiHubInstance apiHubInstance, string apiHubInstanceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateApiHubInstanceAsync(new CreateApiHubInstanceRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ApiHubInstanceId = apiHubInstanceId ?? "",
                ApiHubInstance = gax::GaxPreconditions.CheckNotNull(apiHubInstance, nameof(apiHubInstance)),
            }, callSettings);

        /// <summary>
        /// Provisions instance resources for the API Hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for the Api Hub instance resource.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="apiHubInstance">
        /// Required. The ApiHub instance.
        /// </param>
        /// <param name="apiHubInstanceId">
        /// Optional. Identifier to assign to the Api Hub instance. Must be unique
        /// within scope of the parent resource. If the field is not provided, system
        /// generated id will be used.
        /// 
        /// This value should be 4-40 characters, and valid characters
        /// are `/[a-z][A-Z][0-9]-_/`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ApiHubInstance, OperationMetadata>> CreateApiHubInstanceAsync(gagr::LocationName parent, ApiHubInstance apiHubInstance, string apiHubInstanceId, st::CancellationToken cancellationToken) =>
            CreateApiHubInstanceAsync(parent, apiHubInstance, apiHubInstanceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single API Hub instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApiHubInstance GetApiHubInstance(GetApiHubInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single API Hub instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiHubInstance> GetApiHubInstanceAsync(GetApiHubInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single API Hub instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiHubInstance> GetApiHubInstanceAsync(GetApiHubInstanceRequest request, st::CancellationToken cancellationToken) =>
            GetApiHubInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single API Hub instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Api Hub instance to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/apiHubInstances/{apiHubInstance}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApiHubInstance GetApiHubInstance(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetApiHubInstance(new GetApiHubInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single API Hub instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Api Hub instance to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/apiHubInstances/{apiHubInstance}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiHubInstance> GetApiHubInstanceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetApiHubInstanceAsync(new GetApiHubInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single API Hub instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Api Hub instance to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/apiHubInstances/{apiHubInstance}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiHubInstance> GetApiHubInstanceAsync(string name, st::CancellationToken cancellationToken) =>
            GetApiHubInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single API Hub instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Api Hub instance to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/apiHubInstances/{apiHubInstance}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApiHubInstance GetApiHubInstance(ApiHubInstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetApiHubInstance(new GetApiHubInstanceRequest
            {
                ApiHubInstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single API Hub instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Api Hub instance to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/apiHubInstances/{apiHubInstance}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiHubInstance> GetApiHubInstanceAsync(ApiHubInstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetApiHubInstanceAsync(new GetApiHubInstanceRequest
            {
                ApiHubInstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single API Hub instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Api Hub instance to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/apiHubInstances/{apiHubInstance}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApiHubInstance> GetApiHubInstanceAsync(ApiHubInstanceName name, st::CancellationToken cancellationToken) =>
            GetApiHubInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Looks up an Api Hub instance in a given GCP project. There will always be
        /// only one Api Hub instance for a GCP project across all locations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LookupApiHubInstanceResponse LookupApiHubInstance(LookupApiHubInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Looks up an Api Hub instance in a given GCP project. There will always be
        /// only one Api Hub instance for a GCP project across all locations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LookupApiHubInstanceResponse> LookupApiHubInstanceAsync(LookupApiHubInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Looks up an Api Hub instance in a given GCP project. There will always be
        /// only one Api Hub instance for a GCP project across all locations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LookupApiHubInstanceResponse> LookupApiHubInstanceAsync(LookupApiHubInstanceRequest request, st::CancellationToken cancellationToken) =>
            LookupApiHubInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Looks up an Api Hub instance in a given GCP project. There will always be
        /// only one Api Hub instance for a GCP project across all locations.
        /// </summary>
        /// <param name="parent">
        /// Required. There will always be only one Api Hub instance for a GCP project
        /// across all locations.
        /// The parent resource for the Api Hub instance resource.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LookupApiHubInstanceResponse LookupApiHubInstance(string parent, gaxgrpc::CallSettings callSettings = null) =>
            LookupApiHubInstance(new LookupApiHubInstanceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Looks up an Api Hub instance in a given GCP project. There will always be
        /// only one Api Hub instance for a GCP project across all locations.
        /// </summary>
        /// <param name="parent">
        /// Required. There will always be only one Api Hub instance for a GCP project
        /// across all locations.
        /// The parent resource for the Api Hub instance resource.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LookupApiHubInstanceResponse> LookupApiHubInstanceAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            LookupApiHubInstanceAsync(new LookupApiHubInstanceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Looks up an Api Hub instance in a given GCP project. There will always be
        /// only one Api Hub instance for a GCP project across all locations.
        /// </summary>
        /// <param name="parent">
        /// Required. There will always be only one Api Hub instance for a GCP project
        /// across all locations.
        /// The parent resource for the Api Hub instance resource.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LookupApiHubInstanceResponse> LookupApiHubInstanceAsync(string parent, st::CancellationToken cancellationToken) =>
            LookupApiHubInstanceAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Looks up an Api Hub instance in a given GCP project. There will always be
        /// only one Api Hub instance for a GCP project across all locations.
        /// </summary>
        /// <param name="parent">
        /// Required. There will always be only one Api Hub instance for a GCP project
        /// across all locations.
        /// The parent resource for the Api Hub instance resource.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LookupApiHubInstanceResponse LookupApiHubInstance(gagr::LocationName parent, gaxgrpc::CallSettings callSettings = null) =>
            LookupApiHubInstance(new LookupApiHubInstanceRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Looks up an Api Hub instance in a given GCP project. There will always be
        /// only one Api Hub instance for a GCP project across all locations.
        /// </summary>
        /// <param name="parent">
        /// Required. There will always be only one Api Hub instance for a GCP project
        /// across all locations.
        /// The parent resource for the Api Hub instance resource.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LookupApiHubInstanceResponse> LookupApiHubInstanceAsync(gagr::LocationName parent, gaxgrpc::CallSettings callSettings = null) =>
            LookupApiHubInstanceAsync(new LookupApiHubInstanceRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Looks up an Api Hub instance in a given GCP project. There will always be
        /// only one Api Hub instance for a GCP project across all locations.
        /// </summary>
        /// <param name="parent">
        /// Required. There will always be only one Api Hub instance for a GCP project
        /// across all locations.
        /// The parent resource for the Api Hub instance resource.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LookupApiHubInstanceResponse> LookupApiHubInstanceAsync(gagr::LocationName parent, st::CancellationToken cancellationToken) =>
            LookupApiHubInstanceAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Provisioning client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// This service is used for managing the data plane provisioning of the API hub.
    /// </remarks>
    public sealed partial class ProvisioningClientImpl : ProvisioningClient
    {
        private readonly gaxgrpc::ApiCall<CreateApiHubInstanceRequest, lro::Operation> _callCreateApiHubInstance;

        private readonly gaxgrpc::ApiCall<GetApiHubInstanceRequest, ApiHubInstance> _callGetApiHubInstance;

        private readonly gaxgrpc::ApiCall<LookupApiHubInstanceRequest, LookupApiHubInstanceResponse> _callLookupApiHubInstance;

        /// <summary>
        /// Constructs a client wrapper for the Provisioning service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ProvisioningSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ProvisioningClientImpl(Provisioning.ProvisioningClient grpcClient, ProvisioningSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ProvisioningSettings effectiveSettings = settings ?? ProvisioningSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateApiHubInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateApiHubInstanceOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callCreateApiHubInstance = clientHelper.BuildApiCall<CreateApiHubInstanceRequest, lro::Operation>("CreateApiHubInstance", grpcClient.CreateApiHubInstanceAsync, grpcClient.CreateApiHubInstance, effectiveSettings.CreateApiHubInstanceSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateApiHubInstance);
            Modify_CreateApiHubInstanceApiCall(ref _callCreateApiHubInstance);
            _callGetApiHubInstance = clientHelper.BuildApiCall<GetApiHubInstanceRequest, ApiHubInstance>("GetApiHubInstance", grpcClient.GetApiHubInstanceAsync, grpcClient.GetApiHubInstance, effectiveSettings.GetApiHubInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetApiHubInstance);
            Modify_GetApiHubInstanceApiCall(ref _callGetApiHubInstance);
            _callLookupApiHubInstance = clientHelper.BuildApiCall<LookupApiHubInstanceRequest, LookupApiHubInstanceResponse>("LookupApiHubInstance", grpcClient.LookupApiHubInstanceAsync, grpcClient.LookupApiHubInstance, effectiveSettings.LookupApiHubInstanceSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callLookupApiHubInstance);
            Modify_LookupApiHubInstanceApiCall(ref _callLookupApiHubInstance);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateApiHubInstanceApiCall(ref gaxgrpc::ApiCall<CreateApiHubInstanceRequest, lro::Operation> call);

        partial void Modify_GetApiHubInstanceApiCall(ref gaxgrpc::ApiCall<GetApiHubInstanceRequest, ApiHubInstance> call);

        partial void Modify_LookupApiHubInstanceApiCall(ref gaxgrpc::ApiCall<LookupApiHubInstanceRequest, LookupApiHubInstanceResponse> call);

        partial void OnConstruction(Provisioning.ProvisioningClient grpcClient, ProvisioningSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Provisioning client</summary>
        public override Provisioning.ProvisioningClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_CreateApiHubInstanceRequest(ref CreateApiHubInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetApiHubInstanceRequest(ref GetApiHubInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_LookupApiHubInstanceRequest(ref LookupApiHubInstanceRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateApiHubInstance</c>.</summary>
        public override lro::OperationsClient CreateApiHubInstanceOperationsClient { get; }

        /// <summary>
        /// Provisions instance resources for the API Hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ApiHubInstance, OperationMetadata> CreateApiHubInstance(CreateApiHubInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateApiHubInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<ApiHubInstance, OperationMetadata>(_callCreateApiHubInstance.Sync(request, callSettings), CreateApiHubInstanceOperationsClient);
        }

        /// <summary>
        /// Provisions instance resources for the API Hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ApiHubInstance, OperationMetadata>> CreateApiHubInstanceAsync(CreateApiHubInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateApiHubInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<ApiHubInstance, OperationMetadata>(await _callCreateApiHubInstance.Async(request, callSettings).ConfigureAwait(false), CreateApiHubInstanceOperationsClient);
        }

        /// <summary>
        /// Gets details of a single API Hub instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ApiHubInstance GetApiHubInstance(GetApiHubInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetApiHubInstanceRequest(ref request, ref callSettings);
            return _callGetApiHubInstance.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single API Hub instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ApiHubInstance> GetApiHubInstanceAsync(GetApiHubInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetApiHubInstanceRequest(ref request, ref callSettings);
            return _callGetApiHubInstance.Async(request, callSettings);
        }

        /// <summary>
        /// Looks up an Api Hub instance in a given GCP project. There will always be
        /// only one Api Hub instance for a GCP project across all locations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LookupApiHubInstanceResponse LookupApiHubInstance(LookupApiHubInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LookupApiHubInstanceRequest(ref request, ref callSettings);
            return _callLookupApiHubInstance.Sync(request, callSettings);
        }

        /// <summary>
        /// Looks up an Api Hub instance in a given GCP project. There will always be
        /// only one Api Hub instance for a GCP project across all locations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LookupApiHubInstanceResponse> LookupApiHubInstanceAsync(LookupApiHubInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LookupApiHubInstanceRequest(ref request, ref callSettings);
            return _callLookupApiHubInstance.Async(request, callSettings);
        }
    }

    public static partial class Provisioning
    {
        public partial class ProvisioningClient
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

    public static partial class Provisioning
    {
        public partial class ProvisioningClient
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
