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

namespace Google.Cloud.Support.V2Beta
{
    /// <summary>Settings for <see cref="CaseAttachmentServiceClient"/> instances.</summary>
    public sealed partial class CaseAttachmentServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CaseAttachmentServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CaseAttachmentServiceSettings"/>.</returns>
        public static CaseAttachmentServiceSettings GetDefault() => new CaseAttachmentServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CaseAttachmentServiceSettings"/> object with default settings.
        /// </summary>
        public CaseAttachmentServiceSettings()
        {
        }

        private CaseAttachmentServiceSettings(CaseAttachmentServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListAttachmentsSettings = existing.ListAttachmentsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CaseAttachmentServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CaseAttachmentServiceClient.ListAttachments</c> and <c>CaseAttachmentServiceClient.ListAttachmentsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAttachmentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CaseAttachmentServiceSettings"/> object.</returns>
        public CaseAttachmentServiceSettings Clone() => new CaseAttachmentServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CaseAttachmentServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class CaseAttachmentServiceClientBuilder : gaxgrpc::ClientBuilderBase<CaseAttachmentServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CaseAttachmentServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CaseAttachmentServiceClientBuilder() : base(CaseAttachmentServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CaseAttachmentServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CaseAttachmentServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CaseAttachmentServiceClient Build()
        {
            CaseAttachmentServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CaseAttachmentServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CaseAttachmentServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CaseAttachmentServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CaseAttachmentServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CaseAttachmentServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CaseAttachmentServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CaseAttachmentServiceClient.ChannelPool;
    }

    /// <summary>CaseAttachmentService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service to manage file attachments for Google Cloud support cases.
    /// </remarks>
    public abstract partial class CaseAttachmentServiceClient
    {
        /// <summary>
        /// The default endpoint for the CaseAttachmentService service, which is a host of "cloudsupport.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloudsupport.googleapis.com:443";

        /// <summary>The default CaseAttachmentService scopes.</summary>
        /// <remarks>
        /// The default CaseAttachmentService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CaseAttachmentService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CaseAttachmentServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="CaseAttachmentServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CaseAttachmentServiceClient"/>.</returns>
        public static stt::Task<CaseAttachmentServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CaseAttachmentServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CaseAttachmentServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="CaseAttachmentServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CaseAttachmentServiceClient"/>.</returns>
        public static CaseAttachmentServiceClient Create() => new CaseAttachmentServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CaseAttachmentServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CaseAttachmentServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CaseAttachmentServiceClient"/>.</returns>
        internal static CaseAttachmentServiceClient Create(grpccore::CallInvoker callInvoker, CaseAttachmentServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CaseAttachmentService.CaseAttachmentServiceClient grpcClient = new CaseAttachmentService.CaseAttachmentServiceClient(callInvoker);
            return new CaseAttachmentServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CaseAttachmentService client</summary>
        public virtual CaseAttachmentService.CaseAttachmentServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// List all the attachments associated with a support case.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Attachment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAttachmentsResponse, Attachment> ListAttachments(ListAttachmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all the attachments associated with a support case.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Attachment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAttachmentsResponse, Attachment> ListAttachmentsAsync(ListAttachmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all the attachments associated with a support case.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the case for which attachments should be listed.
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
        /// <returns>A pageable sequence of <see cref="Attachment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAttachmentsResponse, Attachment> ListAttachments(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAttachmentsRequest request = new ListAttachmentsRequest
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
            return ListAttachments(request, callSettings);
        }

        /// <summary>
        /// List all the attachments associated with a support case.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the case for which attachments should be listed.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Attachment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAttachmentsResponse, Attachment> ListAttachmentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAttachmentsRequest request = new ListAttachmentsRequest
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
            return ListAttachmentsAsync(request, callSettings);
        }

        /// <summary>
        /// List all the attachments associated with a support case.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the case for which attachments should be listed.
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
        /// <returns>A pageable sequence of <see cref="Attachment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAttachmentsResponse, Attachment> ListAttachments(CaseName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAttachmentsRequest request = new ListAttachmentsRequest
            {
                ParentAsCaseName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAttachments(request, callSettings);
        }

        /// <summary>
        /// List all the attachments associated with a support case.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the case for which attachments should be listed.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Attachment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAttachmentsResponse, Attachment> ListAttachmentsAsync(CaseName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAttachmentsRequest request = new ListAttachmentsRequest
            {
                ParentAsCaseName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAttachmentsAsync(request, callSettings);
        }
    }

    /// <summary>CaseAttachmentService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service to manage file attachments for Google Cloud support cases.
    /// </remarks>
    public sealed partial class CaseAttachmentServiceClientImpl : CaseAttachmentServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListAttachmentsRequest, ListAttachmentsResponse> _callListAttachments;

        /// <summary>
        /// Constructs a client wrapper for the CaseAttachmentService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CaseAttachmentServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CaseAttachmentServiceClientImpl(CaseAttachmentService.CaseAttachmentServiceClient grpcClient, CaseAttachmentServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CaseAttachmentServiceSettings effectiveSettings = settings ?? CaseAttachmentServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callListAttachments = clientHelper.BuildApiCall<ListAttachmentsRequest, ListAttachmentsResponse>("ListAttachments", grpcClient.ListAttachmentsAsync, grpcClient.ListAttachments, effectiveSettings.ListAttachmentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAttachments);
            Modify_ListAttachmentsApiCall(ref _callListAttachments);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListAttachmentsApiCall(ref gaxgrpc::ApiCall<ListAttachmentsRequest, ListAttachmentsResponse> call);

        partial void OnConstruction(CaseAttachmentService.CaseAttachmentServiceClient grpcClient, CaseAttachmentServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CaseAttachmentService client</summary>
        public override CaseAttachmentService.CaseAttachmentServiceClient GrpcClient { get; }

        partial void Modify_ListAttachmentsRequest(ref ListAttachmentsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// List all the attachments associated with a support case.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Attachment"/> resources.</returns>
        public override gax::PagedEnumerable<ListAttachmentsResponse, Attachment> ListAttachments(ListAttachmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAttachmentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAttachmentsRequest, ListAttachmentsResponse, Attachment>(_callListAttachments, request, callSettings);
        }

        /// <summary>
        /// List all the attachments associated with a support case.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Attachment"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAttachmentsResponse, Attachment> ListAttachmentsAsync(ListAttachmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAttachmentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAttachmentsRequest, ListAttachmentsResponse, Attachment>(_callListAttachments, request, callSettings);
        }
    }

    public partial class ListAttachmentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAttachmentsResponse : gaxgrpc::IPageResponse<Attachment>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Attachment> GetEnumerator() => Attachments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
