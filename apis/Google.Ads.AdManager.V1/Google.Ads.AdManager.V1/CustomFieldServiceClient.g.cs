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
    /// <summary>Settings for <see cref="CustomFieldServiceClient"/> instances.</summary>
    public sealed partial class CustomFieldServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CustomFieldServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CustomFieldServiceSettings"/>.</returns>
        public static CustomFieldServiceSettings GetDefault() => new CustomFieldServiceSettings();

        /// <summary>Constructs a new <see cref="CustomFieldServiceSettings"/> object with default settings.</summary>
        public CustomFieldServiceSettings()
        {
        }

        private CustomFieldServiceSettings(CustomFieldServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetCustomFieldSettings = existing.GetCustomFieldSettings;
            ListCustomFieldsSettings = existing.ListCustomFieldsSettings;
            CreateCustomFieldSettings = existing.CreateCustomFieldSettings;
            BatchCreateCustomFieldsSettings = existing.BatchCreateCustomFieldsSettings;
            UpdateCustomFieldSettings = existing.UpdateCustomFieldSettings;
            BatchUpdateCustomFieldsSettings = existing.BatchUpdateCustomFieldsSettings;
            BatchActivateCustomFieldsSettings = existing.BatchActivateCustomFieldsSettings;
            BatchDeactivateCustomFieldsSettings = existing.BatchDeactivateCustomFieldsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CustomFieldServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomFieldServiceClient.GetCustomField</c> and <c>CustomFieldServiceClient.GetCustomFieldAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCustomFieldSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomFieldServiceClient.ListCustomFields</c> and <c>CustomFieldServiceClient.ListCustomFieldsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListCustomFieldsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomFieldServiceClient.CreateCustomField</c> and <c>CustomFieldServiceClient.CreateCustomFieldAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateCustomFieldSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomFieldServiceClient.BatchCreateCustomFields</c> and
        /// <c>CustomFieldServiceClient.BatchCreateCustomFieldsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchCreateCustomFieldsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomFieldServiceClient.UpdateCustomField</c> and <c>CustomFieldServiceClient.UpdateCustomFieldAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateCustomFieldSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomFieldServiceClient.BatchUpdateCustomFields</c> and
        /// <c>CustomFieldServiceClient.BatchUpdateCustomFieldsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchUpdateCustomFieldsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomFieldServiceClient.BatchActivateCustomFields</c> and
        /// <c>CustomFieldServiceClient.BatchActivateCustomFieldsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchActivateCustomFieldsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomFieldServiceClient.BatchDeactivateCustomFields</c> and
        /// <c>CustomFieldServiceClient.BatchDeactivateCustomFieldsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchDeactivateCustomFieldsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CustomFieldServiceSettings"/> object.</returns>
        public CustomFieldServiceSettings Clone() => new CustomFieldServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CustomFieldServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class CustomFieldServiceClientBuilder : gaxgrpc::ClientBuilderBase<CustomFieldServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CustomFieldServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CustomFieldServiceClientBuilder() : base(CustomFieldServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CustomFieldServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CustomFieldServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CustomFieldServiceClient Build()
        {
            CustomFieldServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CustomFieldServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CustomFieldServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CustomFieldServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CustomFieldServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CustomFieldServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CustomFieldServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CustomFieldServiceClient.ChannelPool;
    }

    /// <summary>CustomFieldService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `CustomField` objects.
    /// </remarks>
    public abstract partial class CustomFieldServiceClient
    {
        /// <summary>
        /// The default endpoint for the CustomFieldService service, which is a host of "admanager.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default CustomFieldService scopes.</summary>
        /// <remarks>
        /// The default CustomFieldService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/admanager</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/admanager",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CustomFieldService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CustomFieldServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CustomFieldServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CustomFieldServiceClient"/>.</returns>
        public static stt::Task<CustomFieldServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CustomFieldServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CustomFieldServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CustomFieldServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="CustomFieldServiceClient"/>.</returns>
        public static CustomFieldServiceClient Create() => new CustomFieldServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CustomFieldServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CustomFieldServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CustomFieldServiceClient"/>.</returns>
        internal static CustomFieldServiceClient Create(grpccore::CallInvoker callInvoker, CustomFieldServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CustomFieldService.CustomFieldServiceClient grpcClient = new CustomFieldService.CustomFieldServiceClient(callInvoker);
            return new CustomFieldServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CustomFieldService client</summary>
        public virtual CustomFieldService.CustomFieldServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `CustomField` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomField GetCustomField(GetCustomFieldRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `CustomField` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomField> GetCustomFieldAsync(GetCustomFieldRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `CustomField` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomField> GetCustomFieldAsync(GetCustomFieldRequest request, st::CancellationToken cancellationToken) =>
            GetCustomFieldAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `CustomField` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CustomField.
        /// Format: `networks/{network_code}/customFields/{custom_field_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomField GetCustomField(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomField(new GetCustomFieldRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `CustomField` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CustomField.
        /// Format: `networks/{network_code}/customFields/{custom_field_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomField> GetCustomFieldAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomFieldAsync(new GetCustomFieldRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `CustomField` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CustomField.
        /// Format: `networks/{network_code}/customFields/{custom_field_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomField> GetCustomFieldAsync(string name, st::CancellationToken cancellationToken) =>
            GetCustomFieldAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `CustomField` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CustomField.
        /// Format: `networks/{network_code}/customFields/{custom_field_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomField GetCustomField(CustomFieldName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomField(new GetCustomFieldRequest
            {
                CustomFieldName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `CustomField` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CustomField.
        /// Format: `networks/{network_code}/customFields/{custom_field_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomField> GetCustomFieldAsync(CustomFieldName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomFieldAsync(new GetCustomFieldRequest
            {
                CustomFieldName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `CustomField` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CustomField.
        /// Format: `networks/{network_code}/customFields/{custom_field_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomField> GetCustomFieldAsync(CustomFieldName name, st::CancellationToken cancellationToken) =>
            GetCustomFieldAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a list of `CustomField` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CustomField"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCustomFieldsResponse, CustomField> ListCustomFields(ListCustomFieldsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `CustomField` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CustomField"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCustomFieldsResponse, CustomField> ListCustomFieldsAsync(ListCustomFieldsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `CustomField` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CustomFields.
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
        /// <returns>A pageable sequence of <see cref="CustomField"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCustomFieldsResponse, CustomField> ListCustomFields(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCustomFieldsRequest request = new ListCustomFieldsRequest
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
            return ListCustomFields(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `CustomField` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CustomFields.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CustomField"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCustomFieldsResponse, CustomField> ListCustomFieldsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCustomFieldsRequest request = new ListCustomFieldsRequest
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
            return ListCustomFieldsAsync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `CustomField` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CustomFields.
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
        /// <returns>A pageable sequence of <see cref="CustomField"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCustomFieldsResponse, CustomField> ListCustomFields(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCustomFieldsRequest request = new ListCustomFieldsRequest
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
            return ListCustomFields(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `CustomField` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CustomFields.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CustomField"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCustomFieldsResponse, CustomField> ListCustomFieldsAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCustomFieldsRequest request = new ListCustomFieldsRequest
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
            return ListCustomFieldsAsync(request, callSettings);
        }

        /// <summary>
        /// API to create a `CustomField` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomField CreateCustomField(CreateCustomFieldRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to create a `CustomField` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomField> CreateCustomFieldAsync(CreateCustomFieldRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to create a `CustomField` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomField> CreateCustomFieldAsync(CreateCustomFieldRequest request, st::CancellationToken cancellationToken) =>
            CreateCustomFieldAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to create a `CustomField` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `CustomField` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="customField">
        /// Required. The `CustomField` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomField CreateCustomField(string parent, CustomField customField, gaxgrpc::CallSettings callSettings = null) =>
            CreateCustomField(new CreateCustomFieldRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CustomField = gax::GaxPreconditions.CheckNotNull(customField, nameof(customField)),
            }, callSettings);

        /// <summary>
        /// API to create a `CustomField` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `CustomField` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="customField">
        /// Required. The `CustomField` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomField> CreateCustomFieldAsync(string parent, CustomField customField, gaxgrpc::CallSettings callSettings = null) =>
            CreateCustomFieldAsync(new CreateCustomFieldRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CustomField = gax::GaxPreconditions.CheckNotNull(customField, nameof(customField)),
            }, callSettings);

        /// <summary>
        /// API to create a `CustomField` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `CustomField` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="customField">
        /// Required. The `CustomField` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomField> CreateCustomFieldAsync(string parent, CustomField customField, st::CancellationToken cancellationToken) =>
            CreateCustomFieldAsync(parent, customField, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to create a `CustomField` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `CustomField` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="customField">
        /// Required. The `CustomField` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomField CreateCustomField(NetworkName parent, CustomField customField, gaxgrpc::CallSettings callSettings = null) =>
            CreateCustomField(new CreateCustomFieldRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CustomField = gax::GaxPreconditions.CheckNotNull(customField, nameof(customField)),
            }, callSettings);

        /// <summary>
        /// API to create a `CustomField` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `CustomField` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="customField">
        /// Required. The `CustomField` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomField> CreateCustomFieldAsync(NetworkName parent, CustomField customField, gaxgrpc::CallSettings callSettings = null) =>
            CreateCustomFieldAsync(new CreateCustomFieldRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CustomField = gax::GaxPreconditions.CheckNotNull(customField, nameof(customField)),
            }, callSettings);

        /// <summary>
        /// API to create a `CustomField` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `CustomField` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="customField">
        /// Required. The `CustomField` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomField> CreateCustomFieldAsync(NetworkName parent, CustomField customField, st::CancellationToken cancellationToken) =>
            CreateCustomFieldAsync(parent, customField, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to batch create `CustomField` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateCustomFieldsResponse BatchCreateCustomFields(BatchCreateCustomFieldsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to batch create `CustomField` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateCustomFieldsResponse> BatchCreateCustomFieldsAsync(BatchCreateCustomFieldsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to batch create `CustomField` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateCustomFieldsResponse> BatchCreateCustomFieldsAsync(BatchCreateCustomFieldsRequest request, st::CancellationToken cancellationToken) =>
            BatchCreateCustomFieldsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to batch create `CustomField` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `CustomFields` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateCustomFieldRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `CustomField` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateCustomFieldsResponse BatchCreateCustomFields(string parent, scg::IEnumerable<CreateCustomFieldRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateCustomFields(new BatchCreateCustomFieldsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch create `CustomField` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `CustomFields` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateCustomFieldRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `CustomField` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateCustomFieldsResponse> BatchCreateCustomFieldsAsync(string parent, scg::IEnumerable<CreateCustomFieldRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateCustomFieldsAsync(new BatchCreateCustomFieldsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch create `CustomField` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `CustomFields` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateCustomFieldRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `CustomField` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateCustomFieldsResponse> BatchCreateCustomFieldsAsync(string parent, scg::IEnumerable<CreateCustomFieldRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateCustomFieldsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to batch create `CustomField` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `CustomFields` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateCustomFieldRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `CustomField` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateCustomFieldsResponse BatchCreateCustomFields(NetworkName parent, scg::IEnumerable<CreateCustomFieldRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateCustomFields(new BatchCreateCustomFieldsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch create `CustomField` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `CustomFields` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateCustomFieldRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `CustomField` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateCustomFieldsResponse> BatchCreateCustomFieldsAsync(NetworkName parent, scg::IEnumerable<CreateCustomFieldRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateCustomFieldsAsync(new BatchCreateCustomFieldsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch create `CustomField` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `CustomFields` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateCustomFieldRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `CustomField` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateCustomFieldsResponse> BatchCreateCustomFieldsAsync(NetworkName parent, scg::IEnumerable<CreateCustomFieldRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateCustomFieldsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to update a `CustomField` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomField UpdateCustomField(UpdateCustomFieldRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to update a `CustomField` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomField> UpdateCustomFieldAsync(UpdateCustomFieldRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to update a `CustomField` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomField> UpdateCustomFieldAsync(UpdateCustomFieldRequest request, st::CancellationToken cancellationToken) =>
            UpdateCustomFieldAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to update a `CustomField` object.
        /// </summary>
        /// <param name="customField">
        /// Required. The `CustomField` to update.
        /// 
        /// The `CustomField`'s `name` is used to identify the `CustomField` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomField UpdateCustomField(CustomField customField, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCustomField(new UpdateCustomFieldRequest
            {
                CustomField = gax::GaxPreconditions.CheckNotNull(customField, nameof(customField)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// API to update a `CustomField` object.
        /// </summary>
        /// <param name="customField">
        /// Required. The `CustomField` to update.
        /// 
        /// The `CustomField`'s `name` is used to identify the `CustomField` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomField> UpdateCustomFieldAsync(CustomField customField, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCustomFieldAsync(new UpdateCustomFieldRequest
            {
                CustomField = gax::GaxPreconditions.CheckNotNull(customField, nameof(customField)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// API to update a `CustomField` object.
        /// </summary>
        /// <param name="customField">
        /// Required. The `CustomField` to update.
        /// 
        /// The `CustomField`'s `name` is used to identify the `CustomField` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomField> UpdateCustomFieldAsync(CustomField customField, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateCustomFieldAsync(customField, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to batch update `CustomField` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateCustomFieldsResponse BatchUpdateCustomFields(BatchUpdateCustomFieldsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to batch update `CustomField` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateCustomFieldsResponse> BatchUpdateCustomFieldsAsync(BatchUpdateCustomFieldsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to batch update `CustomField` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateCustomFieldsResponse> BatchUpdateCustomFieldsAsync(BatchUpdateCustomFieldsRequest request, st::CancellationToken cancellationToken) =>
            BatchUpdateCustomFieldsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to batch update `CustomField` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `CustomFields` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateCustomFieldRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `CustomField` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateCustomFieldsResponse BatchUpdateCustomFields(string parent, scg::IEnumerable<UpdateCustomFieldRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateCustomFields(new BatchUpdateCustomFieldsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch update `CustomField` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `CustomFields` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateCustomFieldRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `CustomField` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateCustomFieldsResponse> BatchUpdateCustomFieldsAsync(string parent, scg::IEnumerable<UpdateCustomFieldRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateCustomFieldsAsync(new BatchUpdateCustomFieldsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch update `CustomField` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `CustomFields` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateCustomFieldRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `CustomField` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateCustomFieldsResponse> BatchUpdateCustomFieldsAsync(string parent, scg::IEnumerable<UpdateCustomFieldRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateCustomFieldsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to batch update `CustomField` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `CustomFields` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateCustomFieldRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `CustomField` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateCustomFieldsResponse BatchUpdateCustomFields(NetworkName parent, scg::IEnumerable<UpdateCustomFieldRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateCustomFields(new BatchUpdateCustomFieldsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch update `CustomField` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `CustomFields` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateCustomFieldRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `CustomField` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateCustomFieldsResponse> BatchUpdateCustomFieldsAsync(NetworkName parent, scg::IEnumerable<UpdateCustomFieldRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateCustomFieldsAsync(new BatchUpdateCustomFieldsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch update `CustomField` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `CustomFields` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateCustomFieldRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `CustomField` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateCustomFieldsResponse> BatchUpdateCustomFieldsAsync(NetworkName parent, scg::IEnumerable<UpdateCustomFieldRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateCustomFieldsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Activates a list of `CustomField` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchActivateCustomFieldsResponse BatchActivateCustomFields(BatchActivateCustomFieldsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Activates a list of `CustomField` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateCustomFieldsResponse> BatchActivateCustomFieldsAsync(BatchActivateCustomFieldsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Activates a list of `CustomField` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateCustomFieldsResponse> BatchActivateCustomFieldsAsync(BatchActivateCustomFieldsRequest request, st::CancellationToken cancellationToken) =>
            BatchActivateCustomFieldsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Activates a list of `CustomField` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `CustomField` objects to activate.
        /// Format: `networks/{network_code}/customFields/{custom_field_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchActivateCustomFieldsResponse BatchActivateCustomFields(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateCustomFields(new BatchActivateCustomFieldsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Activates a list of `CustomField` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `CustomField` objects to activate.
        /// Format: `networks/{network_code}/customFields/{custom_field_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateCustomFieldsResponse> BatchActivateCustomFieldsAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateCustomFieldsAsync(new BatchActivateCustomFieldsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Activates a list of `CustomField` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `CustomField` objects to activate.
        /// Format: `networks/{network_code}/customFields/{custom_field_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateCustomFieldsResponse> BatchActivateCustomFieldsAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchActivateCustomFieldsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Activates a list of `CustomField` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `CustomField` objects to activate.
        /// Format: `networks/{network_code}/customFields/{custom_field_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchActivateCustomFieldsResponse BatchActivateCustomFields(NetworkName parent, scg::IEnumerable<CustomFieldName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateCustomFields(new BatchActivateCustomFieldsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CustomFieldNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Activates a list of `CustomField` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `CustomField` objects to activate.
        /// Format: `networks/{network_code}/customFields/{custom_field_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateCustomFieldsResponse> BatchActivateCustomFieldsAsync(NetworkName parent, scg::IEnumerable<CustomFieldName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateCustomFieldsAsync(new BatchActivateCustomFieldsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CustomFieldNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Activates a list of `CustomField` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `CustomField` objects to activate.
        /// Format: `networks/{network_code}/customFields/{custom_field_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateCustomFieldsResponse> BatchActivateCustomFieldsAsync(NetworkName parent, scg::IEnumerable<CustomFieldName> names, st::CancellationToken cancellationToken) =>
            BatchActivateCustomFieldsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deactivates a list of `CustomField` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDeactivateCustomFieldsResponse BatchDeactivateCustomFields(BatchDeactivateCustomFieldsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deactivates a list of `CustomField` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateCustomFieldsResponse> BatchDeactivateCustomFieldsAsync(BatchDeactivateCustomFieldsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deactivates a list of `CustomField` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateCustomFieldsResponse> BatchDeactivateCustomFieldsAsync(BatchDeactivateCustomFieldsRequest request, st::CancellationToken cancellationToken) =>
            BatchDeactivateCustomFieldsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deactivates a list of `CustomField` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `CustomField` objects to deactivate.
        /// Format: `networks/{network_code}/customFields/{custom_field_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDeactivateCustomFieldsResponse BatchDeactivateCustomFields(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateCustomFields(new BatchDeactivateCustomFieldsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deactivates a list of `CustomField` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `CustomField` objects to deactivate.
        /// Format: `networks/{network_code}/customFields/{custom_field_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateCustomFieldsResponse> BatchDeactivateCustomFieldsAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateCustomFieldsAsync(new BatchDeactivateCustomFieldsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deactivates a list of `CustomField` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `CustomField` objects to deactivate.
        /// Format: `networks/{network_code}/customFields/{custom_field_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateCustomFieldsResponse> BatchDeactivateCustomFieldsAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchDeactivateCustomFieldsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deactivates a list of `CustomField` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `CustomField` objects to deactivate.
        /// Format: `networks/{network_code}/customFields/{custom_field_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDeactivateCustomFieldsResponse BatchDeactivateCustomFields(NetworkName parent, scg::IEnumerable<CustomFieldName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateCustomFields(new BatchDeactivateCustomFieldsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CustomFieldNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deactivates a list of `CustomField` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `CustomField` objects to deactivate.
        /// Format: `networks/{network_code}/customFields/{custom_field_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateCustomFieldsResponse> BatchDeactivateCustomFieldsAsync(NetworkName parent, scg::IEnumerable<CustomFieldName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateCustomFieldsAsync(new BatchDeactivateCustomFieldsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CustomFieldNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deactivates a list of `CustomField` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `CustomField` objects to deactivate.
        /// Format: `networks/{network_code}/customFields/{custom_field_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateCustomFieldsResponse> BatchDeactivateCustomFieldsAsync(NetworkName parent, scg::IEnumerable<CustomFieldName> names, st::CancellationToken cancellationToken) =>
            BatchDeactivateCustomFieldsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CustomFieldService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `CustomField` objects.
    /// </remarks>
    public sealed partial class CustomFieldServiceClientImpl : CustomFieldServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetCustomFieldRequest, CustomField> _callGetCustomField;

        private readonly gaxgrpc::ApiCall<ListCustomFieldsRequest, ListCustomFieldsResponse> _callListCustomFields;

        private readonly gaxgrpc::ApiCall<CreateCustomFieldRequest, CustomField> _callCreateCustomField;

        private readonly gaxgrpc::ApiCall<BatchCreateCustomFieldsRequest, BatchCreateCustomFieldsResponse> _callBatchCreateCustomFields;

        private readonly gaxgrpc::ApiCall<UpdateCustomFieldRequest, CustomField> _callUpdateCustomField;

        private readonly gaxgrpc::ApiCall<BatchUpdateCustomFieldsRequest, BatchUpdateCustomFieldsResponse> _callBatchUpdateCustomFields;

        private readonly gaxgrpc::ApiCall<BatchActivateCustomFieldsRequest, BatchActivateCustomFieldsResponse> _callBatchActivateCustomFields;

        private readonly gaxgrpc::ApiCall<BatchDeactivateCustomFieldsRequest, BatchDeactivateCustomFieldsResponse> _callBatchDeactivateCustomFields;

        /// <summary>
        /// Constructs a client wrapper for the CustomFieldService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CustomFieldServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CustomFieldServiceClientImpl(CustomFieldService.CustomFieldServiceClient grpcClient, CustomFieldServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CustomFieldServiceSettings effectiveSettings = settings ?? CustomFieldServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetCustomField = clientHelper.BuildApiCall<GetCustomFieldRequest, CustomField>("GetCustomField", grpcClient.GetCustomFieldAsync, grpcClient.GetCustomField, effectiveSettings.GetCustomFieldSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCustomField);
            Modify_GetCustomFieldApiCall(ref _callGetCustomField);
            _callListCustomFields = clientHelper.BuildApiCall<ListCustomFieldsRequest, ListCustomFieldsResponse>("ListCustomFields", grpcClient.ListCustomFieldsAsync, grpcClient.ListCustomFields, effectiveSettings.ListCustomFieldsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCustomFields);
            Modify_ListCustomFieldsApiCall(ref _callListCustomFields);
            _callCreateCustomField = clientHelper.BuildApiCall<CreateCustomFieldRequest, CustomField>("CreateCustomField", grpcClient.CreateCustomFieldAsync, grpcClient.CreateCustomField, effectiveSettings.CreateCustomFieldSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateCustomField);
            Modify_CreateCustomFieldApiCall(ref _callCreateCustomField);
            _callBatchCreateCustomFields = clientHelper.BuildApiCall<BatchCreateCustomFieldsRequest, BatchCreateCustomFieldsResponse>("BatchCreateCustomFields", grpcClient.BatchCreateCustomFieldsAsync, grpcClient.BatchCreateCustomFields, effectiveSettings.BatchCreateCustomFieldsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchCreateCustomFields);
            Modify_BatchCreateCustomFieldsApiCall(ref _callBatchCreateCustomFields);
            _callUpdateCustomField = clientHelper.BuildApiCall<UpdateCustomFieldRequest, CustomField>("UpdateCustomField", grpcClient.UpdateCustomFieldAsync, grpcClient.UpdateCustomField, effectiveSettings.UpdateCustomFieldSettings).WithGoogleRequestParam("custom_field.name", request => request.CustomField?.Name);
            Modify_ApiCall(ref _callUpdateCustomField);
            Modify_UpdateCustomFieldApiCall(ref _callUpdateCustomField);
            _callBatchUpdateCustomFields = clientHelper.BuildApiCall<BatchUpdateCustomFieldsRequest, BatchUpdateCustomFieldsResponse>("BatchUpdateCustomFields", grpcClient.BatchUpdateCustomFieldsAsync, grpcClient.BatchUpdateCustomFields, effectiveSettings.BatchUpdateCustomFieldsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchUpdateCustomFields);
            Modify_BatchUpdateCustomFieldsApiCall(ref _callBatchUpdateCustomFields);
            _callBatchActivateCustomFields = clientHelper.BuildApiCall<BatchActivateCustomFieldsRequest, BatchActivateCustomFieldsResponse>("BatchActivateCustomFields", grpcClient.BatchActivateCustomFieldsAsync, grpcClient.BatchActivateCustomFields, effectiveSettings.BatchActivateCustomFieldsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchActivateCustomFields);
            Modify_BatchActivateCustomFieldsApiCall(ref _callBatchActivateCustomFields);
            _callBatchDeactivateCustomFields = clientHelper.BuildApiCall<BatchDeactivateCustomFieldsRequest, BatchDeactivateCustomFieldsResponse>("BatchDeactivateCustomFields", grpcClient.BatchDeactivateCustomFieldsAsync, grpcClient.BatchDeactivateCustomFields, effectiveSettings.BatchDeactivateCustomFieldsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchDeactivateCustomFields);
            Modify_BatchDeactivateCustomFieldsApiCall(ref _callBatchDeactivateCustomFields);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetCustomFieldApiCall(ref gaxgrpc::ApiCall<GetCustomFieldRequest, CustomField> call);

        partial void Modify_ListCustomFieldsApiCall(ref gaxgrpc::ApiCall<ListCustomFieldsRequest, ListCustomFieldsResponse> call);

        partial void Modify_CreateCustomFieldApiCall(ref gaxgrpc::ApiCall<CreateCustomFieldRequest, CustomField> call);

        partial void Modify_BatchCreateCustomFieldsApiCall(ref gaxgrpc::ApiCall<BatchCreateCustomFieldsRequest, BatchCreateCustomFieldsResponse> call);

        partial void Modify_UpdateCustomFieldApiCall(ref gaxgrpc::ApiCall<UpdateCustomFieldRequest, CustomField> call);

        partial void Modify_BatchUpdateCustomFieldsApiCall(ref gaxgrpc::ApiCall<BatchUpdateCustomFieldsRequest, BatchUpdateCustomFieldsResponse> call);

        partial void Modify_BatchActivateCustomFieldsApiCall(ref gaxgrpc::ApiCall<BatchActivateCustomFieldsRequest, BatchActivateCustomFieldsResponse> call);

        partial void Modify_BatchDeactivateCustomFieldsApiCall(ref gaxgrpc::ApiCall<BatchDeactivateCustomFieldsRequest, BatchDeactivateCustomFieldsResponse> call);

        partial void OnConstruction(CustomFieldService.CustomFieldServiceClient grpcClient, CustomFieldServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CustomFieldService client</summary>
        public override CustomFieldService.CustomFieldServiceClient GrpcClient { get; }

        partial void Modify_GetCustomFieldRequest(ref GetCustomFieldRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCustomFieldsRequest(ref ListCustomFieldsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateCustomFieldRequest(ref CreateCustomFieldRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchCreateCustomFieldsRequest(ref BatchCreateCustomFieldsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateCustomFieldRequest(ref UpdateCustomFieldRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchUpdateCustomFieldsRequest(ref BatchUpdateCustomFieldsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchActivateCustomFieldsRequest(ref BatchActivateCustomFieldsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchDeactivateCustomFieldsRequest(ref BatchDeactivateCustomFieldsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// API to retrieve a `CustomField` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CustomField GetCustomField(GetCustomFieldRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCustomFieldRequest(ref request, ref callSettings);
            return _callGetCustomField.Sync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a `CustomField` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CustomField> GetCustomFieldAsync(GetCustomFieldRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCustomFieldRequest(ref request, ref callSettings);
            return _callGetCustomField.Async(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `CustomField` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CustomField"/> resources.</returns>
        public override gax::PagedEnumerable<ListCustomFieldsResponse, CustomField> ListCustomFields(ListCustomFieldsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCustomFieldsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCustomFieldsRequest, ListCustomFieldsResponse, CustomField>(_callListCustomFields, request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `CustomField` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CustomField"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCustomFieldsResponse, CustomField> ListCustomFieldsAsync(ListCustomFieldsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCustomFieldsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCustomFieldsRequest, ListCustomFieldsResponse, CustomField>(_callListCustomFields, request, callSettings);
        }

        /// <summary>
        /// API to create a `CustomField` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CustomField CreateCustomField(CreateCustomFieldRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCustomFieldRequest(ref request, ref callSettings);
            return _callCreateCustomField.Sync(request, callSettings);
        }

        /// <summary>
        /// API to create a `CustomField` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CustomField> CreateCustomFieldAsync(CreateCustomFieldRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCustomFieldRequest(ref request, ref callSettings);
            return _callCreateCustomField.Async(request, callSettings);
        }

        /// <summary>
        /// API to batch create `CustomField` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchCreateCustomFieldsResponse BatchCreateCustomFields(BatchCreateCustomFieldsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateCustomFieldsRequest(ref request, ref callSettings);
            return _callBatchCreateCustomFields.Sync(request, callSettings);
        }

        /// <summary>
        /// API to batch create `CustomField` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchCreateCustomFieldsResponse> BatchCreateCustomFieldsAsync(BatchCreateCustomFieldsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateCustomFieldsRequest(ref request, ref callSettings);
            return _callBatchCreateCustomFields.Async(request, callSettings);
        }

        /// <summary>
        /// API to update a `CustomField` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CustomField UpdateCustomField(UpdateCustomFieldRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCustomFieldRequest(ref request, ref callSettings);
            return _callUpdateCustomField.Sync(request, callSettings);
        }

        /// <summary>
        /// API to update a `CustomField` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CustomField> UpdateCustomFieldAsync(UpdateCustomFieldRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCustomFieldRequest(ref request, ref callSettings);
            return _callUpdateCustomField.Async(request, callSettings);
        }

        /// <summary>
        /// API to batch update `CustomField` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchUpdateCustomFieldsResponse BatchUpdateCustomFields(BatchUpdateCustomFieldsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateCustomFieldsRequest(ref request, ref callSettings);
            return _callBatchUpdateCustomFields.Sync(request, callSettings);
        }

        /// <summary>
        /// API to batch update `CustomField` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchUpdateCustomFieldsResponse> BatchUpdateCustomFieldsAsync(BatchUpdateCustomFieldsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateCustomFieldsRequest(ref request, ref callSettings);
            return _callBatchUpdateCustomFields.Async(request, callSettings);
        }

        /// <summary>
        /// Activates a list of `CustomField` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchActivateCustomFieldsResponse BatchActivateCustomFields(BatchActivateCustomFieldsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchActivateCustomFieldsRequest(ref request, ref callSettings);
            return _callBatchActivateCustomFields.Sync(request, callSettings);
        }

        /// <summary>
        /// Activates a list of `CustomField` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchActivateCustomFieldsResponse> BatchActivateCustomFieldsAsync(BatchActivateCustomFieldsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchActivateCustomFieldsRequest(ref request, ref callSettings);
            return _callBatchActivateCustomFields.Async(request, callSettings);
        }

        /// <summary>
        /// Deactivates a list of `CustomField` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchDeactivateCustomFieldsResponse BatchDeactivateCustomFields(BatchDeactivateCustomFieldsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeactivateCustomFieldsRequest(ref request, ref callSettings);
            return _callBatchDeactivateCustomFields.Sync(request, callSettings);
        }

        /// <summary>
        /// Deactivates a list of `CustomField` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchDeactivateCustomFieldsResponse> BatchDeactivateCustomFieldsAsync(BatchDeactivateCustomFieldsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeactivateCustomFieldsRequest(ref request, ref callSettings);
            return _callBatchDeactivateCustomFields.Async(request, callSettings);
        }
    }

    public partial class ListCustomFieldsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCustomFieldsResponse : gaxgrpc::IPageResponse<CustomField>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<CustomField> GetEnumerator() => CustomFields.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
