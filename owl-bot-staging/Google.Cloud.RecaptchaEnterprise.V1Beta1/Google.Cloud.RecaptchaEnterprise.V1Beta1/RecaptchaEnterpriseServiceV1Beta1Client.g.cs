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
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.RecaptchaEnterprise.V1Beta1
{
    /// <summary>Settings for <see cref="RecaptchaEnterpriseServiceV1Beta1Client"/> instances.</summary>
    public sealed partial class RecaptchaEnterpriseServiceV1Beta1Settings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="RecaptchaEnterpriseServiceV1Beta1Settings"/>.
        /// </summary>
        /// <returns>A new instance of the default <see cref="RecaptchaEnterpriseServiceV1Beta1Settings"/>.</returns>
        public static RecaptchaEnterpriseServiceV1Beta1Settings GetDefault() =>
            new RecaptchaEnterpriseServiceV1Beta1Settings();

        /// <summary>
        /// Constructs a new <see cref="RecaptchaEnterpriseServiceV1Beta1Settings"/> object with default settings.
        /// </summary>
        public RecaptchaEnterpriseServiceV1Beta1Settings()
        {
        }

        private RecaptchaEnterpriseServiceV1Beta1Settings(RecaptchaEnterpriseServiceV1Beta1Settings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateAssessmentSettings = existing.CreateAssessmentSettings;
            AnnotateAssessmentSettings = existing.AnnotateAssessmentSettings;
            OnCopy(existing);
        }

        partial void OnCopy(RecaptchaEnterpriseServiceV1Beta1Settings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RecaptchaEnterpriseServiceV1Beta1Client.CreateAssessment</c> and
        /// <c>RecaptchaEnterpriseServiceV1Beta1Client.CreateAssessmentAsync</c>.
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
        /// <c>RecaptchaEnterpriseServiceV1Beta1Client.AnnotateAssessment</c> and
        /// <c>RecaptchaEnterpriseServiceV1Beta1Client.AnnotateAssessmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AnnotateAssessmentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="RecaptchaEnterpriseServiceV1Beta1Settings"/> object.</returns>
        public RecaptchaEnterpriseServiceV1Beta1Settings Clone() => new RecaptchaEnterpriseServiceV1Beta1Settings(this);
    }

    /// <summary>
    /// Builder class for <see cref="RecaptchaEnterpriseServiceV1Beta1Client"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class RecaptchaEnterpriseServiceV1Beta1ClientBuilder : gaxgrpc::ClientBuilderBase<RecaptchaEnterpriseServiceV1Beta1Client>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public RecaptchaEnterpriseServiceV1Beta1Settings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public RecaptchaEnterpriseServiceV1Beta1ClientBuilder() : base(RecaptchaEnterpriseServiceV1Beta1Client.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref RecaptchaEnterpriseServiceV1Beta1Client client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<RecaptchaEnterpriseServiceV1Beta1Client> task);

        /// <summary>Builds the resulting client.</summary>
        public override RecaptchaEnterpriseServiceV1Beta1Client Build()
        {
            RecaptchaEnterpriseServiceV1Beta1Client client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<RecaptchaEnterpriseServiceV1Beta1Client> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<RecaptchaEnterpriseServiceV1Beta1Client> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private RecaptchaEnterpriseServiceV1Beta1Client BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return RecaptchaEnterpriseServiceV1Beta1Client.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<RecaptchaEnterpriseServiceV1Beta1Client> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return RecaptchaEnterpriseServiceV1Beta1Client.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => RecaptchaEnterpriseServiceV1Beta1Client.ChannelPool;
    }

    /// <summary>RecaptchaEnterpriseServiceV1Beta1 client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to determine the likelihood an event is legitimate.
    /// </remarks>
    public abstract partial class RecaptchaEnterpriseServiceV1Beta1Client
    {
        /// <summary>
        /// The default endpoint for the RecaptchaEnterpriseServiceV1Beta1 service, which is a host of
        /// "recaptchaenterprise.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "recaptchaenterprise.googleapis.com:443";

        /// <summary>The default RecaptchaEnterpriseServiceV1Beta1 scopes.</summary>
        /// <remarks>
        /// The default RecaptchaEnterpriseServiceV1Beta1 scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(RecaptchaEnterpriseServiceV1Beta1.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="RecaptchaEnterpriseServiceV1Beta1Client"/> using the default
        /// credentials, endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="RecaptchaEnterpriseServiceV1Beta1ClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="RecaptchaEnterpriseServiceV1Beta1Client"/>.</returns>
        public static stt::Task<RecaptchaEnterpriseServiceV1Beta1Client> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new RecaptchaEnterpriseServiceV1Beta1ClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="RecaptchaEnterpriseServiceV1Beta1Client"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="RecaptchaEnterpriseServiceV1Beta1ClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="RecaptchaEnterpriseServiceV1Beta1Client"/>.</returns>
        public static RecaptchaEnterpriseServiceV1Beta1Client Create() =>
            new RecaptchaEnterpriseServiceV1Beta1ClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="RecaptchaEnterpriseServiceV1Beta1Client"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="RecaptchaEnterpriseServiceV1Beta1Settings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="RecaptchaEnterpriseServiceV1Beta1Client"/>.</returns>
        internal static RecaptchaEnterpriseServiceV1Beta1Client Create(grpccore::CallInvoker callInvoker, RecaptchaEnterpriseServiceV1Beta1Settings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client grpcClient = new RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client(callInvoker);
            return new RecaptchaEnterpriseServiceV1Beta1ClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC RecaptchaEnterpriseServiceV1Beta1 client</summary>
        public virtual RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client GrpcClient => throw new sys::NotImplementedException();

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
        /// Required. The name of the project in which the assessment is created,
        /// in the format `projects/{project_number}`.
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
        /// Required. The name of the project in which the assessment is created,
        /// in the format `projects/{project_number}`.
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
        /// Required. The name of the project in which the assessment is created,
        /// in the format `projects/{project_number}`.
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
        /// Required. The name of the project in which the assessment is created,
        /// in the format `projects/{project_number}`.
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
        /// Required. The name of the project in which the assessment is created,
        /// in the format `projects/{project_number}`.
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
        /// Required. The name of the project in which the assessment is created,
        /// in the format `projects/{project_number}`.
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
        /// on whether the event turned out to be authentic or fradulent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnnotateAssessmentResponse AnnotateAssessment(AnnotateAssessmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Annotates a previously created Assessment to provide additional information
        /// on whether the event turned out to be authentic or fradulent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotateAssessmentResponse> AnnotateAssessmentAsync(AnnotateAssessmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Annotates a previously created Assessment to provide additional information
        /// on whether the event turned out to be authentic or fradulent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotateAssessmentResponse> AnnotateAssessmentAsync(AnnotateAssessmentRequest request, st::CancellationToken cancellationToken) =>
            AnnotateAssessmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Annotates a previously created Assessment to provide additional information
        /// on whether the event turned out to be authentic or fradulent.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Assessment, in the format
        /// `projects/{project_number}/assessments/{assessment_id}`.
        /// </param>
        /// <param name="annotation">
        /// Optional. The annotation that is assigned to the Event. This field can be
        /// left empty to provide reasons that apply to an event without concluding
        /// whether the event is legitimate or fraudulent.
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
        /// on whether the event turned out to be authentic or fradulent.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Assessment, in the format
        /// `projects/{project_number}/assessments/{assessment_id}`.
        /// </param>
        /// <param name="annotation">
        /// Optional. The annotation that is assigned to the Event. This field can be
        /// left empty to provide reasons that apply to an event without concluding
        /// whether the event is legitimate or fraudulent.
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
        /// on whether the event turned out to be authentic or fradulent.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Assessment, in the format
        /// `projects/{project_number}/assessments/{assessment_id}`.
        /// </param>
        /// <param name="annotation">
        /// Optional. The annotation that is assigned to the Event. This field can be
        /// left empty to provide reasons that apply to an event without concluding
        /// whether the event is legitimate or fraudulent.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotateAssessmentResponse> AnnotateAssessmentAsync(string name, AnnotateAssessmentRequest.Types.Annotation annotation, st::CancellationToken cancellationToken) =>
            AnnotateAssessmentAsync(name, annotation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Annotates a previously created Assessment to provide additional information
        /// on whether the event turned out to be authentic or fradulent.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Assessment, in the format
        /// `projects/{project_number}/assessments/{assessment_id}`.
        /// </param>
        /// <param name="annotation">
        /// Optional. The annotation that is assigned to the Event. This field can be
        /// left empty to provide reasons that apply to an event without concluding
        /// whether the event is legitimate or fraudulent.
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
        /// on whether the event turned out to be authentic or fradulent.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Assessment, in the format
        /// `projects/{project_number}/assessments/{assessment_id}`.
        /// </param>
        /// <param name="annotation">
        /// Optional. The annotation that is assigned to the Event. This field can be
        /// left empty to provide reasons that apply to an event without concluding
        /// whether the event is legitimate or fraudulent.
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
        /// on whether the event turned out to be authentic or fradulent.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Assessment, in the format
        /// `projects/{project_number}/assessments/{assessment_id}`.
        /// </param>
        /// <param name="annotation">
        /// Optional. The annotation that is assigned to the Event. This field can be
        /// left empty to provide reasons that apply to an event without concluding
        /// whether the event is legitimate or fraudulent.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotateAssessmentResponse> AnnotateAssessmentAsync(AssessmentName name, AnnotateAssessmentRequest.Types.Annotation annotation, st::CancellationToken cancellationToken) =>
            AnnotateAssessmentAsync(name, annotation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>RecaptchaEnterpriseServiceV1Beta1 client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to determine the likelihood an event is legitimate.
    /// </remarks>
    public sealed partial class RecaptchaEnterpriseServiceV1Beta1ClientImpl : RecaptchaEnterpriseServiceV1Beta1Client
    {
        private readonly gaxgrpc::ApiCall<CreateAssessmentRequest, Assessment> _callCreateAssessment;

        private readonly gaxgrpc::ApiCall<AnnotateAssessmentRequest, AnnotateAssessmentResponse> _callAnnotateAssessment;

        /// <summary>
        /// Constructs a client wrapper for the RecaptchaEnterpriseServiceV1Beta1 service, with the specified gRPC
        /// client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="RecaptchaEnterpriseServiceV1Beta1Settings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public RecaptchaEnterpriseServiceV1Beta1ClientImpl(RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client grpcClient, RecaptchaEnterpriseServiceV1Beta1Settings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            RecaptchaEnterpriseServiceV1Beta1Settings effectiveSettings = settings ?? RecaptchaEnterpriseServiceV1Beta1Settings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callCreateAssessment = clientHelper.BuildApiCall<CreateAssessmentRequest, Assessment>("CreateAssessment", grpcClient.CreateAssessmentAsync, grpcClient.CreateAssessment, effectiveSettings.CreateAssessmentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAssessment);
            Modify_CreateAssessmentApiCall(ref _callCreateAssessment);
            _callAnnotateAssessment = clientHelper.BuildApiCall<AnnotateAssessmentRequest, AnnotateAssessmentResponse>("AnnotateAssessment", grpcClient.AnnotateAssessmentAsync, grpcClient.AnnotateAssessment, effectiveSettings.AnnotateAssessmentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callAnnotateAssessment);
            Modify_AnnotateAssessmentApiCall(ref _callAnnotateAssessment);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateAssessmentApiCall(ref gaxgrpc::ApiCall<CreateAssessmentRequest, Assessment> call);

        partial void Modify_AnnotateAssessmentApiCall(ref gaxgrpc::ApiCall<AnnotateAssessmentRequest, AnnotateAssessmentResponse> call);

        partial void OnConstruction(RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client grpcClient, RecaptchaEnterpriseServiceV1Beta1Settings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC RecaptchaEnterpriseServiceV1Beta1 client</summary>
        public override RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client GrpcClient { get; }

        partial void Modify_CreateAssessmentRequest(ref CreateAssessmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AnnotateAssessmentRequest(ref AnnotateAssessmentRequest request, ref gaxgrpc::CallSettings settings);

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
        /// on whether the event turned out to be authentic or fradulent.
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
        /// on whether the event turned out to be authentic or fradulent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AnnotateAssessmentResponse> AnnotateAssessmentAsync(AnnotateAssessmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AnnotateAssessmentRequest(ref request, ref callSettings);
            return _callAnnotateAssessment.Async(request, callSettings);
        }
    }
}
