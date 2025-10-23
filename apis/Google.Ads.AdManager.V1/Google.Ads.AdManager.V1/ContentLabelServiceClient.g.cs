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
    /// <summary>Settings for <see cref="ContentLabelServiceClient"/> instances.</summary>
    public sealed partial class ContentLabelServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ContentLabelServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ContentLabelServiceSettings"/>.</returns>
        public static ContentLabelServiceSettings GetDefault() => new ContentLabelServiceSettings();

        /// <summary>Constructs a new <see cref="ContentLabelServiceSettings"/> object with default settings.</summary>
        public ContentLabelServiceSettings()
        {
        }

        private ContentLabelServiceSettings(ContentLabelServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetContentLabelSettings = existing.GetContentLabelSettings;
            ListContentLabelsSettings = existing.ListContentLabelsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ContentLabelServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContentLabelServiceClient.GetContentLabel</c> and <c>ContentLabelServiceClient.GetContentLabelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetContentLabelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContentLabelServiceClient.ListContentLabels</c> and <c>ContentLabelServiceClient.ListContentLabelsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListContentLabelsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ContentLabelServiceSettings"/> object.</returns>
        public ContentLabelServiceSettings Clone() => new ContentLabelServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ContentLabelServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class ContentLabelServiceClientBuilder : gaxgrpc::ClientBuilderBase<ContentLabelServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ContentLabelServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ContentLabelServiceClientBuilder() : base(ContentLabelServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ContentLabelServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ContentLabelServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ContentLabelServiceClient Build()
        {
            ContentLabelServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ContentLabelServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ContentLabelServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ContentLabelServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ContentLabelServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ContentLabelServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ContentLabelServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ContentLabelServiceClient.ChannelPool;
    }

    /// <summary>ContentLabelService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `ContentLabel` objects.
    /// </remarks>
    public abstract partial class ContentLabelServiceClient
    {
        /// <summary>
        /// The default endpoint for the ContentLabelService service, which is a host of "admanager.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default ContentLabelService scopes.</summary>
        /// <remarks>
        /// The default ContentLabelService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/admanager</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/admanager",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ContentLabelService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ContentLabelServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="ContentLabelServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ContentLabelServiceClient"/>.</returns>
        public static stt::Task<ContentLabelServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ContentLabelServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ContentLabelServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="ContentLabelServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ContentLabelServiceClient"/>.</returns>
        public static ContentLabelServiceClient Create() => new ContentLabelServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ContentLabelServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ContentLabelServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ContentLabelServiceClient"/>.</returns>
        internal static ContentLabelServiceClient Create(grpccore::CallInvoker callInvoker, ContentLabelServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ContentLabelService.ContentLabelServiceClient grpcClient = new ContentLabelService.ContentLabelServiceClient(callInvoker);
            return new ContentLabelServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ContentLabelService client</summary>
        public virtual ContentLabelService.ContentLabelServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `ContentLabel` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ContentLabel GetContentLabel(GetContentLabelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `ContentLabel` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ContentLabel> GetContentLabelAsync(GetContentLabelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `ContentLabel` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ContentLabel> GetContentLabelAsync(GetContentLabelRequest request, st::CancellationToken cancellationToken) =>
            GetContentLabelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `ContentLabel` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ContentLabel.
        /// Format: `networks/{network_code}/contentLabels/{content_label_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ContentLabel GetContentLabel(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetContentLabel(new GetContentLabelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `ContentLabel` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ContentLabel.
        /// Format: `networks/{network_code}/contentLabels/{content_label_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ContentLabel> GetContentLabelAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetContentLabelAsync(new GetContentLabelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `ContentLabel` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ContentLabel.
        /// Format: `networks/{network_code}/contentLabels/{content_label_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ContentLabel> GetContentLabelAsync(string name, st::CancellationToken cancellationToken) =>
            GetContentLabelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `ContentLabel` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ContentLabel.
        /// Format: `networks/{network_code}/contentLabels/{content_label_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ContentLabel GetContentLabel(ContentLabelName name, gaxgrpc::CallSettings callSettings = null) =>
            GetContentLabel(new GetContentLabelRequest
            {
                ContentLabelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `ContentLabel` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ContentLabel.
        /// Format: `networks/{network_code}/contentLabels/{content_label_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ContentLabel> GetContentLabelAsync(ContentLabelName name, gaxgrpc::CallSettings callSettings = null) =>
            GetContentLabelAsync(new GetContentLabelRequest
            {
                ContentLabelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `ContentLabel` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ContentLabel.
        /// Format: `networks/{network_code}/contentLabels/{content_label_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ContentLabel> GetContentLabelAsync(ContentLabelName name, st::CancellationToken cancellationToken) =>
            GetContentLabelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a list of `ContentLabel` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ContentLabel"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListContentLabelsResponse, ContentLabel> ListContentLabels(ListContentLabelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `ContentLabel` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ContentLabel"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListContentLabelsResponse, ContentLabel> ListContentLabelsAsync(ListContentLabelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `ContentLabel` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of ContentLabels.
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
        /// <returns>A pageable sequence of <see cref="ContentLabel"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListContentLabelsResponse, ContentLabel> ListContentLabels(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListContentLabelsRequest request = new ListContentLabelsRequest
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
            return ListContentLabels(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `ContentLabel` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of ContentLabels.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ContentLabel"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListContentLabelsResponse, ContentLabel> ListContentLabelsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListContentLabelsRequest request = new ListContentLabelsRequest
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
            return ListContentLabelsAsync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `ContentLabel` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of ContentLabels.
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
        /// <returns>A pageable sequence of <see cref="ContentLabel"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListContentLabelsResponse, ContentLabel> ListContentLabels(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListContentLabelsRequest request = new ListContentLabelsRequest
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
            return ListContentLabels(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `ContentLabel` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of ContentLabels.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ContentLabel"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListContentLabelsResponse, ContentLabel> ListContentLabelsAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListContentLabelsRequest request = new ListContentLabelsRequest
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
            return ListContentLabelsAsync(request, callSettings);
        }
    }

    /// <summary>ContentLabelService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `ContentLabel` objects.
    /// </remarks>
    public sealed partial class ContentLabelServiceClientImpl : ContentLabelServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetContentLabelRequest, ContentLabel> _callGetContentLabel;

        private readonly gaxgrpc::ApiCall<ListContentLabelsRequest, ListContentLabelsResponse> _callListContentLabels;

        /// <summary>
        /// Constructs a client wrapper for the ContentLabelService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ContentLabelServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ContentLabelServiceClientImpl(ContentLabelService.ContentLabelServiceClient grpcClient, ContentLabelServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ContentLabelServiceSettings effectiveSettings = settings ?? ContentLabelServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetContentLabel = clientHelper.BuildApiCall<GetContentLabelRequest, ContentLabel>("GetContentLabel", grpcClient.GetContentLabelAsync, grpcClient.GetContentLabel, effectiveSettings.GetContentLabelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetContentLabel);
            Modify_GetContentLabelApiCall(ref _callGetContentLabel);
            _callListContentLabels = clientHelper.BuildApiCall<ListContentLabelsRequest, ListContentLabelsResponse>("ListContentLabels", grpcClient.ListContentLabelsAsync, grpcClient.ListContentLabels, effectiveSettings.ListContentLabelsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListContentLabels);
            Modify_ListContentLabelsApiCall(ref _callListContentLabels);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetContentLabelApiCall(ref gaxgrpc::ApiCall<GetContentLabelRequest, ContentLabel> call);

        partial void Modify_ListContentLabelsApiCall(ref gaxgrpc::ApiCall<ListContentLabelsRequest, ListContentLabelsResponse> call);

        partial void OnConstruction(ContentLabelService.ContentLabelServiceClient grpcClient, ContentLabelServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ContentLabelService client</summary>
        public override ContentLabelService.ContentLabelServiceClient GrpcClient { get; }

        partial void Modify_GetContentLabelRequest(ref GetContentLabelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListContentLabelsRequest(ref ListContentLabelsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// API to retrieve a `ContentLabel` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ContentLabel GetContentLabel(GetContentLabelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetContentLabelRequest(ref request, ref callSettings);
            return _callGetContentLabel.Sync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a `ContentLabel` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ContentLabel> GetContentLabelAsync(GetContentLabelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetContentLabelRequest(ref request, ref callSettings);
            return _callGetContentLabel.Async(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `ContentLabel` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ContentLabel"/> resources.</returns>
        public override gax::PagedEnumerable<ListContentLabelsResponse, ContentLabel> ListContentLabels(ListContentLabelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListContentLabelsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListContentLabelsRequest, ListContentLabelsResponse, ContentLabel>(_callListContentLabels, request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `ContentLabel` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ContentLabel"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListContentLabelsResponse, ContentLabel> ListContentLabelsAsync(ListContentLabelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListContentLabelsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListContentLabelsRequest, ListContentLabelsResponse, ContentLabel>(_callListContentLabels, request, callSettings);
        }
    }

    public partial class ListContentLabelsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListContentLabelsResponse : gaxgrpc::IPageResponse<ContentLabel>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ContentLabel> GetEnumerator() => ContentLabels.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
