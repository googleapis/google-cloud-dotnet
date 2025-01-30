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
using gciv = Google.Cloud.Iam.V1;
using gcl = Google.Cloud.Location;
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
            GetIamPolicySettings = existing.GetIamPolicySettings;
            SetIamPolicySettings = existing.SetIamPolicySettings;
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
            ListContentSettings = existing.ListContentSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateContentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContentServiceClient.UpdateContent</c> and <c>ContentServiceClient.UpdateContentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateContentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContentServiceClient.DeleteContent</c> and <c>ContentServiceClient.DeleteContentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteContentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContentServiceClient.GetContent</c> and <c>ContentServiceClient.GetContentAsync</c>.
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
        public gaxgrpc::CallSettings GetContentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContentServiceClient.GetIamPolicy</c> and <c>ContentServiceClient.GetIamPolicyAsync</c>.
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
        public gaxgrpc::CallSettings GetIamPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContentServiceClient.SetIamPolicy</c> and <c>ContentServiceClient.SetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContentServiceClient.TestIamPermissions</c> and <c>ContentServiceClient.TestIamPermissionsAsync</c>.
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
        public gaxgrpc::CallSettings TestIamPermissionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContentServiceClient.ListContent</c> and <c>ContentServiceClient.ListContentAsync</c>.
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
        public gaxgrpc::CallSettings ListContentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

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
            return ContentServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ContentServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ContentServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ContentService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

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

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

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
        /// Gets the access control policy for a contentitem resource. A `NOT_FOUND`
        /// error is returned if the resource does not exist. An empty policy is
        /// returned if the resource exists but does not have a policy set on it.
        /// 
        /// Caller must have Google IAM `dataplex.content.getIamPolicy` permission
        /// on the resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the access control policy for a contentitem resource. A `NOT_FOUND`
        /// error is returned if the resource does not exist. An empty policy is
        /// returned if the resource exists but does not have a policy set on it.
        /// 
        /// Caller must have Google IAM `dataplex.content.getIamPolicy` permission
        /// on the resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the access control policy for a contentitem resource. A `NOT_FOUND`
        /// error is returned if the resource does not exist. An empty policy is
        /// returned if the resource exists but does not have a policy set on it.
        /// 
        /// Caller must have Google IAM `dataplex.content.getIamPolicy` permission
        /// on the resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a contentitem resource. A `NOT_FOUND`
        /// error is returned if the resource does not exist. An empty policy is
        /// returned if the resource exists but does not have a policy set on it.
        /// 
        /// Caller must have Google IAM `dataplex.content.getIamPolicy` permission
        /// on the resource.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(string resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicy(new gciv::GetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for a contentitem resource. A `NOT_FOUND`
        /// error is returned if the resource does not exist. An empty policy is
        /// returned if the resource exists but does not have a policy set on it.
        /// 
        /// Caller must have Google IAM `dataplex.content.getIamPolicy` permission
        /// on the resource.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(string resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicyAsync(new gciv::GetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for a contentitem resource. A `NOT_FOUND`
        /// error is returned if the resource does not exist. An empty policy is
        /// returned if the resource exists but does not have a policy set on it.
        /// 
        /// Caller must have Google IAM `dataplex.content.getIamPolicy` permission
        /// on the resource.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(string resource, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a contentitem resource. A `NOT_FOUND`
        /// error is returned if the resource does not exist. An empty policy is
        /// returned if the resource exists but does not have a policy set on it.
        /// 
        /// Caller must have Google IAM `dataplex.content.getIamPolicy` permission
        /// on the resource.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(gax::IResourceName resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicy(new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for a contentitem resource. A `NOT_FOUND`
        /// error is returned if the resource does not exist. An empty policy is
        /// returned if the resource exists but does not have a policy set on it.
        /// 
        /// Caller must have Google IAM `dataplex.content.getIamPolicy` permission
        /// on the resource.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gax::IResourceName resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicyAsync(new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for a contentitem resource. A `NOT_FOUND`
        /// error is returned if the resource does not exist. An empty policy is
        /// returned if the resource exists but does not have a policy set on it.
        /// 
        /// Caller must have Google IAM `dataplex.content.getIamPolicy` permission
        /// on the resource.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gax::IResourceName resource, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on the specified contentitem resource.
        /// Replaces any existing policy.
        /// 
        /// Caller must have Google IAM `dataplex.content.setIamPolicy` permission
        /// on the resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the access control policy on the specified contentitem resource.
        /// Replaces any existing policy.
        /// 
        /// Caller must have Google IAM `dataplex.content.setIamPolicy` permission
        /// on the resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the access control policy on the specified contentitem resource.
        /// Replaces any existing policy.
        /// 
        /// Caller must have Google IAM `dataplex.content.setIamPolicy` permission
        /// on the resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the caller's permissions on a resource.
        /// If the resource does not exist, an empty set of
        /// permissions is returned (a `NOT_FOUND` error is not returned).
        /// 
        /// A caller is not required to have Google IAM permission to make this
        /// request.
        /// 
        /// Note: This operation is designed to be used for building permission-aware
        /// UIs and command-line tools, not for authorization checking. This operation
        /// may "fail open" without warning.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the caller's permissions on a resource.
        /// If the resource does not exist, an empty set of
        /// permissions is returned (a `NOT_FOUND` error is not returned).
        /// 
        /// A caller is not required to have Google IAM permission to make this
        /// request.
        /// 
        /// Note: This operation is designed to be used for building permission-aware
        /// UIs and command-line tools, not for authorization checking. This operation
        /// may "fail open" without warning.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the caller's permissions on a resource.
        /// If the resource does not exist, an empty set of
        /// permissions is returned (a `NOT_FOUND` error is not returned).
        /// 
        /// A caller is not required to have Google IAM permission to make this
        /// request.
        /// 
        /// Note: This operation is designed to be used for building permission-aware
        /// UIs and command-line tools, not for authorization checking. This operation
        /// may "fail open" without warning.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual gax::PagedEnumerable<ListContentResponse, Content> ListContent(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListContentRequest request = new ListContentRequest
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
            return ListContent(request, callSettings);
        }

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
        public virtual gax::PagedAsyncEnumerable<ListContentResponse, Content> ListContentAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListContentRequest request = new ListContentRequest
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
            return ListContentAsync(request, callSettings);
        }

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
        public virtual gax::PagedEnumerable<ListContentResponse, Content> ListContent(LakeName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListContentRequest request = new ListContentRequest
            {
                ParentAsLakeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListContent(request, callSettings);
        }

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
        public virtual gax::PagedAsyncEnumerable<ListContentResponse, Content> ListContentAsync(LakeName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListContentRequest request = new ListContentRequest
            {
                ParentAsLakeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListContentAsync(request, callSettings);
        }
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

        private readonly gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> _callGetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> _callSetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> _callTestIamPermissions;

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
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
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
            _callGetIamPolicy = clientHelper.BuildApiCall<gciv::GetIamPolicyRequest, gciv::Policy>("GetIamPolicy", grpcClient.GetIamPolicyAsync, grpcClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callGetIamPolicy);
            Modify_GetIamPolicyApiCall(ref _callGetIamPolicy);
            _callSetIamPolicy = clientHelper.BuildApiCall<gciv::SetIamPolicyRequest, gciv::Policy>("SetIamPolicy", grpcClient.SetIamPolicyAsync, grpcClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callSetIamPolicy);
            Modify_SetIamPolicyApiCall(ref _callSetIamPolicy);
            _callTestIamPermissions = clientHelper.BuildApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse>("TestIamPermissions", grpcClient.TestIamPermissionsAsync, grpcClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callTestIamPermissions);
            Modify_TestIamPermissionsApiCall(ref _callTestIamPermissions);
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

        partial void Modify_GetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_SetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_TestIamPermissionsApiCall(ref gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> call);

        partial void Modify_ListContentApiCall(ref gaxgrpc::ApiCall<ListContentRequest, ListContentResponse> call);

        partial void OnConstruction(ContentService.ContentServiceClient grpcClient, ContentServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ContentService client</summary>
        public override ContentService.ContentServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_CreateContentRequest(ref CreateContentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateContentRequest(ref UpdateContentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteContentRequest(ref DeleteContentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetContentRequest(ref GetContentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIamPolicyRequest(ref gciv::GetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetIamPolicyRequest(ref gciv::SetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TestIamPermissionsRequest(ref gciv::TestIamPermissionsRequest request, ref gaxgrpc::CallSettings settings);

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
        /// Gets the access control policy for a contentitem resource. A `NOT_FOUND`
        /// error is returned if the resource does not exist. An empty policy is
        /// returned if the resource exists but does not have a policy set on it.
        /// 
        /// Caller must have Google IAM `dataplex.content.getIamPolicy` permission
        /// on the resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the access control policy for a contentitem resource. A `NOT_FOUND`
        /// error is returned if the resource does not exist. An empty policy is
        /// returned if the resource exists but does not have a policy set on it.
        /// 
        /// Caller must have Google IAM `dataplex.content.getIamPolicy` permission
        /// on the resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the access control policy on the specified contentitem resource.
        /// Replaces any existing policy.
        /// 
        /// Caller must have Google IAM `dataplex.content.setIamPolicy` permission
        /// on the resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the access control policy on the specified contentitem resource.
        /// Replaces any existing policy.
        /// 
        /// Caller must have Google IAM `dataplex.content.setIamPolicy` permission
        /// on the resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the caller's permissions on a resource.
        /// If the resource does not exist, an empty set of
        /// permissions is returned (a `NOT_FOUND` error is not returned).
        /// 
        /// A caller is not required to have Google IAM permission to make this
        /// request.
        /// 
        /// Note: This operation is designed to be used for building permission-aware
        /// UIs and command-line tools, not for authorization checking. This operation
        /// may "fail open" without warning.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the caller's permissions on a resource.
        /// If the resource does not exist, an empty set of
        /// permissions is returned (a `NOT_FOUND` error is not returned).
        /// 
        /// A caller is not required to have Google IAM permission to make this
        /// request.
        /// 
        /// Note: This operation is designed to be used for building permission-aware
        /// UIs and command-line tools, not for authorization checking. This operation
        /// may "fail open" without warning.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Async(request, callSettings);
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

    public static partial class ContentService
    {
        public partial class ContentServiceClient
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
