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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using lro = Google.LongRunning;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Ids.V1
{
    /// <summary>Settings for <see cref="IDSClient"/> instances.</summary>
    public sealed partial class IDSSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="IDSSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="IDSSettings"/>.</returns>
        public static IDSSettings GetDefault() => new IDSSettings();

        /// <summary>Constructs a new <see cref="IDSSettings"/> object with default settings.</summary>
        public IDSSettings()
        {
        }

        private IDSSettings(IDSSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListEndpointsSettings = existing.ListEndpointsSettings;
            GetEndpointSettings = existing.GetEndpointSettings;
            CreateEndpointSettings = existing.CreateEndpointSettings;
            CreateEndpointOperationsSettings = existing.CreateEndpointOperationsSettings.Clone();
            DeleteEndpointSettings = existing.DeleteEndpointSettings;
            DeleteEndpointOperationsSettings = existing.DeleteEndpointOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(IDSSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>IDSClient.ListEndpoints</c>
        /// and <c>IDSClient.ListEndpointsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 250 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListEndpointsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(250), maxBackoff: sys::TimeSpan.FromMilliseconds(32000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>IDSClient.GetEndpoint</c>
        /// and <c>IDSClient.GetEndpointAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 250 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetEndpointSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(250), maxBackoff: sys::TimeSpan.FromMilliseconds(32000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>IDSClient.CreateEndpoint</c>
        ///  and <c>IDSClient.CreateEndpointAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 3600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateEndpointSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>IDSClient.CreateEndpoint</c> and
        /// <c>IDSClient.CreateEndpointAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings CreateEndpointOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>IDSClient.DeleteEndpoint</c>
        ///  and <c>IDSClient.DeleteEndpointAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 3600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteEndpointSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>IDSClient.DeleteEndpoint</c> and
        /// <c>IDSClient.DeleteEndpointAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings DeleteEndpointOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="IDSSettings"/> object.</returns>
        public IDSSettings Clone() => new IDSSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="IDSClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class IDSClientBuilder : gaxgrpc::ClientBuilderBase<IDSClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public IDSSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public IDSClientBuilder() : base(IDSClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref IDSClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<IDSClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override IDSClient Build()
        {
            IDSClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<IDSClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<IDSClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private IDSClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return IDSClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<IDSClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return IDSClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => IDSClient.ChannelPool;
    }

    /// <summary>IDS client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The IDS Service
    /// </remarks>
    public abstract partial class IDSClient
    {
        /// <summary>
        /// The default endpoint for the IDS service, which is a host of "ids.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "ids.googleapis.com:443";

        /// <summary>The default IDS scopes.</summary>
        /// <remarks>
        /// The default IDS scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(IDS.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="IDSClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="IDSClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="IDSClient"/>.</returns>
        public static stt::Task<IDSClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new IDSClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="IDSClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="IDSClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="IDSClient"/>.</returns>
        public static IDSClient Create() => new IDSClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="IDSClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="IDSSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="IDSClient"/>.</returns>
        internal static IDSClient Create(grpccore::CallInvoker callInvoker, IDSSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            IDS.IDSClient grpcClient = new IDS.IDSClient(callInvoker);
            return new IDSClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC IDS client</summary>
        public virtual IDS.IDSClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Endpoints in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Endpoint"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEndpointsResponse, Endpoint> ListEndpoints(ListEndpointsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Endpoints in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Endpoint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEndpointsResponse, Endpoint> ListEndpointsAsync(ListEndpointsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Endpoints in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of endpoints.
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
        /// <returns>A pageable sequence of <see cref="Endpoint"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEndpointsResponse, Endpoint> ListEndpoints(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEndpointsRequest request = new ListEndpointsRequest
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
            return ListEndpoints(request, callSettings);
        }

        /// <summary>
        /// Lists Endpoints in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of endpoints.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Endpoint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEndpointsResponse, Endpoint> ListEndpointsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEndpointsRequest request = new ListEndpointsRequest
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
            return ListEndpointsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Endpoints in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of endpoints.
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
        /// <returns>A pageable sequence of <see cref="Endpoint"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEndpointsResponse, Endpoint> ListEndpoints(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEndpointsRequest request = new ListEndpointsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEndpoints(request, callSettings);
        }

        /// <summary>
        /// Lists Endpoints in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of endpoints.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Endpoint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEndpointsResponse, Endpoint> ListEndpointsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEndpointsRequest request = new ListEndpointsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEndpointsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Endpoint GetEndpoint(GetEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Endpoint> GetEndpointAsync(GetEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Endpoint> GetEndpointAsync(GetEndpointRequest request, st::CancellationToken cancellationToken) =>
            GetEndpointAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the endpoint to retrieve.
        /// Format: `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Endpoint GetEndpoint(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEndpoint(new GetEndpointRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the endpoint to retrieve.
        /// Format: `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Endpoint> GetEndpointAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEndpointAsync(new GetEndpointRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the endpoint to retrieve.
        /// Format: `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Endpoint> GetEndpointAsync(string name, st::CancellationToken cancellationToken) =>
            GetEndpointAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the endpoint to retrieve.
        /// Format: `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Endpoint GetEndpoint(EndpointName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEndpoint(new GetEndpointRequest
            {
                EndpointName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the endpoint to retrieve.
        /// Format: `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Endpoint> GetEndpointAsync(EndpointName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEndpointAsync(new GetEndpointRequest
            {
                EndpointName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the endpoint to retrieve.
        /// Format: `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Endpoint> GetEndpointAsync(EndpointName name, st::CancellationToken cancellationToken) =>
            GetEndpointAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Endpoint in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Endpoint, OperationMetadata> CreateEndpoint(CreateEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Endpoint in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Endpoint, OperationMetadata>> CreateEndpointAsync(CreateEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Endpoint in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Endpoint, OperationMetadata>> CreateEndpointAsync(CreateEndpointRequest request, st::CancellationToken cancellationToken) =>
            CreateEndpointAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateEndpoint</c>.</summary>
        public virtual lro::OperationsClient CreateEndpointOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateEndpoint</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Endpoint, OperationMetadata> PollOnceCreateEndpoint(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Endpoint, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateEndpointOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateEndpoint</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Endpoint, OperationMetadata>> PollOnceCreateEndpointAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Endpoint, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateEndpointOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Endpoint in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The endpoint's parent.
        /// </param>
        /// <param name="endpoint">
        /// Required. The endpoint to create.
        /// </param>
        /// <param name="endpointId">
        /// Required. The endpoint identifier. This will be part of the endpoint's
        /// resource name.
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, or hyphens, and cannot end with a hyphen.
        /// Values that do not match this pattern will trigger an INVALID_ARGUMENT
        /// error.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Endpoint, OperationMetadata> CreateEndpoint(string parent, Endpoint endpoint, string endpointId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEndpoint(new CreateEndpointRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EndpointId = gax::GaxPreconditions.CheckNotNullOrEmpty(endpointId, nameof(endpointId)),
                Endpoint = gax::GaxPreconditions.CheckNotNull(endpoint, nameof(endpoint)),
            }, callSettings);

        /// <summary>
        /// Creates a new Endpoint in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The endpoint's parent.
        /// </param>
        /// <param name="endpoint">
        /// Required. The endpoint to create.
        /// </param>
        /// <param name="endpointId">
        /// Required. The endpoint identifier. This will be part of the endpoint's
        /// resource name.
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, or hyphens, and cannot end with a hyphen.
        /// Values that do not match this pattern will trigger an INVALID_ARGUMENT
        /// error.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Endpoint, OperationMetadata>> CreateEndpointAsync(string parent, Endpoint endpoint, string endpointId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEndpointAsync(new CreateEndpointRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EndpointId = gax::GaxPreconditions.CheckNotNullOrEmpty(endpointId, nameof(endpointId)),
                Endpoint = gax::GaxPreconditions.CheckNotNull(endpoint, nameof(endpoint)),
            }, callSettings);

        /// <summary>
        /// Creates a new Endpoint in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The endpoint's parent.
        /// </param>
        /// <param name="endpoint">
        /// Required. The endpoint to create.
        /// </param>
        /// <param name="endpointId">
        /// Required. The endpoint identifier. This will be part of the endpoint's
        /// resource name.
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, or hyphens, and cannot end with a hyphen.
        /// Values that do not match this pattern will trigger an INVALID_ARGUMENT
        /// error.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Endpoint, OperationMetadata>> CreateEndpointAsync(string parent, Endpoint endpoint, string endpointId, st::CancellationToken cancellationToken) =>
            CreateEndpointAsync(parent, endpoint, endpointId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Endpoint in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The endpoint's parent.
        /// </param>
        /// <param name="endpoint">
        /// Required. The endpoint to create.
        /// </param>
        /// <param name="endpointId">
        /// Required. The endpoint identifier. This will be part of the endpoint's
        /// resource name.
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, or hyphens, and cannot end with a hyphen.
        /// Values that do not match this pattern will trigger an INVALID_ARGUMENT
        /// error.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Endpoint, OperationMetadata> CreateEndpoint(gagr::LocationName parent, Endpoint endpoint, string endpointId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEndpoint(new CreateEndpointRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EndpointId = gax::GaxPreconditions.CheckNotNullOrEmpty(endpointId, nameof(endpointId)),
                Endpoint = gax::GaxPreconditions.CheckNotNull(endpoint, nameof(endpoint)),
            }, callSettings);

        /// <summary>
        /// Creates a new Endpoint in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The endpoint's parent.
        /// </param>
        /// <param name="endpoint">
        /// Required. The endpoint to create.
        /// </param>
        /// <param name="endpointId">
        /// Required. The endpoint identifier. This will be part of the endpoint's
        /// resource name.
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, or hyphens, and cannot end with a hyphen.
        /// Values that do not match this pattern will trigger an INVALID_ARGUMENT
        /// error.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Endpoint, OperationMetadata>> CreateEndpointAsync(gagr::LocationName parent, Endpoint endpoint, string endpointId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEndpointAsync(new CreateEndpointRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EndpointId = gax::GaxPreconditions.CheckNotNullOrEmpty(endpointId, nameof(endpointId)),
                Endpoint = gax::GaxPreconditions.CheckNotNull(endpoint, nameof(endpoint)),
            }, callSettings);

        /// <summary>
        /// Creates a new Endpoint in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The endpoint's parent.
        /// </param>
        /// <param name="endpoint">
        /// Required. The endpoint to create.
        /// </param>
        /// <param name="endpointId">
        /// Required. The endpoint identifier. This will be part of the endpoint's
        /// resource name.
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, or hyphens, and cannot end with a hyphen.
        /// Values that do not match this pattern will trigger an INVALID_ARGUMENT
        /// error.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Endpoint, OperationMetadata>> CreateEndpointAsync(gagr::LocationName parent, Endpoint endpoint, string endpointId, st::CancellationToken cancellationToken) =>
            CreateEndpointAsync(parent, endpoint, endpointId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteEndpoint(DeleteEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEndpointAsync(DeleteEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEndpointAsync(DeleteEndpointRequest request, st::CancellationToken cancellationToken) =>
            DeleteEndpointAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteEndpoint</c>.</summary>
        public virtual lro::OperationsClient DeleteEndpointOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteEndpoint</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteEndpoint(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteEndpointOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteEndpoint</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteEndpointAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteEndpointOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the endpoint to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteEndpoint(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEndpoint(new DeleteEndpointRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the endpoint to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEndpointAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEndpointAsync(new DeleteEndpointRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the endpoint to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEndpointAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteEndpointAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the endpoint to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteEndpoint(EndpointName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEndpoint(new DeleteEndpointRequest
            {
                EndpointName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the endpoint to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEndpointAsync(EndpointName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEndpointAsync(new DeleteEndpointRequest
            {
                EndpointName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the endpoint to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEndpointAsync(EndpointName name, st::CancellationToken cancellationToken) =>
            DeleteEndpointAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>IDS client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The IDS Service
    /// </remarks>
    public sealed partial class IDSClientImpl : IDSClient
    {
        private readonly gaxgrpc::ApiCall<ListEndpointsRequest, ListEndpointsResponse> _callListEndpoints;

        private readonly gaxgrpc::ApiCall<GetEndpointRequest, Endpoint> _callGetEndpoint;

        private readonly gaxgrpc::ApiCall<CreateEndpointRequest, lro::Operation> _callCreateEndpoint;

        private readonly gaxgrpc::ApiCall<DeleteEndpointRequest, lro::Operation> _callDeleteEndpoint;

        /// <summary>
        /// Constructs a client wrapper for the IDS service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="IDSSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public IDSClientImpl(IDS.IDSClient grpcClient, IDSSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            IDSSettings effectiveSettings = settings ?? IDSSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateEndpointOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateEndpointOperationsSettings, logger);
            DeleteEndpointOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteEndpointOperationsSettings, logger);
            _callListEndpoints = clientHelper.BuildApiCall<ListEndpointsRequest, ListEndpointsResponse>("ListEndpoints", grpcClient.ListEndpointsAsync, grpcClient.ListEndpoints, effectiveSettings.ListEndpointsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEndpoints);
            Modify_ListEndpointsApiCall(ref _callListEndpoints);
            _callGetEndpoint = clientHelper.BuildApiCall<GetEndpointRequest, Endpoint>("GetEndpoint", grpcClient.GetEndpointAsync, grpcClient.GetEndpoint, effectiveSettings.GetEndpointSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEndpoint);
            Modify_GetEndpointApiCall(ref _callGetEndpoint);
            _callCreateEndpoint = clientHelper.BuildApiCall<CreateEndpointRequest, lro::Operation>("CreateEndpoint", grpcClient.CreateEndpointAsync, grpcClient.CreateEndpoint, effectiveSettings.CreateEndpointSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateEndpoint);
            Modify_CreateEndpointApiCall(ref _callCreateEndpoint);
            _callDeleteEndpoint = clientHelper.BuildApiCall<DeleteEndpointRequest, lro::Operation>("DeleteEndpoint", grpcClient.DeleteEndpointAsync, grpcClient.DeleteEndpoint, effectiveSettings.DeleteEndpointSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteEndpoint);
            Modify_DeleteEndpointApiCall(ref _callDeleteEndpoint);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListEndpointsApiCall(ref gaxgrpc::ApiCall<ListEndpointsRequest, ListEndpointsResponse> call);

        partial void Modify_GetEndpointApiCall(ref gaxgrpc::ApiCall<GetEndpointRequest, Endpoint> call);

        partial void Modify_CreateEndpointApiCall(ref gaxgrpc::ApiCall<CreateEndpointRequest, lro::Operation> call);

        partial void Modify_DeleteEndpointApiCall(ref gaxgrpc::ApiCall<DeleteEndpointRequest, lro::Operation> call);

        partial void OnConstruction(IDS.IDSClient grpcClient, IDSSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC IDS client</summary>
        public override IDS.IDSClient GrpcClient { get; }

        partial void Modify_ListEndpointsRequest(ref ListEndpointsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetEndpointRequest(ref GetEndpointRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateEndpointRequest(ref CreateEndpointRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteEndpointRequest(ref DeleteEndpointRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists Endpoints in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Endpoint"/> resources.</returns>
        public override gax::PagedEnumerable<ListEndpointsResponse, Endpoint> ListEndpoints(ListEndpointsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEndpointsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEndpointsRequest, ListEndpointsResponse, Endpoint>(_callListEndpoints, request, callSettings);
        }

        /// <summary>
        /// Lists Endpoints in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Endpoint"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListEndpointsResponse, Endpoint> ListEndpointsAsync(ListEndpointsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEndpointsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEndpointsRequest, ListEndpointsResponse, Endpoint>(_callListEndpoints, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Endpoint GetEndpoint(GetEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEndpointRequest(ref request, ref callSettings);
            return _callGetEndpoint.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Endpoint> GetEndpointAsync(GetEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEndpointRequest(ref request, ref callSettings);
            return _callGetEndpoint.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateEndpoint</c>.</summary>
        public override lro::OperationsClient CreateEndpointOperationsClient { get; }

        /// <summary>
        /// Creates a new Endpoint in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Endpoint, OperationMetadata> CreateEndpoint(CreateEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEndpointRequest(ref request, ref callSettings);
            return new lro::Operation<Endpoint, OperationMetadata>(_callCreateEndpoint.Sync(request, callSettings), CreateEndpointOperationsClient);
        }

        /// <summary>
        /// Creates a new Endpoint in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Endpoint, OperationMetadata>> CreateEndpointAsync(CreateEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEndpointRequest(ref request, ref callSettings);
            return new lro::Operation<Endpoint, OperationMetadata>(await _callCreateEndpoint.Async(request, callSettings).ConfigureAwait(false), CreateEndpointOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteEndpoint</c>.</summary>
        public override lro::OperationsClient DeleteEndpointOperationsClient { get; }

        /// <summary>
        /// Deletes a single Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteEndpoint(DeleteEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEndpointRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteEndpoint.Sync(request, callSettings), DeleteEndpointOperationsClient);
        }

        /// <summary>
        /// Deletes a single Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEndpointAsync(DeleteEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEndpointRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteEndpoint.Async(request, callSettings).ConfigureAwait(false), DeleteEndpointOperationsClient);
        }
    }

    public partial class ListEndpointsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEndpointsResponse : gaxgrpc::IPageResponse<Endpoint>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Endpoint> GetEnumerator() => Endpoints.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class IDS
    {
        public partial class IDSClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() =>
                new lro::Operations.OperationsClient(CallInvoker);
        }
    }
}
