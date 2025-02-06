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
using gciv = Google.Cloud.Iam.V1;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.DevTools.ContainerAnalysis.V1
{
    /// <summary>Settings for <see cref="ContainerAnalysisClient"/> instances.</summary>
    public sealed partial class ContainerAnalysisSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ContainerAnalysisSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ContainerAnalysisSettings"/>.</returns>
        public static ContainerAnalysisSettings GetDefault() => new ContainerAnalysisSettings();

        /// <summary>Constructs a new <see cref="ContainerAnalysisSettings"/> object with default settings.</summary>
        public ContainerAnalysisSettings()
        {
        }

        private ContainerAnalysisSettings(ContainerAnalysisSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            SetIamPolicySettings = existing.SetIamPolicySettings;
            GetIamPolicySettings = existing.GetIamPolicySettings;
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
            GetVulnerabilityOccurrencesSummarySettings = existing.GetVulnerabilityOccurrencesSummarySettings;
            OnCopy(existing);
        }

        partial void OnCopy(ContainerAnalysisSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContainerAnalysisClient.SetIamPolicy</c> and <c>ContainerAnalysisClient.SetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContainerAnalysisClient.GetIamPolicy</c> and <c>ContainerAnalysisClient.GetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContainerAnalysisClient.TestIamPermissions</c> and <c>ContainerAnalysisClient.TestIamPermissionsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TestIamPermissionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContainerAnalysisClient.GetVulnerabilityOccurrencesSummary</c> and
        /// <c>ContainerAnalysisClient.GetVulnerabilityOccurrencesSummaryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetVulnerabilityOccurrencesSummarySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ContainerAnalysisSettings"/> object.</returns>
        public ContainerAnalysisSettings Clone() => new ContainerAnalysisSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ContainerAnalysisClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class ContainerAnalysisClientBuilder : gaxgrpc::ClientBuilderBase<ContainerAnalysisClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ContainerAnalysisSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ContainerAnalysisClientBuilder() : base(ContainerAnalysisClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ContainerAnalysisClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ContainerAnalysisClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ContainerAnalysisClient Build()
        {
            ContainerAnalysisClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ContainerAnalysisClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ContainerAnalysisClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ContainerAnalysisClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ContainerAnalysisClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ContainerAnalysisClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ContainerAnalysisClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ContainerAnalysisClient.ChannelPool;
    }

    /// <summary>ContainerAnalysis client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Retrieves analysis results of Cloud components such as Docker container
    /// images. The Container Analysis API is an implementation of the
    /// [Grafeas](https://grafeas.io) API.
    /// 
    /// Analysis results are stored as a series of occurrences. An `Occurrence`
    /// contains information about a specific analysis instance on a resource. An
    /// occurrence refers to a `Note`. A note contains details describing the
    /// analysis and is generally stored in a separate project, called a `Provider`.
    /// Multiple occurrences can refer to the same note.
    /// 
    /// For example, an SSL vulnerability could affect multiple images. In this case,
    /// there would be one note for the vulnerability and an occurrence for each
    /// image with the vulnerability referring to that note.
    /// </remarks>
    public abstract partial class ContainerAnalysisClient
    {
        /// <summary>
        /// The default endpoint for the ContainerAnalysis service, which is a host of
        /// "containeranalysis.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "containeranalysis.googleapis.com:443";

        /// <summary>The default ContainerAnalysis scopes.</summary>
        /// <remarks>
        /// The default ContainerAnalysis scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ContainerAnalysis.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ContainerAnalysisClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ContainerAnalysisClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ContainerAnalysisClient"/>.</returns>
        public static stt::Task<ContainerAnalysisClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ContainerAnalysisClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ContainerAnalysisClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ContainerAnalysisClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ContainerAnalysisClient"/>.</returns>
        public static ContainerAnalysisClient Create() => new ContainerAnalysisClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ContainerAnalysisClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ContainerAnalysisSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ContainerAnalysisClient"/>.</returns>
        internal static ContainerAnalysisClient Create(grpccore::CallInvoker callInvoker, ContainerAnalysisSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ContainerAnalysis.ContainerAnalysisClient grpcClient = new ContainerAnalysis.ContainerAnalysisClient(callInvoker);
            return new ContainerAnalysisClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ContainerAnalysis client</summary>
        public virtual ContainerAnalysis.ContainerAnalysisClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the access control policy on the specified note or occurrence.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or an occurrence, respectively.
        /// 
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the access control policy on the specified note or occurrence.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or an occurrence, respectively.
        /// 
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the access control policy on the specified note or occurrence.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or an occurrence, respectively.
        /// 
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on the specified note or occurrence.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or an occurrence, respectively.
        /// 
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(string resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicy(new gciv::SetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Sets the access control policy on the specified note or occurrence.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or an occurrence, respectively.
        /// 
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(string resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicyAsync(new gciv::SetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Sets the access control policy on the specified note or occurrence.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or an occurrence, respectively.
        /// 
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(string resource, gciv::Policy policy, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(resource, policy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on the specified note or occurrence.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or an occurrence, respectively.
        /// 
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(gax::IResourceName resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicy(new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Sets the access control policy on the specified note or occurrence.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or an occurrence, respectively.
        /// 
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gax::IResourceName resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicyAsync(new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Sets the access control policy on the specified note or occurrence.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or an occurrence, respectively.
        /// 
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gax::IResourceName resource, gciv::Policy policy, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(resource, policy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a note or an occurrence resource.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or occurrence, respectively.
        /// 
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the access control policy for a note or an occurrence resource.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or occurrence, respectively.
        /// 
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the access control policy for a note or an occurrence resource.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or occurrence, respectively.
        /// 
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a note or an occurrence resource.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or occurrence, respectively.
        /// 
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(string resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicy(new gciv::GetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for a note or an occurrence resource.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or occurrence, respectively.
        /// 
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(string resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicyAsync(new gciv::GetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for a note or an occurrence resource.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or occurrence, respectively.
        /// 
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(string resource, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a note or an occurrence resource.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or occurrence, respectively.
        /// 
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(gax::IResourceName resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicy(new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for a note or an occurrence resource.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or occurrence, respectively.
        /// 
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gax::IResourceName resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicyAsync(new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for a note or an occurrence resource.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or occurrence, respectively.
        /// 
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gax::IResourceName resource, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the permissions that a caller has on the specified note or
        /// occurrence. Requires list permission on the project (for example,
        /// `containeranalysis.notes.list`).
        /// 
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the permissions that a caller has on the specified note or
        /// occurrence. Requires list permission on the project (for example,
        /// `containeranalysis.notes.list`).
        /// 
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the permissions that a caller has on the specified note or
        /// occurrence. Requires list permission on the project (for example,
        /// `containeranalysis.notes.list`).
        /// 
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the permissions that a caller has on the specified note or
        /// occurrence. Requires list permission on the project (for example,
        /// `containeranalysis.notes.list`).
        /// 
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(string resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissions(new gciv::TestIamPermissionsRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Returns the permissions that a caller has on the specified note or
        /// occurrence. Requires list permission on the project (for example,
        /// `containeranalysis.notes.list`).
        /// 
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(string resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissionsAsync(new gciv::TestIamPermissionsRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Returns the permissions that a caller has on the specified note or
        /// occurrence. Requires list permission on the project (for example,
        /// `containeranalysis.notes.list`).
        /// 
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(string resource, scg::IEnumerable<string> permissions, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(resource, permissions, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the permissions that a caller has on the specified note or
        /// occurrence. Requires list permission on the project (for example,
        /// `containeranalysis.notes.list`).
        /// 
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(gax::IResourceName resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissions(new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Returns the permissions that a caller has on the specified note or
        /// occurrence. Requires list permission on the project (for example,
        /// `containeranalysis.notes.list`).
        /// 
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gax::IResourceName resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissionsAsync(new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Returns the permissions that a caller has on the specified note or
        /// occurrence. Requires list permission on the project (for example,
        /// `containeranalysis.notes.list`).
        /// 
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gax::IResourceName resource, scg::IEnumerable<string> permissions, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(resource, permissions, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a summary of the number and severity of occurrences.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VulnerabilityOccurrencesSummary GetVulnerabilityOccurrencesSummary(GetVulnerabilityOccurrencesSummaryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a summary of the number and severity of occurrences.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VulnerabilityOccurrencesSummary> GetVulnerabilityOccurrencesSummaryAsync(GetVulnerabilityOccurrencesSummaryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a summary of the number and severity of occurrences.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VulnerabilityOccurrencesSummary> GetVulnerabilityOccurrencesSummaryAsync(GetVulnerabilityOccurrencesSummaryRequest request, st::CancellationToken cancellationToken) =>
            GetVulnerabilityOccurrencesSummaryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a summary of the number and severity of occurrences.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project to get a vulnerability summary for in the form of
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="filter">
        /// The filter expression.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VulnerabilityOccurrencesSummary GetVulnerabilityOccurrencesSummary(string parent, string filter, gaxgrpc::CallSettings callSettings = null) =>
            GetVulnerabilityOccurrencesSummary(new GetVulnerabilityOccurrencesSummaryRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Filter = filter ?? "",
            }, callSettings);

        /// <summary>
        /// Gets a summary of the number and severity of occurrences.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project to get a vulnerability summary for in the form of
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="filter">
        /// The filter expression.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VulnerabilityOccurrencesSummary> GetVulnerabilityOccurrencesSummaryAsync(string parent, string filter, gaxgrpc::CallSettings callSettings = null) =>
            GetVulnerabilityOccurrencesSummaryAsync(new GetVulnerabilityOccurrencesSummaryRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Filter = filter ?? "",
            }, callSettings);

        /// <summary>
        /// Gets a summary of the number and severity of occurrences.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project to get a vulnerability summary for in the form of
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="filter">
        /// The filter expression.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VulnerabilityOccurrencesSummary> GetVulnerabilityOccurrencesSummaryAsync(string parent, string filter, st::CancellationToken cancellationToken) =>
            GetVulnerabilityOccurrencesSummaryAsync(parent, filter, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a summary of the number and severity of occurrences.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project to get a vulnerability summary for in the form of
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="filter">
        /// The filter expression.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VulnerabilityOccurrencesSummary GetVulnerabilityOccurrencesSummary(gagr::ProjectName parent, string filter, gaxgrpc::CallSettings callSettings = null) =>
            GetVulnerabilityOccurrencesSummary(new GetVulnerabilityOccurrencesSummaryRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Filter = filter ?? "",
            }, callSettings);

        /// <summary>
        /// Gets a summary of the number and severity of occurrences.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project to get a vulnerability summary for in the form of
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="filter">
        /// The filter expression.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VulnerabilityOccurrencesSummary> GetVulnerabilityOccurrencesSummaryAsync(gagr::ProjectName parent, string filter, gaxgrpc::CallSettings callSettings = null) =>
            GetVulnerabilityOccurrencesSummaryAsync(new GetVulnerabilityOccurrencesSummaryRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Filter = filter ?? "",
            }, callSettings);

        /// <summary>
        /// Gets a summary of the number and severity of occurrences.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project to get a vulnerability summary for in the form of
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="filter">
        /// The filter expression.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VulnerabilityOccurrencesSummary> GetVulnerabilityOccurrencesSummaryAsync(gagr::ProjectName parent, string filter, st::CancellationToken cancellationToken) =>
            GetVulnerabilityOccurrencesSummaryAsync(parent, filter, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ContainerAnalysis client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Retrieves analysis results of Cloud components such as Docker container
    /// images. The Container Analysis API is an implementation of the
    /// [Grafeas](https://grafeas.io) API.
    /// 
    /// Analysis results are stored as a series of occurrences. An `Occurrence`
    /// contains information about a specific analysis instance on a resource. An
    /// occurrence refers to a `Note`. A note contains details describing the
    /// analysis and is generally stored in a separate project, called a `Provider`.
    /// Multiple occurrences can refer to the same note.
    /// 
    /// For example, an SSL vulnerability could affect multiple images. In this case,
    /// there would be one note for the vulnerability and an occurrence for each
    /// image with the vulnerability referring to that note.
    /// </remarks>
    public sealed partial class ContainerAnalysisClientImpl : ContainerAnalysisClient
    {
        private readonly gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> _callSetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> _callGetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> _callTestIamPermissions;

        private readonly gaxgrpc::ApiCall<GetVulnerabilityOccurrencesSummaryRequest, VulnerabilityOccurrencesSummary> _callGetVulnerabilityOccurrencesSummary;

        /// <summary>
        /// Constructs a client wrapper for the ContainerAnalysis service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ContainerAnalysisSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ContainerAnalysisClientImpl(ContainerAnalysis.ContainerAnalysisClient grpcClient, ContainerAnalysisSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ContainerAnalysisSettings effectiveSettings = settings ?? ContainerAnalysisSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callSetIamPolicy = clientHelper.BuildApiCall<gciv::SetIamPolicyRequest, gciv::Policy>("SetIamPolicy", grpcClient.SetIamPolicyAsync, grpcClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callSetIamPolicy);
            Modify_SetIamPolicyApiCall(ref _callSetIamPolicy);
            _callGetIamPolicy = clientHelper.BuildApiCall<gciv::GetIamPolicyRequest, gciv::Policy>("GetIamPolicy", grpcClient.GetIamPolicyAsync, grpcClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callGetIamPolicy);
            Modify_GetIamPolicyApiCall(ref _callGetIamPolicy);
            _callTestIamPermissions = clientHelper.BuildApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse>("TestIamPermissions", grpcClient.TestIamPermissionsAsync, grpcClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callTestIamPermissions);
            Modify_TestIamPermissionsApiCall(ref _callTestIamPermissions);
            _callGetVulnerabilityOccurrencesSummary = clientHelper.BuildApiCall<GetVulnerabilityOccurrencesSummaryRequest, VulnerabilityOccurrencesSummary>("GetVulnerabilityOccurrencesSummary", grpcClient.GetVulnerabilityOccurrencesSummaryAsync, grpcClient.GetVulnerabilityOccurrencesSummary, effectiveSettings.GetVulnerabilityOccurrencesSummarySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callGetVulnerabilityOccurrencesSummary);
            Modify_GetVulnerabilityOccurrencesSummaryApiCall(ref _callGetVulnerabilityOccurrencesSummary);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_SetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_GetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_TestIamPermissionsApiCall(ref gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> call);

        partial void Modify_GetVulnerabilityOccurrencesSummaryApiCall(ref gaxgrpc::ApiCall<GetVulnerabilityOccurrencesSummaryRequest, VulnerabilityOccurrencesSummary> call);

        partial void OnConstruction(ContainerAnalysis.ContainerAnalysisClient grpcClient, ContainerAnalysisSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ContainerAnalysis client</summary>
        public override ContainerAnalysis.ContainerAnalysisClient GrpcClient { get; }

        partial void Modify_SetIamPolicyRequest(ref gciv::SetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIamPolicyRequest(ref gciv::GetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TestIamPermissionsRequest(ref gciv::TestIamPermissionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetVulnerabilityOccurrencesSummaryRequest(ref GetVulnerabilityOccurrencesSummaryRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Sets the access control policy on the specified note or occurrence.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or an occurrence, respectively.
        /// 
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the access control policy on the specified note or occurrence.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or an occurrence, respectively.
        /// 
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the access control policy for a note or an occurrence resource.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or occurrence, respectively.
        /// 
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the access control policy for a note or an occurrence resource.
        /// Requires `containeranalysis.notes.setIamPolicy` or
        /// `containeranalysis.occurrences.setIamPolicy` permission if the resource is
        /// a note or occurrence, respectively.
        /// 
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the permissions that a caller has on the specified note or
        /// occurrence. Requires list permission on the project (for example,
        /// `containeranalysis.notes.list`).
        /// 
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the permissions that a caller has on the specified note or
        /// occurrence. Requires list permission on the project (for example,
        /// `containeranalysis.notes.list`).
        /// 
        /// The resource takes the format `projects/[PROJECT_ID]/notes/[NOTE_ID]` for
        /// notes and `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]` for
        /// occurrences.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a summary of the number and severity of occurrences.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override VulnerabilityOccurrencesSummary GetVulnerabilityOccurrencesSummary(GetVulnerabilityOccurrencesSummaryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVulnerabilityOccurrencesSummaryRequest(ref request, ref callSettings);
            return _callGetVulnerabilityOccurrencesSummary.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a summary of the number and severity of occurrences.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<VulnerabilityOccurrencesSummary> GetVulnerabilityOccurrencesSummaryAsync(GetVulnerabilityOccurrencesSummaryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVulnerabilityOccurrencesSummaryRequest(ref request, ref callSettings);
            return _callGetVulnerabilityOccurrencesSummary.Async(request, callSettings);
        }
    }
}
