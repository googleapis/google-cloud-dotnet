// Copyright 2026 Google LLC
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
    /// <summary>Settings for <see cref="CustomTargetingValueServiceClient"/> instances.</summary>
    public sealed partial class CustomTargetingValueServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CustomTargetingValueServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CustomTargetingValueServiceSettings"/>.</returns>
        public static CustomTargetingValueServiceSettings GetDefault() => new CustomTargetingValueServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CustomTargetingValueServiceSettings"/> object with default settings.
        /// </summary>
        public CustomTargetingValueServiceSettings()
        {
        }

        private CustomTargetingValueServiceSettings(CustomTargetingValueServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetCustomTargetingValueSettings = existing.GetCustomTargetingValueSettings;
            ListCustomTargetingValuesSettings = existing.ListCustomTargetingValuesSettings;
            CreateCustomTargetingValueSettings = existing.CreateCustomTargetingValueSettings;
            BatchCreateCustomTargetingValuesSettings = existing.BatchCreateCustomTargetingValuesSettings;
            UpdateCustomTargetingValueSettings = existing.UpdateCustomTargetingValueSettings;
            BatchUpdateCustomTargetingValuesSettings = existing.BatchUpdateCustomTargetingValuesSettings;
            BatchActivateCustomTargetingValuesSettings = existing.BatchActivateCustomTargetingValuesSettings;
            BatchDeactivateCustomTargetingValuesSettings = existing.BatchDeactivateCustomTargetingValuesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CustomTargetingValueServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomTargetingValueServiceClient.GetCustomTargetingValue</c> and
        /// <c>CustomTargetingValueServiceClient.GetCustomTargetingValueAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCustomTargetingValueSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomTargetingValueServiceClient.ListCustomTargetingValues</c> and
        /// <c>CustomTargetingValueServiceClient.ListCustomTargetingValuesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListCustomTargetingValuesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomTargetingValueServiceClient.CreateCustomTargetingValue</c> and
        /// <c>CustomTargetingValueServiceClient.CreateCustomTargetingValueAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateCustomTargetingValueSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomTargetingValueServiceClient.BatchCreateCustomTargetingValues</c> and
        /// <c>CustomTargetingValueServiceClient.BatchCreateCustomTargetingValuesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchCreateCustomTargetingValuesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomTargetingValueServiceClient.UpdateCustomTargetingValue</c> and
        /// <c>CustomTargetingValueServiceClient.UpdateCustomTargetingValueAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateCustomTargetingValueSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomTargetingValueServiceClient.BatchUpdateCustomTargetingValues</c> and
        /// <c>CustomTargetingValueServiceClient.BatchUpdateCustomTargetingValuesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchUpdateCustomTargetingValuesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomTargetingValueServiceClient.BatchActivateCustomTargetingValues</c> and
        /// <c>CustomTargetingValueServiceClient.BatchActivateCustomTargetingValuesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchActivateCustomTargetingValuesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomTargetingValueServiceClient.BatchDeactivateCustomTargetingValues</c> and
        /// <c>CustomTargetingValueServiceClient.BatchDeactivateCustomTargetingValuesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchDeactivateCustomTargetingValuesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CustomTargetingValueServiceSettings"/> object.</returns>
        public CustomTargetingValueServiceSettings Clone() => new CustomTargetingValueServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CustomTargetingValueServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class CustomTargetingValueServiceClientBuilder : gaxgrpc::ClientBuilderBase<CustomTargetingValueServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CustomTargetingValueServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CustomTargetingValueServiceClientBuilder() : base(CustomTargetingValueServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CustomTargetingValueServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CustomTargetingValueServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CustomTargetingValueServiceClient Build()
        {
            CustomTargetingValueServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CustomTargetingValueServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CustomTargetingValueServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CustomTargetingValueServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CustomTargetingValueServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CustomTargetingValueServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CustomTargetingValueServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CustomTargetingValueServiceClient.ChannelPool;
    }

    /// <summary>CustomTargetingValueService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `CustomTargetingValue` objects.
    /// </remarks>
    public abstract partial class CustomTargetingValueServiceClient
    {
        /// <summary>
        /// The default endpoint for the CustomTargetingValueService service, which is a host of
        /// "admanager.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default CustomTargetingValueService scopes.</summary>
        /// <remarks>
        /// The default CustomTargetingValueService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/admanager</description></item>
        /// <item><description>https://www.googleapis.com/auth/admanager.readonly</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/admanager",
            "https://www.googleapis.com/auth/admanager.readonly",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CustomTargetingValueService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CustomTargetingValueServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CustomTargetingValueServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CustomTargetingValueServiceClient"/>.</returns>
        public static stt::Task<CustomTargetingValueServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CustomTargetingValueServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CustomTargetingValueServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CustomTargetingValueServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CustomTargetingValueServiceClient"/>.</returns>
        public static CustomTargetingValueServiceClient Create() => new CustomTargetingValueServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CustomTargetingValueServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CustomTargetingValueServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CustomTargetingValueServiceClient"/>.</returns>
        internal static CustomTargetingValueServiceClient Create(grpccore::CallInvoker callInvoker, CustomTargetingValueServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CustomTargetingValueService.CustomTargetingValueServiceClient grpcClient = new CustomTargetingValueService.CustomTargetingValueServiceClient(callInvoker);
            return new CustomTargetingValueServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CustomTargetingValueService client</summary>
        public virtual CustomTargetingValueService.CustomTargetingValueServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `CustomTargetingValue` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomTargetingValue GetCustomTargetingValue(GetCustomTargetingValueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `CustomTargetingValue` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomTargetingValue> GetCustomTargetingValueAsync(GetCustomTargetingValueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `CustomTargetingValue` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomTargetingValue> GetCustomTargetingValueAsync(GetCustomTargetingValueRequest request, st::CancellationToken cancellationToken) =>
            GetCustomTargetingValueAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `CustomTargetingValue` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CustomTargetingValue.
        /// Format:
        /// `networks/{network_code}/customTargetingValues/{custom_targeting_value_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomTargetingValue GetCustomTargetingValue(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomTargetingValue(new GetCustomTargetingValueRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `CustomTargetingValue` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CustomTargetingValue.
        /// Format:
        /// `networks/{network_code}/customTargetingValues/{custom_targeting_value_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomTargetingValue> GetCustomTargetingValueAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomTargetingValueAsync(new GetCustomTargetingValueRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `CustomTargetingValue` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CustomTargetingValue.
        /// Format:
        /// `networks/{network_code}/customTargetingValues/{custom_targeting_value_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomTargetingValue> GetCustomTargetingValueAsync(string name, st::CancellationToken cancellationToken) =>
            GetCustomTargetingValueAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `CustomTargetingValue` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CustomTargetingValue.
        /// Format:
        /// `networks/{network_code}/customTargetingValues/{custom_targeting_value_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomTargetingValue GetCustomTargetingValue(CustomTargetingValueName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomTargetingValue(new GetCustomTargetingValueRequest
            {
                CustomTargetingValueName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `CustomTargetingValue` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CustomTargetingValue.
        /// Format:
        /// `networks/{network_code}/customTargetingValues/{custom_targeting_value_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomTargetingValue> GetCustomTargetingValueAsync(CustomTargetingValueName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomTargetingValueAsync(new GetCustomTargetingValueRequest
            {
                CustomTargetingValueName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `CustomTargetingValue` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CustomTargetingValue.
        /// Format:
        /// `networks/{network_code}/customTargetingValues/{custom_targeting_value_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomTargetingValue> GetCustomTargetingValueAsync(CustomTargetingValueName name, st::CancellationToken cancellationToken) =>
            GetCustomTargetingValueAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CustomTargetingValue"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCustomTargetingValuesResponse, CustomTargetingValue> ListCustomTargetingValues(ListCustomTargetingValuesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CustomTargetingValue"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCustomTargetingValuesResponse, CustomTargetingValue> ListCustomTargetingValuesAsync(ListCustomTargetingValuesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CustomTargetingValues.
        /// Format:
        /// `networks/{network_code}`
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
        /// <returns>A pageable sequence of <see cref="CustomTargetingValue"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCustomTargetingValuesResponse, CustomTargetingValue> ListCustomTargetingValues(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCustomTargetingValuesRequest request = new ListCustomTargetingValuesRequest
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
            return ListCustomTargetingValues(request, callSettings);
        }

        /// <summary>
        /// Lists `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CustomTargetingValues.
        /// Format:
        /// `networks/{network_code}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="CustomTargetingValue"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCustomTargetingValuesResponse, CustomTargetingValue> ListCustomTargetingValuesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCustomTargetingValuesRequest request = new ListCustomTargetingValuesRequest
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
            return ListCustomTargetingValuesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CustomTargetingValues.
        /// Format:
        /// `networks/{network_code}`
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
        /// <returns>A pageable sequence of <see cref="CustomTargetingValue"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCustomTargetingValuesResponse, CustomTargetingValue> ListCustomTargetingValues(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCustomTargetingValuesRequest request = new ListCustomTargetingValuesRequest
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
            return ListCustomTargetingValues(request, callSettings);
        }

        /// <summary>
        /// Lists `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CustomTargetingValues.
        /// Format:
        /// `networks/{network_code}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="CustomTargetingValue"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCustomTargetingValuesResponse, CustomTargetingValue> ListCustomTargetingValuesAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCustomTargetingValuesRequest request = new ListCustomTargetingValuesRequest
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
            return ListCustomTargetingValuesAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a `CustomTargetingValue` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomTargetingValue CreateCustomTargetingValue(CreateCustomTargetingValueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a `CustomTargetingValue` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomTargetingValue> CreateCustomTargetingValueAsync(CreateCustomTargetingValueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a `CustomTargetingValue` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomTargetingValue> CreateCustomTargetingValueAsync(CreateCustomTargetingValueRequest request, st::CancellationToken cancellationToken) =>
            CreateCustomTargetingValueAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a `CustomTargetingValue` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CustomTargetingValues.
        /// Format:
        /// `networks/{network_code}`
        /// </param>
        /// <param name="customTargetingValue">
        /// Required. The `CustomTargetingValue` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomTargetingValue CreateCustomTargetingValue(string parent, CustomTargetingValue customTargetingValue, gaxgrpc::CallSettings callSettings = null) =>
            CreateCustomTargetingValue(new CreateCustomTargetingValueRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CustomTargetingValue = gax::GaxPreconditions.CheckNotNull(customTargetingValue, nameof(customTargetingValue)),
            }, callSettings);

        /// <summary>
        /// Creates a `CustomTargetingValue` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CustomTargetingValues.
        /// Format:
        /// `networks/{network_code}`
        /// </param>
        /// <param name="customTargetingValue">
        /// Required. The `CustomTargetingValue` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomTargetingValue> CreateCustomTargetingValueAsync(string parent, CustomTargetingValue customTargetingValue, gaxgrpc::CallSettings callSettings = null) =>
            CreateCustomTargetingValueAsync(new CreateCustomTargetingValueRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CustomTargetingValue = gax::GaxPreconditions.CheckNotNull(customTargetingValue, nameof(customTargetingValue)),
            }, callSettings);

        /// <summary>
        /// Creates a `CustomTargetingValue` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CustomTargetingValues.
        /// Format:
        /// `networks/{network_code}`
        /// </param>
        /// <param name="customTargetingValue">
        /// Required. The `CustomTargetingValue` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomTargetingValue> CreateCustomTargetingValueAsync(string parent, CustomTargetingValue customTargetingValue, st::CancellationToken cancellationToken) =>
            CreateCustomTargetingValueAsync(parent, customTargetingValue, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a `CustomTargetingValue` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CustomTargetingValues.
        /// Format:
        /// `networks/{network_code}`
        /// </param>
        /// <param name="customTargetingValue">
        /// Required. The `CustomTargetingValue` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomTargetingValue CreateCustomTargetingValue(NetworkName parent, CustomTargetingValue customTargetingValue, gaxgrpc::CallSettings callSettings = null) =>
            CreateCustomTargetingValue(new CreateCustomTargetingValueRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CustomTargetingValue = gax::GaxPreconditions.CheckNotNull(customTargetingValue, nameof(customTargetingValue)),
            }, callSettings);

        /// <summary>
        /// Creates a `CustomTargetingValue` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CustomTargetingValues.
        /// Format:
        /// `networks/{network_code}`
        /// </param>
        /// <param name="customTargetingValue">
        /// Required. The `CustomTargetingValue` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomTargetingValue> CreateCustomTargetingValueAsync(NetworkName parent, CustomTargetingValue customTargetingValue, gaxgrpc::CallSettings callSettings = null) =>
            CreateCustomTargetingValueAsync(new CreateCustomTargetingValueRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CustomTargetingValue = gax::GaxPreconditions.CheckNotNull(customTargetingValue, nameof(customTargetingValue)),
            }, callSettings);

        /// <summary>
        /// Creates a `CustomTargetingValue` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CustomTargetingValues.
        /// Format:
        /// `networks/{network_code}`
        /// </param>
        /// <param name="customTargetingValue">
        /// Required. The `CustomTargetingValue` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomTargetingValue> CreateCustomTargetingValueAsync(NetworkName parent, CustomTargetingValue customTargetingValue, st::CancellationToken cancellationToken) =>
            CreateCustomTargetingValueAsync(parent, customTargetingValue, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateCustomTargetingValuesResponse BatchCreateCustomTargetingValues(BatchCreateCustomTargetingValuesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateCustomTargetingValuesResponse> BatchCreateCustomTargetingValuesAsync(BatchCreateCustomTargetingValuesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateCustomTargetingValuesResponse> BatchCreateCustomTargetingValuesAsync(BatchCreateCustomTargetingValuesRequest request, st::CancellationToken cancellationToken) =>
            BatchCreateCustomTargetingValuesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CustomTargetingValues.
        /// Format:
        /// `networks/{network_code}`
        /// </param>
        /// <param name="requests">
        /// Required. The `CustomTargetingValue` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateCustomTargetingValuesResponse BatchCreateCustomTargetingValues(string parent, scg::IEnumerable<CreateCustomTargetingValueRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateCustomTargetingValues(new BatchCreateCustomTargetingValuesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CustomTargetingValues.
        /// Format:
        /// `networks/{network_code}`
        /// </param>
        /// <param name="requests">
        /// Required. The `CustomTargetingValue` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateCustomTargetingValuesResponse> BatchCreateCustomTargetingValuesAsync(string parent, scg::IEnumerable<CreateCustomTargetingValueRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateCustomTargetingValuesAsync(new BatchCreateCustomTargetingValuesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CustomTargetingValues.
        /// Format:
        /// `networks/{network_code}`
        /// </param>
        /// <param name="requests">
        /// Required. The `CustomTargetingValue` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateCustomTargetingValuesResponse> BatchCreateCustomTargetingValuesAsync(string parent, scg::IEnumerable<CreateCustomTargetingValueRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateCustomTargetingValuesAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CustomTargetingValues.
        /// Format:
        /// `networks/{network_code}`
        /// </param>
        /// <param name="requests">
        /// Required. The `CustomTargetingValue` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateCustomTargetingValuesResponse BatchCreateCustomTargetingValues(NetworkName parent, scg::IEnumerable<CreateCustomTargetingValueRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateCustomTargetingValues(new BatchCreateCustomTargetingValuesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CustomTargetingValues.
        /// Format:
        /// `networks/{network_code}`
        /// </param>
        /// <param name="requests">
        /// Required. The `CustomTargetingValue` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateCustomTargetingValuesResponse> BatchCreateCustomTargetingValuesAsync(NetworkName parent, scg::IEnumerable<CreateCustomTargetingValueRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateCustomTargetingValuesAsync(new BatchCreateCustomTargetingValuesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CustomTargetingValues.
        /// Format:
        /// `networks/{network_code}`
        /// </param>
        /// <param name="requests">
        /// Required. The `CustomTargetingValue` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateCustomTargetingValuesResponse> BatchCreateCustomTargetingValuesAsync(NetworkName parent, scg::IEnumerable<CreateCustomTargetingValueRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateCustomTargetingValuesAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a `CustomTargetingValue` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomTargetingValue UpdateCustomTargetingValue(UpdateCustomTargetingValueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `CustomTargetingValue` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomTargetingValue> UpdateCustomTargetingValueAsync(UpdateCustomTargetingValueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `CustomTargetingValue` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomTargetingValue> UpdateCustomTargetingValueAsync(UpdateCustomTargetingValueRequest request, st::CancellationToken cancellationToken) =>
            UpdateCustomTargetingValueAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a `CustomTargetingValue` object.
        /// </summary>
        /// <param name="customTargetingValue">
        /// Required. The `CustomTargetingValue` to update.
        /// 
        /// The `CustomTargetingValue`'s `name` is used to identify the
        /// `CustomTargetingValue` to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomTargetingValue UpdateCustomTargetingValue(CustomTargetingValue customTargetingValue, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCustomTargetingValue(new UpdateCustomTargetingValueRequest
            {
                CustomTargetingValue = gax::GaxPreconditions.CheckNotNull(customTargetingValue, nameof(customTargetingValue)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a `CustomTargetingValue` object.
        /// </summary>
        /// <param name="customTargetingValue">
        /// Required. The `CustomTargetingValue` to update.
        /// 
        /// The `CustomTargetingValue`'s `name` is used to identify the
        /// `CustomTargetingValue` to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomTargetingValue> UpdateCustomTargetingValueAsync(CustomTargetingValue customTargetingValue, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCustomTargetingValueAsync(new UpdateCustomTargetingValueRequest
            {
                CustomTargetingValue = gax::GaxPreconditions.CheckNotNull(customTargetingValue, nameof(customTargetingValue)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a `CustomTargetingValue` object.
        /// </summary>
        /// <param name="customTargetingValue">
        /// Required. The `CustomTargetingValue` to update.
        /// 
        /// The `CustomTargetingValue`'s `name` is used to identify the
        /// `CustomTargetingValue` to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomTargetingValue> UpdateCustomTargetingValueAsync(CustomTargetingValue customTargetingValue, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateCustomTargetingValueAsync(customTargetingValue, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateCustomTargetingValuesResponse BatchUpdateCustomTargetingValues(BatchUpdateCustomTargetingValuesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch updates `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateCustomTargetingValuesResponse> BatchUpdateCustomTargetingValuesAsync(BatchUpdateCustomTargetingValuesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch updates `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateCustomTargetingValuesResponse> BatchUpdateCustomTargetingValuesAsync(BatchUpdateCustomTargetingValuesRequest request, st::CancellationToken cancellationToken) =>
            BatchUpdateCustomTargetingValuesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CustomTargetingValues.
        /// Format:
        /// `networks/{network_code}`
        /// </param>
        /// <param name="requests">
        /// Required. The `CustomTargetingValue` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateCustomTargetingValuesResponse BatchUpdateCustomTargetingValues(string parent, scg::IEnumerable<UpdateCustomTargetingValueRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateCustomTargetingValues(new BatchUpdateCustomTargetingValuesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CustomTargetingValues.
        /// Format:
        /// `networks/{network_code}`
        /// </param>
        /// <param name="requests">
        /// Required. The `CustomTargetingValue` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateCustomTargetingValuesResponse> BatchUpdateCustomTargetingValuesAsync(string parent, scg::IEnumerable<UpdateCustomTargetingValueRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateCustomTargetingValuesAsync(new BatchUpdateCustomTargetingValuesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CustomTargetingValues.
        /// Format:
        /// `networks/{network_code}`
        /// </param>
        /// <param name="requests">
        /// Required. The `CustomTargetingValue` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateCustomTargetingValuesResponse> BatchUpdateCustomTargetingValuesAsync(string parent, scg::IEnumerable<UpdateCustomTargetingValueRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateCustomTargetingValuesAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CustomTargetingValues.
        /// Format:
        /// `networks/{network_code}`
        /// </param>
        /// <param name="requests">
        /// Required. The `CustomTargetingValue` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateCustomTargetingValuesResponse BatchUpdateCustomTargetingValues(NetworkName parent, scg::IEnumerable<UpdateCustomTargetingValueRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateCustomTargetingValues(new BatchUpdateCustomTargetingValuesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CustomTargetingValues.
        /// Format:
        /// `networks/{network_code}`
        /// </param>
        /// <param name="requests">
        /// Required. The `CustomTargetingValue` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateCustomTargetingValuesResponse> BatchUpdateCustomTargetingValuesAsync(NetworkName parent, scg::IEnumerable<UpdateCustomTargetingValueRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateCustomTargetingValuesAsync(new BatchUpdateCustomTargetingValuesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CustomTargetingValues.
        /// Format:
        /// `networks/{network_code}`
        /// </param>
        /// <param name="requests">
        /// Required. The `CustomTargetingValue` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateCustomTargetingValuesResponse> BatchUpdateCustomTargetingValuesAsync(NetworkName parent, scg::IEnumerable<UpdateCustomTargetingValueRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateCustomTargetingValuesAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch activates `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchActivateCustomTargetingValuesResponse BatchActivateCustomTargetingValues(BatchActivateCustomTargetingValuesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch activates `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateCustomTargetingValuesResponse> BatchActivateCustomTargetingValuesAsync(BatchActivateCustomTargetingValuesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch activates `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateCustomTargetingValuesResponse> BatchActivateCustomTargetingValuesAsync(BatchActivateCustomTargetingValuesRequest request, st::CancellationToken cancellationToken) =>
            BatchActivateCustomTargetingValuesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch activates `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CustomTargetingValues.
        /// Format:
        /// `networks/{network_code}`
        /// </param>
        /// <param name="requests">
        /// Required. The `CustomTargetingValue` objects to activate.
        /// A maximum of 100 objects can be activated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchActivateCustomTargetingValuesResponse BatchActivateCustomTargetingValues(string parent, scg::IEnumerable<ActivateCustomTargetingValueRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateCustomTargetingValues(new BatchActivateCustomTargetingValuesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch activates `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CustomTargetingValues.
        /// Format:
        /// `networks/{network_code}`
        /// </param>
        /// <param name="requests">
        /// Required. The `CustomTargetingValue` objects to activate.
        /// A maximum of 100 objects can be activated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateCustomTargetingValuesResponse> BatchActivateCustomTargetingValuesAsync(string parent, scg::IEnumerable<ActivateCustomTargetingValueRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateCustomTargetingValuesAsync(new BatchActivateCustomTargetingValuesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch activates `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CustomTargetingValues.
        /// Format:
        /// `networks/{network_code}`
        /// </param>
        /// <param name="requests">
        /// Required. The `CustomTargetingValue` objects to activate.
        /// A maximum of 100 objects can be activated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateCustomTargetingValuesResponse> BatchActivateCustomTargetingValuesAsync(string parent, scg::IEnumerable<ActivateCustomTargetingValueRequest> requests, st::CancellationToken cancellationToken) =>
            BatchActivateCustomTargetingValuesAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch activates `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CustomTargetingValues.
        /// Format:
        /// `networks/{network_code}`
        /// </param>
        /// <param name="requests">
        /// Required. The `CustomTargetingValue` objects to activate.
        /// A maximum of 100 objects can be activated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchActivateCustomTargetingValuesResponse BatchActivateCustomTargetingValues(NetworkName parent, scg::IEnumerable<ActivateCustomTargetingValueRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateCustomTargetingValues(new BatchActivateCustomTargetingValuesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch activates `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CustomTargetingValues.
        /// Format:
        /// `networks/{network_code}`
        /// </param>
        /// <param name="requests">
        /// Required. The `CustomTargetingValue` objects to activate.
        /// A maximum of 100 objects can be activated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateCustomTargetingValuesResponse> BatchActivateCustomTargetingValuesAsync(NetworkName parent, scg::IEnumerable<ActivateCustomTargetingValueRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateCustomTargetingValuesAsync(new BatchActivateCustomTargetingValuesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch activates `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CustomTargetingValues.
        /// Format:
        /// `networks/{network_code}`
        /// </param>
        /// <param name="requests">
        /// Required. The `CustomTargetingValue` objects to activate.
        /// A maximum of 100 objects can be activated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateCustomTargetingValuesResponse> BatchActivateCustomTargetingValuesAsync(NetworkName parent, scg::IEnumerable<ActivateCustomTargetingValueRequest> requests, st::CancellationToken cancellationToken) =>
            BatchActivateCustomTargetingValuesAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deactivates a list of `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDeactivateCustomTargetingValuesResponse BatchDeactivateCustomTargetingValues(BatchDeactivateCustomTargetingValuesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deactivates a list of `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateCustomTargetingValuesResponse> BatchDeactivateCustomTargetingValuesAsync(BatchDeactivateCustomTargetingValuesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deactivates a list of `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateCustomTargetingValuesResponse> BatchDeactivateCustomTargetingValuesAsync(BatchDeactivateCustomTargetingValuesRequest request, st::CancellationToken cancellationToken) =>
            BatchDeactivateCustomTargetingValuesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deactivates a list of `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CustomTargetingValues.
        /// Format:
        /// `networks/{network_code}/`
        /// </param>
        /// <param name="requests">
        /// Required. The `CustomTargetingValue` objects to deactivate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDeactivateCustomTargetingValuesResponse BatchDeactivateCustomTargetingValues(string parent, scg::IEnumerable<DeactivateCustomTargetingValueRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateCustomTargetingValues(new BatchDeactivateCustomTargetingValuesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Deactivates a list of `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CustomTargetingValues.
        /// Format:
        /// `networks/{network_code}/`
        /// </param>
        /// <param name="requests">
        /// Required. The `CustomTargetingValue` objects to deactivate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateCustomTargetingValuesResponse> BatchDeactivateCustomTargetingValuesAsync(string parent, scg::IEnumerable<DeactivateCustomTargetingValueRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateCustomTargetingValuesAsync(new BatchDeactivateCustomTargetingValuesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Deactivates a list of `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CustomTargetingValues.
        /// Format:
        /// `networks/{network_code}/`
        /// </param>
        /// <param name="requests">
        /// Required. The `CustomTargetingValue` objects to deactivate.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateCustomTargetingValuesResponse> BatchDeactivateCustomTargetingValuesAsync(string parent, scg::IEnumerable<DeactivateCustomTargetingValueRequest> requests, st::CancellationToken cancellationToken) =>
            BatchDeactivateCustomTargetingValuesAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deactivates a list of `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CustomTargetingValues.
        /// Format:
        /// `networks/{network_code}/`
        /// </param>
        /// <param name="requests">
        /// Required. The `CustomTargetingValue` objects to deactivate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDeactivateCustomTargetingValuesResponse BatchDeactivateCustomTargetingValues(NetworkName parent, scg::IEnumerable<DeactivateCustomTargetingValueRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateCustomTargetingValues(new BatchDeactivateCustomTargetingValuesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Deactivates a list of `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CustomTargetingValues.
        /// Format:
        /// `networks/{network_code}/`
        /// </param>
        /// <param name="requests">
        /// Required. The `CustomTargetingValue` objects to deactivate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateCustomTargetingValuesResponse> BatchDeactivateCustomTargetingValuesAsync(NetworkName parent, scg::IEnumerable<DeactivateCustomTargetingValueRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateCustomTargetingValuesAsync(new BatchDeactivateCustomTargetingValuesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Deactivates a list of `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of CustomTargetingValues.
        /// Format:
        /// `networks/{network_code}/`
        /// </param>
        /// <param name="requests">
        /// Required. The `CustomTargetingValue` objects to deactivate.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateCustomTargetingValuesResponse> BatchDeactivateCustomTargetingValuesAsync(NetworkName parent, scg::IEnumerable<DeactivateCustomTargetingValueRequest> requests, st::CancellationToken cancellationToken) =>
            BatchDeactivateCustomTargetingValuesAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CustomTargetingValueService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `CustomTargetingValue` objects.
    /// </remarks>
    public sealed partial class CustomTargetingValueServiceClientImpl : CustomTargetingValueServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetCustomTargetingValueRequest, CustomTargetingValue> _callGetCustomTargetingValue;

        private readonly gaxgrpc::ApiCall<ListCustomTargetingValuesRequest, ListCustomTargetingValuesResponse> _callListCustomTargetingValues;

        private readonly gaxgrpc::ApiCall<CreateCustomTargetingValueRequest, CustomTargetingValue> _callCreateCustomTargetingValue;

        private readonly gaxgrpc::ApiCall<BatchCreateCustomTargetingValuesRequest, BatchCreateCustomTargetingValuesResponse> _callBatchCreateCustomTargetingValues;

        private readonly gaxgrpc::ApiCall<UpdateCustomTargetingValueRequest, CustomTargetingValue> _callUpdateCustomTargetingValue;

        private readonly gaxgrpc::ApiCall<BatchUpdateCustomTargetingValuesRequest, BatchUpdateCustomTargetingValuesResponse> _callBatchUpdateCustomTargetingValues;

        private readonly gaxgrpc::ApiCall<BatchActivateCustomTargetingValuesRequest, BatchActivateCustomTargetingValuesResponse> _callBatchActivateCustomTargetingValues;

        private readonly gaxgrpc::ApiCall<BatchDeactivateCustomTargetingValuesRequest, BatchDeactivateCustomTargetingValuesResponse> _callBatchDeactivateCustomTargetingValues;

        /// <summary>
        /// Constructs a client wrapper for the CustomTargetingValueService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="CustomTargetingValueServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CustomTargetingValueServiceClientImpl(CustomTargetingValueService.CustomTargetingValueServiceClient grpcClient, CustomTargetingValueServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CustomTargetingValueServiceSettings effectiveSettings = settings ?? CustomTargetingValueServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetCustomTargetingValue = clientHelper.BuildApiCall<GetCustomTargetingValueRequest, CustomTargetingValue>("GetCustomTargetingValue", grpcClient.GetCustomTargetingValueAsync, grpcClient.GetCustomTargetingValue, effectiveSettings.GetCustomTargetingValueSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCustomTargetingValue);
            Modify_GetCustomTargetingValueApiCall(ref _callGetCustomTargetingValue);
            _callListCustomTargetingValues = clientHelper.BuildApiCall<ListCustomTargetingValuesRequest, ListCustomTargetingValuesResponse>("ListCustomTargetingValues", grpcClient.ListCustomTargetingValuesAsync, grpcClient.ListCustomTargetingValues, effectiveSettings.ListCustomTargetingValuesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCustomTargetingValues);
            Modify_ListCustomTargetingValuesApiCall(ref _callListCustomTargetingValues);
            _callCreateCustomTargetingValue = clientHelper.BuildApiCall<CreateCustomTargetingValueRequest, CustomTargetingValue>("CreateCustomTargetingValue", grpcClient.CreateCustomTargetingValueAsync, grpcClient.CreateCustomTargetingValue, effectiveSettings.CreateCustomTargetingValueSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateCustomTargetingValue);
            Modify_CreateCustomTargetingValueApiCall(ref _callCreateCustomTargetingValue);
            _callBatchCreateCustomTargetingValues = clientHelper.BuildApiCall<BatchCreateCustomTargetingValuesRequest, BatchCreateCustomTargetingValuesResponse>("BatchCreateCustomTargetingValues", grpcClient.BatchCreateCustomTargetingValuesAsync, grpcClient.BatchCreateCustomTargetingValues, effectiveSettings.BatchCreateCustomTargetingValuesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchCreateCustomTargetingValues);
            Modify_BatchCreateCustomTargetingValuesApiCall(ref _callBatchCreateCustomTargetingValues);
            _callUpdateCustomTargetingValue = clientHelper.BuildApiCall<UpdateCustomTargetingValueRequest, CustomTargetingValue>("UpdateCustomTargetingValue", grpcClient.UpdateCustomTargetingValueAsync, grpcClient.UpdateCustomTargetingValue, effectiveSettings.UpdateCustomTargetingValueSettings).WithGoogleRequestParam("custom_targeting_value.name", request => request.CustomTargetingValue?.Name);
            Modify_ApiCall(ref _callUpdateCustomTargetingValue);
            Modify_UpdateCustomTargetingValueApiCall(ref _callUpdateCustomTargetingValue);
            _callBatchUpdateCustomTargetingValues = clientHelper.BuildApiCall<BatchUpdateCustomTargetingValuesRequest, BatchUpdateCustomTargetingValuesResponse>("BatchUpdateCustomTargetingValues", grpcClient.BatchUpdateCustomTargetingValuesAsync, grpcClient.BatchUpdateCustomTargetingValues, effectiveSettings.BatchUpdateCustomTargetingValuesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchUpdateCustomTargetingValues);
            Modify_BatchUpdateCustomTargetingValuesApiCall(ref _callBatchUpdateCustomTargetingValues);
            _callBatchActivateCustomTargetingValues = clientHelper.BuildApiCall<BatchActivateCustomTargetingValuesRequest, BatchActivateCustomTargetingValuesResponse>("BatchActivateCustomTargetingValues", grpcClient.BatchActivateCustomTargetingValuesAsync, grpcClient.BatchActivateCustomTargetingValues, effectiveSettings.BatchActivateCustomTargetingValuesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchActivateCustomTargetingValues);
            Modify_BatchActivateCustomTargetingValuesApiCall(ref _callBatchActivateCustomTargetingValues);
            _callBatchDeactivateCustomTargetingValues = clientHelper.BuildApiCall<BatchDeactivateCustomTargetingValuesRequest, BatchDeactivateCustomTargetingValuesResponse>("BatchDeactivateCustomTargetingValues", grpcClient.BatchDeactivateCustomTargetingValuesAsync, grpcClient.BatchDeactivateCustomTargetingValues, effectiveSettings.BatchDeactivateCustomTargetingValuesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchDeactivateCustomTargetingValues);
            Modify_BatchDeactivateCustomTargetingValuesApiCall(ref _callBatchDeactivateCustomTargetingValues);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetCustomTargetingValueApiCall(ref gaxgrpc::ApiCall<GetCustomTargetingValueRequest, CustomTargetingValue> call);

        partial void Modify_ListCustomTargetingValuesApiCall(ref gaxgrpc::ApiCall<ListCustomTargetingValuesRequest, ListCustomTargetingValuesResponse> call);

        partial void Modify_CreateCustomTargetingValueApiCall(ref gaxgrpc::ApiCall<CreateCustomTargetingValueRequest, CustomTargetingValue> call);

        partial void Modify_BatchCreateCustomTargetingValuesApiCall(ref gaxgrpc::ApiCall<BatchCreateCustomTargetingValuesRequest, BatchCreateCustomTargetingValuesResponse> call);

        partial void Modify_UpdateCustomTargetingValueApiCall(ref gaxgrpc::ApiCall<UpdateCustomTargetingValueRequest, CustomTargetingValue> call);

        partial void Modify_BatchUpdateCustomTargetingValuesApiCall(ref gaxgrpc::ApiCall<BatchUpdateCustomTargetingValuesRequest, BatchUpdateCustomTargetingValuesResponse> call);

        partial void Modify_BatchActivateCustomTargetingValuesApiCall(ref gaxgrpc::ApiCall<BatchActivateCustomTargetingValuesRequest, BatchActivateCustomTargetingValuesResponse> call);

        partial void Modify_BatchDeactivateCustomTargetingValuesApiCall(ref gaxgrpc::ApiCall<BatchDeactivateCustomTargetingValuesRequest, BatchDeactivateCustomTargetingValuesResponse> call);

        partial void OnConstruction(CustomTargetingValueService.CustomTargetingValueServiceClient grpcClient, CustomTargetingValueServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CustomTargetingValueService client</summary>
        public override CustomTargetingValueService.CustomTargetingValueServiceClient GrpcClient { get; }

        partial void Modify_GetCustomTargetingValueRequest(ref GetCustomTargetingValueRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCustomTargetingValuesRequest(ref ListCustomTargetingValuesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateCustomTargetingValueRequest(ref CreateCustomTargetingValueRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchCreateCustomTargetingValuesRequest(ref BatchCreateCustomTargetingValuesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateCustomTargetingValueRequest(ref UpdateCustomTargetingValueRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchUpdateCustomTargetingValuesRequest(ref BatchUpdateCustomTargetingValuesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchActivateCustomTargetingValuesRequest(ref BatchActivateCustomTargetingValuesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchDeactivateCustomTargetingValuesRequest(ref BatchDeactivateCustomTargetingValuesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves a `CustomTargetingValue` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CustomTargetingValue GetCustomTargetingValue(GetCustomTargetingValueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCustomTargetingValueRequest(ref request, ref callSettings);
            return _callGetCustomTargetingValue.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a `CustomTargetingValue` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CustomTargetingValue> GetCustomTargetingValueAsync(GetCustomTargetingValueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCustomTargetingValueRequest(ref request, ref callSettings);
            return _callGetCustomTargetingValue.Async(request, callSettings);
        }

        /// <summary>
        /// Lists `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CustomTargetingValue"/> resources.</returns>
        public override gax::PagedEnumerable<ListCustomTargetingValuesResponse, CustomTargetingValue> ListCustomTargetingValues(ListCustomTargetingValuesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCustomTargetingValuesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCustomTargetingValuesRequest, ListCustomTargetingValuesResponse, CustomTargetingValue>(_callListCustomTargetingValues, request, callSettings);
        }

        /// <summary>
        /// Lists `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CustomTargetingValue"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCustomTargetingValuesResponse, CustomTargetingValue> ListCustomTargetingValuesAsync(ListCustomTargetingValuesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCustomTargetingValuesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCustomTargetingValuesRequest, ListCustomTargetingValuesResponse, CustomTargetingValue>(_callListCustomTargetingValues, request, callSettings);
        }

        /// <summary>
        /// Creates a `CustomTargetingValue` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CustomTargetingValue CreateCustomTargetingValue(CreateCustomTargetingValueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCustomTargetingValueRequest(ref request, ref callSettings);
            return _callCreateCustomTargetingValue.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a `CustomTargetingValue` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CustomTargetingValue> CreateCustomTargetingValueAsync(CreateCustomTargetingValueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCustomTargetingValueRequest(ref request, ref callSettings);
            return _callCreateCustomTargetingValue.Async(request, callSettings);
        }

        /// <summary>
        /// Creates `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchCreateCustomTargetingValuesResponse BatchCreateCustomTargetingValues(BatchCreateCustomTargetingValuesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateCustomTargetingValuesRequest(ref request, ref callSettings);
            return _callBatchCreateCustomTargetingValues.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchCreateCustomTargetingValuesResponse> BatchCreateCustomTargetingValuesAsync(BatchCreateCustomTargetingValuesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateCustomTargetingValuesRequest(ref request, ref callSettings);
            return _callBatchCreateCustomTargetingValues.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a `CustomTargetingValue` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CustomTargetingValue UpdateCustomTargetingValue(UpdateCustomTargetingValueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCustomTargetingValueRequest(ref request, ref callSettings);
            return _callUpdateCustomTargetingValue.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a `CustomTargetingValue` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CustomTargetingValue> UpdateCustomTargetingValueAsync(UpdateCustomTargetingValueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCustomTargetingValueRequest(ref request, ref callSettings);
            return _callUpdateCustomTargetingValue.Async(request, callSettings);
        }

        /// <summary>
        /// Batch updates `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchUpdateCustomTargetingValuesResponse BatchUpdateCustomTargetingValues(BatchUpdateCustomTargetingValuesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateCustomTargetingValuesRequest(ref request, ref callSettings);
            return _callBatchUpdateCustomTargetingValues.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch updates `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchUpdateCustomTargetingValuesResponse> BatchUpdateCustomTargetingValuesAsync(BatchUpdateCustomTargetingValuesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateCustomTargetingValuesRequest(ref request, ref callSettings);
            return _callBatchUpdateCustomTargetingValues.Async(request, callSettings);
        }

        /// <summary>
        /// Batch activates `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchActivateCustomTargetingValuesResponse BatchActivateCustomTargetingValues(BatchActivateCustomTargetingValuesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchActivateCustomTargetingValuesRequest(ref request, ref callSettings);
            return _callBatchActivateCustomTargetingValues.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch activates `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchActivateCustomTargetingValuesResponse> BatchActivateCustomTargetingValuesAsync(BatchActivateCustomTargetingValuesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchActivateCustomTargetingValuesRequest(ref request, ref callSettings);
            return _callBatchActivateCustomTargetingValues.Async(request, callSettings);
        }

        /// <summary>
        /// Deactivates a list of `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchDeactivateCustomTargetingValuesResponse BatchDeactivateCustomTargetingValues(BatchDeactivateCustomTargetingValuesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeactivateCustomTargetingValuesRequest(ref request, ref callSettings);
            return _callBatchDeactivateCustomTargetingValues.Sync(request, callSettings);
        }

        /// <summary>
        /// Deactivates a list of `CustomTargetingValue` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchDeactivateCustomTargetingValuesResponse> BatchDeactivateCustomTargetingValuesAsync(BatchDeactivateCustomTargetingValuesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeactivateCustomTargetingValuesRequest(ref request, ref callSettings);
            return _callBatchDeactivateCustomTargetingValues.Async(request, callSettings);
        }
    }

    public partial class ListCustomTargetingValuesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCustomTargetingValuesResponse : gaxgrpc::IPageResponse<CustomTargetingValue>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<CustomTargetingValue> GetEnumerator() => CustomTargetingValues.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
