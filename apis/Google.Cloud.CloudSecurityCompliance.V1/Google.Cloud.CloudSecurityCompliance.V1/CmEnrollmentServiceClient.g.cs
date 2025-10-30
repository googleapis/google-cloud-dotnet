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
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.CloudSecurityCompliance.V1
{
    /// <summary>Settings for <see cref="CmEnrollmentServiceClient"/> instances.</summary>
    public sealed partial class CmEnrollmentServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CmEnrollmentServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CmEnrollmentServiceSettings"/>.</returns>
        public static CmEnrollmentServiceSettings GetDefault() => new CmEnrollmentServiceSettings();

        /// <summary>Constructs a new <see cref="CmEnrollmentServiceSettings"/> object with default settings.</summary>
        public CmEnrollmentServiceSettings()
        {
        }

        private CmEnrollmentServiceSettings(CmEnrollmentServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            UpdateCmEnrollmentSettings = existing.UpdateCmEnrollmentSettings;
            CalculateEffectiveCmEnrollmentSettings = existing.CalculateEffectiveCmEnrollmentSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CmEnrollmentServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CmEnrollmentServiceClient.UpdateCmEnrollment</c> and <c>CmEnrollmentServiceClient.UpdateCmEnrollmentAsync</c>
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
        public gaxgrpc::CallSettings UpdateCmEnrollmentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CmEnrollmentServiceClient.CalculateEffectiveCmEnrollment</c> and
        /// <c>CmEnrollmentServiceClient.CalculateEffectiveCmEnrollmentAsync</c>.
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
        public gaxgrpc::CallSettings CalculateEffectiveCmEnrollmentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CmEnrollmentServiceSettings"/> object.</returns>
        public CmEnrollmentServiceSettings Clone() => new CmEnrollmentServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CmEnrollmentServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class CmEnrollmentServiceClientBuilder : gaxgrpc::ClientBuilderBase<CmEnrollmentServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CmEnrollmentServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CmEnrollmentServiceClientBuilder() : base(CmEnrollmentServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CmEnrollmentServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CmEnrollmentServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CmEnrollmentServiceClient Build()
        {
            CmEnrollmentServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CmEnrollmentServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CmEnrollmentServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CmEnrollmentServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CmEnrollmentServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CmEnrollmentServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CmEnrollmentServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CmEnrollmentServiceClient.ChannelPool;
    }

    /// <summary>CmEnrollmentService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service describing CmEnrollment related RPCs for
    /// complianceManager.
    /// </remarks>
    public abstract partial class CmEnrollmentServiceClient
    {
        /// <summary>
        /// The default endpoint for the CmEnrollmentService service, which is a host of
        /// "cloudsecuritycompliance.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloudsecuritycompliance.googleapis.com:443";

        /// <summary>The default CmEnrollmentService scopes.</summary>
        /// <remarks>
        /// The default CmEnrollmentService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CmEnrollmentService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CmEnrollmentServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="CmEnrollmentServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CmEnrollmentServiceClient"/>.</returns>
        public static stt::Task<CmEnrollmentServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CmEnrollmentServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CmEnrollmentServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="CmEnrollmentServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CmEnrollmentServiceClient"/>.</returns>
        public static CmEnrollmentServiceClient Create() => new CmEnrollmentServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CmEnrollmentServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CmEnrollmentServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CmEnrollmentServiceClient"/>.</returns>
        internal static CmEnrollmentServiceClient Create(grpccore::CallInvoker callInvoker, CmEnrollmentServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CmEnrollmentService.CmEnrollmentServiceClient grpcClient = new CmEnrollmentService.CmEnrollmentServiceClient(callInvoker);
            return new CmEnrollmentServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CmEnrollmentService client</summary>
        public virtual CmEnrollmentService.CmEnrollmentServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the Compliance Manager enrollment for a resource to facilitate
        /// an audit.
        /// Use this method to enroll a resource in Compliance Manager or to
        /// create or update feature-specific configurations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CmEnrollment UpdateCmEnrollment(UpdateCmEnrollmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the Compliance Manager enrollment for a resource to facilitate
        /// an audit.
        /// Use this method to enroll a resource in Compliance Manager or to
        /// create or update feature-specific configurations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CmEnrollment> UpdateCmEnrollmentAsync(UpdateCmEnrollmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the Compliance Manager enrollment for a resource to facilitate
        /// an audit.
        /// Use this method to enroll a resource in Compliance Manager or to
        /// create or update feature-specific configurations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CmEnrollment> UpdateCmEnrollmentAsync(UpdateCmEnrollmentRequest request, st::CancellationToken cancellationToken) =>
            UpdateCmEnrollmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the Compliance Manager enrollment for a resource to facilitate
        /// an audit.
        /// Use this method to enroll a resource in Compliance Manager or to
        /// create or update feature-specific configurations.
        /// </summary>
        /// <param name="cmEnrollment">
        /// Required. The Compliance Manager enrollment to update.
        /// The `name` field is used to identify the settings that you want to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields that you want to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CmEnrollment UpdateCmEnrollment(CmEnrollment cmEnrollment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCmEnrollment(new UpdateCmEnrollmentRequest
            {
                CmEnrollment = gax::GaxPreconditions.CheckNotNull(cmEnrollment, nameof(cmEnrollment)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the Compliance Manager enrollment for a resource to facilitate
        /// an audit.
        /// Use this method to enroll a resource in Compliance Manager or to
        /// create or update feature-specific configurations.
        /// </summary>
        /// <param name="cmEnrollment">
        /// Required. The Compliance Manager enrollment to update.
        /// The `name` field is used to identify the settings that you want to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields that you want to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CmEnrollment> UpdateCmEnrollmentAsync(CmEnrollment cmEnrollment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCmEnrollmentAsync(new UpdateCmEnrollmentRequest
            {
                CmEnrollment = gax::GaxPreconditions.CheckNotNull(cmEnrollment, nameof(cmEnrollment)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the Compliance Manager enrollment for a resource to facilitate
        /// an audit.
        /// Use this method to enroll a resource in Compliance Manager or to
        /// create or update feature-specific configurations.
        /// </summary>
        /// <param name="cmEnrollment">
        /// Required. The Compliance Manager enrollment to update.
        /// The `name` field is used to identify the settings that you want to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields that you want to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CmEnrollment> UpdateCmEnrollmentAsync(CmEnrollment cmEnrollment, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateCmEnrollmentAsync(cmEnrollment, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Calculates the effective Compliance Manager enrollment for a resource.
        /// An effective enrollment is either a direct enrollment of a
        /// resource (if it exists), or an enrollment of the closest parent of a
        /// resource that's enrolled in Compliance Manager.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CalculateEffectiveCmEnrollmentResponse CalculateEffectiveCmEnrollment(CalculateEffectiveCmEnrollmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Calculates the effective Compliance Manager enrollment for a resource.
        /// An effective enrollment is either a direct enrollment of a
        /// resource (if it exists), or an enrollment of the closest parent of a
        /// resource that's enrolled in Compliance Manager.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CalculateEffectiveCmEnrollmentResponse> CalculateEffectiveCmEnrollmentAsync(CalculateEffectiveCmEnrollmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Calculates the effective Compliance Manager enrollment for a resource.
        /// An effective enrollment is either a direct enrollment of a
        /// resource (if it exists), or an enrollment of the closest parent of a
        /// resource that's enrolled in Compliance Manager.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CalculateEffectiveCmEnrollmentResponse> CalculateEffectiveCmEnrollmentAsync(CalculateEffectiveCmEnrollmentRequest request, st::CancellationToken cancellationToken) =>
            CalculateEffectiveCmEnrollmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Calculates the effective Compliance Manager enrollment for a resource.
        /// An effective enrollment is either a direct enrollment of a
        /// resource (if it exists), or an enrollment of the closest parent of a
        /// resource that's enrolled in Compliance Manager.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Compliance Manager enrollment to calculate.
        /// 
        /// Supported formats are the following:
        /// 
        /// * `organizations/{organization_id}/locations/{location}/cmEnrollment`
        /// * `folders/{folder_id}/locations/{location}/cmEnrollment`
        /// * `projects/{project_id}/locations/{location}/cmEnrollment`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CalculateEffectiveCmEnrollmentResponse CalculateEffectiveCmEnrollment(string name, gaxgrpc::CallSettings callSettings = null) =>
            CalculateEffectiveCmEnrollment(new CalculateEffectiveCmEnrollmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Calculates the effective Compliance Manager enrollment for a resource.
        /// An effective enrollment is either a direct enrollment of a
        /// resource (if it exists), or an enrollment of the closest parent of a
        /// resource that's enrolled in Compliance Manager.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Compliance Manager enrollment to calculate.
        /// 
        /// Supported formats are the following:
        /// 
        /// * `organizations/{organization_id}/locations/{location}/cmEnrollment`
        /// * `folders/{folder_id}/locations/{location}/cmEnrollment`
        /// * `projects/{project_id}/locations/{location}/cmEnrollment`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CalculateEffectiveCmEnrollmentResponse> CalculateEffectiveCmEnrollmentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            CalculateEffectiveCmEnrollmentAsync(new CalculateEffectiveCmEnrollmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Calculates the effective Compliance Manager enrollment for a resource.
        /// An effective enrollment is either a direct enrollment of a
        /// resource (if it exists), or an enrollment of the closest parent of a
        /// resource that's enrolled in Compliance Manager.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Compliance Manager enrollment to calculate.
        /// 
        /// Supported formats are the following:
        /// 
        /// * `organizations/{organization_id}/locations/{location}/cmEnrollment`
        /// * `folders/{folder_id}/locations/{location}/cmEnrollment`
        /// * `projects/{project_id}/locations/{location}/cmEnrollment`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CalculateEffectiveCmEnrollmentResponse> CalculateEffectiveCmEnrollmentAsync(string name, st::CancellationToken cancellationToken) =>
            CalculateEffectiveCmEnrollmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Calculates the effective Compliance Manager enrollment for a resource.
        /// An effective enrollment is either a direct enrollment of a
        /// resource (if it exists), or an enrollment of the closest parent of a
        /// resource that's enrolled in Compliance Manager.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Compliance Manager enrollment to calculate.
        /// 
        /// Supported formats are the following:
        /// 
        /// * `organizations/{organization_id}/locations/{location}/cmEnrollment`
        /// * `folders/{folder_id}/locations/{location}/cmEnrollment`
        /// * `projects/{project_id}/locations/{location}/cmEnrollment`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CalculateEffectiveCmEnrollmentResponse CalculateEffectiveCmEnrollment(CmEnrollmentName name, gaxgrpc::CallSettings callSettings = null) =>
            CalculateEffectiveCmEnrollment(new CalculateEffectiveCmEnrollmentRequest
            {
                CmEnrollmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Calculates the effective Compliance Manager enrollment for a resource.
        /// An effective enrollment is either a direct enrollment of a
        /// resource (if it exists), or an enrollment of the closest parent of a
        /// resource that's enrolled in Compliance Manager.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Compliance Manager enrollment to calculate.
        /// 
        /// Supported formats are the following:
        /// 
        /// * `organizations/{organization_id}/locations/{location}/cmEnrollment`
        /// * `folders/{folder_id}/locations/{location}/cmEnrollment`
        /// * `projects/{project_id}/locations/{location}/cmEnrollment`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CalculateEffectiveCmEnrollmentResponse> CalculateEffectiveCmEnrollmentAsync(CmEnrollmentName name, gaxgrpc::CallSettings callSettings = null) =>
            CalculateEffectiveCmEnrollmentAsync(new CalculateEffectiveCmEnrollmentRequest
            {
                CmEnrollmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Calculates the effective Compliance Manager enrollment for a resource.
        /// An effective enrollment is either a direct enrollment of a
        /// resource (if it exists), or an enrollment of the closest parent of a
        /// resource that's enrolled in Compliance Manager.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Compliance Manager enrollment to calculate.
        /// 
        /// Supported formats are the following:
        /// 
        /// * `organizations/{organization_id}/locations/{location}/cmEnrollment`
        /// * `folders/{folder_id}/locations/{location}/cmEnrollment`
        /// * `projects/{project_id}/locations/{location}/cmEnrollment`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CalculateEffectiveCmEnrollmentResponse> CalculateEffectiveCmEnrollmentAsync(CmEnrollmentName name, st::CancellationToken cancellationToken) =>
            CalculateEffectiveCmEnrollmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CmEnrollmentService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service describing CmEnrollment related RPCs for
    /// complianceManager.
    /// </remarks>
    public sealed partial class CmEnrollmentServiceClientImpl : CmEnrollmentServiceClient
    {
        private readonly gaxgrpc::ApiCall<UpdateCmEnrollmentRequest, CmEnrollment> _callUpdateCmEnrollment;

        private readonly gaxgrpc::ApiCall<CalculateEffectiveCmEnrollmentRequest, CalculateEffectiveCmEnrollmentResponse> _callCalculateEffectiveCmEnrollment;

        /// <summary>
        /// Constructs a client wrapper for the CmEnrollmentService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CmEnrollmentServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CmEnrollmentServiceClientImpl(CmEnrollmentService.CmEnrollmentServiceClient grpcClient, CmEnrollmentServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CmEnrollmentServiceSettings effectiveSettings = settings ?? CmEnrollmentServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callUpdateCmEnrollment = clientHelper.BuildApiCall<UpdateCmEnrollmentRequest, CmEnrollment>("UpdateCmEnrollment", grpcClient.UpdateCmEnrollmentAsync, grpcClient.UpdateCmEnrollment, effectiveSettings.UpdateCmEnrollmentSettings).WithGoogleRequestParam("cm_enrollment.name", request => request.CmEnrollment?.Name);
            Modify_ApiCall(ref _callUpdateCmEnrollment);
            Modify_UpdateCmEnrollmentApiCall(ref _callUpdateCmEnrollment);
            _callCalculateEffectiveCmEnrollment = clientHelper.BuildApiCall<CalculateEffectiveCmEnrollmentRequest, CalculateEffectiveCmEnrollmentResponse>("CalculateEffectiveCmEnrollment", grpcClient.CalculateEffectiveCmEnrollmentAsync, grpcClient.CalculateEffectiveCmEnrollment, effectiveSettings.CalculateEffectiveCmEnrollmentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCalculateEffectiveCmEnrollment);
            Modify_CalculateEffectiveCmEnrollmentApiCall(ref _callCalculateEffectiveCmEnrollment);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_UpdateCmEnrollmentApiCall(ref gaxgrpc::ApiCall<UpdateCmEnrollmentRequest, CmEnrollment> call);

        partial void Modify_CalculateEffectiveCmEnrollmentApiCall(ref gaxgrpc::ApiCall<CalculateEffectiveCmEnrollmentRequest, CalculateEffectiveCmEnrollmentResponse> call);

        partial void OnConstruction(CmEnrollmentService.CmEnrollmentServiceClient grpcClient, CmEnrollmentServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CmEnrollmentService client</summary>
        public override CmEnrollmentService.CmEnrollmentServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_UpdateCmEnrollmentRequest(ref UpdateCmEnrollmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CalculateEffectiveCmEnrollmentRequest(ref CalculateEffectiveCmEnrollmentRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Updates the Compliance Manager enrollment for a resource to facilitate
        /// an audit.
        /// Use this method to enroll a resource in Compliance Manager or to
        /// create or update feature-specific configurations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CmEnrollment UpdateCmEnrollment(UpdateCmEnrollmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCmEnrollmentRequest(ref request, ref callSettings);
            return _callUpdateCmEnrollment.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the Compliance Manager enrollment for a resource to facilitate
        /// an audit.
        /// Use this method to enroll a resource in Compliance Manager or to
        /// create or update feature-specific configurations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CmEnrollment> UpdateCmEnrollmentAsync(UpdateCmEnrollmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCmEnrollmentRequest(ref request, ref callSettings);
            return _callUpdateCmEnrollment.Async(request, callSettings);
        }

        /// <summary>
        /// Calculates the effective Compliance Manager enrollment for a resource.
        /// An effective enrollment is either a direct enrollment of a
        /// resource (if it exists), or an enrollment of the closest parent of a
        /// resource that's enrolled in Compliance Manager.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CalculateEffectiveCmEnrollmentResponse CalculateEffectiveCmEnrollment(CalculateEffectiveCmEnrollmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CalculateEffectiveCmEnrollmentRequest(ref request, ref callSettings);
            return _callCalculateEffectiveCmEnrollment.Sync(request, callSettings);
        }

        /// <summary>
        /// Calculates the effective Compliance Manager enrollment for a resource.
        /// An effective enrollment is either a direct enrollment of a
        /// resource (if it exists), or an enrollment of the closest parent of a
        /// resource that's enrolled in Compliance Manager.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CalculateEffectiveCmEnrollmentResponse> CalculateEffectiveCmEnrollmentAsync(CalculateEffectiveCmEnrollmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CalculateEffectiveCmEnrollmentRequest(ref request, ref callSettings);
            return _callCalculateEffectiveCmEnrollment.Async(request, callSettings);
        }
    }

    public static partial class CmEnrollmentService
    {
        public partial class CmEnrollmentServiceClient
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
