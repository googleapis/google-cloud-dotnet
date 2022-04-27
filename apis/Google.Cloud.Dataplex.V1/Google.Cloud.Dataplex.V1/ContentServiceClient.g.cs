// Copyright 2022 Google LLC
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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Dataplex.V1
{
    /// <summary>Settings for <see cref="ContentServiceClient"/> instances.</summary>
    public sealed partial class ContentServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ContentServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ContentServiceSettings"/>.</returns>
        public static ContentServiceSettings GetDefault() => new ContentServiceSettings();

        /// <summary>Constructs a new <see cref="ContentServiceSettings"/> object with default settings.</summary>
        public ContentServiceSettings()
        {
        }

        private ContentServiceSettings(ContentServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateContentSettings = existing.CreateContentSettings;
            UpdateContentSettings = existing.UpdateContentSettings;
            DeleteContentSettings = existing.DeleteContentSettings;
            GetContentSettings = existing.GetContentSettings;
            ListContentSettings = existing.ListContentSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ContentServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContentServiceClient.CreateContent</c> and <c>ContentServiceClient.CreateContentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateContentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContentServiceClient.UpdateContent</c> and <c>ContentServiceClient.UpdateContentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateContentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContentServiceClient.DeleteContent</c> and <c>ContentServiceClient.DeleteContentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteContentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContentServiceClient.GetContent</c> and <c>ContentServiceClient.GetContentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetContentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContentServiceClient.ListContent</c> and <c>ContentServiceClient.ListContentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListContentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ContentServiceSettings"/> object.</returns>
        public ContentServiceSettings Clone() => new ContentServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ContentServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class ContentServiceClientBuilder : gaxgrpc::ClientBuilderBase<ContentServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ContentServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ContentServiceClientBuilder() : base(ContentServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ContentServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ContentServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ContentServiceClient Build()
        {
            ContentServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ContentServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ContentServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ContentServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ContentServiceClient.Create(callInvoker, Settings, Logger);
        }

        private async stt::Task<ContentServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ContentServiceClient.Create(callInvoker, Settings, Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ContentServiceClient.ChannelPool;
    }

    /// <summary>ContentService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// ContentService manages Notebook and SQL Scripts for Dataplex.
    /// </remarks>
    public abstract partial class ContentServiceClient
    {
        /// <summary>
        /// The default endpoint for the ContentService service, which is a host of "dataplex.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dataplex.googleapis.com:443";

        /// <summary>The default ContentService scopes.</summary>
        /// <remarks>
        /// The default ContentService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ContentService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ContentServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ContentServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ContentServiceClient"/>.</returns>
        public static stt::Task<ContentServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ContentServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ContentServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ContentServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ContentServiceClient"/>.</returns>
        public static ContentServiceClient Create() => new ContentServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ContentServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ContentServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ContentServiceClient"/>.</returns>
        internal static ContentServiceClient Create(grpccore::CallInvoker callInvoker, ContentServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ContentService.ContentServiceClient grpcClient = new ContentService.ContentServiceClient(callInvoker);
            return new ContentServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ContentService client</summary>
        public virtual ContentService.ContentServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Create a content.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Content CreateContent(CreateContentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a content.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Content> CreateContentAsync(CreateContentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a content.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Content> CreateContentAsync(CreateContentRequest request, st::CancellationToken cancellationToken) =>
            CreateContentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a content.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent lake:
        /// projects/{project_id}/locations/{location_id}/lakes/{lake_id}
        /// </param>
        /// <param name="content">
        /// Required. Content resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Content CreateContent(string parent, Content content, gaxgrpc::CallSettings callSettings = null) =>
            CreateContent(new CreateContentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Content = gax::GaxPreconditions.CheckNotNull(content, nameof(content)),
            }, callSettings);

        /// <summary>
        /// Create a content.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent lake:
        /// projects/{project_id}/locations/{location_id}/lakes/{lake_id}
        /// </param>
        /// <param name="content">
        /// Required. Content resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Content> CreateContentAsync(string parent, Content content, gaxgrpc::CallSettings callSettings = null) =>
            CreateContentAsync(new CreateContentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Content = gax::GaxPreconditions.CheckNotNull(content, nameof(content)),
            }, callSettings);

        /// <summary>
        /// Create a content.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent lake:
        /// projects/{project_id}/locations/{location_id}/lakes/{lake_id}
        /// </param>
        /// <param name="content">
        /// Required. Content resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Content> CreateContentAsync(string parent, Content content, st::CancellationToken cancellationToken) =>
            CreateContentAsync(parent, content, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a content.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent lake:
        /// projects/{project_id}/locations/{location_id}/lakes/{lake_id}
        /// </param>
        /// <param name="content">
        /// Required. Content resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Content CreateContent(LakeName parent, Content content, gaxgrpc::CallSettings callSettings = null) =>
            CreateContent(new CreateContentRequest
            {
                ParentAsLakeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Content = gax::GaxPreconditions.CheckNotNull(content, nameof(content)),
            }, callSettings);

        /// <summary>
        /// Create a content.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent lake:
        /// projects/{project_id}/locations/{location_id}/lakes/{lake_id}
        /// </param>
        /// <param name="content">
        /// Required. Content resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Content> CreateContentAsync(LakeName parent, Content content, gaxgrpc::CallSettings callSettings = null) =>
            CreateContentAsync(new CreateContentRequest
            {
                ParentAsLakeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Content = gax::GaxPreconditions.CheckNotNull(content, nameof(content)),
            }, callSettings);

        /// <summary>
        /// Create a content.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent lake:
        /// projects/{project_id}/locations/{location_id}/lakes/{lake_id}
        /// </param>
        /// <param name="content">
        /// Required. Content resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Content> CreateContentAsync(LakeName parent, Content content, st::CancellationToken cancellationToken) =>
            CreateContentAsync(parent, content, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a content. Only supports full resource update.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Content UpdateContent(UpdateContentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a content. Only supports full resource update.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Content> UpdateContentAsync(UpdateContentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a content. Only supports full resource update.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Content> UpdateContentAsync(UpdateContentRequest request, st::CancellationToken cancellationToken) =>
            UpdateContentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a content. Only supports full resource update.
        /// </summary>
        /// <param name="content">
        /// Required. Update description.
        /// Only fields specified in `update_mask` are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Content UpdateContent(Content content, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateContent(new UpdateContentRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Content = gax::GaxPreconditions.CheckNotNull(content, nameof(content)),
            }, callSettings);

        /// <summary>
        /// Update a content. Only supports full resource update.
        /// </summary>
        /// <param name="content">
        /// Required. Update description.
        /// Only fields specified in `update_mask` are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Content> UpdateContentAsync(Content content, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateContentAsync(new UpdateContentRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Content = gax::GaxPreconditions.CheckNotNull(content, nameof(content)),
            }, callSettings);

        /// <summary>
        /// Update a content. Only supports full resource update.
        /// </summary>
        /// <param name="content">
        /// Required. Update description.
        /// Only fields specified in `update_mask` are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Content> UpdateContentAsync(Content content, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateContentAsync(content, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a content.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteContent(DeleteContentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a content.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteContentAsync(DeleteContentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a content.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteContentAsync(DeleteContentRequest request, st::CancellationToken cancellationToken) =>
            DeleteContentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a content.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the content:
        /// projects/{project_id}/locations/{location_id}/lakes/{lake_id}/content/{content_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteContent(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteContent(new DeleteContentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a content.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the content:
        /// projects/{project_id}/locations/{location_id}/lakes/{lake_id}/content/{content_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteContentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteContentAsync(new DeleteContentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a content.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the content:
        /// projects/{project_id}/locations/{location_id}/lakes/{lake_id}/content/{content_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteContentAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteContentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a content.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the content:
        /// projects/{project_id}/locations/{location_id}/lakes/{lake_id}/content/{content_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteContent(ContentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteContent(new DeleteContentRequest
            {
                ContentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a content.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the content:
        /// projects/{project_id}/locations/{location_id}/lakes/{lake_id}/content/{content_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteContentAsync(ContentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteContentAsync(new DeleteContentRequest
            {
                ContentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a content.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the content:
        /// projects/{project_id}/locations/{location_id}/lakes/{lake_id}/content/{content_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteContentAsync(ContentName name, st::CancellationToken cancellationToken) =>
            DeleteContentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a content resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Content GetContent(GetContentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a content resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Content> GetContentAsync(GetContentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a content resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Content> GetContentAsync(GetContentRequest request, st::CancellationToken cancellationToken) =>
            GetContentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a content resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the content:
        /// projects/{project_id}/locations/{location_id}/lakes/{lake_id}/content/{content_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Content GetContent(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetContent(new GetContentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a content resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the content:
        /// projects/{project_id}/locations/{location_id}/lakes/{lake_id}/content/{content_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Content> GetContentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetContentAsync(new GetContentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a content resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the content:
        /// projects/{project_id}/locations/{location_id}/lakes/{lake_id}/content/{content_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Content> GetContentAsync(string name, st::CancellationToken cancellationToken) =>
            GetContentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a content resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the content:
        /// projects/{project_id}/locations/{location_id}/lakes/{lake_id}/content/{content_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Content GetContent(ContentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetContent(new GetContentRequest
            {
                ContentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a content resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the content:
        /// projects/{project_id}/locations/{location_id}/lakes/{lake_id}/content/{content_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Content> GetContentAsync(ContentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetContentAsync(new GetContentRequest
            {
                ContentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a content resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the content:
        /// projects/{project_id}/locations/{location_id}/lakes/{lake_id}/content/{content_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Content> GetContentAsync(ContentName name, st::CancellationToken cancellationToken) =>
            GetContentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List content.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Content"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListContentResponse, Content> ListContent(ListContentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List content.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Content"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListContentResponse, Content> ListContentAsync(ListContentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List content.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent lake:
        /// projects/{project_id}/locations/{location_id}/lakes/{lake_id}
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
        /// <returns>A pageable sequence of <see cref="Content"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListContentResponse, Content> ListContent(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListContent(new ListContentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List content.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent lake:
        /// projects/{project_id}/locations/{location_id}/lakes/{lake_id}
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
        /// <returns>A pageable asynchronous sequence of <see cref="Content"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListContentResponse, Content> ListContentAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListContentAsync(new ListContentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List content.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent lake:
        /// projects/{project_id}/locations/{location_id}/lakes/{lake_id}
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
        /// <returns>A pageable sequence of <see cref="Content"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListContentResponse, Content> ListContent(LakeName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListContent(new ListContentRequest
            {
                ParentAsLakeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List content.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent lake:
        /// projects/{project_id}/locations/{location_id}/lakes/{lake_id}
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
        /// <returns>A pageable asynchronous sequence of <see cref="Content"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListContentResponse, Content> ListContentAsync(LakeName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListContentAsync(new ListContentRequest
            {
                ParentAsLakeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);
    }

    /// <summary>ContentService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// ContentService manages Notebook and SQL Scripts for Dataplex.
    /// </remarks>
    public sealed partial class ContentServiceClientImpl : ContentServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateContentRequest, Content> _callCreateContent;

        private readonly gaxgrpc::ApiCall<UpdateContentRequest, Content> _callUpdateContent;

        private readonly gaxgrpc::ApiCall<DeleteContentRequest, wkt::Empty> _callDeleteContent;

        private readonly gaxgrpc::ApiCall<GetContentRequest, Content> _callGetContent;

        private readonly gaxgrpc::ApiCall<ListContentRequest, ListContentResponse> _callListContent;

        /// <summary>
        /// Constructs a client wrapper for the ContentService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ContentServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ContentServiceClientImpl(ContentService.ContentServiceClient grpcClient, ContentServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ContentServiceSettings effectiveSettings = settings ?? ContentServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            _callCreateContent = clientHelper.BuildApiCall<CreateContentRequest, Content>("CreateContent", grpcClient.CreateContentAsync, grpcClient.CreateContent, effectiveSettings.CreateContentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateContent);
            Modify_CreateContentApiCall(ref _callCreateContent);
            _callUpdateContent = clientHelper.BuildApiCall<UpdateContentRequest, Content>("UpdateContent", grpcClient.UpdateContentAsync, grpcClient.UpdateContent, effectiveSettings.UpdateContentSettings).WithGoogleRequestParam("content.name", request => request.Content?.Name);
            Modify_ApiCall(ref _callUpdateContent);
            Modify_UpdateContentApiCall(ref _callUpdateContent);
            _callDeleteContent = clientHelper.BuildApiCall<DeleteContentRequest, wkt::Empty>("DeleteContent", grpcClient.DeleteContentAsync, grpcClient.DeleteContent, effectiveSettings.DeleteContentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteContent);
            Modify_DeleteContentApiCall(ref _callDeleteContent);
            _callGetContent = clientHelper.BuildApiCall<GetContentRequest, Content>("GetContent", grpcClient.GetContentAsync, grpcClient.GetContent, effectiveSettings.GetContentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetContent);
            Modify_GetContentApiCall(ref _callGetContent);
            _callListContent = clientHelper.BuildApiCall<ListContentRequest, ListContentResponse>("ListContent", grpcClient.ListContentAsync, grpcClient.ListContent, effectiveSettings.ListContentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListContent);
            Modify_ListContentApiCall(ref _callListContent);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateContentApiCall(ref gaxgrpc::ApiCall<CreateContentRequest, Content> call);

        partial void Modify_UpdateContentApiCall(ref gaxgrpc::ApiCall<UpdateContentRequest, Content> call);

        partial void Modify_DeleteContentApiCall(ref gaxgrpc::ApiCall<DeleteContentRequest, wkt::Empty> call);

        partial void Modify_GetContentApiCall(ref gaxgrpc::ApiCall<GetContentRequest, Content> call);

        partial void Modify_ListContentApiCall(ref gaxgrpc::ApiCall<ListContentRequest, ListContentResponse> call);

        partial void OnConstruction(ContentService.ContentServiceClient grpcClient, ContentServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ContentService client</summary>
        public override ContentService.ContentServiceClient GrpcClient { get; }

        partial void Modify_CreateContentRequest(ref CreateContentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateContentRequest(ref UpdateContentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteContentRequest(ref DeleteContentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetContentRequest(ref GetContentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListContentRequest(ref ListContentRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Create a content.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Content CreateContent(CreateContentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateContentRequest(ref request, ref callSettings);
            return _callCreateContent.Sync(request, callSettings);
        }

        /// <summary>
        /// Create a content.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Content> CreateContentAsync(CreateContentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateContentRequest(ref request, ref callSettings);
            return _callCreateContent.Async(request, callSettings);
        }

        /// <summary>
        /// Update a content. Only supports full resource update.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Content UpdateContent(UpdateContentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateContentRequest(ref request, ref callSettings);
            return _callUpdateContent.Sync(request, callSettings);
        }

        /// <summary>
        /// Update a content. Only supports full resource update.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Content> UpdateContentAsync(UpdateContentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateContentRequest(ref request, ref callSettings);
            return _callUpdateContent.Async(request, callSettings);
        }

        /// <summary>
        /// Delete a content.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteContent(DeleteContentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteContentRequest(ref request, ref callSettings);
            _callDeleteContent.Sync(request, callSettings);
        }

        /// <summary>
        /// Delete a content.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteContentAsync(DeleteContentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteContentRequest(ref request, ref callSettings);
            return _callDeleteContent.Async(request, callSettings);
        }

        /// <summary>
        /// Get a content resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Content GetContent(GetContentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetContentRequest(ref request, ref callSettings);
            return _callGetContent.Sync(request, callSettings);
        }

        /// <summary>
        /// Get a content resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Content> GetContentAsync(GetContentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetContentRequest(ref request, ref callSettings);
            return _callGetContent.Async(request, callSettings);
        }

        /// <summary>
        /// List content.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Content"/> resources.</returns>
        public override gax::PagedEnumerable<ListContentResponse, Content> ListContent(ListContentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListContentRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListContentRequest, ListContentResponse, Content>(_callListContent, request, callSettings);
        }

        /// <summary>
        /// List content.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Content"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListContentResponse, Content> ListContentAsync(ListContentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListContentRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListContentRequest, ListContentResponse, Content>(_callListContent, request, callSettings);
        }
    }

    public partial class ListContentRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListContentResponse : gaxgrpc::IPageResponse<Content>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Content> GetEnumerator() => Content.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
