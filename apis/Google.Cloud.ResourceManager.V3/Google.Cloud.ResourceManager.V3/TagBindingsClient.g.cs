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

namespace Google.Cloud.ResourceManager.V3
{
    /// <summary>Settings for <see cref="TagBindingsClient"/> instances.</summary>
    public sealed partial class TagBindingsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="TagBindingsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="TagBindingsSettings"/>.</returns>
        public static TagBindingsSettings GetDefault() => new TagBindingsSettings();

        /// <summary>Constructs a new <see cref="TagBindingsSettings"/> object with default settings.</summary>
        public TagBindingsSettings()
        {
        }

        private TagBindingsSettings(TagBindingsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListTagBindingsSettings = existing.ListTagBindingsSettings;
            CreateTagBindingSettings = existing.CreateTagBindingSettings;
            CreateTagBindingOperationsSettings = existing.CreateTagBindingOperationsSettings.Clone();
            DeleteTagBindingSettings = existing.DeleteTagBindingSettings;
            DeleteTagBindingOperationsSettings = existing.DeleteTagBindingOperationsSettings.Clone();
            ListEffectiveTagsSettings = existing.ListEffectiveTagsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(TagBindingsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TagBindingsClient.ListTagBindings</c> and <c>TagBindingsClient.ListTagBindingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTagBindingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TagBindingsClient.CreateTagBinding</c> and <c>TagBindingsClient.CreateTagBindingAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateTagBindingSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>TagBindingsClient.CreateTagBinding</c> and
        /// <c>TagBindingsClient.CreateTagBindingAsync</c>.
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
        public lro::OperationsSettings CreateTagBindingOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TagBindingsClient.DeleteTagBinding</c> and <c>TagBindingsClient.DeleteTagBindingAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteTagBindingSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>TagBindingsClient.DeleteTagBinding</c> and
        /// <c>TagBindingsClient.DeleteTagBindingAsync</c>.
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
        public lro::OperationsSettings DeleteTagBindingOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TagBindingsClient.ListEffectiveTags</c> and <c>TagBindingsClient.ListEffectiveTagsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListEffectiveTagsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="TagBindingsSettings"/> object.</returns>
        public TagBindingsSettings Clone() => new TagBindingsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="TagBindingsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class TagBindingsClientBuilder : gaxgrpc::ClientBuilderBase<TagBindingsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public TagBindingsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public TagBindingsClientBuilder() : base(TagBindingsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref TagBindingsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<TagBindingsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override TagBindingsClient Build()
        {
            TagBindingsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<TagBindingsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<TagBindingsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private TagBindingsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return TagBindingsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<TagBindingsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return TagBindingsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => TagBindingsClient.ChannelPool;
    }

    /// <summary>TagBindings client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Allow users to create and manage TagBindings between TagValues and
    /// different Google Cloud resources throughout the GCP resource hierarchy.
    /// </remarks>
    public abstract partial class TagBindingsClient
    {
        /// <summary>
        /// The default endpoint for the TagBindings service, which is a host of "cloudresourcemanager.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloudresourcemanager.googleapis.com:443";

        /// <summary>The default TagBindings scopes.</summary>
        /// <remarks>
        /// The default TagBindings scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform.read-only</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud-platform.read-only",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(TagBindings.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="TagBindingsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="TagBindingsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="TagBindingsClient"/>.</returns>
        public static stt::Task<TagBindingsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new TagBindingsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="TagBindingsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="TagBindingsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="TagBindingsClient"/>.</returns>
        public static TagBindingsClient Create() => new TagBindingsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="TagBindingsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="TagBindingsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="TagBindingsClient"/>.</returns>
        internal static TagBindingsClient Create(grpccore::CallInvoker callInvoker, TagBindingsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            TagBindings.TagBindingsClient grpcClient = new TagBindings.TagBindingsClient(callInvoker);
            return new TagBindingsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC TagBindings client</summary>
        public virtual TagBindings.TagBindingsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the TagBindings for the given Google Cloud resource, as specified
        /// with `parent`.
        /// 
        /// NOTE: The `parent` field is expected to be a full resource name:
        /// https://cloud.google.com/apis/design/resource_names#full_resource_name
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TagBinding"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTagBindingsResponse, TagBinding> ListTagBindings(ListTagBindingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the TagBindings for the given Google Cloud resource, as specified
        /// with `parent`.
        /// 
        /// NOTE: The `parent` field is expected to be a full resource name:
        /// https://cloud.google.com/apis/design/resource_names#full_resource_name
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TagBinding"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTagBindingsResponse, TagBinding> ListTagBindingsAsync(ListTagBindingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the TagBindings for the given Google Cloud resource, as specified
        /// with `parent`.
        /// 
        /// NOTE: The `parent` field is expected to be a full resource name:
        /// https://cloud.google.com/apis/design/resource_names#full_resource_name
        /// </summary>
        /// <param name="parent">
        /// Required. The full resource name of a resource for which you want to list
        /// existing TagBindings. E.g.
        /// "//cloudresourcemanager.googleapis.com/projects/123"
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
        /// <returns>A pageable sequence of <see cref="TagBinding"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTagBindingsResponse, TagBinding> ListTagBindings(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTagBindingsRequest request = new ListTagBindingsRequest
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
            return ListTagBindings(request, callSettings);
        }

        /// <summary>
        /// Lists the TagBindings for the given Google Cloud resource, as specified
        /// with `parent`.
        /// 
        /// NOTE: The `parent` field is expected to be a full resource name:
        /// https://cloud.google.com/apis/design/resource_names#full_resource_name
        /// </summary>
        /// <param name="parent">
        /// Required. The full resource name of a resource for which you want to list
        /// existing TagBindings. E.g.
        /// "//cloudresourcemanager.googleapis.com/projects/123"
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
        /// <returns>A pageable asynchronous sequence of <see cref="TagBinding"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTagBindingsResponse, TagBinding> ListTagBindingsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTagBindingsRequest request = new ListTagBindingsRequest
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
            return ListTagBindingsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the TagBindings for the given Google Cloud resource, as specified
        /// with `parent`.
        /// 
        /// NOTE: The `parent` field is expected to be a full resource name:
        /// https://cloud.google.com/apis/design/resource_names#full_resource_name
        /// </summary>
        /// <param name="parent">
        /// Required. The full resource name of a resource for which you want to list
        /// existing TagBindings. E.g.
        /// "//cloudresourcemanager.googleapis.com/projects/123"
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
        /// <returns>A pageable sequence of <see cref="TagBinding"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTagBindingsResponse, TagBinding> ListTagBindings(gax::IResourceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTagBindingsRequest request = new ListTagBindingsRequest
            {
                ParentAsResourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTagBindings(request, callSettings);
        }

        /// <summary>
        /// Lists the TagBindings for the given Google Cloud resource, as specified
        /// with `parent`.
        /// 
        /// NOTE: The `parent` field is expected to be a full resource name:
        /// https://cloud.google.com/apis/design/resource_names#full_resource_name
        /// </summary>
        /// <param name="parent">
        /// Required. The full resource name of a resource for which you want to list
        /// existing TagBindings. E.g.
        /// "//cloudresourcemanager.googleapis.com/projects/123"
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
        /// <returns>A pageable asynchronous sequence of <see cref="TagBinding"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTagBindingsResponse, TagBinding> ListTagBindingsAsync(gax::IResourceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTagBindingsRequest request = new ListTagBindingsRequest
            {
                ParentAsResourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTagBindingsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a TagBinding between a TagValue and a Google Cloud resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TagBinding, CreateTagBindingMetadata> CreateTagBinding(CreateTagBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a TagBinding between a TagValue and a Google Cloud resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TagBinding, CreateTagBindingMetadata>> CreateTagBindingAsync(CreateTagBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a TagBinding between a TagValue and a Google Cloud resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TagBinding, CreateTagBindingMetadata>> CreateTagBindingAsync(CreateTagBindingRequest request, st::CancellationToken cancellationToken) =>
            CreateTagBindingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateTagBinding</c>.</summary>
        public virtual lro::OperationsClient CreateTagBindingOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateTagBinding</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<TagBinding, CreateTagBindingMetadata> PollOnceCreateTagBinding(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<TagBinding, CreateTagBindingMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateTagBindingOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateTagBinding</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<TagBinding, CreateTagBindingMetadata>> PollOnceCreateTagBindingAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<TagBinding, CreateTagBindingMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateTagBindingOperationsClient, callSettings);

        /// <summary>
        /// Creates a TagBinding between a TagValue and a Google Cloud resource.
        /// </summary>
        /// <param name="tagBinding">
        /// Required. The TagBinding to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TagBinding, CreateTagBindingMetadata> CreateTagBinding(TagBinding tagBinding, gaxgrpc::CallSettings callSettings = null) =>
            CreateTagBinding(new CreateTagBindingRequest
            {
                TagBinding = gax::GaxPreconditions.CheckNotNull(tagBinding, nameof(tagBinding)),
            }, callSettings);

        /// <summary>
        /// Creates a TagBinding between a TagValue and a Google Cloud resource.
        /// </summary>
        /// <param name="tagBinding">
        /// Required. The TagBinding to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TagBinding, CreateTagBindingMetadata>> CreateTagBindingAsync(TagBinding tagBinding, gaxgrpc::CallSettings callSettings = null) =>
            CreateTagBindingAsync(new CreateTagBindingRequest
            {
                TagBinding = gax::GaxPreconditions.CheckNotNull(tagBinding, nameof(tagBinding)),
            }, callSettings);

        /// <summary>
        /// Creates a TagBinding between a TagValue and a Google Cloud resource.
        /// </summary>
        /// <param name="tagBinding">
        /// Required. The TagBinding to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TagBinding, CreateTagBindingMetadata>> CreateTagBindingAsync(TagBinding tagBinding, st::CancellationToken cancellationToken) =>
            CreateTagBindingAsync(tagBinding, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a TagBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteTagBindingMetadata> DeleteTagBinding(DeleteTagBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a TagBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteTagBindingMetadata>> DeleteTagBindingAsync(DeleteTagBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a TagBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteTagBindingMetadata>> DeleteTagBindingAsync(DeleteTagBindingRequest request, st::CancellationToken cancellationToken) =>
            DeleteTagBindingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteTagBinding</c>.</summary>
        public virtual lro::OperationsClient DeleteTagBindingOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteTagBinding</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteTagBindingMetadata> PollOnceDeleteTagBinding(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteTagBindingMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteTagBindingOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteTagBinding</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteTagBindingMetadata>> PollOnceDeleteTagBindingAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteTagBindingMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteTagBindingOperationsClient, callSettings);

        /// <summary>
        /// Deletes a TagBinding.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TagBinding. This is a String of the form:
        /// `tagBindings/{id}` (e.g.
        /// `tagBindings/%2F%2Fcloudresourcemanager.googleapis.com%2Fprojects%2F123/tagValues/456`).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteTagBindingMetadata> DeleteTagBinding(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTagBinding(new DeleteTagBindingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a TagBinding.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TagBinding. This is a String of the form:
        /// `tagBindings/{id}` (e.g.
        /// `tagBindings/%2F%2Fcloudresourcemanager.googleapis.com%2Fprojects%2F123/tagValues/456`).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteTagBindingMetadata>> DeleteTagBindingAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTagBindingAsync(new DeleteTagBindingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a TagBinding.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TagBinding. This is a String of the form:
        /// `tagBindings/{id}` (e.g.
        /// `tagBindings/%2F%2Fcloudresourcemanager.googleapis.com%2Fprojects%2F123/tagValues/456`).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteTagBindingMetadata>> DeleteTagBindingAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteTagBindingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a TagBinding.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TagBinding. This is a String of the form:
        /// `tagBindings/{id}` (e.g.
        /// `tagBindings/%2F%2Fcloudresourcemanager.googleapis.com%2Fprojects%2F123/tagValues/456`).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteTagBindingMetadata> DeleteTagBinding(TagBindingName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTagBinding(new DeleteTagBindingRequest
            {
                TagBindingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a TagBinding.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TagBinding. This is a String of the form:
        /// `tagBindings/{id}` (e.g.
        /// `tagBindings/%2F%2Fcloudresourcemanager.googleapis.com%2Fprojects%2F123/tagValues/456`).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteTagBindingMetadata>> DeleteTagBindingAsync(TagBindingName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTagBindingAsync(new DeleteTagBindingRequest
            {
                TagBindingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a TagBinding.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TagBinding. This is a String of the form:
        /// `tagBindings/{id}` (e.g.
        /// `tagBindings/%2F%2Fcloudresourcemanager.googleapis.com%2Fprojects%2F123/tagValues/456`).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteTagBindingMetadata>> DeleteTagBindingAsync(TagBindingName name, st::CancellationToken cancellationToken) =>
            DeleteTagBindingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Return a list of effective tags for the given Google Cloud resource, as
        /// specified in `parent`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EffectiveTag"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEffectiveTagsResponse, EffectiveTag> ListEffectiveTags(ListEffectiveTagsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Return a list of effective tags for the given Google Cloud resource, as
        /// specified in `parent`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="EffectiveTag"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEffectiveTagsResponse, EffectiveTag> ListEffectiveTagsAsync(ListEffectiveTagsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Return a list of effective tags for the given Google Cloud resource, as
        /// specified in `parent`.
        /// </summary>
        /// <param name="parent">
        /// Required. The full resource name of a resource for which you want to list
        /// the effective tags. E.g.
        /// "//cloudresourcemanager.googleapis.com/projects/123"
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
        /// <returns>A pageable sequence of <see cref="EffectiveTag"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEffectiveTagsResponse, EffectiveTag> ListEffectiveTags(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEffectiveTagsRequest request = new ListEffectiveTagsRequest
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
            return ListEffectiveTags(request, callSettings);
        }

        /// <summary>
        /// Return a list of effective tags for the given Google Cloud resource, as
        /// specified in `parent`.
        /// </summary>
        /// <param name="parent">
        /// Required. The full resource name of a resource for which you want to list
        /// the effective tags. E.g.
        /// "//cloudresourcemanager.googleapis.com/projects/123"
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
        /// <returns>A pageable asynchronous sequence of <see cref="EffectiveTag"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEffectiveTagsResponse, EffectiveTag> ListEffectiveTagsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEffectiveTagsRequest request = new ListEffectiveTagsRequest
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
            return ListEffectiveTagsAsync(request, callSettings);
        }
    }

    /// <summary>TagBindings client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Allow users to create and manage TagBindings between TagValues and
    /// different Google Cloud resources throughout the GCP resource hierarchy.
    /// </remarks>
    public sealed partial class TagBindingsClientImpl : TagBindingsClient
    {
        private readonly gaxgrpc::ApiCall<ListTagBindingsRequest, ListTagBindingsResponse> _callListTagBindings;

        private readonly gaxgrpc::ApiCall<CreateTagBindingRequest, lro::Operation> _callCreateTagBinding;

        private readonly gaxgrpc::ApiCall<DeleteTagBindingRequest, lro::Operation> _callDeleteTagBinding;

        private readonly gaxgrpc::ApiCall<ListEffectiveTagsRequest, ListEffectiveTagsResponse> _callListEffectiveTags;

        /// <summary>
        /// Constructs a client wrapper for the TagBindings service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="TagBindingsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public TagBindingsClientImpl(TagBindings.TagBindingsClient grpcClient, TagBindingsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            TagBindingsSettings effectiveSettings = settings ?? TagBindingsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateTagBindingOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateTagBindingOperationsSettings, logger);
            DeleteTagBindingOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteTagBindingOperationsSettings, logger);
            _callListTagBindings = clientHelper.BuildApiCall<ListTagBindingsRequest, ListTagBindingsResponse>("ListTagBindings", grpcClient.ListTagBindingsAsync, grpcClient.ListTagBindings, effectiveSettings.ListTagBindingsSettings);
            Modify_ApiCall(ref _callListTagBindings);
            Modify_ListTagBindingsApiCall(ref _callListTagBindings);
            _callCreateTagBinding = clientHelper.BuildApiCall<CreateTagBindingRequest, lro::Operation>("CreateTagBinding", grpcClient.CreateTagBindingAsync, grpcClient.CreateTagBinding, effectiveSettings.CreateTagBindingSettings);
            Modify_ApiCall(ref _callCreateTagBinding);
            Modify_CreateTagBindingApiCall(ref _callCreateTagBinding);
            _callDeleteTagBinding = clientHelper.BuildApiCall<DeleteTagBindingRequest, lro::Operation>("DeleteTagBinding", grpcClient.DeleteTagBindingAsync, grpcClient.DeleteTagBinding, effectiveSettings.DeleteTagBindingSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteTagBinding);
            Modify_DeleteTagBindingApiCall(ref _callDeleteTagBinding);
            _callListEffectiveTags = clientHelper.BuildApiCall<ListEffectiveTagsRequest, ListEffectiveTagsResponse>("ListEffectiveTags", grpcClient.ListEffectiveTagsAsync, grpcClient.ListEffectiveTags, effectiveSettings.ListEffectiveTagsSettings);
            Modify_ApiCall(ref _callListEffectiveTags);
            Modify_ListEffectiveTagsApiCall(ref _callListEffectiveTags);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListTagBindingsApiCall(ref gaxgrpc::ApiCall<ListTagBindingsRequest, ListTagBindingsResponse> call);

        partial void Modify_CreateTagBindingApiCall(ref gaxgrpc::ApiCall<CreateTagBindingRequest, lro::Operation> call);

        partial void Modify_DeleteTagBindingApiCall(ref gaxgrpc::ApiCall<DeleteTagBindingRequest, lro::Operation> call);

        partial void Modify_ListEffectiveTagsApiCall(ref gaxgrpc::ApiCall<ListEffectiveTagsRequest, ListEffectiveTagsResponse> call);

        partial void OnConstruction(TagBindings.TagBindingsClient grpcClient, TagBindingsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC TagBindings client</summary>
        public override TagBindings.TagBindingsClient GrpcClient { get; }

        partial void Modify_ListTagBindingsRequest(ref ListTagBindingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateTagBindingRequest(ref CreateTagBindingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteTagBindingRequest(ref DeleteTagBindingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListEffectiveTagsRequest(ref ListEffectiveTagsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists the TagBindings for the given Google Cloud resource, as specified
        /// with `parent`.
        /// 
        /// NOTE: The `parent` field is expected to be a full resource name:
        /// https://cloud.google.com/apis/design/resource_names#full_resource_name
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TagBinding"/> resources.</returns>
        public override gax::PagedEnumerable<ListTagBindingsResponse, TagBinding> ListTagBindings(ListTagBindingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTagBindingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTagBindingsRequest, ListTagBindingsResponse, TagBinding>(_callListTagBindings, request, callSettings);
        }

        /// <summary>
        /// Lists the TagBindings for the given Google Cloud resource, as specified
        /// with `parent`.
        /// 
        /// NOTE: The `parent` field is expected to be a full resource name:
        /// https://cloud.google.com/apis/design/resource_names#full_resource_name
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TagBinding"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTagBindingsResponse, TagBinding> ListTagBindingsAsync(ListTagBindingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTagBindingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTagBindingsRequest, ListTagBindingsResponse, TagBinding>(_callListTagBindings, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateTagBinding</c>.</summary>
        public override lro::OperationsClient CreateTagBindingOperationsClient { get; }

        /// <summary>
        /// Creates a TagBinding between a TagValue and a Google Cloud resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<TagBinding, CreateTagBindingMetadata> CreateTagBinding(CreateTagBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTagBindingRequest(ref request, ref callSettings);
            return new lro::Operation<TagBinding, CreateTagBindingMetadata>(_callCreateTagBinding.Sync(request, callSettings), CreateTagBindingOperationsClient);
        }

        /// <summary>
        /// Creates a TagBinding between a TagValue and a Google Cloud resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<TagBinding, CreateTagBindingMetadata>> CreateTagBindingAsync(CreateTagBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTagBindingRequest(ref request, ref callSettings);
            return new lro::Operation<TagBinding, CreateTagBindingMetadata>(await _callCreateTagBinding.Async(request, callSettings).ConfigureAwait(false), CreateTagBindingOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteTagBinding</c>.</summary>
        public override lro::OperationsClient DeleteTagBindingOperationsClient { get; }

        /// <summary>
        /// Deletes a TagBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteTagBindingMetadata> DeleteTagBinding(DeleteTagBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTagBindingRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteTagBindingMetadata>(_callDeleteTagBinding.Sync(request, callSettings), DeleteTagBindingOperationsClient);
        }

        /// <summary>
        /// Deletes a TagBinding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteTagBindingMetadata>> DeleteTagBindingAsync(DeleteTagBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTagBindingRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteTagBindingMetadata>(await _callDeleteTagBinding.Async(request, callSettings).ConfigureAwait(false), DeleteTagBindingOperationsClient);
        }

        /// <summary>
        /// Return a list of effective tags for the given Google Cloud resource, as
        /// specified in `parent`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EffectiveTag"/> resources.</returns>
        public override gax::PagedEnumerable<ListEffectiveTagsResponse, EffectiveTag> ListEffectiveTags(ListEffectiveTagsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEffectiveTagsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEffectiveTagsRequest, ListEffectiveTagsResponse, EffectiveTag>(_callListEffectiveTags, request, callSettings);
        }

        /// <summary>
        /// Return a list of effective tags for the given Google Cloud resource, as
        /// specified in `parent`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="EffectiveTag"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListEffectiveTagsResponse, EffectiveTag> ListEffectiveTagsAsync(ListEffectiveTagsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEffectiveTagsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEffectiveTagsRequest, ListEffectiveTagsResponse, EffectiveTag>(_callListEffectiveTags, request, callSettings);
        }
    }

    public partial class ListTagBindingsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEffectiveTagsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTagBindingsResponse : gaxgrpc::IPageResponse<TagBinding>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<TagBinding> GetEnumerator() => TagBindings.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListEffectiveTagsResponse : gaxgrpc::IPageResponse<EffectiveTag>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<EffectiveTag> GetEnumerator() => EffectiveTags.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class TagBindings
    {
        public partial class TagBindingsClient
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
}
