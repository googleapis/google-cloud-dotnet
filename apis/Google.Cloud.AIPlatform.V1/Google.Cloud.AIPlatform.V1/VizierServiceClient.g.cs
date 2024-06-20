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
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.AIPlatform.V1
{
    /// <summary>Settings for <see cref="VizierServiceClient"/> instances.</summary>
    public sealed partial class VizierServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="VizierServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="VizierServiceSettings"/>.</returns>
        public static VizierServiceSettings GetDefault() => new VizierServiceSettings();

        /// <summary>Constructs a new <see cref="VizierServiceSettings"/> object with default settings.</summary>
        public VizierServiceSettings()
        {
        }

        private VizierServiceSettings(VizierServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateStudySettings = existing.CreateStudySettings;
            GetStudySettings = existing.GetStudySettings;
            ListStudiesSettings = existing.ListStudiesSettings;
            DeleteStudySettings = existing.DeleteStudySettings;
            LookupStudySettings = existing.LookupStudySettings;
            SuggestTrialsSettings = existing.SuggestTrialsSettings;
            SuggestTrialsOperationsSettings = existing.SuggestTrialsOperationsSettings.Clone();
            CreateTrialSettings = existing.CreateTrialSettings;
            GetTrialSettings = existing.GetTrialSettings;
            ListTrialsSettings = existing.ListTrialsSettings;
            AddTrialMeasurementSettings = existing.AddTrialMeasurementSettings;
            CompleteTrialSettings = existing.CompleteTrialSettings;
            DeleteTrialSettings = existing.DeleteTrialSettings;
            CheckTrialEarlyStoppingStateSettings = existing.CheckTrialEarlyStoppingStateSettings;
            CheckTrialEarlyStoppingStateOperationsSettings = existing.CheckTrialEarlyStoppingStateOperationsSettings.Clone();
            StopTrialSettings = existing.StopTrialSettings;
            ListOptimalTrialsSettings = existing.ListOptimalTrialsSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(VizierServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VizierServiceClient.CreateStudy</c> and <c>VizierServiceClient.CreateStudyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateStudySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VizierServiceClient.GetStudy</c> and <c>VizierServiceClient.GetStudyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetStudySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VizierServiceClient.ListStudies</c> and <c>VizierServiceClient.ListStudiesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListStudiesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VizierServiceClient.DeleteStudy</c> and <c>VizierServiceClient.DeleteStudyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteStudySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VizierServiceClient.LookupStudy</c> and <c>VizierServiceClient.LookupStudyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings LookupStudySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VizierServiceClient.SuggestTrials</c> and <c>VizierServiceClient.SuggestTrialsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SuggestTrialsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>VizierServiceClient.SuggestTrials</c> and
        /// <c>VizierServiceClient.SuggestTrialsAsync</c>.
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
        public lro::OperationsSettings SuggestTrialsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VizierServiceClient.CreateTrial</c> and <c>VizierServiceClient.CreateTrialAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateTrialSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VizierServiceClient.GetTrial</c> and <c>VizierServiceClient.GetTrialAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetTrialSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VizierServiceClient.ListTrials</c> and <c>VizierServiceClient.ListTrialsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTrialsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VizierServiceClient.AddTrialMeasurement</c> and <c>VizierServiceClient.AddTrialMeasurementAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AddTrialMeasurementSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VizierServiceClient.CompleteTrial</c> and <c>VizierServiceClient.CompleteTrialAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CompleteTrialSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VizierServiceClient.DeleteTrial</c> and <c>VizierServiceClient.DeleteTrialAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteTrialSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VizierServiceClient.CheckTrialEarlyStoppingState</c> and
        /// <c>VizierServiceClient.CheckTrialEarlyStoppingStateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CheckTrialEarlyStoppingStateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>VizierServiceClient.CheckTrialEarlyStoppingState</c> and
        /// <c>VizierServiceClient.CheckTrialEarlyStoppingStateAsync</c>.
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
        public lro::OperationsSettings CheckTrialEarlyStoppingStateOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VizierServiceClient.StopTrial</c> and <c>VizierServiceClient.StopTrialAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StopTrialSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VizierServiceClient.ListOptimalTrials</c> and <c>VizierServiceClient.ListOptimalTrialsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListOptimalTrialsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="VizierServiceSettings"/> object.</returns>
        public VizierServiceSettings Clone() => new VizierServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="VizierServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class VizierServiceClientBuilder : gaxgrpc::ClientBuilderBase<VizierServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public VizierServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public VizierServiceClientBuilder() : base(VizierServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref VizierServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<VizierServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override VizierServiceClient Build()
        {
            VizierServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<VizierServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<VizierServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private VizierServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return VizierServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<VizierServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return VizierServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => VizierServiceClient.ChannelPool;
    }

    /// <summary>VizierService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Vertex AI Vizier API.
    /// 
    /// Vertex AI Vizier is a service to solve blackbox optimization problems,
    /// such as tuning machine learning hyperparameters and searching over deep
    /// learning architectures.
    /// </remarks>
    public abstract partial class VizierServiceClient
    {
        /// <summary>
        /// The default endpoint for the VizierService service, which is a host of "aiplatform.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "aiplatform.googleapis.com:443";

        /// <summary>The default VizierService scopes.</summary>
        /// <remarks>
        /// The default VizierService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(VizierService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="VizierServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="VizierServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="VizierServiceClient"/>.</returns>
        public static stt::Task<VizierServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new VizierServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="VizierServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="VizierServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="VizierServiceClient"/>.</returns>
        public static VizierServiceClient Create() => new VizierServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="VizierServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="VizierServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="VizierServiceClient"/>.</returns>
        internal static VizierServiceClient Create(grpccore::CallInvoker callInvoker, VizierServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            VizierService.VizierServiceClient grpcClient = new VizierService.VizierServiceClient(callInvoker);
            return new VizierServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC VizierService client</summary>
        public virtual VizierService.VizierServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Study. A resource name will be generated after creation of the
        /// Study.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Study CreateStudy(CreateStudyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Study. A resource name will be generated after creation of the
        /// Study.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Study> CreateStudyAsync(CreateStudyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Study. A resource name will be generated after creation of the
        /// Study.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Study> CreateStudyAsync(CreateStudyRequest request, st::CancellationToken cancellationToken) =>
            CreateStudyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Study. A resource name will be generated after creation of the
        /// Study.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the CustomJob in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="study">
        /// Required. The Study configuration used to create the Study.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Study CreateStudy(string parent, Study study, gaxgrpc::CallSettings callSettings = null) =>
            CreateStudy(new CreateStudyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Study = gax::GaxPreconditions.CheckNotNull(study, nameof(study)),
            }, callSettings);

        /// <summary>
        /// Creates a Study. A resource name will be generated after creation of the
        /// Study.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the CustomJob in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="study">
        /// Required. The Study configuration used to create the Study.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Study> CreateStudyAsync(string parent, Study study, gaxgrpc::CallSettings callSettings = null) =>
            CreateStudyAsync(new CreateStudyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Study = gax::GaxPreconditions.CheckNotNull(study, nameof(study)),
            }, callSettings);

        /// <summary>
        /// Creates a Study. A resource name will be generated after creation of the
        /// Study.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the CustomJob in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="study">
        /// Required. The Study configuration used to create the Study.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Study> CreateStudyAsync(string parent, Study study, st::CancellationToken cancellationToken) =>
            CreateStudyAsync(parent, study, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Study. A resource name will be generated after creation of the
        /// Study.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the CustomJob in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="study">
        /// Required. The Study configuration used to create the Study.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Study CreateStudy(gagr::LocationName parent, Study study, gaxgrpc::CallSettings callSettings = null) =>
            CreateStudy(new CreateStudyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Study = gax::GaxPreconditions.CheckNotNull(study, nameof(study)),
            }, callSettings);

        /// <summary>
        /// Creates a Study. A resource name will be generated after creation of the
        /// Study.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the CustomJob in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="study">
        /// Required. The Study configuration used to create the Study.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Study> CreateStudyAsync(gagr::LocationName parent, Study study, gaxgrpc::CallSettings callSettings = null) =>
            CreateStudyAsync(new CreateStudyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Study = gax::GaxPreconditions.CheckNotNull(study, nameof(study)),
            }, callSettings);

        /// <summary>
        /// Creates a Study. A resource name will be generated after creation of the
        /// Study.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the CustomJob in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="study">
        /// Required. The Study configuration used to create the Study.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Study> CreateStudyAsync(gagr::LocationName parent, Study study, st::CancellationToken cancellationToken) =>
            CreateStudyAsync(parent, study, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Study by name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Study GetStudy(GetStudyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a Study by name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Study> GetStudyAsync(GetStudyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a Study by name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Study> GetStudyAsync(GetStudyRequest request, st::CancellationToken cancellationToken) =>
            GetStudyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Study by name.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Study resource.
        /// Format: `projects/{project}/locations/{location}/studies/{study}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Study GetStudy(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetStudy(new GetStudyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Study by name.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Study resource.
        /// Format: `projects/{project}/locations/{location}/studies/{study}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Study> GetStudyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetStudyAsync(new GetStudyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Study by name.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Study resource.
        /// Format: `projects/{project}/locations/{location}/studies/{study}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Study> GetStudyAsync(string name, st::CancellationToken cancellationToken) =>
            GetStudyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Study by name.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Study resource.
        /// Format: `projects/{project}/locations/{location}/studies/{study}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Study GetStudy(StudyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetStudy(new GetStudyRequest
            {
                StudyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Study by name.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Study resource.
        /// Format: `projects/{project}/locations/{location}/studies/{study}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Study> GetStudyAsync(StudyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetStudyAsync(new GetStudyRequest
            {
                StudyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Study by name.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Study resource.
        /// Format: `projects/{project}/locations/{location}/studies/{study}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Study> GetStudyAsync(StudyName name, st::CancellationToken cancellationToken) =>
            GetStudyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all the studies in a region for an associated project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Study"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListStudiesResponse, Study> ListStudies(ListStudiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the studies in a region for an associated project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Study"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListStudiesResponse, Study> ListStudiesAsync(ListStudiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the studies in a region for an associated project.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the Study from.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="Study"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListStudiesResponse, Study> ListStudies(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListStudies(new ListStudiesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all the studies in a region for an associated project.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the Study from.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Study"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListStudiesResponse, Study> ListStudiesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListStudiesAsync(new ListStudiesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all the studies in a region for an associated project.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the Study from.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="Study"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListStudiesResponse, Study> ListStudies(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListStudies(new ListStudiesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all the studies in a region for an associated project.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the Study from.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Study"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListStudiesResponse, Study> ListStudiesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListStudiesAsync(new ListStudiesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Deletes a Study.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteStudy(DeleteStudyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Study.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteStudyAsync(DeleteStudyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Study.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteStudyAsync(DeleteStudyRequest request, st::CancellationToken cancellationToken) =>
            DeleteStudyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Study.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Study resource to be deleted.
        /// Format: `projects/{project}/locations/{location}/studies/{study}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteStudy(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteStudy(new DeleteStudyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Study.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Study resource to be deleted.
        /// Format: `projects/{project}/locations/{location}/studies/{study}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteStudyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteStudyAsync(new DeleteStudyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Study.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Study resource to be deleted.
        /// Format: `projects/{project}/locations/{location}/studies/{study}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteStudyAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteStudyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Study.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Study resource to be deleted.
        /// Format: `projects/{project}/locations/{location}/studies/{study}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteStudy(StudyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteStudy(new DeleteStudyRequest
            {
                StudyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Study.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Study resource to be deleted.
        /// Format: `projects/{project}/locations/{location}/studies/{study}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteStudyAsync(StudyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteStudyAsync(new DeleteStudyRequest
            {
                StudyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Study.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Study resource to be deleted.
        /// Format: `projects/{project}/locations/{location}/studies/{study}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteStudyAsync(StudyName name, st::CancellationToken cancellationToken) =>
            DeleteStudyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Looks a study up using the user-defined display_name field instead of the
        /// fully qualified resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Study LookupStudy(LookupStudyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Looks a study up using the user-defined display_name field instead of the
        /// fully qualified resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Study> LookupStudyAsync(LookupStudyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Looks a study up using the user-defined display_name field instead of the
        /// fully qualified resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Study> LookupStudyAsync(LookupStudyRequest request, st::CancellationToken cancellationToken) =>
            LookupStudyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Looks a study up using the user-defined display_name field instead of the
        /// fully qualified resource name.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to get the Study from.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Study LookupStudy(string parent, gaxgrpc::CallSettings callSettings = null) =>
            LookupStudy(new LookupStudyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Looks a study up using the user-defined display_name field instead of the
        /// fully qualified resource name.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to get the Study from.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Study> LookupStudyAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            LookupStudyAsync(new LookupStudyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Looks a study up using the user-defined display_name field instead of the
        /// fully qualified resource name.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to get the Study from.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Study> LookupStudyAsync(string parent, st::CancellationToken cancellationToken) =>
            LookupStudyAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Looks a study up using the user-defined display_name field instead of the
        /// fully qualified resource name.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to get the Study from.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Study LookupStudy(gagr::LocationName parent, gaxgrpc::CallSettings callSettings = null) =>
            LookupStudy(new LookupStudyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Looks a study up using the user-defined display_name field instead of the
        /// fully qualified resource name.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to get the Study from.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Study> LookupStudyAsync(gagr::LocationName parent, gaxgrpc::CallSettings callSettings = null) =>
            LookupStudyAsync(new LookupStudyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Looks a study up using the user-defined display_name field instead of the
        /// fully qualified resource name.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to get the Study from.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Study> LookupStudyAsync(gagr::LocationName parent, st::CancellationToken cancellationToken) =>
            LookupStudyAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds one or more Trials to a Study, with parameter values
        /// suggested by Vertex AI Vizier. Returns a long-running
        /// operation associated with the generation of Trial suggestions.
        /// When this long-running operation succeeds, it will contain
        /// a
        /// [SuggestTrialsResponse][google.cloud.aiplatform.v1.SuggestTrialsResponse].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<SuggestTrialsResponse, SuggestTrialsMetadata> SuggestTrials(SuggestTrialsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds one or more Trials to a Study, with parameter values
        /// suggested by Vertex AI Vizier. Returns a long-running
        /// operation associated with the generation of Trial suggestions.
        /// When this long-running operation succeeds, it will contain
        /// a
        /// [SuggestTrialsResponse][google.cloud.aiplatform.v1.SuggestTrialsResponse].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SuggestTrialsResponse, SuggestTrialsMetadata>> SuggestTrialsAsync(SuggestTrialsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds one or more Trials to a Study, with parameter values
        /// suggested by Vertex AI Vizier. Returns a long-running
        /// operation associated with the generation of Trial suggestions.
        /// When this long-running operation succeeds, it will contain
        /// a
        /// [SuggestTrialsResponse][google.cloud.aiplatform.v1.SuggestTrialsResponse].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SuggestTrialsResponse, SuggestTrialsMetadata>> SuggestTrialsAsync(SuggestTrialsRequest request, st::CancellationToken cancellationToken) =>
            SuggestTrialsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SuggestTrials</c>.</summary>
        public virtual lro::OperationsClient SuggestTrialsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SuggestTrials</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<SuggestTrialsResponse, SuggestTrialsMetadata> PollOnceSuggestTrials(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<SuggestTrialsResponse, SuggestTrialsMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SuggestTrialsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SuggestTrials</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<SuggestTrialsResponse, SuggestTrialsMetadata>> PollOnceSuggestTrialsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<SuggestTrialsResponse, SuggestTrialsMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SuggestTrialsOperationsClient, callSettings);

        /// <summary>
        /// Adds a user provided Trial to a Study.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Trial CreateTrial(CreateTrialRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds a user provided Trial to a Study.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Trial> CreateTrialAsync(CreateTrialRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds a user provided Trial to a Study.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Trial> CreateTrialAsync(CreateTrialRequest request, st::CancellationToken cancellationToken) =>
            CreateTrialAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds a user provided Trial to a Study.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Study to create the Trial in.
        /// Format: `projects/{project}/locations/{location}/studies/{study}`
        /// </param>
        /// <param name="trial">
        /// Required. The Trial to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Trial CreateTrial(string parent, Trial trial, gaxgrpc::CallSettings callSettings = null) =>
            CreateTrial(new CreateTrialRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Trial = gax::GaxPreconditions.CheckNotNull(trial, nameof(trial)),
            }, callSettings);

        /// <summary>
        /// Adds a user provided Trial to a Study.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Study to create the Trial in.
        /// Format: `projects/{project}/locations/{location}/studies/{study}`
        /// </param>
        /// <param name="trial">
        /// Required. The Trial to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Trial> CreateTrialAsync(string parent, Trial trial, gaxgrpc::CallSettings callSettings = null) =>
            CreateTrialAsync(new CreateTrialRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Trial = gax::GaxPreconditions.CheckNotNull(trial, nameof(trial)),
            }, callSettings);

        /// <summary>
        /// Adds a user provided Trial to a Study.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Study to create the Trial in.
        /// Format: `projects/{project}/locations/{location}/studies/{study}`
        /// </param>
        /// <param name="trial">
        /// Required. The Trial to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Trial> CreateTrialAsync(string parent, Trial trial, st::CancellationToken cancellationToken) =>
            CreateTrialAsync(parent, trial, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds a user provided Trial to a Study.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Study to create the Trial in.
        /// Format: `projects/{project}/locations/{location}/studies/{study}`
        /// </param>
        /// <param name="trial">
        /// Required. The Trial to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Trial CreateTrial(StudyName parent, Trial trial, gaxgrpc::CallSettings callSettings = null) =>
            CreateTrial(new CreateTrialRequest
            {
                ParentAsStudyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Trial = gax::GaxPreconditions.CheckNotNull(trial, nameof(trial)),
            }, callSettings);

        /// <summary>
        /// Adds a user provided Trial to a Study.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Study to create the Trial in.
        /// Format: `projects/{project}/locations/{location}/studies/{study}`
        /// </param>
        /// <param name="trial">
        /// Required. The Trial to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Trial> CreateTrialAsync(StudyName parent, Trial trial, gaxgrpc::CallSettings callSettings = null) =>
            CreateTrialAsync(new CreateTrialRequest
            {
                ParentAsStudyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Trial = gax::GaxPreconditions.CheckNotNull(trial, nameof(trial)),
            }, callSettings);

        /// <summary>
        /// Adds a user provided Trial to a Study.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Study to create the Trial in.
        /// Format: `projects/{project}/locations/{location}/studies/{study}`
        /// </param>
        /// <param name="trial">
        /// Required. The Trial to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Trial> CreateTrialAsync(StudyName parent, Trial trial, st::CancellationToken cancellationToken) =>
            CreateTrialAsync(parent, trial, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Trial.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Trial GetTrial(GetTrialRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a Trial.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Trial> GetTrialAsync(GetTrialRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a Trial.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Trial> GetTrialAsync(GetTrialRequest request, st::CancellationToken cancellationToken) =>
            GetTrialAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Trial.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Trial resource.
        /// Format:
        /// `projects/{project}/locations/{location}/studies/{study}/trials/{trial}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Trial GetTrial(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTrial(new GetTrialRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Trial.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Trial resource.
        /// Format:
        /// `projects/{project}/locations/{location}/studies/{study}/trials/{trial}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Trial> GetTrialAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTrialAsync(new GetTrialRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Trial.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Trial resource.
        /// Format:
        /// `projects/{project}/locations/{location}/studies/{study}/trials/{trial}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Trial> GetTrialAsync(string name, st::CancellationToken cancellationToken) =>
            GetTrialAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Trial.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Trial resource.
        /// Format:
        /// `projects/{project}/locations/{location}/studies/{study}/trials/{trial}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Trial GetTrial(TrialName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTrial(new GetTrialRequest
            {
                TrialName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Trial.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Trial resource.
        /// Format:
        /// `projects/{project}/locations/{location}/studies/{study}/trials/{trial}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Trial> GetTrialAsync(TrialName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTrialAsync(new GetTrialRequest
            {
                TrialName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Trial.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Trial resource.
        /// Format:
        /// `projects/{project}/locations/{location}/studies/{study}/trials/{trial}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Trial> GetTrialAsync(TrialName name, st::CancellationToken cancellationToken) =>
            GetTrialAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the Trials associated with a Study.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Trial"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTrialsResponse, Trial> ListTrials(ListTrialsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the Trials associated with a Study.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Trial"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTrialsResponse, Trial> ListTrialsAsync(ListTrialsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the Trials associated with a Study.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Study to list the Trial from.
        /// Format: `projects/{project}/locations/{location}/studies/{study}`
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
        /// <returns>A pageable sequence of <see cref="Trial"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTrialsResponse, Trial> ListTrials(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListTrials(new ListTrialsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists the Trials associated with a Study.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Study to list the Trial from.
        /// Format: `projects/{project}/locations/{location}/studies/{study}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Trial"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTrialsResponse, Trial> ListTrialsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListTrialsAsync(new ListTrialsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists the Trials associated with a Study.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Study to list the Trial from.
        /// Format: `projects/{project}/locations/{location}/studies/{study}`
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
        /// <returns>A pageable sequence of <see cref="Trial"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTrialsResponse, Trial> ListTrials(StudyName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListTrials(new ListTrialsRequest
            {
                ParentAsStudyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists the Trials associated with a Study.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Study to list the Trial from.
        /// Format: `projects/{project}/locations/{location}/studies/{study}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Trial"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTrialsResponse, Trial> ListTrialsAsync(StudyName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListTrialsAsync(new ListTrialsRequest
            {
                ParentAsStudyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Adds a measurement of the objective metrics to a Trial. This measurement
        /// is assumed to have been taken before the Trial is complete.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Trial AddTrialMeasurement(AddTrialMeasurementRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds a measurement of the objective metrics to a Trial. This measurement
        /// is assumed to have been taken before the Trial is complete.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Trial> AddTrialMeasurementAsync(AddTrialMeasurementRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds a measurement of the objective metrics to a Trial. This measurement
        /// is assumed to have been taken before the Trial is complete.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Trial> AddTrialMeasurementAsync(AddTrialMeasurementRequest request, st::CancellationToken cancellationToken) =>
            AddTrialMeasurementAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Marks a Trial as complete.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Trial CompleteTrial(CompleteTrialRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Marks a Trial as complete.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Trial> CompleteTrialAsync(CompleteTrialRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Marks a Trial as complete.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Trial> CompleteTrialAsync(CompleteTrialRequest request, st::CancellationToken cancellationToken) =>
            CompleteTrialAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Trial.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTrial(DeleteTrialRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Trial.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTrialAsync(DeleteTrialRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Trial.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTrialAsync(DeleteTrialRequest request, st::CancellationToken cancellationToken) =>
            DeleteTrialAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Trial.
        /// </summary>
        /// <param name="name">
        /// Required. The Trial's name.
        /// Format:
        /// `projects/{project}/locations/{location}/studies/{study}/trials/{trial}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTrial(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTrial(new DeleteTrialRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Trial.
        /// </summary>
        /// <param name="name">
        /// Required. The Trial's name.
        /// Format:
        /// `projects/{project}/locations/{location}/studies/{study}/trials/{trial}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTrialAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTrialAsync(new DeleteTrialRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Trial.
        /// </summary>
        /// <param name="name">
        /// Required. The Trial's name.
        /// Format:
        /// `projects/{project}/locations/{location}/studies/{study}/trials/{trial}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTrialAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteTrialAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Trial.
        /// </summary>
        /// <param name="name">
        /// Required. The Trial's name.
        /// Format:
        /// `projects/{project}/locations/{location}/studies/{study}/trials/{trial}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTrial(TrialName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTrial(new DeleteTrialRequest
            {
                TrialName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Trial.
        /// </summary>
        /// <param name="name">
        /// Required. The Trial's name.
        /// Format:
        /// `projects/{project}/locations/{location}/studies/{study}/trials/{trial}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTrialAsync(TrialName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTrialAsync(new DeleteTrialRequest
            {
                TrialName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Trial.
        /// </summary>
        /// <param name="name">
        /// Required. The Trial's name.
        /// Format:
        /// `projects/{project}/locations/{location}/studies/{study}/trials/{trial}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTrialAsync(TrialName name, st::CancellationToken cancellationToken) =>
            DeleteTrialAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Checks  whether a Trial should stop or not. Returns a
        /// long-running operation. When the operation is successful,
        /// it will contain a
        /// [CheckTrialEarlyStoppingStateResponse][google.cloud.aiplatform.v1.CheckTrialEarlyStoppingStateResponse].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CheckTrialEarlyStoppingStateResponse, CheckTrialEarlyStoppingStateMetatdata> CheckTrialEarlyStoppingState(CheckTrialEarlyStoppingStateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Checks  whether a Trial should stop or not. Returns a
        /// long-running operation. When the operation is successful,
        /// it will contain a
        /// [CheckTrialEarlyStoppingStateResponse][google.cloud.aiplatform.v1.CheckTrialEarlyStoppingStateResponse].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CheckTrialEarlyStoppingStateResponse, CheckTrialEarlyStoppingStateMetatdata>> CheckTrialEarlyStoppingStateAsync(CheckTrialEarlyStoppingStateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Checks  whether a Trial should stop or not. Returns a
        /// long-running operation. When the operation is successful,
        /// it will contain a
        /// [CheckTrialEarlyStoppingStateResponse][google.cloud.aiplatform.v1.CheckTrialEarlyStoppingStateResponse].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CheckTrialEarlyStoppingStateResponse, CheckTrialEarlyStoppingStateMetatdata>> CheckTrialEarlyStoppingStateAsync(CheckTrialEarlyStoppingStateRequest request, st::CancellationToken cancellationToken) =>
            CheckTrialEarlyStoppingStateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CheckTrialEarlyStoppingState</c>.</summary>
        public virtual lro::OperationsClient CheckTrialEarlyStoppingStateOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CheckTrialEarlyStoppingState</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<CheckTrialEarlyStoppingStateResponse, CheckTrialEarlyStoppingStateMetatdata> PollOnceCheckTrialEarlyStoppingState(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CheckTrialEarlyStoppingStateResponse, CheckTrialEarlyStoppingStateMetatdata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CheckTrialEarlyStoppingStateOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CheckTrialEarlyStoppingState</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<CheckTrialEarlyStoppingStateResponse, CheckTrialEarlyStoppingStateMetatdata>> PollOnceCheckTrialEarlyStoppingStateAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CheckTrialEarlyStoppingStateResponse, CheckTrialEarlyStoppingStateMetatdata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CheckTrialEarlyStoppingStateOperationsClient, callSettings);

        /// <summary>
        /// Stops a Trial.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Trial StopTrial(StopTrialRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops a Trial.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Trial> StopTrialAsync(StopTrialRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops a Trial.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Trial> StopTrialAsync(StopTrialRequest request, st::CancellationToken cancellationToken) =>
            StopTrialAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the pareto-optimal Trials for multi-objective Study or the
        /// optimal Trials for single-objective Study. The definition of
        /// pareto-optimal can be checked in wiki page.
        /// https://en.wikipedia.org/wiki/Pareto_efficiency
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListOptimalTrialsResponse ListOptimalTrials(ListOptimalTrialsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the pareto-optimal Trials for multi-objective Study or the
        /// optimal Trials for single-objective Study. The definition of
        /// pareto-optimal can be checked in wiki page.
        /// https://en.wikipedia.org/wiki/Pareto_efficiency
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListOptimalTrialsResponse> ListOptimalTrialsAsync(ListOptimalTrialsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the pareto-optimal Trials for multi-objective Study or the
        /// optimal Trials for single-objective Study. The definition of
        /// pareto-optimal can be checked in wiki page.
        /// https://en.wikipedia.org/wiki/Pareto_efficiency
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListOptimalTrialsResponse> ListOptimalTrialsAsync(ListOptimalTrialsRequest request, st::CancellationToken cancellationToken) =>
            ListOptimalTrialsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the pareto-optimal Trials for multi-objective Study or the
        /// optimal Trials for single-objective Study. The definition of
        /// pareto-optimal can be checked in wiki page.
        /// https://en.wikipedia.org/wiki/Pareto_efficiency
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the Study that the optimal Trial belongs to.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListOptimalTrialsResponse ListOptimalTrials(string parent, gaxgrpc::CallSettings callSettings = null) =>
            ListOptimalTrials(new ListOptimalTrialsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Lists the pareto-optimal Trials for multi-objective Study or the
        /// optimal Trials for single-objective Study. The definition of
        /// pareto-optimal can be checked in wiki page.
        /// https://en.wikipedia.org/wiki/Pareto_efficiency
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the Study that the optimal Trial belongs to.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListOptimalTrialsResponse> ListOptimalTrialsAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            ListOptimalTrialsAsync(new ListOptimalTrialsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Lists the pareto-optimal Trials for multi-objective Study or the
        /// optimal Trials for single-objective Study. The definition of
        /// pareto-optimal can be checked in wiki page.
        /// https://en.wikipedia.org/wiki/Pareto_efficiency
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the Study that the optimal Trial belongs to.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListOptimalTrialsResponse> ListOptimalTrialsAsync(string parent, st::CancellationToken cancellationToken) =>
            ListOptimalTrialsAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the pareto-optimal Trials for multi-objective Study or the
        /// optimal Trials for single-objective Study. The definition of
        /// pareto-optimal can be checked in wiki page.
        /// https://en.wikipedia.org/wiki/Pareto_efficiency
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the Study that the optimal Trial belongs to.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListOptimalTrialsResponse ListOptimalTrials(StudyName parent, gaxgrpc::CallSettings callSettings = null) =>
            ListOptimalTrials(new ListOptimalTrialsRequest
            {
                ParentAsStudyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Lists the pareto-optimal Trials for multi-objective Study or the
        /// optimal Trials for single-objective Study. The definition of
        /// pareto-optimal can be checked in wiki page.
        /// https://en.wikipedia.org/wiki/Pareto_efficiency
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the Study that the optimal Trial belongs to.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListOptimalTrialsResponse> ListOptimalTrialsAsync(StudyName parent, gaxgrpc::CallSettings callSettings = null) =>
            ListOptimalTrialsAsync(new ListOptimalTrialsRequest
            {
                ParentAsStudyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Lists the pareto-optimal Trials for multi-objective Study or the
        /// optimal Trials for single-objective Study. The definition of
        /// pareto-optimal can be checked in wiki page.
        /// https://en.wikipedia.org/wiki/Pareto_efficiency
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the Study that the optimal Trial belongs to.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListOptimalTrialsResponse> ListOptimalTrialsAsync(StudyName parent, st::CancellationToken cancellationToken) =>
            ListOptimalTrialsAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>VizierService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Vertex AI Vizier API.
    /// 
    /// Vertex AI Vizier is a service to solve blackbox optimization problems,
    /// such as tuning machine learning hyperparameters and searching over deep
    /// learning architectures.
    /// </remarks>
    public sealed partial class VizierServiceClientImpl : VizierServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateStudyRequest, Study> _callCreateStudy;

        private readonly gaxgrpc::ApiCall<GetStudyRequest, Study> _callGetStudy;

        private readonly gaxgrpc::ApiCall<ListStudiesRequest, ListStudiesResponse> _callListStudies;

        private readonly gaxgrpc::ApiCall<DeleteStudyRequest, wkt::Empty> _callDeleteStudy;

        private readonly gaxgrpc::ApiCall<LookupStudyRequest, Study> _callLookupStudy;

        private readonly gaxgrpc::ApiCall<SuggestTrialsRequest, lro::Operation> _callSuggestTrials;

        private readonly gaxgrpc::ApiCall<CreateTrialRequest, Trial> _callCreateTrial;

        private readonly gaxgrpc::ApiCall<GetTrialRequest, Trial> _callGetTrial;

        private readonly gaxgrpc::ApiCall<ListTrialsRequest, ListTrialsResponse> _callListTrials;

        private readonly gaxgrpc::ApiCall<AddTrialMeasurementRequest, Trial> _callAddTrialMeasurement;

        private readonly gaxgrpc::ApiCall<CompleteTrialRequest, Trial> _callCompleteTrial;

        private readonly gaxgrpc::ApiCall<DeleteTrialRequest, wkt::Empty> _callDeleteTrial;

        private readonly gaxgrpc::ApiCall<CheckTrialEarlyStoppingStateRequest, lro::Operation> _callCheckTrialEarlyStoppingState;

        private readonly gaxgrpc::ApiCall<StopTrialRequest, Trial> _callStopTrial;

        private readonly gaxgrpc::ApiCall<ListOptimalTrialsRequest, ListOptimalTrialsResponse> _callListOptimalTrials;

        /// <summary>
        /// Constructs a client wrapper for the VizierService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="VizierServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public VizierServiceClientImpl(VizierService.VizierServiceClient grpcClient, VizierServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            VizierServiceSettings effectiveSettings = settings ?? VizierServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            SuggestTrialsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.SuggestTrialsOperationsSettings, logger);
            CheckTrialEarlyStoppingStateOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CheckTrialEarlyStoppingStateOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callCreateStudy = clientHelper.BuildApiCall<CreateStudyRequest, Study>("CreateStudy", grpcClient.CreateStudyAsync, grpcClient.CreateStudy, effectiveSettings.CreateStudySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateStudy);
            Modify_CreateStudyApiCall(ref _callCreateStudy);
            _callGetStudy = clientHelper.BuildApiCall<GetStudyRequest, Study>("GetStudy", grpcClient.GetStudyAsync, grpcClient.GetStudy, effectiveSettings.GetStudySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetStudy);
            Modify_GetStudyApiCall(ref _callGetStudy);
            _callListStudies = clientHelper.BuildApiCall<ListStudiesRequest, ListStudiesResponse>("ListStudies", grpcClient.ListStudiesAsync, grpcClient.ListStudies, effectiveSettings.ListStudiesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListStudies);
            Modify_ListStudiesApiCall(ref _callListStudies);
            _callDeleteStudy = clientHelper.BuildApiCall<DeleteStudyRequest, wkt::Empty>("DeleteStudy", grpcClient.DeleteStudyAsync, grpcClient.DeleteStudy, effectiveSettings.DeleteStudySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteStudy);
            Modify_DeleteStudyApiCall(ref _callDeleteStudy);
            _callLookupStudy = clientHelper.BuildApiCall<LookupStudyRequest, Study>("LookupStudy", grpcClient.LookupStudyAsync, grpcClient.LookupStudy, effectiveSettings.LookupStudySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callLookupStudy);
            Modify_LookupStudyApiCall(ref _callLookupStudy);
            _callSuggestTrials = clientHelper.BuildApiCall<SuggestTrialsRequest, lro::Operation>("SuggestTrials", grpcClient.SuggestTrialsAsync, grpcClient.SuggestTrials, effectiveSettings.SuggestTrialsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callSuggestTrials);
            Modify_SuggestTrialsApiCall(ref _callSuggestTrials);
            _callCreateTrial = clientHelper.BuildApiCall<CreateTrialRequest, Trial>("CreateTrial", grpcClient.CreateTrialAsync, grpcClient.CreateTrial, effectiveSettings.CreateTrialSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateTrial);
            Modify_CreateTrialApiCall(ref _callCreateTrial);
            _callGetTrial = clientHelper.BuildApiCall<GetTrialRequest, Trial>("GetTrial", grpcClient.GetTrialAsync, grpcClient.GetTrial, effectiveSettings.GetTrialSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTrial);
            Modify_GetTrialApiCall(ref _callGetTrial);
            _callListTrials = clientHelper.BuildApiCall<ListTrialsRequest, ListTrialsResponse>("ListTrials", grpcClient.ListTrialsAsync, grpcClient.ListTrials, effectiveSettings.ListTrialsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTrials);
            Modify_ListTrialsApiCall(ref _callListTrials);
            _callAddTrialMeasurement = clientHelper.BuildApiCall<AddTrialMeasurementRequest, Trial>("AddTrialMeasurement", grpcClient.AddTrialMeasurementAsync, grpcClient.AddTrialMeasurement, effectiveSettings.AddTrialMeasurementSettings).WithGoogleRequestParam("trial_name", request => request.TrialName);
            Modify_ApiCall(ref _callAddTrialMeasurement);
            Modify_AddTrialMeasurementApiCall(ref _callAddTrialMeasurement);
            _callCompleteTrial = clientHelper.BuildApiCall<CompleteTrialRequest, Trial>("CompleteTrial", grpcClient.CompleteTrialAsync, grpcClient.CompleteTrial, effectiveSettings.CompleteTrialSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCompleteTrial);
            Modify_CompleteTrialApiCall(ref _callCompleteTrial);
            _callDeleteTrial = clientHelper.BuildApiCall<DeleteTrialRequest, wkt::Empty>("DeleteTrial", grpcClient.DeleteTrialAsync, grpcClient.DeleteTrial, effectiveSettings.DeleteTrialSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteTrial);
            Modify_DeleteTrialApiCall(ref _callDeleteTrial);
            _callCheckTrialEarlyStoppingState = clientHelper.BuildApiCall<CheckTrialEarlyStoppingStateRequest, lro::Operation>("CheckTrialEarlyStoppingState", grpcClient.CheckTrialEarlyStoppingStateAsync, grpcClient.CheckTrialEarlyStoppingState, effectiveSettings.CheckTrialEarlyStoppingStateSettings).WithGoogleRequestParam("trial_name", request => request.TrialName);
            Modify_ApiCall(ref _callCheckTrialEarlyStoppingState);
            Modify_CheckTrialEarlyStoppingStateApiCall(ref _callCheckTrialEarlyStoppingState);
            _callStopTrial = clientHelper.BuildApiCall<StopTrialRequest, Trial>("StopTrial", grpcClient.StopTrialAsync, grpcClient.StopTrial, effectiveSettings.StopTrialSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callStopTrial);
            Modify_StopTrialApiCall(ref _callStopTrial);
            _callListOptimalTrials = clientHelper.BuildApiCall<ListOptimalTrialsRequest, ListOptimalTrialsResponse>("ListOptimalTrials", grpcClient.ListOptimalTrialsAsync, grpcClient.ListOptimalTrials, effectiveSettings.ListOptimalTrialsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListOptimalTrials);
            Modify_ListOptimalTrialsApiCall(ref _callListOptimalTrials);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateStudyApiCall(ref gaxgrpc::ApiCall<CreateStudyRequest, Study> call);

        partial void Modify_GetStudyApiCall(ref gaxgrpc::ApiCall<GetStudyRequest, Study> call);

        partial void Modify_ListStudiesApiCall(ref gaxgrpc::ApiCall<ListStudiesRequest, ListStudiesResponse> call);

        partial void Modify_DeleteStudyApiCall(ref gaxgrpc::ApiCall<DeleteStudyRequest, wkt::Empty> call);

        partial void Modify_LookupStudyApiCall(ref gaxgrpc::ApiCall<LookupStudyRequest, Study> call);

        partial void Modify_SuggestTrialsApiCall(ref gaxgrpc::ApiCall<SuggestTrialsRequest, lro::Operation> call);

        partial void Modify_CreateTrialApiCall(ref gaxgrpc::ApiCall<CreateTrialRequest, Trial> call);

        partial void Modify_GetTrialApiCall(ref gaxgrpc::ApiCall<GetTrialRequest, Trial> call);

        partial void Modify_ListTrialsApiCall(ref gaxgrpc::ApiCall<ListTrialsRequest, ListTrialsResponse> call);

        partial void Modify_AddTrialMeasurementApiCall(ref gaxgrpc::ApiCall<AddTrialMeasurementRequest, Trial> call);

        partial void Modify_CompleteTrialApiCall(ref gaxgrpc::ApiCall<CompleteTrialRequest, Trial> call);

        partial void Modify_DeleteTrialApiCall(ref gaxgrpc::ApiCall<DeleteTrialRequest, wkt::Empty> call);

        partial void Modify_CheckTrialEarlyStoppingStateApiCall(ref gaxgrpc::ApiCall<CheckTrialEarlyStoppingStateRequest, lro::Operation> call);

        partial void Modify_StopTrialApiCall(ref gaxgrpc::ApiCall<StopTrialRequest, Trial> call);

        partial void Modify_ListOptimalTrialsApiCall(ref gaxgrpc::ApiCall<ListOptimalTrialsRequest, ListOptimalTrialsResponse> call);

        partial void OnConstruction(VizierService.VizierServiceClient grpcClient, VizierServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC VizierService client</summary>
        public override VizierService.VizierServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_CreateStudyRequest(ref CreateStudyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetStudyRequest(ref GetStudyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListStudiesRequest(ref ListStudiesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteStudyRequest(ref DeleteStudyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_LookupStudyRequest(ref LookupStudyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SuggestTrialsRequest(ref SuggestTrialsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateTrialRequest(ref CreateTrialRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTrialRequest(ref GetTrialRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTrialsRequest(ref ListTrialsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AddTrialMeasurementRequest(ref AddTrialMeasurementRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CompleteTrialRequest(ref CompleteTrialRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteTrialRequest(ref DeleteTrialRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CheckTrialEarlyStoppingStateRequest(ref CheckTrialEarlyStoppingStateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StopTrialRequest(ref StopTrialRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListOptimalTrialsRequest(ref ListOptimalTrialsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a Study. A resource name will be generated after creation of the
        /// Study.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Study CreateStudy(CreateStudyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateStudyRequest(ref request, ref callSettings);
            return _callCreateStudy.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a Study. A resource name will be generated after creation of the
        /// Study.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Study> CreateStudyAsync(CreateStudyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateStudyRequest(ref request, ref callSettings);
            return _callCreateStudy.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a Study by name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Study GetStudy(GetStudyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetStudyRequest(ref request, ref callSettings);
            return _callGetStudy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a Study by name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Study> GetStudyAsync(GetStudyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetStudyRequest(ref request, ref callSettings);
            return _callGetStudy.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all the studies in a region for an associated project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Study"/> resources.</returns>
        public override gax::PagedEnumerable<ListStudiesResponse, Study> ListStudies(ListStudiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListStudiesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListStudiesRequest, ListStudiesResponse, Study>(_callListStudies, request, callSettings);
        }

        /// <summary>
        /// Lists all the studies in a region for an associated project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Study"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListStudiesResponse, Study> ListStudiesAsync(ListStudiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListStudiesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListStudiesRequest, ListStudiesResponse, Study>(_callListStudies, request, callSettings);
        }

        /// <summary>
        /// Deletes a Study.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteStudy(DeleteStudyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteStudyRequest(ref request, ref callSettings);
            _callDeleteStudy.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a Study.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteStudyAsync(DeleteStudyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteStudyRequest(ref request, ref callSettings);
            return _callDeleteStudy.Async(request, callSettings);
        }

        /// <summary>
        /// Looks a study up using the user-defined display_name field instead of the
        /// fully qualified resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Study LookupStudy(LookupStudyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LookupStudyRequest(ref request, ref callSettings);
            return _callLookupStudy.Sync(request, callSettings);
        }

        /// <summary>
        /// Looks a study up using the user-defined display_name field instead of the
        /// fully qualified resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Study> LookupStudyAsync(LookupStudyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LookupStudyRequest(ref request, ref callSettings);
            return _callLookupStudy.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>SuggestTrials</c>.</summary>
        public override lro::OperationsClient SuggestTrialsOperationsClient { get; }

        /// <summary>
        /// Adds one or more Trials to a Study, with parameter values
        /// suggested by Vertex AI Vizier. Returns a long-running
        /// operation associated with the generation of Trial suggestions.
        /// When this long-running operation succeeds, it will contain
        /// a
        /// [SuggestTrialsResponse][google.cloud.aiplatform.v1.SuggestTrialsResponse].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<SuggestTrialsResponse, SuggestTrialsMetadata> SuggestTrials(SuggestTrialsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SuggestTrialsRequest(ref request, ref callSettings);
            return new lro::Operation<SuggestTrialsResponse, SuggestTrialsMetadata>(_callSuggestTrials.Sync(request, callSettings), SuggestTrialsOperationsClient);
        }

        /// <summary>
        /// Adds one or more Trials to a Study, with parameter values
        /// suggested by Vertex AI Vizier. Returns a long-running
        /// operation associated with the generation of Trial suggestions.
        /// When this long-running operation succeeds, it will contain
        /// a
        /// [SuggestTrialsResponse][google.cloud.aiplatform.v1.SuggestTrialsResponse].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<SuggestTrialsResponse, SuggestTrialsMetadata>> SuggestTrialsAsync(SuggestTrialsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SuggestTrialsRequest(ref request, ref callSettings);
            return new lro::Operation<SuggestTrialsResponse, SuggestTrialsMetadata>(await _callSuggestTrials.Async(request, callSettings).ConfigureAwait(false), SuggestTrialsOperationsClient);
        }

        /// <summary>
        /// Adds a user provided Trial to a Study.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Trial CreateTrial(CreateTrialRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTrialRequest(ref request, ref callSettings);
            return _callCreateTrial.Sync(request, callSettings);
        }

        /// <summary>
        /// Adds a user provided Trial to a Study.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Trial> CreateTrialAsync(CreateTrialRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTrialRequest(ref request, ref callSettings);
            return _callCreateTrial.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a Trial.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Trial GetTrial(GetTrialRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTrialRequest(ref request, ref callSettings);
            return _callGetTrial.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a Trial.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Trial> GetTrialAsync(GetTrialRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTrialRequest(ref request, ref callSettings);
            return _callGetTrial.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the Trials associated with a Study.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Trial"/> resources.</returns>
        public override gax::PagedEnumerable<ListTrialsResponse, Trial> ListTrials(ListTrialsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTrialsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTrialsRequest, ListTrialsResponse, Trial>(_callListTrials, request, callSettings);
        }

        /// <summary>
        /// Lists the Trials associated with a Study.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Trial"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTrialsResponse, Trial> ListTrialsAsync(ListTrialsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTrialsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTrialsRequest, ListTrialsResponse, Trial>(_callListTrials, request, callSettings);
        }

        /// <summary>
        /// Adds a measurement of the objective metrics to a Trial. This measurement
        /// is assumed to have been taken before the Trial is complete.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Trial AddTrialMeasurement(AddTrialMeasurementRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddTrialMeasurementRequest(ref request, ref callSettings);
            return _callAddTrialMeasurement.Sync(request, callSettings);
        }

        /// <summary>
        /// Adds a measurement of the objective metrics to a Trial. This measurement
        /// is assumed to have been taken before the Trial is complete.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Trial> AddTrialMeasurementAsync(AddTrialMeasurementRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddTrialMeasurementRequest(ref request, ref callSettings);
            return _callAddTrialMeasurement.Async(request, callSettings);
        }

        /// <summary>
        /// Marks a Trial as complete.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Trial CompleteTrial(CompleteTrialRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CompleteTrialRequest(ref request, ref callSettings);
            return _callCompleteTrial.Sync(request, callSettings);
        }

        /// <summary>
        /// Marks a Trial as complete.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Trial> CompleteTrialAsync(CompleteTrialRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CompleteTrialRequest(ref request, ref callSettings);
            return _callCompleteTrial.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a Trial.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteTrial(DeleteTrialRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTrialRequest(ref request, ref callSettings);
            _callDeleteTrial.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a Trial.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteTrialAsync(DeleteTrialRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTrialRequest(ref request, ref callSettings);
            return _callDeleteTrial.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CheckTrialEarlyStoppingState</c>.</summary>
        public override lro::OperationsClient CheckTrialEarlyStoppingStateOperationsClient { get; }

        /// <summary>
        /// Checks  whether a Trial should stop or not. Returns a
        /// long-running operation. When the operation is successful,
        /// it will contain a
        /// [CheckTrialEarlyStoppingStateResponse][google.cloud.aiplatform.v1.CheckTrialEarlyStoppingStateResponse].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<CheckTrialEarlyStoppingStateResponse, CheckTrialEarlyStoppingStateMetatdata> CheckTrialEarlyStoppingState(CheckTrialEarlyStoppingStateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CheckTrialEarlyStoppingStateRequest(ref request, ref callSettings);
            return new lro::Operation<CheckTrialEarlyStoppingStateResponse, CheckTrialEarlyStoppingStateMetatdata>(_callCheckTrialEarlyStoppingState.Sync(request, callSettings), CheckTrialEarlyStoppingStateOperationsClient);
        }

        /// <summary>
        /// Checks  whether a Trial should stop or not. Returns a
        /// long-running operation. When the operation is successful,
        /// it will contain a
        /// [CheckTrialEarlyStoppingStateResponse][google.cloud.aiplatform.v1.CheckTrialEarlyStoppingStateResponse].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<CheckTrialEarlyStoppingStateResponse, CheckTrialEarlyStoppingStateMetatdata>> CheckTrialEarlyStoppingStateAsync(CheckTrialEarlyStoppingStateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CheckTrialEarlyStoppingStateRequest(ref request, ref callSettings);
            return new lro::Operation<CheckTrialEarlyStoppingStateResponse, CheckTrialEarlyStoppingStateMetatdata>(await _callCheckTrialEarlyStoppingState.Async(request, callSettings).ConfigureAwait(false), CheckTrialEarlyStoppingStateOperationsClient);
        }

        /// <summary>
        /// Stops a Trial.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Trial StopTrial(StopTrialRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StopTrialRequest(ref request, ref callSettings);
            return _callStopTrial.Sync(request, callSettings);
        }

        /// <summary>
        /// Stops a Trial.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Trial> StopTrialAsync(StopTrialRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StopTrialRequest(ref request, ref callSettings);
            return _callStopTrial.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the pareto-optimal Trials for multi-objective Study or the
        /// optimal Trials for single-objective Study. The definition of
        /// pareto-optimal can be checked in wiki page.
        /// https://en.wikipedia.org/wiki/Pareto_efficiency
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ListOptimalTrialsResponse ListOptimalTrials(ListOptimalTrialsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOptimalTrialsRequest(ref request, ref callSettings);
            return _callListOptimalTrials.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists the pareto-optimal Trials for multi-objective Study or the
        /// optimal Trials for single-objective Study. The definition of
        /// pareto-optimal can be checked in wiki page.
        /// https://en.wikipedia.org/wiki/Pareto_efficiency
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ListOptimalTrialsResponse> ListOptimalTrialsAsync(ListOptimalTrialsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOptimalTrialsRequest(ref request, ref callSettings);
            return _callListOptimalTrials.Async(request, callSettings);
        }
    }

    public partial class ListStudiesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTrialsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListStudiesResponse : gaxgrpc::IPageResponse<Study>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Study> GetEnumerator() => Studies.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListTrialsResponse : gaxgrpc::IPageResponse<Trial>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Trial> GetEnumerator() => Trials.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class VizierService
    {
        public partial class VizierServiceClient
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

    public static partial class VizierService
    {
        public partial class VizierServiceClient
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
