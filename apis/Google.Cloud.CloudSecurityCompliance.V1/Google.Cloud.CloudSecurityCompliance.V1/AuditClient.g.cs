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
using lro = Google.LongRunning;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.CloudSecurityCompliance.V1
{
    /// <summary>Settings for <see cref="AuditClient"/> instances.</summary>
    public sealed partial class AuditSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AuditSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AuditSettings"/>.</returns>
        public static AuditSettings GetDefault() => new AuditSettings();

        /// <summary>Constructs a new <see cref="AuditSettings"/> object with default settings.</summary>
        public AuditSettings()
        {
        }

        private AuditSettings(AuditSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GenerateFrameworkAuditScopeReportSettings = existing.GenerateFrameworkAuditScopeReportSettings;
            CreateFrameworkAuditSettings = existing.CreateFrameworkAuditSettings;
            CreateFrameworkAuditOperationsSettings = existing.CreateFrameworkAuditOperationsSettings.Clone();
            ListFrameworkAuditsSettings = existing.ListFrameworkAuditsSettings;
            GetFrameworkAuditSettings = existing.GetFrameworkAuditSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AuditSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AuditClient.GenerateFrameworkAuditScopeReport</c> and
        /// <c>AuditClient.GenerateFrameworkAuditScopeReportAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GenerateFrameworkAuditScopeReportSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AuditClient.CreateFrameworkAudit</c> and <c>AuditClient.CreateFrameworkAuditAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateFrameworkAuditSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AuditClient.CreateFrameworkAudit</c> and
        /// <c>AuditClient.CreateFrameworkAuditAsync</c>.
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
        public lro::OperationsSettings CreateFrameworkAuditOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AuditClient.ListFrameworkAudits</c> and <c>AuditClient.ListFrameworkAuditsAsync</c>.
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
        public gaxgrpc::CallSettings ListFrameworkAuditsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AuditClient.GetFrameworkAudit</c> and <c>AuditClient.GetFrameworkAuditAsync</c>.
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
        public gaxgrpc::CallSettings GetFrameworkAuditSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AuditSettings"/> object.</returns>
        public AuditSettings Clone() => new AuditSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AuditClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class AuditClientBuilder : gaxgrpc::ClientBuilderBase<AuditClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AuditSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AuditClientBuilder() : base(AuditClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AuditClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AuditClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AuditClient Build()
        {
            AuditClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AuditClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AuditClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AuditClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AuditClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AuditClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AuditClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AuditClient.ChannelPool;
    }

    /// <summary>Audit client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public abstract partial class AuditClient
    {
        /// <summary>
        /// The default endpoint for the Audit service, which is a host of "cloudsecuritycompliance.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloudsecuritycompliance.googleapis.com:443";

        /// <summary>The default Audit scopes.</summary>
        /// <remarks>
        /// The default Audit scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Audit.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AuditClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="AuditClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AuditClient"/>.</returns>
        public static stt::Task<AuditClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AuditClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AuditClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="AuditClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AuditClient"/>.</returns>
        public static AuditClient Create() => new AuditClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AuditClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AuditSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AuditClient"/>.</returns>
        internal static AuditClient Create(grpccore::CallInvoker callInvoker, AuditSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Audit.AuditClient grpcClient = new Audit.AuditClient(callInvoker);
            return new AuditClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Audit client</summary>
        public virtual Audit.AuditClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Generates an audit scope report for a framework.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateFrameworkAuditScopeReportResponse GenerateFrameworkAuditScopeReport(GenerateFrameworkAuditScopeReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates an audit scope report for a framework.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateFrameworkAuditScopeReportResponse> GenerateFrameworkAuditScopeReportAsync(GenerateFrameworkAuditScopeReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates an audit scope report for a framework.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateFrameworkAuditScopeReportResponse> GenerateFrameworkAuditScopeReportAsync(GenerateFrameworkAuditScopeReportRequest request, st::CancellationToken cancellationToken) =>
            GenerateFrameworkAuditScopeReportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates an audit scope report for a framework.
        /// </summary>
        /// <param name="scope">
        /// Required. The organization, folder or project for the audit report.
        /// 
        /// Supported formats are the following:
        /// 
        /// * `projects/{project_id}/locations/{location}`
        /// * `folders/{folder_id}/locations/{location}`
        /// * `organizations/{organization_id}/locations/{location}`
        /// </param>
        /// <param name="reportFormat">
        /// Required. The format that the scope report bytes is returned in.
        /// </param>
        /// <param name="complianceFramework">
        /// Required. The compliance framework that the scope report is generated for.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateFrameworkAuditScopeReportResponse GenerateFrameworkAuditScopeReport(string scope, GenerateFrameworkAuditScopeReportRequest.Types.Format reportFormat, string complianceFramework, gaxgrpc::CallSettings callSettings = null) =>
            GenerateFrameworkAuditScopeReport(new GenerateFrameworkAuditScopeReportRequest
            {
                Scope = gax::GaxPreconditions.CheckNotNullOrEmpty(scope, nameof(scope)),
                ReportFormat = reportFormat,
                ComplianceFramework = gax::GaxPreconditions.CheckNotNullOrEmpty(complianceFramework, nameof(complianceFramework)),
            }, callSettings);

        /// <summary>
        /// Generates an audit scope report for a framework.
        /// </summary>
        /// <param name="scope">
        /// Required. The organization, folder or project for the audit report.
        /// 
        /// Supported formats are the following:
        /// 
        /// * `projects/{project_id}/locations/{location}`
        /// * `folders/{folder_id}/locations/{location}`
        /// * `organizations/{organization_id}/locations/{location}`
        /// </param>
        /// <param name="reportFormat">
        /// Required. The format that the scope report bytes is returned in.
        /// </param>
        /// <param name="complianceFramework">
        /// Required. The compliance framework that the scope report is generated for.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateFrameworkAuditScopeReportResponse> GenerateFrameworkAuditScopeReportAsync(string scope, GenerateFrameworkAuditScopeReportRequest.Types.Format reportFormat, string complianceFramework, gaxgrpc::CallSettings callSettings = null) =>
            GenerateFrameworkAuditScopeReportAsync(new GenerateFrameworkAuditScopeReportRequest
            {
                Scope = gax::GaxPreconditions.CheckNotNullOrEmpty(scope, nameof(scope)),
                ReportFormat = reportFormat,
                ComplianceFramework = gax::GaxPreconditions.CheckNotNullOrEmpty(complianceFramework, nameof(complianceFramework)),
            }, callSettings);

        /// <summary>
        /// Generates an audit scope report for a framework.
        /// </summary>
        /// <param name="scope">
        /// Required. The organization, folder or project for the audit report.
        /// 
        /// Supported formats are the following:
        /// 
        /// * `projects/{project_id}/locations/{location}`
        /// * `folders/{folder_id}/locations/{location}`
        /// * `organizations/{organization_id}/locations/{location}`
        /// </param>
        /// <param name="reportFormat">
        /// Required. The format that the scope report bytes is returned in.
        /// </param>
        /// <param name="complianceFramework">
        /// Required. The compliance framework that the scope report is generated for.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateFrameworkAuditScopeReportResponse> GenerateFrameworkAuditScopeReportAsync(string scope, GenerateFrameworkAuditScopeReportRequest.Types.Format reportFormat, string complianceFramework, st::CancellationToken cancellationToken) =>
            GenerateFrameworkAuditScopeReportAsync(scope, reportFormat, complianceFramework, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an audit scope report for a framework.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<FrameworkAudit, OperationMetadata> CreateFrameworkAudit(CreateFrameworkAuditRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an audit scope report for a framework.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FrameworkAudit, OperationMetadata>> CreateFrameworkAuditAsync(CreateFrameworkAuditRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an audit scope report for a framework.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FrameworkAudit, OperationMetadata>> CreateFrameworkAuditAsync(CreateFrameworkAuditRequest request, st::CancellationToken cancellationToken) =>
            CreateFrameworkAuditAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateFrameworkAudit</c>.</summary>
        public virtual lro::OperationsClient CreateFrameworkAuditOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateFrameworkAudit</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<FrameworkAudit, OperationMetadata> PollOnceCreateFrameworkAudit(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<FrameworkAudit, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateFrameworkAuditOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateFrameworkAudit</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<FrameworkAudit, OperationMetadata>> PollOnceCreateFrameworkAuditAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<FrameworkAudit, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateFrameworkAuditOperationsClient, callSettings);

        /// <summary>
        /// Creates an audit scope report for a framework.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this framework audit is created.
        /// 
        /// Supported formats are the following:
        /// 
        /// * `organizations/{organization_id}/locations/{location}`
        /// * `folders/{folder_id}/locations/{location}`
        /// * `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="frameworkAudit">
        /// Required. The framework audit to create.
        /// </param>
        /// <param name="frameworkAuditId">
        /// Optional. The ID to use for the framework audit. The ID becomes the final
        /// component of the framework audit's full resource name.
        /// 
        /// The ID must be between 4-63 characters, and valid characters
        /// are `\[a-z][0-9]-\`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<FrameworkAudit, OperationMetadata> CreateFrameworkAudit(string parent, FrameworkAudit frameworkAudit, string frameworkAuditId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFrameworkAudit(new CreateFrameworkAuditRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                FrameworkAuditId = frameworkAuditId ?? "",
                FrameworkAudit = gax::GaxPreconditions.CheckNotNull(frameworkAudit, nameof(frameworkAudit)),
            }, callSettings);

        /// <summary>
        /// Creates an audit scope report for a framework.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this framework audit is created.
        /// 
        /// Supported formats are the following:
        /// 
        /// * `organizations/{organization_id}/locations/{location}`
        /// * `folders/{folder_id}/locations/{location}`
        /// * `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="frameworkAudit">
        /// Required. The framework audit to create.
        /// </param>
        /// <param name="frameworkAuditId">
        /// Optional. The ID to use for the framework audit. The ID becomes the final
        /// component of the framework audit's full resource name.
        /// 
        /// The ID must be between 4-63 characters, and valid characters
        /// are `\[a-z][0-9]-\`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FrameworkAudit, OperationMetadata>> CreateFrameworkAuditAsync(string parent, FrameworkAudit frameworkAudit, string frameworkAuditId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFrameworkAuditAsync(new CreateFrameworkAuditRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                FrameworkAuditId = frameworkAuditId ?? "",
                FrameworkAudit = gax::GaxPreconditions.CheckNotNull(frameworkAudit, nameof(frameworkAudit)),
            }, callSettings);

        /// <summary>
        /// Creates an audit scope report for a framework.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this framework audit is created.
        /// 
        /// Supported formats are the following:
        /// 
        /// * `organizations/{organization_id}/locations/{location}`
        /// * `folders/{folder_id}/locations/{location}`
        /// * `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="frameworkAudit">
        /// Required. The framework audit to create.
        /// </param>
        /// <param name="frameworkAuditId">
        /// Optional. The ID to use for the framework audit. The ID becomes the final
        /// component of the framework audit's full resource name.
        /// 
        /// The ID must be between 4-63 characters, and valid characters
        /// are `\[a-z][0-9]-\`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FrameworkAudit, OperationMetadata>> CreateFrameworkAuditAsync(string parent, FrameworkAudit frameworkAudit, string frameworkAuditId, st::CancellationToken cancellationToken) =>
            CreateFrameworkAuditAsync(parent, frameworkAudit, frameworkAuditId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an audit scope report for a framework.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this framework audit is created.
        /// 
        /// Supported formats are the following:
        /// 
        /// * `organizations/{organization_id}/locations/{location}`
        /// * `folders/{folder_id}/locations/{location}`
        /// * `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="frameworkAudit">
        /// Required. The framework audit to create.
        /// </param>
        /// <param name="frameworkAuditId">
        /// Optional. The ID to use for the framework audit. The ID becomes the final
        /// component of the framework audit's full resource name.
        /// 
        /// The ID must be between 4-63 characters, and valid characters
        /// are `\[a-z][0-9]-\`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<FrameworkAudit, OperationMetadata> CreateFrameworkAudit(gagr::LocationName parent, FrameworkAudit frameworkAudit, string frameworkAuditId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFrameworkAudit(new CreateFrameworkAuditRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                FrameworkAuditId = frameworkAuditId ?? "",
                FrameworkAudit = gax::GaxPreconditions.CheckNotNull(frameworkAudit, nameof(frameworkAudit)),
            }, callSettings);

        /// <summary>
        /// Creates an audit scope report for a framework.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this framework audit is created.
        /// 
        /// Supported formats are the following:
        /// 
        /// * `organizations/{organization_id}/locations/{location}`
        /// * `folders/{folder_id}/locations/{location}`
        /// * `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="frameworkAudit">
        /// Required. The framework audit to create.
        /// </param>
        /// <param name="frameworkAuditId">
        /// Optional. The ID to use for the framework audit. The ID becomes the final
        /// component of the framework audit's full resource name.
        /// 
        /// The ID must be between 4-63 characters, and valid characters
        /// are `\[a-z][0-9]-\`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FrameworkAudit, OperationMetadata>> CreateFrameworkAuditAsync(gagr::LocationName parent, FrameworkAudit frameworkAudit, string frameworkAuditId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFrameworkAuditAsync(new CreateFrameworkAuditRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                FrameworkAuditId = frameworkAuditId ?? "",
                FrameworkAudit = gax::GaxPreconditions.CheckNotNull(frameworkAudit, nameof(frameworkAudit)),
            }, callSettings);

        /// <summary>
        /// Creates an audit scope report for a framework.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this framework audit is created.
        /// 
        /// Supported formats are the following:
        /// 
        /// * `organizations/{organization_id}/locations/{location}`
        /// * `folders/{folder_id}/locations/{location}`
        /// * `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="frameworkAudit">
        /// Required. The framework audit to create.
        /// </param>
        /// <param name="frameworkAuditId">
        /// Optional. The ID to use for the framework audit. The ID becomes the final
        /// component of the framework audit's full resource name.
        /// 
        /// The ID must be between 4-63 characters, and valid characters
        /// are `\[a-z][0-9]-\`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FrameworkAudit, OperationMetadata>> CreateFrameworkAuditAsync(gagr::LocationName parent, FrameworkAudit frameworkAudit, string frameworkAuditId, st::CancellationToken cancellationToken) =>
            CreateFrameworkAuditAsync(parent, frameworkAudit, frameworkAuditId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an audit scope report for a framework.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this framework audit is created.
        /// 
        /// Supported formats are the following:
        /// 
        /// * `organizations/{organization_id}/locations/{location}`
        /// * `folders/{folder_id}/locations/{location}`
        /// * `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="frameworkAudit">
        /// Required. The framework audit to create.
        /// </param>
        /// <param name="frameworkAuditId">
        /// Optional. The ID to use for the framework audit. The ID becomes the final
        /// component of the framework audit's full resource name.
        /// 
        /// The ID must be between 4-63 characters, and valid characters
        /// are `\[a-z][0-9]-\`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<FrameworkAudit, OperationMetadata> CreateFrameworkAudit(OrganizationLocationName parent, FrameworkAudit frameworkAudit, string frameworkAuditId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFrameworkAudit(new CreateFrameworkAuditRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                FrameworkAuditId = frameworkAuditId ?? "",
                FrameworkAudit = gax::GaxPreconditions.CheckNotNull(frameworkAudit, nameof(frameworkAudit)),
            }, callSettings);

        /// <summary>
        /// Creates an audit scope report for a framework.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this framework audit is created.
        /// 
        /// Supported formats are the following:
        /// 
        /// * `organizations/{organization_id}/locations/{location}`
        /// * `folders/{folder_id}/locations/{location}`
        /// * `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="frameworkAudit">
        /// Required. The framework audit to create.
        /// </param>
        /// <param name="frameworkAuditId">
        /// Optional. The ID to use for the framework audit. The ID becomes the final
        /// component of the framework audit's full resource name.
        /// 
        /// The ID must be between 4-63 characters, and valid characters
        /// are `\[a-z][0-9]-\`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FrameworkAudit, OperationMetadata>> CreateFrameworkAuditAsync(OrganizationLocationName parent, FrameworkAudit frameworkAudit, string frameworkAuditId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFrameworkAuditAsync(new CreateFrameworkAuditRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                FrameworkAuditId = frameworkAuditId ?? "",
                FrameworkAudit = gax::GaxPreconditions.CheckNotNull(frameworkAudit, nameof(frameworkAudit)),
            }, callSettings);

        /// <summary>
        /// Creates an audit scope report for a framework.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this framework audit is created.
        /// 
        /// Supported formats are the following:
        /// 
        /// * `organizations/{organization_id}/locations/{location}`
        /// * `folders/{folder_id}/locations/{location}`
        /// * `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="frameworkAudit">
        /// Required. The framework audit to create.
        /// </param>
        /// <param name="frameworkAuditId">
        /// Optional. The ID to use for the framework audit. The ID becomes the final
        /// component of the framework audit's full resource name.
        /// 
        /// The ID must be between 4-63 characters, and valid characters
        /// are `\[a-z][0-9]-\`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FrameworkAudit, OperationMetadata>> CreateFrameworkAuditAsync(OrganizationLocationName parent, FrameworkAudit frameworkAudit, string frameworkAuditId, st::CancellationToken cancellationToken) =>
            CreateFrameworkAuditAsync(parent, frameworkAudit, frameworkAuditId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the framework audits for a given organization, folder, or project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FrameworkAudit"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFrameworkAuditsResponse, FrameworkAudit> ListFrameworkAudits(ListFrameworkAuditsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the framework audits for a given organization, folder, or project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FrameworkAudit"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFrameworkAuditsResponse, FrameworkAudit> ListFrameworkAuditsAsync(ListFrameworkAuditsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the framework audits for a given organization, folder, or project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where the framework audits are listed.
        /// 
        /// Supported formats are the following:
        /// 
        /// * `organizations/{organization_id}/locations/{location}`
        /// * `folders/{folder_id}/locations/{location}`
        /// * `projects/{project_id}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="FrameworkAudit"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFrameworkAuditsResponse, FrameworkAudit> ListFrameworkAudits(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFrameworkAuditsRequest request = new ListFrameworkAuditsRequest
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
            return ListFrameworkAudits(request, callSettings);
        }

        /// <summary>
        /// Lists the framework audits for a given organization, folder, or project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where the framework audits are listed.
        /// 
        /// Supported formats are the following:
        /// 
        /// * `organizations/{organization_id}/locations/{location}`
        /// * `folders/{folder_id}/locations/{location}`
        /// * `projects/{project_id}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="FrameworkAudit"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFrameworkAuditsResponse, FrameworkAudit> ListFrameworkAuditsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFrameworkAuditsRequest request = new ListFrameworkAuditsRequest
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
            return ListFrameworkAuditsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the framework audits for a given organization, folder, or project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where the framework audits are listed.
        /// 
        /// Supported formats are the following:
        /// 
        /// * `organizations/{organization_id}/locations/{location}`
        /// * `folders/{folder_id}/locations/{location}`
        /// * `projects/{project_id}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="FrameworkAudit"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFrameworkAuditsResponse, FrameworkAudit> ListFrameworkAudits(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFrameworkAuditsRequest request = new ListFrameworkAuditsRequest
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
            return ListFrameworkAudits(request, callSettings);
        }

        /// <summary>
        /// Lists the framework audits for a given organization, folder, or project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where the framework audits are listed.
        /// 
        /// Supported formats are the following:
        /// 
        /// * `organizations/{organization_id}/locations/{location}`
        /// * `folders/{folder_id}/locations/{location}`
        /// * `projects/{project_id}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="FrameworkAudit"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFrameworkAuditsResponse, FrameworkAudit> ListFrameworkAuditsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFrameworkAuditsRequest request = new ListFrameworkAuditsRequest
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
            return ListFrameworkAuditsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the framework audits for a given organization, folder, or project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where the framework audits are listed.
        /// 
        /// Supported formats are the following:
        /// 
        /// * `organizations/{organization_id}/locations/{location}`
        /// * `folders/{folder_id}/locations/{location}`
        /// * `projects/{project_id}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="FrameworkAudit"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFrameworkAuditsResponse, FrameworkAudit> ListFrameworkAudits(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFrameworkAuditsRequest request = new ListFrameworkAuditsRequest
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
            return ListFrameworkAudits(request, callSettings);
        }

        /// <summary>
        /// Lists the framework audits for a given organization, folder, or project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where the framework audits are listed.
        /// 
        /// Supported formats are the following:
        /// 
        /// * `organizations/{organization_id}/locations/{location}`
        /// * `folders/{folder_id}/locations/{location}`
        /// * `projects/{project_id}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="FrameworkAudit"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFrameworkAuditsResponse, FrameworkAudit> ListFrameworkAuditsAsync(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFrameworkAuditsRequest request = new ListFrameworkAuditsRequest
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
            return ListFrameworkAuditsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets the details for a framework audit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FrameworkAudit GetFrameworkAudit(GetFrameworkAuditRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details for a framework audit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FrameworkAudit> GetFrameworkAuditAsync(GetFrameworkAuditRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details for a framework audit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FrameworkAudit> GetFrameworkAuditAsync(GetFrameworkAuditRequest request, st::CancellationToken cancellationToken) =>
            GetFrameworkAuditAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details for a framework audit.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the framework audit to retrieve.
        /// 
        /// Supported formats are the following:
        /// 
        /// * `organizations/{organization_id}/locations/{location}/frameworkAudits/{frameworkAuditName}`
        /// * `folders/{folder_id}/locations/{location}/frameworkAudits/{frameworkAuditName}`
        /// * `projects/{project_id}/locations/{location}/frameworkAudits/{frameworkAuditName}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FrameworkAudit GetFrameworkAudit(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFrameworkAudit(new GetFrameworkAuditRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details for a framework audit.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the framework audit to retrieve.
        /// 
        /// Supported formats are the following:
        /// 
        /// * `organizations/{organization_id}/locations/{location}/frameworkAudits/{frameworkAuditName}`
        /// * `folders/{folder_id}/locations/{location}/frameworkAudits/{frameworkAuditName}`
        /// * `projects/{project_id}/locations/{location}/frameworkAudits/{frameworkAuditName}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FrameworkAudit> GetFrameworkAuditAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFrameworkAuditAsync(new GetFrameworkAuditRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details for a framework audit.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the framework audit to retrieve.
        /// 
        /// Supported formats are the following:
        /// 
        /// * `organizations/{organization_id}/locations/{location}/frameworkAudits/{frameworkAuditName}`
        /// * `folders/{folder_id}/locations/{location}/frameworkAudits/{frameworkAuditName}`
        /// * `projects/{project_id}/locations/{location}/frameworkAudits/{frameworkAuditName}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FrameworkAudit> GetFrameworkAuditAsync(string name, st::CancellationToken cancellationToken) =>
            GetFrameworkAuditAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details for a framework audit.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the framework audit to retrieve.
        /// 
        /// Supported formats are the following:
        /// 
        /// * `organizations/{organization_id}/locations/{location}/frameworkAudits/{frameworkAuditName}`
        /// * `folders/{folder_id}/locations/{location}/frameworkAudits/{frameworkAuditName}`
        /// * `projects/{project_id}/locations/{location}/frameworkAudits/{frameworkAuditName}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FrameworkAudit GetFrameworkAudit(FrameworkAuditName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFrameworkAudit(new GetFrameworkAuditRequest
            {
                FrameworkAuditName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details for a framework audit.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the framework audit to retrieve.
        /// 
        /// Supported formats are the following:
        /// 
        /// * `organizations/{organization_id}/locations/{location}/frameworkAudits/{frameworkAuditName}`
        /// * `folders/{folder_id}/locations/{location}/frameworkAudits/{frameworkAuditName}`
        /// * `projects/{project_id}/locations/{location}/frameworkAudits/{frameworkAuditName}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FrameworkAudit> GetFrameworkAuditAsync(FrameworkAuditName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFrameworkAuditAsync(new GetFrameworkAuditRequest
            {
                FrameworkAuditName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details for a framework audit.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the framework audit to retrieve.
        /// 
        /// Supported formats are the following:
        /// 
        /// * `organizations/{organization_id}/locations/{location}/frameworkAudits/{frameworkAuditName}`
        /// * `folders/{folder_id}/locations/{location}/frameworkAudits/{frameworkAuditName}`
        /// * `projects/{project_id}/locations/{location}/frameworkAudits/{frameworkAuditName}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FrameworkAudit> GetFrameworkAuditAsync(FrameworkAuditName name, st::CancellationToken cancellationToken) =>
            GetFrameworkAuditAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Audit client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public sealed partial class AuditClientImpl : AuditClient
    {
        private readonly gaxgrpc::ApiCall<GenerateFrameworkAuditScopeReportRequest, GenerateFrameworkAuditScopeReportResponse> _callGenerateFrameworkAuditScopeReport;

        private readonly gaxgrpc::ApiCall<CreateFrameworkAuditRequest, lro::Operation> _callCreateFrameworkAudit;

        private readonly gaxgrpc::ApiCall<ListFrameworkAuditsRequest, ListFrameworkAuditsResponse> _callListFrameworkAudits;

        private readonly gaxgrpc::ApiCall<GetFrameworkAuditRequest, FrameworkAudit> _callGetFrameworkAudit;

        /// <summary>
        /// Constructs a client wrapper for the Audit service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AuditSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AuditClientImpl(Audit.AuditClient grpcClient, AuditSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AuditSettings effectiveSettings = settings ?? AuditSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateFrameworkAuditOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateFrameworkAuditOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callGenerateFrameworkAuditScopeReport = clientHelper.BuildApiCall<GenerateFrameworkAuditScopeReportRequest, GenerateFrameworkAuditScopeReportResponse>("GenerateFrameworkAuditScopeReport", grpcClient.GenerateFrameworkAuditScopeReportAsync, grpcClient.GenerateFrameworkAuditScopeReport, effectiveSettings.GenerateFrameworkAuditScopeReportSettings).WithGoogleRequestParam("scope", request => request.Scope);
            Modify_ApiCall(ref _callGenerateFrameworkAuditScopeReport);
            Modify_GenerateFrameworkAuditScopeReportApiCall(ref _callGenerateFrameworkAuditScopeReport);
            _callCreateFrameworkAudit = clientHelper.BuildApiCall<CreateFrameworkAuditRequest, lro::Operation>("CreateFrameworkAudit", grpcClient.CreateFrameworkAuditAsync, grpcClient.CreateFrameworkAudit, effectiveSettings.CreateFrameworkAuditSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateFrameworkAudit);
            Modify_CreateFrameworkAuditApiCall(ref _callCreateFrameworkAudit);
            _callListFrameworkAudits = clientHelper.BuildApiCall<ListFrameworkAuditsRequest, ListFrameworkAuditsResponse>("ListFrameworkAudits", grpcClient.ListFrameworkAuditsAsync, grpcClient.ListFrameworkAudits, effectiveSettings.ListFrameworkAuditsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListFrameworkAudits);
            Modify_ListFrameworkAuditsApiCall(ref _callListFrameworkAudits);
            _callGetFrameworkAudit = clientHelper.BuildApiCall<GetFrameworkAuditRequest, FrameworkAudit>("GetFrameworkAudit", grpcClient.GetFrameworkAuditAsync, grpcClient.GetFrameworkAudit, effectiveSettings.GetFrameworkAuditSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetFrameworkAudit);
            Modify_GetFrameworkAuditApiCall(ref _callGetFrameworkAudit);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GenerateFrameworkAuditScopeReportApiCall(ref gaxgrpc::ApiCall<GenerateFrameworkAuditScopeReportRequest, GenerateFrameworkAuditScopeReportResponse> call);

        partial void Modify_CreateFrameworkAuditApiCall(ref gaxgrpc::ApiCall<CreateFrameworkAuditRequest, lro::Operation> call);

        partial void Modify_ListFrameworkAuditsApiCall(ref gaxgrpc::ApiCall<ListFrameworkAuditsRequest, ListFrameworkAuditsResponse> call);

        partial void Modify_GetFrameworkAuditApiCall(ref gaxgrpc::ApiCall<GetFrameworkAuditRequest, FrameworkAudit> call);

        partial void OnConstruction(Audit.AuditClient grpcClient, AuditSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Audit client</summary>
        public override Audit.AuditClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_GenerateFrameworkAuditScopeReportRequest(ref GenerateFrameworkAuditScopeReportRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateFrameworkAuditRequest(ref CreateFrameworkAuditRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListFrameworkAuditsRequest(ref ListFrameworkAuditsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetFrameworkAuditRequest(ref GetFrameworkAuditRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Generates an audit scope report for a framework.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateFrameworkAuditScopeReportResponse GenerateFrameworkAuditScopeReport(GenerateFrameworkAuditScopeReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateFrameworkAuditScopeReportRequest(ref request, ref callSettings);
            return _callGenerateFrameworkAuditScopeReport.Sync(request, callSettings);
        }

        /// <summary>
        /// Generates an audit scope report for a framework.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateFrameworkAuditScopeReportResponse> GenerateFrameworkAuditScopeReportAsync(GenerateFrameworkAuditScopeReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateFrameworkAuditScopeReportRequest(ref request, ref callSettings);
            return _callGenerateFrameworkAuditScopeReport.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateFrameworkAudit</c>.</summary>
        public override lro::OperationsClient CreateFrameworkAuditOperationsClient { get; }

        /// <summary>
        /// Creates an audit scope report for a framework.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<FrameworkAudit, OperationMetadata> CreateFrameworkAudit(CreateFrameworkAuditRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFrameworkAuditRequest(ref request, ref callSettings);
            return new lro::Operation<FrameworkAudit, OperationMetadata>(_callCreateFrameworkAudit.Sync(request, callSettings), CreateFrameworkAuditOperationsClient);
        }

        /// <summary>
        /// Creates an audit scope report for a framework.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<FrameworkAudit, OperationMetadata>> CreateFrameworkAuditAsync(CreateFrameworkAuditRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFrameworkAuditRequest(ref request, ref callSettings);
            return new lro::Operation<FrameworkAudit, OperationMetadata>(await _callCreateFrameworkAudit.Async(request, callSettings).ConfigureAwait(false), CreateFrameworkAuditOperationsClient);
        }

        /// <summary>
        /// Lists the framework audits for a given organization, folder, or project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FrameworkAudit"/> resources.</returns>
        public override gax::PagedEnumerable<ListFrameworkAuditsResponse, FrameworkAudit> ListFrameworkAudits(ListFrameworkAuditsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFrameworkAuditsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListFrameworkAuditsRequest, ListFrameworkAuditsResponse, FrameworkAudit>(_callListFrameworkAudits, request, callSettings);
        }

        /// <summary>
        /// Lists the framework audits for a given organization, folder, or project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FrameworkAudit"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListFrameworkAuditsResponse, FrameworkAudit> ListFrameworkAuditsAsync(ListFrameworkAuditsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFrameworkAuditsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListFrameworkAuditsRequest, ListFrameworkAuditsResponse, FrameworkAudit>(_callListFrameworkAudits, request, callSettings);
        }

        /// <summary>
        /// Gets the details for a framework audit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FrameworkAudit GetFrameworkAudit(GetFrameworkAuditRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFrameworkAuditRequest(ref request, ref callSettings);
            return _callGetFrameworkAudit.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the details for a framework audit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FrameworkAudit> GetFrameworkAuditAsync(GetFrameworkAuditRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFrameworkAuditRequest(ref request, ref callSettings);
            return _callGetFrameworkAudit.Async(request, callSettings);
        }
    }

    public partial class ListFrameworkAuditsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListFrameworkAuditsResponse : gaxgrpc::IPageResponse<FrameworkAudit>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<FrameworkAudit> GetEnumerator() => FrameworkAudits.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Audit
    {
        public partial class AuditClient
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

    public static partial class Audit
    {
        public partial class AuditClient
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
