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
using gagr = Google.Api.Gax.ResourceNames;
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

namespace Google.Cloud.ApiHub.V1
{
    /// <summary>Settings for <see cref="HostProjectRegistrationServiceClient"/> instances.</summary>
    public sealed partial class HostProjectRegistrationServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="HostProjectRegistrationServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="HostProjectRegistrationServiceSettings"/>.</returns>
        public static HostProjectRegistrationServiceSettings GetDefault() => new HostProjectRegistrationServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="HostProjectRegistrationServiceSettings"/> object with default settings.
        /// </summary>
        public HostProjectRegistrationServiceSettings()
        {
        }

        private HostProjectRegistrationServiceSettings(HostProjectRegistrationServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateHostProjectRegistrationSettings = existing.CreateHostProjectRegistrationSettings;
            GetHostProjectRegistrationSettings = existing.GetHostProjectRegistrationSettings;
            ListHostProjectRegistrationsSettings = existing.ListHostProjectRegistrationsSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(HostProjectRegistrationServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>HostProjectRegistrationServiceClient.CreateHostProjectRegistration</c> and
        /// <c>HostProjectRegistrationServiceClient.CreateHostProjectRegistrationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateHostProjectRegistrationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>HostProjectRegistrationServiceClient.GetHostProjectRegistration</c> and
        /// <c>HostProjectRegistrationServiceClient.GetHostProjectRegistrationAsync</c>.
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
        public gaxgrpc::CallSettings GetHostProjectRegistrationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>HostProjectRegistrationServiceClient.ListHostProjectRegistrations</c> and
        /// <c>HostProjectRegistrationServiceClient.ListHostProjectRegistrationsAsync</c>.
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
        public gaxgrpc::CallSettings ListHostProjectRegistrationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="HostProjectRegistrationServiceSettings"/> object.</returns>
        public HostProjectRegistrationServiceSettings Clone() => new HostProjectRegistrationServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="HostProjectRegistrationServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class HostProjectRegistrationServiceClientBuilder : gaxgrpc::ClientBuilderBase<HostProjectRegistrationServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public HostProjectRegistrationServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public HostProjectRegistrationServiceClientBuilder() : base(HostProjectRegistrationServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref HostProjectRegistrationServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<HostProjectRegistrationServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override HostProjectRegistrationServiceClient Build()
        {
            HostProjectRegistrationServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<HostProjectRegistrationServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<HostProjectRegistrationServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private HostProjectRegistrationServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return HostProjectRegistrationServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<HostProjectRegistrationServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return HostProjectRegistrationServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => HostProjectRegistrationServiceClient.ChannelPool;
    }

    /// <summary>HostProjectRegistrationService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// This service is used for managing the host project registrations.
    /// </remarks>
    public abstract partial class HostProjectRegistrationServiceClient
    {
        /// <summary>
        /// The default endpoint for the HostProjectRegistrationService service, which is a host of
        /// "apihub.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "apihub.googleapis.com:443";

        /// <summary>The default HostProjectRegistrationService scopes.</summary>
        /// <remarks>
        /// The default HostProjectRegistrationService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(HostProjectRegistrationService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="HostProjectRegistrationServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="HostProjectRegistrationServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="HostProjectRegistrationServiceClient"/>.</returns>
        public static stt::Task<HostProjectRegistrationServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new HostProjectRegistrationServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="HostProjectRegistrationServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="HostProjectRegistrationServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="HostProjectRegistrationServiceClient"/>.</returns>
        public static HostProjectRegistrationServiceClient Create() =>
            new HostProjectRegistrationServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="HostProjectRegistrationServiceClient"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="HostProjectRegistrationServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="HostProjectRegistrationServiceClient"/>.</returns>
        internal static HostProjectRegistrationServiceClient Create(grpccore::CallInvoker callInvoker, HostProjectRegistrationServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            HostProjectRegistrationService.HostProjectRegistrationServiceClient grpcClient = new HostProjectRegistrationService.HostProjectRegistrationServiceClient(callInvoker);
            return new HostProjectRegistrationServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC HostProjectRegistrationService client</summary>
        public virtual HostProjectRegistrationService.HostProjectRegistrationServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Create a host project registration.
        /// A Google cloud project can be registered as a host project if it is not
        /// attached as a runtime project to another host project.
        /// A project can be registered as a host project only once. Subsequent
        /// register calls for the same project will fail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual HostProjectRegistration CreateHostProjectRegistration(CreateHostProjectRegistrationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a host project registration.
        /// A Google cloud project can be registered as a host project if it is not
        /// attached as a runtime project to another host project.
        /// A project can be registered as a host project only once. Subsequent
        /// register calls for the same project will fail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HostProjectRegistration> CreateHostProjectRegistrationAsync(CreateHostProjectRegistrationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a host project registration.
        /// A Google cloud project can be registered as a host project if it is not
        /// attached as a runtime project to another host project.
        /// A project can be registered as a host project only once. Subsequent
        /// register calls for the same project will fail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HostProjectRegistration> CreateHostProjectRegistrationAsync(CreateHostProjectRegistrationRequest request, st::CancellationToken cancellationToken) =>
            CreateHostProjectRegistrationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a host project registration.
        /// A Google cloud project can be registered as a host project if it is not
        /// attached as a runtime project to another host project.
        /// A project can be registered as a host project only once. Subsequent
        /// register calls for the same project will fail.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for the host project.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="hostProjectRegistration">
        /// Required. The host project registration to register.
        /// </param>
        /// <param name="hostProjectRegistrationId">
        /// Required. The ID to use for the Host Project Registration, which will
        /// become the final component of the host project registration's resource
        /// name. The ID must be the same as the Google cloud project specified in the
        /// host_project_registration.gcp_project field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual HostProjectRegistration CreateHostProjectRegistration(string parent, HostProjectRegistration hostProjectRegistration, string hostProjectRegistrationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateHostProjectRegistration(new CreateHostProjectRegistrationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                HostProjectRegistrationId = gax::GaxPreconditions.CheckNotNullOrEmpty(hostProjectRegistrationId, nameof(hostProjectRegistrationId)),
                HostProjectRegistration = gax::GaxPreconditions.CheckNotNull(hostProjectRegistration, nameof(hostProjectRegistration)),
            }, callSettings);

        /// <summary>
        /// Create a host project registration.
        /// A Google cloud project can be registered as a host project if it is not
        /// attached as a runtime project to another host project.
        /// A project can be registered as a host project only once. Subsequent
        /// register calls for the same project will fail.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for the host project.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="hostProjectRegistration">
        /// Required. The host project registration to register.
        /// </param>
        /// <param name="hostProjectRegistrationId">
        /// Required. The ID to use for the Host Project Registration, which will
        /// become the final component of the host project registration's resource
        /// name. The ID must be the same as the Google cloud project specified in the
        /// host_project_registration.gcp_project field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HostProjectRegistration> CreateHostProjectRegistrationAsync(string parent, HostProjectRegistration hostProjectRegistration, string hostProjectRegistrationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateHostProjectRegistrationAsync(new CreateHostProjectRegistrationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                HostProjectRegistrationId = gax::GaxPreconditions.CheckNotNullOrEmpty(hostProjectRegistrationId, nameof(hostProjectRegistrationId)),
                HostProjectRegistration = gax::GaxPreconditions.CheckNotNull(hostProjectRegistration, nameof(hostProjectRegistration)),
            }, callSettings);

