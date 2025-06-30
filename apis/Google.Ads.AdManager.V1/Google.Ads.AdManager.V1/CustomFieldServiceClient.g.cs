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
    }

    /// <summary>CustomFieldService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `CustomField` objects.
    /// </remarks>
    public sealed partial class CustomFieldServiceClientImpl : CustomFieldServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetCustomFieldRequest, CustomField> _callGetCustomField;

        private readonly gaxgrpc::ApiCall<ListCustomFieldsRequest, ListCustomFieldsResponse> _callListCustomFields;

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
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetCustomFieldApiCall(ref gaxgrpc::ApiCall<GetCustomFieldRequest, CustomField> call);

        partial void Modify_ListCustomFieldsApiCall(ref gaxgrpc::ApiCall<ListCustomFieldsRequest, ListCustomFieldsResponse> call);

        partial void OnConstruction(CustomFieldService.CustomFieldServiceClient grpcClient, CustomFieldServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CustomFieldService client</summary>
        public override CustomFieldService.CustomFieldServiceClient GrpcClient { get; }

        partial void Modify_GetCustomFieldRequest(ref GetCustomFieldRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCustomFieldsRequest(ref ListCustomFieldsRequest request, ref gaxgrpc::CallSettings settings);

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
