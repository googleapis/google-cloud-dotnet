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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gciv = Google.Cloud.Iam.V1;
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

namespace Google.Cloud.Dataproc.V1
{
    /// <summary>Settings for <see cref="SessionTemplateControllerClient"/> instances.</summary>
    public sealed partial class SessionTemplateControllerSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SessionTemplateControllerSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SessionTemplateControllerSettings"/>.</returns>
        public static SessionTemplateControllerSettings GetDefault() => new SessionTemplateControllerSettings();

        /// <summary>
        /// Constructs a new <see cref="SessionTemplateControllerSettings"/> object with default settings.
        /// </summary>
        public SessionTemplateControllerSettings()
        {
        }

        private SessionTemplateControllerSettings(SessionTemplateControllerSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateSessionTemplateSettings = existing.CreateSessionTemplateSettings;
            UpdateSessionTemplateSettings = existing.UpdateSessionTemplateSettings;
            GetSessionTemplateSettings = existing.GetSessionTemplateSettings;
            ListSessionTemplatesSettings = existing.ListSessionTemplatesSettings;
            DeleteSessionTemplateSettings = existing.DeleteSessionTemplateSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(SessionTemplateControllerSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SessionTemplateControllerClient.CreateSessionTemplate</c> and
        /// <c>SessionTemplateControllerClient.CreateSessionTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSessionTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SessionTemplateControllerClient.UpdateSessionTemplate</c> and
        /// <c>SessionTemplateControllerClient.UpdateSessionTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSessionTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SessionTemplateControllerClient.GetSessionTemplate</c> and
        /// <c>SessionTemplateControllerClient.GetSessionTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSessionTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SessionTemplateControllerClient.ListSessionTemplates</c> and
        /// <c>SessionTemplateControllerClient.ListSessionTemplatesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSessionTemplatesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SessionTemplateControllerClient.DeleteSessionTemplate</c> and
        /// <c>SessionTemplateControllerClient.DeleteSessionTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSessionTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SessionTemplateControllerSettings"/> object.</returns>
        public SessionTemplateControllerSettings Clone() => new SessionTemplateControllerSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SessionTemplateControllerClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class SessionTemplateControllerClientBuilder : gaxgrpc::ClientBuilderBase<SessionTemplateControllerClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SessionTemplateControllerSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SessionTemplateControllerClientBuilder() : base(SessionTemplateControllerClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref SessionTemplateControllerClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SessionTemplateControllerClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SessionTemplateControllerClient Build()
        {
            SessionTemplateControllerClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SessionTemplateControllerClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SessionTemplateControllerClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SessionTemplateControllerClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SessionTemplateControllerClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<SessionTemplateControllerClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SessionTemplateControllerClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SessionTemplateControllerClient.ChannelPool;
    }

    /// <summary>SessionTemplateController client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The SessionTemplateController provides methods to manage session templates.
    /// </remarks>
    public abstract partial class SessionTemplateControllerClient
    {
        /// <summary>
        /// The default endpoint for the SessionTemplateController service, which is a host of "dataproc.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dataproc.googleapis.com:443";

        /// <summary>The default SessionTemplateController scopes.</summary>
        /// <remarks>
        /// The default SessionTemplateController scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(SessionTemplateController.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="SessionTemplateControllerClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="SessionTemplateControllerClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SessionTemplateControllerClient"/>.</returns>
        public static stt::Task<SessionTemplateControllerClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SessionTemplateControllerClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SessionTemplateControllerClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="SessionTemplateControllerClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SessionTemplateControllerClient"/>.</returns>
        public static SessionTemplateControllerClient Create() => new SessionTemplateControllerClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SessionTemplateControllerClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SessionTemplateControllerSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="SessionTemplateControllerClient"/>.</returns>
        internal static SessionTemplateControllerClient Create(grpccore::CallInvoker callInvoker, SessionTemplateControllerSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SessionTemplateController.SessionTemplateControllerClient grpcClient = new SessionTemplateController.SessionTemplateControllerClient(callInvoker);
            return new SessionTemplateControllerClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC SessionTemplateController client</summary>
        public virtual SessionTemplateController.SessionTemplateControllerClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Create a session template synchronously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SessionTemplate CreateSessionTemplate(CreateSessionTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a session template synchronously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SessionTemplate> CreateSessionTemplateAsync(CreateSessionTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a session template synchronously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SessionTemplate> CreateSessionTemplateAsync(CreateSessionTemplateRequest request, st::CancellationToken cancellationToken) =>
            CreateSessionTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a session template synchronously.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this session template will be created.
        /// </param>
        /// <param name="sessionTemplate">
        /// Required. The session template to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SessionTemplate CreateSessionTemplate(string parent, SessionTemplate sessionTemplate, gaxgrpc::CallSettings callSettings = null) =>
            CreateSessionTemplate(new CreateSessionTemplateRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SessionTemplate = gax::GaxPreconditions.CheckNotNull(sessionTemplate, nameof(sessionTemplate)),
            }, callSettings);

        /// <summary>
        /// Create a session template synchronously.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this session template will be created.
        /// </param>
        /// <param name="sessionTemplate">
        /// Required. The session template to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SessionTemplate> CreateSessionTemplateAsync(string parent, SessionTemplate sessionTemplate, gaxgrpc::CallSettings callSettings = null) =>
            CreateSessionTemplateAsync(new CreateSessionTemplateRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SessionTemplate = gax::GaxPreconditions.CheckNotNull(sessionTemplate, nameof(sessionTemplate)),
            }, callSettings);

        /// <summary>
        /// Create a session template synchronously.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this session template will be created.
        /// </param>
        /// <param name="sessionTemplate">
        /// Required. The session template to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SessionTemplate> CreateSessionTemplateAsync(string parent, SessionTemplate sessionTemplate, st::CancellationToken cancellationToken) =>
            CreateSessionTemplateAsync(parent, sessionTemplate, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a session template synchronously.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this session template will be created.
        /// </param>
        /// <param name="sessionTemplate">
        /// Required. The session template to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SessionTemplate CreateSessionTemplate(gagr::LocationName parent, SessionTemplate sessionTemplate, gaxgrpc::CallSettings callSettings = null) =>
            CreateSessionTemplate(new CreateSessionTemplateRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SessionTemplate = gax::GaxPreconditions.CheckNotNull(sessionTemplate, nameof(sessionTemplate)),
            }, callSettings);

        /// <summary>
        /// Create a session template synchronously.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this session template will be created.
        /// </param>
        /// <param name="sessionTemplate">
        /// Required. The session template to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SessionTemplate> CreateSessionTemplateAsync(gagr::LocationName parent, SessionTemplate sessionTemplate, gaxgrpc::CallSettings callSettings = null) =>
            CreateSessionTemplateAsync(new CreateSessionTemplateRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SessionTemplate = gax::GaxPreconditions.CheckNotNull(sessionTemplate, nameof(sessionTemplate)),
            }, callSettings);

        /// <summary>
        /// Create a session template synchronously.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this session template will be created.
        /// </param>
        /// <param name="sessionTemplate">
        /// Required. The session template to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SessionTemplate> CreateSessionTemplateAsync(gagr::LocationName parent, SessionTemplate sessionTemplate, st::CancellationToken cancellationToken) =>
            CreateSessionTemplateAsync(parent, sessionTemplate, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the session template synchronously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SessionTemplate UpdateSessionTemplate(UpdateSessionTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the session template synchronously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SessionTemplate> UpdateSessionTemplateAsync(UpdateSessionTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the session template synchronously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SessionTemplate> UpdateSessionTemplateAsync(UpdateSessionTemplateRequest request, st::CancellationToken cancellationToken) =>
            UpdateSessionTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the session template synchronously.
        /// </summary>
        /// <param name="sessionTemplate">
        /// Required. The updated session template.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SessionTemplate UpdateSessionTemplate(SessionTemplate sessionTemplate, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSessionTemplate(new UpdateSessionTemplateRequest
            {
                SessionTemplate = gax::GaxPreconditions.CheckNotNull(sessionTemplate, nameof(sessionTemplate)),
            }, callSettings);

        /// <summary>
        /// Updates the session template synchronously.
        /// </summary>
        /// <param name="sessionTemplate">
        /// Required. The updated session template.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SessionTemplate> UpdateSessionTemplateAsync(SessionTemplate sessionTemplate, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSessionTemplateAsync(new UpdateSessionTemplateRequest
            {
                SessionTemplate = gax::GaxPreconditions.CheckNotNull(sessionTemplate, nameof(sessionTemplate)),
            }, callSettings);

        /// <summary>
        /// Updates the session template synchronously.
        /// </summary>
        /// <param name="sessionTemplate">
        /// Required. The updated session template.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SessionTemplate> UpdateSessionTemplateAsync(SessionTemplate sessionTemplate, st::CancellationToken cancellationToken) =>
            UpdateSessionTemplateAsync(sessionTemplate, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the resource representation for a session template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SessionTemplate GetSessionTemplate(GetSessionTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the resource representation for a session template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SessionTemplate> GetSessionTemplateAsync(GetSessionTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the resource representation for a session template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SessionTemplate> GetSessionTemplateAsync(GetSessionTemplateRequest request, st::CancellationToken cancellationToken) =>
            GetSessionTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the resource representation for a session template.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session template to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SessionTemplate GetSessionTemplate(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSessionTemplate(new GetSessionTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the resource representation for a session template.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session template to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SessionTemplate> GetSessionTemplateAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSessionTemplateAsync(new GetSessionTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the resource representation for a session template.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session template to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SessionTemplate> GetSessionTemplateAsync(string name, st::CancellationToken cancellationToken) =>
            GetSessionTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the resource representation for a session template.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session template to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SessionTemplate GetSessionTemplate(SessionTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSessionTemplate(new GetSessionTemplateRequest
            {
                SessionTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the resource representation for a session template.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session template to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SessionTemplate> GetSessionTemplateAsync(SessionTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSessionTemplateAsync(new GetSessionTemplateRequest
            {
                SessionTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the resource representation for a session template.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session template to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SessionTemplate> GetSessionTemplateAsync(SessionTemplateName name, st::CancellationToken cancellationToken) =>
            GetSessionTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists session templates.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SessionTemplate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSessionTemplatesResponse, SessionTemplate> ListSessionTemplates(ListSessionTemplatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists session templates.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SessionTemplate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSessionTemplatesResponse, SessionTemplate> ListSessionTemplatesAsync(ListSessionTemplatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists session templates.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns this collection of session templates.
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
        /// <returns>A pageable sequence of <see cref="SessionTemplate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSessionTemplatesResponse, SessionTemplate> ListSessionTemplates(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSessionTemplatesRequest request = new ListSessionTemplatesRequest
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
            return ListSessionTemplates(request, callSettings);
        }

        /// <summary>
        /// Lists session templates.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns this collection of session templates.
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
        /// <returns>A pageable asynchronous sequence of <see cref="SessionTemplate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSessionTemplatesResponse, SessionTemplate> ListSessionTemplatesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSessionTemplatesRequest request = new ListSessionTemplatesRequest
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
            return ListSessionTemplatesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists session templates.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns this collection of session templates.
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
        /// <returns>A pageable sequence of <see cref="SessionTemplate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSessionTemplatesResponse, SessionTemplate> ListSessionTemplates(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSessionTemplatesRequest request = new ListSessionTemplatesRequest
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
            return ListSessionTemplates(request, callSettings);
        }

        /// <summary>
        /// Lists session templates.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns this collection of session templates.
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
        /// <returns>A pageable asynchronous sequence of <see cref="SessionTemplate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSessionTemplatesResponse, SessionTemplate> ListSessionTemplatesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSessionTemplatesRequest request = new ListSessionTemplatesRequest
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
            return ListSessionTemplatesAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes a session template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSessionTemplate(DeleteSessionTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a session template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSessionTemplateAsync(DeleteSessionTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a session template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSessionTemplateAsync(DeleteSessionTemplateRequest request, st::CancellationToken cancellationToken) =>
            DeleteSessionTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a session template.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session template resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSessionTemplate(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSessionTemplate(new DeleteSessionTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a session template.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session template resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSessionTemplateAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSessionTemplateAsync(new DeleteSessionTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a session template.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session template resource to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSessionTemplateAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteSessionTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a session template.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session template resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSessionTemplate(SessionTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSessionTemplate(new DeleteSessionTemplateRequest
            {
                SessionTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a session template.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session template resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSessionTemplateAsync(SessionTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSessionTemplateAsync(new DeleteSessionTemplateRequest
            {
                SessionTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a session template.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the session template resource to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSessionTemplateAsync(SessionTemplateName name, st::CancellationToken cancellationToken) =>
            DeleteSessionTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>SessionTemplateController client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The SessionTemplateController provides methods to manage session templates.
    /// </remarks>
    public sealed partial class SessionTemplateControllerClientImpl : SessionTemplateControllerClient
    {
        private readonly gaxgrpc::ApiCall<CreateSessionTemplateRequest, SessionTemplate> _callCreateSessionTemplate;

        private readonly gaxgrpc::ApiCall<UpdateSessionTemplateRequest, SessionTemplate> _callUpdateSessionTemplate;

        private readonly gaxgrpc::ApiCall<GetSessionTemplateRequest, SessionTemplate> _callGetSessionTemplate;

        private readonly gaxgrpc::ApiCall<ListSessionTemplatesRequest, ListSessionTemplatesResponse> _callListSessionTemplates;

        private readonly gaxgrpc::ApiCall<DeleteSessionTemplateRequest, wkt::Empty> _callDeleteSessionTemplate;

        /// <summary>
        /// Constructs a client wrapper for the SessionTemplateController service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="SessionTemplateControllerSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public SessionTemplateControllerClientImpl(SessionTemplateController.SessionTemplateControllerClient grpcClient, SessionTemplateControllerSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            SessionTemplateControllerSettings effectiveSettings = settings ?? SessionTemplateControllerSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callCreateSessionTemplate = clientHelper.BuildApiCall<CreateSessionTemplateRequest, SessionTemplate>("CreateSessionTemplate", grpcClient.CreateSessionTemplateAsync, grpcClient.CreateSessionTemplate, effectiveSettings.CreateSessionTemplateSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSessionTemplate);
            Modify_CreateSessionTemplateApiCall(ref _callCreateSessionTemplate);
            _callUpdateSessionTemplate = clientHelper.BuildApiCall<UpdateSessionTemplateRequest, SessionTemplate>("UpdateSessionTemplate", grpcClient.UpdateSessionTemplateAsync, grpcClient.UpdateSessionTemplate, effectiveSettings.UpdateSessionTemplateSettings).WithGoogleRequestParam("session_template.name", request => request.SessionTemplate?.Name);
            Modify_ApiCall(ref _callUpdateSessionTemplate);
            Modify_UpdateSessionTemplateApiCall(ref _callUpdateSessionTemplate);
            _callGetSessionTemplate = clientHelper.BuildApiCall<GetSessionTemplateRequest, SessionTemplate>("GetSessionTemplate", grpcClient.GetSessionTemplateAsync, grpcClient.GetSessionTemplate, effectiveSettings.GetSessionTemplateSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSessionTemplate);
            Modify_GetSessionTemplateApiCall(ref _callGetSessionTemplate);
            _callListSessionTemplates = clientHelper.BuildApiCall<ListSessionTemplatesRequest, ListSessionTemplatesResponse>("ListSessionTemplates", grpcClient.ListSessionTemplatesAsync, grpcClient.ListSessionTemplates, effectiveSettings.ListSessionTemplatesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSessionTemplates);
            Modify_ListSessionTemplatesApiCall(ref _callListSessionTemplates);
            _callDeleteSessionTemplate = clientHelper.BuildApiCall<DeleteSessionTemplateRequest, wkt::Empty>("DeleteSessionTemplate", grpcClient.DeleteSessionTemplateAsync, grpcClient.DeleteSessionTemplate, effectiveSettings.DeleteSessionTemplateSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteSessionTemplate);
            Modify_DeleteSessionTemplateApiCall(ref _callDeleteSessionTemplate);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateSessionTemplateApiCall(ref gaxgrpc::ApiCall<CreateSessionTemplateRequest, SessionTemplate> call);

        partial void Modify_UpdateSessionTemplateApiCall(ref gaxgrpc::ApiCall<UpdateSessionTemplateRequest, SessionTemplate> call);

        partial void Modify_GetSessionTemplateApiCall(ref gaxgrpc::ApiCall<GetSessionTemplateRequest, SessionTemplate> call);

        partial void Modify_ListSessionTemplatesApiCall(ref gaxgrpc::ApiCall<ListSessionTemplatesRequest, ListSessionTemplatesResponse> call);

        partial void Modify_DeleteSessionTemplateApiCall(ref gaxgrpc::ApiCall<DeleteSessionTemplateRequest, wkt::Empty> call);

        partial void OnConstruction(SessionTemplateController.SessionTemplateControllerClient grpcClient, SessionTemplateControllerSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SessionTemplateController client</summary>
        public override SessionTemplateController.SessionTemplateControllerClient GrpcClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_CreateSessionTemplateRequest(ref CreateSessionTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSessionTemplateRequest(ref UpdateSessionTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSessionTemplateRequest(ref GetSessionTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSessionTemplatesRequest(ref ListSessionTemplatesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSessionTemplateRequest(ref DeleteSessionTemplateRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Create a session template synchronously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SessionTemplate CreateSessionTemplate(CreateSessionTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSessionTemplateRequest(ref request, ref callSettings);
            return _callCreateSessionTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Create a session template synchronously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SessionTemplate> CreateSessionTemplateAsync(CreateSessionTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSessionTemplateRequest(ref request, ref callSettings);
            return _callCreateSessionTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the session template synchronously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SessionTemplate UpdateSessionTemplate(UpdateSessionTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSessionTemplateRequest(ref request, ref callSettings);
            return _callUpdateSessionTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the session template synchronously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SessionTemplate> UpdateSessionTemplateAsync(UpdateSessionTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSessionTemplateRequest(ref request, ref callSettings);
            return _callUpdateSessionTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the resource representation for a session template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SessionTemplate GetSessionTemplate(GetSessionTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSessionTemplateRequest(ref request, ref callSettings);
            return _callGetSessionTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the resource representation for a session template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SessionTemplate> GetSessionTemplateAsync(GetSessionTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSessionTemplateRequest(ref request, ref callSettings);
            return _callGetSessionTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Lists session templates.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SessionTemplate"/> resources.</returns>
        public override gax::PagedEnumerable<ListSessionTemplatesResponse, SessionTemplate> ListSessionTemplates(ListSessionTemplatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSessionTemplatesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSessionTemplatesRequest, ListSessionTemplatesResponse, SessionTemplate>(_callListSessionTemplates, request, callSettings);
        }

        /// <summary>
        /// Lists session templates.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SessionTemplate"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSessionTemplatesResponse, SessionTemplate> ListSessionTemplatesAsync(ListSessionTemplatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSessionTemplatesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSessionTemplatesRequest, ListSessionTemplatesResponse, SessionTemplate>(_callListSessionTemplates, request, callSettings);
        }

        /// <summary>
        /// Deletes a session template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteSessionTemplate(DeleteSessionTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSessionTemplateRequest(ref request, ref callSettings);
            _callDeleteSessionTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a session template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteSessionTemplateAsync(DeleteSessionTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSessionTemplateRequest(ref request, ref callSettings);
            return _callDeleteSessionTemplate.Async(request, callSettings);
        }
    }

    public partial class ListSessionTemplatesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSessionTemplatesResponse : gaxgrpc::IPageResponse<SessionTemplate>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<SessionTemplate> GetEnumerator() => SessionTemplates.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class SessionTemplateController
    {
        public partial class SessionTemplateControllerClient
        {
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
