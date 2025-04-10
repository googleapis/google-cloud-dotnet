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

namespace Google.Cloud.Chronicle.V1
{
    /// <summary>Settings for <see cref="ReferenceListServiceClient"/> instances.</summary>
    public sealed partial class ReferenceListServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ReferenceListServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ReferenceListServiceSettings"/>.</returns>
        public static ReferenceListServiceSettings GetDefault() => new ReferenceListServiceSettings();

        /// <summary>Constructs a new <see cref="ReferenceListServiceSettings"/> object with default settings.</summary>
        public ReferenceListServiceSettings()
        {
        }

        private ReferenceListServiceSettings(ReferenceListServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetReferenceListSettings = existing.GetReferenceListSettings;
            ListReferenceListsSettings = existing.ListReferenceListsSettings;
            CreateReferenceListSettings = existing.CreateReferenceListSettings;
            UpdateReferenceListSettings = existing.UpdateReferenceListSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ReferenceListServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReferenceListServiceClient.GetReferenceList</c> and <c>ReferenceListServiceClient.GetReferenceListAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetReferenceListSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReferenceListServiceClient.ListReferenceLists</c> and
        /// <c>ReferenceListServiceClient.ListReferenceListsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListReferenceListsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReferenceListServiceClient.CreateReferenceList</c> and
        /// <c>ReferenceListServiceClient.CreateReferenceListAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateReferenceListSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReferenceListServiceClient.UpdateReferenceList</c> and
        /// <c>ReferenceListServiceClient.UpdateReferenceListAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateReferenceListSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ReferenceListServiceSettings"/> object.</returns>
        public ReferenceListServiceSettings Clone() => new ReferenceListServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ReferenceListServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class ReferenceListServiceClientBuilder : gaxgrpc::ClientBuilderBase<ReferenceListServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ReferenceListServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ReferenceListServiceClientBuilder() : base(ReferenceListServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ReferenceListServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ReferenceListServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ReferenceListServiceClient Build()
        {
            ReferenceListServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ReferenceListServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ReferenceListServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ReferenceListServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ReferenceListServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ReferenceListServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ReferenceListServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ReferenceListServiceClient.ChannelPool;
    }

    /// <summary>ReferenceListService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// ReferenceListService provides an interface for managing reference lists.
    /// </remarks>
    public abstract partial class ReferenceListServiceClient
    {
        /// <summary>
        /// The default endpoint for the ReferenceListService service, which is a host of "chronicle.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "chronicle.googleapis.com:443";

        /// <summary>The default ReferenceListService scopes.</summary>
        /// <remarks>
        /// The default ReferenceListService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ReferenceListService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ReferenceListServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="ReferenceListServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ReferenceListServiceClient"/>.</returns>
        public static stt::Task<ReferenceListServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ReferenceListServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ReferenceListServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="ReferenceListServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ReferenceListServiceClient"/>.</returns>
        public static ReferenceListServiceClient Create() => new ReferenceListServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ReferenceListServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ReferenceListServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ReferenceListServiceClient"/>.</returns>
        internal static ReferenceListServiceClient Create(grpccore::CallInvoker callInvoker, ReferenceListServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ReferenceListService.ReferenceListServiceClient grpcClient = new ReferenceListService.ReferenceListServiceClient(callInvoker);
            return new ReferenceListServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ReferenceListService client</summary>
        public virtual ReferenceListService.ReferenceListServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a single reference list.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReferenceList GetReferenceList(GetReferenceListRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a single reference list.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReferenceList> GetReferenceListAsync(GetReferenceListRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a single reference list.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReferenceList> GetReferenceListAsync(GetReferenceListRequest request, st::CancellationToken cancellationToken) =>
            GetReferenceListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single reference list.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the reference list to retrieve.
        /// Format:
        /// `projects/{project}/locations/{locations}/instances/{instance}/referenceLists/{reference_list}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReferenceList GetReferenceList(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetReferenceList(new GetReferenceListRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single reference list.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the reference list to retrieve.
        /// Format:
        /// `projects/{project}/locations/{locations}/instances/{instance}/referenceLists/{reference_list}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReferenceList> GetReferenceListAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetReferenceListAsync(new GetReferenceListRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single reference list.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the reference list to retrieve.
        /// Format:
        /// `projects/{project}/locations/{locations}/instances/{instance}/referenceLists/{reference_list}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReferenceList> GetReferenceListAsync(string name, st::CancellationToken cancellationToken) =>
            GetReferenceListAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single reference list.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the reference list to retrieve.
        /// Format:
        /// `projects/{project}/locations/{locations}/instances/{instance}/referenceLists/{reference_list}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReferenceList GetReferenceList(ReferenceListName name, gaxgrpc::CallSettings callSettings = null) =>
            GetReferenceList(new GetReferenceListRequest
            {
                ReferenceListName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single reference list.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the reference list to retrieve.
        /// Format:
        /// `projects/{project}/locations/{locations}/instances/{instance}/referenceLists/{reference_list}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReferenceList> GetReferenceListAsync(ReferenceListName name, gaxgrpc::CallSettings callSettings = null) =>
            GetReferenceListAsync(new GetReferenceListRequest
            {
                ReferenceListName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single reference list.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the reference list to retrieve.
        /// Format:
        /// `projects/{project}/locations/{locations}/instances/{instance}/referenceLists/{reference_list}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReferenceList> GetReferenceListAsync(ReferenceListName name, st::CancellationToken cancellationToken) =>
            GetReferenceListAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists a collection of reference lists.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ReferenceList"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReferenceListsResponse, ReferenceList> ListReferenceLists(ListReferenceListsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists a collection of reference lists.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ReferenceList"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReferenceListsResponse, ReferenceList> ListReferenceListsAsync(ListReferenceListsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists a collection of reference lists.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of reference lists.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}`
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
        /// <returns>A pageable sequence of <see cref="ReferenceList"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReferenceListsResponse, ReferenceList> ListReferenceLists(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReferenceListsRequest request = new ListReferenceListsRequest
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
            return ListReferenceLists(request, callSettings);
        }

        /// <summary>
        /// Lists a collection of reference lists.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of reference lists.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="ReferenceList"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReferenceListsResponse, ReferenceList> ListReferenceListsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReferenceListsRequest request = new ListReferenceListsRequest
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
            return ListReferenceListsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists a collection of reference lists.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of reference lists.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}`
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
        /// <returns>A pageable sequence of <see cref="ReferenceList"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReferenceListsResponse, ReferenceList> ListReferenceLists(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReferenceListsRequest request = new ListReferenceListsRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListReferenceLists(request, callSettings);
        }

        /// <summary>
        /// Lists a collection of reference lists.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of reference lists.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="ReferenceList"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReferenceListsResponse, ReferenceList> ListReferenceListsAsync(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReferenceListsRequest request = new ListReferenceListsRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListReferenceListsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a new reference list.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReferenceList CreateReferenceList(CreateReferenceListRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new reference list.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReferenceList> CreateReferenceListAsync(CreateReferenceListRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new reference list.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReferenceList> CreateReferenceListAsync(CreateReferenceListRequest request, st::CancellationToken cancellationToken) =>
            CreateReferenceListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new reference list.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this reference list will be created.
        /// Format: `projects/{project}/locations/{location}/instances/{instance}`
        /// </param>
        /// <param name="referenceList">
        /// Required. The reference list to create.
        /// </param>
        /// <param name="referenceListId">
        /// Required. The ID to use for the reference list. This is also the display
        /// name for the reference list. It must satisfy the following requirements:
        /// - Starts with letter.
        /// - Contains only letters, numbers and underscore.
        /// - Has length less than 256.
        /// - Must be unique.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReferenceList CreateReferenceList(string parent, ReferenceList referenceList, string referenceListId, gaxgrpc::CallSettings callSettings = null) =>
            CreateReferenceList(new CreateReferenceListRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ReferenceList = gax::GaxPreconditions.CheckNotNull(referenceList, nameof(referenceList)),
                ReferenceListId = gax::GaxPreconditions.CheckNotNullOrEmpty(referenceListId, nameof(referenceListId)),
            }, callSettings);

        /// <summary>
        /// Creates a new reference list.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this reference list will be created.
        /// Format: `projects/{project}/locations/{location}/instances/{instance}`
        /// </param>
        /// <param name="referenceList">
        /// Required. The reference list to create.
        /// </param>
        /// <param name="referenceListId">
        /// Required. The ID to use for the reference list. This is also the display
        /// name for the reference list. It must satisfy the following requirements:
        /// - Starts with letter.
        /// - Contains only letters, numbers and underscore.
        /// - Has length less than 256.
        /// - Must be unique.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReferenceList> CreateReferenceListAsync(string parent, ReferenceList referenceList, string referenceListId, gaxgrpc::CallSettings callSettings = null) =>
            CreateReferenceListAsync(new CreateReferenceListRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ReferenceList = gax::GaxPreconditions.CheckNotNull(referenceList, nameof(referenceList)),
                ReferenceListId = gax::GaxPreconditions.CheckNotNullOrEmpty(referenceListId, nameof(referenceListId)),
            }, callSettings);

        /// <summary>
        /// Creates a new reference list.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this reference list will be created.
        /// Format: `projects/{project}/locations/{location}/instances/{instance}`
        /// </param>
        /// <param name="referenceList">
        /// Required. The reference list to create.
        /// </param>
        /// <param name="referenceListId">
        /// Required. The ID to use for the reference list. This is also the display
        /// name for the reference list. It must satisfy the following requirements:
        /// - Starts with letter.
        /// - Contains only letters, numbers and underscore.
        /// - Has length less than 256.
        /// - Must be unique.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReferenceList> CreateReferenceListAsync(string parent, ReferenceList referenceList, string referenceListId, st::CancellationToken cancellationToken) =>
            CreateReferenceListAsync(parent, referenceList, referenceListId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new reference list.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this reference list will be created.
        /// Format: `projects/{project}/locations/{location}/instances/{instance}`
        /// </param>
        /// <param name="referenceList">
        /// Required. The reference list to create.
        /// </param>
        /// <param name="referenceListId">
        /// Required. The ID to use for the reference list. This is also the display
        /// name for the reference list. It must satisfy the following requirements:
        /// - Starts with letter.
        /// - Contains only letters, numbers and underscore.
        /// - Has length less than 256.
        /// - Must be unique.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReferenceList CreateReferenceList(InstanceName parent, ReferenceList referenceList, string referenceListId, gaxgrpc::CallSettings callSettings = null) =>
            CreateReferenceList(new CreateReferenceListRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ReferenceList = gax::GaxPreconditions.CheckNotNull(referenceList, nameof(referenceList)),
                ReferenceListId = gax::GaxPreconditions.CheckNotNullOrEmpty(referenceListId, nameof(referenceListId)),
            }, callSettings);

        /// <summary>
        /// Creates a new reference list.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this reference list will be created.
        /// Format: `projects/{project}/locations/{location}/instances/{instance}`
        /// </param>
        /// <param name="referenceList">
        /// Required. The reference list to create.
        /// </param>
        /// <param name="referenceListId">
        /// Required. The ID to use for the reference list. This is also the display
        /// name for the reference list. It must satisfy the following requirements:
        /// - Starts with letter.
        /// - Contains only letters, numbers and underscore.
        /// - Has length less than 256.
        /// - Must be unique.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReferenceList> CreateReferenceListAsync(InstanceName parent, ReferenceList referenceList, string referenceListId, gaxgrpc::CallSettings callSettings = null) =>
            CreateReferenceListAsync(new CreateReferenceListRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ReferenceList = gax::GaxPreconditions.CheckNotNull(referenceList, nameof(referenceList)),
                ReferenceListId = gax::GaxPreconditions.CheckNotNullOrEmpty(referenceListId, nameof(referenceListId)),
            }, callSettings);

        /// <summary>
        /// Creates a new reference list.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this reference list will be created.
        /// Format: `projects/{project}/locations/{location}/instances/{instance}`
        /// </param>
        /// <param name="referenceList">
        /// Required. The reference list to create.
        /// </param>
        /// <param name="referenceListId">
        /// Required. The ID to use for the reference list. This is also the display
        /// name for the reference list. It must satisfy the following requirements:
        /// - Starts with letter.
        /// - Contains only letters, numbers and underscore.
        /// - Has length less than 256.
        /// - Must be unique.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReferenceList> CreateReferenceListAsync(InstanceName parent, ReferenceList referenceList, string referenceListId, st::CancellationToken cancellationToken) =>
            CreateReferenceListAsync(parent, referenceList, referenceListId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing reference list.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReferenceList UpdateReferenceList(UpdateReferenceListRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing reference list.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReferenceList> UpdateReferenceListAsync(UpdateReferenceListRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing reference list.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReferenceList> UpdateReferenceListAsync(UpdateReferenceListRequest request, st::CancellationToken cancellationToken) =>
            UpdateReferenceListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing reference list.
        /// </summary>
        /// <param name="referenceList">
        /// Required. The reference list to update.
        /// 
        /// The reference list's `name` field is used to identify the reference list to
        /// update.
        /// Format:
        /// `projects/{project}/locations/{locations}/instances/{instance}/referenceLists/{reference_list}`
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to update.
        /// When no field mask is supplied, all non-empty fields will be updated.
        /// A field mask of "*" will update all fields, whether empty or not.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReferenceList UpdateReferenceList(ReferenceList referenceList, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateReferenceList(new UpdateReferenceListRequest
            {
                ReferenceList = gax::GaxPreconditions.CheckNotNull(referenceList, nameof(referenceList)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an existing reference list.
        /// </summary>
        /// <param name="referenceList">
        /// Required. The reference list to update.
        /// 
        /// The reference list's `name` field is used to identify the reference list to
        /// update.
        /// Format:
        /// `projects/{project}/locations/{locations}/instances/{instance}/referenceLists/{reference_list}`
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to update.
        /// When no field mask is supplied, all non-empty fields will be updated.
        /// A field mask of "*" will update all fields, whether empty or not.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReferenceList> UpdateReferenceListAsync(ReferenceList referenceList, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateReferenceListAsync(new UpdateReferenceListRequest
            {
                ReferenceList = gax::GaxPreconditions.CheckNotNull(referenceList, nameof(referenceList)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an existing reference list.
        /// </summary>
        /// <param name="referenceList">
        /// Required. The reference list to update.
        /// 
        /// The reference list's `name` field is used to identify the reference list to
        /// update.
        /// Format:
        /// `projects/{project}/locations/{locations}/instances/{instance}/referenceLists/{reference_list}`
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to update.
        /// When no field mask is supplied, all non-empty fields will be updated.
        /// A field mask of "*" will update all fields, whether empty or not.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReferenceList> UpdateReferenceListAsync(ReferenceList referenceList, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateReferenceListAsync(referenceList, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ReferenceListService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// ReferenceListService provides an interface for managing reference lists.
    /// </remarks>
    public sealed partial class ReferenceListServiceClientImpl : ReferenceListServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetReferenceListRequest, ReferenceList> _callGetReferenceList;

        private readonly gaxgrpc::ApiCall<ListReferenceListsRequest, ListReferenceListsResponse> _callListReferenceLists;

        private readonly gaxgrpc::ApiCall<CreateReferenceListRequest, ReferenceList> _callCreateReferenceList;

        private readonly gaxgrpc::ApiCall<UpdateReferenceListRequest, ReferenceList> _callUpdateReferenceList;

        /// <summary>
        /// Constructs a client wrapper for the ReferenceListService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ReferenceListServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ReferenceListServiceClientImpl(ReferenceListService.ReferenceListServiceClient grpcClient, ReferenceListServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ReferenceListServiceSettings effectiveSettings = settings ?? ReferenceListServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetReferenceList = clientHelper.BuildApiCall<GetReferenceListRequest, ReferenceList>("GetReferenceList", grpcClient.GetReferenceListAsync, grpcClient.GetReferenceList, effectiveSettings.GetReferenceListSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetReferenceList);
            Modify_GetReferenceListApiCall(ref _callGetReferenceList);
            _callListReferenceLists = clientHelper.BuildApiCall<ListReferenceListsRequest, ListReferenceListsResponse>("ListReferenceLists", grpcClient.ListReferenceListsAsync, grpcClient.ListReferenceLists, effectiveSettings.ListReferenceListsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListReferenceLists);
            Modify_ListReferenceListsApiCall(ref _callListReferenceLists);
            _callCreateReferenceList = clientHelper.BuildApiCall<CreateReferenceListRequest, ReferenceList>("CreateReferenceList", grpcClient.CreateReferenceListAsync, grpcClient.CreateReferenceList, effectiveSettings.CreateReferenceListSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateReferenceList);
            Modify_CreateReferenceListApiCall(ref _callCreateReferenceList);
            _callUpdateReferenceList = clientHelper.BuildApiCall<UpdateReferenceListRequest, ReferenceList>("UpdateReferenceList", grpcClient.UpdateReferenceListAsync, grpcClient.UpdateReferenceList, effectiveSettings.UpdateReferenceListSettings).WithGoogleRequestParam("reference_list.name", request => request.ReferenceList?.Name);
            Modify_ApiCall(ref _callUpdateReferenceList);
            Modify_UpdateReferenceListApiCall(ref _callUpdateReferenceList);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetReferenceListApiCall(ref gaxgrpc::ApiCall<GetReferenceListRequest, ReferenceList> call);

        partial void Modify_ListReferenceListsApiCall(ref gaxgrpc::ApiCall<ListReferenceListsRequest, ListReferenceListsResponse> call);

        partial void Modify_CreateReferenceListApiCall(ref gaxgrpc::ApiCall<CreateReferenceListRequest, ReferenceList> call);

        partial void Modify_UpdateReferenceListApiCall(ref gaxgrpc::ApiCall<UpdateReferenceListRequest, ReferenceList> call);

        partial void OnConstruction(ReferenceListService.ReferenceListServiceClient grpcClient, ReferenceListServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ReferenceListService client</summary>
        public override ReferenceListService.ReferenceListServiceClient GrpcClient { get; }

        partial void Modify_GetReferenceListRequest(ref GetReferenceListRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListReferenceListsRequest(ref ListReferenceListsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateReferenceListRequest(ref CreateReferenceListRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateReferenceListRequest(ref UpdateReferenceListRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets a single reference list.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ReferenceList GetReferenceList(GetReferenceListRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReferenceListRequest(ref request, ref callSettings);
            return _callGetReferenceList.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a single reference list.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ReferenceList> GetReferenceListAsync(GetReferenceListRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReferenceListRequest(ref request, ref callSettings);
            return _callGetReferenceList.Async(request, callSettings);
        }

        /// <summary>
        /// Lists a collection of reference lists.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ReferenceList"/> resources.</returns>
        public override gax::PagedEnumerable<ListReferenceListsResponse, ReferenceList> ListReferenceLists(ListReferenceListsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReferenceListsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListReferenceListsRequest, ListReferenceListsResponse, ReferenceList>(_callListReferenceLists, request, callSettings);
        }

        /// <summary>
        /// Lists a collection of reference lists.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ReferenceList"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListReferenceListsResponse, ReferenceList> ListReferenceListsAsync(ListReferenceListsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReferenceListsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListReferenceListsRequest, ListReferenceListsResponse, ReferenceList>(_callListReferenceLists, request, callSettings);
        }

        /// <summary>
        /// Creates a new reference list.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ReferenceList CreateReferenceList(CreateReferenceListRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateReferenceListRequest(ref request, ref callSettings);
            return _callCreateReferenceList.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new reference list.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ReferenceList> CreateReferenceListAsync(CreateReferenceListRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateReferenceListRequest(ref request, ref callSettings);
            return _callCreateReferenceList.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an existing reference list.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ReferenceList UpdateReferenceList(UpdateReferenceListRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateReferenceListRequest(ref request, ref callSettings);
            return _callUpdateReferenceList.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an existing reference list.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ReferenceList> UpdateReferenceListAsync(UpdateReferenceListRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateReferenceListRequest(ref request, ref callSettings);
            return _callUpdateReferenceList.Async(request, callSettings);
        }
    }

    public partial class ListReferenceListsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListReferenceListsResponse : gaxgrpc::IPageResponse<ReferenceList>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ReferenceList> GetEnumerator() => ReferenceLists.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
