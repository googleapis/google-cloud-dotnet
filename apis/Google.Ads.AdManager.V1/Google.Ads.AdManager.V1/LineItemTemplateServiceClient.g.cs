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

namespace Google.Ads.AdManager.V1
{
    /// <summary>Settings for <see cref="LineItemTemplateServiceClient"/> instances.</summary>
    public sealed partial class LineItemTemplateServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="LineItemTemplateServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="LineItemTemplateServiceSettings"/>.</returns>
        public static LineItemTemplateServiceSettings GetDefault() => new LineItemTemplateServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="LineItemTemplateServiceSettings"/> object with default settings.
        /// </summary>
        public LineItemTemplateServiceSettings()
        {
        }

        private LineItemTemplateServiceSettings(LineItemTemplateServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetLineItemTemplateSettings = existing.GetLineItemTemplateSettings;
            ListLineItemTemplatesSettings = existing.ListLineItemTemplatesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(LineItemTemplateServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LineItemTemplateServiceClient.GetLineItemTemplate</c> and
        /// <c>LineItemTemplateServiceClient.GetLineItemTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetLineItemTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LineItemTemplateServiceClient.ListLineItemTemplates</c> and
        /// <c>LineItemTemplateServiceClient.ListLineItemTemplatesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListLineItemTemplatesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="LineItemTemplateServiceSettings"/> object.</returns>
        public LineItemTemplateServiceSettings Clone() => new LineItemTemplateServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="LineItemTemplateServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class LineItemTemplateServiceClientBuilder : gaxgrpc::ClientBuilderBase<LineItemTemplateServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public LineItemTemplateServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public LineItemTemplateServiceClientBuilder() : base(LineItemTemplateServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref LineItemTemplateServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<LineItemTemplateServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override LineItemTemplateServiceClient Build()
        {
            LineItemTemplateServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<LineItemTemplateServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<LineItemTemplateServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private LineItemTemplateServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return LineItemTemplateServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<LineItemTemplateServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return LineItemTemplateServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => LineItemTemplateServiceClient.ChannelPool;
    }

    /// <summary>LineItemTemplateService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `LineItemTemplate` objects.
    /// </remarks>
    public abstract partial class LineItemTemplateServiceClient
    {
        /// <summary>
        /// The default endpoint for the LineItemTemplateService service, which is a host of "admanager.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default LineItemTemplateService scopes.</summary>
        /// <remarks>
        /// The default LineItemTemplateService scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(LineItemTemplateService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="LineItemTemplateServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="LineItemTemplateServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="LineItemTemplateServiceClient"/>.</returns>
        public static stt::Task<LineItemTemplateServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new LineItemTemplateServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="LineItemTemplateServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="LineItemTemplateServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="LineItemTemplateServiceClient"/>.</returns>
        public static LineItemTemplateServiceClient Create() => new LineItemTemplateServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="LineItemTemplateServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="LineItemTemplateServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="LineItemTemplateServiceClient"/>.</returns>
        internal static LineItemTemplateServiceClient Create(grpccore::CallInvoker callInvoker, LineItemTemplateServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            LineItemTemplateService.LineItemTemplateServiceClient grpcClient = new LineItemTemplateService.LineItemTemplateServiceClient(callInvoker);
            return new LineItemTemplateServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC LineItemTemplateService client</summary>
        public virtual LineItemTemplateService.LineItemTemplateServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `LineItemTemplate` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LineItemTemplate GetLineItemTemplate(GetLineItemTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `LineItemTemplate` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineItemTemplate> GetLineItemTemplateAsync(GetLineItemTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `LineItemTemplate` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineItemTemplate> GetLineItemTemplateAsync(GetLineItemTemplateRequest request, st::CancellationToken cancellationToken) =>
            GetLineItemTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `LineItemTemplate` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the LineItemTemplate.
        /// Format:
        /// `networks/{network_code}/lineItemTemplates/{line_item_template_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LineItemTemplate GetLineItemTemplate(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetLineItemTemplate(new GetLineItemTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `LineItemTemplate` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the LineItemTemplate.
        /// Format:
        /// `networks/{network_code}/lineItemTemplates/{line_item_template_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineItemTemplate> GetLineItemTemplateAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetLineItemTemplateAsync(new GetLineItemTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `LineItemTemplate` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the LineItemTemplate.
        /// Format:
        /// `networks/{network_code}/lineItemTemplates/{line_item_template_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineItemTemplate> GetLineItemTemplateAsync(string name, st::CancellationToken cancellationToken) =>
            GetLineItemTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `LineItemTemplate` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the LineItemTemplate.
        /// Format:
        /// `networks/{network_code}/lineItemTemplates/{line_item_template_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LineItemTemplate GetLineItemTemplate(LineItemTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            GetLineItemTemplate(new GetLineItemTemplateRequest
            {
                LineItemTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `LineItemTemplate` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the LineItemTemplate.
        /// Format:
        /// `networks/{network_code}/lineItemTemplates/{line_item_template_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineItemTemplate> GetLineItemTemplateAsync(LineItemTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            GetLineItemTemplateAsync(new GetLineItemTemplateRequest
            {
                LineItemTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `LineItemTemplate` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the LineItemTemplate.
        /// Format:
        /// `networks/{network_code}/lineItemTemplates/{line_item_template_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LineItemTemplate> GetLineItemTemplateAsync(LineItemTemplateName name, st::CancellationToken cancellationToken) =>
            GetLineItemTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists `LineItemTemplate` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LineItemTemplate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLineItemTemplatesResponse, LineItemTemplate> ListLineItemTemplates(ListLineItemTemplatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `LineItemTemplate` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LineItemTemplate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLineItemTemplatesResponse, LineItemTemplate> ListLineItemTemplatesAsync(ListLineItemTemplatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `LineItemTemplate` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of LineItemTemplates.
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
        /// <returns>A pageable sequence of <see cref="LineItemTemplate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLineItemTemplatesResponse, LineItemTemplate> ListLineItemTemplates(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLineItemTemplatesRequest request = new ListLineItemTemplatesRequest
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
            return ListLineItemTemplates(request, callSettings);
        }

        /// <summary>
        /// Lists `LineItemTemplate` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of LineItemTemplates.
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
        /// <returns>A pageable asynchronous sequence of <see cref="LineItemTemplate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLineItemTemplatesResponse, LineItemTemplate> ListLineItemTemplatesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLineItemTemplatesRequest request = new ListLineItemTemplatesRequest
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
            return ListLineItemTemplatesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists `LineItemTemplate` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of LineItemTemplates.
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
        /// <returns>A pageable sequence of <see cref="LineItemTemplate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLineItemTemplatesResponse, LineItemTemplate> ListLineItemTemplates(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLineItemTemplatesRequest request = new ListLineItemTemplatesRequest
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
            return ListLineItemTemplates(request, callSettings);
        }

        /// <summary>
        /// Lists `LineItemTemplate` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of LineItemTemplates.
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
        /// <returns>A pageable asynchronous sequence of <see cref="LineItemTemplate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLineItemTemplatesResponse, LineItemTemplate> ListLineItemTemplatesAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLineItemTemplatesRequest request = new ListLineItemTemplatesRequest
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
            return ListLineItemTemplatesAsync(request, callSettings);
        }
    }

    /// <summary>LineItemTemplateService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `LineItemTemplate` objects.
    /// </remarks>
    public sealed partial class LineItemTemplateServiceClientImpl : LineItemTemplateServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetLineItemTemplateRequest, LineItemTemplate> _callGetLineItemTemplate;

        private readonly gaxgrpc::ApiCall<ListLineItemTemplatesRequest, ListLineItemTemplatesResponse> _callListLineItemTemplates;

        /// <summary>
        /// Constructs a client wrapper for the LineItemTemplateService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="LineItemTemplateServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public LineItemTemplateServiceClientImpl(LineItemTemplateService.LineItemTemplateServiceClient grpcClient, LineItemTemplateServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            LineItemTemplateServiceSettings effectiveSettings = settings ?? LineItemTemplateServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetLineItemTemplate = clientHelper.BuildApiCall<GetLineItemTemplateRequest, LineItemTemplate>("GetLineItemTemplate", grpcClient.GetLineItemTemplateAsync, grpcClient.GetLineItemTemplate, effectiveSettings.GetLineItemTemplateSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetLineItemTemplate);
            Modify_GetLineItemTemplateApiCall(ref _callGetLineItemTemplate);
            _callListLineItemTemplates = clientHelper.BuildApiCall<ListLineItemTemplatesRequest, ListLineItemTemplatesResponse>("ListLineItemTemplates", grpcClient.ListLineItemTemplatesAsync, grpcClient.ListLineItemTemplates, effectiveSettings.ListLineItemTemplatesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListLineItemTemplates);
            Modify_ListLineItemTemplatesApiCall(ref _callListLineItemTemplates);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetLineItemTemplateApiCall(ref gaxgrpc::ApiCall<GetLineItemTemplateRequest, LineItemTemplate> call);

        partial void Modify_ListLineItemTemplatesApiCall(ref gaxgrpc::ApiCall<ListLineItemTemplatesRequest, ListLineItemTemplatesResponse> call);

        partial void OnConstruction(LineItemTemplateService.LineItemTemplateServiceClient grpcClient, LineItemTemplateServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC LineItemTemplateService client</summary>
        public override LineItemTemplateService.LineItemTemplateServiceClient GrpcClient { get; }

        partial void Modify_GetLineItemTemplateRequest(ref GetLineItemTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListLineItemTemplatesRequest(ref ListLineItemTemplatesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves a `LineItemTemplate` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LineItemTemplate GetLineItemTemplate(GetLineItemTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLineItemTemplateRequest(ref request, ref callSettings);
            return _callGetLineItemTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a `LineItemTemplate` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LineItemTemplate> GetLineItemTemplateAsync(GetLineItemTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLineItemTemplateRequest(ref request, ref callSettings);
            return _callGetLineItemTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Lists `LineItemTemplate` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LineItemTemplate"/> resources.</returns>
        public override gax::PagedEnumerable<ListLineItemTemplatesResponse, LineItemTemplate> ListLineItemTemplates(ListLineItemTemplatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLineItemTemplatesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListLineItemTemplatesRequest, ListLineItemTemplatesResponse, LineItemTemplate>(_callListLineItemTemplates, request, callSettings);
        }

        /// <summary>
        /// Lists `LineItemTemplate` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LineItemTemplate"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListLineItemTemplatesResponse, LineItemTemplate> ListLineItemTemplatesAsync(ListLineItemTemplatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLineItemTemplatesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListLineItemTemplatesRequest, ListLineItemTemplatesResponse, LineItemTemplate>(_callListLineItemTemplates, request, callSettings);
        }
    }

    public partial class ListLineItemTemplatesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListLineItemTemplatesResponse : gaxgrpc::IPageResponse<LineItemTemplate>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<LineItemTemplate> GetEnumerator() => LineItemTemplates.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
