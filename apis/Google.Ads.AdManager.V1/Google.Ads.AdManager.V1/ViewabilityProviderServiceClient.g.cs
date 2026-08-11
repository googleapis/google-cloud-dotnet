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
    /// <summary>Settings for <see cref="ViewabilityProviderServiceClient"/> instances.</summary>
    public sealed partial class ViewabilityProviderServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ViewabilityProviderServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ViewabilityProviderServiceSettings"/>.</returns>
        public static ViewabilityProviderServiceSettings GetDefault() => new ViewabilityProviderServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ViewabilityProviderServiceSettings"/> object with default settings.
        /// </summary>
        public ViewabilityProviderServiceSettings()
        {
        }

        private ViewabilityProviderServiceSettings(ViewabilityProviderServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetViewabilityProviderSettings = existing.GetViewabilityProviderSettings;
            ListViewabilityProvidersSettings = existing.ListViewabilityProvidersSettings;
            CreateViewabilityProviderSettings = existing.CreateViewabilityProviderSettings;
            BatchCreateViewabilityProvidersSettings = existing.BatchCreateViewabilityProvidersSettings;
            UpdateViewabilityProviderSettings = existing.UpdateViewabilityProviderSettings;
            BatchUpdateViewabilityProvidersSettings = existing.BatchUpdateViewabilityProvidersSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ViewabilityProviderServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ViewabilityProviderServiceClient.GetViewabilityProvider</c> and
        /// <c>ViewabilityProviderServiceClient.GetViewabilityProviderAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetViewabilityProviderSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ViewabilityProviderServiceClient.ListViewabilityProviders</c> and
        /// <c>ViewabilityProviderServiceClient.ListViewabilityProvidersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListViewabilityProvidersSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ViewabilityProviderServiceClient.CreateViewabilityProvider</c> and
        /// <c>ViewabilityProviderServiceClient.CreateViewabilityProviderAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateViewabilityProviderSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ViewabilityProviderServiceClient.BatchCreateViewabilityProviders</c> and
        /// <c>ViewabilityProviderServiceClient.BatchCreateViewabilityProvidersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchCreateViewabilityProvidersSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ViewabilityProviderServiceClient.UpdateViewabilityProvider</c> and
        /// <c>ViewabilityProviderServiceClient.UpdateViewabilityProviderAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateViewabilityProviderSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ViewabilityProviderServiceClient.BatchUpdateViewabilityProviders</c> and
        /// <c>ViewabilityProviderServiceClient.BatchUpdateViewabilityProvidersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchUpdateViewabilityProvidersSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ViewabilityProviderServiceSettings"/> object.</returns>
        public ViewabilityProviderServiceSettings Clone() => new ViewabilityProviderServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ViewabilityProviderServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class ViewabilityProviderServiceClientBuilder : gaxgrpc::ClientBuilderBase<ViewabilityProviderServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ViewabilityProviderServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ViewabilityProviderServiceClientBuilder() : base(ViewabilityProviderServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ViewabilityProviderServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ViewabilityProviderServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ViewabilityProviderServiceClient Build()
        {
            ViewabilityProviderServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ViewabilityProviderServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ViewabilityProviderServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ViewabilityProviderServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ViewabilityProviderServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ViewabilityProviderServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ViewabilityProviderServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ViewabilityProviderServiceClient.ChannelPool;
    }

    /// <summary>ViewabilityProviderService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling
    /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] objects.
    /// </remarks>
    public abstract partial class ViewabilityProviderServiceClient
    {
        /// <summary>
        /// The default endpoint for the ViewabilityProviderService service, which is a host of
        /// "admanager.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default ViewabilityProviderService scopes.</summary>
        /// <remarks>
        /// The default ViewabilityProviderService scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ViewabilityProviderService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ViewabilityProviderServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="ViewabilityProviderServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ViewabilityProviderServiceClient"/>.</returns>
        public static stt::Task<ViewabilityProviderServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ViewabilityProviderServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ViewabilityProviderServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="ViewabilityProviderServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ViewabilityProviderServiceClient"/>.</returns>
        public static ViewabilityProviderServiceClient Create() => new ViewabilityProviderServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ViewabilityProviderServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ViewabilityProviderServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ViewabilityProviderServiceClient"/>.</returns>
        internal static ViewabilityProviderServiceClient Create(grpccore::CallInvoker callInvoker, ViewabilityProviderServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ViewabilityProviderService.ViewabilityProviderServiceClient grpcClient = new ViewabilityProviderService.ViewabilityProviderServiceClient(callInvoker);
            return new ViewabilityProviderServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ViewabilityProviderService client</summary>
        public virtual ViewabilityProviderService.ViewabilityProviderServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ViewabilityProvider GetViewabilityProvider(GetViewabilityProviderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ViewabilityProvider> GetViewabilityProviderAsync(GetViewabilityProviderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ViewabilityProvider> GetViewabilityProviderAsync(GetViewabilityProviderRequest request, st::CancellationToken cancellationToken) =>
            GetViewabilityProviderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider]. Format:
        /// `networks/{network_code}/viewabilityProviders/{viewability_provider}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ViewabilityProvider GetViewabilityProvider(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetViewabilityProvider(new GetViewabilityProviderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider]. Format:
        /// `networks/{network_code}/viewabilityProviders/{viewability_provider}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ViewabilityProvider> GetViewabilityProviderAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetViewabilityProviderAsync(new GetViewabilityProviderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider]. Format:
        /// `networks/{network_code}/viewabilityProviders/{viewability_provider}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ViewabilityProvider> GetViewabilityProviderAsync(string name, st::CancellationToken cancellationToken) =>
            GetViewabilityProviderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider]. Format:
        /// `networks/{network_code}/viewabilityProviders/{viewability_provider}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ViewabilityProvider GetViewabilityProvider(ViewabilityProviderName name, gaxgrpc::CallSettings callSettings = null) =>
            GetViewabilityProvider(new GetViewabilityProviderRequest
            {
                ViewabilityProviderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider]. Format:
        /// `networks/{network_code}/viewabilityProviders/{viewability_provider}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ViewabilityProvider> GetViewabilityProviderAsync(ViewabilityProviderName name, gaxgrpc::CallSettings callSettings = null) =>
            GetViewabilityProviderAsync(new GetViewabilityProviderRequest
            {
                ViewabilityProviderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider]. Format:
        /// `networks/{network_code}/viewabilityProviders/{viewability_provider}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ViewabilityProvider> GetViewabilityProviderAsync(ViewabilityProviderName name, st::CancellationToken cancellationToken) =>
            GetViewabilityProviderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider]
        /// objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ViewabilityProvider"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListViewabilityProvidersResponse, ViewabilityProvider> ListViewabilityProviders(ListViewabilityProvidersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider]
        /// objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ViewabilityProvider"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListViewabilityProvidersResponse, ViewabilityProvider> ListViewabilityProvidersAsync(ListViewabilityProvidersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider]
        /// objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider]s.
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
        /// <returns>A pageable sequence of <see cref="ViewabilityProvider"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListViewabilityProvidersResponse, ViewabilityProvider> ListViewabilityProviders(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListViewabilityProvidersRequest request = new ListViewabilityProvidersRequest
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
            return ListViewabilityProviders(request, callSettings);
        }

        /// <summary>
        /// Lists [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider]
        /// objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider]s.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ViewabilityProvider"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListViewabilityProvidersResponse, ViewabilityProvider> ListViewabilityProvidersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListViewabilityProvidersRequest request = new ListViewabilityProvidersRequest
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
            return ListViewabilityProvidersAsync(request, callSettings);
        }

        /// <summary>
        /// Lists [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider]
        /// objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider]s.
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
        /// <returns>A pageable sequence of <see cref="ViewabilityProvider"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListViewabilityProvidersResponse, ViewabilityProvider> ListViewabilityProviders(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListViewabilityProvidersRequest request = new ListViewabilityProvidersRequest
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
            return ListViewabilityProviders(request, callSettings);
        }

        /// <summary>
        /// Lists [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider]
        /// objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider]s.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ViewabilityProvider"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListViewabilityProvidersResponse, ViewabilityProvider> ListViewabilityProvidersAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListViewabilityProvidersRequest request = new ListViewabilityProvidersRequest
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
            return ListViewabilityProvidersAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ViewabilityProvider CreateViewabilityProvider(CreateViewabilityProviderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ViewabilityProvider> CreateViewabilityProviderAsync(CreateViewabilityProviderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ViewabilityProvider> CreateViewabilityProviderAsync(CreateViewabilityProviderRequest request, st::CancellationToken cancellationToken) =>
            CreateViewabilityProviderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] will be
        /// created. Format: `networks/{network_code}`
        /// </param>
        /// <param name="viewabilityProvider">
        /// Required. The
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] to
        /// create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ViewabilityProvider CreateViewabilityProvider(string parent, ViewabilityProvider viewabilityProvider, gaxgrpc::CallSettings callSettings = null) =>
            CreateViewabilityProvider(new CreateViewabilityProviderRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ViewabilityProvider = gax::GaxPreconditions.CheckNotNull(viewabilityProvider, nameof(viewabilityProvider)),
            }, callSettings);

        /// <summary>
        /// Creates a
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] will be
        /// created. Format: `networks/{network_code}`
        /// </param>
        /// <param name="viewabilityProvider">
        /// Required. The
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] to
        /// create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ViewabilityProvider> CreateViewabilityProviderAsync(string parent, ViewabilityProvider viewabilityProvider, gaxgrpc::CallSettings callSettings = null) =>
            CreateViewabilityProviderAsync(new CreateViewabilityProviderRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ViewabilityProvider = gax::GaxPreconditions.CheckNotNull(viewabilityProvider, nameof(viewabilityProvider)),
            }, callSettings);

        /// <summary>
        /// Creates a
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] will be
        /// created. Format: `networks/{network_code}`
        /// </param>
        /// <param name="viewabilityProvider">
        /// Required. The
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] to
        /// create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ViewabilityProvider> CreateViewabilityProviderAsync(string parent, ViewabilityProvider viewabilityProvider, st::CancellationToken cancellationToken) =>
            CreateViewabilityProviderAsync(parent, viewabilityProvider, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] will be
        /// created. Format: `networks/{network_code}`
        /// </param>
        /// <param name="viewabilityProvider">
        /// Required. The
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] to
        /// create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ViewabilityProvider CreateViewabilityProvider(NetworkName parent, ViewabilityProvider viewabilityProvider, gaxgrpc::CallSettings callSettings = null) =>
            CreateViewabilityProvider(new CreateViewabilityProviderRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ViewabilityProvider = gax::GaxPreconditions.CheckNotNull(viewabilityProvider, nameof(viewabilityProvider)),
            }, callSettings);

        /// <summary>
        /// Creates a
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] will be
        /// created. Format: `networks/{network_code}`
        /// </param>
        /// <param name="viewabilityProvider">
        /// Required. The
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] to
        /// create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ViewabilityProvider> CreateViewabilityProviderAsync(NetworkName parent, ViewabilityProvider viewabilityProvider, gaxgrpc::CallSettings callSettings = null) =>
            CreateViewabilityProviderAsync(new CreateViewabilityProviderRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ViewabilityProvider = gax::GaxPreconditions.CheckNotNull(viewabilityProvider, nameof(viewabilityProvider)),
            }, callSettings);

        /// <summary>
        /// Creates a
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] will be
        /// created. Format: `networks/{network_code}`
        /// </param>
        /// <param name="viewabilityProvider">
        /// Required. The
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] to
        /// create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ViewabilityProvider> CreateViewabilityProviderAsync(NetworkName parent, ViewabilityProvider viewabilityProvider, st::CancellationToken cancellationToken) =>
            CreateViewabilityProviderAsync(parent, viewabilityProvider, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider]
        /// objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateViewabilityProvidersResponse BatchCreateViewabilityProviders(BatchCreateViewabilityProvidersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider]
        /// objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateViewabilityProvidersResponse> BatchCreateViewabilityProvidersAsync(BatchCreateViewabilityProvidersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider]
        /// objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateViewabilityProvidersResponse> BatchCreateViewabilityProvidersAsync(BatchCreateViewabilityProvidersRequest request, st::CancellationToken cancellationToken) =>
            BatchCreateViewabilityProvidersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider]
        /// objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider]s will be
        /// created. Format: `networks/{network_code}` The parent field in the
        /// CreateViewabilityProviderRequest must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] objects
        /// to create. A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateViewabilityProvidersResponse BatchCreateViewabilityProviders(string parent, scg::IEnumerable<CreateViewabilityProviderRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateViewabilityProviders(new BatchCreateViewabilityProvidersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider]
        /// objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider]s will be
        /// created. Format: `networks/{network_code}` The parent field in the
        /// CreateViewabilityProviderRequest must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] objects
        /// to create. A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateViewabilityProvidersResponse> BatchCreateViewabilityProvidersAsync(string parent, scg::IEnumerable<CreateViewabilityProviderRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateViewabilityProvidersAsync(new BatchCreateViewabilityProvidersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider]
        /// objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider]s will be
        /// created. Format: `networks/{network_code}` The parent field in the
        /// CreateViewabilityProviderRequest must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] objects
        /// to create. A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateViewabilityProvidersResponse> BatchCreateViewabilityProvidersAsync(string parent, scg::IEnumerable<CreateViewabilityProviderRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateViewabilityProvidersAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider]
        /// objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider]s will be
        /// created. Format: `networks/{network_code}` The parent field in the
        /// CreateViewabilityProviderRequest must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] objects
        /// to create. A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateViewabilityProvidersResponse BatchCreateViewabilityProviders(NetworkName parent, scg::IEnumerable<CreateViewabilityProviderRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateViewabilityProviders(new BatchCreateViewabilityProvidersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider]
        /// objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider]s will be
        /// created. Format: `networks/{network_code}` The parent field in the
        /// CreateViewabilityProviderRequest must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] objects
        /// to create. A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateViewabilityProvidersResponse> BatchCreateViewabilityProvidersAsync(NetworkName parent, scg::IEnumerable<CreateViewabilityProviderRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateViewabilityProvidersAsync(new BatchCreateViewabilityProvidersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider]
        /// objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider]s will be
        /// created. Format: `networks/{network_code}` The parent field in the
        /// CreateViewabilityProviderRequest must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] objects
        /// to create. A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateViewabilityProvidersResponse> BatchCreateViewabilityProvidersAsync(NetworkName parent, scg::IEnumerable<CreateViewabilityProviderRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateViewabilityProvidersAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ViewabilityProvider UpdateViewabilityProvider(UpdateViewabilityProviderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ViewabilityProvider> UpdateViewabilityProviderAsync(UpdateViewabilityProviderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ViewabilityProvider> UpdateViewabilityProviderAsync(UpdateViewabilityProviderRequest request, st::CancellationToken cancellationToken) =>
            UpdateViewabilityProviderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] object.
        /// </summary>
        /// <param name="viewabilityProvider">
        /// Required. The
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] to
        /// update.
        /// 
        /// The [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider]'s
        /// `name` is used to identify the
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] to
        /// update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ViewabilityProvider UpdateViewabilityProvider(ViewabilityProvider viewabilityProvider, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateViewabilityProvider(new UpdateViewabilityProviderRequest
            {
                ViewabilityProvider = gax::GaxPreconditions.CheckNotNull(viewabilityProvider, nameof(viewabilityProvider)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] object.
        /// </summary>
        /// <param name="viewabilityProvider">
        /// Required. The
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] to
        /// update.
        /// 
        /// The [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider]'s
        /// `name` is used to identify the
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] to
        /// update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ViewabilityProvider> UpdateViewabilityProviderAsync(ViewabilityProvider viewabilityProvider, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateViewabilityProviderAsync(new UpdateViewabilityProviderRequest
            {
                ViewabilityProvider = gax::GaxPreconditions.CheckNotNull(viewabilityProvider, nameof(viewabilityProvider)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] object.
        /// </summary>
        /// <param name="viewabilityProvider">
        /// Required. The
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] to
        /// update.
        /// 
        /// The [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider]'s
        /// `name` is used to identify the
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] to
        /// update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ViewabilityProvider> UpdateViewabilityProviderAsync(ViewabilityProvider viewabilityProvider, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateViewabilityProviderAsync(viewabilityProvider, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateViewabilityProvidersResponse BatchUpdateViewabilityProviders(BatchUpdateViewabilityProvidersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch updates
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateViewabilityProvidersResponse> BatchUpdateViewabilityProvidersAsync(BatchUpdateViewabilityProvidersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch updates
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateViewabilityProvidersResponse> BatchUpdateViewabilityProvidersAsync(BatchUpdateViewabilityProvidersRequest request, st::CancellationToken cancellationToken) =>
            BatchUpdateViewabilityProvidersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider]s will be
        /// updated. Format: `networks/{network_code}` The parent field in the
        /// UpdateViewabilityProviderRequest must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] objects
        /// to update. A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateViewabilityProvidersResponse BatchUpdateViewabilityProviders(string parent, scg::IEnumerable<UpdateViewabilityProviderRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateViewabilityProviders(new BatchUpdateViewabilityProvidersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider]s will be
        /// updated. Format: `networks/{network_code}` The parent field in the
        /// UpdateViewabilityProviderRequest must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] objects
        /// to update. A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateViewabilityProvidersResponse> BatchUpdateViewabilityProvidersAsync(string parent, scg::IEnumerable<UpdateViewabilityProviderRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateViewabilityProvidersAsync(new BatchUpdateViewabilityProvidersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider]s will be
        /// updated. Format: `networks/{network_code}` The parent field in the
        /// UpdateViewabilityProviderRequest must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] objects
        /// to update. A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateViewabilityProvidersResponse> BatchUpdateViewabilityProvidersAsync(string parent, scg::IEnumerable<UpdateViewabilityProviderRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateViewabilityProvidersAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider]s will be
        /// updated. Format: `networks/{network_code}` The parent field in the
        /// UpdateViewabilityProviderRequest must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] objects
        /// to update. A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateViewabilityProvidersResponse BatchUpdateViewabilityProviders(NetworkName parent, scg::IEnumerable<UpdateViewabilityProviderRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateViewabilityProviders(new BatchUpdateViewabilityProvidersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider]s will be
        /// updated. Format: `networks/{network_code}` The parent field in the
        /// UpdateViewabilityProviderRequest must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] objects
        /// to update. A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateViewabilityProvidersResponse> BatchUpdateViewabilityProvidersAsync(NetworkName parent, scg::IEnumerable<UpdateViewabilityProviderRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateViewabilityProvidersAsync(new BatchUpdateViewabilityProvidersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider]s will be
        /// updated. Format: `networks/{network_code}` The parent field in the
        /// UpdateViewabilityProviderRequest must match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] objects
        /// to update. A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateViewabilityProvidersResponse> BatchUpdateViewabilityProvidersAsync(NetworkName parent, scg::IEnumerable<UpdateViewabilityProviderRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateViewabilityProvidersAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ViewabilityProviderService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling
    /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] objects.
    /// </remarks>
    public sealed partial class ViewabilityProviderServiceClientImpl : ViewabilityProviderServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetViewabilityProviderRequest, ViewabilityProvider> _callGetViewabilityProvider;

        private readonly gaxgrpc::ApiCall<ListViewabilityProvidersRequest, ListViewabilityProvidersResponse> _callListViewabilityProviders;

        private readonly gaxgrpc::ApiCall<CreateViewabilityProviderRequest, ViewabilityProvider> _callCreateViewabilityProvider;

        private readonly gaxgrpc::ApiCall<BatchCreateViewabilityProvidersRequest, BatchCreateViewabilityProvidersResponse> _callBatchCreateViewabilityProviders;

        private readonly gaxgrpc::ApiCall<UpdateViewabilityProviderRequest, ViewabilityProvider> _callUpdateViewabilityProvider;

        private readonly gaxgrpc::ApiCall<BatchUpdateViewabilityProvidersRequest, BatchUpdateViewabilityProvidersResponse> _callBatchUpdateViewabilityProviders;

        /// <summary>
        /// Constructs a client wrapper for the ViewabilityProviderService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="ViewabilityProviderServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ViewabilityProviderServiceClientImpl(ViewabilityProviderService.ViewabilityProviderServiceClient grpcClient, ViewabilityProviderServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ViewabilityProviderServiceSettings effectiveSettings = settings ?? ViewabilityProviderServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetViewabilityProvider = clientHelper.BuildApiCall<GetViewabilityProviderRequest, ViewabilityProvider>("GetViewabilityProvider", grpcClient.GetViewabilityProviderAsync, grpcClient.GetViewabilityProvider, effectiveSettings.GetViewabilityProviderSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetViewabilityProvider);
            Modify_GetViewabilityProviderApiCall(ref _callGetViewabilityProvider);
            _callListViewabilityProviders = clientHelper.BuildApiCall<ListViewabilityProvidersRequest, ListViewabilityProvidersResponse>("ListViewabilityProviders", grpcClient.ListViewabilityProvidersAsync, grpcClient.ListViewabilityProviders, effectiveSettings.ListViewabilityProvidersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListViewabilityProviders);
            Modify_ListViewabilityProvidersApiCall(ref _callListViewabilityProviders);
            _callCreateViewabilityProvider = clientHelper.BuildApiCall<CreateViewabilityProviderRequest, ViewabilityProvider>("CreateViewabilityProvider", grpcClient.CreateViewabilityProviderAsync, grpcClient.CreateViewabilityProvider, effectiveSettings.CreateViewabilityProviderSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateViewabilityProvider);
            Modify_CreateViewabilityProviderApiCall(ref _callCreateViewabilityProvider);
            _callBatchCreateViewabilityProviders = clientHelper.BuildApiCall<BatchCreateViewabilityProvidersRequest, BatchCreateViewabilityProvidersResponse>("BatchCreateViewabilityProviders", grpcClient.BatchCreateViewabilityProvidersAsync, grpcClient.BatchCreateViewabilityProviders, effectiveSettings.BatchCreateViewabilityProvidersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchCreateViewabilityProviders);
            Modify_BatchCreateViewabilityProvidersApiCall(ref _callBatchCreateViewabilityProviders);
            _callUpdateViewabilityProvider = clientHelper.BuildApiCall<UpdateViewabilityProviderRequest, ViewabilityProvider>("UpdateViewabilityProvider", grpcClient.UpdateViewabilityProviderAsync, grpcClient.UpdateViewabilityProvider, effectiveSettings.UpdateViewabilityProviderSettings).WithGoogleRequestParam("viewability_provider.name", request => request.ViewabilityProvider?.Name);
            Modify_ApiCall(ref _callUpdateViewabilityProvider);
            Modify_UpdateViewabilityProviderApiCall(ref _callUpdateViewabilityProvider);
            _callBatchUpdateViewabilityProviders = clientHelper.BuildApiCall<BatchUpdateViewabilityProvidersRequest, BatchUpdateViewabilityProvidersResponse>("BatchUpdateViewabilityProviders", grpcClient.BatchUpdateViewabilityProvidersAsync, grpcClient.BatchUpdateViewabilityProviders, effectiveSettings.BatchUpdateViewabilityProvidersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchUpdateViewabilityProviders);
            Modify_BatchUpdateViewabilityProvidersApiCall(ref _callBatchUpdateViewabilityProviders);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetViewabilityProviderApiCall(ref gaxgrpc::ApiCall<GetViewabilityProviderRequest, ViewabilityProvider> call);

        partial void Modify_ListViewabilityProvidersApiCall(ref gaxgrpc::ApiCall<ListViewabilityProvidersRequest, ListViewabilityProvidersResponse> call);

        partial void Modify_CreateViewabilityProviderApiCall(ref gaxgrpc::ApiCall<CreateViewabilityProviderRequest, ViewabilityProvider> call);

        partial void Modify_BatchCreateViewabilityProvidersApiCall(ref gaxgrpc::ApiCall<BatchCreateViewabilityProvidersRequest, BatchCreateViewabilityProvidersResponse> call);

        partial void Modify_UpdateViewabilityProviderApiCall(ref gaxgrpc::ApiCall<UpdateViewabilityProviderRequest, ViewabilityProvider> call);

        partial void Modify_BatchUpdateViewabilityProvidersApiCall(ref gaxgrpc::ApiCall<BatchUpdateViewabilityProvidersRequest, BatchUpdateViewabilityProvidersResponse> call);

        partial void OnConstruction(ViewabilityProviderService.ViewabilityProviderServiceClient grpcClient, ViewabilityProviderServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ViewabilityProviderService client</summary>
        public override ViewabilityProviderService.ViewabilityProviderServiceClient GrpcClient { get; }

        partial void Modify_GetViewabilityProviderRequest(ref GetViewabilityProviderRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListViewabilityProvidersRequest(ref ListViewabilityProvidersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateViewabilityProviderRequest(ref CreateViewabilityProviderRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchCreateViewabilityProvidersRequest(ref BatchCreateViewabilityProvidersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateViewabilityProviderRequest(ref UpdateViewabilityProviderRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchUpdateViewabilityProvidersRequest(ref BatchUpdateViewabilityProvidersRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves a
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ViewabilityProvider GetViewabilityProvider(GetViewabilityProviderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetViewabilityProviderRequest(ref request, ref callSettings);
            return _callGetViewabilityProvider.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ViewabilityProvider> GetViewabilityProviderAsync(GetViewabilityProviderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetViewabilityProviderRequest(ref request, ref callSettings);
            return _callGetViewabilityProvider.Async(request, callSettings);
        }

        /// <summary>
        /// Lists [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider]
        /// objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ViewabilityProvider"/> resources.</returns>
        public override gax::PagedEnumerable<ListViewabilityProvidersResponse, ViewabilityProvider> ListViewabilityProviders(ListViewabilityProvidersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListViewabilityProvidersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListViewabilityProvidersRequest, ListViewabilityProvidersResponse, ViewabilityProvider>(_callListViewabilityProviders, request, callSettings);
        }

        /// <summary>
        /// Lists [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider]
        /// objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ViewabilityProvider"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListViewabilityProvidersResponse, ViewabilityProvider> ListViewabilityProvidersAsync(ListViewabilityProvidersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListViewabilityProvidersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListViewabilityProvidersRequest, ListViewabilityProvidersResponse, ViewabilityProvider>(_callListViewabilityProviders, request, callSettings);
        }

        /// <summary>
        /// Creates a
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ViewabilityProvider CreateViewabilityProvider(CreateViewabilityProviderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateViewabilityProviderRequest(ref request, ref callSettings);
            return _callCreateViewabilityProvider.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ViewabilityProvider> CreateViewabilityProviderAsync(CreateViewabilityProviderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateViewabilityProviderRequest(ref request, ref callSettings);
            return _callCreateViewabilityProvider.Async(request, callSettings);
        }

        /// <summary>
        /// Creates [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider]
        /// objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchCreateViewabilityProvidersResponse BatchCreateViewabilityProviders(BatchCreateViewabilityProvidersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateViewabilityProvidersRequest(ref request, ref callSettings);
            return _callBatchCreateViewabilityProviders.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider]
        /// objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchCreateViewabilityProvidersResponse> BatchCreateViewabilityProvidersAsync(BatchCreateViewabilityProvidersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateViewabilityProvidersRequest(ref request, ref callSettings);
            return _callBatchCreateViewabilityProviders.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ViewabilityProvider UpdateViewabilityProvider(UpdateViewabilityProviderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateViewabilityProviderRequest(ref request, ref callSettings);
            return _callUpdateViewabilityProvider.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ViewabilityProvider> UpdateViewabilityProviderAsync(UpdateViewabilityProviderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateViewabilityProviderRequest(ref request, ref callSettings);
            return _callUpdateViewabilityProvider.Async(request, callSettings);
        }

        /// <summary>
        /// Batch updates
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchUpdateViewabilityProvidersResponse BatchUpdateViewabilityProviders(BatchUpdateViewabilityProvidersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateViewabilityProvidersRequest(ref request, ref callSettings);
            return _callBatchUpdateViewabilityProviders.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch updates
        /// [ViewabilityProvider][google.ads.admanager.v1.ViewabilityProvider] objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchUpdateViewabilityProvidersResponse> BatchUpdateViewabilityProvidersAsync(BatchUpdateViewabilityProvidersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateViewabilityProvidersRequest(ref request, ref callSettings);
            return _callBatchUpdateViewabilityProviders.Async(request, callSettings);
        }
    }

    public partial class ListViewabilityProvidersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListViewabilityProvidersResponse : gaxgrpc::IPageResponse<ViewabilityProvider>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ViewabilityProvider> GetEnumerator() => ViewabilityProviders.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