        /// <summary>
        /// Create a host project registration.
        /// A Google cloud project can be registered as a host project if it is not
        /// attached as a runtime project to another host project.
        /// A project can be registered as a host project only once. Subsequent
        /// register calls for the same project will fail.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for the host project.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="hostProjectRegistration">
        /// Required. The host project registration to register.
        /// </param>
        /// <param name="hostProjectRegistrationId">
        /// Required. The ID to use for the Host Project Registration, which will
        /// become the final component of the host project registration's resource
        /// name. The ID must be the same as the Google cloud project specified in the
        /// host_project_registration.gcp_project field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HostProjectRegistration> CreateHostProjectRegistrationAsync(string parent, HostProjectRegistration hostProjectRegistration, string hostProjectRegistrationId, st::CancellationToken cancellationToken) =>
            CreateHostProjectRegistrationAsync(parent, hostProjectRegistration, hostProjectRegistrationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a host project registration.
        /// A Google cloud project can be registered as a host project if it is not
        /// attached as a runtime project to another host project.
        /// A project can be registered as a host project only once. Subsequent
        /// register calls for the same project will fail.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for the host project.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="hostProjectRegistration">
        /// Required. The host project registration to register.
        /// </param>
        /// <param name="hostProjectRegistrationId">
        /// Required. The ID to use for the Host Project Registration, which will
        /// become the final component of the host project registration's resource
        /// name. The ID must be the same as the Google cloud project specified in the
        /// host_project_registration.gcp_project field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual HostProjectRegistration CreateHostProjectRegistration(gagr::LocationName parent, HostProjectRegistration hostProjectRegistration, string hostProjectRegistrationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateHostProjectRegistration(new CreateHostProjectRegistrationRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                HostProjectRegistrationId = gax::GaxPreconditions.CheckNotNullOrEmpty(hostProjectRegistrationId, nameof(hostProjectRegistrationId)),
                HostProjectRegistration = gax::GaxPreconditions.CheckNotNull(hostProjectRegistration, nameof(hostProjectRegistration)),
            }, callSettings);

        /// <summary>
        /// Create a host project registration.
        /// A Google cloud project can be registered as a host project if it is not
        /// attached as a runtime project to another host project.
        /// A project can be registered as a host project only once. Subsequent
        /// register calls for the same project will fail.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for the host project.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="hostProjectRegistration">
        /// Required. The host project registration to register.
        /// </param>
        /// <param name="hostProjectRegistrationId">
        /// Required. The ID to use for the Host Project Registration, which will
        /// become the final component of the host project registration's resource
        /// name. The ID must be the same as the Google cloud project specified in the
        /// host_project_registration.gcp_project field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HostProjectRegistration> CreateHostProjectRegistrationAsync(gagr::LocationName parent, HostProjectRegistration hostProjectRegistration, string hostProjectRegistrationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateHostProjectRegistrationAsync(new CreateHostProjectRegistrationRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                HostProjectRegistrationId = gax::GaxPreconditions.CheckNotNullOrEmpty(hostProjectRegistrationId, nameof(hostProjectRegistrationId)),
                HostProjectRegistration = gax::GaxPreconditions.CheckNotNull(hostProjectRegistration, nameof(hostProjectRegistration)),
            }, callSettings);

        /// <summary>
        /// Create a host project registration.
        /// A Google cloud project can be registered as a host project if it is not
        /// attached as a runtime project to another host project.
        /// A project can be registered as a host project only once. Subsequent
        /// register calls for the same project will fail.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for the host project.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="hostProjectRegistration">
        /// Required. The host project registration to register.
        /// </param>
        /// <param name="hostProjectRegistrationId">
        /// Required. The ID to use for the Host Project Registration, which will
        /// become the final component of the host project registration's resource
        /// name. The ID must be the same as the Google cloud project specified in the
        /// host_project_registration.gcp_project field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HostProjectRegistration> CreateHostProjectRegistrationAsync(gagr::LocationName parent, HostProjectRegistration hostProjectRegistration, string hostProjectRegistrationId, st::CancellationToken cancellationToken) =>
            CreateHostProjectRegistrationAsync(parent, hostProjectRegistration, hostProjectRegistrationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a host project registration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual HostProjectRegistration GetHostProjectRegistration(GetHostProjectRegistrationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a host project registration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HostProjectRegistration> GetHostProjectRegistrationAsync(GetHostProjectRegistrationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a host project registration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HostProjectRegistration> GetHostProjectRegistrationAsync(GetHostProjectRegistrationRequest request, st::CancellationToken cancellationToken) =>
            GetHostProjectRegistrationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a host project registration.
        /// </summary>
        /// <param name="name">
        /// Required. Host project registration resource name.
        /// projects/{project}/locations/{location}/hostProjectRegistrations/{host_project_registration_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual HostProjectRegistration GetHostProjectRegistration(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetHostProjectRegistration(new GetHostProjectRegistrationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a host project registration.
        /// </summary>
        /// <param name="name">
        /// Required. Host project registration resource name.
        /// projects/{project}/locations/{location}/hostProjectRegistrations/{host_project_registration_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HostProjectRegistration> GetHostProjectRegistrationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetHostProjectRegistrationAsync(new GetHostProjectRegistrationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a host project registration.
        /// </summary>
        /// <param name="name">
        /// Required. Host project registration resource name.
        /// projects/{project}/locations/{location}/hostProjectRegistrations/{host_project_registration_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HostProjectRegistration> GetHostProjectRegistrationAsync(string name, st::CancellationToken cancellationToken) =>
            GetHostProjectRegistrationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a host project registration.
        /// </summary>
        /// <param name="name">
        /// Required. Host project registration resource name.
        /// projects/{project}/locations/{location}/hostProjectRegistrations/{host_project_registration_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual HostProjectRegistration GetHostProjectRegistration(HostProjectRegistrationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetHostProjectRegistration(new GetHostProjectRegistrationRequest
            {
                HostProjectRegistrationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a host project registration.
        /// </summary>
        /// <param name="name">
        /// Required. Host project registration resource name.
        /// projects/{project}/locations/{location}/hostProjectRegistrations/{host_project_registration_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HostProjectRegistration> GetHostProjectRegistrationAsync(HostProjectRegistrationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetHostProjectRegistrationAsync(new GetHostProjectRegistrationRequest
            {
                HostProjectRegistrationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a host project registration.
        /// </summary>
        /// <param name="name">
        /// Required. Host project registration resource name.
        /// projects/{project}/locations/{location}/hostProjectRegistrations/{host_project_registration_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HostProjectRegistration> GetHostProjectRegistrationAsync(HostProjectRegistrationName name, st::CancellationToken cancellationToken) =>
            GetHostProjectRegistrationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists host project registrations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="HostProjectRegistration"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListHostProjectRegistrationsResponse, HostProjectRegistration> ListHostProjectRegistrations(ListHostProjectRegistrationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists host project registrations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="HostProjectRegistration"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListHostProjectRegistrationsResponse, HostProjectRegistration> ListHostProjectRegistrationsAsync(ListHostProjectRegistrationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists host project registrations.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of host projects.
        /// Format: `projects/*/locations/*`
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
        /// <returns>A pageable sequence of <see cref="HostProjectRegistration"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListHostProjectRegistrationsResponse, HostProjectRegistration> ListHostProjectRegistrations(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListHostProjectRegistrationsRequest request = new ListHostProjectRegistrationsRequest
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
            return ListHostProjectRegistrations(request, callSettings);
        }

        /// <summary>
        /// Lists host project registrations.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of host projects.
        /// Format: `projects/*/locations/*`
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
        /// <returns>A pageable asynchronous sequence of <see cref="HostProjectRegistration"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListHostProjectRegistrationsResponse, HostProjectRegistration> ListHostProjectRegistrationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListHostProjectRegistrationsRequest request = new ListHostProjectRegistrationsRequest
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
            return ListHostProjectRegistrationsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists host project registrations.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of host projects.
        /// Format: `projects/*/locations/*`
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
        /// <returns>A pageable sequence of <see cref="HostProjectRegistration"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListHostProjectRegistrationsResponse, HostProjectRegistration> ListHostProjectRegistrations(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListHostProjectRegistrationsRequest request = new ListHostProjectRegistrationsRequest
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
            return ListHostProjectRegistrations(request, callSettings);
        }

        /// <summary>
        /// Lists host project registrations.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of host projects.
        /// Format: `projects/*/locations/*`
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
        /// <returns>A pageable asynchronous sequence of <see cref="HostProjectRegistration"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListHostProjectRegistrationsResponse, HostProjectRegistration> ListHostProjectRegistrationsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListHostProjectRegistrationsRequest request = new ListHostProjectRegistrationsRequest
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
            return ListHostProjectRegistrationsAsync(request, callSettings);
        }
    }

    /// <summary>HostProjectRegistrationService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// This service is used for managing the host project registrations.
    /// </remarks>
    public sealed partial class HostProjectRegistrationServiceClientImpl : HostProjectRegistrationServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateHostProjectRegistrationRequest, HostProjectRegistration> _callCreateHostProjectRegistration;

        private readonly gaxgrpc::ApiCall<GetHostProjectRegistrationRequest, HostProjectRegistration> _callGetHostProjectRegistration;

        private readonly gaxgrpc::ApiCall<ListHostProjectRegistrationsRequest, ListHostProjectRegistrationsResponse> _callListHostProjectRegistrations;

        /// <summary>
        /// Constructs a client wrapper for the HostProjectRegistrationService service, with the specified gRPC client
        /// and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="HostProjectRegistrationServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public HostProjectRegistrationServiceClientImpl(HostProjectRegistrationService.HostProjectRegistrationServiceClient grpcClient, HostProjectRegistrationServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            HostProjectRegistrationServiceSettings effectiveSettings = settings ?? HostProjectRegistrationServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callCreateHostProjectRegistration = clientHelper.BuildApiCall<CreateHostProjectRegistrationRequest, HostProjectRegistration>("CreateHostProjectRegistration", grpcClient.CreateHostProjectRegistrationAsync, grpcClient.CreateHostProjectRegistration, effectiveSettings.CreateHostProjectRegistrationSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateHostProjectRegistration);
            Modify_CreateHostProjectRegistrationApiCall(ref _callCreateHostProjectRegistration);
            _callGetHostProjectRegistration = clientHelper.BuildApiCall<GetHostProjectRegistrationRequest, HostProjectRegistration>("GetHostProjectRegistration", grpcClient.GetHostProjectRegistrationAsync, grpcClient.GetHostProjectRegistration, effectiveSettings.GetHostProjectRegistrationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetHostProjectRegistration);
            Modify_GetHostProjectRegistrationApiCall(ref _callGetHostProjectRegistration);
            _callListHostProjectRegistrations = clientHelper.BuildApiCall<ListHostProjectRegistrationsRequest, ListHostProjectRegistrationsResponse>("ListHostProjectRegistrations", grpcClient.ListHostProjectRegistrationsAsync, grpcClient.ListHostProjectRegistrations, effectiveSettings.ListHostProjectRegistrationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListHostProjectRegistrations);
            Modify_ListHostProjectRegistrationsApiCall(ref _callListHostProjectRegistrations);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateHostProjectRegistrationApiCall(ref gaxgrpc::ApiCall<CreateHostProjectRegistrationRequest, HostProjectRegistration> call);

        partial void Modify_GetHostProjectRegistrationApiCall(ref gaxgrpc::ApiCall<GetHostProjectRegistrationRequest, HostProjectRegistration> call);

        partial void Modify_ListHostProjectRegistrationsApiCall(ref gaxgrpc::ApiCall<ListHostProjectRegistrationsRequest, ListHostProjectRegistrationsResponse> call);

        partial void OnConstruction(HostProjectRegistrationService.HostProjectRegistrationServiceClient grpcClient, HostProjectRegistrationServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC HostProjectRegistrationService client</summary>
        public override HostProjectRegistrationService.HostProjectRegistrationServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_CreateHostProjectRegistrationRequest(ref CreateHostProjectRegistrationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetHostProjectRegistrationRequest(ref GetHostProjectRegistrationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListHostProjectRegistrationsRequest(ref ListHostProjectRegistrationsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Create a host project registration.
        /// A Google cloud project can be registered as a host project if it is not
        /// attached as a runtime project to another host project.
        /// A project can be registered as a host project only once. Subsequent
        /// register calls for the same project will fail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override HostProjectRegistration CreateHostProjectRegistration(CreateHostProjectRegistrationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateHostProjectRegistrationRequest(ref request, ref callSettings);
            return _callCreateHostProjectRegistration.Sync(request, callSettings);
        }

        /// <summary>
        /// Create a host project registration.
        /// A Google cloud project can be registered as a host project if it is not
        /// attached as a runtime project to another host project.
        /// A project can be registered as a host project only once. Subsequent
        /// register calls for the same project will fail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<HostProjectRegistration> CreateHostProjectRegistrationAsync(CreateHostProjectRegistrationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateHostProjectRegistrationRequest(ref request, ref callSettings);
            return _callCreateHostProjectRegistration.Async(request, callSettings);
        }

        /// <summary>
        /// Get a host project registration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override HostProjectRegistration GetHostProjectRegistration(GetHostProjectRegistrationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetHostProjectRegistrationRequest(ref request, ref callSettings);
            return _callGetHostProjectRegistration.Sync(request, callSettings);
        }

        /// <summary>
        /// Get a host project registration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<HostProjectRegistration> GetHostProjectRegistrationAsync(GetHostProjectRegistrationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetHostProjectRegistrationRequest(ref request, ref callSettings);
            return _callGetHostProjectRegistration.Async(request, callSettings);
        }

        /// <summary>
        /// Lists host project registrations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="HostProjectRegistration"/> resources.</returns>
        public override gax::PagedEnumerable<ListHostProjectRegistrationsResponse, HostProjectRegistration> ListHostProjectRegistrations(ListHostProjectRegistrationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListHostProjectRegistrationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListHostProjectRegistrationsRequest, ListHostProjectRegistrationsResponse, HostProjectRegistration>(_callListHostProjectRegistrations, request, callSettings);
        }

        /// <summary>
        /// Lists host project registrations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="HostProjectRegistration"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListHostProjectRegistrationsResponse, HostProjectRegistration> ListHostProjectRegistrationsAsync(ListHostProjectRegistrationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListHostProjectRegistrationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListHostProjectRegistrationsRequest, ListHostProjectRegistrationsResponse, HostProjectRegistration>(_callListHostProjectRegistrations, request, callSettings);
        }
    }

    public partial class ListHostProjectRegistrationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListHostProjectRegistrationsResponse : gaxgrpc::IPageResponse<HostProjectRegistration>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<HostProjectRegistration> GetEnumerator() => HostProjectRegistrations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class HostProjectRegistrationService
    {
        public partial class HostProjectRegistrationServiceClient
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
