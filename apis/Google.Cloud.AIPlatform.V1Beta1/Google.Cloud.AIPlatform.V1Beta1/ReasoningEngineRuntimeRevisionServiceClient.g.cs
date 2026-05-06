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

namespace Google.Cloud.AIPlatform.V1Beta1
{
    /// <summary>Settings for <see cref="ReasoningEngineRuntimeRevisionServiceClient"/> instances.</summary>
    public sealed partial class ReasoningEngineRuntimeRevisionServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="ReasoningEngineRuntimeRevisionServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="ReasoningEngineRuntimeRevisionServiceSettings"/>.
        /// </returns>
        public static ReasoningEngineRuntimeRevisionServiceSettings GetDefault() =>
            new ReasoningEngineRuntimeRevisionServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ReasoningEngineRuntimeRevisionServiceSettings"/> object with default settings.
        /// </summary>
        public ReasoningEngineRuntimeRevisionServiceSettings()
        {
        }

        private ReasoningEngineRuntimeRevisionServiceSettings(ReasoningEngineRuntimeRevisionServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetReasoningEngineRuntimeRevisionSettings = existing.GetReasoningEngineRuntimeRevisionSettings;
            ListReasoningEngineRuntimeRevisionsSettings = existing.ListReasoningEngineRuntimeRevisionsSettings;
            DeleteReasoningEngineRuntimeRevisionSettings = existing.DeleteReasoningEngineRuntimeRevisionSettings;
            DeleteReasoningEngineRuntimeRevisionOperationsSettings = existing.DeleteReasoningEngineRuntimeRevisionOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(ReasoningEngineRuntimeRevisionServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReasoningEngineRuntimeRevisionServiceClient.GetReasoningEngineRuntimeRevision</c> and
        /// <c>ReasoningEngineRuntimeRevisionServiceClient.GetReasoningEngineRuntimeRevisionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetReasoningEngineRuntimeRevisionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReasoningEngineRuntimeRevisionServiceClient.ListReasoningEngineRuntimeRevisions</c> and
        /// <c>ReasoningEngineRuntimeRevisionServiceClient.ListReasoningEngineRuntimeRevisionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListReasoningEngineRuntimeRevisionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReasoningEngineRuntimeRevisionServiceClient.DeleteReasoningEngineRuntimeRevision</c> and
        /// <c>ReasoningEngineRuntimeRevisionServiceClient.DeleteReasoningEngineRuntimeRevisionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteReasoningEngineRuntimeRevisionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to
        /// <c>ReasoningEngineRuntimeRevisionServiceClient.DeleteReasoningEngineRuntimeRevision</c> and
        /// <c>ReasoningEngineRuntimeRevisionServiceClient.DeleteReasoningEngineRuntimeRevisionAsync</c>.
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
        public lro::OperationsSettings DeleteReasoningEngineRuntimeRevisionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ReasoningEngineRuntimeRevisionServiceSettings"/> object.</returns>
        public ReasoningEngineRuntimeRevisionServiceSettings Clone() =>
            new ReasoningEngineRuntimeRevisionServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ReasoningEngineRuntimeRevisionServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class ReasoningEngineRuntimeRevisionServiceClientBuilder : gaxgrpc::ClientBuilderBase<ReasoningEngineRuntimeRevisionServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ReasoningEngineRuntimeRevisionServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ReasoningEngineRuntimeRevisionServiceClientBuilder() : base(ReasoningEngineRuntimeRevisionServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ReasoningEngineRuntimeRevisionServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ReasoningEngineRuntimeRevisionServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ReasoningEngineRuntimeRevisionServiceClient Build()
        {
            ReasoningEngineRuntimeRevisionServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ReasoningEngineRuntimeRevisionServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ReasoningEngineRuntimeRevisionServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ReasoningEngineRuntimeRevisionServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ReasoningEngineRuntimeRevisionServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ReasoningEngineRuntimeRevisionServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ReasoningEngineRuntimeRevisionServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ReasoningEngineRuntimeRevisionServiceClient.ChannelPool;
    }

    /// <summary>ReasoningEngineRuntimeRevisionService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Manages Vertex AI's Reasoning Engine Revisions.
    /// </remarks>
    public abstract partial class ReasoningEngineRuntimeRevisionServiceClient
    {
        /// <summary>
        /// The default endpoint for the ReasoningEngineRuntimeRevisionService service, which is a host of
        /// "aiplatform.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "aiplatform.googleapis.com:443";

        /// <summary>The default ReasoningEngineRuntimeRevisionService scopes.</summary>
        /// <remarks>
        /// The default ReasoningEngineRuntimeRevisionService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ReasoningEngineRuntimeRevisionService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ReasoningEngineRuntimeRevisionServiceClient"/> using the default
        /// credentials, endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="ReasoningEngineRuntimeRevisionServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>
        /// The task representing the created <see cref="ReasoningEngineRuntimeRevisionServiceClient"/>.
        /// </returns>
        public static stt::Task<ReasoningEngineRuntimeRevisionServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ReasoningEngineRuntimeRevisionServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ReasoningEngineRuntimeRevisionServiceClient"/> using the default
        /// credentials, endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="ReasoningEngineRuntimeRevisionServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ReasoningEngineRuntimeRevisionServiceClient"/>.</returns>
        public static ReasoningEngineRuntimeRevisionServiceClient Create() =>
            new ReasoningEngineRuntimeRevisionServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ReasoningEngineRuntimeRevisionServiceClient"/> which uses the specified call invoker
        /// for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ReasoningEngineRuntimeRevisionServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ReasoningEngineRuntimeRevisionServiceClient"/>.</returns>
        internal static ReasoningEngineRuntimeRevisionServiceClient Create(grpccore::CallInvoker callInvoker, ReasoningEngineRuntimeRevisionServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ReasoningEngineRuntimeRevisionService.ReasoningEngineRuntimeRevisionServiceClient grpcClient = new ReasoningEngineRuntimeRevisionService.ReasoningEngineRuntimeRevisionServiceClient(callInvoker);
            return new ReasoningEngineRuntimeRevisionServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ReasoningEngineRuntimeRevisionService client</summary>
        public virtual ReasoningEngineRuntimeRevisionService.ReasoningEngineRuntimeRevisionServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a reasoning engine runtime revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReasoningEngineRuntimeRevision GetReasoningEngineRuntimeRevision(GetReasoningEngineRuntimeRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a reasoning engine runtime revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReasoningEngineRuntimeRevision> GetReasoningEngineRuntimeRevisionAsync(GetReasoningEngineRuntimeRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a reasoning engine runtime revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReasoningEngineRuntimeRevision> GetReasoningEngineRuntimeRevisionAsync(GetReasoningEngineRuntimeRevisionRequest request, st::CancellationToken cancellationToken) =>
            GetReasoningEngineRuntimeRevisionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a reasoning engine runtime revision.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ReasoningEngineRuntimeRevision resource.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/runtimeRevisions/{runtimeRevision}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReasoningEngineRuntimeRevision GetReasoningEngineRuntimeRevision(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetReasoningEngineRuntimeRevision(new GetReasoningEngineRuntimeRevisionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a reasoning engine runtime revision.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ReasoningEngineRuntimeRevision resource.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/runtimeRevisions/{runtimeRevision}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReasoningEngineRuntimeRevision> GetReasoningEngineRuntimeRevisionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetReasoningEngineRuntimeRevisionAsync(new GetReasoningEngineRuntimeRevisionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a reasoning engine runtime revision.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ReasoningEngineRuntimeRevision resource.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/runtimeRevisions/{runtimeRevision}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReasoningEngineRuntimeRevision> GetReasoningEngineRuntimeRevisionAsync(string name, st::CancellationToken cancellationToken) =>
            GetReasoningEngineRuntimeRevisionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a reasoning engine runtime revision.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ReasoningEngineRuntimeRevision resource.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/runtimeRevisions/{runtimeRevision}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReasoningEngineRuntimeRevision GetReasoningEngineRuntimeRevision(ReasoningEngineRuntimeRevisionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetReasoningEngineRuntimeRevision(new GetReasoningEngineRuntimeRevisionRequest
            {
                ReasoningEngineRuntimeRevisionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a reasoning engine runtime revision.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ReasoningEngineRuntimeRevision resource.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/runtimeRevisions/{runtimeRevision}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReasoningEngineRuntimeRevision> GetReasoningEngineRuntimeRevisionAsync(ReasoningEngineRuntimeRevisionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetReasoningEngineRuntimeRevisionAsync(new GetReasoningEngineRuntimeRevisionRequest
            {
                ReasoningEngineRuntimeRevisionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a reasoning engine runtime revision.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ReasoningEngineRuntimeRevision resource.
        /// Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/runtimeRevisions/{runtimeRevision}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReasoningEngineRuntimeRevision> GetReasoningEngineRuntimeRevisionAsync(ReasoningEngineRuntimeRevisionName name, st::CancellationToken cancellationToken) =>
            GetReasoningEngineRuntimeRevisionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists runtime revisions in a reasoning engine.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ReasoningEngineRuntimeRevision"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReasoningEngineRuntimeRevisionsResponse, ReasoningEngineRuntimeRevision> ListReasoningEngineRuntimeRevisions(ListReasoningEngineRuntimeRevisionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists runtime revisions in a reasoning engine.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ReasoningEngineRuntimeRevision"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListReasoningEngineRuntimeRevisionsResponse, ReasoningEngineRuntimeRevision> ListReasoningEngineRuntimeRevisionsAsync(ListReasoningEngineRuntimeRevisionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists runtime revisions in a reasoning engine.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the ReasoningEngine to list the
        /// ReasoningEngineRuntimeRevisions from. Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}`
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
        /// <returns>A pageable sequence of <see cref="ReasoningEngineRuntimeRevision"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReasoningEngineRuntimeRevisionsResponse, ReasoningEngineRuntimeRevision> ListReasoningEngineRuntimeRevisions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReasoningEngineRuntimeRevisionsRequest request = new ListReasoningEngineRuntimeRevisionsRequest
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
            return ListReasoningEngineRuntimeRevisions(request, callSettings);
        }

        /// <summary>
        /// Lists runtime revisions in a reasoning engine.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the ReasoningEngine to list the
        /// ReasoningEngineRuntimeRevisions from. Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}`
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
        /// A pageable asynchronous sequence of <see cref="ReasoningEngineRuntimeRevision"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListReasoningEngineRuntimeRevisionsResponse, ReasoningEngineRuntimeRevision> ListReasoningEngineRuntimeRevisionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReasoningEngineRuntimeRevisionsRequest request = new ListReasoningEngineRuntimeRevisionsRequest
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
            return ListReasoningEngineRuntimeRevisionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists runtime revisions in a reasoning engine.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the ReasoningEngine to list the
        /// ReasoningEngineRuntimeRevisions from. Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}`
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
        /// <returns>A pageable sequence of <see cref="ReasoningEngineRuntimeRevision"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReasoningEngineRuntimeRevisionsResponse, ReasoningEngineRuntimeRevision> ListReasoningEngineRuntimeRevisions(ReasoningEngineName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReasoningEngineRuntimeRevisionsRequest request = new ListReasoningEngineRuntimeRevisionsRequest
            {
                ParentAsReasoningEngineName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListReasoningEngineRuntimeRevisions(request, callSettings);
        }

        /// <summary>
        /// Lists runtime revisions in a reasoning engine.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the ReasoningEngine to list the
        /// ReasoningEngineRuntimeRevisions from. Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}`
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
        /// A pageable asynchronous sequence of <see cref="ReasoningEngineRuntimeRevision"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListReasoningEngineRuntimeRevisionsResponse, ReasoningEngineRuntimeRevision> ListReasoningEngineRuntimeRevisionsAsync(ReasoningEngineName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReasoningEngineRuntimeRevisionsRequest request = new ListReasoningEngineRuntimeRevisionsRequest
            {
                ParentAsReasoningEngineName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListReasoningEngineRuntimeRevisionsAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes a reasoning engine revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteReasoningEngineRuntimeRevisionOperationMetadata> DeleteReasoningEngineRuntimeRevision(DeleteReasoningEngineRuntimeRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a reasoning engine revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteReasoningEngineRuntimeRevisionOperationMetadata>> DeleteReasoningEngineRuntimeRevisionAsync(DeleteReasoningEngineRuntimeRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a reasoning engine revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteReasoningEngineRuntimeRevisionOperationMetadata>> DeleteReasoningEngineRuntimeRevisionAsync(DeleteReasoningEngineRuntimeRevisionRequest request, st::CancellationToken cancellationToken) =>
            DeleteReasoningEngineRuntimeRevisionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteReasoningEngineRuntimeRevision</c>.</summary>
        public virtual lro::OperationsClient DeleteReasoningEngineRuntimeRevisionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteReasoningEngineRuntimeRevision</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteReasoningEngineRuntimeRevisionOperationMetadata> PollOnceDeleteReasoningEngineRuntimeRevision(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteReasoningEngineRuntimeRevisionOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteReasoningEngineRuntimeRevisionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteReasoningEngineRuntimeRevision</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteReasoningEngineRuntimeRevisionOperationMetadata>> PollOnceDeleteReasoningEngineRuntimeRevisionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteReasoningEngineRuntimeRevisionOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteReasoningEngineRuntimeRevisionOperationsClient, callSettings);

        /// <summary>
        /// Deletes a reasoning engine revision.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ReasoningEngineRuntimeRevision resource to be
        /// deleted. Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/runtimeRevisions/{runtime_revision}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteReasoningEngineRuntimeRevisionOperationMetadata> DeleteReasoningEngineRuntimeRevision(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReasoningEngineRuntimeRevision(new DeleteReasoningEngineRuntimeRevisionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a reasoning engine revision.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ReasoningEngineRuntimeRevision resource to be
        /// deleted. Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/runtimeRevisions/{runtime_revision}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteReasoningEngineRuntimeRevisionOperationMetadata>> DeleteReasoningEngineRuntimeRevisionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReasoningEngineRuntimeRevisionAsync(new DeleteReasoningEngineRuntimeRevisionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a reasoning engine revision.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ReasoningEngineRuntimeRevision resource to be
        /// deleted. Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/runtimeRevisions/{runtime_revision}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteReasoningEngineRuntimeRevisionOperationMetadata>> DeleteReasoningEngineRuntimeRevisionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteReasoningEngineRuntimeRevisionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a reasoning engine revision.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ReasoningEngineRuntimeRevision resource to be
        /// deleted. Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/runtimeRevisions/{runtime_revision}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteReasoningEngineRuntimeRevisionOperationMetadata> DeleteReasoningEngineRuntimeRevision(ReasoningEngineRuntimeRevisionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReasoningEngineRuntimeRevision(new DeleteReasoningEngineRuntimeRevisionRequest
            {
                ReasoningEngineRuntimeRevisionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a reasoning engine revision.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ReasoningEngineRuntimeRevision resource to be
        /// deleted. Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/runtimeRevisions/{runtime_revision}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteReasoningEngineRuntimeRevisionOperationMetadata>> DeleteReasoningEngineRuntimeRevisionAsync(ReasoningEngineRuntimeRevisionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReasoningEngineRuntimeRevisionAsync(new DeleteReasoningEngineRuntimeRevisionRequest
            {
                ReasoningEngineRuntimeRevisionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a reasoning engine revision.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ReasoningEngineRuntimeRevision resource to be
        /// deleted. Format:
        /// `projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/runtimeRevisions/{runtime_revision}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteReasoningEngineRuntimeRevisionOperationMetadata>> DeleteReasoningEngineRuntimeRevisionAsync(ReasoningEngineRuntimeRevisionName name, st::CancellationToken cancellationToken) =>
            DeleteReasoningEngineRuntimeRevisionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ReasoningEngineRuntimeRevisionService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Manages Vertex AI's Reasoning Engine Revisions.
    /// </remarks>
    public sealed partial class ReasoningEngineRuntimeRevisionServiceClientImpl : ReasoningEngineRuntimeRevisionServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetReasoningEngineRuntimeRevisionRequest, ReasoningEngineRuntimeRevision> _callGetReasoningEngineRuntimeRevision;

        private readonly gaxgrpc::ApiCall<ListReasoningEngineRuntimeRevisionsRequest, ListReasoningEngineRuntimeRevisionsResponse> _callListReasoningEngineRuntimeRevisions;

        private readonly gaxgrpc::ApiCall<DeleteReasoningEngineRuntimeRevisionRequest, lro::Operation> _callDeleteReasoningEngineRuntimeRevision;

        /// <summary>
        /// Constructs a client wrapper for the ReasoningEngineRuntimeRevisionService service, with the specified gRPC
        /// client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="ReasoningEngineRuntimeRevisionServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ReasoningEngineRuntimeRevisionServiceClientImpl(ReasoningEngineRuntimeRevisionService.ReasoningEngineRuntimeRevisionServiceClient grpcClient, ReasoningEngineRuntimeRevisionServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ReasoningEngineRuntimeRevisionServiceSettings effectiveSettings = settings ?? ReasoningEngineRuntimeRevisionServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            DeleteReasoningEngineRuntimeRevisionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteReasoningEngineRuntimeRevisionOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callGetReasoningEngineRuntimeRevision = clientHelper.BuildApiCall<GetReasoningEngineRuntimeRevisionRequest, ReasoningEngineRuntimeRevision>("GetReasoningEngineRuntimeRevision", grpcClient.GetReasoningEngineRuntimeRevisionAsync, grpcClient.GetReasoningEngineRuntimeRevision, effectiveSettings.GetReasoningEngineRuntimeRevisionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetReasoningEngineRuntimeRevision);
            Modify_GetReasoningEngineRuntimeRevisionApiCall(ref _callGetReasoningEngineRuntimeRevision);
            _callListReasoningEngineRuntimeRevisions = clientHelper.BuildApiCall<ListReasoningEngineRuntimeRevisionsRequest, ListReasoningEngineRuntimeRevisionsResponse>("ListReasoningEngineRuntimeRevisions", grpcClient.ListReasoningEngineRuntimeRevisionsAsync, grpcClient.ListReasoningEngineRuntimeRevisions, effectiveSettings.ListReasoningEngineRuntimeRevisionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListReasoningEngineRuntimeRevisions);
            Modify_ListReasoningEngineRuntimeRevisionsApiCall(ref _callListReasoningEngineRuntimeRevisions);
            _callDeleteReasoningEngineRuntimeRevision = clientHelper.BuildApiCall<DeleteReasoningEngineRuntimeRevisionRequest, lro::Operation>("DeleteReasoningEngineRuntimeRevision", grpcClient.DeleteReasoningEngineRuntimeRevisionAsync, grpcClient.DeleteReasoningEngineRuntimeRevision, effectiveSettings.DeleteReasoningEngineRuntimeRevisionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteReasoningEngineRuntimeRevision);
            Modify_DeleteReasoningEngineRuntimeRevisionApiCall(ref _callDeleteReasoningEngineRuntimeRevision);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetReasoningEngineRuntimeRevisionApiCall(ref gaxgrpc::ApiCall<GetReasoningEngineRuntimeRevisionRequest, ReasoningEngineRuntimeRevision> call);

        partial void Modify_ListReasoningEngineRuntimeRevisionsApiCall(ref gaxgrpc::ApiCall<ListReasoningEngineRuntimeRevisionsRequest, ListReasoningEngineRuntimeRevisionsResponse> call);

        partial void Modify_DeleteReasoningEngineRuntimeRevisionApiCall(ref gaxgrpc::ApiCall<DeleteReasoningEngineRuntimeRevisionRequest, lro::Operation> call);

        partial void OnConstruction(ReasoningEngineRuntimeRevisionService.ReasoningEngineRuntimeRevisionServiceClient grpcClient, ReasoningEngineRuntimeRevisionServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ReasoningEngineRuntimeRevisionService client</summary>
        public override ReasoningEngineRuntimeRevisionService.ReasoningEngineRuntimeRevisionServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_GetReasoningEngineRuntimeRevisionRequest(ref GetReasoningEngineRuntimeRevisionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListReasoningEngineRuntimeRevisionsRequest(ref ListReasoningEngineRuntimeRevisionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteReasoningEngineRuntimeRevisionRequest(ref DeleteReasoningEngineRuntimeRevisionRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets a reasoning engine runtime revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ReasoningEngineRuntimeRevision GetReasoningEngineRuntimeRevision(GetReasoningEngineRuntimeRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReasoningEngineRuntimeRevisionRequest(ref request, ref callSettings);
            return _callGetReasoningEngineRuntimeRevision.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a reasoning engine runtime revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ReasoningEngineRuntimeRevision> GetReasoningEngineRuntimeRevisionAsync(GetReasoningEngineRuntimeRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReasoningEngineRuntimeRevisionRequest(ref request, ref callSettings);
            return _callGetReasoningEngineRuntimeRevision.Async(request, callSettings);
        }

        /// <summary>
        /// Lists runtime revisions in a reasoning engine.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ReasoningEngineRuntimeRevision"/> resources.</returns>
        public override gax::PagedEnumerable<ListReasoningEngineRuntimeRevisionsResponse, ReasoningEngineRuntimeRevision> ListReasoningEngineRuntimeRevisions(ListReasoningEngineRuntimeRevisionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReasoningEngineRuntimeRevisionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListReasoningEngineRuntimeRevisionsRequest, ListReasoningEngineRuntimeRevisionsResponse, ReasoningEngineRuntimeRevision>(_callListReasoningEngineRuntimeRevisions, request, callSettings);
        }

        /// <summary>
        /// Lists runtime revisions in a reasoning engine.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ReasoningEngineRuntimeRevision"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListReasoningEngineRuntimeRevisionsResponse, ReasoningEngineRuntimeRevision> ListReasoningEngineRuntimeRevisionsAsync(ListReasoningEngineRuntimeRevisionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReasoningEngineRuntimeRevisionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListReasoningEngineRuntimeRevisionsRequest, ListReasoningEngineRuntimeRevisionsResponse, ReasoningEngineRuntimeRevision>(_callListReasoningEngineRuntimeRevisions, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteReasoningEngineRuntimeRevision</c>.</summary>
        public override lro::OperationsClient DeleteReasoningEngineRuntimeRevisionOperationsClient { get; }

        /// <summary>
        /// Deletes a reasoning engine revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteReasoningEngineRuntimeRevisionOperationMetadata> DeleteReasoningEngineRuntimeRevision(DeleteReasoningEngineRuntimeRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteReasoningEngineRuntimeRevisionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteReasoningEngineRuntimeRevisionOperationMetadata>(_callDeleteReasoningEngineRuntimeRevision.Sync(request, callSettings), DeleteReasoningEngineRuntimeRevisionOperationsClient);
        }

        /// <summary>
        /// Deletes a reasoning engine revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteReasoningEngineRuntimeRevisionOperationMetadata>> DeleteReasoningEngineRuntimeRevisionAsync(DeleteReasoningEngineRuntimeRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteReasoningEngineRuntimeRevisionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteReasoningEngineRuntimeRevisionOperationMetadata>(await _callDeleteReasoningEngineRuntimeRevision.Async(request, callSettings).ConfigureAwait(false), DeleteReasoningEngineRuntimeRevisionOperationsClient);
        }
    }

    public partial class ListReasoningEngineRuntimeRevisionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListReasoningEngineRuntimeRevisionsResponse : gaxgrpc::IPageResponse<ReasoningEngineRuntimeRevision>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ReasoningEngineRuntimeRevision> GetEnumerator() =>
            ReasoningEngineRuntimeRevisions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class ReasoningEngineRuntimeRevisionService
    {
        public partial class ReasoningEngineRuntimeRevisionServiceClient
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

    public static partial class ReasoningEngineRuntimeRevisionService
    {
        public partial class ReasoningEngineRuntimeRevisionServiceClient
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
