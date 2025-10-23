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

namespace Google.Ads.AdManager.V1
{
    /// <summary>Settings for <see cref="AudienceSegmentServiceClient"/> instances.</summary>
    public sealed partial class AudienceSegmentServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AudienceSegmentServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AudienceSegmentServiceSettings"/>.</returns>
        public static AudienceSegmentServiceSettings GetDefault() => new AudienceSegmentServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="AudienceSegmentServiceSettings"/> object with default settings.
        /// </summary>
        public AudienceSegmentServiceSettings()
        {
        }

        private AudienceSegmentServiceSettings(AudienceSegmentServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetAudienceSegmentSettings = existing.GetAudienceSegmentSettings;
            ListAudienceSegmentsSettings = existing.ListAudienceSegmentsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AudienceSegmentServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AudienceSegmentServiceClient.GetAudienceSegment</c> and
        /// <c>AudienceSegmentServiceClient.GetAudienceSegmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAudienceSegmentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AudienceSegmentServiceClient.ListAudienceSegments</c> and
        /// <c>AudienceSegmentServiceClient.ListAudienceSegmentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAudienceSegmentsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AudienceSegmentServiceSettings"/> object.</returns>
        public AudienceSegmentServiceSettings Clone() => new AudienceSegmentServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AudienceSegmentServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class AudienceSegmentServiceClientBuilder : gaxgrpc::ClientBuilderBase<AudienceSegmentServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AudienceSegmentServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AudienceSegmentServiceClientBuilder() : base(AudienceSegmentServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AudienceSegmentServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AudienceSegmentServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AudienceSegmentServiceClient Build()
        {
            AudienceSegmentServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AudienceSegmentServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AudienceSegmentServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AudienceSegmentServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AudienceSegmentServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AudienceSegmentServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AudienceSegmentServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AudienceSegmentServiceClient.ChannelPool;
    }

    /// <summary>AudienceSegmentService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `AudienceSegment` objects.
    /// </remarks>
    public abstract partial class AudienceSegmentServiceClient
    {
        /// <summary>
        /// The default endpoint for the AudienceSegmentService service, which is a host of "admanager.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default AudienceSegmentService scopes.</summary>
        /// <remarks>
        /// The default AudienceSegmentService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/admanager</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/admanager",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AudienceSegmentService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AudienceSegmentServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="AudienceSegmentServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AudienceSegmentServiceClient"/>.</returns>
        public static stt::Task<AudienceSegmentServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AudienceSegmentServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AudienceSegmentServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="AudienceSegmentServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AudienceSegmentServiceClient"/>.</returns>
        public static AudienceSegmentServiceClient Create() => new AudienceSegmentServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AudienceSegmentServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AudienceSegmentServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AudienceSegmentServiceClient"/>.</returns>
        internal static AudienceSegmentServiceClient Create(grpccore::CallInvoker callInvoker, AudienceSegmentServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AudienceSegmentService.AudienceSegmentServiceClient grpcClient = new AudienceSegmentService.AudienceSegmentServiceClient(callInvoker);
            return new AudienceSegmentServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AudienceSegmentService client</summary>
        public virtual AudienceSegmentService.AudienceSegmentServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve an `AudienceSegment` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AudienceSegment GetAudienceSegment(GetAudienceSegmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve an `AudienceSegment` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AudienceSegment> GetAudienceSegmentAsync(GetAudienceSegmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve an `AudienceSegment` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AudienceSegment> GetAudienceSegmentAsync(GetAudienceSegmentRequest request, st::CancellationToken cancellationToken) =>
            GetAudienceSegmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve an `AudienceSegment` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the AudienceSegment.
        /// Format: `networks/{network_code}/audienceSegments/{audience_segment_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AudienceSegment GetAudienceSegment(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAudienceSegment(new GetAudienceSegmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve an `AudienceSegment` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the AudienceSegment.
        /// Format: `networks/{network_code}/audienceSegments/{audience_segment_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AudienceSegment> GetAudienceSegmentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAudienceSegmentAsync(new GetAudienceSegmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve an `AudienceSegment` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the AudienceSegment.
        /// Format: `networks/{network_code}/audienceSegments/{audience_segment_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AudienceSegment> GetAudienceSegmentAsync(string name, st::CancellationToken cancellationToken) =>
            GetAudienceSegmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve an `AudienceSegment` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the AudienceSegment.
        /// Format: `networks/{network_code}/audienceSegments/{audience_segment_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AudienceSegment GetAudienceSegment(AudienceSegmentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAudienceSegment(new GetAudienceSegmentRequest
            {
                AudienceSegmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve an `AudienceSegment` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the AudienceSegment.
        /// Format: `networks/{network_code}/audienceSegments/{audience_segment_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AudienceSegment> GetAudienceSegmentAsync(AudienceSegmentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAudienceSegmentAsync(new GetAudienceSegmentRequest
            {
                AudienceSegmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve an `AudienceSegment` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the AudienceSegment.
        /// Format: `networks/{network_code}/audienceSegments/{audience_segment_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AudienceSegment> GetAudienceSegmentAsync(AudienceSegmentName name, st::CancellationToken cancellationToken) =>
            GetAudienceSegmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a list of `AudienceSegment` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AudienceSegment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAudienceSegmentsResponse, AudienceSegment> ListAudienceSegments(ListAudienceSegmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `AudienceSegment` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AudienceSegment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAudienceSegmentsResponse, AudienceSegment> ListAudienceSegmentsAsync(ListAudienceSegmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `AudienceSegment` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent publisher network associated with these audience
        /// segments. Format: `networks/{network_code}`
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
        /// <returns>A pageable sequence of <see cref="AudienceSegment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAudienceSegmentsResponse, AudienceSegment> ListAudienceSegments(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAudienceSegmentsRequest request = new ListAudienceSegmentsRequest
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
            return ListAudienceSegments(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `AudienceSegment` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent publisher network associated with these audience
        /// segments. Format: `networks/{network_code}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="AudienceSegment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAudienceSegmentsResponse, AudienceSegment> ListAudienceSegmentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAudienceSegmentsRequest request = new ListAudienceSegmentsRequest
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
            return ListAudienceSegmentsAsync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `AudienceSegment` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent publisher network associated with these audience
        /// segments. Format: `networks/{network_code}`
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
        /// <returns>A pageable sequence of <see cref="AudienceSegment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAudienceSegmentsResponse, AudienceSegment> ListAudienceSegments(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAudienceSegmentsRequest request = new ListAudienceSegmentsRequest
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
            return ListAudienceSegments(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `AudienceSegment` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent publisher network associated with these audience
        /// segments. Format: `networks/{network_code}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="AudienceSegment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAudienceSegmentsResponse, AudienceSegment> ListAudienceSegmentsAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAudienceSegmentsRequest request = new ListAudienceSegmentsRequest
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
            return ListAudienceSegmentsAsync(request, callSettings);
        }
    }

    /// <summary>AudienceSegmentService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `AudienceSegment` objects.
    /// </remarks>
    public sealed partial class AudienceSegmentServiceClientImpl : AudienceSegmentServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetAudienceSegmentRequest, AudienceSegment> _callGetAudienceSegment;

        private readonly gaxgrpc::ApiCall<ListAudienceSegmentsRequest, ListAudienceSegmentsResponse> _callListAudienceSegments;

        /// <summary>
        /// Constructs a client wrapper for the AudienceSegmentService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="AudienceSegmentServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AudienceSegmentServiceClientImpl(AudienceSegmentService.AudienceSegmentServiceClient grpcClient, AudienceSegmentServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AudienceSegmentServiceSettings effectiveSettings = settings ?? AudienceSegmentServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetAudienceSegment = clientHelper.BuildApiCall<GetAudienceSegmentRequest, AudienceSegment>("GetAudienceSegment", grpcClient.GetAudienceSegmentAsync, grpcClient.GetAudienceSegment, effectiveSettings.GetAudienceSegmentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAudienceSegment);
            Modify_GetAudienceSegmentApiCall(ref _callGetAudienceSegment);
            _callListAudienceSegments = clientHelper.BuildApiCall<ListAudienceSegmentsRequest, ListAudienceSegmentsResponse>("ListAudienceSegments", grpcClient.ListAudienceSegmentsAsync, grpcClient.ListAudienceSegments, effectiveSettings.ListAudienceSegmentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAudienceSegments);
            Modify_ListAudienceSegmentsApiCall(ref _callListAudienceSegments);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetAudienceSegmentApiCall(ref gaxgrpc::ApiCall<GetAudienceSegmentRequest, AudienceSegment> call);

        partial void Modify_ListAudienceSegmentsApiCall(ref gaxgrpc::ApiCall<ListAudienceSegmentsRequest, ListAudienceSegmentsResponse> call);

        partial void OnConstruction(AudienceSegmentService.AudienceSegmentServiceClient grpcClient, AudienceSegmentServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AudienceSegmentService client</summary>
        public override AudienceSegmentService.AudienceSegmentServiceClient GrpcClient { get; }

        partial void Modify_GetAudienceSegmentRequest(ref GetAudienceSegmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAudienceSegmentsRequest(ref ListAudienceSegmentsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// API to retrieve an `AudienceSegment` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AudienceSegment GetAudienceSegment(GetAudienceSegmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAudienceSegmentRequest(ref request, ref callSettings);
            return _callGetAudienceSegment.Sync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve an `AudienceSegment` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AudienceSegment> GetAudienceSegmentAsync(GetAudienceSegmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAudienceSegmentRequest(ref request, ref callSettings);
            return _callGetAudienceSegment.Async(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `AudienceSegment` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AudienceSegment"/> resources.</returns>
        public override gax::PagedEnumerable<ListAudienceSegmentsResponse, AudienceSegment> ListAudienceSegments(ListAudienceSegmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAudienceSegmentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAudienceSegmentsRequest, ListAudienceSegmentsResponse, AudienceSegment>(_callListAudienceSegments, request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `AudienceSegment` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AudienceSegment"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAudienceSegmentsResponse, AudienceSegment> ListAudienceSegmentsAsync(ListAudienceSegmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAudienceSegmentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAudienceSegmentsRequest, ListAudienceSegmentsResponse, AudienceSegment>(_callListAudienceSegments, request, callSettings);
        }
    }

    public partial class ListAudienceSegmentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAudienceSegmentsResponse : gaxgrpc::IPageResponse<AudienceSegment>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AudienceSegment> GetEnumerator() => AudienceSegments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
