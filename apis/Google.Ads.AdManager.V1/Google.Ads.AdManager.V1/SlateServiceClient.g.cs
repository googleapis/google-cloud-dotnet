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
    /// <summary>Settings for <see cref="SlateServiceClient"/> instances.</summary>
    public sealed partial class SlateServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SlateServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SlateServiceSettings"/>.</returns>
        public static SlateServiceSettings GetDefault() => new SlateServiceSettings();

        /// <summary>Constructs a new <see cref="SlateServiceSettings"/> object with default settings.</summary>
        public SlateServiceSettings()
        {
        }

        private SlateServiceSettings(SlateServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetSlateSettings = existing.GetSlateSettings;
            ListSlatesSettings = existing.ListSlatesSettings;
            CreateSlateSettings = existing.CreateSlateSettings;
            BatchCreateSlatesSettings = existing.BatchCreateSlatesSettings;
            UpdateSlateSettings = existing.UpdateSlateSettings;
            BatchUpdateSlatesSettings = existing.BatchUpdateSlatesSettings;
            BatchArchiveSlatesSettings = existing.BatchArchiveSlatesSettings;
            BatchUnarchiveSlatesSettings = existing.BatchUnarchiveSlatesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SlateServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>SlateServiceClient.GetSlate</c>
        ///  and <c>SlateServiceClient.GetSlateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSlateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SlateServiceClient.ListSlates</c> and <c>SlateServiceClient.ListSlatesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSlatesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SlateServiceClient.CreateSlate</c> and <c>SlateServiceClient.CreateSlateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSlateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SlateServiceClient.BatchCreateSlates</c> and <c>SlateServiceClient.BatchCreateSlatesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchCreateSlatesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SlateServiceClient.UpdateSlate</c> and <c>SlateServiceClient.UpdateSlateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSlateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SlateServiceClient.BatchUpdateSlates</c> and <c>SlateServiceClient.BatchUpdateSlatesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchUpdateSlatesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SlateServiceClient.BatchArchiveSlates</c> and <c>SlateServiceClient.BatchArchiveSlatesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchArchiveSlatesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SlateServiceClient.BatchUnarchiveSlates</c> and <c>SlateServiceClient.BatchUnarchiveSlatesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchUnarchiveSlatesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SlateServiceSettings"/> object.</returns>
        public SlateServiceSettings Clone() => new SlateServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SlateServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class SlateServiceClientBuilder : gaxgrpc::ClientBuilderBase<SlateServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SlateServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SlateServiceClientBuilder() : base(SlateServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref SlateServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SlateServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SlateServiceClient Build()
        {
            SlateServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SlateServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SlateServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SlateServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SlateServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<SlateServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SlateServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SlateServiceClient.ChannelPool;
    }

    /// <summary>SlateService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `Slate` objects.
    /// </remarks>
    public abstract partial class SlateServiceClient
    {
        /// <summary>
        /// The default endpoint for the SlateService service, which is a host of "admanager.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default SlateService scopes.</summary>
        /// <remarks>
        /// The default SlateService scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(SlateService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="SlateServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="SlateServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SlateServiceClient"/>.</returns>
        public static stt::Task<SlateServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SlateServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SlateServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="SlateServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SlateServiceClient"/>.</returns>
        public static SlateServiceClient Create() => new SlateServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SlateServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SlateServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="SlateServiceClient"/>.</returns>
        internal static SlateServiceClient Create(grpccore::CallInvoker callInvoker, SlateServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SlateService.SlateServiceClient grpcClient = new SlateService.SlateServiceClient(callInvoker);
            return new SlateServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC SlateService client</summary>
        public virtual SlateService.SlateServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `Slate` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Slate GetSlate(GetSlateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `Slate` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Slate> GetSlateAsync(GetSlateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `Slate` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Slate> GetSlateAsync(GetSlateRequest request, st::CancellationToken cancellationToken) =>
            GetSlateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `Slate` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Slate to retrieve.
        /// Format: `networks/{network_code}/slates/{slate_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Slate GetSlate(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSlate(new GetSlateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `Slate` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Slate to retrieve.
        /// Format: `networks/{network_code}/slates/{slate_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Slate> GetSlateAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSlateAsync(new GetSlateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `Slate` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Slate to retrieve.
        /// Format: `networks/{network_code}/slates/{slate_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Slate> GetSlateAsync(string name, st::CancellationToken cancellationToken) =>
            GetSlateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `Slate` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Slate to retrieve.
        /// Format: `networks/{network_code}/slates/{slate_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Slate GetSlate(SlateName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSlate(new GetSlateRequest
            {
                SlateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `Slate` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Slate to retrieve.
        /// Format: `networks/{network_code}/slates/{slate_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Slate> GetSlateAsync(SlateName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSlateAsync(new GetSlateRequest
            {
                SlateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `Slate` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Slate to retrieve.
        /// Format: `networks/{network_code}/slates/{slate_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Slate> GetSlateAsync(SlateName name, st::CancellationToken cancellationToken) =>
            GetSlateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists `Slate` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Slate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSlatesResponse, Slate> ListSlates(ListSlatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `Slate` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Slate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSlatesResponse, Slate> ListSlatesAsync(ListSlatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `Slate` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource containing the Slates.
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
        /// <returns>A pageable sequence of <see cref="Slate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSlatesResponse, Slate> ListSlates(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSlatesRequest request = new ListSlatesRequest
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
            return ListSlates(request, callSettings);
        }

        /// <summary>
        /// Lists `Slate` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource containing the Slates.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Slate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSlatesResponse, Slate> ListSlatesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSlatesRequest request = new ListSlatesRequest
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
            return ListSlatesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists `Slate` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource containing the Slates.
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
        /// <returns>A pageable sequence of <see cref="Slate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSlatesResponse, Slate> ListSlates(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSlatesRequest request = new ListSlatesRequest
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
            return ListSlates(request, callSettings);
        }

        /// <summary>
        /// Lists `Slate` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource containing the Slates.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Slate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSlatesResponse, Slate> ListSlatesAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSlatesRequest request = new ListSlatesRequest
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
            return ListSlatesAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a `Slate` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Slate CreateSlate(CreateSlateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a `Slate` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Slate> CreateSlateAsync(CreateSlateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a `Slate` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Slate> CreateSlateAsync(CreateSlateRequest request, st::CancellationToken cancellationToken) =>
            CreateSlateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a `Slate` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `Slate` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="slate">
        /// Required. The `Slate` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Slate CreateSlate(string parent, Slate slate, gaxgrpc::CallSettings callSettings = null) =>
            CreateSlate(new CreateSlateRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Slate = gax::GaxPreconditions.CheckNotNull(slate, nameof(slate)),
            }, callSettings);

        /// <summary>
        /// Creates a `Slate` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `Slate` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="slate">
        /// Required. The `Slate` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Slate> CreateSlateAsync(string parent, Slate slate, gaxgrpc::CallSettings callSettings = null) =>
            CreateSlateAsync(new CreateSlateRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Slate = gax::GaxPreconditions.CheckNotNull(slate, nameof(slate)),
            }, callSettings);

        /// <summary>
        /// Creates a `Slate` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `Slate` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="slate">
        /// Required. The `Slate` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Slate> CreateSlateAsync(string parent, Slate slate, st::CancellationToken cancellationToken) =>
            CreateSlateAsync(parent, slate, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a `Slate` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `Slate` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="slate">
        /// Required. The `Slate` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Slate CreateSlate(NetworkName parent, Slate slate, gaxgrpc::CallSettings callSettings = null) =>
            CreateSlate(new CreateSlateRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Slate = gax::GaxPreconditions.CheckNotNull(slate, nameof(slate)),
            }, callSettings);

        /// <summary>
        /// Creates a `Slate` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `Slate` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="slate">
        /// Required. The `Slate` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Slate> CreateSlateAsync(NetworkName parent, Slate slate, gaxgrpc::CallSettings callSettings = null) =>
            CreateSlateAsync(new CreateSlateRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Slate = gax::GaxPreconditions.CheckNotNull(slate, nameof(slate)),
            }, callSettings);

        /// <summary>
        /// Creates a `Slate` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `Slate` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="slate">
        /// Required. The `Slate` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Slate> CreateSlateAsync(NetworkName parent, Slate slate, st::CancellationToken cancellationToken) =>
            CreateSlateAsync(parent, slate, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch creates `Slate` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateSlatesResponse BatchCreateSlates(BatchCreateSlatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch creates `Slate` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateSlatesResponse> BatchCreateSlatesAsync(BatchCreateSlatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch creates `Slate` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateSlatesResponse> BatchCreateSlatesAsync(BatchCreateSlatesRequest request, st::CancellationToken cancellationToken) =>
            BatchCreateSlatesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch creates `Slate` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Slates` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateSlateRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Slate` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateSlatesResponse BatchCreateSlates(string parent, scg::IEnumerable<CreateSlateRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateSlates(new BatchCreateSlatesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch creates `Slate` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Slates` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateSlateRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Slate` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateSlatesResponse> BatchCreateSlatesAsync(string parent, scg::IEnumerable<CreateSlateRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateSlatesAsync(new BatchCreateSlatesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch creates `Slate` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Slates` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateSlateRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Slate` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateSlatesResponse> BatchCreateSlatesAsync(string parent, scg::IEnumerable<CreateSlateRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateSlatesAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch creates `Slate` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Slates` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateSlateRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Slate` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateSlatesResponse BatchCreateSlates(NetworkName parent, scg::IEnumerable<CreateSlateRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateSlates(new BatchCreateSlatesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch creates `Slate` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Slates` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateSlateRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Slate` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateSlatesResponse> BatchCreateSlatesAsync(NetworkName parent, scg::IEnumerable<CreateSlateRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateSlatesAsync(new BatchCreateSlatesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch creates `Slate` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Slates` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateSlateRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Slate` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateSlatesResponse> BatchCreateSlatesAsync(NetworkName parent, scg::IEnumerable<CreateSlateRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateSlatesAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a `Slate` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Slate UpdateSlate(UpdateSlateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `Slate` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Slate> UpdateSlateAsync(UpdateSlateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `Slate` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Slate> UpdateSlateAsync(UpdateSlateRequest request, st::CancellationToken cancellationToken) =>
            UpdateSlateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a `Slate` object.
        /// </summary>
        /// <param name="slate">
        /// Required. The `Slate` to update.
        /// 
        /// The `Slate`'s `name` is used to identify the `Slate` to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Slate UpdateSlate(Slate slate, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSlate(new UpdateSlateRequest
            {
                Slate = gax::GaxPreconditions.CheckNotNull(slate, nameof(slate)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a `Slate` object.
        /// </summary>
        /// <param name="slate">
        /// Required. The `Slate` to update.
        /// 
        /// The `Slate`'s `name` is used to identify the `Slate` to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Slate> UpdateSlateAsync(Slate slate, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSlateAsync(new UpdateSlateRequest
            {
                Slate = gax::GaxPreconditions.CheckNotNull(slate, nameof(slate)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a `Slate` object.
        /// </summary>
        /// <param name="slate">
        /// Required. The `Slate` to update.
        /// 
        /// The `Slate`'s `name` is used to identify the `Slate` to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Slate> UpdateSlateAsync(Slate slate, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSlateAsync(slate, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `Slate` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateSlatesResponse BatchUpdateSlates(BatchUpdateSlatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch updates `Slate` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateSlatesResponse> BatchUpdateSlatesAsync(BatchUpdateSlatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch updates `Slate` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateSlatesResponse> BatchUpdateSlatesAsync(BatchUpdateSlatesRequest request, st::CancellationToken cancellationToken) =>
            BatchUpdateSlatesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `Slate` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Slates` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateSlateRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Slate` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateSlatesResponse BatchUpdateSlates(string parent, scg::IEnumerable<UpdateSlateRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateSlates(new BatchUpdateSlatesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `Slate` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Slates` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateSlateRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Slate` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateSlatesResponse> BatchUpdateSlatesAsync(string parent, scg::IEnumerable<UpdateSlateRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateSlatesAsync(new BatchUpdateSlatesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `Slate` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Slates` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateSlateRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Slate` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateSlatesResponse> BatchUpdateSlatesAsync(string parent, scg::IEnumerable<UpdateSlateRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateSlatesAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `Slate` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Slates` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateSlateRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Slate` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateSlatesResponse BatchUpdateSlates(NetworkName parent, scg::IEnumerable<UpdateSlateRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateSlates(new BatchUpdateSlatesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `Slate` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Slates` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateSlateRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Slate` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateSlatesResponse> BatchUpdateSlatesAsync(NetworkName parent, scg::IEnumerable<UpdateSlateRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateSlatesAsync(new BatchUpdateSlatesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `Slate` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Slates` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateSlateRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Slate` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateSlatesResponse> BatchUpdateSlatesAsync(NetworkName parent, scg::IEnumerable<UpdateSlateRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateSlatesAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch archives `Slate` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchArchiveSlatesResponse BatchArchiveSlates(BatchArchiveSlatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch archives `Slate` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveSlatesResponse> BatchArchiveSlatesAsync(BatchArchiveSlatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch archives `Slate` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveSlatesResponse> BatchArchiveSlatesAsync(BatchArchiveSlatesRequest request, st::CancellationToken cancellationToken) =>
            BatchArchiveSlatesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch archives `Slate` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource containing the slates.
        /// Format: "networks/{network_code}"
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the slates to archive.
        /// Format: "networks/{network_code}/slates/{slate_id}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchArchiveSlatesResponse BatchArchiveSlates(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchArchiveSlates(new BatchArchiveSlatesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch archives `Slate` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource containing the slates.
        /// Format: "networks/{network_code}"
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the slates to archive.
        /// Format: "networks/{network_code}/slates/{slate_id}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveSlatesResponse> BatchArchiveSlatesAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchArchiveSlatesAsync(new BatchArchiveSlatesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch archives `Slate` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource containing the slates.
        /// Format: "networks/{network_code}"
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the slates to archive.
        /// Format: "networks/{network_code}/slates/{slate_id}"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveSlatesResponse> BatchArchiveSlatesAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchArchiveSlatesAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch archives `Slate` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource containing the slates.
        /// Format: "networks/{network_code}"
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the slates to archive.
        /// Format: "networks/{network_code}/slates/{slate_id}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchArchiveSlatesResponse BatchArchiveSlates(NetworkName parent, scg::IEnumerable<SlateName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchArchiveSlates(new BatchArchiveSlatesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SlateNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch archives `Slate` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource containing the slates.
        /// Format: "networks/{network_code}"
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the slates to archive.
        /// Format: "networks/{network_code}/slates/{slate_id}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveSlatesResponse> BatchArchiveSlatesAsync(NetworkName parent, scg::IEnumerable<SlateName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchArchiveSlatesAsync(new BatchArchiveSlatesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SlateNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch archives `Slate` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource containing the slates.
        /// Format: "networks/{network_code}"
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the slates to archive.
        /// Format: "networks/{network_code}/slates/{slate_id}"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveSlatesResponse> BatchArchiveSlatesAsync(NetworkName parent, scg::IEnumerable<SlateName> names, st::CancellationToken cancellationToken) =>
            BatchArchiveSlatesAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch unarchives `Slate` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUnarchiveSlatesResponse BatchUnarchiveSlates(BatchUnarchiveSlatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch unarchives `Slate` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUnarchiveSlatesResponse> BatchUnarchiveSlatesAsync(BatchUnarchiveSlatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch unarchives `Slate` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUnarchiveSlatesResponse> BatchUnarchiveSlatesAsync(BatchUnarchiveSlatesRequest request, st::CancellationToken cancellationToken) =>
            BatchUnarchiveSlatesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch unarchives `Slate` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource containing the slates.
        /// Format: "networks/{network_code}"
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the slates to unarchive.
        /// Format: "networks/{network_code}/slates/{slate_id}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUnarchiveSlatesResponse BatchUnarchiveSlates(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchUnarchiveSlates(new BatchUnarchiveSlatesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch unarchives `Slate` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource containing the slates.
        /// Format: "networks/{network_code}"
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the slates to unarchive.
        /// Format: "networks/{network_code}/slates/{slate_id}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUnarchiveSlatesResponse> BatchUnarchiveSlatesAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchUnarchiveSlatesAsync(new BatchUnarchiveSlatesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch unarchives `Slate` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource containing the slates.
        /// Format: "networks/{network_code}"
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the slates to unarchive.
        /// Format: "networks/{network_code}/slates/{slate_id}"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUnarchiveSlatesResponse> BatchUnarchiveSlatesAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchUnarchiveSlatesAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch unarchives `Slate` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource containing the slates.
        /// Format: "networks/{network_code}"
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the slates to unarchive.
        /// Format: "networks/{network_code}/slates/{slate_id}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUnarchiveSlatesResponse BatchUnarchiveSlates(NetworkName parent, scg::IEnumerable<SlateName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchUnarchiveSlates(new BatchUnarchiveSlatesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SlateNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch unarchives `Slate` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource containing the slates.
        /// Format: "networks/{network_code}"
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the slates to unarchive.
        /// Format: "networks/{network_code}/slates/{slate_id}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUnarchiveSlatesResponse> BatchUnarchiveSlatesAsync(NetworkName parent, scg::IEnumerable<SlateName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchUnarchiveSlatesAsync(new BatchUnarchiveSlatesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SlateNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Batch unarchives `Slate` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource containing the slates.
        /// Format: "networks/{network_code}"
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the slates to unarchive.
        /// Format: "networks/{network_code}/slates/{slate_id}"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUnarchiveSlatesResponse> BatchUnarchiveSlatesAsync(NetworkName parent, scg::IEnumerable<SlateName> names, st::CancellationToken cancellationToken) =>
            BatchUnarchiveSlatesAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>SlateService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `Slate` objects.
    /// </remarks>
    public sealed partial class SlateServiceClientImpl : SlateServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetSlateRequest, Slate> _callGetSlate;

        private readonly gaxgrpc::ApiCall<ListSlatesRequest, ListSlatesResponse> _callListSlates;

        private readonly gaxgrpc::ApiCall<CreateSlateRequest, Slate> _callCreateSlate;

        private readonly gaxgrpc::ApiCall<BatchCreateSlatesRequest, BatchCreateSlatesResponse> _callBatchCreateSlates;

        private readonly gaxgrpc::ApiCall<UpdateSlateRequest, Slate> _callUpdateSlate;

        private readonly gaxgrpc::ApiCall<BatchUpdateSlatesRequest, BatchUpdateSlatesResponse> _callBatchUpdateSlates;

        private readonly gaxgrpc::ApiCall<BatchArchiveSlatesRequest, BatchArchiveSlatesResponse> _callBatchArchiveSlates;

        private readonly gaxgrpc::ApiCall<BatchUnarchiveSlatesRequest, BatchUnarchiveSlatesResponse> _callBatchUnarchiveSlates;

        /// <summary>
        /// Constructs a client wrapper for the SlateService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SlateServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public SlateServiceClientImpl(SlateService.SlateServiceClient grpcClient, SlateServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            SlateServiceSettings effectiveSettings = settings ?? SlateServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetSlate = clientHelper.BuildApiCall<GetSlateRequest, Slate>("GetSlate", grpcClient.GetSlateAsync, grpcClient.GetSlate, effectiveSettings.GetSlateSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSlate);
            Modify_GetSlateApiCall(ref _callGetSlate);
            _callListSlates = clientHelper.BuildApiCall<ListSlatesRequest, ListSlatesResponse>("ListSlates", grpcClient.ListSlatesAsync, grpcClient.ListSlates, effectiveSettings.ListSlatesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSlates);
            Modify_ListSlatesApiCall(ref _callListSlates);
            _callCreateSlate = clientHelper.BuildApiCall<CreateSlateRequest, Slate>("CreateSlate", grpcClient.CreateSlateAsync, grpcClient.CreateSlate, effectiveSettings.CreateSlateSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSlate);
            Modify_CreateSlateApiCall(ref _callCreateSlate);
            _callBatchCreateSlates = clientHelper.BuildApiCall<BatchCreateSlatesRequest, BatchCreateSlatesResponse>("BatchCreateSlates", grpcClient.BatchCreateSlatesAsync, grpcClient.BatchCreateSlates, effectiveSettings.BatchCreateSlatesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchCreateSlates);
            Modify_BatchCreateSlatesApiCall(ref _callBatchCreateSlates);
            _callUpdateSlate = clientHelper.BuildApiCall<UpdateSlateRequest, Slate>("UpdateSlate", grpcClient.UpdateSlateAsync, grpcClient.UpdateSlate, effectiveSettings.UpdateSlateSettings).WithGoogleRequestParam("slate.name", request => request.Slate?.Name);
            Modify_ApiCall(ref _callUpdateSlate);
            Modify_UpdateSlateApiCall(ref _callUpdateSlate);
            _callBatchUpdateSlates = clientHelper.BuildApiCall<BatchUpdateSlatesRequest, BatchUpdateSlatesResponse>("BatchUpdateSlates", grpcClient.BatchUpdateSlatesAsync, grpcClient.BatchUpdateSlates, effectiveSettings.BatchUpdateSlatesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchUpdateSlates);
            Modify_BatchUpdateSlatesApiCall(ref _callBatchUpdateSlates);
            _callBatchArchiveSlates = clientHelper.BuildApiCall<BatchArchiveSlatesRequest, BatchArchiveSlatesResponse>("BatchArchiveSlates", grpcClient.BatchArchiveSlatesAsync, grpcClient.BatchArchiveSlates, effectiveSettings.BatchArchiveSlatesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchArchiveSlates);
            Modify_BatchArchiveSlatesApiCall(ref _callBatchArchiveSlates);
            _callBatchUnarchiveSlates = clientHelper.BuildApiCall<BatchUnarchiveSlatesRequest, BatchUnarchiveSlatesResponse>("BatchUnarchiveSlates", grpcClient.BatchUnarchiveSlatesAsync, grpcClient.BatchUnarchiveSlates, effectiveSettings.BatchUnarchiveSlatesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchUnarchiveSlates);
            Modify_BatchUnarchiveSlatesApiCall(ref _callBatchUnarchiveSlates);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetSlateApiCall(ref gaxgrpc::ApiCall<GetSlateRequest, Slate> call);

        partial void Modify_ListSlatesApiCall(ref gaxgrpc::ApiCall<ListSlatesRequest, ListSlatesResponse> call);

        partial void Modify_CreateSlateApiCall(ref gaxgrpc::ApiCall<CreateSlateRequest, Slate> call);

        partial void Modify_BatchCreateSlatesApiCall(ref gaxgrpc::ApiCall<BatchCreateSlatesRequest, BatchCreateSlatesResponse> call);

        partial void Modify_UpdateSlateApiCall(ref gaxgrpc::ApiCall<UpdateSlateRequest, Slate> call);

        partial void Modify_BatchUpdateSlatesApiCall(ref gaxgrpc::ApiCall<BatchUpdateSlatesRequest, BatchUpdateSlatesResponse> call);

        partial void Modify_BatchArchiveSlatesApiCall(ref gaxgrpc::ApiCall<BatchArchiveSlatesRequest, BatchArchiveSlatesResponse> call);

        partial void Modify_BatchUnarchiveSlatesApiCall(ref gaxgrpc::ApiCall<BatchUnarchiveSlatesRequest, BatchUnarchiveSlatesResponse> call);

        partial void OnConstruction(SlateService.SlateServiceClient grpcClient, SlateServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SlateService client</summary>
        public override SlateService.SlateServiceClient GrpcClient { get; }

        partial void Modify_GetSlateRequest(ref GetSlateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSlatesRequest(ref ListSlatesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateSlateRequest(ref CreateSlateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchCreateSlatesRequest(ref BatchCreateSlatesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSlateRequest(ref UpdateSlateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchUpdateSlatesRequest(ref BatchUpdateSlatesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchArchiveSlatesRequest(ref BatchArchiveSlatesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchUnarchiveSlatesRequest(ref BatchUnarchiveSlatesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves a `Slate` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Slate GetSlate(GetSlateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSlateRequest(ref request, ref callSettings);
            return _callGetSlate.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a `Slate` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Slate> GetSlateAsync(GetSlateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSlateRequest(ref request, ref callSettings);
            return _callGetSlate.Async(request, callSettings);
        }

        /// <summary>
        /// Lists `Slate` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Slate"/> resources.</returns>
        public override gax::PagedEnumerable<ListSlatesResponse, Slate> ListSlates(ListSlatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSlatesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSlatesRequest, ListSlatesResponse, Slate>(_callListSlates, request, callSettings);
        }

        /// <summary>
        /// Lists `Slate` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Slate"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSlatesResponse, Slate> ListSlatesAsync(ListSlatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSlatesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSlatesRequest, ListSlatesResponse, Slate>(_callListSlates, request, callSettings);
        }

        /// <summary>
        /// Creates a `Slate` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Slate CreateSlate(CreateSlateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSlateRequest(ref request, ref callSettings);
            return _callCreateSlate.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a `Slate` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Slate> CreateSlateAsync(CreateSlateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSlateRequest(ref request, ref callSettings);
            return _callCreateSlate.Async(request, callSettings);
        }

        /// <summary>
        /// Batch creates `Slate` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchCreateSlatesResponse BatchCreateSlates(BatchCreateSlatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateSlatesRequest(ref request, ref callSettings);
            return _callBatchCreateSlates.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch creates `Slate` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchCreateSlatesResponse> BatchCreateSlatesAsync(BatchCreateSlatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateSlatesRequest(ref request, ref callSettings);
            return _callBatchCreateSlates.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a `Slate` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Slate UpdateSlate(UpdateSlateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSlateRequest(ref request, ref callSettings);
            return _callUpdateSlate.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a `Slate` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Slate> UpdateSlateAsync(UpdateSlateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSlateRequest(ref request, ref callSettings);
            return _callUpdateSlate.Async(request, callSettings);
        }

        /// <summary>
        /// Batch updates `Slate` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchUpdateSlatesResponse BatchUpdateSlates(BatchUpdateSlatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateSlatesRequest(ref request, ref callSettings);
            return _callBatchUpdateSlates.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch updates `Slate` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchUpdateSlatesResponse> BatchUpdateSlatesAsync(BatchUpdateSlatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateSlatesRequest(ref request, ref callSettings);
            return _callBatchUpdateSlates.Async(request, callSettings);
        }

        /// <summary>
        /// Batch archives `Slate` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchArchiveSlatesResponse BatchArchiveSlates(BatchArchiveSlatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchArchiveSlatesRequest(ref request, ref callSettings);
            return _callBatchArchiveSlates.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch archives `Slate` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchArchiveSlatesResponse> BatchArchiveSlatesAsync(BatchArchiveSlatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchArchiveSlatesRequest(ref request, ref callSettings);
            return _callBatchArchiveSlates.Async(request, callSettings);
        }

        /// <summary>
        /// Batch unarchives `Slate` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchUnarchiveSlatesResponse BatchUnarchiveSlates(BatchUnarchiveSlatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUnarchiveSlatesRequest(ref request, ref callSettings);
            return _callBatchUnarchiveSlates.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch unarchives `Slate` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchUnarchiveSlatesResponse> BatchUnarchiveSlatesAsync(BatchUnarchiveSlatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUnarchiveSlatesRequest(ref request, ref callSettings);
            return _callBatchUnarchiveSlates.Async(request, callSettings);
        }
    }

    public partial class ListSlatesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSlatesResponse : gaxgrpc::IPageResponse<Slate>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Slate> GetEnumerator() => Slates.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
