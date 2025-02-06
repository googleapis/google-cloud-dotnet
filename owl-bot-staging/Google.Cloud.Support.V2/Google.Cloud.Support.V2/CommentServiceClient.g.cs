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

namespace Google.Cloud.Support.V2
{
    /// <summary>Settings for <see cref="CommentServiceClient"/> instances.</summary>
    public sealed partial class CommentServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CommentServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CommentServiceSettings"/>.</returns>
        public static CommentServiceSettings GetDefault() => new CommentServiceSettings();

        /// <summary>Constructs a new <see cref="CommentServiceSettings"/> object with default settings.</summary>
        public CommentServiceSettings()
        {
        }

        private CommentServiceSettings(CommentServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListCommentsSettings = existing.ListCommentsSettings;
            CreateCommentSettings = existing.CreateCommentSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CommentServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CommentServiceClient.ListComments</c> and <c>CommentServiceClient.ListCommentsAsync</c>.
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
        public gaxgrpc::CallSettings ListCommentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CommentServiceClient.CreateComment</c> and <c>CommentServiceClient.CreateCommentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateCommentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CommentServiceSettings"/> object.</returns>
        public CommentServiceSettings Clone() => new CommentServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CommentServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class CommentServiceClientBuilder : gaxgrpc::ClientBuilderBase<CommentServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CommentServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CommentServiceClientBuilder() : base(CommentServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CommentServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CommentServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CommentServiceClient Build()
        {
            CommentServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CommentServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CommentServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CommentServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CommentServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CommentServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CommentServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CommentServiceClient.ChannelPool;
    }

    /// <summary>CommentService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service to manage comments on cases.
    /// </remarks>
    public abstract partial class CommentServiceClient
    {
        /// <summary>
        /// The default endpoint for the CommentService service, which is a host of "cloudsupport.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloudsupport.googleapis.com:443";

        /// <summary>The default CommentService scopes.</summary>
        /// <remarks>
        /// The default CommentService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CommentService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CommentServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CommentServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CommentServiceClient"/>.</returns>
        public static stt::Task<CommentServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CommentServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CommentServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CommentServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CommentServiceClient"/>.</returns>
        public static CommentServiceClient Create() => new CommentServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CommentServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CommentServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CommentServiceClient"/>.</returns>
        internal static CommentServiceClient Create(grpccore::CallInvoker callInvoker, CommentServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CommentService.CommentServiceClient grpcClient = new CommentService.CommentServiceClient(callInvoker);
            return new CommentServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CommentService client</summary>
        public virtual CommentService.CommentServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve all Comments associated with the Case object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Comment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCommentsResponse, Comment> ListComments(ListCommentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve all Comments associated with the Case object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Comment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCommentsResponse, Comment> ListCommentsAsync(ListCommentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve all Comments associated with the Case object.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of Case object for which comments should be
        /// listed.
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
        /// <returns>A pageable sequence of <see cref="Comment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCommentsResponse, Comment> ListComments(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCommentsRequest request = new ListCommentsRequest
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
            return ListComments(request, callSettings);
        }

        /// <summary>
        /// Retrieve all Comments associated with the Case object.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of Case object for which comments should be
        /// listed.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Comment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCommentsResponse, Comment> ListCommentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCommentsRequest request = new ListCommentsRequest
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
            return ListCommentsAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieve all Comments associated with the Case object.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of Case object for which comments should be
        /// listed.
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
        /// <returns>A pageable sequence of <see cref="Comment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCommentsResponse, Comment> ListComments(CaseName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCommentsRequest request = new ListCommentsRequest
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
            return ListComments(request, callSettings);
        }

        /// <summary>
        /// Retrieve all Comments associated with the Case object.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of Case object for which comments should be
        /// listed.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Comment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCommentsResponse, Comment> ListCommentsAsync(CaseName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCommentsRequest request = new ListCommentsRequest
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
            return ListCommentsAsync(request, callSettings);
        }

        /// <summary>
        /// Add a new comment to the specified Case.
        /// The comment object must have the following fields set: body.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Comment CreateComment(CreateCommentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Add a new comment to the specified Case.
        /// The comment object must have the following fields set: body.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Comment> CreateCommentAsync(CreateCommentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Add a new comment to the specified Case.
        /// The comment object must have the following fields set: body.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Comment> CreateCommentAsync(CreateCommentRequest request, st::CancellationToken cancellationToken) =>
            CreateCommentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Add a new comment to the specified Case.
        /// The comment object must have the following fields set: body.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of Case to which this comment should be added.
        /// </param>
        /// <param name="comment">
        /// Required. The Comment object to be added to this Case.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Comment CreateComment(string parent, Comment comment, gaxgrpc::CallSettings callSettings = null) =>
            CreateComment(new CreateCommentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Comment = gax::GaxPreconditions.CheckNotNull(comment, nameof(comment)),
            }, callSettings);

        /// <summary>
        /// Add a new comment to the specified Case.
        /// The comment object must have the following fields set: body.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of Case to which this comment should be added.
        /// </param>
        /// <param name="comment">
        /// Required. The Comment object to be added to this Case.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Comment> CreateCommentAsync(string parent, Comment comment, gaxgrpc::CallSettings callSettings = null) =>
            CreateCommentAsync(new CreateCommentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Comment = gax::GaxPreconditions.CheckNotNull(comment, nameof(comment)),
            }, callSettings);

        /// <summary>
        /// Add a new comment to the specified Case.
        /// The comment object must have the following fields set: body.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of Case to which this comment should be added.
        /// </param>
        /// <param name="comment">
        /// Required. The Comment object to be added to this Case.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Comment> CreateCommentAsync(string parent, Comment comment, st::CancellationToken cancellationToken) =>
            CreateCommentAsync(parent, comment, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Add a new comment to the specified Case.
        /// The comment object must have the following fields set: body.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of Case to which this comment should be added.
        /// </param>
        /// <param name="comment">
        /// Required. The Comment object to be added to this Case.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Comment CreateComment(CaseName parent, Comment comment, gaxgrpc::CallSettings callSettings = null) =>
            CreateComment(new CreateCommentRequest
            {
                ParentAsCaseName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Comment = gax::GaxPreconditions.CheckNotNull(comment, nameof(comment)),
            }, callSettings);

        /// <summary>
        /// Add a new comment to the specified Case.
        /// The comment object must have the following fields set: body.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of Case to which this comment should be added.
        /// </param>
        /// <param name="comment">
        /// Required. The Comment object to be added to this Case.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Comment> CreateCommentAsync(CaseName parent, Comment comment, gaxgrpc::CallSettings callSettings = null) =>
            CreateCommentAsync(new CreateCommentRequest
            {
                ParentAsCaseName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Comment = gax::GaxPreconditions.CheckNotNull(comment, nameof(comment)),
            }, callSettings);

        /// <summary>
        /// Add a new comment to the specified Case.
        /// The comment object must have the following fields set: body.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of Case to which this comment should be added.
        /// </param>
        /// <param name="comment">
        /// Required. The Comment object to be added to this Case.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Comment> CreateCommentAsync(CaseName parent, Comment comment, st::CancellationToken cancellationToken) =>
            CreateCommentAsync(parent, comment, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CommentService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service to manage comments on cases.
    /// </remarks>
    public sealed partial class CommentServiceClientImpl : CommentServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListCommentsRequest, ListCommentsResponse> _callListComments;

        private readonly gaxgrpc::ApiCall<CreateCommentRequest, Comment> _callCreateComment;

        /// <summary>
        /// Constructs a client wrapper for the CommentService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CommentServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CommentServiceClientImpl(CommentService.CommentServiceClient grpcClient, CommentServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CommentServiceSettings effectiveSettings = settings ?? CommentServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callListComments = clientHelper.BuildApiCall<ListCommentsRequest, ListCommentsResponse>("ListComments", grpcClient.ListCommentsAsync, grpcClient.ListComments, effectiveSettings.ListCommentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListComments);
            Modify_ListCommentsApiCall(ref _callListComments);
            _callCreateComment = clientHelper.BuildApiCall<CreateCommentRequest, Comment>("CreateComment", grpcClient.CreateCommentAsync, grpcClient.CreateComment, effectiveSettings.CreateCommentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateComment);
            Modify_CreateCommentApiCall(ref _callCreateComment);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListCommentsApiCall(ref gaxgrpc::ApiCall<ListCommentsRequest, ListCommentsResponse> call);

        partial void Modify_CreateCommentApiCall(ref gaxgrpc::ApiCall<CreateCommentRequest, Comment> call);

        partial void OnConstruction(CommentService.CommentServiceClient grpcClient, CommentServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CommentService client</summary>
        public override CommentService.CommentServiceClient GrpcClient { get; }

        partial void Modify_ListCommentsRequest(ref ListCommentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateCommentRequest(ref CreateCommentRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieve all Comments associated with the Case object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Comment"/> resources.</returns>
        public override gax::PagedEnumerable<ListCommentsResponse, Comment> ListComments(ListCommentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCommentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCommentsRequest, ListCommentsResponse, Comment>(_callListComments, request, callSettings);
        }

        /// <summary>
        /// Retrieve all Comments associated with the Case object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Comment"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCommentsResponse, Comment> ListCommentsAsync(ListCommentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCommentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCommentsRequest, ListCommentsResponse, Comment>(_callListComments, request, callSettings);
        }

        /// <summary>
        /// Add a new comment to the specified Case.
        /// The comment object must have the following fields set: body.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Comment CreateComment(CreateCommentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCommentRequest(ref request, ref callSettings);
            return _callCreateComment.Sync(request, callSettings);
        }

        /// <summary>
        /// Add a new comment to the specified Case.
        /// The comment object must have the following fields set: body.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Comment> CreateCommentAsync(CreateCommentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCommentRequest(ref request, ref callSettings);
            return _callCreateComment.Async(request, callSettings);
        }
    }

    public partial class ListCommentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCommentsResponse : gaxgrpc::IPageResponse<Comment>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Comment> GetEnumerator() => Comments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
