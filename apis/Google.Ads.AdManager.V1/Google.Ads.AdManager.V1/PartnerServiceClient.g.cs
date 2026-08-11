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
    /// <summary>Settings for <see cref="PartnerServiceClient"/> instances.</summary>
    public sealed partial class PartnerServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="PartnerServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="PartnerServiceSettings"/>.</returns>
        public static PartnerServiceSettings GetDefault() => new PartnerServiceSettings();

        /// <summary>Constructs a new <see cref="PartnerServiceSettings"/> object with default settings.</summary>
        public PartnerServiceSettings()
        {
        }

        private PartnerServiceSettings(PartnerServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetPartnerSettings = existing.GetPartnerSettings;
            ListPartnersSettings = existing.ListPartnersSettings;
            UpdatePartnerSettings = existing.UpdatePartnerSettings;
            BatchUpdatePartnersSettings = existing.BatchUpdatePartnersSettings;
            OnCopy(existing);
        }

        partial void OnCopy(PartnerServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PartnerServiceClient.GetPartner</c> and <c>PartnerServiceClient.GetPartnerAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetPartnerSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PartnerServiceClient.ListPartners</c> and <c>PartnerServiceClient.ListPartnersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListPartnersSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PartnerServiceClient.UpdatePartner</c> and <c>PartnerServiceClient.UpdatePartnerAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdatePartnerSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PartnerServiceClient.BatchUpdatePartners</c> and <c>PartnerServiceClient.BatchUpdatePartnersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchUpdatePartnersSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="PartnerServiceSettings"/> object.</returns>
        public PartnerServiceSettings Clone() => new PartnerServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="PartnerServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class PartnerServiceClientBuilder : gaxgrpc::ClientBuilderBase<PartnerServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public PartnerServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public PartnerServiceClientBuilder() : base(PartnerServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref PartnerServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<PartnerServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override PartnerServiceClient Build()
        {
            PartnerServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<PartnerServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<PartnerServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private PartnerServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return PartnerServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<PartnerServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return PartnerServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => PartnerServiceClient.ChannelPool;
    }

    /// <summary>PartnerService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling [Partner][google.ads.admanager.v1.Partner]
    /// objects.
    /// </remarks>
    public abstract partial class PartnerServiceClient
    {
        /// <summary>
        /// The default endpoint for the PartnerService service, which is a host of "admanager.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default PartnerService scopes.</summary>
        /// <remarks>
        /// The default PartnerService scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(PartnerService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="PartnerServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="PartnerServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="PartnerServiceClient"/>.</returns>
        public static stt::Task<PartnerServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new PartnerServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="PartnerServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="PartnerServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="PartnerServiceClient"/>.</returns>
        public static PartnerServiceClient Create() => new PartnerServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="PartnerServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="PartnerServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="PartnerServiceClient"/>.</returns>
        internal static PartnerServiceClient Create(grpccore::CallInvoker callInvoker, PartnerServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            PartnerService.PartnerServiceClient grpcClient = new PartnerService.PartnerServiceClient(callInvoker);
            return new PartnerServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC PartnerService client</summary>
        public virtual PartnerService.PartnerServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a [Partner][google.ads.admanager.v1.Partner] object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Partner GetPartner(GetPartnerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a [Partner][google.ads.admanager.v1.Partner] object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Partner> GetPartnerAsync(GetPartnerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a [Partner][google.ads.admanager.v1.Partner] object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Partner> GetPartnerAsync(GetPartnerRequest request, st::CancellationToken cancellationToken) =>
            GetPartnerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a [Partner][google.ads.admanager.v1.Partner] object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [Partner][google.ads.admanager.v1.Partner]. Format:
        /// `networks/{network_code}/partners/{partner_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Partner GetPartner(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPartner(new GetPartnerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a [Partner][google.ads.admanager.v1.Partner] object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [Partner][google.ads.admanager.v1.Partner]. Format:
        /// `networks/{network_code}/partners/{partner_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Partner> GetPartnerAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPartnerAsync(new GetPartnerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a [Partner][google.ads.admanager.v1.Partner] object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [Partner][google.ads.admanager.v1.Partner]. Format:
        /// `networks/{network_code}/partners/{partner_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Partner> GetPartnerAsync(string name, st::CancellationToken cancellationToken) =>
            GetPartnerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a [Partner][google.ads.admanager.v1.Partner] object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [Partner][google.ads.admanager.v1.Partner]. Format:
        /// `networks/{network_code}/partners/{partner_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Partner GetPartner(PartnerName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPartner(new GetPartnerRequest
            {
                PartnerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a [Partner][google.ads.admanager.v1.Partner] object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [Partner][google.ads.admanager.v1.Partner]. Format:
        /// `networks/{network_code}/partners/{partner_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Partner> GetPartnerAsync(PartnerName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPartnerAsync(new GetPartnerRequest
            {
                PartnerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a [Partner][google.ads.admanager.v1.Partner] object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [Partner][google.ads.admanager.v1.Partner]. Format:
        /// `networks/{network_code}/partners/{partner_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Partner> GetPartnerAsync(PartnerName name, st::CancellationToken cancellationToken) =>
            GetPartnerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists [Partner][google.ads.admanager.v1.Partner] objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Partner"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPartnersResponse, Partner> ListPartners(ListPartnersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [Partner][google.ads.admanager.v1.Partner] objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Partner"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPartnersResponse, Partner> ListPartnersAsync(ListPartnersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [Partner][google.ads.admanager.v1.Partner] objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of
        /// [Partner][google.ads.admanager.v1.Partner]s. Format:
        /// `networks/{network_code}`
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
        /// <returns>A pageable sequence of <see cref="Partner"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPartnersResponse, Partner> ListPartners(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPartnersRequest request = new ListPartnersRequest
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
            return ListPartners(request, callSettings);
        }

        /// <summary>
        /// Lists [Partner][google.ads.admanager.v1.Partner] objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of
        /// [Partner][google.ads.admanager.v1.Partner]s. Format:
        /// `networks/{network_code}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Partner"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPartnersResponse, Partner> ListPartnersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPartnersRequest request = new ListPartnersRequest
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
            return ListPartnersAsync(request, callSettings);
        }

        /// <summary>
        /// Lists [Partner][google.ads.admanager.v1.Partner] objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of
        /// [Partner][google.ads.admanager.v1.Partner]s. Format:
        /// `networks/{network_code}`
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
        /// <returns>A pageable sequence of <see cref="Partner"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPartnersResponse, Partner> ListPartners(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPartnersRequest request = new ListPartnersRequest
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
            return ListPartners(request, callSettings);
        }

        /// <summary>
        /// Lists [Partner][google.ads.admanager.v1.Partner] objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of
        /// [Partner][google.ads.admanager.v1.Partner]s. Format:
        /// `networks/{network_code}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Partner"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPartnersResponse, Partner> ListPartnersAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPartnersRequest request = new ListPartnersRequest
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
            return ListPartnersAsync(request, callSettings);
        }

        /// <summary>
        /// Updates a [Partner][google.ads.admanager.v1.Partner] object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Partner UpdatePartner(UpdatePartnerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a [Partner][google.ads.admanager.v1.Partner] object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Partner> UpdatePartnerAsync(UpdatePartnerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a [Partner][google.ads.admanager.v1.Partner] object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Partner> UpdatePartnerAsync(UpdatePartnerRequest request, st::CancellationToken cancellationToken) =>
            UpdatePartnerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a [Partner][google.ads.admanager.v1.Partner] object.
        /// </summary>
        /// <param name="partner">
        /// Required. The [Partner][google.ads.admanager.v1.Partner] to update.
        /// 
        /// The [Partner][google.ads.admanager.v1.Partner]'s `name` is used to identify
        /// the [Partner][google.ads.admanager.v1.Partner] to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Partner UpdatePartner(Partner partner, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePartner(new UpdatePartnerRequest
            {
                Partner = gax::GaxPreconditions.CheckNotNull(partner, nameof(partner)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a [Partner][google.ads.admanager.v1.Partner] object.
        /// </summary>
        /// <param name="partner">
        /// Required. The [Partner][google.ads.admanager.v1.Partner] to update.
        /// 
        /// The [Partner][google.ads.admanager.v1.Partner]'s `name` is used to identify
        /// the [Partner][google.ads.admanager.v1.Partner] to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Partner> UpdatePartnerAsync(Partner partner, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePartnerAsync(new UpdatePartnerRequest
            {
                Partner = gax::GaxPreconditions.CheckNotNull(partner, nameof(partner)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a [Partner][google.ads.admanager.v1.Partner] object.
        /// </summary>
        /// <param name="partner">
        /// Required. The [Partner][google.ads.admanager.v1.Partner] to update.
        /// 
        /// The [Partner][google.ads.admanager.v1.Partner]'s `name` is used to identify
        /// the [Partner][google.ads.admanager.v1.Partner] to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Partner> UpdatePartnerAsync(Partner partner, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdatePartnerAsync(partner, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates [Partner][google.ads.admanager.v1.Partner] objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdatePartnersResponse BatchUpdatePartners(BatchUpdatePartnersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch updates [Partner][google.ads.admanager.v1.Partner] objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdatePartnersResponse> BatchUpdatePartnersAsync(BatchUpdatePartnersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch updates [Partner][google.ads.admanager.v1.Partner] objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdatePartnersResponse> BatchUpdatePartnersAsync(BatchUpdatePartnersRequest request, st::CancellationToken cancellationToken) =>
            BatchUpdatePartnersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates [Partner][google.ads.admanager.v1.Partner] objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where
        /// [Partner][google.ads.admanager.v1.Partner]s will be updated. Format:
        /// `networks/{network_code}` The parent field in the
        /// [UpdatePartnerRequest][google.ads.admanager.v1.UpdatePartnerRequest] must
        /// match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The [Partner][google.ads.admanager.v1.Partner] objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdatePartnersResponse BatchUpdatePartners(string parent, scg::IEnumerable<UpdatePartnerRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdatePartners(new BatchUpdatePartnersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates [Partner][google.ads.admanager.v1.Partner] objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where
        /// [Partner][google.ads.admanager.v1.Partner]s will be updated. Format:
        /// `networks/{network_code}` The parent field in the
        /// [UpdatePartnerRequest][google.ads.admanager.v1.UpdatePartnerRequest] must
        /// match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The [Partner][google.ads.admanager.v1.Partner] objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdatePartnersResponse> BatchUpdatePartnersAsync(string parent, scg::IEnumerable<UpdatePartnerRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdatePartnersAsync(new BatchUpdatePartnersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates [Partner][google.ads.admanager.v1.Partner] objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where
        /// [Partner][google.ads.admanager.v1.Partner]s will be updated. Format:
        /// `networks/{network_code}` The parent field in the
        /// [UpdatePartnerRequest][google.ads.admanager.v1.UpdatePartnerRequest] must
        /// match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The [Partner][google.ads.admanager.v1.Partner] objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdatePartnersResponse> BatchUpdatePartnersAsync(string parent, scg::IEnumerable<UpdatePartnerRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdatePartnersAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates [Partner][google.ads.admanager.v1.Partner] objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where
        /// [Partner][google.ads.admanager.v1.Partner]s will be updated. Format:
        /// `networks/{network_code}` The parent field in the
        /// [UpdatePartnerRequest][google.ads.admanager.v1.UpdatePartnerRequest] must
        /// match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The [Partner][google.ads.admanager.v1.Partner] objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdatePartnersResponse BatchUpdatePartners(NetworkName parent, scg::IEnumerable<UpdatePartnerRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdatePartners(new BatchUpdatePartnersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates [Partner][google.ads.admanager.v1.Partner] objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where
        /// [Partner][google.ads.admanager.v1.Partner]s will be updated. Format:
        /// `networks/{network_code}` The parent field in the
        /// [UpdatePartnerRequest][google.ads.admanager.v1.UpdatePartnerRequest] must
        /// match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The [Partner][google.ads.admanager.v1.Partner] objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdatePartnersResponse> BatchUpdatePartnersAsync(NetworkName parent, scg::IEnumerable<UpdatePartnerRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdatePartnersAsync(new BatchUpdatePartnersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates [Partner][google.ads.admanager.v1.Partner] objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where
        /// [Partner][google.ads.admanager.v1.Partner]s will be updated. Format:
        /// `networks/{network_code}` The parent field in the
        /// [UpdatePartnerRequest][google.ads.admanager.v1.UpdatePartnerRequest] must
        /// match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The [Partner][google.ads.admanager.v1.Partner] objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdatePartnersResponse> BatchUpdatePartnersAsync(NetworkName parent, scg::IEnumerable<UpdatePartnerRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdatePartnersAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>PartnerService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling [Partner][google.ads.admanager.v1.Partner]
    /// objects.
    /// </remarks>
    public sealed partial class PartnerServiceClientImpl : PartnerServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetPartnerRequest, Partner> _callGetPartner;

        private readonly gaxgrpc::ApiCall<ListPartnersRequest, ListPartnersResponse> _callListPartners;

        private readonly gaxgrpc::ApiCall<UpdatePartnerRequest, Partner> _callUpdatePartner;

        private readonly gaxgrpc::ApiCall<BatchUpdatePartnersRequest, BatchUpdatePartnersResponse> _callBatchUpdatePartners;

        /// <summary>
        /// Constructs a client wrapper for the PartnerService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="PartnerServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public PartnerServiceClientImpl(PartnerService.PartnerServiceClient grpcClient, PartnerServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            PartnerServiceSettings effectiveSettings = settings ?? PartnerServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetPartner = clientHelper.BuildApiCall<GetPartnerRequest, Partner>("GetPartner", grpcClient.GetPartnerAsync, grpcClient.GetPartner, effectiveSettings.GetPartnerSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPartner);
            Modify_GetPartnerApiCall(ref _callGetPartner);
            _callListPartners = clientHelper.BuildApiCall<ListPartnersRequest, ListPartnersResponse>("ListPartners", grpcClient.ListPartnersAsync, grpcClient.ListPartners, effectiveSettings.ListPartnersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPartners);
            Modify_ListPartnersApiCall(ref _callListPartners);
            _callUpdatePartner = clientHelper.BuildApiCall<UpdatePartnerRequest, Partner>("UpdatePartner", grpcClient.UpdatePartnerAsync, grpcClient.UpdatePartner, effectiveSettings.UpdatePartnerSettings).WithGoogleRequestParam("partner.name", request => request.Partner?.Name);
            Modify_ApiCall(ref _callUpdatePartner);
            Modify_UpdatePartnerApiCall(ref _callUpdatePartner);
            _callBatchUpdatePartners = clientHelper.BuildApiCall<BatchUpdatePartnersRequest, BatchUpdatePartnersResponse>("BatchUpdatePartners", grpcClient.BatchUpdatePartnersAsync, grpcClient.BatchUpdatePartners, effectiveSettings.BatchUpdatePartnersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchUpdatePartners);
            Modify_BatchUpdatePartnersApiCall(ref _callBatchUpdatePartners);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetPartnerApiCall(ref gaxgrpc::ApiCall<GetPartnerRequest, Partner> call);

        partial void Modify_ListPartnersApiCall(ref gaxgrpc::ApiCall<ListPartnersRequest, ListPartnersResponse> call);

        partial void Modify_UpdatePartnerApiCall(ref gaxgrpc::ApiCall<UpdatePartnerRequest, Partner> call);

        partial void Modify_BatchUpdatePartnersApiCall(ref gaxgrpc::ApiCall<BatchUpdatePartnersRequest, BatchUpdatePartnersResponse> call);

        partial void OnConstruction(PartnerService.PartnerServiceClient grpcClient, PartnerServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC PartnerService client</summary>
        public override PartnerService.PartnerServiceClient GrpcClient { get; }

        partial void Modify_GetPartnerRequest(ref GetPartnerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPartnersRequest(ref ListPartnersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdatePartnerRequest(ref UpdatePartnerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchUpdatePartnersRequest(ref BatchUpdatePartnersRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves a [Partner][google.ads.admanager.v1.Partner] object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Partner GetPartner(GetPartnerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPartnerRequest(ref request, ref callSettings);
            return _callGetPartner.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a [Partner][google.ads.admanager.v1.Partner] object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Partner> GetPartnerAsync(GetPartnerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPartnerRequest(ref request, ref callSettings);
            return _callGetPartner.Async(request, callSettings);
        }

        /// <summary>
        /// Lists [Partner][google.ads.admanager.v1.Partner] objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Partner"/> resources.</returns>
        public override gax::PagedEnumerable<ListPartnersResponse, Partner> ListPartners(ListPartnersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPartnersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPartnersRequest, ListPartnersResponse, Partner>(_callListPartners, request, callSettings);
        }

        /// <summary>
        /// Lists [Partner][google.ads.admanager.v1.Partner] objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Partner"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPartnersResponse, Partner> ListPartnersAsync(ListPartnersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPartnersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPartnersRequest, ListPartnersResponse, Partner>(_callListPartners, request, callSettings);
        }

        /// <summary>
        /// Updates a [Partner][google.ads.admanager.v1.Partner] object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Partner UpdatePartner(UpdatePartnerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePartnerRequest(ref request, ref callSettings);
            return _callUpdatePartner.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a [Partner][google.ads.admanager.v1.Partner] object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Partner> UpdatePartnerAsync(UpdatePartnerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePartnerRequest(ref request, ref callSettings);
            return _callUpdatePartner.Async(request, callSettings);
        }

        /// <summary>
        /// Batch updates [Partner][google.ads.admanager.v1.Partner] objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchUpdatePartnersResponse BatchUpdatePartners(BatchUpdatePartnersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdatePartnersRequest(ref request, ref callSettings);
            return _callBatchUpdatePartners.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch updates [Partner][google.ads.admanager.v1.Partner] objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchUpdatePartnersResponse> BatchUpdatePartnersAsync(BatchUpdatePartnersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdatePartnersRequest(ref request, ref callSettings);
            return _callBatchUpdatePartners.Async(request, callSettings);
        }
    }

    public partial class ListPartnersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPartnersResponse : gaxgrpc::IPageResponse<Partner>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Partner> GetEnumerator() => Partners.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
