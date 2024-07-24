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

namespace Google.Cloud.EssentialContacts.V1
{
    /// <summary>Settings for <see cref="EssentialContactsServiceClient"/> instances.</summary>
    public sealed partial class EssentialContactsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="EssentialContactsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="EssentialContactsServiceSettings"/>.</returns>
        public static EssentialContactsServiceSettings GetDefault() => new EssentialContactsServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="EssentialContactsServiceSettings"/> object with default settings.
        /// </summary>
        public EssentialContactsServiceSettings()
        {
        }

        private EssentialContactsServiceSettings(EssentialContactsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateContactSettings = existing.CreateContactSettings;
            UpdateContactSettings = existing.UpdateContactSettings;
            ListContactsSettings = existing.ListContactsSettings;
            GetContactSettings = existing.GetContactSettings;
            DeleteContactSettings = existing.DeleteContactSettings;
            ComputeContactsSettings = existing.ComputeContactsSettings;
            SendTestMessageSettings = existing.SendTestMessageSettings;
            OnCopy(existing);
        }

        partial void OnCopy(EssentialContactsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EssentialContactsServiceClient.CreateContact</c> and <c>EssentialContactsServiceClient.CreateContactAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateContactSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EssentialContactsServiceClient.UpdateContact</c> and <c>EssentialContactsServiceClient.UpdateContactAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateContactSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EssentialContactsServiceClient.ListContacts</c> and <c>EssentialContactsServiceClient.ListContactsAsync</c>
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
        public gaxgrpc::CallSettings ListContactsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EssentialContactsServiceClient.GetContact</c> and <c>EssentialContactsServiceClient.GetContactAsync</c>.
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
        public gaxgrpc::CallSettings GetContactSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EssentialContactsServiceClient.DeleteContact</c> and <c>EssentialContactsServiceClient.DeleteContactAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteContactSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EssentialContactsServiceClient.ComputeContacts</c> and
        /// <c>EssentialContactsServiceClient.ComputeContactsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ComputeContactsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EssentialContactsServiceClient.SendTestMessage</c> and
        /// <c>EssentialContactsServiceClient.SendTestMessageAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SendTestMessageSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="EssentialContactsServiceSettings"/> object.</returns>
        public EssentialContactsServiceSettings Clone() => new EssentialContactsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="EssentialContactsServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class EssentialContactsServiceClientBuilder : gaxgrpc::ClientBuilderBase<EssentialContactsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public EssentialContactsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public EssentialContactsServiceClientBuilder() : base(EssentialContactsServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref EssentialContactsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<EssentialContactsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override EssentialContactsServiceClient Build()
        {
            EssentialContactsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<EssentialContactsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<EssentialContactsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private EssentialContactsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return EssentialContactsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<EssentialContactsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return EssentialContactsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => EssentialContactsServiceClient.ChannelPool;
    }

    /// <summary>EssentialContactsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Manages contacts for important Google Cloud notifications.
    /// </remarks>
    public abstract partial class EssentialContactsServiceClient
    {
        /// <summary>
        /// The default endpoint for the EssentialContactsService service, which is a host of
        /// "essentialcontacts.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "essentialcontacts.googleapis.com:443";

        /// <summary>The default EssentialContactsService scopes.</summary>
        /// <remarks>
        /// The default EssentialContactsService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(EssentialContactsService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="EssentialContactsServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="EssentialContactsServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="EssentialContactsServiceClient"/>.</returns>
        public static stt::Task<EssentialContactsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new EssentialContactsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="EssentialContactsServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="EssentialContactsServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="EssentialContactsServiceClient"/>.</returns>
        public static EssentialContactsServiceClient Create() => new EssentialContactsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="EssentialContactsServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="EssentialContactsServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="EssentialContactsServiceClient"/>.</returns>
        internal static EssentialContactsServiceClient Create(grpccore::CallInvoker callInvoker, EssentialContactsServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            EssentialContactsService.EssentialContactsServiceClient grpcClient = new EssentialContactsService.EssentialContactsServiceClient(callInvoker);
            return new EssentialContactsServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC EssentialContactsService client</summary>
        public virtual EssentialContactsService.EssentialContactsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Adds a new contact for a resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Contact CreateContact(CreateContactRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds a new contact for a resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Contact> CreateContactAsync(CreateContactRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds a new contact for a resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Contact> CreateContactAsync(CreateContactRequest request, st::CancellationToken cancellationToken) =>
            CreateContactAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds a new contact for a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource to save this contact for.
        /// Format: organizations/{organization_id}, folders/{folder_id} or
        /// projects/{project_id}
        /// </param>
        /// <param name="contact">
        /// Required. The contact to create. Must specify an email address and language
        /// tag.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Contact CreateContact(string parent, Contact contact, gaxgrpc::CallSettings callSettings = null) =>
            CreateContact(new CreateContactRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Contact = gax::GaxPreconditions.CheckNotNull(contact, nameof(contact)),
            }, callSettings);

        /// <summary>
        /// Adds a new contact for a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource to save this contact for.
        /// Format: organizations/{organization_id}, folders/{folder_id} or
        /// projects/{project_id}
        /// </param>
        /// <param name="contact">
        /// Required. The contact to create. Must specify an email address and language
        /// tag.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Contact> CreateContactAsync(string parent, Contact contact, gaxgrpc::CallSettings callSettings = null) =>
            CreateContactAsync(new CreateContactRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Contact = gax::GaxPreconditions.CheckNotNull(contact, nameof(contact)),
            }, callSettings);

        /// <summary>
        /// Adds a new contact for a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource to save this contact for.
        /// Format: organizations/{organization_id}, folders/{folder_id} or
        /// projects/{project_id}
        /// </param>
        /// <param name="contact">
        /// Required. The contact to create. Must specify an email address and language
        /// tag.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Contact> CreateContactAsync(string parent, Contact contact, st::CancellationToken cancellationToken) =>
            CreateContactAsync(parent, contact, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds a new contact for a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource to save this contact for.
        /// Format: organizations/{organization_id}, folders/{folder_id} or
        /// projects/{project_id}
        /// </param>
        /// <param name="contact">
        /// Required. The contact to create. Must specify an email address and language
        /// tag.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Contact CreateContact(gagr::ProjectName parent, Contact contact, gaxgrpc::CallSettings callSettings = null) =>
            CreateContact(new CreateContactRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Contact = gax::GaxPreconditions.CheckNotNull(contact, nameof(contact)),
            }, callSettings);

        /// <summary>
        /// Adds a new contact for a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource to save this contact for.
        /// Format: organizations/{organization_id}, folders/{folder_id} or
        /// projects/{project_id}
        /// </param>
        /// <param name="contact">
        /// Required. The contact to create. Must specify an email address and language
        /// tag.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Contact> CreateContactAsync(gagr::ProjectName parent, Contact contact, gaxgrpc::CallSettings callSettings = null) =>
            CreateContactAsync(new CreateContactRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Contact = gax::GaxPreconditions.CheckNotNull(contact, nameof(contact)),
            }, callSettings);

        /// <summary>
        /// Adds a new contact for a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource to save this contact for.
        /// Format: organizations/{organization_id}, folders/{folder_id} or
        /// projects/{project_id}
        /// </param>
        /// <param name="contact">
        /// Required. The contact to create. Must specify an email address and language
        /// tag.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Contact> CreateContactAsync(gagr::ProjectName parent, Contact contact, st::CancellationToken cancellationToken) =>
            CreateContactAsync(parent, contact, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds a new contact for a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource to save this contact for.
        /// Format: organizations/{organization_id}, folders/{folder_id} or
        /// projects/{project_id}
        /// </param>
        /// <param name="contact">
        /// Required. The contact to create. Must specify an email address and language
        /// tag.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Contact CreateContact(gagr::FolderName parent, Contact contact, gaxgrpc::CallSettings callSettings = null) =>
            CreateContact(new CreateContactRequest
            {
                ParentAsFolderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Contact = gax::GaxPreconditions.CheckNotNull(contact, nameof(contact)),
            }, callSettings);

        /// <summary>
        /// Adds a new contact for a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource to save this contact for.
        /// Format: organizations/{organization_id}, folders/{folder_id} or
        /// projects/{project_id}
        /// </param>
        /// <param name="contact">
        /// Required. The contact to create. Must specify an email address and language
        /// tag.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Contact> CreateContactAsync(gagr::FolderName parent, Contact contact, gaxgrpc::CallSettings callSettings = null) =>
            CreateContactAsync(new CreateContactRequest
            {
                ParentAsFolderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Contact = gax::GaxPreconditions.CheckNotNull(contact, nameof(contact)),
            }, callSettings);

        /// <summary>
        /// Adds a new contact for a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource to save this contact for.
        /// Format: organizations/{organization_id}, folders/{folder_id} or
        /// projects/{project_id}
        /// </param>
        /// <param name="contact">
        /// Required. The contact to create. Must specify an email address and language
        /// tag.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Contact> CreateContactAsync(gagr::FolderName parent, Contact contact, st::CancellationToken cancellationToken) =>
            CreateContactAsync(parent, contact, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds a new contact for a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource to save this contact for.
        /// Format: organizations/{organization_id}, folders/{folder_id} or
        /// projects/{project_id}
        /// </param>
        /// <param name="contact">
        /// Required. The contact to create. Must specify an email address and language
        /// tag.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Contact CreateContact(gagr::OrganizationName parent, Contact contact, gaxgrpc::CallSettings callSettings = null) =>
            CreateContact(new CreateContactRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Contact = gax::GaxPreconditions.CheckNotNull(contact, nameof(contact)),
            }, callSettings);

        /// <summary>
        /// Adds a new contact for a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource to save this contact for.
        /// Format: organizations/{organization_id}, folders/{folder_id} or
        /// projects/{project_id}
        /// </param>
        /// <param name="contact">
        /// Required. The contact to create. Must specify an email address and language
        /// tag.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Contact> CreateContactAsync(gagr::OrganizationName parent, Contact contact, gaxgrpc::CallSettings callSettings = null) =>
            CreateContactAsync(new CreateContactRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Contact = gax::GaxPreconditions.CheckNotNull(contact, nameof(contact)),
            }, callSettings);

        /// <summary>
        /// Adds a new contact for a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource to save this contact for.
        /// Format: organizations/{organization_id}, folders/{folder_id} or
        /// projects/{project_id}
        /// </param>
        /// <param name="contact">
        /// Required. The contact to create. Must specify an email address and language
        /// tag.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Contact> CreateContactAsync(gagr::OrganizationName parent, Contact contact, st::CancellationToken cancellationToken) =>
            CreateContactAsync(parent, contact, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a contact.
        /// Note: A contact's email address cannot be changed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Contact UpdateContact(UpdateContactRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a contact.
        /// Note: A contact's email address cannot be changed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Contact> UpdateContactAsync(UpdateContactRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a contact.
        /// Note: A contact's email address cannot be changed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Contact> UpdateContactAsync(UpdateContactRequest request, st::CancellationToken cancellationToken) =>
            UpdateContactAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a contact.
        /// Note: A contact's email address cannot be changed.
        /// </summary>
        /// <param name="contact">
        /// Required. The contact resource to replace the existing saved contact. Note:
        /// the email address of the contact cannot be modified.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The update mask applied to the resource. For the `FieldMask`
        /// definition, see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Contact UpdateContact(Contact contact, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateContact(new UpdateContactRequest
            {
                Contact = gax::GaxPreconditions.CheckNotNull(contact, nameof(contact)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a contact.
        /// Note: A contact's email address cannot be changed.
        /// </summary>
        /// <param name="contact">
        /// Required. The contact resource to replace the existing saved contact. Note:
        /// the email address of the contact cannot be modified.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The update mask applied to the resource. For the `FieldMask`
        /// definition, see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Contact> UpdateContactAsync(Contact contact, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateContactAsync(new UpdateContactRequest
            {
                Contact = gax::GaxPreconditions.CheckNotNull(contact, nameof(contact)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a contact.
        /// Note: A contact's email address cannot be changed.
        /// </summary>
        /// <param name="contact">
        /// Required. The contact resource to replace the existing saved contact. Note:
        /// the email address of the contact cannot be modified.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The update mask applied to the resource. For the `FieldMask`
        /// definition, see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Contact> UpdateContactAsync(Contact contact, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateContactAsync(contact, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the contacts that have been set on a resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Contact"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListContactsResponse, Contact> ListContacts(ListContactsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the contacts that have been set on a resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Contact"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListContactsResponse, Contact> ListContactsAsync(ListContactsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the contacts that have been set on a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
        /// Format: organizations/{organization_id}, folders/{folder_id} or
        /// projects/{project_id}
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
        /// <returns>A pageable sequence of <see cref="Contact"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListContactsResponse, Contact> ListContacts(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListContactsRequest request = new ListContactsRequest
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
            return ListContacts(request, callSettings);
        }

        /// <summary>
        /// Lists the contacts that have been set on a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
        /// Format: organizations/{organization_id}, folders/{folder_id} or
        /// projects/{project_id}
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
        /// <returns>A pageable asynchronous sequence of <see cref="Contact"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListContactsResponse, Contact> ListContactsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListContactsRequest request = new ListContactsRequest
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
            return ListContactsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the contacts that have been set on a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
        /// Format: organizations/{organization_id}, folders/{folder_id} or
        /// projects/{project_id}
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
        /// <returns>A pageable sequence of <see cref="Contact"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListContactsResponse, Contact> ListContacts(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListContactsRequest request = new ListContactsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListContacts(request, callSettings);
        }

        /// <summary>
        /// Lists the contacts that have been set on a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
        /// Format: organizations/{organization_id}, folders/{folder_id} or
        /// projects/{project_id}
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
        /// <returns>A pageable asynchronous sequence of <see cref="Contact"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListContactsResponse, Contact> ListContactsAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListContactsRequest request = new ListContactsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListContactsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the contacts that have been set on a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
        /// Format: organizations/{organization_id}, folders/{folder_id} or
        /// projects/{project_id}
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
        /// <returns>A pageable sequence of <see cref="Contact"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListContactsResponse, Contact> ListContacts(gagr::FolderName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListContactsRequest request = new ListContactsRequest
            {
                ParentAsFolderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListContacts(request, callSettings);
        }

        /// <summary>
        /// Lists the contacts that have been set on a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
        /// Format: organizations/{organization_id}, folders/{folder_id} or
        /// projects/{project_id}
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
        /// <returns>A pageable asynchronous sequence of <see cref="Contact"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListContactsResponse, Contact> ListContactsAsync(gagr::FolderName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListContactsRequest request = new ListContactsRequest
            {
                ParentAsFolderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListContactsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the contacts that have been set on a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
        /// Format: organizations/{organization_id}, folders/{folder_id} or
        /// projects/{project_id}
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
        /// <returns>A pageable sequence of <see cref="Contact"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListContactsResponse, Contact> ListContacts(gagr::OrganizationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListContactsRequest request = new ListContactsRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListContacts(request, callSettings);
        }

        /// <summary>
        /// Lists the contacts that have been set on a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
        /// Format: organizations/{organization_id}, folders/{folder_id} or
        /// projects/{project_id}
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
        /// <returns>A pageable asynchronous sequence of <see cref="Contact"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListContactsResponse, Contact> ListContactsAsync(gagr::OrganizationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListContactsRequest request = new ListContactsRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListContactsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a single contact.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Contact GetContact(GetContactRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a single contact.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Contact> GetContactAsync(GetContactRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a single contact.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Contact> GetContactAsync(GetContactRequest request, st::CancellationToken cancellationToken) =>
            GetContactAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single contact.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the contact to retrieve.
        /// Format: organizations/{organization_id}/contacts/{contact_id},
        /// folders/{folder_id}/contacts/{contact_id} or
        /// projects/{project_id}/contacts/{contact_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Contact GetContact(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetContact(new GetContactRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single contact.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the contact to retrieve.
        /// Format: organizations/{organization_id}/contacts/{contact_id},
        /// folders/{folder_id}/contacts/{contact_id} or
        /// projects/{project_id}/contacts/{contact_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Contact> GetContactAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetContactAsync(new GetContactRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single contact.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the contact to retrieve.
        /// Format: organizations/{organization_id}/contacts/{contact_id},
        /// folders/{folder_id}/contacts/{contact_id} or
        /// projects/{project_id}/contacts/{contact_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Contact> GetContactAsync(string name, st::CancellationToken cancellationToken) =>
            GetContactAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single contact.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the contact to retrieve.
        /// Format: organizations/{organization_id}/contacts/{contact_id},
        /// folders/{folder_id}/contacts/{contact_id} or
        /// projects/{project_id}/contacts/{contact_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Contact GetContact(ContactName name, gaxgrpc::CallSettings callSettings = null) =>
            GetContact(new GetContactRequest
            {
                ContactName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single contact.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the contact to retrieve.
        /// Format: organizations/{organization_id}/contacts/{contact_id},
        /// folders/{folder_id}/contacts/{contact_id} or
        /// projects/{project_id}/contacts/{contact_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Contact> GetContactAsync(ContactName name, gaxgrpc::CallSettings callSettings = null) =>
            GetContactAsync(new GetContactRequest
            {
                ContactName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single contact.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the contact to retrieve.
        /// Format: organizations/{organization_id}/contacts/{contact_id},
        /// folders/{folder_id}/contacts/{contact_id} or
        /// projects/{project_id}/contacts/{contact_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Contact> GetContactAsync(ContactName name, st::CancellationToken cancellationToken) =>
            GetContactAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a contact.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteContact(DeleteContactRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a contact.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteContactAsync(DeleteContactRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a contact.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteContactAsync(DeleteContactRequest request, st::CancellationToken cancellationToken) =>
            DeleteContactAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a contact.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the contact to delete.
        /// Format: organizations/{organization_id}/contacts/{contact_id},
        /// folders/{folder_id}/contacts/{contact_id} or
        /// projects/{project_id}/contacts/{contact_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteContact(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteContact(new DeleteContactRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a contact.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the contact to delete.
        /// Format: organizations/{organization_id}/contacts/{contact_id},
        /// folders/{folder_id}/contacts/{contact_id} or
        /// projects/{project_id}/contacts/{contact_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteContactAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteContactAsync(new DeleteContactRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a contact.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the contact to delete.
        /// Format: organizations/{organization_id}/contacts/{contact_id},
        /// folders/{folder_id}/contacts/{contact_id} or
        /// projects/{project_id}/contacts/{contact_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteContactAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteContactAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a contact.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the contact to delete.
        /// Format: organizations/{organization_id}/contacts/{contact_id},
        /// folders/{folder_id}/contacts/{contact_id} or
        /// projects/{project_id}/contacts/{contact_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteContact(ContactName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteContact(new DeleteContactRequest
            {
                ContactName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a contact.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the contact to delete.
        /// Format: organizations/{organization_id}/contacts/{contact_id},
        /// folders/{folder_id}/contacts/{contact_id} or
        /// projects/{project_id}/contacts/{contact_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteContactAsync(ContactName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteContactAsync(new DeleteContactRequest
            {
                ContactName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a contact.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the contact to delete.
        /// Format: organizations/{organization_id}/contacts/{contact_id},
        /// folders/{folder_id}/contacts/{contact_id} or
        /// projects/{project_id}/contacts/{contact_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteContactAsync(ContactName name, st::CancellationToken cancellationToken) =>
            DeleteContactAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all contacts for the resource that are subscribed to the
        /// specified notification categories, including contacts inherited from
        /// any parent resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Contact"/> resources.</returns>
        public virtual gax::PagedEnumerable<ComputeContactsResponse, Contact> ComputeContacts(ComputeContactsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all contacts for the resource that are subscribed to the
        /// specified notification categories, including contacts inherited from
        /// any parent resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Contact"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ComputeContactsResponse, Contact> ComputeContactsAsync(ComputeContactsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Allows a contact admin to send a test message to contact to verify that it
        /// has been configured correctly.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void SendTestMessage(SendTestMessageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Allows a contact admin to send a test message to contact to verify that it
        /// has been configured correctly.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task SendTestMessageAsync(SendTestMessageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Allows a contact admin to send a test message to contact to verify that it
        /// has been configured correctly.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task SendTestMessageAsync(SendTestMessageRequest request, st::CancellationToken cancellationToken) =>
            SendTestMessageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>EssentialContactsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Manages contacts for important Google Cloud notifications.
    /// </remarks>
    public sealed partial class EssentialContactsServiceClientImpl : EssentialContactsServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateContactRequest, Contact> _callCreateContact;

        private readonly gaxgrpc::ApiCall<UpdateContactRequest, Contact> _callUpdateContact;

        private readonly gaxgrpc::ApiCall<ListContactsRequest, ListContactsResponse> _callListContacts;

        private readonly gaxgrpc::ApiCall<GetContactRequest, Contact> _callGetContact;

        private readonly gaxgrpc::ApiCall<DeleteContactRequest, wkt::Empty> _callDeleteContact;

        private readonly gaxgrpc::ApiCall<ComputeContactsRequest, ComputeContactsResponse> _callComputeContacts;

        private readonly gaxgrpc::ApiCall<SendTestMessageRequest, wkt::Empty> _callSendTestMessage;

        /// <summary>
        /// Constructs a client wrapper for the EssentialContactsService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="EssentialContactsServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public EssentialContactsServiceClientImpl(EssentialContactsService.EssentialContactsServiceClient grpcClient, EssentialContactsServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            EssentialContactsServiceSettings effectiveSettings = settings ?? EssentialContactsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callCreateContact = clientHelper.BuildApiCall<CreateContactRequest, Contact>("CreateContact", grpcClient.CreateContactAsync, grpcClient.CreateContact, effectiveSettings.CreateContactSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateContact);
            Modify_CreateContactApiCall(ref _callCreateContact);
            _callUpdateContact = clientHelper.BuildApiCall<UpdateContactRequest, Contact>("UpdateContact", grpcClient.UpdateContactAsync, grpcClient.UpdateContact, effectiveSettings.UpdateContactSettings).WithGoogleRequestParam("contact.name", request => request.Contact?.Name);
            Modify_ApiCall(ref _callUpdateContact);
            Modify_UpdateContactApiCall(ref _callUpdateContact);
            _callListContacts = clientHelper.BuildApiCall<ListContactsRequest, ListContactsResponse>("ListContacts", grpcClient.ListContactsAsync, grpcClient.ListContacts, effectiveSettings.ListContactsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListContacts);
            Modify_ListContactsApiCall(ref _callListContacts);
            _callGetContact = clientHelper.BuildApiCall<GetContactRequest, Contact>("GetContact", grpcClient.GetContactAsync, grpcClient.GetContact, effectiveSettings.GetContactSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetContact);
            Modify_GetContactApiCall(ref _callGetContact);
            _callDeleteContact = clientHelper.BuildApiCall<DeleteContactRequest, wkt::Empty>("DeleteContact", grpcClient.DeleteContactAsync, grpcClient.DeleteContact, effectiveSettings.DeleteContactSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteContact);
            Modify_DeleteContactApiCall(ref _callDeleteContact);
            _callComputeContacts = clientHelper.BuildApiCall<ComputeContactsRequest, ComputeContactsResponse>("ComputeContacts", grpcClient.ComputeContactsAsync, grpcClient.ComputeContacts, effectiveSettings.ComputeContactsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callComputeContacts);
            Modify_ComputeContactsApiCall(ref _callComputeContacts);
            _callSendTestMessage = clientHelper.BuildApiCall<SendTestMessageRequest, wkt::Empty>("SendTestMessage", grpcClient.SendTestMessageAsync, grpcClient.SendTestMessage, effectiveSettings.SendTestMessageSettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callSendTestMessage);
            Modify_SendTestMessageApiCall(ref _callSendTestMessage);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateContactApiCall(ref gaxgrpc::ApiCall<CreateContactRequest, Contact> call);

        partial void Modify_UpdateContactApiCall(ref gaxgrpc::ApiCall<UpdateContactRequest, Contact> call);

        partial void Modify_ListContactsApiCall(ref gaxgrpc::ApiCall<ListContactsRequest, ListContactsResponse> call);

        partial void Modify_GetContactApiCall(ref gaxgrpc::ApiCall<GetContactRequest, Contact> call);

        partial void Modify_DeleteContactApiCall(ref gaxgrpc::ApiCall<DeleteContactRequest, wkt::Empty> call);

        partial void Modify_ComputeContactsApiCall(ref gaxgrpc::ApiCall<ComputeContactsRequest, ComputeContactsResponse> call);

        partial void Modify_SendTestMessageApiCall(ref gaxgrpc::ApiCall<SendTestMessageRequest, wkt::Empty> call);

        partial void OnConstruction(EssentialContactsService.EssentialContactsServiceClient grpcClient, EssentialContactsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC EssentialContactsService client</summary>
        public override EssentialContactsService.EssentialContactsServiceClient GrpcClient { get; }

        partial void Modify_CreateContactRequest(ref CreateContactRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateContactRequest(ref UpdateContactRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListContactsRequest(ref ListContactsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetContactRequest(ref GetContactRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteContactRequest(ref DeleteContactRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ComputeContactsRequest(ref ComputeContactsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SendTestMessageRequest(ref SendTestMessageRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Adds a new contact for a resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Contact CreateContact(CreateContactRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateContactRequest(ref request, ref callSettings);
            return _callCreateContact.Sync(request, callSettings);
        }

        /// <summary>
        /// Adds a new contact for a resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Contact> CreateContactAsync(CreateContactRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateContactRequest(ref request, ref callSettings);
            return _callCreateContact.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a contact.
        /// Note: A contact's email address cannot be changed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Contact UpdateContact(UpdateContactRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateContactRequest(ref request, ref callSettings);
            return _callUpdateContact.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a contact.
        /// Note: A contact's email address cannot be changed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Contact> UpdateContactAsync(UpdateContactRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateContactRequest(ref request, ref callSettings);
            return _callUpdateContact.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the contacts that have been set on a resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Contact"/> resources.</returns>
        public override gax::PagedEnumerable<ListContactsResponse, Contact> ListContacts(ListContactsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListContactsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListContactsRequest, ListContactsResponse, Contact>(_callListContacts, request, callSettings);
        }

        /// <summary>
        /// Lists the contacts that have been set on a resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Contact"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListContactsResponse, Contact> ListContactsAsync(ListContactsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListContactsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListContactsRequest, ListContactsResponse, Contact>(_callListContacts, request, callSettings);
        }

        /// <summary>
        /// Gets a single contact.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Contact GetContact(GetContactRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetContactRequest(ref request, ref callSettings);
            return _callGetContact.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a single contact.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Contact> GetContactAsync(GetContactRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetContactRequest(ref request, ref callSettings);
            return _callGetContact.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a contact.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteContact(DeleteContactRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteContactRequest(ref request, ref callSettings);
            _callDeleteContact.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a contact.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteContactAsync(DeleteContactRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteContactRequest(ref request, ref callSettings);
            return _callDeleteContact.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all contacts for the resource that are subscribed to the
        /// specified notification categories, including contacts inherited from
        /// any parent resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Contact"/> resources.</returns>
        public override gax::PagedEnumerable<ComputeContactsResponse, Contact> ComputeContacts(ComputeContactsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ComputeContactsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ComputeContactsRequest, ComputeContactsResponse, Contact>(_callComputeContacts, request, callSettings);
        }

        /// <summary>
        /// Lists all contacts for the resource that are subscribed to the
        /// specified notification categories, including contacts inherited from
        /// any parent resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Contact"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ComputeContactsResponse, Contact> ComputeContactsAsync(ComputeContactsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ComputeContactsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ComputeContactsRequest, ComputeContactsResponse, Contact>(_callComputeContacts, request, callSettings);
        }

        /// <summary>
        /// Allows a contact admin to send a test message to contact to verify that it
        /// has been configured correctly.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void SendTestMessage(SendTestMessageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SendTestMessageRequest(ref request, ref callSettings);
            _callSendTestMessage.Sync(request, callSettings);
        }

        /// <summary>
        /// Allows a contact admin to send a test message to contact to verify that it
        /// has been configured correctly.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task SendTestMessageAsync(SendTestMessageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SendTestMessageRequest(ref request, ref callSettings);
            return _callSendTestMessage.Async(request, callSettings);
        }
    }

    public partial class ListContactsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ComputeContactsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListContactsResponse : gaxgrpc::IPageResponse<Contact>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Contact> GetEnumerator() => Contacts.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ComputeContactsResponse : gaxgrpc::IPageResponse<Contact>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Contact> GetEnumerator() => Contacts.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
