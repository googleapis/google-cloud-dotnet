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
    /// <summary>Settings for <see cref="ChildPublisherServiceClient"/> instances.</summary>
    public sealed partial class ChildPublisherServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ChildPublisherServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ChildPublisherServiceSettings"/>.</returns>
        public static ChildPublisherServiceSettings GetDefault() => new ChildPublisherServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ChildPublisherServiceSettings"/> object with default settings.
        /// </summary>
        public ChildPublisherServiceSettings()
        {
        }

        private ChildPublisherServiceSettings(ChildPublisherServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetChildPublisherSettings = existing.GetChildPublisherSettings;
            ListChildPublishersSettings = existing.ListChildPublishersSettings;
            CreateChildPublisherSettings = existing.CreateChildPublisherSettings;
            BatchCreateChildPublishersSettings = existing.BatchCreateChildPublishersSettings;
            UpdateChildPublisherSettings = existing.UpdateChildPublisherSettings;
            BatchUpdateChildPublishersSettings = existing.BatchUpdateChildPublishersSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ChildPublisherServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ChildPublisherServiceClient.GetChildPublisher</c> and
        /// <c>ChildPublisherServiceClient.GetChildPublisherAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetChildPublisherSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ChildPublisherServiceClient.ListChildPublishers</c> and
        /// <c>ChildPublisherServiceClient.ListChildPublishersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListChildPublishersSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ChildPublisherServiceClient.CreateChildPublisher</c> and
        /// <c>ChildPublisherServiceClient.CreateChildPublisherAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateChildPublisherSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ChildPublisherServiceClient.BatchCreateChildPublishers</c> and
        /// <c>ChildPublisherServiceClient.BatchCreateChildPublishersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchCreateChildPublishersSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ChildPublisherServiceClient.UpdateChildPublisher</c> and
        /// <c>ChildPublisherServiceClient.UpdateChildPublisherAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateChildPublisherSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ChildPublisherServiceClient.BatchUpdateChildPublishers</c> and
        /// <c>ChildPublisherServiceClient.BatchUpdateChildPublishersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchUpdateChildPublishersSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ChildPublisherServiceSettings"/> object.</returns>
        public ChildPublisherServiceSettings Clone() => new ChildPublisherServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ChildPublisherServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class ChildPublisherServiceClientBuilder : gaxgrpc::ClientBuilderBase<ChildPublisherServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ChildPublisherServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ChildPublisherServiceClientBuilder() : base(ChildPublisherServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ChildPublisherServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ChildPublisherServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ChildPublisherServiceClient Build()
        {
            ChildPublisherServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ChildPublisherServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ChildPublisherServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ChildPublisherServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ChildPublisherServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ChildPublisherServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ChildPublisherServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ChildPublisherServiceClient.ChannelPool;
    }

    /// <summary>ChildPublisherService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling
    /// [ChildPublisher][google.ads.admanager.v1.ChildPublisher] objects.
    /// </remarks>
    public abstract partial class ChildPublisherServiceClient
    {
        /// <summary>
        /// The default endpoint for the ChildPublisherService service, which is a host of "admanager.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default ChildPublisherService scopes.</summary>
        /// <remarks>
        /// The default ChildPublisherService scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ChildPublisherService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ChildPublisherServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="ChildPublisherServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ChildPublisherServiceClient"/>.</returns>
        public static stt::Task<ChildPublisherServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ChildPublisherServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ChildPublisherServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="ChildPublisherServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ChildPublisherServiceClient"/>.</returns>
        public static ChildPublisherServiceClient Create() => new ChildPublisherServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ChildPublisherServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ChildPublisherServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ChildPublisherServiceClient"/>.</returns>
        internal static ChildPublisherServiceClient Create(grpccore::CallInvoker callInvoker, ChildPublisherServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ChildPublisherService.ChildPublisherServiceClient grpcClient = new ChildPublisherService.ChildPublisherServiceClient(callInvoker);
            return new ChildPublisherServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ChildPublisherService client</summary>
        public virtual ChildPublisherService.ChildPublisherServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a [ChildPublisher][google.ads.admanager.v1.ChildPublisher]
        /// object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ChildPublisher GetChildPublisher(GetChildPublisherRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a [ChildPublisher][google.ads.admanager.v1.ChildPublisher]
        /// object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChildPublisher> GetChildPublisherAsync(GetChildPublisherRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a [ChildPublisher][google.ads.admanager.v1.ChildPublisher]
        /// object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChildPublisher> GetChildPublisherAsync(GetChildPublisherRequest request, st::CancellationToken cancellationToken) =>
            GetChildPublisherAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a [ChildPublisher][google.ads.admanager.v1.ChildPublisher]
        /// object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [ChildPublisher][google.ads.admanager.v1.ChildPublisher]. Format:
        /// `networks/{network_code}/childPublishers/{child_publisher_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ChildPublisher GetChildPublisher(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetChildPublisher(new GetChildPublisherRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a [ChildPublisher][google.ads.admanager.v1.ChildPublisher]
        /// object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [ChildPublisher][google.ads.admanager.v1.ChildPublisher]. Format:
        /// `networks/{network_code}/childPublishers/{child_publisher_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChildPublisher> GetChildPublisherAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetChildPublisherAsync(new GetChildPublisherRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a [ChildPublisher][google.ads.admanager.v1.ChildPublisher]
        /// object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [ChildPublisher][google.ads.admanager.v1.ChildPublisher]. Format:
        /// `networks/{network_code}/childPublishers/{child_publisher_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChildPublisher> GetChildPublisherAsync(string name, st::CancellationToken cancellationToken) =>
            GetChildPublisherAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a [ChildPublisher][google.ads.admanager.v1.ChildPublisher]
        /// object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [ChildPublisher][google.ads.admanager.v1.ChildPublisher]. Format:
        /// `networks/{network_code}/childPublishers/{child_publisher_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ChildPublisher GetChildPublisher(ChildPublisherName name, gaxgrpc::CallSettings callSettings = null) =>
            GetChildPublisher(new GetChildPublisherRequest
            {
                ChildPublisherName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a [ChildPublisher][google.ads.admanager.v1.ChildPublisher]
        /// object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [ChildPublisher][google.ads.admanager.v1.ChildPublisher]. Format:
        /// `networks/{network_code}/childPublishers/{child_publisher_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChildPublisher> GetChildPublisherAsync(ChildPublisherName name, gaxgrpc::CallSettings callSettings = null) =>
            GetChildPublisherAsync(new GetChildPublisherRequest
            {
                ChildPublisherName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a [ChildPublisher][google.ads.admanager.v1.ChildPublisher]
        /// object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [ChildPublisher][google.ads.admanager.v1.ChildPublisher]. Format:
        /// `networks/{network_code}/childPublishers/{child_publisher_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChildPublisher> GetChildPublisherAsync(ChildPublisherName name, st::CancellationToken cancellationToken) =>
            GetChildPublisherAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists [ChildPublisher][google.ads.admanager.v1.ChildPublisher] objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ChildPublisher"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListChildPublishersResponse, ChildPublisher> ListChildPublishers(ListChildPublishersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [ChildPublisher][google.ads.admanager.v1.ChildPublisher] objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ChildPublisher"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListChildPublishersResponse, ChildPublisher> ListChildPublishersAsync(ListChildPublishersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [ChildPublisher][google.ads.admanager.v1.ChildPublisher] objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of
        /// [ChildPublisher][google.ads.admanager.v1.ChildPublisher]s. Format:
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
        /// <returns>A pageable sequence of <see cref="ChildPublisher"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListChildPublishersResponse, ChildPublisher> ListChildPublishers(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListChildPublishersRequest request = new ListChildPublishersRequest
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
            return ListChildPublishers(request, callSettings);
        }

        /// <summary>
        /// Lists [ChildPublisher][google.ads.admanager.v1.ChildPublisher] objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of
        /// [ChildPublisher][google.ads.admanager.v1.ChildPublisher]s. Format:
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
        /// <returns>A pageable asynchronous sequence of <see cref="ChildPublisher"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListChildPublishersResponse, ChildPublisher> ListChildPublishersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListChildPublishersRequest request = new ListChildPublishersRequest
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
            return ListChildPublishersAsync(request, callSettings);
        }

        /// <summary>
        /// Lists [ChildPublisher][google.ads.admanager.v1.ChildPublisher] objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of
        /// [ChildPublisher][google.ads.admanager.v1.ChildPublisher]s. Format:
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
        /// <returns>A pageable sequence of <see cref="ChildPublisher"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListChildPublishersResponse, ChildPublisher> ListChildPublishers(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListChildPublishersRequest request = new ListChildPublishersRequest
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
            return ListChildPublishers(request, callSettings);
        }

        /// <summary>
        /// Lists [ChildPublisher][google.ads.admanager.v1.ChildPublisher] objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of
        /// [ChildPublisher][google.ads.admanager.v1.ChildPublisher]s. Format:
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
        /// <returns>A pageable asynchronous sequence of <see cref="ChildPublisher"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListChildPublishersResponse, ChildPublisher> ListChildPublishersAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListChildPublishersRequest request = new ListChildPublishersRequest
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
            return ListChildPublishersAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a [ChildPublisher][google.ads.admanager.v1.ChildPublisher] object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ChildPublisher CreateChildPublisher(CreateChildPublisherRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a [ChildPublisher][google.ads.admanager.v1.ChildPublisher] object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChildPublisher> CreateChildPublisherAsync(CreateChildPublisherRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a [ChildPublisher][google.ads.admanager.v1.ChildPublisher] object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChildPublisher> CreateChildPublisherAsync(CreateChildPublisherRequest request, st::CancellationToken cancellationToken) =>
            CreateChildPublisherAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a [ChildPublisher][google.ads.admanager.v1.ChildPublisher] object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this
        /// [ChildPublisher][google.ads.admanager.v1.ChildPublisher] will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="childPublisher">
        /// Required. The [ChildPublisher][google.ads.admanager.v1.ChildPublisher] to
        /// create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ChildPublisher CreateChildPublisher(string parent, ChildPublisher childPublisher, gaxgrpc::CallSettings callSettings = null) =>
            CreateChildPublisher(new CreateChildPublisherRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ChildPublisher = gax::GaxPreconditions.CheckNotNull(childPublisher, nameof(childPublisher)),
            }, callSettings);

        /// <summary>
        /// Creates a [ChildPublisher][google.ads.admanager.v1.ChildPublisher] object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this
        /// [ChildPublisher][google.ads.admanager.v1.ChildPublisher] will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="childPublisher">
        /// Required. The [ChildPublisher][google.ads.admanager.v1.ChildPublisher] to
        /// create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChildPublisher> CreateChildPublisherAsync(string parent, ChildPublisher childPublisher, gaxgrpc::CallSettings callSettings = null) =>
            CreateChildPublisherAsync(new CreateChildPublisherRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ChildPublisher = gax::GaxPreconditions.CheckNotNull(childPublisher, nameof(childPublisher)),
            }, callSettings);

        /// <summary>
        /// Creates a [ChildPublisher][google.ads.admanager.v1.ChildPublisher] object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this
        /// [ChildPublisher][google.ads.admanager.v1.ChildPublisher] will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="childPublisher">
        /// Required. The [ChildPublisher][google.ads.admanager.v1.ChildPublisher] to
        /// create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChildPublisher> CreateChildPublisherAsync(string parent, ChildPublisher childPublisher, st::CancellationToken cancellationToken) =>
            CreateChildPublisherAsync(parent, childPublisher, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a [ChildPublisher][google.ads.admanager.v1.ChildPublisher] object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this
        /// [ChildPublisher][google.ads.admanager.v1.ChildPublisher] will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="childPublisher">
        /// Required. The [ChildPublisher][google.ads.admanager.v1.ChildPublisher] to
        /// create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ChildPublisher CreateChildPublisher(NetworkName parent, ChildPublisher childPublisher, gaxgrpc::CallSettings callSettings = null) =>
            CreateChildPublisher(new CreateChildPublisherRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ChildPublisher = gax::GaxPreconditions.CheckNotNull(childPublisher, nameof(childPublisher)),
            }, callSettings);

        /// <summary>
        /// Creates a [ChildPublisher][google.ads.admanager.v1.ChildPublisher] object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this
        /// [ChildPublisher][google.ads.admanager.v1.ChildPublisher] will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="childPublisher">
        /// Required. The [ChildPublisher][google.ads.admanager.v1.ChildPublisher] to
        /// create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChildPublisher> CreateChildPublisherAsync(NetworkName parent, ChildPublisher childPublisher, gaxgrpc::CallSettings callSettings = null) =>
            CreateChildPublisherAsync(new CreateChildPublisherRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ChildPublisher = gax::GaxPreconditions.CheckNotNull(childPublisher, nameof(childPublisher)),
            }, callSettings);

        /// <summary>
        /// Creates a [ChildPublisher][google.ads.admanager.v1.ChildPublisher] object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this
        /// [ChildPublisher][google.ads.admanager.v1.ChildPublisher] will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="childPublisher">
        /// Required. The [ChildPublisher][google.ads.admanager.v1.ChildPublisher] to
        /// create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChildPublisher> CreateChildPublisherAsync(NetworkName parent, ChildPublisher childPublisher, st::CancellationToken cancellationToken) =>
            CreateChildPublisherAsync(parent, childPublisher, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates [ChildPublisher][google.ads.admanager.v1.ChildPublisher] objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateChildPublishersResponse BatchCreateChildPublishers(BatchCreateChildPublishersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates [ChildPublisher][google.ads.admanager.v1.ChildPublisher] objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateChildPublishersResponse> BatchCreateChildPublishersAsync(BatchCreateChildPublishersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates [ChildPublisher][google.ads.admanager.v1.ChildPublisher] objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateChildPublishersResponse> BatchCreateChildPublishersAsync(BatchCreateChildPublishersRequest request, st::CancellationToken cancellationToken) =>
            BatchCreateChildPublishersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates [ChildPublisher][google.ads.admanager.v1.ChildPublisher] objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where
        /// [ChildPublisher][google.ads.admanager.v1.ChildPublisher]s will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateChildPublisherRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The [ChildPublisher][google.ads.admanager.v1.ChildPublisher]
        /// objects to create. A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateChildPublishersResponse BatchCreateChildPublishers(string parent, scg::IEnumerable<CreateChildPublisherRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateChildPublishers(new BatchCreateChildPublishersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates [ChildPublisher][google.ads.admanager.v1.ChildPublisher] objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where
        /// [ChildPublisher][google.ads.admanager.v1.ChildPublisher]s will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateChildPublisherRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The [ChildPublisher][google.ads.admanager.v1.ChildPublisher]
        /// objects to create. A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateChildPublishersResponse> BatchCreateChildPublishersAsync(string parent, scg::IEnumerable<CreateChildPublisherRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateChildPublishersAsync(new BatchCreateChildPublishersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates [ChildPublisher][google.ads.admanager.v1.ChildPublisher] objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where
        /// [ChildPublisher][google.ads.admanager.v1.ChildPublisher]s will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateChildPublisherRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The [ChildPublisher][google.ads.admanager.v1.ChildPublisher]
        /// objects to create. A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateChildPublishersResponse> BatchCreateChildPublishersAsync(string parent, scg::IEnumerable<CreateChildPublisherRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateChildPublishersAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates [ChildPublisher][google.ads.admanager.v1.ChildPublisher] objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where
        /// [ChildPublisher][google.ads.admanager.v1.ChildPublisher]s will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateChildPublisherRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The [ChildPublisher][google.ads.admanager.v1.ChildPublisher]
        /// objects to create. A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateChildPublishersResponse BatchCreateChildPublishers(NetworkName parent, scg::IEnumerable<CreateChildPublisherRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateChildPublishers(new BatchCreateChildPublishersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates [ChildPublisher][google.ads.admanager.v1.ChildPublisher] objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where
        /// [ChildPublisher][google.ads.admanager.v1.ChildPublisher]s will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateChildPublisherRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The [ChildPublisher][google.ads.admanager.v1.ChildPublisher]
        /// objects to create. A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateChildPublishersResponse> BatchCreateChildPublishersAsync(NetworkName parent, scg::IEnumerable<CreateChildPublisherRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateChildPublishersAsync(new BatchCreateChildPublishersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates [ChildPublisher][google.ads.admanager.v1.ChildPublisher] objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where
        /// [ChildPublisher][google.ads.admanager.v1.ChildPublisher]s will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateChildPublisherRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The [ChildPublisher][google.ads.admanager.v1.ChildPublisher]
        /// objects to create. A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateChildPublishersResponse> BatchCreateChildPublishersAsync(NetworkName parent, scg::IEnumerable<CreateChildPublisherRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateChildPublishersAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a [ChildPublisher][google.ads.admanager.v1.ChildPublisher] object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ChildPublisher UpdateChildPublisher(UpdateChildPublisherRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a [ChildPublisher][google.ads.admanager.v1.ChildPublisher] object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChildPublisher> UpdateChildPublisherAsync(UpdateChildPublisherRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a [ChildPublisher][google.ads.admanager.v1.ChildPublisher] object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChildPublisher> UpdateChildPublisherAsync(UpdateChildPublisherRequest request, st::CancellationToken cancellationToken) =>
            UpdateChildPublisherAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a [ChildPublisher][google.ads.admanager.v1.ChildPublisher] object.
        /// </summary>
        /// <param name="childPublisher">
        /// Required. The [ChildPublisher][google.ads.admanager.v1.ChildPublisher] to
        /// update.
        /// 
        /// The [ChildPublisher][google.ads.admanager.v1.ChildPublisher]'s `name` is
        /// used to identify the
        /// [ChildPublisher][google.ads.admanager.v1.ChildPublisher] to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ChildPublisher UpdateChildPublisher(ChildPublisher childPublisher, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateChildPublisher(new UpdateChildPublisherRequest
            {
                ChildPublisher = gax::GaxPreconditions.CheckNotNull(childPublisher, nameof(childPublisher)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a [ChildPublisher][google.ads.admanager.v1.ChildPublisher] object.
        /// </summary>
        /// <param name="childPublisher">
        /// Required. The [ChildPublisher][google.ads.admanager.v1.ChildPublisher] to
        /// update.
        /// 
        /// The [ChildPublisher][google.ads.admanager.v1.ChildPublisher]'s `name` is
        /// used to identify the
        /// [ChildPublisher][google.ads.admanager.v1.ChildPublisher] to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChildPublisher> UpdateChildPublisherAsync(ChildPublisher childPublisher, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateChildPublisherAsync(new UpdateChildPublisherRequest
            {
                ChildPublisher = gax::GaxPreconditions.CheckNotNull(childPublisher, nameof(childPublisher)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a [ChildPublisher][google.ads.admanager.v1.ChildPublisher] object.
        /// </summary>
        /// <param name="childPublisher">
        /// Required. The [ChildPublisher][google.ads.admanager.v1.ChildPublisher] to
        /// update.
        /// 
        /// The [ChildPublisher][google.ads.admanager.v1.ChildPublisher]'s `name` is
        /// used to identify the
        /// [ChildPublisher][google.ads.admanager.v1.ChildPublisher] to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChildPublisher> UpdateChildPublisherAsync(ChildPublisher childPublisher, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateChildPublisherAsync(childPublisher, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates [ChildPublisher][google.ads.admanager.v1.ChildPublisher]
        /// objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateChildPublishersResponse BatchUpdateChildPublishers(BatchUpdateChildPublishersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch updates [ChildPublisher][google.ads.admanager.v1.ChildPublisher]
        /// objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateChildPublishersResponse> BatchUpdateChildPublishersAsync(BatchUpdateChildPublishersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch updates [ChildPublisher][google.ads.admanager.v1.ChildPublisher]
        /// objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateChildPublishersResponse> BatchUpdateChildPublishersAsync(BatchUpdateChildPublishersRequest request, st::CancellationToken cancellationToken) =>
            BatchUpdateChildPublishersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates [ChildPublisher][google.ads.admanager.v1.ChildPublisher]
        /// objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where
        /// [ChildPublisher][google.ads.admanager.v1.ChildPublisher]s will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateChildPublisherRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The [ChildPublisher][google.ads.admanager.v1.ChildPublisher]
        /// objects to update. A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateChildPublishersResponse BatchUpdateChildPublishers(string parent, scg::IEnumerable<UpdateChildPublisherRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateChildPublishers(new BatchUpdateChildPublishersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates [ChildPublisher][google.ads.admanager.v1.ChildPublisher]
        /// objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where
        /// [ChildPublisher][google.ads.admanager.v1.ChildPublisher]s will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateChildPublisherRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The [ChildPublisher][google.ads.admanager.v1.ChildPublisher]
        /// objects to update. A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateChildPublishersResponse> BatchUpdateChildPublishersAsync(string parent, scg::IEnumerable<UpdateChildPublisherRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateChildPublishersAsync(new BatchUpdateChildPublishersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates [ChildPublisher][google.ads.admanager.v1.ChildPublisher]
        /// objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where
        /// [ChildPublisher][google.ads.admanager.v1.ChildPublisher]s will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateChildPublisherRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The [ChildPublisher][google.ads.admanager.v1.ChildPublisher]
        /// objects to update. A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateChildPublishersResponse> BatchUpdateChildPublishersAsync(string parent, scg::IEnumerable<UpdateChildPublisherRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateChildPublishersAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates [ChildPublisher][google.ads.admanager.v1.ChildPublisher]
        /// objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where
        /// [ChildPublisher][google.ads.admanager.v1.ChildPublisher]s will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateChildPublisherRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The [ChildPublisher][google.ads.admanager.v1.ChildPublisher]
        /// objects to update. A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateChildPublishersResponse BatchUpdateChildPublishers(NetworkName parent, scg::IEnumerable<UpdateChildPublisherRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateChildPublishers(new BatchUpdateChildPublishersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates [ChildPublisher][google.ads.admanager.v1.ChildPublisher]
        /// objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where
        /// [ChildPublisher][google.ads.admanager.v1.ChildPublisher]s will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateChildPublisherRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The [ChildPublisher][google.ads.admanager.v1.ChildPublisher]
        /// objects to update. A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateChildPublishersResponse> BatchUpdateChildPublishersAsync(NetworkName parent, scg::IEnumerable<UpdateChildPublisherRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateChildPublishersAsync(new BatchUpdateChildPublishersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates [ChildPublisher][google.ads.admanager.v1.ChildPublisher]
        /// objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where
        /// [ChildPublisher][google.ads.admanager.v1.ChildPublisher]s will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateChildPublisherRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The [ChildPublisher][google.ads.admanager.v1.ChildPublisher]
        /// objects to update. A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateChildPublishersResponse> BatchUpdateChildPublishersAsync(NetworkName parent, scg::IEnumerable<UpdateChildPublisherRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateChildPublishersAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ChildPublisherService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling
    /// [ChildPublisher][google.ads.admanager.v1.ChildPublisher] objects.
    /// </remarks>
    public sealed partial class ChildPublisherServiceClientImpl : ChildPublisherServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetChildPublisherRequest, ChildPublisher> _callGetChildPublisher;

        private readonly gaxgrpc::ApiCall<ListChildPublishersRequest, ListChildPublishersResponse> _callListChildPublishers;

        private readonly gaxgrpc::ApiCall<CreateChildPublisherRequest, ChildPublisher> _callCreateChildPublisher;

        private readonly gaxgrpc::ApiCall<BatchCreateChildPublishersRequest, BatchCreateChildPublishersResponse> _callBatchCreateChildPublishers;

        private readonly gaxgrpc::ApiCall<UpdateChildPublisherRequest, ChildPublisher> _callUpdateChildPublisher;

        private readonly gaxgrpc::ApiCall<BatchUpdateChildPublishersRequest, BatchUpdateChildPublishersResponse> _callBatchUpdateChildPublishers;

        /// <summary>
        /// Constructs a client wrapper for the ChildPublisherService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ChildPublisherServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ChildPublisherServiceClientImpl(ChildPublisherService.ChildPublisherServiceClient grpcClient, ChildPublisherServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ChildPublisherServiceSettings effectiveSettings = settings ?? ChildPublisherServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetChildPublisher = clientHelper.BuildApiCall<GetChildPublisherRequest, ChildPublisher>("GetChildPublisher", grpcClient.GetChildPublisherAsync, grpcClient.GetChildPublisher, effectiveSettings.GetChildPublisherSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetChildPublisher);
            Modify_GetChildPublisherApiCall(ref _callGetChildPublisher);
            _callListChildPublishers = clientHelper.BuildApiCall<ListChildPublishersRequest, ListChildPublishersResponse>("ListChildPublishers", grpcClient.ListChildPublishersAsync, grpcClient.ListChildPublishers, effectiveSettings.ListChildPublishersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListChildPublishers);
            Modify_ListChildPublishersApiCall(ref _callListChildPublishers);
            _callCreateChildPublisher = clientHelper.BuildApiCall<CreateChildPublisherRequest, ChildPublisher>("CreateChildPublisher", grpcClient.CreateChildPublisherAsync, grpcClient.CreateChildPublisher, effectiveSettings.CreateChildPublisherSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateChildPublisher);
            Modify_CreateChildPublisherApiCall(ref _callCreateChildPublisher);
            _callBatchCreateChildPublishers = clientHelper.BuildApiCall<BatchCreateChildPublishersRequest, BatchCreateChildPublishersResponse>("BatchCreateChildPublishers", grpcClient.BatchCreateChildPublishersAsync, grpcClient.BatchCreateChildPublishers, effectiveSettings.BatchCreateChildPublishersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchCreateChildPublishers);
            Modify_BatchCreateChildPublishersApiCall(ref _callBatchCreateChildPublishers);
            _callUpdateChildPublisher = clientHelper.BuildApiCall<UpdateChildPublisherRequest, ChildPublisher>("UpdateChildPublisher", grpcClient.UpdateChildPublisherAsync, grpcClient.UpdateChildPublisher, effectiveSettings.UpdateChildPublisherSettings).WithGoogleRequestParam("child_publisher.name", request => request.ChildPublisher?.Name);
            Modify_ApiCall(ref _callUpdateChildPublisher);
            Modify_UpdateChildPublisherApiCall(ref _callUpdateChildPublisher);
            _callBatchUpdateChildPublishers = clientHelper.BuildApiCall<BatchUpdateChildPublishersRequest, BatchUpdateChildPublishersResponse>("BatchUpdateChildPublishers", grpcClient.BatchUpdateChildPublishersAsync, grpcClient.BatchUpdateChildPublishers, effectiveSettings.BatchUpdateChildPublishersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchUpdateChildPublishers);
            Modify_BatchUpdateChildPublishersApiCall(ref _callBatchUpdateChildPublishers);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetChildPublisherApiCall(ref gaxgrpc::ApiCall<GetChildPublisherRequest, ChildPublisher> call);

        partial void Modify_ListChildPublishersApiCall(ref gaxgrpc::ApiCall<ListChildPublishersRequest, ListChildPublishersResponse> call);

        partial void Modify_CreateChildPublisherApiCall(ref gaxgrpc::ApiCall<CreateChildPublisherRequest, ChildPublisher> call);

        partial void Modify_BatchCreateChildPublishersApiCall(ref gaxgrpc::ApiCall<BatchCreateChildPublishersRequest, BatchCreateChildPublishersResponse> call);

        partial void Modify_UpdateChildPublisherApiCall(ref gaxgrpc::ApiCall<UpdateChildPublisherRequest, ChildPublisher> call);

        partial void Modify_BatchUpdateChildPublishersApiCall(ref gaxgrpc::ApiCall<BatchUpdateChildPublishersRequest, BatchUpdateChildPublishersResponse> call);

        partial void OnConstruction(ChildPublisherService.ChildPublisherServiceClient grpcClient, ChildPublisherServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ChildPublisherService client</summary>
        public override ChildPublisherService.ChildPublisherServiceClient GrpcClient { get; }

        partial void Modify_GetChildPublisherRequest(ref GetChildPublisherRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListChildPublishersRequest(ref ListChildPublishersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateChildPublisherRequest(ref CreateChildPublisherRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchCreateChildPublishersRequest(ref BatchCreateChildPublishersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateChildPublisherRequest(ref UpdateChildPublisherRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchUpdateChildPublishersRequest(ref BatchUpdateChildPublishersRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves a [ChildPublisher][google.ads.admanager.v1.ChildPublisher]
        /// object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ChildPublisher GetChildPublisher(GetChildPublisherRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetChildPublisherRequest(ref request, ref callSettings);
            return _callGetChildPublisher.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a [ChildPublisher][google.ads.admanager.v1.ChildPublisher]
        /// object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ChildPublisher> GetChildPublisherAsync(GetChildPublisherRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetChildPublisherRequest(ref request, ref callSettings);
            return _callGetChildPublisher.Async(request, callSettings);
        }

        /// <summary>
        /// Lists [ChildPublisher][google.ads.admanager.v1.ChildPublisher] objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ChildPublisher"/> resources.</returns>
        public override gax::PagedEnumerable<ListChildPublishersResponse, ChildPublisher> ListChildPublishers(ListChildPublishersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListChildPublishersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListChildPublishersRequest, ListChildPublishersResponse, ChildPublisher>(_callListChildPublishers, request, callSettings);
        }

        /// <summary>
        /// Lists [ChildPublisher][google.ads.admanager.v1.ChildPublisher] objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ChildPublisher"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListChildPublishersResponse, ChildPublisher> ListChildPublishersAsync(ListChildPublishersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListChildPublishersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListChildPublishersRequest, ListChildPublishersResponse, ChildPublisher>(_callListChildPublishers, request, callSettings);
        }

        /// <summary>
        /// Creates a [ChildPublisher][google.ads.admanager.v1.ChildPublisher] object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ChildPublisher CreateChildPublisher(CreateChildPublisherRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateChildPublisherRequest(ref request, ref callSettings);
            return _callCreateChildPublisher.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a [ChildPublisher][google.ads.admanager.v1.ChildPublisher] object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ChildPublisher> CreateChildPublisherAsync(CreateChildPublisherRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateChildPublisherRequest(ref request, ref callSettings);
            return _callCreateChildPublisher.Async(request, callSettings);
        }

        /// <summary>
        /// Creates [ChildPublisher][google.ads.admanager.v1.ChildPublisher] objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchCreateChildPublishersResponse BatchCreateChildPublishers(BatchCreateChildPublishersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateChildPublishersRequest(ref request, ref callSettings);
            return _callBatchCreateChildPublishers.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates [ChildPublisher][google.ads.admanager.v1.ChildPublisher] objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchCreateChildPublishersResponse> BatchCreateChildPublishersAsync(BatchCreateChildPublishersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateChildPublishersRequest(ref request, ref callSettings);
            return _callBatchCreateChildPublishers.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a [ChildPublisher][google.ads.admanager.v1.ChildPublisher] object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ChildPublisher UpdateChildPublisher(UpdateChildPublisherRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateChildPublisherRequest(ref request, ref callSettings);
            return _callUpdateChildPublisher.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a [ChildPublisher][google.ads.admanager.v1.ChildPublisher] object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ChildPublisher> UpdateChildPublisherAsync(UpdateChildPublisherRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateChildPublisherRequest(ref request, ref callSettings);
            return _callUpdateChildPublisher.Async(request, callSettings);
        }

        /// <summary>
        /// Batch updates [ChildPublisher][google.ads.admanager.v1.ChildPublisher]
        /// objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchUpdateChildPublishersResponse BatchUpdateChildPublishers(BatchUpdateChildPublishersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateChildPublishersRequest(ref request, ref callSettings);
            return _callBatchUpdateChildPublishers.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch updates [ChildPublisher][google.ads.admanager.v1.ChildPublisher]
        /// objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchUpdateChildPublishersResponse> BatchUpdateChildPublishersAsync(BatchUpdateChildPublishersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateChildPublishersRequest(ref request, ref callSettings);
            return _callBatchUpdateChildPublishers.Async(request, callSettings);
        }
    }

    public partial class ListChildPublishersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListChildPublishersResponse : gaxgrpc::IPageResponse<ChildPublisher>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ChildPublisher> GetEnumerator() => ChildPublishers.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
