// Copyright 2022 Google LLC
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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gagr = Google.Api.Gax.ResourceNames;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.RecaptchaEnterprise.V1
{
    /// <summary>Settings for <see cref="RecaptchaEnterpriseServiceClient"/> instances.</summary>
    public sealed partial class RecaptchaEnterpriseServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="RecaptchaEnterpriseServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="RecaptchaEnterpriseServiceSettings"/>.</returns>
        public static RecaptchaEnterpriseServiceSettings GetDefault() => new RecaptchaEnterpriseServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="RecaptchaEnterpriseServiceSettings"/> object with default settings.
        /// </summary>
        public RecaptchaEnterpriseServiceSettings()
        {
        }

        private RecaptchaEnterpriseServiceSettings(RecaptchaEnterpriseServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateAssessmentSettings = existing.CreateAssessmentSettings;
            AnnotateAssessmentSettings = existing.AnnotateAssessmentSettings;
            CreateKeySettings = existing.CreateKeySettings;
            ListKeysSettings = existing.ListKeysSettings;
            GetKeySettings = existing.GetKeySettings;
            UpdateKeySettings = existing.UpdateKeySettings;
            DeleteKeySettings = existing.DeleteKeySettings;
            MigrateKeySettings = existing.MigrateKeySettings;
            GetMetricsSettings = existing.GetMetricsSettings;
            ListRelatedAccountGroupsSettings = existing.ListRelatedAccountGroupsSettings;
            ListRelatedAccountGroupMembershipsSettings = existing.ListRelatedAccountGroupMembershipsSettings;
            SearchRelatedAccountGroupMembershipsSettings = existing.SearchRelatedAccountGroupMembershipsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(RecaptchaEnterpriseServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RecaptchaEnterpriseServiceClient.CreateAssessment</c> and
        /// <c>RecaptchaEnterpriseServiceClient.CreateAssessmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAssessmentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RecaptchaEnterpriseServiceClient.AnnotateAssessment</c> and
        /// <c>RecaptchaEnterpriseServiceClient.AnnotateAssessmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AnnotateAssessmentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RecaptchaEnterpriseServiceClient.CreateKey</c> and <c>RecaptchaEnterpriseServiceClient.CreateKeyAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateKeySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RecaptchaEnterpriseServiceClient.ListKeys</c> and <c>RecaptchaEnterpriseServiceClient.ListKeysAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListKeysSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RecaptchaEnterpriseServiceClient.GetKey</c> and <c>RecaptchaEnterpriseServiceClient.GetKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetKeySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RecaptchaEnterpriseServiceClient.UpdateKey</c> and <c>RecaptchaEnterpriseServiceClient.UpdateKeyAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateKeySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RecaptchaEnterpriseServiceClient.DeleteKey</c> and <c>RecaptchaEnterpriseServiceClient.DeleteKeyAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteKeySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RecaptchaEnterpriseServiceClient.MigrateKey</c> and <c>RecaptchaEnterpriseServiceClient.MigrateKeyAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MigrateKeySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RecaptchaEnterpriseServiceClient.GetMetrics</c> and <c>RecaptchaEnterpriseServiceClient.GetMetricsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetMetricsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RecaptchaEnterpriseServiceClient.ListRelatedAccountGroups</c> and
        /// <c>RecaptchaEnterpriseServiceClient.ListRelatedAccountGroupsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListRelatedAccountGroupsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RecaptchaEnterpriseServiceClient.ListRelatedAccountGroupMemberships</c> and
        /// <c>RecaptchaEnterpriseServiceClient.ListRelatedAccountGroupMembershipsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListRelatedAccountGroupMembershipsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RecaptchaEnterpriseServiceClient.SearchRelatedAccountGroupMemberships</c> and
        /// <c>RecaptchaEnterpriseServiceClient.SearchRelatedAccountGroupMembershipsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchRelatedAccountGroupMembershipsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="RecaptchaEnterpriseServiceSettings"/> object.</returns>
        public RecaptchaEnterpriseServiceSettings Clone() => new RecaptchaEnterpriseServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="RecaptchaEnterpriseServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class RecaptchaEnterpriseServiceClientBuilder : gaxgrpc::ClientBuilderBase<RecaptchaEnterpriseServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public RecaptchaEnterpriseServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public RecaptchaEnterpriseServiceClientBuilder() : base(RecaptchaEnterpriseServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref RecaptchaEnterpriseServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<RecaptchaEnterpriseServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override RecaptchaEnterpriseServiceClient Build()
        {
            RecaptchaEnterpriseServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<RecaptchaEnterpriseServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<RecaptchaEnterpriseServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private RecaptchaEnterpriseServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return RecaptchaEnterpriseServiceClient.Create(callInvoker, Settings, Logger);
        }

        private async stt::Task<RecaptchaEnterpriseServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return RecaptchaEnterpriseServiceClient.Create(callInvoker, Settings, Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => RecaptchaEnterpriseServiceClient.ChannelPool;
    }

    /// <summary>RecaptchaEnterpriseService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to determine the likelihood an event is legitimate.
    /// </remarks>
    public abstract partial class RecaptchaEnterpriseServiceClient
    {
        /// <summary>
        /// The default endpoint for the RecaptchaEnterpriseService service, which is a host of
        /// "recaptchaenterprise.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "recaptchaenterprise.googleapis.com:443";

        /// <summary>The default RecaptchaEnterpriseService scopes.</summary>
        /// <remarks>
        /// The default RecaptchaEnterpriseService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(RecaptchaEnterpriseService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="RecaptchaEnterpriseServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="RecaptchaEnterpriseServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="RecaptchaEnterpriseServiceClient"/>.</returns>
        public static stt::Task<RecaptchaEnterpriseServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new RecaptchaEnterpriseServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="RecaptchaEnterpriseServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="RecaptchaEnterpriseServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="RecaptchaEnterpriseServiceClient"/>.</returns>
        public static RecaptchaEnterpriseServiceClient Create() => new RecaptchaEnterpriseServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="RecaptchaEnterpriseServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="RecaptchaEnterpriseServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="RecaptchaEnterpriseServiceClient"/>.</returns>
        internal static RecaptchaEnterpriseServiceClient Create(grpccore::CallInvoker callInvoker, RecaptchaEnterpriseServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient grpcClient = new RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient(callInvoker);
            return new RecaptchaEnterpriseServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC RecaptchaEnterpriseService client</summary>
        public virtual RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an Assessment of the likelihood an event is legitimate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Assessment CreateAssessment(CreateAssessmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an Assessment of the likelihood an event is legitimate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Assessment> CreateAssessmentAsync(CreateAssessmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an Assessment of the likelihood an event is legitimate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Assessment> CreateAssessmentAsync(CreateAssessmentRequest request, st::CancellationToken cancellationToken) =>
            CreateAssessmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an Assessment of the likelihood an event is legitimate.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project in which the assessment will be created,
        /// in the format "projects/{project}".
        /// </param>
        /// <param name="assessment">
        /// Required. The assessment details.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Assessment CreateAssessment(string parent, Assessment assessment, gaxgrpc::CallSettings callSettings = null) =>
            CreateAssessment(new CreateAssessmentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Assessment = gax::GaxPreconditions.CheckNotNull(assessment, nameof(assessment)),
            }, callSettings);

        /// <summary>
        /// Creates an Assessment of the likelihood an event is legitimate.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project in which the assessment will be created,
        /// in the format "projects/{project}".
        /// </param>
        /// <param name="assessment">
        /// Required. The assessment details.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Assessment> CreateAssessmentAsync(string parent, Assessment assessment, gaxgrpc::CallSettings callSettings = null) =>
            CreateAssessmentAsync(new CreateAssessmentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Assessment = gax::GaxPreconditions.CheckNotNull(assessment, nameof(assessment)),
            }, callSettings);

        /// <summary>
        /// Creates an Assessment of the likelihood an event is legitimate.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project in which the assessment will be created,
        /// in the format "projects/{project}".
        /// </param>
        /// <param name="assessment">
        /// Required. The assessment details.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Assessment> CreateAssessmentAsync(string parent, Assessment assessment, st::CancellationToken cancellationToken) =>
            CreateAssessmentAsync(parent, assessment, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an Assessment of the likelihood an event is legitimate.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project in which the assessment will be created,
        /// in the format "projects/{project}".
        /// </param>
        /// <param name="assessment">
        /// Required. The assessment details.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Assessment CreateAssessment(gagr::ProjectName parent, Assessment assessment, gaxgrpc::CallSettings callSettings = null) =>
            CreateAssessment(new CreateAssessmentRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Assessment = gax::GaxPreconditions.CheckNotNull(assessment, nameof(assessment)),
            }, callSettings);

        /// <summary>
        /// Creates an Assessment of the likelihood an event is legitimate.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project in which the assessment will be created,
        /// in the format "projects/{project}".
        /// </param>
        /// <param name="assessment">
        /// Required. The assessment details.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Assessment> CreateAssessmentAsync(gagr::ProjectName parent, Assessment assessment, gaxgrpc::CallSettings callSettings = null) =>
            CreateAssessmentAsync(new CreateAssessmentRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Assessment = gax::GaxPreconditions.CheckNotNull(assessment, nameof(assessment)),
            }, callSettings);

        /// <summary>
        /// Creates an Assessment of the likelihood an event is legitimate.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project in which the assessment will be created,
        /// in the format "projects/{project}".
        /// </param>
        /// <param name="assessment">
        /// Required. The assessment details.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Assessment> CreateAssessmentAsync(gagr::ProjectName parent, Assessment assessment, st::CancellationToken cancellationToken) =>
            CreateAssessmentAsync(parent, assessment, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Annotates a previously created Assessment to provide additional information
        /// on whether the event turned out to be authentic or fraudulent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnnotateAssessmentResponse AnnotateAssessment(AnnotateAssessmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Annotates a previously created Assessment to provide additional information
        /// on whether the event turned out to be authentic or fraudulent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotateAssessmentResponse> AnnotateAssessmentAsync(AnnotateAssessmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Annotates a previously created Assessment to provide additional information
        /// on whether the event turned out to be authentic or fraudulent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotateAssessmentResponse> AnnotateAssessmentAsync(AnnotateAssessmentRequest request, st::CancellationToken cancellationToken) =>
            AnnotateAssessmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Annotates a previously created Assessment to provide additional information
        /// on whether the event turned out to be authentic or fraudulent.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Assessment, in the format
        /// "projects/{project}/assessments/{assessment}".
        /// </param>
        /// <param name="annotation">
        /// Optional. The annotation that will be assigned to the Event. This field can be left
        /// empty to provide reasons that apply to an event without concluding whether
        /// the event is legitimate or fraudulent.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnnotateAssessmentResponse AnnotateAssessment(string name, AnnotateAssessmentRequest.Types.Annotation annotation, gaxgrpc::CallSettings callSettings = null) =>
            AnnotateAssessment(new AnnotateAssessmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Annotation = annotation,
            }, callSettings);

        /// <summary>
        /// Annotates a previously created Assessment to provide additional information
        /// on whether the event turned out to be authentic or fraudulent.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Assessment, in the format
        /// "projects/{project}/assessments/{assessment}".
        /// </param>
        /// <param name="annotation">
        /// Optional. The annotation that will be assigned to the Event. This field can be left
        /// empty to provide reasons that apply to an event without concluding whether
        /// the event is legitimate or fraudulent.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotateAssessmentResponse> AnnotateAssessmentAsync(string name, AnnotateAssessmentRequest.Types.Annotation annotation, gaxgrpc::CallSettings callSettings = null) =>
            AnnotateAssessmentAsync(new AnnotateAssessmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Annotation = annotation,
            }, callSettings);

        /// <summary>
        /// Annotates a previously created Assessment to provide additional information
        /// on whether the event turned out to be authentic or fraudulent.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Assessment, in the format
        /// "projects/{project}/assessments/{assessment}".
        /// </param>
        /// <param name="annotation">
        /// Optional. The annotation that will be assigned to the Event. This field can be left
        /// empty to provide reasons that apply to an event without concluding whether
        /// the event is legitimate or fraudulent.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotateAssessmentResponse> AnnotateAssessmentAsync(string name, AnnotateAssessmentRequest.Types.Annotation annotation, st::CancellationToken cancellationToken) =>
            AnnotateAssessmentAsync(name, annotation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Annotates a previously created Assessment to provide additional information
        /// on whether the event turned out to be authentic or fraudulent.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Assessment, in the format
        /// "projects/{project}/assessments/{assessment}".
        /// </param>
        /// <param name="annotation">
        /// Optional. The annotation that will be assigned to the Event. This field can be left
        /// empty to provide reasons that apply to an event without concluding whether
        /// the event is legitimate or fraudulent.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnnotateAssessmentResponse AnnotateAssessment(AssessmentName name, AnnotateAssessmentRequest.Types.Annotation annotation, gaxgrpc::CallSettings callSettings = null) =>
            AnnotateAssessment(new AnnotateAssessmentRequest
            {
                AssessmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Annotation = annotation,
            }, callSettings);

        /// <summary>
        /// Annotates a previously created Assessment to provide additional information
        /// on whether the event turned out to be authentic or fraudulent.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Assessment, in the format
        /// "projects/{project}/assessments/{assessment}".
        /// </param>
        /// <param name="annotation">
        /// Optional. The annotation that will be assigned to the Event. This field can be left
        /// empty to provide reasons that apply to an event without concluding whether
        /// the event is legitimate or fraudulent.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotateAssessmentResponse> AnnotateAssessmentAsync(AssessmentName name, AnnotateAssessmentRequest.Types.Annotation annotation, gaxgrpc::CallSettings callSettings = null) =>
            AnnotateAssessmentAsync(new AnnotateAssessmentRequest
            {
                AssessmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Annotation = annotation,
            }, callSettings);

        /// <summary>
        /// Annotates a previously created Assessment to provide additional information
        /// on whether the event turned out to be authentic or fraudulent.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Assessment, in the format
        /// "projects/{project}/assessments/{assessment}".
        /// </param>
        /// <param name="annotation">
        /// Optional. The annotation that will be assigned to the Event. This field can be left
        /// empty to provide reasons that apply to an event without concluding whether
        /// the event is legitimate or fraudulent.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotateAssessmentResponse> AnnotateAssessmentAsync(AssessmentName name, AnnotateAssessmentRequest.Types.Annotation annotation, st::CancellationToken cancellationToken) =>
            AnnotateAssessmentAsync(name, annotation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new reCAPTCHA Enterprise key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Key CreateKey(CreateKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new reCAPTCHA Enterprise key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Key> CreateKeyAsync(CreateKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new reCAPTCHA Enterprise key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Key> CreateKeyAsync(CreateKeyRequest request, st::CancellationToken cancellationToken) =>
            CreateKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the list of all keys that belong to a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Key"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListKeysResponse, Key> ListKeys(ListKeysRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all keys that belong to a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Key"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListKeysResponse, Key> ListKeysAsync(ListKeysRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Key GetKey(GetKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Key> GetKeyAsync(GetKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Key> GetKeyAsync(GetKeyRequest request, st::CancellationToken cancellationToken) =>
            GetKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Key UpdateKey(UpdateKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Key> UpdateKeyAsync(UpdateKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Key> UpdateKeyAsync(UpdateKeyRequest request, st::CancellationToken cancellationToken) =>
            UpdateKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteKey(DeleteKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteKeyAsync(DeleteKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteKeyAsync(DeleteKeyRequest request, st::CancellationToken cancellationToken) =>
            DeleteKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Migrates an existing key from reCAPTCHA to reCAPTCHA Enterprise.
        /// Once a key is migrated, it can be used from either product. SiteVerify
        /// requests are billed as CreateAssessment calls. You must be
        /// authenticated as one of the current owners of the reCAPTCHA Site Key, and
        /// your user must have the reCAPTCHA Enterprise Admin IAM role in the
        /// destination project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Key MigrateKey(MigrateKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Migrates an existing key from reCAPTCHA to reCAPTCHA Enterprise.
        /// Once a key is migrated, it can be used from either product. SiteVerify
        /// requests are billed as CreateAssessment calls. You must be
        /// authenticated as one of the current owners of the reCAPTCHA Site Key, and
        /// your user must have the reCAPTCHA Enterprise Admin IAM role in the
        /// destination project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Key> MigrateKeyAsync(MigrateKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Migrates an existing key from reCAPTCHA to reCAPTCHA Enterprise.
        /// Once a key is migrated, it can be used from either product. SiteVerify
        /// requests are billed as CreateAssessment calls. You must be
        /// authenticated as one of the current owners of the reCAPTCHA Site Key, and
        /// your user must have the reCAPTCHA Enterprise Admin IAM role in the
        /// destination project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Key> MigrateKeyAsync(MigrateKeyRequest request, st::CancellationToken cancellationToken) =>
            MigrateKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get some aggregated metrics for a Key. This data can be used to build
        /// dashboards.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Metrics GetMetrics(GetMetricsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get some aggregated metrics for a Key. This data can be used to build
        /// dashboards.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Metrics> GetMetricsAsync(GetMetricsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get some aggregated metrics for a Key. This data can be used to build
        /// dashboards.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Metrics> GetMetricsAsync(GetMetricsRequest request, st::CancellationToken cancellationToken) =>
            GetMetricsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get some aggregated metrics for a Key. This data can be used to build
        /// dashboards.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the requested metrics, in the format
        /// "projects/{project}/keys/{key}/metrics".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Metrics GetMetrics(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMetrics(new GetMetricsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get some aggregated metrics for a Key. This data can be used to build
        /// dashboards.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the requested metrics, in the format
        /// "projects/{project}/keys/{key}/metrics".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Metrics> GetMetricsAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMetricsAsync(new GetMetricsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get some aggregated metrics for a Key. This data can be used to build
        /// dashboards.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the requested metrics, in the format
        /// "projects/{project}/keys/{key}/metrics".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Metrics> GetMetricsAsync(string name, st::CancellationToken cancellationToken) =>
            GetMetricsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get some aggregated metrics for a Key. This data can be used to build
        /// dashboards.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the requested metrics, in the format
        /// "projects/{project}/keys/{key}/metrics".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Metrics GetMetrics(MetricsName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMetrics(new GetMetricsRequest
            {
                MetricsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get some aggregated metrics for a Key. This data can be used to build
        /// dashboards.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the requested metrics, in the format
        /// "projects/{project}/keys/{key}/metrics".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Metrics> GetMetricsAsync(MetricsName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMetricsAsync(new GetMetricsRequest
            {
                MetricsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get some aggregated metrics for a Key. This data can be used to build
        /// dashboards.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the requested metrics, in the format
        /// "projects/{project}/keys/{key}/metrics".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Metrics> GetMetricsAsync(MetricsName name, st::CancellationToken cancellationToken) =>
            GetMetricsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List groups of related accounts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RelatedAccountGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRelatedAccountGroupsResponse, RelatedAccountGroup> ListRelatedAccountGroups(ListRelatedAccountGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List groups of related accounts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RelatedAccountGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRelatedAccountGroupsResponse, RelatedAccountGroup> ListRelatedAccountGroupsAsync(ListRelatedAccountGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List groups of related accounts.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project to list related account groups from, in the format
        /// "projects/{project}".
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
        /// <returns>A pageable sequence of <see cref="RelatedAccountGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRelatedAccountGroupsResponse, RelatedAccountGroup> ListRelatedAccountGroups(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListRelatedAccountGroups(new ListRelatedAccountGroupsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List groups of related accounts.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project to list related account groups from, in the format
        /// "projects/{project}".
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
        /// <returns>A pageable asynchronous sequence of <see cref="RelatedAccountGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRelatedAccountGroupsResponse, RelatedAccountGroup> ListRelatedAccountGroupsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListRelatedAccountGroupsAsync(new ListRelatedAccountGroupsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List groups of related accounts.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project to list related account groups from, in the format
        /// "projects/{project}".
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
        /// <returns>A pageable sequence of <see cref="RelatedAccountGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRelatedAccountGroupsResponse, RelatedAccountGroup> ListRelatedAccountGroups(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListRelatedAccountGroups(new ListRelatedAccountGroupsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List groups of related accounts.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project to list related account groups from, in the format
        /// "projects/{project}".
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
        /// <returns>A pageable asynchronous sequence of <see cref="RelatedAccountGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRelatedAccountGroupsResponse, RelatedAccountGroup> ListRelatedAccountGroupsAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListRelatedAccountGroupsAsync(new ListRelatedAccountGroupsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Get the memberships in a group of related accounts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RelatedAccountGroupMembership"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRelatedAccountGroupMembershipsResponse, RelatedAccountGroupMembership> ListRelatedAccountGroupMemberships(ListRelatedAccountGroupMembershipsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get the memberships in a group of related accounts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="RelatedAccountGroupMembership"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListRelatedAccountGroupMembershipsResponse, RelatedAccountGroupMembership> ListRelatedAccountGroupMembershipsAsync(ListRelatedAccountGroupMembershipsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get the memberships in a group of related accounts.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name for the related account group in the format
        /// `projects/{project}/relatedaccountgroups/{relatedaccountgroup}`.
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
        /// <returns>A pageable sequence of <see cref="RelatedAccountGroupMembership"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRelatedAccountGroupMembershipsResponse, RelatedAccountGroupMembership> ListRelatedAccountGroupMemberships(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListRelatedAccountGroupMemberships(new ListRelatedAccountGroupMembershipsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Get the memberships in a group of related accounts.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name for the related account group in the format
        /// `projects/{project}/relatedaccountgroups/{relatedaccountgroup}`.
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
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="RelatedAccountGroupMembership"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListRelatedAccountGroupMembershipsResponse, RelatedAccountGroupMembership> ListRelatedAccountGroupMembershipsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListRelatedAccountGroupMembershipsAsync(new ListRelatedAccountGroupMembershipsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Get the memberships in a group of related accounts.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name for the related account group in the format
        /// `projects/{project}/relatedaccountgroups/{relatedaccountgroup}`.
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
        /// <returns>A pageable sequence of <see cref="RelatedAccountGroupMembership"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRelatedAccountGroupMembershipsResponse, RelatedAccountGroupMembership> ListRelatedAccountGroupMemberships(RelatedAccountGroupName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListRelatedAccountGroupMemberships(new ListRelatedAccountGroupMembershipsRequest
            {
                ParentAsRelatedAccountGroupName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Get the memberships in a group of related accounts.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name for the related account group in the format
        /// `projects/{project}/relatedaccountgroups/{relatedaccountgroup}`.
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
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="RelatedAccountGroupMembership"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListRelatedAccountGroupMembershipsResponse, RelatedAccountGroupMembership> ListRelatedAccountGroupMembershipsAsync(RelatedAccountGroupName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListRelatedAccountGroupMembershipsAsync(new ListRelatedAccountGroupMembershipsRequest
            {
                ParentAsRelatedAccountGroupName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Search group memberships related to a given account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RelatedAccountGroupMembership"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchRelatedAccountGroupMembershipsResponse, RelatedAccountGroupMembership> SearchRelatedAccountGroupMemberships(SearchRelatedAccountGroupMembershipsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Search group memberships related to a given account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="RelatedAccountGroupMembership"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<SearchRelatedAccountGroupMembershipsResponse, RelatedAccountGroupMembership> SearchRelatedAccountGroupMembershipsAsync(SearchRelatedAccountGroupMembershipsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Search group memberships related to a given account.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project to search related account group memberships from,
        /// in the format "projects/{project}".
        /// </param>
        /// <param name="hashedAccountId">
        /// Optional. The unique stable hashed user identifier we should search connections to.
        /// The identifier should correspond to a `hashed_account_id` provided in a
        /// previous CreateAssessment or AnnotateAssessment call.
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
        /// <returns>A pageable sequence of <see cref="RelatedAccountGroupMembership"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchRelatedAccountGroupMembershipsResponse, RelatedAccountGroupMembership> SearchRelatedAccountGroupMemberships(string parent, proto::ByteString hashedAccountId, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            SearchRelatedAccountGroupMemberships(new SearchRelatedAccountGroupMembershipsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                HashedAccountId = hashedAccountId ?? proto::ByteString.Empty,
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Search group memberships related to a given account.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project to search related account group memberships from,
        /// in the format "projects/{project}".
        /// </param>
        /// <param name="hashedAccountId">
        /// Optional. The unique stable hashed user identifier we should search connections to.
        /// The identifier should correspond to a `hashed_account_id` provided in a
        /// previous CreateAssessment or AnnotateAssessment call.
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
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="RelatedAccountGroupMembership"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<SearchRelatedAccountGroupMembershipsResponse, RelatedAccountGroupMembership> SearchRelatedAccountGroupMembershipsAsync(string parent, proto::ByteString hashedAccountId, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            SearchRelatedAccountGroupMembershipsAsync(new SearchRelatedAccountGroupMembershipsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                HashedAccountId = hashedAccountId ?? proto::ByteString.Empty,
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Search group memberships related to a given account.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project to search related account group memberships from,
        /// in the format "projects/{project}".
        /// </param>
        /// <param name="hashedAccountId">
        /// Optional. The unique stable hashed user identifier we should search connections to.
        /// The identifier should correspond to a `hashed_account_id` provided in a
        /// previous CreateAssessment or AnnotateAssessment call.
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
        /// <returns>A pageable sequence of <see cref="RelatedAccountGroupMembership"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchRelatedAccountGroupMembershipsResponse, RelatedAccountGroupMembership> SearchRelatedAccountGroupMemberships(RelatedAccountGroupName parent, proto::ByteString hashedAccountId, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            SearchRelatedAccountGroupMemberships(new SearchRelatedAccountGroupMembershipsRequest
            {
                ParentAsRelatedAccountGroupName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                HashedAccountId = hashedAccountId ?? proto::ByteString.Empty,
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Search group memberships related to a given account.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project to search related account group memberships from,
        /// in the format "projects/{project}".
        /// </param>
        /// <param name="hashedAccountId">
        /// Optional. The unique stable hashed user identifier we should search connections to.
        /// The identifier should correspond to a `hashed_account_id` provided in a
        /// previous CreateAssessment or AnnotateAssessment call.
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
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="RelatedAccountGroupMembership"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<SearchRelatedAccountGroupMembershipsResponse, RelatedAccountGroupMembership> SearchRelatedAccountGroupMembershipsAsync(RelatedAccountGroupName parent, proto::ByteString hashedAccountId, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            SearchRelatedAccountGroupMembershipsAsync(new SearchRelatedAccountGroupMembershipsRequest
            {
                ParentAsRelatedAccountGroupName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                HashedAccountId = hashedAccountId ?? proto::ByteString.Empty,
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);
    }

    /// <summary>RecaptchaEnterpriseService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to determine the likelihood an event is legitimate.
    /// </remarks>
    public sealed partial class RecaptchaEnterpriseServiceClientImpl : RecaptchaEnterpriseServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateAssessmentRequest, Assessment> _callCreateAssessment;

        private readonly gaxgrpc::ApiCall<AnnotateAssessmentRequest, AnnotateAssessmentResponse> _callAnnotateAssessment;

        private readonly gaxgrpc::ApiCall<CreateKeyRequest, Key> _callCreateKey;

        private readonly gaxgrpc::ApiCall<ListKeysRequest, ListKeysResponse> _callListKeys;

        private readonly gaxgrpc::ApiCall<GetKeyRequest, Key> _callGetKey;

        private readonly gaxgrpc::ApiCall<UpdateKeyRequest, Key> _callUpdateKey;

        private readonly gaxgrpc::ApiCall<DeleteKeyRequest, wkt::Empty> _callDeleteKey;

        private readonly gaxgrpc::ApiCall<MigrateKeyRequest, Key> _callMigrateKey;

        private readonly gaxgrpc::ApiCall<GetMetricsRequest, Metrics> _callGetMetrics;

        private readonly gaxgrpc::ApiCall<ListRelatedAccountGroupsRequest, ListRelatedAccountGroupsResponse> _callListRelatedAccountGroups;

        private readonly gaxgrpc::ApiCall<ListRelatedAccountGroupMembershipsRequest, ListRelatedAccountGroupMembershipsResponse> _callListRelatedAccountGroupMemberships;

        private readonly gaxgrpc::ApiCall<SearchRelatedAccountGroupMembershipsRequest, SearchRelatedAccountGroupMembershipsResponse> _callSearchRelatedAccountGroupMemberships;

        /// <summary>
        /// Constructs a client wrapper for the RecaptchaEnterpriseService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="RecaptchaEnterpriseServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public RecaptchaEnterpriseServiceClientImpl(RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient grpcClient, RecaptchaEnterpriseServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            RecaptchaEnterpriseServiceSettings effectiveSettings = settings ?? RecaptchaEnterpriseServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            _callCreateAssessment = clientHelper.BuildApiCall<CreateAssessmentRequest, Assessment>("CreateAssessment", grpcClient.CreateAssessmentAsync, grpcClient.CreateAssessment, effectiveSettings.CreateAssessmentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAssessment);
            Modify_CreateAssessmentApiCall(ref _callCreateAssessment);
            _callAnnotateAssessment = clientHelper.BuildApiCall<AnnotateAssessmentRequest, AnnotateAssessmentResponse>("AnnotateAssessment", grpcClient.AnnotateAssessmentAsync, grpcClient.AnnotateAssessment, effectiveSettings.AnnotateAssessmentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callAnnotateAssessment);
            Modify_AnnotateAssessmentApiCall(ref _callAnnotateAssessment);
            _callCreateKey = clientHelper.BuildApiCall<CreateKeyRequest, Key>("CreateKey", grpcClient.CreateKeyAsync, grpcClient.CreateKey, effectiveSettings.CreateKeySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateKey);
            Modify_CreateKeyApiCall(ref _callCreateKey);
            _callListKeys = clientHelper.BuildApiCall<ListKeysRequest, ListKeysResponse>("ListKeys", grpcClient.ListKeysAsync, grpcClient.ListKeys, effectiveSettings.ListKeysSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListKeys);
            Modify_ListKeysApiCall(ref _callListKeys);
            _callGetKey = clientHelper.BuildApiCall<GetKeyRequest, Key>("GetKey", grpcClient.GetKeyAsync, grpcClient.GetKey, effectiveSettings.GetKeySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetKey);
            Modify_GetKeyApiCall(ref _callGetKey);
            _callUpdateKey = clientHelper.BuildApiCall<UpdateKeyRequest, Key>("UpdateKey", grpcClient.UpdateKeyAsync, grpcClient.UpdateKey, effectiveSettings.UpdateKeySettings).WithGoogleRequestParam("key.name", request => request.Key?.Name);
            Modify_ApiCall(ref _callUpdateKey);
            Modify_UpdateKeyApiCall(ref _callUpdateKey);
            _callDeleteKey = clientHelper.BuildApiCall<DeleteKeyRequest, wkt::Empty>("DeleteKey", grpcClient.DeleteKeyAsync, grpcClient.DeleteKey, effectiveSettings.DeleteKeySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteKey);
            Modify_DeleteKeyApiCall(ref _callDeleteKey);
            _callMigrateKey = clientHelper.BuildApiCall<MigrateKeyRequest, Key>("MigrateKey", grpcClient.MigrateKeyAsync, grpcClient.MigrateKey, effectiveSettings.MigrateKeySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callMigrateKey);
            Modify_MigrateKeyApiCall(ref _callMigrateKey);
            _callGetMetrics = clientHelper.BuildApiCall<GetMetricsRequest, Metrics>("GetMetrics", grpcClient.GetMetricsAsync, grpcClient.GetMetrics, effectiveSettings.GetMetricsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetMetrics);
            Modify_GetMetricsApiCall(ref _callGetMetrics);
            _callListRelatedAccountGroups = clientHelper.BuildApiCall<ListRelatedAccountGroupsRequest, ListRelatedAccountGroupsResponse>("ListRelatedAccountGroups", grpcClient.ListRelatedAccountGroupsAsync, grpcClient.ListRelatedAccountGroups, effectiveSettings.ListRelatedAccountGroupsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListRelatedAccountGroups);
            Modify_ListRelatedAccountGroupsApiCall(ref _callListRelatedAccountGroups);
            _callListRelatedAccountGroupMemberships = clientHelper.BuildApiCall<ListRelatedAccountGroupMembershipsRequest, ListRelatedAccountGroupMembershipsResponse>("ListRelatedAccountGroupMemberships", grpcClient.ListRelatedAccountGroupMembershipsAsync, grpcClient.ListRelatedAccountGroupMemberships, effectiveSettings.ListRelatedAccountGroupMembershipsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListRelatedAccountGroupMemberships);
            Modify_ListRelatedAccountGroupMembershipsApiCall(ref _callListRelatedAccountGroupMemberships);
            _callSearchRelatedAccountGroupMemberships = clientHelper.BuildApiCall<SearchRelatedAccountGroupMembershipsRequest, SearchRelatedAccountGroupMembershipsResponse>("SearchRelatedAccountGroupMemberships", grpcClient.SearchRelatedAccountGroupMembershipsAsync, grpcClient.SearchRelatedAccountGroupMemberships, effectiveSettings.SearchRelatedAccountGroupMembershipsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callSearchRelatedAccountGroupMemberships);
            Modify_SearchRelatedAccountGroupMembershipsApiCall(ref _callSearchRelatedAccountGroupMemberships);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateAssessmentApiCall(ref gaxgrpc::ApiCall<CreateAssessmentRequest, Assessment> call);

        partial void Modify_AnnotateAssessmentApiCall(ref gaxgrpc::ApiCall<AnnotateAssessmentRequest, AnnotateAssessmentResponse> call);

        partial void Modify_CreateKeyApiCall(ref gaxgrpc::ApiCall<CreateKeyRequest, Key> call);

        partial void Modify_ListKeysApiCall(ref gaxgrpc::ApiCall<ListKeysRequest, ListKeysResponse> call);

        partial void Modify_GetKeyApiCall(ref gaxgrpc::ApiCall<GetKeyRequest, Key> call);

        partial void Modify_UpdateKeyApiCall(ref gaxgrpc::ApiCall<UpdateKeyRequest, Key> call);

        partial void Modify_DeleteKeyApiCall(ref gaxgrpc::ApiCall<DeleteKeyRequest, wkt::Empty> call);

        partial void Modify_MigrateKeyApiCall(ref gaxgrpc::ApiCall<MigrateKeyRequest, Key> call);

        partial void Modify_GetMetricsApiCall(ref gaxgrpc::ApiCall<GetMetricsRequest, Metrics> call);

        partial void Modify_ListRelatedAccountGroupsApiCall(ref gaxgrpc::ApiCall<ListRelatedAccountGroupsRequest, ListRelatedAccountGroupsResponse> call);

        partial void Modify_ListRelatedAccountGroupMembershipsApiCall(ref gaxgrpc::ApiCall<ListRelatedAccountGroupMembershipsRequest, ListRelatedAccountGroupMembershipsResponse> call);

        partial void Modify_SearchRelatedAccountGroupMembershipsApiCall(ref gaxgrpc::ApiCall<SearchRelatedAccountGroupMembershipsRequest, SearchRelatedAccountGroupMembershipsResponse> call);

        partial void OnConstruction(RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient grpcClient, RecaptchaEnterpriseServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC RecaptchaEnterpriseService client</summary>
        public override RecaptchaEnterpriseService.RecaptchaEnterpriseServiceClient GrpcClient { get; }

        partial void Modify_CreateAssessmentRequest(ref CreateAssessmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AnnotateAssessmentRequest(ref AnnotateAssessmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateKeyRequest(ref CreateKeyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListKeysRequest(ref ListKeysRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetKeyRequest(ref GetKeyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateKeyRequest(ref UpdateKeyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteKeyRequest(ref DeleteKeyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MigrateKeyRequest(ref MigrateKeyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetMetricsRequest(ref GetMetricsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRelatedAccountGroupsRequest(ref ListRelatedAccountGroupsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRelatedAccountGroupMembershipsRequest(ref ListRelatedAccountGroupMembershipsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchRelatedAccountGroupMembershipsRequest(ref SearchRelatedAccountGroupMembershipsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates an Assessment of the likelihood an event is legitimate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Assessment CreateAssessment(CreateAssessmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAssessmentRequest(ref request, ref callSettings);
            return _callCreateAssessment.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates an Assessment of the likelihood an event is legitimate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Assessment> CreateAssessmentAsync(CreateAssessmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAssessmentRequest(ref request, ref callSettings);
            return _callCreateAssessment.Async(request, callSettings);
        }

        /// <summary>
        /// Annotates a previously created Assessment to provide additional information
        /// on whether the event turned out to be authentic or fraudulent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AnnotateAssessmentResponse AnnotateAssessment(AnnotateAssessmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AnnotateAssessmentRequest(ref request, ref callSettings);
            return _callAnnotateAssessment.Sync(request, callSettings);
        }

        /// <summary>
        /// Annotates a previously created Assessment to provide additional information
        /// on whether the event turned out to be authentic or fraudulent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AnnotateAssessmentResponse> AnnotateAssessmentAsync(AnnotateAssessmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AnnotateAssessmentRequest(ref request, ref callSettings);
            return _callAnnotateAssessment.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new reCAPTCHA Enterprise key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Key CreateKey(CreateKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateKeyRequest(ref request, ref callSettings);
            return _callCreateKey.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new reCAPTCHA Enterprise key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Key> CreateKeyAsync(CreateKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateKeyRequest(ref request, ref callSettings);
            return _callCreateKey.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all keys that belong to a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Key"/> resources.</returns>
        public override gax::PagedEnumerable<ListKeysResponse, Key> ListKeys(ListKeysRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListKeysRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListKeysRequest, ListKeysResponse, Key>(_callListKeys, request, callSettings);
        }

        /// <summary>
        /// Returns the list of all keys that belong to a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Key"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListKeysResponse, Key> ListKeysAsync(ListKeysRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListKeysRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListKeysRequest, ListKeysResponse, Key>(_callListKeys, request, callSettings);
        }

        /// <summary>
        /// Returns the specified key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Key GetKey(GetKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetKeyRequest(ref request, ref callSettings);
            return _callGetKey.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Key> GetKeyAsync(GetKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetKeyRequest(ref request, ref callSettings);
            return _callGetKey.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the specified key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Key UpdateKey(UpdateKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateKeyRequest(ref request, ref callSettings);
            return _callUpdateKey.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the specified key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Key> UpdateKeyAsync(UpdateKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateKeyRequest(ref request, ref callSettings);
            return _callUpdateKey.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteKey(DeleteKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteKeyRequest(ref request, ref callSettings);
            _callDeleteKey.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteKeyAsync(DeleteKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteKeyRequest(ref request, ref callSettings);
            return _callDeleteKey.Async(request, callSettings);
        }

        /// <summary>
        /// Migrates an existing key from reCAPTCHA to reCAPTCHA Enterprise.
        /// Once a key is migrated, it can be used from either product. SiteVerify
        /// requests are billed as CreateAssessment calls. You must be
        /// authenticated as one of the current owners of the reCAPTCHA Site Key, and
        /// your user must have the reCAPTCHA Enterprise Admin IAM role in the
        /// destination project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Key MigrateKey(MigrateKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MigrateKeyRequest(ref request, ref callSettings);
            return _callMigrateKey.Sync(request, callSettings);
        }

        /// <summary>
        /// Migrates an existing key from reCAPTCHA to reCAPTCHA Enterprise.
        /// Once a key is migrated, it can be used from either product. SiteVerify
        /// requests are billed as CreateAssessment calls. You must be
        /// authenticated as one of the current owners of the reCAPTCHA Site Key, and
        /// your user must have the reCAPTCHA Enterprise Admin IAM role in the
        /// destination project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Key> MigrateKeyAsync(MigrateKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MigrateKeyRequest(ref request, ref callSettings);
            return _callMigrateKey.Async(request, callSettings);
        }

        /// <summary>
        /// Get some aggregated metrics for a Key. This data can be used to build
        /// dashboards.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Metrics GetMetrics(GetMetricsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMetricsRequest(ref request, ref callSettings);
            return _callGetMetrics.Sync(request, callSettings);
        }

        /// <summary>
        /// Get some aggregated metrics for a Key. This data can be used to build
        /// dashboards.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Metrics> GetMetricsAsync(GetMetricsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMetricsRequest(ref request, ref callSettings);
            return _callGetMetrics.Async(request, callSettings);
        }

        /// <summary>
        /// List groups of related accounts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RelatedAccountGroup"/> resources.</returns>
        public override gax::PagedEnumerable<ListRelatedAccountGroupsResponse, RelatedAccountGroup> ListRelatedAccountGroups(ListRelatedAccountGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRelatedAccountGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRelatedAccountGroupsRequest, ListRelatedAccountGroupsResponse, RelatedAccountGroup>(_callListRelatedAccountGroups, request, callSettings);
        }

        /// <summary>
        /// List groups of related accounts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RelatedAccountGroup"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListRelatedAccountGroupsResponse, RelatedAccountGroup> ListRelatedAccountGroupsAsync(ListRelatedAccountGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRelatedAccountGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRelatedAccountGroupsRequest, ListRelatedAccountGroupsResponse, RelatedAccountGroup>(_callListRelatedAccountGroups, request, callSettings);
        }

        /// <summary>
        /// Get the memberships in a group of related accounts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RelatedAccountGroupMembership"/> resources.</returns>
        public override gax::PagedEnumerable<ListRelatedAccountGroupMembershipsResponse, RelatedAccountGroupMembership> ListRelatedAccountGroupMemberships(ListRelatedAccountGroupMembershipsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRelatedAccountGroupMembershipsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRelatedAccountGroupMembershipsRequest, ListRelatedAccountGroupMembershipsResponse, RelatedAccountGroupMembership>(_callListRelatedAccountGroupMemberships, request, callSettings);
        }

        /// <summary>
        /// Get the memberships in a group of related accounts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="RelatedAccountGroupMembership"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListRelatedAccountGroupMembershipsResponse, RelatedAccountGroupMembership> ListRelatedAccountGroupMembershipsAsync(ListRelatedAccountGroupMembershipsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRelatedAccountGroupMembershipsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRelatedAccountGroupMembershipsRequest, ListRelatedAccountGroupMembershipsResponse, RelatedAccountGroupMembership>(_callListRelatedAccountGroupMemberships, request, callSettings);
        }

        /// <summary>
        /// Search group memberships related to a given account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RelatedAccountGroupMembership"/> resources.</returns>
        public override gax::PagedEnumerable<SearchRelatedAccountGroupMembershipsResponse, RelatedAccountGroupMembership> SearchRelatedAccountGroupMemberships(SearchRelatedAccountGroupMembershipsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchRelatedAccountGroupMembershipsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchRelatedAccountGroupMembershipsRequest, SearchRelatedAccountGroupMembershipsResponse, RelatedAccountGroupMembership>(_callSearchRelatedAccountGroupMemberships, request, callSettings);
        }

        /// <summary>
        /// Search group memberships related to a given account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="RelatedAccountGroupMembership"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<SearchRelatedAccountGroupMembershipsResponse, RelatedAccountGroupMembership> SearchRelatedAccountGroupMembershipsAsync(SearchRelatedAccountGroupMembershipsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchRelatedAccountGroupMembershipsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchRelatedAccountGroupMembershipsRequest, SearchRelatedAccountGroupMembershipsResponse, RelatedAccountGroupMembership>(_callSearchRelatedAccountGroupMemberships, request, callSettings);
        }
    }

    public partial class ListKeysRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListRelatedAccountGroupsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListRelatedAccountGroupMembershipsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchRelatedAccountGroupMembershipsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListKeysResponse : gaxgrpc::IPageResponse<Key>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Key> GetEnumerator() => Keys.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListRelatedAccountGroupsResponse : gaxgrpc::IPageResponse<RelatedAccountGroup>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<RelatedAccountGroup> GetEnumerator() => RelatedAccountGroups.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListRelatedAccountGroupMembershipsResponse : gaxgrpc::IPageResponse<RelatedAccountGroupMembership>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<RelatedAccountGroupMembership> GetEnumerator() =>
            RelatedAccountGroupMemberships.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class SearchRelatedAccountGroupMembershipsResponse : gaxgrpc::IPageResponse<RelatedAccountGroupMembership>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<RelatedAccountGroupMembership> GetEnumerator() =>
            RelatedAccountGroupMemberships.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
