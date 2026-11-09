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
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Ads.AdManager.V1
{
    /// <summary>Settings for <see cref="ProposalServiceClient"/> instances.</summary>
    public sealed partial class ProposalServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ProposalServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ProposalServiceSettings"/>.</returns>
        public static ProposalServiceSettings GetDefault() => new ProposalServiceSettings();

        /// <summary>Constructs a new <see cref="ProposalServiceSettings"/> object with default settings.</summary>
        public ProposalServiceSettings()
        {
        }

        private ProposalServiceSettings(ProposalServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetProposalSettings = existing.GetProposalSettings;
            ListProposalsSettings = existing.ListProposalsSettings;
            CreateProposalSettings = existing.CreateProposalSettings;
            BatchCreateProposalsSettings = existing.BatchCreateProposalsSettings;
            UpdateProposalSettings = existing.UpdateProposalSettings;
            BatchUpdateProposalsSettings = existing.BatchUpdateProposalsSettings;
            BatchArchiveProposalsSettings = existing.BatchArchiveProposalsSettings;
            BatchUnarchiveProposalsSettings = existing.BatchUnarchiveProposalsSettings;
            BatchPauseProposalsSettings = existing.BatchPauseProposalsSettings;
            BatchResumeProposalsSettings = existing.BatchResumeProposalsSettings;
            BatchRequestBuyerReviewProposalsSettings = existing.BatchRequestBuyerReviewProposalsSettings;
            BatchRequestBuyerAcceptProposalsSettings = existing.BatchRequestBuyerAcceptProposalsSettings;
            BatchReserveProposalsSettings = existing.BatchReserveProposalsSettings;
            BatchRedraftProposalsSettings = existing.BatchRedraftProposalsSettings;
            BatchDiscardDraftProposalsSettings = existing.BatchDiscardDraftProposalsSettings;
            BatchTerminateProposalsSettings = existing.BatchTerminateProposalsSettings;
            BatchPushToOrderProposalsSettings = existing.BatchPushToOrderProposalsSettings;
            FetchMarketplaceCommentsSettings = existing.FetchMarketplaceCommentsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ProposalServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProposalServiceClient.GetProposal</c> and <c>ProposalServiceClient.GetProposalAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetProposalSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProposalServiceClient.ListProposals</c> and <c>ProposalServiceClient.ListProposalsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListProposalsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProposalServiceClient.CreateProposal</c> and <c>ProposalServiceClient.CreateProposalAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateProposalSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProposalServiceClient.BatchCreateProposals</c> and <c>ProposalServiceClient.BatchCreateProposalsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchCreateProposalsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProposalServiceClient.UpdateProposal</c> and <c>ProposalServiceClient.UpdateProposalAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateProposalSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProposalServiceClient.BatchUpdateProposals</c> and <c>ProposalServiceClient.BatchUpdateProposalsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchUpdateProposalsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProposalServiceClient.BatchArchiveProposals</c> and <c>ProposalServiceClient.BatchArchiveProposalsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchArchiveProposalsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProposalServiceClient.BatchUnarchiveProposals</c> and
        /// <c>ProposalServiceClient.BatchUnarchiveProposalsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchUnarchiveProposalsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProposalServiceClient.BatchPauseProposals</c> and <c>ProposalServiceClient.BatchPauseProposalsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchPauseProposalsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProposalServiceClient.BatchResumeProposals</c> and <c>ProposalServiceClient.BatchResumeProposalsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchResumeProposalsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProposalServiceClient.BatchRequestBuyerReviewProposals</c> and
        /// <c>ProposalServiceClient.BatchRequestBuyerReviewProposalsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchRequestBuyerReviewProposalsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProposalServiceClient.BatchRequestBuyerAcceptProposals</c> and
        /// <c>ProposalServiceClient.BatchRequestBuyerAcceptProposalsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchRequestBuyerAcceptProposalsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProposalServiceClient.BatchReserveProposals</c> and <c>ProposalServiceClient.BatchReserveProposalsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchReserveProposalsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProposalServiceClient.BatchRedraftProposals</c> and <c>ProposalServiceClient.BatchRedraftProposalsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchRedraftProposalsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProposalServiceClient.BatchDiscardDraftProposals</c> and
        /// <c>ProposalServiceClient.BatchDiscardDraftProposalsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchDiscardDraftProposalsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProposalServiceClient.BatchTerminateProposals</c> and
        /// <c>ProposalServiceClient.BatchTerminateProposalsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchTerminateProposalsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProposalServiceClient.BatchPushToOrderProposals</c> and
        /// <c>ProposalServiceClient.BatchPushToOrderProposalsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchPushToOrderProposalsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProposalServiceClient.FetchMarketplaceComments</c> and
        /// <c>ProposalServiceClient.FetchMarketplaceCommentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings FetchMarketplaceCommentsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ProposalServiceSettings"/> object.</returns>
        public ProposalServiceSettings Clone() => new ProposalServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ProposalServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class ProposalServiceClientBuilder : gaxgrpc::ClientBuilderBase<ProposalServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ProposalServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ProposalServiceClientBuilder() : base(ProposalServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ProposalServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ProposalServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ProposalServiceClient Build()
        {
            ProposalServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ProposalServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ProposalServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ProposalServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ProposalServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ProposalServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ProposalServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ProposalServiceClient.ChannelPool;
    }

    /// <summary>ProposalService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `Proposal` objects.
    /// </remarks>
    public abstract partial class ProposalServiceClient
    {
        /// <summary>
        /// The default endpoint for the ProposalService service, which is a host of "admanager.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default ProposalService scopes.</summary>
        /// <remarks>
        /// The default ProposalService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/admanager</description></item>
        /// <item><description>https://www.googleapis.com/auth/admanager.readonly</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/admanager",
            "https://www.googleapis.com/auth/admanager.readonly",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ProposalService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ProposalServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ProposalServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ProposalServiceClient"/>.</returns>
        public static stt::Task<ProposalServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ProposalServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ProposalServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ProposalServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ProposalServiceClient"/>.</returns>
        public static ProposalServiceClient Create() => new ProposalServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ProposalServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ProposalServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ProposalServiceClient"/>.</returns>
        internal static ProposalServiceClient Create(grpccore::CallInvoker callInvoker, ProposalServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ProposalService.ProposalServiceClient grpcClient = new ProposalService.ProposalServiceClient(callInvoker);
            return new ProposalServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ProposalService client</summary>
        public virtual ProposalService.ProposalServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `Proposal` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Proposal GetProposal(GetProposalRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `Proposal` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Proposal> GetProposalAsync(GetProposalRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `Proposal` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Proposal> GetProposalAsync(GetProposalRequest request, st::CancellationToken cancellationToken) =>
            GetProposalAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `Proposal` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Proposal.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Proposal GetProposal(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProposal(new GetProposalRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `Proposal` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Proposal.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Proposal> GetProposalAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProposalAsync(new GetProposalRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `Proposal` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Proposal.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Proposal> GetProposalAsync(string name, st::CancellationToken cancellationToken) =>
            GetProposalAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `Proposal` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Proposal.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Proposal GetProposal(ProposalName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProposal(new GetProposalRequest
            {
                ProposalName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `Proposal` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Proposal.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Proposal> GetProposalAsync(ProposalName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProposalAsync(new GetProposalRequest
            {
                ProposalName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `Proposal` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Proposal.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Proposal> GetProposalAsync(ProposalName name, st::CancellationToken cancellationToken) =>
            GetProposalAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Proposal"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProposalsResponse, Proposal> ListProposals(ListProposalsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Proposal"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProposalsResponse, Proposal> ListProposalsAsync(ListProposalsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Proposals.
        /// Format: `networks/{network_code}`
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
        /// <returns>A pageable sequence of <see cref="Proposal"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProposalsResponse, Proposal> ListProposals(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProposalsRequest request = new ListProposalsRequest
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
            return ListProposals(request, callSettings);
        }

        /// <summary>
        /// Lists `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Proposals.
        /// Format: `networks/{network_code}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Proposal"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProposalsResponse, Proposal> ListProposalsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProposalsRequest request = new ListProposalsRequest
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
            return ListProposalsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Proposals.
        /// Format: `networks/{network_code}`
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
        /// <returns>A pageable sequence of <see cref="Proposal"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProposalsResponse, Proposal> ListProposals(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProposalsRequest request = new ListProposalsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListProposals(request, callSettings);
        }

        /// <summary>
        /// Lists `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Proposals.
        /// Format: `networks/{network_code}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Proposal"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProposalsResponse, Proposal> ListProposalsAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProposalsRequest request = new ListProposalsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListProposalsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a `Proposal` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Proposal CreateProposal(CreateProposalRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a `Proposal` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Proposal> CreateProposalAsync(CreateProposalRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a `Proposal` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Proposal> CreateProposalAsync(CreateProposalRequest request, st::CancellationToken cancellationToken) =>
            CreateProposalAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a `Proposal` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `Proposal` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="proposal">
        /// Required. The `Proposal` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Proposal CreateProposal(string parent, Proposal proposal, gaxgrpc::CallSettings callSettings = null) =>
            CreateProposal(new CreateProposalRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Proposal = gax::GaxPreconditions.CheckNotNull(proposal, nameof(proposal)),
            }, callSettings);

        /// <summary>
        /// Creates a `Proposal` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `Proposal` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="proposal">
        /// Required. The `Proposal` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Proposal> CreateProposalAsync(string parent, Proposal proposal, gaxgrpc::CallSettings callSettings = null) =>
            CreateProposalAsync(new CreateProposalRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Proposal = gax::GaxPreconditions.CheckNotNull(proposal, nameof(proposal)),
            }, callSettings);

        /// <summary>
        /// Creates a `Proposal` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `Proposal` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="proposal">
        /// Required. The `Proposal` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Proposal> CreateProposalAsync(string parent, Proposal proposal, st::CancellationToken cancellationToken) =>
            CreateProposalAsync(parent, proposal, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a `Proposal` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `Proposal` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="proposal">
        /// Required. The `Proposal` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Proposal CreateProposal(NetworkName parent, Proposal proposal, gaxgrpc::CallSettings callSettings = null) =>
            CreateProposal(new CreateProposalRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Proposal = gax::GaxPreconditions.CheckNotNull(proposal, nameof(proposal)),
            }, callSettings);

        /// <summary>
        /// Creates a `Proposal` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `Proposal` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="proposal">
        /// Required. The `Proposal` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Proposal> CreateProposalAsync(NetworkName parent, Proposal proposal, gaxgrpc::CallSettings callSettings = null) =>
            CreateProposalAsync(new CreateProposalRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Proposal = gax::GaxPreconditions.CheckNotNull(proposal, nameof(proposal)),
            }, callSettings);

        /// <summary>
        /// Creates a `Proposal` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `Proposal` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="proposal">
        /// Required. The `Proposal` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Proposal> CreateProposalAsync(NetworkName parent, Proposal proposal, st::CancellationToken cancellationToken) =>
            CreateProposalAsync(parent, proposal, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateProposalsResponse BatchCreateProposals(BatchCreateProposalsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateProposalsResponse> BatchCreateProposalsAsync(BatchCreateProposalsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateProposalsResponse> BatchCreateProposalsAsync(BatchCreateProposalsRequest request, st::CancellationToken cancellationToken) =>
            BatchCreateProposalsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Proposals` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateProposalRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Proposal` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateProposalsResponse BatchCreateProposals(string parent, scg::IEnumerable<CreateProposalRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateProposals(new BatchCreateProposalsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Proposals` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateProposalRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Proposal` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateProposalsResponse> BatchCreateProposalsAsync(string parent, scg::IEnumerable<CreateProposalRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateProposalsAsync(new BatchCreateProposalsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Proposals` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateProposalRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Proposal` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateProposalsResponse> BatchCreateProposalsAsync(string parent, scg::IEnumerable<CreateProposalRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateProposalsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Proposals` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateProposalRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Proposal` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateProposalsResponse BatchCreateProposals(NetworkName parent, scg::IEnumerable<CreateProposalRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateProposals(new BatchCreateProposalsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Proposals` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateProposalRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Proposal` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateProposalsResponse> BatchCreateProposalsAsync(NetworkName parent, scg::IEnumerable<CreateProposalRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateProposalsAsync(new BatchCreateProposalsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Proposals` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateProposalRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Proposal` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateProposalsResponse> BatchCreateProposalsAsync(NetworkName parent, scg::IEnumerable<CreateProposalRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateProposalsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a `Proposal` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Proposal UpdateProposal(UpdateProposalRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `Proposal` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Proposal> UpdateProposalAsync(UpdateProposalRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `Proposal` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Proposal> UpdateProposalAsync(UpdateProposalRequest request, st::CancellationToken cancellationToken) =>
            UpdateProposalAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a `Proposal` object.
        /// </summary>
        /// <param name="proposal">
        /// Required. The `Proposal` to update.
        /// 
        /// The `Proposal`'s `name` is used to identify the `Proposal` to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Proposal UpdateProposal(Proposal proposal, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateProposal(new UpdateProposalRequest
            {
                Proposal = gax::GaxPreconditions.CheckNotNull(proposal, nameof(proposal)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a `Proposal` object.
        /// </summary>
        /// <param name="proposal">
        /// Required. The `Proposal` to update.
        /// 
        /// The `Proposal`'s `name` is used to identify the `Proposal` to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Proposal> UpdateProposalAsync(Proposal proposal, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateProposalAsync(new UpdateProposalRequest
            {
                Proposal = gax::GaxPreconditions.CheckNotNull(proposal, nameof(proposal)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a `Proposal` object.
        /// </summary>
        /// <param name="proposal">
        /// Required. The `Proposal` to update.
        /// 
        /// The `Proposal`'s `name` is used to identify the `Proposal` to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Proposal> UpdateProposalAsync(Proposal proposal, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateProposalAsync(proposal, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateProposalsResponse BatchUpdateProposals(BatchUpdateProposalsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch updates `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateProposalsResponse> BatchUpdateProposalsAsync(BatchUpdateProposalsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch updates `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateProposalsResponse> BatchUpdateProposalsAsync(BatchUpdateProposalsRequest request, st::CancellationToken cancellationToken) =>
            BatchUpdateProposalsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Proposals` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateProposalRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Proposal` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateProposalsResponse BatchUpdateProposals(string parent, scg::IEnumerable<UpdateProposalRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateProposals(new BatchUpdateProposalsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Proposals` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateProposalRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Proposal` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateProposalsResponse> BatchUpdateProposalsAsync(string parent, scg::IEnumerable<UpdateProposalRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateProposalsAsync(new BatchUpdateProposalsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Proposals` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateProposalRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Proposal` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateProposalsResponse> BatchUpdateProposalsAsync(string parent, scg::IEnumerable<UpdateProposalRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateProposalsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Proposals` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateProposalRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Proposal` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateProposalsResponse BatchUpdateProposals(NetworkName parent, scg::IEnumerable<UpdateProposalRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateProposals(new BatchUpdateProposalsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Proposals` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateProposalRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Proposal` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateProposalsResponse> BatchUpdateProposalsAsync(NetworkName parent, scg::IEnumerable<UpdateProposalRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateProposalsAsync(new BatchUpdateProposalsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Proposals` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateProposalRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Proposal` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateProposalsResponse> BatchUpdateProposalsAsync(NetworkName parent, scg::IEnumerable<UpdateProposalRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateProposalsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Archives `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchArchiveProposalsResponse BatchArchiveProposals(BatchArchiveProposalsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Archives `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveProposalsResponse> BatchArchiveProposalsAsync(BatchArchiveProposalsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Archives `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveProposalsResponse> BatchArchiveProposalsAsync(BatchArchiveProposalsRequest request, st::CancellationToken cancellationToken) =>
            BatchArchiveProposalsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Archives `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be archived.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to archive.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchArchiveProposalsResponse BatchArchiveProposals(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchArchiveProposals(new BatchArchiveProposalsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Archives `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be archived.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to archive.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveProposalsResponse> BatchArchiveProposalsAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchArchiveProposalsAsync(new BatchArchiveProposalsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Archives `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be archived.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to archive.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveProposalsResponse> BatchArchiveProposalsAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchArchiveProposalsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Archives `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be archived.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to archive.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchArchiveProposalsResponse BatchArchiveProposals(NetworkName parent, scg::IEnumerable<ProposalName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchArchiveProposals(new BatchArchiveProposalsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ProposalNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Archives `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be archived.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to archive.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveProposalsResponse> BatchArchiveProposalsAsync(NetworkName parent, scg::IEnumerable<ProposalName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchArchiveProposalsAsync(new BatchArchiveProposalsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ProposalNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Archives `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be archived.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to archive.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveProposalsResponse> BatchArchiveProposalsAsync(NetworkName parent, scg::IEnumerable<ProposalName> names, st::CancellationToken cancellationToken) =>
            BatchArchiveProposalsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Unarchives `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUnarchiveProposalsResponse BatchUnarchiveProposals(BatchUnarchiveProposalsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Unarchives `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUnarchiveProposalsResponse> BatchUnarchiveProposalsAsync(BatchUnarchiveProposalsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Unarchives `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUnarchiveProposalsResponse> BatchUnarchiveProposalsAsync(BatchUnarchiveProposalsRequest request, st::CancellationToken cancellationToken) =>
            BatchUnarchiveProposalsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Unarchives `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be unarchived.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to unarchive.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUnarchiveProposalsResponse BatchUnarchiveProposals(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchUnarchiveProposals(new BatchUnarchiveProposalsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Unarchives `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be unarchived.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to unarchive.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUnarchiveProposalsResponse> BatchUnarchiveProposalsAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchUnarchiveProposalsAsync(new BatchUnarchiveProposalsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Unarchives `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be unarchived.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to unarchive.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUnarchiveProposalsResponse> BatchUnarchiveProposalsAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchUnarchiveProposalsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Unarchives `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be unarchived.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to unarchive.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUnarchiveProposalsResponse BatchUnarchiveProposals(NetworkName parent, scg::IEnumerable<ProposalName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchUnarchiveProposals(new BatchUnarchiveProposalsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ProposalNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Unarchives `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be unarchived.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to unarchive.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUnarchiveProposalsResponse> BatchUnarchiveProposalsAsync(NetworkName parent, scg::IEnumerable<ProposalName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchUnarchiveProposalsAsync(new BatchUnarchiveProposalsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ProposalNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Unarchives `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be unarchived.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to unarchive.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUnarchiveProposalsResponse> BatchUnarchiveProposalsAsync(NetworkName parent, scg::IEnumerable<ProposalName> names, st::CancellationToken cancellationToken) =>
            BatchUnarchiveProposalsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Pauses `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchPauseProposalsResponse BatchPauseProposals(BatchPauseProposalsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Pauses `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchPauseProposalsResponse> BatchPauseProposalsAsync(BatchPauseProposalsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Pauses `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchPauseProposalsResponse> BatchPauseProposalsAsync(BatchPauseProposalsRequest request, st::CancellationToken cancellationToken) =>
            BatchPauseProposalsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Pauses `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be paused.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to pause.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="reason">
        /// Required. The reason for pausing the Proposals.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchPauseProposalsResponse BatchPauseProposals(string parent, scg::IEnumerable<string> names, string reason, gaxgrpc::CallSettings callSettings = null) =>
            BatchPauseProposals(new BatchPauseProposalsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
                Reason = gax::GaxPreconditions.CheckNotNullOrEmpty(reason, nameof(reason)),
            }, callSettings);

        /// <summary>
        /// Pauses `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be paused.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to pause.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="reason">
        /// Required. The reason for pausing the Proposals.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchPauseProposalsResponse> BatchPauseProposalsAsync(string parent, scg::IEnumerable<string> names, string reason, gaxgrpc::CallSettings callSettings = null) =>
            BatchPauseProposalsAsync(new BatchPauseProposalsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
                Reason = gax::GaxPreconditions.CheckNotNullOrEmpty(reason, nameof(reason)),
            }, callSettings);

        /// <summary>
        /// Pauses `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be paused.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to pause.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="reason">
        /// Required. The reason for pausing the Proposals.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchPauseProposalsResponse> BatchPauseProposalsAsync(string parent, scg::IEnumerable<string> names, string reason, st::CancellationToken cancellationToken) =>
            BatchPauseProposalsAsync(parent, names, reason, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Pauses `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be paused.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to pause.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="reason">
        /// Required. The reason for pausing the Proposals.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchPauseProposalsResponse BatchPauseProposals(NetworkName parent, scg::IEnumerable<ProposalName> names, string reason, gaxgrpc::CallSettings callSettings = null) =>
            BatchPauseProposals(new BatchPauseProposalsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ProposalNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
                Reason = gax::GaxPreconditions.CheckNotNullOrEmpty(reason, nameof(reason)),
            }, callSettings);

        /// <summary>
        /// Pauses `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be paused.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to pause.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="reason">
        /// Required. The reason for pausing the Proposals.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchPauseProposalsResponse> BatchPauseProposalsAsync(NetworkName parent, scg::IEnumerable<ProposalName> names, string reason, gaxgrpc::CallSettings callSettings = null) =>
            BatchPauseProposalsAsync(new BatchPauseProposalsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ProposalNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
                Reason = gax::GaxPreconditions.CheckNotNullOrEmpty(reason, nameof(reason)),
            }, callSettings);

        /// <summary>
        /// Pauses `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be paused.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to pause.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="reason">
        /// Required. The reason for pausing the Proposals.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchPauseProposalsResponse> BatchPauseProposalsAsync(NetworkName parent, scg::IEnumerable<ProposalName> names, string reason, st::CancellationToken cancellationToken) =>
            BatchPauseProposalsAsync(parent, names, reason, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resumes `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchResumeProposalsResponse BatchResumeProposals(BatchResumeProposalsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resumes `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchResumeProposalsResponse> BatchResumeProposalsAsync(BatchResumeProposalsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resumes `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchResumeProposalsResponse> BatchResumeProposalsAsync(BatchResumeProposalsRequest request, st::CancellationToken cancellationToken) =>
            BatchResumeProposalsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resumes `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be resumed.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to resume.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchResumeProposalsResponse BatchResumeProposals(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchResumeProposals(new BatchResumeProposalsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Resumes `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be resumed.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to resume.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchResumeProposalsResponse> BatchResumeProposalsAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchResumeProposalsAsync(new BatchResumeProposalsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Resumes `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be resumed.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to resume.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchResumeProposalsResponse> BatchResumeProposalsAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchResumeProposalsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resumes `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be resumed.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to resume.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchResumeProposalsResponse BatchResumeProposals(NetworkName parent, scg::IEnumerable<ProposalName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchResumeProposals(new BatchResumeProposalsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ProposalNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Resumes `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be resumed.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to resume.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchResumeProposalsResponse> BatchResumeProposalsAsync(NetworkName parent, scg::IEnumerable<ProposalName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchResumeProposalsAsync(new BatchResumeProposalsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ProposalNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Resumes `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be resumed.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to resume.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchResumeProposalsResponse> BatchResumeProposalsAsync(NetworkName parent, scg::IEnumerable<ProposalName> names, st::CancellationToken cancellationToken) =>
            BatchResumeProposalsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Requests buyer review for `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchRequestBuyerReviewProposalsResponse BatchRequestBuyerReviewProposals(BatchRequestBuyerReviewProposalsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Requests buyer review for `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchRequestBuyerReviewProposalsResponse> BatchRequestBuyerReviewProposalsAsync(BatchRequestBuyerReviewProposalsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Requests buyer review for `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchRequestBuyerReviewProposalsResponse> BatchRequestBuyerReviewProposalsAsync(BatchRequestBuyerReviewProposalsRequest request, st::CancellationToken cancellationToken) =>
            BatchRequestBuyerReviewProposalsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Requests buyer review for `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be reviewed.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to request buyer review.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchRequestBuyerReviewProposalsResponse BatchRequestBuyerReviewProposals(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchRequestBuyerReviewProposals(new BatchRequestBuyerReviewProposalsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Requests buyer review for `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be reviewed.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to request buyer review.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchRequestBuyerReviewProposalsResponse> BatchRequestBuyerReviewProposalsAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchRequestBuyerReviewProposalsAsync(new BatchRequestBuyerReviewProposalsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Requests buyer review for `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be reviewed.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to request buyer review.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchRequestBuyerReviewProposalsResponse> BatchRequestBuyerReviewProposalsAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchRequestBuyerReviewProposalsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Requests buyer review for `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be reviewed.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to request buyer review.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchRequestBuyerReviewProposalsResponse BatchRequestBuyerReviewProposals(NetworkName parent, scg::IEnumerable<ProposalName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchRequestBuyerReviewProposals(new BatchRequestBuyerReviewProposalsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ProposalNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Requests buyer review for `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be reviewed.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to request buyer review.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchRequestBuyerReviewProposalsResponse> BatchRequestBuyerReviewProposalsAsync(NetworkName parent, scg::IEnumerable<ProposalName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchRequestBuyerReviewProposalsAsync(new BatchRequestBuyerReviewProposalsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ProposalNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Requests buyer review for `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be reviewed.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to request buyer review.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchRequestBuyerReviewProposalsResponse> BatchRequestBuyerReviewProposalsAsync(NetworkName parent, scg::IEnumerable<ProposalName> names, st::CancellationToken cancellationToken) =>
            BatchRequestBuyerReviewProposalsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Requests buyer acceptance for `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchRequestBuyerAcceptProposalsResponse BatchRequestBuyerAcceptProposals(BatchRequestBuyerAcceptProposalsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Requests buyer acceptance for `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchRequestBuyerAcceptProposalsResponse> BatchRequestBuyerAcceptProposalsAsync(BatchRequestBuyerAcceptProposalsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Requests buyer acceptance for `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchRequestBuyerAcceptProposalsResponse> BatchRequestBuyerAcceptProposalsAsync(BatchRequestBuyerAcceptProposalsRequest request, st::CancellationToken cancellationToken) =>
            BatchRequestBuyerAcceptProposalsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Requests buyer acceptance for `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be accepted.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to request buyer accept.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchRequestBuyerAcceptProposalsResponse BatchRequestBuyerAcceptProposals(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchRequestBuyerAcceptProposals(new BatchRequestBuyerAcceptProposalsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Requests buyer acceptance for `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be accepted.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to request buyer accept.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchRequestBuyerAcceptProposalsResponse> BatchRequestBuyerAcceptProposalsAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchRequestBuyerAcceptProposalsAsync(new BatchRequestBuyerAcceptProposalsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Requests buyer acceptance for `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be accepted.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to request buyer accept.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchRequestBuyerAcceptProposalsResponse> BatchRequestBuyerAcceptProposalsAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchRequestBuyerAcceptProposalsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Requests buyer acceptance for `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be accepted.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to request buyer accept.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchRequestBuyerAcceptProposalsResponse BatchRequestBuyerAcceptProposals(NetworkName parent, scg::IEnumerable<ProposalName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchRequestBuyerAcceptProposals(new BatchRequestBuyerAcceptProposalsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ProposalNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Requests buyer acceptance for `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be accepted.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to request buyer accept.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchRequestBuyerAcceptProposalsResponse> BatchRequestBuyerAcceptProposalsAsync(NetworkName parent, scg::IEnumerable<ProposalName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchRequestBuyerAcceptProposalsAsync(new BatchRequestBuyerAcceptProposalsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ProposalNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Requests buyer acceptance for `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be accepted.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to request buyer accept.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchRequestBuyerAcceptProposalsResponse> BatchRequestBuyerAcceptProposalsAsync(NetworkName parent, scg::IEnumerable<ProposalName> names, st::CancellationToken cancellationToken) =>
            BatchRequestBuyerAcceptProposalsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reserves inventory for `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchReserveProposalsResponse BatchReserveProposals(BatchReserveProposalsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reserves inventory for `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchReserveProposalsResponse> BatchReserveProposalsAsync(BatchReserveProposalsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reserves inventory for `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchReserveProposalsResponse> BatchReserveProposalsAsync(BatchReserveProposalsRequest request, st::CancellationToken cancellationToken) =>
            BatchReserveProposalsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reserves inventory for `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be reserved.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to reserve.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchReserveProposalsResponse BatchReserveProposals(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchReserveProposals(new BatchReserveProposalsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Reserves inventory for `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be reserved.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to reserve.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchReserveProposalsResponse> BatchReserveProposalsAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchReserveProposalsAsync(new BatchReserveProposalsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Reserves inventory for `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be reserved.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to reserve.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchReserveProposalsResponse> BatchReserveProposalsAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchReserveProposalsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reserves inventory for `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be reserved.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to reserve.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchReserveProposalsResponse BatchReserveProposals(NetworkName parent, scg::IEnumerable<ProposalName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchReserveProposals(new BatchReserveProposalsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ProposalNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Reserves inventory for `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be reserved.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to reserve.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchReserveProposalsResponse> BatchReserveProposalsAsync(NetworkName parent, scg::IEnumerable<ProposalName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchReserveProposalsAsync(new BatchReserveProposalsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ProposalNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Reserves inventory for `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be reserved.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to reserve.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchReserveProposalsResponse> BatchReserveProposalsAsync(NetworkName parent, scg::IEnumerable<ProposalName> names, st::CancellationToken cancellationToken) =>
            BatchReserveProposalsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Redrafts `Proposal` objects for negotiation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchRedraftProposalsResponse BatchRedraftProposals(BatchRedraftProposalsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Redrafts `Proposal` objects for negotiation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchRedraftProposalsResponse> BatchRedraftProposalsAsync(BatchRedraftProposalsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Redrafts `Proposal` objects for negotiation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchRedraftProposalsResponse> BatchRedraftProposalsAsync(BatchRedraftProposalsRequest request, st::CancellationToken cancellationToken) =>
            BatchRedraftProposalsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Redrafts `Proposal` objects for negotiation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be redrafted.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to redraft.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchRedraftProposalsResponse BatchRedraftProposals(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchRedraftProposals(new BatchRedraftProposalsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Redrafts `Proposal` objects for negotiation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be redrafted.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to redraft.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchRedraftProposalsResponse> BatchRedraftProposalsAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchRedraftProposalsAsync(new BatchRedraftProposalsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Redrafts `Proposal` objects for negotiation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be redrafted.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to redraft.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchRedraftProposalsResponse> BatchRedraftProposalsAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchRedraftProposalsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Redrafts `Proposal` objects for negotiation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be redrafted.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to redraft.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchRedraftProposalsResponse BatchRedraftProposals(NetworkName parent, scg::IEnumerable<ProposalName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchRedraftProposals(new BatchRedraftProposalsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ProposalNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Redrafts `Proposal` objects for negotiation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be redrafted.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to redraft.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchRedraftProposalsResponse> BatchRedraftProposalsAsync(NetworkName parent, scg::IEnumerable<ProposalName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchRedraftProposalsAsync(new BatchRedraftProposalsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ProposalNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Redrafts `Proposal` objects for negotiation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be redrafted.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to redraft.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchRedraftProposalsResponse> BatchRedraftProposalsAsync(NetworkName parent, scg::IEnumerable<ProposalName> names, st::CancellationToken cancellationToken) =>
            BatchRedraftProposalsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Discards drafts, or revert local modifications, of `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDiscardDraftProposalsResponse BatchDiscardDraftProposals(BatchDiscardDraftProposalsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Discards drafts, or revert local modifications, of `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDiscardDraftProposalsResponse> BatchDiscardDraftProposalsAsync(BatchDiscardDraftProposalsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Discards drafts, or revert local modifications, of `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDiscardDraftProposalsResponse> BatchDiscardDraftProposalsAsync(BatchDiscardDraftProposalsRequest request, st::CancellationToken cancellationToken) =>
            BatchDiscardDraftProposalsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Discards drafts, or revert local modifications, of `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be discarded.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to discard.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDiscardDraftProposalsResponse BatchDiscardDraftProposals(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDiscardDraftProposals(new BatchDiscardDraftProposalsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Discards drafts, or revert local modifications, of `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be discarded.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to discard.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDiscardDraftProposalsResponse> BatchDiscardDraftProposalsAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDiscardDraftProposalsAsync(new BatchDiscardDraftProposalsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Discards drafts, or revert local modifications, of `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be discarded.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to discard.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDiscardDraftProposalsResponse> BatchDiscardDraftProposalsAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchDiscardDraftProposalsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Discards drafts, or revert local modifications, of `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be discarded.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to discard.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDiscardDraftProposalsResponse BatchDiscardDraftProposals(NetworkName parent, scg::IEnumerable<ProposalName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDiscardDraftProposals(new BatchDiscardDraftProposalsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ProposalNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Discards drafts, or revert local modifications, of `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be discarded.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to discard.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDiscardDraftProposalsResponse> BatchDiscardDraftProposalsAsync(NetworkName parent, scg::IEnumerable<ProposalName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDiscardDraftProposalsAsync(new BatchDiscardDraftProposalsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ProposalNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Discards drafts, or revert local modifications, of `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be discarded.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to discard.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDiscardDraftProposalsResponse> BatchDiscardDraftProposalsAsync(NetworkName parent, scg::IEnumerable<ProposalName> names, st::CancellationToken cancellationToken) =>
            BatchDiscardDraftProposalsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Terminates negotiation on `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchTerminateProposalsResponse BatchTerminateProposals(BatchTerminateProposalsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Terminates negotiation on `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchTerminateProposalsResponse> BatchTerminateProposalsAsync(BatchTerminateProposalsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Terminates negotiation on `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchTerminateProposalsResponse> BatchTerminateProposalsAsync(BatchTerminateProposalsRequest request, st::CancellationToken cancellationToken) =>
            BatchTerminateProposalsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Terminates negotiation on `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be terminated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to terminate.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchTerminateProposalsResponse BatchTerminateProposals(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchTerminateProposals(new BatchTerminateProposalsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Terminates negotiation on `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be terminated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to terminate.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchTerminateProposalsResponse> BatchTerminateProposalsAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchTerminateProposalsAsync(new BatchTerminateProposalsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Terminates negotiation on `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be terminated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to terminate.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchTerminateProposalsResponse> BatchTerminateProposalsAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchTerminateProposalsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Terminates negotiation on `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be terminated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to terminate.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchTerminateProposalsResponse BatchTerminateProposals(NetworkName parent, scg::IEnumerable<ProposalName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchTerminateProposals(new BatchTerminateProposalsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ProposalNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Terminates negotiation on `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be terminated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to terminate.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchTerminateProposalsResponse> BatchTerminateProposalsAsync(NetworkName parent, scg::IEnumerable<ProposalName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchTerminateProposalsAsync(new BatchTerminateProposalsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ProposalNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Terminates negotiation on `Proposal` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be terminated.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to terminate.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchTerminateProposalsResponse> BatchTerminateProposalsAsync(NetworkName parent, scg::IEnumerable<ProposalName> names, st::CancellationToken cancellationToken) =>
            BatchTerminateProposalsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Push changes on `Proposal`s to corresponding `Order`s, after negotiations
        /// have been finalized.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchPushToOrderProposalsResponse BatchPushToOrderProposals(BatchPushToOrderProposalsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Push changes on `Proposal`s to corresponding `Order`s, after negotiations
        /// have been finalized.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchPushToOrderProposalsResponse> BatchPushToOrderProposalsAsync(BatchPushToOrderProposalsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Push changes on `Proposal`s to corresponding `Order`s, after negotiations
        /// have been finalized.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchPushToOrderProposalsResponse> BatchPushToOrderProposalsAsync(BatchPushToOrderProposalsRequest request, st::CancellationToken cancellationToken) =>
            BatchPushToOrderProposalsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Push changes on `Proposal`s to corresponding `Order`s, after negotiations
        /// have been finalized.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be pushed to order.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to push to order.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchPushToOrderProposalsResponse BatchPushToOrderProposals(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchPushToOrderProposals(new BatchPushToOrderProposalsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Push changes on `Proposal`s to corresponding `Order`s, after negotiations
        /// have been finalized.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be pushed to order.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to push to order.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchPushToOrderProposalsResponse> BatchPushToOrderProposalsAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchPushToOrderProposalsAsync(new BatchPushToOrderProposalsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Push changes on `Proposal`s to corresponding `Order`s, after negotiations
        /// have been finalized.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be pushed to order.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to push to order.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchPushToOrderProposalsResponse> BatchPushToOrderProposalsAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchPushToOrderProposalsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Push changes on `Proposal`s to corresponding `Order`s, after negotiations
        /// have been finalized.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be pushed to order.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to push to order.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchPushToOrderProposalsResponse BatchPushToOrderProposals(NetworkName parent, scg::IEnumerable<ProposalName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchPushToOrderProposals(new BatchPushToOrderProposalsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ProposalNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Push changes on `Proposal`s to corresponding `Order`s, after negotiations
        /// have been finalized.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be pushed to order.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to push to order.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchPushToOrderProposalsResponse> BatchPushToOrderProposalsAsync(NetworkName parent, scg::IEnumerable<ProposalName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchPushToOrderProposalsAsync(new BatchPushToOrderProposalsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ProposalNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Push changes on `Proposal`s to corresponding `Order`s, after negotiations
        /// have been finalized.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where proposals will be pushed to order.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals to push to order.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchPushToOrderProposalsResponse> BatchPushToOrderProposalsAsync(NetworkName parent, scg::IEnumerable<ProposalName> names, st::CancellationToken cancellationToken) =>
            BatchPushToOrderProposalsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches MarketplaceComments made on `Proposal`s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MarketplaceComment"/> resources.</returns>
        public virtual gax::PagedEnumerable<FetchMarketplaceCommentsResponse, MarketplaceComment> FetchMarketplaceComments(FetchMarketplaceCommentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches MarketplaceComments made on `Proposal`s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MarketplaceComment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<FetchMarketplaceCommentsResponse, MarketplaceComment> FetchMarketplaceCommentsAsync(FetchMarketplaceCommentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches MarketplaceComments made on `Proposal`s.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where MarketplaceComments will be fetched
        /// from. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals for which to fetch
        /// marketplace comments. A maximum of 50 proposal names can be specified.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
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
        /// <returns>A pageable sequence of <see cref="MarketplaceComment"/> resources.</returns>
        public virtual gax::PagedEnumerable<FetchMarketplaceCommentsResponse, MarketplaceComment> FetchMarketplaceComments(string parent, scg::IEnumerable<string> names, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            FetchMarketplaceCommentsRequest request = new FetchMarketplaceCommentsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return FetchMarketplaceComments(request, callSettings);
        }

        /// <summary>
        /// Fetches MarketplaceComments made on `Proposal`s.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where MarketplaceComments will be fetched
        /// from. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals for which to fetch
        /// marketplace comments. A maximum of 50 proposal names can be specified.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="MarketplaceComment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<FetchMarketplaceCommentsResponse, MarketplaceComment> FetchMarketplaceCommentsAsync(string parent, scg::IEnumerable<string> names, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            FetchMarketplaceCommentsRequest request = new FetchMarketplaceCommentsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return FetchMarketplaceCommentsAsync(request, callSettings);
        }

        /// <summary>
        /// Fetches MarketplaceComments made on `Proposal`s.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where MarketplaceComments will be fetched
        /// from. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals for which to fetch
        /// marketplace comments. A maximum of 50 proposal names can be specified.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
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
        /// <returns>A pageable sequence of <see cref="MarketplaceComment"/> resources.</returns>
        public virtual gax::PagedEnumerable<FetchMarketplaceCommentsResponse, MarketplaceComment> FetchMarketplaceComments(NetworkName parent, scg::IEnumerable<ProposalName> names, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            FetchMarketplaceCommentsRequest request = new FetchMarketplaceCommentsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ProposalNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return FetchMarketplaceComments(request, callSettings);
        }

        /// <summary>
        /// Fetches MarketplaceComments made on `Proposal`s.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where MarketplaceComments will be fetched
        /// from. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the Proposals for which to fetch
        /// marketplace comments. A maximum of 50 proposal names can be specified.
        /// Format: `networks/{network_code}/proposals/{proposal_id}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="MarketplaceComment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<FetchMarketplaceCommentsResponse, MarketplaceComment> FetchMarketplaceCommentsAsync(NetworkName parent, scg::IEnumerable<ProposalName> names, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            FetchMarketplaceCommentsRequest request = new FetchMarketplaceCommentsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ProposalNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return FetchMarketplaceCommentsAsync(request, callSettings);
        }
    }

    /// <summary>ProposalService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `Proposal` objects.
    /// </remarks>
    public sealed partial class ProposalServiceClientImpl : ProposalServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetProposalRequest, Proposal> _callGetProposal;

        private readonly gaxgrpc::ApiCall<ListProposalsRequest, ListProposalsResponse> _callListProposals;

        private readonly gaxgrpc::ApiCall<CreateProposalRequest, Proposal> _callCreateProposal;

        private readonly gaxgrpc::ApiCall<BatchCreateProposalsRequest, BatchCreateProposalsResponse> _callBatchCreateProposals;

        private readonly gaxgrpc::ApiCall<UpdateProposalRequest, Proposal> _callUpdateProposal;

        private readonly gaxgrpc::ApiCall<BatchUpdateProposalsRequest, BatchUpdateProposalsResponse> _callBatchUpdateProposals;

        private readonly gaxgrpc::ApiCall<BatchArchiveProposalsRequest, BatchArchiveProposalsResponse> _callBatchArchiveProposals;

        private readonly gaxgrpc::ApiCall<BatchUnarchiveProposalsRequest, BatchUnarchiveProposalsResponse> _callBatchUnarchiveProposals;

        private readonly gaxgrpc::ApiCall<BatchPauseProposalsRequest, BatchPauseProposalsResponse> _callBatchPauseProposals;

        private readonly gaxgrpc::ApiCall<BatchResumeProposalsRequest, BatchResumeProposalsResponse> _callBatchResumeProposals;

        private readonly gaxgrpc::ApiCall<BatchRequestBuyerReviewProposalsRequest, BatchRequestBuyerReviewProposalsResponse> _callBatchRequestBuyerReviewProposals;

        private readonly gaxgrpc::ApiCall<BatchRequestBuyerAcceptProposalsRequest, BatchRequestBuyerAcceptProposalsResponse> _callBatchRequestBuyerAcceptProposals;

        private readonly gaxgrpc::ApiCall<BatchReserveProposalsRequest, BatchReserveProposalsResponse> _callBatchReserveProposals;

        private readonly gaxgrpc::ApiCall<BatchRedraftProposalsRequest, BatchRedraftProposalsResponse> _callBatchRedraftProposals;

        private readonly gaxgrpc::ApiCall<BatchDiscardDraftProposalsRequest, BatchDiscardDraftProposalsResponse> _callBatchDiscardDraftProposals;

        private readonly gaxgrpc::ApiCall<BatchTerminateProposalsRequest, BatchTerminateProposalsResponse> _callBatchTerminateProposals;

        private readonly gaxgrpc::ApiCall<BatchPushToOrderProposalsRequest, BatchPushToOrderProposalsResponse> _callBatchPushToOrderProposals;

        private readonly gaxgrpc::ApiCall<FetchMarketplaceCommentsRequest, FetchMarketplaceCommentsResponse> _callFetchMarketplaceComments;

        /// <summary>
        /// Constructs a client wrapper for the ProposalService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ProposalServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ProposalServiceClientImpl(ProposalService.ProposalServiceClient grpcClient, ProposalServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ProposalServiceSettings effectiveSettings = settings ?? ProposalServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetProposal = clientHelper.BuildApiCall<GetProposalRequest, Proposal>("GetProposal", grpcClient.GetProposalAsync, grpcClient.GetProposal, effectiveSettings.GetProposalSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetProposal);
            Modify_GetProposalApiCall(ref _callGetProposal);
            _callListProposals = clientHelper.BuildApiCall<ListProposalsRequest, ListProposalsResponse>("ListProposals", grpcClient.ListProposalsAsync, grpcClient.ListProposals, effectiveSettings.ListProposalsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListProposals);
            Modify_ListProposalsApiCall(ref _callListProposals);
            _callCreateProposal = clientHelper.BuildApiCall<CreateProposalRequest, Proposal>("CreateProposal", grpcClient.CreateProposalAsync, grpcClient.CreateProposal, effectiveSettings.CreateProposalSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateProposal);
            Modify_CreateProposalApiCall(ref _callCreateProposal);
            _callBatchCreateProposals = clientHelper.BuildApiCall<BatchCreateProposalsRequest, BatchCreateProposalsResponse>("BatchCreateProposals", grpcClient.BatchCreateProposalsAsync, grpcClient.BatchCreateProposals, effectiveSettings.BatchCreateProposalsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchCreateProposals);
            Modify_BatchCreateProposalsApiCall(ref _callBatchCreateProposals);
            _callUpdateProposal = clientHelper.BuildApiCall<UpdateProposalRequest, Proposal>("UpdateProposal", grpcClient.UpdateProposalAsync, grpcClient.UpdateProposal, effectiveSettings.UpdateProposalSettings).WithGoogleRequestParam("proposal.name", request => request.Proposal?.Name);
            Modify_ApiCall(ref _callUpdateProposal);
            Modify_UpdateProposalApiCall(ref _callUpdateProposal);
            _callBatchUpdateProposals = clientHelper.BuildApiCall<BatchUpdateProposalsRequest, BatchUpdateProposalsResponse>("BatchUpdateProposals", grpcClient.BatchUpdateProposalsAsync, grpcClient.BatchUpdateProposals, effectiveSettings.BatchUpdateProposalsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchUpdateProposals);
            Modify_BatchUpdateProposalsApiCall(ref _callBatchUpdateProposals);
            _callBatchArchiveProposals = clientHelper.BuildApiCall<BatchArchiveProposalsRequest, BatchArchiveProposalsResponse>("BatchArchiveProposals", grpcClient.BatchArchiveProposalsAsync, grpcClient.BatchArchiveProposals, effectiveSettings.BatchArchiveProposalsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchArchiveProposals);
            Modify_BatchArchiveProposalsApiCall(ref _callBatchArchiveProposals);
            _callBatchUnarchiveProposals = clientHelper.BuildApiCall<BatchUnarchiveProposalsRequest, BatchUnarchiveProposalsResponse>("BatchUnarchiveProposals", grpcClient.BatchUnarchiveProposalsAsync, grpcClient.BatchUnarchiveProposals, effectiveSettings.BatchUnarchiveProposalsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchUnarchiveProposals);
            Modify_BatchUnarchiveProposalsApiCall(ref _callBatchUnarchiveProposals);
            _callBatchPauseProposals = clientHelper.BuildApiCall<BatchPauseProposalsRequest, BatchPauseProposalsResponse>("BatchPauseProposals", grpcClient.BatchPauseProposalsAsync, grpcClient.BatchPauseProposals, effectiveSettings.BatchPauseProposalsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchPauseProposals);
            Modify_BatchPauseProposalsApiCall(ref _callBatchPauseProposals);
            _callBatchResumeProposals = clientHelper.BuildApiCall<BatchResumeProposalsRequest, BatchResumeProposalsResponse>("BatchResumeProposals", grpcClient.BatchResumeProposalsAsync, grpcClient.BatchResumeProposals, effectiveSettings.BatchResumeProposalsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchResumeProposals);
            Modify_BatchResumeProposalsApiCall(ref _callBatchResumeProposals);
            _callBatchRequestBuyerReviewProposals = clientHelper.BuildApiCall<BatchRequestBuyerReviewProposalsRequest, BatchRequestBuyerReviewProposalsResponse>("BatchRequestBuyerReviewProposals", grpcClient.BatchRequestBuyerReviewProposalsAsync, grpcClient.BatchRequestBuyerReviewProposals, effectiveSettings.BatchRequestBuyerReviewProposalsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchRequestBuyerReviewProposals);
            Modify_BatchRequestBuyerReviewProposalsApiCall(ref _callBatchRequestBuyerReviewProposals);
            _callBatchRequestBuyerAcceptProposals = clientHelper.BuildApiCall<BatchRequestBuyerAcceptProposalsRequest, BatchRequestBuyerAcceptProposalsResponse>("BatchRequestBuyerAcceptProposals", grpcClient.BatchRequestBuyerAcceptProposalsAsync, grpcClient.BatchRequestBuyerAcceptProposals, effectiveSettings.BatchRequestBuyerAcceptProposalsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchRequestBuyerAcceptProposals);
            Modify_BatchRequestBuyerAcceptProposalsApiCall(ref _callBatchRequestBuyerAcceptProposals);
            _callBatchReserveProposals = clientHelper.BuildApiCall<BatchReserveProposalsRequest, BatchReserveProposalsResponse>("BatchReserveProposals", grpcClient.BatchReserveProposalsAsync, grpcClient.BatchReserveProposals, effectiveSettings.BatchReserveProposalsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchReserveProposals);
            Modify_BatchReserveProposalsApiCall(ref _callBatchReserveProposals);
            _callBatchRedraftProposals = clientHelper.BuildApiCall<BatchRedraftProposalsRequest, BatchRedraftProposalsResponse>("BatchRedraftProposals", grpcClient.BatchRedraftProposalsAsync, grpcClient.BatchRedraftProposals, effectiveSettings.BatchRedraftProposalsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchRedraftProposals);
            Modify_BatchRedraftProposalsApiCall(ref _callBatchRedraftProposals);
            _callBatchDiscardDraftProposals = clientHelper.BuildApiCall<BatchDiscardDraftProposalsRequest, BatchDiscardDraftProposalsResponse>("BatchDiscardDraftProposals", grpcClient.BatchDiscardDraftProposalsAsync, grpcClient.BatchDiscardDraftProposals, effectiveSettings.BatchDiscardDraftProposalsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchDiscardDraftProposals);
            Modify_BatchDiscardDraftProposalsApiCall(ref _callBatchDiscardDraftProposals);
            _callBatchTerminateProposals = clientHelper.BuildApiCall<BatchTerminateProposalsRequest, BatchTerminateProposalsResponse>("BatchTerminateProposals", grpcClient.BatchTerminateProposalsAsync, grpcClient.BatchTerminateProposals, effectiveSettings.BatchTerminateProposalsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchTerminateProposals);
            Modify_BatchTerminateProposalsApiCall(ref _callBatchTerminateProposals);
            _callBatchPushToOrderProposals = clientHelper.BuildApiCall<BatchPushToOrderProposalsRequest, BatchPushToOrderProposalsResponse>("BatchPushToOrderProposals", grpcClient.BatchPushToOrderProposalsAsync, grpcClient.BatchPushToOrderProposals, effectiveSettings.BatchPushToOrderProposalsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchPushToOrderProposals);
            Modify_BatchPushToOrderProposalsApiCall(ref _callBatchPushToOrderProposals);
            _callFetchMarketplaceComments = clientHelper.BuildApiCall<FetchMarketplaceCommentsRequest, FetchMarketplaceCommentsResponse>("FetchMarketplaceComments", grpcClient.FetchMarketplaceCommentsAsync, grpcClient.FetchMarketplaceComments, effectiveSettings.FetchMarketplaceCommentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callFetchMarketplaceComments);
            Modify_FetchMarketplaceCommentsApiCall(ref _callFetchMarketplaceComments);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetProposalApiCall(ref gaxgrpc::ApiCall<GetProposalRequest, Proposal> call);

        partial void Modify_ListProposalsApiCall(ref gaxgrpc::ApiCall<ListProposalsRequest, ListProposalsResponse> call);

        partial void Modify_CreateProposalApiCall(ref gaxgrpc::ApiCall<CreateProposalRequest, Proposal> call);

        partial void Modify_BatchCreateProposalsApiCall(ref gaxgrpc::ApiCall<BatchCreateProposalsRequest, BatchCreateProposalsResponse> call);

        partial void Modify_UpdateProposalApiCall(ref gaxgrpc::ApiCall<UpdateProposalRequest, Proposal> call);

        partial void Modify_BatchUpdateProposalsApiCall(ref gaxgrpc::ApiCall<BatchUpdateProposalsRequest, BatchUpdateProposalsResponse> call);

        partial void Modify_BatchArchiveProposalsApiCall(ref gaxgrpc::ApiCall<BatchArchiveProposalsRequest, BatchArchiveProposalsResponse> call);

        partial void Modify_BatchUnarchiveProposalsApiCall(ref gaxgrpc::ApiCall<BatchUnarchiveProposalsRequest, BatchUnarchiveProposalsResponse> call);

        partial void Modify_BatchPauseProposalsApiCall(ref gaxgrpc::ApiCall<BatchPauseProposalsRequest, BatchPauseProposalsResponse> call);

        partial void Modify_BatchResumeProposalsApiCall(ref gaxgrpc::ApiCall<BatchResumeProposalsRequest, BatchResumeProposalsResponse> call);

        partial void Modify_BatchRequestBuyerReviewProposalsApiCall(ref gaxgrpc::ApiCall<BatchRequestBuyerReviewProposalsRequest, BatchRequestBuyerReviewProposalsResponse> call);

        partial void Modify_BatchRequestBuyerAcceptProposalsApiCall(ref gaxgrpc::ApiCall<BatchRequestBuyerAcceptProposalsRequest, BatchRequestBuyerAcceptProposalsResponse> call);

        partial void Modify_BatchReserveProposalsApiCall(ref gaxgrpc::ApiCall<BatchReserveProposalsRequest, BatchReserveProposalsResponse> call);

        partial void Modify_BatchRedraftProposalsApiCall(ref gaxgrpc::ApiCall<BatchRedraftProposalsRequest, BatchRedraftProposalsResponse> call);

        partial void Modify_BatchDiscardDraftProposalsApiCall(ref gaxgrpc::ApiCall<BatchDiscardDraftProposalsRequest, BatchDiscardDraftProposalsResponse> call);

        partial void Modify_BatchTerminateProposalsApiCall(ref gaxgrpc::ApiCall<BatchTerminateProposalsRequest, BatchTerminateProposalsResponse> call);

        partial void Modify_BatchPushToOrderProposalsApiCall(ref gaxgrpc::ApiCall<BatchPushToOrderProposalsRequest, BatchPushToOrderProposalsResponse> call);

        partial void Modify_FetchMarketplaceCommentsApiCall(ref gaxgrpc::ApiCall<FetchMarketplaceCommentsRequest, FetchMarketplaceCommentsResponse> call);

        partial void OnConstruction(ProposalService.ProposalServiceClient grpcClient, ProposalServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ProposalService client</summary>
        public override ProposalService.ProposalServiceClient GrpcClient { get; }

        partial void Modify_GetProposalRequest(ref GetProposalRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListProposalsRequest(ref ListProposalsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateProposalRequest(ref CreateProposalRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchCreateProposalsRequest(ref BatchCreateProposalsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateProposalRequest(ref UpdateProposalRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchUpdateProposalsRequest(ref BatchUpdateProposalsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchArchiveProposalsRequest(ref BatchArchiveProposalsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchUnarchiveProposalsRequest(ref BatchUnarchiveProposalsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchPauseProposalsRequest(ref BatchPauseProposalsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchResumeProposalsRequest(ref BatchResumeProposalsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchRequestBuyerReviewProposalsRequest(ref BatchRequestBuyerReviewProposalsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchRequestBuyerAcceptProposalsRequest(ref BatchRequestBuyerAcceptProposalsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchReserveProposalsRequest(ref BatchReserveProposalsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchRedraftProposalsRequest(ref BatchRedraftProposalsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchDiscardDraftProposalsRequest(ref BatchDiscardDraftProposalsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchTerminateProposalsRequest(ref BatchTerminateProposalsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchPushToOrderProposalsRequest(ref BatchPushToOrderProposalsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FetchMarketplaceCommentsRequest(ref FetchMarketplaceCommentsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves a `Proposal` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Proposal GetProposal(GetProposalRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProposalRequest(ref request, ref callSettings);
            return _callGetProposal.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a `Proposal` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Proposal> GetProposalAsync(GetProposalRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProposalRequest(ref request, ref callSettings);
            return _callGetProposal.Async(request, callSettings);
        }

        /// <summary>
        /// Lists `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Proposal"/> resources.</returns>
        public override gax::PagedEnumerable<ListProposalsResponse, Proposal> ListProposals(ListProposalsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProposalsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListProposalsRequest, ListProposalsResponse, Proposal>(_callListProposals, request, callSettings);
        }

        /// <summary>
        /// Lists `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Proposal"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListProposalsResponse, Proposal> ListProposalsAsync(ListProposalsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProposalsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListProposalsRequest, ListProposalsResponse, Proposal>(_callListProposals, request, callSettings);
        }

        /// <summary>
        /// Creates a `Proposal` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Proposal CreateProposal(CreateProposalRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateProposalRequest(ref request, ref callSettings);
            return _callCreateProposal.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a `Proposal` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Proposal> CreateProposalAsync(CreateProposalRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateProposalRequest(ref request, ref callSettings);
            return _callCreateProposal.Async(request, callSettings);
        }

        /// <summary>
        /// Creates `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchCreateProposalsResponse BatchCreateProposals(BatchCreateProposalsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateProposalsRequest(ref request, ref callSettings);
            return _callBatchCreateProposals.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchCreateProposalsResponse> BatchCreateProposalsAsync(BatchCreateProposalsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateProposalsRequest(ref request, ref callSettings);
            return _callBatchCreateProposals.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a `Proposal` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Proposal UpdateProposal(UpdateProposalRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateProposalRequest(ref request, ref callSettings);
            return _callUpdateProposal.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a `Proposal` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Proposal> UpdateProposalAsync(UpdateProposalRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateProposalRequest(ref request, ref callSettings);
            return _callUpdateProposal.Async(request, callSettings);
        }

        /// <summary>
        /// Batch updates `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchUpdateProposalsResponse BatchUpdateProposals(BatchUpdateProposalsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateProposalsRequest(ref request, ref callSettings);
            return _callBatchUpdateProposals.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch updates `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchUpdateProposalsResponse> BatchUpdateProposalsAsync(BatchUpdateProposalsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateProposalsRequest(ref request, ref callSettings);
            return _callBatchUpdateProposals.Async(request, callSettings);
        }

        /// <summary>
        /// Archives `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchArchiveProposalsResponse BatchArchiveProposals(BatchArchiveProposalsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchArchiveProposalsRequest(ref request, ref callSettings);
            return _callBatchArchiveProposals.Sync(request, callSettings);
        }

        /// <summary>
        /// Archives `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchArchiveProposalsResponse> BatchArchiveProposalsAsync(BatchArchiveProposalsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchArchiveProposalsRequest(ref request, ref callSettings);
            return _callBatchArchiveProposals.Async(request, callSettings);
        }

        /// <summary>
        /// Unarchives `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchUnarchiveProposalsResponse BatchUnarchiveProposals(BatchUnarchiveProposalsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUnarchiveProposalsRequest(ref request, ref callSettings);
            return _callBatchUnarchiveProposals.Sync(request, callSettings);
        }

        /// <summary>
        /// Unarchives `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchUnarchiveProposalsResponse> BatchUnarchiveProposalsAsync(BatchUnarchiveProposalsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUnarchiveProposalsRequest(ref request, ref callSettings);
            return _callBatchUnarchiveProposals.Async(request, callSettings);
        }

        /// <summary>
        /// Pauses `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchPauseProposalsResponse BatchPauseProposals(BatchPauseProposalsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchPauseProposalsRequest(ref request, ref callSettings);
            return _callBatchPauseProposals.Sync(request, callSettings);
        }

        /// <summary>
        /// Pauses `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchPauseProposalsResponse> BatchPauseProposalsAsync(BatchPauseProposalsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchPauseProposalsRequest(ref request, ref callSettings);
            return _callBatchPauseProposals.Async(request, callSettings);
        }

        /// <summary>
        /// Resumes `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchResumeProposalsResponse BatchResumeProposals(BatchResumeProposalsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchResumeProposalsRequest(ref request, ref callSettings);
            return _callBatchResumeProposals.Sync(request, callSettings);
        }

        /// <summary>
        /// Resumes `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchResumeProposalsResponse> BatchResumeProposalsAsync(BatchResumeProposalsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchResumeProposalsRequest(ref request, ref callSettings);
            return _callBatchResumeProposals.Async(request, callSettings);
        }

        /// <summary>
        /// Requests buyer review for `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchRequestBuyerReviewProposalsResponse BatchRequestBuyerReviewProposals(BatchRequestBuyerReviewProposalsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchRequestBuyerReviewProposalsRequest(ref request, ref callSettings);
            return _callBatchRequestBuyerReviewProposals.Sync(request, callSettings);
        }

        /// <summary>
        /// Requests buyer review for `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchRequestBuyerReviewProposalsResponse> BatchRequestBuyerReviewProposalsAsync(BatchRequestBuyerReviewProposalsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchRequestBuyerReviewProposalsRequest(ref request, ref callSettings);
            return _callBatchRequestBuyerReviewProposals.Async(request, callSettings);
        }

        /// <summary>
        /// Requests buyer acceptance for `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchRequestBuyerAcceptProposalsResponse BatchRequestBuyerAcceptProposals(BatchRequestBuyerAcceptProposalsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchRequestBuyerAcceptProposalsRequest(ref request, ref callSettings);
            return _callBatchRequestBuyerAcceptProposals.Sync(request, callSettings);
        }

        /// <summary>
        /// Requests buyer acceptance for `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchRequestBuyerAcceptProposalsResponse> BatchRequestBuyerAcceptProposalsAsync(BatchRequestBuyerAcceptProposalsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchRequestBuyerAcceptProposalsRequest(ref request, ref callSettings);
            return _callBatchRequestBuyerAcceptProposals.Async(request, callSettings);
        }

        /// <summary>
        /// Reserves inventory for `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchReserveProposalsResponse BatchReserveProposals(BatchReserveProposalsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchReserveProposalsRequest(ref request, ref callSettings);
            return _callBatchReserveProposals.Sync(request, callSettings);
        }

        /// <summary>
        /// Reserves inventory for `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchReserveProposalsResponse> BatchReserveProposalsAsync(BatchReserveProposalsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchReserveProposalsRequest(ref request, ref callSettings);
            return _callBatchReserveProposals.Async(request, callSettings);
        }

        /// <summary>
        /// Redrafts `Proposal` objects for negotiation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchRedraftProposalsResponse BatchRedraftProposals(BatchRedraftProposalsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchRedraftProposalsRequest(ref request, ref callSettings);
            return _callBatchRedraftProposals.Sync(request, callSettings);
        }

        /// <summary>
        /// Redrafts `Proposal` objects for negotiation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchRedraftProposalsResponse> BatchRedraftProposalsAsync(BatchRedraftProposalsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchRedraftProposalsRequest(ref request, ref callSettings);
            return _callBatchRedraftProposals.Async(request, callSettings);
        }

        /// <summary>
        /// Discards drafts, or revert local modifications, of `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchDiscardDraftProposalsResponse BatchDiscardDraftProposals(BatchDiscardDraftProposalsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDiscardDraftProposalsRequest(ref request, ref callSettings);
            return _callBatchDiscardDraftProposals.Sync(request, callSettings);
        }

        /// <summary>
        /// Discards drafts, or revert local modifications, of `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchDiscardDraftProposalsResponse> BatchDiscardDraftProposalsAsync(BatchDiscardDraftProposalsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDiscardDraftProposalsRequest(ref request, ref callSettings);
            return _callBatchDiscardDraftProposals.Async(request, callSettings);
        }

        /// <summary>
        /// Terminates negotiation on `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchTerminateProposalsResponse BatchTerminateProposals(BatchTerminateProposalsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchTerminateProposalsRequest(ref request, ref callSettings);
            return _callBatchTerminateProposals.Sync(request, callSettings);
        }

        /// <summary>
        /// Terminates negotiation on `Proposal` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchTerminateProposalsResponse> BatchTerminateProposalsAsync(BatchTerminateProposalsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchTerminateProposalsRequest(ref request, ref callSettings);
            return _callBatchTerminateProposals.Async(request, callSettings);
        }

        /// <summary>
        /// Push changes on `Proposal`s to corresponding `Order`s, after negotiations
        /// have been finalized.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchPushToOrderProposalsResponse BatchPushToOrderProposals(BatchPushToOrderProposalsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchPushToOrderProposalsRequest(ref request, ref callSettings);
            return _callBatchPushToOrderProposals.Sync(request, callSettings);
        }

        /// <summary>
        /// Push changes on `Proposal`s to corresponding `Order`s, after negotiations
        /// have been finalized.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchPushToOrderProposalsResponse> BatchPushToOrderProposalsAsync(BatchPushToOrderProposalsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchPushToOrderProposalsRequest(ref request, ref callSettings);
            return _callBatchPushToOrderProposals.Async(request, callSettings);
        }

        /// <summary>
        /// Fetches MarketplaceComments made on `Proposal`s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MarketplaceComment"/> resources.</returns>
        public override gax::PagedEnumerable<FetchMarketplaceCommentsResponse, MarketplaceComment> FetchMarketplaceComments(FetchMarketplaceCommentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchMarketplaceCommentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<FetchMarketplaceCommentsRequest, FetchMarketplaceCommentsResponse, MarketplaceComment>(_callFetchMarketplaceComments, request, callSettings);
        }

        /// <summary>
        /// Fetches MarketplaceComments made on `Proposal`s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MarketplaceComment"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<FetchMarketplaceCommentsResponse, MarketplaceComment> FetchMarketplaceCommentsAsync(FetchMarketplaceCommentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchMarketplaceCommentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<FetchMarketplaceCommentsRequest, FetchMarketplaceCommentsResponse, MarketplaceComment>(_callFetchMarketplaceComments, request, callSettings);
        }
    }

    public partial class ListProposalsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class FetchMarketplaceCommentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListProposalsResponse : gaxgrpc::IPageResponse<Proposal>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Proposal> GetEnumerator() => Proposals.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class FetchMarketplaceCommentsResponse : gaxgrpc::IPageResponse<MarketplaceComment>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<MarketplaceComment> GetEnumerator() => MarketplaceComments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
