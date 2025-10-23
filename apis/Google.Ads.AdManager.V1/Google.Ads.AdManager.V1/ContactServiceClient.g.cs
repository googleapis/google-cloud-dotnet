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
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Ads.AdManager.V1
{
    /// <summary>Settings for <see cref="ContactServiceClient"/> instances.</summary>
    public sealed partial class ContactServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ContactServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ContactServiceSettings"/>.</returns>
        public static ContactServiceSettings GetDefault() => new ContactServiceSettings();

        /// <summary>Constructs a new <see cref="ContactServiceSettings"/> object with default settings.</summary>
        public ContactServiceSettings()
        {
        }

        private ContactServiceSettings(ContactServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetContactSettings = existing.GetContactSettings;
            ListContactsSettings = existing.ListContactsSettings;
            CreateContactSettings = existing.CreateContactSettings;
            BatchCreateContactsSettings = existing.BatchCreateContactsSettings;
            UpdateContactSettings = existing.UpdateContactSettings;
            BatchUpdateContactsSettings = existing.BatchUpdateContactsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ContactServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactServiceClient.GetContact</c> and <c>ContactServiceClient.GetContactAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetContactSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactServiceClient.ListContacts</c> and <c>ContactServiceClient.ListContactsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListContactsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactServiceClient.CreateContact</c> and <c>ContactServiceClient.CreateContactAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateContactSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactServiceClient.BatchCreateContacts</c> and <c>ContactServiceClient.BatchCreateContactsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchCreateContactsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactServiceClient.UpdateContact</c> and <c>ContactServiceClient.UpdateContactAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateContactSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContactServiceClient.BatchUpdateContacts</c> and <c>ContactServiceClient.BatchUpdateContactsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchUpdateContactsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ContactServiceSettings"/> object.</returns>
        public ContactServiceSettings Clone() => new ContactServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ContactServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class ContactServiceClientBuilder : gaxgrpc::ClientBuilderBase<ContactServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ContactServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ContactServiceClientBuilder() : base(ContactServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ContactServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ContactServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ContactServiceClient Build()
        {
            ContactServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ContactServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ContactServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ContactServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ContactServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ContactServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ContactServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ContactServiceClient.ChannelPool;
    }

    /// <summary>ContactService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `Contact` objects.
    /// </remarks>
    public abstract partial class ContactServiceClient
    {
        /// <summary>
        /// The default endpoint for the ContactService service, which is a host of "admanager.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default ContactService scopes.</summary>
        /// <remarks>
        /// The default ContactService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/admanager</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/admanager",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ContactService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ContactServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ContactServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ContactServiceClient"/>.</returns>
        public static stt::Task<ContactServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ContactServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ContactServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ContactServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ContactServiceClient"/>.</returns>
        public static ContactServiceClient Create() => new ContactServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ContactServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ContactServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ContactServiceClient"/>.</returns>
        internal static ContactServiceClient Create(grpccore::CallInvoker callInvoker, ContactServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ContactService.ContactServiceClient grpcClient = new ContactService.ContactServiceClient(callInvoker);
            return new ContactServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ContactService client</summary>
        public virtual ContactService.ContactServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `Contact` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Contact GetContact(GetContactRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `Contact` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Contact> GetContactAsync(GetContactRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `Contact` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Contact> GetContactAsync(GetContactRequest request, st::CancellationToken cancellationToken) =>
            GetContactAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `Contact` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Contact.
        /// Format: `networks/{network_code}/contacts/{contact_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Contact GetContact(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetContact(new GetContactRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `Contact` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Contact.
        /// Format: `networks/{network_code}/contacts/{contact_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Contact> GetContactAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetContactAsync(new GetContactRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `Contact` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Contact.
        /// Format: `networks/{network_code}/contacts/{contact_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Contact> GetContactAsync(string name, st::CancellationToken cancellationToken) =>
            GetContactAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `Contact` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Contact.
        /// Format: `networks/{network_code}/contacts/{contact_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Contact GetContact(ContactName name, gaxgrpc::CallSettings callSettings = null) =>
            GetContact(new GetContactRequest
            {
                ContactName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `Contact` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Contact.
        /// Format: `networks/{network_code}/contacts/{contact_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Contact> GetContactAsync(ContactName name, gaxgrpc::CallSettings callSettings = null) =>
            GetContactAsync(new GetContactRequest
            {
                ContactName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `Contact` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Contact.
        /// Format: `networks/{network_code}/contacts/{contact_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Contact> GetContactAsync(ContactName name, st::CancellationToken cancellationToken) =>
            GetContactAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a list of `Contact` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Contact"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListContactsResponse, Contact> ListContacts(ListContactsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `Contact` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Contact"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListContactsResponse, Contact> ListContactsAsync(ListContactsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `Contact` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Contacts.
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
        /// API to retrieve a list of `Contact` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Contacts.
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
        /// API to retrieve a list of `Contact` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Contacts.
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
        /// <returns>A pageable sequence of <see cref="Contact"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListContactsResponse, Contact> ListContacts(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListContactsRequest request = new ListContactsRequest
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
            return ListContacts(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `Contact` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Contacts.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Contact"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListContactsResponse, Contact> ListContactsAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListContactsRequest request = new ListContactsRequest
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
            return ListContactsAsync(request, callSettings);
        }

        /// <summary>
        /// API to create a `Contact` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Contact CreateContact(CreateContactRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to create a `Contact` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Contact> CreateContactAsync(CreateContactRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to create a `Contact` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Contact> CreateContactAsync(CreateContactRequest request, st::CancellationToken cancellationToken) =>
            CreateContactAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to create a `Contact` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `Contact` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="contact">
        /// Required. The `Contact` to create.
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
        /// API to create a `Contact` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `Contact` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="contact">
        /// Required. The `Contact` to create.
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
        /// API to create a `Contact` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `Contact` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="contact">
        /// Required. The `Contact` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Contact> CreateContactAsync(string parent, Contact contact, st::CancellationToken cancellationToken) =>
            CreateContactAsync(parent, contact, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to create a `Contact` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `Contact` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="contact">
        /// Required. The `Contact` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Contact CreateContact(NetworkName parent, Contact contact, gaxgrpc::CallSettings callSettings = null) =>
            CreateContact(new CreateContactRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Contact = gax::GaxPreconditions.CheckNotNull(contact, nameof(contact)),
            }, callSettings);

        /// <summary>
        /// API to create a `Contact` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `Contact` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="contact">
        /// Required. The `Contact` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Contact> CreateContactAsync(NetworkName parent, Contact contact, gaxgrpc::CallSettings callSettings = null) =>
            CreateContactAsync(new CreateContactRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Contact = gax::GaxPreconditions.CheckNotNull(contact, nameof(contact)),
            }, callSettings);

        /// <summary>
        /// API to create a `Contact` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `Contact` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="contact">
        /// Required. The `Contact` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Contact> CreateContactAsync(NetworkName parent, Contact contact, st::CancellationToken cancellationToken) =>
            CreateContactAsync(parent, contact, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to batch create `Contact` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateContactsResponse BatchCreateContacts(BatchCreateContactsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to batch create `Contact` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateContactsResponse> BatchCreateContactsAsync(BatchCreateContactsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to batch create `Contact` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateContactsResponse> BatchCreateContactsAsync(BatchCreateContactsRequest request, st::CancellationToken cancellationToken) =>
            BatchCreateContactsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to batch create `Contact` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Contacts` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateContactRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Contact` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateContactsResponse BatchCreateContacts(string parent, scg::IEnumerable<CreateContactRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateContacts(new BatchCreateContactsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch create `Contact` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Contacts` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateContactRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Contact` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateContactsResponse> BatchCreateContactsAsync(string parent, scg::IEnumerable<CreateContactRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateContactsAsync(new BatchCreateContactsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch create `Contact` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Contacts` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateContactRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Contact` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateContactsResponse> BatchCreateContactsAsync(string parent, scg::IEnumerable<CreateContactRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateContactsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to batch create `Contact` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Contacts` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateContactRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Contact` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateContactsResponse BatchCreateContacts(NetworkName parent, scg::IEnumerable<CreateContactRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateContacts(new BatchCreateContactsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch create `Contact` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Contacts` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateContactRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Contact` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateContactsResponse> BatchCreateContactsAsync(NetworkName parent, scg::IEnumerable<CreateContactRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateContactsAsync(new BatchCreateContactsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch create `Contact` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Contacts` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateContactRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Contact` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateContactsResponse> BatchCreateContactsAsync(NetworkName parent, scg::IEnumerable<CreateContactRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateContactsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to update a `Contact` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Contact UpdateContact(UpdateContactRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to update a `Contact` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Contact> UpdateContactAsync(UpdateContactRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to update a `Contact` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Contact> UpdateContactAsync(UpdateContactRequest request, st::CancellationToken cancellationToken) =>
            UpdateContactAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to update a `Contact` object.
        /// </summary>
        /// <param name="contact">
        /// Required. The `Contact` to update.
        /// 
        /// The `Contact`'s `name` is used to identify the `Contact` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Contact UpdateContact(Contact contact, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateContact(new UpdateContactRequest
            {
                Contact = gax::GaxPreconditions.CheckNotNull(contact, nameof(contact)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// API to update a `Contact` object.
        /// </summary>
        /// <param name="contact">
        /// Required. The `Contact` to update.
        /// 
        /// The `Contact`'s `name` is used to identify the `Contact` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Contact> UpdateContactAsync(Contact contact, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateContactAsync(new UpdateContactRequest
            {
                Contact = gax::GaxPreconditions.CheckNotNull(contact, nameof(contact)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// API to update a `Contact` object.
        /// </summary>
        /// <param name="contact">
        /// Required. The `Contact` to update.
        /// 
        /// The `Contact`'s `name` is used to identify the `Contact` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Contact> UpdateContactAsync(Contact contact, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateContactAsync(contact, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to batch update `Contact` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateContactsResponse BatchUpdateContacts(BatchUpdateContactsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to batch update `Contact` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateContactsResponse> BatchUpdateContactsAsync(BatchUpdateContactsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to batch update `Contact` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateContactsResponse> BatchUpdateContactsAsync(BatchUpdateContactsRequest request, st::CancellationToken cancellationToken) =>
            BatchUpdateContactsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to batch update `Contact` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Contacts` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateContactRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Contact` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateContactsResponse BatchUpdateContacts(string parent, scg::IEnumerable<UpdateContactRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateContacts(new BatchUpdateContactsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch update `Contact` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Contacts` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateContactRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Contact` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateContactsResponse> BatchUpdateContactsAsync(string parent, scg::IEnumerable<UpdateContactRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateContactsAsync(new BatchUpdateContactsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch update `Contact` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Contacts` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateContactRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Contact` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateContactsResponse> BatchUpdateContactsAsync(string parent, scg::IEnumerable<UpdateContactRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateContactsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to batch update `Contact` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Contacts` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateContactRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Contact` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateContactsResponse BatchUpdateContacts(NetworkName parent, scg::IEnumerable<UpdateContactRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateContacts(new BatchUpdateContactsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch update `Contact` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Contacts` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateContactRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Contact` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateContactsResponse> BatchUpdateContactsAsync(NetworkName parent, scg::IEnumerable<UpdateContactRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateContactsAsync(new BatchUpdateContactsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch update `Contact` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Contacts` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateContactRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Contact` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateContactsResponse> BatchUpdateContactsAsync(NetworkName parent, scg::IEnumerable<UpdateContactRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateContactsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ContactService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `Contact` objects.
    /// </remarks>
    public sealed partial class ContactServiceClientImpl : ContactServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetContactRequest, Contact> _callGetContact;

        private readonly gaxgrpc::ApiCall<ListContactsRequest, ListContactsResponse> _callListContacts;

        private readonly gaxgrpc::ApiCall<CreateContactRequest, Contact> _callCreateContact;

        private readonly gaxgrpc::ApiCall<BatchCreateContactsRequest, BatchCreateContactsResponse> _callBatchCreateContacts;

        private readonly gaxgrpc::ApiCall<UpdateContactRequest, Contact> _callUpdateContact;

        private readonly gaxgrpc::ApiCall<BatchUpdateContactsRequest, BatchUpdateContactsResponse> _callBatchUpdateContacts;

        /// <summary>
        /// Constructs a client wrapper for the ContactService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ContactServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ContactServiceClientImpl(ContactService.ContactServiceClient grpcClient, ContactServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ContactServiceSettings effectiveSettings = settings ?? ContactServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetContact = clientHelper.BuildApiCall<GetContactRequest, Contact>("GetContact", grpcClient.GetContactAsync, grpcClient.GetContact, effectiveSettings.GetContactSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetContact);
            Modify_GetContactApiCall(ref _callGetContact);
            _callListContacts = clientHelper.BuildApiCall<ListContactsRequest, ListContactsResponse>("ListContacts", grpcClient.ListContactsAsync, grpcClient.ListContacts, effectiveSettings.ListContactsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListContacts);
            Modify_ListContactsApiCall(ref _callListContacts);
            _callCreateContact = clientHelper.BuildApiCall<CreateContactRequest, Contact>("CreateContact", grpcClient.CreateContactAsync, grpcClient.CreateContact, effectiveSettings.CreateContactSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateContact);
            Modify_CreateContactApiCall(ref _callCreateContact);
            _callBatchCreateContacts = clientHelper.BuildApiCall<BatchCreateContactsRequest, BatchCreateContactsResponse>("BatchCreateContacts", grpcClient.BatchCreateContactsAsync, grpcClient.BatchCreateContacts, effectiveSettings.BatchCreateContactsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchCreateContacts);
            Modify_BatchCreateContactsApiCall(ref _callBatchCreateContacts);
            _callUpdateContact = clientHelper.BuildApiCall<UpdateContactRequest, Contact>("UpdateContact", grpcClient.UpdateContactAsync, grpcClient.UpdateContact, effectiveSettings.UpdateContactSettings).WithGoogleRequestParam("contact.name", request => request.Contact?.Name);
            Modify_ApiCall(ref _callUpdateContact);
            Modify_UpdateContactApiCall(ref _callUpdateContact);
            _callBatchUpdateContacts = clientHelper.BuildApiCall<BatchUpdateContactsRequest, BatchUpdateContactsResponse>("BatchUpdateContacts", grpcClient.BatchUpdateContactsAsync, grpcClient.BatchUpdateContacts, effectiveSettings.BatchUpdateContactsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchUpdateContacts);
            Modify_BatchUpdateContactsApiCall(ref _callBatchUpdateContacts);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetContactApiCall(ref gaxgrpc::ApiCall<GetContactRequest, Contact> call);

        partial void Modify_ListContactsApiCall(ref gaxgrpc::ApiCall<ListContactsRequest, ListContactsResponse> call);

        partial void Modify_CreateContactApiCall(ref gaxgrpc::ApiCall<CreateContactRequest, Contact> call);

        partial void Modify_BatchCreateContactsApiCall(ref gaxgrpc::ApiCall<BatchCreateContactsRequest, BatchCreateContactsResponse> call);

        partial void Modify_UpdateContactApiCall(ref gaxgrpc::ApiCall<UpdateContactRequest, Contact> call);

        partial void Modify_BatchUpdateContactsApiCall(ref gaxgrpc::ApiCall<BatchUpdateContactsRequest, BatchUpdateContactsResponse> call);

        partial void OnConstruction(ContactService.ContactServiceClient grpcClient, ContactServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ContactService client</summary>
        public override ContactService.ContactServiceClient GrpcClient { get; }

        partial void Modify_GetContactRequest(ref GetContactRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListContactsRequest(ref ListContactsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateContactRequest(ref CreateContactRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchCreateContactsRequest(ref BatchCreateContactsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateContactRequest(ref UpdateContactRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchUpdateContactsRequest(ref BatchUpdateContactsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// API to retrieve a `Contact` object.
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
        /// API to retrieve a `Contact` object.
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
        /// API to retrieve a list of `Contact` objects.
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
        /// API to retrieve a list of `Contact` objects.
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
        /// API to create a `Contact` object.
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
        /// API to create a `Contact` object.
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
        /// API to batch create `Contact` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchCreateContactsResponse BatchCreateContacts(BatchCreateContactsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateContactsRequest(ref request, ref callSettings);
            return _callBatchCreateContacts.Sync(request, callSettings);
        }

        /// <summary>
        /// API to batch create `Contact` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchCreateContactsResponse> BatchCreateContactsAsync(BatchCreateContactsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateContactsRequest(ref request, ref callSettings);
            return _callBatchCreateContacts.Async(request, callSettings);
        }

        /// <summary>
        /// API to update a `Contact` object.
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
        /// API to update a `Contact` object.
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
        /// API to batch update `Contact` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchUpdateContactsResponse BatchUpdateContacts(BatchUpdateContactsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateContactsRequest(ref request, ref callSettings);
            return _callBatchUpdateContacts.Sync(request, callSettings);
        }

        /// <summary>
        /// API to batch update `Contact` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchUpdateContactsResponse> BatchUpdateContactsAsync(BatchUpdateContactsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateContactsRequest(ref request, ref callSettings);
            return _callBatchUpdateContacts.Async(request, callSettings);
        }
    }

    public partial class ListContactsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListContactsResponse : gaxgrpc::IPageResponse<Contact>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Contact> GetEnumerator() => Contacts.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
