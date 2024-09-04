// Copyright 2024 Google LLC
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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
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

namespace Google.Cloud.ApiHub.V1
{
    /// <summary>Settings for <see cref="RuntimeProjectAttachmentServiceClient"/> instances.</summary>
    public sealed partial class RuntimeProjectAttachmentServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="RuntimeProjectAttachmentServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="RuntimeProjectAttachmentServiceSettings"/>.</returns>
        public static RuntimeProjectAttachmentServiceSettings GetDefault() => new RuntimeProjectAttachmentServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="RuntimeProjectAttachmentServiceSettings"/> object with default settings.
        /// </summary>
        public RuntimeProjectAttachmentServiceSettings()
        {
        }

        private RuntimeProjectAttachmentServiceSettings(RuntimeProjectAttachmentServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateRuntimeProjectAttachmentSettings = existing.CreateRuntimeProjectAttachmentSettings;
            GetRuntimeProjectAttachmentSettings = existing.GetRuntimeProjectAttachmentSettings;
            ListRuntimeProjectAttachmentsSettings = existing.ListRuntimeProjectAttachmentsSettings;
            DeleteRuntimeProjectAttachmentSettings = existing.DeleteRuntimeProjectAttachmentSettings;
            LookupRuntimeProjectAttachmentSettings = existing.LookupRuntimeProjectAttachmentSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(RuntimeProjectAttachmentServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RuntimeProjectAttachmentServiceClient.CreateRuntimeProjectAttachment</c> and
        /// <c>RuntimeProjectAttachmentServiceClient.CreateRuntimeProjectAttachmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateRuntimeProjectAttachmentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RuntimeProjectAttachmentServiceClient.GetRuntimeProjectAttachment</c> and
        /// <c>RuntimeProjectAttachmentServiceClient.GetRuntimeProjectAttachmentAsync</c>.
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
        public gaxgrpc::CallSettings GetRuntimeProjectAttachmentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RuntimeProjectAttachmentServiceClient.ListRuntimeProjectAttachments</c> and
        /// <c>RuntimeProjectAttachmentServiceClient.ListRuntimeProjectAttachmentsAsync</c>.
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
        public gaxgrpc::CallSettings ListRuntimeProjectAttachmentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RuntimeProjectAttachmentServiceClient.DeleteRuntimeProjectAttachment</c> and
        /// <c>RuntimeProjectAttachmentServiceClient.DeleteRuntimeProjectAttachmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteRuntimeProjectAttachmentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RuntimeProjectAttachmentServiceClient.LookupRuntimeProjectAttachment</c> and
        /// <c>RuntimeProjectAttachmentServiceClient.LookupRuntimeProjectAttachmentAsync</c>.
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
        public gaxgrpc::CallSettings LookupRuntimeProjectAttachmentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="RuntimeProjectAttachmentServiceSettings"/> object.</returns>
        public RuntimeProjectAttachmentServiceSettings Clone() => new RuntimeProjectAttachmentServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="RuntimeProjectAttachmentServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class RuntimeProjectAttachmentServiceClientBuilder : gaxgrpc::ClientBuilderBase<RuntimeProjectAttachmentServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public RuntimeProjectAttachmentServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public RuntimeProjectAttachmentServiceClientBuilder() : base(RuntimeProjectAttachmentServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref RuntimeProjectAttachmentServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<RuntimeProjectAttachmentServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override RuntimeProjectAttachmentServiceClient Build()
        {
            RuntimeProjectAttachmentServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<RuntimeProjectAttachmentServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<RuntimeProjectAttachmentServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private RuntimeProjectAttachmentServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return RuntimeProjectAttachmentServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<RuntimeProjectAttachmentServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return RuntimeProjectAttachmentServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => RuntimeProjectAttachmentServiceClient.ChannelPool;
    }

    /// <summary>RuntimeProjectAttachmentService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// This service is used for managing the runtime project attachments.
    /// </remarks>
    public abstract partial class RuntimeProjectAttachmentServiceClient
    {
        /// <summary>
        /// The default endpoint for the RuntimeProjectAttachmentService service, which is a host of
        /// "apihub.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "apihub.googleapis.com:443";

        /// <summary>The default RuntimeProjectAttachmentService scopes.</summary>
        /// <remarks>
        /// The default RuntimeProjectAttachmentService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(RuntimeProjectAttachmentService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="RuntimeProjectAttachmentServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="RuntimeProjectAttachmentServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="RuntimeProjectAttachmentServiceClient"/>.</returns>
        public static stt::Task<RuntimeProjectAttachmentServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new RuntimeProjectAttachmentServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="RuntimeProjectAttachmentServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="RuntimeProjectAttachmentServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="RuntimeProjectAttachmentServiceClient"/>.</returns>
        public static RuntimeProjectAttachmentServiceClient Create() =>
            new RuntimeProjectAttachmentServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="RuntimeProjectAttachmentServiceClient"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="RuntimeProjectAttachmentServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="RuntimeProjectAttachmentServiceClient"/>.</returns>
        internal static RuntimeProjectAttachmentServiceClient Create(grpccore::CallInvoker callInvoker, RuntimeProjectAttachmentServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            RuntimeProjectAttachmentService.RuntimeProjectAttachmentServiceClient grpcClient = new RuntimeProjectAttachmentService.RuntimeProjectAttachmentServiceClient(callInvoker);
            return new RuntimeProjectAttachmentServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC RuntimeProjectAttachmentService client</summary>
        public virtual RuntimeProjectAttachmentService.RuntimeProjectAttachmentServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Attaches a runtime project to the host project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RuntimeProjectAttachment CreateRuntimeProjectAttachment(CreateRuntimeProjectAttachmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Attaches a runtime project to the host project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RuntimeProjectAttachment> CreateRuntimeProjectAttachmentAsync(CreateRuntimeProjectAttachmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Attaches a runtime project to the host project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RuntimeProjectAttachment> CreateRuntimeProjectAttachmentAsync(CreateRuntimeProjectAttachmentRequest request, st::CancellationToken cancellationToken) =>
            CreateRuntimeProjectAttachmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Attaches a runtime project to the host project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for the Runtime Project Attachment.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="runtimeProjectAttachment">
        /// Required. The Runtime Project Attachment to create.
        /// </param>
        /// <param name="runtimeProjectAttachmentId">
        /// Required. The ID to use for the Runtime Project Attachment, which will
        /// become the final component of the Runtime Project Attachment's name. The ID
        /// must be the same as the project ID of the Google cloud project specified in
        /// the runtime_project_attachment.runtime_project field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RuntimeProjectAttachment CreateRuntimeProjectAttachment(string parent, RuntimeProjectAttachment runtimeProjectAttachment, string runtimeProjectAttachmentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRuntimeProjectAttachment(new CreateRuntimeProjectAttachmentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                RuntimeProjectAttachmentId = gax::GaxPreconditions.CheckNotNullOrEmpty(runtimeProjectAttachmentId, nameof(runtimeProjectAttachmentId)),
                RuntimeProjectAttachment = gax::GaxPreconditions.CheckNotNull(runtimeProjectAttachment, nameof(runtimeProjectAttachment)),
            }, callSettings);

        /// <summary>
        /// Attaches a runtime project to the host project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for the Runtime Project Attachment.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="runtimeProjectAttachment">
        /// Required. The Runtime Project Attachment to create.
        /// </param>
        /// <param name="runtimeProjectAttachmentId">
        /// Required. The ID to use for the Runtime Project Attachment, which will
        /// become the final component of the Runtime Project Attachment's name. The ID
        /// must be the same as the project ID of the Google cloud project specified in
        /// the runtime_project_attachment.runtime_project field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RuntimeProjectAttachment> CreateRuntimeProjectAttachmentAsync(string parent, RuntimeProjectAttachment runtimeProjectAttachment, string runtimeProjectAttachmentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRuntimeProjectAttachmentAsync(new CreateRuntimeProjectAttachmentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                RuntimeProjectAttachmentId = gax::GaxPreconditions.CheckNotNullOrEmpty(runtimeProjectAttachmentId, nameof(runtimeProjectAttachmentId)),
                RuntimeProjectAttachment = gax::GaxPreconditions.CheckNotNull(runtimeProjectAttachment, nameof(runtimeProjectAttachment)),
            }, callSettings);

        /// <summary>
        /// Attaches a runtime project to the host project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for the Runtime Project Attachment.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="runtimeProjectAttachment">
        /// Required. The Runtime Project Attachment to create.
        /// </param>
        /// <param name="runtimeProjectAttachmentId">
        /// Required. The ID to use for the Runtime Project Attachment, which will
        /// become the final component of the Runtime Project Attachment's name. The ID
        /// must be the same as the project ID of the Google cloud project specified in
        /// the runtime_project_attachment.runtime_project field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RuntimeProjectAttachment> CreateRuntimeProjectAttachmentAsync(string parent, RuntimeProjectAttachment runtimeProjectAttachment, string runtimeProjectAttachmentId, st::CancellationToken cancellationToken) =>
            CreateRuntimeProjectAttachmentAsync(parent, runtimeProjectAttachment, runtimeProjectAttachmentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Attaches a runtime project to the host project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for the Runtime Project Attachment.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="runtimeProjectAttachment">
        /// Required. The Runtime Project Attachment to create.
        /// </param>
        /// <param name="runtimeProjectAttachmentId">
        /// Required. The ID to use for the Runtime Project Attachment, which will
        /// become the final component of the Runtime Project Attachment's name. The ID
        /// must be the same as the project ID of the Google cloud project specified in
        /// the runtime_project_attachment.runtime_project field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RuntimeProjectAttachment CreateRuntimeProjectAttachment(gagr::LocationName parent, RuntimeProjectAttachment runtimeProjectAttachment, string runtimeProjectAttachmentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRuntimeProjectAttachment(new CreateRuntimeProjectAttachmentRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                RuntimeProjectAttachmentId = gax::GaxPreconditions.CheckNotNullOrEmpty(runtimeProjectAttachmentId, nameof(runtimeProjectAttachmentId)),
                RuntimeProjectAttachment = gax::GaxPreconditions.CheckNotNull(runtimeProjectAttachment, nameof(runtimeProjectAttachment)),
            }, callSettings);

        /// <summary>
        /// Attaches a runtime project to the host project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for the Runtime Project Attachment.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="runtimeProjectAttachment">
        /// Required. The Runtime Project Attachment to create.
        /// </param>
        /// <param name="runtimeProjectAttachmentId">
        /// Required. The ID to use for the Runtime Project Attachment, which will
        /// become the final component of the Runtime Project Attachment's name. The ID
        /// must be the same as the project ID of the Google cloud project specified in
        /// the runtime_project_attachment.runtime_project field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RuntimeProjectAttachment> CreateRuntimeProjectAttachmentAsync(gagr::LocationName parent, RuntimeProjectAttachment runtimeProjectAttachment, string runtimeProjectAttachmentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRuntimeProjectAttachmentAsync(new CreateRuntimeProjectAttachmentRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                RuntimeProjectAttachmentId = gax::GaxPreconditions.CheckNotNullOrEmpty(runtimeProjectAttachmentId, nameof(runtimeProjectAttachmentId)),
                RuntimeProjectAttachment = gax::GaxPreconditions.CheckNotNull(runtimeProjectAttachment, nameof(runtimeProjectAttachment)),
            }, callSettings);

        /// <summary>
        /// Attaches a runtime project to the host project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for the Runtime Project Attachment.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="runtimeProjectAttachment">
        /// Required. The Runtime Project Attachment to create.
        /// </param>
        /// <param name="runtimeProjectAttachmentId">
        /// Required. The ID to use for the Runtime Project Attachment, which will
        /// become the final component of the Runtime Project Attachment's name. The ID
        /// must be the same as the project ID of the Google cloud project specified in
        /// the runtime_project_attachment.runtime_project field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RuntimeProjectAttachment> CreateRuntimeProjectAttachmentAsync(gagr::LocationName parent, RuntimeProjectAttachment runtimeProjectAttachment, string runtimeProjectAttachmentId, st::CancellationToken cancellationToken) =>
            CreateRuntimeProjectAttachmentAsync(parent, runtimeProjectAttachment, runtimeProjectAttachmentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a runtime project attachment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RuntimeProjectAttachment GetRuntimeProjectAttachment(GetRuntimeProjectAttachmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a runtime project attachment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RuntimeProjectAttachment> GetRuntimeProjectAttachmentAsync(GetRuntimeProjectAttachmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a runtime project attachment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RuntimeProjectAttachment> GetRuntimeProjectAttachmentAsync(GetRuntimeProjectAttachmentRequest request, st::CancellationToken cancellationToken) =>
            GetRuntimeProjectAttachmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a runtime project attachment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the API resource to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/runtimeProjectAttachments/{runtime_project_attachment}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RuntimeProjectAttachment GetRuntimeProjectAttachment(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRuntimeProjectAttachment(new GetRuntimeProjectAttachmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a runtime project attachment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the API resource to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/runtimeProjectAttachments/{runtime_project_attachment}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RuntimeProjectAttachment> GetRuntimeProjectAttachmentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRuntimeProjectAttachmentAsync(new GetRuntimeProjectAttachmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a runtime project attachment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the API resource to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/runtimeProjectAttachments/{runtime_project_attachment}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RuntimeProjectAttachment> GetRuntimeProjectAttachmentAsync(string name, st::CancellationToken cancellationToken) =>
            GetRuntimeProjectAttachmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a runtime project attachment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the API resource to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/runtimeProjectAttachments/{runtime_project_attachment}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RuntimeProjectAttachment GetRuntimeProjectAttachment(RuntimeProjectAttachmentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRuntimeProjectAttachment(new GetRuntimeProjectAttachmentRequest
            {
                RuntimeProjectAttachmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a runtime project attachment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the API resource to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/runtimeProjectAttachments/{runtime_project_attachment}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RuntimeProjectAttachment> GetRuntimeProjectAttachmentAsync(RuntimeProjectAttachmentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRuntimeProjectAttachmentAsync(new GetRuntimeProjectAttachmentRequest
            {
                RuntimeProjectAttachmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a runtime project attachment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the API resource to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/runtimeProjectAttachments/{runtime_project_attachment}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RuntimeProjectAttachment> GetRuntimeProjectAttachmentAsync(RuntimeProjectAttachmentName name, st::CancellationToken cancellationToken) =>
            GetRuntimeProjectAttachmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List runtime projects attached to the host project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RuntimeProjectAttachment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRuntimeProjectAttachmentsResponse, RuntimeProjectAttachment> ListRuntimeProjectAttachments(ListRuntimeProjectAttachmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List runtime projects attached to the host project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RuntimeProjectAttachment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRuntimeProjectAttachmentsResponse, RuntimeProjectAttachment> ListRuntimeProjectAttachmentsAsync(ListRuntimeProjectAttachmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List runtime projects attached to the host project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of runtime project
        /// attachments. Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="RuntimeProjectAttachment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRuntimeProjectAttachmentsResponse, RuntimeProjectAttachment> ListRuntimeProjectAttachments(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRuntimeProjectAttachmentsRequest request = new ListRuntimeProjectAttachmentsRequest
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
            return ListRuntimeProjectAttachments(request, callSettings);
        }

        /// <summary>
        /// List runtime projects attached to the host project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of runtime project
        /// attachments. Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="RuntimeProjectAttachment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRuntimeProjectAttachmentsResponse, RuntimeProjectAttachment> ListRuntimeProjectAttachmentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRuntimeProjectAttachmentsRequest request = new ListRuntimeProjectAttachmentsRequest
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
            return ListRuntimeProjectAttachmentsAsync(request, callSettings);
        }

        /// <summary>
        /// List runtime projects attached to the host project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of runtime project
        /// attachments. Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="RuntimeProjectAttachment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRuntimeProjectAttachmentsResponse, RuntimeProjectAttachment> ListRuntimeProjectAttachments(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRuntimeProjectAttachmentsRequest request = new ListRuntimeProjectAttachmentsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListRuntimeProjectAttachments(request, callSettings);
        }

        /// <summary>
        /// List runtime projects attached to the host project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of runtime project
        /// attachments. Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="RuntimeProjectAttachment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRuntimeProjectAttachmentsResponse, RuntimeProjectAttachment> ListRuntimeProjectAttachmentsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRuntimeProjectAttachmentsRequest request = new ListRuntimeProjectAttachmentsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListRuntimeProjectAttachmentsAsync(request, callSettings);
        }

        /// <summary>
        /// Delete a runtime project attachment in the API Hub. This call will detach
        /// the runtime project from the host project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteRuntimeProjectAttachment(DeleteRuntimeProjectAttachmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a runtime project attachment in the API Hub. This call will detach
        /// the runtime project from the host project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRuntimeProjectAttachmentAsync(DeleteRuntimeProjectAttachmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a runtime project attachment in the API Hub. This call will detach
        /// the runtime project from the host project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRuntimeProjectAttachmentAsync(DeleteRuntimeProjectAttachmentRequest request, st::CancellationToken cancellationToken) =>
            DeleteRuntimeProjectAttachmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a runtime project attachment in the API Hub. This call will detach
        /// the runtime project from the host project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Runtime Project Attachment to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/runtimeProjectAttachments/{runtime_project_attachment}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteRuntimeProjectAttachment(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRuntimeProjectAttachment(new DeleteRuntimeProjectAttachmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a runtime project attachment in the API Hub. This call will detach
        /// the runtime project from the host project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Runtime Project Attachment to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/runtimeProjectAttachments/{runtime_project_attachment}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRuntimeProjectAttachmentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRuntimeProjectAttachmentAsync(new DeleteRuntimeProjectAttachmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a runtime project attachment in the API Hub. This call will detach
        /// the runtime project from the host project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Runtime Project Attachment to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/runtimeProjectAttachments/{runtime_project_attachment}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRuntimeProjectAttachmentAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteRuntimeProjectAttachmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a runtime project attachment in the API Hub. This call will detach
        /// the runtime project from the host project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Runtime Project Attachment to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/runtimeProjectAttachments/{runtime_project_attachment}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteRuntimeProjectAttachment(RuntimeProjectAttachmentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRuntimeProjectAttachment(new DeleteRuntimeProjectAttachmentRequest
            {
                RuntimeProjectAttachmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a runtime project attachment in the API Hub. This call will detach
        /// the runtime project from the host project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Runtime Project Attachment to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/runtimeProjectAttachments/{runtime_project_attachment}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRuntimeProjectAttachmentAsync(RuntimeProjectAttachmentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRuntimeProjectAttachmentAsync(new DeleteRuntimeProjectAttachmentRequest
            {
                RuntimeProjectAttachmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a runtime project attachment in the API Hub. This call will detach
        /// the runtime project from the host project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Runtime Project Attachment to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/runtimeProjectAttachments/{runtime_project_attachment}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRuntimeProjectAttachmentAsync(RuntimeProjectAttachmentName name, st::CancellationToken cancellationToken) =>
            DeleteRuntimeProjectAttachmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Look up a runtime project attachment. This API can be called in the context
        /// of any project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LookupRuntimeProjectAttachmentResponse LookupRuntimeProjectAttachment(LookupRuntimeProjectAttachmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Look up a runtime project attachment. This API can be called in the context
        /// of any project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LookupRuntimeProjectAttachmentResponse> LookupRuntimeProjectAttachmentAsync(LookupRuntimeProjectAttachmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Look up a runtime project attachment. This API can be called in the context
        /// of any project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LookupRuntimeProjectAttachmentResponse> LookupRuntimeProjectAttachmentAsync(LookupRuntimeProjectAttachmentRequest request, st::CancellationToken cancellationToken) =>
            LookupRuntimeProjectAttachmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Look up a runtime project attachment. This API can be called in the context
        /// of any project.
        /// </summary>
        /// <param name="name">
        /// Required. Runtime project ID to look up runtime project attachment for.
        /// Lookup happens across all regions. Expected format:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LookupRuntimeProjectAttachmentResponse LookupRuntimeProjectAttachment(string name, gaxgrpc::CallSettings callSettings = null) =>
            LookupRuntimeProjectAttachment(new LookupRuntimeProjectAttachmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Look up a runtime project attachment. This API can be called in the context
        /// of any project.
        /// </summary>
        /// <param name="name">
        /// Required. Runtime project ID to look up runtime project attachment for.
        /// Lookup happens across all regions. Expected format:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LookupRuntimeProjectAttachmentResponse> LookupRuntimeProjectAttachmentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            LookupRuntimeProjectAttachmentAsync(new LookupRuntimeProjectAttachmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Look up a runtime project attachment. This API can be called in the context
        /// of any project.
        /// </summary>
        /// <param name="name">
        /// Required. Runtime project ID to look up runtime project attachment for.
        /// Lookup happens across all regions. Expected format:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LookupRuntimeProjectAttachmentResponse> LookupRuntimeProjectAttachmentAsync(string name, st::CancellationToken cancellationToken) =>
            LookupRuntimeProjectAttachmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Look up a runtime project attachment. This API can be called in the context
        /// of any project.
        /// </summary>
        /// <param name="name">
        /// Required. Runtime project ID to look up runtime project attachment for.
        /// Lookup happens across all regions. Expected format:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LookupRuntimeProjectAttachmentResponse LookupRuntimeProjectAttachment(gagr::LocationName name, gaxgrpc::CallSettings callSettings = null) =>
            LookupRuntimeProjectAttachment(new LookupRuntimeProjectAttachmentRequest
            {
                LocationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Look up a runtime project attachment. This API can be called in the context
        /// of any project.
        /// </summary>
        /// <param name="name">
        /// Required. Runtime project ID to look up runtime project attachment for.
        /// Lookup happens across all regions. Expected format:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LookupRuntimeProjectAttachmentResponse> LookupRuntimeProjectAttachmentAsync(gagr::LocationName name, gaxgrpc::CallSettings callSettings = null) =>
            LookupRuntimeProjectAttachmentAsync(new LookupRuntimeProjectAttachmentRequest
            {
                LocationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Look up a runtime project attachment. This API can be called in the context
        /// of any project.
        /// </summary>
        /// <param name="name">
        /// Required. Runtime project ID to look up runtime project attachment for.
        /// Lookup happens across all regions. Expected format:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LookupRuntimeProjectAttachmentResponse> LookupRuntimeProjectAttachmentAsync(gagr::LocationName name, st::CancellationToken cancellationToken) =>
            LookupRuntimeProjectAttachmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>RuntimeProjectAttachmentService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// This service is used for managing the runtime project attachments.
    /// </remarks>
    public sealed partial class RuntimeProjectAttachmentServiceClientImpl : RuntimeProjectAttachmentServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateRuntimeProjectAttachmentRequest, RuntimeProjectAttachment> _callCreateRuntimeProjectAttachment;

        private readonly gaxgrpc::ApiCall<GetRuntimeProjectAttachmentRequest, RuntimeProjectAttachment> _callGetRuntimeProjectAttachment;

        private readonly gaxgrpc::ApiCall<ListRuntimeProjectAttachmentsRequest, ListRuntimeProjectAttachmentsResponse> _callListRuntimeProjectAttachments;

        private readonly gaxgrpc::ApiCall<DeleteRuntimeProjectAttachmentRequest, wkt::Empty> _callDeleteRuntimeProjectAttachment;

        private readonly gaxgrpc::ApiCall<LookupRuntimeProjectAttachmentRequest, LookupRuntimeProjectAttachmentResponse> _callLookupRuntimeProjectAttachment;

        /// <summary>
        /// Constructs a client wrapper for the RuntimeProjectAttachmentService service, with the specified gRPC client
        /// and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="RuntimeProjectAttachmentServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public RuntimeProjectAttachmentServiceClientImpl(RuntimeProjectAttachmentService.RuntimeProjectAttachmentServiceClient grpcClient, RuntimeProjectAttachmentServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            RuntimeProjectAttachmentServiceSettings effectiveSettings = settings ?? RuntimeProjectAttachmentServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callCreateRuntimeProjectAttachment = clientHelper.BuildApiCall<CreateRuntimeProjectAttachmentRequest, RuntimeProjectAttachment>("CreateRuntimeProjectAttachment", grpcClient.CreateRuntimeProjectAttachmentAsync, grpcClient.CreateRuntimeProjectAttachment, effectiveSettings.CreateRuntimeProjectAttachmentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateRuntimeProjectAttachment);
            Modify_CreateRuntimeProjectAttachmentApiCall(ref _callCreateRuntimeProjectAttachment);
            _callGetRuntimeProjectAttachment = clientHelper.BuildApiCall<GetRuntimeProjectAttachmentRequest, RuntimeProjectAttachment>("GetRuntimeProjectAttachment", grpcClient.GetRuntimeProjectAttachmentAsync, grpcClient.GetRuntimeProjectAttachment, effectiveSettings.GetRuntimeProjectAttachmentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetRuntimeProjectAttachment);
            Modify_GetRuntimeProjectAttachmentApiCall(ref _callGetRuntimeProjectAttachment);
            _callListRuntimeProjectAttachments = clientHelper.BuildApiCall<ListRuntimeProjectAttachmentsRequest, ListRuntimeProjectAttachmentsResponse>("ListRuntimeProjectAttachments", grpcClient.ListRuntimeProjectAttachmentsAsync, grpcClient.ListRuntimeProjectAttachments, effectiveSettings.ListRuntimeProjectAttachmentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListRuntimeProjectAttachments);
            Modify_ListRuntimeProjectAttachmentsApiCall(ref _callListRuntimeProjectAttachments);
            _callDeleteRuntimeProjectAttachment = clientHelper.BuildApiCall<DeleteRuntimeProjectAttachmentRequest, wkt::Empty>("DeleteRuntimeProjectAttachment", grpcClient.DeleteRuntimeProjectAttachmentAsync, grpcClient.DeleteRuntimeProjectAttachment, effectiveSettings.DeleteRuntimeProjectAttachmentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteRuntimeProjectAttachment);
            Modify_DeleteRuntimeProjectAttachmentApiCall(ref _callDeleteRuntimeProjectAttachment);
            _callLookupRuntimeProjectAttachment = clientHelper.BuildApiCall<LookupRuntimeProjectAttachmentRequest, LookupRuntimeProjectAttachmentResponse>("LookupRuntimeProjectAttachment", grpcClient.LookupRuntimeProjectAttachmentAsync, grpcClient.LookupRuntimeProjectAttachment, effectiveSettings.LookupRuntimeProjectAttachmentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callLookupRuntimeProjectAttachment);
            Modify_LookupRuntimeProjectAttachmentApiCall(ref _callLookupRuntimeProjectAttachment);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateRuntimeProjectAttachmentApiCall(ref gaxgrpc::ApiCall<CreateRuntimeProjectAttachmentRequest, RuntimeProjectAttachment> call);

        partial void Modify_GetRuntimeProjectAttachmentApiCall(ref gaxgrpc::ApiCall<GetRuntimeProjectAttachmentRequest, RuntimeProjectAttachment> call);

        partial void Modify_ListRuntimeProjectAttachmentsApiCall(ref gaxgrpc::ApiCall<ListRuntimeProjectAttachmentsRequest, ListRuntimeProjectAttachmentsResponse> call);

        partial void Modify_DeleteRuntimeProjectAttachmentApiCall(ref gaxgrpc::ApiCall<DeleteRuntimeProjectAttachmentRequest, wkt::Empty> call);

        partial void Modify_LookupRuntimeProjectAttachmentApiCall(ref gaxgrpc::ApiCall<LookupRuntimeProjectAttachmentRequest, LookupRuntimeProjectAttachmentResponse> call);

        partial void OnConstruction(RuntimeProjectAttachmentService.RuntimeProjectAttachmentServiceClient grpcClient, RuntimeProjectAttachmentServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC RuntimeProjectAttachmentService client</summary>
        public override RuntimeProjectAttachmentService.RuntimeProjectAttachmentServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_CreateRuntimeProjectAttachmentRequest(ref CreateRuntimeProjectAttachmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRuntimeProjectAttachmentRequest(ref GetRuntimeProjectAttachmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRuntimeProjectAttachmentsRequest(ref ListRuntimeProjectAttachmentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteRuntimeProjectAttachmentRequest(ref DeleteRuntimeProjectAttachmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_LookupRuntimeProjectAttachmentRequest(ref LookupRuntimeProjectAttachmentRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Attaches a runtime project to the host project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RuntimeProjectAttachment CreateRuntimeProjectAttachment(CreateRuntimeProjectAttachmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateRuntimeProjectAttachmentRequest(ref request, ref callSettings);
            return _callCreateRuntimeProjectAttachment.Sync(request, callSettings);
        }

        /// <summary>
        /// Attaches a runtime project to the host project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RuntimeProjectAttachment> CreateRuntimeProjectAttachmentAsync(CreateRuntimeProjectAttachmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateRuntimeProjectAttachmentRequest(ref request, ref callSettings);
            return _callCreateRuntimeProjectAttachment.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a runtime project attachment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RuntimeProjectAttachment GetRuntimeProjectAttachment(GetRuntimeProjectAttachmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRuntimeProjectAttachmentRequest(ref request, ref callSettings);
            return _callGetRuntimeProjectAttachment.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a runtime project attachment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RuntimeProjectAttachment> GetRuntimeProjectAttachmentAsync(GetRuntimeProjectAttachmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRuntimeProjectAttachmentRequest(ref request, ref callSettings);
            return _callGetRuntimeProjectAttachment.Async(request, callSettings);
        }

        /// <summary>
        /// List runtime projects attached to the host project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RuntimeProjectAttachment"/> resources.</returns>
        public override gax::PagedEnumerable<ListRuntimeProjectAttachmentsResponse, RuntimeProjectAttachment> ListRuntimeProjectAttachments(ListRuntimeProjectAttachmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRuntimeProjectAttachmentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRuntimeProjectAttachmentsRequest, ListRuntimeProjectAttachmentsResponse, RuntimeProjectAttachment>(_callListRuntimeProjectAttachments, request, callSettings);
        }

        /// <summary>
        /// List runtime projects attached to the host project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RuntimeProjectAttachment"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListRuntimeProjectAttachmentsResponse, RuntimeProjectAttachment> ListRuntimeProjectAttachmentsAsync(ListRuntimeProjectAttachmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRuntimeProjectAttachmentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRuntimeProjectAttachmentsRequest, ListRuntimeProjectAttachmentsResponse, RuntimeProjectAttachment>(_callListRuntimeProjectAttachments, request, callSettings);
        }

        /// <summary>
        /// Delete a runtime project attachment in the API Hub. This call will detach
        /// the runtime project from the host project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteRuntimeProjectAttachment(DeleteRuntimeProjectAttachmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRuntimeProjectAttachmentRequest(ref request, ref callSettings);
            _callDeleteRuntimeProjectAttachment.Sync(request, callSettings);
        }

        /// <summary>
        /// Delete a runtime project attachment in the API Hub. This call will detach
        /// the runtime project from the host project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteRuntimeProjectAttachmentAsync(DeleteRuntimeProjectAttachmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRuntimeProjectAttachmentRequest(ref request, ref callSettings);
            return _callDeleteRuntimeProjectAttachment.Async(request, callSettings);
        }

        /// <summary>
        /// Look up a runtime project attachment. This API can be called in the context
        /// of any project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LookupRuntimeProjectAttachmentResponse LookupRuntimeProjectAttachment(LookupRuntimeProjectAttachmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LookupRuntimeProjectAttachmentRequest(ref request, ref callSettings);
            return _callLookupRuntimeProjectAttachment.Sync(request, callSettings);
        }

        /// <summary>
        /// Look up a runtime project attachment. This API can be called in the context
        /// of any project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LookupRuntimeProjectAttachmentResponse> LookupRuntimeProjectAttachmentAsync(LookupRuntimeProjectAttachmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LookupRuntimeProjectAttachmentRequest(ref request, ref callSettings);
            return _callLookupRuntimeProjectAttachment.Async(request, callSettings);
        }
    }

    public partial class ListRuntimeProjectAttachmentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListRuntimeProjectAttachmentsResponse : gaxgrpc::IPageResponse<RuntimeProjectAttachment>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<RuntimeProjectAttachment> GetEnumerator() => RuntimeProjectAttachments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class RuntimeProjectAttachmentService
    {
        public partial class RuntimeProjectAttachmentServiceClient
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
        }
    }
}
