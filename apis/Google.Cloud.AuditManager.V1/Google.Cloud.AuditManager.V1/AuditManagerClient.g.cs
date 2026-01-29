// Copyright 2026 Google LLC
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
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.AuditManager.V1
{
    /// <summary>Settings for <see cref="AuditManagerClient"/> instances.</summary>
    public sealed partial class AuditManagerSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AuditManagerSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AuditManagerSettings"/>.</returns>
        public static AuditManagerSettings GetDefault() => new AuditManagerSettings();

        /// <summary>Constructs a new <see cref="AuditManagerSettings"/> object with default settings.</summary>
        public AuditManagerSettings()
        {
        }

        private AuditManagerSettings(AuditManagerSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            EnrollResourceSettings = existing.EnrollResourceSettings;
            GenerateAuditScopeReportSettings = existing.GenerateAuditScopeReportSettings;
            GenerateAuditReportSettings = existing.GenerateAuditReportSettings;
            GenerateAuditReportOperationsSettings = existing.GenerateAuditReportOperationsSettings.Clone();
            ListAuditReportsSettings = existing.ListAuditReportsSettings;
            GetAuditReportSettings = existing.GetAuditReportSettings;
            GetResourceEnrollmentStatusSettings = existing.GetResourceEnrollmentStatusSettings;
            ListResourceEnrollmentStatusesSettings = existing.ListResourceEnrollmentStatusesSettings;
            ListControlsSettings = existing.ListControlsSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AuditManagerSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AuditManagerClient.EnrollResource</c> and <c>AuditManagerClient.EnrollResourceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings EnrollResourceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AuditManagerClient.GenerateAuditScopeReport</c> and <c>AuditManagerClient.GenerateAuditScopeReportAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GenerateAuditScopeReportSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AuditManagerClient.GenerateAuditReport</c> and <c>AuditManagerClient.GenerateAuditReportAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GenerateAuditReportSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AuditManagerClient.GenerateAuditReport</c> and
        /// <c>AuditManagerClient.GenerateAuditReportAsync</c>.
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
        public lro::OperationsSettings GenerateAuditReportOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AuditManagerClient.ListAuditReports</c> and <c>AuditManagerClient.ListAuditReportsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAuditReportsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AuditManagerClient.GetAuditReport</c> and <c>AuditManagerClient.GetAuditReportAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAuditReportSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AuditManagerClient.GetResourceEnrollmentStatus</c> and
        /// <c>AuditManagerClient.GetResourceEnrollmentStatusAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetResourceEnrollmentStatusSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AuditManagerClient.ListResourceEnrollmentStatuses</c> and
        /// <c>AuditManagerClient.ListResourceEnrollmentStatusesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListResourceEnrollmentStatusesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AuditManagerClient.ListControls</c> and <c>AuditManagerClient.ListControlsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListControlsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AuditManagerSettings"/> object.</returns>
        public AuditManagerSettings Clone() => new AuditManagerSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AuditManagerClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class AuditManagerClientBuilder : gaxgrpc::ClientBuilderBase<AuditManagerClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AuditManagerSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AuditManagerClientBuilder() : base(AuditManagerClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AuditManagerClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AuditManagerClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AuditManagerClient Build()
        {
            AuditManagerClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AuditManagerClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AuditManagerClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AuditManagerClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AuditManagerClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AuditManagerClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AuditManagerClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AuditManagerClient.ChannelPool;
    }

    /// <summary>AuditManager client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public abstract partial class AuditManagerClient
    {
        /// <summary>
        /// The default endpoint for the AuditManager service, which is a host of "auditmanager.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "auditmanager.googleapis.com:443";

        /// <summary>The default AuditManager scopes.</summary>
        /// <remarks>
        /// The default AuditManager scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AuditManager.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AuditManagerClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AuditManagerClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AuditManagerClient"/>.</returns>
        public static stt::Task<AuditManagerClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AuditManagerClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AuditManagerClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AuditManagerClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AuditManagerClient"/>.</returns>
        public static AuditManagerClient Create() => new AuditManagerClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AuditManagerClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AuditManagerSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AuditManagerClient"/>.</returns>
        internal static AuditManagerClient Create(grpccore::CallInvoker callInvoker, AuditManagerSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AuditManager.AuditManagerClient grpcClient = new AuditManager.AuditManagerClient(callInvoker);
            return new AuditManagerClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AuditManager client</summary>
        public virtual AuditManager.AuditManagerClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Enrolls the customer resource(folder/project/organization) to the audit
        /// manager service by creating the audit managers Service Agent in customers
        /// workload and granting required permissions to the Service Agent. Please
        /// note that if enrollment request is made on the already enrolled workload
        /// then enrollment is executed overriding the existing set of destinations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Enrollment EnrollResource(EnrollResourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enrolls the customer resource(folder/project/organization) to the audit
        /// manager service by creating the audit managers Service Agent in customers
        /// workload and granting required permissions to the Service Agent. Please
        /// note that if enrollment request is made on the already enrolled workload
        /// then enrollment is executed overriding the existing set of destinations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Enrollment> EnrollResourceAsync(EnrollResourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enrolls the customer resource(folder/project/organization) to the audit
        /// manager service by creating the audit managers Service Agent in customers
        /// workload and granting required permissions to the Service Agent. Please
        /// note that if enrollment request is made on the already enrolled workload
        /// then enrollment is executed overriding the existing set of destinations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Enrollment> EnrollResourceAsync(EnrollResourceRequest request, st::CancellationToken cancellationToken) =>
            EnrollResourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Enrolls the customer resource(folder/project/organization) to the audit
        /// manager service by creating the audit managers Service Agent in customers
        /// workload and granting required permissions to the Service Agent. Please
        /// note that if enrollment request is made on the already enrolled workload
        /// then enrollment is executed overriding the existing set of destinations.
        /// </summary>
        /// <param name="scope">
        /// Required. The resource to be enrolled to the audit manager. Scope format
        /// should be resource_type/resource_identifier Eg:
        /// projects/{project}/locations/{location},
        /// folders/{folder}/locations/{location}
        /// organizations/{organization}/locations/{location}
        /// </param>
        /// <param name="destinations">
        /// Required. List of destination among which customer can choose to upload
        /// their reports during the audit process. While enrolling at a
        /// organization/folder level, customer can choose Cloud storage bucket in any
        /// project. If the audit is triggered at project level using the service agent
        /// at organization/folder level, all the destination options associated with
        /// respective organization/folder level service agent will be available to
        /// auditing projects.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Enrollment EnrollResource(string scope, scg::IEnumerable<EnrollResourceRequest.Types.EligibleDestination> destinations, gaxgrpc::CallSettings callSettings = null) =>
            EnrollResource(new EnrollResourceRequest
            {
                Scope = gax::GaxPreconditions.CheckNotNullOrEmpty(scope, nameof(scope)),
                Destinations =
                {
                    gax::GaxPreconditions.CheckNotNull(destinations, nameof(destinations)),
                },
            }, callSettings);

        /// <summary>
        /// Enrolls the customer resource(folder/project/organization) to the audit
        /// manager service by creating the audit managers Service Agent in customers
        /// workload and granting required permissions to the Service Agent. Please
        /// note that if enrollment request is made on the already enrolled workload
        /// then enrollment is executed overriding the existing set of destinations.
        /// </summary>
        /// <param name="scope">
        /// Required. The resource to be enrolled to the audit manager. Scope format
        /// should be resource_type/resource_identifier Eg:
        /// projects/{project}/locations/{location},
        /// folders/{folder}/locations/{location}
        /// organizations/{organization}/locations/{location}
        /// </param>
        /// <param name="destinations">
        /// Required. List of destination among which customer can choose to upload
        /// their reports during the audit process. While enrolling at a
        /// organization/folder level, customer can choose Cloud storage bucket in any
        /// project. If the audit is triggered at project level using the service agent
        /// at organization/folder level, all the destination options associated with
        /// respective organization/folder level service agent will be available to
        /// auditing projects.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Enrollment> EnrollResourceAsync(string scope, scg::IEnumerable<EnrollResourceRequest.Types.EligibleDestination> destinations, gaxgrpc::CallSettings callSettings = null) =>
            EnrollResourceAsync(new EnrollResourceRequest
            {
                Scope = gax::GaxPreconditions.CheckNotNullOrEmpty(scope, nameof(scope)),
                Destinations =
                {
                    gax::GaxPreconditions.CheckNotNull(destinations, nameof(destinations)),
                },
            }, callSettings);

        /// <summary>
        /// Enrolls the customer resource(folder/project/organization) to the audit
        /// manager service by creating the audit managers Service Agent in customers
        /// workload and granting required permissions to the Service Agent. Please
        /// note that if enrollment request is made on the already enrolled workload
        /// then enrollment is executed overriding the existing set of destinations.
        /// </summary>
        /// <param name="scope">
        /// Required. The resource to be enrolled to the audit manager. Scope format
        /// should be resource_type/resource_identifier Eg:
        /// projects/{project}/locations/{location},
        /// folders/{folder}/locations/{location}
        /// organizations/{organization}/locations/{location}
        /// </param>
        /// <param name="destinations">
        /// Required. List of destination among which customer can choose to upload
        /// their reports during the audit process. While enrolling at a
        /// organization/folder level, customer can choose Cloud storage bucket in any
        /// project. If the audit is triggered at project level using the service agent
        /// at organization/folder level, all the destination options associated with
        /// respective organization/folder level service agent will be available to
        /// auditing projects.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Enrollment> EnrollResourceAsync(string scope, scg::IEnumerable<EnrollResourceRequest.Types.EligibleDestination> destinations, st::CancellationToken cancellationToken) =>
            EnrollResourceAsync(scope, destinations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates a demo report highlighting different responsibilities
        /// (Google/Customer/ shared) required to be fulfilled for the customer's
        /// workload to be compliant with the given standard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AuditScopeReport GenerateAuditScopeReport(GenerateAuditScopeReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates a demo report highlighting different responsibilities
        /// (Google/Customer/ shared) required to be fulfilled for the customer's
        /// workload to be compliant with the given standard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AuditScopeReport> GenerateAuditScopeReportAsync(GenerateAuditScopeReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates a demo report highlighting different responsibilities
        /// (Google/Customer/ shared) required to be fulfilled for the customer's
        /// workload to be compliant with the given standard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AuditScopeReport> GenerateAuditScopeReportAsync(GenerateAuditScopeReportRequest request, st::CancellationToken cancellationToken) =>
            GenerateAuditScopeReportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates a demo report highlighting different responsibilities
        /// (Google/Customer/ shared) required to be fulfilled for the customer's
        /// workload to be compliant with the given standard.
        /// </summary>
        /// <param name="scope">
        /// Required. Scope for which the AuditScopeReport is required. Must be of
        /// format resource_type/resource_identifier Eg:
        /// projects/{project}/locations/{location},
        /// folders/{folder}/locations/{location}
        /// </param>
        /// <param name="complianceStandard">
        /// Required. Compliance Standard against which the Scope Report must be
        /// generated. Eg: FEDRAMP_MODERATE
        /// </param>
        /// <param name="reportFormat">
        /// Required. The format in which the Scope report bytes should be returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AuditScopeReport GenerateAuditScopeReport(string scope, string complianceStandard, GenerateAuditScopeReportRequest.Types.AuditScopeReportFormat reportFormat, gaxgrpc::CallSettings callSettings = null) =>
            GenerateAuditScopeReport(new GenerateAuditScopeReportRequest
            {
                Scope = gax::GaxPreconditions.CheckNotNullOrEmpty(scope, nameof(scope)),
                ComplianceStandard = gax::GaxPreconditions.CheckNotNullOrEmpty(complianceStandard, nameof(complianceStandard)),
                ReportFormat = reportFormat,
            }, callSettings);

        /// <summary>
        /// Generates a demo report highlighting different responsibilities
        /// (Google/Customer/ shared) required to be fulfilled for the customer's
        /// workload to be compliant with the given standard.
        /// </summary>
        /// <param name="scope">
        /// Required. Scope for which the AuditScopeReport is required. Must be of
        /// format resource_type/resource_identifier Eg:
        /// projects/{project}/locations/{location},
        /// folders/{folder}/locations/{location}
        /// </param>
        /// <param name="complianceStandard">
        /// Required. Compliance Standard against which the Scope Report must be
        /// generated. Eg: FEDRAMP_MODERATE
        /// </param>
        /// <param name="reportFormat">
        /// Required. The format in which the Scope report bytes should be returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AuditScopeReport> GenerateAuditScopeReportAsync(string scope, string complianceStandard, GenerateAuditScopeReportRequest.Types.AuditScopeReportFormat reportFormat, gaxgrpc::CallSettings callSettings = null) =>
            GenerateAuditScopeReportAsync(new GenerateAuditScopeReportRequest
            {
                Scope = gax::GaxPreconditions.CheckNotNullOrEmpty(scope, nameof(scope)),
                ComplianceStandard = gax::GaxPreconditions.CheckNotNullOrEmpty(complianceStandard, nameof(complianceStandard)),
                ReportFormat = reportFormat,
            }, callSettings);

        /// <summary>
        /// Generates a demo report highlighting different responsibilities
        /// (Google/Customer/ shared) required to be fulfilled for the customer's
        /// workload to be compliant with the given standard.
        /// </summary>
        /// <param name="scope">
        /// Required. Scope for which the AuditScopeReport is required. Must be of
        /// format resource_type/resource_identifier Eg:
        /// projects/{project}/locations/{location},
        /// folders/{folder}/locations/{location}
        /// </param>
        /// <param name="complianceStandard">
        /// Required. Compliance Standard against which the Scope Report must be
        /// generated. Eg: FEDRAMP_MODERATE
        /// </param>
        /// <param name="reportFormat">
        /// Required. The format in which the Scope report bytes should be returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AuditScopeReport> GenerateAuditScopeReportAsync(string scope, string complianceStandard, GenerateAuditScopeReportRequest.Types.AuditScopeReportFormat reportFormat, st::CancellationToken cancellationToken) =>
            GenerateAuditScopeReportAsync(scope, complianceStandard, reportFormat, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Register the Audit Report generation requests and returns the OperationId
        /// using which the customer can track the report generation progress.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AuditReport, OperationMetadata> GenerateAuditReport(GenerateAuditReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Register the Audit Report generation requests and returns the OperationId
        /// using which the customer can track the report generation progress.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AuditReport, OperationMetadata>> GenerateAuditReportAsync(GenerateAuditReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Register the Audit Report generation requests and returns the OperationId
        /// using which the customer can track the report generation progress.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AuditReport, OperationMetadata>> GenerateAuditReportAsync(GenerateAuditReportRequest request, st::CancellationToken cancellationToken) =>
            GenerateAuditReportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>GenerateAuditReport</c>.</summary>
        public virtual lro::OperationsClient GenerateAuditReportOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>GenerateAuditReport</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AuditReport, OperationMetadata> PollOnceGenerateAuditReport(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AuditReport, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), GenerateAuditReportOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>GenerateAuditReport</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AuditReport, OperationMetadata>> PollOnceGenerateAuditReportAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AuditReport, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), GenerateAuditReportOperationsClient, callSettings);

        /// <summary>
        /// Register the Audit Report generation requests and returns the OperationId
        /// using which the customer can track the report generation progress.
        /// </summary>
        /// <param name="scope">
        /// Required. Scope for which the AuditScopeReport is required. Must be of
        /// format resource_type/resource_identifier Eg:
        /// projects/{project}/locations/{location},
        /// folders/{folder}/locations/{location}
        /// </param>
        /// <param name="gcsUri">
        /// Destination Cloud storage bucket where report and evidence must be
        /// uploaded. The Cloud storage bucket provided here must be selected among
        /// the buckets entered during the enrollment process.
        /// </param>
        /// <param name="complianceStandard">
        /// Required. Compliance Standard against which the Scope Report must be
        /// generated. Eg: FEDRAMP_MODERATE
        /// </param>
        /// <param name="reportFormat">
        /// Required. The format in which the audit report should be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AuditReport, OperationMetadata> GenerateAuditReport(string scope, string gcsUri, string complianceStandard, GenerateAuditReportRequest.Types.AuditReportFormat reportFormat, gaxgrpc::CallSettings callSettings = null) =>
            GenerateAuditReport(new GenerateAuditReportRequest
            {
                GcsUri = gcsUri ?? "",
                Scope = gax::GaxPreconditions.CheckNotNullOrEmpty(scope, nameof(scope)),
                ComplianceStandard = gax::GaxPreconditions.CheckNotNullOrEmpty(complianceStandard, nameof(complianceStandard)),
                ReportFormat = reportFormat,
            }, callSettings);

        /// <summary>
        /// Register the Audit Report generation requests and returns the OperationId
        /// using which the customer can track the report generation progress.
        /// </summary>
        /// <param name="scope">
        /// Required. Scope for which the AuditScopeReport is required. Must be of
        /// format resource_type/resource_identifier Eg:
        /// projects/{project}/locations/{location},
        /// folders/{folder}/locations/{location}
        /// </param>
        /// <param name="gcsUri">
        /// Destination Cloud storage bucket where report and evidence must be
        /// uploaded. The Cloud storage bucket provided here must be selected among
        /// the buckets entered during the enrollment process.
        /// </param>
        /// <param name="complianceStandard">
        /// Required. Compliance Standard against which the Scope Report must be
        /// generated. Eg: FEDRAMP_MODERATE
        /// </param>
        /// <param name="reportFormat">
        /// Required. The format in which the audit report should be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AuditReport, OperationMetadata>> GenerateAuditReportAsync(string scope, string gcsUri, string complianceStandard, GenerateAuditReportRequest.Types.AuditReportFormat reportFormat, gaxgrpc::CallSettings callSettings = null) =>
            GenerateAuditReportAsync(new GenerateAuditReportRequest
            {
                GcsUri = gcsUri ?? "",
                Scope = gax::GaxPreconditions.CheckNotNullOrEmpty(scope, nameof(scope)),
                ComplianceStandard = gax::GaxPreconditions.CheckNotNullOrEmpty(complianceStandard, nameof(complianceStandard)),
                ReportFormat = reportFormat,
            }, callSettings);

        /// <summary>
        /// Register the Audit Report generation requests and returns the OperationId
        /// using which the customer can track the report generation progress.
        /// </summary>
        /// <param name="scope">
        /// Required. Scope for which the AuditScopeReport is required. Must be of
        /// format resource_type/resource_identifier Eg:
        /// projects/{project}/locations/{location},
        /// folders/{folder}/locations/{location}
        /// </param>
        /// <param name="gcsUri">
        /// Destination Cloud storage bucket where report and evidence must be
        /// uploaded. The Cloud storage bucket provided here must be selected among
        /// the buckets entered during the enrollment process.
        /// </param>
        /// <param name="complianceStandard">
        /// Required. Compliance Standard against which the Scope Report must be
        /// generated. Eg: FEDRAMP_MODERATE
        /// </param>
        /// <param name="reportFormat">
        /// Required. The format in which the audit report should be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AuditReport, OperationMetadata>> GenerateAuditReportAsync(string scope, string gcsUri, string complianceStandard, GenerateAuditReportRequest.Types.AuditReportFormat reportFormat, st::CancellationToken cancellationToken) =>
            GenerateAuditReportAsync(scope, gcsUri, complianceStandard, reportFormat, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists audit reports in the selected parent scope
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AuditReport"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAuditReportsResponse, AuditReport> ListAuditReports(ListAuditReportsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists audit reports in the selected parent scope
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AuditReport"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAuditReportsResponse, AuditReport> ListAuditReportsAsync(ListAuditReportsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists audit reports in the selected parent scope
        /// </summary>
        /// <param name="parent">
        /// Required. The parent scope for which to list the reports.
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
        /// <returns>A pageable sequence of <see cref="AuditReport"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAuditReportsResponse, AuditReport> ListAuditReports(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAuditReportsRequest request = new ListAuditReportsRequest
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
            return ListAuditReports(request, callSettings);
        }

        /// <summary>
        /// Lists audit reports in the selected parent scope
        /// </summary>
        /// <param name="parent">
        /// Required. The parent scope for which to list the reports.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AuditReport"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAuditReportsResponse, AuditReport> ListAuditReportsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAuditReportsRequest request = new ListAuditReportsRequest
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
            return ListAuditReportsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists audit reports in the selected parent scope
        /// </summary>
        /// <param name="parent">
        /// Required. The parent scope for which to list the reports.
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
        /// <returns>A pageable sequence of <see cref="AuditReport"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAuditReportsResponse, AuditReport> ListAuditReports(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAuditReportsRequest request = new ListAuditReportsRequest
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
            return ListAuditReports(request, callSettings);
        }

        /// <summary>
        /// Lists audit reports in the selected parent scope
        /// </summary>
        /// <param name="parent">
        /// Required. The parent scope for which to list the reports.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AuditReport"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAuditReportsResponse, AuditReport> ListAuditReportsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAuditReportsRequest request = new ListAuditReportsRequest
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
            return ListAuditReportsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists audit reports in the selected parent scope
        /// </summary>
        /// <param name="parent">
        /// Required. The parent scope for which to list the reports.
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
        /// <returns>A pageable sequence of <see cref="AuditReport"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAuditReportsResponse, AuditReport> ListAuditReports(FolderLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAuditReportsRequest request = new ListAuditReportsRequest
            {
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAuditReports(request, callSettings);
        }

        /// <summary>
        /// Lists audit reports in the selected parent scope
        /// </summary>
        /// <param name="parent">
        /// Required. The parent scope for which to list the reports.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AuditReport"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAuditReportsResponse, AuditReport> ListAuditReportsAsync(FolderLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAuditReportsRequest request = new ListAuditReportsRequest
            {
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAuditReportsAsync(request, callSettings);
        }

        /// <summary>
        /// Get the overall audit report
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AuditReport GetAuditReport(GetAuditReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get the overall audit report
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AuditReport> GetAuditReportAsync(GetAuditReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get the overall audit report
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AuditReport> GetAuditReportAsync(GetAuditReportRequest request, st::CancellationToken cancellationToken) =>
            GetAuditReportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the overall audit report
        /// </summary>
        /// <param name="name">
        /// Required. Format
        /// projects/{project}/locations/{location}/auditReports/{audit_report},
        /// folders/{folder}/locations/{location}/auditReports/{audit_report}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AuditReport GetAuditReport(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAuditReport(new GetAuditReportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the overall audit report
        /// </summary>
        /// <param name="name">
        /// Required. Format
        /// projects/{project}/locations/{location}/auditReports/{audit_report},
        /// folders/{folder}/locations/{location}/auditReports/{audit_report}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AuditReport> GetAuditReportAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAuditReportAsync(new GetAuditReportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the overall audit report
        /// </summary>
        /// <param name="name">
        /// Required. Format
        /// projects/{project}/locations/{location}/auditReports/{audit_report},
        /// folders/{folder}/locations/{location}/auditReports/{audit_report}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AuditReport> GetAuditReportAsync(string name, st::CancellationToken cancellationToken) =>
            GetAuditReportAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the overall audit report
        /// </summary>
        /// <param name="name">
        /// Required. Format
        /// projects/{project}/locations/{location}/auditReports/{audit_report},
        /// folders/{folder}/locations/{location}/auditReports/{audit_report}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AuditReport GetAuditReport(AuditReportName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAuditReport(new GetAuditReportRequest
            {
                AuditReportName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the overall audit report
        /// </summary>
        /// <param name="name">
        /// Required. Format
        /// projects/{project}/locations/{location}/auditReports/{audit_report},
        /// folders/{folder}/locations/{location}/auditReports/{audit_report}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AuditReport> GetAuditReportAsync(AuditReportName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAuditReportAsync(new GetAuditReportRequest
            {
                AuditReportName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the overall audit report
        /// </summary>
        /// <param name="name">
        /// Required. Format
        /// projects/{project}/locations/{location}/auditReports/{audit_report},
        /// folders/{folder}/locations/{location}/auditReports/{audit_report}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AuditReport> GetAuditReportAsync(AuditReportName name, st::CancellationToken cancellationToken) =>
            GetAuditReportAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a resource along with its enrollment status.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ResourceEnrollmentStatus GetResourceEnrollmentStatus(GetResourceEnrollmentStatusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a resource along with its enrollment status.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResourceEnrollmentStatus> GetResourceEnrollmentStatusAsync(GetResourceEnrollmentStatusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a resource along with its enrollment status.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResourceEnrollmentStatus> GetResourceEnrollmentStatusAsync(GetResourceEnrollmentStatusRequest request, st::CancellationToken cancellationToken) =>
            GetResourceEnrollmentStatusAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a resource along with its enrollment status.
        /// </summary>
        /// <param name="name">
        /// Required. Format
        /// folders/{folder}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status},
        /// projects/{project}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status},
        /// organizations/{organization}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ResourceEnrollmentStatus GetResourceEnrollmentStatus(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetResourceEnrollmentStatus(new GetResourceEnrollmentStatusRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a resource along with its enrollment status.
        /// </summary>
        /// <param name="name">
        /// Required. Format
        /// folders/{folder}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status},
        /// projects/{project}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status},
        /// organizations/{organization}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResourceEnrollmentStatus> GetResourceEnrollmentStatusAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetResourceEnrollmentStatusAsync(new GetResourceEnrollmentStatusRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a resource along with its enrollment status.
        /// </summary>
        /// <param name="name">
        /// Required. Format
        /// folders/{folder}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status},
        /// projects/{project}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status},
        /// organizations/{organization}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResourceEnrollmentStatus> GetResourceEnrollmentStatusAsync(string name, st::CancellationToken cancellationToken) =>
            GetResourceEnrollmentStatusAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a resource along with its enrollment status.
        /// </summary>
        /// <param name="name">
        /// Required. Format
        /// folders/{folder}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status},
        /// projects/{project}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status},
        /// organizations/{organization}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ResourceEnrollmentStatus GetResourceEnrollmentStatus(ResourceEnrollmentStatusName name, gaxgrpc::CallSettings callSettings = null) =>
            GetResourceEnrollmentStatus(new GetResourceEnrollmentStatusRequest
            {
                ResourceEnrollmentStatusName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a resource along with its enrollment status.
        /// </summary>
        /// <param name="name">
        /// Required. Format
        /// folders/{folder}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status},
        /// projects/{project}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status},
        /// organizations/{organization}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResourceEnrollmentStatus> GetResourceEnrollmentStatusAsync(ResourceEnrollmentStatusName name, gaxgrpc::CallSettings callSettings = null) =>
            GetResourceEnrollmentStatusAsync(new GetResourceEnrollmentStatusRequest
            {
                ResourceEnrollmentStatusName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a resource along with its enrollment status.
        /// </summary>
        /// <param name="name">
        /// Required. Format
        /// folders/{folder}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status},
        /// projects/{project}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status},
        /// organizations/{organization}/locations/{location}/resourceEnrollmentStatuses/{resource_enrollment_status}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResourceEnrollmentStatus> GetResourceEnrollmentStatusAsync(ResourceEnrollmentStatusName name, st::CancellationToken cancellationToken) =>
            GetResourceEnrollmentStatusAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches all resources under the parent along with their enrollment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ResourceEnrollmentStatus"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListResourceEnrollmentStatusesResponse, ResourceEnrollmentStatus> ListResourceEnrollmentStatuses(ListResourceEnrollmentStatusesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches all resources under the parent along with their enrollment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ResourceEnrollmentStatus"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListResourceEnrollmentStatusesResponse, ResourceEnrollmentStatus> ListResourceEnrollmentStatusesAsync(ListResourceEnrollmentStatusesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches all resources under the parent along with their enrollment.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent scope for which the list of resources with enrollments
        /// are required.
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
        /// <returns>A pageable sequence of <see cref="ResourceEnrollmentStatus"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListResourceEnrollmentStatusesResponse, ResourceEnrollmentStatus> ListResourceEnrollmentStatuses(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListResourceEnrollmentStatusesRequest request = new ListResourceEnrollmentStatusesRequest
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
            return ListResourceEnrollmentStatuses(request, callSettings);
        }

        /// <summary>
        /// Fetches all resources under the parent along with their enrollment.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent scope for which the list of resources with enrollments
        /// are required.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ResourceEnrollmentStatus"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListResourceEnrollmentStatusesResponse, ResourceEnrollmentStatus> ListResourceEnrollmentStatusesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListResourceEnrollmentStatusesRequest request = new ListResourceEnrollmentStatusesRequest
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
            return ListResourceEnrollmentStatusesAsync(request, callSettings);
        }

        /// <summary>
        /// Fetches all resources under the parent along with their enrollment.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent scope for which the list of resources with enrollments
        /// are required.
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
        /// <returns>A pageable sequence of <see cref="ResourceEnrollmentStatus"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListResourceEnrollmentStatusesResponse, ResourceEnrollmentStatus> ListResourceEnrollmentStatuses(EnrollmentStatusScopeName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListResourceEnrollmentStatusesRequest request = new ListResourceEnrollmentStatusesRequest
            {
                ParentAsEnrollmentStatusScopeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListResourceEnrollmentStatuses(request, callSettings);
        }

        /// <summary>
        /// Fetches all resources under the parent along with their enrollment.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent scope for which the list of resources with enrollments
        /// are required.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ResourceEnrollmentStatus"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListResourceEnrollmentStatusesResponse, ResourceEnrollmentStatus> ListResourceEnrollmentStatusesAsync(EnrollmentStatusScopeName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListResourceEnrollmentStatusesRequest request = new ListResourceEnrollmentStatusesRequest
            {
                ParentAsEnrollmentStatusScopeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListResourceEnrollmentStatusesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets controls needed to be implemented to be compliant to a standard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Control"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListControlsResponse, Control> ListControls(ListControlsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets controls needed to be implemented to be compliant to a standard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Control"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListControlsResponse, Control> ListControlsAsync(ListControlsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets controls needed to be implemented to be compliant to a standard.
        /// </summary>
        /// <param name="parent">
        /// Required. Format
        /// projects/{project}/locations/{location}/standards/{standard},
        /// folders/{folder}/locations/{location}/standards/{standard}
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
        /// <returns>A pageable sequence of <see cref="Control"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListControlsResponse, Control> ListControls(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListControlsRequest request = new ListControlsRequest
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
            return ListControls(request, callSettings);
        }

        /// <summary>
        /// Gets controls needed to be implemented to be compliant to a standard.
        /// </summary>
        /// <param name="parent">
        /// Required. Format
        /// projects/{project}/locations/{location}/standards/{standard},
        /// folders/{folder}/locations/{location}/standards/{standard}
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
        /// <returns>A pageable asynchronous sequence of <see cref="Control"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListControlsResponse, Control> ListControlsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListControlsRequest request = new ListControlsRequest
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
            return ListControlsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets controls needed to be implemented to be compliant to a standard.
        /// </summary>
        /// <param name="parent">
        /// Required. Format
        /// projects/{project}/locations/{location}/standards/{standard},
        /// folders/{folder}/locations/{location}/standards/{standard}
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
        /// <returns>A pageable sequence of <see cref="Control"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListControlsResponse, Control> ListControls(StandardName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListControlsRequest request = new ListControlsRequest
            {
                ParentAsStandardName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListControls(request, callSettings);
        }

        /// <summary>
        /// Gets controls needed to be implemented to be compliant to a standard.
        /// </summary>
        /// <param name="parent">
        /// Required. Format
        /// projects/{project}/locations/{location}/standards/{standard},
        /// folders/{folder}/locations/{location}/standards/{standard}
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
        /// <returns>A pageable asynchronous sequence of <see cref="Control"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListControlsResponse, Control> ListControlsAsync(StandardName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListControlsRequest request = new ListControlsRequest
            {
                ParentAsStandardName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListControlsAsync(request, callSettings);
        }
    }

    /// <summary>AuditManager client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public sealed partial class AuditManagerClientImpl : AuditManagerClient
    {
        private readonly gaxgrpc::ApiCall<EnrollResourceRequest, Enrollment> _callEnrollResource;

        private readonly gaxgrpc::ApiCall<GenerateAuditScopeReportRequest, AuditScopeReport> _callGenerateAuditScopeReport;

        private readonly gaxgrpc::ApiCall<GenerateAuditReportRequest, lro::Operation> _callGenerateAuditReport;

        private readonly gaxgrpc::ApiCall<ListAuditReportsRequest, ListAuditReportsResponse> _callListAuditReports;

        private readonly gaxgrpc::ApiCall<GetAuditReportRequest, AuditReport> _callGetAuditReport;

        private readonly gaxgrpc::ApiCall<GetResourceEnrollmentStatusRequest, ResourceEnrollmentStatus> _callGetResourceEnrollmentStatus;

        private readonly gaxgrpc::ApiCall<ListResourceEnrollmentStatusesRequest, ListResourceEnrollmentStatusesResponse> _callListResourceEnrollmentStatuses;

        private readonly gaxgrpc::ApiCall<ListControlsRequest, ListControlsResponse> _callListControls;

        /// <summary>
        /// Constructs a client wrapper for the AuditManager service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AuditManagerSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AuditManagerClientImpl(AuditManager.AuditManagerClient grpcClient, AuditManagerSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AuditManagerSettings effectiveSettings = settings ?? AuditManagerSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            GenerateAuditReportOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.GenerateAuditReportOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callEnrollResource = clientHelper.BuildApiCall<EnrollResourceRequest, Enrollment>("EnrollResource", grpcClient.EnrollResourceAsync, grpcClient.EnrollResource, effectiveSettings.EnrollResourceSettings).WithGoogleRequestParam("scope", request => request.Scope);
            Modify_ApiCall(ref _callEnrollResource);
            Modify_EnrollResourceApiCall(ref _callEnrollResource);
            _callGenerateAuditScopeReport = clientHelper.BuildApiCall<GenerateAuditScopeReportRequest, AuditScopeReport>("GenerateAuditScopeReport", grpcClient.GenerateAuditScopeReportAsync, grpcClient.GenerateAuditScopeReport, effectiveSettings.GenerateAuditScopeReportSettings).WithGoogleRequestParam("scope", request => request.Scope);
            Modify_ApiCall(ref _callGenerateAuditScopeReport);
            Modify_GenerateAuditScopeReportApiCall(ref _callGenerateAuditScopeReport);
            _callGenerateAuditReport = clientHelper.BuildApiCall<GenerateAuditReportRequest, lro::Operation>("GenerateAuditReport", grpcClient.GenerateAuditReportAsync, grpcClient.GenerateAuditReport, effectiveSettings.GenerateAuditReportSettings).WithGoogleRequestParam("scope", request => request.Scope);
            Modify_ApiCall(ref _callGenerateAuditReport);
            Modify_GenerateAuditReportApiCall(ref _callGenerateAuditReport);
            _callListAuditReports = clientHelper.BuildApiCall<ListAuditReportsRequest, ListAuditReportsResponse>("ListAuditReports", grpcClient.ListAuditReportsAsync, grpcClient.ListAuditReports, effectiveSettings.ListAuditReportsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAuditReports);
            Modify_ListAuditReportsApiCall(ref _callListAuditReports);
            _callGetAuditReport = clientHelper.BuildApiCall<GetAuditReportRequest, AuditReport>("GetAuditReport", grpcClient.GetAuditReportAsync, grpcClient.GetAuditReport, effectiveSettings.GetAuditReportSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAuditReport);
            Modify_GetAuditReportApiCall(ref _callGetAuditReport);
            _callGetResourceEnrollmentStatus = clientHelper.BuildApiCall<GetResourceEnrollmentStatusRequest, ResourceEnrollmentStatus>("GetResourceEnrollmentStatus", grpcClient.GetResourceEnrollmentStatusAsync, grpcClient.GetResourceEnrollmentStatus, effectiveSettings.GetResourceEnrollmentStatusSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetResourceEnrollmentStatus);
            Modify_GetResourceEnrollmentStatusApiCall(ref _callGetResourceEnrollmentStatus);
            _callListResourceEnrollmentStatuses = clientHelper.BuildApiCall<ListResourceEnrollmentStatusesRequest, ListResourceEnrollmentStatusesResponse>("ListResourceEnrollmentStatuses", grpcClient.ListResourceEnrollmentStatusesAsync, grpcClient.ListResourceEnrollmentStatuses, effectiveSettings.ListResourceEnrollmentStatusesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListResourceEnrollmentStatuses);
            Modify_ListResourceEnrollmentStatusesApiCall(ref _callListResourceEnrollmentStatuses);
            _callListControls = clientHelper.BuildApiCall<ListControlsRequest, ListControlsResponse>("ListControls", grpcClient.ListControlsAsync, grpcClient.ListControls, effectiveSettings.ListControlsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListControls);
            Modify_ListControlsApiCall(ref _callListControls);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_EnrollResourceApiCall(ref gaxgrpc::ApiCall<EnrollResourceRequest, Enrollment> call);

        partial void Modify_GenerateAuditScopeReportApiCall(ref gaxgrpc::ApiCall<GenerateAuditScopeReportRequest, AuditScopeReport> call);

        partial void Modify_GenerateAuditReportApiCall(ref gaxgrpc::ApiCall<GenerateAuditReportRequest, lro::Operation> call);

        partial void Modify_ListAuditReportsApiCall(ref gaxgrpc::ApiCall<ListAuditReportsRequest, ListAuditReportsResponse> call);

        partial void Modify_GetAuditReportApiCall(ref gaxgrpc::ApiCall<GetAuditReportRequest, AuditReport> call);

        partial void Modify_GetResourceEnrollmentStatusApiCall(ref gaxgrpc::ApiCall<GetResourceEnrollmentStatusRequest, ResourceEnrollmentStatus> call);

        partial void Modify_ListResourceEnrollmentStatusesApiCall(ref gaxgrpc::ApiCall<ListResourceEnrollmentStatusesRequest, ListResourceEnrollmentStatusesResponse> call);

        partial void Modify_ListControlsApiCall(ref gaxgrpc::ApiCall<ListControlsRequest, ListControlsResponse> call);

        partial void OnConstruction(AuditManager.AuditManagerClient grpcClient, AuditManagerSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AuditManager client</summary>
        public override AuditManager.AuditManagerClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_EnrollResourceRequest(ref EnrollResourceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateAuditScopeReportRequest(ref GenerateAuditScopeReportRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateAuditReportRequest(ref GenerateAuditReportRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAuditReportsRequest(ref ListAuditReportsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAuditReportRequest(ref GetAuditReportRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetResourceEnrollmentStatusRequest(ref GetResourceEnrollmentStatusRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListResourceEnrollmentStatusesRequest(ref ListResourceEnrollmentStatusesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListControlsRequest(ref ListControlsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Enrolls the customer resource(folder/project/organization) to the audit
        /// manager service by creating the audit managers Service Agent in customers
        /// workload and granting required permissions to the Service Agent. Please
        /// note that if enrollment request is made on the already enrolled workload
        /// then enrollment is executed overriding the existing set of destinations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Enrollment EnrollResource(EnrollResourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EnrollResourceRequest(ref request, ref callSettings);
            return _callEnrollResource.Sync(request, callSettings);
        }

        /// <summary>
        /// Enrolls the customer resource(folder/project/organization) to the audit
        /// manager service by creating the audit managers Service Agent in customers
        /// workload and granting required permissions to the Service Agent. Please
        /// note that if enrollment request is made on the already enrolled workload
        /// then enrollment is executed overriding the existing set of destinations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Enrollment> EnrollResourceAsync(EnrollResourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EnrollResourceRequest(ref request, ref callSettings);
            return _callEnrollResource.Async(request, callSettings);
        }

        /// <summary>
        /// Generates a demo report highlighting different responsibilities
        /// (Google/Customer/ shared) required to be fulfilled for the customer's
        /// workload to be compliant with the given standard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AuditScopeReport GenerateAuditScopeReport(GenerateAuditScopeReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateAuditScopeReportRequest(ref request, ref callSettings);
            return _callGenerateAuditScopeReport.Sync(request, callSettings);
        }

        /// <summary>
        /// Generates a demo report highlighting different responsibilities
        /// (Google/Customer/ shared) required to be fulfilled for the customer's
        /// workload to be compliant with the given standard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AuditScopeReport> GenerateAuditScopeReportAsync(GenerateAuditScopeReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateAuditScopeReportRequest(ref request, ref callSettings);
            return _callGenerateAuditScopeReport.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>GenerateAuditReport</c>.</summary>
        public override lro::OperationsClient GenerateAuditReportOperationsClient { get; }

        /// <summary>
        /// Register the Audit Report generation requests and returns the OperationId
        /// using which the customer can track the report generation progress.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AuditReport, OperationMetadata> GenerateAuditReport(GenerateAuditReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateAuditReportRequest(ref request, ref callSettings);
            return new lro::Operation<AuditReport, OperationMetadata>(_callGenerateAuditReport.Sync(request, callSettings), GenerateAuditReportOperationsClient);
        }

        /// <summary>
        /// Register the Audit Report generation requests and returns the OperationId
        /// using which the customer can track the report generation progress.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AuditReport, OperationMetadata>> GenerateAuditReportAsync(GenerateAuditReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateAuditReportRequest(ref request, ref callSettings);
            return new lro::Operation<AuditReport, OperationMetadata>(await _callGenerateAuditReport.Async(request, callSettings).ConfigureAwait(false), GenerateAuditReportOperationsClient);
        }

        /// <summary>
        /// Lists audit reports in the selected parent scope
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AuditReport"/> resources.</returns>
        public override gax::PagedEnumerable<ListAuditReportsResponse, AuditReport> ListAuditReports(ListAuditReportsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAuditReportsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAuditReportsRequest, ListAuditReportsResponse, AuditReport>(_callListAuditReports, request, callSettings);
        }

        /// <summary>
        /// Lists audit reports in the selected parent scope
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AuditReport"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAuditReportsResponse, AuditReport> ListAuditReportsAsync(ListAuditReportsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAuditReportsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAuditReportsRequest, ListAuditReportsResponse, AuditReport>(_callListAuditReports, request, callSettings);
        }

        /// <summary>
        /// Get the overall audit report
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AuditReport GetAuditReport(GetAuditReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAuditReportRequest(ref request, ref callSettings);
            return _callGetAuditReport.Sync(request, callSettings);
        }

        /// <summary>
        /// Get the overall audit report
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AuditReport> GetAuditReportAsync(GetAuditReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAuditReportRequest(ref request, ref callSettings);
            return _callGetAuditReport.Async(request, callSettings);
        }

        /// <summary>
        /// Get a resource along with its enrollment status.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ResourceEnrollmentStatus GetResourceEnrollmentStatus(GetResourceEnrollmentStatusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetResourceEnrollmentStatusRequest(ref request, ref callSettings);
            return _callGetResourceEnrollmentStatus.Sync(request, callSettings);
        }

        /// <summary>
        /// Get a resource along with its enrollment status.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ResourceEnrollmentStatus> GetResourceEnrollmentStatusAsync(GetResourceEnrollmentStatusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetResourceEnrollmentStatusRequest(ref request, ref callSettings);
            return _callGetResourceEnrollmentStatus.Async(request, callSettings);
        }

        /// <summary>
        /// Fetches all resources under the parent along with their enrollment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ResourceEnrollmentStatus"/> resources.</returns>
        public override gax::PagedEnumerable<ListResourceEnrollmentStatusesResponse, ResourceEnrollmentStatus> ListResourceEnrollmentStatuses(ListResourceEnrollmentStatusesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListResourceEnrollmentStatusesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListResourceEnrollmentStatusesRequest, ListResourceEnrollmentStatusesResponse, ResourceEnrollmentStatus>(_callListResourceEnrollmentStatuses, request, callSettings);
        }

        /// <summary>
        /// Fetches all resources under the parent along with their enrollment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ResourceEnrollmentStatus"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListResourceEnrollmentStatusesResponse, ResourceEnrollmentStatus> ListResourceEnrollmentStatusesAsync(ListResourceEnrollmentStatusesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListResourceEnrollmentStatusesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListResourceEnrollmentStatusesRequest, ListResourceEnrollmentStatusesResponse, ResourceEnrollmentStatus>(_callListResourceEnrollmentStatuses, request, callSettings);
        }

        /// <summary>
        /// Gets controls needed to be implemented to be compliant to a standard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Control"/> resources.</returns>
        public override gax::PagedEnumerable<ListControlsResponse, Control> ListControls(ListControlsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListControlsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListControlsRequest, ListControlsResponse, Control>(_callListControls, request, callSettings);
        }

        /// <summary>
        /// Gets controls needed to be implemented to be compliant to a standard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Control"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListControlsResponse, Control> ListControlsAsync(ListControlsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListControlsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListControlsRequest, ListControlsResponse, Control>(_callListControls, request, callSettings);
        }
    }

    public partial class ListAuditReportsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListResourceEnrollmentStatusesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListControlsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAuditReportsResponse : gaxgrpc::IPageResponse<AuditReport>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AuditReport> GetEnumerator() => AuditReports.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListResourceEnrollmentStatusesResponse : gaxgrpc::IPageResponse<ResourceEnrollmentStatus>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ResourceEnrollmentStatus> GetEnumerator() => ResourceEnrollmentStatuses.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListControlsResponse : gaxgrpc::IPageResponse<Control>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Control> GetEnumerator() => Controls.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class AuditManager
    {
        public partial class AuditManagerClient
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

    public static partial class AuditManager
    {
        public partial class AuditManagerClient
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
