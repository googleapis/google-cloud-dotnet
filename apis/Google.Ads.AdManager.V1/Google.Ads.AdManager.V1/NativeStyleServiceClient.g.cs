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

namespace Google.Ads.AdManager.V1
{
    /// <summary>Settings for <see cref="NativeStyleServiceClient"/> instances.</summary>
    public sealed partial class NativeStyleServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="NativeStyleServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="NativeStyleServiceSettings"/>.</returns>
        public static NativeStyleServiceSettings GetDefault() => new NativeStyleServiceSettings();

        /// <summary>Constructs a new <see cref="NativeStyleServiceSettings"/> object with default settings.</summary>
        public NativeStyleServiceSettings()
        {
        }

        private NativeStyleServiceSettings(NativeStyleServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetNativeStyleSettings = existing.GetNativeStyleSettings;
            ListNativeStylesSettings = existing.ListNativeStylesSettings;
            BatchCreateNativeStylesSettings = existing.BatchCreateNativeStylesSettings;
            BatchUpdateNativeStylesSettings = existing.BatchUpdateNativeStylesSettings;
            BatchActivateNativeStylesSettings = existing.BatchActivateNativeStylesSettings;
            BatchDeactivateNativeStylesSettings = existing.BatchDeactivateNativeStylesSettings;
            BatchArchiveNativeStylesSettings = existing.BatchArchiveNativeStylesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(NativeStyleServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NativeStyleServiceClient.GetNativeStyle</c> and <c>NativeStyleServiceClient.GetNativeStyleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetNativeStyleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NativeStyleServiceClient.ListNativeStyles</c> and <c>NativeStyleServiceClient.ListNativeStylesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListNativeStylesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NativeStyleServiceClient.BatchCreateNativeStyles</c> and
        /// <c>NativeStyleServiceClient.BatchCreateNativeStylesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchCreateNativeStylesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NativeStyleServiceClient.BatchUpdateNativeStyles</c> and
        /// <c>NativeStyleServiceClient.BatchUpdateNativeStylesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchUpdateNativeStylesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NativeStyleServiceClient.BatchActivateNativeStyles</c> and
        /// <c>NativeStyleServiceClient.BatchActivateNativeStylesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchActivateNativeStylesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NativeStyleServiceClient.BatchDeactivateNativeStyles</c> and
        /// <c>NativeStyleServiceClient.BatchDeactivateNativeStylesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchDeactivateNativeStylesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NativeStyleServiceClient.BatchArchiveNativeStyles</c> and
        /// <c>NativeStyleServiceClient.BatchArchiveNativeStylesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchArchiveNativeStylesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="NativeStyleServiceSettings"/> object.</returns>
        public NativeStyleServiceSettings Clone() => new NativeStyleServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="NativeStyleServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class NativeStyleServiceClientBuilder : gaxgrpc::ClientBuilderBase<NativeStyleServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public NativeStyleServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public NativeStyleServiceClientBuilder() : base(NativeStyleServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref NativeStyleServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<NativeStyleServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override NativeStyleServiceClient Build()
        {
            NativeStyleServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<NativeStyleServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<NativeStyleServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private NativeStyleServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return NativeStyleServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<NativeStyleServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return NativeStyleServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => NativeStyleServiceClient.ChannelPool;
    }

    /// <summary>NativeStyleService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `NativeStyle` objects.
    /// </remarks>
    public abstract partial class NativeStyleServiceClient
    {
        /// <summary>
        /// The default endpoint for the NativeStyleService service, which is a host of "admanager.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default NativeStyleService scopes.</summary>
        /// <remarks>
        /// The default NativeStyleService scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(NativeStyleService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="NativeStyleServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="NativeStyleServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="NativeStyleServiceClient"/>.</returns>
        public static stt::Task<NativeStyleServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new NativeStyleServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="NativeStyleServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="NativeStyleServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="NativeStyleServiceClient"/>.</returns>
        public static NativeStyleServiceClient Create() => new NativeStyleServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="NativeStyleServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="NativeStyleServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="NativeStyleServiceClient"/>.</returns>
        internal static NativeStyleServiceClient Create(grpccore::CallInvoker callInvoker, NativeStyleServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            NativeStyleService.NativeStyleServiceClient grpcClient = new NativeStyleService.NativeStyleServiceClient(callInvoker);
            return new NativeStyleServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC NativeStyleService client</summary>
        public virtual NativeStyleService.NativeStyleServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `NativeStyle` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NativeStyle GetNativeStyle(GetNativeStyleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `NativeStyle` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NativeStyle> GetNativeStyleAsync(GetNativeStyleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `NativeStyle` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NativeStyle> GetNativeStyleAsync(GetNativeStyleRequest request, st::CancellationToken cancellationToken) =>
            GetNativeStyleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `NativeStyle` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the NativeStyle.
        /// Format: `networks/{network_code}/nativeStyles/{native_style_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NativeStyle GetNativeStyle(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNativeStyle(new GetNativeStyleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `NativeStyle` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the NativeStyle.
        /// Format: `networks/{network_code}/nativeStyles/{native_style_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NativeStyle> GetNativeStyleAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNativeStyleAsync(new GetNativeStyleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `NativeStyle` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the NativeStyle.
        /// Format: `networks/{network_code}/nativeStyles/{native_style_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NativeStyle> GetNativeStyleAsync(string name, st::CancellationToken cancellationToken) =>
            GetNativeStyleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `NativeStyle` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the NativeStyle.
        /// Format: `networks/{network_code}/nativeStyles/{native_style_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NativeStyle GetNativeStyle(NativeStyleName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNativeStyle(new GetNativeStyleRequest
            {
                NativeStyleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `NativeStyle` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the NativeStyle.
        /// Format: `networks/{network_code}/nativeStyles/{native_style_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NativeStyle> GetNativeStyleAsync(NativeStyleName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNativeStyleAsync(new GetNativeStyleRequest
            {
                NativeStyleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `NativeStyle` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the NativeStyle.
        /// Format: `networks/{network_code}/nativeStyles/{native_style_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NativeStyle> GetNativeStyleAsync(NativeStyleName name, st::CancellationToken cancellationToken) =>
            GetNativeStyleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists `NativeStyle` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="NativeStyle"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNativeStylesResponse, NativeStyle> ListNativeStyles(ListNativeStylesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `NativeStyle` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="NativeStyle"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNativeStylesResponse, NativeStyle> ListNativeStylesAsync(ListNativeStylesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `NativeStyle` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of NativeStyles.
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
        /// <returns>A pageable sequence of <see cref="NativeStyle"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNativeStylesResponse, NativeStyle> ListNativeStyles(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNativeStylesRequest request = new ListNativeStylesRequest
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
            return ListNativeStyles(request, callSettings);
        }

        /// <summary>
        /// Lists `NativeStyle` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of NativeStyles.
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
        /// <returns>A pageable asynchronous sequence of <see cref="NativeStyle"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNativeStylesResponse, NativeStyle> ListNativeStylesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNativeStylesRequest request = new ListNativeStylesRequest
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
            return ListNativeStylesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists `NativeStyle` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of NativeStyles.
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
        /// <returns>A pageable sequence of <see cref="NativeStyle"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNativeStylesResponse, NativeStyle> ListNativeStyles(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNativeStylesRequest request = new ListNativeStylesRequest
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
            return ListNativeStyles(request, callSettings);
        }

        /// <summary>
        /// Lists `NativeStyle` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of NativeStyles.
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
        /// <returns>A pageable asynchronous sequence of <see cref="NativeStyle"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNativeStylesResponse, NativeStyle> ListNativeStylesAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNativeStylesRequest request = new ListNativeStylesRequest
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
            return ListNativeStylesAsync(request, callSettings);
        }

        /// <summary>
        /// Creates `NativeStyle` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateNativeStylesResponse BatchCreateNativeStyles(BatchCreateNativeStylesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates `NativeStyle` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateNativeStylesResponse> BatchCreateNativeStylesAsync(BatchCreateNativeStylesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates `NativeStyle` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateNativeStylesResponse> BatchCreateNativeStylesAsync(BatchCreateNativeStylesRequest request, st::CancellationToken cancellationToken) =>
            BatchCreateNativeStylesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates `NativeStyle` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `NativeStyles` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateNativeStyleRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `NativeStyle` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateNativeStylesResponse BatchCreateNativeStyles(string parent, scg::IEnumerable<CreateNativeStyleRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateNativeStyles(new BatchCreateNativeStylesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates `NativeStyle` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `NativeStyles` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateNativeStyleRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `NativeStyle` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateNativeStylesResponse> BatchCreateNativeStylesAsync(string parent, scg::IEnumerable<CreateNativeStyleRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateNativeStylesAsync(new BatchCreateNativeStylesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates `NativeStyle` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `NativeStyles` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateNativeStyleRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `NativeStyle` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateNativeStylesResponse> BatchCreateNativeStylesAsync(string parent, scg::IEnumerable<CreateNativeStyleRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateNativeStylesAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates `NativeStyle` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `NativeStyles` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateNativeStyleRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `NativeStyle` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateNativeStylesResponse BatchCreateNativeStyles(NetworkName parent, scg::IEnumerable<CreateNativeStyleRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateNativeStyles(new BatchCreateNativeStylesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates `NativeStyle` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `NativeStyles` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateNativeStyleRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `NativeStyle` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateNativeStylesResponse> BatchCreateNativeStylesAsync(NetworkName parent, scg::IEnumerable<CreateNativeStyleRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateNativeStylesAsync(new BatchCreateNativeStylesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates `NativeStyle` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `NativeStyles` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateNativeStyleRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `NativeStyle` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateNativeStylesResponse> BatchCreateNativeStylesAsync(NetworkName parent, scg::IEnumerable<CreateNativeStyleRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateNativeStylesAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `NativeStyle` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateNativeStylesResponse BatchUpdateNativeStyles(BatchUpdateNativeStylesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch updates `NativeStyle` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateNativeStylesResponse> BatchUpdateNativeStylesAsync(BatchUpdateNativeStylesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch updates `NativeStyle` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateNativeStylesResponse> BatchUpdateNativeStylesAsync(BatchUpdateNativeStylesRequest request, st::CancellationToken cancellationToken) =>
            BatchUpdateNativeStylesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `NativeStyle` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `NativeStyles` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateNativeStyleRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `NativeStyle` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateNativeStylesResponse BatchUpdateNativeStyles(string parent, scg::IEnumerable<UpdateNativeStyleRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateNativeStyles(new BatchUpdateNativeStylesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `NativeStyle` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `NativeStyles` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateNativeStyleRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `NativeStyle` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateNativeStylesResponse> BatchUpdateNativeStylesAsync(string parent, scg::IEnumerable<UpdateNativeStyleRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateNativeStylesAsync(new BatchUpdateNativeStylesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `NativeStyle` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `NativeStyles` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateNativeStyleRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `NativeStyle` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateNativeStylesResponse> BatchUpdateNativeStylesAsync(string parent, scg::IEnumerable<UpdateNativeStyleRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateNativeStylesAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `NativeStyle` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `NativeStyles` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateNativeStyleRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `NativeStyle` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateNativeStylesResponse BatchUpdateNativeStyles(NetworkName parent, scg::IEnumerable<UpdateNativeStyleRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateNativeStyles(new BatchUpdateNativeStylesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `NativeStyle` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `NativeStyles` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateNativeStyleRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `NativeStyle` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateNativeStylesResponse> BatchUpdateNativeStylesAsync(NetworkName parent, scg::IEnumerable<UpdateNativeStyleRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateNativeStylesAsync(new BatchUpdateNativeStylesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `NativeStyle` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `NativeStyles` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateNativeStyleRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `NativeStyle` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateNativeStylesResponse> BatchUpdateNativeStylesAsync(NetworkName parent, scg::IEnumerable<UpdateNativeStyleRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateNativeStylesAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Beginning of non-CRUD
        /// Activates a list of `NativeStyle` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchActivateNativeStylesResponse BatchActivateNativeStyles(BatchActivateNativeStylesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Beginning of non-CRUD
        /// Activates a list of `NativeStyle` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateNativeStylesResponse> BatchActivateNativeStylesAsync(BatchActivateNativeStylesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Beginning of non-CRUD
        /// Activates a list of `NativeStyle` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateNativeStylesResponse> BatchActivateNativeStylesAsync(BatchActivateNativeStylesRequest request, st::CancellationToken cancellationToken) =>
            BatchActivateNativeStylesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Beginning of non-CRUD
        /// Activates a list of `NativeStyle` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the `NativeStyle`s.
        /// Format: `networks/{network_code}/nativeStyles/{native_style_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchActivateNativeStylesResponse BatchActivateNativeStyles(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateNativeStyles(new BatchActivateNativeStylesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Beginning of non-CRUD
        /// Activates a list of `NativeStyle` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the `NativeStyle`s.
        /// Format: `networks/{network_code}/nativeStyles/{native_style_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateNativeStylesResponse> BatchActivateNativeStylesAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateNativeStylesAsync(new BatchActivateNativeStylesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Beginning of non-CRUD
        /// Activates a list of `NativeStyle` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the `NativeStyle`s.
        /// Format: `networks/{network_code}/nativeStyles/{native_style_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateNativeStylesResponse> BatchActivateNativeStylesAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchActivateNativeStylesAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Beginning of non-CRUD
        /// Activates a list of `NativeStyle` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the `NativeStyle`s.
        /// Format: `networks/{network_code}/nativeStyles/{native_style_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchActivateNativeStylesResponse BatchActivateNativeStyles(NetworkName parent, scg::IEnumerable<NativeStyleName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateNativeStyles(new BatchActivateNativeStylesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                NativeStyleNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Beginning of non-CRUD
        /// Activates a list of `NativeStyle` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the `NativeStyle`s.
        /// Format: `networks/{network_code}/nativeStyles/{native_style_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateNativeStylesResponse> BatchActivateNativeStylesAsync(NetworkName parent, scg::IEnumerable<NativeStyleName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateNativeStylesAsync(new BatchActivateNativeStylesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                NativeStyleNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Beginning of non-CRUD
        /// Activates a list of `NativeStyle` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the `NativeStyle`s.
        /// Format: `networks/{network_code}/nativeStyles/{native_style_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateNativeStylesResponse> BatchActivateNativeStylesAsync(NetworkName parent, scg::IEnumerable<NativeStyleName> names, st::CancellationToken cancellationToken) =>
            BatchActivateNativeStylesAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deactivates a list of `NativeStyle` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDeactivateNativeStylesResponse BatchDeactivateNativeStyles(BatchDeactivateNativeStylesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deactivates a list of `NativeStyle` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateNativeStylesResponse> BatchDeactivateNativeStylesAsync(BatchDeactivateNativeStylesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deactivates a list of `NativeStyle` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateNativeStylesResponse> BatchDeactivateNativeStylesAsync(BatchDeactivateNativeStylesRequest request, st::CancellationToken cancellationToken) =>
            BatchDeactivateNativeStylesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deactivates a list of `NativeStyle` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the `NativeStyle`s.
        /// Format: `networks/{network_code}/nativeStyles/{native_style_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDeactivateNativeStylesResponse BatchDeactivateNativeStyles(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateNativeStyles(new BatchDeactivateNativeStylesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deactivates a list of `NativeStyle` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the `NativeStyle`s.
        /// Format: `networks/{network_code}/nativeStyles/{native_style_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateNativeStylesResponse> BatchDeactivateNativeStylesAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateNativeStylesAsync(new BatchDeactivateNativeStylesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deactivates a list of `NativeStyle` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the `NativeStyle`s.
        /// Format: `networks/{network_code}/nativeStyles/{native_style_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateNativeStylesResponse> BatchDeactivateNativeStylesAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchDeactivateNativeStylesAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deactivates a list of `NativeStyle` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the `NativeStyle`s.
        /// Format: `networks/{network_code}/nativeStyles/{native_style_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDeactivateNativeStylesResponse BatchDeactivateNativeStyles(NetworkName parent, scg::IEnumerable<NativeStyleName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateNativeStyles(new BatchDeactivateNativeStylesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                NativeStyleNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deactivates a list of `NativeStyle` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the `NativeStyle`s.
        /// Format: `networks/{network_code}/nativeStyles/{native_style_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateNativeStylesResponse> BatchDeactivateNativeStylesAsync(NetworkName parent, scg::IEnumerable<NativeStyleName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateNativeStylesAsync(new BatchDeactivateNativeStylesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                NativeStyleNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deactivates a list of `NativeStyle` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the `NativeStyle`s.
        /// Format: `networks/{network_code}/nativeStyles/{native_style_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateNativeStylesResponse> BatchDeactivateNativeStylesAsync(NetworkName parent, scg::IEnumerable<NativeStyleName> names, st::CancellationToken cancellationToken) =>
            BatchDeactivateNativeStylesAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Archives a list of `NativeStyle` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchArchiveNativeStylesResponse BatchArchiveNativeStyles(BatchArchiveNativeStylesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Archives a list of `NativeStyle` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveNativeStylesResponse> BatchArchiveNativeStylesAsync(BatchArchiveNativeStylesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Archives a list of `NativeStyle` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveNativeStylesResponse> BatchArchiveNativeStylesAsync(BatchArchiveNativeStylesRequest request, st::CancellationToken cancellationToken) =>
            BatchArchiveNativeStylesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Archives a list of `NativeStyle` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the `NativeStyle`s.
        /// Format: `networks/{network_code}/nativeStyles/{native_style_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchArchiveNativeStylesResponse BatchArchiveNativeStyles(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchArchiveNativeStyles(new BatchArchiveNativeStylesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Archives a list of `NativeStyle` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the `NativeStyle`s.
        /// Format: `networks/{network_code}/nativeStyles/{native_style_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveNativeStylesResponse> BatchArchiveNativeStylesAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchArchiveNativeStylesAsync(new BatchArchiveNativeStylesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Archives a list of `NativeStyle` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the `NativeStyle`s.
        /// Format: `networks/{network_code}/nativeStyles/{native_style_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveNativeStylesResponse> BatchArchiveNativeStylesAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchArchiveNativeStylesAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Archives a list of `NativeStyle` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the `NativeStyle`s.
        /// Format: `networks/{network_code}/nativeStyles/{native_style_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchArchiveNativeStylesResponse BatchArchiveNativeStyles(NetworkName parent, scg::IEnumerable<NativeStyleName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchArchiveNativeStyles(new BatchArchiveNativeStylesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                NativeStyleNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Archives a list of `NativeStyle` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the `NativeStyle`s.
        /// Format: `networks/{network_code}/nativeStyles/{native_style_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveNativeStylesResponse> BatchArchiveNativeStylesAsync(NetworkName parent, scg::IEnumerable<NativeStyleName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchArchiveNativeStylesAsync(new BatchArchiveNativeStylesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                NativeStyleNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Archives a list of `NativeStyle` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the `NativeStyle`s.
        /// Format: `networks/{network_code}/nativeStyles/{native_style_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveNativeStylesResponse> BatchArchiveNativeStylesAsync(NetworkName parent, scg::IEnumerable<NativeStyleName> names, st::CancellationToken cancellationToken) =>
            BatchArchiveNativeStylesAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>NativeStyleService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `NativeStyle` objects.
    /// </remarks>
    public sealed partial class NativeStyleServiceClientImpl : NativeStyleServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetNativeStyleRequest, NativeStyle> _callGetNativeStyle;

        private readonly gaxgrpc::ApiCall<ListNativeStylesRequest, ListNativeStylesResponse> _callListNativeStyles;

        private readonly gaxgrpc::ApiCall<BatchCreateNativeStylesRequest, BatchCreateNativeStylesResponse> _callBatchCreateNativeStyles;

        private readonly gaxgrpc::ApiCall<BatchUpdateNativeStylesRequest, BatchUpdateNativeStylesResponse> _callBatchUpdateNativeStyles;

        private readonly gaxgrpc::ApiCall<BatchActivateNativeStylesRequest, BatchActivateNativeStylesResponse> _callBatchActivateNativeStyles;

        private readonly gaxgrpc::ApiCall<BatchDeactivateNativeStylesRequest, BatchDeactivateNativeStylesResponse> _callBatchDeactivateNativeStyles;

        private readonly gaxgrpc::ApiCall<BatchArchiveNativeStylesRequest, BatchArchiveNativeStylesResponse> _callBatchArchiveNativeStyles;

        /// <summary>
        /// Constructs a client wrapper for the NativeStyleService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="NativeStyleServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public NativeStyleServiceClientImpl(NativeStyleService.NativeStyleServiceClient grpcClient, NativeStyleServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            NativeStyleServiceSettings effectiveSettings = settings ?? NativeStyleServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetNativeStyle = clientHelper.BuildApiCall<GetNativeStyleRequest, NativeStyle>("GetNativeStyle", grpcClient.GetNativeStyleAsync, grpcClient.GetNativeStyle, effectiveSettings.GetNativeStyleSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetNativeStyle);
            Modify_GetNativeStyleApiCall(ref _callGetNativeStyle);
            _callListNativeStyles = clientHelper.BuildApiCall<ListNativeStylesRequest, ListNativeStylesResponse>("ListNativeStyles", grpcClient.ListNativeStylesAsync, grpcClient.ListNativeStyles, effectiveSettings.ListNativeStylesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListNativeStyles);
            Modify_ListNativeStylesApiCall(ref _callListNativeStyles);
            _callBatchCreateNativeStyles = clientHelper.BuildApiCall<BatchCreateNativeStylesRequest, BatchCreateNativeStylesResponse>("BatchCreateNativeStyles", grpcClient.BatchCreateNativeStylesAsync, grpcClient.BatchCreateNativeStyles, effectiveSettings.BatchCreateNativeStylesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchCreateNativeStyles);
            Modify_BatchCreateNativeStylesApiCall(ref _callBatchCreateNativeStyles);
            _callBatchUpdateNativeStyles = clientHelper.BuildApiCall<BatchUpdateNativeStylesRequest, BatchUpdateNativeStylesResponse>("BatchUpdateNativeStyles", grpcClient.BatchUpdateNativeStylesAsync, grpcClient.BatchUpdateNativeStyles, effectiveSettings.BatchUpdateNativeStylesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchUpdateNativeStyles);
            Modify_BatchUpdateNativeStylesApiCall(ref _callBatchUpdateNativeStyles);
            _callBatchActivateNativeStyles = clientHelper.BuildApiCall<BatchActivateNativeStylesRequest, BatchActivateNativeStylesResponse>("BatchActivateNativeStyles", grpcClient.BatchActivateNativeStylesAsync, grpcClient.BatchActivateNativeStyles, effectiveSettings.BatchActivateNativeStylesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchActivateNativeStyles);
            Modify_BatchActivateNativeStylesApiCall(ref _callBatchActivateNativeStyles);
            _callBatchDeactivateNativeStyles = clientHelper.BuildApiCall<BatchDeactivateNativeStylesRequest, BatchDeactivateNativeStylesResponse>("BatchDeactivateNativeStyles", grpcClient.BatchDeactivateNativeStylesAsync, grpcClient.BatchDeactivateNativeStyles, effectiveSettings.BatchDeactivateNativeStylesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchDeactivateNativeStyles);
            Modify_BatchDeactivateNativeStylesApiCall(ref _callBatchDeactivateNativeStyles);
            _callBatchArchiveNativeStyles = clientHelper.BuildApiCall<BatchArchiveNativeStylesRequest, BatchArchiveNativeStylesResponse>("BatchArchiveNativeStyles", grpcClient.BatchArchiveNativeStylesAsync, grpcClient.BatchArchiveNativeStyles, effectiveSettings.BatchArchiveNativeStylesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchArchiveNativeStyles);
            Modify_BatchArchiveNativeStylesApiCall(ref _callBatchArchiveNativeStyles);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetNativeStyleApiCall(ref gaxgrpc::ApiCall<GetNativeStyleRequest, NativeStyle> call);

        partial void Modify_ListNativeStylesApiCall(ref gaxgrpc::ApiCall<ListNativeStylesRequest, ListNativeStylesResponse> call);

        partial void Modify_BatchCreateNativeStylesApiCall(ref gaxgrpc::ApiCall<BatchCreateNativeStylesRequest, BatchCreateNativeStylesResponse> call);

        partial void Modify_BatchUpdateNativeStylesApiCall(ref gaxgrpc::ApiCall<BatchUpdateNativeStylesRequest, BatchUpdateNativeStylesResponse> call);

        partial void Modify_BatchActivateNativeStylesApiCall(ref gaxgrpc::ApiCall<BatchActivateNativeStylesRequest, BatchActivateNativeStylesResponse> call);

        partial void Modify_BatchDeactivateNativeStylesApiCall(ref gaxgrpc::ApiCall<BatchDeactivateNativeStylesRequest, BatchDeactivateNativeStylesResponse> call);

        partial void Modify_BatchArchiveNativeStylesApiCall(ref gaxgrpc::ApiCall<BatchArchiveNativeStylesRequest, BatchArchiveNativeStylesResponse> call);

        partial void OnConstruction(NativeStyleService.NativeStyleServiceClient grpcClient, NativeStyleServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC NativeStyleService client</summary>
        public override NativeStyleService.NativeStyleServiceClient GrpcClient { get; }

        partial void Modify_GetNativeStyleRequest(ref GetNativeStyleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListNativeStylesRequest(ref ListNativeStylesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchCreateNativeStylesRequest(ref BatchCreateNativeStylesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchUpdateNativeStylesRequest(ref BatchUpdateNativeStylesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchActivateNativeStylesRequest(ref BatchActivateNativeStylesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchDeactivateNativeStylesRequest(ref BatchDeactivateNativeStylesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchArchiveNativeStylesRequest(ref BatchArchiveNativeStylesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves a `NativeStyle` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override NativeStyle GetNativeStyle(GetNativeStyleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNativeStyleRequest(ref request, ref callSettings);
            return _callGetNativeStyle.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a `NativeStyle` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<NativeStyle> GetNativeStyleAsync(GetNativeStyleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNativeStyleRequest(ref request, ref callSettings);
            return _callGetNativeStyle.Async(request, callSettings);
        }

        /// <summary>
        /// Lists `NativeStyle` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="NativeStyle"/> resources.</returns>
        public override gax::PagedEnumerable<ListNativeStylesResponse, NativeStyle> ListNativeStyles(ListNativeStylesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNativeStylesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListNativeStylesRequest, ListNativeStylesResponse, NativeStyle>(_callListNativeStyles, request, callSettings);
        }

        /// <summary>
        /// Lists `NativeStyle` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="NativeStyle"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListNativeStylesResponse, NativeStyle> ListNativeStylesAsync(ListNativeStylesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNativeStylesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListNativeStylesRequest, ListNativeStylesResponse, NativeStyle>(_callListNativeStyles, request, callSettings);
        }

        /// <summary>
        /// Creates `NativeStyle` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchCreateNativeStylesResponse BatchCreateNativeStyles(BatchCreateNativeStylesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateNativeStylesRequest(ref request, ref callSettings);
            return _callBatchCreateNativeStyles.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates `NativeStyle` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchCreateNativeStylesResponse> BatchCreateNativeStylesAsync(BatchCreateNativeStylesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateNativeStylesRequest(ref request, ref callSettings);
            return _callBatchCreateNativeStyles.Async(request, callSettings);
        }

        /// <summary>
        /// Batch updates `NativeStyle` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchUpdateNativeStylesResponse BatchUpdateNativeStyles(BatchUpdateNativeStylesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateNativeStylesRequest(ref request, ref callSettings);
            return _callBatchUpdateNativeStyles.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch updates `NativeStyle` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchUpdateNativeStylesResponse> BatchUpdateNativeStylesAsync(BatchUpdateNativeStylesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateNativeStylesRequest(ref request, ref callSettings);
            return _callBatchUpdateNativeStyles.Async(request, callSettings);
        }

        /// <summary>
        /// Beginning of non-CRUD
        /// Activates a list of `NativeStyle` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchActivateNativeStylesResponse BatchActivateNativeStyles(BatchActivateNativeStylesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchActivateNativeStylesRequest(ref request, ref callSettings);
            return _callBatchActivateNativeStyles.Sync(request, callSettings);
        }

        /// <summary>
        /// Beginning of non-CRUD
        /// Activates a list of `NativeStyle` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchActivateNativeStylesResponse> BatchActivateNativeStylesAsync(BatchActivateNativeStylesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchActivateNativeStylesRequest(ref request, ref callSettings);
            return _callBatchActivateNativeStyles.Async(request, callSettings);
        }

        /// <summary>
        /// Deactivates a list of `NativeStyle` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchDeactivateNativeStylesResponse BatchDeactivateNativeStyles(BatchDeactivateNativeStylesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeactivateNativeStylesRequest(ref request, ref callSettings);
            return _callBatchDeactivateNativeStyles.Sync(request, callSettings);
        }

        /// <summary>
        /// Deactivates a list of `NativeStyle` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchDeactivateNativeStylesResponse> BatchDeactivateNativeStylesAsync(BatchDeactivateNativeStylesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeactivateNativeStylesRequest(ref request, ref callSettings);
            return _callBatchDeactivateNativeStyles.Async(request, callSettings);
        }

        /// <summary>
        /// Archives a list of `NativeStyle` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchArchiveNativeStylesResponse BatchArchiveNativeStyles(BatchArchiveNativeStylesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchArchiveNativeStylesRequest(ref request, ref callSettings);
            return _callBatchArchiveNativeStyles.Sync(request, callSettings);
        }

        /// <summary>
        /// Archives a list of `NativeStyle` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchArchiveNativeStylesResponse> BatchArchiveNativeStylesAsync(BatchArchiveNativeStylesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchArchiveNativeStylesRequest(ref request, ref callSettings);
            return _callBatchArchiveNativeStyles.Async(request, callSettings);
        }
    }

    public partial class ListNativeStylesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListNativeStylesResponse : gaxgrpc::IPageResponse<NativeStyle>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<NativeStyle> GetEnumerator() => NativeStyles.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
